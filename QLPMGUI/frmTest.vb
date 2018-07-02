Imports QLPMDAL

Public Class frmTest
    Private donViDAL As DonViDAL = New DonViDAL()

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbMaDonvi.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nextID = Nothing
        Dim result = donViDAL.BuildID(nextID)
        lbMaDonvi.Text = nextID
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lapdskham As frmLapDanhSachKham = New frmLapDanhSachKham()
        lapdskham.Show()
    End Sub

    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim lapdskham As frmPhieuKhamBenh = New frmPhieuKhamBenh()
        lapdskham.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim tracuubenhnhan As frmTraCuuBenhNhan = New frmTraCuuBenhNhan()
        tracuubenhnhan.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim hoadonfrm As frmLapHoaDon = New frmLapHoaDon()
        hoadonfrm.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim baocaongay As frmBaoCaoDoanhThu = New frmBaoCaoDoanhThu()
        baocaongay.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim aaaa As frmBaoCaoSuDungThuoc = New frmBaoCaoSuDungThuoc()
        aaaa.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim zzz As frmThayDoiQuyDinh = New frmThayDoiQuyDinh()
        zzz.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim cachdung As frmQuanLiCachDung = New frmQuanLiCachDung()
        cachdung.Show()
    End Sub

    Private Sub Button11aaa_Click(sender As Object, e As EventArgs) Handles Button11aaa.Click
        Dim cachdung As frmQuanLiThuoc = New frmQuanLiThuoc()
        cachdung.Show()
    End Sub
End Class