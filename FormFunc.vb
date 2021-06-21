Public Class FormFunc
    Implements FormAba
    Private _ent As Funcionario

    Public Sub New(ByRef func As Funcionario)
        InitializeComponent()
        _ent = func
    End Sub

    Public Sub Carregar() Implements FormAba.Carregar
        codiTB.Text = ""
        nifTB.Text = ""
        nomeTB.Text = ""
        morTB.Text = ""
        emailTB.Text = ""
        telTB.Text = ""
        lojaTB.Text = ""
    End Sub

    Public Function New_item() As Object Implements FormAba.New_item
        Return New Funcionario(
            Convert.ToInt64(codiTB.Text),
            nifTB.Text,
            nomeTB.Text,
            morTB.Text,
            telTB.Text,
            emailTB.Text,
            Convert.ToInt64(lojaTB.Text)
       )
    End Function

    Public Function Set_item(item As Object) As Object Implements FormAba.Set_item
        _ent = item
    End Function

    Public Function Tipo() As String Implements FormAba.Tipo
        Return "funcionario"
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ent As New ValorRetorno("")
        Dim form = New SelectLoja(ent)
        form.ShowDialog()
        lojaTB.Text = ent.Valor
    End Sub
End Class