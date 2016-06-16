Public Class SessionUser
    Public Sub New()

    End Sub
    Public Shared _sStatus As Boolean
    Public Shared Property sStatus() As Boolean
        Get
            Return _sStatus
        End Get
        Set(ByVal value As Boolean)
            _sStatus = value
        End Set
    End Property

    Public Shared _sAlias As String
    Public Shared Property sAlias() As String
        Get
            Return _sAlias
        End Get
        Set(ByVal value As String)
            _sAlias = value
        End Set
    End Property

    Public Shared _sCentro As String
    Public Shared Property sCentro() As String
        Get
            Return _sCentro
        End Get
        Set(ByVal value As String)
            _sCentro = value
        End Set
    End Property

    Public Shared _sNombre As String
    Public Shared Property sNombre() As String
        Get
            Return _sNombre
        End Get
        Set(ByVal value As String)
            _sNombre = value
        End Set
    End Property

    Public Shared _sPlanta As String
    Public Shared Property sPlanta() As String
        Get
            Return _sPlanta
        End Get
        Set(ByVal value As String)
            _sPlanta = value
        End Set
    End Property


    Public Shared _sTipo As String
    Public Shared Property sTipo() As String
        Get
            Return _sTipo
        End Get
        Set(ByVal value As String)
            _sTipo = value
        End Set
    End Property

    Public Shared _sPerfil As String
    Public Shared Property sPerfil() As String
        Get
            Return _sPerfil
        End Get
        Set(ByVal value As String)
            _sPerfil = value
        End Set
    End Property

    Public Shared _sIdPerfil As String
    Public Shared Property sIdPerfil() As String
        Get
            Return _sIdPerfil
        End Get
        Set(ByVal value As String)
            _sIdPerfil = value
        End Set
    End Property

    Public Shared _sAmbiente As String
    Public Shared Property sAmbiente() As String
        Get
            Return _sAmbiente
        End Get
        Set(ByVal value As String)
            _sAmbiente = value
        End Set
    End Property

    Public Shared _sCadena As Integer
    Public Shared Property sCadena() As Integer
        Get
            Return _sCadena
        End Get
        Set(ByVal value As Integer)
            _sCadena = value
        End Set
    End Property

    Public Shared _sMultiCentro As Boolean
    Public Shared Property sMultiCentro() As Boolean
        Get
            Return _sMultiCentro
        End Get
        Set(ByVal value As Boolean)
            _sMultiCentro = value
        End Set
    End Property

    Public Shared _sPassword As String
    Public Shared Property sPassword() As String
        Get
            Return _sPassword
        End Get
        Set(ByVal value As String)
            _sPassword = value
        End Set
    End Property
End Class
