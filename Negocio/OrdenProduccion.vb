Option Explicit On
Public Class OrdenProduccion
#Region "Eventos"
#End Region

#Region "Variables miembro"
    Private m_OrdenProduccion As String
    Private m_StatusActiva As Boolean
    Private m_Pedido As String
    Private m_CveCte As String
    Private m_NombreCliente As String
    Private m_Destino As String
    Private m_Planta As String

    Private m_equipo As String
    Private m_codigoProducto As String
    Private m_cantProgPzs As Decimal
    Private m_cantProgKgs As Decimal
    Private m_unidad As String
    Private m_inicio As String
    Private m_fin As String
    Private m_origen As String
    Private m_status1 As String
    Private m_fechaIni As String
    Private m_horaReal As String
    Private m_fechaFin As String
    Private m_status As String
    Private m_almacen As String
    Private m_PuestoTrabajo As String

#End Region

#Region "Constructores"
    Public Sub New()
        m_OrdenProduccion = ""
        m_StatusActiva = False
        m_Pedido = ""
        m_CveCte = ""
        m_NombreCliente = ""
        m_Destino = ""
        m_Planta = ""

        m_equipo = ""
        m_codigoProducto = ""
        m_cantProgPzs = 0.0
        m_cantProgKgs = 0.0
        m_unidad = ""
        m_inicio = ""
        m_fin = ""
        m_origen = ""
        m_status1 = ""
        m_fechaIni = ""
        m_horaReal = ""
        m_fechaFin = ""
        m_status = ""
        m_almacen = ""
        m_PuestoTrabajo = ""
    End Sub

#End Region

#Region "Enumeraciones"
#End Region

#Region "Clases anidadas"
#End Region

#Region "Propiedades"
    ReadOnly Property ordenProduccion() As String
        Get
            Return m_OrdenProduccion
        End Get
    End Property

    Property statusActiva() As Char
        Get
            If m_StatusActiva Then
                Return "1"
            Else
                Return "0"
            End If
        End Get
        Set(ByVal value As Char)
            If value = "1" Or value = "T" Then
                m_StatusActiva = True
            Else
                m_StatusActiva = False
            End If
        End Set
    End Property

    Property pedido() As String
        Get
            Return m_Pedido
        End Get
        Set(ByVal value As String)
            m_Pedido = value
        End Set
    End Property

    Property cveCte() As String
        Get
            Return m_CveCte
        End Get
        Set(ByVal value As String)
            m_CveCte = value
        End Set
    End Property

    Property nombreCliente() As String
        Get
            Return m_NombreCliente
        End Get
        Set(ByVal value As String)
            m_NombreCliente = Caracteres(value)
        End Set
    End Property

    Property destino() As String
        Get
            Return m_Destino
        End Get
        Set(ByVal value As String)
            m_Destino = destino
        End Set
    End Property

    Property planta() As String
        Get
            Return m_Planta
        End Get
        Set(ByVal value As String)
            m_Planta = value
        End Set
    End Property

    Property equipo() As String
        Get
            Return m_equipo
        End Get
        Set(ByVal value As String)
            m_equipo = value
        End Set
    End Property

    Property codigoProducto() As String
        Get
            Return m_codigoProducto
        End Get
        Set(ByVal value As String)
            m_codigoProducto = value
        End Set
    End Property

    Property cantProgPzs() As Decimal
        Get
            Return m_cantProgPzs
        End Get
        Set(ByVal value As Decimal)
            m_cantProgPzs = value
        End Set
    End Property

    Property cantProgKgs() As Decimal
        Get
            Return m_cantProgKgs
        End Get
        Set(ByVal value As Decimal)
            m_cantProgKgs = value
        End Set
    End Property

    Property unidad() As String
        Get
            Return m_unidad
        End Get
        Set(ByVal value As String)
            m_unidad = value
        End Set
    End Property

    Property inicio() As String
        Get
            Return m_inicio
        End Get
        Set(ByVal value As String)
            m_inicio = value
        End Set
    End Property

    Property fin() As String
        Get
            Return m_fin
        End Get
        Set(ByVal value As String)
            m_fin = value
        End Set
    End Property

    Property origen() As String
        Get
            Return m_origen
        End Get
        Set(ByVal value As String)
            m_origen = value
        End Set
    End Property

    Property status1() As String
        Get
            Return m_status1
        End Get
        Set(ByVal value As String)
            m_status1 = value
        End Set
    End Property

    Property fechaIni() As String
        Get
            Return m_fechaIni
        End Get
        Set(ByVal value As String)
            m_fechaIni = value
        End Set
    End Property

    Property horaReal() As String
        Get
            Return m_horaReal
        End Get
        Set(ByVal value As String)
            m_horaReal = value
        End Set
    End Property

    Property fechaFin() As String
        Get
            Return m_fechaFin
        End Get
        Set(ByVal value As String)
            m_fechaFin = value
        End Set
    End Property

    Property status() As String
        Get
            Return m_status
        End Get
        Set(ByVal value As String)
            m_status = value
        End Set
    End Property

    Property almacen() As String
        Get
            Return m_almacen
        End Get
        Set(ByVal value As String)
            m_almacen = value
        End Set
    End Property
    Property PuestoTrabajo() As String
        Get
            Return m_PuestoTrabajo
        End Get
        Set(ByVal value As String)
            m_PuestoTrabajo = value.Trim
        End Set
    End Property

#End Region

#Region "Métodos"
#End Region

#Region "Colección"
#End Region

#Region "Campos"
#End Region

End Class
