Public Class OrdenProductionSap
    Public Sub New()

    End Sub

    Public Shared _Head As String
    Public Shared Property Head() As String
        Get
            Return _Head
        End Get
        Set(ByVal value As String)
            _Head = value
        End Set
    End Property

    Public Shared _Order As String
    Public Shared Property Order() As String
        Get
            Return _Order
        End Get
        Set(ByVal value As String)
            _Order = value
        End Set
    End Property

    Public Shared _Centro As String
    Public Shared Property Centro() As String
        Get
            Return _Centro
        End Get
        Set(ByVal value As String)
            _Centro = value
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

    Public Shared _IdProducto As String
    Public Shared Property IdProducto() As String
        Get
            Return _IdProducto
        End Get
        Set(ByVal value As String)
            _IdProducto = value
        End Set
    End Property

    Public Shared _CantProduccion As String
    Public Shared Property CantProduccion() As String
        Get
            Return _CantProduccion
        End Get
        Set(ByVal value As String)
            _CantProduccion = value
        End Set
    End Property

    Public Shared _Unidad As String
    Public Shared Property Unidad() As String
        Get
            Return _Unidad
        End Get
        Set(ByVal value As String)
            _Unidad = value
        End Set
    End Property

    Public Shared _FI_Produccion As String
    Public Shared Property FI_Produccion() As String
        Get
            Return _FI_Produccion
        End Get
        Set(ByVal value As String)
            _FI_Produccion = value
        End Set
    End Property

    Public Shared _FF_Produccion As String
    Public Shared Property FF_Produccion() As String
        Get
            Return _FF_Produccion
        End Get
        Set(ByVal value As String)
            _FF_Produccion = value
        End Set
    End Property

    Public Shared _Origen As String
    Public Shared Property Origen() As String
        Get
            Return _Origen
        End Get
        Set(ByVal value As String)
            _Origen = value
        End Set
    End Property

    Public Shared _IdStatus As String
    Public Shared Property IdStatus() As String
        Get
            Return _IdStatus
        End Get
        Set(ByVal value As String)
            _IdStatus = value
        End Set
    End Property

    Public Shared _Status As String
    Public Shared Property Status() As String
        Get
            Return _Status
        End Get
        Set(ByVal value As String)
            _Status = value
        End Set
    End Property

    Public Shared _F_Inicio As String
    Public Shared Property F_Inicio() As String
        Get
            Return _F_Inicio
        End Get
        Set(ByVal value As String)
            _F_Inicio = value
        End Set
    End Property

    Public Shared _Type_Order As String
    Public Shared Property Type_Order() As String
        Get
            Return _Type_Order
        End Get
        Set(ByVal value As String)
            _Type_Order = value
        End Set
    End Property

    Public Shared _IdMessage As String
    Public Shared Property IdMessage() As String
        Get
            Return _IdMessage
        End Get
        Set(ByVal value As String)
            _IdMessage = value
        End Set
    End Property

    Public Shared _Message As String
    Public Shared Property Message() As String
        Get
            Return _Message
        End Get
        Set(ByVal value As String)
            _Message = value
        End Set
    End Property
End Class
