Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Imports System.Drawing
Public Class OperacionExtrusionPeru

    Shared Sub Combo_Turnos(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Turno '" & SessionUser._sCentro.Trim & "' "
        Cnn.Combo_ADM(Q)
        NDataSet1 = Cnn.DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Descripcion"
        CB.ValueMember = "Turno"
        CB.Text = ""
    End Sub

    Shared Sub ABC(ByVal Operacion As Integer)
        Cnn.LecturaQry("PA_Produccion_Proceso '','" & ProduccionSeparadaABC._IdFolioPeso & "','" & ProduccionSeparadaABC._OrdenProduccion.Trim & "','" & SessionUser._sIdCentro.Trim & "','" & ProduccionSeparadaABC._FH_Registro & "','','','',''," & Operacion & "")
    End Sub
    Shared Sub TipoScrap(ByVal CB As ComboBox, Area As String, IdScrap As String, Operacion As Integer)
        Dim NDSTipoScrap As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_TipoScrap '" & SessionUser._sCentro.Trim & "','" & IdScrap.Trim & "','','','','" & Area & "', " & Operacion & " "
        Cnn.Combo(Q)
        NDSTipoScrap = Cnn.DataSetCombo.Copy
        CB.DataSource = NDSTipoScrap.Tables(0)
        CB.DisplayMember = "D_Scrap"
        CB.ValueMember = "C_Scrap"
    End Sub
    Public Shared Sub Fecha_Turno(ByVal DT_Turno As DateTimePicker, DT_SAP As DateTimePicker, ByVal CB_SAP As CheckBox)
        DT_Turno.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_SAP.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_Turno.Enabled = True
        CB_SAP.Enabled = True
    End Sub

    Public Shared Sub SAP_Status(ByVal Modulo As String, ByVal TSS As ToolStripStatusLabel)
        StatusSap = SAP_Conexion.Estatus(Modulo)
        Select Case StatusSap
            Case "True"
                TSS.Image = Global.Atlas.ExtrusionPeru.My.Resources.btn_SAPOk
                TSS.Text = "En comunicación con SAP"
                TSS.ForeColor = Color.Blue
            Case "False"
                TSS.Image = Global.Atlas.ExtrusionPeru.My.Resources.btn_SAPFail
                TSS.Text = "No hay comunicación con SAP"
                TSS.ForeColor = Color.Red
        End Select
    End Sub
    Public Shared Sub Cerrar(Modulo As String, Accion As String)
        If SessionUser._sCentro <> Nothing Then
            Log.Alta(SessionUser._sCentro, SessionUser._sAlias, SessionUser._sCadena, SessionUser._sPassword, Modulo, Accion)
        End If
    End Sub
    Public Shared Sub Inicializa_Frm_PTEI(ByVal DT_Turno As DateTimePicker, DT_SAP As DateTimePicker, ByVal CB_SAP As CheckBox)
        DT_Turno.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_SAP.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_Turno.Enabled = True
        CB_SAP.Enabled = True
    End Sub

    Public Shared Sub Notifica_PTE(ByVal strHead As String, List As Generic.List(Of String), strFolio As String, TBDocumento As TextBox, _
                                TBConsecutivo As TextBox, BtnPesar As Button, BtnImp As Button, TBOrd As TextBox, UsrOperador As String)
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
                InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set MsgSAP = '" & Mns.Trim & "' "
                InQry = InQry & " Where Folio = '" & strFolio.Trim & "'"
                Cnn.LecturaQry(InQry)
                Exit Sub
            Else
                If (SAP.DocumentoSAP = "" Or SAP.DocumentoSAP = "NULL" Or SAP.DocumentoSAP = "0000000000") And (SAP.ConsecutivoSAP = "" Or SAP.ConsecutivoSAP = "NULL" Or SAP.ConsecutivoSAP = "00000000") Then
                    reg = "0"
                    LoadingForm.CloseForm()
                    MsgBox("No Notifico a SAP")
                    BtnPesar.Enabled = False
                    BtnImp.Enabled = True
                    TBOrd.Enabled = False
                    SuperAutoSobrepeso = ""
                    Return
                Else
                    reg = "1"
                    TBDocumento.Text = SAP.DocumentoSAP
                    TBConsecutivo.Text = SAP.ConsecutivoSAP
                    Cnn.LecturaQry("PA_Actualiza_Notificacion_Produccion " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, '" & SAP.DocumentoSAP & "', '" & SAP.ConsecutivoSAP & "', '" & reg & "', '" & Mns & "', '" & strFolio & "' ")
                    'Rotomoldeo.Notificacion(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, strFolio, Mns, SAP.DocumentoSAP, SAP.ConsecutivoSAP, reg, 2)
                    BtnImp.Enabled = True
                    TBOrd.Enabled = False
                    SuperAutoSobrepeso = ""
                    LoadingForm.CloseForm()
                    MensajeBox.Mostrar("La notificación de la Orden '" & TBOrd.Text & "' a sido Exitosa ", "Notificación Exitosa", MensajeBox.TipoMensaje.Good)
                End If
            End If
        Catch ex As Exception
            LoadingForm.CloseForm()
            MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
        End Try
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
        Q = "PA_NotificacionExtrusionSC '" & NPTExtrusion._iOrdenProduccion.Trim & "','" & SessionUser._sCentro.Trim & "','" & NPTExtrusion._iFechaPesaje.Trim & "','" & NPTExtrusion._iHoraPesaje.Trim & _
            "','" & NPTExtrusion._iIdBascula.Trim & "','" & NPTExtrusion._iTipoScrap & "'," & NPTExtrusion._iPB & "," & NPTExtrusion._iPT & "," & NPTExtrusion._iPN & "," & NPTExtrusion._iUsuario.Trim & _
            "," & NPTExtrusion._iTurno & ",'0', '', '', '', '0','" & NPTExtrusion._iIdCausa & "','" & NPTExtrusion._iIdDefecto & "','" & NPTExtrusion._iFechaTurno.Trim & "','" & NPTExtrusion._iPuestoTrabajo.Trim.Trim & _
            "','" & NPTExtrusion._iRepGenerado & "','" & NPTExtrusion._iArea.Trim & "', '" & NPTExtrusion._iPuestoTrabajo.Trim.Trim & "','" & NPTExtrusion._iSupervisor.Trim & "','" & NPTExtrusion._iIdRack.Trim & _
            "','" & NPTExtrusion._iComp1.Trim & "','" & NPTExtrusion._iPorc1.Trim & "','" & NPTExtrusion._iCant1.Trim & _
            "','" & NPTExtrusion._iComp2.Trim & "','" & NPTExtrusion._iPorc2.Trim & "','" & NPTExtrusion._iCant2.Trim & "', '', '', '', '" & NPTExtrusion._iVersion.Trim & "', 1"
        Cnn.LecturaQry(Q)

        If (Cnn.LecturaBD.Read) Then
            Notifica_SC = Cnn.LecturaBD(0)
        Else
            Notifica_SC = 0
        End If
    End Function
End Class
