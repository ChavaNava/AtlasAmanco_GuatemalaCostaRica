Public Class CompuestoVirgen
    Public Sub New()

    End Sub

    Public Shared _IdCompOriginal As String
    Public Shared Property IdCompOriginal() As String
        Get
            Return _IdCompOriginal
        End Get
        Set(ByVal value As String)
            _IdCompOriginal = value
        End Set
    End Property
End Class
