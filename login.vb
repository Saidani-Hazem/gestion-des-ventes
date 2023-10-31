Public Class login
    Private Sub init()
        txt_username.Clear()
        txt_pwd.Clear()
    End Sub
    Private Sub btn_connexion_Click(sender As Object, e As EventArgs) Handles btn_connexion.Click
        Dim username As String = txt_username.Text
        Dim pwd As String = txt_pwd.Text

        If (username = "ADMIN") And (pwd = "1234") Then
            Me.Hide()
            Tab.WindowState = FormWindowState.Maximized
            Tab.Show()
        Else
            init()
            MsgBox("        Informations incorrecte")
        End If

    End Sub
    Private Sub btn_fermer_Click(sender As Object, e As EventArgs) Handles btn_fermer.Click
        init()
    End Sub
End Class
