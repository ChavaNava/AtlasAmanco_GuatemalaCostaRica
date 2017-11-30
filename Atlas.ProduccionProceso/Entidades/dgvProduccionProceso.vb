Public Class dgvProduccionProceso
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

    Public Shared _IdFolioPesaje As Integer
    Public Shared Property IdFolioPesaje() As Integer
        Get
            Return _IdFolioPesaje
        End Get
        Set(ByVal value As Integer)
            _IdFolioPesaje = value
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

    Public Shared _IdProducto As Integer
    Public Shared Property IdProducto() As Integer
        Get
            Return _IdProducto
        End Get
        Set(ByVal value As Integer)
            _IdProducto = value
        End Set
    End Property

    Public Shared _Producto As String
    Public Shared Property Producto() As String
        Get
            Return _Producto
        End Get
        Set(ByVal value As String)
            _Producto = value
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

    Public Shared _IdPuestoTrabajo As String
    Public Shared Property IdPuestoTrabajo() As String
        Get
            Return _IdPuestoTrabajo
        End Get
        Set(ByVal value As String)
            _IdPuestoTrabajo = value
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

    Public Shared _Area As String
    Public Shared Property Area() As String
        Get
            Return _Area
        End Get
        Set(ByVal value As String)
            _Area = value
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

    Public Shared _Estatus As String
    Public Shared Property Estatus() As String
        Get
            Return _Estatus
        End Get
        Set(ByVal value As String)
            _Estatus = value
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

    Public Shared _PesoTeorico As String
    Public Shared Property PesoTeorico() As String
        Get
            Return _PesoTeorico
        End Get
        Set(ByVal value As String)
            _PesoTeorico = value
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

    Public Shared _Comp1 As String
    Public Shared Property Comp1() As String
        Get
            Return _Comp1
        End Get
        Set(ByVal value As String)
            _Comp1 = value
        End Set
    End Property

    Public Shared _Porc1 As String
    Public Shared Property Porc1() As String
        Get
            Return _Porc1
        End Get
        Set(ByVal value As String)
            _Porc1 = value
        End Set
    End Property

    Public Shared _Cant1 As String
    Public Shared Property Cant1() As String
        Get
            Return _Cant1
        End Get
        Set(ByVal value As String)
            _Cant1 = value
        End Set
    End Property

    Public Shared _Comp2 As String
    Public Shared Property Comp2() As String
        Get
            Return _Comp2
        End Get
        Set(ByVal value As String)
            _Comp2 = value
        End Set
    End Property

    Public Shared _Porc2 As String
    Public Shared Property Porc2() As String
        Get
            Return _Porc2
        End Get
        Set(ByVal value As String)
            _Porc2 = value
        End Set
    End Property

    Public Shared _Cant2 As String
    Public Shared Property Cant2() As String
        Get
            Return _Cant2
        End Get
        Set(ByVal value As String)
            _Cant2 = value
        End Set
    End Property
End Class
