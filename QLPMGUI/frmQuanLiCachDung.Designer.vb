<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLiCachDung
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLiCachDung))
        Me.dgvCD = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.tbMaCD = New System.Windows.Forms.TextBox()
        Me.lbMaTh = New System.Windows.Forms.Label()
        Me.tbTenCachDung = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvCD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCD
        '
        Me.dgvCD.AllowUserToAddRows = False
        Me.dgvCD.AllowUserToDeleteRows = False
        Me.dgvCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCD.Location = New System.Drawing.Point(251, 259)
        Me.dgvCD.MultiSelect = False
        Me.dgvCD.Name = "dgvCD"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCD.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCD.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCD.Size = New System.Drawing.Size(470, 242)
        Me.dgvCD.TabIndex = 69
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(756, 568)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 66
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 515)
        Me.Panel1.TabIndex = 67
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btThoat)
        Me.Panel2.Controls.Add(Me.btCapNhat)
        Me.Panel2.Controls.Add(Me.btXoa)
        Me.Panel2.Controls.Add(Me.btThem)
        Me.Panel2.Controls.Add(Me.tbMaCD)
        Me.Panel2.Controls.Add(Me.lbMaTh)
        Me.Panel2.Controls.Add(Me.tbTenCachDung)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(251, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(470, 212)
        Me.Panel2.TabIndex = 70
        '
        'btThoat
        '
        Me.btThoat.BackgroundImage = CType(resources.GetObject("btThoat.BackgroundImage"), System.Drawing.Image)
        Me.btThoat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThoat.ForeColor = System.Drawing.SystemColors.Control
        Me.btThoat.Location = New System.Drawing.Point(358, 148)
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
        Me.btCapNhat.Location = New System.Drawing.Point(223, 148)
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
        Me.btXoa.Location = New System.Drawing.Point(129, 148)
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
        Me.btThem.Location = New System.Drawing.Point(28, 148)
        Me.btThem.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(77, 40)
        Me.btThem.TabIndex = 96
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'tbMaCD
        '
        Me.tbMaCD.BackColor = System.Drawing.SystemColors.Control
        Me.tbMaCD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMaCD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMaCD.Location = New System.Drawing.Point(170, 33)
        Me.tbMaCD.Name = "tbMaCD"
        Me.tbMaCD.ReadOnly = True
        Me.tbMaCD.Size = New System.Drawing.Size(280, 29)
        Me.tbMaCD.TabIndex = 95
        '
        'lbMaTh
        '
        Me.lbMaTh.AutoSize = True
        Me.lbMaTh.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaTh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbMaTh.Location = New System.Drawing.Point(22, 34)
        Me.lbMaTh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaTh.Name = "lbMaTh"
        Me.lbMaTh.Size = New System.Drawing.Size(144, 28)
        Me.lbMaTh.TabIndex = 94
        Me.lbMaTh.Text = "Mã Cách Dùng:"
        '
        'tbTenCachDung
        '
        Me.tbTenCachDung.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTenCachDung.Location = New System.Drawing.Point(170, 89)
        Me.tbTenCachDung.Name = "tbTenCachDung"
        Me.tbTenCachDung.Size = New System.Drawing.Size(280, 29)
        Me.tbTenCachDung.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 28)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Tên Cách Dùng:"
        '
        'frmQuanLiCachDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 515)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvCD)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmQuanLiCachDung"
        Me.Text = "frmQuanLiLoaiBenh"
        CType(Me.dgvCD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCD As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTenCachDung As TextBox
    Friend WithEvents tbMaCD As TextBox
    Friend WithEvents lbMaTh As Label
    Friend WithEvents btThoat As Button
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btThem As Button
End Class
