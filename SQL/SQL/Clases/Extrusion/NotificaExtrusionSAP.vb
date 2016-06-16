Imports WebServices
Imports Utili_Generales
Public Class NotificaExtrusionSAP
    Public Shared Function PTE() As Boolean
        Select Case SessionUser._sAmbiente
            Case Is = "P"
                Dim lo_wsamancomx As New PTConProd.ZPPMXF001Service
                Dim ls_return As New PTConProd.ZBAPIRET2
                Dim ls_Notifica As New PTConProd.ZEPP002
                Dim ls_result As New PTConProd._ISDFPS_TCUPS_KEY

                ls_Notifica.ZBUDAT = NotificacionPTE.FechaPesajeSAP
                ls_Notifica.ZCONSUME_REC = 0
                ls_Notifica.ZENTRY_QNT = NotificacionPTE._Tramos
                ls_Notifica.ZISM01 = 0
                ls_Notifica.ZISM02 = 0
                ls_Notifica.ZISM03 = 0
                ls_Notifica.ZISMNGEH1 = ""
                ls_Notifica.ZISMNGEH2 = ""
                ls_Notifica.ZISMNGEH3 = ""
                ls_Notifica.ZMATNR_REC = ""
                ls_Notifica.ZORDERID = NotificacionPTE._Orden
                ls_Notifica.ZRECOVERED = 0
                ls_Notifica.ZVIRGIN = NotificacionPTE._PN

                'lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                ls_result = lo_wsamancomx.ZPPMXF001(NotificacionPTE._CadenaTexto, NotificacionPTE._LTCompuestos, ls_Notifica, ls_return)

                NotificacionPTESAP.Documento = ls_result.RUECK
                NotificacionPTESAP.Consecutivo = ls_result.RMZHL
                NotificacionPTESAP.TipoError = ls_return.ZTYPE
                NotificacionPTESAP.Mensaje = ls_return.ZMESSAGE
            Case Is = "D"
                Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
                Dim ls_returnr As New PTConsumos.ZBAPIRET2
                Dim ls_Notifica As New PTConsumos.ZEPP002
                Dim ls_result As New PTConsumos._ISDFPS_TCUPS_KEY

                ls_Notifica.ZBUDAT = NotificacionPTE.FechaPesajeSAP
                ls_Notifica.ZCONSUME_REC = 0
                ls_Notifica.ZENTRY_QNT = NotificacionPTE._Tramos
                ls_Notifica.ZISM01 = 0
                ls_Notifica.ZISM02 = 0
                ls_Notifica.ZISM03 = 0
                ls_Notifica.ZISMNGEH1 = ""
                ls_Notifica.ZISMNGEH2 = ""
                ls_Notifica.ZISMNGEH3 = ""
                ls_Notifica.ZMATNR_REC = ""
                ls_Notifica.ZORDERID = NotificacionPTE._Orden
                ls_Notifica.ZRECOVERED = 0
                ls_Notifica.ZVIRGIN = NotificacionPTE._PN

                'lo_wsamancomxr.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                ls_result = lo_wsamancomxr.ZPPMXF001(NotificacionPTE._CadenaTexto, NotificacionPTE._LTCompuestos, ls_Notifica, ls_returnr)

                NotificacionPTESAP.Documento = ls_result.RUECK
                NotificacionPTESAP.Consecutivo = ls_result.RMZHL
                NotificacionPTESAP.TipoError = ls_returnr.ZTYPE
                NotificacionPTESAP.Mensaje = ls_returnr.ZMESSAGE
        End Select

        Select Case NotificacionPTESAP._TipoError.Trim
            Case Is = "E"
                MensajeBox.Mostrar("& NotificacionPTESAP.Mensaje &, Error en SAP Notifique al Supervisor", "Error SAP", MensajeBox.TipoMensaje.Information, MensajeBox.TipoBoton.OkOnly)
                Return False
            Case Else
                Return True
        End Select

    End Function

    Public Shared Function SCE() As Boolean
        Select Case SessionUser._sAmbiente.Trim
            Case Is = "P"
                Dim lo_wsamancomx As New PTConProd.ZPPMXF001Service
                Dim ls_return As New PTConProd.ZBAPIRET2
                Dim ls_Notifica As New PTConProd.ZEPP002
                Dim ls_result As New PTConProd._ISDFPS_TCUPS_KEY

                ls_Notifica.ZBUDAT = NotificacionPTE._FechaPesajeSAP
                ls_Notifica.ZCONSUME_REC = 0
                ls_Notifica.ZENTRY_QNT = 0
                ls_Notifica.ZISM01 = 0
                ls_Notifica.ZISM02 = 0
                ls_Notifica.ZISM03 = 0
                ls_Notifica.ZISMNGEH1 = ""
                ls_Notifica.ZISMNGEH2 = ""
                ls_Notifica.ZISMNGEH3 = ""
                ls_Notifica.ZMATNR_REC = ""
                ls_Notifica.ZORDERID = NotificacionPTE._Orden
                ls_Notifica.ZRECOVERED = NotificacionPTE._PN
                ls_Notifica.ZVIRGIN = 0

                'lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                ls_result = lo_wsamancomx.ZPPMXF001(NotificacionPTE._CadenaTexto, NotificacionPTE._LTCompuestos, ls_Notifica, ls_return)

                NotificacionPTESAP.Documento = ls_result.RUECK
                NotificacionPTESAP.Consecutivo = ls_result.RMZHL
                NotificacionPTESAP.TipoError = ls_return.ZTYPE
                NotificacionPTESAP.Mensaje = ls_return.ZMESSAGE
            Case Is = "D"
                Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
                Dim ls_returnr As New PTConsumos.ZBAPIRET2
                Dim ls_Notifica As New PTConsumos.ZEPP002
                Dim ls_result As New PTConsumos._ISDFPS_TCUPS_KEY

                ls_Notifica.ZBUDAT = NotificacionPTE._FechaPesajeSAP
                ls_Notifica.ZCONSUME_REC = 0
                ls_Notifica.ZENTRY_QNT = 0
                ls_Notifica.ZISM01 = 0
                ls_Notifica.ZISM02 = 0
                ls_Notifica.ZISM03 = 0
                ls_Notifica.ZISMNGEH1 = ""
                ls_Notifica.ZISMNGEH2 = ""
                ls_Notifica.ZISMNGEH3 = ""
                ls_Notifica.ZMATNR_REC = ""
                ls_Notifica.ZORDERID = NotificacionPTE._Orden
                ls_Notifica.ZRECOVERED = NotificacionPTE._PN
                ls_Notifica.ZVIRGIN = 0

                'lo_wsamancomxr.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                ls_result = lo_wsamancomxr.ZPPMXF001(NotificacionPTE._CadenaTexto, NotificacionPTE._LTCompuestos, ls_Notifica, ls_returnr)

                NotificacionPTESAP.Documento = ls_result.RUECK
                NotificacionPTESAP.Consecutivo = ls_result.RMZHL
                NotificacionPTESAP.TipoError = ls_returnr.ZTYPE
                NotificacionPTESAP.Mensaje = ls_returnr.ZMESSAGE
        End Select

        Select Case NotificacionPTESAP._TipoError.Trim
            Case Is = "E"
                MensajeBox.Mostrar("& NotificacionPTESAP.Mensaje &, Error en SAP Notifique al Supervisor", "Error SAP", MensajeBox.TipoMensaje.Information, MensajeBox.TipoBoton.OkOnly)
                Return False
            Case Else
                Return True
        End Select
    End Function
End Class
