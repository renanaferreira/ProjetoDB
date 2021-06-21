Public Class SSLoja
    Public Overrides Sub Read_item(item As Object)
        Dim ent As Loja = CType(item, Loja)
        Dim listitem As ListViewItem = MainList.Items.Add(ent.Cod_int)
        listitem.SubItems.Add(ent.Nome)
        listitem.SubItems.Add(ent.Morada)
        listitem.SubItems.Add(ent.Email)
        listitem.SubItems.Add(ent.Tel)
        listitem.SubItems.Add(ent.Cod_int_arm)
        If ent.Cod_int_ger <> -1 Then
            listitem.SubItems.Add(ent.Cod_int_ger)
        Else
            listitem.SubItems.Add("")
        End If

    End Sub

    Public Overrides Sub SetColumns()
        MainList.Columns.Add("Código Interno")
        MainList.Columns.Add("Nome")
        MainList.Columns.Add("Morada")
        MainList.Columns.Add("Email")
        MainList.Columns.Add("Telefone")
        MainList.Columns.Add("Código do Armazém")
        MainList.Columns.Add("Código do Gerente")
    End Sub

    Public Overrides Function EntShow(ByRef item As Object) As Form
        item = CType(item, Loja)
        Return New FormLoja(item)
    End Function

    Public Overrides Function New_item() As Object
        Dim row = MainList.SelectedItems.Item(0)
        Dim cod_int_ger = row.SubItems.Item(6).Text
        If cod_int_ger = "" Then
            cod_int_ger = "-1"
        End If
        Return New Loja(
            Convert.ToInt64(row.Text),
            row.SubItems.Item(1).Text,
            row.SubItems.Item(2).Text,
            row.SubItems.Item(3).Text,
            row.SubItems.Item(4).Text,
            Convert.ToInt64(row.SubItems.Item(5).Text),
            Convert.ToInt64(cod_int_ger)
        )
    End Function

    Public Overrides Function Tipo() As String
        Return "loja"
    End Function

    Public Overrides Function GetAddAba() As Form
        Return New AddLoja()
    End Function
End Class
