Public Class TiemposConsulta
    Public Sub New()

    End Sub

    Public Shared _cOrden As String
    Public Shared Property cOrden() As String
        Get
            Return _cOrden
        End Get
        Set(ByVal value As String)
            _cOrden = value
        End Set
    End Property

    Public Shared _cCentro As String
    Public Shared Property cCentro() As String
        Get
            Return _cCentro
        End Get
        Set(ByVal value As String)
            _cCentro = value
        End Set
    End Property

    Public Shared _cEquipo_basico As String
    Public Shared Property cEquipo_basico() As String
        Get
            Return _cEquipo_basico
        End Get
        Set(ByVal value As String)
            _cEquipo_basico = value
        End Set
    End Property

    Public Shared _cIdProducto As String
    Public Shared Property cIdProducto() As String
        Get
            Return _cIdProducto
        End Get
        Set(ByVal value As String)
            _cIdProducto = value
        End Set
    End Property

    Public Shared _cCantidad_Programada_Tramos As String
    Public Shared Property cCantidad_Programada_Tramos() As String
        Get
            Return _cCantidad_Programada_Tramos
        End Get
        Set(ByVal value As String)
            _cCantidad_Programada_Tramos = value
        End Set
    End Property

    Public Shared _cCantidad_Programada_Kilos As String
    Public Shared Property cCantidad_Programada_Kilos() As String
        Get
            Return _cCantidad_Programada_Kilos
        End Get
        Set(ByVal value As String)
            _cCantidad_Programada_Kilos = value
        End Set
    End Property

    Public Shared _cFecha_Inicio As String
    Public Shared Property cFecha_Inicio() As String
        Get
            Return _cFecha_Inicio
        End Get
        Set(ByVal value As String)
            _cFecha_Inicio = value
        End Set
    End Property

    Public Shared _cFecha_Termino As String
    Public Shared Property cFecha_Termino() As String
        Get
            Return _cFecha_Termino
        End Get
        Set(ByVal value As String)
            _cFecha_Termino = value
        End Set
    End Property

    Public Shared _cOrigen_Informacion As String
    Public Shared Property cOrigen_Informacion() As String
        Get
            Return _cOrigen_Informacion
        End Get
        Set(ByVal value As String)
            _cOrigen_Informacion = value
        End Set
    End Property

    Public Shared _cEstatus_Activa As String
    Public Shared Property cEstatus_Activa() As String
        Get
            Return _cEstatus_Activa
        End Get
        Set(ByVal value As String)
            _cEstatus_Activa = value
        End Set
    End Property

    Public Shared _cUsuario_Actualiza As String
    Public Shared Property cUsuario_Actualiza() As String
        Get
            Return _cUsuario_Actualiza
        End Get
        Set(ByVal value As String)
            _cUsuario_Actualiza = value
        End Set
    End Property

    Public Shared _cFecha_Actualiza As String
    Public Shared Property cFecha_Actualiza() As String
        Get
            Return _cFecha_Actualiza
        End Get
        Set(ByVal value As String)
            _cFecha_Actualiza = value
        End Set
    End Property
End Class
