Imports MySql.Data.MySqlClient
Imports ZooMS.koneksi

Public Class Animals
    Dim conn As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim conn2 As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim CMD As New MySqlCommand
    Dim data As New MySqlDataAdapter
    Dim table As New DataTable()

    Dim ds As New DataSet
    Dim reader As MySqlDataReader

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ManagementMenu.Show()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If TextBox2.Text.Equals("") And TextBox9.Text.Equals("") And String.IsNullOrEmpty(ComboBox4.Text) And String.IsNullOrEmpty(ComboBox7.Text) Then
            MsgBox("Please Fill All Forms", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            conn2.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "select * from Animal where AnimalName ='" & TextBox2.Text & "'"
                CMD.Connection = conn
                reader = CMD.ExecuteReader()

                If reader.HasRows Then
                    MsgBox("Animal Name already exists!", MsgBoxStyle.Information, "information")
                Else
                    Try
                        CMD.CommandType = CommandType.Text
                        CMD.CommandText = "INSERT INTO Animal (AnimalName,Species,ConditionAnim,PlaceName) VALUES('" & TextBox2.Text & "','" & TextBox9.Text & "','" & ComboBox4.Text & "','" & ComboBox7.Text & "')"
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

    Private Sub Animals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox7.Items.Clear()
        ComboBox2.Items.Clear()
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from Place"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                Dim PlaceID = reader.GetString("PlaceID")
                ComboBox7.Items.Add(PlaceID)
                ComboBox2.Items.Add(PlaceID)
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub AnimalTab_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        ComboBox1.Items.Clear()
        ComboBox6.Items.Clear()
        ComboBox5.Items.Clear()
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from Animal"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                Dim AnimalName = reader.GetString("AnimalName")
                ComboBox6.Items.Add(AnimalName)
                ComboBox5.Items.Add(AnimalName)
                ComboBox1.Items.Add(AnimalName)
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
            CMD.CommandText = "select * from Animal where AnimalName='" & ComboBox1.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox1.Text = reader.GetString("Species")
                TextBox4.Text = reader.GetString("ConditionAnim")
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
            CMD.CommandText = "select * from Animal where AnimalName='" & ComboBox5.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox8.Text = reader.GetString("Species")
                TextBox3.Text = reader.GetString("PlaceName")
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from Animal where AnimalName='" & ComboBox6.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox7.Text = reader.GetString("Species")
                TextBox6.Text = reader.GetString("ConditionAnim")
                TextBox5.Text = reader.GetString("PlaceName")
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(ComboBox3.Text) And String.IsNullOrEmpty(ComboBox1.Text) Then
            MsgBox("Animal Name and Condition Cannot be Empty", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "UPDATE animal set ConditionAnim= '" & ComboBox3.Text & "' WHERE AnimalName='" & ComboBox1.Text & "'"
                CMD.Connection = conn
                CMD.ExecuteNonQuery()
                TextBox4.Text = ComboBox3.Text
                MsgBox("Transaction Success", MsgBoxStyle.Information, "information")

            Catch ex As Exception
                MsgBox("Transaction Failed", MsgBoxStyle.Information, "information")
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If String.IsNullOrEmpty(ComboBox2.Text) And String.IsNullOrEmpty(ComboBox5.Text) Then
            MsgBox("PlaceName and Animal Name Cannot be Empty", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "UPDATE animal set PlaceName= '" & ComboBox2.Text & "' WHERE AnimalName='" & ComboBox5.Text & "'"
                CMD.Connection = conn
                CMD.ExecuteNonQuery()
                TextBox3.Text = ComboBox2.Text
                MsgBox("Transaction Success", MsgBoxStyle.Information, "information")

            Catch ex As Exception
                MsgBox("Transaction Failed", MsgBoxStyle.Information, "information")
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If String.IsNullOrEmpty(ComboBox6.Text) Then
            MsgBox("PlaceName  Cannot be Empty", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "Delete from animal WHERE AnimalName='" & ComboBox6.Text & "'"
                CMD.Connection = conn
                CMD.ExecuteNonQuery()
                MsgBox("Deletion Success", MsgBoxStyle.Information, "information")
            Catch ex As Exception
                MsgBox("No Data to Delete", MsgBoxStyle.Information, "information")
            End Try
            conn.Close()
        End If
    End Sub
End Class