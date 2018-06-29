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
End Class