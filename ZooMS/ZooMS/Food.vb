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
        If String.IsNullOrEmpty(ComboBox1.Text) Then
            MsgBox("Food Name Cannot be Empty", MsgBoxStyle.Information, "information")
        Else
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
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If String.IsNullOrEmpty(ComboBox1.Text) Then
            MsgBox("Food Name Cannot be Empty", MsgBoxStyle.Information, "information")
        Else
            qty = Convert.ToInt32(TextBox2.Text)
            stock = Convert.ToInt32(TextBox1.Text)
            Result = stock + qty
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ManagementMenu.Show()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class