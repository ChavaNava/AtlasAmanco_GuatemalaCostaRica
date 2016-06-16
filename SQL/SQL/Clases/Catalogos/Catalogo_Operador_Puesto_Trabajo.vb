Public Class Catalogo_Operador_Puesto_Trabajo
    Shared Sub CB_Operador_Linea(ByVal CB As ComboBox, TipoProd As String)
        If TipoProd = "T" Then
            Dim NDataSet1 As New DataSet
            Dim Q As String
            Q = ""
            Q = "PA_Consulta_Operadores_Linea '" & SessionUser.sCentro & "' "
            Combo_ADM(Q)
            NDataSet1 = DataSetCombo.Copy
            CB.DataSource = NDataSet1.Tables(0)
            CB.DisplayMember = "nombre"
            CB.ValueMember = "usuario"
            CB.Text = ""
        Else
            CB.DataSource = Nothing
            CB.Text = ""
        End If
    End Sub
End Class
