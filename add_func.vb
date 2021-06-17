Public Class add_func

    Private list_tb As List(Of TextBox)
    Private _loja As Loja

    Public Sub New()
        InitializeComponent()
        list_tb = New List(Of TextBox)
        _loja = New Loja(-1)
    End Sub

    Private Sub Adicionar(sender As Object, e As EventArgs) Handles Button1.Click
        If (telTB.Text = "" Or morTB.Text = "" Or emTB.Text = "" Or _loja.Cod_int = -1) Then
            MsgBox("Campos telefone, email e morada não podem ser vazios")
            Return
        End If
        Dim ent As New Funcionario(nifTB.Text, nomeTB.Text, morTB.Text, telTB.Text, emTB.Text, _loja.Cod_int)
        If AbaLogin.conn.execute("create_func", ent) Then
            MsgBox("Armazém foi criado com sucesso!")
        Else
            MsgBox("Erro na criação do novo armazém!")
        End If
        Me.clear_editable_tbs()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim ent As New Loja(-1)
        Dim form As New select_loja(ent)
        form.ShowDialog()
        If ent.Cod_int = -1 Then
            Return
        End If
        lojaTB.Text = ent.Cod_int.ToString
        _loja = ent
    End Sub

    Private Sub clear_editable_tbs()
        nifTB.Text = ""
        telTB.Text = ""
        morTB.Text = ""
        emTB.Text = ""
        nomeTB.Text = ""
        lojaTB.Text = ""
    End Sub

    Private Sub add_arm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clear_editable_tbs()
    End Sub
End Class