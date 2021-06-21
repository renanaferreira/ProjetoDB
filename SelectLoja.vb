Public Class SelectLoja
    Public Sub New(ByRef id As ValorRetorno)
        MyBase.New(id)
        InitializeComponent()
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

    Public Overrides Sub Read_item(item As Object)
        Dim ent As Loja = CType(item, Loja)
        Dim listitem As ListViewItem = MainList.Items.Add(ent.Cod_int)
        listitem.SubItems.Add(ent.Nome)
        listitem.SubItems.Add(ent.Morada)
        listitem.SubItems.Add(ent.Email)
        listitem.SubItems.Add(ent.Tel)
        listitem.SubItems.Add(ent.Cod_int_arm)
        listitem.SubItems.Add(ent.Cod_int_ger)
    End Sub

    Public Overrides Function Tipo() As String
        Return "loja"
    End Function
End Class
