Public Class FormLoja
    Implements FormAba

    Private _entity As Loja
    Public Sub New(ByRef ent As Loja)
        _entity = ent
        InitializeComponent()
    End Sub

    Public Sub Carregar() Implements FormAba.Carregar
        codiTB.Text = _entity.Cod_int
        nomeTB.Text = _entity.Nome
        telTB.Text = _entity.Tel
        emailTB.Text = _entity.Email
        morTB.Text = _entity.Morada
        armTB.Text = _entity.Cod_int_arm
        If _entity.Cod_int_ger <> -1 Then
            gerTB.Text = _entity.Cod_int_ger
        Else
            gerTB.Text = ""
        End If

    End Sub

    Public Function New_item() As Object Implements FormAba.New_item
        Return New Loja(
            Convert.ToInt64(codiTB.Text),
            nomeTB.Text,
            morTB.Text,
            emailTB.Text,
            telTB.Text,
            armTB.Text,
            Convert.ToInt64(gerTB.Text)
        )
    End Function

    Public Function Set_item(item As Object) As Object Implements FormAba.Set_item
        _entity = item
    End Function

    Public Function Tipo() As String Implements FormAba.Tipo
        Return "loja"
    End Function

    Private Sub FormLoja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ent As New ValorRetorno("")
        Dim form = New SelectArm(ent)
        'form.ShowDialog()
        armTB.Text = ent.Valor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        armTB.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        gerTB.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ent As New ValorRetorno("")
        Dim form = New SelectFunc(ent)
        form.ShowDialog()
        armTB.Text = ent.Valor
    End Sub
End Class