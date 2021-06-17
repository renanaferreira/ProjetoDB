Public Class SSItem
    Private Sub select_item(sender As Object, e As EventArgs) Handles MainList.MouseDoubleClick
        If MainList.SelectedItems.Count = 0 Then
            Return
        End If
        Dim ent As Object
        New_item(ent)
        Dim form_arm As New FormItem(ent)
        form_arm.Show()
    End Sub

    Private Sub Carregar(tipo)
        MainList.Items.Clear()
        For Each item In AbaLogin.conn.read(tipo)
            Read_item(item)
        Next
    End Sub

    Private Sub New_item(ByRef item As Object)
        Dim row As ListViewItem = MainList.SelectedItems.Item(0)
        item = New Item(
            Convert.ToInt64(row.Text),
            Convert.ToString(row.SubItems.Item(1).Text),
            Convert.ToString(row.SubItems.Item(2).Text),
            Convert.ToString(row.SubItems.Item(3).Text)
        )
    End Sub

    Private Sub Read_item(ByRef item As Object)
        Dim elem As ListViewItem
        elem = MainList.Items.Add(item.Codigo_interno)
        elem.SubItems.Add(item.Nome)
        elem.SubItems.Add(item.Preço)
        elem.SubItems.Add(item.Descricao)
    End Sub

    Private Sub SSArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar("read_all_item")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addBttn.Click
        Dim add As New add_item()
        add.Show()
    End Sub

    Private Sub refreshBTN_Click(sender As Object, e As EventArgs) Handles refreshBTN.Click
        Carregar("read_all_item")
    End Sub

End Class