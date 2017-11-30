Public Class ConsultaOrden
    Public Sub New()

    End Sub

    Public Shared _FH As String
    Public Shared Property FH() As String
        Get
            Return _FH
        End Get
        Set(ByVal value As String)
            _FH = value
        End Set
    End Property

    Public Shared _Folio As String
    Public Shared Property Folio() As String
        Get
            Return _Folio
        End Get
        Set(ByVal value As String)
            _Folio = value
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

    Public Shared _Tipo As String
    Public Shared Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property
End Class
