Public Class Item_qt

    Private _cod_int_item As Int64
    Private _qt As Int64

    Public Sub New()
    End Sub

    Public Sub New(cod_int_item As Long, qt As Long)
        Me.Cod_int_item = cod_int_item
        Me.Qt = qt
    End Sub

    Public Property Cod_int_item As Long
        Get
            Return _cod_int_item
        End Get
        Set(value As Long)
            _cod_int_item = value
        End Set
    End Property

    Public Property Qt As Long
        Get
            Return _qt
        End Get
        Set(value As Long)
            _qt = value
        End Set
    End Property

End Class
