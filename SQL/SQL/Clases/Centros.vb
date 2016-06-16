Public Class Centros
    Public Shared Sub CB_Centros(ByVal CB As ComboBox, Usuario As String, Pass As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_MultiCentros '" & Usuario.Trim & "', '" & Pass.Trim & "' "
        Combo_ADM(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Centro"
        CB.ValueMember = "Centro"
        CB.Text = ""
    End Sub
End Class
