Public Class SSEntregaFornArm
    Public Overrides Sub SetColumns()
        MainList.Columns.Add("Código interno")
        MainList.Columns.Add("Código Armazém")
        'MainList.Columns.Add("Nome do Armazém")
        MainList.Columns.Add("Nif do Fornecedor")
        'MainList.Columns.Add("Nome do Fornecedor")
        MainList.Columns.Add("Data")
    End Sub

    Public Overrides Sub Read_item(item As Object)
        Dim ent As Entrega_forn_arm = CType(item, Entrega_forn_arm)
        Dim listitem As ListViewItem = MainList.Items.Add(ent.Cod_int)
        listitem.SubItems.Add(ent.Cod_int_arm)
        listitem.SubItems.Add(ent.Nif_forn)
        listitem.SubItems.Add(ent.Data)
    End Sub

    Public Overrides Function GetAddAba() As Form
        Return New AddEntFornArm
    End Function

    Public Overrides Function EntShow(ByRef item As Object) As Form
        item = CType(item, Entrega_forn_arm)
        Return MyBase.EntShow(item)
    End Function

    Public Overrides Function New_item() As Object
        Dim row = MainList.SelectedItems.Item(0)
        Return New Entrega_forn_arm(
            Convert.ToInt64(row.Text),
            row.SubItems.Item(1).Text,
            Convert.ToInt64(row.SubItems.Item(2).Text),
            Convert.ToDateTime(row.SubItems.Item(3).Text)
        )
    End Function

    Public Overrides Function Tipo() As String
        Return "entrega_forn_arm"
    End Function
End Class
