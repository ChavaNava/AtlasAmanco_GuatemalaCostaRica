Public Class dgv_TotalHoras
    Public Sub New()

    End Sub

    Public Shared _FechaAvance As String
    Public Shared Property FechaAvance() As String
        Get
            Return _FechaAvance
        End Get
        Set(ByVal value As String)
            _FechaAvance = value
        End Set
    End Property

    Public Shared _EquipoAvance As String
    Public Shared Property EquipoAvance() As String
        Get
            Return _EquipoAvance
        End Get
        Set(ByVal value As String)
            _EquipoAvance = value
        End Set
    End Property

    Public Shared _OrdenProduccion As String
    Public Shared Property OrdenProduccion() As String
        Get
            Return _OrdenProduccion
        End Get
        Set(ByVal value As String)
            _OrdenProduccion = value
        End Set
    End Property

    Public Shared _TurnoAvance As String
    Public Shared Property TurnoAvance() As String
        Get
            Return _TurnoAvance
        End Get
        Set(ByVal value As String)
            _TurnoAvance = value
        End Set
    End Property

    Public Shared _HorasAvance As String
    Public Shared Property HorasAvance() As String
        Get
            Return _HorasAvance
        End Get
        Set(ByVal value As String)
            _HorasAvance = value
        End Set
    End Property

End Class
