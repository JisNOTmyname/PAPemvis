Imports MySql.Data.MySqlClient
Imports System.IO

Public Class adminlihat
    Sub tampilJenis()
        DgvLihatAdmin.Rows.Clear()
        CMD = New MySqlCommand("Select * from vehicle", CONN)
        RD = CMD.ExecuteReader()
        Dim directoryPath As String = "C:\Users\fa506\OneDrive\Documents\TUGAS\PA (4)\PA\PA\bin\Release"

        ' Get the files in the directory
        Dim files As String() = Directory.GetFiles(directoryPath)

        ' Loop through each file and display its name
        For Each filePath As String In files
            Dim fileName As String = Path.GetFileName(filePath)
            Console.WriteLine(fileName)
        Next
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DgvLihatAdmin)
            row.Cells(0).Value = RD("ID_mobil")
            row.Cells(1).Value = RD("nama")
            row.Cells(2).Value = RD("Harga")
            row.Cells(3).Value = RD("Detail")
            row.Cells(4).Value = RD("Gambar")
            DgvLihatAdmin.Rows.Add(row)
        End While
        RD.Close()
    End Sub
    Sub aturGrid()
        Try
            DgvLihatAdmin.Columns(0).HeaderText = "ID Mobil"
            DgvLihatAdmin.Columns(1).HeaderText = "Nama Mobil"
            DgvLihatAdmin.Columns(2).HeaderText = "Harga"
            DgvLihatAdmin.Columns(3).HeaderText = "Detail"
            DgvLihatAdmin.Columns(4).HeaderText = "Gambar"

            DgvLihatAdmin.Columns(0).Width = 60
            DgvLihatAdmin.Columns(1).Width = 200

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DgvLihatAdmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLihatAdmin.CellContentClick

    End Sub
    Sub Main()
        ' Specify the directory path
        Dim directoryPath As String = "C:\YourDirectoryPath"

        ' Get the files in the directory
        Dim files As String() = Directory.GetFiles(directoryPath)

        ' Loop through each file and display its name
        For Each filePath As String In files
            Dim fileName As String = Path.GetFileName(filePath)
            Console.WriteLine(fileName)
        Next

        ' Keep the console window open
        Console.ReadLine()
    End Sub
    Private Sub adminlihat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilJenis()
        aturGrid()
    End Sub
End Class
