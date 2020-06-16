Public Class Catalogo_Productos
    Shared Sub CB(ByVal CB As ComboBox, Area As Integer)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_ProductoTerminado '" & SessionUser._sCentro.Trim & "','','','','','','','','','','','','','','','','','','','','" & Area & "','','','','','','','','','','','',1"
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Producto"
        CB.ValueMember = "Codigo"
    End Sub
End Class
