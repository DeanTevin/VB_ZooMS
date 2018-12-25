Imports MySql.Data.MySqlClient
Imports ZooMS.koneksi

Public Class Food
    Dim conn As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim conn2 As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim CMD As New MySqlCommand
    Dim data As New MySqlDataAdapter
    Dim table As New DataTable()

    Dim ds As New DataSet
    Dim reader As MySqlDataReader
    Dim stock, qty, Result As Integer

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from food where FoodName='" & ComboBox1.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox1.Text = reader.GetString("Stock")
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub TakeFood(sender As Object, e As EventArgs) Handles Button1.Click
        qty = Convert.ToInt32(TextBox2.Text)
        stock = Convert.ToInt32(TextBox1.Text)
        Result = stock - qty
        If Result < 0 Then
            MsgBox("Quantity taken cannot exceeds stock, Transaction Failed", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "UPDATE food set Stock=" & Result & " WHERE FoodName='" & ComboBox1.Text & "'"
                CMD.Connection = conn
                CMD.ExecuteNonQuery()
                TextBox1.Text = Result.ToString
                MsgBox("Transaction Success", MsgBoxStyle.Information, "information")
            Catch ex As Exception
                MsgBox("Transaction Failed", MsgBoxStyle.Information, "information")
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        qty = Convert.ToInt32(TextBox2.Text)
        stock = Convert.ToInt32(TextBox1.Text)
        Result = stock + qty
        If Result < 0 Then
            MsgBox("Quantity taken cannot exceeds stock, Transaction Failed", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "UPDATE medicine set Stock=" & Result & " WHERE MedicineName='" & ComboBox1.Text & "'"
                CMD.Connection = conn
                CMD.ExecuteNonQuery()
                TextBox1.Text = Result.ToString
                MsgBox("Transaction Success", MsgBoxStyle.Information, "information")
            Catch ex As Exception
                MsgBox("Transaction Failed", MsgBoxStyle.Information, "information")
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub Food_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        foodcbbox()
    End Sub

    Public Sub foodcbbox()
        ComboBox1.Items.Clear()
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from food"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                Dim Foodname = reader.GetString("FoodName")
                ComboBox1.Items.Add(Foodname)
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

End Class