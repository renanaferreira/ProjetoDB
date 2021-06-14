Public Class FormArm


    Private arm As Armazem
    Public Sub New(ByRef arm As Armazem)
        Me.arm = arm
        InitializeComponent()
    End Sub

    Private Sub FormArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub load()
        codiTB.Text = Me.arm.Cod_int
        morTB.Text = Me.arm.Morada
        emailTB.Text = Me.arm.Email
        nomeTB.Text = Me.arm.Nome
        telTB.Text = Me.arm.Tel
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newarm As New Armazem()
        newarm.Cod_int = arm.Cod_int
        newarm.Email = emailTB.Text
        newarm.Morada = morTB.Text
        newarm.Tel = telTB.Text
        newarm.Nome = nomeTB.Text

        Dim status As Boolean
        AbaLogin.conn.update_arm(status, newarm)
        If status = True Then
            MsgBox("Atualização feita com sucesso!")
            arm = newarm
        Else
            MsgBox("Erro na atualização")
        End If
        load()

    End Sub
End Class