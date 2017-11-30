Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class OperacionExtrusion
    Shared Sub ABC(ByVal Operacion As Integer)
        Cnn.LecturaQry("PA_Produccion_Proceso '','" & ProduccionSeparadaABC._IdFolioPeso & "','" & ProduccionSeparadaABC._OrdenProduccion.Trim & "','" & SessionUser._sIdCentro.Trim & "','" & ProduccionSeparadaABC._FH_Registro & "','','','',''," & Operacion & "")
    End Sub


    Public Shared Function Notifica_PT() As Integer
        Dim Q As String

        Q = ""
        Q = "PA_NotificacionExtrusionPT '" & NPTExtrusion._iOrdenProduccion.Trim & "','" & SessionUser._sCentro.Trim & "','" & NPTExtrusion._iFechaPesaje.Trim & _
            "','" & NPTExtrusion._iHoraPesaje.Trim & "','" & NPTExtrusion._iIdBascula.Trim & "','" & NPTExtrusion._iIdRack.Trim & "'," & NPTExtrusion._iPB & "," & NPTExtrusion._iPT & "," & NPTExtrusion._iPN & _
            "," & NPTExtrusion._iEmpaques & "," & NPTExtrusion._iTramos & ",'" & NPTExtrusion._iUsuario.Trim & "','" & NPTExtrusion._iFechaTurno.Trim & "','" & NPTExtrusion._iTurno & _
            "','" & NPTExtrusion._iSupervisor.Trim & "','" & NPTExtrusion._iSobrePeso & "','" & NPTExtrusion._iTipoCausa.Trim & "','" & NPTExtrusion._iPuestoTrabajo.Trim.Trim & _
            "'," & NPTExtrusion._iPesoTeorico & ",'" & NPTExtrusion._iArea.Trim & "','" & NPTExtrusion._iTipoPT.Trim & "','" & NPTExtrusion._iEstatusSobrePeso.Trim & "','" & NPTExtrusion._iComp1.Trim & "','" & NPTExtrusion._iPorc1.Trim & "','" & NPTExtrusion._iCant1.Trim & _
            "','" & NPTExtrusion._iComp2.Trim & "','" & NPTExtrusion._iPorc2.Trim & "','" & NPTExtrusion._iCant2.Trim & "','" & NPTExtrusion._iVersion.Trim & "','','" & NPTExtrusion._iFolioVale.Trim & "','" & NPTExtrusion._iIdOperadorPtoTra.Trim & "','" & NPTExtrusion._iNotifica.Trim & "','','','', 1"
        Cnn.LecturaQry(Q)

        If (Cnn.LecturaBD.Read) Then
            Notifica_PT = Cnn.LecturaBD(0)
        Else
            Notifica_PT = 0
        End If
    End Function

    Public Shared Function Notifica_SC() As Integer
        Dim Q As String

        Q = ""
        Q = "PA_NotificacionExtrusionSC '" & NPTExtrusion._iOrdenProduccion.Trim & "','" & SessionUser._sCentro.Trim & "','" & NPTExtrusion._iFechaPesaje.Trim & _
            "','" & NPTExtrusion._iHoraPesaje.Trim & "','" & NPTExtrusion._iIdBascula.Trim & "','" & NPTExtrusion._iTipoScrap.Trim & "'," & NPTExtrusion._iPB & "," & NPTExtrusion._iPT & "," & NPTExtrusion._iPN & _
            ",'" & NPTExtrusion._iUsuario.Trim & "','" & NPTExtrusion._iTurno & "','0','Msg','0000000000','00000000','0','" & NPTExtrusion._iIdCausa.Trim & "','" & NPTExtrusion._iIdDefecto.Trim & "','" & NPTExtrusion._iFechaTurno & _
            "','" & NPTExtrusion._iPuestoTrabajo.Trim & "','" & NPTExtrusion._iRepGenerado.Trim & "','" & NPTExtrusion._iArea.Trim & "','" & NPTExtrusion._iIdOperadorPtoTra.Trim & "','" & NPTExtrusion._iSupervisor.Trim & _
            "'," & NPTExtrusion._iIdRack.Trim & ",'" & NPTExtrusion._iComp1.Trim & "','" & NPTExtrusion._iPorc1.Trim & "','" & NPTExtrusion._iCant1.Trim & "','" & NPTExtrusion._iComp2.Trim & "','" & NPTExtrusion._iPorc2.Trim & "','" & NPTExtrusion._iCant2.Trim & _
            "','','0','0','" & NPTExtrusion._iVersion.Trim & "', 1"
        Cnn.LecturaQry(Q)

        If (Cnn.LecturaBD.Read) Then
            Notifica_SC = Cnn.LecturaBD(0)
        Else
            Notifica_SC = 0
        End If
    End Function
End Class
