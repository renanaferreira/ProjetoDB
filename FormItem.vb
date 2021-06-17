Public Class FormItem

    Private ent As Item

    Public Sub New(ByRef item As Item)
        Me.ent = item
        InitializeComponent()
    End Sub

    Private Sub load()
        ciTB.Text = ent.Codigo_interno
        descTB.Text = ent.Descricao
        preçoTB.Text = ent.Preço
        nomeTB.Text = ent.Nome
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent As New Item
        ent.Codigo_interno = Me.ent.Codigo_interno
        ent.Nome = nomeTB.Text
        ent.Preço = preçoTB.Text
        ent.Descricao = descTB.Text
        If AbaLogin.conn.execute("update_item", ent) Then
            MsgBox("Atualização feita com sucesso!")
            Me.ent = ent
        Else
            MsgBox("Erro na atualização")
        End If
        load()

    End Sub

    Private Sub FormForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

End Class