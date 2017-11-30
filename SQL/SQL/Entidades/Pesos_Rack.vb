Public Class Pesos_Rack
    Public Sub New()

    End Sub

    Public Shared _Peso As String
    Public Shared Property Peso() As String
        Get
            Return _Peso
        End Get
        Set(ByVal value As String)
            _Peso = value
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
