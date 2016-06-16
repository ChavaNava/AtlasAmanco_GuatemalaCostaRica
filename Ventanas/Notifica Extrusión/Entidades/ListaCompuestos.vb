Public Class ListaCompuestos
    Public Sub New()

    End Sub

    Public Shared _cCodigo As String
    Public Shared Property cCodigo() As String
        Get
            Return _cCodigo
        End Get
        Set(ByVal value As String)
            _cCodigo = value
        End Set
    End Property

    Public Shared _cDesc As String
    Public Shared Property cDesc() As String
        Get
            Return _cDesc
        End Get
        Set(ByVal value As String)
            _cDesc = value
        End Set
    End Property

    Public Shared _cPorc As String
    Public Shared Property cPorc() As String
        Get
            Return _cPorc
        End Get
        Set(ByVal value As String)
            _cPorc = value
        End Set
    End Property

    Public Shared _cCantidad As String
    Public Shared Property cCantidad() As String
        Get
            Return _cCantidad
        End Get
        Set(ByVal value As String)
            _cCantidad = value
        End Set
    End Property

    Public Shared _cCodRemp As String
    Public Shared Property cCodRemp() As String
        Get
            Return _cCodRemp
        End Get
        Set(ByVal value As String)
            _cCodRemp = value
        End Set
    End Property

    Public Shared _cDescRemp As String
    Public Shared Property cDescRemp() As String
        Get
            Return _cDescRemp
        End Get
        Set(ByVal value As String)
            _cDescRemp = value
        End Set
    End Property
End Class
