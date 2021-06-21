<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddArm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomeTB = New System.Windows.Forms.TextBox()
        Me.morTB = New System.Windows.Forms.TextBox()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.telTB = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Morada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'nomeTB
        '
        Me.nomeTB.AcceptsTab = True
        Me.nomeTB.Location = New System.Drawing.Point(238, 63)
        Me.nomeTB.Name = "nomeTB"
        Me.nomeTB.Size = New System.Drawing.Size(100, 22)
        Me.nomeTB.TabIndex = 5
        '
        'morTB
        '
        Me.morTB.Location = New System.Drawing.Point(238, 123)
        Me.morTB.Name = "morTB"
        Me.morTB.Size = New System.Drawing.Size(100, 22)
        Me.morTB.TabIndex = 6
        '
        'emailTB
        '
        Me.emailTB.Location = New System.Drawing.Point(238, 191)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(100, 22)
        Me.emailTB.TabIndex = 7
        '
        'telTB
        '
        Me.telTB.Location = New System.Drawing.Point(238, 263)
        Me.telTB.Name = "telTB"
        Me.telTB.Size = New System.Drawing.Size(100, 22)
        Me.telTB.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'add_arm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.telTB)
        Me.Controls.Add(Me.emailTB)
        Me.Controls.Add(Me.morTB)
        Me.Controls.Add(Me.nomeTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "add_arm"
        Me.Text = "Inserir Armazém"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nomeTB As TextBox
    Friend WithEvents morTB As TextBox
    Friend WithEvents emailTB As TextBox
    Friend WithEvents telTB As TextBox
    Friend WithEvents Button1 As Button
End Class
