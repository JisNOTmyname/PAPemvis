Imports MySql.Data.MySqlClient

Public Class tambahmobiladmin
    Private _CurrentContactPanelName As String = Nothing
    Private _ContactPanelsAddedCount As Integer = 0

    ' Define MySQL connection variables
    Private CONN As MySqlConnection

    ' Define the Car class to hold car details
    Public Class Car
        Public Property NamaMobil As String
        Public Property GambarMobil As String
        Public Property HargaMobil As Decimal
        Public Property DetailMobil As String
    End Class

    ' Method to initialize the database connection
    Private Sub koneksi()
        Dim connectionString As String = "server=localhost;userid=root;password=;database=dbdeluxemotorsport"
        CONN = New MySqlConnection(connectionString)
        Try
            CONN.Open()
        Catch ex As MySqlException
            MessageBox.Show("Error connecting to the database: " & ex.Message)
        End Try
    End Sub

    Private Sub tambahmobiladmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Public Sub CreateCarPanel()
        Dim carPanel = New Panel()

        With carPanel
            .BackColor = Color.White
            .Size = New Size(500, 200) ' Adjusted size to fit more controls
            .Name = "pnlCar" + (_ContactPanelsAddedCount + 1).ToString
        End With

        flpMain.Controls.Add(carPanel)
        _CurrentContactPanelName = carPanel.Name
        _ContactPanelsAddedCount += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newCar As New Car()

        ' Retrieve values from the input controls
        newCar.NamaMobil = txtNamaMobil.Text
        newCar.GambarMobil = txtGambarMobil.Text
        newCar.HargaMobil = NumericUpDown1.Value
        newCar.DetailMobil = txtDetailMobil.Text

        ' Insert new car data into the database
        Try
            Dim queryInsert As String = "INSERT INTO vehicle (nama, Gambar, Harga, Detail) VALUES (@nama, @gambar, @harga, @detail)"
            Dim cmdInsert As New MySqlCommand(queryInsert, CONN)
            cmdInsert.Parameters.AddWithValue("@nama", newCar.NamaMobil)
            cmdInsert.Parameters.AddWithValue("@gambar", newCar.GambarMobil)
            cmdInsert.Parameters.AddWithValue("@harga", newCar.HargaMobil)
            cmdInsert.Parameters.AddWithValue("@detail", newCar.DetailMobil)
            cmdInsert.ExecuteNonQuery()
            MessageBox.Show("Data berhasil ditambahkan!")
        Catch ex As Exception
            MessageBox.Show("Error inserting data into the database: " & ex.Message)
        End Try

        CreateCarPanel()
        CreateCarPictureBox(_CurrentContactPanelName, newCar.GambarMobil)
        CreateCarNameLabel(_CurrentContactPanelName, newCar.NamaMobil)
        CreateCarDetails(_CurrentContactPanelName, newCar.HargaMobil, newCar.DetailMobil)

    End Sub

    Public Sub CreateCarPictureBox(ByVal PanelName As String, ByVal imagePath As String)
        Dim carPictureBox As PictureBox
        carPictureBox = New PictureBox

        With carPictureBox
            .SizeMode = PictureBoxSizeMode.Zoom
            .Size = New Drawing.Size(100, 100) ' Increased size for better visibility
            .Location = New Point(10, 10) ' Adjust location as needed
            .Name = "picCarImage" + (_ContactPanelsAddedCount).ToString
            .ImageLocation = imagePath
        End With

        For Each controlObject As Control In flpMain.Controls
            If controlObject.Name = PanelName Then
                controlObject.Controls.Add(carPictureBox)
            End If
        Next
    End Sub

    Public Sub CreateCarNameLabel(ByVal PanelName As String, ByVal namaMobil As String)
        Dim carNameLabel As Label
        carNameLabel = New Label

        With carNameLabel
            .Text = namaMobil
            .Font = New Font("Arial", 12, FontStyle.Bold) ' Adjusted font for better visibility
            .Size = New Drawing.Size(350, 20)
            .Location = New Point(120, 10) ' Adjusted location to fit next to the image
            .Name = "lblCarName" + (_ContactPanelsAddedCount).ToString
        End With

        For Each controlObject As Control In flpMain.Controls
            If controlObject.Name = PanelName Then
                controlObject.Controls.Add(carNameLabel)
            End If
        Next
    End Sub

    Public Sub CreateCarDetails(ByVal PanelName As String, ByVal hargaMobil As Decimal, ByVal detailMobil As String)
        Dim priceLabel As Label = New Label()
        With priceLabel
            .Text = "Harga: " & hargaMobil.ToString("C")
            .Font = New Font("Arial", 10, FontStyle.Regular) ' Adjusted font for better visibility
            .Size = New Drawing.Size(350, 20)
            .Location = New Point(120, 40) ' Adjusted location to fit next to the image
            .Name = "lblCarPrice" + (_ContactPanelsAddedCount).ToString
        End With

        Dim detailsLabel As Label = New Label()
        With detailsLabel
            .Text = "Detail: " & detailMobil
            .Font = New Font("Arial", 10, FontStyle.Regular) ' Adjusted font for better visibility
            .Size = New Drawing.Size(350, 50)
            .Location = New Point(120, 70) ' Adjusted location to fit next to the image
            .Name = "lblCarDetails" + (_ContactPanelsAddedCount).ToString
        End With

        For Each controlObject As Control In flpMain.Controls
            If controlObject.Name = PanelName Then
                controlObject.Controls.Add(priceLabel)
                controlObject.Controls.Add(detailsLabel)
            End If
        Next
    End Sub

    Private Sub btnPicture_Click(sender As Object, e As EventArgs) Handles btnPicture.Click
        ' Open a file dialog to select an image
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        If ofd.ShowDialog() = DialogResult.OK Then
            ' Display the selected image path in the TextBox
            txtGambarMobil.Text = ofd.FileName
        End If
    End Sub
End Class
