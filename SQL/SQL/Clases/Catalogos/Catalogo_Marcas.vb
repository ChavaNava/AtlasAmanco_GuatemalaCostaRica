Public Class Catalogo_Marcas
    Shared Sub CB_Marcas(ByVal CB As ComboBox, Usuario As String, TCod As TextBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Marcas"
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Marca"
        CB.ValueMember = "IdMarca"
        TCod.Text = CB.SelectedValue
    End Sub
End Class
