Public Class Catalogo_Defectos
    Shared Sub Combo_Defectos(ByVal CB As ComboBox, Centro As String, Usuario As String, CodigoCausa As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Defectos_2 '" & Centro.Trim & "', '" & CodigoCausa.Trim & "' "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Defecto"
        CB.ValueMember = "C_Defecto"
    End Sub
End Class
