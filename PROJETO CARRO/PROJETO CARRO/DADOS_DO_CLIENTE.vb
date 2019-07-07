Public Class DADOS_DO_CLIENTE

    Dim desconto As Single
    Private Sub BtnConcluirCompra_Click(sender As Object, e As EventArgs) Handles BtnConcluirCompra.Click




   



        If NOME_CLIENTE.Text = "" And CPF_CLIENTE.Text = "" And EMAIL_CLIENTE.Text = "" And CEL_CLIENTE.Text = "" Then

            MsgBox("CAMPOS >>> NOME CLIENTE, CPF CLIENTE, EMAIL, CEL, SE ENCONTRAM VAZIOS!!  ")




        ElseIf NOME_CLIENTE.Text = "" Then


            MsgBox("CAMPO NOME CLIENTE VAZIO")




        ElseIf CPF_CLIENTE.Text = "" Then


            MsgBox("CAMPO CPF VAZIO")




        ElseIf EMAIL_CLIENTE.Text = "" Then


            MsgBox("CAMPO EMAIL CLIENTE VAZIO")




        ElseIf CEL_CLIENTE.Text = "" Then
            MsgBox("CAMPO CEL  VAZIO")
        End If


        If BANCO.Text = "" And TIPO_CONTA.Text = "" And N_CONTA.Text = "" And AGENCIA.Text = "" Then

            MsgBox(" BANCO NÃO SELECIONADO, TIPO DE CONTA NÃO SELECIONADA, NUMERO DA CONTA VAZIA, NUMERO AGENCIA VAZIA")

        ElseIf BANCO.Text = "" Then


            MsgBox("CAMPO BANCO VAZIO")




        ElseIf TIPO_CONTA.Text = "" Then


            MsgBox("CAMPO TIPO DE CONTA VAZIO")




        ElseIf N_CONTA.Text = "" Then


            MsgBox("CAMPO NUMERO DA CONTA VAZIO")




        ElseIf AGENCIA.Text = "" Then
            MsgBox("CAMPO AGENCIA VAZIO")


        Else
            contadora = contadora + 1


            If contadora = 1 Then

                NomeCliente = NOME_CLIENTE.Text

                CPFCliente = CPF_CLIENTE.Text
                EmailCliente = EMAIL_CLIENTE.Text
                CelCliente = CEL_CLIENTE.Text
                parcelas1 = parcelas.Text
                entradacliente1 = entrada.Text
                carro_comprado1 = carro_comprado1
                DDDcliente1 = ddd.Text
                hora.Text = DateString
                ValorTotalDoCarroComprado = ValorTotalDoCarroComprado
                captar_hora_atual = hora.Text
                captar_hora_atual1 = captar_hora_atual

                desconto1 = ValorTotalDoCarroComprado * 10 / 100




            ElseIf contadora = 2 Then





                NomeCliente2 = NOME_CLIENTE.Text
                CPFCliente2 = CPF_CLIENTE.Text
                EmailCliente2 = EMAIL_CLIENTE.Text
                CelCliente2 = CEL_CLIENTE.Text
                parcelas2 = parcelas.Text
                carro_comprado2 = carro_comprado2
                entradacliente2 = entrada.Text
                ValorTotalDoCarroComprado2 = ValorTotalDoCarroComprado2
                hora.Text = DateString
                DDDcliente2 = ddd.Text
                captar_hora_atual = hora.Text
                captar_hora_atual2 = captar_hora_atual
                desconto2 = ValorTotalDoCarroComprado2 * 10 / 100


            ElseIf contadora = 3 Then



                NomeCliente3 = NOME_CLIENTE.Text
                CPFCliente3 = CPF_CLIENTE.Text
                EmailCliente3 = EMAIL_CLIENTE.Text
                CelCliente3 = CEL_CLIENTE.Text
                carro_comprado3 = carro_comprado3
                parcelas3 = parcelas.Text
                entradacliente3 = entrada.Text
                ValorTotalDoCarroComprado3 = ValorTotalDoCarroComprado3
                hora.Text = DateString
                DDDcliente3 = ddd.Text
                captar_hora_atual = hora.Text
                captar_hora_atual3 = captar_hora_atual
                desconto3 = ValorTotalDoCarroComprado3 * 10 / 100




            End If


            If contadora = 1 Then

                If confirmarprecoavista = 1 Then


                    ValorTotalDoCarroComprado = FormatCurrency(ValorTotalDoCarroComprado - desconto)
                End If

            ElseIf contadora = 2 Then
                If confirmarprecoavista = 1 Then

                    desconto = ValorTotalDoCarroComprado3 * 10 / 100
                    ValorTotalDoCarroComprado2 = FormatCurrency(ValorTotalDoCarroComprado2 - desconto)
                End If

            ElseIf contadora = 3 Then
                If confirmarprecoavista = 1 Then

                    desconto3 = ValorTotalDoCarroComprado3 * 10 / 100


                End If

            End If



            MsgBox("CARRO COMPRADO COM SUCESSO ")

            If contadora = 1 Then
                RELATORIO_FINAL_COMPRA.ShowDialog()

            ElseIf contadora = 2 Then
                RELATORIO_FINAL_COMPRA2.ShowDialog()

            ElseIf contadora = 3 Then
                RELATORIO_FINAL_COMPRA3.ShowDialog()



            End If

            NOME_CLIENTE.Text = ""
            CPF_CLIENTE.Text = ""
            EMAIL_CLIENTE.Text = ""
            CEL_CLIENTE.Text = ""
            parcelas.Text = ""
            entrada.Text = ""
            ddd.Text = ""
            BANCO.Text = ""
            TIPO_CONTA.Text = ""
            N_CONTA.Text = ""
            AGENCIA.Text = ""

           





            End If






    End Sub

    
    'PROIBINDO NUMERO NA CAIXA DE TEXTO'
    Private Sub NOME_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NOME_CLIENTE.KeyPress

      

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then

            e.Handled = True
        End If

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then

            e.Handled = True
        End If





    End Sub

   




    Private Sub CEL_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CEL_CLIENTE.KeyPress
        If Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then

            e.Handled = True
        End If


    End Sub




    Private Sub CPF_CLIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CPF_CLIENTE.KeyPress
        If Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then

            e.Handled = True
        End If
        'limitando a quantidade de numeros que sera incluida na text box'
        CPF_CLIENTE.MaxLength = 11

      

    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles N_CONTA.KeyPress
        If Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then

            e.Handled = True
        End If

    End Sub




    Private Sub CEP_CLIENTE_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CPF_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles CPF_CLIENTE.TextChanged

    End Sub

    Private Sub CEL_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles CEL_CLIENTE.TextChanged
        CEL_CLIENTE.MaxLength = 8
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ddd_TextChanged(sender As Object, e As EventArgs) Handles ddd.TextChanged
        ddd.MaxLength = 3
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles N_CONTA.TextChanged
        N_CONTA.MaxLength = 16
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AGENCIA.KeyPress
        If Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then

            e.Handled = True
        End If

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles AGENCIA.TextChanged
        AGENCIA.MaxLength = 3
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BANCO.SelectedIndexChanged

    End Sub

    Private Sub NOME_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles NOME_CLIENTE.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DADOS_DO_CLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AVISTA.Checked = True Then

            AVISTA.Checked = False

        End If
    End Sub

    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click
        Me.Close()
        Voyage_Cores.Close()
        Saveiro_Cores.Close()
        Crossfox_Cores.Close()
        Cross.Close()
        Spacefox_Cores.Close()



    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub AVISTA_CheckedChanged(sender As Object, e As EventArgs) Handles AVISTA.CheckedChanged
        If AVISTA.Checked = True Then
            precoavista = 0.1
            confirmarprecoavista = 1
            parcelas.Text = "XXXXX"
            entrada.Text = "XXXXXXXXXXXXXXXXX"

        Else
            parcelas.Text = ""
            entrada.Text = ""
            confirmarprecoavista = 0
        End If
    End Sub
End Class