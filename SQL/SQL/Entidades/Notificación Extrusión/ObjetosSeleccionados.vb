Public Class ObjetosSeleccionados
    Public Sub New()

    End Sub

    Public Shared _modCentro As String
    Public Shared Property modCentro() As String
        Get
            Return _modCentro
        End Get
        Set(ByVal value As String)
            _modCentro = value
        End Set
    End Property

    Public Shared _modOrden As String
    Public Shared Property modOrden() As String
        Get
            Return _modOrden
        End Get
        Set(ByVal value As String)
            _modOrden = value
        End Set
    End Property

    Public Shared _modFolio As String
    Public Shared Property modFolio() As String
        Get
            Return _modFolio
        End Get
        Set(ByVal value As String)
            _modFolio = value
        End Set
    End Property

    Public Shared _modTramos As String
    Public Shared Property modTramos() As Integer
        Get
            Return _modTramos
        End Get
        Set(ByVal value As Integer)
            _modTramos = value
        End Set
    End Property

    Public Shared _modPB As String
    Public Shared Property modPB() As Decimal
        Get
            Return _modPB
        End Get
        Set(ByVal value As Decimal)
            _modPB = value
        End Set
    End Property

    Public Shared _modPT As String
    Public Shared Property modPT() As Decimal
        Get
            Return _modPT
        End Get
        Set(ByVal value As Decimal)
            _modPT = value
        End Set
    End Property

    Public Shared _modPN As String
    Public Shared Property modPN() As Decimal
        Get
            Return _modPN
        End Get
        Set(ByVal value As Decimal)
            _modPN = value
        End Set
    End Property

    Public Shared _modComp1 As String
    Public Shared Property modComp1() As String
        Get
            Return _modComp1
        End Get
        Set(ByVal value As String)
            _modComp1 = value
        End Set
    End Property

    Public Shared _modPorc1 As String
    Public Shared Property modPorc1() As Decimal
        Get
            Return _modPorc1
        End Get
        Set(ByVal value As Decimal)
            _modPorc1 = value
        End Set
    End Property

    Public Shared _modCant1 As Decimal
    Public Shared Property modCant1() As Decimal
        Get
            Return _modCant1
        End Get
        Set(ByVal value As Decimal)
            _modCant1 = value
        End Set
    End Property

    Public Shared _modComp2 As String
    Public Shared Property modComp2() As String
        Get
            Return _modComp2
        End Get
        Set(ByVal value As String)
            _modComp2 = value
        End Set
    End Property

    Public Shared _modPorc2 As String
    Public Shared Property modPorc2() As Decimal
        Get
            Return _modPorc2
        End Get
        Set(ByVal value As Decimal)
            _modPorc2 = value
        End Set
    End Property

    Public Shared _modCant2 As Decimal
    Public Shared Property modCant2() As Decimal
        Get
            Return _modCant2
        End Get
        Set(ByVal value As Decimal)
            _modCant2 = value
        End Set
    End Property

    Public Shared _modArea As String
    Public Shared Property modArea() As String
        Get
            Return _modArea
        End Get
        Set(ByVal value As String)
            _modArea = value
        End Set
    End Property
End Class
