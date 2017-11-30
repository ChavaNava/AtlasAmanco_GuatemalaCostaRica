Public Class AccionQuery
    Public Sub New()

    End Sub

    Public Shared _Centro As String
    Public Shared Property Centro() As String
        Get
            Return _Centro
        End Get
        Set(ByVal value As String)
            _Centro = value
        End Set
    End Property

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

    Public Shared _Activo As String
    Public Shared Property Activo() As String
        Get
            Return _Activo
        End Get
        Set(ByVal value As String)
            _Activo = value
        End Set
    End Property

    Public Shared _Operacion As String
    Public Shared Property Operacion() As String
        Get
            Return _Operacion
        End Get
        Set(ByVal value As String)
            _Operacion = value
        End Set
    End Property
End Class
