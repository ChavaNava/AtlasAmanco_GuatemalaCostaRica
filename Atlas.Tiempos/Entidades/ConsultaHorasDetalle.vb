Public Class ConsultaHorasDetalle
    Public Sub New()

    End Sub

    Public Shared _Fecha As String
    Public Shared Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property

    Public Shared _PuestoTrabajo As String
    Public Shared Property PuestoTrabajo() As String
        Get
            Return _PuestoTrabajo
        End Get
        Set(ByVal value As String)
            _PuestoTrabajo = value
        End Set
    End Property

    Public Shared _Turno As String
    Public Shared Property Turno() As String
        Get
            Return _Turno
        End Get
        Set(ByVal value As String)
            _Turno = value
        End Set
    End Property
End Class
