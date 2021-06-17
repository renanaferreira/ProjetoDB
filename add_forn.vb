Public Class add_forn
    Private Sub Add_click(sender As Object, e As EventArgs) Handles Button1.Click
        If (nomeTB.Text = "" Or morTB.Text = "" Or telTB.Text = "") Then
            MsgBox("Campos telefone, email, morada e nif não podem ser vazios")
            Me.clear_editable_tbs()
            Return
        End If
        Dim ent As New Fornecedor
        ent.Nif = nifTB.Text
        ent.Nome = nomeTB.Text
        ent.Morada = morTB.Text
        ent.Tel = telTB.Text
        ent.Email = emTB.Text
        If AbaLogin.conn.execute("create_forn", ent) Then
            MsgBox("Fornecedor foi criado com sucesso!")
        Else
            MsgBox("Erro na criação do novo Fornecedor!")
        End If
        Me.clear_editable_tbs()
    End Sub

    Private Sub clear_editable_tbs()
        morTB.Text = ""
        telTB.Text = ""
        nomeTB.Text = ""
        nifTB.Text = ""
        emTB.Text = ""
    End Sub

    Private Sub add_forn_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clear_editable_tbs()
    End Sub
End Class