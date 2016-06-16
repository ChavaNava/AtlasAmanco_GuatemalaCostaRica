Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class CAT_Causas
    Inherits Atlas.Master_Cat
#Region "Variables de Miembro"
    Dim C_Status As Boolean
#End Region

#Region "Eventos"

    Private Sub CAT_Causas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Btn_Elimina.Enabled = True
        FrontUtils.BloquearText(Me)
        FrontUtils.BloquearComboBox(Me)
        TCodCausa.Enabled = True
        TCodCausa.Focus()
    End Sub

    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        SQL_DATA.Catalogo_Causas.Catalogo_Causas(DGV, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TCodCausa.Text.Trim, Seccion.Trim, "")
    End Sub

    Private Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nuevo.Click
        Btn_Guardar.Enabled = True
        FrontUtils.ActivaText(Me)
        FrontUtils.LimpiarText(Me)
        FrontUtils.ActivaCombo(Me)
        Catalogo_Tipo_Causas.Combo_Tipo_Causas(CB_Tipo, SessionUser._sCentro, SessionUser._sAlias)
        Catalogo_Procesos.Combo_Procesos(CB_Procesos, SessionUser._sCentro, SessionUser._sAlias)

    End Sub

    Private Sub DGV_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            C_Status = (DGV.Rows(e.RowIndex).Cells(7).Value)
            If C_Status = True Then
                e.CellStyle.BackColor = Color.LightGreen
                e.CellStyle.ForeColor = Color.Black
            ElseIf C_Status = False Then
                e.CellStyle.BackColor = Color.LightCyan
                e.CellStyle.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub DGV_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DGV.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Try
                Dim Fila_Seleccionada As Integer = DGV.CurrentCell.RowIndex
                TCodCausa.Text = DGV.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                TDesCausa.Text = DGV.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                CB_Tipo.Text = DGV.Rows(Fila_Seleccionada).Cells(3).Value.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub
#End Region

#Region "Metodos"

#End Region


End Class