Public Class FHIniFin
    Public Sub New()

    End Sub

    Public Shared _rFIP As String
    Public Shared Property rFIP() As String
        Get
            Return _rFIP
        End Get
        Set(ByVal value As String)
            _rFIP = value
        End Set
    End Property

    Public Shared _rFFP As String
    Public Shared Property rFFP() As String
        Get
            Return _rFFP
        End Get
        Set(ByVal value As String)
            _rFFP = value
        End Set
    End Property

End Class
