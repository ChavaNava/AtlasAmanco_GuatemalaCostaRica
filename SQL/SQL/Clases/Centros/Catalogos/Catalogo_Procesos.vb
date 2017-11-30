Public Class Catalogo_Procesos
    Shared Sub Combo_Procesos(ByVal CB As ComboBox, Centro As String, Usuario As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "Select * from CAT_Procesos "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Proceso"
        CB.ValueMember = "IdProceso"
    End Sub
End Class
