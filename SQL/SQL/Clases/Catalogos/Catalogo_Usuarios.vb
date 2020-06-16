Imports System.Data.SqlClient
Public Class Catalogo_Usuarios
    Public Shared Sub Consulta(ByVal DataGV As DataGridView, Usuario As String, Codigo As String, Seccion As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Usuarios '" & SessionUser._sCentro & "', '" & Seccion & "' "
        Try
            objDa = New SqlDataAdapter(Q, Usuarios(SessionUser._sAlias))
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

    Public Shared Sub CB(ByVal CB As ComboBox, Operacion As Integer)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Usuarios '" & SessionUser._sCentro & "','','','','','','','','','','','','','','','','','','','','','','',''," & Operacion & " "
        Combo_ADM(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Nombre"
        CB.ValueMember = "IdUsuario"
        CB.Text = ""
    End Sub

    Public Shared Sub Email(ByVal Operacion As Integer)
        LecturaQry_ADM("PA_Usuarios '', '" & Accionesabc._IdUsuario.Trim & "', '','','','','','','','','','','','','','','','','','','','','',''," & Operacion & " ", SessionUser._sAlias)

        Do While (LecturaBD_ADM.Read)
            AccionCatalog.Email = LecturaBD_ADM(0)
        Loop
    End Sub
End Class
