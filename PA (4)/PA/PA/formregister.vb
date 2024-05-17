Public Class FormRegister
    Private _loginForm As formlogin

    Public Sub New(loginForm As formlogin)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _loginForm = loginForm
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim newUsername As String = txtNewUsername.Text
        Dim newPassword As String = txtNewPassword.Text

        ' Validate input
        If String.IsNullOrWhiteSpace(newUsername) OrElse String.IsNullOrWhiteSpace(newPassword) Then
            MessageBox.Show("Username dan password tidak boleh kosong.")
            Return
        End If

        ' Add the new user to the login form
        _loginForm.AddUser(newUsername, newPassword)
        MessageBox.Show("Registrasi berhasil.")
        Me.Close()
        _loginForm.Show()
    End Sub

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewUsername.Text = "New Username"
        txtNewUsername.ForeColor = Color.DarkGray

        txtNewPassword.Text = "New Password"
        txtNewPassword.ForeColor = Color.DarkGray
    End Sub

    Private Sub txtNewUsername_GotFocus(sender As Object, e As EventArgs) Handles txtNewUsername.GotFocus
        If txtNewUsername.Text = "New Username" Then
            txtNewUsername.Text = ""
            txtNewUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNewUsername_LostFocus(sender As Object, e As EventArgs) Handles txtNewUsername.LostFocus
        If txtNewUsername.Text = "" Then
            txtNewUsername.Text = "New Username"
            txtNewUsername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtNewPassword_GotFocus(sender As Object, e As EventArgs) Handles txtNewPassword.GotFocus
        If txtNewPassword.Text = "New Password" Then
            txtNewPassword.Text = ""
            txtNewPassword.PasswordChar = "•"
            txtNewPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNewPassword_LostFocus(sender As Object, e As EventArgs) Handles txtNewPassword.LostFocus
        If txtNewPassword.Text = "" Then
            txtNewPassword.Text = "New Password"
            txtNewPassword.PasswordChar = ""
            txtNewPassword.ForeColor = Color.DarkGray
        End If
    End Sub
End Class
