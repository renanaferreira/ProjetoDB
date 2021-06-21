<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFunc
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
        Me.emTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nifTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.telTB = New System.Windows.Forms.TextBox()
        Me.morTB = New System.Windows.Forms.TextBox()
        Me.nomeTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lojaTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'emTB
        '
        Me.emTB.Location = New System.Drawing.Point(260, 276)
        Me.emTB.Name = "emTB"
        Me.emTB.Size = New System.Drawing.Size(100, 22)
        Me.emTB.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Email"
        '
        'nifTB
        '
        Me.nifTB.AcceptsTab = True
        Me.nifTB.Location = New System.Drawing.Point(260, 49)
        Me.nifTB.Name = "nifTB"
        Me.nifTB.Size = New System.Drawing.Size(100, 22)
        Me.nifTB.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "NIF"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'telTB
        '
        Me.telTB.Location = New System.Drawing.Point(260, 224)
        Me.telTB.Name = "telTB"
        Me.telTB.Size = New System.Drawing.Size(100, 22)
        Me.telTB.TabIndex = 28
        '
        'morTB
        '
        Me.morTB.Location = New System.Drawing.Point(260, 156)
        Me.morTB.Name = "morTB"
        Me.morTB.Size = New System.Drawing.Size(100, 22)
        Me.morTB.TabIndex = 27
        '
        'nomeTB
        '
        Me.nomeTB.AcceptsTab = True
        Me.nomeTB.Location = New System.Drawing.Point(260, 96)
        Me.nomeTB.Name = "nomeTB"
        Me.nomeTB.Size = New System.Drawing.Size(100, 22)
        Me.nomeTB.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "telefone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Morada"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nome"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(454, 53)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(35, 17)
        Me.LinkLabel1.TabIndex = 34
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Loja"
        '
        'lojaTB
        '
        Me.lojaTB.Location = New System.Drawing.Point(605, 53)
        Me.lojaTB.Name = "lojaTB"
        Me.lojaTB.ReadOnly = True
        Me.lojaTB.Size = New System.Drawing.Size(100, 22)
        Me.lojaTB.TabIndex = 35
        '
        'add_func
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lojaTB)
        Me.Controls.Add(Me.LinkLabel1)
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
        Me.Name = "add_func"
        Me.Text = "add_func"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents emTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nifTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents telTB As TextBox
    Friend WithEvents morTB As TextBox
    Friend WithEvents nomeTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lojaTB As TextBox
End Class
