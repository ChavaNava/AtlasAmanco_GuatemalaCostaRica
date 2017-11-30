Public Class Tiempos_ODF
    Public Sub New()

    End Sub

    Public Shared _tOrden_Produccion As String
    Public Shared Property tOrden_Produccion() As String
        Get
            Return _tOrden_Produccion
        End Get
        Set(ByVal value As String)
            _tOrden_Produccion = value
        End Set
    End Property

    Public Shared _tCentro As String
    Public Shared Property tCentro() As String
        Get
            Return _tCentro
        End Get
        Set(ByVal value As String)
            _tCentro = value
        End Set
    End Property

    Public Shared _tPuestoTrabajo As String
    Public Shared Property tPuestoTrabajo() As String
        Get
            Return _tPuestoTrabajo
        End Get
        Set(ByVal value As String)
            _tPuestoTrabajo = value
        End Set
    End Property

    Public Shared _tCodigoMaterial As String
    Public Shared Property tCodigoMaterial() As String
        Get
            Return _tCodigoMaterial
        End Get
        Set(ByVal value As String)
            _tCodigoMaterial = value
        End Set
    End Property

    Public Shared _tMaterial As String
    Public Shared Property tMaterial() As String
        Get
            Return _tMaterial
        End Get
        Set(ByVal value As String)
            _tMaterial = value
        End Set
    End Property

    Public Shared _tCantidadProgramada As Decimal
    Public Shared Property tCantidadProgramada() As Decimal
        Get
            Return _tCantidadProgramada
        End Get
        Set(ByVal value As Decimal)
            _tCantidadProgramada = value
        End Set
    End Property

    Public Shared _tFI As DateTime
    Public Shared Property tFI() As DateTime
        Get
            Return _tFI
        End Get
        Set(ByVal value As DateTime)
            _tFI = value
        End Set
    End Property

    Public Shared _tFF As DateTime
    Public Shared Property tFF() As DateTime
        Get
            Return _tFF
        End Get
        Set(ByVal value As DateTime)
            _tFF = value
        End Set
    End Property

    Public Shared _tEstatus As Integer
    Public Shared Property tEstatus() As Integer
        Get
            Return _tEstatus
        End Get
        Set(ByVal value As Integer)
            _tEstatus = value
        End Set
    End Property

    Public Shared _tTotalTiempo As String
    Public Shared Property tTotalTiempo() As String
        Get
            Return _tTotalTiempo
        End Get
        Set(ByVal value As String)
            _tTotalTiempo = value
        End Set
    End Property

    Public Shared _tTiempoMuerto As String
    Public Shared Property tTiempoMuerto As String
        Get
            Return _tTiempoMuerto
        End Get
        Set(ByVal value As String)
            _tTiempoMuerto = value
        End Set
    End Property
End Class
