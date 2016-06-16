Imports System.Data.SqlClient
Public Class Catalogo_Usuarios
    Public Shared Sub Catalogo_Usuarios(ByVal DataGV As DataGridView, Usuario As String, Centro As String, Codigo As String, Seccion As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Usuarios '" & Centro & "', '" & Seccion & "' "
        Try
            objDa = New SqlDataAdapter(Q, Usuarios())
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Alias"
        DataGV.Columns(1).HeaderText = "Contraseña"
        DataGV.Columns(2).HeaderText = "Nombre Usuario"
        DataGV.Columns(3).HeaderText = "Número Empleado"
        DataGV.Columns(4).HeaderText = "Código Perfil"
        DataGV.Columns(5).HeaderText = "Descripción Perfil"
        DataGV.Columns(6).HeaderText = "Correo Electronico"
        DataGV.Columns(7).HeaderText = "Telefono Fijo"
        DataGV.Columns(8).HeaderText = "Telefono Movil"
        DataGV.Columns(9).HeaderText = "Area"
        DataGV.Columns(10).HeaderText = "Descripción Area"
        DataGV.Columns(11).HeaderText = "Activo"
    End Sub
End Class
