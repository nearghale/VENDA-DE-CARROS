Public Class Cross
    Dim carro_selecionado As String
    Public valor_do_carro As Integer = 33520
    Public valorCalculado As String
    Dim componentesUP(1) As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VALOR_TOTAL.Text = FormatCurrency(33520)
        If contadora = 1 Then
            modulo_up.Checked = False
            take_up.Checked = False
        ElseIf contadora = 2 Then
            modulo_up.Checked = False
            take_up.Checked = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        receberimg.Image = Image.FromFile("F:\Volks img\UP\preto-ninja.jpg")

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        receberimg.Image = Image.FromFile("F:\Volks img\UP\azul-night.jpg")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        receberimg.Image = Image.FromFile("F:\Volks img\UP\branco-cristal.jpg")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        receberimg.Image = Image.FromFile("F:\Volks img\UP\vermelho-flash.jpg")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)


    End Sub

    Private Sub receberimg_Click(sender As Object, e As EventArgs) Handles receberimg.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Modulo_SpaceFox_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub modulo_up_CheckedChanged(sender As Object, e As EventArgs) Handles modulo_up.CheckedChanged
        If modulo_up.Checked = True Then

            componentesUP(0) = "MODULO 4 PORTAS"

            SomarComponentes(2300)

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\UP\modulo_up.jpg")

        ElseIf modulo_up.Checked = True And take_up.Checked = True Then
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\UP\modulo+take_exterior.jpg")
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\UP\modulo+take_interior.jpg")

        Else
            componentesUP(0) = ""
            SubtrairComponentes(2300)
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\UP\up_padrao.jpg")
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\UP\painel_padrao1.jpg")
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)
    End Sub

    Private Sub take_up_CheckedChanged(sender As Object, e As EventArgs) Handles take_up.CheckedChanged
        If take_up.Checked = True Then

            componentesUP(1) = "+ TAKE COMPLETO"

            SomarComponentes(4670)

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\UP\take_up.jpg")
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\UP\take_painel.jpg")

        ElseIf take_up.Checked = True And modulo_up.Checked = True Then
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\UP\modulo+take_exterior.jpg")
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\UP\modulo+take_interior.jpg")
        Else
            componentesUP(1) = ""
            SubtrairComponentes(4670)
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\UP\up_padrao.jpg")
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\UP\painel_padrao1.jpg")
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)
    End Sub

    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click
        Me.Hide()

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Button1.Click
        carro_selecionado = "UP"
        If contadora = 0 Then
            carro_comprado1 = carro_selecionado
            ValorTotalDoCarroComprado = VALOR_TOTAL.Text
            componentesdoprimeiroup = String.Join(vbCrLf, componentesUP)

        ElseIf contadora = 1 Then
            carro_comprado2 = carro_selecionado
            ValorTotalDoCarroComprado2 = VALOR_TOTAL.Text
            componentesdosegundoup = String.Join(vbCrLf, componentesUP)

        ElseIf contadora = 2 Then
            carro_comprado3 = carro_selecionado
            ValorTotalDoCarroComprado3 = VALOR_TOTAL.Text
            componentesdoterceiroup = String.Join(vbCrLf, componentesUP)
       
        End If
            ValorTotalDoCarroComprado = VALOR_TOTAL.Text
            DADOS_DO_CLIENTE.ShowDialog()
    End Sub
End Class
'   