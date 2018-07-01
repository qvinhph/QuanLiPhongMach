Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Public Class frmTraCuuBenhNhan

    Private bnbus As BenhNhanBUS
    Private loaiBenhBUS As LoaiBenhBUS
    Private phieuKhamBUS As PhieuKhamBUS


    Private Sub frmTraCuuBenhNhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bnbus = New BenhNhanBUS()
        loaiBenhBUS = New LoaiBenhBUS()
        phieuKhamBUS = New PhieuKhamBUS()

#Region "Get data into combobox LoaiBenh"

        ' Load LoaiBenh list
        Dim listLoaiBenh = New List(Of LoaiBenhDTO)
        Dim result As Result
        result = loaiBenhBUS.SelectAll(listLoaiBenh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại bệnh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbLoaiBenh.DataSource = New BindingSource(listLoaiBenh, String.Empty)
        'cbLoaiBenh.ValueMember = "ma_loai_benh"
        'cbLoaiBenh.ValueMember = "loai_benh"
        cbLoaiBenh.DisplayMember = "LoaiBenh"
        cbLoaiBenh.ValueMember = "MaLoaiBenh"
#End Region
#Region "Load datagridview List Benh Nhan"
        loadlistBenhNhan()
    End Sub
#Region "Load list Benh Nhan default"
    Private Sub loadlistBenhNhan()
        Dim listBenhNhan = New List(Of BenhNhanDTO)

        Dim result As Result
        result = bnbus.SelectAll(listBenhNhan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If


        dgvListBenhNhan.Columns.Clear()
        dgvListBenhNhan.DataSource = Nothing

        dgvListBenhNhan.AutoGenerateColumns = False
        dgvListBenhNhan.AllowUserToAddRows = False
        dgvListBenhNhan.DataSource = listBenhNhan


        Dim clmBn = New DataGridViewTextBoxColumn()
        clmBn.Name = "MaBenhNhan"
        clmBn.HeaderText = "Mã số bệnh nhân"
        clmBn.DataPropertyName = "MaBenhNhan"
        dgvListBenhNhan.Columns.Add(clmBn)

        Dim clmHoTen = New DataGridViewTextBoxColumn()
        clmHoTen.Name = "HoTen"
        clmHoTen.HeaderText = "Họ và tên"
        clmHoTen.DataPropertyName = "HoTen"
        dgvListBenhNhan.Columns.Add(clmHoTen)

        Dim clmDiaChi = New DataGridViewTextBoxColumn()
        clmDiaChi.Name = "DiaChi"
        clmDiaChi.HeaderText = "Địa Chỉ"
        clmDiaChi.DataPropertyName = "DiaChi"
        dgvListBenhNhan.Columns.Add(clmDiaChi)

        Dim clmNamSinh = New DataGridViewTextBoxColumn()
        clmNamSinh.Name = "NgaySinh"
        clmNamSinh.HeaderText = "Năm Sinh"
        clmNamSinh.DataPropertyName = "NgaySinh"
        dgvListBenhNhan.Columns.Add(clmNamSinh)

        Dim clmGioiTinh = New DataGridViewTextBoxColumn()
        clmGioiTinh.Name = "GioiTinh"
        clmGioiTinh.HeaderText = "Giới Tính"
        clmGioiTinh.DataPropertyName = "GioiTinh"
        dgvListBenhNhan.Columns.Add(clmGioiTinh)

        'Dim clmTrieuChung = New DataGridViewTextBoxColumn()
        'clmTrieuChung.Name = "TrieuChung"
        'clmTrieuChung.HeaderText = "Triệu Chứng"
        'clmTrieuChung.DataPropertyName = "TrieuChung"
        'dgvListBenhNhan.Columns.Add(clmTrieuChung)




    End Sub
#End Region

#Region "Load list Benh Nhan by Ma Loai Benh"
    Private Sub loadListBenhNhan(maloaibenh As String)
        Dim listBenhNhan = New List(Of BenhNhanDTO)
        Dim result As Result
        result = bnbus.SelectAll_ByLoaiBenh(maloaibenh, listBenhNhan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListBenhNhan.Columns.Clear()
        dgvListBenhNhan.DataSource = Nothing

        dgvListBenhNhan.AutoGenerateColumns = False
        dgvListBenhNhan.AllowUserToAddRows = False
        dgvListBenhNhan.DataSource = listBenhNhan
        'dgvListBenhNhan.DataSource = listPhieuKham


        Dim clmBn = New DataGridViewTextBoxColumn()
        clmBn.Name = "MaBenhNhan"
        clmBn.HeaderText = "Mã số bệnh nhân"
        clmBn.DataPropertyName = "MaBenhNhan"
        dgvListBenhNhan.Columns.Add(clmBn)

        Dim clmHoTen = New DataGridViewTextBoxColumn()
        clmHoTen.Name = "HoTen"
        clmHoTen.HeaderText = "Họ và tên"
        clmHoTen.DataPropertyName = "HoTen"
        dgvListBenhNhan.Columns.Add(clmHoTen)

        Dim clmDiaChi = New DataGridViewTextBoxColumn()
        clmDiaChi.Name = "DiaChi"
        clmDiaChi.HeaderText = "Địa Chỉ"
        clmDiaChi.DataPropertyName = "DiaChi"
        dgvListBenhNhan.Columns.Add(clmDiaChi)

        Dim clmNamSinh = New DataGridViewTextBoxColumn()
        clmNamSinh.Name = "NgaySinh"
        clmNamSinh.HeaderText = "Năm Sinh"
        clmNamSinh.DataPropertyName = "NgaySinh"
        dgvListBenhNhan.Columns.Add(clmNamSinh)

        Dim clmGioiTinh = New DataGridViewTextBoxColumn()
        clmGioiTinh.Name = "GioiTinh"
        clmGioiTinh.HeaderText = "Giới Tính"
        clmGioiTinh.DataPropertyName = "GioiTinh"
        dgvListBenhNhan.Columns.Add(clmGioiTinh)

        'Dim clmTrieuChung = New DataGridViewTextBoxColumn()
        'clmTrieuChung.Name = "TrieuChung"
        'clmTrieuChung.HeaderText = "Triệu Chứng"
        'clmTrieuChung.DataPropertyName = "TrieuChung"
        'dgvListBenhNhan.Columns.Add(clmTrieuChung)
    End Sub
#End Region

#Region "Load list benh nhan by ngay kham"
    Private Sub loadListBenhNhan(ngayKham As Date)
        Dim listBenhNhan = New List(Of BenhNhanDTO)
        Dim result As Result
        result = bnbus.SelectAll_ByNgayKham(ngayKham, listBenhNhan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListBenhNhan.Columns.Clear()
        dgvListBenhNhan.DataSource = Nothing

        dgvListBenhNhan.AutoGenerateColumns = False
        dgvListBenhNhan.AllowUserToAddRows = False
        dgvListBenhNhan.DataSource = listBenhNhan
        'dgvListBenhNhan.DataSource = listPhieuKham


        Dim clmBn = New DataGridViewTextBoxColumn()
        clmBn.Name = "MaBenhNhan"
        clmBn.HeaderText = "Mã số bệnh nhân"
        clmBn.DataPropertyName = "MaBenhNhan"
        dgvListBenhNhan.Columns.Add(clmBn)

        Dim clmHoTen = New DataGridViewTextBoxColumn()
        clmHoTen.Name = "HoTen"
        clmHoTen.HeaderText = "Họ và tên"
        clmHoTen.DataPropertyName = "HoTen"
        dgvListBenhNhan.Columns.Add(clmHoTen)

        Dim clmDiaChi = New DataGridViewTextBoxColumn()
        clmDiaChi.Name = "DiaChi"
        clmDiaChi.HeaderText = "Địa Chỉ"
        clmDiaChi.DataPropertyName = "DiaChi"
        dgvListBenhNhan.Columns.Add(clmDiaChi)

        Dim clmNamSinh = New DataGridViewTextBoxColumn()
        clmNamSinh.Name = "NgaySinh"
        clmNamSinh.HeaderText = "Năm Sinh"
        clmNamSinh.DataPropertyName = "NgaySinh"
        dgvListBenhNhan.Columns.Add(clmNamSinh)

        Dim clmGioiTinh = New DataGridViewTextBoxColumn()
        clmGioiTinh.Name = "GioiTinh"
        clmGioiTinh.HeaderText = "Giới Tính"
        clmGioiTinh.DataPropertyName = "GioiTinh"
        dgvListBenhNhan.Columns.Add(clmGioiTinh)

        'Dim clmTrieuChung = New DataGridViewTextBoxColumn()
        'clmTrieuChung.Name = "TrieuChung"
        'clmTrieuChung.HeaderText = "Triệu Chứng"
        'clmTrieuChung.DataPropertyName = "TrieuChung"
        'dgvListBenhNhan.Columns.Add(clmTrieuChung)
    End Sub
#End Region

#Region "Load list benh nhan by name"
    Private Sub loadListBenhNhan_ByName(hoTen As String)

        Dim listBenhNhan = New List(Of BenhNhanDTO)
        Dim result As Result
        result = bnbus.SelectAll_ByName(hoTen, listBenhNhan)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListBenhNhan.Columns.Clear()
        dgvListBenhNhan.DataSource = Nothing

        dgvListBenhNhan.AutoGenerateColumns = False
        dgvListBenhNhan.AllowUserToAddRows = False
        dgvListBenhNhan.DataSource = listBenhNhan
        'dgvListBenhNhan.DataSource = listPhieuKham


        Dim clmBn = New DataGridViewTextBoxColumn()
        clmBn.Name = "MaBenhNhan"
        clmBn.HeaderText = "Mã số bệnh nhân"
        clmBn.DataPropertyName = "MaBenhNhan"
        dgvListBenhNhan.Columns.Add(clmBn)

        Dim clmHoTen = New DataGridViewTextBoxColumn()
        clmHoTen.Name = "HoTen"
        clmHoTen.HeaderText = "Họ và tên"
        clmHoTen.DataPropertyName = "HoTen"
        dgvListBenhNhan.Columns.Add(clmHoTen)

        Dim clmDiaChi = New DataGridViewTextBoxColumn()
        clmDiaChi.Name = "DiaChi"
        clmDiaChi.HeaderText = "Địa Chỉ"
        clmDiaChi.DataPropertyName = "DiaChi"
        dgvListBenhNhan.Columns.Add(clmDiaChi)

        Dim clmNamSinh = New DataGridViewTextBoxColumn()
        clmNamSinh.Name = "NgaySinh"
        clmNamSinh.HeaderText = "Năm Sinh"
        clmNamSinh.DataPropertyName = "NgaySinh"
        dgvListBenhNhan.Columns.Add(clmNamSinh)

        Dim clmGioiTinh = New DataGridViewTextBoxColumn()
        clmGioiTinh.Name = "GioiTinh"
        clmGioiTinh.HeaderText = "Giới Tính"
        clmGioiTinh.DataPropertyName = "GioiTinh"
        dgvListBenhNhan.Columns.Add(clmGioiTinh)

        'Dim clmTrieuChung = New DataGridViewTextBoxColumn()
        'clmTrieuChung.Name = "TrieuChung"
        'clmTrieuChung.HeaderText = "Triệu Chứng"
        'clmTrieuChung.DataPropertyName = "TrieuChung"
        'dgvListBenhNhan.Columns.Add(clmTrieuChung)
    End Sub
#End Region

#Region "Load list benh nhan by ID"
    Private Sub loadListBenhNhan_ByID(maSo As String)

        Dim listBenhNhan = New List(Of BenhNhanDTO)
        Dim result As Result
        result = bnbus.SelectAll_ByID(maSo, listBenhNhan)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListBenhNhan.Columns.Clear()
        dgvListBenhNhan.DataSource = Nothing

        dgvListBenhNhan.AutoGenerateColumns = False
        dgvListBenhNhan.AllowUserToAddRows = False
        dgvListBenhNhan.DataSource = listBenhNhan
        'dgvListBenhNhan.DataSource = listPhieuKham


        Dim clmBn = New DataGridViewTextBoxColumn()
        clmBn.Name = "MaBenhNhan"
        clmBn.HeaderText = "Mã số bệnh nhân"
        clmBn.DataPropertyName = "MaBenhNhan"
        dgvListBenhNhan.Columns.Add(clmBn)

        Dim clmHoTen = New DataGridViewTextBoxColumn()
        clmHoTen.Name = "HoTen"
        clmHoTen.HeaderText = "Họ và tên"
        clmHoTen.DataPropertyName = "HoTen"
        dgvListBenhNhan.Columns.Add(clmHoTen)

        Dim clmDiaChi = New DataGridViewTextBoxColumn()
        clmDiaChi.Name = "DiaChi"
        clmDiaChi.HeaderText = "Địa Chỉ"
        clmDiaChi.DataPropertyName = "DiaChi"
        dgvListBenhNhan.Columns.Add(clmDiaChi)

        Dim clmNamSinh = New DataGridViewTextBoxColumn()
        clmNamSinh.Name = "NgaySinh"
        clmNamSinh.HeaderText = "Năm Sinh"
        clmNamSinh.DataPropertyName = "NgaySinh"
        dgvListBenhNhan.Columns.Add(clmNamSinh)

        Dim clmGioiTinh = New DataGridViewTextBoxColumn()
        clmGioiTinh.Name = "GioiTinh"
        clmGioiTinh.HeaderText = "Giới Tính"
        clmGioiTinh.DataPropertyName = "GioiTinh"
        dgvListBenhNhan.Columns.Add(clmGioiTinh)

        'Dim clmTrieuChung = New DataGridViewTextBoxColumn()
        'clmTrieuChung.Name = "TrieuChung"
        'clmTrieuChung.HeaderText = "Triệu Chứng"
        'clmTrieuChung.DataPropertyName = "TrieuChung"
        'dgvListBenhNhan.Columns.Add(clmTrieuChung)
    End Sub
#End Region
#End Region

    Private Sub cbLoaiBenh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLoaiBenh.SelectedIndexChanged
        Try
            Dim maLoaiBenh As String
            maLoaiBenh = Convert.ToString(cbLoaiBenh.SelectedValue)

            loadListBenhNhan(maLoaiBenh)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub


    Private Sub dtpNgayKham_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayKham.ValueChanged
        txtHoTen.Text = Nothing
        txtMaSo.Text = Nothing

        Try
            Dim NgayKham = Convert.ToDateTime(dtpNgayKham.Value)

            loadListBenhNhan(NgayKham)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtHoTen_TextChanged(sender As Object, e As EventArgs) Handles txtHoTen.TextChanged
        txtMaSo.Text = Nothing
        Try
            Dim HoTen = txtHoTen.Text

            loadListBenhNhan_ByName(HoTen)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click
        txtHoTen.Text = Nothing
        txtMaSo.Text = Nothing
        loadlistBenhNhan()
    End Sub

    Private Sub txtMaSo_TextChanged(sender As Object, e As EventArgs) Handles txtMaSo.TextChanged
        txtHoTen.Text = Nothing
        Try
            Dim MaSo = txtMaSo.Text

            loadListBenhNhan_ByID(MaSo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class