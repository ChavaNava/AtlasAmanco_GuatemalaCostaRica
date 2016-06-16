Public Class Usuario
#Region "Variables miembro"
    Private m_Usuario As String
    Private m_Planta As String
    Private m_Turno As Decimal
    Private m_Puesto As Decimal
    Private m_ClaveAcceso As String
    Private m_Nombre As String
    Private m_Correo As String
    Private m_Telefono As String
    Private m_TelMovil As String
    Private m_Supervisor As String
    Private m_Deshabilitado As Boolean
    Private m_NumEmpleado As String
    Private m_Tipo As String
    Private m_CodPer As String
    Private m_Modulo As String
    Private m_CorreoExt As Boolean
    Private m_Grupo As String
    Private m_Depto As Char
#End Region

#Region "Constructores"
    Public Sub New()
        m_Usuario = ""
        m_Planta = ""
        m_Turno = 0
        m_Puesto = 0
        m_ClaveAcceso = ""
        m_Nombre = ""
        m_Correo = ""
        m_Telefono = ""
        m_TelMovil = ""
        m_Supervisor = ""
        m_Deshabilitado = False
        m_NumEmpleado = ""
        m_Tipo = ""
        m_CodPer = ""
        m_Modulo = ""
        m_CorreoExt = False
        m_Grupo = ""
        m_Depto = ""
    End Sub

    Public Sub New(ByVal Usuario As String, ByVal Planta As String, ByVal Turno As Decimal, ByVal Puesto As Decimal, _
                   ByVal ClaveAcceso As String, ByVal Nombre As String, ByVal Correo As String, _
                   ByVal Telefono As String, ByVal TelMovil As String, ByVal Supervisor As String, _
                   ByVal Deshabilitado As Boolean, ByVal NumEmpleado As String, ByVal Tipo As String, _
                   ByVal CodPer As String, ByVal Modulo As String, ByVal CorreoExt As Boolean, _
                   ByVal Grupo As String, ByVal Depto As Char)
        m_Usuario = Usuario.Trim
        m_Planta = Planta.Trim
        m_Turno = Turno
        m_Puesto = Puesto
        m_ClaveAcceso = ClaveAcceso.Trim
        m_Nombre = Nombre.Trim
        m_Correo = Correo.Trim
        m_Telefono = Telefono.Trim
        m_TelMovil = TelMovil.Trim
        m_Supervisor = Supervisor.Trim
        m_Deshabilitado = Deshabilitado
        m_NumEmpleado = NumEmpleado.Trim
        m_Tipo = Tipo.Trim
        m_CodPer = CodPer.Trim
        m_Modulo = Modulo.Trim
        m_CorreoExt = CorreoExt
        m_Grupo = Grupo.Trim
        m_Depto = Depto
    End Sub
#End Region

#Region "Propiedades"
    Property Usuario() As String
        Get
            Return m_Usuario
        End Get
        Set(ByVal value As String)
            m_Usuario = value.Trim
        End Set
    End Property

    Property Planta() As String
        Get
            Return m_Planta
        End Get
        Set(ByVal value As String)
            m_Planta = value.Trim
        End Set
    End Property

    Property Turno() As Decimal
        Get
            Return m_Turno
        End Get
        Set(ByVal value As Decimal)
            m_Turno = value
        End Set
    End Property

    Property Puesto() As Decimal
        Get
            Return m_Puesto
        End Get
        Set(ByVal value As Decimal)
            m_Puesto = value
        End Set
    End Property

    Property ClaveAcceso() As String
        Get
            Return m_ClaveAcceso
        End Get
        Set(ByVal value As String)
            m_ClaveAcceso = value.Trim
        End Set
    End Property

    Property Nombre() As String
        Get
            Return m_Nombre
        End Get
        Set(ByVal value As String)
            m_Nombre = value.Trim
        End Set
    End Property

    Property Correo() As String
        Get
            Return m_Correo
        End Get
        Set(ByVal value As String)
            m_Correo = value.Trim
        End Set
    End Property

    Property Telefono() As String
        Get
            Return m_Telefono
        End Get
        Set(ByVal value As String)
            m_Telefono = value.Trim
        End Set
    End Property

    Property TelMovil() As String
        Get
            Return m_TelMovil
        End Get
        Set(ByVal value As String)
            m_TelMovil = value
        End Set
    End Property

    Property Supervisor() As String
        Get
            Return m_Supervisor
        End Get
        Set(ByVal value As String)
            m_Supervisor = value.Trim
        End Set
    End Property

    Property Deshabilitado() As Boolean
        Get
            Return m_Deshabilitado
        End Get
        Set(ByVal value As Boolean)
            m_Deshabilitado = value
        End Set
    End Property

    Property NumEmpleado() As String
        Get
            Return m_NumEmpleado
        End Get
        Set(ByVal value As String)
            m_NumEmpleado = value.Trim
        End Set
    End Property

    Property Tipo() As String
        Get
            Return m_Tipo
        End Get
        Set(ByVal value As String)
            m_Tipo = value.Trim
        End Set
    End Property

    Property CodPer() As String
        Get
            Return m_CodPer
        End Get
        Set(ByVal value As String)
            m_CodPer = value.Trim
        End Set
    End Property

    Property Modulo() As String
        Get
            Return m_Modulo
        End Get
        Set(ByVal value As String)
            m_Modulo = value.Trim
        End Set
    End Property

    Property CorreoExt() As Boolean
        Get
            Return m_CorreoExt
        End Get
        Set(ByVal value As Boolean)
            m_CorreoExt = value
        End Set
    End Property

    Property Grupo() As String
        Get
            Return m_Grupo
        End Get
        Set(ByVal value As String)
            m_Grupo = value.Trim
        End Set
    End Property

    Property Depto() As Char
        Get
            Return m_Depto
        End Get
        Set(ByVal value As Char)
            m_Depto = value
        End Set
    End Property
#End Region

End Class
