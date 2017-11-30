Public Class AccionCatalog
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

    Public Shared _Descripcion As String
    Public Shared Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
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

    Public Shared _Usuario As String
    Public Shared Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    Public Shared _Nombre As String
    Public Shared Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Shared _Email As String
    Public Shared Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property
End Class
