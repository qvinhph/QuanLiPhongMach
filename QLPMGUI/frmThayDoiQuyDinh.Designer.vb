<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThayDoiQuyDinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThayDoiQuyDinh))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbTienKham = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCapNhatThamSo = New System.Windows.Forms.Button()
        Me.tbSoLuongMax = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCapNhatLoaiBenh = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.tbTenLoaiBenh = New System.Windows.Forms.TextBox()
        Me.tbMaLoaiBenh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvLoaiBenh = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvLoaiBenh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbTienKham)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnCapNhatThamSo)
        Me.Panel2.Controls.Add(Me.tbSoLuongMax)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(274, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 142)
        Me.Panel2.TabIndex = 72
        '
        'tbTienKham
        '
        Me.tbTienKham.Location = New System.Drawing.Point(322, 55)
        Me.tbTienKham.Name = "tbTienKham"
        Me.tbTienKham.Size = New System.Drawing.Size(100, 20)
        Me.tbTienKham.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 30)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Tiền khám:"
        '
        'btnCapNhatThamSo
        '
        Me.btnCapNhatThamSo.BackgroundImage = CType(resources.GetObject("btnCapNhatThamSo.BackgroundImage"), System.Drawing.Image)
        Me.btnCapNhatThamSo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhatThamSo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCapNhatThamSo.Location = New System.Drawing.Point(338, 96)
        Me.btnCapNhatThamSo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCapNhatThamSo.Name = "btnCapNhatThamSo"
        Me.btnCapNhatThamSo.Size = New System.Drawing.Size(95, 40)
        Me.btnCapNhatThamSo.TabIndex = 55
        Me.btnCapNhatThamSo.Text = "Cập nhật"
        Me.btnCapNhatThamSo.UseVisualStyleBackColor = True
        '
        'tbSoLuongMax
        '
        Me.tbSoLuongMax.Location = New System.Drawing.Point(395, 16)
        Me.tbSoLuongMax.Name = "tbSoLuongMax"
        Me.tbSoLuongMax.Size = New System.Drawing.Size(27, 20)
        Me.tbSoLuongMax.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(372, 30)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Số lượng bệnh nhân tối đa trong ngày:"
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
        Me.Panel1.Size = New System.Drawing.Size(268, 660)
        Me.Panel1.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 102)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Thay Đổi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quy Định" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(645, 567)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 69
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(771, -1)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 30)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "x"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnCapNhatLoaiBenh)
        Me.Panel3.Controls.Add(Me.btXoa)
        Me.Panel3.Controls.Add(Me.tbTenLoaiBenh)
        Me.Panel3.Controls.Add(Me.tbMaLoaiBenh)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.dgvLoaiBenh)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(274, 160)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(499, 190)
        Me.Panel3.TabIndex = 73
        '
        'btnCapNhatLoaiBenh
        '
        Me.btnCapNhatLoaiBenh.BackgroundImage = CType(resources.GetObject("btnCapNhatLoaiBenh.BackgroundImage"), System.Drawing.Image)
        Me.btnCapNhatLoaiBenh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhatLoaiBenh.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCapNhatLoaiBenh.Location = New System.Drawing.Point(349, 124)
        Me.btnCapNhatLoaiBenh.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCapNhatLoaiBenh.Name = "btnCapNhatLoaiBenh"
        Me.btnCapNhatLoaiBenh.Size = New System.Drawing.Size(95, 40)
        Me.btnCapNhatLoaiBenh.TabIndex = 60
        Me.btnCapNhatLoaiBenh.Text = "Cập nhật"
        Me.btnCapNhatLoaiBenh.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.BackgroundImage = CType(resources.GetObject("btXoa.BackgroundImage"), System.Drawing.Image)
        Me.btXoa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoa.ForeColor = System.Drawing.SystemColors.Control
        Me.btXoa.Location = New System.Drawing.Point(251, 124)
        Me.btXoa.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(66, 40)
        Me.btXoa.TabIndex = 58
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'tbTenLoaiBenh
        '
        Me.tbTenLoaiBenh.Location = New System.Drawing.Point(256, 95)
        Me.tbTenLoaiBenh.Name = "tbTenLoaiBenh"
        Me.tbTenLoaiBenh.Size = New System.Drawing.Size(188, 20)
        Me.tbTenLoaiBenh.TabIndex = 59
        '
        'tbMaLoaiBenh
        '
        Me.tbMaLoaiBenh.Location = New System.Drawing.Point(256, 34)
        Me.tbMaLoaiBenh.Name = "tbMaLoaiBenh"
        Me.tbMaLoaiBenh.Size = New System.Drawing.Size(188, 20)
        Me.tbMaLoaiBenh.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(251, 67)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tên Loại Bệnh:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(251, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Mã Loại Bệnh:"
        '
        'dgvLoaiBenh
        '
        Me.dgvLoaiBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoaiBenh.Location = New System.Drawing.Point(9, 33)
        Me.dgvLoaiBenh.Name = "dgvLoaiBenh"
        Me.dgvLoaiBenh.Size = New System.Drawing.Size(224, 144)
        Me.dgvLoaiBenh.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 30)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Loại Bệnh:"
        '
        'frmThayDoiQuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 660)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmThayDoiQuyDinh"
        Me.Text = "frmThayDoiQuyDinh"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvLoaiBenh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbSoLuongMax As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCapNhatThamSo As Button
    Friend WithEvents tbTienKham As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvLoaiBenh As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTenLoaiBenh As TextBox
    Friend WithEvents tbMaLoaiBenh As TextBox
    Friend WithEvents btnCapNhatLoaiBenh As Button
    Friend WithEvents btXoa As Button
End Class
