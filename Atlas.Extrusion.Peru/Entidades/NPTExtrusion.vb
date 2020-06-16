Public Class NPTExtrusion
    Public Sub New()

    End Sub

    Public Shared _iOrdenProduccion As String
    Public Shared Property iOrdenProduccion() As String
        Get
            Return _iOrdenProduccion
        End Get
        Set(ByVal value As String)
            _iOrdenProduccion = value
        End Set
    End Property

    Public Shared _iFechaPesaje As String
    Public Shared Property iFechaPesaje() As String
        Get
            Return _iFechaPesaje
        End Get
        Set(ByVal value As String)
            _iFechaPesaje = value
        End Set
    End Property

    Public Shared _iHoraPesaje As String
    Public Shared Property iHoraPesaje() As String
        Get
            Return _iHoraPesaje
        End Get
        Set(ByVal value As String)
            _iHoraPesaje = value
        End Set
    End Property

    Public Shared _iFechaPesajeSAP As String
    Public Shared Property iFechaPesajeSAP() As String
        Get
            Return _iFechaPesajeSAP
        End Get
        Set(ByVal value As String)
            _iFechaPesajeSAP = value
        End Set
    End Property

    Public Shared _iFechaPesajeSAP_CR As String
    Public Shared Property iFechaPesajeSAP_CR() As String
        Get
            Return _iFechaPesajeSAP_CR
        End Get
        Set(ByVal value As String)
            _iFechaPesajeSAP_CR = value
        End Set
    End Property

    Public Shared _iIdBascula As String
    Public Shared Property iIdBascula() As String
        Get
            Return _iIdBascula
        End Get
        Set(ByVal value As String)
            _iIdBascula = value
        End Set
    End Property

    Public Shared _iIdRack As String
    Public Shared Property iIdRack() As String
        Get
            Return _iIdRack
        End Get
        Set(ByVal value As String)
            _iIdRack = value
        End Set
    End Property

    Public Shared _iPB As Decimal
    Public Shared Property iPB() As Decimal
        Get
            Return _iPB
        End Get
        Set(ByVal value As Decimal)
            _iPB = value
        End Set
    End Property

    Public Shared _iPT As Decimal
    Public Shared Property iPT() As Decimal
        Get
            Return _iPT
        End Get
        Set(ByVal value As Decimal)
            _iPT = value
        End Set
    End Property

    Public Shared _iPN As Decimal
    Public Shared Property iPN() As Decimal
        Get
            Return _iPN
        End Get
        Set(ByVal value As Decimal)
            _iPN = value
        End Set
    End Property

    Public Shared _iEmpaques As Integer
    Public Shared Property iEmpaques() As Integer
        Get
            Return _iEmpaques
        End Get
        Set(ByVal value As Integer)
            _iEmpaques = value
        End Set
    End Property

    Public Shared _iTramos As Integer
    Public Shared Property iTramos() As Integer
        Get
            Return _iTramos
        End Get
        Set(ByVal value As Integer)
            _iTramos = value
        End Set
    End Property

    Public Shared _iUsuario As String
    Public Shared Property iUsuario() As String
        Get
            Return _iUsuario
        End Get
        Set(ByVal value As String)
            _iUsuario = value
        End Set
    End Property

    Public Shared _iFechaTurno As String
    Public Shared Property iFechaTurno() As String
        Get
            Return _iFechaTurno
        End Get
        Set(ByVal value As String)
            _iFechaTurno = value
        End Set
    End Property

    Public Shared _iTurno As Integer
    Public Shared Property iTurno() As Integer
        Get
            Return _iTurno
        End Get
        Set(ByVal value As Integer)
            _iTurno = value
        End Set
    End Property

    Public Shared _iSupervisor As String
    Public Shared Property iSupervisor() As String
        Get
            Return _iSupervisor
        End Get
        Set(ByVal value As String)
            _iSupervisor = value
        End Set
    End Property

    Public Shared _iSobrePeso As Decimal
    Public Shared Property iSobrePeso() As Decimal
        Get
            Return _iSobrePeso
        End Get
        Set(ByVal value As Decimal)
            _iSobrePeso = value
        End Set
    End Property

    Public Shared _iTipoCausa As String
    Public Shared Property iTipoCausa() As String
        Get
            Return _iTipoCausa
        End Get
        Set(ByVal value As String)
            _iTipoCausa = value
        End Set
    End Property

    Public Shared _iPuestoTrabajo As String
    Public Shared Property iPuestoTrabajo() As String
        Get
            Return _iPuestoTrabajo
        End Get
        Set(ByVal value As String)
            _iPuestoTrabajo = value
        End Set
    End Property

    Public Shared _iPesoTeorico As Decimal
    Public Shared Property iPesoTeorico() As Decimal
        Get
            Return _iPesoTeorico
        End Get
        Set(ByVal value As Decimal)
            _iPesoTeorico = value
        End Set
    End Property

    Public Shared _iArea As String
    Public Shared Property iArea() As String
        Get
            Return _iArea
        End Get
        Set(ByVal value As String)
            _iArea = value
        End Set
    End Property

    Public Shared _iTipoPT As String
    Public Shared Property iTipoPT() As String
        Get
            Return _iTipoPT
        End Get
        Set(ByVal value As String)
            _iTipoPT = value
        End Set
    End Property

    Public Shared _iEstatusSobrePeso As String
    Public Shared Property iEstatusSobrePeso() As String
        Get
            Return _iEstatusSobrePeso
        End Get
        Set(ByVal value As String)
            _iEstatusSobrePeso = value
        End Set
    End Property

    Public Shared _iComp1 As String
    Public Shared Property iComp1() As String
        Get
            Return _iComp1
        End Get
        Set(ByVal value As String)
            _iComp1 = value
        End Set
    End Property

    Public Shared _iPorc1 As String
    Public Shared Property iPorc1() As String
        Get
            Return _iPorc1
        End Get
        Set(ByVal value As String)
            _iPorc1 = value
        End Set
    End Property

    Public Shared _iCant1 As String
    Public Shared Property iCant1() As String
        Get
            Return _iCant1
        End Get
        Set(ByVal value As String)
            _iCant1 = value
        End Set
    End Property

    Public Shared _iComp2 As String
    Public Shared Property iComp2() As String
        Get
            Return _iComp2
        End Get
        Set(ByVal value As String)
            _iComp2 = value
        End Set
    End Property

    Public Shared _iPorc2 As String
    Public Shared Property iPorc2() As String
        Get
            Return _iPorc2
        End Get
        Set(ByVal value As String)
            _iPorc2 = value
        End Set
    End Property

    Public Shared _iCant2 As String
    Public Shared Property iCant2() As String
        Get
            Return _iCant2
        End Get
        Set(ByVal value As String)
            _iCant2 = value
        End Set
    End Property

    Public Shared _iNotifica As String
    Public Shared Property iNotifica() As String
        Get
            Return _iNotifica
        End Get
        Set(ByVal value As String)
            _iNotifica = value
        End Set
    End Property

    Public Shared _iVersion As String
    Public Shared Property iVersion() As String
        Get
            Return _iVersion
        End Get
        Set(ByVal value As String)
            _iVersion = value
        End Set
    End Property

    Public Shared _iFolioVale As String
    Public Shared Property iFolioVale() As String
        Get
            Return _iFolioVale
        End Get
        Set(ByVal value As String)
            _iFolioVale = value
        End Set
    End Property

    Public Shared _iIdOperadorPtoTra As String
    Public Shared Property iIdOperadorPtoTra() As String
        Get
            Return _iIdOperadorPtoTra
        End Get
        Set(ByVal value As String)
            _iIdOperadorPtoTra = value
        End Set
    End Property

    Public Shared _iTipoScrap As Integer
    Public Shared Property iTipoScrap() As Integer
        Get
            Return _iTipoScrap
        End Get
        Set(ByVal value As Integer)
            _iTipoScrap = value
        End Set
    End Property

    Public Shared _iCompuesto1 As String
    Public Shared Property iCompuesto1() As String
        Get
            Return _iCompuesto1
        End Get
        Set(ByVal value As String)
            _iCompuesto1 = value
        End Set
    End Property

    Public Shared _iCompuesto2 As String
    Public Shared Property iCompuesto2() As String
        Get
            Return _iCompuesto2
        End Get
        Set(ByVal value As String)
            _iCompuesto2 = value
        End Set
    End Property

    Public Shared _iIdCausa As String
    Public Shared Property iIdCausa() As String
        Get
            Return _iIdCausa
        End Get
        Set(ByVal value As String)
            _iIdCausa = value
        End Set
    End Property

    Public Shared _iIdDefecto As String
    Public Shared Property iIdDefecto() As String
        Get
            Return _iIdDefecto
        End Get
        Set(ByVal value As String)
            _iIdDefecto = value
        End Set
    End Property

    Public Shared _iRepGenerado As String
    Public Shared Property iRepGenerado() As String
        Get
            Return _iRepGenerado
        End Get
        Set(ByVal value As String)
            _iRepGenerado = value
        End Set
    End Property

    Public Shared _iLtCompuestos As String
    Public Shared Property iLtCompuestos() As String
        Get
            Return _iLtCompuestos
        End Get
        Set(ByVal value As String)
            _iLtCompuestos = value
        End Set
    End Property

    Public Shared _iNotificacion As String
    Public Shared Property iNotificacion() As String
        Get
            Return _iNotificacion
        End Get
        Set(ByVal value As String)
            _iNotificacion = value
        End Set
    End Property

    Public Shared _iConsecutivo As String
    Public Shared Property iConsecutivo() As String
        Get
            Return _iConsecutivo
        End Get
        Set(ByVal value As String)
            _iConsecutivo = value
        End Set
    End Property
End Class
