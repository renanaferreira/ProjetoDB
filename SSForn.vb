Public Class SSForn


    Private Sub select_item(sender As Object, e As EventArgs) Handles MainList.MouseDoubleClick
        If MainList.SelectedItems.Count = 0 Then
            Return
        End If
        Dim row As ListViewItem = MainList.SelectedItems.Item(0)
        Dim forn As New Fornecedor
        forn.Nif = Convert.ToString(row.Text)
        forn.Nome = Convert.ToString(row.SubItems.Item(1).Text)
        forn.Email = Convert.ToString(row.SubItems.Item(2).Text)
        forn.Morada = Convert.ToString(row.SubItems.Item(3).Text)
        forn.Tel = Convert.ToString(row.SubItems.Item(4).Text)
        MsgBox(forn.ToString)

        Dim form_arm As New FormForn(forn)
        form_arm.Show()
    End Sub

    Private Sub load()
        MainList.Items.Clear()
        For Each item In AbaLogin.conn.read("read_all_forn")
            Dim listitem As ListViewItem
            listitem = MainList.Items.Add(item.Nif)
            listitem.SubItems.Add(item.Nome)
            listitem.SubItems.Add(item.Email)
            listitem.SubItems.Add(item.Morada)
            listitem.SubItems.Add(item.Tel)
        Next
    End Sub

    Private Sub SSForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim add As New add_forn
        add.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        load()
    End Sub
End Class