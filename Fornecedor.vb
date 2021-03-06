Public Class Fornecedor
    Private _nif As String
    Private _nome As String
    Private _morada As String
    Private _email As String

    Public Sub New()

    End Sub

    Public Sub New(nif As String)
        Me.Nif = nif
    End Sub

    Public Sub New(nif As String, nome As String, morada As String, email As String, telefone As String)
        Me.Nif = nif
        Me.Nome = nome
        Me.Email = email
        Me.Morada = morada
        Me.Tel = telefone
    End Sub

    Private _tel As String

    Public ReadOnly Property Id As String
        Get

            Return Convert.ToString(_nif)
        End Get
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

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
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

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
