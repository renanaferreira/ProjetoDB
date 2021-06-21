Public Class SSItem

    Public Overrides Sub Read_item(item As Object)
        Dim ent As Item = CType(item, Item)
        Dim listitem As ListViewItem = MainList.Items.Add(ent.Cod_int)
        listitem.SubItems.Add(ent.Nome)
        listitem.SubItems.Add(ent.Preço)
        listitem.SubItems.Add(ent.Descricao)
    End Sub

    Public Overrides Sub SetColumns()
        MainList.Columns.Add("Código Interno")
        MainList.Columns.Add("Nome")
        MainList.Columns.Add("Preço")
        MainList.Columns.Add("Descrição")
    End Sub

    Public Overrides Function EntShow(ByRef item As Object) As Form
        item = CType(item, Item)
        Return New FormItem(item)
    End Function

    Public Overrides Function New_item() As Object
        Dim row = MainList.SelectedItems.Item(0)
        Return New Item(
            Convert.ToInt64(row.Text),
            row.SubItems.Item(1).Text,
            row.SubItems.Item(2).Text,
            row.SubItems.Item(3).Text
        )
    End Function

    Public Overrides Function Tipo() As String
        Return "item"
    End Function

    Public Overrides Function GetAddAba() As Form
        Return New AddItem()
    End Function

End Class
