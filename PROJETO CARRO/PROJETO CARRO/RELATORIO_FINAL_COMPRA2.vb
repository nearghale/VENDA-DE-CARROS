Public Class RELATORIO_FINAL_COMPRA2
    Dim desconto As Single
    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click
        Me.Hide()

    End Sub

    Private Sub parcelas_Click(sender As Object, e As EventArgs) Handles parcelas.Click

    End Sub

    Private Sub RELATORIO_FINAL_COMPRA2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If confirmarprecoavista = 1 Then

            nome_cliente2.Text = NomeCliente2
            carro_comprado_cliente2.Text = carro_comprado2
            Label4.Text = ""
            Label5.Text = "A VISTA"
            Label6.Text = "O CLIENTE TEVE UM DESCONTO DE 10%"
            pagar_por_mes.Text = FormatCurrency(ValorTotalDoCarroComprado2 - desconto2)
            Label8.Text = ""

        Else
            nome_cliente2.Text = NomeCliente2
            carro_comprado_cliente2.Text = carro_comprado2
            parcelas.Text = parcelas2
            entrada2.Text = FormatCurrency(entradacliente2)
            TOTAL_DA_COMPRA.Location = New Point(315, 263)
            TOTAL_DA_COMPRA.Text = FormatCurrency(ValorTotalDoCarroComprado2 - entrada2.Text)
            If parcelas.Text = "12X" Then
                pagar_por_mes.Text = FormatCurrency(TOTAL_DA_COMPRA.Text / 12)

            ElseIf parcelas.Text = "24X" Then
                pagar_por_mes.Text = FormatCurrency(TOTAL_DA_COMPRA.Text / 24)

            ElseIf parcelas.Text = "36X" Then
                pagar_por_mes.Text = FormatCurrency(TOTAL_DA_COMPRA.Text / 36)

            End If

            If carro_comprado_cliente2.Text = "VOYAGE" Then

                componentesadicionados.Text = componentesdosegundovoyage




            End If

            If carro_comprado_cliente2.Text = "UP" Then

                componentesadicionados.Text = componentesdosegundoup




            End If

            If carro_comprado_cliente2.Text = "SPACEFOX" Then

                componentesadicionados.Text = componentesdosegundospacefox

            End If


            If carro_comprado_cliente2.Text = "SAVEIRO" Then

                componentesadicionados.Text = componentesdosegundosaveiro




            End If
            If carro_comprado_cliente2.Text = "CROSSFOX" Then

                componentesadicionados.Text = componentesdosegundocrossfox




            End If



    

        End If

        If carro_comprado_cliente2.Text = "VOYAGE" Then

            componentesadicionados.Text = componentesdosegundovoyage



        End If

        If carro_comprado_cliente2.Text = "UP" Then

            componentesadicionados.Text = componentesdosegundoup

        End If

        If carro_comprado_cliente2.Text = "SPACEFOX" Then

            componentesadicionados.Text = componentesdosegundospacefox

        End If


        If carro_comprado_cliente2.Text = "SAVEIRO" Then

            componentesadicionados.Text = componentesdosegundosaveiro

        End If

        If carro_comprado_cliente2.Text = "CROSSFOX" Then

            componentesadicionados.Text = componentesdosegundocrossfox




        End If



    End Sub

    Private Sub TOTAL_DA_COMPRA_Click(sender As Object, e As EventArgs) Handles TOTAL_DA_COMPRA.Click

    End Sub

    Private Sub componentesadicionados_Click(sender As Object, e As EventArgs) Handles componentesadicionados.Click

    End Sub
End Class