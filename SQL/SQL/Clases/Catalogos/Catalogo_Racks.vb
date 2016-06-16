Imports System.Data.SqlClient
Imports Utili_Generales
Public Class Catalogo_Racks
    Shared Sub Combo_Rack(ByVal CB As ComboBox, Centro As String, Usuario As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Racks '" & SessionUser._sCentro.Trim & "' "
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "C_Rack"
        CB.ValueMember = "Peso"
    End Sub

    Public Shared Function Desc_Rack(ByVal Centro As String, Usuario As String, C_Rack As String)
        Dim Descripcion As String
        LecturaQry("PA_Consulta_Rack '" & Centro.Trim & "', " & C_Rack & "", Usuario)
        If (LecturaBD.Read) Then
            Descripcion = "" & LecturaBD(1)
        Else
            Descripcion = "Rack"
        End If
        LecturaBD.Close()

        Return Descripcion
    End Function

    Public Shared Sub Catalogo_Racks(ByVal Centro As String, C_Rack As String, Usuario As String, ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Catalogo_Racks '" & Centro.Trim & "', '" & C_Rack.Trim & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(Usuario))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DataGV.Columns(0).HeaderText = "Centro"
        DataGV.Columns(1).HeaderText = "Código Rack"
        DataGV.Columns(2).HeaderText = "Descripción Rack"
        DataGV.Columns(3).HeaderText = "Peso"
        DataGV.Columns(4).HeaderText = "Capacidad"
        DataGV.Columns(5).HeaderText = "Activo"
    End Sub

    Public Shared Function Valida_Existencia_Rack(ByVal Centro As String, Usuario As String, C_Rack As String)
        Dim Contador As Integer = 0
        LecturaQry("PA_Consulta_Rack '" & Centro.Trim & "', " & C_Rack & "", Usuario)
        If (LecturaBD.Read) Then
            Contador = Contador + 1
        Else
            Contador = Contador
        End If
        Return Contador
    End Function

    Public Shared Sub Insert_Rack(Usuario As String, Centro As String, Codigo As String, Desc As String, Peso As String)
        Try
            LecturaQry("PA_Insert_Rack '" & Centro.Trim & "', '" & Codigo.Trim & "', '" & Desc.Trim & "', '" & Peso & "'", Usuario)
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub Update_Rack(Usuario As String, Centro As String, Codigo As String, Desc As String, Peso As String, Activo As String)

        Dim FH_Update As String = DateTime.Now.ToString("yyyyMMdd hh:mm:ss")

        LecturaQry("PA_Actualiza_Rack '" & Centro.Trim & "', '" & Codigo.Trim & "', '" & Desc.Trim & "', '" & Peso & _
                   "' , '" & FH_Update & "', '" & Usuario & "'", Usuario)
    End Sub

    Public Shared Sub Baja_Rack(ByVal Usuario As String, Centro As String, Codigo As String, Activo As String)

        Dim FH_Update As String = DateTime.Now.ToString("yyyyMMdd hh:mm:ss")

        LecturaQry("PA_Baja_Rack '" & Centro.Trim & "', '" & Codigo.Trim & "',  '" & Activo.Trim & "', '" & FH_Update & "', '" & Usuario & "' ", Usuario)
    End Sub
End Class
