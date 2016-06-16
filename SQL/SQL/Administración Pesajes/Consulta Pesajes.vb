Imports SQL_DATA
Imports System.Data.SqlClient
Imports Utili_Generales
Public Class Consulta_Pesajes
    Public Shared Sub Pesajes(ByVal DataGV As DataGridView, Usuario As String, Centro As String, FI As String, FF As String, ODF As String, _
                              Folio As String, Turno As String, Area As String)
        Dim Q As String
        Dim RegCount As Integer
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Produccion_1 '" & Centro & "', '" & FI & "', '" & FF & "', '" & ODF & "', '" & Folio & "', '" & Turno & "', '" & Area & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(Usuario))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
            RegCount = DataGV.RowCount

            If RegCount <= 0 Then
                MensajeBox.Mostrar("La consulta no encontro resultados dentro de las fechas y filtros establecidos.", "Consulta", MensajeBox.TipoMensaje.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
    End Sub
End Class
