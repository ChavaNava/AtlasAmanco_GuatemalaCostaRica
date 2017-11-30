Public Class RegistrarSBP
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

    Public Shared _FolioAtlas As String
    Public Shared Property FolioAtlas() As String
        Get
            Return _FolioAtlas
        End Get
        Set(ByVal value As String)
            _FolioAtlas = value
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

    Public Shared _Sobrepeso As String
    Public Shared Property Sobrepeso() As String
        Get
            Return _Sobrepeso
        End Get
        Set(ByVal value As String)
            _Sobrepeso = value
        End Set
    End Property

    Public Shared _Causa As String
    Public Shared Property Causa() As String
        Get
            Return _Causa
        End Get
        Set(ByVal value As String)
            _Causa = value
        End Set
    End Property

    Public Shared _Autoriza As String
    Public Shared Property Autoriza() As String
        Get
            Return _Autoriza
        End Get
        Set(ByVal value As String)
            _Autoriza = value
        End Set
    End Property

    Public Shared _Observacion As String
    Public Shared Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property

    Public Shared _Aviso As String
    Public Shared Property Aviso() As String
        Get
            Return _Aviso
        End Get
        Set(ByVal value As String)
            _Aviso = value
        End Set
    End Property


End Class
