Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If (txtUsername.Text <> "" And txtPassword.Text <> "") Then
            oUser.Login(txtUsername.Text, txtPassword.Text)
            If (login_valid = True) Then
                If (oUser.rolename = "admin") Then
                    Form1.Show()
                    Me.Hide()
                ElseIf (oUser.rolename = "dosen") Then
                    Form2.Show()
                    Me.Hide()

                ElseIf (oUser.rolename = "mahasiswa") Then
                    Form3.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Login tidak dikenal")

                End If
            Else

            End If
        Else
            MessageBox.Show("Username dan password wajib diisi!")
        End If
    End Sub
End Class