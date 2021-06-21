Public Class SelectForn

    Public Sub New(ByRef id As ValorRetorno)
        MyBase.New(id)
        InitializeComponent()
    End Sub

    Public Overrides Sub SetColumns()
        MainList.Columns.Add("Nif")
        MainList.Columns.Add("Nome")
        MainList.Columns.Add("Morada")
        MainList.Columns.Add("Email")
        MainList.Columns.Add("Telefone")
    End Sub

    Public Overrides Sub Read_item(item As Object)
        Dim ent As Fornecedor = CType(item, Fornecedor)
        Dim listitem As ListViewItem = MainList.Items.Add(ent.Nif)
        listitem.SubItems.Add(ent.Nome)
        listitem.SubItems.Add(ent.Morada)
        listitem.SubItems.Add(ent.Email)
        listitem.SubItems.Add(ent.Tel)
    End Sub

    Public Overrides Function Tipo() As String
        Return "fornecedor"
    End Function

End Class
