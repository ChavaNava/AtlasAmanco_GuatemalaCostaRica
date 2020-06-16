Public Class Catalogo_Grupo_Materiales
    Shared Sub CB_Gpo_Mat(ByVal CB As ComboBox, Usuario As String, Centro As String, Codigo As String, Tipo As String, TCod As TextBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Gpo_Materiales_2 '" & Centro & "', '" & Codigo & "', '" & Tipo & "' "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_Material"
        CB.ValueMember = "C_Material"
        TCod.Text = CB.SelectedValue
    End Sub

    Shared Sub CB(ByVal CB As ComboBox, Area As Integer)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_GrupoMateriales '','" & SessionUser._sCentro.Trim & "','','','" & Area & "','','','',1"
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "GrupoMat"
        CB.ValueMember = "C_Material"
    End Sub
End Class
