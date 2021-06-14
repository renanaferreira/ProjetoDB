Public Class add_forn
    Private Sub Add_click(sender As Object, e As EventArgs) Handles Button1.Click
        If (telTB.Text = "" Or morTB.Text = "" Or emailTB.Text = "") Then
            MsgBox("Campos telefone, email, morada e nif não podem ser vazios")
            Me.clear_editable_tbs()
            Return
        End If
        Dim forn As New Fornecedor
        Dim status As Boolean
        forn.Nif = nifTB.Text
        forn.Nome = nomeTB.Text
        forn.Morada = morTB.Text
        forn.Tel = telTB.Text
        forn.Email = emailTB.Text
        MsgBox(forn.ToString)
        AbaLogin.conn.create_forn(forn, status)
        If status Then
            MsgBox("Fornecedpr foi criado com sucesso!")
        Else
            MsgBox("Erro na criação do novo Fornecedor!")
        End If
        Me.clear_editable_tbs()
    End Sub

    Private Sub clear_editable_tbs()
        nifTB.Text = ""
        telTB.Text = ""
        morTB.Text = ""
        emailTB.Text = ""
        nomeTB.Text = ""
    End Sub

    Private Sub add_forn_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clear_editable_tbs()
    End Sub
End Class