Public Class SSArm

    Dim conn As DBConnection

    Public Sub New(ByRef dbconn As DBConnection)
        Me.conn = dbconn
        InitializeComponent()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainList.MouseDoubleClick
        If MainList.SelectedItems.Count = 0 Then
            Return
        End If
        Dim row As ListViewItem = MainList.SelectedItems.Item(0)
        Dim arm As New Armazem
        arm.Cod_int = Convert.ToInt32(row.Text)
        arm.Nome = Convert.ToString(row.SubItems.Item(1).Text)
        arm.Email = Convert.ToString(row.SubItems.Item(2).Text)
        arm.Morada = Convert.ToString(row.SubItems.Item(3).Text)
        arm.Tel = Convert.ToString(row.SubItems.Item(4).Text)

        Dim form_arm As New FormArm(conn, arm)
        form_arm.Show()
    End Sub

    Private Sub load_arm()
        MainList.Items.Clear()
        Dim lista As New List(Of Armazem)
        Me.conn.read_all_arm(lista)
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
        load_arm()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addBttn.Click
        Dim addarm As New add_arm(Me.conn)
        addarm.Show()
    End Sub

    Private Sub refreshBTN_Click(sender As Object, e As EventArgs) Handles refreshBTN.Click
        load_arm()
    End Sub
End Class