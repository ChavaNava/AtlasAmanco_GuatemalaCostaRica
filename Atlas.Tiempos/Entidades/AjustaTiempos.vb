Public Class AjustaTiempos
    Public Sub New()

    End Sub

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

    Public Shared _OrdenProduccion As String
    Public Shared Property OrdenProduccion() As String
        Get
            Return _OrdenProduccion
        End Get
        Set(ByVal value As String)
            _OrdenProduccion = value
        End Set
    End Property

    Public Shared _Codigo As String
    Public Shared Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
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

    Public Shared _FIP As String
    Public Shared Property FIP() As String
        Get
            Return _FIP
        End Get
        Set(ByVal value As String)
            _FIP = value
        End Set
    End Property


    Public Shared _FFP As String
    Public Shared Property FFP() As String
        Get
            Return _FFP
        End Get
        Set(ByVal value As String)
            _FFP = value
        End Set
    End Property

    Public Shared _EstatusProduccion As String
    Public Shared Property EstatusProduccion() As String
        Get
            Return _EstatusProduccion
        End Get
        Set(ByVal value As String)
            _EstatusProduccion = value
        End Set
    End Property

    Public Shared _TiempoProduccion As String
    Public Shared Property TiempoProduccion() As String
        Get
            Return _TiempoProduccion
        End Get
        Set(ByVal value As String)
            _TiempoProduccion = value
        End Set
    End Property

    Public Shared _IdOrden As String
    Public Shared Property IdOrden() As String
        Get
            Return _IdOrden
        End Get
        Set(ByVal value As String)
            _IdOrden = value
        End Set
    End Property

    Public Shared _IdTurno As String
    Public Shared Property IdTurno() As String
        Get
            Return _IdTurno
        End Get
        Set(ByVal value As String)
            _IdTurno = value
        End Set
    End Property

End Class
