Public Class OrdenCantidades
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

    Public Shared _Cantidad As String
    Public Shared Property Cantidad() As String
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As String)
            _Cantidad = value
        End Set
    End Property

    Public Shared _CantEntregada As String
    Public Shared Property CantEntregada() As String
        Get
            Return _CantEntregada
        End Get
        Set(ByVal value As String)
            _CantEntregada = value
        End Set
    End Property

    Public Shared _CantSeparada As String
    Public Shared Property CantSeparada() As String
        Get
            Return _CantSeparada
        End Get
        Set(ByVal value As String)
            _CantSeparada = value
        End Set
    End Property

    Public Shared _CantProceso As String
    Public Shared Property CantProceso() As String
        Get
            Return _CantProceso
        End Get
        Set(ByVal value As String)
            _CantProceso = value
        End Set
    End Property

    Public Shared _CantPendientes As String
    Public Shared Property CantPendientes() As String
        Get
            Return _CantPendientes
        End Get
        Set(ByVal value As String)
            _CantPendientes = value
        End Set
    End Property

End Class
