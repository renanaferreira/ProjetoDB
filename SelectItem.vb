Public Class SelectItem

    Public Sub New(ByRef id As ValorRetorno)
        MyBase.New(id)
        InitializeComponent()
    End Sub

    Public Overrides Sub SetColumns()
        MainList.Columns.Add("Código Interno")
        MainList.Columns.Add("Nome")
        MainList.Columns.Add("Preço")
        MainList.Columns.Add("Descrição")
    End Sub

    Public Overrides Sub Read_item(item As Object)
        Dim ent As Item = CType(item, Item)
        Dim listitem As ListViewItem = MainList.Items.Add(ent.Cod_int)
        listitem.SubItems.Add(ent.Nome)
        listitem.SubItems.Add(ent.Preço)
        listitem.SubItems.Add(ent.Descricao)
    End Sub

    Public Overrides Function Tipo() As String
        Return "item"
    End Function

End Class
