Public Class WSG

#Region "Variables WS Desarrollo"
    Dim DEV_WS As New Dev_Gen.ZGLMX_ATLAS_GRService
    Dim D_Return As New Dev_Gen.ZBAPIRET2
    Dim D_Tbl As String()
#End Region

#Region "Variables WS Calidad"
    Dim QAS_WS As New Qas_Gen.ZGLMX_ATLAS_GR
    Dim Q_Return As New Qas_Gen.ZBAPIRET2
    Dim Q_Tbl As String()
#End Region

#Region "Variables WS Productivo"
    Dim PRD_WS As New Prd_Gen.ZGLMX_ATLAS_GR
    Dim P_Return As New Prd_Gen.ZBAPIRET2
    Dim P_Tbl As String()

#End Region

#Region "Variables WS Productivo Old"
    Dim PRD_WS_Old As New PTConProd.ZPPMXF001Service
    Dim ls_returnp As New PTConProd.ZBAPIRET2
    Dim ls_Notificap As New PTConProd.ZEPP002
#End Region

#Region "Variables WS Desarrollo Old"
    Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
    Dim ls_returnd As New PTConsumos.ZBAPIRET2
    Dim ls_Notificad As New PTConsumos.ZEPP002
#End Region

#Region "Variables WS Calidad Old"
    Dim QAS_WS_Old As New Qas_PTConsumos.ZPPMXF001Service
    Dim ls_returnq As New Qas_PTConsumos.ZBAPIRET2
    Dim ls_Notificaq As New Qas_PTConsumos.ZEPP002
#End Region

#Region "Variables Generales"
    Public Tbl_resultado As String()
    Public Return_SAP As Object
    Public Tbl_resultado_d As New PTConsumos._ISDFPS_TCUPS_KEY
    Public Tbl_resultado_p As New PTConProd._ISDFPS_TCUPS_KEY
    Public Tbl_resultado_q As New Qas_PTConsumos._ISDFPS_TCUPS_KEY
#End Region

#Region "Metodos"

    Public Function Consume_WS(ByVal E_Header As String, ByVal P_List As Generic.List(Of String), ByVal ID As String) As Object

        If ID.Trim = "D" Then
            DEV_WS.Credentials = New System.Net.NetworkCredential("libra", "mxlibra$")
            D_Tbl = DEV_WS.Z_GLMX_ATLAS_GR(P_List.ToArray, E_Header, D_Return)
            Tbl_resultado = D_Tbl
            Return_SAP = D_Return
        ElseIf ID.Trim = "Q" Then
            QAS_WS.Credentials = New System.Net.NetworkCredential("libra", "mxlibra$")
            Q_Tbl = QAS_WS.Z_GLMX_ATLAS_GR(P_List.ToArray, E_Header, Q_Return)
            Tbl_resultado = Q_Tbl
            Return_SAP = Q_Return
        ElseIf ID.Trim = "P" Then
            PRD_WS.Credentials = New System.Net.NetworkCredential("libra", "mxlibra$")
            P_Tbl = PRD_WS.Z_GLMX_ATLAS_GR(P_List.ToArray, E_Header, P_Return)
            Tbl_resultado = P_Tbl
            Return_SAP = P_Return
        End If

        Return Tbl_resultado

    End Function

    Public Function Consume_Old_WS(ByVal Cadena As String, Compuestos As String, ByVal ID As String, Fecha_SAP As String, Piezas As String, Orden As String, Peso As String) As Object

        If ID.Trim = "D" Then
            ls_Notificad.ZBUDAT = Fecha_SAP.Trim
            ls_Notificad.ZCONSUME_REC = 0.0
            ls_Notificad.ZENTRY_QNT = Piezas.Trim
            ls_Notificad.ZISM01 = 0.0
            ls_Notificad.ZISM02 = 0.0
            ls_Notificad.ZISM03 = 0.0
            ls_Notificad.ZISMNGEH1 = ""
            ls_Notificad.ZISMNGEH2 = ""
            ls_Notificad.ZISMNGEH3 = ""
            ls_Notificad.ZMATNR_REC = ""
            ls_Notificad.ZORDERID = Orden.Trim
            ls_Notificad.ZRECOVERED = 0.0
            ls_Notificad.ZVIRGIN = Peso.Trim
            lo_wsamancomxr.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3matlas2012")
            Tbl_resultado_d = lo_wsamancomxr.ZPPMXF001(Cadena, Compuestos, ls_Notificad, ls_returnd)
            Return_SAP = ls_returnd
            Return Tbl_resultado_d
        ElseIf ID.Trim = "P" Then
            ls_Notificap.ZBUDAT = Fecha_SAP.Trim
            ls_Notificap.ZCONSUME_REC = 0.0
            ls_Notificap.ZENTRY_QNT = Piezas.Trim
            ls_Notificap.ZISM01 = 0.0
            ls_Notificap.ZISM02 = 0.0
            ls_Notificap.ZISM03 = 0.0
            ls_Notificap.ZISMNGEH1 = ""
            ls_Notificap.ZISMNGEH2 = ""
            ls_Notificap.ZISMNGEH3 = ""
            ls_Notificap.ZMATNR_REC = ""
            ls_Notificap.ZORDERID = Orden.Trim
            ls_Notificap.ZRECOVERED = 0.0
            ls_Notificap.ZVIRGIN = Peso.Trim
            PRD_WS_Old.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3matlas2012")
            Tbl_resultado_p = PRD_WS_Old.ZPPMXF001(Cadena, Compuestos, ls_Notificap, ls_returnp)
            Return_SAP = ls_returnp
            Return Tbl_resultado_p
        ElseIf ID.Trim = "Q" Then
            ls_Notificaq.ZBUDAT = Fecha_SAP.Trim
            ls_Notificaq.ZCONSUME_REC = 0.0
            ls_Notificaq.ZENTRY_QNT = Piezas.Trim
            ls_Notificaq.ZISM01 = 0.0
            ls_Notificaq.ZISM02 = 0.0
            ls_Notificaq.ZISM03 = 0.0
            ls_Notificaq.ZISMNGEH1 = ""
            ls_Notificaq.ZISMNGEH2 = ""
            ls_Notificaq.ZISMNGEH3 = ""
            ls_Notificaq.ZMATNR_REC = ""
            ls_Notificaq.ZORDERID = Orden.Trim
            ls_Notificaq.ZRECOVERED = 0.0
            ls_Notificaq.ZVIRGIN = Peso.Trim
            QAS_WS_Old.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3matlas2012")
            Tbl_resultado_q = QAS_WS_Old.ZPPMXF001(Cadena, Compuestos, ls_Notificaq, ls_returnq)
            Return_SAP = ls_returnq
            Return Tbl_resultado_q
        End If
    End Function

#End Region

End Class
