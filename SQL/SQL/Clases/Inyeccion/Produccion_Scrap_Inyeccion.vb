Imports System.Data.SqlClient
Public Class Produccion_Scrap_Inyeccion
    Public Shared Function Valida_Bom(ByVal Centro As String, Usuario As String, Codigo As String)
        Dim Cod_Compuesto As String = "0"

        LecturaQry("PA_Identifica_Compuesto_BOM '" & Centro & "', '" & Codigo & "' ")
        If (LecturaBD.Read) Then
            Cod_Compuesto = "" & LecturaBD(0)
        End If

        Return Cod_Compuesto
    End Function

    Public Shared Sub Notifica_Scrap()
        LecturaQry("PA_Scrap_Inyeccion '" & SessionUser._sCentro.Trim & "', '" & NotificaScrapIny._Orden.Trim & "', '" & NotificaScrapIny._FechaPesaje & "', '" & NotificaScrapIny._HoraPesaje & _
                   "', '" & NotificaScrapIny._Bascula & "', '" & NotificaScrapIny._TipoScrap & "', '" & NotificaScrapIny._PB & "', '" & NotificaScrapIny._PT & "', '" & NotificaScrapIny._PN & "', '" & NotificaScrapIny._Usuario & "', '" & NotificaScrapIny._Turno & "', '" & NotificaScrapIny._FechaTurno & "', '" & NotificaScrapIny._PuestoTrabajo & "', '" & NotificaScrapIny._RepGenerado & "', '" & NotificaScrapIny._Area & "', '" & NotificaScrapIny._OpePtoTrabajo & "', '" & NotificaScrapIny._Supervisor & "', '" & NotificaScrapIny._Rack & "', '" & NotificaScrapIny._LTCompuestos & "', '" & NotificaScrapIny._Comp1 & "', '" & NotificaScrapIny._Porc1 & "', '" & NotificaScrapIny._Cant1 & "', '" & NotificaScrapIny._Comp2 & "', '" & NotificaScrapIny._Porc2 & "', '" & NotificaScrapIny._Cant2 & "', '" & NotificaScrapIny._Comp3 & "', '" & NotificaScrapIny._Porc3 & "', '" & NotificaScrapIny._Cant3 & "'")
    End Sub

    Public Shared Function Notifica_PTI() As Integer
        Dim Q As String
        Q = ""
        Q = "PA_PT_Inyeccion '" & NotificacionPtIny._OrdenProduccion.Trim & "', '" & NotificacionPtIny._Centro.Trim & "', '" & NotificacionPtIny._FechaPesaje.Trim & "', '" & NotificacionPtIny._HoraPesaje.Trim & _
                   "', '" & NotificacionPtIny._Bascula.Trim & "', '" & NotificacionPtIny._Rack.Trim & "', '" & NotificacionPtIny._PB.Trim & "', '" & NotificacionPtIny._PT.Trim & "', '" & NotificacionPtIny._PN.Trim & _
                   "', '" & NotificacionPtIny._Empaques.Trim & "', '" & NotificacionPtIny._Piezas.Trim & "', '" & NotificacionPtIny._Usuario.Trim & "', '" & NotificacionPtIny._FechaTurno.Trim & _
                   "', '" & NotificacionPtIny._Turno.Trim & "', '" & NotificacionPtIny._Supervisor.Trim & "', '" & NotificacionPtIny._Sobrepeso.Trim & "', '" & NotificacionPtIny._Tipocausa.Trim & _
                   "', '" & NotificacionPtIny._PuestoTrabajo.Trim & "', '" & NotificacionPtIny._PesoTeorico.Trim & "', '" & NotificacionPtIny._Area.Trim & "', '" & NotificacionPtIny._Tipo_PT.Trim & _
                   "', '" & NotificacionPtIny._StatusSobrepeso.Trim & "', '" & NotificacionPtIny._Peso_C.Trim & "', '" & NotificacionPtIny._Pzas_C.Trim & "', '" & NotificacionPtIny._Peso_B.Trim & _
                   "', '" & NotificacionPtIny._Pzas_B.Trim & "', '" & NotificacionPtIny._Comp1.Trim & "', '" & NotificacionPtIny._Porc1.Trim & "', '" & NotificacionPtIny._Cant1.Trim & _
                   "', '" & NotificacionPtIny._Comp2.Trim & "', '" & NotificacionPtIny._Porc2.Trim & "', '" & NotificacionPtIny._Cant2.Trim & "', '" & NotificacionPtIny._Comp3.Trim & _
                   "', '" & NotificacionPtIny._Porc3.Trim & "', '" & NotificacionPtIny._Cant3.Trim & "', '" & NotificacionPtIny._LTCompuestos.Trim & "', '" & NotificacionPtIny._Version.Trim & _
                   "', '" & NotificacionPtIny._FolioPesaje.Trim & "', '" & NotificacionPtIny._FolioVale.Trim & "', '" & NotificacionPtIny._OperadortPtoTrabajo.Trim & "', '" & NotificacionPtIny._Notifica.Trim & _
                   "', '" & NotificacionPtIny._MsgSAP.Trim & "', '" & NotificacionPtIny._DocSAP.Trim & "', '" & NotificacionPtIny._NumSAP.Trim & "', '1'"
        Cnn.LecturaQry(Q)

        If (Cnn.LecturaBD.Read) Then
            Notifica_PTI = Cnn.LecturaBD(0)
        Else
            Notifica_PTI = 0
        End If
    End Function
End Class
