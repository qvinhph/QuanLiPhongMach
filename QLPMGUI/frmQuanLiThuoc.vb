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

        'Load list cach dung to combobox
        Dim allCachDung = New List(Of CachDungDTO)
        cachDungBUS.SelectAll(allCachDung)
        cbCachDung.DataSource = New BindingSource(allCachDung, String.Empty)
        cbCachDung.DisplayMember = "CachDung"
        cbCachDung.ValueMember = "MaCachDung"

        'Load list don vi to combobox
        Dim allDonVi = New List(Of DonViDTO)
        donViBUS.SelectAll(allDonVi)
        cbDonVi.DataSource = New BindingSource(allDonVi, String.Empty)
        cbDonVi.DisplayMember = "DonVi"
        cbDonVi.ValueMember = "MaDonVi"

        Dim maThuoc
        thuocBUS.BuildID(maThuoc)
        tbMaThuoc.Text = maThuoc

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

            maThuoc = thuoc.MaThuoc
            tenThuoc = thuoc.TenThuoc
            donGia = thuoc.DonGia

            Dim row As String() = New String() {lineNumber, maThuoc, tenThuoc, donVi, cachDung, donGia}

            dgvThuoc.Rows.Add(row)

        Next

    End Sub

    Private Sub dgvThuoc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThuoc.CellClick

        Dim maThuoc = String.Empty
        Dim donVi = String.Empty
        Dim cachDung = String.Empty
        Dim donGia = String.Empty
        Dim tenThuoc = String.Empty

        'Get selected cell value
        If (e.RowIndex > -1 And e.RowIndex < dgvThuoc.Rows.Count) Then
            maThuoc = dgvThuoc.Rows(e.RowIndex).Cells(1).Value
            tenThuoc = dgvThuoc.Rows(e.RowIndex).Cells(2).Value
            cachDung = dgvThuoc.Rows(e.RowIndex).Cells(4).Value
            donVi = dgvThuoc.Rows(e.RowIndex).Cells(3).Value
            donGia = dgvThuoc.Rows(e.RowIndex).Cells(5).Value
        End If

        'Load to textbox
        tbDonGia.Text = donGia
        tbMaThuoc.Text = maThuoc
        tbThuoc.Text = tenThuoc

        Dim allDonVi = New List(Of DonViDTO)
        donViBUS.SelectAll(allDonVi)
        Dim selectedMaDV = String.Empty

        Dim allCachDung = New List(Of CachDungDTO)
        cachDungBUS.SelectAll(allCachDung)
        Dim selectedMaCD = String.Empty

        For Each dv In allDonVi
            If (dv.DonVi = donVi) Then
                selectedMaDV = dv.MaDonVi
            End If
        Next

        For Each cd In allCachDung
            If (cd.CachDung = cachDung) Then
                selectedMaCD = cd.MaCachDung
            End If
        Next

        cbDonVi.SelectedValue = selectedMaDV
        cbCachDung.SelectedValue = selectedMaCD

    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click

        If (tbThuoc.Text = "" Or tbDonGia.Text = Nothing) Then
            Return
        End If

        Dim thuoc = New ThuocDTO()
        thuoc.MaThuoc = String.Empty 'Insert tu them
        thuoc.TenThuoc = tbThuoc.Text
        Dim donGiaDoule As Double = 0
        Double.TryParse(tbDonGia.Text, donGiaDoule)
        thuoc.DonGia = donGiaDoule
        thuoc.MaDonVi = CType(cbDonVi.SelectedItem, DonViDTO).MaDonVi
        thuoc.MaCachDung = CType(cbCachDung.SelectedItem, CachDungDTO).MaCachDung

        thuocBUS.Insert(thuoc)

        LoadDataDataGridView()

    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click

        Dim maThuoc = tbMaThuoc.Text

        thuocBUS.Delete(maThuoc)

        LoadDataDataGridView()

    End Sub

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click

        If (tbThuoc.Text = "" Or tbDonGia.Text = Nothing) Then
            Return
        End If

        Dim thuoc = New ThuocDTO()
        thuoc.MaThuoc = tbMaThuoc.Text 'Insert tu them
        thuoc.TenThuoc = tbThuoc.Text
        Dim donGiaDoule As Double = 0
        Double.TryParse(tbDonGia.Text, donGiaDoule)
        thuoc.DonGia = donGiaDoule
        thuoc.MaDonVi = CType(cbDonVi.SelectedItem, DonViDTO).MaDonVi
        thuoc.MaCachDung = CType(cbCachDung.SelectedItem, CachDungDTO).MaCachDung

        thuocBUS.Update(thuoc)

        LoadDataDataGridView()

    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class