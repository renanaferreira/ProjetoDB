<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormForn
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.telTB = New System.Windows.Forms.TextBox()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.morTB = New System.Windows.Forms.TextBox()
        Me.nomeTB = New System.Windows.Forms.TextBox()
        Me.nifTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Atualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'telTB
        '
        Me.telTB.Location = New System.Drawing.Point(476, 275)
        Me.telTB.Name = "telTB"
        Me.telTB.Size = New System.Drawing.Size(100, 22)
        Me.telTB.TabIndex = 21
        '
        'emailTB
        '
        Me.emailTB.Location = New System.Drawing.Point(476, 199)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(100, 22)
        Me.emailTB.TabIndex = 20
        '
        'morTB
        '
        Me.morTB.Location = New System.Drawing.Point(476, 143)
        Me.morTB.Name = "morTB"
        Me.morTB.Size = New System.Drawing.Size(100, 22)
        Me.morTB.TabIndex = 19
        '
        'nomeTB
        '
        Me.nomeTB.Location = New System.Drawing.Point(476, 90)
        Me.nomeTB.Name = "nomeTB"
        Me.nomeTB.Size = New System.Drawing.Size(100, 22)
        Me.nomeTB.TabIndex = 18
        '
        'nifTB
        '
        Me.nifTB.Location = New System.Drawing.Point(476, 43)
        Me.nifTB.Name = "nifTB"
        Me.nifTB.ReadOnly = True
        Me.nifTB.Size = New System.Drawing.Size(100, 22)
        Me.nifTB.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "NIF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Telefone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Morada"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nome"
        '
        'FormForn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.telTB)
        Me.Controls.Add(Me.emailTB)
        Me.Controls.Add(Me.morTB)
        Me.Controls.Add(Me.nomeTB)
        Me.Controls.Add(Me.nifTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormForn"
        Me.Text = "FormForn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents telTB As TextBox
    Friend WithEvents emailTB As TextBox
    Friend WithEvents morTB As TextBox
    Friend WithEvents nomeTB As TextBox
    Friend WithEvents nifTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
