<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLiDonVi
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLiDonVi))
        Me.dgvDonVi = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.tbMaDonVi = New System.Windows.Forms.TextBox()
        Me.lbMaDv = New System.Windows.Forms.Label()
        Me.tbDonVi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvDonVi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDonVi
        '
        Me.dgvDonVi.AllowUserToAddRows = False
        Me.dgvDonVi.AllowUserToDeleteRows = False
        Me.dgvDonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDonVi.Location = New System.Drawing.Point(273, 246)
        Me.dgvDonVi.MultiSelect = False
        Me.dgvDonVi.Name = "dgvDonVi"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDonVi.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDonVi.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDonVi.Size = New System.Drawing.Size(470, 242)
        Me.dgvDonVi.TabIndex = 73
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(778, 555)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 102)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Quản Lí " & Global.Microsoft.VisualBasic.ChrW(13) & "Đơn Vị"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btThoat)
        Me.Panel2.Controls.Add(Me.btCapNhat)
        Me.Panel2.Controls.Add(Me.btXoa)
        Me.Panel2.Controls.Add(Me.btThem)
        Me.Panel2.Controls.Add(Me.tbMaDonVi)
        Me.Panel2.Controls.Add(Me.lbMaDv)
        Me.Panel2.Controls.Add(Me.tbDonVi)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(273, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(470, 212)
        Me.Panel2.TabIndex = 74
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
        'tbMaDonVi
        '
        Me.tbMaDonVi.BackColor = System.Drawing.SystemColors.Control
        Me.tbMaDonVi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMaDonVi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMaDonVi.Location = New System.Drawing.Point(170, 33)
        Me.tbMaDonVi.Name = "tbMaDonVi"
        Me.tbMaDonVi.ReadOnly = True
        Me.tbMaDonVi.Size = New System.Drawing.Size(280, 29)
        Me.tbMaDonVi.TabIndex = 95
        '
        'lbMaDv
        '
        Me.lbMaDv.AutoSize = True
        Me.lbMaDv.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaDv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbMaDv.Location = New System.Drawing.Point(22, 34)
        Me.lbMaDv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaDv.Name = "lbMaDv"
        Me.lbMaDv.Size = New System.Drawing.Size(108, 28)
        Me.lbMaDv.TabIndex = 94
        Me.lbMaDv.Text = "Mã Đơn Vị:"
        '
        'tbDonVi
        '
        Me.tbDonVi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDonVi.Location = New System.Drawing.Point(170, 89)
        Me.tbDonVi.Name = "tbDonVi"
        Me.tbDonVi.Size = New System.Drawing.Size(280, 29)
        Me.tbDonVi.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 28)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Đơn Vị:"
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
        Me.Panel1.Size = New System.Drawing.Size(233, 554)
        Me.Panel1.TabIndex = 72
        '
        'frmQuanLiDonVi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 554)
        Me.Controls.Add(Me.dgvDonVi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuanLiDonVi"
        Me.Text = "frmQuanLiDonVi"
        CType(Me.dgvDonVi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDonVi As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btThoat As Button
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btThem As Button
    Friend WithEvents tbMaDonVi As TextBox
    Friend WithEvents lbMaDv As Label
    Friend WithEvents tbDonVi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
