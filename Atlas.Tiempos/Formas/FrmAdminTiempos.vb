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
        Asigna_Turno()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub Btn_Consulta_Click(sender As Object, e As EventArgs) Handles Btn_Consulta.Click
        If cmbTurnos.Text = "" Then
            MensajeBox.Mostrar("Seleccione turno", "Campo vacio", MensajeBox.TipoMensaje.Information)
            Return
        Else
            CargaGrid()
        End If
    End Sub
    Private Sub dgvOrdenes_CurrentCellChanged(sender As Object, e As EventArgs)
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

                ConsultaHorasTotales.rFFP = DTP_Fecha.Value.AddMonths(1).ToString("yyyy-MM-dd")
                ConsultaHorasTotales.rPuestoTrabajo = Tiempos_ODF._tPuestoTrabajo
                ConsultaHorasTotales.rOrdenProduccion = Tiempos_ODF._tOrden_Produccion
                ConsultaHorasTotales.rOrdenProduccionGenerica = "99999991"
                'SetTiempos()
                'Config_Buttons(Tiempos_ODF._tEstatus)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub dgvOrdenes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Dim oldRowIndex As Object
        oldRowIndex = dgvOrdenes.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            ControlDataGridView.DGV_Formating_Estandar(dgvOrdenes)
        End If
    End Sub
    Private Sub btnRegTiemposParoProd_Click(sender As Object, e As EventArgs) Handles btnRegTiemposParoProd.Click
        Accion = "0"

        PermisoTiempos.Accesos("MP_IngresoTiempos", EXTINY.Trim, SessionUser._sIdPerfil, "E", "Registro Tiempos Paro / Productivos")
        If Accion = "1" Then
            CargaGrid()
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Accion = "0"
        PermisoTiempos.Accesos("MP_BajaTiempos", EXTINY.Trim, SessionUser._sIdPerfil, "E", "Baja Tiempos Paro / Productivos")
        If Accion = "1" Then
            CargaGrid()
        End If
    End Sub
    Private Sub dgvOrdenes_CellFormatting_1(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvOrdenes.CellFormatting
        With dgvOrdenes
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        End With
    End Sub
    Private Sub dgvDetalle_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDetalle.CellFormatting
        With dgvDetalle
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        End With
    End Sub
#End Region

#Region "Metodos"
    Public Sub CargaGrid()

        ConsultaODF.rFIP = DTP_Fecha.Value.ToString("yyyy-MM-dd")
        ConsultaODF.rTurno = cmbTurnos.SelectedValue
        ConsultaODF.rArea = EXTINY

        OperacionTiempos.DetalleHoras(dgvOrdenes, 1)
        OperacionTiempos.ResumenHoras(dgvDetalle, 2)

    End Sub

    Private Sub Asigna_Turno()
        ' ---------------------------------------------------------------------------------
        'Se asigna turno que corresponde acorde al horario
        Dim HReal As String = DateTime.Now.ToString("HH:mm:ss")
        Catalogo_Turnos.Combo_Turnos(cmbTurnos)
        Catalogo_Turnos.Asigna_turno(cmbTurnos, HReal)
    End Sub
#End Region

    Private Sub dgvOrdenes_CurrentCellChanged_1(sender As Object, e As EventArgs) Handles dgvOrdenes.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = dgvOrdenes.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Try
                dgv_DetalleHoras.Folio = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(0).Value.ToString
                dgv_DetalleHoras.OrdenProduccion = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(1).Value.ToString
                dgv_DetalleHoras.IdPuestoTrabajo = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(2).Value.ToString
                dgv_DetalleHoras.PuestoTrabajo = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(3).Value.ToString
                dgv_DetalleHoras.Horas = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(4).Value.ToString
                dgv_DetalleHoras.IdCausa = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(5).Value.ToString
                dgv_DetalleHoras.Causa = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(6).Value.ToString
                dgv_DetalleHoras.FechaTurno = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(7).Value.ToString
                dgv_DetalleHoras.FechaRegistro = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(8).Value.ToString
                dgv_DetalleHoras.UserRegistro = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(9).Value.ToString
                dgv_DetalleHoras.Turno = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(10).Value.ToString
                dgv_DetalleHoras.FechaAlta = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(11).Value.ToString
                dgv_DetalleHoras.IdArea = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(12).Value.ToString
                dgv_DetalleHoras.Area = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(13).Value.ToString
                dgv_DetalleHoras.IdSeccion = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(14).Value.ToString
                dgv_DetalleHoras.Seccion = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(15).Value.ToString
                dgv_DetalleHoras.IdGpoDiametro = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(16).Value.ToString
                dgv_DetalleHoras.GpoDiametro = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(17).Value.ToString
                dgv_DetalleHoras.IdProducto = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(18).Value.ToString
                dgv_DetalleHoras.Producto = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(19).Value.ToString
                dgv_DetalleHoras.IdGrupoParos = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(20).Value.ToString
                dgv_DetalleHoras.GrupoParos = dgvOrdenes.Rows(dgvOrdenes.CurrentCell.RowIndex).Cells(21).Value.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub
End Class