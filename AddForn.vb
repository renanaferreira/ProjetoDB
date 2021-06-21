Public Class AddForn

    Implements AddAba

    Private Sub Adicionar(sender As Object, e As EventArgs) Handles Button1.Click
        AbaLogin.Adicionar(Me)
    End Sub

    Public Sub Limpar() Implements AddAba.Limpar
        morTB.Text = ""
        telTB.Text = ""
        nomeTB.Text = ""
        nifTB.Text = ""
        emTB.Text = ""
    End Sub

    Public Function Tipo() As String Implements AddAba.Tipo
        Return "fornecedor"
    End Function

    Public Function Check_input() As Boolean Implements AddAba.Check_input
        If (nomeTB.Text = "" Or morTB.Text = "" Or telTB.Text = "" Or nifTB.Text = "") Then
            MsgBox("Campos telefone, email, morada e nif não podem ser vazios")
            Return False
        End If
        Return True
    End Function

    Public Function New_item() As Object Implements AddAba.New_item
        Return New Fornecedor(nifTB.Text, nomeTB.Text, morTB.Text, emTB.Text, telTB.Text)
    End Function

End Class