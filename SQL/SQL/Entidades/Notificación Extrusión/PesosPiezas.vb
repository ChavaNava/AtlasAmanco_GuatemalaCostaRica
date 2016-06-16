Public Class PesosPiezas
    Public Sub New()

    End Sub

    Public Shared _Piezas As String
    Public Shared Property Piezas() As String
        Get
            Return _Piezas
        End Get
        Set(ByVal value As String)
            _Piezas = value
        End Set
    End Property

    Public Shared _Pesos As String
    Public Shared Property Pesos() As String
        Get
            Return _Pesos
        End Get
        Set(ByVal value As String)
            _Pesos = value
        End Set
    End Property
End Class
