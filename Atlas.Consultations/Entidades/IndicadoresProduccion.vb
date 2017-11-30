Public Class IndicadoresProduccion
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

    Public Shared _abcIndicador As String
    Public Shared Property abcIndicador() As String
        Get
            Return _abcIndicador
        End Get
        Set(ByVal value As String)
            _abcIndicador = value
        End Set
    End Property

    Public Shared _abcMeta As String
    Public Shared Property abcMeta() As String
        Get
            Return _abcMeta
        End Get
        Set(ByVal value As String)
            _abcMeta = value
        End Set
    End Property

    Public Shared _abcTurno As String
    Public Shared Property abcTurno() As String
        Get
            Return _abcTurno
        End Get
        Set(ByVal value As String)
            _abcTurno = value
        End Set
    End Property

    Public Shared _abcMes As String
    Public Shared Property abcMes() As String
        Get
            Return _abcMes
        End Get
        Set(ByVal value As String)
            _abcMes = value
        End Set
    End Property
End Class
