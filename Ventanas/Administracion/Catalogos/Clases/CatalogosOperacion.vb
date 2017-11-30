Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class CatalogosOperacion
    Shared Sub CBEmpaque(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Empaque_Tipo '" & SessionUser._sCentro & "', '', 'S' "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "CD_Empaque"
        CB.ValueMember = "C_Empaque"
    End Sub

    Shared Sub CBReten(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Empaque_Tipo '" & SessionUser._sCentro & "', '', 'R' "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "CD_Empaque"
        CB.ValueMember = "C_Empaque"
    End Sub

    Shared Function Compuesto_Bom(ByVal IdPt As String) As Boolean
        LecturaQry("PA_Identifica_Compuesto_BOM '" & SessionUser._sCentro.Trim & "', '" & IdPt.Trim & "' ")
        If (LecturaBD.Read) Then
            CompuestoVirgen.IdCompOriginal = LecturaBD(0)
            Return True
        Else
            Return False
        End If
    End Function
End Class
