Public Class FormForn
    Private _forn As Fornecedor

    Public Sub New(ByRef forn As Fornecedor)
        Me._forn = forn
        InitializeComponent()
    End Sub

    Private Sub Carregar()
        nifTB.Text = _forn.Nif
        morTB.Text = _forn.Morada
        emailTB.Text = _forn.Email
        nomeTB.Text = _forn.Nome
        telTB.Text = _forn.Tel
    End Sub

    Private Sub Update(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent As New Fornecedor(_forn.Nif, nomeTB.Text, morTB.Text, emailTB.Text, telTB.Text)
        If AbaLogin.conn.execute("update_forn", ent) Then
            MsgBox("Atualização feita com sucesso!")
            _forn = ent
        Else
            MsgBox("Erro na atualização")
        End If
        Carregar()

    End Sub

    Private Sub FormForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar()
    End Sub
End Class