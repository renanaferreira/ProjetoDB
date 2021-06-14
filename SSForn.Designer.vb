<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSForn
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
        Me.MainList = New System.Windows.Forms.ListView()
        Me.nif = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.morada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MainList
        '
        Me.MainList.CheckBoxes = True
        Me.MainList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nif, Me.nome, Me.morada, Me.email, Me.tel})
        Me.MainList.FullRowSelect = True
        Me.MainList.HideSelection = False
        Me.MainList.Location = New System.Drawing.Point(1, 27)
        Me.MainList.Name = "MainList"
        Me.MainList.Size = New System.Drawing.Size(800, 423)
        Me.MainList.TabIndex = 0
        Me.MainList.UseCompatibleStateImageBehavior = False
        Me.MainList.View = System.Windows.Forms.View.Details
        '
        'nif
        '
        Me.nif.Text = "NIF"
        '
        'nome
        '
        Me.nome.Text = "Nome"
        '
        'morada
        '
        Me.morada.Text = "Morada"
        '
        'email
        '
        Me.email.Text = "Email"
        '
        'tel
        '
        Me.tel.Text = "Telefone"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, -2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SSForn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MainList)
        Me.Name = "SSForn"
        Me.Text = "SSForn"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainList As ListView
    Friend WithEvents nif As ColumnHeader
    Friend WithEvents nome As ColumnHeader
    Friend WithEvents morada As ColumnHeader
    Friend WithEvents email As ColumnHeader
    Friend WithEvents tel As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
