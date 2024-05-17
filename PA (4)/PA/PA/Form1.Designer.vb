<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.btnlihatadmin = New System.Windows.Forms.Button()
        Me.btnhapusadmin = New System.Windows.Forms.Button()
        Me.btnubahadmin = New System.Windows.Forms.Button()
        Me.btntambahadmin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Firstcostumcontrol1 = New PA.firstcostumcontrol()
        Me.Usercontrol21 = New PA.UserControl2()
        Me.Hapusmobiladmin1 = New PA.hapusmobiladmin()
        Me.Ubahmobiladmin1 = New PA.ubahmobiladmin()
        Me.Tambahmobiladmin2 = New PA.tambahmobiladmin()
        Me.Adminlihat1 = New PA.adminlihat()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 761)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnLogout)
        Me.Panel4.Controls.Add(Me.SidePanel)
        Me.Panel4.Controls.Add(Me.btnlihatadmin)
        Me.Panel4.Controls.Add(Me.btnhapusadmin)
        Me.Panel4.Controls.Add(Me.btnubahadmin)
        Me.Panel4.Controls.Add(Me.btntambahadmin)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 761)
        Me.Panel4.TabIndex = 6
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 577)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(227, 89)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "LogOut"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SidePanel.Location = New System.Drawing.Point(0, 164)
        Me.SidePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(11, 46)
        Me.SidePanel.TabIndex = 5
        '
        'btnlihatadmin
        '
        Me.btnlihatadmin.FlatAppearance.BorderSize = 0
        Me.btnlihatadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlihatadmin.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlihatadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlihatadmin.Image = CType(resources.GetObject("btnlihatadmin.Image"), System.Drawing.Image)
        Me.btnlihatadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlihatadmin.Location = New System.Drawing.Point(3, 484)
        Me.btnlihatadmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnlihatadmin.Name = "btnlihatadmin"
        Me.btnlihatadmin.Size = New System.Drawing.Size(227, 89)
        Me.btnlihatadmin.TabIndex = 8
        Me.btnlihatadmin.Text = " Lihat Data Mobil"
        Me.btnlihatadmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlihatadmin.UseVisualStyleBackColor = True
        '
        'btnhapusadmin
        '
        Me.btnhapusadmin.FlatAppearance.BorderSize = 0
        Me.btnhapusadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapusadmin.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapusadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnhapusadmin.Image = CType(resources.GetObject("btnhapusadmin.Image"), System.Drawing.Image)
        Me.btnhapusadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhapusadmin.Location = New System.Drawing.Point(3, 359)
        Me.btnhapusadmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnhapusadmin.Name = "btnhapusadmin"
        Me.btnhapusadmin.Size = New System.Drawing.Size(227, 89)
        Me.btnhapusadmin.TabIndex = 7
        Me.btnhapusadmin.Text = " Hapus Data Mobil"
        Me.btnhapusadmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhapusadmin.UseVisualStyleBackColor = True
        '
        'btnubahadmin
        '
        Me.btnubahadmin.FlatAppearance.BorderSize = 0
        Me.btnubahadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubahadmin.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubahadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnubahadmin.Image = CType(resources.GetObject("btnubahadmin.Image"), System.Drawing.Image)
        Me.btnubahadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnubahadmin.Location = New System.Drawing.Point(3, 249)
        Me.btnubahadmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnubahadmin.Name = "btnubahadmin"
        Me.btnubahadmin.Size = New System.Drawing.Size(227, 89)
        Me.btnubahadmin.TabIndex = 6
        Me.btnubahadmin.Text = "  Ubah Data Mobil"
        Me.btnubahadmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnubahadmin.UseVisualStyleBackColor = True
        '
        'btntambahadmin
        '
        Me.btntambahadmin.FlatAppearance.BorderSize = 0
        Me.btntambahadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambahadmin.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambahadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btntambahadmin.Image = CType(resources.GetObject("btntambahadmin.Image"), System.Drawing.Image)
        Me.btntambahadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambahadmin.Location = New System.Drawing.Point(3, 140)
        Me.btntambahadmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btntambahadmin.Name = "btntambahadmin"
        Me.btntambahadmin.Size = New System.Drawing.Size(227, 89)
        Me.btntambahadmin.TabIndex = 5
        Me.btntambahadmin.Text = "Tambah Data Mobil"
        Me.btntambahadmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntambahadmin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 96)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 89)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Tambah Data Mobil"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(227, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1026, 10)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(544, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(361, 82)
        Me.Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(81, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Deluxe Motorsport"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(391, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.Controls.Add(Me.Adminlihat1)
        Me.Panel6.Controls.Add(Me.Firstcostumcontrol1)
        Me.Panel6.Controls.Add(Me.Usercontrol21)
        Me.Panel6.Controls.Add(Me.Hapusmobiladmin1)
        Me.Panel6.Controls.Add(Me.Ubahmobiladmin1)
        Me.Panel6.Controls.Add(Me.Tambahmobiladmin2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(227, 106)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1026, 655)
        Me.Panel6.TabIndex = 5
        '
        'Firstcostumcontrol1
        '
        Me.Firstcostumcontrol1.Location = New System.Drawing.Point(0, -25)
        Me.Firstcostumcontrol1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Firstcostumcontrol1.Name = "Firstcostumcontrol1"
        Me.Firstcostumcontrol1.Size = New System.Drawing.Size(1028, 655)
        Me.Firstcostumcontrol1.TabIndex = 4
        '
        'Usercontrol21
        '
        Me.Usercontrol21.Location = New System.Drawing.Point(0, -16)
        Me.Usercontrol21.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Usercontrol21.Name = "Usercontrol21"
        Me.Usercontrol21.Size = New System.Drawing.Size(1028, 655)
        Me.Usercontrol21.TabIndex = 3
        '
        'Hapusmobiladmin1
        '
        Me.Hapusmobiladmin1.Location = New System.Drawing.Point(0, -2)
        Me.Hapusmobiladmin1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Hapusmobiladmin1.Name = "Hapusmobiladmin1"
        Me.Hapusmobiladmin1.Size = New System.Drawing.Size(1028, 655)
        Me.Hapusmobiladmin1.TabIndex = 2
        '
        'Ubahmobiladmin1
        '
        Me.Ubahmobiladmin1.Location = New System.Drawing.Point(0, 0)
        Me.Ubahmobiladmin1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Ubahmobiladmin1.Name = "Ubahmobiladmin1"
        Me.Ubahmobiladmin1.Size = New System.Drawing.Size(1028, 655)
        Me.Ubahmobiladmin1.TabIndex = 1
        '
        'Tambahmobiladmin2
        '
        Me.Tambahmobiladmin2.Location = New System.Drawing.Point(0, 0)
        Me.Tambahmobiladmin2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tambahmobiladmin2.Name = "Tambahmobiladmin2"
        Me.Tambahmobiladmin2.Size = New System.Drawing.Size(1028, 655)
        Me.Tambahmobiladmin2.TabIndex = 0
        '
        'Adminlihat1
        '
        Me.Adminlihat1.Location = New System.Drawing.Point(0, -25)
        Me.Adminlihat1.Name = "Adminlihat1"
        Me.Adminlihat1.Size = New System.Drawing.Size(1028, 663)
        Me.Adminlihat1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 761)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents btnlihatadmin As System.Windows.Forms.Button
    Friend WithEvents btnhapusadmin As System.Windows.Forms.Button
    Friend WithEvents btnubahadmin As System.Windows.Forms.Button
    Friend WithEvents btntambahadmin As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Tambahmobiladmin1 As PA.tambahmobiladmin
    Friend WithEvents Usercontrol21 As PA.usercontrol2
    Friend WithEvents Hapusmobiladmin1 As PA.hapusmobiladmin
    Friend WithEvents Ubahmobiladmin1 As PA.ubahmobiladmin
    Friend WithEvents Tambahmobiladmin2 As PA.tambahmobiladmin
    Friend WithEvents Firstcostumcontrol1 As PA.firstcostumcontrol
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Adminlihat1 As PA.adminlihat

End Class
