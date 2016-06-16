Public Class Usr_DGV


#Region "Variables"
    Public Event CurrentCellChanged As EventHandler
    Public IdEstatus As Integer
#End Region

#Region "Eventos"
    Private Sub DGV1_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV1.CellFormatting
        Dim Estatus As Integer = (DGV1.Rows(e.RowIndex).Cells(IdEstatus).Value)

        If Estatus = 1 Then
            e.CellStyle.BackColor = Color.LightGreen
            e.CellStyle.ForeColor = Color.Black
        ElseIf Estatus = 0 Or Estatus = 4 Or Estatus = 3 Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Black
        ElseIf Estatus = 9 Then
            e.CellStyle.BackColor = Color.Red
            e.CellStyle.ForeColor = Color.White
        End If
    End Sub
#End Region

#Region "Metodos"

#End Region


    Private Sub DGV1_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DGV1.CurrentCellChanged
        RaiseEvent CurrentCellChanged(sender, e)
    End Sub

End Class
