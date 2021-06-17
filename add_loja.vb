Public Class add_loja

    Private _arm As Armazem
    Private _func As Funcionario

    Public Sub New()
        _arm = New Armazem(-1)
        _func = New Funcionario(-1)
        InitializeComponent()
    End Sub

    Private Sub SelecionarArmazem(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim ent As New Armazem(-1)
        Dim form As New select_arm(ent)
        form.ShowDialog()
        If ent.Id = "" Then
            Return
        End If
        armTB.Text = ent.Cod_int.ToString
        _arm = ent
    End Sub

    Private Sub SelecionarGerente(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim ent As New Funcionario(-1)
        Dim form As New select_func(ent)
        form.ShowDialog()
        If ent.Id = "" Then
            Return
        End If
        gerTB.Text = ent.Cod_int.ToString + "(" + ent.Nome + ")"
        _func = ent
    End Sub

    Private Sub clear_editable_tbs()
        telTB.Text = ""
        morTB.Text = ""
        emailTB.Text = ""
        nomeTB.Text = ""
        armTB.Text = ""
        gerTB.Text = ""
    End Sub

    Private Sub add_arm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clear_editable_tbs()
    End Sub

    Private Sub Adicionar(sender As Object, e As EventArgs) Handles Button1.Click
        If (telTB.Text = "" Or morTB.Text = "" Or emailTB.Text = "" Or _arm.Id = "") Then
            MsgBox("Campos telefone, email e morada não podem ser vazios")
            Me.clear_editable_tbs()
            Return
        End If
        Dim ent As New Loja(nomeTB.Text, morTB.Text, emailTB.Text, telTB.Text, _arm.Cod_int)

        If AbaLogin.conn.execute("create_loja", ent) Then
            MsgBox("Entidade foi criada com sucesso!")
        Else
            MsgBox("Erro na criação da nova Entidade!")
        End If
        Me.clear_editable_tbs()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _func = New Funcionario(-1)
        gerTB.Text = ""
    End Sub
End Class