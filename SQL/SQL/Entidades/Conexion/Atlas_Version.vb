Public Class Atlas_Version
    Public Sub New()

    End Sub
    Public Shared _Version As String
    Public Shared Property Version() As String
        Get
            Return _Version
        End Get
        Set(ByVal value As String)
            _Version = value
        End Set
    End Property
End Class
