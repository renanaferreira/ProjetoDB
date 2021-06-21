Public Class SSVendaFuncCli
    Public Overrides Sub SetColumns()
        MyBase.SetColumns()
    End Sub

    Public Overrides Sub Read_item(item As Object)
        MyBase.Read_item(item)
    End Sub

    Public Overrides Function GetAddAba() As Form
        Return New AddVendaFuncCli()
    End Function

    Public Overrides Function EntShow(ByRef item As Object) As Form
        Return MyBase.EntShow(item)
    End Function

    Public Overrides Function New_item() As Object
        Return MyBase.New_item()
    End Function

    Public Overrides Function Tipo() As String
        Return MyBase.Tipo()
    End Function
End Class
