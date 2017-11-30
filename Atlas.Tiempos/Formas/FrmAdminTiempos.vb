Imports SQL_DATA
Imports Atlas.Accesos
Imports Atlas.Accesos.CLVarGlobales
Imports Utili_Generales

Public Class FrmAdminTiempos
#Region "Variables"
    Dim FI As String        'Fecha inicio consulta
    Dim FF As String        'Fecha fin consulta
    'Variables filtros consulta
    Dim cOrden As String
#End Region

#Region "Eventos"
    Private Sub tsbClose_Click(sender As Object, e As EventArgs) Handles tsbClose.Click
        Close()
    End Sub
    Private Sub FrmAdminTiempos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Accesos.Parametrizacion.ParametrizedFormTiempos(Me)
        Parameter()
        CargaGrid()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub Btn_Consulta_Click(sender As Object, e As EventArgs) Handles Btn_Consulta.Click
        If DTP_FI.Value > DTP_FF.Value Then
            MensajeBox.Mostrar("La Fecha Inicio no puede ser mayor a la fecha Fin ", "Fechas", MensajeBox.TipoMensaje.Exclamation)
            Return
        End If

        If DTP_FF.Value < DTP_FI.Value Then
            MensajeBox.Mostrar("La Fecha Fin no puede ser menor a la fecha Inicio ", "Fechas", MensajeBox.TipoMensaje.Exclamation)
            Return
        End If

        CargaGrid()
    End Sub
    Private Sub dgvOrdenes_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvOrdenes.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = dgvOrdenes.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Try
                Dim Fila_Seleccionada As Integer = dgvOrdenes.CurrentCell.RowIndex
                Tiempos_ODF.tCentro = dgvOrdenes.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                Tiempos_ODF.tPuestoTrabajo = dgvOrdenes.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                Tiempos_ODF.tOrden_Produccion = dgvOrdenes.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                Tiempos_ODF.tCodigoMaterial = dgvOrdenes.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                Tiempos_ODF.tCantidadProgramada = dgvOrdenes.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                Tiempos_ODF.tFI = dgvOrdenes.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                Tiempos_ODF.tFF = dgvOrdenes.Rows(Fila_Seleccionada).Cells(6).Value.ToString
                Tiempos_ODF.tEstatus = dgvOrdenes.Rows(Fila_Seleccionada).Cells(7).Value.ToString
                Tiempos_ODF.tTotalTiempo = dgvOrdenes.Rows(Fila_Seleccionada).Cells(8).Value.ToString

                ConsultaHorasTotales.rFIP = DTP_FI.Value.ToString("yyyy-MM-dd")
                ConsultaHorasTotales.rFFP = DTP_FF.Value.AddMonths(1).ToString("yyyy-MM-dd")
                ConsultaHorasTotales.rPuestoTrabajo = Tiempos_ODF._tPuestoTrabajo
                ConsultaHorasTotales.rOrdenProduccion = Tiempos_ODF._tOrden_Produccion
                ConsultaHorasTotales.rOrdenProduccionGenerica = "99999991"
                dgvDetalleHoras.Columns.Clear()
                dgvDetalleHoras.Refresh()
                dgvDetalleHoras.DataSource = Nothing
                OperacionTiempos.TotalHoras(dgvDetalle, 4)

                'SetTiempos()
                'Config_Buttons(Tiempos_ODF._tEstatus)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub dgvOrdenes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvOrdenes.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = dgvOrdenes.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            ControlDataGridView.DGV_Formating_Estandar(dgvOrdenes)
        End If
    End Sub

    Private Sub dgvDetalle_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDetalle.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = dgvOrdenes.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            OperacionTiempos.dgvEstatusAvanceHoras(dgvDetalle, 4, e)
        End If
    End Sub
    Private Sub dgvDetalle_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvDetalle.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = dgvDetalle.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Try
                Dim Fila_Seleccionada As Integer = dgvDetalle.CurrentCell.RowIndex
                dgv_TotalHoras.FechaAvance = dgvDetalle.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                dgv_TotalHoras.EquipoAvance = dgvDetalle.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                dgv_TotalHoras.OrdenProduccion = dgvDetalle.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                dgv_TotalHoras.TurnoAvance = dgvDetalle.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                dgv_TotalHoras.HorasAvance = dgvDetalle.Rows(Fila_Seleccionada).Cells(4).Value.ToString

                ConsultaHorasDetalle.Fecha = dgv_TotalHoras._FechaAvance
                ConsultaHorasDetalle.Turno = dgv_TotalHoras._TurnoAvance
                ConsultaHorasDetalle.PuestoTrabajo = dgv_TotalHoras._EquipoAvance
                OperacionTiempos.DetalleHoras(dgvDetalleHoras, 2)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub dgvDetalleHoras_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDetalleHoras.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = dgvDetalleHoras.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            OperacionTiempos.dgvEstatusDetalleHoras(dgvDetalleHoras, 11, e)
        End If
    End Sub
    Private Sub dgvDetalleHoras_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvDetalleHoras.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = dgvDetalleHoras.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Try
                Dim Fila_Seleccionada As Integer = dgvDetalleHoras.CurrentCell.RowIndex
                dgv_DetalleHoras.IdTiempo = dgvDetalleHoras.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                dgv_DetalleHoras.Fecha = dgvDetalleHoras.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                dgv_DetalleHoras.OrdenProduccion = dgvDetalleHoras.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                dgv_DetalleHoras.PuestoTrabajo = dgvDetalleHoras.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                dgv_DetalleHoras.Turno = dgvDetalleHoras.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                dgv_DetalleHoras.IdGrupoParos = dgvDetalleHoras.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                dgv_DetalleHoras.GrupoParos = dgvDetalleHoras.Rows(Fila_Seleccionada).Cells(6).Value.ToString
                dgv_DetalleHoras.IdParoProduccion = dgvDetalleHoras.Rows(Fila_Seleccionada).Cells(7).Value.ToString
                dgv_DetalleHoras.CodigoParo = dgvDetalleHoras.Rows(Fila_Seleccionada).Cells(8).Value.ToString
                dgv_DetalleHoras.ConceptoParo = dgvDetalleHoras.Rows(Fila_Seleccionada).Cells(9).Value.ToString
                dgv_DetalleHoras.Horas = dgvDetalleHoras.Rows(Fila_Seleccionada).Cells(10).Value.ToString


            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub btnCalculaTiempos_Click(sender As Object, e As EventArgs) Handles btnCalculaTiempos.Click
        LoadingForm.ShowLoading()
        For j = 0 To dgvOrdenes.RowCount - 1
            AjustaTiempos.PuestoTrabajo = dgvOrdenes.Rows(j).Cells(1).Value.ToString()
            AjustaTiempos.OrdenProduccion = dgvOrdenes.Rows(j).Cells(2).Value.ToString()
            AjustaTiempos.IdOrden = dgvOrdenes.Rows(j).Cells(9).Value.ToString()
            AjustaTiempos.IdTurno = ""

            Select Case AjustaTiempos._OrdenProduccion
                Case Is = 0

                Case Is > 0
                    Try
                        OperacionTiempos.FechaIniProd()
                        Dim RFIP As DateTime
                        RFIP = AjustaTiempos._FIP
                        FHIniFin.rFIP = RFIP.ToString("yyyy/MM/dd HH:mm:ss")
                        Try
                            OperacionTiempos.FechaFinProd()
                            Dim RFFP As DateTime
                            RFFP = AjustaTiempos._FFP
                            FHIniFin.rFFP = RFFP.ToString("yyyy/MM/dd HH:mm:ss")
                            Try
                                OperacionTiempos.ActualizaFechas(2)
                            Catch ex As Exception
                                LoadingForm.CloseForm()
                                MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                                Exit For
                            End Try
                        Catch ex As Exception
                            LoadingForm.CloseForm()
                            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                            Exit For
                        End Try
                    Catch ex As Exception
                        LoadingForm.CloseForm()
                        MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                        Exit For
                    End Try
            End Select
        Next
        LoadingForm.CloseForm()
    End Sub

    Private Sub btnRegTiemposParoProd_Click(sender As Object, e As EventArgs) Handles btnRegTiemposParoProd.Click
        Accion = "0"

        PermisoTiempos.Accesos("MP_IngresoTiempos", 1, SessionUser._sIdPerfil, "E", "Registro Tiempos Paro / Productivos")
        If Accion = "1" Then
            CargaGrid()
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Accion = "0"

        PermisoTiempos.Accesos("MP_BajaTiempos", 1, SessionUser._sIdPerfil, "E", "Baja Tiempos Paro / Productivos")
        If Accion = "1" Then
            CargaGrid()
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Accion = "0"

        PermisoTiempos.Accesos("MP_ModificarTiempos", 1, SessionUser._sIdPerfil, "E", "Modifica Tiempos Paro / Productivos")
        If Accion = "1" Then
            CargaGrid()
        End If
    End Sub
#End Region

#Region "Metodos"
    Public Sub CargaGrid()

        ConsultaODF.rODF = txtOrdenProduccion.Text.Trim
        ConsultaODF.rFIP = DTP_FI.Value.ToString("yyyyMMdd")
        ConsultaODF.rFFP = DTP_FF.Value.AddDays(1).ToString("yyyyMMdd")
        ConsultaODF.rArea = EXTINY


        FI = DTP_FI.Value.ToString("yyyyMMdd")
        FF = DTP_FF.Value.AddDays(1).ToString("yyyyMMdd")
        cOrden = txtOrdenProduccion.Text.Trim
        Try
            LoadingForm.ShowLoading()
            OperacionTiempos.Consulta_ODF_Tiempos(dgvOrdenes, 3)
            LoadingForm.CloseForm()
        Catch ex As Exception
            LoadingForm.CloseForm()
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
        End Try
    End Sub

    Public Sub Parameter()
        btnCalculaTiempos.Enabled = P_CT
    End Sub
#End Region

End Class