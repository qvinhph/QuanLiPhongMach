<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoCaoDoanhThu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaoCaoDoanhThu))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvBaoCao = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbMaBaoCao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpNgayKham = New System.Windows.Forms.DateTimePicker()
        Me.lbThang = New System.Windows.Forms.Label()
        Me.btnLuuBaoCao = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbTongBenhNhan = New System.Windows.Forms.Label()
        Me.lbTongDoanhThu = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(34, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 153)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Báo Cáo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Doanh Thu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Theo Ngày" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.Panel1.Size = New System.Drawing.Size(268, 707)
        Me.Panel1.TabIndex = 65
        '
        'dgvBaoCao
        '
        Me.dgvBaoCao.AllowUserToAddRows = False
        Me.dgvBaoCao.AllowUserToDeleteRows = False
        Me.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCao.Location = New System.Drawing.Point(274, 189)
        Me.dgvBaoCao.Name = "dgvBaoCao"
        Me.dgvBaoCao.Size = New System.Drawing.Size(553, 343)
        Me.dgvBaoCao.TabIndex = 76
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.tbMaBaoCao)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.dtpNgayKham)
        Me.Panel2.Controls.Add(Me.lbThang)
        Me.Panel2.Controls.Add(Me.btnLuuBaoCao)
        Me.Panel2.Location = New System.Drawing.Point(274, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(539, 159)
        Me.Panel2.TabIndex = 75
        '
        'tbMaBaoCao
        '
        Me.tbMaBaoCao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMaBaoCao.Location = New System.Drawing.Point(156, 19)
        Me.tbMaBaoCao.Name = "tbMaBaoCao"
        Me.tbMaBaoCao.ReadOnly = True
        Me.tbMaBaoCao.Size = New System.Drawing.Size(309, 29)
        Me.tbMaBaoCao.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 28)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Mã Báo Cáo:"
        '
        'dtpNgayKham
        '
        Me.dtpNgayKham.CustomFormat = "MM / yyyy"
        Me.dtpNgayKham.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayKham.Location = New System.Drawing.Point(156, 58)
        Me.dtpNgayKham.Name = "dtpNgayKham"
        Me.dtpNgayKham.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpNgayKham.Size = New System.Drawing.Size(309, 29)
        Me.dtpNgayKham.TabIndex = 96
        '
        'lbThang
        '
        Me.lbThang.AutoSize = True
        Me.lbThang.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbThang.Location = New System.Drawing.Point(21, 58)
        Me.lbThang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbThang.Name = "lbThang"
        Me.lbThang.Size = New System.Drawing.Size(70, 28)
        Me.lbThang.TabIndex = 18
        Me.lbThang.Text = "Tháng:"
        '
        'btnLuuBaoCao
        '
        Me.btnLuuBaoCao.BackgroundImage = CType(resources.GetObject("btnLuuBaoCao.BackgroundImage"), System.Drawing.Image)
        Me.btnLuuBaoCao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuuBaoCao.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLuuBaoCao.Location = New System.Drawing.Point(26, 108)
        Me.btnLuuBaoCao.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLuuBaoCao.Name = "btnLuuBaoCao"
        Me.btnLuuBaoCao.Size = New System.Drawing.Size(111, 40)
        Me.btnLuuBaoCao.TabIndex = 7
        Me.btnLuuBaoCao.Text = "Lưu Báo Cáo"
        Me.btnLuuBaoCao.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(295, 568)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 28)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Tổng Bệnh Nhân:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(295, 621)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 28)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Tổng Danh Thu:"
        '
        'lbTongBenhNhan
        '
        Me.lbTongBenhNhan.AutoSize = True
        Me.lbTongBenhNhan.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTongBenhNhan.ForeColor = System.Drawing.Color.Maroon
        Me.lbTongBenhNhan.Location = New System.Drawing.Point(493, 568)
        Me.lbTongBenhNhan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTongBenhNhan.Name = "lbTongBenhNhan"
        Me.lbTongBenhNhan.Size = New System.Drawing.Size(24, 30)
        Me.lbTongBenhNhan.TabIndex = 102
        Me.lbTongBenhNhan.Text = "0"
        '
        'lbTongDoanhThu
        '
        Me.lbTongDoanhThu.AutoSize = True
        Me.lbTongDoanhThu.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTongDoanhThu.ForeColor = System.Drawing.Color.Maroon
        Me.lbTongDoanhThu.Location = New System.Drawing.Point(493, 621)
        Me.lbTongDoanhThu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTongDoanhThu.Name = "lbTongDoanhThu"
        Me.lbTongDoanhThu.Size = New System.Drawing.Size(24, 30)
        Me.lbTongDoanhThu.TabIndex = 103
        Me.lbTongDoanhThu.Text = "0"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(355, 108)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 40)
        Me.Button3.TabIndex = 99
        Me.Button3.Text = "Thoát"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmBaoCaoDoanhThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 707)
        Me.Controls.Add(Me.lbTongDoanhThu)
        Me.Controls.Add(Me.lbTongBenhNhan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvBaoCao)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBaoCaoDoanhThu"
        Me.Text = "frmBaoCaoDoanhThuGUI"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvBaoCao As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbMaBaoCao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpNgayKham As DateTimePicker
    Friend WithEvents lbThang As Label
    Friend WithEvents btnLuuBaoCao As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTongBenhNhan As Label
    Friend WithEvents lbTongDoanhThu As Label
    Friend WithEvents Button3 As Button
End Class
