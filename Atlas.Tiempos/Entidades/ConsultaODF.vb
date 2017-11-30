Public Class ConsultaODF
    Public Sub New()

    End Sub

    Public Shared _rODF As String
    Public Shared Property rODF() As String
        Get
            Return _rODF
        End Get
        Set(ByVal value As String)
            _rODF = value
        End Set
    End Property

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

    Public Shared _rArea As String
    Public Shared Property rArea() As String
        Get
            Return _rArea
        End Get
        Set(ByVal value As String)
            _rArea = value
        End Set
    End Property
End Class
