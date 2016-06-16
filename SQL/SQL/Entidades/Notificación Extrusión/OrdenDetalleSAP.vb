Public Class OrdenDetalleSAP
    Public Sub New()

    End Sub

    Public _Orden As String
    Public Property Orden() As String
        Get
            Return _Orden
        End Get
        Set(ByVal value As String)
            _Orden = value
        End Set
    End Property

    Public _Movimiento As String
    Public Property Movimiento() As String
        Get
            Return _Movimiento
        End Get
        Set(ByVal value As String)
            _Movimiento = value
        End Set
    End Property

    Public _Codigo As String
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Public _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public _Centro As String
    Public Property Centro() As String
        Get
            Return _Centro
        End Get
        Set(ByVal value As String)
            _Centro = value
        End Set
    End Property

    Public _Almacen As String
    Public Property Almacen() As String
        Get
            Return _Almacen
        End Get
        Set(ByVal value As String)
            _Almacen = value
        End Set
    End Property

    Public _Cantidad As String
    Public Property Cantidad() As String
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As String)
            _Cantidad = value
        End Set
    End Property

    Public _UM As String
    Public Property UM() As String
        Get
            Return _UM
        End Get
        Set(ByVal value As String)
            _UM = value
        End Set
    End Property

    Public _Lote As String
    Public Property Lote() As String
        Get
            Return _Lote
        End Get
        Set(ByVal value As String)
            _Lote = value
        End Set
    End Property

End Class

