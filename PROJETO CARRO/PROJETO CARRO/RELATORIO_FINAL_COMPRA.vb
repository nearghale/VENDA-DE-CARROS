Public Class RELATORIO_FINAL_COMPRA
    Dim desconto As Single

    Private Sub nome_cliente_Click(sender As Object, e As EventArgs) Handles nome_cliente.Click

    End Sub

    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click
        Me.Hide()

    End Sub

    Private Sub RELATORIO_FINAL_COMPRA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If confirmarprecoavista = 1 Then

            nome_cliente.Text = NomeCliente
            carro_comprado_cliente.Text = carro_comprado1
            Label4.Text = "A VISTA"
            Label6.Text = "O CLIENTE TEVE UM DESCONTO DE 10%"
            Label7.Text = ""
            pagar_por_mes.Text = FormatCurrency(ValorTotalDoCarroComprado - desconto1)
            Label8.Text = ""


            If carro_comprado_cliente.Text = "VOYAGE" Then

                componentesadicionados.Text = componentesdoprimeirovoyage




            End If

            If carro_comprado_cliente.Text = "UP" Then

                componentesadicionados.Text = componentesdoprimeiroup




            End If

            If carro_comprado_cliente.Text = "SPACEFOX" Then

                componentesadicionados.Text = componentesdoprimeirospacefox

            End If


            If carro_comprado_cliente.Text = "SAVEIRO" Then

                componentesadicionados.Text = componentesdoprimeirosaveiro




            End If
            If carro_comprado_cliente.Text = "CROSSFOX" Then

                componentesadicionados.Text = componentesdoprimeirocrossfox




            End If
        Else

            nome_cliente.Text = NomeCliente
            carro_comprado_cliente.Text = carro_comprado1
            parcelas.Text = parcelas1
            entrada.Text = FormatCurrency(entradacliente1)
            TOTAL_DA_COMPRA.Location = New Point(315, 263)
            TOTAL_DA_COMPRA.Text = FormatCurrency(ValorTotalDoCarroComprado - entrada.Text)
            If parcelas.Text = "12X" Then
                pagar_por_mes.Text = FormatCurrency(TOTAL_DA_COMPRA.Text / 12)

            ElseIf parcelas.Text = "24X" Then
                pagar_por_mes.Text = FormatCurrency(TOTAL_DA_COMPRA.Text / 24)

            ElseIf parcelas.Text = "36X" Then
                pagar_por_mes.Text = FormatCurrency(TOTAL_DA_COMPRA.Text / 36)

            End If

        End If

        If carro_comprado_cliente.Text = "VOYAGE" Then

            componentesadicionados.Text = componentesdoprimeirovoyage




        End If

        If carro_comprado_cliente.Text = "UP" Then

            componentesadicionados.Text = componentesdoprimeiroup




        End If

        If carro_comprado_cliente.Text = "SPACEFOX" Then

            componentesadicionados.Text = componentesdoprimeirospacefox

        End If


        If carro_comprado_cliente.Text = "SAVEIRO" Then

            componentesadicionados.Text = componentesdoprimeirosaveiro




        End If
        If carro_comprado_cliente.Text = "CROSSFOX" Then

            componentesadicionados.Text = componentesdoprimeirocrossfox




        End If


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles pagar_por_mes.Click

    End Sub

    Private Sub parcelas_Click(sender As Object, e As EventArgs) Handles parcelas.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub carro_comprado_cliente_Click(sender As Object, e As EventArgs) Handles carro_comprado_cliente.Click

    End Sub
End Class