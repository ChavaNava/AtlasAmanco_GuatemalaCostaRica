Public Class Catalogo_Scrap
    Shared Sub CB_Scrap(ByVal CB As ComboBox, Usuario As String, Centro As String, Area As String, TipoProd As String)
        If TipoProd = "S" Then
            Dim NDataSet1 As New DataSet
            Dim Q As String
            Q = ""
            Q = "PA_Consulta_Tipo_Scrap '" & Centro & "', '" & Area & "' "
            Combo(Q, Usuario)
            NDataSet1 = DataSetCombo.Copy
            CB.DataSource = NDataSet1.Tables(0)
            CB.DisplayMember = "Scrap"
            CB.ValueMember = "C_Scrap"
            CB.Text = ""
        Else
            CB.DataSource = Nothing
            CB.Text = ""
        End If
    
    End Sub
End Class
