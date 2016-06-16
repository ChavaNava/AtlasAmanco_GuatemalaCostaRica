Imports System.Data.SqlClient
Imports SQL_DATA

Public Class CargaGrid
    'Public Shared Sub Catalogo_Causas(ByVal DataGV As DataGridView, Usuario As String, Centro As String, Codigo As String, Seccion As String)
    '    Dim Q As String
    '    Dim objDa As SqlDataAdapter
    '    Dim objDs As DataSet

    '    Q = ""
    '    Q = "PA_Consulta_Causas '" & Centro & "', '" & Codigo & "', '" & Seccion & "' "
    '    Try
    '        objDa = New SqlDataAdapter(Q, MSI(Usuario))
    '        objDs = New DataSet
    '        objDa.Fill(objDs)
    '        DataGV.DataSource = objDs.Tables(0)
    '    Catch ex As Exception
    '        MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
    '    End Try
    '    DataGV.Columns(0).HeaderText = "Centro"
    '    DataGV.Columns(1).HeaderText = "Codigo Causa"
    '    DataGV.Columns(2).HeaderText = "Descripción Causa"
    '    DataGV.Columns(3).HeaderText = "Tipo Causa"
    '    DataGV.Columns(4).HeaderText = "Descripción Tipo Causa"
    '    DataGV.Columns(5).HeaderText = "Código Area Producción"
    '    DataGV.Columns(6).HeaderText = "Descripción Area Producción"
    '    DataGV.Columns(7).Visible = False   'Status
    '    DataGV.Columns(8).HeaderText = "Fecha Alta"
    '    DataGV.Columns(9).HeaderText = "Usuario Alta"
    '    DataGV.Columns(10).HeaderText = "Fecha Baja"
    '    DataGV.Columns(11).HeaderText = "Usuario Baja"
    '    DataGV.Columns(12).HeaderText = "Fecha Cambio"
    '    DataGV.Columns(13).HeaderText = "Usuario Cambio"
    'End Sub
End Class
