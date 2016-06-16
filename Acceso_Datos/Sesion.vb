Public Class Sesion
#Region "Eventos"
#End Region

#Region "Variables miembro"
    Private m_usuario As Usuario
    Private m_nombreUsuario As String
    Private m_codPersona As String
    Private m_clave As String
    Private m_deshabilitado As Boolean
    Private m_puesto As String
    Private m_operador As String
    Private m_moduloPersona As String
    Private m_DescPuesto As String

    Private m_planta As String
    Private m_nombrePlanta As String
    Private m_tipoPlanta As String
    Private m_operacionesPlanta As Boolean
    Private m_status As Integer
#End Region

#Region "Constructores"
    Public Sub New()
        m_nombreUsuario = ""
        m_planta = ""
        m_status = 0
    End Sub

    Public Sub New(ByVal nombreUsuario As String, ByVal planta As String)
        m_nombreUsuario = nombreUsuario
        m_planta = planta
    End Sub

    Public Sub New(ByVal nombreUsuario As String, ByVal codPersona As String, ByVal clave As String, ByVal deshabilitado As Boolean, _
                   ByVal puesto As String, ByVal operador As String, ByVal moduloPersona As String, ByVal planta As String, _
                    ByVal nombrePlanta As String, ByVal tipoPlanta As String, ByVal operacionesPlanta As Boolean, _
                    ByVal descPuesto As String)
        m_nombreUsuario = nombreUsuario.Trim
        m_codPersona = codPersona.Trim
        m_clave = clave.Trim
        m_deshabilitado = deshabilitado
        m_puesto = puesto.Trim
        m_operador = operador.Trim
        m_moduloPersona = moduloPersona.Trim

        m_planta = planta.Trim
        m_nombrePlanta = nombrePlanta.Trim
        m_tipoPlanta = tipoPlanta.Trim
        m_operacionesPlanta = operacionesPlanta
        m_DescPuesto = descPuesto.Trim
    End Sub

    Public Sub New(ByVal usuario As Usuario, ByVal planta As String, ByVal tipoPlanta As String, _
                   ByVal operacionesPlanta As Boolean, ByVal descPuesto As String)
        m_usuario = usuario
        m_planta = planta.Trim
        m_tipoPlanta = tipoPlanta.Trim
        m_operacionesPlanta = operacionesPlanta
        m_DescPuesto = DescPuesto.Trim
    End Sub
#End Region

#Region "Propiedades"
    ReadOnly Property Usuario() As Usuario
        Get
            Return m_usuario
        End Get
    End Property

    ReadOnly Property strUsuario() As String
        Get
            Return m_nombreUsuario
        End Get
    End Property

    ReadOnly Property codPersona() As String
        Get
            Return m_codPersona
        End Get
    End Property

    ReadOnly Property clave() As String
        Get
            Return m_clave
        End Get
    End Property

    ReadOnly Property habilitado() As Boolean
        Get
            Return habilitado
        End Get
    End Property

    ReadOnly Property puesto() As String
        Get
            Return m_puesto
        End Get
    End Property

    ReadOnly Property operador() As String
        Get
            Return m_operador
        End Get
    End Property

    ReadOnly Property moduloPersona() As String
        Get
            Return m_moduloPersona
        End Get
    End Property

    ReadOnly Property planta() As String
        Get
            Return m_planta
        End Get
    End Property

    ReadOnly Property nombrePlanta() As String
        Get
            Return m_nombrePlanta
        End Get
    End Property

    ReadOnly Property tipoPlanta() As String
        Get
            Return m_tipoPlanta
        End Get
    End Property

    ReadOnly Property operacionesPlanta() As Boolean
        Get
            Return m_operacionesPlanta
        End Get
    End Property

    ReadOnly Property DescPuesto() As String
        Get
            Return m_DescPuesto
        End Get
    End Property

    '' status:
    ''      1 - conectado
    ''      0 - desconectado
    ''      -1 - error: usuario y/o clave incorrectos
    ''      -2 - error: en la conexión de BD
    Property status() As Integer
        Get
            Return m_status
        End Get
        Set(ByVal value As Integer)
            m_status = value
        End Set
    End Property
#End Region

#Region "Métodos"
#End Region

End Class
