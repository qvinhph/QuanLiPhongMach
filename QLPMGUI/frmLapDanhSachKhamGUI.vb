Imports QLPMBUS
Imports QLPMDTO
Imports Utility

Public Class frmLapDanhSachKhamGUI

    Private dgBus As PhongmachBUS

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click

        Dim Benhnhan As PhongMachDTO
        Benhnhan = New PhongMachDTO()

        '1. Mapping data from GUI control
        Benhnhan.MSBN = txtMaSo.Text
        Benhnhan.HoTen = txtHoTen.Text
        Benhnhan.DiaChi = txtDiaChi.Text
        Benhnhan.NgaySinh = dtpNgaySinh.Value
        Benhnhan.Ngaylapthe = txtNgaylapthe.Text







        '2. Business .....
        If (dgBus.isValidName(Benhnhan) = False) Then
            MessageBox.Show("Họ tên độc giả không đúng")
            txtHoTen.Focus()
            Return
        End If



        ''3. Insert to DB
        'Dim result As Result
        'result = dgBus.insert(Benhnhan)
        'If (result.FlagResult = True) Then
        '    MessageBox.Show("Thêm độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Dim nextMsdg = "1"
        '    result = dgBus.buildMSDG(nextMsdg)
        '    If (result.FlagResult = False) Then
        '        MessageBox.Show("Lấy danh tự động mã độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Me.Close()
        '        Return
        '    End If
        '    txtMaSo.Text = nextMsdg
        '    txtDiaChi.Text = String.Empty
        '    txtHoTen.Text = String.Empty

        'Else
        '    MessageBox.Show("Thêm đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        'End If

    End Sub

    Private Sub frmLapDanhSachKhamGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Auto generate patient id
        dgBus = New PhongmachBUS()
        Dim result
        Dim nextMsdg = "1"
        result = dgBus.buildMSDG(nextMsdg)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tự động mã bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaSo.Text = nextMsdg

        '
        lvBenhNhan.Columns.Add("", 0)
        lvBenhNhan.Columns.Add("Họ Tên Bệnh Nhân", 150, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Mã số", 80, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Địa Chỉ", 140, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Giới Tính", 80, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Ngày Khám", 100, HorizontalAlignment.Center)



    End Sub
    Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs)
        Dim Benhnhan As PhongMachDTO
        Benhnhan = New PhongMachDTO()

        '1. Mapping data from GUI control
        Benhnhan.MSBN = txtMaSo.Text
        Benhnhan.HoTen = txtHoTen.Text
        Benhnhan.DiaChi = txtDiaChi.Text
        Benhnhan.NgaySinh = dtpNgaySinh.Value
        Benhnhan.Ngaylapthe = txtNgaylapthe.Text


        '2. Business .....
        If (dgBus.isValidName(Benhnhan) = False) Then
            MessageBox.Show("Họ tên độc giả không đúng")
            txtHoTen.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(Benhnhan)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub txtDiaChi_TextChanged(sender As Object, e As EventArgs) Handles txtDiaChi.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtMaSo_TextChanged(sender As Object, e As EventArgs) Handles txtMaSo.TextChanged

    End Sub

    Private Sub cbLop_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbGioitinh_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNgaylapthe_Click(sender As Object, e As EventArgs) Handles txtNgaylapthe.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Label11_Click_1(sender As Object, e As EventArgs) Handles Label11.Click
        Application.Exit()
    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNguoilap_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpNgaySinh_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgaySinh.ValueChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub lvBenhNhan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvBenhNhan.SelectedIndexChanged

    End Sub
End Class