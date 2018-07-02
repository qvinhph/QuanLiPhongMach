Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Imports System.Windows.Forms

Public Class frmQuanLiDonVi

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

    Private Sub frmQuanLiDonVi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaiBenhBUS = New LoaiBenhBUS()
        danhSachKhamBUS = New DanhSachKhamBUS()
        chiTietDanhSachBUS = New ChiTietDanhSachBUS()
        benhNhanBUS = New BenhNhanBUS()
        thuocBUS = New ThuocBUS()
        donViBUS = New DonViBUS()
        cachDungBUS = New CachDungBUS()
        phieuKhamBUS = New PhieuKhamBUS()
        chiTietPhieuKhamBUS = New ChiTietPhieuKhamBUS()

#Region "Load DataGridView DonVi"

        'Properties
        dgvDonVi.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'Contructing columns
        Dim clSTT = New DataGridViewTextBoxColumn()
        clSTT.Name = "stt"
        clSTT.HeaderText = "STT"
        clSTT.ReadOnly = True
        clSTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvDonVi.Columns.Add(clSTT)

        Dim clMaDV = New DataGridViewTextBoxColumn()
        clMaDV.Name = "MaDonVi"
        clMaDV.HeaderText = "Mã Đơn Vị"
        clMaDV.ReadOnly = True
        clMaDV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvDonVi.Columns.Add(clMaDV)

        Dim clDonVi = New DataGridViewTextBoxColumn()
        clDonVi.Name = "DonVi"
        clDonVi.HeaderText = "Tên Đơn Vị"
        clDonVi.ReadOnly = True
        clDonVi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvDonVi.Columns.Add(clDonVi)

#End Region

        Dim maDonVi = String.Empty
        donViBUS.BuildID(maDonVi)
        tbMaDonVi.Text = maDonVi

        LoadDataDataGridView()

    End Sub

    Public Sub LoadDataDataGridView()

        dgvDonVi.Rows.Clear()
        lineNumber = 0
        Dim allDonVi = New List(Of DonViDTO)
        donViBUS.SelectAll(allDonVi)

        For Each dv In allDonVi

            lineNumber = lineNumber + 1
            Dim row As String() = New String() {lineNumber, dv.MaDonVi, dv.DonVi}

            dgvDonVi.Rows.Add(row)

        Next

    End Sub

    Private Sub dgvDonVi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDonVi.CellClick

        Dim maDonVi As String = String.Empty
        Dim donVi As String = String.Empty

        'Get selected cell value
        If (e.RowIndex > -1 And e.RowIndex < dgvDonVi.Rows.Count) Then
            maDonVi = dgvDonVi.Rows(e.RowIndex).Cells(1).Value
            donVi = dgvDonVi.Rows(e.RowIndex).Cells(2).Value
        End If

        'Load to textbox
        tbMaDonVi.Text = maDonVi
        tbDonVi.Text = donVi
    End Sub
    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click

        If (tbDonVi.Text = "") Then
            Return
        End If

        Dim donvi = New DonViDTO()
        donvi.MaDonVi = String.Empty 'Insert tu them
        donvi.DonVi = tbDonVi.Text

        donViBUS.Insert(donvi)

        LoadDataDataGridView()

    End Sub


    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click

        Dim maDonVi = tbMaDonVi.Text

        donViBUS.Delete(maDonVi)

        LoadDataDataGridView()

    End Sub


    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click

        If (tbDonVi.Text = "") Then
            Return
        End If

        Dim donVi = New DonViDTO()
        donVi.MaDonVi = tbMaDonVi.Text
        donVi.DonVi = tbDonVi.Text

        Dim result = New Result
        result = donViBUS.Update(donVi)
        If (result.FlagResult = False) Then
            Console.WriteLine("Cập nhật đơn vị không thành công")
        End If

        LoadDataDataGridView()

    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class