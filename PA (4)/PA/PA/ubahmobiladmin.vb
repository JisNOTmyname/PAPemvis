Imports MySql.Data.MySqlClient

Public Class ubahmobiladmin
    ' Define MySQL connection variables
    Private CONN As MySqlConnection
    Private CMD As MySqlCommand
    Private RD As MySqlDataReader

    ' Method to initialize the database connection
    Private Sub InitializeConnection()
        Dim connectionString As String = "server=localhost;userid=root;password=;database=dbdeluxemotorsport"
        CONN = New MySqlConnection(connectionString)
        Try
            CONN.Open()
        Catch ex As MySqlException
            MessageBox.Show("Failed to connect to the database: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ubahmobiladmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeConnection()
        LoadVehicleTypes()
        ConfigureDataGridView()
    End Sub

    ' Method to load vehicle types into DataGridView
    Private Sub LoadVehicleTypes()
        DataGridView1.Rows.Clear()
        Try
            CMD = New MySqlCommand("SELECT * FROM vehicle", CONN)
            RD = CMD.ExecuteReader()
            While RD.Read()
                DataGridView1.Rows.Add(RD("ID_mobil"), RD("nama"), RD("Harga"))
            End While
            RD.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to load vehicle types: " & ex.Message, "Data Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to configure DataGridView columns
    Private Sub ConfigureDataGridView()
        Try
            DataGridView1.Columns(0).HeaderText = "ID Mobil"
            DataGridView1.Columns(1).HeaderText = "Nama Mobil"
            DataGridView1.Columns(2).HeaderText = "Harga Mobil"
            DataGridView1.Columns(0).Width = 60
            DataGridView1.Columns(2).Width = 140
        Catch ex As Exception
            MessageBox.Show("Failed to configure DataGridView: " & ex.Message, "DataGridView Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button click event to update vehicle details
    Private Sub BtnUbahAdmin_Click(sender As Object, e As EventArgs) Handles BtnUbahAdmin.Click
        Try
            If String.IsNullOrWhiteSpace(TxtID.Text) Or String.IsNullOrWhiteSpace(TxtNamaMobil.Text) Or NumericUpDown1.Value = 0 Then
                MessageBox.Show("Data belum lengkap!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim queryCheck As String = "SELECT COUNT(*) FROM vehicle WHERE ID_mobil = @id"
                Dim cmdCheck As New MySqlCommand(queryCheck, CONN)
                cmdCheck.Parameters.AddWithValue("@id", TxtID.Text)
                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                If count > 0 Then
                    Dim queryUpdate As String = "UPDATE vehicle SET nama = @nama, Harga = @harga WHERE ID_mobil = @id"
                    Dim cmdUpdate As New MySqlCommand(queryUpdate, CONN)
                    cmdUpdate.Parameters.AddWithValue("@nama", TxtNamaMobil.Text)
                    cmdUpdate.Parameters.AddWithValue("@harga", NumericUpDown1.Value)
                    cmdUpdate.Parameters.AddWithValue("@id", TxtID.Text)
                    cmdUpdate.ExecuteNonQuery()

                    MessageBox.Show("Data berhasil diupdate!", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadVehicleTypes() ' Refresh DataGridView after updating data
                Else
                    MessageBox.Show("ID tidak ditemukan!", "ID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message, "Data Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button click event to select an image file
    Private Sub btnPicture_Click(sender As Object, e As EventArgs) Handles btnPicture.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        If ofd.ShowDialog() = DialogResult.OK Then
            txtGambarMobil.Text = ofd.FileName
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
