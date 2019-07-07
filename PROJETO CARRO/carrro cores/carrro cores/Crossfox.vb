Public Class Cross

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        receberimg.Image = Image.FromFile("F:\Volks img\Crossfox\preto-ninja.jpg")

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        receberimg.Image = Image.FromFile("F:\Volks img\Crossfox\laranja-sahara.jpg")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        receberimg.Image = Image.FromFile("F:\Volks img\Crossfox\branco-cristal (1).jpg")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        receberimg.Image = Image.FromFile("F:\Volks img\Crossfox\vermelho-tornado.jpg")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_saveiro.Click
        Saveiro.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Voyage.Click
        Voyage.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_Fox.Click
        Fox.ShowDialog()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Golf.ShowDialog()

    End Sub
End Class
'   