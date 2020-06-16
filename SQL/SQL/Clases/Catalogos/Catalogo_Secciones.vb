Public Class Catalogo_Secciones
    Shared Sub CB_Secc(ByVal CB As ComboBox, Usuario As String, Centro As String, Codigo_Emp As String, TCod As TextBox, C_Tipo As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Secciones_2 '" & Centro & "', '" & Codigo_Emp & "', '" & C_Tipo & "' "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_Seccion"
        CB.ValueMember = "C_Seccion"
        TCod.Text = CB.SelectedValue
    End Sub

    Shared Sub CB(ByVal CB As ComboBox, Area As Integer)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Secciones '" & Area & "', " & 1 & " "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Descripcion"
        CB.ValueMember = "CodSeccion"
    End Sub

End Class
