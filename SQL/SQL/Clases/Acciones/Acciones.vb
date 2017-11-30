Imports System.Data.SqlClient

Public Class Acciones
    Public Shared Sub QueryRecords(ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Acciones '" & SessionUser._sCentro.Trim & "', '" & AccionQuery._IdAccion & "', '" & AccionQuery._Descripcion & "', '" & AccionQuery._Activo & "', '" & AccionQuery._Operacion & "'"

        objDa = New SqlDataAdapter(Q, Usuarios(SessionUser._sAlias))
        objDs = New DataSet
        objDa.Fill(objDs)
        DataGV.DataSource = objDs.Tables(0)

        DataGV.Columns(0).HeaderText = "Id Acción"
        DataGV.Columns(1).HeaderText = "Descripción"
        DataGV.Columns(2).Visible = False   'IdUsuario
        DataGV.Columns(3).HeaderText = "Usuario"
        DataGV.Columns(4).HeaderText = "Nombre"
        DataGV.Columns(5).HeaderText = "Correo"

    End Sub

    Public Shared Sub abc(ByVal Operacion As Integer)
        LecturaQry_ADM("PA_AccionesUsuarios '', '" & SessionUser._sIdCentro.Trim & "', '" & Accionesabc._IdAccion.Trim & "', '" & Accionesabc._IdUsuario.Trim & "',  " & Operacion & "", SessionUser._sAlias)
    End Sub
End Class
