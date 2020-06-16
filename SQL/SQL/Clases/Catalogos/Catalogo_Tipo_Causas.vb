Imports System.Data.SqlClient
Public Class Catalogo_Tipo_Causas
    Shared Sub Combo_Tipo_Causas(ByVal CB As ComboBox, Centro As String, Usuario As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "Select * from CAT_Tipo_Causas "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_TipoCausa"
        CB.ValueMember = "C_TipoCausa"
    End Sub
End Class
