﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSLoja
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
        Dim tel As System.Windows.Forms.ColumnHeader
        Me.refreshBTN = New System.Windows.Forms.Button()
        Me.addBttn = New System.Windows.Forms.Button()
        Me.MainList = New System.Windows.Forms.ListView()
        Me.cod_int = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.morada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.codintarm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.codintger = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        tel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'tel
        '
        tel.Text = "Telefone"
        tel.Width = 88
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
        Me.MainList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cod_int, Me.nome, Me.morada, Me.email, tel, Me.codintarm, Me.codintger})
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
        'email
        '
        Me.email.DisplayIndex = 2
        Me.email.Text = "Email"
        Me.email.Width = 78
        '
        'morada
        '
        Me.morada.DisplayIndex = 3
        Me.morada.Text = "Morada"
        Me.morada.Width = 79
        '
        'codintarm
        '
        Me.codintarm.Text = "armazem"
        '
        'codintger
        '
        Me.codintger.Text = "Gerente"
        '
        'SSLoja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.refreshBTN)
        Me.Controls.Add(Me.addBttn)
        Me.Controls.Add(Me.MainList)
        Me.Name = "SSLoja"
        Me.Text = "SSLoja"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents refreshBTN As Button
    Friend WithEvents addBttn As Button
    Friend WithEvents MainList As ListView
    Friend WithEvents cod_int As ColumnHeader
    Friend WithEvents nome As ColumnHeader
    Friend WithEvents email As ColumnHeader
    Friend WithEvents morada As ColumnHeader
    Friend WithEvents codintarm As ColumnHeader
    Friend WithEvents codintger As ColumnHeader
End Class