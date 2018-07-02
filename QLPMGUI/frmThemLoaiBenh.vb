Imports QLPMBUS
Imports QLPMDTO
Imports Utility


Public Class frmThemLoaiBenh

    Private loaibenhBUS As LoaiBenhBUS

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub frmThemLoaiBenh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaibenhBUS = New LoaiBenhBUS()

        ' Get Next ID
        Dim nextID As String = String.Empty
        Dim result As Result = New Result
        result = loaibenhBUS.BuildID(nextID)
        If (result.FlagResult = True) Then
            txtMaSo.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loại bệnh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim loaiBenh As LoaiBenhDTO
        loaiBenh = New LoaiBenhDTO()

        '1. Mapping data from GUI control
        loaiBenh.MaLoaiBenh = txtMaSo.Text
        loaiBenh.LoaiBenh = txtTenLoai.Text

        '2. Business .....
        If (loaibenhBUS.IsValidName(loaiBenh) = False) Then
            MessageBox.Show("Tên Loại bệnh không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = loaibenhBUS.Insert(loaiBenh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại bệnh thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenLoai.Text = String.Empty

            ' Get Next ID
            Dim nextID As String = String.Empty
            result = loaibenhBUS.BuildID(nextID)
            If (result.FlagResult = True) Then
                txtMaSo.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Loại bệnh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm loại bệnh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnThemVaDong_Click(sender As Object, e As EventArgs) Handles btnThemVaDong.Click
        btnThem_Click(sender, e)
        Me.Close()
    End Sub
End Class