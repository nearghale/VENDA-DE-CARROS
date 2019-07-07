<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DADOS_DO_CLIENTE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DADOS_DO_CLIENTE))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NOME_CLIENTE = New System.Windows.Forms.TextBox()
        Me.CPF_CLIENTE = New System.Windows.Forms.TextBox()
        Me.EMAIL_CLIENTE = New System.Windows.Forms.TextBox()
        Me.N_CONTA = New System.Windows.Forms.TextBox()
        Me.AGENCIA = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnConcluirCompra = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.hora = New System.Windows.Forms.Label()
        Me.CEL_CLIENTE = New System.Windows.Forms.TextBox()
        Me.ddd = New System.Windows.Forms.TextBox()
        Me.BANCO = New System.Windows.Forms.ComboBox()
        Me.TIPO_CONTA = New System.Windows.Forms.ComboBox()
        Me.Btn_fechar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.entrada = New System.Windows.Forms.TextBox()
        Me.AVISTA = New System.Windows.Forms.CheckBox()
        Me.parcelas = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_fechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(31, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CPF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(31, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tipo de Conta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(166, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(272, 28)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DADOS BANCARIOS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(33, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "N° Conta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(183, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(246, 28)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "DADOS PESSOAIS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(35, 394)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 24)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Agência"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(35, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 24)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Banco"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(33, 149)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 24)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "E-mail"
        '
        'NOME_CLIENTE
        '
        Me.NOME_CLIENTE.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOME_CLIENTE.Location = New System.Drawing.Point(188, 62)
        Me.NOME_CLIENTE.Name = "NOME_CLIENTE"
        Me.NOME_CLIENTE.Size = New System.Drawing.Size(397, 21)
        Me.NOME_CLIENTE.TabIndex = 14
        '
        'CPF_CLIENTE
        '
        Me.CPF_CLIENTE.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPF_CLIENTE.Location = New System.Drawing.Point(90, 105)
        Me.CPF_CLIENTE.Name = "CPF_CLIENTE"
        Me.CPF_CLIENTE.Size = New System.Drawing.Size(244, 21)
        Me.CPF_CLIENTE.TabIndex = 20
        '
        'EMAIL_CLIENTE
        '
        Me.EMAIL_CLIENTE.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMAIL_CLIENTE.Location = New System.Drawing.Point(124, 152)
        Me.EMAIL_CLIENTE.Name = "EMAIL_CLIENTE"
        Me.EMAIL_CLIENTE.Size = New System.Drawing.Size(472, 21)
        Me.EMAIL_CLIENTE.TabIndex = 22
        '
        'N_CONTA
        '
        Me.N_CONTA.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_CONTA.Location = New System.Drawing.Point(153, 304)
        Me.N_CONTA.Name = "N_CONTA"
        Me.N_CONTA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.N_CONTA.Size = New System.Drawing.Size(181, 21)
        Me.N_CONTA.TabIndex = 23
        '
        'AGENCIA
        '
        Me.AGENCIA.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGENCIA.Location = New System.Drawing.Point(143, 397)
        Me.AGENCIA.Name = "AGENCIA"
        Me.AGENCIA.Size = New System.Drawing.Size(191, 21)
        Me.AGENCIA.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(405, 254)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'BtnConcluirCompra
        '
        Me.BtnConcluirCompra.BackColor = System.Drawing.Color.Black
        Me.BtnConcluirCompra.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConcluirCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnConcluirCompra.Location = New System.Drawing.Point(416, 553)
        Me.BtnConcluirCompra.Name = "BtnConcluirCompra"
        Me.BtnConcluirCompra.Size = New System.Drawing.Size(180, 45)
        Me.BtnConcluirCompra.TabIndex = 27
        Me.BtnConcluirCompra.Text = "Concluir"
        Me.BtnConcluirCompra.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(367, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 24)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Tel."
        '
        'hora
        '
        Me.hora.AutoSize = True
        Me.hora.Location = New System.Drawing.Point(448, 238)
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(0, 13)
        Me.hora.TabIndex = 29
        '
        'CEL_CLIENTE
        '
        Me.CEL_CLIENTE.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEL_CLIENTE.Location = New System.Drawing.Point(472, 111)
        Me.CEL_CLIENTE.Name = "CEL_CLIENTE"
        Me.CEL_CLIENTE.Size = New System.Drawing.Size(124, 21)
        Me.CEL_CLIENTE.TabIndex = 30
        '
        'ddd
        '
        Me.ddd.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddd.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.ddd.Location = New System.Drawing.Point(422, 110)
        Me.ddd.Name = "ddd"
        Me.ddd.Size = New System.Drawing.Size(43, 21)
        Me.ddd.TabIndex = 31
        Me.ddd.Text = "DDD"
        '
        'BANCO
        '
        Me.BANCO.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BANCO.FormattingEnabled = True
        Me.BANCO.Items.AddRange(New Object() {"HSBC", "ITAÚ", "BRADESCO", "SANTANDER", "BANCO DO BRASIL", "BANCO DA CAIXA"})
        Me.BANCO.Location = New System.Drawing.Point(155, 254)
        Me.BANCO.Name = "BANCO"
        Me.BANCO.Size = New System.Drawing.Size(179, 24)
        Me.BANCO.TabIndex = 32
        '
        'TIPO_CONTA
        '
        Me.TIPO_CONTA.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIPO_CONTA.FormattingEnabled = True
        Me.TIPO_CONTA.Items.AddRange(New Object() {"SALÁRIO", "CORRENTE", "POUPANÇA"})
        Me.TIPO_CONTA.Location = New System.Drawing.Point(207, 354)
        Me.TIPO_CONTA.Name = "TIPO_CONTA"
        Me.TIPO_CONTA.Size = New System.Drawing.Size(127, 24)
        Me.TIPO_CONTA.TabIndex = 33
        '
        'Btn_fechar
        '
        Me.Btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_fechar.Image = CType(resources.GetObject("Btn_fechar.Image"), System.Drawing.Image)
        Me.Btn_fechar.Location = New System.Drawing.Point(561, 9)
        Me.Btn_fechar.Name = "Btn_fechar"
        Me.Btn_fechar.Size = New System.Drawing.Size(35, 30)
        Me.Btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_fechar.TabIndex = 34
        Me.Btn_fechar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 531)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 24)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Parcelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(138, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 28)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "FORMA DE PAGAMENTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 574)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 24)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Entrada"
        '
        'entrada
        '
        Me.entrada.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entrada.Location = New System.Drawing.Point(135, 574)
        Me.entrada.Name = "entrada"
        Me.entrada.Size = New System.Drawing.Size(181, 21)
        Me.entrada.TabIndex = 39
        '
        'AVISTA
        '
        Me.AVISTA.AutoSize = True
        Me.AVISTA.BackColor = System.Drawing.Color.Transparent
        Me.AVISTA.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AVISTA.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AVISTA.Location = New System.Drawing.Point(35, 484)
        Me.AVISTA.Name = "AVISTA"
        Me.AVISTA.Size = New System.Drawing.Size(304, 25)
        Me.AVISTA.TabIndex = 40
        Me.AVISTA.Text = "A Vista com 10% de desconto"
        Me.AVISTA.UseVisualStyleBackColor = False
        '
        'parcelas
        '
        Me.parcelas.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parcelas.FormattingEnabled = True
        Me.parcelas.Items.AddRange(New Object() {"12X", "24X", "36X"})
        Me.parcelas.Location = New System.Drawing.Point(135, 531)
        Me.parcelas.Name = "parcelas"
        Me.parcelas.Size = New System.Drawing.Size(49, 24)
        Me.parcelas.TabIndex = 36
        '
        'DADOS_DO_CLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(608, 610)
        Me.ControlBox = False
        Me.Controls.Add(Me.AVISTA)
        Me.Controls.Add(Me.entrada)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.parcelas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_fechar)
        Me.Controls.Add(Me.TIPO_CONTA)
        Me.Controls.Add(Me.BANCO)
        Me.Controls.Add(Me.ddd)
        Me.Controls.Add(Me.CEL_CLIENTE)
        Me.Controls.Add(Me.hora)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BtnConcluirCompra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AGENCIA)
        Me.Controls.Add(Me.N_CONTA)
        Me.Controls.Add(Me.EMAIL_CLIENTE)
        Me.Controls.Add(Me.CPF_CLIENTE)
        Me.Controls.Add(Me.NOME_CLIENTE)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DADOS_DO_CLIENTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DADOS_DO_CLIENTE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_fechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents NOME_CLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents CPF_CLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents EMAIL_CLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents N_CONTA As System.Windows.Forms.TextBox
    Friend WithEvents AGENCIA As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnConcluirCompra As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents hora As System.Windows.Forms.Label
    Friend WithEvents CEL_CLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents ddd As System.Windows.Forms.TextBox
    Friend WithEvents BANCO As System.Windows.Forms.ComboBox
    Friend WithEvents TIPO_CONTA As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_fechar As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents entrada As System.Windows.Forms.TextBox
    Friend WithEvents AVISTA As System.Windows.Forms.CheckBox
    Friend WithEvents parcelas As System.Windows.Forms.ComboBox
End Class
