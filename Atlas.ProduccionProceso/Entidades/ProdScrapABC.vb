Public Class ProdScrapABC
    Public Sub New()

    End Sub

    Public Shared _IdCentro As Integer
    Public Shared Property IdCentro() As Integer
        Get
            Return _IdCentro
        End Get
        Set(ByVal value As Integer)
            _IdCentro = value
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

    Public Shared _FechaPesaje As String
    Public Shared Property FechaPesaje() As String
        Get
            Return _FechaPesaje
        End Get
        Set(ByVal value As String)
            _FechaPesaje = value
        End Set
    End Property

    Public Shared _HoraPesaje As String
    Public Shared Property HoraPesaje() As String
        Get
            Return _HoraPesaje
        End Get
        Set(ByVal value As String)
            _HoraPesaje = value
        End Set
    End Property

    Public Shared _IdBascula As String
    Public Shared Property IdBascula() As String
        Get
            Return _IdBascula
        End Get
        Set(ByVal value As String)
            _IdBascula = value
        End Set
    End Property

    Public Shared _IdRack As String
    Public Shared Property IdRack() As String
        Get
            Return _IdRack
        End Get
        Set(ByVal value As String)
            _IdRack = value
        End Set
    End Property

    Public Shared _PB As String
    Public Shared Property PB() As String
        Get
            Return _PB
        End Get
        Set(ByVal value As String)
            _PB = value
        End Set
    End Property

    Public Shared _PT As String
    Public Shared Property PT() As String
        Get
            Return _PT
        End Get
        Set(ByVal value As String)
            _PT = value
        End Set
    End Property

    Public Shared _PN As String
    Public Shared Property PN() As String
        Get
            Return _PN
        End Get
        Set(ByVal value As String)
            _PN = value
        End Set
    End Property

    Public Shared _Empaques As String
    Public Shared Property Empaques() As String
        Get
            Return _Empaques
        End Get
        Set(ByVal value As String)
            _Empaques = value
        End Set
    End Property

    Public Shared _Tramos As String
    Public Shared Property Tramos() As String
        Get
            Return _Tramos
        End Get
        Set(ByVal value As String)
            _Tramos = value
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

    Public Shared _FechaTurno As String
    Public Shared Property FechaTurno() As String
        Get
            Return _FechaTurno
        End Get
        Set(ByVal value As String)
            _FechaTurno = value
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

    Public Shared _Supervisor As String
    Public Shared Property Supervisor() As String
        Get
            Return _Supervisor
        End Get
        Set(ByVal value As String)
            _Supervisor = value
        End Set
    End Property

    Public Shared _SobrePeso As String
    Public Shared Property SobrePeso() As String
        Get
            Return _SobrePeso
        End Get
        Set(ByVal value As String)
            _SobrePeso = value
        End Set
    End Property

    Public Shared _CausaSobrePeso As String
    Public Shared Property CausaSobrePeso() As String
        Get
            Return _CausaSobrePeso
        End Get
        Set(ByVal value As String)
            _CausaSobrePeso = value
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

    Public Shared _PesoTeorico As String
    Public Shared Property PesoTeorico() As String
        Get
            Return _PesoTeorico
        End Get
        Set(ByVal value As String)
            _PesoTeorico = value
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

    Public Shared _EstatusSP As String
    Public Shared Property EstatusSP() As String
        Get
            Return _EstatusSP
        End Get
        Set(ByVal value As String)
            _EstatusSP = value
        End Set
    End Property

    Public Shared _Compuesto1 As String
    Public Shared Property Compuesto1() As String
        Get
            Return _Compuesto1
        End Get
        Set(ByVal value As String)
            _Compuesto1 = value
        End Set
    End Property

    Public Shared _Porcentaje1 As String
    Public Shared Property Porcentaje1() As String
        Get
            Return _Porcentaje1
        End Get
        Set(ByVal value As String)
            _Porcentaje1 = value
        End Set
    End Property

    Public Shared _Cantidad1 As String
    Public Shared Property Cantidad1() As String
        Get
            Return _Cantidad1
        End Get
        Set(ByVal value As String)
            _Cantidad1 = value
        End Set
    End Property

    Public Shared _Compuesto2 As String
    Public Shared Property Compuesto2() As String
        Get
            Return _Compuesto2
        End Get
        Set(ByVal value As String)
            _Compuesto2 = value
        End Set
    End Property

    Public Shared _Porcentaje2 As String
    Public Shared Property Porcentaje2() As String
        Get
            Return _Porcentaje2
        End Get
        Set(ByVal value As String)
            _Porcentaje2 = value
        End Set
    End Property

    Public Shared _Cantidad2 As String
    Public Shared Property Cantidad2() As String
        Get
            Return _Cantidad2
        End Get
        Set(ByVal value As String)
            _Cantidad2 = value
        End Set
    End Property

    Public Shared _Version As String
    Public Shared Property Version() As String
        Get
            Return _Version
        End Get
        Set(ByVal value As String)
            _Version = value
        End Set
    End Property

    Public Shared _FolioVale As String
    Public Shared Property FolioVale() As String
        Get
            Return _FolioVale
        End Get
        Set(ByVal value As String)
            _FolioVale = value
        End Set
    End Property
End Class
