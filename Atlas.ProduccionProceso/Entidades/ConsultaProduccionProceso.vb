Public Class ConsultaProduccionProceso
    Public Sub New()

    End Sub

    Public Shared _IdFolioProceso As Integer
    Public Shared Property IdFolioProceso() As Integer
        Get
            Return _IdFolioProceso
        End Get
        Set(ByVal value As Integer)
            _IdFolioProceso = value
        End Set
    End Property

    Public Shared _Area As String
    Public Shared Property Area() As String
        Get
            Return _Area
        End Get
        Set(ByVal value As String)
            _Area = value
        End Set
    End Property

    Public Shared _Estatus As String
    Public Shared Property Estatus() As String
        Get
            Return _Estatus
        End Get
        Set(ByVal value As String)
            _Estatus = value
        End Set
    End Property

    Public Shared _Orden As String
    Public Shared Property Orden() As String
        Get
            Return _Orden
        End Get
        Set(ByVal value As String)
            _Orden = value
        End Set
    End Property

    Public Shared _FI As String
    Public Shared Property FI() As String
        Get
            Return _FI
        End Get
        Set(ByVal value As String)
            _FI = value
        End Set
    End Property

    Public Shared _FF As String
    Public Shared Property FF() As String
        Get
            Return _FF
        End Get
        Set(ByVal value As String)
            _FF = value
        End Set
    End Property
End Class
