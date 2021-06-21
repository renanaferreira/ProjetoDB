Public Class FormItem

    Implements FormAba
    Implements InactivateEntity

    Private _ent As Item

    Public Sub New(ByRef ent As Item)
        _ent = ent
        InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbaLogin.Atualizar(Me)
    End Sub

    Private Sub FormForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar()
    End Sub

    Public Sub Carregar() Implements FormAba.Carregar
        ciTB.Text = _ent.Cod_int
        descTB.Text = _ent.Descricao
        preçoTB.Text = _ent.Preço
        nomeTB.Text = _ent.Nome
    End Sub

    Public Function New_item() As Object Implements FormAba.New_item
        Return New Item(_ent.Cod_int, nomeTB.Text, preçoTB.Text, descTB.Text)
    End Function

    Public Function Tipo() As String Implements FormAba.Tipo
        Return "item"
    End Function

    Public Function Set_item(item As Object) Implements FormAba.Set_item
        _ent = item
    End Function

    Public Function Get_in_item() As Object Implements InactivateEntity.Get_in_item
        Return New Item(_ent.Cod_int)
    End Function

    Public Sub Sucesso() Implements InactivateEntity.Sucesso
        Close()
    End Sub

    Public Sub Erro() Implements InactivateEntity.Erro
        Carregar()
    End Sub

    Public Function TipoEnt() As String Implements InactivateEntity.TipoEnt
        Return "item"
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbaLogin.Inativar(Me)
    End Sub
End Class