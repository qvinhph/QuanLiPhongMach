<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanLiThuoc
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLiThuoc))
        Me.dgvThuoc = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.lbMaTh = New System.Windows.Forms.Label()
        Me.lbCachDung = New System.Windows.Forms.Label()
        Me.cbDonVi = New System.Windows.Forms.ComboBox()
        Me.lbDonVi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCachDung = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.dgvThuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvThuoc
        '
        Me.dgvThuoc.AllowUserToAddRows = False
        Me.dgvThuoc.AllowUserToDeleteRows = False
        Me.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThuoc.Location = New System.Drawing.Point(248, 367)
        Me.dgvThuoc.MultiSelect = False
        Me.dgvThuoc.Name = "dgvThuoc"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvThuoc.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvThuoc.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvThuoc.Size = New System.Drawing.Size(579, 193)
        Me.dgvThuoc.TabIndex = 73
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(776, 627)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 71
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 572)
        Me.Panel1.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 102)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Quản Lí " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cách Dùng"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.cbCachDung)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lbMaTh)
        Me.Panel2.Controls.Add(Me.lbCachDung)
        Me.Panel2.Controls.Add(Me.cbDonVi)
        Me.Panel2.Controls.Add(Me.lbDonVi)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btThoat)
        Me.Panel2.Controls.Add(Me.btCapNhat)
        Me.Panel2.Controls.Add(Me.btXoa)
        Me.Panel2.Controls.Add(Me.btThem)
        Me.Panel2.Location = New System.Drawing.Point(248, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(579, 349)
        Me.Panel2.TabIndex = 74
        '
        'btThoat
        '
        Me.btThoat.BackgroundImage = CType(resources.GetObject("btThoat.BackgroundImage"), System.Drawing.Image)
        Me.btThoat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThoat.ForeColor = System.Drawing.SystemColors.Control
        Me.btThoat.Location = New System.Drawing.Point(414, 292)
        Me.btThoat.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(104, 40)
        Me.btThoat.TabIndex = 99
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'btCapNhat
        '
        Me.btCapNhat.BackgroundImage = CType(resources.GetObject("btCapNhat.BackgroundImage"), System.Drawing.Image)
        Me.btCapNhat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCapNhat.ForeColor = System.Drawing.SystemColors.Control
        Me.btCapNhat.Location = New System.Drawing.Point(227, 292)
        Me.btCapNhat.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(104, 40)
        Me.btCapNhat.TabIndex = 98
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.BackgroundImage = CType(resources.GetObject("btXoa.BackgroundImage"), System.Drawing.Image)
        Me.btXoa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoa.ForeColor = System.Drawing.SystemColors.Control
        Me.btXoa.Location = New System.Drawing.Point(133, 292)
        Me.btXoa.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(77, 40)
        Me.btXoa.TabIndex = 97
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btThem
        '
        Me.btThem.BackgroundImage = CType(resources.GetObject("btThem.BackgroundImage"), System.Drawing.Image)
        Me.btThem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThem.ForeColor = System.Drawing.SystemColors.Control
        Me.btThem.Location = New System.Drawing.Point(32, 292)
        Me.btThem.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(77, 40)
        Me.btThem.TabIndex = 96
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'lbMaTh
        '
        Me.lbMaTh.AutoSize = True
        Me.lbMaTh.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaTh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbMaTh.Location = New System.Drawing.Point(27, 64)
        Me.lbMaTh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaTh.Name = "lbMaTh"
        Me.lbMaTh.Size = New System.Drawing.Size(102, 28)
        Me.lbMaTh.TabIndex = 106
        Me.lbMaTh.Text = "Mã Thuốc:"
        '
        'lbCachDung
        '
        Me.lbCachDung.AutoSize = True
        Me.lbCachDung.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCachDung.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbCachDung.Location = New System.Drawing.Point(27, 180)
        Me.lbCachDung.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCachDung.Name = "lbCachDung"
        Me.lbCachDung.Size = New System.Drawing.Size(111, 28)
        Me.lbCachDung.TabIndex = 105
        Me.lbCachDung.Text = "Cách Dùng:"
        '
        'cbDonVi
        '
        Me.cbDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDonVi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDonVi.FormattingEnabled = True
        Me.cbDonVi.Location = New System.Drawing.Point(146, 132)
        Me.cbDonVi.Name = "cbDonVi"
        Me.cbDonVi.Size = New System.Drawing.Size(280, 29)
        Me.cbDonVi.TabIndex = 102
        '
        'lbDonVi
        '
        Me.lbDonVi.AutoSize = True
        Me.lbDonVi.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDonVi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbDonVi.Location = New System.Drawing.Point(27, 129)
        Me.lbDonVi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDonVi.Name = "lbDonVi"
        Me.lbDonVi.Size = New System.Drawing.Size(75, 28)
        Me.lbDonVi.TabIndex = 101
        Me.lbDonVi.Text = "Đơn Vị:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(27, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 28)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Thuốc:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 236)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 28)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Đơn Giá:"
        '
        'cbCachDung
        '
        Me.cbCachDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCachDung.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCachDung.FormattingEnabled = True
        Me.cbCachDung.Location = New System.Drawing.Point(146, 183)
        Me.cbCachDung.Name = "cbCachDung"
        Me.cbCachDung.Size = New System.Drawing.Size(280, 29)
        Me.cbCachDung.TabIndex = 110
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(146, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(280, 29)
        Me.TextBox2.TabIndex = 111
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(146, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 29)
        Me.TextBox1.TabIndex = 112
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(146, 239)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(280, 29)
        Me.TextBox3.TabIndex = 113
        '
        'frmQuanLiThuoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 572)
        Me.Controls.Add(Me.dgvThuoc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmQuanLiThuoc"
        Me.Text = "frmQuanLiThuoc"
        CType(Me.dgvThuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvThuoc As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btThoat As Button
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btThem As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cbCachDung As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbMaTh As Label
    Friend WithEvents lbCachDung As Label
    Friend WithEvents cbDonVi As ComboBox
    Friend WithEvents lbDonVi As Label
    Friend WithEvents Label3 As Label
End Class
