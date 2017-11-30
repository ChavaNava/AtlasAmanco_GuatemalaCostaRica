Imports Atlas.Accesos
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Imports Utili_Generales
Imports System.Windows.Forms
Imports System.Drawing


Public Class FrmProduccionProceso
#Region "Variables"
    Dim Conexion_SAP As String
    Dim Lista As New Generic.List(Of String)
    Dim Status_Not As String
    Dim Reprocesado_Gen As String
#End Region

#Region "Eventos"
    Private Sub FrmProduccionProceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP_FI.Value = DateSerial(Now.Date.Year, Now.Month, 1)
        DTP_FF.Value = DateSerial(Now.Year, Now.Month + 1, 0)
        ConfigLoad()
        Load_Grid()
    End Sub
    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Load_Grid()
    End Sub
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Close()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        abcProduccionProceso.IdFolioProceso = dgvProduccionProceso._IdFolioProceso
        MensajeBox.Mostrar("El registro con folio " & dgvProduccionProceso._IdFolioProceso & " se dara de baja ", "Baja", MensajeBox.TipoMensaje.Information, MensajeBox.TipoBoton.OkCancel)
        Select Case MensajeBox.Respuesta()
            Case Is = False

            Case Is = True
                Try
                    OperacionProduccionProceso.ABC(3)
                    MensajeBox.Mostrar("Se realizo la baja de forma correcta ", "Baja", MensajeBox.TipoMensaje.Good)
                    Load_Grid()
                Catch ex As Exception
                    MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                End Try
        End Select

    End Sub

    Private Sub btnNotificar_Click(sender As Object, e As EventArgs) Handles btnNotificar.Click
        If rbProduccion.Checked Then
            NotificaPT()
        End If

        If rbScrap.Checked Then
            NotificaSC()
        End If
    End Sub

    Private Sub rbProduccion_CheckedChanged(sender As Object, e As EventArgs) Handles rbProduccion.CheckedChanged
        Select Case rbProduccion.Checked
            Case Is = True
                txtUnidadesFinales.Enabled = True
                cmbCausa.DataSource = Nothing
                cmbDefecto.DataSource = Nothing
                cmbCausa.Enabled = False
                cmbDefecto.Enabled = False
                btnNotificar.Enabled = True
        End Select
    End Sub

    Private Sub rbScrap_CheckedChanged(sender As Object, e As EventArgs) Handles rbScrap.CheckedChanged
        Select Case rbScrap.Checked
            Case Is = True
                ComboCausas.CodigoCausa = ""
                ComboCausas.Area = "E"
                ComboCausas.TipoCausa = ""
                btnNotificar.Enabled = True
                txtUnidadesFinales.Enabled = True
                cmbCausa.DataSource = Nothing
                cmbDefecto.DataSource = Nothing
                cmbCausa.Enabled = True
                cmbDefecto.Enabled = True
                OperacionProduccionProceso.CB_Causa(cmbCausa)
        End Select
    End Sub
    Private Sub txtUnidadesFinales_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(OperacionProduccionProceso.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtUnidadesFinales_TextChanged(sender As Object, e As EventArgs) Handles txtUnidadesFinales.TextChanged
        If Val(txtUnidadesFinales.Text) >= 0 And dgvProduccionProceso.PesoUnitario > 0 Then
            txtUnidades.Text = (dgvProduccionProceso._Unidades - txtUnidadesFinales.Text)
            txtPesoBruto.Text = Format(((txtUnidades.Text * dgvProduccionProceso.PesoUnitario) + txtPesoTara.Text), "###0.00")
            txtPesoFinal.Text = Format((txtUnidadesFinales.Text * dgvProduccionProceso.PesoUnitario), "###00.00")
            txtPesoNeto.Text = Format((dgvProduccionProceso.PesoNeto - (txtUnidadesFinales.Text * dgvProduccionProceso.PesoUnitario)), "###00.00")
            txtPorFinal.Text = Format((((dgvProduccionProceso._Unidades - txtUnidadesFinales.Text) * (dgvProduccionProceso.PesoNeto - (txtUnidadesFinales.Text * dgvProduccionProceso.PesoUnitario))) / dgvProduccionProceso._Unidades), "###00.00")
        End If
    End Sub
    Private Sub txtPesoFinal_TextChanged(sender As Object, e As EventArgs)
        If Val(txtUnidadesFinales.Text.Length) > 0 Or txtUnidadesFinales.Text.Trim = "" Then

        End If
    End Sub
    Private Sub cmbCausa_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles cmbCausa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            Defectos()
        End If
    End Sub
    Private Sub chbSAP_CheckedChanged(sender As Object, e As EventArgs) Handles chbSAP.CheckedChanged
        If chbSAP.Checked = True Then
            dtpFechaSAP.Enabled = False
        Else
            dtpFechaSAP.Enabled = True
        End If
    End Sub
    Private Sub dgvNuevos_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvNuevos.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = dgvNuevos.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Try
                Dim Fila_Seleccionada As Integer = dgvNuevos.CurrentCell.RowIndex
                dgvProduccionProceso.IdFolioProceso = dgvNuevos.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                dgvProduccionProceso.FechaPesaje = dgvNuevos.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                dgvProduccionProceso.HoraPesaje = dgvNuevos.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                dgvProduccionProceso.Centro = dgvNuevos.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                dgvProduccionProceso.OrdenProduccion = dgvNuevos.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                dgvProduccionProceso.IdProducto = dgvNuevos.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                dgvProduccionProceso.Producto = dgvNuevos.Rows(Fila_Seleccionada).Cells(6).Value.ToString
                dgvProduccionProceso.IdBascula = dgvNuevos.Rows(Fila_Seleccionada).Cells(7).Value.ToString
                dgvProduccionProceso.IdRack = dgvNuevos.Rows(Fila_Seleccionada).Cells(8).Value.ToString
                dgvProduccionProceso.PesoBruto = dgvNuevos.Rows(Fila_Seleccionada).Cells(9).Value.ToString
                dgvProduccionProceso.PesoTara = dgvNuevos.Rows(Fila_Seleccionada).Cells(10).Value.ToString
                dgvProduccionProceso.PesoNeto = dgvNuevos.Rows(Fila_Seleccionada).Cells(11).Value.ToString
                dgvProduccionProceso.Empaques = dgvNuevos.Rows(Fila_Seleccionada).Cells(12).Value.ToString
                dgvProduccionProceso.Unidades = dgvNuevos.Rows(Fila_Seleccionada).Cells(13).Value.ToString
                dgvProduccionProceso.UsuarioRegistraProceso = dgvNuevos.Rows(Fila_Seleccionada).Cells(14).Value.ToString
                dgvProduccionProceso.IdTurno = dgvNuevos.Rows(Fila_Seleccionada).Cells(15).Value.ToString
                dgvProduccionProceso.IdPuestoTrabajo = dgvNuevos.Rows(Fila_Seleccionada).Cells(16).Value.ToString
                dgvProduccionProceso.IdFolioPesaje = dgvNuevos.Rows(Fila_Seleccionada).Cells(17).Value.ToString
                dgvProduccionProceso.Estatus = dgvNuevos.Rows(Fila_Seleccionada).Cells(18).Value.ToString
                dgvProduccionProceso.PesoUnitario = dgvNuevos.Rows(Fila_Seleccionada).Cells(19).Value.ToString
                dgvProduccionProceso.PesoTeorico = dgvNuevos.Rows(Fila_Seleccionada).Cells(20).Value.ToString
                dgvProduccionProceso.Comp1 = dgvNuevos.Rows(Fila_Seleccionada).Cells(21).Value.ToString
                dgvProduccionProceso.Porc1 = dgvNuevos.Rows(Fila_Seleccionada).Cells(22).Value.ToString
                dgvProduccionProceso.Cant1 = dgvNuevos.Rows(Fila_Seleccionada).Cells(23).Value.ToString
                dgvProduccionProceso.Comp2 = dgvNuevos.Rows(Fila_Seleccionada).Cells(24).Value.ToString
                dgvProduccionProceso.Porc2 = dgvNuevos.Rows(Fila_Seleccionada).Cells(25).Value.ToString
                dgvProduccionProceso.Cant2 = dgvNuevos.Rows(Fila_Seleccionada).Cells(26).Value.ToString
                ConsultaProduccionProceso.IdFolioProceso = dgvProduccionProceso._IdFolioProceso
                OperacionProduccionProceso.ConsultaDetalleSeparada(dgvDetalle)
                EstatusBotones(dgvProduccionProceso._IdEstatus)
                Cleandgv()
            Catch ex As Exception
                MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub dgvNuevos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvNuevos.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = dgvNuevos.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            OperacionProduccionProceso.FomatingProduccionProceso(dgvNuevos, 18, e)
        End If
    End Sub

    Private Sub dgvDetalle_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDetalle.CellFormatting
        Status_Not = (dgvDetalle.Rows(e.RowIndex).Cells(20).Value)

        If Status_Not = "1" Then
            e.CellStyle.BackColor = Color.LightGreen
            e.CellStyle.ForeColor = Color.Black
        ElseIf Status_Not = "0" Or Status_Not = "4" Or Status_Not = "3" Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Black
        ElseIf Status_Not = "9" Then
            e.CellStyle.BackColor = Color.Red
            e.CellStyle.ForeColor = Color.White
        End If
    End Sub
    Private Sub dgvNuevos_DoubleClick(sender As Object, e As EventArgs) Handles dgvNuevos.DoubleClick
        Filldgv()
    End Sub
#End Region

#Region "Metodos"
    Private Sub Load_Grid()
        LoadingForm.ShowLoading()

        DTP_FI.Value = DateSerial(Now.Date.Year, Now.Month, 1)
        dgvNuevos.Columns.Clear()
        dgvNuevos.Refresh()
        dgvNuevos.DataSource = Nothing

        dgvDetalle.Columns.Clear()
        dgvDetalle.Refresh()
        dgvDetalle.DataSource = Nothing

        If cmbEstatus.SelectedValue = Nothing Then
            ConsultaProduccionProceso.Estatus = ""
        Else
            ConsultaProduccionProceso.Estatus = cmbEstatus.SelectedValue
        End If

        If txtOrdenProduccion.Text.Trim = "" Then
            ConsultaProduccionProceso.Orden = ""
        Else
            ConsultaProduccionProceso.Orden = txtOrdenProduccion.Text.Trim
        End If

        ConsultaProduccionProceso.Area = "E"
        ConsultaProduccionProceso.FI = DTP_FI.Value.ToString("yyyyMMdd")
        ConsultaProduccionProceso.FF = DTP_FF.Value.ToString("yyyyMMdd")
        Try
            OperacionProduccionProceso.Consulta(dgvNuevos)
            LoadingForm.CloseForm()
        Catch ex As Exception
            LoadingForm.CloseForm()
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
        End Try


    End Sub
    Private Sub EstatusBotones(ByVal IdEstatus As Integer)
        Select Case IdEstatus
            Case Is = 1
                btnNotificar.Enabled = True
                btnCancel.Enabled = True
                gbOrden.Enabled = True
            Case Is = 2
                btnNotificar.Enabled = True
                btnCancel.Enabled = True
                gbOrden.Enabled = True
            Case Is = 3
                btnNotificar.Enabled = True
                btnCancel.Enabled = False
                gbOrden.Enabled = False
            Case Is = 4
                btnNotificar.Enabled = False
                btnCancel.Enabled = False
                gbOrden.Enabled = False
        End Select
    End Sub

    Private Sub Filldgv()
        txtOrdenProduccion.Text = dgvProduccionProceso._OrdenProduccion
        txtIdProducto.Text = dgvProduccionProceso._IdProducto
        txtProducto.Text = dgvProduccionProceso._Producto
        txtUnidades.Text = dgvProduccionProceso._Unidades
        txtPesoNeto.Text = dgvProduccionProceso._PesoNeto
        txtPesoTara.Text = dgvProduccionProceso._PesoTara
        txtPesoBruto.Text = dgvProduccionProceso._PesoBruto
        txtFolio.Text = dgvProduccionProceso._IdFolioProceso
    End Sub
    Private Sub Cleandgv()
        txtUnidadesFinales.Text = "0"
        txtUnidadesFinales.Enabled = False
        txtPesoFinal.Text = "0"
        txtPorFinal.Text = "0"
        cmbCausa.DataSource = Nothing
        cmbDefecto.DataSource = Nothing
        cmbCausa.Enabled = False
        cmbDefecto.Enabled = False
        rbProduccion.Checked = False
        rbScrap.Checked = False
        txtOrdenProduccion.Text = ""
        txtIdProducto.Text = ""
        txtProducto.Text = ""
        txtUnidades.Text = ""
        txtPesoNeto.Text = ""
        txtPesoTara.Text = ""
        txtPesoBruto.Text = ""
        txtFolio.Text = ""
        btnNotificar.Enabled = False
        txtFolioAtlas.Text = ""
        txtDocSAP.Text = ""
        txtConSAP.Text = ""
    End Sub

    Private Sub ConfigLoad()
        txtUnidadesFinales.Enabled = False
        txtUnidadesFinales.Enabled = False
        cmbCausa.DataSource = Nothing
        cmbDefecto.DataSource = Nothing
        cmbCausa.Enabled = False
        cmbDefecto.Enabled = False
        'Se asigna turno que corresponde acorde al horario
        Dim HReal As String = DateTime.Now.ToString("HH:mm:ss")
        Catalogo_Turnos.Combo_Turnos(cmbTurnos)
        Catalogo_Turnos.Asigna_turno(cmbTurnos, HReal)
        OperacionProduccionProceso.CB_Estatus(cmbEstatus)
        cmbEstatus.SelectedIndex = -1
    End Sub

    Private Sub Defectos()
        If cmbCausa.Text = "" Then
            MensajeBox.Mostrar("Seleccione una causa", "Causas", MensajeBox.TipoMensaje.Information)
            cmbCausa.Focus()
            Return
        Else
            ComboDefectos.CodigoCausa = cmbCausa.SelectedValue
            OperacionProduccionProceso.CB_Defectos(cmbDefecto)
        End If

    End Sub

    Private Sub NotificaPT()
        Dim PBO As Decimal = txtPesoBruto.Text
        Dim PTO As Decimal = txtPesoTara.Text
        Dim PNO As Decimal = txtPesoNeto.Text
        Dim PNF As Decimal = txtPesoFinal.Text

        Conexion_SAP = SAP_Conexion.Estatus(Seccion)

        NPTExtrusion.iFolioProduccionProceso = dgvProduccionProceso._IdFolioProceso
        NPTExtrusion.iOrdenProduccion = txtOrdenProduccion.Text.Trim
        NPTExtrusion.iUsuario = SessionUser._sAlias
        NPTExtrusion.iTramos = txtUnidadesFinales.Text.Trim
        NPTExtrusion.iIdRack = dgvProduccionProceso.IdRack.Trim
        NPTExtrusion.iPB = PNF + PTO
        NPTExtrusion.iPT = PTO
        NPTExtrusion.iPN = Format((NPTExtrusion._iPB - NPTExtrusion._iPT), "###0.0")
        NPTExtrusion.iIdBascula = ValCodigoBascula
        NPTExtrusion.iPuestoTrabajo = dgvProduccionProceso._IdPuestoTrabajo
        NPTExtrusion.iEstatusSobrePeso = "0"
        NPTExtrusion.iEmpaques = "0"
        NPTExtrusion.iFechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        NPTExtrusion.iHoraPesaje = Date.Now.TimeOfDay.ToString()
        NPTExtrusion.iTurno = cmbTurnos.Text.Trim
        NPTExtrusion.iPesoTeorico = dgvProduccionProceso._PesoTeorico
        NPTExtrusion.iIdOperadorPtoTra = "N/A"
        NPTExtrusion.iFechaTurno = dtpFecha.Value.ToString("yyyy-MM-dd")
        NPTExtrusion.iSobrePeso = 0.0
        NPTExtrusion.iFechaPesajeSAP = dtpFechaSAP.Value.ToString("yyyyMMdd")
        NPTExtrusion.iTipoPT = "R"
        NPTExtrusion.iArea = "E"
        NPTExtrusion.iFolioPesaje = dgvProduccionProceso._IdFolioPesaje
        NPTExtrusion.iVersion = Atlas_Version.Version
        NPTExtrusion.iSupervisor = "Supervisor"
        NPTExtrusion.iComp1 = dgvProduccionProceso._Comp1.Trim
        NPTExtrusion.iPorc1 = dgvProduccionProceso.Porc1.Trim
        NPTExtrusion.iCant1 = NPTExtrusion._iPN
        NPTExtrusion.iComp2 = "0"
        NPTExtrusion.iPorc2 = "0"
        NPTExtrusion.iCant2 = "0"
        'Información para actualiza pesaje en proceso original
        NPTExtrusion.iPBR = txtPesoBruto.Text
        NPTExtrusion.iPTR = txtPesoTara.Text
        NPTExtrusion.iPNR = txtPesoNeto.Text
        NPTExtrusion.iTramosR = txtUnidades.Text
        'Inserta regisrto pesaje recuperado
        Try
            LoadingForm.ShowLoading()
            FolioNotifica.rIdFolio = OperacionProduccionProceso.NotificaProduccion
            OperacionProduccionProceso.ActualizaNotificacionRecuperadaPT()
            If NPTExtrusion._iTramosR = 0 Then
                NPTExtrusion.iEstatusProceso = "3"
            Else
                NPTExtrusion.iEstatusProceso = "2"
            End If
            OperacionProduccionProceso.ActualizaEnProceso()
        Catch ex As Exception
            LoadingForm.CloseForm()
            MensajeBox.Mostrar(ex.Message, "Error Intente Nuevamente", MensajeBox.TipoMensaje.Critical)
            Return
        End Try
        'Identificar Compuesto original de la bom ------------------------------------------------
        Dim IdComEstatus As Boolean
        IdComEstatus = OperacionProduccionProceso.Compuesto_Bom(dgvProduccionProceso._IdProducto)
        If IdComEstatus = False Then
            MsgBox("Este producto no tiene asignado compuesto virgen para su consumo", MsgBoxStyle.Critical)
            Return
        End If
        'Se asigna valor a variables de consumo compuestos 1, 2 -----------------------------------
        Lista.Clear()

        If NPTExtrusion.iComp1.Trim <> 0 Then
            Lista.Add(Util.QuitarCerosIzquierda(NPTExtrusion._iComp1.Trim) + "|" + NPTExtrusion._iCant1.Trim)
        End If

        If NPTExtrusion.iComp2.Trim <> 0 Then
            Lista.Add(Util.QuitarCerosIzquierda(NPTExtrusion._iComp2.Trim) + "|" + NPTExtrusion._iCant2.Trim)
        End If
        'Se verifica status de conexión y se determina si se envia a SAP o no --------------------
        Select Case Conexion_SAP
            Case "False"
                LoadingForm.CloseForm()
                MsgBox(" No se realizara notificación a SAP se encuntra deshabilitada la conexión ")
            Case "True"
                'Se arma la cadena del Header de verificacion de duplicados
                Header_Duplicado = "74" + _
                                "|" + "CO15" + _
                                "|" + txtOrdenProduccion.Text.Trim + _
                                "|" + SessionUser._sAlias.Trim + _
                                "|" + FolioNotifica._rIdFolio.Trim
                'Variables WS Duplicados
                Dim Err_dup As String = ""
                Dim Mns_dup As String = ""
                Dim Return_dup As Object
                Dim Tbl_dup As String()
                WS_P.Consume_WS(Header_Duplicado, Lista, SessionUser._sAmbiente)
                Tbl_dup = WS_P.Tbl_resultado
                Return_dup = WS_P.Return_SAP
                Err_dup = Return_dup.ZTYPE
                Mns_dup = Return_dup.ZMESSAGE

                Select Case Err_dup
                    '------Si no existe la notificacion regresa Error y se realiza la notificación normal
                    Case Is = "E"
                        'Lectura de WS Generico para realizar la notificación ------------------------------------
                        Dim Head As String
                        Head = "28|" + txtOrdenProduccion.Text.Trim + "|" + NPTExtrusion._iTramos.ToString + "|" + NPTExtrusion._iFechaPesajeSAP.Trim + "|" + Compuestos._IdCompuestoBOM.Trim + "|" + "P" + "|" + SessionUser._sAlias.Trim + "|" + FolioNotifica._rIdFolio.Trim
                        Notifica_SAP(Head, Lista, FolioNotifica._rIdFolio.Trim, SessionUser._sAlias)
                        Load_Grid()
                    Case Else
                        '------Si fue notificado se actualiza el registro
                        Dim Doc_Con_dup As String = ""
                        Doc_Con_dup = Tbl_dup(0)
                        Generic_SAP.agregarConsecutivosSAP(Doc_Con_dup)

                        NPTExtrusion.iOrdenProduccion = dgvProduccionProceso._OrdenProduccion.Trim
                        NPTExtrusion.iFolioPesaje = dgvProduccionProceso._IdFolioPesaje
                        NPTExtrusion.iIdReg = 1
                        NPTExtrusion.iDocSAP = Generic_SAP.DocumentoSAP
                        NPTExtrusion.iNumSAP = Generic_SAP.ConsecutivoSAP

                        OperacionProduccionProceso.NotificacionExitosaPT()
                        Load_Grid()
                End Select
                '------Fin Se ejecuta el WS verificacion duplicados
        End Select

        LoadingForm.CloseForm()
    End Sub

    Private Sub Notifica_SAP(ByVal strHead As String, List As Generic.List(Of String), strFolio As String, UsrOperador As String)
        Dim Tbl As String()
        Dim Tbl_LM As New Generic.List(Of String)
        Dim SAP_Return As Object
        Dim Doc_Con As String
        Dim Cod_Err As String = ""
        Dim reg As String

        Try
            WS_P.Consume_WS(strHead, List, SessionUser._sAmbiente)
            Tbl = WS_P.Tbl_resultado
            SAP_Return = WS_P.Return_SAP
            Err = SAP_Return.ZTYPE
            Mns = SAP_Return.ZMESSAGE
            Doc_Con = SAP_Return.zmessage_v1

            Generic_SAP.agregarConsecutivosSAP(Doc_Con)

            If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                LoadingForm.CloseForm()
                reg = "0"
                MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
                Try
                    NPTExtrusion.iOrdenProduccion = dgvProduccionProceso._OrdenProduccion.Trim
                    NPTExtrusion.iFolioPesaje = FolioNotifica._rIdFolio
                    OperacionProduccionProceso.NotificacionFallidaPT()
                    LoadingForm.CloseForm()
                Catch ex As Exception
                    LoadingForm.CloseForm()
                    MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                End Try
            Else
                If (Generic_SAP.DocumentoSAP = "" Or Generic_SAP.DocumentoSAP = "NULL" Or Generic_SAP.DocumentoSAP = "0000000000") And (Generic_SAP.ConsecutivoSAP = "" Or Generic_SAP.ConsecutivoSAP = "NULL" Or Generic_SAP.ConsecutivoSAP = "00000000") Then
                    reg = "0"
                    LoadingForm.CloseForm()
                    MsgBox("No Notifico a SAP")
                    Return
                Else
                    reg = "1"
                    txtFolioAtlas.Text = FolioNotifica._rIdFolio
                    txtDocSAP.Text = Generic_SAP.DocumentoSAP
                    txtConSAP.Text = Generic_SAP.ConsecutivoSAP
                    Cnn.LecturaQry("PA_Actualiza_Notificacion_Produccion " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, '" & Generic_SAP.DocumentoSAP & "', '" & Generic_SAP.ConsecutivoSAP & "', '" & reg & "', '" & Mns & "', '" & FolioNotifica._rIdFolio & "' ")
                    LoadingForm.CloseForm()
                    MensajeBox.Mostrar("La notificación de la Orden '" & dgvProduccionProceso._OrdenProduccion.Trim & "' a sido Exitosa ", "Notificación Exitosa", MensajeBox.TipoMensaje.Good)
                End If
            End If
        Catch ex As Exception
            LoadingForm.CloseForm()
            MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
        End Try
    End Sub
    Private Sub NotificaSC()
        Dim PBO As Decimal = txtPesoBruto.Text
        Dim PTO As Decimal = txtPesoTara.Text
        Dim PNO As Decimal = txtPesoNeto.Text
        Dim PNF As Decimal = txtPesoFinal.Text

        Conexion_SAP = SAP_Conexion.Estatus(Seccion)

        'Se asigna valor a variables -------------------------------------------------------------
        NPTExtrusion.iFolioProduccionProceso = dgvProduccionProceso._IdFolioProceso
        NPTExtrusion.iOrdenProduccion = txtOrdenProduccion.Text.Trim
        NPTExtrusion.iUsuario = SessionUser._sAlias
        NPTExtrusion.iTramos = txtUnidadesFinales.Text.Trim
        NPTExtrusion.iIdRack = dgvProduccionProceso.IdRack.Trim
        NPTExtrusion.iPB = PNF + PTO
        NPTExtrusion.iPT = PTO
        NPTExtrusion.iPN = Format((NPTExtrusion._iPB - NPTExtrusion._iPT), "###0.0")
        NPTExtrusion.iIdBascula = ValCodigoBascula
        NPTExtrusion.iPuestoTrabajo = dgvProduccionProceso._IdPuestoTrabajo
        NPTExtrusion.iEstatusSobrePeso = "0"
        NPTExtrusion.iEmpaques = "0"
        NPTExtrusion.iFechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        NPTExtrusion.iHoraPesaje = Date.Now.TimeOfDay.ToString()
        NPTExtrusion.iTurno = cmbTurnos.Text.Trim
        NPTExtrusion.iPesoTeorico = dgvProduccionProceso._PesoTeorico
        NPTExtrusion.iIdOperadorPtoTra = "N/A"
        NPTExtrusion.iFechaTurno = dtpFecha.Value.ToString("yyyy-MM-dd")
        NPTExtrusion.iSobrePeso = 0.0
        NPTExtrusion.iFechaPesajeSAP = dtpFechaSAP.Value.ToString("yyyyMMdd")
        NPTExtrusion.iTipoPT = "R"
        NPTExtrusion.iArea = "E"
        NPTExtrusion.iTipoScrap = "1"
        NPTExtrusion.iRepGenerado = "0"
        NPTExtrusion.iFolioPesaje = dgvProduccionProceso._IdFolioPesaje
        NPTExtrusion.iVersion = Atlas_Version.Version
        NPTExtrusion.iSupervisor = "Supervisor"
        NPTExtrusion.iComp1 = dgvProduccionProceso._Comp1.Trim
        NPTExtrusion.iPorc1 = dgvProduccionProceso.Porc1.Trim
        NPTExtrusion.iCant1 = NPTExtrusion._iPN
        NPTExtrusion.iComp2 = "0"
        NPTExtrusion.iPorc2 = "0"
        NPTExtrusion.iCant2 = "0"
        NPTExtrusion.iIdCausa = cmbCausa.SelectedValue
        NPTExtrusion.iIdDefecto = cmbDefecto.SelectedValue
        NPTExtrusion.iPBR = txtPesoBruto.Text
        NPTExtrusion.iPTR = txtPesoTara.Text
        NPTExtrusion.iPNR = txtPesoNeto.Text
        NPTExtrusion.iTramosR = txtUnidades.Text
        NPTExtrusion.iNotifica = "0"
        NPTExtrusion.iFolioRecuperacion = dgvProduccionProceso._IdFolioProceso
        'Inserta regisrto pesaje recuperado
        Try
            LoadingForm.ShowLoading()
            FolioNotifica.rIdFolio = OperacionProduccionProceso.NotificaScrap
            OperacionProduccionProceso.ActualizaNotificacionRecuperadaPT()
            If NPTExtrusion._iTramosR = 0 Then
                NPTExtrusion.iEstatusProceso = "3"
            Else
                NPTExtrusion.iEstatusProceso = "2"
            End If
            OperacionProduccionProceso.ActualizaEnProceso()
        Catch ex As Exception
            LoadingForm.CloseForm()
            MensajeBox.Mostrar(ex.Message, "Error Intente Nuevamente", MensajeBox.TipoMensaje.Critical)
            Return
        End Try
        'Identificar Compuesto original de la bom ------------------------------------------------
        Dim IdComEstatus As Boolean
        IdComEstatus = OperacionProduccionProceso.Compuesto_Bom(dgvProduccionProceso._IdProducto)
        If IdComEstatus = False Then
            MsgBox("Este producto no tiene asignado compuesto virgen para su consumo", MsgBoxStyle.Critical)
            Return
        End If
        'Se asigna valor a variables de consumo compuestos 1, 2 -----------------------------------
        Lista.Clear()

        If NPTExtrusion.iComp1.Trim <> 0 Then
            Lista.Add(Util.QuitarCerosIzquierda(NPTExtrusion._iComp1.Trim) + "|" + NPTExtrusion._iCant1.Trim)
        End If

        If NPTExtrusion.iComp2.Trim <> 0 Then
            Lista.Add(Util.QuitarCerosIzquierda(NPTExtrusion._iComp2.Trim) + "|" + NPTExtrusion._iCant2.Trim)
        End If
        'Identifica si el compuesto es de paros y arranques o normal
        Reprocesado_Gen = OperacionProduccionProceso.Identifica_Reprocesado(NPTExtrusion._iComp1.Trim)
        'Se verifica status de conexión y se determina si se envia a SAP o no --------------------
        Select Case Conexion_SAP
            Case "False"
                LoadingForm.CloseForm()
                MsgBox(" No se realizara notificación a SAP se encuntra deshabilitada la conexión ")
            Case "True"
                'Se arma la cadena del Header de verificacion de duplicados
                Header_Duplicado = "74" + _
                                "|" + "CO15" + _
                                "|" + txtOrdenProduccion.Text.Trim + _
                                "|" + SessionUser._sAlias.Trim + _
                                "|" + FolioNotifica._rIdFolio.Trim
                'Variables WS Duplicados
                Dim Err_dup As String = ""
                Dim Mns_dup As String = ""
                Dim Return_dup As Object
                Dim Tbl_dup As String()
                WS_P.Consume_WS(Header_Duplicado, Lista, SessionUser._sAmbiente)
                Tbl_dup = WS_P.Tbl_resultado
                Return_dup = WS_P.Return_SAP
                Err_dup = Return_dup.ZTYPE
                Mns_dup = Return_dup.ZMESSAGE
                Select Case Err_dup
                    '------Si no existe la notificacion regresa Error y se realiza la notificación normal
                    Case Is = "E"
                        Dim Head As String
                        Head = "28|" + txtOrdenProduccion.Text.Trim + "|" + NPTExtrusion.iPN.ToString + "|" + NPTExtrusion._iFechaPesajeSAP.Trim + "|" + Compuestos._IdCompuestoBOM.Trim + "|" + "S" + "|" + SessionUser._sAlias.Trim + "|" + FolioNotifica._rIdFolio.Trim + "|" + Reprocesado_Gen
                        Notifica_SCE(Head, Lista, FolioNotifica._rIdFolio.Trim, SessionUser._sAlias)
                        Load_Grid()
                    Case Else
                        '------Si fue notificado se actualiza el registro
                        Dim Doc_Con_dup As String = ""
                        Doc_Con_dup = Tbl_dup(0)
                        Generic_SAP.agregarConsecutivosSAP(Doc_Con_dup)

                        NPTExtrusion.iOrdenProduccion = dgvProduccionProceso._OrdenProduccion.Trim
                        NPTExtrusion.iFolioPesaje = dgvProduccionProceso._IdFolioPesaje
                        NPTExtrusion.iIdReg = 1
                        NPTExtrusion.iDocSAP = Generic_SAP.DocumentoSAP
                        NPTExtrusion.iNumSAP = Generic_SAP.ConsecutivoSAP

                        OperacionProduccionProceso.NotificacionExitosaSC()
                        Load_Grid()
                End Select
                'Se notifica Scrap a SAP
                LoadingForm.CloseForm()
        End Select
    End Sub

    Private Sub Notifica_SCE(ByVal strHead As String, List As Generic.List(Of String), strFolio As String, UsrOperador As String)
        Dim Tbl As String()
        Dim Tbl_LM As New Generic.List(Of String)
        Dim SAP_Return As Object
        Dim Doc_Con As String
        Dim Cod_Err As String = ""
        Dim reg As String
        Try
            WS_P.Consume_WS(strHead, List, SessionUser._sAmbiente)
            Tbl = WS_P.Tbl_resultado
            SAP_Return = WS_P.Return_SAP
            Err = SAP_Return.ZTYPE
            Mns = SAP_Return.ZMESSAGE
            Doc_Con = SAP_Return.zmessage_v1
            Generic_SAP.agregarConsecutivosSAP(Doc_Con)

            If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                LoadingForm.CloseForm()
                reg = "0"
                MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
                Try
                    NPTExtrusion.iOrdenProduccion = dgvProduccionProceso._OrdenProduccion.Trim
                    NPTExtrusion.iFolioPesaje = FolioNotifica._rIdFolio
                    OperacionProduccionProceso.NotificacionFallidaSC()
                    LoadingForm.CloseForm()
                Catch ex As Exception
                    LoadingForm.CloseForm()
                    MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                End Try
            Else
                If (Generic_SAP.DocumentoSAP = "" Or Generic_SAP.DocumentoSAP = "NULL" Or Generic_SAP.DocumentoSAP = "0000000000") And (Generic_SAP.ConsecutivoSAP = "" Or Generic_SAP.ConsecutivoSAP = "NULL" Or Generic_SAP.ConsecutivoSAP = "00000000") Then
                    LoadingForm.CloseForm()
                    reg = "0"
                    MsgBox("No Notifico a SAP")
                    Return
                Else
                    reg = "1"
                    txtFolioAtlas.Text = FolioNotifica._rIdFolio
                    txtDocSAP.Text = Generic_SAP.DocumentoSAP
                    txtConSAP.Text = Generic_SAP.ConsecutivoSAP
                    Cnn.LecturaQry("PA_Actualiza_Notificacion_Scrap " & SessionUser._sCentro.Trim & "_PesoScrap, '" & Generic_SAP.DocumentoSAP & "', '" & Generic_SAP.ConsecutivoSAP & "', '" & reg & "', '" & Mns.Trim & "',  '" & strFolio.Trim & "' ")
                    LoadingForm.CloseForm()
                    MensajeBox.Mostrar("La notificación de la Orden '" & dgvProduccionProceso._OrdenProduccion.Trim & "' a sido Exitosa ", "Notificación Exitosa", MensajeBox.TipoMensaje.Good)
                End If
            End If
        Catch ex As Exception
            LoadingForm.CloseForm()
            MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
        End Try
    End Sub

#End Region

End Class