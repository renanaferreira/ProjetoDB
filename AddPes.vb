Public Class AddPes

    Implements AddAba

    Private Sub Adicionar(sender As Object, e As EventArgs) Handles Button1.Click
        AbaLogin.Adicionar(Me)
    End Sub

    Public Function Tipo() As String Implements AddAba.Tipo
        Return "pessoa"
    End Function

    Private Function Check_input() As Boolean Implements AddAba.Check_input
        If (telTB.Text = "" Or morTB.Text = "" Or emTB.Text = "" Or nifTB.Text = "" Or nomeTB.Text = "") Then
            MsgBox("Nenhum campo pode ser vazio")
            Return False
        End If
        Return True
    End Function

    Private Function New_item() As Object Implements AddAba.New_item
        Return New Pessoa(nifTB.Text, nomeTB.Text, morTB.Text, telTB.Text, emTB.Text)
    End Function

    Private Sub Limpar() Implements AddAba.Limpar
        nifTB.Text = ""
        telTB.Text = ""
        morTB.Text = ""
        emTB.Text = ""
        nomeTB.Text = ""
    End Sub
End Class