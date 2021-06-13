Public Class FormArm

    Private conn As DBConnection
    Private arm As Armazem
    Public Sub New(ByRef conn As DBConnection, ByRef arm As Armazem)
        Me.conn = conn
        Me.arm = arm
        InitializeComponent()
    End Sub

    Private Sub FormArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codiTB.Text = Me.arm.Cod_int
        morTB.Text = Me.arm.Morada
        emailTB.Text = Me.arm.Email
        nomeTB.Text = Me.arm.Nome
        telTB.Text = Me.arm.Tel
    End Sub

    Private Sub Remover_Click(sender As Object, e As EventArgs) Handles rmvBTN.Click
        Dim fator As Boolean
        Me.conn.delete_arm(Me.arm.Cod_int, fator)
    End Sub
End Class