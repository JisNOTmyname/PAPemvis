Public Class customerform

    Private Sub btnubahuser_Click(sender As Object, e As EventArgs) Handles btnubahuser.Click
        Usercontrollihatmobil1.BringToFront()
        SidePanel.Top = btnubahuser.Top
    End Sub

    Private Sub SidePanel_Paint(sender As Object, e As PaintEventArgs) Handles SidePanel.Paint

    End Sub

    Private Sub Usercontrollihatmobil1_Load(sender As Object, e As EventArgs) Handles Usercontrollihatmobil1.Load

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Tutup form saat ini
        Me.Close()

        ' Buka form login
        Dim loginForm As New formlogin()
        loginForm.Show()
    End Sub

    Private Sub customerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class