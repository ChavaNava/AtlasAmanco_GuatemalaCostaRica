Public Class Accionesabc
    Public Sub New()

    End Sub


    Public Shared _IdAccion As String
    Public Shared Property IdAccion() As String
        Get
            Return _IdAccion
        End Get
        Set(ByVal value As String)
            _IdAccion = value
        End Set
    End Property

    Public Shared _IdUsuario As String
    Public Shared Property IdUsuario() As String
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value As String)
            _IdUsuario = value
        End Set
    End Property

End Class
