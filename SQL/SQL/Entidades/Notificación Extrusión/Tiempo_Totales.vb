Public Class Tiempo_Totales
    Public Sub New()

    End Sub

    Public Shared _tTotalTProd As String
    Public Shared Property tTotalTProd() As String
        Get
            Return _tTotalTProd
        End Get
        Set(ByVal value As String)
            _tTotalTProd = value
        End Set
    End Property

    Public Shared _tTotalTParos As String
    Public Shared Property tTotalTParos() As String
        Get
            Return _tTotalTParos
        End Get
        Set(ByVal value As String)
            _tTotalTParos = value
        End Set
    End Property

    Public Shared _tTotalTMuerto As String
    Public Shared Property tTotalTMuerto() As String
        Get
            Return _tTotalTMuerto
        End Get
        Set(ByVal value As String)
            _tTotalTMuerto = value
        End Set
    End Property

End Class
