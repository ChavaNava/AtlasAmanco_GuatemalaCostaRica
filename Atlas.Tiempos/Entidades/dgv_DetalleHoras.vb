Public Class dgv_DetalleHoras
    Public Sub New()

    End Sub

    Public Shared _IdTiempo As String
    Public Shared Property IdTiempo() As String
        Get
            Return _IdTiempo
        End Get
        Set(ByVal value As String)
            _IdTiempo = value
        End Set
    End Property

    Public Shared _Fecha As String
    Public Shared Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
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

    Public Shared _IdGrupoParos As String
    Public Shared Property IdGrupoParos() As String
        Get
            Return _IdGrupoParos
        End Get
        Set(ByVal value As String)
            _IdGrupoParos = value
        End Set
    End Property

    Public Shared _GrupoParos As String
    Public Shared Property GrupoParos() As String
        Get
            Return _GrupoParos
        End Get
        Set(ByVal value As String)
            _GrupoParos = value
        End Set
    End Property

    Public Shared _IdParoProduccion As String
    Public Shared Property IdParoProduccion() As String
        Get
            Return _IdParoProduccion
        End Get
        Set(ByVal value As String)
            _IdParoProduccion = value
        End Set
    End Property

    Public Shared _CodigoParo As String
    Public Shared Property CodigoParo() As String
        Get
            Return _CodigoParo
        End Get
        Set(ByVal value As String)
            _CodigoParo = value
        End Set
    End Property

    Public Shared _ConceptoParo As String
    Public Shared Property ConceptoParo() As String
        Get
            Return _ConceptoParo
        End Get
        Set(ByVal value As String)
            _ConceptoParo = value
        End Set
    End Property

    Public Shared _Horas As String
    Public Shared Property Horas() As String
        Get
            Return _Horas
        End Get
        Set(ByVal value As String)
            _Horas = value
        End Set
    End Property
End Class
