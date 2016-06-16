Imports System.Data.SqlClient
Imports Utili_Generales
Imports System.Windows.Forms

Public Class Catalogo_Material_Compuesto
    Shared Sub Combo_Mat_Comp(ByVal CB As ComboBox, Usuario As String, Centro As String, EXTINY As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Mat_Comp '" & Centro.Trim & "', '" & EXTINY & "' "
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "CodCompuesto"
        CB.ValueMember = "C_Compuesto"
    End Sub
    Public Shared Sub Catalogo_Materiales_Compuesto(ByVal DataGV As DataGridView, Centro As String, C_Producto As String, Usuario As String, EXTINY As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Material_Compuestos '" & Centro.Trim & "', '" & C_Producto.Trim & "', '" & EXTINY & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(Usuario))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Codigo Compuesto"
        DataGV.Columns(1).HeaderText = "Descripción Compuesto"
        DataGV.Columns(2).HeaderText = "Clase"
        DataGV.Columns(3).HeaderText = "Tipo"
        DataGV.Columns(4).HeaderText = "Bom"
        DataGV.Columns(5).HeaderText = "Código Reprocesado Generado"
        DataGV.Columns(6).Visible = False    'Estatus
    End Sub

    Public Shared Sub Insert_Compuesto_Consumo(ByVal Usuario As String, Centro As String, C_Material As String, C_Compuesto As String, Clase As String, Tipo As String, Bom As String)
        Try
            LecturaQry("PA_Insert_Compuesto_Consumo '" & Centro.Trim & "', '" & C_Material.Trim & "', '" & C_Compuesto.Trim & "', '" & Usuario.Trim & "', '" & Clase.Trim & "', '" & Tipo.Trim & "', '" & Bom.Trim & "' ", Usuario)
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub Actualiza_Compuesto_Consumo(ByVal Usuario As String, Centro As String, C_Material As String, C_Compuesto As String, Bom As String)
        Try
            LecturaQry("PA_Actualiza_Compuesto_Consumo '" & Centro.Trim & "', '" & C_Material.Trim & "', '" & C_Compuesto.Trim & "', '" & Usuario.Trim & "', '" & Bom.Trim & "' ", Usuario)
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try
    End Sub

    Public Shared Function Consulta_Compuesto(ByVal Usuario As String, Centro As String, Compuesto As String)
        Dim C_Centro As String
        Dim C_Compuesto As String
        Dim C_Clase As String
        Dim C_Tipo As String
        Dim C_Activo As String

        LecturaQry("PA_Consulta_Compuesto_Asignar '" & Centro.Trim & "', '" & Compuesto.Trim & "' ", Usuario)
        If (LecturaBD.Read) Then
            C_Centro = "" & LecturaBD(0)
            C_Compuesto = "" & LecturaBD(1)
            C_Clase = "" & LecturaBD(2)
            C_Tipo = "" & LecturaBD(3)
            C_Activo = "" & LecturaBD(4)
        End If
        LecturaBD.Close()

        Return C_Compuesto & "|" & C_Clase & "|" & C_Tipo & "|" & C_Activo

    End Function

End Class
