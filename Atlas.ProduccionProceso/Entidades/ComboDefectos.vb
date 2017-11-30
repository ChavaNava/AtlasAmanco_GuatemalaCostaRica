Public Class ComboDefectos
    Public Sub New()

    End Sub

    Public Shared _Centro As String
    Public Shared Property Centro() As String
        Get
            Return _Centro
        End Get
        Set(ByVal value As String)
            _Centro = value
        End Set
    End Property

    Public Shared _CodigoCausa As String
    Public Shared Property CodigoCausa() As String
        Get
            Return _CodigoCausa
        End Get
        Set(ByVal value As String)
            _CodigoCausa = value
        End Set
    End Property
End Class
