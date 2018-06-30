Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Public Class frmThayDoiQuyDinh

    Private thamSoBUS As ThamSoBUS
    Private thamSo As ThamSoDTO

    Private Sub frmThayDoiQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        thamSoBUS = New ThamSoBUS()
        Dim result As Result
        result = thamSoBUS.GetThamSoOnDB(thamSo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tham số thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        tbSoLuongMax.Text = thamSo.SoBenhNhanToiDa

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbSoLuongMax.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Close()
    End Sub
End Class