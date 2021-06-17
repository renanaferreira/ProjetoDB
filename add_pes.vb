Public Class add_pes

    Private Sub Adicionar(sender As Object, e As EventArgs) Handles Button1.Click
        If (telTB.Text = "" Or morTB.Text = "" Or emTB.Text = "" Or nifTB.Text = "" Or nomeTB.Text = "") Then
            MsgBox("Campos telefone, email e morada não podem ser vazios")
            Return
        End If
        Dim ent As New Pessoa(nifTB.Text, nomeTB.Text, morTB.Text, telTB.Text, emTB.Text)
        If AbaLogin.conn.execute("create_pessoa", ent) Then
            MsgBox("pessoa foi criado com sucesso!")
        Else
            MsgBox("Erro na criação do novo pessoa!")
        End If
        Me.clear_editable_tbs()
    End Sub

    Private Sub clear_editable_tbs()
        nifTB.Text = ""
        telTB.Text = ""
        morTB.Text = ""
        emTB.Text = ""
        nomeTB.Text = ""
    End Sub

    Private Sub add_arm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clear_editable_tbs()
    End Sub

End Class