Public Class Catalogo_Empaques
    Shared Sub CB_Empaques(ByVal CB As ComboBox, Usuario As String, Centro As String, Codigo_Emp As String, Tipo_Emp As String, Estatus As Boolean, TCod As TextBox)
        If Estatus = True Then
            Dim NDataSet1 As New DataSet
            Dim Q As String
            Q = ""
            Q = "PA_Consulta_Empaque_Tipo '" & Centro & "', '" & Codigo_Emp & "', '" & Tipo_Emp & "' "
            Combo(Q)
            NDataSet1 = DataSetCombo.Copy
            CB.DataSource = NDataSet1.Tables(0)
            CB.DisplayMember = "CD_Empaque"
            CB.ValueMember = "C_Empaque"
            ''TCod.Text = CB.SelectedValue
        Else
            TCod.Text = "0"
        End If
    End Sub
End Class
