Public Class Loja

    Private _cod_int As Int64
    Private _nome As String
    Private _morada As String
    Private _tel As String
    Private _email As String
    Private _cod_int_arm As Int64
    Private _cod_int_ger As Int64
    Public Sub New()
    End Sub

    Public Sub New(cod_int As Long)
        _cod_int = cod_int
    End Sub

    Public Sub New(nome As String, morada As String, email As String, tel As String, cod_int_arm As Long, Optional ByVal cod_int_ger As Long = -1)
        _nome = nome
        _morada = morada
        _tel = tel
        _email = email
        _cod_int_arm = cod_int_arm
        _cod_int_ger = cod_int_ger
    End Sub

    Public Sub New(cod_int As Long, nome As String, morada As String, email As String, telefone As String, cod_int_arm As Long, cod_int_ger As Long)
        _cod_int = cod_int
        _nome = nome
        _morada = morada
        _tel = telefone
        _email = email
        _cod_int_arm = cod_int_arm
        _cod_int_ger = cod_int_ger
    End Sub

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

    Public Property Cod_int_arm As Long
        Get
            Return _cod_int_arm
        End Get
        Set(value As Long)
            _cod_int_arm = value
        End Set
    End Property

    Public Property Cod_int_ger As Long
        Get
            Return _cod_int_ger
        End Get
        Set(value As Long)
            _cod_int_ger = value
        End Set
    End Property
End Class
