Public Class RELATORIO_FINAL_COMPRA3

    Private Sub RELATORIO_FINAL_COMPRA3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If confirmarprecoavista = 1 Then

            nome_cliente3.Text = NomeCliente3
            carro_comprado_cliente3.Text = carro_comprado3
            Label4.Text = "A VISTA"
            Label6.Text = "O CLIENTE TEVE UM DESCONTO DE 10%"
            Label7.Text = ""
            pagar_por_mes.Text = FormatCurrency(ValorTotalDoCarroComprado3 - desconto3)
            Label8.Text = ""


            If carro_comprado_cliente3.Text = "VOYAGE" Then

                componentesadicionados.Text = componentesdoterceirovoyage




            End If

            If carro_comprado_cliente3.Text = "UP" Then

                componentesadicionados.Text = componentesdoterceiroup




            End If

            If carro_comprado_cliente3.Text = "SPACEFOX" Then

                componentesadicionados.Text = componentesdoterceirospacefox

            End If


            If carro_comprado_cliente3.Text = "SAVEIRO" Then

                componentesadicionados.Text = componentesdoterceirosaveiro




            End If
            If carro_comprado_cliente3.Text = "CROSSFOX" Then

                componentesadicionados.Text = componentesdoterceirocrossfox




            End If

        Else


            nome_cliente3.Text = NomeCliente3
            carro_comprado_cliente3.Text = carro_comprado3
            parcelas.Text = parcelas3
            entrada3.Text = FormatCurrency(entradacliente3)
            TOTAL_DA_COMPRA.Location = New Point(315, 263)
            TOTAL_DA_COMPRA.Text = FormatCurrency(ValorTotalDoCarroComprado3 - entrada3.Text)
            If parcelas.Text = "12X" Then
                pagar_por_mes.Text = FormatCurrency(TOTAL_DA_COMPRA.Text / 12)

            ElseIf parcelas.Text = "24X" Then
                pagar_por_mes.Text = FormatCurrency(TOTAL_DA_COMPRA.Text / 24)

            ElseIf parcelas.Text = "36X" Then
                pagar_por_mes.Text = FormatCurrency(TOTAL_DA_COMPRA.Text / 36)

            End If

        End If
        If carro_comprado_cliente3.Text = "VOYAGE" Then

            componentesadicionados.Text = componentesdoterceirovoyage



        End If

        If carro_comprado_cliente3.Text = "UP" Then

            componentesadicionados.Text = componentesdoterceiroup


        End If

        If carro_comprado_cliente3.Text = "SPACEFOX" Then

            componentesadicionados.Text = componentesdoterceirospacefox


        End If

        If carro_comprado_cliente3.Text = "SAVEIRO" Then

            componentesadicionados.Text = componentesdoterceirosaveiro


        End If
        If carro_comprado_cliente3.Text = "CROSSFOX" Then

            componentesadicionados.Text = componentesdoterceirocrossfox




        End If

    End Sub

    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click
        Me.Hide()

    End Sub
End Class