Public Class Catalogo_TipoScrap
    Shared Sub CBTipoScrap(ByVal CB As ComboBox, Area As String, TipoProd As String, IdScrap As String)
        If TipoProd = "S" Then
            Dim NDataSet1 As New DataSet
            Dim Q As String
            Q = ""
            Q = "PA_TipoScrap '" & SessionUser._sCentro.Trim & "','" & IdScrap.Trim & "','','','','" & Area & "',1 "
            Combo(Q)
            NDataSet1 = DataSetCombo.Copy
            CB.DataSource = NDataSet1.Tables(0)
            CB.DisplayMember = "D_Scrap"
            CB.ValueMember = "C_Scrap"
            CB.Text = ""
        Else
            CB.DataSource = Nothing
            CB.Text = ""
        End If

    End Sub
End Class
