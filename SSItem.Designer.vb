<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSItem
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
        Me.refreshBTN = New System.Windows.Forms.Button()
        Me.addBttn = New System.Windows.Forms.Button()
        Me.MainList = New System.Windows.Forms.ListView()
        Me.cod_int = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.preco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'refreshBTN
        '
        Me.refreshBTN.Location = New System.Drawing.Point(95, 2)
        Me.refreshBTN.Name = "refreshBTN"
        Me.refreshBTN.Size = New System.Drawing.Size(75, 23)
        Me.refreshBTN.TabIndex = 6
        Me.refreshBTN.Text = "Refresh"
        Me.refreshBTN.UseVisualStyleBackColor = True
        '
        'addBttn
        '
        Me.addBttn.Location = New System.Drawing.Point(176, 2)
        Me.addBttn.Name = "addBttn"
        Me.addBttn.Size = New System.Drawing.Size(88, 26)
        Me.addBttn.TabIndex = 5
        Me.addBttn.Text = "Adicionar"
        Me.addBttn.UseVisualStyleBackColor = True
        '
        'MainList
        '
        Me.MainList.CheckBoxes = True
        Me.MainList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cod_int, Me.nome, Me.preco, Me.desc})
        Me.MainList.FullRowSelect = True
        Me.MainList.HideSelection = False
        Me.MainList.LabelEdit = True
        Me.MainList.Location = New System.Drawing.Point(0, 32)
        Me.MainList.Name = "MainList"
        Me.MainList.Size = New System.Drawing.Size(800, 417)
        Me.MainList.TabIndex = 4
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
        'desc
        '
        Me.desc.Text = "descrição"
        Me.desc.Width = 78
        '
        'preco
        '
        Me.preco.Text = "preço"
        Me.preco.Width = 79
        '
        'SSItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.refreshBTN)
        Me.Controls.Add(Me.addBttn)
        Me.Controls.Add(Me.MainList)
        Me.Name = "SSItem"
        Me.Text = "SSItem"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents refreshBTN As Button
    Friend WithEvents addBttn As Button
    Friend WithEvents MainList As ListView
    Friend WithEvents cod_int As ColumnHeader
    Friend WithEvents nome As ColumnHeader
    Friend WithEvents desc As ColumnHeader
    Friend WithEvents preco As ColumnHeader
End Class
