<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambahmobiladmin
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnPicture = New System.Windows.Forms.Button()
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDetailMobil = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.txtNamaMobil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGambarMobil = New System.Windows.Forms.PictureBox()
        CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGambarMobil,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnPicture
        '
        Me.btnPicture.FlatAppearance.BorderSize = 2
        Me.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPicture.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnPicture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.btnPicture.Location = New System.Drawing.Point(728, 427)
        Me.btnPicture.Name = "btnPicture"
        Me.btnPicture.Size = New System.Drawing.Size(184, 56)
        Me.btnPicture.TabIndex = 22
        Me.btnPicture.Text = "Browse"
        Me.btnPicture.UseVisualStyleBackColor = true
        '
        'flpMain
        '
        Me.flpMain.AutoScroll = true
        Me.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMain.Location = New System.Drawing.Point(61, 272)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Size = New System.Drawing.Size(617, 345)
        Me.flpMain.TabIndex = 21
        Me.flpMain.WrapContents = false
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(55,Byte),Integer))
        Me.Button1.Location = New System.Drawing.Point(448, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 56)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'txtDetailMobil
        '
        Me.txtDetailMobil.Location = New System.Drawing.Point(135, 212)
        Me.txtDetailMobil.Name = "txtDetailMobil"
        Me.txtDetailMobil.Size = New System.Drawing.Size(233, 22)
        Me.txtDetailMobil.TabIndex = 18
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(136, 142)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(232, 22)
        Me.NumericUpDown1.TabIndex = 17
        '
        'txtNamaMobil
        '
        Me.txtNamaMobil.Location = New System.Drawing.Point(136, 64)
        Me.txtNamaMobil.Name = "txtNamaMobil"
        Me.txtNamaMobil.Size = New System.Drawing.Size(233, 22)
        Me.txtNamaMobil.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(733, 387)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Gambar Mobil"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Detail Mobil"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Harga Mobil"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama Mobil"
        '
        'txtGambarMobil
        '
        Me.txtGambarMobil.Location = New System.Drawing.Point(737, 142)
        Me.txtGambarMobil.Name = "txtGambarMobil"
        Me.txtGambarMobil.Size = New System.Drawing.Size(160, 228)
        Me.txtGambarMobil.TabIndex = 23
        Me.txtGambarMobil.TabStop = false
        '
        'tambahmobiladmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtGambarMobil)
        Me.Controls.Add(Me.btnPicture)
        Me.Controls.Add(Me.flpMain)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDetailMobil)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.txtNamaMobil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "tambahmobiladmin"
        Me.Size = New System.Drawing.Size(1028, 655)
        CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGambarMobil,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnPicture As System.Windows.Forms.Button
    Friend WithEvents flpMain As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtDetailMobil As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtNamaMobil As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGambarMobil As System.Windows.Forms.PictureBox

End Class
