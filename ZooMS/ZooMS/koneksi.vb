Imports MySql.Data.MySqlClient

Module koneksi

    Public Conn As New MySqlConnection
    Public MySQLReader As MySqlDataReader
    Public CMD As New MySqlCommand
    Public DA As New MySqlDataAdapter

    Public Session As String
    Public Sub Connect(ByVal server As String, ByVal user As String, ByVal pass As String, ByVal DB As String)
        If Conn.State = ConnectionState.Closed Then
            Dim myString As String = "server= " & server & ";user= " & user & "password= " & pass & ";database= " & DB & ";"
            Try
                Conn.ConnectionString = myString
                Conn.Open()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show("Koneksi Gagal" & vbCrLf & "Check Connection", "Connection to Server", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub disconnect()
        Try
            Conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
        End Try
    End Sub

End Module
