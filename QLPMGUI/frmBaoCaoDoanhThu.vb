Public Class frmBaoCaoDoanhThu
    Private Sub frmBaoCaoDoanhThuGUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.CustomFormat = " MM,yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom

    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class