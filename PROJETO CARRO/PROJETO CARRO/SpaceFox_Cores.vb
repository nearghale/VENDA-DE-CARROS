Public Class Spacefox_Cores
    Dim carro_selecionado As String
    Public valor_do_carro As Integer = 62820
    Public valorCalculado As String
    Dim componentesSpacefox(2) As String
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        PictureBox1.Image = Image.FromFile("F:\Volks img\SpaceFOX\BRANCO.jpg")

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        PictureBox1.Image = Image.FromFile("F:\Volks img\SpaceFOX\AZUL.jpg")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        PictureBox1.Image = Image.FromFile("F:\Volks img\SpaceFOX\VERMELHO.jpg")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click


        PictureBox1.Image = Image.FromFile("F:\Volks img\SpaceFOX\PRETO.jpg")
    End Sub


    Private Sub Acesso_SpaceFox_CheckedChanged(sender As Object, e As EventArgs) Handles Acesso_SpaceFox.CheckedChanged
        If Acesso_SpaceFox.Checked Then

            componentesSpacefox(0) = "ACESSO FACIL 4 PORTAS"

            SomarComponentes(970)

            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\SpaceFox\painel_4portas.jpg")
        Else
            componentesSpacefox(0) = ""
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\SpaceFox\painel_padrao.jpg")
            SubtrairComponentes(970)
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)
    End Sub

    Private Sub Modulo_SpaceFox_CheckedChanged(sender As Object, e As EventArgs) Handles Modulo_SpaceFox.CheckedChanged
        If Modulo_SpaceFox.Checked Then

            componentesSpacefox(1) = "+ CONFORT PLUS"

            SomarComponentes(2350)

            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\SpaceFox\painel_modulo.jpg")

        Else
            componentesSpacefox(1) = ""
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\SpaceFox\painel_padrao.jpg")
            SubtrairComponentes(2350)
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)
    End Sub

    Private Sub Modulo_Interative_CheckedChanged(sender As Object, e As EventArgs) Handles Modulo_Interative.CheckedChanged
        If Modulo_Interative.Checked = True Then

            componentesSpacefox(2) = " MODULO INTERATIVE"

            SomarComponentes(1450)

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\SpaceFox\space_modulo.jpg")
        Else
            componentesSpacefox(2) = ""
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\PROJETO CARRO\IMG  COMPONENTES\SpaceFox\Padrao.jpg")

            SubtrairComponentes(1450)
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)
    End Sub

    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click
        Me.Hide()

    End Sub

    Private Sub Spacefox_Cores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VALOR_TOTAL.Text = FormatCurrency(62820)
        If contadora = 1 Then
            Modulo_Interative.Checked = False
            Modulo_SpaceFox.Checked = False
            Acesso_SpaceFox.Checked = False
        ElseIf contadora = 2 Then
            Modulo_Interative.Checked = False
            Modulo_SpaceFox.Checked = False
            Acesso_SpaceFox.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        carro_selecionado = "SPACEFOX"
        If contadora = 0 Then
            carro_comprado1 = carro_selecionado
            ValorTotalDoCarroComprado = VALOR_TOTAL.Text
            componentesdoprimeirospacefox = String.Join(vbCrLf, componentesSpacefox)

        ElseIf contadora = 1 Then
            carro_comprado2 = carro_selecionado
            componentesdosegundospacefox = String.Join(vbCrLf, componentesSpacefox)
            ValorTotalDoCarroComprado2 = VALOR_TOTAL.Text
        ElseIf contadora = 2 Then
            carro_comprado3 = carro_selecionado
            ValorTotalDoCarroComprado3 = VALOR_TOTAL.Text
            componentesdoterceirospacefox = String.Join(vbCrLf, componentesSpacefox)
 

        End If
            ValorTotalDoCarroComprado = VALOR_TOTAL.Text
            DADOS_DO_CLIENTE.ShowDialog()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then

            componentesinclusosradiopadrao = "NENHUM COMPONENTE ADICIONADO PELO CLIENTE"
        Else

        End If
    End Sub

    Private Sub Acesso_SpaceFox_MouseClick(sender As Object, e As MouseEventArgs) Handles Acesso_SpaceFox.MouseClick

    End Sub
End Class