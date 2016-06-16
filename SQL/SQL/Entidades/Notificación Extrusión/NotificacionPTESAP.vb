Public Class NotificacionPTESAP
    Public Sub New()

    End Sub

    Public Shared _Folio As String
    Public Shared Property Folio() As String
        Get
            Return _Folio
        End Get
        Set(ByVal value As String)
            _Folio = value
        End Set
    End Property

    Public Shared _Documento As String
    Public Shared Property Documento() As String
        Get
            Return _Documento
        End Get
        Set(ByVal value As String)
            _Documento = value
        End Set
    End Property

    Public Shared _Consecutivo As String
    Public Shared Property Consecutivo() As String
        Get
            Return _Consecutivo
        End Get
        Set(ByVal value As String)
            _Consecutivo = value
        End Set
    End Property

    Public Shared _TipoError As String
    Public Shared Property TipoError() As String
        Get
            Return _TipoError
        End Get
        Set(ByVal value As String)
            _TipoError = value
        End Set
    End Property

    Public Shared _Mensaje As String
    Public Shared Property Mensaje() As String
        Get
            Return _Mensaje
        End Get
        Set(ByVal value As String)
            _Mensaje = value
        End Set
    End Property
End Class