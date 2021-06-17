Public Class FormArm

    Private _entity As Armazem
    Public Sub New(ByRef arm As Armazem)
        _entity = arm
        InitializeComponent()
    End Sub

    Private Sub FormArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar()
    End Sub

    Private Sub Carregar()
        codiTB.Text = Me._entity.Cod_int
        morTB.Text = Me._entity.Morada
        emailTB.Text = Me._entity.Email
        nomeTB.Text = Me._entity.Nome
        telTB.Text = Me._entity.Tel
    End Sub

    Private Sub Atualizar(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent As New Armazem(_entity.Cod_int, nomeTB.Text, morTB.Text, emailTB.Text, telTB.Text)
        If AbaLogin.conn.execute("update_arm", ent) Then
            MsgBox("Atualização feita com sucesso!")
            _entity = ent
        Else
            MsgBox("Erro na atualização")
        End If
        Carregar()

    End Sub

    Private Sub Inativar(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ent As New Armazem(_entity.Cod_int)
        If AbaLogin.conn.execute("inactivate_arm", ent) Then
            MsgBox("Entidade foi desativada com sucesso")
            Close()
        Else
            MsgBox("Erro na desativação da Entidade")
            Carregar()
        End If
    End Sub
End Class