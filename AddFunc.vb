Public Class AddFunc

    Implements AddAba

    Private Sub Adicionar(sender As Object, e As EventArgs) Handles Button1.Click
        AbaLogin.Adicionar(Me)
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim ent As New ValorRetorno("")
        Dim form As New SelectLoja(ent)
        form.ShowDialog()
        lojaTB.Text = ent.Valor
    End Sub
    Public Sub Limpar() Implements AddAba.Limpar
        nifTB.Text = ""
        telTB.Text = ""
        morTB.Text = ""
        emTB.Text = ""
        nomeTB.Text = ""
        lojaTB.Text = ""
    End Sub

    Public Function Tipo() As String Implements AddAba.Tipo
        Return "funcionario"
    End Function

    Public Function Check_input() As Boolean Implements AddAba.Check_input
        If (telTB.Text = "" Or morTB.Text = "" Or emTB.Text = "" Or nifTB.Text = "" Or lojaTB.Text = "") Then
            MsgBox("Campos nif, telefone, email, morada e loja não podem ser vazios")
            Return False
        End If
        Return True
    End Function

    Public Function New_item() As Object Implements AddAba.New_item
        Return New Funcionario(nifTB.Text, nomeTB.Text, morTB.Text, telTB.Text, emTB.Text, Convert.ToInt64(lojaTB.Text))
    End Function
End Class