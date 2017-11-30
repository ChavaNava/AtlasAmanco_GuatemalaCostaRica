Public Class ConsultaHorasTotales
    Public Sub New()

    End Sub

    Public Shared _rFIP As String
    Public Shared Property rFIP() As String
        Get
            Return _rFIP
        End Get
        Set(ByVal value As String)
            _rFIP = value
        End Set
    End Property

    Public Shared _rFFP As String
    Public Shared Property rFFP() As String
        Get
            Return _rFFP
        End Get
        Set(ByVal value As String)
            _rFFP = value
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

    Public Shared _rOrdenProduccion As String
    Public Shared Property rOrdenProduccion() As String
        Get
            Return _rOrdenProduccion
        End Get
        Set(ByVal value As String)
            _rOrdenProduccion = value
        End Set
    End Property

    Public Shared _rOrdenProduccionGenerica As String
    Public Shared Property rOrdenProduccionGenerica() As String
        Get
            Return _rOrdenProduccionGenerica
        End Get
        Set(ByVal value As String)
            _rOrdenProduccionGenerica = value
        End Set
    End Property
End Class
