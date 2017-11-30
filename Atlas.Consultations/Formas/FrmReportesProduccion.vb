Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Imports System.Drawing

Public Class FrmReportesProduccion
#Region "Variables"

#End Region

#Region "Eventos"
    Private Sub CerrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub BtnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportExcel.Click
        Util.ExportaExcel(DGVQuery)
    End Sub

    Private Sub Btn_Consulta_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Consulta.Click
        ValidateFields()

        If RBPeriod.Checked = True Then
            If RdbConsolidado.Checked = True Then
                Querys.Summary(DGVQuery, 1)
            End If

            If RdbDetalle.Checked = True Then
                Querys.Detail(DGVQuery, 2)
            End If
        End If

        If RBTurno.Checked = True Then
            If RdbConsolidado.Checked = True Then
                Querys.Summary(DGVQuery, 3)
            End If

            If RdbDetalle.Checked = True Then
                Querys.Detail(DGVQuery, 4)
            End If
        End If

        If RBSeccion.Checked = True Then
            If RdbConsolidado.Checked = True Then
                Querys.Summary(DGVQuery, 5)
            End If

            If RdbDetalle.Checked = True Then

            End If
        End If

        If RBPuesto.Checked = True Then
            If RdbConsolidado.Checked = True Then
                Querys.Summary(DGVQuery, 7)
            End If

            If RdbDetalle.Checked = True Then

            End If
        End If

        If RBOrden.Checked = True Then
            If RdbConsolidado.Checked = True Then
                Querys.Summary(DGVQuery, 9)
            End If

            If RdbDetalle.Checked = True Then

            End If
        End If

        If RBProducto.Checked = True Then
            If RdbConsolidado.Checked = True Then
                Querys.Summary(DGVQuery, 11)
            End If

            If RdbDetalle.Checked = True Then

            End If
        End If

        If RBGrp.Checked = True Then
            If RdbConsolidado.Checked = True Then
                Querys.Summary(DGVQuery, 13)
            End If

            If RdbDetalle.Checked = True Then

            End If
        End If
    End Sub

    Private Sub FrmReportesProduccion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Catalogo_Areas.Productivas(CBArea, EXTINY)
        Catalogo_Turnos.Combo_Turnos(CBTurno)
        Catalogo_Secciones.CB(CBSeccion, EXTINY)
        Catalogo_Puestos_Trabajo.CB(CBPuesto, EXTINY)
        Catalogo_Productos.CB(CBProducto, EXTINY)
        Catalogo_Grupo_Materiales.CB(CBGrupo, EXTINY)
        Limpiacb()
    End Sub

    Private Sub DGVQuery_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGVQuery.CellFormatting
        With DGVQuery
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        End With
    End Sub

#End Region

#Region "Metodos"
    Private Sub Limpiacb()
        CBTurno.SelectedIndex = -1
        CBSeccion.SelectedIndex = -1
        CBPuesto.SelectedIndex = -1
        CBProducto.SelectedIndex = -1
        CBGrupo.SelectedIndex = -1
    End Sub
#End Region

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        ValidateFields()

        If RBPeriod.Checked = True Then
            If RdbConsolidado.Checked = True Then
                ReportesProduccion.CPG(1)
            End If
        End If
    End Sub

    Private Sub ValidateFields()
        ConsultasProduccion.Centro = SessionUser._sCentro

        If CBArea.Text <> "" Then
            ConsultasProduccion.Area = CBArea.SelectedValue
        Else
            ConsultasProduccion.Area = ""
        End If

        If CBSeccion.Text <> "" Then
            ConsultasProduccion.Seccion = CBSeccion.SelectedValue
        Else
            ConsultasProduccion.Seccion = ""
        End If

        If CBTurno.Text <> "" Then
            ConsultasProduccion.Turno = CBTurno.SelectedValue
        Else
            ConsultasProduccion.Turno = ""
        End If

        ConsultasProduccion.FI = DTPI.Text.Trim
        ConsultasProduccion.FF = DTPF.Text.Trim

        If CBPuesto.Text <> "" Then
            ConsultasProduccion.PuestoTrabajo = CBPuesto.SelectedValue
        Else
            ConsultasProduccion.PuestoTrabajo = ""
        End If

        If txtOrdenProduccion.Text <> "" Then
            ConsultasProduccion.Orden = txtOrdenProduccion.Text.Trim
        Else
            ConsultasProduccion.Orden = ""
        End If

        If CBProducto.Text <> "" Then
            ConsultasProduccion.Producto = CBProducto.SelectedValue
        Else
            ConsultasProduccion.Producto = ""
        End If

        If CBGrupo.Text <> "" Then
            ConsultasProduccion.GrpDiametro = CBGrupo.SelectedValue
        Else
            ConsultasProduccion.GrpDiametro = ""
        End If

        ConsultasProduccion.AreaProductiva = EXTINY
    End Sub
End Class