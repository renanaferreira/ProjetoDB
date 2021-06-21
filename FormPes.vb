Public Class FormPes

    Implements FormAba

    Private _entity As Pessoa
    Public Sub New(ByRef ent As Pessoa)
        _entity = ent
        InitializeComponent()
    End Sub
    Private Sub FormArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar()
    End Sub

    Private Sub Atualizar(sender As Object, e As EventArgs) Handles Button1.Click
        AbaLogin.Atualizar(Me)
    End Sub

    Private Sub Carregar() Implements FormAba.Carregar
        nifTB.Text = _entity.Nif
        morTB.Text = _entity.Morada
        emailTB.Text = _entity.Email
        nomeTB.Text = _entity.Nome
        telTB.Text = _entity.Tel
    End Sub

    Public Function New_item() As Object Implements FormAba.New_item
        Return New Pessoa(nifTB.Text, nomeTB.Text, morTB.Text, telTB.Text, emailTB.Text)
    End Function

    Public Function Set_item(item As Object) As Object Implements FormAba.Set_item
        _entity = item
    End Function

    Public Function Tipo() As String Implements FormAba.Tipo
        Return "pessoa"
    End Function
End Class