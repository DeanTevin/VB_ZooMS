Imports MySql.Data.MySqlClient
Imports ZooMS.koneksi


Public Class Medicine
    Dim conn As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim CMD As New MySqlCommand
    Dim data As New MySqlDataAdapter
    Dim table As New DataTable()

    Dim ds As New DataSet
    Dim reader As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "INSERT INTO medicine (MedicineName,Stock) VALUES('" & NewMedName.Text & "','" & NewMedStock.Text & "')"
            CMD.Connection = conn
            CMD.ExecuteNonQuery()
            MsgBox("New Data Inserted", MsgBoxStyle.Information, "information")
        Catch ex As Exception
            MsgBox("New Data insert failed", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from medicine "
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                Dim Medname = reader.GetString("MedicineName")
                ComboBox1.Items.Add(Medname)
                ComboBox2.Items.Add(Medname)
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub
End Class