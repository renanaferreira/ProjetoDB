Public Class FormItem

    Private ent As Item

    Public Sub New(ByRef item As Item)
        Me.ent = item
        InitializeComponent()
    End Sub

    Private Sub load()
        ciTB.Text = ent.Cod_int
        descTB.Text = ent.Desc
        preçoTB.Text = ent.Preço
        nomeTB.Text = ent.Nome
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ent As New Item
        ent.Cod_int = Me.ent.Cod_int
        ent.Nome = nomeTB.Text
        ent.Preço = preçoTB.Text
        ent.Desc = descTB.Text

        Dim status As Boolean
        AbaLogin.conn.update_item(status, ent)
        If status = True Then
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