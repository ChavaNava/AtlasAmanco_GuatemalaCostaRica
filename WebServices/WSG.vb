Public Class WSG

#Region "Variables Generales"
    Public Shared Tbl_resultado As String()
    Public Shared Return_SAP As Object

    


#End Region

#Region "Metodos"
    Public Shared Function Consume_WS(ByVal Usr_Atlas As String, ByVal E_Header As String, _
                           ByVal P_List As Generic.List(Of String), ByVal ID As String) As Object

 

        If ID.Trim = "D" Then
            Dim DEV_WS As New Dev_Gen.ZGLMX_ATLAS_GRService
            Dim D_Return As New Dev_Gen.ZBAPIRET2
            Dim D_Tbl As String()

            'DEV_WS.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3matlas2012")
            D_Tbl = DEV_WS.Z_GLMX_ATLAS_GR(P_List.ToArray, E_Header, D_Return)
            Tbl_resultado = D_Tbl
            Return_SAP = D_Return
            'ElseIf ID.Trim = "Q" Then
            '    QAS_WS.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3matlas2012")
            '    Q_Tbl = QAS_WS.Z_GLMX_ATLAS_GR(P_List.ToArray, E_Header, Q_Return)
            '    Tbl_resultado = Q_Tbl
            '    Return_SAP = Q_Return
        ElseIf ID.Trim = "P" Then
            Dim PRD_WS As New Prd_Gen.ZGLMX_ATLAS_GR
            Dim P_Return As New Prd_Gen.ZBAPIRET2
            Dim P_Tbl As String()

            'PRD_WS.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3matlas2012")
            P_Tbl = PRD_WS.Z_GLMX_ATLAS_GR(P_List.ToArray, E_Header, P_Return)
            Tbl_resultado = P_Tbl
            Return_SAP = P_Return
        End If

        Return Tbl_resultado

    End Function
#End Region

End Class
