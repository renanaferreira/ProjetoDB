Public Class add_item
    Private Sub Add_click(sender As Object, e As EventArgs) Handles Button1.Click
        If (nomeTB.Text = "" Or morTB.Text = "" Or telTB.Text = "") Then
            MsgBox("Campos não podem ser vazios")
            Me.clear_editable_tbs()
            Return
        End If
        Dim ent As New Item
        Dim status As Boolean
        ent.Nome = nomeTB.Text
        ent.Desc = morTB.Text
        ent.Preço = telTB.Text
        MsgBox(ent.ToString)
        AbaLogin.conn.create_item(ent, status)
        If status Then
            MsgBox("item foi criado com sucesso!")
        Else
            MsgBox("Erro na criação do novo item!")
        End If
        Me.clear_editable_tbs()
    End Sub

    Private Sub clear_editable_tbs()
        telTB.Text = ""
        morTB.Text = ""
        nomeTB.Text = ""
    End Sub

    Private Sub add_forn_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clear_editable_tbs()
    End Sub

End Class