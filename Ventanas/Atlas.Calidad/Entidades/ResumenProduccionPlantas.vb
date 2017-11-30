Public Class ResumenProduccionPlantas
    Public Sub New()

    End Sub

    Public Shared _cFI As String
    Public Shared Property cFI() As String
        Get
            Return _cFI
        End Get
        Set(ByVal value As String)
            _cFI = value
        End Set
    End Property

    Public Shared _cFF As String
    Public Shared Property cFF() As String
        Get
            Return _cFF
        End Get
        Set(ByVal value As String)
            _cFF = value
        End Set
    End Property
End Class
