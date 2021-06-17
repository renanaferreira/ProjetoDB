﻿Public Class add_arm

    Private Sub Adicionar(sender As Object, e As EventArgs) Handles Button1.Click
        If (telTB.Text = "" Or morTB.Text = "" Or emailTB.Text = "") Then
            MsgBox("Campos telefone, email e morada não podem ser vazios")
            Me.clear_editable_tbs()
            Return
        End If
        Dim ent As New Armazem
        ent.Nome = nomeTB.Text
        ent.Morada = morTB.Text
        ent.Tel = telTB.Text
        ent.Email = emailTB.Text
        If AbaLogin.conn.execute("create_arm", ent) Then
            MsgBox("Armazém foi criado com sucesso!")
        Else

            MsgBox("Erro na criação do novo armazém!")
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