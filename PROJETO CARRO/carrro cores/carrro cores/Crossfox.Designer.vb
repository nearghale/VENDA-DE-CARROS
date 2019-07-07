<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cross
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cross))
        Me.receberimg = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_saveiro = New System.Windows.Forms.Button()
        Me.btn_Voyage = New System.Windows.Forms.Button()
        Me.btn_Fox = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.receberimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'receberimg
        '
        Me.receberimg.Image = CType(resources.GetObject("receberimg.Image"), System.Drawing.Image)
        Me.receberimg.Location = New System.Drawing.Point(139, 66)
        Me.receberimg.Name = "receberimg"
        Me.receberimg.Size = New System.Drawing.Size(389, 201)
        Me.receberimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.receberimg.TabIndex = 0
        Me.receberimg.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(36, 236)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 31)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(36, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(72, 31)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(36, 81)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(72, 31)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cores"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(36, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 31)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btn_saveiro
        '
        Me.btn_saveiro.Location = New System.Drawing.Point(646, 122)
        Me.btn_saveiro.Name = "btn_saveiro"
        Me.btn_saveiro.Size = New System.Drawing.Size(75, 23)
        Me.btn_saveiro.TabIndex = 6
        Me.btn_saveiro.Text = "Saveiro"
        Me.btn_saveiro.UseVisualStyleBackColor = True
        '
        'btn_Voyage
        '
        Me.btn_Voyage.Location = New System.Drawing.Point(646, 66)
        Me.btn_Voyage.Name = "btn_Voyage"
        Me.btn_Voyage.Size = New System.Drawing.Size(75, 23)
        Me.btn_Voyage.TabIndex = 7
        Me.btn_Voyage.Text = "Voyage"
        Me.btn_Voyage.UseVisualStyleBackColor = True
        '
        'btn_Fox
        '
        Me.btn_Fox.Location = New System.Drawing.Point(646, 186)
        Me.btn_Fox.Name = "btn_Fox"
        Me.btn_Fox.Size = New System.Drawing.Size(75, 23)
        Me.btn_Fox.TabIndex = 8
        Me.btn_Fox.Text = "Fox"
        Me.btn_Fox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(646, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Golf"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cross
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 510)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Fox)
        Me.Controls.Add(Me.btn_Voyage)
        Me.Controls.Add(Me.btn_saveiro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.receberimg)
        Me.Name = "Cross"
        Me.Text = "Crossfox"
        CType(Me.receberimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents receberimg As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_saveiro As System.Windows.Forms.Button
    Friend WithEvents btn_Voyage As System.Windows.Forms.Button
    Friend WithEvents btn_Fox As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
