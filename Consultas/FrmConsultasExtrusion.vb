Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmConsultasExtrusion
#Region "Variables Miembro"
    'Dim FIP As String   'Fecha de inicio pesaje
    'Dim FFP As String   'Fecha de fin pesaje
    'Dim HI As String    'Hora de inicio pesaje
    'Dim HF As String    'Hora de fin pesaje
    'Dim Status_Notif As String
    'Dim Seccion As String
    'Dim Seccion1 As String
    Dim Tipo As String
    Dim oldRowIndex As Object
    Dim Registros As Integer

#End Region

#Region "Metodos"

#End Region

#Region "Eventos"
    Private Sub FrmConsultasInyExt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CBG.CB_Turnos(CB_Turno)
        Me.Icon = Util.ApplicationIcon()
        TCentro.Text = SessionUser._sCentro.Trim
        If strArea = "1" Then
            Me.Text = "Consulta Producto Terminado Extrusión"
        Else
            Me.Text = "Consulta Producto Terminado Inyección"
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        ProduccionResumen.FI = DTP_FI.Value.ToString("yyyy-MM-dd")
        ProduccionResumen.FF = DTP_FF.Value.ToString("yyyy-MM-dd")
        ProduccionResumen.HI = THI.Text.Trim
        ProduccionResumen.HF = THF.Text.Trim

        'oldRowIndex = -1
        DGV1.Columns.Clear()
        DGV1.Refresh()
        DGV1.DataSource = Nothing

        ProduccionResumen.Status_Notif = CB_Notif.Checked
        ProduccionResumen.Seccion = CB_Sub.Checked
        ProduccionResumen.Turno = CB_Turno.Text

        'If CB_Notif.Checked Then
        '    Status_Notif = "(0,4,3)"
        'Else
        '    Status_Notif = "(0,4,3,1)"
        'End If

        'If CB_Sub.Checked Then
        '    Seccion = "in (''36'')"
        '    Seccion1 = "="
        'Else
        '    Seccion = "<> ''36''"
        '    Seccion1 = "<>"
        'End If

        'If CB_Turno.Text = "" Or CB_Turno.Text = "0" Then
        '    CB_Turno.Text = "*"
        'End If

        If TOrden.Text = "" Then
            MsgBox("Ingrese un numero de orden")
            Return
        End If

        TOrdProdSel.Text = TOrden.Text.Trim

        If RB_Detalle.Checked Then
            DBG.Consulta_Produccion_Detalle(Seccion, DGV1)
            DBG.Cantidades_Produccion_Detalle(Seccion, TCantProgra, TCantEntre, TCantEnproce, TCantpendi, txtTotunprod, _
                                              txtTotkilosprod, txtTotkilosproceso, txtTotunproceso, txtSobrepeso)
        End If

        If RB_Resumen.Checked Then
            Utili_Generales.ControlDataGridView.Colums_ConsultaResumen(DGV1)
            DBG.Consulta_Resumen_Produccion(Seccion, DGV1, txtPorcsobrepeso, txtSobrepeso, txtTotkilosscrap, txtPorscrap)
            DBG.Cantidades_Produccion_Detalle(Seccion, TCantProgra, TCantEntre, TCantEnproce, TCantpendi, txtTotunprod, _
                                              txtTotkilosprod, txtTotkilosproceso, txtTotunproceso, txtSobrepeso)
        End If
    End Sub

    Private Sub ExportarAExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarAExcelToolStripMenuItem.Click
        Util.ExportaExcel(DGV1)
    End Sub

    Private Sub RB_ProdRes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_Resumen.CheckedChanged
        CB_Turno.Text = "*"
        CB_Turno.Enabled = False
        TOrden.Text = "*"
        TOrden.Enabled = False
    End Sub

    Private Sub RB_Prod_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_Detalle.CheckedChanged
        CB_Turno.Text = "*"
        CB_Turno.Enabled = True
        TOrden.Text = "*"
        TOrden.Enabled = True
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub
#End Region

    Private Sub DGV1_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        oldRowIndex = DGV1.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            DGV1.RowsDefaultCellStyle.BackColor = Color.White
            DGV1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        End If
    End Sub


    Private Sub DGV1_CellFormatting_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV1.CellFormatting
        With DGV1
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        End With
    End Sub
End Class