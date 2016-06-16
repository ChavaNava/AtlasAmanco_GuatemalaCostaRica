Public Class LoginExtrusion
    Public Sub New()

    End Sub
    Public Shared _status As Boolean
    Public Shared Property Status() As Boolean
        Get
            Return _status
        End Get
        Set(ByVal value As Boolean)
            _status = value
        End Set
    End Property

    Public Shared _aliasUsuario As String
    Public Shared Property AliasUsuario() As String
        Get
            Return _aliasUsuario
        End Get
        Set(ByVal value As String)
            _aliasUsuario = value
        End Set
    End Property

    Public Shared _idCentro As String
    Public Shared Property IdCentro() As String
        Get
            Return _idCentro
        End Get
        Set(ByVal value As String)
            _idCentro = value
        End Set
    End Property

    Public Shared _passwordUsuario As String
    Public Shared Property PasswordUsuario() As String
        Get
            Return _passwordUsuario
        End Get
        Set(ByVal value As String)
            _passwordUsuario = value
        End Set
    End Property

    Public Shared _nombreUsuario As String
    Public Shared Property NombreUsuario() As String
        Get
            Return _nombreUsuario
        End Get
        Set(ByVal value As String)
            _nombreUsuario = value
        End Set
    End Property

    Public Shared _nombrePlanta As String
    Public Shared Property NombrePlanta() As String
        Get
            Return _nombrePlanta
        End Get
        Set(ByVal value As String)
            _nombrePlanta = value
        End Set
    End Property


    Public Shared _TipoPlanta As String
    Public Shared Property TipoPlanta() As String
        Get
            Return _TipoPlanta
        End Get
        Set(ByVal value As String)
            _TipoPlanta = value
        End Set
    End Property

    Public Shared _NombrePerfil As String
    Public Shared Property NombrePerfil() As String
        Get
            Return _NombrePerfil
        End Get
        Set(ByVal value As String)
            _NombrePerfil = value
        End Set
    End Property

    Public Shared _IdPerfil As String
    Public Shared Property IdPerfil() As String
        Get
            Return _IdPerfil
        End Get
        Set(ByVal value As String)
            _IdPerfil = value
        End Set
    End Property

    Public Shared _Ambiente As String
    Public Shared Property Ambiente() As String
        Get
            Return _Ambiente
        End Get
        Set(ByVal value As String)
            _Ambiente = value
        End Set
    End Property

    Public Shared _IdCadena As Integer
    Public Shared Property IdCadena() As Integer
        Get
            Return _IdCadena
        End Get
        Set(ByVal value As Integer)
            _IdCadena = value
        End Set
    End Property

    Public Shared _IdContador As Integer
    Public Shared Property IdContador() As Integer
        Get
            Return _IdContador
        End Get
        Set(ByVal value As Integer)
            _IdContador = value
        End Set
    End Property

    Public Shared _AutAltas As Boolean
    Public Shared Property AutAltas() As Boolean
        Get
            Return _AutAltas
        End Get
        Set(ByVal value As Boolean)
            _AutAltas = value
        End Set
    End Property

    Public Shared _AutBajas As Boolean
    Public Shared Property AutBajas() As Boolean
        Get
            Return _AutBajas
        End Get
        Set(ByVal value As Boolean)
            _AutBajas = value
        End Set
    End Property

    Public Shared _AutCambios As Boolean
    Public Shared Property AutCambios() As Boolean
        Get
            Return _AutCambios
        End Get
        Set(ByVal value As Boolean)
            _AutCambios = value
        End Set
    End Property

    Public Shared _AutImprimir As Boolean
    Public Shared Property AutImprimir() As Boolean
        Get
            Return _AutImprimir
        End Get
        Set(ByVal value As Boolean)
            _AutImprimir = value
        End Set
    End Property

    Public Shared _AutNotificar As Boolean
    Public Shared Property AutNotificar() As Boolean
        Get
            Return _AutNotificar
        End Get
        Set(ByVal value As Boolean)
            _AutNotificar = value
        End Set
    End Property

    Public Shared _AutContabilizar As Boolean
    Public Shared Property AutContabilizar() As Boolean
        Get
            Return _AutContabilizar
        End Get
        Set(ByVal value As Boolean)
            _AutContabilizar = value
        End Set
    End Property

    Public Shared _AutsobrePeso As Boolean
    Public Shared Property AutsobrePeso() As Boolean
        Get
            Return _AutsobrePeso
        End Get
        Set(ByVal value As Boolean)
            _AutsobrePeso = value
        End Set
    End Property
End Class
