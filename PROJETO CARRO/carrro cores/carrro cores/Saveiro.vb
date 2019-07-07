Public Class Saveiro

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Saveiro\nova_saveiro_cores_branco.jpg")

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Saveiro\nova_saveiro_cores_vermelho.jpg")
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Saveiro\nova_saveiro_cores_preto.jpg")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Saveiro\nova_saveiro_cores_blue_night.jpg")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Saveiro\nova_saveiro_cores_branco.jpg")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class