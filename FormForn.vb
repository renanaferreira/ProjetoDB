Public Class FormForn
    Implements FormAba
    Implements InactivateEntity

    Private _entity As Fornecedor

    Public Sub New(ByRef forn As Fornecedor)
        _entity = forn
        InitializeComponent()
    End Sub

    Private Sub asdf(sender As Object, e As EventArgs) Handles Button1.Click
        AbaLogin.Atualizar(Me)
    End Sub

    Private Sub FormForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar()
    End Sub

    Public Sub Carregar() Implements FormAba.Carregar
        nifTB.Text = _entity.Nif
        morTB.Text = _entity.Morada
        emailTB.Text = _entity.Email
        nomeTB.Text = _entity.Nome
        telTB.Text = _entity.Tel
    End Sub

    Public Function New_item() As Object Implements FormAba.New_item
        Return New Fornecedor(_entity.Nif, nomeTB.Text, morTB.Text, emailTB.Text, telTB.Text)
    End Function

    Public Function Set_item(item As Object) Implements FormAba.Set_item
        _entity = item
    End Function

    Public Function Tipo() As String Implements FormAba.Tipo
        Return "fornecedor"
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbaLogin.Inativar(Me)
    End Sub

    Public Function Get_in_item() As Object Implements InactivateEntity.Get_in_item
        Return New Fornecedor(_entity.Nif)
    End Function

    Public Sub Sucesso() Implements InactivateEntity.Sucesso
        Close()
    End Sub

    Public Sub Erro() Implements InactivateEntity.Erro
        Carregar()
    End Sub

    Public Function TipoEnt() As String Implements InactivateEntity.TipoEnt
        Return "fornecedor"
    End Function
End Class