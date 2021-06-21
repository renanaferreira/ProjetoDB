Public Class Venda_func_cliente

    Private _cod_int As Int64
    Private _cod_int_func As Int64
    Private _nif_cli As String
    Private _data As Date
    Private _lista As List(Of Item_qt)

    Public Sub New(cod_int_func As Long, nif_cli As String, data As Date, lista As List(Of Item_qt))
        _cod_int_func = cod_int_func
        _nif_cli = nif_cli
        _data = data
        _lista = lista
    End Sub

    Public Sub New(cod_int As Long, cod_int_func As Long, nif_cli As String, data As Date, lista As List(Of Item_qt))
        _cod_int = cod_int
        _cod_int_func = cod_int_func
        _nif_cli = nif_cli
        _data = data
        _lista = lista
    End Sub

    Public Property Cod_int As Long
        Get
            Return _cod_int
        End Get
        Set(value As Long)
            _cod_int = value
        End Set
    End Property

    Public Property Cod_int_func As Long
        Get
            Return _cod_int_func
        End Get
        Set(value As Long)
            _cod_int_func = value
        End Set
    End Property

    Public Property Nif_cli As String
        Get
            Return _nif_cli
        End Get
        Set(value As String)
            _nif_cli = value
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
