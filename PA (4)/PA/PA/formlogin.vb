Imports MySql.Data.MySqlClient

Public Class formlogin
    Public ID_USER As Integer

    Dim DatabaseName As String = "dbdeluxemotorsport"

    Private Sub formlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Public Sub kosongin()
        txtpassword.Clear()
        txtusername.Clear()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username <> "" AndAlso password <> "" Then
            Try
                CMD = New MySqlCommand("SELECT * FROM Akun WHERE username = '" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "' ", CONN)
                RD = CMD.ExecuteReader()

                If RD.HasRows Then
                    RD.Read()
                    ID_USER = RD.Item(2)
                    customerform.Show()
                ElseIf username = "admin" Then
                    Dim Form1 As New Form1()
                    Form1.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Username atau password salah!")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                RD.Close()
            End Try
        Else
            MessageBox.Show("Isi semua kolom!")
        End If
    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username <> "" AndAlso password <> "" Then
            CMD = New MySqlCommand("SELECT * FROM Akun WHERE username = '" & username & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()

                ' Check if the username is 'admin'
                If username.ToLower() = "admin" Then
                    MessageBox.Show("Anda tidak dapat mendaftarkan nama pengguna 'admin'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    CMD = New MySqlCommand("INSERT INTO Akun (username, password) VALUES ('" & username & "' , '" & password & "') ", CONN)

                    RD = CMD.ExecuteReader
                    RD.Read()

                    MsgBox("berhasil")
                End If
            Else
                MessageBox.Show("Username sudah terdaftar!")
            End If
            RD.Close()
        Else
            MessageBox.Show("Isi semua kolom!")
        End If
    End Sub

   
End Class
