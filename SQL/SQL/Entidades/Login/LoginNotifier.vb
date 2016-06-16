Public Class LoginNotifier
    Public Sub New()

    End Sub
    Public Shared _nStatus As Boolean
    Public Shared Property nStatus() As Boolean
        Get
            Return _nStatus
        End Get
        Set(ByVal value As Boolean)
            _nStatus = value
        End Set
    End Property

    Public Shared _nAlias As String
    Public Shared Property nAlias() As String
        Get
            Return _nAlias
        End Get
        Set(ByVal value As String)
            _nAlias = value
        End Set
    End Property

    Public Shared _nCentro As String
    Public Shared Property nCentro() As String
        Get
            Return _nCentro
        End Get
        Set(ByVal value As String)
            _nCentro = value
        End Set
    End Property

    Public Shared _nNombre As String
    Public Shared Property nNombre() As String
        Get
            Return _nNombre
        End Get
        Set(ByVal value As String)
            _nNombre = value
        End Set
    End Property

    Public Shared _nPlanta As String
    Public Shared Property nPlanta() As String
        Get
            Return _nPlanta
        End Get
        Set(ByVal value As String)
            _nPlanta = value
        End Set
    End Property


    Public Shared _nTipo As String
    Public Shared Property nTipo() As String
        Get
            Return _nTipo
        End Get
        Set(ByVal value As String)
            _nTipo = value
        End Set
    End Property

    Public Shared _nPerfil As String
    Public Shared Property nPerfil() As String
        Get
            Return _nPerfil
        End Get
        Set(ByVal value As String)
            _nPerfil = value
        End Set
    End Property

    Public Shared _nIdPerfil As String
    Public Shared Property nIdPerfil() As String
        Get
            Return _nIdPerfil
        End Get
        Set(ByVal value As String)
            _nIdPerfil = value
        End Set
    End Property

    Public Shared _nAmbiente As String
    Public Shared Property nAmbiente() As String
        Get
            Return _nAmbiente
        End Get
        Set(ByVal value As String)
            _nAmbiente = value
        End Set
    End Property

    Public Shared _nCadena As Integer
    Public Shared Property nCadena() As Integer
        Get
            Return _nCadena
        End Get
        Set(ByVal value As Integer)
            _nCadena = value
        End Set
    End Property

    Public Shared _nMultiCentro As Boolean
    Public Shared Property nMultiCentro() As Boolean
        Get
            Return _nMultiCentro
        End Get
        Set(ByVal value As Boolean)
            _nMultiCentro = value
        End Set
    End Property

    Public Shared _nPassword As String
    Public Shared Property nPassword() As String
        Get
            Return _nPassword
        End Get
        Set(ByVal value As String)
            _nPassword = value
        End Set
    End Property

    Public Shared _nAltas As Boolean
    Public Shared Property nAltas() As Boolean
        Get
            Return _nAltas
        End Get
        Set(ByVal value As Boolean)
            _nAltas = value
        End Set
    End Property

    Public Shared _nBajas As Boolean
    Public Shared Property nBajas() As Boolean
        Get
            Return _nBajas
        End Get
        Set(ByVal value As Boolean)
            _nBajas = value
        End Set
    End Property

    Public Shared _nCambios As Boolean
    Public Shared Property nCambios() As Boolean
        Get
            Return _nCambios
        End Get
        Set(ByVal value As Boolean)
            _nCambios = value
        End Set
    End Property

    Public Shared _nImprimir As Boolean
    Public Shared Property nImprimir() As Boolean
        Get
            Return _nImprimir
        End Get
        Set(ByVal value As Boolean)
            _nImprimir = value
        End Set
    End Property

    Public Shared _nNotificar As Boolean
    Public Shared Property nNotificar() As Boolean
        Get
            Return _nNotificar
        End Get
        Set(ByVal value As Boolean)
            _nNotificar = value
        End Set
    End Property

    Public Shared _nContabilizar As Boolean
    Public Shared Property nContabilizar() As Boolean
        Get
            Return _nContabilizar
        End Get
        Set(ByVal value As Boolean)
            _nContabilizar = value
        End Set
    End Property

    Public Shared _nsobrePeso As Boolean
    Public Shared Property nsobrePeso() As Boolean
        Get
            Return _nsobrePeso
        End Get
        Set(ByVal value As Boolean)
            _nsobrePeso = value
        End Set
    End Property
End Class
