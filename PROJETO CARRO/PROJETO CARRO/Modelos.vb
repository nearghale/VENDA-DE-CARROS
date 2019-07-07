Public Class Modelos

    
    Private Sub Golf_Click(sender As Object, e As EventArgs) Handles Golf.Click
        Crossfox_Cores.ShowDialog()

    End Sub

    
    Private Sub Fox_Click(sender As Object, e As EventArgs) Handles Fox.Click
        Spacefox_Cores.ShowDialog()
        
    End Sub

    Private Sub Voyage_Click(sender As Object, e As EventArgs) Handles Voyage.Click
        Voyage_Cores.ShowDialog()
    End Sub

    Private Sub NovaSaveiro_Click(sender As Object, e As EventArgs) Handles NovaSaveiro.Click
        Saveiro_Cores.ShowDialog()
    End Sub

    Private Sub CrossFox_Click(sender As Object, e As EventArgs) Handles CrossFox.Click
        Cross.ShowDialog()

    End Sub

   
   

  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ULTIMAS_VENDAS.ShowDialog()

    End Sub

    Private Sub Modelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOGIN.Hide()




    End Sub

  


    Private Sub Btn_fechar_Click(sender As Object, e As EventArgs) Handles Btn_fechar.Click
        If MessageBox.Show("Deseja Sair ?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub



    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles Btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

   
End Class