<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ubahmobiladmin
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
        Me.BtnUbahAdmin = New System.Windows.Forms.Button()
        Me.TxtDetailMobil = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TxtNamaMobil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPicture = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGambarMobil = New System.Windows.Forms.PictureBox()
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGambarMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUbahAdmin
        '
        Me.BtnUbahAdmin.FlatAppearance.BorderSize = 2
        Me.BtnUbahAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUbahAdmin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbahAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BtnUbahAdmin.Location = New System.Drawing.Point(258, 552)
        Me.BtnUbahAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUbahAdmin.Name = "BtnUbahAdmin"
        Me.BtnUbahAdmin.Size = New System.Drawing.Size(184, 57)
        Me.BtnUbahAdmin.TabIndex = 17
        Me.BtnUbahAdmin.Text = "Ubah"
        Me.BtnUbahAdmin.UseVisualStyleBackColor = True
        '
        'TxtDetailMobil
        '
        Me.TxtDetailMobil.Location = New System.Drawing.Point(391, 249)
        Me.TxtDetailMobil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDetailMobil.Name = "TxtDetailMobil"
        Me.TxtDetailMobil.Size = New System.Drawing.Size(233, 22)
        Me.TxtDetailMobil.TabIndex = 16
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(91, 249)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(232, 22)
        Me.NumericUpDown1.TabIndex = 15
        '
        'TxtNamaMobil
        '
        Me.TxtNamaMobil.Location = New System.Drawing.Point(43, 110)
        Me.TxtNamaMobil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNamaMobil.Name = "TxtNamaMobil"
        Me.TxtNamaMobil.Size = New System.Drawing.Size(233, 22)
        Me.TxtNamaMobil.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1064, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Gambar Mobil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(449, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Detail Mobil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Harga Mobil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nama Mobil"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(732, 110)
        Me.TxtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(233, 22)
        Me.TxtID.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(798, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "ID Mobil"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(699, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(310, 306)
        Me.DataGridView1.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Harga"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'btnPicture
        '
        Me.btnPicture.FlatAppearance.BorderSize = 2
        Me.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPicture.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPicture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnPicture.Location = New System.Drawing.Point(1045, 409)
        Me.btnPicture.Name = "btnPicture"
        Me.btnPicture.Size = New System.Drawing.Size(184, 56)
        Me.btnPicture.TabIndex = 26
        Me.btnPicture.Text = "Browse"
        Me.btnPicture.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.AcceptsReturn = True
        Me.txtSearch.Location = New System.Drawing.Point(391, 110)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(299, 22)
        Me.txtSearch.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(486, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 23)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Search ID"
        '
        'txtGambarMobil
        '
        Me.txtGambarMobil.Location = New System.Drawing.Point(1045, 97)
        Me.txtGambarMobil.Name = "txtGambarMobil"
        Me.txtGambarMobil.Size = New System.Drawing.Size(160, 228)
        Me.txtGambarMobil.TabIndex = 29
        Me.txtGambarMobil.TabStop = False
        '
        'flpMain
        '
        Me.flpMain.AutoScroll = True
        Me.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMain.Location = New System.Drawing.Point(43, 287)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Size = New System.Drawing.Size(617, 260)
        Me.flpMain.TabIndex = 25
        Me.flpMain.WrapContents = False
        '
        'ubahmobiladmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtGambarMobil)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnPicture)
        Me.Controls.Add(Me.flpMain)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnUbahAdmin)
        Me.Controls.Add(Me.TxtDetailMobil)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TxtNamaMobil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ubahmobiladmin"
        Me.Size = New System.Drawing.Size(1288, 655)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGambarMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents BtnUbahAdmin As System.Windows.Forms.Button
    Friend WithEvents TxtDetailMobil As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents TxtNamaMobil As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPicture As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGambarMobil As System.Windows.Forms.PictureBox
    Friend WithEvents flpMain As System.Windows.Forms.FlowLayoutPanel

End Class
