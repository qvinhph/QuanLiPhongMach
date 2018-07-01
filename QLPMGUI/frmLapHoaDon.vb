Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Imports System.Windows.Forms
Imports System.Globalization

Class frmLapHoaDon

    Private loaiBenhBUS As LoaiBenhBUS
    Private danhSachKhamBUS As DanhSachKhamBUS
    Private chiTietDanhSachBUS As ChiTietDanhSachBUS
    Private benhNhanBUS As BenhNhanBUS
    Private thuocBUS As ThuocBUS
    Private donViBUS As DonViBUS
    Private cachDungBUS As CachDungBUS
    Private phieuKhamBUS As PhieuKhamBUS
    Private chiTietPhieuKhamBUS As ChiTietPhieuKhamBUS
    Private hoaDonBUS As HoaDonBUS
    Private thamSoBUS As ThamSoBUS


    'Use for getting all the drugs that patient use
    Dim listChiTietPK_ByMaPhieuKham = New List(Of ChiTietPhieuKhamDTO)

    'For currency number format
    Dim vnd = New CultureInfo("vi")


    Private Sub frmLapHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaiBenhBUS = New LoaiBenhBUS()
        danhSachKhamBUS = New DanhSachKhamBUS()
        chiTietDanhSachBUS = New ChiTietDanhSachBUS()
        benhNhanBUS = New BenhNhanBUS()
        thuocBUS = New ThuocBUS()
        donViBUS = New DonViBUS()
        cachDungBUS = New CachDungBUS()
        phieuKhamBUS = New PhieuKhamBUS()
        chiTietPhieuKhamBUS = New ChiTietPhieuKhamBUS()
        hoaDonBUS = New HoaDonBUS()
        thamSoBUS = New ThamSoBUS()


        'Load MaHoaDon
        Dim result As Result
        Dim maHoaDon As String = Nothing
        result = hoaDonBUS.BuildID(maHoaDon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã hóa đơn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        tbMaHoaDon.Text = maHoaDon


        'To raise daytime picker value changed events for loading BenhNhan ComboBox
        dtpNgayKham.Value = DateTime.Now


        'Load default tien kham
        Dim thamSo = New ThamSoDTO()
        result = thamSoBUS.GetThamSoOnDB(thamSo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tham số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        tbTienKham.Text = thamSo.TienKham


        'load tien thuoc
        Dim currentMaPhieuKham = GetMaPhieuKham()
        'dim listchitietpk_bymaphieukham = new list(of chitietphieukhamdto)
        result = chiTietPhieuKhamBUS.SelectAll_ByMaPhieuKham(currentMaPhieuKham, listChiTietPK_ByMaPhieuKham)
        If (result.FlagResult = False) Then
            MessageBox.Show("lấy danh sách chi tiết phiếu khám theo mã phiếu khám không thành công.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        tbTienThuoc.Text = CalculateTienThuoc()
        tbTongTien.Text = (Double.Parse(tbTienThuoc.Text) + Double.Parse(tbTienKham.Text)).ToString("c", vnd)

#Region "Load DataGridView"

        'Properties
        dgvThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'Contructing columns
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

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "DonGia"
        clDonGia.HeaderText = "Đơn Giá"
        clDonGia.ReadOnly = True
        dgvThuoc.Columns.Add(clDonGia)

        Dim clTongTien = New DataGridViewTextBoxColumn()
        clTongTien.Name = "TonTien"
        clTongTien.HeaderText = "Tổng Tiền"
        clTongTien.ReadOnly = True
        dgvThuoc.Columns.Add(clTongTien)

        'Load data 
        LoadDataDataGridView()

#End Region

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


    Private Sub cbBenhNhan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBenhNhan.SelectedIndexChanged

        If (cbBenhNhan.SelectedIndex < 0) Then
            tbMaBenhNhan.Text = ""
            tbGioiTinh.Text = ""
            tbNamSinh.Text = ""
            Return
        End If

        Dim selectedItem = CType(cbBenhNhan.SelectedItem, BenhNhanDTO)

        'Auto show the information which is matched the BenhNhan
        tbMaBenhNhan.Text = selectedItem.MaBenhNhan
        tbGioiTinh.Text = selectedItem.GioiTinh
        tbNamSinh.Text = selectedItem.NgaySinh.ToString("d")

        'Re-get list ChiTietPhieuKham by MaPhieuKham
        Dim result = New Result()
        Dim currentMaPhieuKham = GetMaPhieuKham()

        result = chiTietPhieuKhamBUS.SelectAll_ByMaPhieuKham(currentMaPhieuKham, listChiTietPK_ByMaPhieuKham)

        If (Result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chi tiết phiếu khám theo mã phiếu khám không thành công.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
        End If

        tbTienThuoc.Text = CalculateTienThuoc()
        tbTongTien.Text = (Double.Parse(tbTienThuoc.Text) + Double.Parse(tbTienKham.Text)).ToString("c", vnd)
        LoadDataDataGridView()

    End Sub


    Private Function GetMaPhieuKham() As String

        If (cbBenhNhan.SelectedIndex = -1) Then Return ""

        Dim result = New Result()

        'Get MaDanhSach of current day
        Dim currentDay = dtpNgayKham.Value.ToString("d")
        Dim currentDanhSach = New DanhSachKhamDTO()
        result = danhSachKhamBUS.Select_ByNgayKham(currentDay, currentDanhSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khám theo ngày không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return Nothing
        End If

        'Get MaChiTietDanhSach by MaBenhNhan and MaDanhSach
        Dim currentMaBenhNhan = CType(cbBenhNhan.SelectedItem, BenhNhanDTO).MaBenhNhan
        Dim listChiTietDS = New List(Of ChiTietDanhSachDTO)
        result = chiTietDanhSachBUS.SelectAll_MaDanhSach(currentDanhSach.MaDanhSach, listChiTietDS)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy chi tiết danh sách theo theo danh sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return Nothing
        End If
        Dim currentMaChiTietDanhSach = (From ctds In listChiTietDS
                                        Where ctds.MaDanhSach = currentDanhSach.MaDanhSach And ctds.MaBenhNhan = currentMaBenhNhan
                                        Select ctds.MaChiTietDanhSach).FirstOrDefault()

        'Get MaPhieuKham
        Dim listPhieuKham = New List(Of PhieuKhamDTO)
        result = phieuKhamBUS.SelectAll(listPhieuKham)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tất cả phiếu khám không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return Nothing
        End If

        Dim currentMaPhieuKham = (From pk In listPhieuKham
                                  Where pk.MaChiTietDanhSach = currentMaChiTietDanhSach
                                  Select pk.MaPhieuKham).FirstOrDefault()

        If (currentMaPhieuKham IsNot Nothing) Then
            Return currentMaPhieuKham
        Else
            'MessageBox.Show("Chưa lập phiếu khám bệnh cho bệnh nhân này. Vui lòng lập rồi tính tiền sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ""
        End If


    End Function


    Private Function CalculateTienThuoc() As Double

        Dim result = New Result
        Dim tongTienThuoc = 0
        Dim thuoc = New ThuocDTO

        For Each ctpk As ChiTietPhieuKhamDTO In listChiTietPK_ByMaPhieuKham

            result = thuocBUS.Select_ByMaThuoc(ctpk.MaThuoc, thuoc)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy thuốc theo mã thuốc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

            tongTienThuoc += ctpk.SoLuong * thuoc.DonGia

        Next

        Return tongTienThuoc

    End Function


    Private Sub tbTienKham_TextChanged(sender As Object, e As EventArgs) Handles tbTienKham.TextChanged

        Dim tienThuoc As Double = 0
        Double.TryParse(tbTienThuoc.Text, tienThuoc)

        Dim tienKham As Double = 0
        Double.TryParse(tbTienKham.Text, tienKham)

        tbTongTien.Text = (tienThuoc + tienKham).ToString("c", vnd)
        
    End Sub


    Private Sub LoadDataDataGridView()

        dgvThuoc.Rows.Clear()
        Dim result = New Result
        Dim thuoc = New ThuocDTO

        For Each ctpk As ChiTietPhieuKhamDTO In listChiTietPK_ByMaPhieuKham

            result = thuocBUS.Select_ByMaThuoc(ctpk.MaThuoc, thuoc)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy thuốc theo mã thuốc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

            Dim tenThuoc = thuoc.TenThuoc
            Dim listDonVi = New List(Of DonViDTO)
            donViBUS.SelectAll(listDonVi)
            Dim tenDonVi = (From dv In listDonVi
                            Where dv.MaDonVi = thuoc.MaDonVi
                            Select dv.DonVi).FirstOrDefault()
            Dim soLuong = ctpk.SoLuong
            Dim donGia = thuoc.DonGia
            Dim tongTien = Integer.Parse(soLuong) * Double.Parse(donGia)

            'Array hold data as a row
            Dim row As String() = New String() {tenThuoc, tenDonVi, soLuong, donGia, tongTien}

            dgvThuoc.Rows.Add(row)

        Next
    End Sub


    Private Sub btLuuHoaDon_Click(sender As Object, e As EventArgs) Handles btLuuHoaDon.Click

        If (cbBenhNhan.SelectedIndex = -1) Then
            MessageBox.Show("Hãy chọn bệnh nhân.", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

        Dim hoaDon = New HoaDonDTO()
        hoaDon.MaHoaDon = tbMaHoaDon.Text
        hoaDon.MaPhieuKham = GetMaPhieuKham()
        hoaDon.TienThuoc = Double.Parse(tbTienThuoc.Text)
        hoaDon.TienKham = Double.Parse(tbTienKham.Text)

        hoaDonBUS.Insert(hoaDon)

        'After Add
        Dim result = New Result()
        Dim nextMaHoaDon = String.Empty
        result = hoaDonBUS.BuildID(nextMaHoaDon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã hóa đơn không thành công.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        tbMaHoaDon.Text = nextMaHoaDon
        cbBenhNhan.SelectedIndex = -1
        tbTienThuoc.Text = ""
        tbTongTien.Text = ""
        dgvThuoc.Rows.Clear()

    End Sub


End Class