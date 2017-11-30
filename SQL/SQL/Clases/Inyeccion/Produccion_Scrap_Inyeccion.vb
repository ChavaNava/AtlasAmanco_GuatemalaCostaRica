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
        LecturaQry("PA_Scrap_Inyeccion '" & SessionUser._sCentro.Trim & "', '" & NotificaScrapIny._Orden.Trim & "', '" & NotificaScrapIny._FechaPesaje & "', '" & NotificaScrapIny._HoraPesaje & "', '" & NotificaScrapIny._Bascula & "', '" & NotificaScrapIny._TipoScrap & "', '" & NotificaScrapIny._PB & "', '" & NotificaScrapIny._PT & "', '" & NotificaScrapIny._PN & "', '" & NotificaScrapIny._Usuario & "', '" & NotificaScrapIny._Turno & "', '" & NotificaScrapIny._FechaTurno & "', '" & NotificaScrapIny._PuestoTrabajo & "', '" & NotificaScrapIny._RepGenerado & "', '" & NotificaScrapIny._Area & "', '" & NotificaScrapIny._OpePtoTrabajo & "', '" & NotificaScrapIny._Supervisor & "', '" & NotificaScrapIny._Rack & "', '" & NotificaScrapIny._LTCompuestos & "', '" & NotificaScrapIny._Comp1 & "', '" & NotificaScrapIny._Porc1 & "', '" & NotificaScrapIny._Cant1 & "', '" & NotificaScrapIny._Comp2 & "', '" & NotificaScrapIny._Porc2 & "', '" & NotificaScrapIny._Cant2 & "', '" & NotificaScrapIny._Comp3 & "', '" & NotificaScrapIny._Porc3 & "', '" & NotificaScrapIny._Cant3 & "'")
    End Sub

    Public Shared Sub Notifica_PTI()
        LecturaQry("PA_PT_Inyeccion '" & NotificacionPtIny._Orden.Trim & "', '" & SessionUser._sCentro.Trim & "', '" & NotificacionPtIny._FechaPesaje & "', '" & NotificacionPtIny._HoraPesaje & "', '" & NotificacionPtIny._Bascula & "', '" & NotificacionPtIny._Rack & "', '" & NotificacionPtIny._PB & "', '" & NotificacionPtIny._PT & "', '" & NotificacionPtIny._PN & "', '" & NotificacionPtIny._Empaques & "', '" & NotificacionPtIny._Piezas & "', '" & NotificacionPtIny._Usuario & "', '" & NotificacionPtIny._FechaTurno & "', '" & NotificacionPtIny._Turno & "', '" & NotificacionPtIny._Supervisor & "', '" & NotificacionPtIny._Sobrepeso & "', '" & NotificacionPtIny._Tipocausa & "', '" & NotificacionPtIny._PuestoTrabajo & "', '" & NotificacionPtIny._PesoTeorico & "', '" & NotificacionPtIny._Area & "', '" & NotificacionPtIny._StatusSobrepeso & "', '" & NotificacionPtIny._Peso_C & "', '" & NotificacionPtIny._Pzas_C & "', '" & NotificacionPtIny._Peso_B & "', '" & NotificacionPtIny._Pzas_B & "', '" & NotificacionPtIny._Comp1 & "', '" & NotificacionPtIny._Porc1 & "', '" & NotificacionPtIny._Cant1 & "', '" & NotificacionPtIny._Comp2 & "', '" & NotificacionPtIny._Porc2 & "', '" & NotificacionPtIny._Cant2 & "', '" & NotificacionPtIny._Comp3 & "', '" & NotificacionPtIny._Porc3 & "', '" & NotificacionPtIny._Cant3 & "'")
    End Sub
End Class
