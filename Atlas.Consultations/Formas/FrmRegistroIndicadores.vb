Imports Utili_Generales

Public Class FrmRegistroIndicadores
#Region "Variables"

#End Region

#Region "Eventos"
    Private Sub FrmRegistroIndicadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Grid()
        btnSave.Enabled = False
        btnSaveSeg.Enabled = False
    End Sub

    Private Sub btnEditarProd_Click(sender As Object, e As EventArgs) Handles btnEditarProd.Click
        dgvProduccion.ReadOnly = False
        btnSave.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvProduccion.ReadOnly = True
        btnSave.Enabled = False
        Load_Grid()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        LoadingForm.ShowLoading()

        For j = 0 To dgvProduccion.RowCount - 1
            IndicadoresProduccion.abcId = dgvProduccion.Rows(j).Cells(0).Value.ToString()
            IndicadoresProduccion.abcIndicador = dgvProduccion.Rows(j).Cells(1).Value.ToString()
            IndicadoresProduccion.abcMeta = dgvProduccion.Rows(j).Cells(2).Value.ToString()
            IndicadoresProduccion.abcTurno = dgvProduccion.Rows(j).Cells(3).Value.ToString()
            IndicadoresProduccion.abcMes = dgvProduccion.Rows(j).Cells(4).Value.ToString()
            Try
                Indicadores.abc(1)
            Catch ex As Exception
                LoadingForm.CloseForm()
                btnSave.Enabled = False
                dgvProduccion.ReadOnly = True
                MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                Exit Sub
            End Try
        Next
        LoadingForm.CloseForm()
        btnSave.Enabled = False
        dgvProduccion.ReadOnly = True
        Load_Grid()
    End Sub
    Private Sub dgvProduccion_CellFormatting(sender As Object, e As Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProduccion.CellFormatting
        ControlDataGridView.DGV_Formating_Estandar(dgvProduccion)
    End Sub

    Private Sub btnSaveSeg_Click(sender As Object, e As EventArgs) Handles btnSaveSeg.Click
        LoadingForm.ShowLoading()
        Dim UltimaFecha As Date

        For j = 0 To dgvSeguridad.RowCount - 1
            IndicadoresSeguridad.abcId = dgvSeguridad.Rows(j).Cells(0).Value.ToString()
            UltimaFecha = dgvSeguridad.Rows(j).Cells(1).Value.ToString()
            IndicadoresSeguridad.abcFecha = UltimaFecha.ToString("dd-MM-yyyy")
            Try
                Indicadores.abcSeguridad(1)
            Catch ex As Exception
                LoadingForm.CloseForm()
                btnSaveSeg.Enabled = False
                dgvSeguridad.ReadOnly = True
                MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                Load_Grid()
                Exit Sub
            End Try
        Next
        LoadingForm.CloseForm()
        btnSaveSeg.Enabled = False
        dgvSeguridad.ReadOnly = True
        Load_Grid()
    End Sub

    Private Sub btnCancelSeg_Click(sender As Object, e As EventArgs) Handles btnCancelSeg.Click
        dgvSeguridad.ReadOnly = True
        btnSaveSeg.Enabled = False
        Load_Grid()
    End Sub

    Private Sub btnEditarSeg_Click(sender As Object, e As EventArgs) Handles btnEditarSeg.Click
        dgvSeguridad.ReadOnly = False
        btnSaveSeg.Enabled = True
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub

#End Region

#Region "Metodos"
    Private Sub Load_Grid()
        Indicadores.Produccion(dgvProduccion)
        Indicadores.Seguridad(dgvSeguridad)
    End Sub
#End Region

End Class