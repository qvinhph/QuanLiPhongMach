Imports QLPMBUS
Imports QLPMDTO
Imports Utility

Public Class frmPhieuKhamBenh

    Private loaiBenhBUS As LoaiBenhBUS
    Private danhSachKhamBUS As DanhSachKhamBUS
    Private chiTietDanhSachBUS As ChiTietDanhSachBUS

    Private Sub frmPhieuKhamBenh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaiBenhBUS = New LoaiBenhBUS()
        danhSachKhamBUS = New DanhSachKhamBUS()
        chiTietDanhSachBUS = New ChiTietDanhSachBUS()

        'Load list of LoaiBenh to combobox
        Dim listLoaiBenh = New List(Of LoaiBenhDTO)
        Dim result As Result
        result = loaiBenhBUS.SelectAll(listLoaiBenh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại bệnh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbLoaiBenh.DataSource = New BindingSource(listLoaiBenh, String.Empty)
        cbLoaiBenh.DisplayMember = "LoaiBenh"
        cbLoaiBenh.ValueMember = "MaLoaiBenh"

        'Load list of BenhNhan in the day to combobox
        ''Get MaDanhSach of the current day
        Dim currentDay = dtpNgayKham.Value
        Dim listDanhSachKham = New List(Of DanhSachKhamDTO)
        danhSachKhamBUS.SelectAll(listDanhSachKham)
        Dim currentMaDanhSach = (From danhSach In listDanhSachKham
                                 Where danhSach.NgayKham = currentDay
                                 Select danhSach.NgayKham).First()

        ''Get list of BenhNhan in the day
        Dim listChiTietDanhSach = New List(Of ChiTietDanhSachDTO)
        chiTietDanhSachBUS.SelectAll_MaDanhSach(currentMaDanhSach, listChiTietDanhSach)
        Dim allBenhNhan = New List(Of BenhnhanDTO)
        'benhnh



    End Sub

End Class