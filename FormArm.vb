Public Class FormArm
    Implements FormAba
    Implements InactivateEntity

    Private _entity As Armazem
    Public Sub New(ByRef arm As Armazem)
        InitializeComponent()
        _entity = arm
    End Sub

    Public Sub Sucesso() Implements InactivateEntity.Sucesso
        Close()
    End Sub

    Public Sub Erro() Implements InactivateEntity.Erro
        Carregar()
    End Sub

    Private Sub FormArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar()
    End Sub



    Private Sub Atualizar(sender As Object, e As EventArgs) Handles Button1.Click
        AbaLogin.Atualizar(Me)
    End Sub

    Private Sub Inativar(sender As Object, e As EventArgs) Handles Button2.Click
        AbaLogin.Inativar(Me)
    End Sub

    Private Sub Carregar() Implements FormAba.Carregar
        codiTB.Text = Me._entity.Cod_int
        morTB.Text = Me._entity.Morada
        emailTB.Text = Me._entity.Email
        nomeTB.Text = Me._entity.Nome
        telTB.Text = Me._entity.Tel
    End Sub

    Public Function New_item() As Object Implements FormAba.New_item
        Return New Armazem(_entity.Cod_int, nomeTB.Text, morTB.Text, emailTB.Text, telTB.Text)
    End Function

    Public Function Set_item(item As Object) As Object Implements FormAba.Set_item
        _entity = item
    End Function

    Public Function Tipo() As String Implements FormAba.Tipo
        Return "armazem"
    End Function

    Public Function Get_in_item() As Object Implements InactivateEntity.Get_in_item
        Return New Armazem(_entity.Cod_int)
    End Function

    Public Function TipoEnt() As String Implements InactivateEntity.TipoEnt
        Return "armazem"
    End Function
End Class