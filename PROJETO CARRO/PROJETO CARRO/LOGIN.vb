Public Class LOGIN

    


    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click


        If txtemail.Text = "" And txtsenha.Text = "" Then
            MsgBox("o campo email e campo senha não preenchidos!!!")


        ElseIf txtemail.Text = "" Then

            MsgBox("campo email não preenchido!!!")

        ElseIf txtsenha.Text = "" Then

            MsgBox("campo senha não preenchido!!!")



        ElseIf txtemail.Text = "celsius@gmail.com" And txtsenha.Text = "123" Then



            Modelos.ShowDialog()

            


        Else
            MsgBox("email ou senha incorretos")

        End If


    End Sub

 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Application.Exit()




    End Sub

    Private Sub BtnSair_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtnSair.KeyPress


    End Sub

    Private Sub LOGIN_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed


    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub EXIBIR_SENHA_CheckedChanged(sender As Object, e As EventArgs) Handles EXIBIR_SENHA.CheckedChanged
        If EXIBIR_SENHA.Checked = True Then

            txtsenha.PasswordChar = ""

        Else
            txtsenha.PasswordChar = "*"

        End If
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
