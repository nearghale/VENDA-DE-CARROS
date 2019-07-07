Public Class Crossfox_Cores
    Dim carro_selecionado As String
    Public valor_do_carro As Integer = 66850
    Public valorCalculado As String
    Dim componentesCrossfox(1) As String

    Private Sub cor_branco_Click(sender As Object, e As EventArgs) Handles cor_branco.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\CrossFOX\branco.jpg")
    End Sub

    Private Sub cor_vermelho_Click(sender As Object, e As EventArgs) Handles cor_vermelho.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\CrossFOX\vermelho.jpg")
    End Sub

    Private Sub cor_preto_Click(sender As Object, e As EventArgs) Handles cor_preto.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\CrossFOX\preto.jpg")
    End Sub

    Private Sub cor_azul_Click(sender As Object, e As EventArgs) Handles cor_azul.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\CrossFOX\azul.jpg")
    End Sub

    Private Sub composition_saveiro_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub modulo_elegance_CheckedChanged(sender As Object, e As EventArgs) Handles modulo_elegance.CheckedChanged
        If modulo_elegance.Checked = True Then

            componentesCrossfox(0) = "MODULO ELEGANCE"

            SomarComponentes(3699)

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\CROSSFOX\MODULO_EXTERIOR.jpg")
            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\CROSSFOX\MODULO_INTERIOR.jpg")
        ElseIf modulo_elegance.Checked = True And seguranca.Checked = True Then
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\CROSSFOX\MODULO+SEGURANÇA_EXTERIOR.jpg")
            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\CROSSFOX\MODULO+SEGURANÇA_INTERIOR.jpg")
        Else
            componentesCrossfox(0) = ""
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\CROSSFOX\EXTERIOR_PADRAO.jpg")
            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\CROSSFOX\INTERIOR_PADRAO.jpg")

            SubtrairComponentes(3699)

        End If

        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)
    End Sub

    Private Sub seguranca_CheckedChanged(sender As Object, e As EventArgs) Handles seguranca.CheckedChanged
        If seguranca.Checked = True Then

            componentesCrossfox(1) = "+  SEGURANÇA COM FUNÇÃO OFF-ROAD"

            SomarComponentes(1311)

            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\CROSSFOX\SEGURANÇA.jpg")
        ElseIf seguranca.Checked = True And modulo_elegance.Checked = True Then
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\CROSSFOX\MODULO+SEGURANÇA_EXTERIOR.jpg")
            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\CROSSFOX\MODULO+SEGURANÇA_INTERIOR.jpg")
        Else
            componentesCrossfox(1) = ""
            SubtrairComponentes(1311)
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\CROSSFOX\EXTERIOR_PADRAO.jpg")
            IMG_COMPONENTE_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\CROSSFOX\INTERIOR_PADRAO.jpg")
        End If

        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)
    End Sub

    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click
        Me.Hide()

    End Sub

    Private Sub Crossfox_Cores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VALOR_TOTAL.Text = FormatCurrency(66850)

        If contadora = 1 Then
            modulo_elegance.Checked = False
        ElseIf contadora = 2 Then
            modulo_elegance.Checked = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        carro_selecionado = "CROSSFOX"
        If contadora = 0 Then
            carro_comprado1 = carro_selecionado
            ValorTotalDoCarroComprado = VALOR_TOTAL.Text
            componentesdoprimeirocrossfox = String.Join(vbCrLf, componentesCrossfox)
        ElseIf contadora = 1 Then
            carro_comprado2 = carro_selecionado
            ValorTotalDoCarroComprado2 = VALOR_TOTAL.Text
            componentesdosegundocrossfox = String.Join(vbCrLf, componentesCrossfox)
        ElseIf contadora = 2 Then
            carro_comprado3 = carro_selecionado
            ValorTotalDoCarroComprado3 = VALOR_TOTAL.Text

            componentesdoterceirocrossfox = String.Join(vbCrLf, componentesCrossfox)

        End If


        ValorTotalDoCarroComprado = VALOR_TOTAL.Text
        DADOS_DO_CLIENTE.ShowDialog()
    End Sub
End Class