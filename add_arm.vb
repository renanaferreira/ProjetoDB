Public Class add_arm

    Private Sub Add_click(sender As Object, e As EventArgs) Handles Button1.Click
        If (telTB.Text = "" Or morTB.Text = "" Or emailTB.Text = "") Then
            MsgBox("Campos telefone, email e morada não podem ser vazios")
            Me.clear_editable_tbs()
            Return
        End If
        Dim arm As New Armazem
        arm.Nome = nomeTB.Text
        arm.Morada = morTB.Text
        arm.Tel = telTB.Text
        arm.Email = emailTB.Text
        AbaLogin.conn.create_arm(arm)
        If arm.Cod_int = -1 Then
            MsgBox("Erro na criação do novo armazém!")
        Else
            MsgBox("Armazém foi criado com sucesso!")
        End If
        Me.clear_editable_tbs()
    End Sub

    Private Sub clear_editable_tbs()
        telTB.Text = ""
        morTB.Text = ""
        emailTB.Text = ""
        nomeTB.Text = ""
    End Sub

    Private Sub add_arm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clear_editable_tbs()
    End Sub
End Class