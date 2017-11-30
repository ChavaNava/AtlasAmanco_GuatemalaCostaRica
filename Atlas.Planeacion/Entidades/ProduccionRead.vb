Public Class ProduccionRead
    Public Sub New()

    End Sub

    Public Shared _rOrdenProduccion As String
    Public Shared Property rOrdenProduccion() As String
        Get
            Return _rOrdenProduccion
        End Get
        Set(ByVal value As String)
            _rOrdenProduccion = value
        End Set
    End Property

    Public Shared _rFolio As String
    Public Shared Property rFolio() As String
        Get
            Return _rFolio
        End Get
        Set(ByVal value As String)
            _rFolio = value
        End Set
    End Property

    Public Shared _rCentro As String
    Public Shared Property rCentro() As String
        Get
            Return _rCentro
        End Get
        Set(ByVal value As String)
            _rCentro = value
        End Set
    End Property

    Public Shared _rArea As String
    Public Shared Property rArea() As String
        Get
            Return _rArea
        End Get
        Set(ByVal value As String)
            _rArea = value
        End Set
    End Property

    Public Shared _rTipoProduccion As String
    Public Shared Property rTipoProduccion() As String
        Get
            Return _rTipoProduccion
        End Get
        Set(ByVal value As String)
            _rTipoProduccion = value
        End Set
    End Property
End Class
