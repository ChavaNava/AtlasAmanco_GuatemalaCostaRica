Imports System.Data.SqlClient
Public Class Sobrepesos
    Public Shared Sub Query(ByVal DataGV As DataGridView, Centro As String, Usuario As String, FI As String, FF As String, Orden As String, Seccion As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Sobre_Pesos " & Centro & "_OrdenProduccion, " & Centro & "_PesoProductoTerminado, " & Centro & "_Sobrepesos, '" & FI & "', '" & FF & "', '" & Orden.Trim & "', '" & Seccion.Trim & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "")
        End Try

        DataGV.Columns(0).HeaderText = "OrdenProduccióm"
        DataGV.Columns(1).HeaderText = "Folio Pesaje"
        DataGV.Columns(2).HeaderText = "Producto"
        DataGV.Columns(3).HeaderText = "Fecha Pesaje"
        DataGV.Columns(4).HeaderText = "Peso Neto"
        DataGV.Columns(5).HeaderText = "Tramos"
        DataGV.Columns(6).HeaderText = "Peso Teorico"
        DataGV.Columns(7).HeaderText = "Sobre Peso"
        DataGV.Columns(8).HeaderText = "% Sobre Peso"
        DataGV.Columns(9).Visible = False  'Peso Teorico"
        DataGV.Columns(10).HeaderText = "Código Sobre Peso"
        DataGV.Columns(11).HeaderText = "Causa Sobre Peso"
        DataGV.Columns(12).HeaderText = "Autorizo"
        DataGV.Columns(13).HeaderText = "Observaciones"

    End Sub

    Public Shared Sub Email()
        LecturaQry_ADM("PA_AvisoSobrePeso '" & EmailSBP._Orden & "', '" & EmailSBP._Producto & "', '" & EmailSBP._FolioAtlas & "', '" & EmailSBP._Justifica & "','" & EmailSBP._FH & "', '" & EmailSBP._PB & "', '" & EmailSBP._PT & "', '" & EmailSBP._PN & "', '" & EmailSBP._SBPKilos & "', '" & EmailSBP._SBPPorcentaje & "', '" & EmailSBP._Centro & "', '" & EmailSBP._IdAccion & "'", SessionUser._sAlias)
    End Sub
End Class
