Public Class FormForn
    Private forn As Fornecedor

    Public Sub New(ByRef forn As Fornecedor)
        Me.forn = forn
        InitializeComponent()
    End Sub

    Private Sub load()
        nifTB.Text = forn.Nif
        morTB.Text = forn.Morada
        emailTB.Text = forn.Email
        nomeTB.Text = forn.Nome
        telTB.Text = forn.Tel
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newforn As New Fornecedor
        newforn.Nif = forn.Nif
        newforn.Email = emailTB.Text
        newforn.Morada = morTB.Text
        newforn.Tel = telTB.Text
        newforn.Nome = nomeTB.Text

        Dim status As Boolean
        AbaLogin.conn.update_forn(status, newforn)
        If status = True Then
            MsgBox("Atualização feita com sucesso!")
            forn = newforn
        Else
            MsgBox("Erro na atualização")
        End If
        load()

    End Sub

    Private Sub FormForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub
End Class