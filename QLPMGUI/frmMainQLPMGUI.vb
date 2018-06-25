
Imports System.Configuration

Public Class frmMain

    Private ConnectionString As String

    Private Sub ThêmHọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmHọcSinhToolStripMenuItem.Click
        Dim frmhs As frmLapDanhSachKhamGUI = New frmLapDanhSachKhamGUI()
        frmhs.MdiParent = Me
        frmhs.Show()
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
End Class
