Public Class ValidaODF
    Public Sub New()

    End Sub

    Public Shared _rODF As String
    Public Shared Property rODF() As String
        Get
            Return _rODF
        End Get
        Set(ByVal value As String)
            _rODF = value
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

    Public Shared _rEstatus As String
    Public Shared Property rEstatus() As String
        Get
            Return _rEstatus
        End Get
        Set(ByVal value As String)
            _rEstatus = value
        End Set
    End Property

    Public Shared _rIdEquipo As String
    Public Shared Property rIdEquipo() As String
        Get
            Return _rIdEquipo
        End Get
        Set(ByVal value As String)
            _rIdEquipo = value
        End Set
    End Property

    Public Shared _rEquipo As String
    Public Shared Property rEquipo() As String
        Get
            Return _rEquipo
        End Get
        Set(ByVal value As String)
            _rEquipo = value
        End Set
    End Property

    Public Shared _rIdGrpProd As String
    Public Shared Property rIdGrpProd() As String
        Get
            Return _rIdGrpProd
        End Get
        Set(ByVal value As String)
            _rIdGrpProd = value
        End Set
    End Property

    Public Shared _rGrpProd As String
    Public Shared Property rGrpProd() As String
        Get
            Return _rGrpProd
        End Get
        Set(ByVal value As String)
            _rGrpProd = value
        End Set
    End Property

    Public Shared _rGrupoMat As String
    Public Shared Property rGrupoMat() As String
        Get
            Return _rGrupoMat
        End Get
        Set(ByVal value As String)
            _rGrupoMat = value
        End Set
    End Property

    Public Shared _rPesoTeorico As Decimal
    Public Shared Property rPesoTeorico() As String
        Get
            Return _rPesoTeorico
        End Get
        Set(ByVal value As String)
            _rPesoTeorico = value
        End Set
    End Property

    Public Shared _rSPPermitido As Decimal
    Public Shared Property rSPPermitido() As String
        Get
            Return _rSPPermitido
        End Get
        Set(ByVal value As String)
            _rSPPermitido = value
        End Set
    End Property

End Class
