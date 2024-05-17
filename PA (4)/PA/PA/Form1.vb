Imports MySql.Data.MySqlClient

Public Class Form1

    Private userControl2 As UserControl2
    Private firstUserControl As firstcostumcontrol

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userControl2 = New UserControl2()
        userControl2.Dock = DockStyle.Fill
        firstUserControl = New firstcostumcontrol()
        firstUserControl.Dock = DockStyle.Fill


        Me.Controls.Add(userControl2)
        SidePanel.Height = btntambahadmin.Height
        Tambahmobiladmin2.BringToFront()
    End Sub

    Public Sub ShowFirstUserControl()

        Me.Controls.Remove(userControl2)
        Me.Controls.Add(firstUserControl)
        firstUserControl.BringToFront()
    End Sub

    Private Sub btntambahadmin_Click(sender As Object, e As EventArgs) Handles btntambahadmin.Click
        SidePanel.Height = btntambahadmin.Height
        Tambahmobiladmin2.BringToFront()
        SidePanel.Top = btntambahadmin.Top
    End Sub

    Private Sub btnubahadmin_Click(sender As Object, e As EventArgs) Handles btnubahadmin.Click
        SidePanel.Height = btnubahadmin.Height
        Ubahmobiladmin1.BringToFront()
        SidePanel.Top = btnubahadmin.Top


    End Sub

    Private Sub btnlihatadmin_Click(sender As Object, e As EventArgs) Handles btnlihatadmin.Click
        SidePanel.Height = btnlihatadmin.Height
        Adminlihat1.BringToFront()
        SidePanel.Top = btnlihatadmin.Top
    End Sub

    Private Sub btnhapusadmin_Click(sender As Object, e As EventArgs) Handles btnhapusadmin.Click
        SidePanel.Height = btnhapusadmin.Height
        Hapusmobiladmin1.BringToFront()
        SidePanel.Top = btnhapusadmin.Top
    End Sub


    Sub ShowFirstCustomControl()
        Throw New NotImplementedException
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Tutup form saat ini
        Me.Close()

        ' Buka form login
        Dim loginForm As New formlogin()
        loginForm.Show()
    End Sub

    Private Sub Adminlihat1_Load(sender As Object, e As EventArgs)

    End Sub
End Class
