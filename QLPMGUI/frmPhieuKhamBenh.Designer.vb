<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuKhamBenh
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuKhamBenh))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbLoaiBenh = New System.Windows.Forms.ComboBox()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.tbNamSinh = New System.Windows.Forms.TextBox()
        Me.tbGioiTinh = New System.Windows.Forms.TextBox()
        Me.lbNamSinh = New System.Windows.Forms.Label()
        Me.lbGioiTinh = New System.Windows.Forms.Label()
        Me.cbBenhNhan = New System.Windows.Forms.ComboBox()
        Me.tbTrieuChung = New System.Windows.Forms.TextBox()
        Me.lbNgayKham = New System.Windows.Forms.Label()
        Me.lbLoaiBenh = New System.Windows.Forms.Label()
        Me.lbTrieuChung = New System.Windows.Forms.Label()
        Me.dtpNgayKham = New System.Windows.Forms.DateTimePicker()
        Me.lbBenhNhan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(417, 320)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 40)
        Me.Button3.TabIndex = 56
        Me.Button3.Text = "Thoát"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 479)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 102)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Danh Sách" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thuốc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(210, 102)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Thông Tin " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Phiếu Khám" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 696)
        Me.Panel1.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(622, 568)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 59
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbLoaiBenh)
        Me.Panel2.Controls.Add(Me.tbDiaChi)
        Me.Panel2.Controls.Add(Me.lbDiaChi)
        Me.Panel2.Controls.Add(Me.tbNamSinh)
        Me.Panel2.Controls.Add(Me.tbGioiTinh)
        Me.Panel2.Controls.Add(Me.lbNamSinh)
        Me.Panel2.Controls.Add(Me.lbGioiTinh)
        Me.Panel2.Controls.Add(Me.cbBenhNhan)
        Me.Panel2.Controls.Add(Me.tbTrieuChung)
        Me.Panel2.Controls.Add(Me.lbNgayKham)
        Me.Panel2.Controls.Add(Me.lbLoaiBenh)
        Me.Panel2.Controls.Add(Me.lbTrieuChung)
        Me.Panel2.Controls.Add(Me.dtpNgayKham)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.lbBenhNhan)
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(239, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 370)
        Me.Panel2.TabIndex = 62
        '
        'cbLoaiBenh
        '
        Me.cbLoaiBenh.FormattingEnabled = True
        Me.cbLoaiBenh.Location = New System.Drawing.Point(203, 283)
        Me.cbLoaiBenh.Name = "cbLoaiBenh"
        Me.cbLoaiBenh.Size = New System.Drawing.Size(324, 28)
        Me.cbLoaiBenh.TabIndex = 70
        '
        'tbDiaChi
        '
        Me.tbDiaChi.BackColor = System.Drawing.SystemColors.Control
        Me.tbDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDiaChi.Location = New System.Drawing.Point(203, 166)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.ReadOnly = True
        Me.tbDiaChi.Size = New System.Drawing.Size(324, 27)
        Me.tbDiaChi.TabIndex = 69
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiaChi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbDiaChi.Location = New System.Drawing.Point(84, 162)
        Me.lbDiaChi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(78, 28)
        Me.lbDiaChi.TabIndex = 68
        Me.lbDiaChi.Text = "Địa Chỉ:"
        '
        'tbNamSinh
        '
        Me.tbNamSinh.BackColor = System.Drawing.SystemColors.Control
        Me.tbNamSinh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNamSinh.Location = New System.Drawing.Point(441, 113)
        Me.tbNamSinh.Name = "tbNamSinh"
        Me.tbNamSinh.ReadOnly = True
        Me.tbNamSinh.Size = New System.Drawing.Size(86, 27)
        Me.tbNamSinh.TabIndex = 67
        '
        'tbGioiTinh
        '
        Me.tbGioiTinh.BackColor = System.Drawing.SystemColors.Control
        Me.tbGioiTinh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbGioiTinh.Location = New System.Drawing.Point(203, 113)
        Me.tbGioiTinh.Name = "tbGioiTinh"
        Me.tbGioiTinh.ReadOnly = True
        Me.tbGioiTinh.Size = New System.Drawing.Size(80, 27)
        Me.tbGioiTinh.TabIndex = 66
        '
        'lbNamSinh
        '
        Me.lbNamSinh.AutoSize = True
        Me.lbNamSinh.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNamSinh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbNamSinh.Location = New System.Drawing.Point(333, 113)
        Me.lbNamSinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNamSinh.Name = "lbNamSinh"
        Me.lbNamSinh.Size = New System.Drawing.Size(101, 28)
        Me.lbNamSinh.TabIndex = 65
        Me.lbNamSinh.Text = "Năm Sinh:"
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbGioiTinh.Location = New System.Drawing.Point(84, 113)
        Me.lbGioiTinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(94, 28)
        Me.lbGioiTinh.TabIndex = 64
        Me.lbGioiTinh.Text = "Giới Tính:"
        '
        'cbBenhNhan
        '
        Me.cbBenhNhan.FormattingEnabled = True
        Me.cbBenhNhan.Location = New System.Drawing.Point(203, 68)
        Me.cbBenhNhan.Name = "cbBenhNhan"
        Me.cbBenhNhan.Size = New System.Drawing.Size(324, 28)
        Me.cbBenhNhan.TabIndex = 63
        '
        'tbTrieuChung
        '
        Me.tbTrieuChung.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTrieuChung.Location = New System.Drawing.Point(203, 215)
        Me.tbTrieuChung.Multiline = True
        Me.tbTrieuChung.Name = "tbTrieuChung"
        Me.tbTrieuChung.Size = New System.Drawing.Size(324, 50)
        Me.tbTrieuChung.TabIndex = 62
        '
        'lbNgayKham
        '
        Me.lbNgayKham.AutoSize = True
        Me.lbNgayKham.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNgayKham.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbNgayKham.Location = New System.Drawing.Point(13, 21)
        Me.lbNgayKham.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgayKham.Name = "lbNgayKham"
        Me.lbNgayKham.Size = New System.Drawing.Size(118, 28)
        Me.lbNgayKham.TabIndex = 61
        Me.lbNgayKham.Text = "Ngày Khám:"
        '
        'lbLoaiBenh
        '
        Me.lbLoaiBenh.AutoSize = True
        Me.lbLoaiBenh.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLoaiBenh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbLoaiBenh.Location = New System.Drawing.Point(13, 283)
        Me.lbLoaiBenh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLoaiBenh.Name = "lbLoaiBenh"
        Me.lbLoaiBenh.Size = New System.Drawing.Size(183, 28)
        Me.lbLoaiBenh.TabIndex = 59
        Me.lbLoaiBenh.Text = "Dự Đoán Loại Bệnh:"
        '
        'lbTrieuChung
        '
        Me.lbTrieuChung.AutoSize = True
        Me.lbTrieuChung.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTrieuChung.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbTrieuChung.Location = New System.Drawing.Point(13, 211)
        Me.lbTrieuChung.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTrieuChung.Name = "lbTrieuChung"
        Me.lbTrieuChung.Size = New System.Drawing.Size(120, 28)
        Me.lbTrieuChung.TabIndex = 58
        Me.lbTrieuChung.Text = "Triệu Chứng:"
        '
        'dtpNgayKham
        '
        Me.dtpNgayKham.CustomFormat = "dd - MM - yyyy"
        Me.dtpNgayKham.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayKham.Location = New System.Drawing.Point(203, 23)
        Me.dtpNgayKham.Name = "dtpNgayKham"
        Me.dtpNgayKham.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpNgayKham.Size = New System.Drawing.Size(324, 27)
        Me.dtpNgayKham.TabIndex = 57
        '
        'lbBenhNhan
        '
        Me.lbBenhNhan.AutoSize = True
        Me.lbBenhNhan.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBenhNhan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbBenhNhan.Location = New System.Drawing.Point(13, 64)
        Me.lbBenhNhan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbBenhNhan.Name = "lbBenhNhan"
        Me.lbBenhNhan.Size = New System.Drawing.Size(111, 28)
        Me.lbBenhNhan.TabIndex = 0
        Me.lbBenhNhan.Text = "Bệnh Nhân:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(439, 479)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 28)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Dự Đoán Loại Bệnh:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(285, 426)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(399, 210)
        Me.TabControl1.TabIndex = 72
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(391, 184)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(391, 184)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmPhieuKhamBenh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(800, 696)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPhieuKhamBenh"
        Me.Text = "frmPhieuKhamBenh"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbBenhNhan As Label
    Friend WithEvents lbLoaiBenh As Label
    Friend WithEvents lbTrieuChung As Label
    Friend WithEvents dtpNgayKham As DateTimePicker
    Friend WithEvents lbNgayKham As Label
    Friend WithEvents tbTrieuChung As TextBox
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents tbNamSinh As TextBox
    Friend WithEvents tbGioiTinh As TextBox
    Friend WithEvents lbNamSinh As Label
    Friend WithEvents lbGioiTinh As Label
    Friend WithEvents cbBenhNhan As ComboBox
    Friend WithEvents cbLoaiBenh As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
