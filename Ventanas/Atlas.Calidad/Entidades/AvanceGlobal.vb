Public Class AvanceGlobal
    Public Sub New()

    End Sub

    Public Shared _rPorcentajeScrap As String
    Public Shared Property rPorcentajeScrap() As String
        Get
            Return _rPorcentajeScrap
        End Get
        Set(ByVal value As String)
            _rPorcentajeScrap = value
        End Set
    End Property

    Public Shared _rPorcenatejSobrepeso As String
    Public Shared Property rPorcenatejSobrepeso() As String
        Get
            Return _rPorcenatejSobrepeso
        End Get
        Set(ByVal value As String)
            _rPorcenatejSobrepeso = value
        End Set
    End Property
End Class
