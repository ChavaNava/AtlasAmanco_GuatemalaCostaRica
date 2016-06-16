Public Class Catalogo_Grupo_Materiales
    Shared Sub CB_Gpo_Mat(ByVal CB As ComboBox, Usuario As String, Centro As String, Codigo As String, Tipo As String, TCod As TextBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Gpo_Materiales_2 '" & Centro & "', '" & Codigo & "', '" & Tipo & "' "
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_Material"
        CB.ValueMember = "C_Material"
        TCod.Text = CB.SelectedValue
    End Sub
End Class
