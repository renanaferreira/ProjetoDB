Public Class SSArm

    Private Sub Selecionar(sender As Object, e As EventArgs) Handles MainList.MouseDoubleClick
        If MainList.SelectedItems.Count = 0 Then
            Return
        End If
        Dim ent As Object
        New_item(ent)
        Dim form As New FormArm(ent)
        form.Show()
    End Sub

    Private Sub Carregar(tipo As String)
        MainList.Items.Clear()
        For Each item In AbaLogin.conn.read(tipo)
            Read_item(item)
        Next
    End Sub

    Private Sub New_item(ByRef item As Object)
        Dim row As ListViewItem = MainList.SelectedItems.Item(0)
        Dim ent As New Armazem(
            Convert.ToInt64(row.Text),
            row.SubItems.Item(1).Text,
            row.SubItems.Item(2).Text,
            row.SubItems.Item(3).Text,
            row.SubItems.Item(4).Text
        )

    End Sub

    Private Sub Read_item(ByRef item As Object)
        Dim listitem As ListViewItem
        listitem = MainList.Items.Add(item.Cod_int)
        listitem.SubItems.Add(item.Nome)
        listitem.SubItems.Add(item.Morada)
        listitem.SubItems.Add(item.Email)
        listitem.SubItems.Add(item.Tel)
    End Sub

    Private Sub SSArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar("read_all_arm")
    End Sub

    Private Sub FormEntidade(sender As Object, e As EventArgs) Handles addBttn.Click
        Dim form As New add_arm()
        form.Show()
    End Sub

    Private Sub Recarregar(sender As Object, e As EventArgs) Handles refreshBTN.Click
        Carregar("read_all_arm")
    End Sub

End Class