Public Class Armazem

    Private _morada As String
    Private _tel As String
    Private _email As String
    Private _cod_int As Int64
    Private _nome As String
    Private _ativo As Boolean

    Public Property Morada As String
        Get
            Return _morada
        End Get
        Set(value As String)
            _morada = value
        End Set
    End Property

    Public Property Tel As String
        Get
            Return _tel
        End Get
        Set(value As String)
            _tel = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

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

    Public Property Ativo As Boolean
        Get
            Return _ativo
        End Get
        Set(value As Boolean)
            _ativo = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString() +
        "\ncódigo interno = " + Convert.ToString(Cod_int) +
        "; nome = " + Nome +
        "; morada = " + Morada +
        "; email = " + Email +
        "; telefone = " + Tel
    End Function
End Class
