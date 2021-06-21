<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPes
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomeTB = New System.Windows.Forms.TextBox()
        Me.morTB = New System.Windows.Forms.TextBox()
        Me.telTB = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nifTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.emTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Morada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "telefone"
        '
        'nomeTB
        '
        Me.nomeTB.AcceptsTab = True
        Me.nomeTB.Location = New System.Drawing.Point(276, 95)
        Me.nomeTB.Name = "nomeTB"
        Me.nomeTB.Size = New System.Drawing.Size(100, 22)
        Me.nomeTB.TabIndex = 39
        '
        'morTB
        '
        Me.morTB.Location = New System.Drawing.Point(276, 155)
        Me.morTB.Name = "morTB"
        Me.morTB.Size = New System.Drawing.Size(100, 22)
        Me.morTB.TabIndex = 40
        '
        'telTB
        '
        Me.telTB.Location = New System.Drawing.Point(276, 223)
        Me.telTB.Name = "telTB"
        Me.telTB.Size = New System.Drawing.Size(100, 22)
        Me.telTB.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "NIF"
        '
        'nifTB
        '
        Me.nifTB.AcceptsTab = True
        Me.nifTB.Location = New System.Drawing.Point(276, 48)
        Me.nifTB.Name = "nifTB"
        Me.nifTB.Size = New System.Drawing.Size(100, 22)
        Me.nifTB.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Email"
        '
        'emTB
        '
        Me.emTB.Location = New System.Drawing.Point(276, 275)
        Me.emTB.Name = "emTB"
        Me.emTB.Size = New System.Drawing.Size(100, 22)
        Me.emTB.TabIndex = 46
        '
        'add_pes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.emTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nifTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.telTB)
        Me.Controls.Add(Me.morTB)
        Me.Controls.Add(Me.nomeTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "add_pes"
        Me.Text = "add_pes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nomeTB As TextBox
    Friend WithEvents morTB As TextBox
    Friend WithEvents telTB As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents nifTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents emTB As TextBox
End Class
