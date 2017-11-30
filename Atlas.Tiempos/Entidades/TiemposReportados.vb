Public Class TiemposReportados
    Public Sub New()

    End Sub

    Public Shared _Horas As String
    Public Shared Property Horas() As String
        Get
            Return _Horas
        End Get
        Set(ByVal value As String)
            _Horas = value
        End Set
    End Property
End Class
