Imports System.Data.SqlClient
Imports Utili_Generales
Imports System.Windows.Forms

Public Class Catalogo_Causas
#Region "Variables de miembro"

#End Region

#Region "Metodos"
    Public Shared Sub Catalogo_Causas(ByVal DataGV As DataGridView, Usuario As String, Centro As String, Codigo As String, Seccion As String, _
                                      TipoCausa As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Causas '" & Centro & "', '" & Codigo & "', '" & Seccion & "', '" & TipoCausa & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(Usuario))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Centro"
        DataGV.Columns(1).HeaderText = "Codigo Causa"
        DataGV.Columns(2).HeaderText = "Descripción Causa"
        DataGV.Columns(3).HeaderText = "Tipo Causa"
        DataGV.Columns(4).HeaderText = "Descripción Tipo Causa"
        DataGV.Columns(5).HeaderText = "Código Area Producción"
        DataGV.Columns(6).HeaderText = "Descripción Area Producción"
        DataGV.Columns(7).Visible = False   'Status
        DataGV.Columns(8).HeaderText = "Fecha Alta"
        DataGV.Columns(9).HeaderText = "Usuario Alta"
        DataGV.Columns(10).HeaderText = "Fecha Baja"
        DataGV.Columns(11).HeaderText = "Usuario Baja"
        DataGV.Columns(12).HeaderText = "Fecha Cambio"
        DataGV.Columns(13).HeaderText = "Usuario Cambio"
    End Sub

    Shared Sub Combo_Causas(ByVal CB As ComboBox, CodigoCausa As String, Area As String, TipoCausa As String, Estatus As Boolean)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        If Estatus = False Then
            CB.Text = ""
            Q = ""
            Q = "PA_Consulta_Causas '" & SessionUser._sCentro.Trim & "', '" & CodigoCausa.Trim & "', '" & Area.Trim & "', '" & TipoCausa.Trim & "' "
            Combo(Q, SessionUser._sAlias.Trim)
            NDataSet1 = DataSetCombo.Copy
            CB.DataSource = NDataSet1.Tables(0)
            CB.DisplayMember = "D_Causa"
            CB.ValueMember = "C_Causa"
        Else
            CB.DataSource = Nothing
            CB.Text = ""
        End If
    End Sub

#End Region

End Class
