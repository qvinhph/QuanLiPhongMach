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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabPageThongTin = New System.Windows.Forms.TabPage()
        Me.tbMaPhieuKham = New System.Windows.Forms.TextBox()
        Me.lbMaPK = New System.Windows.Forms.Label()
        Me.tbMaBenhNhan = New System.Windows.Forms.TextBox()
        Me.lbMaBenhNhan = New System.Windows.Forms.Label()
        Me.btLamLai = New System.Windows.Forms.Button()
        Me.btLapPhieu = New System.Windows.Forms.Button()
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
        Me.tabPageThuoc = New System.Windows.Forms.TabPage()
        Me.tbMaThuoc = New System.Windows.Forms.TextBox()
        Me.lbMaTh = New System.Windows.Forms.Label()
        Me.btTTPhieuKham = New System.Windows.Forms.Button()
        Me.btCapNhatThuoc = New System.Windows.Forms.Button()
        Me.btXoaThuoc = New System.Windows.Forms.Button()
        Me.btThemThuoc = New System.Windows.Forms.Button()
        Me.tbSoLuong = New System.Windows.Forms.TextBox()
        Me.lbCachDung = New System.Windows.Forms.Label()
        Me.tbCachDung = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbDonVi = New System.Windows.Forms.TextBox()
        Me.cbThuoc = New System.Windows.Forms.ComboBox()
        Me.lbDonVi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvThuoc = New System.Windows.Forms.DataGridView()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tabPageThongTin.SuspendLayout()
        Me.tabPageThuoc.SuspendLayout()
        CType(Me.dgvThuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 538)
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
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabPageThongTin)
        Me.tabControl.Controls.Add(Me.tabPageThuoc)
        Me.tabControl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.Location = New System.Drawing.Point(239, 12)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(546, 502)
        Me.tabControl.TabIndex = 64
        '
        'tabPageThongTin
        '
        Me.tabPageThongTin.Controls.Add(Me.btnThoat)
        Me.tabPageThongTin.Controls.Add(Me.tbMaPhieuKham)
        Me.tabPageThongTin.Controls.Add(Me.lbMaPK)
        Me.tabPageThongTin.Controls.Add(Me.tbMaBenhNhan)
        Me.tabPageThongTin.Controls.Add(Me.lbMaBenhNhan)
        Me.tabPageThongTin.Controls.Add(Me.btLamLai)
        Me.tabPageThongTin.Controls.Add(Me.btLapPhieu)
        Me.tabPageThongTin.Controls.Add(Me.btKeThuoc)
        Me.tabPageThongTin.Controls.Add(Me.cbLoaiBenh)
        Me.tabPageThongTin.Controls.Add(Me.tbDiaChi)
        Me.tabPageThongTin.Controls.Add(Me.lbDiaChi)
        Me.tabPageThongTin.Controls.Add(Me.tbNamSinh)
        Me.tabPageThongTin.Controls.Add(Me.tbGioiTinh)
        Me.tabPageThongTin.Controls.Add(Me.lbNamSinh)
        Me.tabPageThongTin.Controls.Add(Me.lbGioiTinh)
        Me.tabPageThongTin.Controls.Add(Me.cbBenhNhan)
        Me.tabPageThongTin.Controls.Add(Me.tbTrieuChung)
        Me.tabPageThongTin.Controls.Add(Me.lbNgayKham)
        Me.tabPageThongTin.Controls.Add(Me.lbLoaiBenh)
        Me.tabPageThongTin.Controls.Add(Me.lbTrieuChung)
        Me.tabPageThongTin.Controls.Add(Me.dtpNgayKham)
        Me.tabPageThongTin.Controls.Add(Me.lbBenhNhan)
        Me.tabPageThongTin.Location = New System.Drawing.Point(4, 30)
        Me.tabPageThongTin.Name = "tabPageThongTin"
        Me.tabPageThongTin.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageThongTin.Size = New System.Drawing.Size(538, 468)
        Me.tabPageThongTin.TabIndex = 0
        Me.tabPageThongTin.Text = "Thông Tin Phiếu"
        Me.tabPageThongTin.UseVisualStyleBackColor = True
        '
        'tbMaPhieuKham
        '
        Me.tbMaPhieuKham.BackColor = System.Drawing.SystemColors.Control
        Me.tbMaPhieuKham.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMaPhieuKham.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMaPhieuKham.Location = New System.Drawing.Point(209, 19)
        Me.tbMaPhieuKham.Name = "tbMaPhieuKham"
        Me.tbMaPhieuKham.ReadOnly = True
        Me.tbMaPhieuKham.Size = New System.Drawing.Size(323, 29)
        Me.tbMaPhieuKham.TabIndex = 93
        '
        'lbMaPK
        '
        Me.lbMaPK.AutoSize = True
        Me.lbMaPK.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaPK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbMaPK.Location = New System.Drawing.Point(23, 19)
        Me.lbMaPK.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaPK.Name = "lbMaPK"
        Me.lbMaPK.Size = New System.Drawing.Size(152, 28)
        Me.lbMaPK.TabIndex = 92
        Me.lbMaPK.Text = "Mã Phiếu Khám:"
        '
        'tbMaBenhNhan
        '
        Me.tbMaBenhNhan.BackColor = System.Drawing.SystemColors.Control
        Me.tbMaBenhNhan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMaBenhNhan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMaBenhNhan.Location = New System.Drawing.Point(211, 155)
        Me.tbMaBenhNhan.Name = "tbMaBenhNhan"
        Me.tbMaBenhNhan.ReadOnly = True
        Me.tbMaBenhNhan.Size = New System.Drawing.Size(323, 29)
        Me.tbMaBenhNhan.TabIndex = 91
        '
        'lbMaBenhNhan
        '
        Me.lbMaBenhNhan.AutoSize = True
        Me.lbMaBenhNhan.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaBenhNhan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbMaBenhNhan.Location = New System.Drawing.Point(60, 155)
        Me.lbMaBenhNhan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaBenhNhan.Name = "lbMaBenhNhan"
        Me.lbMaBenhNhan.Size = New System.Drawing.Size(144, 28)
        Me.lbMaBenhNhan.TabIndex = 90
        Me.lbMaBenhNhan.Text = "Mã Bệnh Nhân:"
        '
        'btLamLai
        '
        Me.btLamLai.BackgroundImage = CType(resources.GetObject("btLamLai.BackgroundImage"), System.Drawing.Image)
        Me.btLamLai.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLamLai.ForeColor = System.Drawing.SystemColors.Control
        Me.btLamLai.Location = New System.Drawing.Point(163, 418)
        Me.btLamLai.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btLamLai.Name = "btLamLai"
        Me.btLamLai.Size = New System.Drawing.Size(94, 40)
        Me.btLamLai.TabIndex = 89
        Me.btLamLai.Text = "Làm Lại"
        Me.btLamLai.UseVisualStyleBackColor = True
        '
        'btLapPhieu
        '
        Me.btLapPhieu.BackgroundImage = CType(resources.GetObject("btLapPhieu.BackgroundImage"), System.Drawing.Image)
        Me.btLapPhieu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLapPhieu.ForeColor = System.Drawing.SystemColors.Control
        Me.btLapPhieu.Location = New System.Drawing.Point(26, 418)
        Me.btLapPhieu.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btLapPhieu.Name = "btLapPhieu"
        Me.btLapPhieu.Size = New System.Drawing.Size(106, 40)
        Me.btLapPhieu.TabIndex = 88
        Me.btLapPhieu.Text = "Lập Phiếu"
        Me.btLapPhieu.UseVisualStyleBackColor = True
        '
        'btKeThuoc
        '
        Me.btKeThuoc.BackgroundImage = CType(resources.GetObject("btKeThuoc.BackgroundImage"), System.Drawing.Image)
        Me.btKeThuoc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKeThuoc.ForeColor = System.Drawing.SystemColors.Control
        Me.btKeThuoc.Location = New System.Drawing.Point(424, 418)
        Me.btKeThuoc.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btKeThuoc.Name = "btKeThuoc"
        Me.btKeThuoc.Size = New System.Drawing.Size(110, 40)
        Me.btKeThuoc.TabIndex = 87
        Me.btKeThuoc.Text = "Kê Thuốc"
        Me.btKeThuoc.UseVisualStyleBackColor = True
        '
        'cbLoaiBenh
        '
        Me.cbLoaiBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoaiBenh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoaiBenh.FormattingEnabled = True
        Me.cbLoaiBenh.Location = New System.Drawing.Point(211, 380)
        Me.cbLoaiBenh.Name = "cbLoaiBenh"
        Me.cbLoaiBenh.Size = New System.Drawing.Size(324, 29)
        Me.cbLoaiBenh.TabIndex = 86
        '
        'tbDiaChi
        '
        Me.tbDiaChi.BackColor = System.Drawing.SystemColors.Control
        Me.tbDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDiaChi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDiaChi.Location = New System.Drawing.Point(211, 260)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.ReadOnly = True
        Me.tbDiaChi.Size = New System.Drawing.Size(324, 29)
        Me.tbDiaChi.TabIndex = 85
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiaChi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbDiaChi.Location = New System.Drawing.Point(60, 256)
        Me.lbDiaChi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(78, 28)
        Me.lbDiaChi.TabIndex = 84
        Me.lbDiaChi.Text = "Địa Chỉ:"
        '
        'tbNamSinh
        '
        Me.tbNamSinh.BackColor = System.Drawing.SystemColors.Control
        Me.tbNamSinh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNamSinh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamSinh.Location = New System.Drawing.Point(423, 206)
        Me.tbNamSinh.Name = "tbNamSinh"
        Me.tbNamSinh.ReadOnly = True
        Me.tbNamSinh.Size = New System.Drawing.Size(111, 29)
        Me.tbNamSinh.TabIndex = 83
        '
        'tbGioiTinh
        '
        Me.tbGioiTinh.BackColor = System.Drawing.SystemColors.Control
        Me.tbGioiTinh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbGioiTinh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGioiTinh.Location = New System.Drawing.Point(211, 207)
        Me.tbGioiTinh.Name = "tbGioiTinh"
        Me.tbGioiTinh.ReadOnly = True
        Me.tbGioiTinh.Size = New System.Drawing.Size(80, 29)
        Me.tbGioiTinh.TabIndex = 82
        '
        'lbNamSinh
        '
        Me.lbNamSinh.AutoSize = True
        Me.lbNamSinh.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNamSinh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbNamSinh.Location = New System.Drawing.Point(324, 204)
        Me.lbNamSinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNamSinh.Name = "lbNamSinh"
        Me.lbNamSinh.Size = New System.Drawing.Size(101, 28)
        Me.lbNamSinh.TabIndex = 81
        Me.lbNamSinh.Text = "Năm Sinh:"
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbGioiTinh.Location = New System.Drawing.Point(60, 207)
        Me.lbGioiTinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(94, 28)
        Me.lbGioiTinh.TabIndex = 80
        Me.lbGioiTinh.Text = "Giới Tính:"
        '
        'cbBenhNhan
        '
        Me.cbBenhNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBenhNhan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBenhNhan.FormattingEnabled = True
        Me.cbBenhNhan.Location = New System.Drawing.Point(211, 111)
        Me.cbBenhNhan.Name = "cbBenhNhan"
        Me.cbBenhNhan.Size = New System.Drawing.Size(324, 29)
        Me.cbBenhNhan.TabIndex = 79
        '
        'tbTrieuChung
        '
        Me.tbTrieuChung.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTrieuChung.Location = New System.Drawing.Point(211, 308)
        Me.tbTrieuChung.Multiline = True
        Me.tbTrieuChung.Name = "tbTrieuChung"
        Me.tbTrieuChung.Size = New System.Drawing.Size(324, 50)
        Me.tbTrieuChung.TabIndex = 78
        '
        'lbNgayKham
        '
        Me.lbNgayKham.AutoSize = True
        Me.lbNgayKham.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNgayKham.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbNgayKham.Location = New System.Drawing.Point(21, 65)
        Me.lbNgayKham.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgayKham.Name = "lbNgayKham"
        Me.lbNgayKham.Size = New System.Drawing.Size(118, 28)
        Me.lbNgayKham.TabIndex = 77
        Me.lbNgayKham.Text = "Ngày Khám:"
        '
        'lbLoaiBenh
        '
        Me.lbLoaiBenh.AutoSize = True
        Me.lbLoaiBenh.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLoaiBenh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbLoaiBenh.Location = New System.Drawing.Point(21, 377)
        Me.lbLoaiBenh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLoaiBenh.Name = "lbLoaiBenh"
        Me.lbLoaiBenh.Size = New System.Drawing.Size(183, 28)
        Me.lbLoaiBenh.TabIndex = 76
        Me.lbLoaiBenh.Text = "Dự Đoán Loại Bệnh:"
        '
        'lbTrieuChung
        '
        Me.lbTrieuChung.AutoSize = True
        Me.lbTrieuChung.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTrieuChung.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbTrieuChung.Location = New System.Drawing.Point(21, 305)
        Me.lbTrieuChung.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTrieuChung.Name = "lbTrieuChung"
        Me.lbTrieuChung.Size = New System.Drawing.Size(120, 28)
        Me.lbTrieuChung.TabIndex = 75
        Me.lbTrieuChung.Text = "Triệu Chứng:"
        '
        'dtpNgayKham
        '
        Me.dtpNgayKham.CustomFormat = "MM / dd / yyyy"
        Me.dtpNgayKham.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayKham.Location = New System.Drawing.Point(211, 67)
        Me.dtpNgayKham.Name = "dtpNgayKham"
        Me.dtpNgayKham.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpNgayKham.Size = New System.Drawing.Size(324, 29)
        Me.dtpNgayKham.TabIndex = 74
        '
        'lbBenhNhan
        '
        Me.lbBenhNhan.AutoSize = True
        Me.lbBenhNhan.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBenhNhan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbBenhNhan.Location = New System.Drawing.Point(21, 108)
        Me.lbBenhNhan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbBenhNhan.Name = "lbBenhNhan"
        Me.lbBenhNhan.Size = New System.Drawing.Size(111, 28)
        Me.lbBenhNhan.TabIndex = 73
        Me.lbBenhNhan.Text = "Bệnh Nhân:"
        '
        'tabPageThuoc
        '
        Me.tabPageThuoc.Controls.Add(Me.tbMaThuoc)
        Me.tabPageThuoc.Controls.Add(Me.lbMaTh)
        Me.tabPageThuoc.Controls.Add(Me.btTTPhieuKham)
        Me.tabPageThuoc.Controls.Add(Me.btCapNhatThuoc)
        Me.tabPageThuoc.Controls.Add(Me.btXoaThuoc)
        Me.tabPageThuoc.Controls.Add(Me.btThemThuoc)
        Me.tabPageThuoc.Controls.Add(Me.tbSoLuong)
        Me.tabPageThuoc.Controls.Add(Me.lbCachDung)
        Me.tabPageThuoc.Controls.Add(Me.tbCachDung)
        Me.tabPageThuoc.Controls.Add(Me.Label1)
        Me.tabPageThuoc.Controls.Add(Me.tbDonVi)
        Me.tabPageThuoc.Controls.Add(Me.cbThuoc)
        Me.tabPageThuoc.Controls.Add(Me.lbDonVi)
        Me.tabPageThuoc.Controls.Add(Me.Label3)
        Me.tabPageThuoc.Location = New System.Drawing.Point(4, 30)
        Me.tabPageThuoc.Name = "tabPageThuoc"
        Me.tabPageThuoc.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageThuoc.Size = New System.Drawing.Size(538, 468)
        Me.tabPageThuoc.TabIndex = 1
        Me.tabPageThuoc.Text = "Thuốc"
        Me.tabPageThuoc.UseVisualStyleBackColor = True
        '
        'tbMaThuoc
        '
        Me.tbMaThuoc.BackColor = System.Drawing.SystemColors.Control
        Me.tbMaThuoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMaThuoc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMaThuoc.Location = New System.Drawing.Point(147, 102)
        Me.tbMaThuoc.Name = "tbMaThuoc"
        Me.tbMaThuoc.ReadOnly = True
        Me.tbMaThuoc.Size = New System.Drawing.Size(280, 29)
        Me.tbMaThuoc.TabIndex = 93
        '
        'lbMaTh
        '
        Me.lbMaTh.AutoSize = True
        Me.lbMaTh.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaTh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbMaTh.Location = New System.Drawing.Point(29, 99)
        Me.lbMaTh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaTh.Name = "lbMaTh"
        Me.lbMaTh.Size = New System.Drawing.Size(102, 28)
        Me.lbMaTh.TabIndex = 92
        Me.lbMaTh.Text = "Mã Thuốc:"
        '
        'btTTPhieuKham
        '
        Me.btTTPhieuKham.BackgroundImage = CType(resources.GetObject("btTTPhieuKham.BackgroundImage"), System.Drawing.Image)
        Me.btTTPhieuKham.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTTPhieuKham.ForeColor = System.Drawing.SystemColors.Control
        Me.btTTPhieuKham.Location = New System.Drawing.Point(353, 364)
        Me.btTTPhieuKham.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btTTPhieuKham.Name = "btTTPhieuKham"
        Me.btTTPhieuKham.Size = New System.Drawing.Size(178, 40)
        Me.btTTPhieuKham.TabIndex = 91
        Me.btTTPhieuKham.Text = "Thông Tin Phiếu Khám"
        Me.btTTPhieuKham.UseVisualStyleBackColor = True
        '
        'btCapNhatThuoc
        '
        Me.btCapNhatThuoc.BackgroundImage = CType(resources.GetObject("btCapNhatThuoc.BackgroundImage"), System.Drawing.Image)
        Me.btCapNhatThuoc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCapNhatThuoc.ForeColor = System.Drawing.SystemColors.Control
        Me.btCapNhatThuoc.Location = New System.Drawing.Point(223, 364)
        Me.btCapNhatThuoc.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btCapNhatThuoc.Name = "btCapNhatThuoc"
        Me.btCapNhatThuoc.Size = New System.Drawing.Size(104, 40)
        Me.btCapNhatThuoc.TabIndex = 90
        Me.btCapNhatThuoc.Text = "Cập Nhật"
        Me.btCapNhatThuoc.UseVisualStyleBackColor = True
        '
        'btXoaThuoc
        '
        Me.btXoaThuoc.BackgroundImage = CType(resources.GetObject("btXoaThuoc.BackgroundImage"), System.Drawing.Image)
        Me.btXoaThuoc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoaThuoc.ForeColor = System.Drawing.SystemColors.Control
        Me.btXoaThuoc.Location = New System.Drawing.Point(129, 364)
        Me.btXoaThuoc.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btXoaThuoc.Name = "btXoaThuoc"
        Me.btXoaThuoc.Size = New System.Drawing.Size(77, 40)
        Me.btXoaThuoc.TabIndex = 89
        Me.btXoaThuoc.Text = "Xóa"
        Me.btXoaThuoc.UseVisualStyleBackColor = True
        '
        'btThemThuoc
        '
        Me.btThemThuoc.BackgroundImage = CType(resources.GetObject("btThemThuoc.BackgroundImage"), System.Drawing.Image)
        Me.btThemThuoc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThemThuoc.ForeColor = System.Drawing.SystemColors.Control
        Me.btThemThuoc.Location = New System.Drawing.Point(28, 364)
        Me.btThemThuoc.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btThemThuoc.Name = "btThemThuoc"
        Me.btThemThuoc.Size = New System.Drawing.Size(77, 40)
        Me.btThemThuoc.TabIndex = 88
        Me.btThemThuoc.Text = "Thêm"
        Me.btThemThuoc.UseVisualStyleBackColor = True
        '
        'tbSoLuong
        '
        Me.tbSoLuong.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSoLuong.Location = New System.Drawing.Point(147, 297)
        Me.tbSoLuong.Name = "tbSoLuong"
        Me.tbSoLuong.Size = New System.Drawing.Size(279, 29)
        Me.tbSoLuong.TabIndex = 87
        '
        'lbCachDung
        '
        Me.lbCachDung.AutoSize = True
        Me.lbCachDung.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCachDung.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbCachDung.Location = New System.Drawing.Point(29, 230)
        Me.lbCachDung.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCachDung.Name = "lbCachDung"
        Me.lbCachDung.Size = New System.Drawing.Size(111, 28)
        Me.lbCachDung.TabIndex = 86
        Me.lbCachDung.Text = "Cách Dùng:"
        '
        'tbCachDung
        '
        Me.tbCachDung.BackColor = System.Drawing.SystemColors.Control
        Me.tbCachDung.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCachDung.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCachDung.Location = New System.Drawing.Point(147, 233)
        Me.tbCachDung.Name = "tbCachDung"
        Me.tbCachDung.ReadOnly = True
        Me.tbCachDung.Size = New System.Drawing.Size(279, 29)
        Me.tbCachDung.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 294)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 28)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Số Lượng:"
        '
        'tbDonVi
        '
        Me.tbDonVi.BackColor = System.Drawing.SystemColors.Control
        Me.tbDonVi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDonVi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDonVi.Location = New System.Drawing.Point(147, 164)
        Me.tbDonVi.Name = "tbDonVi"
        Me.tbDonVi.ReadOnly = True
        Me.tbDonVi.Size = New System.Drawing.Size(280, 29)
        Me.tbDonVi.TabIndex = 83
        '
        'cbThuoc
        '
        Me.cbThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThuoc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbThuoc.FormattingEnabled = True
        Me.cbThuoc.Location = New System.Drawing.Point(147, 34)
        Me.cbThuoc.Name = "cbThuoc"
        Me.cbThuoc.Size = New System.Drawing.Size(280, 29)
        Me.cbThuoc.TabIndex = 82
        '
        'lbDonVi
        '
        Me.lbDonVi.AutoSize = True
        Me.lbDonVi.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDonVi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbDonVi.Location = New System.Drawing.Point(29, 161)
        Me.lbDonVi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDonVi.Name = "lbDonVi"
        Me.lbDonVi.Size = New System.Drawing.Size(75, 28)
        Me.lbDonVi.TabIndex = 81
        Me.lbDonVi.Text = "Đơn Vị:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(29, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 28)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Thuốc:"
        '
        'dgvThuoc
        '
        Me.dgvThuoc.AllowUserToAddRows = False
        Me.dgvThuoc.AllowUserToDeleteRows = False
        Me.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThuoc.Location = New System.Drawing.Point(243, 520)
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
        Me.dgvThuoc.Size = New System.Drawing.Size(538, 164)
        Me.dgvThuoc.TabIndex = 65
        '
        'btnThoat
        '
        Me.btnThoat.BackgroundImage = CType(resources.GetObject("btnThoat.BackgroundImage"), System.Drawing.Image)
        Me.btnThoat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.SystemColors.Control
        Me.btnThoat.Location = New System.Drawing.Point(298, 418)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(94, 40)
        Me.btnThoat.TabIndex = 94
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.tabControl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPhieuKhamBenh"
        Me.Text = "frmPhieuKhamBenh"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabControl.ResumeLayout(False)
        Me.tabPageThongTin.ResumeLayout(False)
        Me.tabPageThongTin.PerformLayout()
        Me.tabPageThuoc.ResumeLayout(False)
        Me.tabPageThuoc.PerformLayout()
        CType(Me.dgvThuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabPageThongTin As TabPage
    Friend WithEvents btLapPhieu As Button
    Friend WithEvents btKeThuoc As Button
    Friend WithEvents cbLoaiBenh As ComboBox
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents tbNamSinh As TextBox
    Friend WithEvents tbGioiTinh As TextBox
    Friend WithEvents lbNamSinh As Label
    Friend WithEvents lbGioiTinh As Label
    Friend WithEvents cbBenhNhan As ComboBox
    Friend WithEvents tbTrieuChung As TextBox
    Friend WithEvents lbNgayKham As Label
    Friend WithEvents lbLoaiBenh As Label
    Friend WithEvents lbTrieuChung As Label
    Friend WithEvents dtpNgayKham As DateTimePicker
    Friend WithEvents lbBenhNhan As Label
    Friend WithEvents tabPageThuoc As TabPage
    Friend WithEvents btXoaThuoc As Button
    Friend WithEvents btThemThuoc As Button
    Friend WithEvents tbSoLuong As TextBox
    Friend WithEvents lbCachDung As Label
    Friend WithEvents tbCachDung As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbDonVi As TextBox
    Friend WithEvents cbThuoc As ComboBox
    Friend WithEvents lbDonVi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btTTPhieuKham As Button
    Friend WithEvents btCapNhatThuoc As Button
    Friend WithEvents dgvThuoc As DataGridView
    Friend WithEvents btLamLai As Button
    Friend WithEvents tbMaBenhNhan As TextBox
    Friend WithEvents lbMaBenhNhan As Label
    Friend WithEvents tbMaThuoc As TextBox
    Friend WithEvents lbMaTh As Label
    Friend WithEvents tbMaPhieuKham As TextBox
    Friend WithEvents lbMaPK As Label
    Friend WithEvents btnThoat As Button
End Class
