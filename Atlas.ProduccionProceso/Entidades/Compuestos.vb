Public Class Compuestos
    Public Sub New()

    End Sub

    Public Shared _IdCompuestoBOM As String
    Public Shared Property IdCompuestoBOM() As String
        Get
            Return _IdCompuestoBOM
        End Get
        Set(ByVal value As String)
            _IdCompuestoBOM = value
        End Set
    End Property
End Class
