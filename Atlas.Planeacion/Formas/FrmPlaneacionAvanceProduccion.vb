Imports SQL_DATA
Imports System.Drawing
Imports Utili_Generales
Imports System.Windows.Forms

Public Class FrmPlaneacionAvanceProduccion

#Region "Variables"
    Dim Status_Not As String
#End Region

#Region "Eventos"
    Private Sub FrmAvanceProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigLoad()
        reset()
    End Sub
    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        LoadingForm.ShowLoading()
        Timer1.Enabled = False
     
        If cmbTurno.Text = "" Then
            ProduccionConsulta.cTurno = ""
        Else
            ProduccionConsulta.cTurno = cmbTurno.SelectedValue
        End If


        dgvResumen.Columns.Clear()
        dgvResumen.Refresh()
        dgvResumen.DataSource = Nothing

        If cmbCentro.Text = "" Then
            ProduccionConsulta.cFI = DTP_FI.Value.ToString("yyyy-MM-dd")
            ProduccionConsulta.cFF = DTP_FF.Value.ToString("yyyy-MM-dd")

            'Filtrado por Orden de Producción
            If rbtOrden.Checked = True Then
                Utili_Generales.ControlDataGridView.ResumenOrden(dgvResumen)
                Planeacion.ResumenOrden(dgvResumen)
                SetInfo()
            End If

            'Filtrado por puesto de trabajo
            If rbtEquipo.Checked = True Then
                Utili_Generales.ControlDataGridView.ResumenEquipo(dgvResumen)
                Planeacion.ResumenEquipos(dgvResumen)
                SetInfo()
            End If
        Else
            ProduccionConsulta.cFI = DTP_FI.Value.ToString("yyyy-MM-dd")
            ProduccionConsulta.cFF = DTP_FF.Value.ToString("yyyy-MM-dd")
            ProduccionConsulta.cHI = DTP_HI.Text
            ProduccionConsulta.cHF = DTP_HF.Text
            ProduccionConsulta.cCentro = cmbCentro.Text
            ProduccionConsulta.cOrden = ""

            'Filtrado por Orden de Producción
            If rbtOrden.Checked = True Then
                Utili_Generales.ControlDataGridView.AvanceOrden(dgvResumen)
                Planeacion.Orden_Resumen(dgvResumen)
                SetInfo()
            End If
            'Filtrado por puesto de trabajo
            If rbtEquipo.Checked = True Then
                Utili_Generales.ControlDataGridView.AvanceEquipo(dgvResumen)
                Planeacion.Equipo_Resumen(dgvResumen)
                SetInfo()
            End If
        End If


        Timer1.Enabled = True
        LoadingForm.CloseForm()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub


    Private Sub dgvScrap_CellFormatting(sender As Object, e As Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvScrap.CellFormatting
        ControlDataGridView.DGV_Formating_Produccion(dgvScrap, 24, e)
    End Sub

    Private Sub dgvProduccion_CellFormatting(sender As Object, e As Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProduccion.CellFormatting
        ControlDataGridView.DGV_Formating_Produccion(dgvProduccion, 24, e)
    End Sub

    Private Sub dgvResumen_CellFormatting(sender As Object, e As Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvResumen.CellFormatting
        If cmbCentro.Text = "" Then
            ControlDataGridView.dgvAvancePlaneacion(dgvResumen, 14, e)
        Else
            ControlDataGridView.dgvAvancePlaneacion(dgvResumen, 13, e)
        End If
    End Sub

    Private Sub ExportarAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarAExcelToolStripMenuItem.Click
        If TCCalidad.SelectedTab.Name = "Resumen" Then
            Util.ExportaExcel(dgvResumen)
        ElseIf TCCalidad.SelectedTab.Name = "Produccion" Then
            Util.ExportaExcel(dgvProduccion)
        ElseIf TCCalidad.SelectedTab.Name = "Scrap" Then
            Util.ExportaExcel(dgvScrap)
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BtnConsulta.PerformClick()
    End Sub
#End Region

#Region "Eventos Detalle Producción"
    Private Sub BtnProduccion_Click(sender As Object, e As EventArgs) Handles BtnProduccion.Click
        LoadingForm.ShowLoading()
        Timer1.Enabled = False
        ProduccionConsulta.cFI = DTP_PFI.Value.ToString("yyyy-MM-dd")
        ProduccionConsulta.cFF = DTP_PFF.Value.ToString("yyyy-MM-dd")
        ProduccionConsulta.cHI = DTP_HPI.Text
        ProduccionConsulta.cHF = DTP_HPF.Text
        ProduccionConsulta.cCentro = cmbCentroProd.Text
        ProduccionConsulta.cOrden = TxPOrden.Text

        If cmbTurnoProd.Text = "" Then
            ProduccionConsulta.cTurno = ""
        Else
            ProduccionConsulta.cTurno = cmbTurnoProd.SelectedValue
        End If

        If cmbCentroProd.SelectedValue = Nothing Then
            MensajeBox.Mostrar("Seleccione clave de centro a consultar", "Campo Vacio", MensajeBox.TipoMensaje.Information)
            Return
        End If

        dgvProduccion.Columns.Clear()
        dgvProduccion.Refresh()
        dgvProduccion.DataSource = Nothing

        If RBPOrden.Checked = True Then
            Planeacion.Orden_Produccion(dgvProduccion)
        End If

        If RBPPuesto.Checked = True Then
            Planeacion.Equipo_Produccion(dgvProduccion)
        End If
        Timer1.Enabled = True
        LoadingForm.CloseForm()
    End Sub
#End Region

#Region "Eventos Detalle Scrap"
    Private Sub BtnScrap_Click(sender As Object, e As EventArgs) Handles BtnScrap.Click
        LoadingForm.ShowLoading()
        Timer1.Enabled = False
        ProduccionConsulta.cFI = DTP_SFI.Value.ToString("yyyy-MM-dd")
        ProduccionConsulta.cFF = DTP_SFF.Value.ToString("yyyy-MM-dd")
        ProduccionConsulta.cHI = DTP_SHI.Text
        ProduccionConsulta.cHF = DTP_SHF.Text()
        ProduccionConsulta.cCentro = cmbCentroScrap.Text
        ProduccionConsulta.cOrden = TxSOrden.Text

        If cmbTurnoScrap.Text = "" Then
            ProduccionConsulta.cTurno = ""
        Else
            ProduccionConsulta.cTurno = cmbTurnoScrap.SelectedValue
        End If

        If cmbCentroScrap.SelectedValue = Nothing Then
            MensajeBox.Mostrar("Seleccione clave de centro a consultar", "Campo Vacio", MensajeBox.TipoMensaje.Information)
            Return
        End If

        dgvScrap.Columns.Clear()
        dgvScrap.Refresh()
        dgvScrap.DataSource = Nothing

        If RBSOrden.Checked = True Then
            Planeacion.Orden_Scrap(dgvScrap)
        End If

        If RBSPuesto.Checked = True Then
            Planeacion.Equipo_Scrap(dgvScrap)
        End If
        Timer1.Enabled = True
        LoadingForm.CloseForm()
    End Sub
#End Region

#Region "Metodos"
    Private Sub ConfigLoad()
        Centros.Centrosxpais(cmbCentro)
        Centros.Centrosxpais(cmbCentroProd)
        Centros.Centrosxpais(cmbCentroScrap)
        Catalogo_Turnos.Combo_Turnos(cmbTurno)
        Catalogo_Turnos.Combo_Turnos(cmbTurnoProd)
        Catalogo_Turnos.Combo_Turnos(cmbTurnoScrap)
        Dim fecha As New DateTime(Date.Now.Year, Date.Now.Month, 1)
        DTP_FI.Value = fecha
        DTP_PFI.Value = fecha
        DTP_SFI.Value = fecha
        DTP_HI.Text = ("00:00:01")
        DTP_HF.Text = ("23:59:59")
        DTP_HPI.Text = ("00:00:01")
        DTP_HPF.Text = ("23:59:59")
        DTP_SHI.Text = ("00:00:01")
        DTP_SHF.Text = ("23:59:59")
    End Sub

    Private Sub reset()
        cmbCentro.SelectedIndex = -1
        cmbCentroProd.SelectedIndex = -1
        cmbCentroScrap.SelectedIndex = -1
        cmbTurno.SelectedIndex = -1
        cmbTurnoProd.SelectedIndex = -1
        cmbTurnoScrap.SelectedIndex = -1
    End Sub

    Private Sub SetInfo()
        Label30.Text = ResumenOrdenEquipo._rProduccionkg
        Label32.Text = ResumenOrdenEquipo._rTeoricokg
        Label34.Text = ResumenOrdenEquipo._rScrapkg
        Label36.Text = ResumenOrdenEquipo._rSobrepesokg
        Label45.Text = ResumenOrdenEquipo._Porcavance
        Label40.Text = ResumenOrdenEquipo._rPorcScrap
        Label38.Text = ResumenOrdenEquipo._rPorcSobrepeso
        Label47.Text = ResumenOrdenEquipo._rTramosrequerdios
        Label42.Text = ResumenOrdenEquipo._rTramosproducidos
        Label50.Text = ResumenOrdenEquipo._rSaldo
    End Sub
#End Region


    Private Sub dgvResumen_CellDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvResumen.CellDoubleClick
        CtrlVariablesGlobal._Estado = "0"
        If dgvAvanceProduccion._rEstatusAvance = "3" Or dgvAvanceProduccion._rEstatusAvance = "4" Then
            Permissions.Access("MP_PlaneacionModOrden", "1", SessionUser._sIdPerfil, "E", "Modifica Orden ", 0)
        End If

        If CtrlVariablesGlobal._Estado = "1" Then
            BtnConsulta.PerformClick()
        End If
    End Sub

    Private Sub dgvResumenResumen_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvResumen.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = dgvResumen.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Try
                Dim Fila_Seleccionada As Integer = dgvResumen.CurrentCell.RowIndex
                dgvAvanceProduccion.rOrdenProduccion = dgvResumen.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                dgvAvanceProduccion.rEstatusOrden = dgvResumen.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                dgvAvanceProduccion.rPuestoTrabajo = dgvResumen.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                dgvAvanceProduccion.rProduccionkg = dgvResumen.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                dgvAvanceProduccion.rScrapkg = dgvResumen.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                dgvAvanceProduccion.rSobrepesokg = dgvResumen.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                dgvAvanceProduccion.rTeoricokg = dgvResumen.Rows(Fila_Seleccionada).Cells(6).Value.ToString
                dgvAvanceProduccion.rPorcScrap = dgvResumen.Rows(Fila_Seleccionada).Cells(7).Value.ToString
                dgvAvanceProduccion.rPorcSobrepeso = dgvResumen.Rows(Fila_Seleccionada).Cells(8).Value.ToString
                dgvAvanceProduccion.rTramosRequeridos = dgvResumen.Rows(Fila_Seleccionada).Cells(9).Value.ToString
                dgvAvanceProduccion.rTramosproducidos = dgvResumen.Rows(Fila_Seleccionada).Cells(10).Value.ToString
                dgvAvanceProduccion.rPendienteProducir = dgvResumen.Rows(Fila_Seleccionada).Cells(11).Value.ToString
                dgvAvanceProduccion.rAvance = dgvResumen.Rows(Fila_Seleccionada).Cells(12).Value.ToString
                dgvAvanceProduccion.rEstatusAvance = dgvResumen.Rows(Fila_Seleccionada).Cells(13).Value.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub
End Class