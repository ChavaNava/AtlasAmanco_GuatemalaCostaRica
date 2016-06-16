Public Class Catalogo_Uso_Maquina
    Shared Sub CB_Uso_Maq(ByVal CB As ComboBox, Usuario As String, Centro As String, Codigo As String, TCod As TextBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Uso_Maquina '" & Centro & "', '" & Codigo & "'"
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_UsoMaq"
        CB.ValueMember = "C_UsoMaq"
        TCod.Text = CB.SelectedValue
    End Sub
End Class
