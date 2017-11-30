Public Class AutorizaAltoBajoPeso
    Public Sub New()

    End Sub
    Public Shared _Autoriza As String
    Public Shared Property Autoriza() As String
        Get
            Return _Autoriza
        End Get
        Set(ByVal value As String)
            _Autoriza = value
        End Set
    End Property
End Class
