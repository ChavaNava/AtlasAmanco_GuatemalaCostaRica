Public Class Conexion
    Public Shared Function SAP(ByVal Modulo As String) As Boolean
        Return False
        LecturaQry_ADM("PA_VerificaConexionSAP '" & SessionUser._sCentro.Trim & "', '" & Modulo & "' ", SessionUser._sAlias)
        If (LecturaBD_ADM.Read) Then
            Return True
        End If
        LecturaBD_ADM.Close()
    End Function

    Public Shared Sub CB_Estatus(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String

        Q = ""
        Q = "PA_Estatus_SAP"
        Combo_ADM(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        If NDataSet1.Tables(0).Rows.Count > 0 Then
            CB.DisplayMember = "Descripcion"
            CB.ValueMember = "Estatus"
            CB.Text = ""
            'CB.SelectedValue = Nullable
        End If
    End Sub

   
End Class
