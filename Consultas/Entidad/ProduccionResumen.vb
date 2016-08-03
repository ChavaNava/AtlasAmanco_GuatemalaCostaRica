Public Class ProduccionResumen
    Public Sub New()

    End Sub

    Public Shared _Status_Notif As String
    Public Shared Property Status_Notif() As String
        Get
            Return _Status_Notif
        End Get
        Set(ByVal value As String)
            _Status_Notif = value
        End Set
    End Property

    Public Shared _Seccion As String
    Public Shared Property Seccion() As String
        Get
            Return _Seccion
        End Get
        Set(ByVal value As String)
            _Seccion = value
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

    Public Shared _FI As String
    Public Shared Property FI() As String
        Get
            Return _FI
        End Get
        Set(ByVal value As String)
            _FI = value
        End Set
    End Property

    Public Shared _FF As String
    Public Shared Property FF() As String
        Get
            Return _FF
        End Get
        Set(ByVal value As String)
            _FF = value
        End Set
    End Property

    Public Shared _HI As String
    Public Shared Property HI() As String
        Get
            Return _HI
        End Get
        Set(ByVal value As String)
            _HI = value
        End Set
    End Property

    Public Shared _HF As String
    Public Shared Property HF() As String
        Get
            Return _HF
        End Get
        Set(ByVal value As String)
            _HF = value
        End Set
    End Property

End Class
