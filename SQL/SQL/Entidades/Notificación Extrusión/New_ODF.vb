Public Class New_ODF

    Public Sub New()

    End Sub

    Public Shared _nOrden_Produccion As String
    Public Shared Property nOrden_Produccion() As String
        Get
            Return _nOrden_Produccion
        End Get
        Set(ByVal value As String)
            _nOrden_Produccion = value
        End Set
    End Property

    Public Shared _nCentro As String
    Public Shared Property nCentro() As String
        Get
            Return _nCentro
        End Get
        Set(ByVal value As String)
            _nCentro = value
        End Set
    End Property

    Public Shared _nPuesto_Trabajo As String
    Public Shared Property nPuesto_Trabajo() As String
        Get
            Return _nPuesto_Trabajo
        End Get
        Set(ByVal value As String)
            _nPuesto_Trabajo = value
        End Set
    End Property

    Public Shared _nCodigo As String
    Public Shared Property nCodigo() As String
        Get
            Return _nCodigo
        End Get
        Set(ByVal value As String)
            _nCodigo = value
        End Set
    End Property

    Public Shared _nCantidad_Programada_Tramos As Decimal
    Public Shared Property nCantidad_Programada_Tramos() As Decimal
        Get
            Return _nCantidad_Programada_Tramos
        End Get
        Set(ByVal value As Decimal)
            _nCantidad_Programada_Tramos = value
        End Set
    End Property

    Public Shared _nCantidad_Programada_Kilos As Decimal
    Public Shared Property nCantidad_Programada_Kilos() As Decimal
        Get
            Return _nCantidad_Programada_Kilos
        End Get
        Set(ByVal value As Decimal)
            _nCantidad_Programada_Kilos = value
        End Set
    End Property

    Public Shared _nUM As String
    Public Shared Property nUM() As String
        Get
            Return _nUM
        End Get
        Set(ByVal value As String)
            _nUM = value
        End Set
    End Property

    Public Shared _nFecha_Inicio As String
    Public Shared Property nFecha_Inicio() As String
        Get
            Return _nFecha_Inicio
        End Get
        Set(ByVal value As String)
            _nFecha_Inicio = value
        End Set
    End Property

    Public Shared _nFecha_Termino As String
    Public Shared Property nFecha_Termino() As String
        Get
            Return _nFecha_Termino
        End Get
        Set(ByVal value As String)
            _nFecha_Termino = value
        End Set
    End Property

    Public Shared _nOrigen_Informacion As String
    Public Shared Property nOrigen_Informacion() As String
        Get
            Return _nOrigen_Informacion
        End Get
        Set(ByVal value As String)
            _nOrigen_Informacion = value
        End Set
    End Property

    Public Shared _nEstatus As String
    Public Shared Property nEstatus() As String
        Get
            Return _nEstatus
        End Get
        Set(ByVal value As String)
            _nEstatus = value
        End Set
    End Property

    Public Shared _nEstatus_Desc As String
    Public Shared Property nEstatus_Desc() As String
        Get
            Return _nEstatus_Desc
        End Get
        Set(ByVal value As String)
            _nEstatus_Desc = value
        End Set
    End Property

    Public Shared _nFecha_Inicio_Prod As String
    Public Shared Property nFecha_Inicio_Prod() As String
        Get
            Return _nFecha_Inicio_Prod
        End Get
        Set(ByVal value As String)
            _nFecha_Inicio_Prod = value
        End Set
    End Property

    Public Shared _nTipo_Orden As String
    Public Shared Property nTipo_Orden() As String
        Get
            Return _nTipo_Orden
        End Get
        Set(ByVal value As String)
            _nTipo_Orden = value
        End Set
    End Property

    Public Shared _nCodigo_Material As String
    Public Shared Property nCodigo_Material() As String
        Get
            Return _nCodigo_Material
        End Get
        Set(ByVal value As String)
            _nCodigo_Material = value
        End Set
    End Property

    Public Shared _nDesc_Material As String
    Public Shared Property nDesc_Material() As String
        Get
            Return _nDesc_Material
        End Get
        Set(ByVal value As String)
            _nDesc_Material = value
        End Set
    End Property

    Public Shared _nUM_Material As String
    Public Shared Property nUM_Material() As String
        Get
            Return _nUM_Material
        End Get
        Set(ByVal value As String)
            _nUM_Material = value
        End Set
    End Property

End Class
