Public Class ProduccionSeparadaABC
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

    Public Shared _IdFolioPeso As Integer
    Public Shared Property IdFolioPeso() As Integer
        Get
            Return _IdFolioPeso
        End Get
        Set(ByVal value As Integer)
            _IdFolioPeso = value
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

    Public Shared _IdCentro As Integer
    Public Shared Property IdCentro() As Integer
        Get
            Return _IdCentro
        End Get
        Set(ByVal value As Integer)
            _IdCentro = value
        End Set
    End Property

    Public Shared _Centro As String
    Public Shared Property Centro() As String
        Get
            Return _Centro
        End Get
        Set(ByVal value As String)
            _Centro = value
        End Set
    End Property

    Public Shared _FH_Registro As String
    Public Shared Property FH_Registro() As String
        Get
            Return _FH_Registro
        End Get
        Set(ByVal value As String)
            _FH_Registro = value
        End Set
    End Property

    Public Shared _IdTurno As String
    Public Shared Property IdTurno() As String
        Get
            Return _IdTurno
        End Get
        Set(ByVal value As String)
            _IdTurno = value
        End Set
    End Property

    Public Shared _IdArea As Integer
    Public Shared Property IdArea() As Integer
        Get
            Return _IdArea
        End Get
        Set(ByVal value As Integer)
            _IdArea = value
        End Set
    End Property

    Public Shared _IdAreaProceso As Integer
    Public Shared Property IdAreaProceso() As Integer
        Get
            Return _IdAreaProceso
        End Get
        Set(ByVal value As Integer)
            _IdAreaProceso = value
        End Set
    End Property

    Public Shared _IdEstatus As Integer
    Public Shared Property IdEstatus() As Integer
        Get
            Return _IdEstatus
        End Get
        Set(ByVal value As Integer)
            _IdEstatus = value
        End Set
    End Property

    Public Shared _FH_Pesaje As String
    Public Shared Property FH_Pesaje() As String
        Get
            Return _FH_Pesaje
        End Get
        Set(ByVal value As String)
            _FH_Pesaje = value
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

    Public Shared _IdPuestoTrabajo As String
    Public Shared Property IdPuestoTrabajo() As String
        Get
            Return _IdPuestoTrabajo
        End Get
        Set(ByVal value As String)
            _IdPuestoTrabajo = value
        End Set
    End Property

    Public Shared _PesoBruto As String
    Public Shared Property PesoBruto() As String
        Get
            Return _PesoBruto
        End Get
        Set(ByVal value As String)
            _PesoBruto = value
        End Set
    End Property

    Public Shared _PesoTara As String
    Public Shared Property PesoTara() As String
        Get
            Return _PesoTara
        End Get
        Set(ByVal value As String)
            _PesoTara = value
        End Set
    End Property

    Public Shared _PesoNeto As String
    Public Shared Property PesoNeto() As String
        Get
            Return _PesoNeto
        End Get
        Set(ByVal value As String)
            _PesoNeto = value
        End Set
    End Property

    Public Shared _PesoUnitario As String
    Public Shared Property PesoUnitario() As String
        Get
            Return _PesoUnitario
        End Get
        Set(ByVal value As String)
            _PesoUnitario = value
        End Set
    End Property

    Public Shared _Unidades As Integer
    Public Shared Property Unidades() As Integer
        Get
            Return _Unidades
        End Get
        Set(ByVal value As Integer)
            _Unidades = value
        End Set
    End Property

    Public Shared _Empaques As Integer
    Public Shared Property Empaques() As Integer
        Get
            Return _Empaques
        End Get
        Set(ByVal value As Integer)
            _Empaques = value
        End Set
    End Property

    Public Shared _AutorizaProceso As String
    Public Shared Property AutorizaProceso() As String
        Get
            Return _AutorizaProceso
        End Get
        Set(ByVal value As String)
            _AutorizaProceso = value
        End Set
    End Property

    Public Shared _UsuarioRegistraProceso As String
    Public Shared Property UsuarioRegistraProceso() As String
        Get
            Return _UsuarioRegistraProceso
        End Get
        Set(ByVal value As String)
            _UsuarioRegistraProceso = value
        End Set
    End Property
    Public Shared _Observaciones As String
    Public Shared Property Observaciones() As String
        Get
            Return _Observaciones
        End Get
        Set(ByVal value As String)
            _Observaciones = value
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
End Class
