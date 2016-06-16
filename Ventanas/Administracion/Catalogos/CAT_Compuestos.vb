Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class CAT_Compuestos
    Inherits Atlas.Master_Cat
#Region "Variables de Miembro"
    Dim C_Status As String
#End Region

#Region "Eventos"
    Private Sub Compuestos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        FrontUtils.LimpiarText(Me)
        FrontUtils.BloquearText(Me)
        FrontUtils.LimpiarComboBox(Me)
        FrontUtils.BloquearComboBox(Me)
        Btn_Guardar.Enabled = False
        CargaGrid()
    End Sub

    Private Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nuevo.Click
        Accion = "Alta"
        FrontUtils.LimpiarText(Me)
        FrontUtils.ActivaText(Me)
        FrontUtils.LimpiarComboBox(Me)
        FrontUtils.ActivaCombo(Me)
        Btn_Guardar.Enabled = True
        Catalogo_Compuestos.CB_Tipo(CB_Area, SessionUser._sAlias)
        Catalogo_Compuestos.CB_Clase(CB_Clase, SessionUser._sAlias)
    End Sub

    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        CargaGrid()
    End Sub

    Private Sub DGV_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DGV.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then
            Try
                Dim Fila_Seleccionada As Integer = DGV.CurrentCell.RowIndex
                TCodProd.Text = DGV.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                TDesProd.Text = DGV.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                CB_Clase.Text = DGV.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                CB_Area.Text = DGV.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                C_Status = DGV.Rows(Fila_Seleccionada).Cells(4).Value.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub DGV_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            ControlDataGridView.DGV_Formating(DGV, 4, e)
        End If
    End Sub
#End Region

#Region "Metodos"

    Private Sub CargaGrid()
        Catalogo_Compuestos.Catalogo_Compuestos(DGV, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, EXTINY)
    End Sub
#End Region

    Private Sub CB_Area_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Area.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

End Class