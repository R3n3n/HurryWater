Imports MySql.Data.MySqlClient
Module dbConnect
    Public cn As New MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String

    Public Sub connection()
        Try
            cn.Close()
            cn.ConnectionString = "server=localhost;user=root;password=;database=hurry_water_db"
            cn.Open()
            MsgBox("Connection Success!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Database connection error!", MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
