Imports SQL_DATA
Imports System.Drawing
Imports Utili_Generales
Public Class FrmAvanceProduccion

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
        AvanceProduccionConsulta.cCentro = cmbCentro.Text

        If cmbTurno.Text = "" Then
            AvanceProduccionConsulta.cTurno = ""
        Else
            AvanceProduccionConsulta.cTurno = cmbTurno.SelectedValue
        End If

        dgvResumen.Columns.Clear()
        dgvResumen.Refresh()
        dgvResumen.DataSource = Nothing

        dgvProduccion.Columns.Clear()
        dgvProduccion.Refresh()
        dgvProduccion.DataSource = Nothing

        dgvScrap.Columns.Clear()
        dgvScrap.Refresh()
        dgvScrap.DataSource = Nothing

        If cmbCentro.Text = "" Then
            ResumenProduccionPlantas.cFI = DTP_FI.Value.ToString("yyyy-MM-dd")
            ResumenProduccionPlantas.cFF = DTP_FF.Value.ToString("yyyy-MM-dd")

            'Filtrado por Orden de Producción
            If rbtOrden.Checked = True Then
                Utili_Generales.ControlDataGridView.ResumenOrden(dgvResumen)
                Adm_Calidad.ResumenOrden(dgvResumen)
                SetInfo()
            End If

            'Filtrado por puesto de trabajo
            If rbtEquipo.Checked = True Then
                Utili_Generales.ControlDataGridView.ResumenEquipo(dgvResumen)
                Adm_Calidad.ResumenEquipos(dgvResumen)
                SetInfo()
            End If
        Else
            AvanceProduccionConsulta.cFI = DTP_FI.Value.ToString("yyyy-MM-dd")
            AvanceProduccionConsulta.cFF = DTP_FF.Value.ToString("yyyy-MM-dd")

            'Filtrado por Orden de Producción
            If rbtOrden.Checked = True Then
                Utili_Generales.ControlDataGridView.AvanceOrden(dgvResumen)
                Adm_Calidad.Orden_Resumen(dgvResumen)
                SetInfo()
            End If
            'Filtrado por puesto de trabajo
            If rbtEquipo.Checked = True Then
                Utili_Generales.ControlDataGridView.AvanceEquipo(dgvResumen)
                Adm_Calidad.Equipo_Resumen(dgvResumen)
                SetInfo()
            End If
        End If
        LoadingForm.CloseForm()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
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
        DTP_PFI.Value = fecha
        DTP_SFI.Value = fecha
        DTP_HPI.Text = ("00:00:01")
        DTP_HPF.Text = ("23:59:59")
        DTP_SHI.Text = ("00:00:01")
        DTP_SHF.Text = ("23:59:59")
        DTP_FI.Value = Util.PrimerDiaDelMes(Date.Now)
        DTP_FF.Value = Util.UltimoDiaDelMes(Date.Now)
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
        LScrap.Text = AvanceGlobal._rPorcentajeScrap
        LSobrepeso.Text = AvanceGlobal._rPorcenatejSobrepeso
    End Sub
#End Region



    Private Sub dgvScrap_CellFormatting(sender As Object, e As Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvScrap.CellFormatting
        ControlDataGridView.DGV_Formating_Produccion(dgvScrap, 24, e)
    End Sub

    Private Sub dgvProduccion_CellFormatting(sender As Object, e As Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProduccion.CellFormatting
        ControlDataGridView.DGV_Formating_Produccion(dgvProduccion, 24, e)
    End Sub

    Private Sub dgvResumen_CellFormatting(sender As Object, e As Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvResumen.CellFormatting
        If cmbCentro.Text = "" Then
            ControlDataGridView.dgvAvance(dgvResumen, 14, e)
        Else
            ControlDataGridView.dgvAvance(dgvResumen, 13, e)
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

    Private Sub BtnProduccion_Click(sender As Object, e As EventArgs) Handles BtnProduccion.Click
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
            ProduccionConsulta.cCentro = ""
        Else
            ProduccionConsulta.cCentro = cmbCentroProd.Text.Trim
        End If

        dgvProduccion.Columns.Clear()
        dgvProduccion.Refresh()
        dgvProduccion.DataSource = Nothing

        If RBPOrden.Checked = True Then
            Adm_Calidad.Orden_Produccion(dgvProduccion, 1)
        End If

        If RBPPuesto.Checked = True Then
            Adm_Calidad.Equipo_Produccion(dgvProduccion)
        End If
        LoadingForm.CloseForm()
    End Sub

    Private Sub BtnScrap_Click(sender As Object, e As EventArgs) Handles BtnScrap.Click
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

        If cmbCentroProd.SelectedValue = Nothing Then
            ProduccionConsulta.cCentro = ""
        Else
            ProduccionConsulta.cCentro = cmbCentroProd.Text.Trim
        End If

        dgvScrap.Columns.Clear()
        dgvScrap.Refresh()
        dgvScrap.DataSource = Nothing

        If RBSOrden.Checked = True Then
            Adm_Calidad.Orden_Scrap(dgvScrap)
        End If

        If RBSPuesto.Checked = True Then
            Adm_Calidad.Equipo_Scrap(dgvScrap)
        End If
        LoadingForm.CloseForm()
    End Sub
End Class