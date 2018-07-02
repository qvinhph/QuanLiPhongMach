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
    Private phieuKhamBUS As PhieuKhamBUS
    Private chiTietPhieuKhamBUS As ChiTietPhieuKhamBUS


    Private Sub frmPhieuKhamBenh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaiBenhBUS = New LoaiBenhBUS()
        danhSachKhamBUS = New DanhSachKhamBUS()
        chiTietDanhSachBUS = New ChiTietDanhSachBUS()
        benhNhanBUS = New BenhNhanBUS()
        thuocBUS = New ThuocBUS()
        donViBus = New DonViBUS()
        cachDungBUS = New CachDungBUS()
        phieuKhamBUS = New PhieuKhamBUS()
        chiTietPhieuKhamBUS = New ChiTietPhieuKhamBUS()

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
        clDonVi.ReadOnly = True
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


#Region "Load tabpage Thong Tin Phieu Kham"

        'Load MaPhieuKham
        Dim result As Result
        Dim maPhieuKham As String = Nothing
        result = phieuKhamBUS.BuildID(maPhieuKham)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã tự động danh sách khám không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        tbMaPhieuKham.Text = maPhieuKham


        'Load list of LoaiBenh to combobox
        Dim listLoaiBenh = New List(Of LoaiBenhDTO)
        result = loaiBenhBUS.SelectAll(listLoaiBenh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại bệnh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbLoaiBenh.DataSource = New BindingSource(listLoaiBenh, String.Empty)
        cbLoaiBenh.DisplayMember = "LoaiBenh"
        cbLoaiBenh.ValueMember = "MaLoaiBenh"


        'To raise daytime picker value changed events for loading BenhNhan ComboBox
        dtpNgayKham.Value = DateTime.Now

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



    End Sub


    Private Sub cbBenhNhan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBenhNhan.SelectedIndexChanged

        If (cbBenhNhan.SelectedIndex < 0) Then
            tbMaBenhNhan.Text = ""
            tbGioiTinh.Text = ""
            tbDiaChi.Text = ""
            tbNamSinh.Text = ""
            Return
        End If

        Dim selectedItem = CType(cbBenhNhan.SelectedItem, BenhNhanDTO)

        'Auto show the information which is matched the BenhNhan
        tbMaBenhNhan.Text = selectedItem.MaBenhNhan
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
            MessageBox.Show("Chưa tạo danh sách khám cho ngày này.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
            tbCachDung.Text = ""
            tbDonVi.Text = ""
            tbSoLuong.Text = ""
            tbMaThuoc.Text = ""
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
        tbMaThuoc.Text = selectedItem.MaThuoc

    End Sub


    Private Sub btThemThuoc_Click(sender As Object, e As EventArgs) Handles btThemThuoc.Click

        If (cbThuoc.SelectedIndex = -1) Then Return

        'Get selected Thuoc in ComboBox
        Dim selectedItem = CType(cbThuoc.SelectedItem, ThuocDTO)

        'Create row that hold data
        Dim row As String() = New String() {selectedItem.MaThuoc, selectedItem.TenThuoc, tbDonVi.Text, tbSoLuong.Text, tbCachDung.Text}

        'Add
        Dim integerNumber As Integer
        If (Int32.TryParse(tbSoLuong.Text, integerNumber)) Then
            If (IsValidToAdd(selectedItem.MaThuoc)) Then
                'Add
                dgvThuoc.Rows.Add(row)

                'Clear textboxs after add
                tbCachDung.Text = ""
                tbDonVi.Text = ""
                cbThuoc.SelectedIndex = -1
                tbSoLuong.Text = ""
                tbMaThuoc.Text = ""
            End If
        Else
            MessageBox.Show("Số lượng thuốc không hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim nextMaThuoc
        thuocBUS.BuildID(nextMaThuoc)
        tbMaThuoc.Text = nextMaThuoc

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


    Private Sub btXoaThuoc_Click(sender As Object, e As EventArgs) Handles btXoaThuoc.Click

        dgvThuoc.Rows.RemoveAt(dgvThuoc.SelectedRows(0).Index)

    End Sub


    Private Sub dgvThuoc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThuoc.CellClick

        Dim maThuoc As String = String.Empty
        Dim donVi As String = String.Empty
        Dim cachDung As String = String.Empty
        Dim soLuong As String = String.Empty

        'Get selected cell value
        If (e.RowIndex > -1 And e.RowIndex < dgvThuoc.Rows.Count) Then
            maThuoc = dgvThuoc.Rows(e.RowIndex).Cells(0).Value
            donVi = dgvThuoc.Rows(e.RowIndex).Cells(2).Value
            cachDung = dgvThuoc.Rows(e.RowIndex).Cells(4).Value
            soLuong = dgvThuoc.Rows(e.RowIndex).Cells(3).Value
        End If

        'Load to textbox
        cbThuoc.SelectedValue = maThuoc
        tbDonVi.Text = donVi
        tbSoLuong.Text = soLuong
        tbCachDung.Text = cachDung
        tbMaThuoc.Text = maThuoc

    End Sub


    Private Sub btCapNhatThuoc_Click(sender As Object, e As EventArgs) Handles btCapNhatThuoc.Click

        'Get selected Thuoc in ComboBox
        Dim selectedItem = CType(cbThuoc.SelectedItem, ThuocDTO)

        'Update
        Dim integerNumber As Integer
        If (Int32.TryParse(tbSoLuong.Text, integerNumber)) Then
            If (IsValidToUpdate(selectedItem.MaThuoc)) Then
                'Update to selected row
                dgvThuoc.SelectedRows(0).Cells(0).Value = selectedItem.MaThuoc
                dgvThuoc.SelectedRows(0).Cells(1).Value = selectedItem.TenThuoc
                dgvThuoc.SelectedRows(0).Cells(2).Value = tbDonVi.Text
                dgvThuoc.SelectedRows(0).Cells(3).Value = tbSoLuong.Text
                dgvThuoc.SelectedRows(0).Cells(4).Value = tbCachDung.Text

                'Clear textboxs after add
                tbCachDung.Text = ""
                tbDonVi.Text = ""
                cbThuoc.SelectedIndex = -1
                tbSoLuong.Text = ""
                tbMaThuoc.Text = ""
            End If
        Else
            MessageBox.Show("Số lượng thuốc không hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Function IsValidToUpdate(maThuoc As String) As Boolean

        Dim selectedRowIndex = dgvThuoc.SelectedRows(0).Index

        For Each row As DataGridViewRow In dgvThuoc.Rows
            If (row.Cells(0).Value = maThuoc And row.Index <> selectedRowIndex) Then
                MessageBox.Show("Loại thuốc này đã được thêm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next

        Return True

    End Function


    Private Sub btLapPhieu_Click(sender As Object, e As EventArgs) Handles btLapPhieu.Click

        If (cbBenhNhan.SelectedIndex = -1) Then
            MessageBox.Show("Bạn chưa chọn bệnh nhân.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim phieuKham = New PhieuKhamDTO()
        Dim chiTietPK = New ChiTietPhieuKhamDTO()

        'Insert to PhieuKham Table
        ''1.Mapping data from GUI Control
        ''Get ChiTietDanhSach by MaBenhNhan and MaDanhSach
        Dim maBenhNhan = tbMaBenhNhan.Text
        Dim currentDay = dtpNgayKham.Value.ToString("d")

        Dim currentDanhSachKham As DanhSachKhamDTO = Nothing
        danhSachKhamBUS.Select_ByNgayKham(currentDay, currentDanhSachKham)

        Dim listChiTietDanhSach = New List(Of ChiTietDanhSachDTO) ' all the chitietdanhsach in the current day
        chiTietDanhSachBUS.SelectAll_MaDanhSach(currentDanhSachKham.MaDanhSach, listChiTietDanhSach)

        Dim chiTietDanhSach = (From ctds In listChiTietDanhSach
                               Where ctds.MaBenhNhan = maBenhNhan
                               Select ctds).FirstOrDefault()

        phieuKham.MaPhieuKham = tbMaPhieuKham.Text
        phieuKham.TrieuChung = tbTrieuChung.Text
        phieuKham.MaLoaiBenh = CType(cbLoaiBenh.SelectedItem, LoaiBenhDTO).MaLoaiBenh
        phieuKham.MaChiTietDanhSach = chiTietDanhSach.MaChiTietDanhSach

        ''2. Business...

        ''3. Insert to DB
        Dim result = phieuKhamBUS.Insert(phieuKham)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm phiếu khám không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If


        'Insert to ChiTietPhieuKham Table
        Dim maChiTietPK = String.Empty
        For Each row In dgvThuoc.Rows

            ''1. Mapping data
            chiTietPhieuKhamBUS.BuildID(maChiTietPK)
            chiTietPK.MaChiTietPhieuKham = maChiTietPK
            chiTietPK.MaPhieuKham = tbMaPhieuKham.Text
            chiTietPK.MaThuoc = row.Cells(0).Value
            chiTietPK.SoLuong = row.Cells(3).Value

            ''2.Business

            ''3.Insert to DB
            result = chiTietPhieuKhamBUS.Insert(chiTietPK)

        Next

        If (result.FlagResult = True) Then
            'get next MaPhieuKham
            Dim nextMaPhieuKham = String.Empty

            result = phieuKhamBUS.BuildID(nextMaPhieuKham)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã phiếu khám không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If

            'After add
            ClearForm()
            tbMaPhieuKham.Text = nextMaPhieuKham
            dgvThuoc.Rows.Clear()
            MessageBox.Show("Thêm phiếu khám thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub ClearForm()

        tbMaBenhNhan.Text = String.Empty
        tbNamSinh.Text = String.Empty
        tbTrieuChung.Text = String.Empty
        tbGioiTinh.Text = String.Empty
        tbDiaChi.Text = String.Empty
        cbLoaiBenh.SelectedIndex = -1
        cbBenhNhan.SelectedIndex = -1

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class