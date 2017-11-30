Public Class InfoProductionOrder
    Public Sub New()

    End Sub

    Public Shared _ZORDER_NUMBER As String
    Public Shared Property ZORDER_NUMBER() As String
        Get
            Return _ZORDER_NUMBER
        End Get
        Set(ByVal value As String)
            _ZORDER_NUMBER = value
        End Set
    End Property

    Public Shared _ZPRODUCTION_PLANT As String
    Public Shared Property ZPRODUCTION_PLANT() As String
        Get
            Return _ZPRODUCTION_PLANT
        End Get
        Set(ByVal value As String)
            _ZPRODUCTION_PLANT = value
        End Set
    End Property

    Public Shared _ZWORK_CENTER As String
    Public Shared Property ZWORK_CENTER() As String
        Get
            Return _ZWORK_CENTER
        End Get
        Set(ByVal value As String)
            _ZWORK_CENTER = value
        End Set
    End Property

    Public Shared _ZMATERIAL As String
    Public Shared Property ZMATERIAL() As String
        Get
            Return _ZMATERIAL
        End Get
        Set(ByVal value As String)
            _ZMATERIAL = value
        End Set
    End Property

    Public Shared _ZTARGET_QUANTITY As String
    Public Shared Property ZTARGET_QUANTITY() As String
        Get
            Return _ZTARGET_QUANTITY
        End Get
        Set(ByVal value As String)
            _ZTARGET_QUANTITY = value
        End Set
    End Property

    Public Shared _ZUNIT As String
    Public Shared Property ZUNIT() As String
        Get
            Return _ZUNIT
        End Get
        Set(ByVal value As String)
            _ZUNIT = value
        End Set
    End Property

    Public Shared _ZSTART_DATE As String
    Public Shared Property ZSTART_DATE() As String
        Get
            Return _ZSTART_DATE
        End Get
        Set(ByVal value As String)
            _ZSTART_DATE = value
        End Set
    End Property

    Public Shared _ZFINISH_DATE As String
    Public Shared Property ZFINISH_DATE() As String
        Get
            Return _ZFINISH_DATE
        End Get
        Set(ByVal value As String)
            _ZFINISH_DATE = value
        End Set
    End Property

    Public Shared _ZORIGIN As String
    Public Shared Property ZORIGIN() As String
        Get
            Return _ZORIGIN
        End Get
        Set(ByVal value As String)
            _ZORIGIN = value
        End Set
    End Property

    Public Shared _ZSTATUS As String
    Public Shared Property ZSTATUS() As String
        Get
            Return _ZSTATUS
        End Get
        Set(ByVal value As String)
            _ZSTATUS = value
        End Set
    End Property

    Public Shared _ZACTUAL_START_DATE As String
    Public Shared Property ZACTUAL_START_DATE() As String
        Get
            Return _ZACTUAL_START_DATE
        End Get
        Set(ByVal value As String)
            _ZACTUAL_START_DATE = value
        End Set
    End Property

    Public Shared _ZACTUAL_START_TIME As String
    Public Shared Property ZACTUAL_START_TIME() As String
        Get
            Return _ZACTUAL_START_TIME
        End Get
        Set(ByVal value As String)
            _ZACTUAL_START_TIME = value
        End Set
    End Property

End Class
