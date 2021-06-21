Public Class AddArm

    Implements AddAba

    Private Sub Adicionar(sender As Object, e As EventArgs) Handles Button1.Click
        AbaLogin.Adicionar(Me)
    End Sub

    Public Function Tipo() As String Implements AddAba.Tipo
        Return "armazem"
    End Function

    Public Function Check_input() As Boolean Implements AddAba.Check_input
        If (telTB.Text = "" Or morTB.Text = "" Or emailTB.Text = "") Then
            MsgBox("Campos telefone, email e morada não podem ser vazios")
            Return False
        End If
        Return True
    End Function

    Public Function New_item() As Object Implements AddAba.New_item
        Return New Armazem(nomeTB.Text, morTB.Text, emailTB.Text, telTB.Text)
    End Function

    Public Sub Limpar() Implements AddAba.Limpar
        nomeTB.Text = ""
        morTB.Text = ""
        emailTB.Text = ""
        telTB.Text = ""
    End Sub

End Class