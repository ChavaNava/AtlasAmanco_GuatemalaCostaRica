Public Class AltaProductionOrders
    Public Sub New()

    End Sub

    Public Shared _OrdenProd As String
    Public Shared Property OrdenProd() As String
        Get
            Return _OrdenProd
        End Get
        Set(ByVal value As String)
            _OrdenProd = value
        End Set
    End Property

    Public Shared _Centro As String
    Public Shared Property Centro() As String
        Get
            Return _Centro
        End Get
        Set(ByVal value As String)
            _Centro = value
        End Set
    End Property

    Public Shared _PuestoTrabajo As String
    Public Shared Property PuestoTrabajo() As String
        Get
            Return _PuestoTrabajo
        End Get
        Set(ByVal value As String)
            _PuestoTrabajo = value
        End Set
    End Property

    Public Shared _GrupoProducto As String
    Public Shared Property GrupoProducto() As String
        Get
            Return _GrupoProducto
        End Get
        Set(ByVal value As String)
            _GrupoProducto = value
        End Set
    End Property

    Public Shared _IdProducto As String
    Public Shared Property IdProducto() As String
        Get
            Return _IdProducto
        End Get
        Set(ByVal value As String)
            _IdProducto = value
        End Set
    End Property

    Public Shared _PzasProgramadas As String
    Public Shared Property PzasProgramadas() As String
        Get
            Return _PzasProgramadas
        End Get
        Set(ByVal value As String)
            _PzasProgramadas = value
        End Set
    End Property

    Public Shared _UM As String
    Public Shared Property UM() As String
        Get
            Return _UM
        End Get
        Set(ByVal value As String)
            _UM = value
        End Set
    End Property

    Public Shared _FechaInicio As String
    Public Shared Property FechaInicio() As String
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As String)
            _FechaInicio = value
        End Set
    End Property

    Public Shared _FechaFin As String
    Public Shared Property FechaFin() As String
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As String)
            _FechaFin = value
        End Set
    End Property

    Public Shared _Origen As String
    Public Shared Property Origen() As String
        Get
            Return _Origen
        End Get
        Set(ByVal value As String)
            _Origen = value
        End Set
    End Property

    Public Shared _Status_Orden As String
    Public Shared Property Status_Orden() As String
        Get
            Return _Status_Orden
        End Get
        Set(ByVal value As String)
            _Status_Orden = value
        End Set
    End Property

    Public Shared _Status_Desc As String
    Public Shared Property Status_Desc() As String
        Get
            Return _Status_Desc
        End Get
        Set(ByVal value As String)
            _Status_Desc = value
        End Set
    End Property

    Public Shared _FechaInicioProduccion As String
    Public Shared Property FechaInicioProduccion() As String
        Get
            Return _FechaInicioProduccion
        End Get
        Set(ByVal value As String)
            _FechaInicioProduccion = value
        End Set
    End Property

    Public Shared _Tipo_Orden As String
    Public Shared Property Tipo_Orden() As String
        Get
            Return _Tipo_Orden
        End Get
        Set(ByVal value As String)
            _Tipo_Orden = value
        End Set
    End Property

    Public Shared _Suceso As String
    Public Shared Property Suceso() As String
        Get
            Return _Suceso
        End Get
        Set(ByVal value As String)
            _Suceso = value
        End Set
    End Property

    Public Shared _Mensaje_Suceso As String
    Public Shared Property Mensaje_Suceso() As String
        Get
            Return _Mensaje_Suceso
        End Get
        Set(ByVal value As String)
            _Mensaje_Suceso = value
        End Set
    End Property
End Class
