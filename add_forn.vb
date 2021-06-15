Public Class add_forn
    Private Sub Add_click(sender As Object, e As EventArgs) Handles Button1.Click
        If (nomeTB.Text = "" Or descTB.Text = "" Or precoTB.Text = "") Then
            MsgBox("Campos telefone, email, morada e nif não podem ser vazios")
            Me.clear_editable_tbs()
            Return
        End If
        Dim ent As New Item
        Dim status As Boolean
        ent.Nome = nomeTB.Text
        ent.Desc = descTB.Text
        ent.Preço = precoTB.Text
        MsgBox(ent.ToString)
        AbaLogin.conn.create_item(ent, status)
        If status Then
            MsgBox("Fornecedpr foi criado com sucesso!")
        Else
            MsgBox("Erro na criação do novo Fornecedor!")
        End If
        Me.clear_editable_tbs()
    End Sub

    Private Sub clear_editable_tbs()
        descTB.Text = ""
        precoTB.Text = ""
        nomeTB.Text = ""
    End Sub

    Private Sub add_forn_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clear_editable_tbs()
    End Sub
End Class