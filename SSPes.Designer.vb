﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSPes
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MainList = New System.Windows.Forms.ListView()
        Me.nif = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.morada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        tel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'tel
        '
        tel.Text = "Telefone"
        tel.Width = 88
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(123, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainList
        '
        Me.MainList.CheckBoxes = True
        Me.MainList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nif, Me.nome, Me.morada, Me.email, tel})
        Me.MainList.FullRowSelect = True
        Me.MainList.HideSelection = False
        Me.MainList.LabelEdit = True
        Me.MainList.Location = New System.Drawing.Point(0, 31)
        Me.MainList.MultiSelect = False
        Me.MainList.Name = "MainList"
        Me.MainList.Size = New System.Drawing.Size(800, 417)
        Me.MainList.TabIndex = 7
        Me.MainList.UseCompatibleStateImageBehavior = False
        Me.MainList.View = System.Windows.Forms.View.Details
        '
        'nif
        '
        Me.nif.Text = "Nif"
        '
        'nome
        '
        Me.nome.Text = "Nome"
        Me.nome.Width = 72
        '
        'morada
        '
        Me.morada.Text = "Morada"
        Me.morada.Width = 79
        '
        'email
        '
        Me.email.Text = "Email"
        Me.email.Width = 78
        '
        'SSPes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MainList)
        Me.Name = "SSPes"
        Me.Text = "SSPes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MainList As ListView
    Friend WithEvents nome As ColumnHeader
    Friend WithEvents email As ColumnHeader
    Friend WithEvents morada As ColumnHeader
    Friend WithEvents nif As ColumnHeader
End Class