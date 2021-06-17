Public Class SSLoja

    Private Sub Selecionar(sender As Object, e As EventArgs) Handles MainList.MouseDoubleClick
        If MainList.SelectedItems.Count = 0 Then
            Return
        End If
        Dim row As ListViewItem = MainList.SelectedItems.Item(0)
        Dim ent As New Loja(
        Convert.ToInt64(row.Text),
        row.SubItems.Item(1).Text,
        row.SubItems.Item(3).Text,
        row.SubItems.Item(2).Text,
        row.SubItems.Item(4).Text,
        Convert.ToInt64(row.SubItems.Item(5).Text),
        Convert.ToInt64(row.SubItems.Item(6).Text))
        'Dim form_arm As New FormLoja(ent)
        'form_arm.Show()
    End Sub


    Public Sub Carregar(tipo As String)
        MainList.Items.Clear()
        For Each item In AbaLogin.conn.read(tipo)
            Dim listitem As ListViewItem
            listitem = MainList.Items.Add(item.Cod_int)
            listitem.SubItems.Add(item.Nome)
            listitem.SubItems.Add(item.Email)
            listitem.SubItems.Add(item.Morada)
            listitem.SubItems.Add(item.Tel)
        Next
    End Sub

    Private Sub SSLoja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar("read_all_loja")
    End Sub

    Private Sub Recarregar(sender As Object, e As EventArgs) Handles refreshBTN.Click
        Carregar("read_all_loja")
    End Sub

    Private Sub FormEntidade(sender As Object, e As EventArgs) Handles addBttn.Click
        Dim aba As New add_loja
        aba.Show()
    End Sub
End Class