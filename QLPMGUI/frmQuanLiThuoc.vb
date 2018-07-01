Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Imports System.Windows.Forms

Public Class frmQuanLiThuoc

    Private loaiBenhBUS As LoaiBenhBUS
    Private danhSachKhamBUS As DanhSachKhamBUS
    Private chiTietDanhSachBUS As ChiTietDanhSachBUS
    Private benhNhanBUS As BenhNhanBUS
    Private thuocBUS As ThuocBUS
    Private donViBUS As DonViBUS
    Private cachDungBUS As CachDungBUS
    Private phieuKhamBUS As PhieuKhamBUS
    Private chiTietPhieuKhamBUS As ChiTietPhieuKhamBUS
    Private lineNumber As Integer

    Private Sub frmQuanLiThuoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaiBenhBUS = New LoaiBenhBUS()
        danhSachKhamBUS = New DanhSachKhamBUS()
        chiTietDanhSachBUS = New ChiTietDanhSachBUS()
        benhNhanBUS = New BenhNhanBUS()
        thuocBUS = New ThuocBUS()
        donViBUS = New DonViBUS()
        cachDungBUS = New CachDungBUS()
        phieuKhamBUS = New PhieuKhamBUS()
        chiTietPhieuKhamBUS = New ChiTietPhieuKhamBUS()

#Region "Load DataGridView Thuoc"

        'Properties
        dgvThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'Contructing columns
        Dim clSTT = New DataGridViewTextBoxColumn()
        clSTT.Name = "stt"
        clSTT.HeaderText = "STT"
        clSTT.ReadOnly = True
        clSTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvThuoc.Columns.Add(clSTT)

        Dim clMaThuoc = New DataGridViewTextBoxColumn()
        clMaThuoc.Name = "MaCD"
        clMaThuoc.HeaderText = "Mã Thuốc"
        clMaThuoc.ReadOnly = True
        clMaThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvThuoc.Columns.Add(clMaThuoc)

        Dim clTenThuoc = New DataGridViewTextBoxColumn()
        clTenThuoc.Name = "TenThuoc"
        clTenThuoc.HeaderText = "Tên Thuốc"
        clTenThuoc.ReadOnly = True
        clTenThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvThuoc.Columns.Add(clTenThuoc)

        Dim clDV = New DataGridViewTextBoxColumn()
        clDV.Name = "DV"
        clDV.HeaderText = "Đơn Vị"
        clDV.ReadOnly = True
        clDV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvThuoc.Columns.Add(clDV)

        Dim clCachDung = New DataGridViewTextBoxColumn()
        clCachDung.Name = "CD"
        clCachDung.HeaderText = "Cách Dùng"
        clCachDung.ReadOnly = True
        clCachDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvThuoc.Columns.Add(clCachDung)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "DG"
        clDonGia.HeaderText = "Đơn Giá"
        clDonGia.ReadOnly = True
        clDonGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvThuoc.Columns.Add(clDonGia)

#End Region

        'Dim maCachDung = String.Empty
        'cachDungBUS.BuildID(maCachDung)
        'tbMaCD.Text = maCachDung

        LoadDataDataGridView()
    End Sub

    Public Sub LoadDataDataGridView()

        dgvThuoc.Rows.Clear()
        lineNumber = 0
        Dim allThuoc = New List(Of ThuocDTO)
        thuocBUS.SelectAll(allThuoc)

        Dim maThuoc = String.Empty
        Dim donVi = String.Empty
        Dim cachDung = String.Empty
        Dim donGia = String.Empty
        Dim tenThuoc = String.Empty

        For Each thuoc In allThuoc

            lineNumber = lineNumber + 1

            Dim allCachDung = New List(Of CachDungDTO)
            cachDungBUS.SelectAll(allCachDung)
            For Each cd As CachDungDTO In allCachDung
                If (cd.MaCachDung = thuoc.MaCachDung) Then
                    cachDung = cd.CachDung
                End If
            Next

            Dim allDonVi = New List(Of DonViDTO)
            donViBUS.SelectAll(allDonVi)
            For Each dv As DonViDTO In allDonVi
                If (dv.MaDonVi = thuoc.MaDonVi) Then
                    donVi = dv.DonVi
                End If
            Next

            tenThuoc = thuoc.TenThuoc
            donGia = thuoc.DonGia

            Dim row As String() = New String() {lineNumber, maThuoc, tenThuoc, donVi, cachDung, donGia}

            dgvThuoc.Rows.Add(row)

        Next

    End Sub

End Class