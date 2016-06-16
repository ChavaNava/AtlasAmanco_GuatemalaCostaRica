Public Class LoginUser
    Public Sub New()

    End Sub
    Public Shared _Login_Alias As String
    Public Shared Property Login_Alias() As String
        Get
            Return _Login_Alias
        End Get
        Set(ByVal value As String)
            _Login_Alias = value
        End Set
    End Property

    Public Shared _Login_Pass As String
    Public Shared Property Login_Pass() As String
        Get
            Return _Login_Pass
        End Get
        Set(ByVal value As String)
            _Login_Pass = value
        End Set
    End Property
End Class
