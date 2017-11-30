Public Class ReadOrderProducction
    Public Sub New()

    End Sub

    Public Shared _rCentro As String
    Public Shared Property rCentro() As String
        Get
            Return _rCentro
        End Get
        Set(ByVal value As String)
            _rCentro = value
        End Set
    End Property

    Public Shared _rOrden As String
    Public Shared Property rOrden() As String
        Get
            Return _rOrden
        End Get
        Set(ByVal value As String)
            _rOrden = value
        End Set
    End Property

    Public Shared _rIdPuestoTrabajo As String
    Public Shared Property rIdPuestoTrabajo() As String
        Get
            Return _rIdPuestoTrabajo
        End Get
        Set(ByVal value As String)
            _rIdPuestoTrabajo = value
        End Set
    End Property

    Public Shared _rPuestoTrabajo As String
    Public Shared Property rPuestoTrabajo() As String
        Get
            Return _rPuestoTrabajo
        End Get
        Set(ByVal value As String)
            _rPuestoTrabajo = value
        End Set
    End Property

    Public Shared _rIdProducto As String
    Public Shared Property rIdProducto() As String
        Get
            Return _rIdProducto
        End Get
        Set(ByVal value As String)
            _rIdProducto = value
        End Set
    End Property

    Public Shared _rProducto As String
    Public Shared Property rProducto() As String
        Get
            Return _rProducto
        End Get
        Set(ByVal value As String)
            _rProducto = value
        End Set
    End Property

    Public Shared _rIdGrupProd As Integer
    Public Shared Property rIdGrupProd() As Integer
        Get
            Return _rIdGrupProd
        End Get
        Set(ByVal value As Integer)
            _rIdGrupProd = value
        End Set
    End Property

    Public Shared _rGrupProd As String
    Public Shared Property rGrupProd() As String
        Get
            Return _rGrupProd
        End Get
        Set(ByVal value As String)
            _rGrupProd = value
        End Set
    End Property

    Public Shared _rGrupProdDesc As String
    Public Shared Property rGrupProdDesc() As String
        Get
            Return _rGrupProdDesc
        End Get
        Set(ByVal value As String)
            _rGrupProdDesc = value
        End Set
    End Property

    Public Shared _rIdSeccion As String
    Public Shared Property rIdSeccion() As String
        Get
            Return _rIdSeccion
        End Get
        Set(ByVal value As String)
            _rIdSeccion = value
        End Set
    End Property

    Public Shared _rCodSeccion As String
    Public Shared Property rCodSeccion() As String
        Get
            Return _rCodSeccion
        End Get
        Set(ByVal value As String)
            _rCodSeccion = value
        End Set
    End Property

    Public Shared _rSeccion As String
    Public Shared Property rSeccion() As String
        Get
            Return _rSeccion
        End Get
        Set(ByVal value As String)
            _rSeccion = value
        End Set
    End Property

    Public Shared _rIdGrupMaterial As Integer
    Public Shared Property rIdGrupMaterial() As Integer
        Get
            Return _rIdGrupMaterial
        End Get
        Set(ByVal value As Integer)
            _rIdGrupMaterial = value
        End Set
    End Property

    Public Shared _rClaveGrupMaterial As String
    Public Shared Property rClaveGrupMaterial() As String
        Get
            Return _rClaveGrupMaterial
        End Get
        Set(ByVal value As String)
            _rClaveGrupMaterial = value
        End Set
    End Property

    Public Shared _rGrupMaterial As String
    Public Shared Property rGrupMaterial() As String
        Get
            Return _rGrupMaterial
        End Get
        Set(ByVal value As String)
            _rGrupMaterial = value
        End Set
    End Property

    Public Shared _rPesoTeorico As String
    Public Shared Property rPesoTeorico() As String
        Get
            Return _rPesoTeorico
        End Get
        Set(ByVal value As String)
            _rPesoTeorico = value
        End Set
    End Property

End Class
