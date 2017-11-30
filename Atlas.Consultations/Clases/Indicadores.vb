Imports SQL_DATA
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Indicadores
    Public Shared Sub Resumen()
        Dim FrmMonitor As New FrmMonitorMaster
        Cnn.LecturaQry("PA_Indicadores '" & SessionUser._sIdCentro.Trim & "', '" & 1 & "'")
        Do While (Cnn.LecturaBD.Read)
            ResumenIndicadores.IdIndicador = Cnn.LecturaBD(1)
            Select Case ResumenIndicadores._IdIndicador
                Case Is = 1
                    'FrmMonitor.TxM1.Text = Cnn.LecturaBD(3)
                    'FrmMonitor.TxT1.Text = Cnn.LecturaBD(4)
                    FrmMonitor.TxMe1.Text = Cnn.LecturaBD(5)
                Case Is = 2
                    FrmMonitor.TxM2.Text = Cnn.LecturaBD(3)
                Case Is = 3
                    FrmMonitor.TxM4.Text = Cnn.LecturaBD(3)
                    FrmMonitor.TxT4.Text = Cnn.LecturaBD(3)
                    FrmMonitor.TxMe4.Text = Cnn.LecturaBD(3)
                Case Is = 4
                    FrmMonitor.TxM5.Text = Cnn.LecturaBD(3)
            End Select
        Loop
        'Dim NOMFRM As String = FrmMonitor.Name
        'If FrmMonitor.Name = "FrmMonitorMaster" Then
        '    FrmMonitor.Show()
        'Else
        '    FrmMonitor.Refresh()
        'End If


    End Sub

    Public Shared Sub Produccion(ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Indicadores '" & SessionUser._sIdCentro & "', '3'"
        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Id"
        DataGV.Columns(1).HeaderText = "Indicador"
        DataGV.Columns(2).HeaderText = "Meta"
        DataGV.Columns(3).HeaderText = "Turno"
        DataGV.Columns(4).HeaderText = "Mes"
    End Sub


    Public Shared Sub Seguridad(ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Indicadores '" & SessionUser._sIdCentro & "', '2'"
        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Id Indicador"
        DataGV.Columns(1).HeaderText = "Fecha ultimo suceso"
        DataGV.Columns(2).HeaderText = "Días sin accidentes"
    End Sub

    Public Shared Sub abc(ByVal Operacion As Integer)
        Cnn.LecturaQry("PA_IndicadoresRegistro '" & IndicadoresProduccion._abcId.Trim & "', '" & SessionUser._sIdCentro.Trim & "', '" & IndicadoresProduccion._abcMeta.Trim & "', '" & IndicadoresProduccion._abcTurno.Trim & "', '" & IndicadoresProduccion._abcMes.Trim & "', " & Operacion & "")
    End Sub

    Public Shared Sub abcSeguridad(ByVal Operacion As Integer)
        Cnn.LecturaQry("PA_IndicadoresSeguridadRegistro '" & IndicadoresSeguridad._abcId.Trim & "', '" & SessionUser._sIdCentro.Trim & "', '" & IndicadoresSeguridad._abcFecha.Trim & "', " & Operacion & "")
    End Sub
End Class
