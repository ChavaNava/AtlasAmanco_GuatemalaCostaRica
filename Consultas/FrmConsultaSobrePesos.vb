Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmConsultaSobrePesos

#Region "Variables Miembro"
    Dim Str_FI As String        'Fecha inicio consulta
    Dim Str_FF As String        'Fecha fin consulta
#End Region

#Region "Eventos"
    Private Sub FrmConsultaSobrePesos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Grid_Load()
    End Sub

    Private Sub Btn_Consulta_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Consulta.Click
        Grid_Load()
    End Sub

    Private Sub Btn_Export_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Export.Click
        Util.ExportaExcel(DGV)
    End Sub
#End Region

#Region "Metodos"
    Public Sub Grid_Load()
        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim

        SQL_DATA.Sobrepesos.Query(DGV, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, Str_FI, Str_FF, TOrdProd.Text.Trim, Seccion)

    End Sub
#End Region

    Private Sub DGV_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        With DGV
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        End With
    End Sub
End Class