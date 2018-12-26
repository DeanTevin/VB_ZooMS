Imports ZooMS.koneksi

Public Class MainMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Check.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If koneksi.Session.Equals("Cleaner") Or koneksi.Session.Equals("Trainer") Then
            MsgBox("Access Denied", MsgBoxStyle.Information, "information")
        Else
            Me.Hide()
            ManagementMenu.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Login.Show()
    End Sub

End Class