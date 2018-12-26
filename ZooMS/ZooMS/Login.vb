Imports MySql.Data.MySqlClient
Imports ZooMS.koneksi

Public Class Login
    Dim conn2 As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim CMD As New MySqlCommand
    Dim data As New MySqlDataAdapter
    Dim table As New DataTable()

    Dim ds As New DataSet
    Dim reader As MySqlDataReader
    Public Session As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn2.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from keeper where Username='" & TextBox1.Text & "' and Password ='" & TextBox2.Text & "'"
            CMD.Connection = conn2
            reader = CMD.ExecuteReader()

            If reader.Read Then
                koneksi.Session = reader("Department")
                MsgBox("Welcome " & reader("KeeperName"), MsgBoxStyle.Information, "information")
                TextBox1.Clear()
                TextBox2.Clear()
                Me.Hide()
                MainMenu.Show()
            Else
                MsgBox("Invalid Username and Password", MsgBoxStyle.Information, "information")
            End If
        Catch ex As Exception
            MsgBox("No Connection", MsgBoxStyle.Information, "information")
        End Try
        conn2.Close()
    End Sub
End Class
