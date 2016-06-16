Public Class Catalogo_Grupos
    Shared Sub CB_Grupos(ByVal CB As ComboBox, Usuario As String, Centro As String, Codigo As String, TCod As TextBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Grupos '" & Centro & "', '" & Codigo & "'"
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_Grupo"
        CB.ValueMember = "C_Grupo"
        TCod.Text = CB.SelectedValue
    End Sub
End Class
