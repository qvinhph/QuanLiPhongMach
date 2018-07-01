Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Imports System.Windows.Forms

Public Class frmQuanLiCachDung

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

    Private Sub frmQuanLiCachDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        dgvCD.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'Contructing columns
        Dim clSTT = New DataGridViewTextBoxColumn()
        clSTT.Name = "stt"
        clSTT.HeaderText = "STT"
        clSTT.ReadOnly = True
        clSTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCD.Columns.Add(clSTT)

        Dim clMaCD = New DataGridViewTextBoxColumn()
        clMaCD.Name = "MaCD"
        clMaCD.HeaderText = "Mã Cách Dùng"
        clMaCD.ReadOnly = True
        clMaCD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCD.Columns.Add(clMaCD)

        Dim clTenCD = New DataGridViewTextBoxColumn()
        clTenCD.Name = "TenCD"
        clTenCD.HeaderText = "Tên Cách Dùng"
        clTenCD.ReadOnly = True
        clTenCD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCD.Columns.Add(clTenCD)

#End Region

        Dim maCachDung = String.Empty
        cachDungBUS.BuildID(maCachDung)
        tbMaCD.Text = maCachDung

        LoadDataDataGridView()

    End Sub

    Public Sub LoadDataDataGridView()

        dgvCD.Rows.Clear()
        lineNumber = 0
        Dim allCachDung = New List(Of CachDungDTO)
        cachDungBUS.SelectAll(allCachDung)

        For Each cd In allCachDung

            lineNumber = lineNumber + 1
            Dim row As String() = New String() {lineNumber, cd.MaCachDung, cd.CachDung}

            dgvCD.Rows.Add(row)

        Next

    End Sub

    Private Sub dgvCD_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCD.CellClick

        Dim maCachDung As String = String.Empty
        Dim cachDung As String = String.Empty

        'Get selected cell value
        If (e.RowIndex > -1 And e.RowIndex < dgvCD.Rows.Count) Then
            maCachDung = dgvCD.Rows(e.RowIndex).Cells(1).Value
            cachDung = dgvCD.Rows(e.RowIndex).Cells(2).Value
        End If

        'Load to textbox
        tbMaCD.Text = maCachDung
        tbTenCachDung.Text = cachDung
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click

        If (tbTenCachDung.Text = "") Then
            Return
        End If

        Dim cachDung = New CachDungDTO()
        cachDung.MaCachDung = String.Empty 'Insert tu them
        cachDung.CachDung = tbTenCachDung.Text

        cachDungBUS.Insert(cachDung)

        LoadDataDataGridView()

    End Sub


    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click

        Dim maCachDung = tbMaCD.Text

        cachDungBUS.Delete(maCachDung)

        LoadDataDataGridView()

    End Sub


    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click

        If (tbTenCachDung.Text = "") Then
            Return
        End If

        Dim cachDung = New CachDungDTO()
        cachDung.MaCachDung = tbMaCD.Text
        cachDung.CachDung = tbTenCachDung.Text

        Dim result = New Result
        result = cachDungBUS.Update(cachDung)
        If (result.FlagResult = False) Then
            Console.WriteLine("sasdasd")
        End If

        LoadDataDataGridView()

    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub
End Class