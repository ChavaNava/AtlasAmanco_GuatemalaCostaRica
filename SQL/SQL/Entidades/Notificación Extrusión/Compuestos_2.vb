Public Class Compuestos_2
    Public Sub New()

    End Sub

    Public Shared _Orden As String
    Public Shared Property Orden() As String
        Get
            Return _Orden
        End Get
        Set(ByVal value As String)
            _Orden = value
        End Set
    End Property

    Public Shared _Codigo As String
    Public Shared Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Public Shared _Lista As String
    Public Shared Property Lista() As String
        Get
            Return _Lista
        End Get
        Set(ByVal value As String)
            _Lista = value
        End Set
    End Property

    Public Shared _Bom As String
    Public Shared Property Bom() As String
        Get
            Return _Bom
        End Get
        Set(ByVal value As String)
            _Bom = value
        End Set
    End Property

    Public Shared _Compuesto As String
    Public Shared Property Compuesto() As String
        Get
            Return _Compuesto
        End Get
        Set(ByVal value As String)
            _Compuesto = value
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

    Public Shared _Porcentaje As String
    Public Shared Property Porcentaje() As String
        Get
            Return _Porcentaje
        End Get
        Set(ByVal value As String)
            _Porcentaje = value
        End Set
    End Property

End Class
