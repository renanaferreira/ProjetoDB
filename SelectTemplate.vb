Public Class SelectTemplate

    Private _id As ValorRetorno

    Public Sub New(ByRef id As ValorRetorno)
        _id = id
        InitializeComponent()
        SetColumns()
    End Sub
    Private Sub SelectTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar(Tipo())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MainList.SelectedItems.Count = 0 Then
            MsgBox("Selecione uma opção")
            Return
        End If
        _id.Valor = MainList.SelectedItems.Item(0).Text
        Close()
    End Sub

    Private Sub Carregar(tipo As String)
        MainList.Items.Clear()
        For Each item In AbaLogin.conn.read(tipo)
            Read_item(item)
        Next
    End Sub

    Public Overridable Sub SetColumns()
    End Sub

    Public Overridable Sub Read_item(item As Object)
    End Sub

    Public Overridable Function Tipo() As String
    End Function


End Class