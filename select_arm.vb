Public Class select_arm
    Private _arm As Armazem

    Public Sub New(ByRef arm As Armazem)
        Me._arm = arm
        InitializeComponent()
    End Sub

    Private Sub select_arm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub load()
        MainList.Items.Clear()
        For Each item In AbaLogin.conn.read("read_all_arm")
            Dim listitem As ListViewItem
            listitem = MainList.Items.Add(item.Cod_int)
            listitem.SubItems.Add(item.Nome)
            listitem.SubItems.Add(item.Email)
            listitem.SubItems.Add(item.Morada)
            listitem.SubItems.Add(item.Tel)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MainList.CheckedItems.Count = 0 Then
            MsgBox("Selecione uma opção")
            Return
        End If
        Dim row As ListViewItem = MainList.CheckedItems.Item(0)
        _arm.Cod_int = row.Text
        _arm.Nome = row.SubItems.Item(1).Text
        _arm.Morada = row.SubItems.Item(3).Text
        MsgBox(_arm.Cod_int)
        Close()
    End Sub
End Class