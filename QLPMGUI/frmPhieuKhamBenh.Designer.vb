<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhieuKhamBenh
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuKhamBenh))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnPhieuKham = New System.Windows.Forms.Panel()
        Me.themRow = New System.Windows.Forms.Button()
        Me.btKeThuoc = New System.Windows.Forms.Button()
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
        Me.pnThuoc = New System.Windows.Forms.Panel()
        Me.btPhieuKham = New System.Windows.Forms.Button()
        Me.dgvThuoc = New System.Windows.Forms.DataGridView()
        Me.clSTT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clThuoc = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.pnPhieuKham.SuspendLayout()
        Me.pnThuoc.SuspendLayout()
        CType(Me.dgvThuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'pnPhieuKham
        '
        Me.pnPhieuKham.Controls.Add(Me.themRow)
        Me.pnPhieuKham.Controls.Add(Me.btKeThuoc)
        Me.pnPhieuKham.Controls.Add(Me.cbLoaiBenh)
        Me.pnPhieuKham.Controls.Add(Me.tbDiaChi)
        Me.pnPhieuKham.Controls.Add(Me.lbDiaChi)
        Me.pnPhieuKham.Controls.Add(Me.tbNamSinh)
        Me.pnPhieuKham.Controls.Add(Me.tbGioiTinh)
        Me.pnPhieuKham.Controls.Add(Me.lbNamSinh)
        Me.pnPhieuKham.Controls.Add(Me.lbGioiTinh)
        Me.pnPhieuKham.Controls.Add(Me.cbBenhNhan)
        Me.pnPhieuKham.Controls.Add(Me.tbTrieuChung)
        Me.pnPhieuKham.Controls.Add(Me.lbNgayKham)
        Me.pnPhieuKham.Controls.Add(Me.lbLoaiBenh)
        Me.pnPhieuKham.Controls.Add(Me.lbTrieuChung)
        Me.pnPhieuKham.Controls.Add(Me.dtpNgayKham)
        Me.pnPhieuKham.Controls.Add(Me.lbBenhNhan)
        Me.pnPhieuKham.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnPhieuKham.Location = New System.Drawing.Point(239, 12)
        Me.pnPhieuKham.Name = "pnPhieuKham"
        Me.pnPhieuKham.Size = New System.Drawing.Size(549, 370)
        Me.pnPhieuKham.TabIndex = 62
        '
        'themRow
        '
        Me.themRow.BackgroundImage = CType(resources.GetObject("themRow.BackgroundImage"), System.Drawing.Image)
        Me.themRow.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.themRow.ForeColor = System.Drawing.SystemColors.Control
        Me.themRow.Location = New System.Drawing.Point(273, 320)
        Me.themRow.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.themRow.Name = "themRow"
        Me.themRow.Size = New System.Drawing.Size(110, 40)
        Me.themRow.TabIndex = 72
        Me.themRow.Text = "Thêm Cột"
        Me.themRow.UseVisualStyleBackColor = True
        '
        'btKeThuoc
        '
        Me.btKeThuoc.BackgroundImage = CType(resources.GetObject("btKeThuoc.BackgroundImage"), System.Drawing.Image)
        Me.btKeThuoc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKeThuoc.ForeColor = System.Drawing.SystemColors.Control
        Me.btKeThuoc.Location = New System.Drawing.Point(417, 320)
        Me.btKeThuoc.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btKeThuoc.Name = "btKeThuoc"
        Me.btKeThuoc.Size = New System.Drawing.Size(110, 40)
        Me.btKeThuoc.TabIndex = 71
        Me.btKeThuoc.Text = "Kê Thuốc"
        Me.btKeThuoc.UseVisualStyleBackColor = True
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
        'pnThuoc
        '
        Me.pnThuoc.Controls.Add(Me.btPhieuKham)
        Me.pnThuoc.Location = New System.Drawing.Point(239, 12)
        Me.pnThuoc.Name = "pnThuoc"
        Me.pnThuoc.Size = New System.Drawing.Size(549, 370)
        Me.pnThuoc.TabIndex = 63
        '
        'btPhieuKham
        '
        Me.btPhieuKham.BackgroundImage = CType(resources.GetObject("btPhieuKham.BackgroundImage"), System.Drawing.Image)
        Me.btPhieuKham.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPhieuKham.ForeColor = System.Drawing.SystemColors.Control
        Me.btPhieuKham.Location = New System.Drawing.Point(359, 320)
        Me.btPhieuKham.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btPhieuKham.Name = "btPhieuKham"
        Me.btPhieuKham.Size = New System.Drawing.Size(186, 40)
        Me.btPhieuKham.TabIndex = 72
        Me.btPhieuKham.Text = "Thông Tin Phiếu Khám"
        Me.btPhieuKham.UseVisualStyleBackColor = True
        '
        'dgvThuoc
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvThuoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThuoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clSTT, Me.clThuoc})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvThuoc.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvThuoc.GridColor = System.Drawing.SystemColors.Control
        Me.dgvThuoc.Location = New System.Drawing.Point(239, 388)
        Me.dgvThuoc.Name = "dgvThuoc"
        Me.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvThuoc.Size = New System.Drawing.Size(549, 296)
        Me.dgvThuoc.TabIndex = 64
        '
        'clSTT
        '
        Me.clSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clSTT.HeaderText = "STT"
        Me.clSTT.Name = "clSTT"
        Me.clSTT.ReadOnly = True
        Me.clSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.clSTT.Width = 58
        '
        'clThuoc
        '
        Me.clThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clThuoc.HeaderText = "Thuốc"
        Me.clThuoc.Name = "clThuoc"
        Me.clThuoc.Width = 135
        '
        'frmPhieuKhamBenh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(797, 696)
        Me.Controls.Add(Me.dgvThuoc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pnPhieuKham)
        Me.Controls.Add(Me.pnThuoc)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPhieuKhamBenh"
        Me.Text = "frmPhieuKhamBenh"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnPhieuKham.ResumeLayout(False)
        Me.pnPhieuKham.PerformLayout()
        Me.pnThuoc.ResumeLayout(False)
        CType(Me.dgvThuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents pnPhieuKham As Panel
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
    Friend WithEvents btKeThuoc As Button
    Friend WithEvents pnThuoc As Panel
    Friend WithEvents btPhieuKham As Button
    Friend WithEvents dgvThuoc As DataGridView
    Friend WithEvents themRow As Button
    Friend WithEvents clSTT As DataGridViewTextBoxColumn
    Friend WithEvents clThuoc As DataGridViewComboBoxColumn
End Class
