Public Class AddItem
    Implements AddAba

    Private Sub Adicionar(sender As Object, e As EventArgs) Handles Button1.Click
        AbaLogin.Adicionar(Me)
    End Sub

    Public Sub Limpar() Implements AddAba.Limpar
        precoTB.Text = ""
        descTB.Text = ""
        nomeTB.Text = ""
    End Sub

    Public Function Tipo() As String Implements AddAba.Tipo
        Return "item"
    End Function

    Public Function Check_input() As Boolean Implements AddAba.Check_input
        If (nomeTB.Text = "" Or precoTB.Text = "") Then
            MsgBox("Campos nome e preço não podem ser vazios")
            Return False
        End If
        Return True
    End Function

    Public Function New_item() As Object Implements AddAba.New_item
        Return New Item(nomeTB.Text, precoTB.Text, descTB.Text)
    End Function
End Class