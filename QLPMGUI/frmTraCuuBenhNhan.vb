Imports QLPMBUS
Imports QLPMDTO
Imports Utility
Public Class frmTraCuuBenhNhan
    Private bnbus As BenhNhanBUS
    Private loaiBenhBUS As LoaiBenhBUS
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click

    End Sub

    Private Sub frmTraCuuBenhNhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bnbus = New BenhNhanBUS()
        loaiBenhBUS = New LoaiBenhBUS()

        ' Load LoaiBenh list
        Dim listLoaiBenh = New List(Of LoaiBenhDTO)
        Dim result As Result
        result = loaiBenhBUS.SelectAll(listLoaiBenh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại bệnh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbLoaiBenh.DataSource = New BindingSource(listLoaiBenh, String.Empty)
        'cbLoaiBenh.ValueMember = "ma_loai_benh"
        'cbLoaiBenh.ValueMember = "loai_benh"
        cbLoaiBenh.DisplayMember = "LoaiBenh"
        cbLoaiBenh.ValueMember = "MaLoaiBenh"
    End Sub

    Private Sub cbTrieuChung_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLoaiBenh.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class