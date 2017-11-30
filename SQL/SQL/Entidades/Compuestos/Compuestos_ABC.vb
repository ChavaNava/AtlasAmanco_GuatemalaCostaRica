Public Class Compuestos_ABC
    Public Sub New()

    End Sub

    Public Shared _IdCompuesto As String
    Public Shared Property IdCompuesto() As String
        Get
            Return _IdCompuesto
        End Get
        Set(ByVal value As String)
            _IdCompuesto = value
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

    Public Shared _UM As String
    Public Shared Property UM() As String
        Get
            Return _UM
        End Get
        Set(ByVal value As String)
            _UM = value
        End Set
    End Property

    Public Shared _Clase As String
    Public Shared Property Clase() As String
        Get
            Return _Clase
        End Get
        Set(ByVal value As String)
            _Clase = value
        End Set
    End Property

    Public Shared _Tipo As String
    Public Shared Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
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

    Public Shared _Reprocesado As String
    Public Shared Property Reprocesado() As String
        Get
            Return _Reprocesado
        End Get
        Set(ByVal value As String)
            _Reprocesado = value
        End Set
    End Property

    Public Shared _FechaHora As String
    Public Shared Property FechaHora() As String
        Get
            Return _FechaHora
        End Get
        Set(ByVal value As String)
            _FechaHora = value
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

End Class
