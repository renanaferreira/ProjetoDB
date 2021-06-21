<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectTemplate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainList = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MainList
        '
        Me.MainList.FullRowSelect = True
        Me.MainList.HideSelection = False
        Me.MainList.Location = New System.Drawing.Point(0, 47)
        Me.MainList.MultiSelect = False
        Me.MainList.Name = "MainList"
        Me.MainList.Size = New System.Drawing.Size(800, 402)
        Me.MainList.TabIndex = 0
        Me.MainList.UseCompatibleStateImageBehavior = False
        Me.MainList.View = System.Windows.Forms.View.Details
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Selecionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SelectTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MainList)
        Me.Name = "SelectTemplate"
        Me.Text = "SelectTemplate"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainList As ListView
    Friend WithEvents Button1 As Button
End Class
