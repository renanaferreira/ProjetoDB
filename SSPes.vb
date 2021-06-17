Public Class SSPes

    Private Sub Selecionar(sender As Object, e As EventArgs) Handles MainList.MouseDoubleClick
        If MainList.SelectedItems.Count = 0 Then
            Return
        End If
        Dim ent As Object
        New_item(ent, Me.MainList)
        'Dim form As New FormArm(ent)
        'Form.Show()
    End Sub

    Private Sub Carregar(tipo As String, ByRef listview As ListView)
        listview.Items.Clear()
        For Each item In AbaLogin.conn.read(tipo)
            Read_item(item, listview)
        Next
    End Sub

    Private Sub New_item(ByRef item As Object, ByRef listview As ListView)
        Dim row As ListViewItem = listview.SelectedItems.Item(0)
        item = New Pessoa(
            Convert.ToInt64(row.Text),
            row.SubItems.Item(1).Text,
            row.SubItems.Item(2).Text,
            row.SubItems.Item(3).Text,
            row.SubItems.Item(4).Text
        )

    End Sub

    Private Sub Read_item(ByRef item As Object, ByRef listview As ListView)
        item = CType(item, Pessoa)
        Dim listitem As ListViewItem
        listitem = listview.Items.Add(item.Nif)
        listitem.SubItems.Add(item.Nome)
        listitem.SubItems.Add(item.Morada)
        listitem.SubItems.Add(item.Email)
        listitem.SubItems.Add(item.Tel)
    End Sub

    Private Sub SSArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar("read_all_pessoa", Me.MainList)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Carregar("read_all_pessoa", Me.MainList)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New add_pes()
        form.Show()
    End Sub
End Class