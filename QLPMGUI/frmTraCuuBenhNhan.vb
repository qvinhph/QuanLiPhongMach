Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Public Class frmTraCuuBenhNhan
    Private bnbus As BenhNhanBUS
    Private loaiBenhBUS As LoaiBenhBUS
    Private chiTietDanhSachBUS As ChiTietDanhSachBUS
    Private phieuKhamBUS As PhieuKhamBUS
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click

    End Sub

    Private Sub frmTraCuuBenhNhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bnbus = New BenhNhanBUS()
        loaiBenhBUS = New LoaiBenhBUS()
        phieuKhamBUS = New PhieuKhamBUS()
        'chiTietDanhSachBUS = New ChiTietDanhSachBUS()


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

        loadlistBenhNhan()
    End Sub
    Private Sub loadlistBenhNhan()
        Dim listBenhNhan = New List(Of BenhNhanDTO)

        Dim result As Result
        result = bnbus.SelectAll(listBenhNhan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'Dim listPhieuKham = New List(Of PhieuKhamDTO)
        'Dim result1 As Result
        'result1 = phieuKhamBUS.SelectAll(listPhieuKham)
        'If (result1.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách triệu chứng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result1.SystemMessage)
        '    Return
        'End If
        'Dim listChiTietDS = New List(Of ChiTietDanhSachDTO)
        'chiTietDanhSachBUS.SelectAll(listChiTietDS)


        'Dim thongTinBenhNhan = (From lbn In listBenhNhan
        '                        From lpk In listPhieuKham
        '                        From lctd In listChiTietDS
        '                        Where lbn.MaBenhNhan = lctd.MaBenhNhan And lpk.MaChiTietDanhSach = lctd.MaChiTietDanhSach
        '                        Select New BenhNhanDTO With
        '                            {
        '                                .MaBenhNhan = lbn.MaBenhNhan,
        '                                .HoTen = lbn.HoTen,
        '                                .DiaChi = lbn.DiaChi,
        '                                .GioiTinh = lbn.GioiTinh,
        '                                .NgaySinh = lbn.NgaySinh
        '                            }).ToList()

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

    Private Sub cbLoaiBenh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLoaiBenh.SelectedIndexChanged
        Try
            Dim maLoaiBenh As String
            maLoaiBenh = cbLoaiBenh.SelectedValue.ToString()

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
End Class