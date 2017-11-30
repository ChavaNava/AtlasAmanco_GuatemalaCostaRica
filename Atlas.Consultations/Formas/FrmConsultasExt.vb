Imports Utili_Generales
Imports Reporting
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Imports System.Drawing
Imports System.Windows.Forms


Public Class FrmConsultasExt
#Region "Variables Miembro"
    Dim Str_FI As String        'Fecha inicio consulta
    Dim Str_FF As String        'Fecha fin consulta
    Dim N_Folio As String       'Numero de Folio
    Dim N_Ord As String         'Numero de Orden de Producción
    Dim N_Prod As String        'Numero de producto
    Dim N_Tramos As String      'Cantidad de tramos a notificar
    Dim N_PN As String          'Peso Neto
    Dim N_Status As String      'Status de notificación
    Dim N_TipoProd As String    'Tipo Produccion 1=PT, 2=SC
    Dim N_DocSAP As String      'Documento SAP
    Dim N_FolioSAP As String    'Consecutivo SAP
    Dim Status_Not As String
#End Region

#Region "Eventos"
    Private Sub FrmConsultas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Btn_Imprimir.Enabled = False
        Btn_Notif.Enabled = False
        Me.Icon = Util.ApplicationIcon()
        Grid_Load()
    End Sub

    Private Sub DGV_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        If SessionUser._sCentro.Trim = "PE01" Or SessionUser._sCentro.Trim = "PE12" Then
            Status_Not = (DGV.Rows(e.RowIndex).Cells(22).Value)
        Else
            Status_Not = (DGV.Rows(e.RowIndex).Cells(20).Value)
        End If


        If Status_Not = "1" Or Status_Not = "5" Then
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

    Private Sub DGV_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DGV.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                If SessionUser._sCentro.Trim = "PE01" Or SessionUser._sCentro.Trim = "PE12" Then
                    N_Folio = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(0).Value.ToString
                    N_Ord = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(2).Value.ToString
                    N_Prod = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(3).Value.ToString
                    N_Tramos = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(9).Value.ToString
                    N_PN = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(13).Value.ToString
                    N_DocSAP = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(18).Value.ToString
                    N_FolioSAP = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(19).Value.ToString
                    N_Status = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(22).Value.ToString
                    TMensajes.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(23).Value.ToString
                    N_TipoProd = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(24).Value.ToString
                Else
                    N_Folio = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(0).Value.ToString
                    N_Ord = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(2).Value.ToString
                    N_Prod = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(3).Value.ToString
                    N_Tramos = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(7).Value.ToString
                    N_PN = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(11).Value.ToString
                    N_DocSAP = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(16).Value.ToString
                    N_FolioSAP = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(17).Value.ToString
                    N_Status = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(20).Value.ToString
                    TMensajes.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(21).Value.ToString
                    N_TipoProd = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(22).Value.ToString
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            TOrden.Text = N_Ord
            TTramos.Text = N_Tramos
            TPN.Text = N_PN

            Btn_Imprimir.Enabled = True

            If N_Status = "0" Then
                Btn_Notif.Enabled = True
            Else
                Btn_Notif.Enabled = False
            End If

        End If
    End Sub

    Private Sub Btn_Cerrar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Cerrar.Click
        Close()
    End Sub

    Private Sub Btn_Consulta_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Consulta.Click
        Grid_Load()
    End Sub

    Private Sub Btn_Export_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Export.Click
        Util.ExportaExcel(DGV)
    End Sub

    Private Sub Btn_Imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Imprimir.Click
        If Seccion = "E" Then
            If SessionUser._sCentro.Trim = "A022" Then
                If N_TipoProd.Trim = "1" Then
                    Reportes.Boleta_Pesaje_PTE_Ext(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, N_Folio.Trim, N_Status.Trim)
                ElseIf N_TipoProd.Trim = "2" Then
                    Reportes.Boleta_Pesaje_SCE_Ext(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, N_Folio.Trim, N_Status.Trim)
                End If
            Else
                If N_TipoProd.Trim = "1" Then
                    Reportes.Boleta_Pesaje_PTE_Ext(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, N_Folio.Trim, N_Status.Trim)
                ElseIf N_TipoProd.Trim = "2" Then
                    Reportes.Boleta_Pesaje_SCE_Ext(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, N_Folio.Trim, N_Status.Trim)
                End If
            End If
        End If

        If Seccion = "I" Then
            If N_TipoProd.Trim = "1" Then
                Reportes.Boleta_Pesaje_PTE_Iny(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, N_Folio.Trim, N_Status.Trim)
            ElseIf N_TipoProd.Trim = "2" Then
                Reportes.Boleta_Pesaje_SCE_Iny(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, N_Folio.Trim, N_Status.Trim)
            End If
        End If


    End Sub
#End Region

#Region "Metodos"
    Public Sub Grid_Load()
        LoadingForm.ShowLoading()
        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim
        Try
            'DBG.Pesajes_PT_SC(Str_FI, Str_FF, DGV, Seccion, TProdKilos, TProdUnidades, TProcKilos, TProcUnidades, TSobPesoKilos, TSobPesoPorc, TScrapKilos, _
            '              TScrapPorc, TScrapPurKilos, TScrapPurPorc, TProg, TEnt, TProc, TPend, TOrdProd.Text.Trim)
            LoadingForm.CloseForm()
        Catch ex As Exception
            LoadingForm.CloseForm()
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
        End Try
    End Sub
#End Region

    Private Sub Btn_Elimina_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Elimina.Click
        'Reversa de Pesajes ------------------------------------
        Dim Head_Delete As String
        Head_Delete = "74|CO1" + N_DocSAP + "|" + N_FolioSAP
    End Sub
End Class