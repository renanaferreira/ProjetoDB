Public Class SSFunc
    Private Sub SSFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub load()
        MainList.Items.Clear()
        For Each item In AbaLogin.conn.read("read_all_func")
            Dim listitem As ListViewItem
            listitem = MainList.Items.Add(item.Cod_int)
            listitem.SubItems.Add(item.Nome)
            listitem.SubItems.Add(item.Email)
            listitem.SubItems.Add(item.Morada)
            listitem.SubItems.Add(item.Tel)
            listitem.SubItems.Add(item.Nif)
            listitem.SubItems.Add(item.Cod_int_loja)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        load()
    End Sub
End Class