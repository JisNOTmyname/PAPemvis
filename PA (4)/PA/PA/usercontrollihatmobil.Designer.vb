<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usercontrollihatmobil
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
        Me.FlowLayoutPanelMobil = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'FlowLayoutPanelMobil
        '
        Me.FlowLayoutPanelMobil.Location = New System.Drawing.Point(186, 101)
        Me.FlowLayoutPanelMobil.Name = "FlowLayoutPanelMobil"
        Me.FlowLayoutPanelMobil.Size = New System.Drawing.Size(652, 308)
        Me.FlowLayoutPanelMobil.TabIndex = 0
        '
        'usercontrollihatmobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanelMobil)
        Me.Name = "usercontrollihatmobil"
        Me.Size = New System.Drawing.Size(1028, 655)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanelMobil As System.Windows.Forms.FlowLayoutPanel

End Class
