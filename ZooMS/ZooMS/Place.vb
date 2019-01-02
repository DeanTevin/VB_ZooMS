Imports MySql.Data.MySqlClient
Imports ZooMS.koneksi

Public Class Place

    Dim conn As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim conn2 As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim CMD As New MySqlCommand
    Dim data As New MySqlDataAdapter
    Dim table As New DataTable()

    Dim ds As New DataSet
    Dim reader As MySqlDataReader

    Private Sub NewPlaceTab_Click(sender As Object, e As EventArgs) Handles NewPlaceTab.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ManagementMenu.Show()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If TextBox2.Text.Equals("") And TextBox9.Text.Equals("") And String.IsNullOrEmpty(ComboBox4.Text) Then
            MsgBox("Please Fill All Forms", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            conn2.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "select * from place where PlaceID ='" & TextBox2.Text & "'"
                CMD.Connection = conn
                reader = CMD.ExecuteReader()

                If reader.HasRows Then
                    MsgBox("PlaceID already exists!", MsgBoxStyle.Information, "information")
                Else
                    Try
                        CMD.CommandType = CommandType.Text
                        CMD.CommandText = "INSERT INTO place (PlaceID,PlaceName,Habitat) VALUES('" & TextBox2.Text & "','" & TextBox9.Text & "','" & ComboBox4.Text & "')"
                        CMD.Connection = conn2
                        CMD.ExecuteNonQuery()
                        MsgBox("New Data Inserted", MsgBoxStyle.Information, "information")
                    Catch ex As Exception
                        MsgBox("New Data insert failed", MsgBoxStyle.Information, "information")
                    End Try
                End If
            Catch ex As Exception
                MsgBox("No Connection", MsgBoxStyle.Information, "information")
            End Try
            conn.Close()
            conn2.Close()
        End If
    End Sub

    Private Sub Place_Load(sender As Object, e As EventArgs) Handles EditPlaceName.Click
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox5.Items.Clear()
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from Place"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                Dim PlaceID = reader.GetString("PlaceID")
                ComboBox2.Items.Add(PlaceID)
                ComboBox5.Items.Add(PlaceID)
                ComboBox1.Items.Add(PlaceID)
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from Place where PlaceID='" & ComboBox2.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox1.Text = reader.GetString("Habitat")
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from Place where PlaceID='" & ComboBox1.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox4.Text = reader.GetString("Habitat")
                TextBox3.Text = reader.GetString("PlaceName")
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from Place where PlaceID='" & ComboBox5.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox5.Text = reader.GetString("PlaceName")
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub ButtonUp_Click(sender As Object, e As EventArgs) Handles ButtonUp.Click
        If String.IsNullOrEmpty(ComboBox3.Text) And String.IsNullOrEmpty(ComboBox2.Text) Then
            MsgBox("Habitat Cannot be Empty", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "UPDATE place set Habitat= '" & ComboBox3.Text & "' WHERE PlaceID='" & ComboBox2.Text & "'"
                CMD.Connection = conn
                CMD.ExecuteNonQuery()
                TextBox1.Text = ComboBox3.Text
                MsgBox("Transaction Success", MsgBoxStyle.Information, "information")

            Catch ex As Exception
                MsgBox("Transaction Failed", MsgBoxStyle.Information, "information")
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        If String.IsNullOrEmpty(ComboBox1.Text) Then
            MsgBox("PlaceID Cannot be Empty", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "Delete from place WHERE PlaceID='" & ComboBox1.Text & "'"
                CMD.Connection = conn
                CMD.ExecuteNonQuery()
                MsgBox("Deletion Success", MsgBoxStyle.Information, "information")
            Catch ex As Exception
                MsgBox("No Data to Delete", MsgBoxStyle.Information, "information")
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox6.Text) And String.IsNullOrEmpty(ComboBox5.Text) Then
            MsgBox("Name Cannot be Empty", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "UPDATE place set PlaceName= '" & TextBox6.Text & "' WHERE PlaceID='" & ComboBox5.Text & "'"
                CMD.Connection = conn
                CMD.ExecuteNonQuery()
                TextBox5.Text = TextBox6.Text
                MsgBox("Transaction Success", MsgBoxStyle.Information, "information")

            Catch ex As Exception
                MsgBox("Transaction Failed", MsgBoxStyle.Information, "information")
            End Try
            conn.Close()
        End If
    End Sub

End Class