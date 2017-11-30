Public Class WeighingInquiry
    Public Sub New()

    End Sub

    Public Shared _IdOrden As String
    Public Shared Property IdOrden() As String
        Get
            Return _IdOrden
        End Get
        Set(ByVal value As String)
            _IdOrden = value
        End Set
    End Property

    Public Shared _IdFolio As String
    Public Shared Property IdFolio() As String
        Get
            Return _IdFolio
        End Get
        Set(ByVal value As String)
            _IdFolio = value
        End Set
    End Property
End Class
