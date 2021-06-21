Public Class SSTemplate
    Private Sub SSTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetColumns()
        Carregar(Tipo())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Carregar(Tipo())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GetAddAba.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Selecionar()
    End Sub

    Private Sub Carregar(tipo As String)
        MainList.Items.Clear()
        For Each item In AbaLogin.conn.read(tipo)
            Read_item(item)
        Next
    End Sub

    Public Overridable Function GetAddAba() As Form
    End Function

    Private Sub Selecionar()
        If MainList.SelectedItems.Count = 0 Then
            Return
        End If
        Dim aba = EntShow(New_item())
        aba.Show()
    End Sub

    Public Overridable Sub SetColumns()
    End Sub

    Public Overridable Function EntShow(ByRef item As Object) As Form
    End Function

    Public Overridable Function New_item() As Object
    End Function

    Public Overridable Sub Read_item(item As Object)
    End Sub

    Public Overridable Function Tipo() As String
    End Function

End Class