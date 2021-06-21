Public Class Item
    Private _codigo_interno As Int64
    Private _nome As String
    Private _descricao As String
    Private _preço As Double

    Public Sub New()

    End Sub

    Public Sub New(cod_int As Long)
        Me.Cod_int = cod_int
    End Sub

    Public Sub New(nome As String, preço As Double, descricao As String)
        _nome = nome
        _descricao = descricao
        _preço = preço
    End Sub

    Public Sub New(codigo_interno As Long, nome As String, preço As Double, descricao As String)
        _codigo_interno = codigo_interno
        _nome = nome
        _descricao = descricao
        _preço = preço
    End Sub



    Public Property Cod_int As Long
        Get
            Return _codigo_interno
        End Get
        Set(value As Long)
            _codigo_interno = value
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

    Public Property Descricao As String
        Get
            Return _descricao
        End Get
        Set(value As String)
            _descricao = value
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
