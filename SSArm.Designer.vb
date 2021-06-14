<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SSArm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim tel As System.Windows.Forms.ColumnHeader
        Me.MainList = New System.Windows.Forms.ListView()
        Me.cod_int = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.morada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.addBttn = New System.Windows.Forms.Button()
        Me.refreshBTN = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        tel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'tel
        '
        tel.Text = "Telefone"
        tel.Width = 88
        '
        'MainList
        '
        Me.MainList.CheckBoxes = True
        Me.MainList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cod_int, Me.nome, Me.email, Me.morada, tel})
        Me.MainList.FullRowSelect = True
        Me.MainList.HideSelection = False
        Me.MainList.LabelEdit = True
        Me.MainList.Location = New System.Drawing.Point(0, 32)
        Me.MainList.Name = "MainList"
        Me.MainList.Size = New System.Drawing.Size(800, 417)
        Me.MainList.TabIndex = 0
        Me.MainList.UseCompatibleStateImageBehavior = False
        Me.MainList.View = System.Windows.Forms.View.Details
        '
        'cod_int
        '
        Me.cod_int.Text = "Código Interno"
        Me.cod_int.Width = 114
        '
        'nome
        '
        Me.nome.Text = "Nome"
        Me.nome.Width = 72
        '
        'email
        '
        Me.email.Text = "Email"
        Me.email.Width = 78
        '
        'morada
        '
        Me.morada.Text = "Morada"
        Me.morada.Width = 79
        '
        'addBttn
        '
        Me.addBttn.Location = New System.Drawing.Point(176, 2)
        Me.addBttn.Name = "addBttn"
        Me.addBttn.Size = New System.Drawing.Size(88, 26)
        Me.addBttn.TabIndex = 1
        Me.addBttn.Text = "Adicionar"
        Me.addBttn.UseVisualStyleBackColor = True
        '
        'refreshBTN
        '
        Me.refreshBTN.Location = New System.Drawing.Point(95, 2)
        Me.refreshBTN.Name = "refreshBTN"
        Me.refreshBTN.Size = New System.Drawing.Size(75, 23)
        Me.refreshBTN.TabIndex = 2
        Me.refreshBTN.Text = "Refresh"
        Me.refreshBTN.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Fechar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SSArm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.refreshBTN)
        Me.Controls.Add(Me.addBttn)
        Me.Controls.Add(Me.MainList)
        Me.Name = "SSArm"
        Me.Text = "Armazéns"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainList As ListView
    Friend WithEvents cod_int As ColumnHeader
    Friend WithEvents email As ColumnHeader
    Friend WithEvents morada As ColumnHeader
    Friend WithEvents nome As ColumnHeader
    Friend WithEvents addBttn As Button
    Friend WithEvents refreshBTN As Button
    Friend WithEvents Button1 As Button
End Class
