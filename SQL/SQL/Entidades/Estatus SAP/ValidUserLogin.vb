Public Class ValidUserLogin
    Public Sub New()

    End Sub
    Public Shared _Pass As String
    Public Shared Property Pass() As String
        Get
            Return _Pass
        End Get
        Set(ByVal value As String)
            _Pass = value
        End Set
    End Property

End Class
