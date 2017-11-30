Imports System.Data.SqlClient
Imports Utili_Generales
Public Class Elimina_Pesajes_Extrusion

    Public Shared Sub Consulta_PT_SC_Extrusion(ByVal Area As String, ByVal DataGV As DataGridView, _
                                               FI As String, FF As String, Orden As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Pesajes_Baja '" & SessionUser._sCentro.Trim & "', '" & Area.Trim & "', '" & FI.Trim & "', '" & FF.Trim & "', '" & Orden.Trim & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DataGV.Columns(0).HeaderText = "Folio"
        DataGV.Columns(1).HeaderText = "Orden de Producción"
        DataGV.Columns(2).HeaderText = "Producto"
        DataGV.Columns(3).HeaderText = "Producción"
        DataGV.Columns(4).HeaderText = "Fecha Pesaje"
        DataGV.Columns(5).HeaderText = "Bascula"
        DataGV.Columns(6).HeaderText = "Num. Rack"
        DataGV.Columns(7).HeaderText = "Peso Bruto"
        DataGV.Columns(8).HeaderText = "Peso Tara"
        DataGV.Columns(9).HeaderText = "Peso Neto"
        DataGV.Columns(10).HeaderText = "Tramos"
        DataGV.Columns(11).HeaderText = "Usuario"
        DataGV.Columns(12).HeaderText = "Turno"
        DataGV.Columns(13).HeaderText = "Docuemnto SAP"
        DataGV.Columns(14).HeaderText = "Consecutivo SAP"
        DataGV.Columns(15).HeaderText = "Sobre Peso"
        DataGV.Columns(16).HeaderText = "Puesto de Trabajo"
        DataGV.Columns(17).HeaderText = "Notificacion"
        DataGV.Columns(18).HeaderText = "Notificacion Masiva"
        DataGV.Columns(19).HeaderText = "Status Pesaje"
        DataGV.Columns(20).HeaderText = "Mensaje SAP"
        DataGV.Columns(21).HeaderText = "Area"

    End Sub

    Public Shared Sub Consulta_Movimientos_Baja(ByVal Usuario As String, Centro As String, Orden As String, Folio As String, Proceso As String, _
                                                ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Movimientos_Bajas '" & Centro.Trim & "', '" & Orden.Trim & "', '" & Folio.Trim & "' , '" & Proceso.Trim & "'"

        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DataGV.Columns(0).HeaderText = "Centro"
        DataGV.Columns(1).HeaderText = "Folio"
        DataGV.Columns(2).HeaderText = "Orden de Producción"
        DataGV.Columns(3).HeaderText = "Fecha Baja"
        DataGV.Columns(4).HeaderText = "Hora Baja"
        DataGV.Columns(5).HeaderText = "Documento SAP"
        DataGV.Columns(6).HeaderText = "Consecutivo SAP"
        DataGV.Columns(7).HeaderText = "Notifica"
        DataGV.Columns(8).HeaderText = "Masiva"
        DataGV.Columns(9).HeaderText = "Usuario"
        DataGV.Columns(10).HeaderText = "Observaciones"
        DataGV.Columns(11).HeaderText = "Status Pesaje"
        DataGV.Columns(12).HeaderText = "Area"
        DataGV.Columns(13).HeaderText = "Proceso"

    End Sub
End Class
