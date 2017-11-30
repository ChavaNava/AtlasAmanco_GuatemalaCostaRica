Public Class Generic_SAP
#Region "Variables"
    Public Shared m_DocumentoSAP As String
    Public Shared m_ConsecutivoSAP As String
#End Region

    Public Shared Sub agregarConsecutivosSAP(ByVal value As String)
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

    Shared ReadOnly Property DocumentoSAP() As String
        Get
            Return m_DocumentoSAP
        End Get
    End Property
    Shared ReadOnly Property ConsecutivoSAP() As String
        Get
            Return m_ConsecutivoSAP
        End Get
    End Property
End Class
