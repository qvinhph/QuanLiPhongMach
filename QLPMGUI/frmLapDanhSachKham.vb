Imports QLPMBUS
Imports QLPMDTO
Imports Utility

Public Class frmLapDanhSachKham

    Private bnBus As BenhNhanBUS
    Dim List_BenhNhan As New List(Of BenhNhanDTO)
    Dim List_Items_Added As New List(Of ListViewItem)
    Private thamSoBUS As ThamSoBUS
    Private thamSo As ThamSoDTO
    Private danhSachKhamBUS As DanhSachKhamBUS
    Private ctdsKhamBUS As ChiTietDanhSachBUS

    'Temp Variable
    Dim countadded As Integer
    Dim bnTemp


    Private Sub frmLapDanhSachKhamGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'init
        danhSachKhamBUS = New DanhSachKhamBUS()
        ctdsKhamBUS = New ChiTietDanhSachBUS()

        countadded = 0
        dtpNgayKham.Value = Date.Today()
        thamSoBUS = New ThamSoBUS()
        thamSoBUS.GetThamSoOnDB(thamSo)

        lbSoLuongBnTrongNgay.Text = thamSo.SoBenhNhanToiDa


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
        CreateListView()



    End Sub

#Region "Load listview data"
    Private Sub CreateListView()
        lvBenhNhan.Columns.Add("Họ Tên Bệnh Nhân", 100, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Mã số", 80, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Địa Chỉ", 130, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Ngày Sinh", 100, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Giới Tính", 70, HorizontalAlignment.Center)
        lvBenhNhan.Columns.Add("Ngày Khám", 100, HorizontalAlignment.Center)
    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click

        Dim Benhnhan As BenhNhanDTO
        Benhnhan = New BenhNhanDTO()



        '1. Mapping data from GUI control
        Benhnhan.MaBenhNhan = txtMaSo.Text
        Benhnhan.HoTen = txtHoTen.Text
        Benhnhan.DiaChi = txtDiaChi.Text
        Benhnhan.NgaySinh = dtpNgaySinh.Value
        Benhnhan.GioiTinh = cbGioitinh.Text

        '2. Business .....
        If (bnBus.IsValidName(Benhnhan) = False) Then
            MessageBox.Show("Họ tên bệnh nhân không đúng")
            txtHoTen.Focus()
            Return
        End If

        lbSoLuongBnTrongNgay.Text = lbSoLuongBnTrongNgay.Text - 1




        '3. Insert to Listview
        countadded = countadded + 1
        Dim lvItem As ListViewItem

        lvItem = lvBenhNhan.Items.Add(txtHoTen.Text)
        lvItem.SubItems.Add(txtMaSo.Text)
        lvItem.SubItems.Add(txtDiaChi.Text)
        lvItem.SubItems.Add(dtpNgaySinh.Value)
        lvItem.SubItems.Add(cbGioitinh.Text)
        lvItem.SubItems.Add(dtpNgayKham.Value)

        'List manage
        List_BenhNhan.Add(Benhnhan)
        List_Items_Added.Add(lvItem)



        '4. Auto generate next patient id


        Dim currentNumberID = Integer.Parse(txtMaSo.Text.Substring(2, 6))
        Dim nextNumberID = currentNumberID + 1
        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
        txtMaSo.Text = "BN" + strNextNumberID
        MessageBox.Show("Đã thêm một bệnh nhân!")

        'Some item properties
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
#End Region


    'Exit button and save before close form
    Private Sub Label11_Click_1(sender As Object, e As EventArgs) Handles Label11.Click
        If countadded = 0 Then
            Me.Close()
        Else
            Dim Answer As DialogResult = MessageBox.Show("Bạn chưa lưu, bạn có muốn lưu trước khi thoát không", "Data Check", MessageBoxButtons.YesNoCancel)
            Select Case Answer
                Case DialogResult.Yes
                    Button2_Click(sender, e)
                    Me.Close()
                Case DialogResult.No

                    Me.Close()
                Case DialogResult.Cancel
                    Exit Sub
                Case Else
                    Exit Sub
            End Select
        End If
    End Sub

    'Update button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim index As ListViewItem
        index = lvBenhNhan.SelectedItems(0)
        index.Text = txtHoTen.Text
        index.SubItems.Item(1).Text = txtMaSo.Text
        index.SubItems.Item(2).Text = txtDiaChi.Text
        index.SubItems.Item(3).Text = dtpNgaySinh.Value
        index.SubItems.Item(4).Text = cbGioitinh.Text
        index.SubItems.Item(5).Text = dtpNgayKham.Value

        Dim currentNumberID = Integer.Parse(txtMaSo.Text.Substring(2, 6)) + countadded
        Dim nextNumberID = currentNumberID + 1
        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
        txtMaSo.Text = "BN" + strNextNumberID
        MessageBox.Show("Đã cập nhật thông tin một bệnh nhân!")
        txtHoTen.Focus()
        txtHoTen.Clear()
        txtDiaChi.Clear()
        cbGioitinh.SelectedIndex = 0

        Button1.Visible = False

    End Sub

    'Handle update function
    Private Sub lvBenhNhan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvBenhNhan.SelectedIndexChanged
        If lvBenhNhan.SelectedItems.Count > 0 Then
            bnTemp = lvBenhNhan.SelectedIndices(0)
            txtMaSo.Text = List_BenhNhan(bnTemp).MaBenhNhan
            txtHoTen.Text = List_BenhNhan(bnTemp).HoTen
            txtDiaChi.Text = List_BenhNhan(bnTemp).DiaChi
            dtpNgaySinh.Value = List_BenhNhan(bnTemp).NgaySinh
            cbGioitinh.Text = List_BenhNhan(bnTemp).GioiTinh

            Button4.Visible = True
            Button1.Visible = True

            bnTemp = vbNull
        End If


        'txtHoTen.Text = List_BenhNhan(bnTemp).HoTen
        'txtDiaChi.Text = List_BenhNhan(bnTemp).DiaChi

        'cbGioitinh.Text = List_BenhNhan(bnTemp).GioiTinh
        'dtpNgayKham.Value = List_BenhNhan(bnTemp).NgayKham
        'dtpNgaySinh.Value = List_BenhNhan(bnTemp).NgaySinh



    End Sub

    'Exit button 2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label11_Click_1(sender, e)
    End Sub

    'Add button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (countadded = 0) Then
            MessageBox.Show("Chưa có bệnh nhân trong danh sách")

        Else
            'Neu danh sach kham ngay hom do chua tao
            Dim currentDanhSachKham = New DanhSachKhamDTO()
            danhSachKhamBUS.Select_ByNgayKham(dtpNgayKham.Value, currentDanhSachKham)
            If (currentDanhSachKham.MaDanhSach = Nothing) Then
                Dim danhSach = New DanhSachKhamDTO()
                Dim maDanhSach = String.Empty
                danhSachKhamBUS.BuildID(maDanhSach)
                danhSach.MaDanhSach = maDanhSach
                danhSach.NgayKham = dtpNgayKham.Value
                danhSachKhamBUS.Insert(danhSach)

                currentDanhSachKham = danhSach
            End If

            For Each benhnhan In List_BenhNhan

                Dim result As Result
                result = bnBus.Insert(benhnhan)
                If (result.FlagResult = True) Then

                    Dim nextMsbn = "1"
                    result = bnBus.BuildID(nextMsbn)
                    If (result.FlagResult = False) Then
                        MessageBox.Show("Lấy danh tự động mã bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                        Return
                    End If
                    'ThemChiTietDanhSachBUS
                    Dim ctds = New ChiTietDanhSachDTO()
                    ctds.MaDanhSach = currentDanhSachKham.MaDanhSach
                    ctds.MaBenhNhan = benhnhan.MaBenhNhan

                    ctdsKhamBUS.Insert(ctds)

                Else
                    MessageBox.Show("Thêm bệnh nhân không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If

            Next
            List_BenhNhan.Clear()
            MessageBox.Show("Thêm " & countadded & " bệnh nhân thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countadded = 0

            For Each lvItem In List_Items_Added
                lvItem.Remove()
            Next

        End If


    End Sub

    'Delete button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If countadded = 0 Then
            MessageBox.Show("Không thể xóa vì danh sách chưa có bệnh nhân nào")
        ElseIf lvBenhNhan.SelectedItems.Count = 0 Then
            MessageBox.Show("Bạn chưa chọn bệnh nhân để xóa")

        Else
            lvBenhNhan.Items.RemoveAt(lvBenhNhan.SelectedIndices(0))
            MessageBox.Show("Đã xóa một bệnh nhân")
            countadded = countadded - 1
        End If
    End Sub

    Private Sub dtpNgayKham_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayKham.ValueChanged
        thamSoBUS = New ThamSoBUS()
        thamSoBUS.GetThamSoOnDB(thamSo)

        lbSoLuongBnTrongNgay.Text = thamSo.SoBenhNhanToiDa
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub
End Class