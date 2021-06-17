Public Class select_func

    Private _func As Funcionario

    Public Sub New(ByRef func As Funcionario)
        InitializeComponent()
        Me._func = func
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

    Private Sub select_func_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MainList.CheckedItems.Count = 0 Then
            MsgBox("Selecione uma opção")
            Return
        End If
        Dim row As ListViewItem = MainList.CheckedItems.Item(0)
        _func.Cod_int = row.Text
        _func.Nome = row.SubItems.Item(1).Text
        Close()
    End Sub
End Class