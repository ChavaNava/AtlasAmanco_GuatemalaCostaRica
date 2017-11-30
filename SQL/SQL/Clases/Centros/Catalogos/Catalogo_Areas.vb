Imports System.Data.SqlClient
Public Class Catalogo_Areas
    Shared Sub Combo_Areas(ByVal CB As ComboBox, Usuario As String, TxDescr As TextBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Areas " & 1 & " "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "C_Area"
        CB.ValueMember = "D_Area"
        TxDescr.Text = CB.SelectedValue
    End Sub

    Shared Sub Productivas(ByVal CB As ComboBox, Area As Integer)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_AreasProductivas '', " & Area & ", " & 1 & " "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Descripcion"
        CB.ValueMember = "grpprod"
    End Sub
End Class
