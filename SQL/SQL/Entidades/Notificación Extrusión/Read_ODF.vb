Public Class Read_ODF
    Public Sub New()

    End Sub

    Public Shared _rGrpProd As String
    Public Shared Property rGrpProd() As String
        Get
            Return _rGrpProd
        End Get
        Set(ByVal value As String)
            _rGrpProd = value
        End Set
    End Property

    Public Shared _rDescProd As String
    Public Shared Property rDescProd() As String
        Get
            Return _rDescProd
        End Get
        Set(ByVal value As String)
            _rDescProd = value
        End Set
    End Property

    Public Shared _rPesoTeorico As Decimal
    Public Shared Property rPesoTeorico() As Decimal
        Get
            Return _rPesoTeorico
        End Get
        Set(ByVal value As Decimal)
            _rPesoTeorico = value
        End Set
    End Property

    Public Shared _rEstatus As Boolean
    Public Shared Property rEstatus() As Boolean
        Get
            Return _rEstatus
        End Get
        Set(ByVal value As Boolean)
            _rEstatus = value
        End Set
    End Property

    Public Shared _rCodigo As String
    Public Shared Property rCodigo() As String
        Get
            Return _rCodigo
        End Get
        Set(ByVal value As String)
            _rCodigo = value
        End Set
    End Property

    Public Shared _rCantProgramada As Decimal
    Public Shared Property rCantProgramada() As Decimal
        Get
            Return _rCantProgramada
        End Get
        Set(ByVal value As Decimal)
            _rCantProgramada = value
        End Set
    End Property

    Public Shared _rPuestoTrabajo As String
    Public Shared Property rPuestoTrabajo() As String
        Get
            Return _rPuestoTrabajo
        End Get
        Set(ByVal value As String)
            _rPuestoTrabajo = value
        End Set
    End Property

    Public Shared _rGrupMaterial As String
    Public Shared Property rGrupMaterial() As String
        Get
            Return _rGrupMaterial
        End Get
        Set(ByVal value As String)
            _rGrupMaterial = value
        End Set
    End Property

    Public Shared _rSobrePeso As Decimal
    Public Shared Property rSobrePeso() As Decimal
        Get
            Return _rSobrePeso
        End Get
        Set(ByVal value As Decimal)
            _rSobrePeso = value
        End Set
    End Property

    Public Shared _rConCombinado As Boolean
    Public Shared Property rConCombinado() As Boolean
        Get
            Return _rConCombinado
        End Get
        Set(ByVal value As Boolean)
            _rConCombinado = value
        End Set
    End Property

    Public Shared _rPesoAcc As Decimal
    Public Shared Property rPesoAcc() As Decimal
        Get
            Return _rPesoAcc
        End Get
        Set(ByVal value As Decimal)
            _rPesoAcc = value
        End Set
    End Property

    Public Shared _rPesoEmb As Decimal
    Public Shared Property rPesoEmb() As Decimal
        Get
            Return _rPesoEmb
        End Get
        Set(ByVal value As Decimal)
            _rPesoEmb = value
        End Set
    End Property

    Public Shared _rCEmpaque As String
    Public Shared Property rCEmpaque() As String
        Get
            Return _rCEmpaque
        End Get
        Set(ByVal value As String)
            _rCEmpaque = value
        End Set
    End Property

    Public Shared _rDEmpaque As String
    Public Shared Property rDEmpaque() As String
        Get
            Return _rDEmpaque
        End Get
        Set(ByVal value As String)
            _rDEmpaque = value
        End Set
    End Property

    Public Shared _rPeso As Decimal
    Public Shared Property rPeso() As Decimal
        Get
            Return _rPeso
        End Get
        Set(ByVal value As Decimal)
            _rPeso = value
        End Set
    End Property

    Public Shared _rDescGrupo As String
    Public Shared Property rDescGrupo() As String
        Get
            Return _rDescGrupo
        End Get
        Set(ByVal value As String)
            _rDescGrupo = value
        End Set
    End Property

    Public Shared _rDescPtoTrabajo As String
    Public Shared Property rDescPtoTrabajo() As String
        Get
            Return _rDescPtoTrabajo
        End Get
        Set(ByVal value As String)
            _rDescPtoTrabajo = value
        End Set
    End Property

End Class
