Public Class Saveiro_Cores

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Saveiro\nova_saveiro_cores_branco.jpg")

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles cor_vermelho.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Saveiro\nova_saveiro_cores_vermelho.jpg")
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles cor_preto.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Saveiro\nova_saveiro_cores_preto.jpg")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles cor_azul.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Saveiro\nova_saveiro_cores_blue_night.jpg")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles cor_branco.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Saveiro\nova_saveiro_cores_branco.jpg")
    End Sub

    

    Private Sub conforto_saveiro_CheckedChanged(sender As Object, e As EventArgs) Handles conforto_saveiro.CheckedChanged

        If conforto_saveiro.Checked = True Then

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\CONFORTO_COMPLETO.jpg")

        ElseIf conforto_saveiro.Checked = True And modulo_saveiro.Checked = True Then

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\CONFORTO+MODULO.jpg")

        Else

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PADRAO.jpg")


        End If


    End Sub



    Private Sub modulo_saveiro_CheckedChanged(sender As Object, e As EventArgs) Handles modulo_saveiro.CheckedChanged

        If modulo_saveiro.Checked = True Then

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\MODULO_PLUS.jpg")


        ElseIf conforto_saveiro.Checked = True And modulo_saveiro.Checked = True Then

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\CONFORTO+MODULO.jpg")

        Else

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PADRAO.jpg")


        End If
    End Sub

    Private Sub composition_saveiro_CheckedChanged(sender As Object, e As EventArgs) Handles composition_saveiro.CheckedChanged

        If composition_saveiro.Checked = True Then

            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PAINEL_COMPOSITION.jpg")


     
        Else

            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PAINEL_PADRAO.jpg")


        End If

    End Sub

    Private Sub media_saveiro_CheckedChanged(sender As Object, e As EventArgs) Handles media_saveiro.CheckedChanged

        If media_saveiro.Checked = True Then

            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PAINEL_MEDIA.jpg")



        Else

            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PAINEL_PADRAO.jpg")


        End If
    End Sub
End Class