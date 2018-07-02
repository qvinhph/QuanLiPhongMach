Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Imports System.Windows.Forms
Imports System.Globalization

Public Class frmBaoCaoSuDungThuoc

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
    Private baoCaoThuocBUS As BaoCaoThuocBUS
    Private chiTietBaoCaoThuocBUS As ChiTietBaoCaoThuocBUS

    Private dateBaoCao As Date
    Private lineNumber As Integer


    Private Sub frmBaoCaoSuDungThuoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dateBaoCao = dtpNgayKham.Value.Date
        lineNumber = 0

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
        baoCaoThuocBUS = New BaoCaoThuocBUS()
        chiTietBaoCaoThuocBUS = New ChiTietBaoCaoThuocBUS()

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

        Dim clThuoc = New DataGridViewTextBoxColumn()
        clThuoc.Name = "Thuoc"
        clThuoc.HeaderText = "Thuốc"
        clThuoc.ReadOnly = True
        dgvBaoCao.Columns.Add(clThuoc)

        Dim clDonVi = New DataGridViewTextBoxColumn()
        clDonVi.Name = "DonVi"
        clDonVi.HeaderText = "Đơn Vị"
        clDonVi.ReadOnly = True
        dgvBaoCao.Columns.Add(clDonVi)

        Dim clSoLuong = New DataGridViewTextBoxColumn()
        clSoLuong.Name = "SoLuong"
        clSoLuong.HeaderText = "Số Lượng"
        clSoLuong.ReadOnly = True
        dgvBaoCao.Columns.Add(clSoLuong)

        Dim clSoLanDung = New DataGridViewTextBoxColumn()
        clSoLanDung.Name = "SoLanDung"
        clSoLanDung.HeaderText = "Số Lần Dùng"
        clSoLanDung.ReadOnly = True
        dgvBaoCao.Columns.Add(clSoLanDung)

        'Load data 
        LoadDataDataGridView(dateBaoCao)

#End Region

        'Load MaBaoCaoThuoc
        Dim result = New Result()
        Dim maBaoCao = String.Empty
        result = baoCaoThuocBUS.BuildID(maBaoCao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy mã báo cáo thuốc không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        tbMaBaoCao.Text = maBaoCao

    End Sub


    Private Sub LoadDataDataGridView(time As Date)

        dgvBaoCao.Rows.Clear()
        Dim result = New Result()
        lineNumber = 0

        'Get list of "danh khach kham" in the month
        Dim listDanhSachKham = New List(Of DanhSachKhamDTO)
        result = danhSachKhamBUS.SelectAll(listDanhSachKham)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tất cả danh sách khám không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        Dim listDSK_ByMonth = New List(Of DanhSachKhamDTO)
        For Each dsk In listDanhSachKham
            If (dsk.NgayKham.Month = dateBaoCao.Month And dsk.NgayKham.Year = dateBaoCao.Year) Then
                listDSK_ByMonth.Add(dsk)
            End If
        Next

        Dim listCTDS_ByMonth = GetChiTietDanhSach_ByMonth(listDSK_ByMonth)
        Dim listPK_ByMonth = GetPhieuKham_ByMonth(listCTDS_ByMonth)
        Dim listCTPK_ByMonth = GetChiTietPhieuKham_ByMonth(listPK_ByMonth)

        'Get all of thuoc
        Dim allThuoc = New List(Of ThuocDTO)
        result = thuocBUS.SelectAll(allThuoc)
        'Dim listCTPK_ByMaThuoc = New List(Of ChiTietPhieuKhamDTO)

        Dim tenThuoc = String.Empty
        Dim soLanDung As Integer = 0
        Dim soLuong As Integer
        Dim donViTinh = String.Empty
        Dim STT

        For Each thuoc In allThuoc

            soLuong = 0
            soLanDung = 0
            lineNumber = lineNumber + 1
            STT = lineNumber
            tenThuoc = thuoc.TenThuoc

            'Get listCTPK_ByMaThuoc
            For Each ctpk In listCTPK_ByMonth
                If (thuoc.MaThuoc = ctpk.MaThuoc) Then
                    soLanDung = soLanDung + 1
                    soLuong = ctpk.SoLuong + soLuong
                End If
            Next

            Dim allDonVi = New List(Of DonViDTO)
            donViBUS.SelectAll(allDonVi)
            For Each dv In allDonVi
                If (dv.MaDonVi = thuoc.MaDonVi) Then
                    donViTinh = dv.DonVi
                End If
            Next

            Dim row As String() = New String() {STT, tenThuoc, donViTinh, soLuong, soLanDung}

            dgvBaoCao.Rows.Add(row)

        Next

    End Sub


    Private Function GetChiTietDanhSach_ByMonth(listDanhSachKham_ByMonth As List(Of DanhSachKhamDTO)) As List(Of ChiTietDanhSachDTO)

        Dim listchiTietDanhSach_ByMonth = New List(Of ChiTietDanhSachDTO)
        Dim tempListCTDS = New List(Of ChiTietDanhSachDTO)

        For Each dsk In listDanhSachKham_ByMonth
            chiTietDanhSachBUS.SelectAll_MaDanhSach(dsk.MaDanhSach, tempListCTDS)
            For Each ctds In tempListCTDS
                listchiTietDanhSach_ByMonth.Add(ctds)
            Next
        Next

        Return listchiTietDanhSach_ByMonth

    End Function


    Private Function GetPhieuKham_ByMonth(listChiTietDanhSach_ByMonth As List(Of ChiTietDanhSachDTO)) As List(Of PhieuKhamDTO)

        Dim listPhieuKham_ByMonth = New List(Of PhieuKhamDTO)
        Dim allPhieuKham = New List(Of PhieuKhamDTO)
        phieuKhamBUS.SelectAll(allPhieuKham)

        For Each pk In allPhieuKham
            For Each ctds In listChiTietDanhSach_ByMonth
                If (pk.MaChiTietDanhSach = ctds.MaChiTietDanhSach) Then
                    listPhieuKham_ByMonth.Add(pk)
                End If
            Next
        Next

        Return listPhieuKham_ByMonth

    End Function


    Private Function GetChiTietPhieuKham_ByMonth(listPhieuKham_ByMonth As List(Of PhieuKhamDTO)) As List(Of ChiTietPhieuKhamDTO)

        Dim listCTPK_ByMonth = New List(Of ChiTietPhieuKhamDTO)
        Dim tempListCTPK = New List(Of ChiTietPhieuKhamDTO)

        For Each pk In listPhieuKham_ByMonth
            chiTietPhieuKhamBUS.SelectAll_ByMaPhieuKham(pk.MaPhieuKham, tempListCTPK)
            For Each ctpk In tempListCTPK
                listCTPK_ByMonth.Add(ctpk)
            Next
        Next

        Return listCTPK_ByMonth

    End Function


    Private Sub dtpNgayKham_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayKham.ValueChanged

        dgvBaoCao.Rows.Clear()
        dateBaoCao = dtpNgayKham.Value.Date
        LoadDataDataGridView(dateBaoCao)

    End Sub

    Private Sub btnLuuBaoCao_Click(sender As Object, e As EventArgs) Handles btnLuuBaoCao.Click

        Dim result = New Result()

        'Save to BaoCaoDoanhThu table
        ''1. Matching data from GUI
        Dim baoCaoThuoc = New BaoCaoThuocDTO()
        baoCaoThuoc.MaBaoCaoThuoc = tbMaBaoCao.Text
        baoCaoThuoc.ThangBaoCao = dateBaoCao.Month

        ''2. Business

        ''3. Insert to DB
        result = baoCaoThuocBUS.Insert(baoCaoThuoc)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm báo cáo thuốc không thành không.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        'Save to ChiTietBaoCaoDoanhThu table
        Dim chiTietBaoCaoThuoc = New ChiTietBaoCaoThuocDTO()
        Dim maChiTietBaoCaoThuoc = String.Empty
        For Each row In dgvBaoCao.Rows

            Console.WriteLine(row.Cells(0).Value)
            Console.WriteLine(row.Cells(1).Value)
            Console.WriteLine(row.Cells(2).Value)
            Console.WriteLine(row.Cells(3).Value)
            Console.WriteLine(row.Cells(4).Value)

            ''1. Matching data from GUI
            chiTietBaoCaoThuocBUS.BuildID(maChiTietBaoCaoThuoc)
            chiTietBaoCaoThuoc.MaChiTietBaoCaoThuoc = maChiTietBaoCaoThuoc
            chiTietBaoCaoThuoc.Ngay = dateBaoCao
            chiTietBaoCaoThuoc.MaThuoc = row.Cells(1).Value

            Dim doubleNumber As Double =
            chiTietBaoCaoThuoc.TongSoLuong = row.Cells(3).Value
            chiTietBaoCaoThuoc.SoLanDung = row.Cells(4).Value
            chiTietBaoCaoThuoc.MaBaoCaoThuoc = tbMaBaoCao.Text

            ''2.Business


            ''3. Insert to DB
            chiTietBaoCaoThuocBUS.Insert(chiTietBaoCaoThuoc)
        Next

        'After save
        MessageBox.Show("Thêm báo cáo thuôc thành không.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim nextMaBaoCaoThuoc = String.Empty
        baoCaoThuocBUS.BuildID(nextMaBaoCaoThuoc)
        tbMaBaoCao.Text = nextMaBaoCaoThuoc
        dgvBaoCao.Rows.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class