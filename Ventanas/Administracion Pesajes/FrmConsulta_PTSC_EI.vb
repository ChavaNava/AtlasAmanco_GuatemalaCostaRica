Imports SQL_DATA
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales

Public Class FrmConsulta_PTSC_EI
#Region "Variables de Miembro"
    Dim Str_FI As String    'Fecha inicio consulta
    Dim Str_FF As String    'Fecha fin consulta
    'Variables Consulta
    Dim C_Folio As String
    Dim C_OrdenProd As String
    Dim C_Producto As String
    Dim C_Proceso As String
    Dim C_Fec_Pesaje As String
    Dim C_Bascula As String
    Dim C_Rack As String
    Dim C_PBruto As String
    Dim C_PTara As String
    Dim C_PNeto As String
    Dim C_Tramos As String
    Dim C_Usr As String
    Dim C_Turno As String
    Dim C_DocSAP As String
    Dim C_NumSAP As String
    Dim C_Sp As String
    Dim C_Maquina As String
    Dim Status_Not As String
    Dim Status_Not_Mas As String
    Dim Status_Pesaje As String
    Dim C_Area As String
#End Region

#Region "Eventos"

    Private Sub CerrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub

    Public Sub BConsulta_Click(sender As System.Object, e As System.EventArgs) Handles BConsulta.Click
        Grid()
    End Sub

    Private Sub FrmConsulta_PTSC_EI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Grid()
    End Sub

    Private Sub DGV1_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV1.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = DGV1.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            ControlDataGridView.DGV_Formating_Produccion(DGV1, 17, e)
        End If
    End Sub

    Private Sub BtnDel_Click(sender As System.Object, e As System.EventArgs) Handles BtnDel.Click
        Baja_FI = DTP_FI.Text.Trim
        Baja_FF = DTP_FF.Text.Trim
        Baja_Folio = C_Folio
        Baja_Orden = C_OrdenProd
        Baja_Proceso = C_Proceso
        Baja_DocSap = C_DocSAP
        Baja_NumSap = C_NumSAP
        Baja_Notifica = Status_Not
        Baja_Masiva = Status_Not_Mas
        Baja_St_Pesaje = Status_Pesaje
        DGV = DGV1
        Permiso.Accesos("MA_BAJA_PESAJE", "1", SessionUser._sIdPerfil, "E", "Eliminar registros pesajes de ")
    End Sub

    Private Sub DGV1_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DGV1.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV1.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                C_Folio = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(0).Value.ToString
                C_OrdenProd = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(1).Value.ToString
                C_Producto = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(2).Value.ToString
                C_Proceso = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(3).Value.ToString
                C_Fec_Pesaje = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(4).Value.ToString
                C_Bascula = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(5).Value.ToString
                C_Rack = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(6).Value.ToString
                C_PBruto = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(7).Value.ToString
                C_PTara = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(8).Value.ToString
                C_PNeto = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(9).Value.ToString
                C_Tramos = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(10).Value.ToString
                C_Usr = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(11).Value.ToString
                C_Turno = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(12).Value.ToString
                C_DocSAP = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(13).Value.ToString
                C_NumSAP = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(14).Value.ToString
                C_Sp = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(15).Value.ToString
                C_Maquina = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(16).Value.ToString
                Status_Not = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(17).Value.ToString
                Status_Not_Mas = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(18).Value.ToString
                Status_Pesaje = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(19).Value.ToString
                C_Area = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(21).Value.ToString

                Elimina_Pesajes_Extrusion.Consulta_Movimientos_Baja(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, C_OrdenProd, C_Folio, C_Proceso, DGV2)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

        End If
    End Sub

#End Region

#Region "Metodos"

    Public Sub Grid()
        Str_FI = DTP_FI.Value.ToString("yyyy-MM-dd")
        Str_FF = DTP_FF.Value.ToString("yyyy-MM-dd")

        Elimina_Pesajes_Extrusion.Consulta_PT_SC_Extrusion(SessionUser._sCentro.Trim, Seccion.Trim, SessionUser._sAlias.Trim, DGV1, Str_FI, Str_FF, TOrden.Text.Trim)

    End Sub

#End Region
 
End Class