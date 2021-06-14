Public Class Item
    Private _cod_int As Int64
    Private _nome As String
    Private _desc As String
    Private _preço As Double

    Public Property Cod_int As Long
        Get
            Return _cod_int
        End Get
        Set(value As Long)
            _cod_int = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property Desc As String
        Get
            Return _desc
        End Get
        Set(value As String)
            _desc = value
        End Set
    End Property

    Public Property Preço As Double
        Get
            Return _preço
        End Get
        Set(value As Double)
            _preço = value
        End Set
    End Property
End Class
