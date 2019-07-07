Public Class ULTIMAS_VENDAS


  


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COLECAO_CLIENTES.SelectedIndexChanged

        If COLECAO_CLIENTES.Text = NomeCliente Then



            DADOS_CLIENTE.Text = NomeCliente
            EXIBIR_CPF.Text = CPFCliente
            EMAIL.Text = EmailCliente
            desocultar_CPF1.Text = "CPF"
            EXIBIR_TELEFONE_CELULAR.Text = CelCliente
            desocultar_TELEFONE1.Text = "TELEFONE"
            DDD.Text = "(" + DDDcliente1 + ")"
            EXIBIR_HORA_DATA.Text = captar_hora_atual1
            desocultar_DATA1.Text = "DATA"






        ElseIf COLECAO_CLIENTES.Text = NomeCliente2 Then


            DADOS_CLIENTE.Text = NomeCliente2
            EXIBIR_CPF.Text = CPFCliente2
            EMAIL.Text = EmailCliente2
            desocultar_CPF1.Text = "CPF"
            EXIBIR_TELEFONE_CELULAR.Text = CelCliente2
            DDD.Text = "(" + DDDcliente2 + ")"
            desocultar_TELEFONE1.Text = "TELEFONE"
            EXIBIR_HORA_DATA.Text = captar_hora_atual2
            desocultar_DATA1.Text = "DATA"




        ElseIf COLECAO_CLIENTES.Text = NomeCliente3 Then


            DADOS_CLIENTE.Text = NomeCliente3
            EXIBIR_CPF.Text = CPFCliente3
            EMAIL.Text = EmailCliente3
            desocultar_CPF1.Text = "CPF"
            EXIBIR_TELEFONE_CELULAR.Text = CelCliente3
            DDD.Text = "(" + DDDcliente3 + ")"
            desocultar_TELEFONE1.Text = "TELEFONE"
            EXIBIR_HORA_DATA.Text = captar_hora_atual3
            desocultar_DATA1.Text = "DATA"


        End If



    End Sub

    Private Sub ULTIMAS_VENDAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If contadora = 1 Then
            COLECAO_CLIENTES.Items.Add(NomeCliente)

        ElseIf contadora = 2 Then
            COLECAO_CLIENTES.Items.Remove(NomeCliente)
            COLECAO_CLIENTES.Items.Remove(NomeCliente2)
            COLECAO_CLIENTES.Items.Add(NomeCliente)
            COLECAO_CLIENTES.Items.Add(NomeCliente2)

        ElseIf contadora = 3 Then
            COLECAO_CLIENTES.Items.Remove(NomeCliente)
            COLECAO_CLIENTES.Items.Remove(NomeCliente2)
            COLECAO_CLIENTES.Items.Remove(NomeCliente3)
            COLECAO_CLIENTES.Items.Add(NomeCliente)
            COLECAO_CLIENTES.Items.Add(NomeCliente2)
            COLECAO_CLIENTES.Items.Add(NomeCliente3)
        End If
    End Sub

    Private Sub desocultar_CARRO1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RELATORIO_Click(sender As Object, e As EventArgs) Handles RELATORIO.Click
        If COLECAO_CLIENTES.Text = NomeCliente Then

            RELATORIO_FINAL_COMPRA.ShowDialog()


        ElseIf COLECAO_CLIENTES.Text = NomeCliente2 Then
            RELATORIO_FINAL_COMPRA2.ShowDialog()


        ElseIf COLECAO_CLIENTES.Text = NomeCliente3 Then
            RELATORIO_FINAL_COMPRA3.ShowDialog()


        End If
    End Sub

    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click
        Me.Hide()

    End Sub

    Private Sub Btn_minimizar_Click(sender As Object, e As EventArgs) Handles Btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class