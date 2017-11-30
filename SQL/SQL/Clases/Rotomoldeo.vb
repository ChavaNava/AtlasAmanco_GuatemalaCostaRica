Imports System.Data.SqlClient
Imports Utili_Generales
Public Class Rotomoldeo
    Public Shared Function Alta(ByVal Usuario As String, OrdenProduccion As String, Centro As String, Unidades As String, _
                                PuestoTrabajo As String, FH_Pesaje As String, Bascula As String, Rack As String, Peso_Bruto As String, _
                                Peso_Tara As String, Peso_Embalaje As String, Peso_Neto As String, UsrReg As String, Turno As String, _
                                Compuesto1 As String, Porcentaje1 As String, Cantidad1 As String, Compuesto2 As String, _
                                Porcentaje2 As String, Cantidad2 As String, Peso_teorico As String, Opcion As String)
        Dim Q As String
        Dim rFolio As Integer = 0

        Q = ""
        Q = "PA_Registros_Rotomoldeo '" & OrdenProduccion.Trim & "','" & Centro.Trim & "','0','" & Unidades.Trim & "','" & PuestoTrabajo.Trim & "', "
        Q = Q & "'" & FH_Pesaje.Trim & "', '" & Bascula.Trim & "', '" & Rack.Trim & "', '" & Peso_Bruto & "', '" & Peso_Tara & "', "
        Q = Q & "'" & Peso_Embalaje & "','" & Peso_Neto & "','" & UsrReg & "','" & Turno & "','Msg_SAP','','','','" & Compuesto1 & "','" & Porcentaje1 & "',"
        Q = Q & "'" & Cantidad1 & "','" & Compuesto2 & "','" & Porcentaje2 & "','" & Cantidad2 & "','" & Peso_teorico & "','" & Opcion & "'"
        LecturaQry(Q)

        If (LecturaBD.Read) Then
            rFolio = "" & LecturaBD(0)
        End If

        Return rFolio

    End Function

    Public Shared Sub Notificacion(ByVal Usuario As String, Centro As String, Folio As String, Msg_SAP As String, Doc_SAP As String, _
                                   Con_SAP As String, Notifica As String, Opcion As String)

        Dim Q As String

        Q = ""
        Q = "PA_Registros_Rotomoldeo '','" & Centro & "'," & Folio & ",'','','', '', '', '', '','','','','','" & Msg_SAP & "','" & Doc_SAP & "', "
        Q = Q & "'" & Con_SAP & "','" & Notifica & "','','','','','','','','" & Opcion & "'"
        LecturaQry(Q)

    End Sub
End Class
