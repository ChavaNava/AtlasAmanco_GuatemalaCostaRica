Public Class ResumenMes
    Public Sub New()

    End Sub
    Public Shared _Sobre_Peso As String
    Public Shared Property Sobre_Peso() As String
        Get
            Return _Sobre_Peso
        End Get
        Set(ByVal value As String)
            _Sobre_Peso = value
        End Set
    End Property

    Public Shared _Peso_Scrap As String
    Public Shared Property Peso_Scrap() As String
        Get
            Return _Peso_Scrap
        End Get
        Set(ByVal value As String)
            _Peso_Scrap = value
        End Set
    End Property

    Public Shared _Porcentaje_Scrap As String
    Public Shared Property Porcentaje_Scrap() As String
        Get
            Return _Porcentaje_Scrap
        End Get
        Set(ByVal value As String)
            _Porcentaje_Scrap = value
        End Set
    End Property
End Class
