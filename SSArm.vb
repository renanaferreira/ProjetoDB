Public Class SSArm
    Public Overrides Sub Read_item(item As Object)
        Dim ent As Armazem = CType(item, Armazem)
        Dim listitem As ListViewItem = MainList.Items.Add(ent.Cod_int)
        listitem.SubItems.Add(ent.Nome)
        listitem.SubItems.Add(ent.Morada)
        listitem.SubItems.Add(ent.Email)
        listitem.SubItems.Add(ent.Tel)
    End Sub

    Public Overrides Sub SetColumns()
        MainList.Columns.Add("Código interno")
        MainList.Columns.Add("Nome")
        MainList.Columns.Add("Morada")
        MainList.Columns.Add("Email")
        MainList.Columns.Add("Telefone")
    End Sub

    Public Overrides Function EntShow(ByRef item As Object) As Form
        item = CType(item, Armazem)
        Return New FormArm(item)
    End Function

    Public Overrides Function New_item() As Object
        Dim row = MainList.SelectedItems.Item(0)
        Return New Armazem(
            Convert.ToInt64(row.Text),
            row.SubItems.Item(1).Text,
            row.SubItems.Item(2).Text,
            row.SubItems.Item(3).Text,
            row.SubItems.Item(4).Text
        )
    End Function

    Public Overrides Function Tipo() As String
        Return "armazem"
    End Function

    Public Overrides Function GetAddAba() As Form
        Return New AddArm()
    End Function
End Class
