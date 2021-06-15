Public Class SSItem
    Private Sub select_item(sender As Object, e As EventArgs) Handles MainList.MouseDoubleClick
        If MainList.SelectedItems.Count = 0 Then
            Return
        End If
        Dim row As ListViewItem = MainList.SelectedItems.Item(0)
        Dim ent As New Item
        ent.Cod_int = Convert.ToInt32(row.Text)
        ent.Nome = Convert.ToString(row.SubItems.Item(1).Text)
        ent.Desc = Convert.ToString(row.SubItems.Item(2).Text)
        ent.Preço = Convert.ToString(row.SubItems.Item(3).Text)

        Dim form_arm As New FormItem(ent)
        form_arm.Show()
    End Sub

    Private Sub load()
        MainList.Items.Clear()
        Dim lista As New List(Of Object)
        AbaLogin.conn.read_all_item(lista)
        For Each item In lista
            Dim listitem As ListViewItem
            listitem = MainList.Items.Add(item.Cod_int)
            listitem.SubItems.Add(item.Nome)
            listitem.SubItems.Add(item.Email)
            listitem.SubItems.Add(item.Morada)
            listitem.SubItems.Add(item.Tel)
        Next
    End Sub

    Private Sub SSArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addBttn.Click
        Dim add As New add_item()
        add.Show()
    End Sub

    Private Sub refreshBTN_Click(sender As Object, e As EventArgs) Handles refreshBTN.Click
        load()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If MainList.CheckedItems.Count = 0 Then
            Return
        End If
        If MainList.CheckedItems.Count > 1 Then
            MsgBox("só pode selecionar um por vez")
            Return
        End If
        Dim status As Boolean
        If status Then
            MsgBox("Armazém foi desativado com sucesso")
            load()
        Else
            MsgBox("Erro na desativação do armazém")
            MainList.SelectedItems.Clear()
        End If
    End Sub

End Class