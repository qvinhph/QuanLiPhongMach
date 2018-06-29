Imports QLPMBUS
Imports QLPMDTO
Imports Utility

Public Class frmPhieuKhamBenh

    Private loaiBenhBUS As LoaiBenhBUS
    Private danhSachKhamBUS As DanhSachKhamBUS
    Private chiTietDanhSachBUS As ChiTietDanhSachBUS
    Private benhNhanBUS As BenhNhanBUS


    Private Sub frmPhieuKhamBenh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaiBenhBUS = New LoaiBenhBUS()
        danhSachKhamBUS = New DanhSachKhamBUS()
        chiTietDanhSachBUS = New ChiTietDanhSachBUS()
        benhNhanBUS = New BenhNhanBUS()

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
        Dim currentDay = dtpNgayKham.Value.ToString("d")

        Dim listDanhSachKham = New List(Of DanhSachKhamDTO)
        danhSachKhamBUS.SelectAll(listDanhSachKham)

        Dim currentMaDanhSach = String.Empty
        If (listDanhSachKham.Count > 0) Then
            currentMaDanhSach = (From danhSach In listDanhSachKham
                                 Where danhSach.NgayKham.ToString("d") = currentDay
                                 Select danhSach.MaDanhSach).First()
        End If


        ''Get list of BenhNhan in the day
        Dim listChiTietDanhSach = New List(Of ChiTietDanhSachDTO) 'Contains all the ChiTietDanhSachDTO in the day
        chiTietDanhSachBUS.SelectAll_MaDanhSach(currentMaDanhSach, listChiTietDanhSach)

        Dim allBenhNhan = New List(Of BenhNhanDTO)
        benhNhanBUS.SelectAll(allBenhNhan)

        Dim listBenhNhanInTheDay = (From ctds In listChiTietDanhSach
                                    From bn In allBenhNhan
                                    Where ctds.MaBenhNhan = bn.MaBenhNhan
                                    Select New BenhNhanDTO With
                                        {
                                            .MaBenhNhan = bn.MaBenhNhan,
                                            .HoTen = bn.HoTen,
                                            .GioiTinh = bn.GioiTinh,
                                            .DiaChi = bn.DiaChi,
                                            .NgaySinh = bn.NgaySinh
                                        }).ToList()

        ''Load the list of BenhNhan to combobox
        cbBenhNhan.DataSource = New BindingSource(listBenhNhanInTheDay, String.Empty)
        cbBenhNhan.DisplayMember = "HoTen"
        cbBenhNhan.ValueMember = "MaBenhNhan"

    End Sub

    Private Sub cbBenhNhan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBenhNhan.SelectedIndexChanged

        If (cbBenhNhan.SelectedIndex < 0) Then
            tbGioiTinh.Text = ""
            tbDiaChi.Text = ""
            tbNamSinh.Text = ""
            Return
        End If

        Dim selectedItem = CType(cbBenhNhan.SelectedItem, BenhNhanDTO)

        'Auto show the information which is matched the BenhNhan
        tbGioiTinh.Text = selectedItem.GioiTinh
        tbDiaChi.Text = selectedItem.DiaChi
        tbNamSinh.Text = selectedItem.NgaySinh.ToString("d")

    End Sub

    Private Sub dtpNgayKham_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayKham.ValueChanged

        'Load list of BenhNhan in the day to combobox
        ''Get MaDanhSach of the current day
        Dim currentDay = dtpNgayKham.Value.ToString("d")

        Dim listDanhSachKham = New List(Of DanhSachKhamDTO)
        danhSachKhamBUS.SelectAll(listDanhSachKham)

        Dim currentMaDanhSach = String.Empty
        If (listDanhSachKham.Count > 0) Then
            currentMaDanhSach = (From danhSach In listDanhSachKham
                                 Where danhSach.NgayKham.ToString("d") = currentDay
                                 Select danhSach.MaDanhSach).DefaultIfEmpty("Null").First()
        End If


        ''Get list of BenhNhan in the day
        Dim listChiTietDanhSach = New List(Of ChiTietDanhSachDTO) 'Contains all the ChiTietDanhSachDTO in the day
        chiTietDanhSachBUS.SelectAll_MaDanhSach(currentMaDanhSach, listChiTietDanhSach)

        Dim allBenhNhan = New List(Of BenhNhanDTO)
        benhNhanBUS.SelectAll(allBenhNhan)

        Dim listBenhNhanInTheDay = (From ctds In listChiTietDanhSach
                                    From bn In allBenhNhan
                                    Where ctds.MaBenhNhan = bn.MaBenhNhan
                                    Select New BenhNhanDTO With
                                        {
                                            .MaBenhNhan = bn.MaBenhNhan,
                                            .HoTen = bn.HoTen,
                                            .GioiTinh = bn.GioiTinh,
                                            .DiaChi = bn.DiaChi,
                                            .NgaySinh = bn.NgaySinh
                                        }).ToList()

        ''Load the list of BenhNhan to combobox
        If (listBenhNhanInTheDay.Count <= 0) Then
            cbBenhNhan.DataSource = Nothing
            cbBenhNhan.Items.Clear()
            Return
        End If

        cbBenhNhan.DataSource = New BindingSource(listBenhNhanInTheDay, String.Empty)
        cbBenhNhan.DisplayMember = "HoTen"
        cbBenhNhan.ValueMember = "MaBenhNhan"

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class