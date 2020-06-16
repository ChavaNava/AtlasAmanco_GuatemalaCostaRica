Imports System.Data.SqlClient
Public Class Catalogo_Perfiles
    Shared Sub Combo_Perfiles(ByVal CB As ComboBox, Centro As String, Usuario As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Perfiles '" & Centro.Trim & "', '' "
        Combo_ADM(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_Perfil"
        CB.ValueMember = "C_Perfil"
    End Sub

    Public Shared Sub Perfil(ByVal Centro As String, Usuario As String, Perfil As String, DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Perfiles '" & Centro.Trim & "', '" & Perfil.Trim & "' "
        Try
            objDa = New SqlDataAdapter(Q, Usuarios(SessionUser._sAlias))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DataGV.Columns(0).HeaderText = "Altas"
        DataGV.Columns(1).HeaderText = "Bajas"
        DataGV.Columns(2).HeaderText = "Modificación"
        DataGV.Columns(3).HeaderText = "Imprimir"
        DataGV.Columns(4).HeaderText = "Notificar"
        DataGV.Columns(5).HeaderText = "Autoriza Sobre/Bajo Peso"
    End Sub
End Class
