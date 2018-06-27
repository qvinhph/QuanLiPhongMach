<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.lbMaDonvi = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbMaDonvi
        '
        Me.lbMaDonvi.AutoSize = True
        Me.lbMaDonvi.Location = New System.Drawing.Point(229, 65)
        Me.lbMaDonvi.Name = "lbMaDonvi"
        Me.lbMaDonvi.Size = New System.Drawing.Size(39, 13)
        Me.lbMaDonvi.TabIndex = 0
        Me.lbMaDonvi.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(384, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Lấy đơn vị tiếp theo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbMaDonvi)
        Me.Name = "frmTest"
        Me.Text = "frmTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbMaDonvi As Label
    Friend WithEvents Button1 As Button
End Class
