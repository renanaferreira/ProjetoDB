<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLoja
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.armTB = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(390, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'telTB
        '
        Me.telTB.Location = New System.Drawing.Point(673, 96)
        Me.telTB.Name = "telTB"
        Me.telTB.Size = New System.Drawing.Size(100, 22)
        Me.telTB.TabIndex = 17
        '
        'emailTB
        '
        Me.emailTB.Location = New System.Drawing.Point(219, 98)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(100, 22)
        Me.emailTB.TabIndex = 16
        '
        'morTB
        '
        Me.morTB.Location = New System.Drawing.Point(673, 29)
        Me.morTB.Name = "morTB"
        Me.morTB.Size = New System.Drawing.Size(100, 22)
        Me.morTB.TabIndex = 15
        '
        'nomeTB
        '
        Me.nomeTB.AcceptsTab = True
        Me.nomeTB.Location = New System.Drawing.Point(219, 29)
        Me.nomeTB.Name = "nomeTB"
        Me.nomeTB.Size = New System.Drawing.Size(100, 22)
        Me.nomeTB.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(477, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Telefone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(477, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Morada"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nome"
        '
        'armTB
        '
        Me.armTB.Location = New System.Drawing.Point(219, 180)
        Me.armTB.Name = "armTB"
        Me.armTB.ReadOnly = True
        Me.armTB.Size = New System.Drawing.Size(100, 22)
        Me.armTB.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(188, 236)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 23)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Selecionar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(297, 236)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Anular"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Armazém Abastecedor"
        '
        'AddLoja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.armTB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.telTB)
        Me.Controls.Add(Me.emailTB)
        Me.Controls.Add(Me.morTB)
        Me.Controls.Add(Me.nomeTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddLoja"
        Me.Text = "add_loja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents telTB As TextBox
    Friend WithEvents emailTB As TextBox
    Friend WithEvents morTB As TextBox
    Friend WithEvents nomeTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents armTB As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
End Class
