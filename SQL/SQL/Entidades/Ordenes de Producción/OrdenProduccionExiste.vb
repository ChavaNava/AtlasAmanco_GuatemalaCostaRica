Public Class OrdenProduccionExiste
    Public Sub New()

    End Sub

    Public Shared _Orden As String
    Public Shared Property Orden() As String
        Get
            Return _Orden
        End Get
        Set(ByVal value As String)
            _Orden = value
        End Set
    End Property

    Public Shared _IdProducto As String
    Public Shared Property IdProducto() As String
        Get
            Return _IdProducto
        End Get
        Set(ByVal value As String)
            _IdProducto = value
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

    Public Shared _Estatus As Boolean
    Public Shared Property Estatus() As Boolean
        Get
            Return _Estatus
        End Get
        Set(ByVal value As Boolean)
            _Estatus = value
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

    Public Shared _IdTipo As String
    Public Shared Property IdTipo() As String
        Get
            Return _IdTipo
        End Get
        Set(ByVal value As String)
            _IdTipo = value
        End Set
    End Property

    Public Shared _OrigenInformacion As String
    Public Shared Property OrigenInformacion() As String
        Get
            Return _OrigenInformacion
        End Get
        Set(ByVal value As String)
            _OrigenInformacion = value
        End Set
    End Property
End Class
