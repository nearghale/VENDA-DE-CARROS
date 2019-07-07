<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.btnentrar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.EXIBIR_SENHA = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(26, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(26, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(146, 56)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(284, 29)
        Me.txtemail.TabIndex = 2
        '
        'txtsenha
        '
        Me.txtsenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsenha.Location = New System.Drawing.Point(146, 119)
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsenha.Size = New System.Drawing.Size(284, 29)
        Me.txtsenha.TabIndex = 3
        '
        'btnentrar
        '
        Me.btnentrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnentrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnentrar.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnentrar.Location = New System.Drawing.Point(261, 220)
        Me.btnentrar.Name = "btnentrar"
        Me.btnentrar.Size = New System.Drawing.Size(169, 40)
        Me.btnentrar.TabIndex = 4
        Me.btnentrar.Text = "ENTRAR"
        Me.btnentrar.UseVisualStyleBackColor = False
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnSair.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSair.Location = New System.Drawing.Point(32, 220)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(169, 40)
        Me.BtnSair.TabIndex = 5
        Me.BtnSair.Text = "SAIR"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'EXIBIR_SENHA
        '
        Me.EXIBIR_SENHA.AutoSize = True
        Me.EXIBIR_SENHA.BackColor = System.Drawing.Color.Transparent
        Me.EXIBIR_SENHA.Font = New System.Drawing.Font("Centaur", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXIBIR_SENHA.ForeColor = System.Drawing.SystemColors.Desktop
        Me.EXIBIR_SENHA.Location = New System.Drawing.Point(80, 170)
        Me.EXIBIR_SENHA.Name = "EXIBIR_SENHA"
        Me.EXIBIR_SENHA.Size = New System.Drawing.Size(145, 22)
        Me.EXIBIR_SENHA.TabIndex = 6
        Me.EXIBIR_SENHA.Text = "EXIBIR SENHA"
        Me.EXIBIR_SENHA.UseVisualStyleBackColor = False
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(475, 281)
        Me.Controls.Add(Me.EXIBIR_SENHA)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.btnentrar)
        Me.Controls.Add(Me.txtsenha)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtsenha As System.Windows.Forms.TextBox
    Friend WithEvents btnentrar As System.Windows.Forms.Button
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents EXIBIR_SENHA As System.Windows.Forms.CheckBox

End Class
