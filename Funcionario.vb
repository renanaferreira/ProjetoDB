Public Class Funcionario

    Private _cod_int As Int64
    Private _nif As String
    Private _nome As String
    Private _morada As String
    Private _tel As String
    Private _email As String
    Private _cod_int_loja As Int64


    Public Sub New()

    End Sub

    Public Sub New(cod_int As Long)
        _cod_int = cod_int
    End Sub

    Public Sub New(nif As String, nome As String, morada As String, tel As String, email As String, cod_int_loja As Long)
        _nif = nif
        _nome = nome
        _morada = morada
        _tel = tel
        _email = email
        _cod_int_loja = cod_int_loja
    End Sub


    Public Sub New(cod_int As Long, nif As String, nome As String, morada As String, tel As String, email As String, cod_int_loja As Long)
        Me.New(cod_int)
        _nif = nif
        _nome = nome
        _morada = morada
        _tel = tel
        _email = email
        _cod_int_loja = cod_int_loja
    End Sub


    Public ReadOnly Property Id As String
        Get
            If _cod_int = -1 Then
                Return ""
            End If
            Return Convert.ToString(_cod_int)
        End Get
    End Property




    Public Property Cod_int As Long
        Get
            Return _cod_int
        End Get
        Set(value As Long)
            _cod_int = value
        End Set
    End Property

    Public Property Nif As String
        Get
            Return _nif
        End Get
        Set(value As String)
            _nif = value
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

    Public Property Cod_int_loja As Long
        Get
            Return _cod_int_loja
        End Get
        Set(value As Long)
            _cod_int_loja = value
        End Set
    End Property
End Class
