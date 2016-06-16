Imports System.Data.SqlClient
Imports Utili_Generales
Imports System.Windows.Forms

Public Class Catalogo_Puestos_Trabajo

    Shared Sub CB_Equipo(ByVal CB As ComboBox, Usuario As String, Centro As String, EXTINY As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Puesto_Trabajo '" & Centro & "', '', '" & EXTINY & "' "
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_Equipo"
        CB.ValueMember = "C_Equipo"
        CB.Text = ""
    End Sub



    Public Shared Sub Catalogo_Equipos(ByVal DataGV As DataGridView, C_Equipo As String, Centro As String, Usuario As String, EXTINY As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Puesto_Trabajo '" & Centro & "', '" & C_Equipo.Trim & "', '" & EXTINY & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(Usuario))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Codigo Equipo"
        DataGV.Columns(1).HeaderText = "Descripción"
        DataGV.Columns(2).HeaderText = "Marca"
        DataGV.Columns(3).HeaderText = "Modelo"
        DataGV.Columns(4).HeaderText = "Capacidad Kg / Hora"
        DataGV.Columns(5).HeaderText = "Limite de Sobrepeso"
        DataGV.Columns(6).HeaderText = "Activo"
    End Sub

    Public Shared Function Valida_Existencia_Puesto(ByVal C_Equipo As String, Centro As String, Usuario As String, EXTINY As String)
        Dim Contador As Integer = 0
        LecturaQry("PA_Consulta_Puesto_Trabajo '" & Centro.Trim & "', '" & C_Equipo.Trim & "', '" & EXTINY & "' ", Usuario)
        If (LecturaBD.Read) Then
            Contador = Contador + 1
        Else
            Contador = Contador
        End If
        Return Contador
    End Function

    Public Shared Sub Insert_Puesto_Trabajo(Centro As String, Usuario As String, C_Equipo As String, D_Equipo As String, Tipo As String, _
                                            Marca As String, Modelo As String, Capacidad As String, Limite As String)

        Dim FH_Update As String = DateTime.Now.ToString("yyyyMMdd hh:mm:ss")

        Try
            LecturaQry("PA_Insert_Equipo_Basico '" & Centro.Trim & "', '" & C_Equipo.Trim & "', '" & D_Equipo.Trim & "', '" & Tipo & "', '" & Marca & "', '" & Modelo & "', '" & Capacidad & "', '" & Limite & "', '" & Usuario & "'", Usuario)
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub Update_Puesto_Trabajo(Centro As String, Usuario As String, C_Equipo As String, D_Equipo As String, Tipo As String, _
                                         Marca As String, Modelo As String, Capacidad As String, Limite As String, Activo As String)

        Dim FH_Update As String = DateTime.Now.ToString("yyyyMMdd hh:mm:ss")

        Try
            LecturaQry("PA_Actualiza_Equipo_Basico '" & Centro.Trim & "', '" & C_Equipo.Trim & "', '" & D_Equipo.Trim & "', '" & Tipo & "', '" & Marca & "', '" & Modelo & "', '" & Capacidad & "', '" & Limite & "', '" & Usuario & "', '" & FH_Update & "', '" & Activo & "'", Usuario)
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub Baja_Puesto_Trabajo(ByVal Usuario As String, Centro As String, Codigo As String, Tipo As String, Activo As String)

        Dim FH_Update As String = DateTime.Now.ToString("yyyyMMdd hh:mm:ss")

        Try
            LecturaQry("PA_Baja_Equipo_Basico '" & Centro.Trim & "', '" & Codigo.Trim & "',  '" & Tipo.Trim & "', '" & Activo.Trim & "', '" & Usuario & "', '" & FH_Update & "' ", Usuario)
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try

    End Sub

End Class
