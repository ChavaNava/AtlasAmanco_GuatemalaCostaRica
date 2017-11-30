Public Class ResumenSeg
    Public Sub New()

    End Sub
    Public Shared _dias As String
    Public Shared Property dias() As String
        Get
            Return _dias
        End Get
        Set(ByVal value As String)
            _dias = value
        End Set
    End Property
End Class
