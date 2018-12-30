Imports MySql.Data.MySqlClient
Imports ZooMS.koneksi
Public Class Check
    Dim conn As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim conn2 As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim CMD As New MySqlCommand
    Dim data As New MySqlDataAdapter
    Dim table As New DataTable()

    Dim ds As New DataSet
    Dim reader As MySqlDataReader
    Dim stock, qty, Result As Integer
    Private Sub FoodStockTab_Click(sender As Object, e As EventArgs) Handles FoodCheckTab.Click

    End Sub

    Private Sub Check_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()

        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from food "
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                Dim FoodName = reader.GetString("FoodName")
                ComboBox1.Items.Add(FoodName)
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()

    End Sub

    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles TabControl1.Click
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from medicine "
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                Dim Medname = reader.GetString("MedicineName")
                ComboBox2.Items.Add(Medname)
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()

        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from animal "
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                Dim AnimName = reader.GetString("AnimalName")
                ComboBox3.Items.Add(AnimName)
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()

        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from place "
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                Dim PlaceID = reader.GetString("PlaceID")
                ComboBox4.Items.Add(PlaceID)
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
            CMD.CommandText = "select * from food where FoodName='" & ComboBox1.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox1.Text = reader.GetString("FoodID")
                TextBox2.Text = reader.GetString("Stock")
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
            CMD.CommandText = "select * from medicine where MedicineName='" & ComboBox2.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox4.Text = reader.GetString("MedicineID")
                TextBox3.Text = reader.GetString("Stock")
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from animal where AnimalName='" & ComboBox3.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox6.Text = reader.GetString("Species")
                TextBox5.Text = reader.GetString("ConditionAnim")
                TextBox7.Text = reader.GetString("PlaceName")
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from place where PlaceID='" & ComboBox4.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox9.Text = reader.GetString("PlaceName")
                TextBox8.Text = reader.GetString("Habitat")
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

End Class