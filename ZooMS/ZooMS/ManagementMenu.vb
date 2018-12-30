Public Class ManagementMenu
    Private Sub ManagementMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If koneksi.Session.Equals("Doctor") Or koneksi.Session.Equals("Keeper") Then
            MsgBox("Access Denied", MsgBoxStyle.Information, "information")
        Else
            Me.Hide()
            Food.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If koneksi.Session.Equals("Doctor") Or koneksi.Session.Equals("Feeder") Then
            MsgBox("Access Denied", MsgBoxStyle.Information, "information")
        Else
            Me.Hide()
            Place.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If koneksi.Session.Equals("Feeder") Or koneksi.Session.Equals("Keeper") Then
            MsgBox("Access Denied", MsgBoxStyle.Information, "information")
        Else
            Me.Hide()
            Medicine.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If koneksi.Session.Equals("Doctor") Or koneksi.Session.Equals("Feeder") Then
            MsgBox("Access Denied", MsgBoxStyle.Information, "information")
        Else
            Me.Hide()
            Animals.Show()
        End If
    End Sub
End Class