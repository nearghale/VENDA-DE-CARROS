Public Class Fox
    Dim preco As Double
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        preco = 30000 + 1500
        txt_result.Text = FormatCurrency(preco)
        PictureBox1.Image = Image.FromFile("F:\Volks img\Fox\branco-cristal.jpg")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        preco = 30000 + 1600
        txt_result.Text = FormatCurrency(preco)
        PictureBox1.Image = Image.FromFile("F:\Volks img\Fox\azul-silk.jpg")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        preco = 30000 + 1520
        txt_result.Text = FormatCurrency(preco)
        PictureBox1.Image = Image.FromFile("F:\Volks img\Fox\vermelho-tornado.jpg")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        preco = 30000 + 555
        txt_result.Text = FormatCurrency(preco)
        PictureBox1.Image = Image.FromFile("F:\Volks img\Fox\preto-ninja.jpg")
    End Sub
End Class