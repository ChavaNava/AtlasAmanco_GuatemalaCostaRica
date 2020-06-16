Public Class Generic_SAP
#Region "Variables"
    Dim m_DocumentoSAP As String
    Dim m_ConsecutivoSAP As String
#End Region

    Public Sub agregarConsecutivosSAP(ByVal value As String)
        Dim arrayText As String()
        arrayText = value.Split("|")
        If arrayText.Count = 2 Then
            m_DocumentoSAP = arrayText(0)
            m_ConsecutivoSAP = arrayText(1)
        Else
            m_DocumentoSAP = ""
            m_ConsecutivoSAP = ""
        End If
    End Sub

    ReadOnly Property DocumentoSAP() As String
        Get
            Return m_DocumentoSAP
        End Get
    End Property
    ReadOnly Property ConsecutivoSAP() As String
        Get
            Return m_ConsecutivoSAP
        End Get
    End Property
End Class
