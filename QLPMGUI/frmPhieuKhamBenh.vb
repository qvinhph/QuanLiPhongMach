Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Imports System.Windows.Forms

Public Class frmPhieuKhamBenh

    Private loaiBenhBUS As LoaiBenhBUS
    Private danhSachKhamBUS As DanhSachKhamBUS
    Private chiTietDanhSachBUS As ChiTietDanhSachBUS
    Private benhNhanBUS As BenhNhanBUS
    Private thuocBUS As ThuocBUS
    Private donViBUS As DonViBUS
    Private cachDungBUS As CachDungBUS


    Private Sub frmPhieuKhamBenh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaiBenhBUS = New LoaiBenhBUS()
        danhSachKhamBUS = New DanhSachKhamBUS()
        chiTietDanhSachBUS = New ChiTietDanhSachBUS()
        benhNhanBUS = New BenhNhanBUS()
        thuocBUS = New ThuocBUS()
        donViBus = New DonViBUS()
        cachDungBUS = New CachDungBUS()

#Region "Load tabpage Thong Tin Phieu Kham"

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
        currentMaDanhSach = (From danhSach In listDanhSachKham
                             Where danhSach.NgayKham.ToString("d") = currentDay
                             Select danhSach.MaDanhSach).FirstOrDefault()



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

#End Region

#Region "Load TabPage Thuoc"

        'Load List of LoaiBenh to combobox
        Dim listThuoc = New List(Of ThuocDTO)
        result = thuocBUS.SelectAll(listThuoc)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách thuốc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbThuoc.DataSource = New BindingSource(listThuoc, String.Empty)
        cbThuoc.DisplayMember = "TenThuoc"
        cbThuoc.ValueMember = "MaThuoc"

#End Region

#Region "Load DataGridView Thuoc"

        'Properties
        dgvThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'Contructing columns
        Dim clMaThuoc = New DataGridViewTextBoxColumn()
        clMaThuoc.Name = "MaThuoc"
        clMaThuoc.HeaderText = "Mã Thuốc"
        clMaThuoc.ReadOnly = True
        dgvThuoc.Columns.Add(clMaThuoc)

        Dim clTenThuoc = New DataGridViewTextBoxColumn()
        clTenThuoc.Name = "TenThuoc"
        clTenThuoc.HeaderText = "Tên Thuốc"
        clTenThuoc.ReadOnly = True
        dgvThuoc.Columns.Add(clTenThuoc)

        Dim clDonVi = New DataGridViewTextBoxColumn()
        clDonVi.Name = "DonVi"
        clDonVi.HeaderText = "Đơn Vị"
        dgvThuoc.Columns.Add(clDonVi)

        Dim clSoLuong = New DataGridViewTextBoxColumn()
        clSoLuong.Name = "SoLuong"
        clSoLuong.HeaderText = "Số Lượng"
        clSoLuong.ReadOnly = False
        dgvThuoc.Columns.Add(clSoLuong)

        Dim clCachDung = New DataGridViewTextBoxColumn()
        clCachDung.Name = "CachDung"
        clCachDung.HeaderText = "Cách Dùng"
        clCachDung.ReadOnly = True
        dgvThuoc.Columns.Add(clCachDung)

#End Region

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
        Else
            cbBenhNhan.DataSource = New BindingSource(listBenhNhanInTheDay, String.Empty)
            cbBenhNhan.DisplayMember = "HoTen"
            cbBenhNhan.ValueMember = "MaBenhNhan"
        End If

    End Sub

    Private Sub btTTPhieuKham_Click(sender As Object, e As EventArgs) Handles btTTPhieuKham.Click
        'Change the tab page
        tabControl.SelectedTab = tabPageThongTin
    End Sub

    Private Sub btKeThuoc_Click(sender As Object, e As EventArgs) Handles btKeThuoc.Click
        'Change the tab page
        tabControl.SelectedTab = tabPageThuoc
    End Sub

    Private Sub cbThuoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbThuoc.SelectedIndexChanged

        If (cbThuoc.SelectedIndex < 0) Then
            tbGioiTinh.Text = ""
            tbDiaChi.Text = ""
            tbNamSinh.Text = ""
            Return
        End If

        Dim selectedItem = CType(cbThuoc.SelectedItem, ThuocDTO)

        'Get the corresponding CachDung and DonVi
        Dim listDonVi = New List(Of DonViDTO)
        Dim listCachDung = New List(Of CachDungDTO)

        cachDungBUS.SelectAll(listCachDung)
        donViBUS.SelectAll(listDonVi)

        Dim cachDung = (From cd In listCachDung
                        Where cd.MaCachDung = selectedItem.MaCachDung
                        Select cd).FirstOrDefault()

        Dim donVi = (From dv In listDonVi
                     Where dv.MaDonVi = selectedItem.MaDonVi
                     Select dv).FirstOrDefault()

        'Auto show the information which is matched Thuoc
        tbDonVi.Text = donVi.DonVi
        tbCachDung.Text = cachDung.CachDung

    End Sub

    Private Sub btThemThuoc_Click(sender As Object, e As EventArgs) Handles btThemThuoc.Click

        'Get selected Thuoc
        Dim selectedItem = CType(cbThuoc.SelectedItem, ThuocDTO)

        'Create row that hold data
        Dim row As String() = New String() {selectedItem.MaThuoc, selectedItem.TenThuoc, tbDonVi.Text, tbSoLuong.Text, tbCachDung.Text}

        'Add
        Dim integerNumber As Integer
        If (Int32.TryParse(tbSoLuong.Text, integerNumber)) Then

            If (IsValidToAdd(selectedItem.MaThuoc)) Then
                dgvThuoc.Rows.Add(row)
            End If

        Else

            MessageBox.Show("Số lượng thuốc không hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

    Private Function IsValidToAdd(maThuoc As String) As Boolean

        For Each row As DataGridViewRow In dgvThuoc.Rows
            If (row.Cells(0).Value = maThuoc) Then
                MessageBox.Show("Loại thuốc này đã được thêm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next

        Return True

    End Function

End Class