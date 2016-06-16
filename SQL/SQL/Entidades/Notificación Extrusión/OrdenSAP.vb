Public Class OrdenSAP

    Public Sub New()

    End Sub

    Public _Orden As String
    Public Property Orden() As String
        Get
            Return _Orden
        End Get
        Set(ByVal value As String)
            _Orden = value
        End Set
    End Property

    Public _Centro As String
    Public Property Centro() As String
        Get
            Return _Centro
        End Get
        Set(ByVal value As String)
            _Centro = value
        End Set
    End Property

    Public _Equipo As String
    Public Property Equipo() As String
        Get
            Return _Equipo
        End Get
        Set(ByVal value As String)
            _Equipo = value
        End Set
    End Property

    Public _Codigo As String
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Public _Cantidad As String
    Public Property Cantidad() As String
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As String)
            _Cantidad = value
        End Set
    End Property

    Public _UM As String
    Public Property UM() As String
        Get
            Return _UM
        End Get
        Set(ByVal value As String)
            _UM = value
        End Set
    End Property

    Public _Fecha_Inicio As String
    Public Property Fecha_Inicio() As String
        Get
            Return _Fecha_Inicio
        End Get
        Set(ByVal value As String)
            _Fecha_Inicio = value
        End Set
    End Property

    Public _Fecha_Termino As String
    Public Property Fecha_Termino() As String
        Get
            Return _Fecha_Termino
        End Get
        Set(ByVal value As String)
            _Fecha_Termino = value
        End Set
    End Property

    Public _Origen As String
    Public Property Origen() As String
        Get
            Return _Origen
        End Get
        Set(ByVal value As String)
            _Origen = value
        End Set
    End Property

    Public _Estatus As String
    Public Property Estatus() As String
        Get
            Return _Estatus
        End Get
        Set(ByVal value As String)
            _Estatus = value
        End Set
    End Property

    Public _DEstatus As String
    Public Property DEstatus() As String
        Get
            Return _DEstatus
        End Get
        Set(ByVal value As String)
            _DEstatus = value
        End Set
    End Property

    Public _Fecha_Actual As String
    Public Property Fecha_Actual() As String
        Get
            Return _Fecha_Actual
        End Get
        Set(ByVal value As String)
            _Fecha_Actual = value
        End Set
    End Property

    Public _Tipo_Orden As String
    Public Property Tipo_Orden() As String
        Get
            Return _Tipo_Orden
        End Get
        Set(ByVal value As String)
            _Tipo_Orden = value
        End Set
    End Property

    Public _ConHojaRuta As String
    Public Property ConHojaRuta() As String
        Get
            Return _ConHojaRuta
        End Get
        Set(ByVal value As String)
            _ConHojaRuta = value
        End Set
    End Property

    Public _Fecha As String
    Public Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property

    Public _Usuario As String
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    Public _Version As String
    Public Property Version() As String
        Get
            Return _Version
        End Get
        Set(ByVal value As String)
            _Version = value
        End Set
    End Property

    Public _GrupoMaterial As String
    Public Property GrupoMaterial() As String
        Get
            Return _GrupoMaterial
        End Get
        Set(ByVal value As String)
            _GrupoMaterial = value
        End Set
    End Property
End Class

