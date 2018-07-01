Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Imports System.Windows.Forms
Imports System.Globalization

Public Class frmBaoCaoDoanhThu

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
    Private baoCaoDoanhThuBUS As BaoCaoDoanhThuBUS
    Private chiTietBaoCaoDoanhThuBUS As ChiTietBaoCaoDoanhThuBUS

    Private dateBaoCao As Date
    Private lineNumber As Integer
    Private listDSK_ByMonth As List(Of DanhSachKhamDTO)

    'For currency number format
    Dim vnd = New CultureInfo("vi")


    Private Sub frmBaoCaoDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        baoCaoDoanhThuBUS = New BaoCaoDoanhThuBUS()
        chiTietBaoCaoDoanhThuBUS = New ChiTietBaoCaoDoanhThuBUS()

        dateBaoCao = dtpNgayKham.Value.Date
        lineNumber = 0

        'Load MaBaoCaoDoanhThu
        Dim result = New Result()
        Dim maBaoCao = String.Empty
        result = baoCaoDoanhThuBUS.BuildID(maBaoCao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã báo cáo doanh thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        tbMaBaoCao.Text = maBaoCao


#Region "Load DataGridView"

        'Properties
        dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'Contructing 
        Dim clSTT = New DataGridViewTextBoxColumn()
        clSTT.Name = "STT"
        clSTT.HeaderText = "STT"
        clSTT.ReadOnly = True
        clSTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        dgvBaoCao.Columns.Add(clSTT)

        Dim clNgay = New DataGridViewTextBoxColumn()
        clNgay.Name = "Ngay"
        clNgay.HeaderText = "Ngày"
        clNgay.ReadOnly = True
        dgvBaoCao.Columns.Add(clNgay)

        Dim clSoBenhNhan = New DataGridViewTextBoxColumn()
        clSoBenhNhan.Name = "SoBenhNhan"
        clSoBenhNhan.HeaderText = "Số Bệnh Nhân"
        clSoBenhNhan.ReadOnly = True
        dgvBaoCao.Columns.Add(clSoBenhNhan)

        Dim clDoanhThu = New DataGridViewTextBoxColumn()
        clDoanhThu.Name = "DoanhThu"
        clDoanhThu.HeaderText = "Doanh Thu"
        clDoanhThu.ReadOnly = True
        dgvBaoCao.Columns.Add(clDoanhThu)

        Dim clTyLe = New DataGridViewTextBoxColumn()
        clTyLe.Name = "TyLe"
        clTyLe.HeaderText = "Tỷ Lệ"
        clTyLe.ReadOnly = True
        dgvBaoCao.Columns.Add(clTyLe)

        'Load data 
        LoadDataGridView(dateBaoCao)

#End Region

    End Sub


    Private Sub dtpNgayKham_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayKham.ValueChanged

        dateBaoCao = dtpNgayKham.Value.Date
        LoadDataGridView(dateBaoCao)

        ' dgvBaoCao.Focus()

    End Sub


    Private Sub LoadDataGridView(time As Date)

        dgvBaoCao.Rows.Clear()
        Dim result = New Result()

        lineNumber = 0

        'Get list of "danh khach kham" in the month
        Dim listDanhSachKham = New List(Of DanhSachKhamDTO)
        result = danhSachKhamBUS.SelectAll(listDanhSachKham)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khám theo tháng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Dim listDSK_ByMonth = From ds In listDanhSachKham
                              Where ds.NgayKham.Month = time.Month And ds.NgayKham.Year = time.Year
                              Select ds

        'Load to datagridview 
        Dim ngayKham As Date
        Dim soBenhNhan As Integer
        Dim doanhThu As Double
        Dim stt As Integer

        For Each dsk In listDSK_ByMonth
            lineNumber += 1
            stt = lineNumber
            ngayKham = dsk.NgayKham
            soBenhNhan = GetListChiTietDanhSach_ByMaDanhSach(dsk.MaDanhSach).Count()

            'Calculate doanh thu
            Dim listHoaDon = GetListHoaDon_ByMaDanhSach(dsk.MaDanhSach)
            For Each hd In listHoaDon
                doanhThu = doanhThu + hd.TienThuoc + hd.TienKham
            Next

            Dim row As String() = New String() {stt, ngayKham, soBenhNhan, doanhThu}
            dgvBaoCao.Rows.Add(row)
        Next

        Dim tongDoanhThu = CalculateTongDoanhThu()
        lbTongDoanhThu.Text = tongDoanhThu.ToString("c", vnd)
        lbTongBenhNhan.Text = CalculateTongBenhNhan()

        'Calculate TyLe and load to datagridview
        Dim tyLe As String
        Dim doubleNumber As Double
        For Each row In dgvBaoCao.Rows

            'Convert to double for calculating
            Double.TryParse(row.Cells(3).Value, doubleNumber)

            tyLe = ((doubleNumber / tongDoanhThu) * 100).ToString() + "%"
            row.Cells(4).Value = tyLe

        Next

    End Sub


    Private Function GetListChiTietDanhSach_ByMaDanhSach(maDanhSach As String) As List(Of ChiTietDanhSachDTO)

        Dim result = New Result()
        Dim listChiTietDanhSach = New List(Of ChiTietDanhSachDTO)

        result = chiTietDanhSachBUS.SelectAll_MaDanhSach(maDanhSach, listChiTietDanhSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy chi tiết danh sách theo mã danh sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        Return listChiTietDanhSach

    End Function


    Private Function GetListHoaDon_ByMaDanhSach(maDanhSach As String) As List(Of HoaDonDTO)

        Dim result = New Result()

        'Get list ctds
        Dim listCTDS = GetListChiTietDanhSach_ByMaDanhSach(maDanhSach)

        'Get all phieukham
        Dim allPhieuKham = New List(Of PhieuKhamDTO)
        result = phieuKhamBUS.SelectAll(allPhieuKham)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tất cả phiếu khám không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        'Get list of phieukham in the day of MaDanhSach
        Dim listPhieuKham = From pk In allPhieuKham
                            From ctds In listCTDS
                            Where ctds.MaChiTietDanhSach = pk.MaChiTietDanhSach
                            Select New PhieuKhamDTO With
                            {
                                .MaChiTietDanhSach = pk.MaChiTietDanhSach,
                                .MaLoaiBenh = pk.MaLoaiBenh,
                                .MaPhieuKham = pk.MaPhieuKham,
                                .TrieuChung = pk.TrieuChung
                            }

        'Get list of hoadon in the day of MaDanhSach
        Dim allHoaDon = New List(Of HoaDonDTO)
        result = hoaDonBUS.SelectAll(allHoaDon)

        'Dim listHoaDon = From hd In allHoaDon
        '                 From pk In listPhieuKham
        '                 Where hd.MaPhieuKham = pk.MaPhieuKham
        '                 Select New HoaDonDTO With
        '                     {
        '                        .MaHoaDon = hd.MaHoaDon,
        '                        .MaPhieuKham = hd.MaPhieuKham,
        '                        .TienKham = hd.TienKham,
        '                        .TienThuoc = hd.TienThuoc
        '                     }

        Dim listHoaDon = New List(Of HoaDonDTO)
        Dim hoaDon = New HoaDonDTO()
        For Each hd In allHoaDon
            For Each pk In listPhieuKham
                If True Then
                    hd.MaPhieuKham = pk.MaPhieuKham
                End If

                hoaDon.MaHoaDon = hd.MaHoaDon
                hoaDon.MaPhieuKham = hd.MaPhieuKham
                hoaDon.TienKham = hd.TienKham
                hoaDon.TienThuoc = hd.TienThuoc

                listHoaDon.Add(hoaDon)
            Next
        Next


        Return listHoaDon

    End Function


    Private Function CalculateTongDoanhThu() As Double

        Dim sum As Double = 0

        For Each row In dgvBaoCao.Rows

            sum = row.Cells(3).Value + sum

        Next

        Return sum

    End Function


    Private Function CalculateTongBenhNhan() As Double

        Dim sum As Double = 0

        For Each row In dgvBaoCao.Rows

            sum = row.Cells(2).Value + sum

        Next

        Return sum

    End Function


    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs) Handles btnLuuBaoCao.Click

        Dim result = New Result()

        If (dgvBaoCao.Rows.Count < 2) Then
            MessageBox.Show("Không có số liệu nào để lưu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

        'Save to BaoCaoDoanhThu table
        ''1. Matching data from GUI
        Dim baoCaoDoanhThu = New BaoCaoDoanhThuDTO()
        baoCaoDoanhThu.MaBaoCaoDoanhThu = tbMaBaoCao.Text
        baoCaoDoanhThu.ThangBaoCao = dateBaoCao.Month

        ''2. Business

        ''3. Insert to DB
        result = baoCaoDoanhThuBUS.Insert(baoCaoDoanhThu)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm báo cáo doanh thu không thành không.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        'Save to ChiTietBaoCaoDoanhThu table
        Dim chiTietBaoCaoDoanhThu = New ChiTietBaoCaoDoanhThuDTO()
        Dim maChiTietBaoCaoDoanhthu = String.Empty
        For Each row In dgvBaoCao.Rows

            Console.WriteLine(row.Cells(0).Value)
            Console.WriteLine(row.Cells(1).Value)
            Console.WriteLine(row.Cells(2).Value)
            Console.WriteLine(row.Cells(3).Value)
            Console.WriteLine(row.Cells(4).Value)

            ''1. Matching data from GUI
            chiTietBaoCaoDoanhThuBUS.BuildID(maChiTietBaoCaoDoanhthu)
            chiTietBaoCaoDoanhThu.MaChiTietBaoCaoDoanhThu = maChiTietBaoCaoDoanhthu
            chiTietBaoCaoDoanhThu.Ngay = row.Cells(1).Value
            chiTietBaoCaoDoanhThu.SoBenhNhan = row.Cells(2).Value

            Dim doubleNumber As Double
            'Dim stringDoanhThu = CType(row.Cells(3).Value, String)
            'Double.TryParse(stringDoanhThu, doubleNumber)
            'chiTietBaoCaoDoanhThu.DoanhThu = doubleNumber
            chiTietBaoCaoDoanhThu.DoanhThu = row.Cells(3).Value

            Dim stringTyLe As String = row.Cells(3).Value
            Dim stringTyLe2 = stringTyLe.ToString()
            Dim onlyNumber = stringTyLe.Substring(0, stringTyLe.Length - 1)
            Double.TryParse(onlyNumber, doubleNumber)
            chiTietBaoCaoDoanhThu.TyLe = doubleNumber

            chiTietBaoCaoDoanhThu.MaBaoCaoDoanhThu = tbMaBaoCao.Text

            ''2.Business


            ''3. Insert to DB
            chiTietBaoCaoDoanhThuBUS.Insert(chiTietBaoCaoDoanhThu)
        Next

        'After save
        MessageBox.Show("Thêm báo cáo doanh thu thành không.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim nextMaBaoCaoDoanhThu = String.Empty
        baoCaoDoanhThuBUS.BuildID(nextMaBaoCaoDoanhThu)
        tbMaBaoCao.Text = nextMaBaoCaoDoanhThu
        dgvBaoCao.Rows.Clear()
        lbTongBenhNhan.Text = "0"
        lbTongDoanhThu.Text = "0"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class