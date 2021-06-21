Public Class Entrega_arm_loja

    Private _cod_int As Int64
    Private _cod_int_arm As Int64
    Private _cod_int_loja As Int64
    Private _data As Date
    Private _lista As List(Of Item_qt)

    Public Sub New(cod_int_arm As Long, cod_int_loja As Long, data As Date, lista As List(Of Item_qt))
        Me.Cod_int_arm = cod_int_arm
        Me.Cod_int_loja = cod_int_loja
        Me.Data = data
        Me.Lista = lista
    End Sub

    Public Sub New(cod_int As Long, cod_int_arm As Long, cod_int_loja As Long, data As Date, lista As List(Of Item_qt))
        Me.Cod_int = cod_int
        Me.Cod_int_arm = cod_int_arm
        Me.Cod_int_loja = cod_int_loja
        Me.Data = data
        Me.Lista = lista
    End Sub

    Public Property Cod_int As Long
        Get
            Return _cod_int
        End Get
        Set(value As Long)
            _cod_int = value
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

    Public Property Cod_int_loja As Long
        Get
            Return _cod_int_loja
        End Get
        Set(value As Long)
            _cod_int_loja = value
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
