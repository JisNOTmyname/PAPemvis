'Imports MySql.Data.MySqlClient

'Public Class usercontrollihatmobil

'    Dim connectionString As String = "server=localhost;userid=root;password=;database=dbdeluxemotorsport"
'    Dim CONN As MySqlConnection

'    Private Sub usercontrollihatmobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        InisialisasiKoneksi()
'        TampilkanMobil()
'    End Sub


'    Private Sub InisialisasiKoneksi()
'        CONN = New MySqlConnection(connectionString)
'        Try
'            CONN.Open()
'            MessageBox.Show("Koneksi berhasil!")
'        Catch ex As MySqlException
'            MessageBox.Show("Error koneksi ke database: " & ex.Message)
'        End Try
'    End Sub


'    Private Sub TampilkanMobil()

'        FlowLayoutPanelMobil.Controls.Clear()

'        Dim querySelect As String = "SELECT * FROM vehicle"
'        Dim cmdSelect As New MySqlCommand(querySelect, CONN)

'        Try
'            Dim reader As MySqlDataReader = cmdSelect.ExecuteReader()
'            Dim index As Integer = 1

'            While reader.Read()

'                Dim mobil As New mobil()
'                mobil.Label.Text = "Mobil " & index
'                mobil.detail.Text = reader("Detail").ToString()
'                mobil.harga.Text = "Harga: " & reader("Harga").ToString()
'                mobil.gambar.ImageLocation = reader("Gambar").ToString()


'                FlowLayoutPanelMobil.Controls.Add(mobil)
'                index += 1
'            End While
'            reader.Close()
'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        End Try
'    End Sub
'End Class