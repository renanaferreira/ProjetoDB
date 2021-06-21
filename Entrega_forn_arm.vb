Public Class Entrega_forn_arm

    Private _cod_int_arm As Int64
    Private _cod_int As Int64
    Private _nif_forn As String
    Private _data As Date
    Private _lista As List(Of Item_qt)

    Public Sub New(nif_forn As String, cod_int_arm As Long, data As Date)
        _cod_int_arm = cod_int_arm
        _nif_forn = nif_forn
        _data = data
        _lista = Lista
    End Sub

    Public Sub New(cod_int As Long, nif_forn As String, cod_int_arm As Long, data As Date)
        _cod_int_arm = cod_int_arm
        _cod_int = cod_int
        _nif_forn = nif_forn
        _data = data
        _lista = Lista
    End Sub

    Public Property Cod_int_arm As Long
        Get
            Return _cod_int_arm
        End Get
        Set(value As Long)
            _cod_int_arm = value
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

    Public Property Nif_forn As String
        Get
            Return _nif_forn
        End Get
        Set(value As String)
            _nif_forn = value
        End Set
    End Property

    Public Property Data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property

    Public Property Lista As List(Of Item_qt)
        Get
            Return _lista
        End Get
        Set(value As List(Of Item_qt))
            _lista = value
        End Set
    End Property

End Class
