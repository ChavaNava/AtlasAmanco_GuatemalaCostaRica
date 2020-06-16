Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Imports System.Windows.Forms

Public Class Notificacion
    Public Shared Sub PTExtrusion(ByVal strHead As String, List As Generic.List(Of String), strFolio As String)
        Dim Tbl As String()
        Dim Tbl_LM As New Generic.List(Of String)
        Dim SAP_Return As Object
        Dim Doc_Con As String
        Dim Cod_Err As String = ""
        Dim SAP As New Generic_SAP
        Dim reg As String
        Try
            WS_P.Consume_WS(strHead, List, SessionUser._sAmbiente)
            Tbl = WS_P.Tbl_resultado
            SAP_Return = WS_P.Return_SAP
            Err = SAP_Return.ZTYPE
            Mns = SAP_Return.ZMESSAGE
            Doc_Con = SAP_Return.zmessage_v1
            SAP.agregarConsecutivosSAP(Doc_Con)

            If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                LoadingForm.CloseForm()
                reg = "0"
                MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
                InQry = ""
                InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set MsgSAP = '" & Mns.Trim & "' "
                InQry = InQry & " Where Folio = '" & strFolio.Trim & "'"
                Cnn.LecturaQry(InQry)
                Exit Sub
            Else
                If (SAP.DocumentoSAP = "" Or SAP.DocumentoSAP = "NULL" Or SAP.DocumentoSAP = "0000000000") And (SAP.ConsecutivoSAP = "" Or SAP.ConsecutivoSAP = "NULL" Or SAP.ConsecutivoSAP = "00000000") Then
                    LoadingForm.CloseForm()
                    NPTExtrusion.iNotifica = SAP.DocumentoSAP
                    NPTExtrusion.iConsecutivo = SAP.ConsecutivoSAP
                    reg = "0"
                    MsgBox("No Notifico a SAP")
                    SuperAutoSobrepeso = ""
                    Return
                Else
                    reg = "1"
                    Cnn.LecturaQry("PA_Actualiza_Notificacion_Scrap " & SessionUser._sCentro.Trim & "_PesoScrap, '" & SAP.DocumentoSAP & "', '" & SAP.ConsecutivoSAP & "', '" & reg & "', '" & Mns.Trim & "',  '" & strFolio.Trim & "' ")
                    SuperAutoSobrepeso = ""
                    LoadingForm.CloseForm()
                    NPTExtrusion.iNotifica = SAP.DocumentoSAP
                    NPTExtrusion.iConsecutivo = SAP.ConsecutivoSAP
                    MensajeBox.Mostrar("La notificación de la Orden '" & NPTExtrusion._iOrdenProduccion.Trim & "' a sido Exitosa ", "Notificación Exitosa", MensajeBox.TipoMensaje.Good)
                End If
            End If
        Catch ex As Exception
            MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
        End Try
    End Sub
End Class
