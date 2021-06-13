<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbaLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lojas Amazon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gestão de Estoque"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Utilizador"
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(31, 247)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Senha"
        '
        'PassTextBox
        '
        Me.PassTextBox.Location = New System.Drawing.Point(34, 363)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PassTextBox.TabIndex = 5
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(163, 427)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(94, 23)
        Me.LoginButton.TabIndex = 6
        Me.LoginButton.Text = "Autenticar"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'AbaLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 623)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AbaLogin"
        Me.Text = "Aplicação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents LoginButton As Button
End Class
