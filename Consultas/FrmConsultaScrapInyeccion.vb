Imports SQL_DATA
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmConsultaScrapInyeccion

#Region "Variables Miembro"
    Dim Str_FI As String        'Fecha inicio consulta
    Dim Str_FF As String        'Fecha fin consulta
#End Region

#Region "Eventos"


    Private Sub FrmConsultaScrapInyeccion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Grid_Load()
    End Sub

    Private Sub BtnConsultas_Click(sender As System.Object, e As System.EventArgs) Handles BtnConsultas.Click
        Grid_Load()
    End Sub

    Private Sub Btn_Consulta_Click(sender As System.Object, e As System.EventArgs)
        Grid_Load()
    End Sub

    Private Sub Btn_Cerrar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Cerrar.Click
        Close()
    End Sub

    Private Sub DGV1_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV1.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = DGV1.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            ControlDataGridView.DGV_Formating_Estandar(DGV1)
        End If
    End Sub

    Private Sub DGV_Resumen_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV_Resumen.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = DGV1.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            ControlDataGridView.DGV_Formating_Estandar(DGV_Resumen)
        End If
    End Sub

    Private Sub Btn_Export_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Export.Click
        Util.ExportaExcel(DGV1)
    End Sub
#End Region

#Region "Metodos"
    Public Sub Grid_Load()
        'Str_FI = DTP_FI.Text.Trim
        'Str_FF = DTP_FF.Text.Trim

        'If RB1.Checked Then
        '    Inyeccion.Scrap_Detalle(DGV1, Str_FI, Str_FF, SessionUser._sAlias.Trim)
        'End If

        'If RB2.Checked Then
        '    Inyeccion.Scrap_Detalle(DGV1, Str_FI, Str_FF, SessionUser._sAlias.Trim)
        'End If

        'Inyeccion.Scrap_Resumen_X_Tipo(DGV_Resumen, Str_FI, Str_FF, SessionUser._sAlias.Trim)

    End Sub
#End Region

End Class