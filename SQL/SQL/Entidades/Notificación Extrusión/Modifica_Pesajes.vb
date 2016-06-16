Public Class Modifica_Pesajes
    Public Sub New()

    End Sub
    Public Shared _mFolio As Integer
    Public Shared Property mFolio() As Integer
        Get
            Return _mFolio
        End Get
        Set(ByVal value As Integer)
            _mFolio = value
        End Set
    End Property

    Public Shared _mTipoProduccion As String
    Public Shared Property mTipoProduccion() As String
        Get
            Return _mTipoProduccion
        End Get
        Set(ByVal value As String)
            _mTipoProduccion = value
        End Set
    End Property

    Public Shared _mOrdenFabricacion As String
    Public Shared Property mOrdenFabricacion() As String
        Get
            Return _mOrdenFabricacion
        End Get
        Set(ByVal value As String)
            _mOrdenFabricacion = value
        End Set
    End Property

    Public Shared _mUnidades As String
    Public Shared Property mUnidades() As String
        Get
            Return _mUnidades
        End Get
        Set(ByVal value As String)
            _mUnidades = value
        End Set
    End Property

    Public Shared _mCodigoProducto As String
    Public Shared Property mCodigoProducto() As String
        Get
            Return _mCodigoProducto
        End Get
        Set(ByVal value As String)
            _mCodigoProducto = value
        End Set
    End Property

    Public Shared _mProducto As String
    Public Shared Property mProducto() As String
        Get
            Return _mProducto
        End Get
        Set(ByVal value As String)
            _mProducto = value
        End Set
    End Property

    Public Shared _mFechaPesaje As String
    Public Shared Property mFechaPesaje() As String
        Get
            Return _mFechaPesaje
        End Get
        Set(ByVal value As String)
            _mFechaPesaje = value
        End Set
    End Property

    Public Shared _mPesoBruto As Decimal
    Public Shared Property mPesoBruto() As Decimal
        Get
            Return _mPesoBruto
        End Get
        Set(ByVal value As Decimal)
            _mPesoBruto = value
        End Set
    End Property

    Public Shared _mPesoTara As Decimal
    Public Shared Property mPesoTara() As Decimal
        Get
            Return _mPesoTara
        End Get
        Set(ByVal value As Decimal)
            _mPesoTara = value
        End Set
    End Property

    Public Shared _mPesoNeto As Decimal
    Public Shared Property mPesoNeto() As Decimal
        Get
            Return _mPesoNeto
        End Get
        Set(ByVal value As Decimal)
            _mPesoNeto = value
        End Set
    End Property

    Public Shared _mPesoEmpaques As Decimal
    Public Shared Property mPesoEmpaques() As Decimal
        Get
            Return _mPesoEmpaques
        End Get
        Set(ByVal value As Decimal)
            _mPesoEmpaques = value
        End Set
    End Property

    Public Shared _mPesoNetoMerma As Decimal
    Public Shared Property mPesoNetoMerma() As Decimal
        Get
            Return _mPesoNetoMerma
        End Get
        Set(ByVal value As Decimal)
            _mPesoNetoMerma = value
        End Set
    End Property

    Public Shared _mCompuesto1 As String
    Public Shared Property mCompuesto1() As String
        Get
            Return _mCompuesto1
        End Get
        Set(ByVal value As String)
            _mCompuesto1 = value
        End Set
    End Property

    Public Shared _mCDescripcion1 As String
    Public Shared Property mCDescripcion1() As String
        Get
            Return _mCDescripcion1
        End Get
        Set(ByVal value As String)
            _mCDescripcion1 = value
        End Set
    End Property

    Public Shared _mPorcentaje1 As String
    Public Shared Property mPorcentaje1() As String
        Get
            Return _mPorcentaje1
        End Get
        Set(ByVal value As String)
            _mPorcentaje1 = value
        End Set
    End Property

    Public Shared _mCantidad1 As Decimal
    Public Shared Property mCantidad1() As Decimal
        Get
            Return _mCantidad1
        End Get
        Set(ByVal value As Decimal)
            _mCantidad1 = value
        End Set
    End Property

    Public Shared _mCompuesto2 As String
    Public Shared Property mCompuesto2() As String
        Get
            Return _mCompuesto2
        End Get
        Set(ByVal value As String)
            _mCompuesto2 = value
        End Set
    End Property

    Public Shared _mCDescripcion2 As String
    Public Shared Property mCDescripcion2() As String
        Get
            Return _mCDescripcion2
        End Get
        Set(ByVal value As String)
            _mCDescripcion2 = value
        End Set
    End Property

    Public Shared _mPorcentaje2 As String
    Public Shared Property mPorcentaje2() As String
        Get
            Return _mPorcentaje2
        End Get
        Set(ByVal value As String)
            _mPorcentaje2 = value
        End Set
    End Property

    Public Shared _mCantidad2 As Decimal
    Public Shared Property mCantidad2() As Decimal
        Get
            Return _mCantidad2
        End Get
        Set(ByVal value As Decimal)
            _mCantidad2 = value
        End Set
    End Property

    Public Shared _mBascula As String
    Public Shared Property mBascula() As String
        Get
            Return _mBascula
        End Get
        Set(ByVal value As String)
            _mBascula = value
        End Set
    End Property

    Public Shared _mRack As String
    Public Shared Property mRack() As String
        Get
            Return _mRack
        End Get
        Set(ByVal value As String)
            _mRack = value
        End Set
    End Property

    Public Shared _mUsuario As String
    Public Shared Property mUsuario() As String
        Get
            Return _mUsuario
        End Get
        Set(ByVal value As String)
            _mUsuario = value
        End Set
    End Property

    Public Shared _mTurno As String
    Public Shared Property mTurno() As String
        Get
            Return _mTurno
        End Get
        Set(ByVal value As String)
            _mTurno = value
        End Set
    End Property

    Public Shared _mDocumento As String
    Public Shared Property mDocumento() As String
        Get
            Return _mDocumento
        End Get
        Set(ByVal value As String)
            _mDocumento = value
        End Set
    End Property

    Public Shared _mConsecutivo As String
    Public Shared Property mConsecutivo() As String
        Get
            Return _mConsecutivo
        End Get
        Set(ByVal value As String)
            _mConsecutivo = value
        End Set
    End Property

    Public Shared _mSobrePeso As Decimal
    Public Shared Property mSobrePeso() As Decimal
        Get
            Return _mSobrePeso
        End Get
        Set(ByVal value As Decimal)
            _mSobrePeso = value
        End Set
    End Property

    Public Shared _mPuestoTrabajo As String
    Public Shared Property mPuestoTrabajo() As String
        Get
            Return _mPuestoTrabajo
        End Get
        Set(ByVal value As String)
            _mPuestoTrabajo = value
        End Set
    End Property

    Public Shared _mNotifica As Integer
    Public Shared Property mNotifica() As Integer
        Get
            Return _mNotifica
        End Get
        Set(ByVal value As Integer)
            _mNotifica = value
        End Set
    End Property

    Public Shared _mPNMerma As Decimal
    Public Shared Property mPNMerma() As Decimal
        Get
            Return _mPNMerma
        End Get
        Set(ByVal value As Decimal)
            _mPNMerma = value
        End Set
    End Property
End Class
