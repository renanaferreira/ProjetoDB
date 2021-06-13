Public Class add_arm

    Private conn As DBConnection

    Public Sub New(conn As DBConnection)
        Me.conn = conn
        InitializeComponent()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Me.conn = Nothing
    End Sub

    Private Sub Add_click(sender As Object, e As EventArgs) Handles Button1.Click
        If (telTB.Text = "" Or morTB.Text = "" Or emailTB.Text = "") Then
            MsgBox("Campos telefone, email e morada não podem ser vazios")
            Me.clear_editable_tbs()
            Return
        End If
        Dim cod_int As Int64
        Me.conn.create_arm(emailTB.Text, morTB.Text, telTB.Text, nomeTB.Text, cod_int)
        If cod_int = -1 Then
            MsgBox("Erro na criação do novo armazém!")
            Me.clear_editable_tbs()
            Return
        End If
        MsgBox("Armazém foi criado com sucesso!")
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