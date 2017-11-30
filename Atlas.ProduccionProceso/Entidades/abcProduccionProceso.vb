Public Class abcProduccionProceso
    Public Sub New()

    End Sub

    Public Shared _IdFolioProceso As Integer
    Public Shared Property IdFolioProceso() As Integer
        Get
            Return _IdFolioProceso
        End Get
        Set(ByVal value As Integer)
            _IdFolioProceso = value
        End Set
    End Property
End Class
