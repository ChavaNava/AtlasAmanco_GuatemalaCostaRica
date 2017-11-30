Public Class ResumenOrdenEquipo
    Public Sub New()

    End Sub

    Public Shared _rProduccionkg As String
    Public Shared Property rProduccionkg() As String
        Get
            Return _rProduccionkg
        End Get
        Set(ByVal value As String)
            _rProduccionkg = value
        End Set
    End Property

    Public Shared _rScrapkg As String
    Public Shared Property rScrapkg() As String
        Get
            Return _rScrapkg
        End Get
        Set(ByVal value As String)
            _rScrapkg = value
        End Set
    End Property

    Public Shared _rSobrepesokg As String
    Public Shared Property rSobrepesokg() As String
        Get
            Return _rSobrepesokg
        End Get
        Set(ByVal value As String)
            _rSobrepesokg = value
        End Set
    End Property

    Public Shared _rTeoricokg As String
    Public Shared Property rTeoricokg() As String
        Get
            Return _rTeoricokg
        End Get
        Set(ByVal value As String)
            _rTeoricokg = value
        End Set
    End Property

    Public Shared _rPorcScrap As String
    Public Shared Property rPorcScrap() As String
        Get
            Return _rPorcScrap
        End Get
        Set(ByVal value As String)
            _rPorcScrap = value
        End Set
    End Property

    Public Shared _rPorcSobrepeso As String
    Public Shared Property rPorcSobrepeso() As String
        Get
            Return _rPorcSobrepeso
        End Get
        Set(ByVal value As String)
            _rPorcSobrepeso = value
        End Set
    End Property

    Public Shared _rTramosrequerdios As String
    Public Shared Property rTramosrequerdios() As String
        Get
            Return _rTramosrequerdios
        End Get
        Set(ByVal value As String)
            _rTramosrequerdios = value
        End Set
    End Property

    Public Shared _rTramosproducidos As String
    Public Shared Property rTramosproducidos() As String
        Get
            Return _rTramosproducidos
        End Get
        Set(ByVal value As String)
            _rTramosproducidos = value
        End Set
    End Property

    Public Shared _rSaldo As String
    Public Shared Property rSaldo() As String
        Get
            Return _rSaldo
        End Get
        Set(ByVal value As String)
            _rSaldo = value
        End Set
    End Property

    Public Shared _Porcavance As String
    Public Shared Property Porcavance() As String
        Get
            Return _Porcavance
        End Get
        Set(ByVal value As String)
            _Porcavance = value
        End Set
    End Property
End Class
