Public Class ResumenOrdenProduccion
    Public Sub New()

    End Sub

    Public Shared _Orden As String
    Public Shared Property Orden() As String
        Get
            Return _Orden
        End Get
        Set(ByVal value As String)
            _Orden = value
        End Set
    End Property

    Public Shared _Puesto As String
    Public Shared Property Puesto() As String
        Get
            Return _Puesto
        End Get
        Set(ByVal value As String)
            _Puesto = value
        End Set
    End Property

    Public Shared _CantidadProgramada As String
    Public Shared Property CantidadProgramada() As String
        Get
            Return _CantidadProgramada
        End Get
        Set(ByVal value As String)
            _CantidadProgramada = value
        End Set
    End Property

    Public Shared _CodigoProducto As String
    Public Shared Property CodigoProducto() As String
        Get
            Return _CodigoProducto
        End Get
        Set(ByVal value As String)
            _CodigoProducto = value
        End Set
    End Property

    Public Shared _Producto As String
    Public Shared Property Producto() As String
        Get
            Return _Producto
        End Get
        Set(ByVal value As String)
            _Producto = value
        End Set
    End Property

    Public Shared _TramosNotificado As String
    Public Shared Property TramosNotificado() As String
        Get
            Return _TramosNotificado
        End Get
        Set(ByVal value As String)
            _TramosNotificado = value
        End Set
    End Property

    Public Shared _TramosPendientes As String
    Public Shared Property TramosPendientes() As String
        Get
            Return _TramosPendientes
        End Get
        Set(ByVal value As String)
            _TramosPendientes = value
        End Set
    End Property

    Public Shared _Sobrepeso As String
    Public Shared Property Sobrepeso() As String
        Get
            Return _Sobrepeso
        End Get
        Set(ByVal value As String)
            _Sobrepeso = value
        End Set
    End Property

    Public Shared _PesoScrap As String
    Public Shared Property PesoScrap() As String
        Get
            Return _PesoScrap
        End Get
        Set(ByVal value As String)
            _PesoScrap = value
        End Set
    End Property

    Public Shared _PorcentajeScrap As String
    Public Shared Property PorcentajeScrap() As String
        Get
            Return _PorcentajeScrap
        End Get
        Set(ByVal value As String)
            _PorcentajeScrap = value
        End Set
    End Property
End Class
