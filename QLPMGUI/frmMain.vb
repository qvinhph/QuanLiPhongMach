
Imports System.Configuration

Public Class frmMain

    Private ConnectionString As String

    Private Sub LapDSKhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapDSKham.Click
        Dim frmLapDSKham As frmLapDanhSachKham = New frmLapDanhSachKham()
        frmLapDSKham.Show()
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Read ConnectionString value from App.config file
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")


    End Sub



    Private Sub HồSơHọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HồSơHọcSinhToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub TraCứuBệnhNhânToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraCứuBệnhNhânToolStripMenuItem.Click
        Dim frmTraCuuBenhNhan As frmTraCuuBenhNhan = New frmTraCuuBenhNhan()
        frmTraCuuBenhNhan.Show()
    End Sub

    Private Sub PhiếuKhámBệnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuKhámBệnhToolStripMenuItem.Click
        Dim frmPhieuKhamBenh As frmPhieuKhamBenh = New frmPhieuKhamBenh()
        frmPhieuKhamBenh.Show()
    End Sub

    Private Sub LậpHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpHóaĐơnToolStripMenuItem.Click
        Dim frmLapHoaDon As frmLapHoaDon = New frmLapHoaDon()
        frmLapHoaDon.Show()
    End Sub

    Private Sub ThêmLoạiBệnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiBệnhToolStripMenuItem.Click
        Dim frmThemLoaiBenh As frmThemLoaiBenh = New frmThemLoaiBenh()
        frmThemLoaiBenh.Show()
    End Sub

    Private Sub ThayĐổiQuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThayĐổiQuyĐịnhToolStripMenuItem.Click
        Dim frmThayDoiQuyDinh As frmThayDoiQuyDinh = New frmThayDoiQuyDinh()
        frmThayDoiQuyDinh.Show()
    End Sub

    Private Sub BáoCáoDoanhThuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoDoanhThuToolStripMenuItem.Click
        Dim frmBaoCaoDT As frmBaoCaoDoanhThu = New frmBaoCaoDoanhThu()
        frmLapHoaDon.Show()
    End Sub

    Private Sub BáoCáoSửDụngThuốcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoSửDụngThuốcToolStripMenuItem.Click
        Dim frmBaoCaoSDT As frmBaoCaoSuDungThuoc = New frmBaoCaoSuDungThuoc()
        frmBaoCaoSDT.Show()
    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
