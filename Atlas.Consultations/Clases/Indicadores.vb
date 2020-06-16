Imports SQL_DATA
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Utili_Generales

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

    Public Shared Sub Pesajes_PT_SC(ByVal FI As String, FF As String, DataGV As DataGridView, AreaProd As String, TBProdKilos As TextBox, _
                        TBProrUnidades As TextBox, TBProcKilos As TextBox, TBProcUnidades As TextBox, TBSobrePesoKilos As TextBox, _
                        TBSobrePesoPorc As TextBox, TBScrapKilos As TextBox, TBScrapPorc As TextBox, TBScrapPurgaKilos As TextBox, _
                        TBScrapPurgaPorc As TextBox, TBProg As TextBox, TBEnt As TextBox, TBProc As TextBox, TBPend As TextBox, _
                        Orden As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        If SessionUser._sCentro.Trim = "PE01" Or SessionUser._sCentro.Trim = "PE12" Then
            Q = ""
            Q = "PA_ConsultaProduccionScrap_1 " & SessionUser._sCentro.Trim & "_OrdenProduccion, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, " & SessionUser._sCentro.Trim & "_PesoScrap, '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "' "

        Else
            Q = ""
            Q = "PA_Consulta_Produccion_Scrap " & SessionUser._sCentro.Trim & "_OrdenProduccion, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, " & SessionUser._sCentro.Trim & "_PesoScrap, '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "' "

        End If

        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            LoadingForm.CloseForm()
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        If SessionUser._sCentro.Trim = "PE01" Or SessionUser._sCentro.Trim = "PE12" Then
            DataGV.Columns(0).HeaderText = "Folio"
            DataGV.Columns(1).HeaderText = "Tipo Producción"
            DataGV.Columns(2).HeaderText = "Orden Producción"
            DataGV.Columns(3).HeaderText = "Codigo Producto"
            DataGV.Columns(4).HeaderText = "Descripción Producto"
            DataGV.Columns(5).HeaderText = "Fecha_Turno"
            DataGV.Columns(6).HeaderText = "Fecha_Pesaje"
            DataGV.Columns(7).HeaderText = "Hora Pesaje"
            DataGV.Columns(8).HeaderText = "Bascula"
            DataGV.Columns(9).HeaderText = "Tramos"
            DataGV.Columns(9).Name = "Tramos"
            DataGV.Columns(10).HeaderText = "Rack"
            DataGV.Columns(11).HeaderText = "Peso Bruto"
            DataGV.Columns(12).HeaderText = "Peso Tara"
            DataGV.Columns(13).HeaderText = "Peso Neto"
            DataGV.Columns(13).Name = "PesoNeto"
            DataGV.Columns(14).Visible = False  'Peso Teorico"
            DataGV.Columns(15).HeaderText = "Empaques"
            DataGV.Columns(16).HeaderText = "Usuario"
            DataGV.Columns(17).HeaderText = "Turno"
            DataGV.Columns(18).HeaderText = "Documento SAP"
            DataGV.Columns(19).HeaderText = "Consecutivo SAP"
            DataGV.Columns(20).HeaderText = "Sobre Peso"
            DataGV.Columns(21).HeaderText = "Puesto Trabajo"
            DataGV.Columns(22).Visible = False  'Status Notificación
            DataGV.Columns(23).Visible = False  'Mensaje
            DataGV.Columns(24).Visible = False  'Tipo Produccion 1 = Producto Terminado 2 Scrap
        Else
            DataGV.Columns(0).HeaderText = "Folio"
            DataGV.Columns(1).HeaderText = "Tipo Producción"
            DataGV.Columns(2).HeaderText = "Orden Producción"
            DataGV.Columns(3).HeaderText = "Codigo Producto"
            DataGV.Columns(4).HeaderText = "Fecha_Pesaje"
            DataGV.Columns(5).HeaderText = "Hora Pesaje"
            DataGV.Columns(6).HeaderText = "Bascula"
            DataGV.Columns(7).HeaderText = "Tramos"
            DataGV.Columns(7).Name = "Tramos"
            DataGV.Columns(8).HeaderText = "Rack"
            DataGV.Columns(9).HeaderText = "Peso Bruto"
            DataGV.Columns(10).HeaderText = "Peso Tara"
            DataGV.Columns(11).HeaderText = "Peso Neto"
            DataGV.Columns(11).Name = "PesoNeto"
            DataGV.Columns(12).Visible = False  'Peso Teorico"
            DataGV.Columns(13).HeaderText = "Empaques"
            DataGV.Columns(14).HeaderText = "Usuario"
            DataGV.Columns(15).HeaderText = "Turno"
            DataGV.Columns(16).HeaderText = "Documento SAP"
            DataGV.Columns(17).HeaderText = "Consecutivo SAP"
            DataGV.Columns(18).HeaderText = "Sobre Peso"
            DataGV.Columns(19).HeaderText = "Puesto Trabajo"
            DataGV.Columns(20).Visible = False  'Status Notificación
            DataGV.Columns(21).Visible = False  'Mensaje
            DataGV.Columns(22).Visible = False  'Tipo Produccion 1 = Producto Terminado 2 Scrap
        End If


        Cnn.LecturaQry("PA_Consulta_Produccion_Totales " & SessionUser._sCentro.Trim & "_OrdenProduccion, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "' ")
        If (Cnn.LecturaBD.Read) Then
            TBProrUnidades.Text = Format(Cnn.LecturaBD(0), "#,##0.00")
            TBProdKilos.Text = Format(Cnn.LecturaBD(1), "#,##0.00")
            TBSobrePesoPorc.Text = Format(Cnn.LecturaBD(2), "#0.000")
            TBSobrePesoKilos.Text = Format(Cnn.LecturaBD(3), "#,##0.00")
        End If
        Cnn.LecturaBD.Close()

        Cnn.LecturaQry("PA_Consulta_Produccion_Scrap_Proceso " & SessionUser._sCentro.Trim & "_OrdenProduccion, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "'")
        If (Cnn.LecturaBD.Read) Then
            TBProcUnidades.Text = Format(Cnn.LecturaBD(0), "#,##0.00")
            TBProcKilos.Text = Format(Cnn.LecturaBD(1), "#,##0.00")
        End If
        Cnn.LecturaBD.Close()

        Cnn.LecturaQry("PA_Consulta_Scrap_Totales " & SessionUser._sCentro.Trim & "_PesoScrap, '" & FI & "', '" & FF & "', '" & AreaProd & "', '1', '" & Orden & "'")
        If (Cnn.LecturaBD.Read) Then
            TBScrapKilos.Text = Format(Cnn.LecturaBD(0), "#,##0.00")
        End If
        Cnn.LecturaBD.Close()

        Cnn.LecturaQry("PA_Consulta_Scrap_Totales " & SessionUser._sCentro.Trim & "_PesoScrap, '" & FI & "', '" & FF & "', '" & AreaProd & "', '2', '" & Orden & "'")
        If (Cnn.LecturaBD.Read) Then
            TBScrapPurgaKilos.Text = Format(Cnn.LecturaBD(0), "#,##0.00")
        End If
        Cnn.LecturaBD.Close()

        'Consulta Cantidad Programada
        Cnn.LecturaQry("PA_Consulta_Cantidad_Programada " & SessionUser._sCentro.Trim & "_OrdenProduccion, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "'")
        If (Cnn.LecturaBD.Read) Then
            TBProg.Text = Format(Cnn.LecturaBD(0), "#,##0.00")
        End If
        Cnn.LecturaBD.Close()

        'Consulta Cantidad Entregada
        Cnn.LecturaQry("PA_Consulta_Cantidad_Entregadas  '" & SessionUser._sCentro.Trim & "', '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "'")
        If (Cnn.LecturaBD.Read) Then
            TBEnt.Text = Format(Cnn.LecturaBD(0), "#,##0.00")
        End If
        Cnn.LecturaBD.Close()

        'Consulta Cantidad En Proceso
        Cnn.LecturaQry("PA_Consulta_Cantidad_Proceso  '" & SessionUser._sCentro.Trim & "', '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "'")
        If (Cnn.LecturaBD.Read) Then
            TBProc.Text = Format(Cnn.LecturaBD(0), "#,##0.00")
        End If
        Cnn.LecturaBD.Close()

        TBPend.Text = Format((TBProg.Text - (TBEnt.Text - TBProc.Text)), "#,##0.00")

        TBScrapPorc.Text = Format((TBScrapKilos.Text / TBProdKilos.Text), "#0.000")
        TBScrapPurgaPorc.Text = Format((TBScrapPurgaKilos.Text / TBProdKilos.Text), "#0.000")

    End Sub

    Public Shared Sub abc(ByVal Operacion As Integer)
        Cnn.LecturaQry("PA_IndicadoresRegistro '" & IndicadoresProduccion._abcId.Trim & "', '" & SessionUser._sIdCentro.Trim & "', '" & IndicadoresProduccion._abcMeta.Trim & "', '" & IndicadoresProduccion._abcTurno.Trim & "', '" & IndicadoresProduccion._abcMes.Trim & "', " & Operacion & "")
    End Sub

    Public Shared Sub abcSeguridad(ByVal Operacion As Integer)
        Cnn.LecturaQry("PA_IndicadoresSeguridadRegistro '" & IndicadoresSeguridad._abcId.Trim & "', '" & SessionUser._sIdCentro.Trim & "', '" & IndicadoresSeguridad._abcFecha.Trim & "', " & Operacion & "")
    End Sub
End Class
