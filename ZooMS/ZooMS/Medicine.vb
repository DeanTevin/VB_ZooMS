Imports MySql.Data.MySqlClient
Imports ZooMS.koneksi


Public Class Medicine
    Dim conn As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim conn2 As New MySqlConnection("Server=localhost; user=root; database=zooms")
    Dim CMD As New MySqlCommand
    Dim data As New MySqlDataAdapter
    Dim table As New DataTable()

    Dim ds As New DataSet
    Dim reader As MySqlDataReader
    Dim stock, qty, Result As Integer

    Private Sub MedicineNew(sender As Object, e As EventArgs) Handles Button1.Click
        If NewMedName.Text.Equals("") And NewMedStock.Text.Equals("") Then
            MsgBox("Please Fill Medicine Name and Stock", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            conn2.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "select * from medicine where MedicineName='" & NewMedName.Text & "'"
                CMD.Connection = conn
                reader = CMD.ExecuteReader()

                If reader.HasRows Then
                    MsgBox("Name already exists!", MsgBoxStyle.Information, "information")
                Else
                    Try
                        CMD.CommandType = CommandType.Text
                        CMD.CommandText = "INSERT INTO medicine (MedicineName,Stock) VALUES('" & NewMedName.Text & "','" & NewMedStock.Text & "')"
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

    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles TabControl1.Click
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from medicine where MedicineName='" & ComboBox1.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox4.Text = reader.GetString("Stock")
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub MedicineTake(sender As Object, e As EventArgs) Handles Button5.Click
        qty = Convert.ToInt32(TextBox3.Text)
        stock = Convert.ToInt32(TextBox4.Text)
        Result = stock - qty
        If Result < 0 Then
            MsgBox("Quantity taken cannot exceeds stock, Transaction Failed", MsgBoxStyle.Information, "information")
        Else
            conn.Open()
            Try
                CMD.CommandType = CommandType.Text
                CMD.CommandText = "UPDATE medicine set Stock=" & Result & " WHERE MedicineName='" & ComboBox1.Text & "'"
                CMD.Connection = conn
                CMD.ExecuteNonQuery()
                TextBox4.Text = Result.ToString
                MsgBox("Transaction Success", MsgBoxStyle.Information, "information")
            Catch ex As Exception
                MsgBox("Transaction Failed", MsgBoxStyle.Information, "information")
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select * from medicine where MedicineName='" & ComboBox2.Text & "'"
            CMD.Connection = conn
            reader = CMD.ExecuteReader()

            While reader.Read
                TextBox6.Text = reader.GetString("Stock")
            End While

        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information, "information")
        End Try
        conn.Close()
    End Sub

    Private Sub MedicineAdd(sender As Object, e As EventArgs) Handles Button4.Click
        qty = Convert.ToInt32(TextBox3.Text)
        stock = Convert.ToInt32(TextBox4.Text)
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
                TextBox4.Text = Result.ToString
                MsgBox("Transaction Success", MsgBoxStyle.Information, "information")
            Catch ex As Exception
                MsgBox("Transaction Failed", MsgBoxStyle.Information, "information")
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub DeleteMedicine(sender As Object, e As EventArgs) Handles Button6.Click
        conn.Open()
        Try
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "Delete from medicine WHERE MedicineName='" & ComboBox2.Text & "'"
            CMD.Connection = conn
            CMD.ExecuteNonQuery()
            MsgBox("Deletion Success", MsgBoxStyle.Information, "information")
        Catch ex As Exception
            MsgBox("No Data to Delete", MsgBoxStyle.Information, "information")
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

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub NewMedStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NewMedStock.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

End Class