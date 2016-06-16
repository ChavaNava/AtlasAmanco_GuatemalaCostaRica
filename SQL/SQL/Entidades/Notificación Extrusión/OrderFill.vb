Public Class OrderFill
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

    Public Shared _GrupoProductivo As String
    Public Shared Property GrupoProductivo() As String
        Get
            Return _GrupoProductivo
        End Get
        Set(ByVal value As String)
            _GrupoProductivo = value
        End Set
    End Property

    Public Shared _DGrupoProductivo As String
    Public Shared Property DGrupoProductivo() As String
        Get
            Return _DGrupoProductivo
        End Get
        Set(ByVal value As String)
            _DGrupoProductivo = value
        End Set
    End Property

    Public Shared _Codigo As String
    Public Shared Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Public Shared _DCodigo As String
    Public Shared Property DCodigo() As String
        Get
            Return _DCodigo
        End Get
        Set(ByVal value As String)
            _DCodigo = value
        End Set
    End Property

    Public Shared _Empaque As String
    Public Shared Property Empaque() As String
        Get
            Return _Empaque
        End Get
        Set(ByVal value As String)
            _Empaque = value
        End Set
    End Property

    Public Shared _PesoTeorico As String
    Public Shared Property PesoTeorico() As String
        Get
            Return _PesoTeorico
        End Get
        Set(ByVal value As String)
            _PesoTeorico = value
        End Set
    End Property

    Public Shared _Estatus As String
    Public Shared Property Estatus() As String
        Get
            Return _Estatus
        End Get
        Set(ByVal value As String)
            _Estatus = value
        End Set
    End Property

    Public Shared _Cantidad As String
    Public Shared Property Cantidad() As String
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As String)
            _Cantidad = value
        End Set
    End Property

    Public Shared _Equipo As String
    Public Shared Property Equipo() As String
        Get
            Return _Equipo
        End Get
        Set(ByVal value As String)
            _Equipo = value
        End Set
    End Property

    Public Shared _DEquipo As String
    Public Shared Property DEquipo() As String
        Get
            Return _DEquipo
        End Get
        Set(ByVal value As String)
            _DEquipo = value
        End Set
    End Property

    Public Shared _GrupoMaterial As String
    Public Shared Property GrupoMaterial() As String
        Get
            Return _GrupoMaterial
        End Get
        Set(ByVal value As String)
            _GrupoMaterial = value
        End Set
    End Property

    Public Shared _SobrePeso As String
    Public Shared Property SobrePeso() As String
        Get
            Return _SobrePeso
        End Get
        Set(ByVal value As String)
            _SobrePeso = value
        End Set
    End Property

End Class
