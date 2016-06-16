Module Md_Notifica_Pt_Scrap
    'Variables WS Productivo
    Dim lo_wsamancomx As New PTConProd.ZPPMXF001Service
    Public ls_return As New PTConProd.ZBAPIRET2
    Dim ls_Notifica As New PTConProd.ZEPP002

    'Variables WS Desarrollo

    Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
    Public ls_returnr As New PTConsumos.ZBAPIRET2
    Dim ls_Notificar As New PTConsumos.ZEPP002

    'Variables WS Productivo consumo de tintas, aditivos y anillos extras

    Dim lo_wsamancomx_p As New PT_ConMat_Prod.ZPPMXF002Service
    Public ls_return_p As New PT_ConMat_Prod.ZBAPIRET2
    Dim ls_Notifica_p As New PT_ConMat_Prod.ZEPP002

    'Variables WS Desarrollo consumo de tintas, aditivos y anillos extras

    Dim lo_wsamancomx_2 As New PT_ConMat_Dev.ZPPMXF002Service
    Public ls_return_2 As New PT_ConMat_Dev.ZBAPIRET2
    Dim ls_Notifica_2 As New PT_ConMat_Dev.ZEPP002

    Public Function Notifica_PT(ByVal Fecha_SAP As String, ByVal Tramos_SAP As Integer, ByVal Orden_SAP As String, ByVal Peso_SAP As Decimal, ByVal Scrap As Decimal, ByVal Cadena As String, ByVal Compuestos As String) As PTConProd._ISDFPS_TCUPS_KEY

        ls_Notifica.ZBUDAT = Fecha_SAP.Trim
        ls_Notifica.ZCONSUME_REC = 0
        ls_Notifica.ZENTRY_QNT = Tramos_SAP
        ls_Notifica.ZISM01 = 0
        ls_Notifica.ZISM02 = 0
        ls_Notifica.ZISM03 = 0
        ls_Notifica.ZISMNGEH1 = ""
        ls_Notifica.ZISMNGEH2 = ""
        ls_Notifica.ZISMNGEH3 = ""
        ls_Notifica.ZMATNR_REC = ""
        ls_Notifica.ZORDERID = Orden_SAP.Trim
        ls_Notifica.ZRECOVERED = 0
        ls_Notifica.ZVIRGIN = Peso_SAP
        lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
        Notifica_PT = lo_wsamancomx.ZPPMXF001(Cadena, Compuestos, ls_Notifica, ls_return)

        lo_wsamancomx.Dispose()

    End Function

    Public Function Notifica_Atlas(ByVal Fecha_SAP As String, ByVal Tramos_SAP As Integer, ByVal Orden_SAP As String, ByVal Peso_SAP As Decimal, ByVal Scrap As Decimal, ByVal Cadena As String, ByVal Compuestos As String) As PTConsumos._ISDFPS_TCUPS_KEY

        ls_Notificar.ZBUDAT = Fecha_SAP.Trim
        ls_Notificar.ZCONSUME_REC = 0
        ls_Notificar.ZENTRY_QNT = Tramos_SAP
        ls_Notificar.ZISM01 = 0
        ls_Notificar.ZISM02 = 0
        ls_Notificar.ZISM03 = 0
        ls_Notificar.ZISMNGEH1 = ""
        ls_Notificar.ZISMNGEH2 = ""
        ls_Notificar.ZISMNGEH3 = ""
        ls_Notificar.ZMATNR_REC = ""
        ls_Notificar.ZORDERID = Orden_SAP
        ls_Notificar.ZRECOVERED = 0
        ls_Notificar.ZVIRGIN = Peso_SAP
        lo_wsamancomxr.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
        Notifica_Atlas = lo_wsamancomxr.ZPPMXF001(Cadena, Compuestos, ls_Notificar, ls_returnr)

        lo_wsamancomxr.Dispose()

    End Function

    Public Function Notifica_Prod(ByVal Fecha_SAP As String, ByVal Tramos_SAP As Integer, ByVal Orden_SAP As String, ByVal Peso_SAP As Decimal, ByVal Scrap As Decimal, ByVal Cadena As String, ByVal Compuestos As String) As PT_ConMat_Prod._ISDFPS_TCUPS_KEY

        ls_Notifica_p.ZBUDAT = Fecha_SAP.Trim
        ls_Notifica_p.ZCONSUME_REC = 0
        ls_Notifica_p.ZENTRY_QNT = Tramos_SAP
        ls_Notifica_p.ZISM01 = 0
        ls_Notifica_p.ZISM02 = 0
        ls_Notifica_p.ZISM03 = 0
        ls_Notifica_p.ZISMNGEH1 = ""
        ls_Notifica_p.ZISMNGEH2 = ""
        ls_Notifica_p.ZISMNGEH3 = ""
        ls_Notifica_p.ZMATNR_REC = ""
        ls_Notifica_p.ZORDERID = Orden_SAP
        ls_Notifica_p.ZRECOVERED = 0
        ls_Notifica_p.ZVIRGIN = Peso_SAP
        lo_wsamancomx_p.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
        Notifica_Prod = lo_wsamancomx_p.ZPPMXF002(Cadena, Compuestos, ls_Notifica_p, ls_return_p)

        lo_wsamancomx.Dispose()

    End Function

    Public Function Notifica_Atlas_Con(ByVal Fecha_SAP As String, ByVal Tramos_SAP As Integer, ByVal Orden_SAP As String, ByVal Peso_SAP As Decimal, ByVal Scrap As Decimal, ByVal Cadena As String, ByVal Compuestos As String) As PT_ConMat_Dev._ISDFPS_TCUPS_KEY

        ls_Notifica_2.ZBUDAT = Fecha_SAP.Trim
        ls_Notifica_2.ZCONSUME_REC = 0
        ls_Notifica_2.ZENTRY_QNT = Tramos_SAP
        ls_Notifica_2.ZISM01 = 0
        ls_Notifica_2.ZISM02 = 0
        ls_Notifica_2.ZISM03 = 0
        ls_Notifica_2.ZISMNGEH1 = ""
        ls_Notifica_2.ZISMNGEH2 = ""
        ls_Notifica_2.ZISMNGEH3 = ""
        ls_Notifica_2.ZMATNR_REC = ""
        ls_Notifica_2.ZORDERID = Orden_SAP
        ls_Notifica_2.ZRECOVERED = 0
        ls_Notifica_2.ZVIRGIN = Peso_SAP
        lo_wsamancomx_2.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
        Notifica_Atlas_Con = lo_wsamancomx_2.ZPPMXF002(Cadena, Compuestos, ls_Notifica_2, ls_return_2)

        lo_wsamancomx_2.Dispose()

    End Function
End Module
