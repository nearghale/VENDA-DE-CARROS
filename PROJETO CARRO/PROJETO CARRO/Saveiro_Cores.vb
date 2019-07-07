Public Class Saveiro_Cores
    Dim carro_selecionado As String
    Public valor_do_carro As Integer = 40790
    Public valorCalculado As String
    Dim componentesSaveiro(3) As String
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
        If conforto_saveiro.Checked Then

            componentesSaveiro(0) = "COMFORTO COMPLETO"

            SomarComponentes(4670)

        Else
            componentesSaveiro(0) = ""
            SubtrairComponentes(4670)
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)


        If conforto_saveiro.Checked = True Then

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\CONFORTO_COMPLETO.jpg")

        ElseIf conforto_saveiro.Checked = True And modulo_saveiro.Checked = True Then

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\CONFORTO+MODULO.jpg")

        Else

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PADRAO.jpg")


        End If


    End Sub



    Private Sub modulo_saveiro_CheckedChanged(sender As Object, e As EventArgs) Handles modulo_saveiro.CheckedChanged
        If modulo_saveiro.Checked Then


            componentesSaveiro(1) = "MÓDULO PLUS "

            SomarComponentes(3720)

        Else
            componentesSaveiro(1) = ""
            SubtrairComponentes(3720)
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)


        If modulo_saveiro.Checked = True Then

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\MODULO_PLUS.jpg")


        ElseIf conforto_saveiro.Checked = True And modulo_saveiro.Checked = True Then

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\CONFORTO+MODULO.jpg")

        Else

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PADRAO.jpg")


        End If
    End Sub

    Private Sub composition_saveiro_CheckedChanged(sender As Object, e As EventArgs) Handles composition_saveiro.CheckedChanged
        If composition_saveiro.Checked Then


            componentesSaveiro(2) = "INTERATIVIDADE COMPOSITION TOUCH"

            SomarComponentes(1700)

        Else
            componentesSaveiro(2) = ""
            SubtrairComponentes(1700)
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)


        If composition_saveiro.Checked = True Then



            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PAINEL_COMPOSITION.jpg")


     
        Else

            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PAINEL_PADRAO.jpg")


        End If

    End Sub

    Private Sub media_saveiro_CheckedChanged(sender As Object, e As EventArgs) Handles media_saveiro.CheckedChanged
        If media_saveiro.Checked Then


            componentesSaveiro(3) = "INTERATIVIDADE MEDIA"

            SomarComponentes(760)

        Else
            componentesSaveiro(3) = ""
            SubtrairComponentes(760)
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)
        If media_saveiro.Checked = True Then

            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PAINEL_MEDIA.jpg")



        Else

            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PAINEL_PADRAO.jpg")


        End If
    End Sub

    Private Sub painel_padrao_CheckedChanged(sender As Object, e As EventArgs) Handles painel_padrao.CheckedChanged
        If painel_padrao.Checked = True Then

            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\NOVA SAVEIRO\PAINEL_PADRAO.jpg")

        End If
    End Sub

    Private Sub Btn_Concluir_Compra_Click(sender As Object, e As EventArgs) Handles Btn_Concluir_Compra.Click
        carro_selecionado = "SAVEIRO"
        If contadora = 0 Then
            carro_comprado1 = carro_selecionado
            ValorTotalDoCarroComprado = VALOR_TOTAL.Text

            componentesdoprimeirosaveiro = String.Join(vbCrLf, componentesSaveiro)


        ElseIf contadora = 1 Then
            carro_comprado2 = carro_selecionado
            ValorTotalDoCarroComprado2 = VALOR_TOTAL.Text
            componentesdosegundosaveiro = String.Join(vbCrLf, componentesSaveiro)


        ElseIf contadora = 2 Then
            carro_comprado3 = carro_selecionado
            ValorTotalDoCarroComprado3 = VALOR_TOTAL.Text
            componentesdoterceirosaveiro = String.Join(vbCrLf, componentesSaveiro)


        End If
        DADOS_DO_CLIENTE.ShowDialog()
        ValorTotalDoCarroComprado = VALOR_TOTAL.Text






    End Sub

    Private Sub Saveiro_Cores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VALOR_TOTAL.Text = FormatCurrency(40790)
        If contadora = 1 Then
            conforto_saveiro.Checked = False
            modulo_saveiro.Checked = False
            painel_padrao.Checked = False
            composition_saveiro.Checked = False
            media_saveiro.Checked = False

        ElseIf contadora = 2 Then
            conforto_saveiro.Checked = False
            modulo_saveiro.Checked = False
            painel_padrao.Checked = False
            composition_saveiro.Checked = False
            media_saveiro.Checked = False

        End If
    End Sub

    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click
        Me.Hide()

    End Sub
End Class