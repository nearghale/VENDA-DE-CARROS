Public Class Voyage_Cores
    Dim carro_selecionado As String
    Public valor_do_carro As Integer = 46400
    Public valorCalculado As String
    Dim componentesvoyage(3) As String



    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Voyage\voyage_highline_cores_branco.jpg")
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Voyage\voyage_highline_cores_branco.jpg")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Voyage\voyage_highline_cores_tungstenio.jpg")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Voyage\voyage_highline_cores_vermelho.jpg")
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox1.Image = Image.FromFile("F:\Volks img\Voyage\voyage_highline_cores_preto.jpg")
    End Sub




    Private Sub suporte_celular_CheckedChanged(sender As Object, e As EventArgs) Handles suporte_celular.CheckedChanged
        If suporte_celular.Checked Then
            componentesvoyage(0) = "SUPORTE CELULAR "
            SomarComponentes(300)

            componentesvoyage(0) = "SUPORTE CELULAR"
        Else
            SubtrairComponentes(300)
            componentesvoyage(0) = ""
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)



        If suporte_celular.Checked = True Then

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\SUPORTE_CELULAR_EXTERIOR.jpg")
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\SUPORTE_CELULAR_INTERIOR.jpg")

        ElseIf suporte_celular.Checked = True And urban_completo.Checked = True Then
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\SUPORTE+URBAN_EXTERIOR.jpg")
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\SUPORTE+URBAN_INTERIOR.jpg")

        Else
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\PADRAO.jpg")
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\PAINEL_PADRAO.jpg")
        End If
    End Sub






    Private Sub urban_completo_CheckedChanged(sender As Object, e As EventArgs) Handles urban_completo.CheckedChanged
        If urban_completo.Checked Then

            SomarComponentes(3410)
            componentesvoyage(1) = "URBAN COMPLETO"

        Else
            SubtrairComponentes(3410)
            componentesvoyage(1) = ""
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)

  

        If urban_completo.Checked = True Then

            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\URBAN_COMPLETO_EXTERIOR.jpg")
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\URBAN_COMPLETO_INTERIOR.jpg")

        ElseIf urban_completo.Checked = True And suporte_celular.Checked = True Then
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\SUPORTE+URBAN_EXTERIOR.jpg")
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\SUPORTE+URBAN_INTERIOR.jpg")

        Else
            IMG_COMPONENTES_EXTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\PADRAO.jpg")
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\PAINEL_PADRAO.jpg")
        End If

        
    End Sub







    Private Sub composition_voyage_CheckedChanged(sender As Object, e As EventArgs) Handles composition_voyage.CheckedChanged
        If composition_voyage.Checked Then

            componentesvoyage(2) = "INTERATIVIDADE COMPOSITION TOUCH INCLUIDA"

            SomarComponentes(1120)

        Else
            componentesvoyage(2) = ""
            SubtrairComponentes(1120)
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)


        If composition_voyage.Checked = True Then

            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\INTERATIVIDADE_COMPOSITON_VOYAGE.jpg")
        Else
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\PAINEL_PADRAO.jpg")
        End If
    End Sub

    Private Sub interatividade_navegação_CheckedChanged(sender As Object, e As EventArgs) Handles interatividade_navegação.CheckedChanged
        If interatividade_navegação.Checked Then

            componentesvoyage(3) = "INTERATIVADE COM NAVEGAÇÃO INCLUIDA"
            SomarComponentes(2390)

        Else
            componentesvoyage(3) = ""
            SubtrairComponentes(2390)
        End If
        VALOR_TOTAL.Text = FormatCurrency(valor_do_carro + valorCalculado)

        If interatividade_navegação.Checked Then

            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\INTERATIVIDADE_NAVEGACAO_VOYAGE.jpg")
        Else
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\PAINEL_PADRAO.jpg")
        End If
    End Sub

    Private Sub painel_padrao_CheckedChanged(sender As Object, e As EventArgs) Handles painel_padrao.CheckedChanged
        If painel_padrao.Checked = True Then
            componentesinclusosradiopadrao = "NENHUM COMPONENTE ADICIONADO PELO CLIENTE"
            IMG_COMPONENTES_INTERIOR.Image = Image.FromFile("F:\Volks img\Voyage\PAINEL_PADRAO.jpg")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        carro_selecionado = "VOYAGE"
        If contadora = 0 Then

            carro_comprado1 = carro_selecionado
            ValorTotalDoCarroComprado = VALOR_TOTAL.Text

            componentesdoprimeirovoyage = String.Join(vbCrLf, componentesvoyage)

        ElseIf contadora = 1 Then
            carro_comprado2 = carro_selecionado
            ValorTotalDoCarroComprado2 = VALOR_TOTAL.Text

            componentesdosegundovoyage = String.Join(vbCrLf, componentesvoyage)

        ElseIf contadora = 2 Then
            carro_comprado3 = carro_selecionado
            ValorTotalDoCarroComprado3 = VALOR_TOTAL.Text

            componentesdoterceirovoyage = String.Join(vbCrLf, componentesvoyage)


        End If




            DADOS_DO_CLIENTE.ShowDialog()






    End Sub

    Private Sub Voyage_Cores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VALOR_TOTAL.Text = FormatCurrency(46400)

        If contadora = 1 Then
            suporte_celular.Checked = False
            urban_completo.Checked = False
            composition_voyage.Checked = False
            interatividade_navegação.Checked = False
        ElseIf contadora = 2 Then
            suporte_celular.Checked = False
            urban_completo.Checked = False
            composition_voyage.Checked = False
            interatividade_navegação.Checked = False
        End If
    

    End Sub

    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)




       
    End Sub
End Class