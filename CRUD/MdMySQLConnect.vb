Imports MySql.Data.MySqlClient

Module MdMySQLConnect
    Dim constring = "Server=localhost; Database=db_latihan;User=root;Password="
    Public Koneksi As New MySqlConnection(constring)

    Public da As MySqlDataAdapter = Nothing
    Public cmd As MySqlCommand = Nothing
    Public dt As New DataTable
    Public dr As MySqlDataReader

    Public Ketemu = False

    Public Sub konek()

        Try
            If Not Koneksi Is Nothing Then Koneksi.Close()
            Koneksi.Open()
            'MsgBox("Konesi berhasil dilakukan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Diskonek()
        Koneksi.Close()
        Return Koneksi
    End Function

End Module
