Public Class NPTExtrusionActualiza
    Public Sub New()

    End Sub

    Public Shared _iOrdenProduccion As String
    Public Shared Property iOrdenProduccion() As String
        Get
            Return _iOrdenProduccion
        End Get
        Set(ByVal value As String)
            _iOrdenProduccion = value
        End Set
    End Property

    Public Shared _iFolioPesaje As String
    Public Shared Property iFolioPesaje() As String
        Get
            Return _iFolioPesaje
        End Get
        Set(ByVal value As String)
            _iFolioPesaje = value
        End Set
    End Property

    Public Shared _iPB As Decimal
    Public Shared Property iPB() As Decimal
        Get
            Return _iPB
        End Get
        Set(ByVal value As Decimal)
            _iPB = value
        End Set
    End Property

    Public Shared _iPT As String
    Public Shared Property iPT() As String
        Get
            Return _iPT
        End Get
        Set(ByVal value As String)
            _iPT = value
        End Set
    End Property

    Public Shared _iPN As Decimal
    Public Shared Property iPN() As Decimal
        Get
            Return _iPN
        End Get
        Set(ByVal value As Decimal)
            _iPN = value
        End Set
    End Property
End Class
