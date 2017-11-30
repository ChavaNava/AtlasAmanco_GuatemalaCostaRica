Public Class FolioNotifica
    Public Sub New()

    End Sub

    Public Shared _rIdFolio As String
    Public Shared Property rIdFolio() As String
        Get
            Return _rIdFolio
        End Get
        Set(ByVal value As String)
            _rIdFolio = value
        End Set
    End Property
End Class