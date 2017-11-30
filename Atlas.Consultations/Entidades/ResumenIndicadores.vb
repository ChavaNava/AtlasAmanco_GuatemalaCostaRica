Public Class ResumenIndicadores
    Public Sub New()

    End Sub

    Public Shared _IdIndicador As String
    Public Shared Property IdIndicador() As String
        Get
            Return _IdIndicador
        End Get
        Set(ByVal value As String)
            _IdIndicador = value
        End Set
    End Property

    Public Shared _Indicador As String
    Public Shared Property Indicador() As String
        Get
            Return _Indicador
        End Get
        Set(ByVal value As String)
            _Indicador = value
        End Set
    End Property

    Public Shared _IdCentro As String
    Public Shared Property IdCentro() As String
        Get
            Return _IdCentro
        End Get
        Set(ByVal value As String)
            _IdCentro = value
        End Set
    End Property

End Class
