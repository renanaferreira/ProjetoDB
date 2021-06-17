Public Class select_loja

    Private _loja As Loja

    Public Sub New(ByRef loja As Loja)
        _loja = loja
        InitializeComponent()
    End Sub


    Private Sub load(ByVal tipo As String)
        MainList.Items.Clear()
        For Each item In AbaLogin.conn.read(tipo)
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

    Private Sub select_loja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load("read_all_loja")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MainList.CheckedItems.Count = 0 Then
            MsgBox("Selecione uma opção")
            Return
        End If
        Dim row As ListViewItem = MainList.CheckedItems.Item(0)
        _loja.Cod_int = row.Text
        _loja.Nome = row.SubItems.Item(1).Text
        Close()
    End Sub
End Class