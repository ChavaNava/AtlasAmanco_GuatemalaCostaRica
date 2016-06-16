Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmNotMasiva

#Region "Variables Miembro"
    Dim Status_Not As String
    Dim SAP As New Generic_SAP
    Dim SAP_dup As New Generic_SAP
    Dim Err As String
    Dim Mns As String
    Dim Doc_Con As String
    Dim Doc_Con_dup As String
    Dim reg As String

    Dim Notifica_ODF As String
    Dim Notific_Fecha As String
    Dim Notifica_Folio As String
    Dim Notifica_Usuario As String
    Dim Notifica_Producto As String
    Dim Notifica_Compuestos As String
    Dim Contador As Integer
    Dim j As Integer

    Dim nvoComp_1 As String
    Dim nvoPorc_1 As String
    Dim nvoCant_1 As String
    Dim nvoComp_2 As String
    Dim nvoPorc_2 As String
    Dim nvoCant_2 As String
    Dim Reprocesado_Gen As String = ""

    Dim ResultActualizaSAP As Boolean

#End Region

#Region "Eventos"
    Private Sub FrmNotMasiva_PT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnNotPeriodo.Enabled = False
        pgbAvance.Visible = False
        DGV.DataSource = Nothing
    End Sub

    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        'Se verifica conexión con SAP
        Label2.Visible = True
        Label2.Text = "Se realiza busqueda de notificaciones en proceso"
        Carga_Grid()
        Label2.Visible = False
    End Sub

    Private Sub DGV_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Status_Not = (DGV.Rows(e.RowIndex).Cells(8).Value)

        If Status_Not = "0" Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub rbPerActualPer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPerActualPer.CheckedChanged
        ' ---------------------------------------------------------------------------------
        'Se verifica conexión con SAP
        Permiso.SAP_Status(Seccion, tsImagen)
        ' ---------------------------------------------------------------------------------
        If rbPerActualPer.Checked Then
            If StatusSap = True Then
                BtnNotPeriodo.Enabled = True
                Label12.Visible = False
                DTPNotiMasiva.Visible = False
            Else
                rbPerActualPer.Checked = False
            End If
        End If
    End Sub

    Private Sub rbNotCierrePer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNotCierrePer.CheckedChanged
        ' ---------------------------------------------------------------------------------
        'Se verifica conexión con SAP
        Permiso.SAP_Status("E", tsImagen)
        ' ---------------------------------------------------------------------------------
        If rbNotCierrePer.Checked Then
            If StatusSap = True Then
                BtnNotPeriodo.Enabled = True
                Label12.Visible = True
                DTPNotiMasiva.Visible = True
            Else
                rbNotCierrePer.Checked = False
            End If
        End If
    End Sub

    Private Sub BtnNotPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotPeriodo.Click
        BtnNotPeriodo.Enabled = False
        BtnConsulta.Enabled = False
        pgbAvance.Visible = True
        Label2.Visible = True
        Label2.Text = ""
        Avance_Notifica.WorkerReportsProgress = True
        Avance_Notifica.RunWorkerAsync()
    End Sub
#End Region

#Region "Metodos"
    Private Sub Carga_Grid()
        Dim FecIni As String
        Dim FecFin As String

        FecIni = DTP1.Value.ToString("yyyy-MM-dd")
        FecFin = DTP2.Value.ToString("yyyy-MM-dd")

        If RB_PT.Checked Then
            Contador = Consulta_Produccion_Extrusion.Prod_Notificar(DGV, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, FecIni, FecFin, Seccion.Trim, TOrden.Text.Trim, TBFolio.Text.Trim, GB_Notifica, Label1)
        End If

        If RB_SC.Checked Then
            Contador = Consulta_Scrap_Extrusion.Prod_Notificar(DGV, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, FecIni, FecFin, Seccion.Trim, TOrden.Text.Trim, TBFolio.Text.Trim, GB_Notifica, Label1)
        End If

    End Sub

    Private Sub Avance_Notifica_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Avance_Notifica.DoWork
        'Variables para la notificacion del WS
        Dim Fecha_SAP As String
        Dim FechaPesajeSAP_CR As String
        'Dim Material As String
        'Dim Peso As String
        Dim Dia As String
        Dim Mes As String
        Dim Ano As String
        Dim Tbl As String()
        Dim Tbl_LM As New Generic.List(Of String)
        Dim SAP_Return As Object
        Dim TipoProd As String
        Dim Tram_Cant As String

        '------------------------------------------------------------------------------------------------------------
        'NOTA IMPORTANTE No alterar el orden del DATA GRID ya que este llena los campos de las cadenas para validar
        'la duplicidad y realiar la notificacion, y los toma en ese orden
        '------------------------------------------------------------------------------------------------------------

        If RB_PT.Checked Then
            TipoProd = "P"
        Else
            TipoProd = "S"
        End If

        For j = 0 To DGV.RowCount - 1
            System.Threading.Thread.Sleep(1000)
            Dim Lista As New Generic.List(Of String)
            Lista.Clear()
            System.Threading.Thread.Sleep(1000)
            Try
                Notifica_ODF = DGV.Rows(j).Cells(0).Value.ToString()
                Notific_Fecha = DGV.Rows(j).Cells(1).Value.ToString()
                Notifica_Producto = DGV.Rows(j).Cells(9).Value.ToString()
                Notifica_Usuario = DGV.Rows(j).Cells(12).Value.ToString()
                Notifica_Compuestos = DGV.Rows(j).Cells(13).Value.ToString()


                Dia = Mid(Notific_Fecha, 9, 2)
                Mes = Mid(Notific_Fecha, 6, 2)
                Ano = Mid(Notific_Fecha, 1, 4)
                If rbPerActualPer.Checked Then
                    Fecha_SAP = Ano & Mes & Dia
                    FechaPesajeSAP_CR = Ano & "-" & Mes & "-" & Dia
                Else
                    Fecha_SAP = DTPNotiMasiva.Value.ToString("yyyyMMdd")
                    FechaPesajeSAP_CR = DTPNotiMasiva.Value.ToString("yyyy-MM-dd")
                End If
                Dim Tramos As String = DGV.Rows(j).Cells(2).Value.ToString()
                Dim Compuesto As String = DGV.Rows(j).Cells(10).Value.ToString()
                Dim P_Neto As String = DGV.Rows(j).Cells(4).Value.ToString()
                Notifica_Folio = DGV.Rows(j).Cells(3).Value.ToString()
                System.Threading.Thread.Sleep(1000)
                QRY = ""
                QRY = "Select notifica "
                If RB_PT.Checked Then
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_PesoProductoTerminado  "
                Else
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_PesoScrap  "
                End If
                QRY = QRY & "Where orden_produccion = '" & Notifica_ODF.Trim & "' "
                QRY = QRY & "And folio = '" & Notifica_Folio.Trim & "' "
                QRY = QRY & "And notifica = '0' "
                LecturaQry(QRY)
                System.Threading.Thread.Sleep(1000)
                'Validar que no se vuelva a notificar un pesaje ya notificado
                If LecturaBD.Read() Then
                    QRY = ""
                    QRY = "Select compuesto1,porcentaje1,cant_1,compuesto2,porcentaje2,cant_2  "
                    If RB_PT.Checked Then
                        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_PesoProductoTerminado  "
                    Else
                        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_PesoScrap  "
                    End If
                    QRY = QRY & "Where orden_produccion = '" & Notifica_ODF.Trim & "' "
                    QRY = QRY & "And folio = '" & Notifica_Folio.Trim & "' "
                    Lista.Clear()
                    LecturaQry(QRY)
                    Do While (LecturaBD.Read)
                        nvoComp_1 = LecturaBD(0)
                        nvoPorc_1 = LecturaBD(1)
                        nvoCant_1 = LecturaBD(2)
                        nvoComp_2 = LecturaBD(3)
                        nvoPorc_2 = LecturaBD(4)
                        nvoCant_2 = LecturaBD(5)
                        Lista.Add(nvoComp_1.Trim + "|" + nvoCant_1)
                        If nvoCant_2 > 0 Then
                            Lista.Add(nvoComp_2.Trim + "|" + nvoCant_2)
                        End If
                    Loop
                    If RB_PT.Checked Then
                        Tram_Cant = Tramos
                    Else
                        Tram_Cant = P_Neto
                        'Identifica si el compuesto es de paros y arranques o normal
                        Reprocesado_Gen = NotificationProcess.Identifica_Reprocesado(nvoComp_1.Trim)
                    End If
                    '------------------------------------------------------------------------------------------------------------
                    'NOTA IMPORTANTE No alterar el orden del DATA GRID ya que este llena los campos de las cadenas para validar
                    'la duplicidad y realiar la notificacion, y los toma en ese orden
                    '------------------------------------------------------------------------------------------------------------
                    'Se arma la cadena del Header de verificacion de duplicados
                    Header_Duplicado = "74" + _
                                        "|" + "CO15" + _
                                        "|" + Notifica_ODF.Trim + _
                                        "|" + Notifica_Usuario.Trim + _
                                        "|" + Notifica_Folio.Trim
                    'Se arma la cadena del Header para el WS de notificación
                    Header_Notifica = "28" + _
                                         "|" + Notifica_ODF.Trim + _
                                         "|" + Tram_Cant + _
                                         "|" + Fecha_SAP + _
                                         "|" + Compuesto.Trim + _
                                         "|" + TipoProd.Trim + _
                                         "|" + Notifica_Usuario.Trim + _
                                         "|" + Notifica_Folio.Trim + _
                                         "|" + Reprocesado_Gen

                    System.Threading.Thread.Sleep(1000)
                    '------Inicio Se ejecuta el WS verificacion duplicados
                    'Variables WS Duplicados
                    Dim Err_dup As String = ""
                    Dim Mns_dup As String = ""
                    Dim Return_dup As Object
                    Dim Tbl_dup As String()
                    WS_P.Consume_WS(SessionUser._sAlias.Trim, Header_Duplicado, Lista, SessionUser._sAmbiente)
                    Tbl_dup = WS_P.Tbl_resultado
                    Return_dup = WS_P.Return_SAP
                    Err_dup = Return_dup.ZTYPE
                    Mns_dup = Return_dup.ZMESSAGE
                    'Si no existe la notificacion regresa Error y se realiza la notificación normal
                    If Err_dup = "E" Then
                        Dim rPlanta As String = SessionUser._sCentro.Trim
                        If rPlanta.Trim <> "CR01" Then

                            '------Inicio Se ejecuta el WS Notificación Producto Terminado Extrusión
                            If RB_PT.Checked Then

                            End If
                            '------Inicio Se ejecuta el WS Notificación Scrap Extrusión
                            If RB_SC.Checked Then
                                NotificacionPTE.CadenaTexto = Notifica_Usuario.Trim & "|" & Notifica_Folio.Trim
                                NotificacionPTE.LTCompuestos = " "
                                NotificacionPTE.FechaPesajeSAP = FechaPesajeSAP_CR
                                NotificacionPTE.Orden = Notifica_ODF.Trim
                                NotificacionPTE.PN = P_Neto
                                ResultActualizaSAP = NotificaExtrusionSAP.SCE
                                Select Case ResultActualizaSAP
                                    Case Is = True
                                        InQry = ""
                                        InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set Notifica = '1', "
                                        InQry = InQry & "notificacionmasiva = '1', "
                                        InQry = InQry & "Documento_SAP = '" & NotificacionPTESAP._Documento.Trim & "', "
                                        InQry = InQry & "Consecutivo_SAP = '" & NotificacionPTESAP.Consecutivo.Trim & "', "
                                        InQry = InQry & "MsgSAP = '" & NotificacionPTESAP.Mensaje.Trim & "' "
                                        InQry = InQry & " Where Folio = '" & Notifica_Folio.Trim & "'"
                                        InsertQry(InQry)
                                        System.Threading.Thread.Sleep(1500)
                                        Avance_Notifica.ReportProgress((j / Contador) * 100)
                                    Case Is = False
                                        InQry = ""
                                        InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set MsgSAP = '" & Mns.Trim & "' "
                                        InQry = InQry & " Where Folio = '" & Notifica_Folio.Trim & "'"
                                        InsertQry(InQry)
                                End Select
                            End If


                            WS_P.Consume_WS(SessionUser._sAlias.Trim, Header_Notifica, Lista, SessionUser._sAmbiente)
                            Tbl = WS_P.Tbl_resultado
                            SAP_Return = WS_P.Return_SAP
                            Err = SAP_Return.ZTYPE
                            Mns = SAP_Return.ZMESSAGE
                            Doc_Con = SAP_Return.zmessage_v1
                            SAP.agregarConsecutivosSAP(Doc_Con)
                            System.Threading.Thread.Sleep(1000)
                            If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                                MessageBox.Show(Mns + " ", "Error en SAP Notifique al Supervisor")
                                System.Threading.Thread.Sleep(1500)
                                InQry = ""
                                If RB_PT.Checked Then
                                    InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set MsgSAP = '" & Mns.Trim & "' "
                                Else
                                    InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set MsgSAP = '" & Mns.Trim & "' "
                                End If
                                InQry = InQry & " Where Folio = '" & Notifica_Folio.Trim & "'"
                                InsertQry(InQry)
                            Else
                                System.Threading.Thread.Sleep(1000)
                                If SAP.DocumentoSAP = "" And SAP.ConsecutivoSAP = "" Or SAP.DocumentoSAP = "0000000000" And SAP.ConsecutivoSAP = "00000000" Then
                                    reg = "0"
                                Else
                                    reg = "1"
                                    InQry = ""
                                    If RB_PT.Checked Then
                                        InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set Notifica = '" & reg.Trim & "', "
                                    Else
                                        InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set Notifica = '" & reg.Trim & "', "
                                    End If
                                    InQry = InQry & "notificacionmasiva = '" & reg.Trim & "', "
                                    InQry = InQry & "Documento_SAP = '" & SAP.DocumentoSAP & "', "
                                    InQry = InQry & "Consecutivo_SAP = '" & SAP.ConsecutivoSAP & "', "
                                    InQry = InQry & "MsgSAP = '" & Mns.Trim & "' "
                                    InQry = InQry & " Where Folio = '" & Notifica_Folio.Trim & "'"
                                    InsertQry(InQry)
                                    System.Threading.Thread.Sleep(1500)
                                    Avance_Notifica.ReportProgress((j / Contador) * 100)
                                End If
                            End If
                            '-----Fin Se ejecuta el WS Notificación 
                        Else
                            If RB_PT.Checked Then
                                '------Inicio Se ejecuta el WS Notificación
                                WS_P.Consume_WS(SessionUser._sAlias.Trim, Header_Notifica, Lista, SessionUser._sAmbiente)
                                Tbl = WS_P.Tbl_resultado
                                SAP_Return = WS_P.Return_SAP
                                Err = SAP_Return.ZTYPE
                                Mns = SAP_Return.ZMESSAGE
                                Doc_Con = SAP_Return.zmessage_v1
                                SAP.agregarConsecutivosSAP(Doc_Con)
                                System.Threading.Thread.Sleep(1000)
                                If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                                    MessageBox.Show(Mns + " ", "Error en SAP Notifique al Supervisor")
                                    System.Threading.Thread.Sleep(1500)
                                    InQry = ""
                                    If RB_PT.Checked Then
                                        InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set MsgSAP = '" & Mns.Trim & "' "
                                    Else
                                        InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set MsgSAP = '" & Mns.Trim & "' "
                                    End If
                                    InQry = InQry & " Where Folio = '" & Notifica_Folio.Trim & "'"
                                    InsertQry(InQry)
                                Else
                                    System.Threading.Thread.Sleep(1000)
                                    If SAP.DocumentoSAP = "" And SAP.ConsecutivoSAP = "" Or SAP.DocumentoSAP = "0000000000" And SAP.ConsecutivoSAP = "00000000" Then
                                        reg = "0"
                                    Else
                                        reg = "1"
                                        InQry = ""
                                        If RB_PT.Checked Then
                                            InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set Notifica = '" & reg.Trim & "', "
                                        Else
                                            InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set Notifica = '" & reg.Trim & "', "
                                        End If
                                        InQry = InQry & "notificacionmasiva = '" & reg.Trim & "', "
                                        InQry = InQry & "Documento_SAP = '" & SAP.DocumentoSAP & "', "
                                        InQry = InQry & "Consecutivo_SAP = '" & SAP.ConsecutivoSAP & "', "
                                        InQry = InQry & "MsgSAP = '" & Mns.Trim & "' "
                                        InQry = InQry & " Where Folio = '" & Notifica_Folio.Trim & "'"
                                        InsertQry(InQry)
                                        System.Threading.Thread.Sleep(1500)
                                        Avance_Notifica.ReportProgress((j / Contador) * 100)
                                    End If
                                End If
                                '------Fin Se ejecuta el WS Notificación 
                            End If

                            If RB_SC.Checked Then
                                '------Inicio Se ejecuta el WS Notificación de Scrap para CR01
                                System.Threading.Thread.Sleep(1000)
                                Dim CadenaTexto As String = ""
                                CadenaTexto = Notifica_Usuario.Trim & "|" & Notifica_Folio.Trim
                                Consume_WS_CR01(SessionUser._sAlias, SessionUser._sAmbiente, CadenaTexto.Trim, Notifica_Compuestos.Trim, FechaPesajeSAP_CR, Notifica_ODF.Trim, P_Neto, Notifica_Folio.Trim)
                                System.Threading.Thread.Sleep(1500)
                                Avance_Notifica.ReportProgress((j / Contador) * 100)
                                '------Fin Se ejecuta el WS Notificación de Scrap para CR01
                            End If
                        End If

                        Select Case SessionUser._sCentro.Trim
                            Case Is <> "CR01"
                                '------Inicio Se ejecuta el WS Notificación
                                WS_P.Consume_WS(SessionUser._sAlias.Trim, Header_Notifica, Lista, SessionUser._sAmbiente)
                                Tbl = WS_P.Tbl_resultado
                                SAP_Return = WS_P.Return_SAP
                                Err = SAP_Return.ZTYPE
                                Mns = SAP_Return.ZMESSAGE
                                Doc_Con = SAP_Return.zmessage_v1
                                SAP.agregarConsecutivosSAP(Doc_Con)
                                System.Threading.Thread.Sleep(1000)
                                If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                                    MessageBox.Show(Mns + " ", "Error en SAP Notifique al Supervisor")
                                    System.Threading.Thread.Sleep(1500)
                                    InQry = ""
                                    If RB_PT.Checked Then
                                        InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set MsgSAP = '" & Mns.Trim & "' "
                                    Else
                                        InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set MsgSAP = '" & Mns.Trim & "' "
                                    End If
                                    InQry = InQry & " Where Folio = '" & Notifica_Folio.Trim & "'"
                                    InsertQry(InQry)
                                Else
                                    System.Threading.Thread.Sleep(1000)
                                    If SAP.DocumentoSAP = "" And SAP.ConsecutivoSAP = "" Or SAP.DocumentoSAP = "0000000000" And SAP.ConsecutivoSAP = "00000000" Then
                                        reg = "0"
                                    Else
                                        reg = "1"
                                        InQry = ""
                                        If RB_PT.Checked Then
                                            InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set Notifica = '" & reg.Trim & "', "
                                        Else
                                            InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set Notifica = '" & reg.Trim & "', "
                                        End If
                                        InQry = InQry & "notificacionmasiva = '" & reg.Trim & "', "
                                        InQry = InQry & "Documento_SAP = '" & SAP.DocumentoSAP & "', "
                                        InQry = InQry & "Consecutivo_SAP = '" & SAP.ConsecutivoSAP & "', "
                                        InQry = InQry & "MsgSAP = '" & Mns.Trim & "' "
                                        InQry = InQry & " Where Folio = '" & Notifica_Folio.Trim & "'"
                                        InsertQry(InQry)
                                        System.Threading.Thread.Sleep(1500)
                                        Avance_Notifica.ReportProgress((j / Contador) * 100)
                                    End If
                                End If
                                '------Fin Se ejecuta el WS Notificación 
                            Case Is = "CR01"

                                If RB_PT.Checked Then
                                    '------Inicio Se ejecuta el WS Notificación
                                    WS_P.Consume_WS(SessionUser._sAlias.Trim, Header_Notifica, Lista, SessionUser._sAmbiente)
                                    Tbl = WS_P.Tbl_resultado
                                    SAP_Return = WS_P.Return_SAP
                                    Err = SAP_Return.ZTYPE
                                    Mns = SAP_Return.ZMESSAGE
                                    Doc_Con = SAP_Return.zmessage_v1
                                    SAP.agregarConsecutivosSAP(Doc_Con)
                                    System.Threading.Thread.Sleep(1000)
                                    If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                                        MessageBox.Show(Mns + " ", "Error en SAP Notifique al Supervisor")
                                        System.Threading.Thread.Sleep(1500)
                                        InQry = ""
                                        If RB_PT.Checked Then
                                            InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set MsgSAP = '" & Mns.Trim & "' "
                                        Else
                                            InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set MsgSAP = '" & Mns.Trim & "' "
                                        End If
                                        InQry = InQry & " Where Folio = '" & Notifica_Folio.Trim & "'"
                                        InsertQry(InQry)
                                    Else
                                        System.Threading.Thread.Sleep(1000)
                                        If SAP.DocumentoSAP = "" And SAP.ConsecutivoSAP = "" Or SAP.DocumentoSAP = "0000000000" And SAP.ConsecutivoSAP = "00000000" Then
                                            reg = "0"
                                        Else
                                            reg = "1"
                                            InQry = ""
                                            If RB_PT.Checked Then
                                                InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set Notifica = '" & reg.Trim & "', "
                                            Else
                                                InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set Notifica = '" & reg.Trim & "', "
                                            End If
                                            InQry = InQry & "notificacionmasiva = '" & reg.Trim & "', "
                                            InQry = InQry & "Documento_SAP = '" & SAP.DocumentoSAP & "', "
                                            InQry = InQry & "Consecutivo_SAP = '" & SAP.ConsecutivoSAP & "', "
                                            InQry = InQry & "MsgSAP = '" & Mns.Trim & "' "
                                            InQry = InQry & " Where Folio = '" & Notifica_Folio.Trim & "'"
                                            InsertQry(InQry)
                                            System.Threading.Thread.Sleep(1500)
                                            Avance_Notifica.ReportProgress((j / Contador) * 100)
                                        End If
                                    End If
                                    '------Fin Se ejecuta el WS Notificación 
                                End If

                                If RB_SC.Checked Then
                                    '------Inicio Se ejecuta el WS Notificación de Scrap para CR01
                                    System.Threading.Thread.Sleep(1000)
                                    Dim CadenaTexto As String = ""
                                    CadenaTexto = Notifica_Usuario.Trim & "|" & Notifica_Folio.Trim
                                    Consume_WS_CR01(SessionUser._sAlias, SessionUser._sAmbiente, CadenaTexto.Trim, Notifica_Compuestos.Trim, FechaPesajeSAP_CR, Notifica_ODF.Trim, P_Neto, Notifica_Folio.Trim)
                                    System.Threading.Thread.Sleep(1500)
                                    Avance_Notifica.ReportProgress((j / Contador) * 100)
                                    '------Fin Se ejecuta el WS Notificación de Scrap para CR01
                                End If
                        End Select

                    End If
                    'Si fue notificado se actualiza el registro
                    If Err_dup = "S" Then
                        System.Threading.Thread.Sleep(1000)
                        Doc_Con_dup = Tbl_dup(0)
                        SAP_dup.agregarConsecutivosSAP(Doc_Con_dup)
                        reg = "1"
                        InQry = ""
                        If RB_PT.Checked Then
                            InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set Notifica = '" & reg.Trim & "', "
                        Else
                            InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set Notifica = '" & reg.Trim & "', "
                        End If
                        InQry = InQry & "notificacionmasiva = '" & reg.Trim & "', "
                        InQry = InQry & "Documento_SAP = '" & SAP_dup.DocumentoSAP & "', "
                        InQry = InQry & "Consecutivo_SAP = '" & SAP_dup.ConsecutivoSAP & "' "
                        InQry = InQry & " Where Folio = '" & Notifica_Folio.Trim & "'"
                        InsertQry(InQry)
                        System.Threading.Thread.Sleep(1500)
                        Avance_Notifica.ReportProgress((j / Contador) * 100)
                        '------Fin Se ejecuta el WS verificacion duplicados
                    End If
                    End If
            Catch ex As Exception
                MessageBox.Show("Error :" & ex.Message, " VENTANA DE ERROR * * * ")
            End Try
        Next
    End Sub

    Private Sub Avance_Notifica_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles Avance_Notifica.ProgressChanged
        Label2.Text = "Notificando Orden '" & Notifica_ODF.Trim & "' Folio: '" & Notifica_Folio.Trim & "'"
        DGV.Refresh()
        Label4.Text = j
        pgbAvance.Value = e.ProgressPercentage
    End Sub

    Private Sub Avance_Notifica_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Avance_Notifica.RunWorkerCompleted
        MessageBox.Show("A terminado la notificación de las ordenes")
        Carga_Grid()
        pgbAvance.Visible = False
        Label2.Visible = False
        Label2.Text = ""
        BtnNotPeriodo.Enabled = True
        BtnConsulta.Enabled = True
        pgbAvance.Increment(0)
        pgbAvance.Refresh()
        Me.Refresh()
        DGV.Refresh()
    End Sub

    Private Sub Consume_WS_CR01(ByVal Usr_Atlas As String, ID As String, CadenaTexto As String, Lt_Compuestos As String, _
                                  FechaPesajeSAP As String, Orden As String, PesoNeto As String, folio As String)

        Dim Err As String
        Dim Mns As String
        Dim reg As String = ""
        Dim Cod_Err As String = ""

        If ID.Trim = "D" Then
            'Variables Desarrollo
            Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
            Dim ls_returnr As New PTConsumos.ZBAPIRET2
            Dim ls_Notifica As New PTConsumos.ZEPP002
            Dim ls_result As New PTConsumos._ISDFPS_TCUPS_KEY
            Dim TNumNoti As String = ""
            Dim TConsNoti As String = ""
            Try
                ls_Notifica.ZBUDAT = FechaPesajeSAP.Trim
                ls_Notifica.ZCONSUME_REC = 0
                ls_Notifica.ZENTRY_QNT = 0
                ls_Notifica.ZISM01 = 0
                ls_Notifica.ZISM02 = 0
                ls_Notifica.ZISM03 = 0
                ls_Notifica.ZISMNGEH1 = ""
                ls_Notifica.ZISMNGEH2 = ""
                ls_Notifica.ZISMNGEH3 = ""
                ls_Notifica.ZMATNR_REC = ""
                ls_Notifica.ZMATNR_REC = ""
                ls_Notifica.ZORDERID = Orden.Trim
                ls_Notifica.ZRECOVERED = PesoNeto
                ls_Notifica.ZVIRGIN = 0
                lo_wsamancomxr.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3m4tl4s")
                ls_result = lo_wsamancomxr.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notifica, ls_returnr)
                TNumNoti = ls_result.RUECK
                TConsNoti = ls_result.RMZHL
                Err = ls_returnr.ZTYPE
                Mns = ls_returnr.ZMESSAGE
            Catch ex As Exception
                MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
            End Try
        ElseIf ID.Trim = "P" Then
            'Variables Productivo
            Dim lo_wsamancomxp As New PTConProd.ZPPMXF001Service
            Dim ls_returnp As New PTConProd.ZBAPIRET2
            Dim ls_Notificap As New PTConProd.ZEPP002
            Dim ls_resultp As New PTConProd._ISDFPS_TCUPS_KEY
            Dim TNumNoti As String = ""
            Dim TConsNoti As String = ""
            Try
                ls_Notificap.ZBUDAT = FechaPesajeSAP.Trim
                ls_Notificap.ZCONSUME_REC = 0.0
                ls_Notificap.ZENTRY_QNT = 0
                ls_Notificap.ZISM01 = 0.0
                ls_Notificap.ZISM02 = 0.0
                ls_Notificap.ZISM03 = 0.0
                ls_Notificap.ZISMNGEH1 = ""
                ls_Notificap.ZISMNGEH2 = ""
                ls_Notificap.ZISMNGEH3 = ""
                ls_Notificap.ZMATNR_REC = ""
                ls_Notificap.ZORDERID = Orden.Trim
                ls_Notificap.ZRECOVERED = PesoNeto
                ls_Notificap.ZVIRGIN = 0.0
                'lo_wsamancomxp.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3m4tl4s")
                ls_resultp = lo_wsamancomxp.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notificap, ls_returnp)
                TNumNoti = ls_resultp.RUECK
                TConsNoti = ls_resultp.RMZHL
                Err = ls_returnp.ZTYPE
                Mns = ls_returnp.ZMESSAGE

                If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                    reg = "0"
                    MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
                    InQry = ""
                    InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set MsgSAP = '" & Mns.Trim & "' "
                    InQry = InQry & " Where Folio = '" & folio.Trim & "'"
                    InsertQry(InQry)
                    Exit Sub
                Else
                    If (TNumNoti = "" Or TNumNoti = "NULL" Or TNumNoti = "0000000000") And (TConsNoti = "" Or TConsNoti = "NULL" Or TConsNoti = "00000000") Then
                        reg = "0"
                        MsgBox("No Notifico a SAP")
                        Return
                    Else
                        reg = "1"
                        LecturaQry("PA_Update_Not_Masiva_Scrap " & SessionUser._sCentro.Trim & "_PesoScrap, '" & TNumNoti & "', '" & TConsNoti & "', '" & reg & "', '" & reg & "', '" & Mns & "',  '" & folio & "' ")
                    End If
                End If
            Catch ex As Exception
                MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
            End Try
        End If
    End Sub

#End Region



End Class
