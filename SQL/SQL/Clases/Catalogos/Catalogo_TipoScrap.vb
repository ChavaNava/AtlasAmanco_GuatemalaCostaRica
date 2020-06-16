Public Class Catalogo_TipoScrap
  
    Shared Sub TipoScrap(ByVal CB As ComboBox, Area As String, TipoProd As String, IdScrap As String, Operacion As Integer)
        Dim NDSTipoScrap As New DataSet
        Dim Q As String

        If TipoProd = "S" Then
            Q = ""
            Q = "PA_TipoScrap '" & SessionUser._sCentro.Trim & "','" & IdScrap.Trim & "','','','','" & Area & "', " & Operacion & " "
            Combo(Q)
            NDSTipoScrap = DataSetCombo.Copy
            CB.DataSource = NDSTipoScrap.Tables(0)
            CB.DisplayMember = "D_Scrap"
            CB.ValueMember = "C_Scrap"
            CB.Text = ""
        Else
            CB.DataSource = Nothing
            CB.Text = ""
        End If

    End Sub
End Class
