Public Class IndicadoresSeguridad
    Public Sub New()

    End Sub

    Public Shared _abcId As String
    Public Shared Property abcId() As String
        Get
            Return _abcId
        End Get
        Set(ByVal value As String)
            _abcId = value
        End Set
    End Property

    Public Shared _abcFecha As String
    Public Shared Property abcFecha() As String
        Get
            Return _abcFecha
        End Get
        Set(ByVal value As String)
            _abcFecha = value
        End Set
    End Property
End Class
