
Imports MySql.Data.MySqlClient

Public Class hapusmobiladmin
    ' Define MySQL connection variables
    Private CONN As MySqlConnection

    Private Sub Koneksi()
        Dim connectionString As String = "server=localhost;userid=root;password=;database=dbdeluxemotorsport"
        CONN = New MySqlConnection(connectionString)
        Try
            CONN.Open()
        Catch ex As MySqlException
            MessageBox.Show("Error connecting to the database: " & ex.Message)
        End Try
    End Sub

    Private Sub hapusmobiladmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        tampilJenis()
        aturGrid()
    End Sub

    Sub tampilJenis()
        Try
            Dim query As String = "SELECT * FROM vehicle"
            Dim adapter As New MySqlDataAdapter(query, CONN)
            Dim dataset As New DataSet()
            adapter.Fill(dataset, "vehicle")
            DataGridView1.DataSource = dataset.Tables("vehicle")
        Catch ex As Exception
            MessageBox.Show("Error displaying data: " & ex.Message)
        End Try
    End Sub

    Sub aturGrid()
        Try
            DataGridView1.Columns(0).HeaderText = "ID Mobil"
            DataGridView1.Columns(1).HeaderText = "Nama Mobil"
            DataGridView1.Columns(2).HeaderText = "Harga Mobil"

            DataGridView1.Columns(0).Width = 60
            DataGridView1.Columns(1).Width = 200
        Catch ex As Exception
            MessageBox.Show("Error configuring grid: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim CMD As New MySqlCommand("DELETE FROM vehicle WHERE ID_mobil = @id", CONN)
            CMD.Parameters.AddWithValue("@id", TxtID.Text)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!")
            tampilJenis()  ' Refresh the grid after deletion
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            TxtID.Text = row.Cells(0).Value.ToString()
        End If
    End Sub
End Class
