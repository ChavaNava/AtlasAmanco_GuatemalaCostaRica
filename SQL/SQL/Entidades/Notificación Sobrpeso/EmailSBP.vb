Public Class EmailSBP
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

    Public Shared _Producto As String
    Public Shared Property Producto() As String
        Get
            Return _Producto
        End Get
        Set(ByVal value As String)
            _Producto = value
        End Set
    End Property

    Public Shared _FolioAtlas As String
    Public Shared Property FolioAtlas() As String
        Get
            Return _FolioAtlas
        End Get
        Set(ByVal value As String)
            _FolioAtlas = value
        End Set
    End Property

    Public Shared _Justifica As String
    Public Shared Property Justifica() As String
        Get
            Return _Justifica
        End Get
        Set(ByVal value As String)
            _Justifica = value
        End Set
    End Property

    Public Shared _FH As String
    Public Shared Property FH() As String
        Get
            Return _FH
        End Get
        Set(ByVal value As String)
            _FH = value
        End Set
    End Property

    Public Shared _PB As String
    Public Shared Property PB() As String
        Get
            Return _PB
        End Get
        Set(ByVal value As String)
            _PB = value
        End Set
    End Property

    Public Shared _PT As String
    Public Shared Property PT() As String
        Get
            Return _PT
        End Get
        Set(ByVal value As String)
            _PT = value
        End Set
    End Property

    Public Shared _PN As String
    Public Shared Property PN() As String
        Get
            Return _PN
        End Get
        Set(ByVal value As String)
            _PN = value
        End Set
    End Property

    Public Shared _SBPKilos As String
    Public Shared Property SBPKilos() As String
        Get
            Return _SBPKilos
        End Get
        Set(ByVal value As String)
            _SBPKilos = value
        End Set
    End Property

    Public Shared _SBPPorcentaje As String
    Public Shared Property SBPPorcentaje() As String
        Get
            Return _SBPPorcentaje
        End Get
        Set(ByVal value As String)
            _SBPPorcentaje = value
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

    Public Shared _IdAccion As String
    Public Shared Property IdAccion() As String
        Get
            Return _IdAccion
        End Get
        Set(ByVal value As String)
            _IdAccion = value
        End Set
    End Property
End Class
