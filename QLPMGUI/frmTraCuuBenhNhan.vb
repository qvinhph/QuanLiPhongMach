Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Public Class frmTraCuuBenhNhan
    Private bnbus As BenhNhanBUS
    Private loaiBenhBUS As LoaiBenhBUS
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click

    End Sub

    Private Sub frmTraCuuBenhNhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bnbus = New BenhNhanBUS()
        loaiBenhBUS = New LoaiBenhBUS()

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

        Dim clmTrieuChung = New DataGridViewTextBoxColumn()
        clmTrieuChung.Name = "TrieuChung"
        clmTrieuChung.HeaderText = "Triệu Chứng"
        clmTrieuChung.DataPropertyName = "TrieuChung"
        dgvListBenhNhan.Columns.Add(clmTrieuChung)




    End Sub

    Private Sub cbLoaiBenh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLoaiBenh.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class