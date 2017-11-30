Public Class ConsultasProduccion
    Public Sub New()

    End Sub

    Public Shared _Centro As String
    Public Shared Property Centro() As String
        Get
            Return _Centro
        End Get
        Set(ByVal value As String)
            _Centro = value
        End Set
    End Property

    Public Shared _Area As String
    Public Shared Property Area() As String
        Get
            Return _Area
        End Get
        Set(ByVal value As String)
            _Area = value
        End Set
    End Property

    Public Shared _Seccion As String
    Public Shared Property Seccion() As String
        Get
            Return _Seccion
        End Get
        Set(ByVal value As String)
            _Seccion = value
        End Set
    End Property

    Public Shared _Turno As String
    Public Shared Property Turno() As String
        Get
            Return _Turno
        End Get
        Set(ByVal value As String)
            _Turno = value
        End Set
    End Property

    Public Shared _FI As String
    Public Shared Property FI() As String
        Get
            Return _FI
        End Get
        Set(ByVal value As String)
            _FI = value
        End Set
    End Property

    Public Shared _FF As String
    Public Shared Property FF() As String
        Get
            Return _FF
        End Get
        Set(ByVal value As String)
            _FF = value
        End Set
    End Property

    Public Shared _PuestoTrabajo As String
    Public Shared Property PuestoTrabajo() As String
        Get
            Return _PuestoTrabajo
        End Get
        Set(ByVal value As String)
            _PuestoTrabajo = value
        End Set
    End Property

    Public Shared _Orden As String
    Public Shared Property Orden() As String
        Get
            Return _Orden
        End Get
        Set(ByVal value As String)
            _Orden = value
        End Set
    End Property

    Public Shared _Producto As String
    Public Shared Property Producto() As String
        Get
            Return _Producto
        End Get
        Set(ByVal value As String)
            _Producto = value
        End Set
    End Property


    Public Shared _GrpDiametro As String
    Public Shared Property GrpDiametro() As String
        Get
            Return _GrpDiametro
        End Get
        Set(ByVal value As String)
            _GrpDiametro = value
        End Set
    End Property

    Public Shared _AreaProductiva As String
    Public Shared Property AreaProductiva() As String
        Get
            Return _AreaProductiva
        End Get
        Set(ByVal value As String)
            _AreaProductiva = value
        End Set
    End Property
End Class
