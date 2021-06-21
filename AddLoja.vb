Public Class AddLoja

    Implements AddAba

    Private Sub Adicionar(sender As Object, e As EventArgs) Handles Button1.Click
        AbaLogin.Adicionar(Me)
    End Sub

    Public Sub Limpar() Implements AddAba.Limpar
        telTB.Text = ""
        morTB.Text = ""
        emailTB.Text = ""
        nomeTB.Text = ""
        armTB.Text = ""
    End Sub

    Public Function Tipo() As String Implements AddAba.Tipo
        Return "loja"
    End Function

    Public Function Check_input() As Boolean Implements AddAba.Check_input
        If (telTB.Text = "" Or morTB.Text = "" Or emailTB.Text = "" Or armTB.Text = "") Then
            MsgBox("Campos telefone, email e morada e armazém não podem ser vazios")
            Return False
        End If
        Return True
    End Function

    Public Function New_item() As Object Implements AddAba.New_item
        Return New Loja(nomeTB.Text, morTB.Text, emailTB.Text, telTB.Text, Convert.ToInt64(armTB.Text))
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim id As New ValorRetorno("")
        Dim form As New SelectArm(id)
        form.ShowDialog()
        armTB.Text = id.Valor
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        armTB.Text = ""
    End Sub

End Class