Imports System.Data.SqlClient
Imports Utili_Generales
Public Class Consulta_Produccion_Extrusion
    Public Shared Function Prod_Notificar(ByVal DataGV As DataGridView, Usuario As String, Centro As String, Fec_Ini As String, _
                                          Fec_Fin As String, Seccion As String, ODF As String, Folio As String, GBNotif As GroupBox, _
                                          Lb1 As Label)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        Dim Contador As Integer = 0

        Q = ""
        Q = "PA_Consulta_Prod_Ext_Masiva '" & Centro & "', '" & Fec_Ini & "', '" & Fec_Fin & "', '" & Seccion & "', '" & ODF & "', '" & Folio & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
            Contador = objDs.Tables(0).Rows.Count
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Orden Produccion"
        DataGV.Columns(1).HeaderText = "Fecha Pesaje"
        DataGV.Columns(2).HeaderText = "Unidades"
        DataGV.Columns(3).HeaderText = "Folio"
        DataGV.Columns(4).HeaderText = "Peso Neto"
        DataGV.Columns(5).HeaderText = "Documento SAP"
        DataGV.Columns(6).HeaderText = "Consecutivo SAP"
        DataGV.Columns(7).HeaderText = "Status Notificación"
        DataGV.Columns(8).HeaderText = "Status Notificación Masiva"
        DataGV.Columns(9).HeaderText = "Producto Terminado"
        DataGV.Columns(10).Visible = False    'Compuesto Original
        DataGV.Columns(11).HeaderText = "Mensaje SAP"
        DataGV.Columns(12).Visible = False    'Usuario
        DataGV.Columns(13).HeaderText = "Compuestos"

        If Contador <= 0 Then
            MensajeBox.Mostrar("No existen registros a Notificar dentro del periodo seleccionado", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            Exit Function
        Else
            GBNotif.Enabled = True
            Lb1.Text = DataGV.RowCount
        End If

        Return Contador
    End Function
End Class
