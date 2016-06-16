Imports System.Data.SqlClient
Public Class Catalogo_Areas
    Shared Sub Combo_Areas(ByVal CB As ComboBox, Usuario As String, TxDescr As TextBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Areas " & 1 & " "
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "C_Area"
        CB.ValueMember = "D_Area"
        TxDescr.Text = CB.SelectedValue
    End Sub
End Class
