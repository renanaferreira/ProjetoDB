Public Class add_item
    Private Sub Add_click(sender As Object, e As EventArgs) Handles Button1.Click
        If (nomeTB.Text = "" Or precoTB.Text = "") Then
            MsgBox("Campos nome e preço não podem ser vazios")
            Return
        End If
        Dim ent As New Item
        ent.Nome = nomeTB.Text
        ent.Descricao = descTB.Text
        ent.Preço = precoTB.Text

        If AbaLogin.conn.execute("create_item", ent) Then
            MsgBox("item foi criado com sucesso!")
        Else
            MsgBox("Erro na criação do novo item!")
        End If
        Me.clear_editable_tbs()
    End Sub

    Private Sub clear_editable_tbs()
        precoTB.Text = ""
        descTB.Text = ""
        nomeTB.Text = ""
    End Sub

    Private Sub add_forn_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clear_editable_tbs()
    End Sub

End Class