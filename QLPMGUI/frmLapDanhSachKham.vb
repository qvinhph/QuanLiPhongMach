Imports QLPMBUS
Imports QLPMDTO
Imports Utility

Public Class frmLapDanhSachKham

    Private bnBus As BenhNhanBUS
    Dim List_BenhNhan As New List(Of BenhnhanDTO)
    Dim List_Items_Added As New List(Of ListViewItem)

    Dim count As Integer

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click

        Dim Benhnhan As BenhnhanDTO
        Benhnhan = New BenhnhanDTO()

        '1. Mapping data from GUI control
        Benhnhan.MSBN = txtMaSo.Text
        Benhnhan.HoTen = txtHoTen.Text
        Benhnhan.DiaChi = txtDiaChi.Text
        Benhnhan.NgaySinh = dtpNgaySinh.Value
        Benhnhan.NgayKham = dtpNgayKham.Text
        Benhnhan.Gioitinh = cbGioitinh.Text

        '2. Business .....
        If (bnBus.IsValidName(Benhnhan) = False) Then
            MessageBox.Show("Họ tên bệnh nhân không đúng")
            txtHoTen.Focus()
            Return
        End If



        '3. Insert to Listview

        count = count + 1
        Dim lvItem As ListViewItem
        CreateListView()
        lvItem = lvBenhNhan.Items.Add(txtHoTen.Text)
        lvItem.SubItems.Add(txtMaSo.Text)
        lvItem.SubItems.Add(txtDiaChi.Text)
        lvItem.SubItems.Add(dtpNgaySinh.Value)
        lvItem.SubItems.Add(cbGioitinh.Text)
        lvItem.SubItems.Add(dtpNgayKham.Value)

        List_BenhNhan.Add(Benhnhan)
        List_Items_Added.Add(lvItem)



        '4. Auto generate next patient id


        Dim currentNumberID = Integer.Parse(txtMaSo.Text.Substring(2, 6))
        Dim nextNumberID = currentNumberID + 1
        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
        txtMaSo.Text = "BN" + strNextNumberID
        MessageBox.Show("Đã thêm một bệnh nhân!")
        txtHoTen.Focus()
        txtHoTen.Clear()
        txtDiaChi.Clear()
        cbGioitinh.SelectedIndex = 0

        Button2.Visible = True







        'Dim result As Result
        'result = bnBus.Insert(Benhnhan)
        'If (result.FlagResult = True) Then
        '    MessageBox.Show("Thêm độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Dim nextMsbn = "1"
        '    result = bnBus.BuildID(nextMsbn)
        '    If (result.FlagResult = False) Then
        '        MessageBox.Show("Lấy danh tự động mã độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Me.Close()
        '        Return
        '    End If
        '    txtMaSo.Text = nextMsbn
        '    txtDiaChi.Text = String.Empty
        '    txtHoTen.Text = String.Empty

        'Else
        '    MessageBox.Show("Thêm đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        'End If

    End Sub

    Private Sub CreateListView()
        lvBenhNhan.Columns.Add("Họ Tên Bệnh Nhân", 60, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Mã số", 50, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Địa Chỉ", 130, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Ngày Sinh", 100, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Giới Tính", 70, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Ngày Khám", 100, HorizontalAlignment.Center)
    End Sub
    Private Sub frmLapDanhSachKhamGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        count = 0

        dtpNgayKham.Value = Date.Today()

        'Auto generate patient id
        bnBus = New BenhNhanBUS()
        Dim result
        Dim nextMsbn = "1"
        result = bnBus.BuildID(nextMsbn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tự động mã bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaSo.Text = nextMsbn

        '




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

    Private Sub txtNgaylapthe_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Label11_Click_1(sender As Object, e As EventArgs) Handles Label11.Click
        If count = 0 Then
            Application.Exit()
        Else
            Dim Answer As DialogResult = MessageBox.Show("Bạn chưa lưu, bạn có muốn lưu trước khi thoát không", "Data Check", MessageBoxButtons.YesNoCancel)
            Select Case Answer
                Case DialogResult.Yes
                    Button2_Click(sender, e)
                    Application.Exit()
                Case DialogResult.No
                    Application.Exit()
                Case DialogResult.Cancel
                    Exit Sub
                Case Else
                    Exit Sub
            End Select
        End If
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


        Dim bnTemp As Integer
        bnTemp = lvBenhNhan.SelectedIndices(0)

        txtHoTen.Text = List_BenhNhan(bnTemp).HoTen
        txtDiaChi.Text = List_BenhNhan(bnTemp).DiaChi
        txtMaSo.Text = List_BenhNhan(bnTemp).MSBN
        cbGioitinh.Text = List_BenhNhan(bnTemp).Gioitinh
        dtpNgayKham.Value = List_BenhNhan(bnTemp).NgayKham
        dtpNgaySinh.Value = List_BenhNhan(bnTemp).NgaySinh

        lvBenhNhan.Items.RemoveAt(bnTemp)


    End Sub

    Private Sub lvBenhNhan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvBenhNhan.SelectedIndexChanged
        Button4.Visible = True
        Button1.Visible = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label11_Click_1(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim countadded As Integer
        countadded = 0
        For Each benhnhan In List_BenhNhan

            Dim result As Result
            result = bnBus.Insert(benhnhan)
            If (result.FlagResult = True) Then
                countadded = countadded + 1

                Dim nextMsbn = "1"
                result = bnBus.BuildID(nextMsbn)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Lấy danh tự động mã bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Return
                End If

            Else
                MessageBox.Show("Thêm bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Next
        List_BenhNhan.Clear()
        MessageBox.Show("Thêm " & countadded & " bệnh nhân thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        count = 0

        For Each lvItem In List_Items_Added
            lvItem.Remove()
        Next


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If count = 0 Then
            MessageBox.Show("Không thể xóa vì danh sách chưa có bệnh nhân nào")
        ElseIf lvBenhNhan.SelectedItems.Count = 0 Then
            MessageBox.Show("Bạn chưa chọn bệnh nhân để xóa")

        Else
            lvBenhNhan.Items.RemoveAt(lvBenhNhan.SelectedIndices(0))
            MessageBox.Show("Đã xóa một bệnh nhân")
            count = count - 1
        End If
    End Sub
End Class