Public Class Catalogo_Familia_Producto
    Shared Sub CB_Tip_Comp(ByVal CB As ComboBox, Usuario As String, Centro As String, Codigo_Emp As String, TCod As TextBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Fam_Producto '" & Centro & "', '" & Codigo_Emp & "' "
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_TipoComp"
        CB.ValueMember = "C_TipoComp"
        TCod.Text = CB.SelectedValue
    End Sub
End Class
