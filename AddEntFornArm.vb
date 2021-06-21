Public Class AddEntFornArm

    Implements AddAba

    Public Sub Limpar() Implements AddAba.Limpar
        Throw New NotImplementedException()
    End Sub

    Public Function Tipo() As String Implements AddAba.Tipo
        Return "entrega_forn_arm"
    End Function

    Public Function Check_input() As Boolean Implements AddAba.Check_input
        Throw New NotImplementedException()
    End Function

    Public Function New_item() As Object Implements AddAba.New_item
        Throw New NotImplementedException()
    End Function
End Class