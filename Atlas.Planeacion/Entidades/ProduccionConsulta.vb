Public Class ProduccionConsulta
    Public Sub New()

    End Sub

    Public Shared _cCentro As String
    Public Shared Property cCentro() As String
        Get
            Return _cCentro
        End Get
        Set(ByVal value As String)
            _cCentro = value
        End Set
    End Property

    Public Shared _cFI As String
    Public Shared Property cFI() As String
        Get
            Return _cFI
        End Get
        Set(ByVal value As String)
            _cFI = value
        End Set
    End Property

    Public Shared _cHF As String
    Public Shared Property cHF() As String
        Get
            Return _cHF
        End Get
        Set(ByVal value As String)
            _cHF = value
        End Set
    End Property

    Public Shared _cHI As String
    Public Shared Property cHI() As String
        Get
            Return _cHI
        End Get
        Set(ByVal value As String)
            _cHI = value
        End Set
    End Property

    Public Shared _cFF As String
    Public Shared Property cFF() As String
        Get
            Return _cFF
        End Get
        Set(ByVal value As String)
            _cFF = value
        End Set
    End Property

    Public Shared _cOrden As String
    Public Shared Property cOrden() As String
        Get
            Return _cOrden
        End Get
        Set(ByVal value As String)
            _cOrden = value
        End Set
    End Property

    Public Shared _cFolio As String
    Public Shared Property cFolio() As String
        Get
            Return _cFolio
        End Get
        Set(ByVal value As String)
            _cFolio = value
        End Set
    End Property

    Public Shared _cTurno As String
    Public Shared Property cTurno() As String
        Get
            Return _cTurno
        End Get
        Set(ByVal value As String)
            _cTurno = value
        End Set
    End Property

    Public Shared _cArea As String
    Public Shared Property cArea() As String
        Get
            Return _cArea
        End Get
        Set(ByVal value As String)
            _cArea = value
        End Set
    End Property

End Class
