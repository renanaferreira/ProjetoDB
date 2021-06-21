Public Class ValorRetorno

    Private _valor As String

    Public Sub New(valor As String)
        Me.Valor = valor
    End Sub

    Public Property Valor As String
        Get
            Return _valor
        End Get
        Set(value As String)
            _valor = value
        End Set
    End Property
End Class
