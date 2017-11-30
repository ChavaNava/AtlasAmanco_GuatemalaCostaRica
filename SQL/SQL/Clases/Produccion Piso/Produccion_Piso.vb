Imports System.Data.SqlClient
Imports Utili_Generales
Public Class Produccion_Piso
    Public Shared Sub Catalogo_Prod_Piso(Usuario As String, DataGV As DataGridView, Centro As String, ODP As String, C_Producto As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Produccion_Piso '" & Centro & "', '" & ODP & "', '" & C_Producto & "' "
        Try           
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Folio"
        DataGV.Columns(1).HeaderText = "Orden Producción"
        DataGV.Columns(2).HeaderText = "Código Producto"
        DataGV.Columns(3).HeaderText = "Fecha Hora Registro"
        DataGV.Columns(4).HeaderText = "Unidades"
        DataGV.Columns(5).HeaderText = "Cajas"
        DataGV.Columns(6).HeaderText = "Peso"
        DataGV.Columns(7).HeaderText = "Inyectora"
        DataGV.Columns(8).HeaderText = "Descripcion Inyectora"
        DataGV.Columns(9).HeaderText = "Usuario"
        DataGV.Columns(10).Visible = False      'Fecha Alta
        DataGV.Columns(11).Visible = False      'Usuario Alta
        DataGV.Columns(12).Visible = False      'Fecha Baja
        DataGV.Columns(13).Visible = False      'Usuario Baja
        DataGV.Columns(14).Visible = False      'Fecha Cambio
        DataGV.Columns(15).Visible = False      'Usuario Cambio
        DataGV.Columns(16).Visible = False      'Status Registro
    End Sub

    Public Shared Sub Actualiza_Registro(ByVal Usuario As String, ODP As String, Centro As String)
        Try
            LecturaQry("PA_Actualiza_Produccion_Piso_Registro '" & Centro.Trim & "', '" & ODP.Trim & "'   ")
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub Insert_Prod_Piso(ByVal Usuario As String, ODP As String, Centro As String, CodProd As String, Unidades As String, _
                                       Cajas As String, Peso As String, Equipobasico As String, DesProd As String)

        Try
            LecturaQry("PA_Insert_Produccion_Piso '" & ODP.Trim & "',  '" & Centro.Trim & "', '" & CodProd.Trim & "', " & Unidades & _
                  ", " & Cajas & ", " & Peso & ", '" & Equipobasico.Trim & "', '" & DesProd.Trim & "', '" & Usuario.Trim & "' ")
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try

    End Sub
End Class
