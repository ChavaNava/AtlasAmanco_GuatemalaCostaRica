Public Class Catalogo_UM
    Shared Sub CB_UM(ByVal CB As ComboBox, Usuario As String, TCod As TextBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_UM"
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_UM"
        CB.ValueMember = "C_UM"
        TCod.Text = CB.SelectedValue
    End Sub
End Class
