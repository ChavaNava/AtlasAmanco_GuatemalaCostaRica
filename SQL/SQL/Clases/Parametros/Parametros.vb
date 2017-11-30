Imports System.Data.SqlClient

Public Class Parametros
    Public Shared Sub Extrusion(ByVal DataGV As DataGridView, Operacion As Integer)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Parametrizacion '" & SessionUser._sIdCentro.Trim & "', '57', '', '', '','" & Operacion & "'"

        objDa = New SqlDataAdapter(Q, Usuarios(SessionUser._sAlias))
        objDs = New DataSet
        objDa.Fill(objDs)
        DataGV.DataSource = objDs.Tables(0)

        DataGV.Columns(0).Visible = False   'IdCentro
        DataGV.Columns(1).Visible = False   'IdPrograma
        DataGV.Columns(2).HeaderText = "Módulo"
        DataGV.Columns(3).Visible = False   'IdParametro
        DataGV.Columns(4).HeaderText = "Parametro"
        DataGV.Columns(5).HeaderText = "Estatus"
    End Sub
End Class
