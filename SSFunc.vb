Public Class SSFunc

    Public Overrides Sub Read_item(item As Object)
        Dim ent As Funcionario = CType(item, Funcionario)
        Dim listitem As ListViewItem = MainList.Items.Add(ent.Cod_int)
        listitem.SubItems.Add(ent.Nif)
        listitem.SubItems.Add(ent.Nome)
        listitem.SubItems.Add(ent.Morada)
        listitem.SubItems.Add(ent.Email)
        listitem.SubItems.Add(ent.Tel)
        listitem.SubItems.Add(ent.Cod_int_loja)
    End Sub

    Public Overrides Sub SetColumns()
        MainList.Columns.Add("Código Interno")
        MainList.Columns.Add("Nif")
        MainList.Columns.Add("Nome")
        MainList.Columns.Add("Morada")
        MainList.Columns.Add("Email")
        MainList.Columns.Add("Telefone")
        MainList.Columns.Add("Código da Loja")
    End Sub

    Public Overrides Function EntShow(ByRef item As Object) As Form
        item = CType(item, Funcionario)
        Return New FormFunc(item)
    End Function

    Public Overrides Function New_item() As Object
        Dim row = MainList.SelectedItems.Item(0)
        Return New Funcionario(
            Convert.ToInt64(row.Text),
            row.SubItems.Item(1).Text,
            row.SubItems.Item(2).Text,
            row.SubItems.Item(3).Text,
            row.SubItems.Item(4).Text,
            row.SubItems.Item(5).Text,
            Convert.ToInt64(row.SubItems.Item(6).Text)
)
    End Function

    Public Overrides Function Tipo() As String
        Return "funcionario"
    End Function

    Public Overrides Function GetAddAba() As Form
        Return New AddFunc()
    End Function

End Class
