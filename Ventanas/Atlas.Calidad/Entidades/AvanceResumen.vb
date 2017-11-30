Public Class AvanceResumen
    Public Sub New()

    End Sub

    Public Shared _rOrdenProduccion As String
    Public Shared Property rOrdenProduccion() As String
        Get
            Return _rOrdenProduccion
        End Get
        Set(ByVal value As String)
            _rOrdenProduccion = value
        End Set
    End Property

    Public Shared _rCentro As String
    Public Shared Property rCentro() As String
        Get
            Return _rCentro
        End Get
        Set(ByVal value As String)
            _rCentro = value
        End Set
    End Property

    Public Shared _rEstatusOrden As String
    Public Shared Property rEstatusOrden() As String
        Get
            Return _rEstatusOrden
        End Get
        Set(ByVal value As String)
            _rEstatusOrden = value
        End Set
    End Property

    Public Shared _rPuestoTrabajo As String
    Public Shared Property rPuestoTrabajo() As String
        Get
            Return _rPuestoTrabajo
        End Get
        Set(ByVal value As String)
            _rPuestoTrabajo = value
        End Set
    End Property

    Public Shared _rProduccionkg As String
    Public Shared Property rProduccionkg() As String
        Get
            Return _rProduccionkg
        End Get
        Set(ByVal value As String)
            _rProduccionkg = value
        End Set
    End Property

    Public Shared _rScrapkg As String
    Public Shared Property rScrapkg() As String
        Get
            Return _rScrapkg
        End Get
        Set(ByVal value As String)
            _rScrapkg = value
        End Set
    End Property

    Public Shared _rSobrepesokg As String
    Public Shared Property rSobrepesokg() As String
        Get
            Return _rSobrepesokg
        End Get
        Set(ByVal value As String)
            _rSobrepesokg = value
        End Set
    End Property

    Public Shared _rTeoricokg As String
    Public Shared Property rTeoricokg() As String
        Get
            Return _rTeoricokg
        End Get
        Set(ByVal value As String)
            _rTeoricokg = value
        End Set
    End Property

    Public Shared _rPorcScrap As String
    Public Shared Property rPorcScrap() As String
        Get
            Return _rPorcScrap
        End Get
        Set(ByVal value As String)
            _rPorcScrap = value
        End Set
    End Property

    Public Shared _rPorcSobrepeso As String
    Public Shared Property rPorcSobrepeso() As String
        Get
            Return _rPorcSobrepeso
        End Get
        Set(ByVal value As String)
            _rPorcSobrepeso = value
        End Set
    End Property

    Public Shared _rTramosRequeridos As String
    Public Shared Property rTramosRequeridos() As String
        Get
            Return _rTramosRequeridos
        End Get
        Set(ByVal value As String)
            _rTramosRequeridos = value
        End Set
    End Property

    Public Shared _rTramosproducidos As String
    Public Shared Property rTramosproducidos() As String
        Get
            Return _rTramosproducidos
        End Get
        Set(ByVal value As String)
            _rTramosproducidos = value
        End Set
    End Property

    Public Shared _rPendienteProducir As String
    Public Shared Property rPendienteProducir() As String
        Get
            Return _rPendienteProducir
        End Get
        Set(ByVal value As String)
            _rPendienteProducir = value
        End Set
    End Property

    Public Shared _rAvance As String
    Public Shared Property rAvance() As String
        Get
            Return _rAvance
        End Get
        Set(ByVal value As String)
            _rAvance = value
        End Set
    End Property

    Public Shared _rEstatusAvance As String
    Public Shared Property rEstatusAvance() As String
        Get
            Return _rEstatusAvance
        End Get
        Set(ByVal value As String)
            _rEstatusAvance = value
        End Set
    End Property
End Class
