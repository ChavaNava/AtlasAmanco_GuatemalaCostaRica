Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports SQL_DATA
Imports System.Drawing
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales

Public Class OperacionProduccionProceso
    Shared Sub Consulta(ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Produccion_Proceso '','','" & ConsultaProduccionProceso._Orden.Trim & "','','','" & ConsultaProduccionProceso._Estatus.Trim & "','" & ConsultaProduccionProceso._Area.Trim & "','" & ConsultaProduccionProceso._FI.Trim & "','" & ConsultaProduccionProceso._FF.Trim & "',2"
        Try
            Dim sqlCmd As New SqlCommand(Q, Cnn.MSI(SessionUser._sAmbiente))
            sqlCmd.CommandTimeout = 3600
            objDa = New SqlDataAdapter(sqlCmd)
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            LoadingForm.CloseForm()
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Folio Producción Proceso"
        DataGV.Columns(1).HeaderText = "Fecha Pesaje"
        DataGV.Columns(2).HeaderText = "Hora Pesaje"
        DataGV.Columns(3).HeaderText = "Centro"
        DataGV.Columns(4).HeaderText = "Orden Producción"
        DataGV.Columns(5).HeaderText = "Código Producto"
        DataGV.Columns(6).HeaderText = "Descripción"
        DataGV.Columns(7).HeaderText = "Bascula"
        DataGV.Columns(8).HeaderText = "Rack"
        DataGV.Columns(9).HeaderText = "Peso Bruto"
        DataGV.Columns(10).HeaderText = "Peso Tara"
        DataGV.Columns(11).HeaderText = "Peso Neto"
        DataGV.Columns(12).HeaderText = "Empaques"
        DataGV.Columns(13).HeaderText = "Tramos"
        DataGV.Columns(14).HeaderText = "Usuario"
        DataGV.Columns(15).HeaderText = "Turno"
        DataGV.Columns(16).HeaderText = "Puesto Trabajo"
        DataGV.Columns(17).HeaderText = "Folio Pesaje"
        DataGV.Columns(18).HeaderText = "Estatus"
        DataGV.Columns(19).Visible = False  'Peso Unitario
        DataGV.Columns(20).Visible = False  'Peso Teorico
        DataGV.Columns(21).Visible = False  'Compuesto 1
        DataGV.Columns(22).Visible = False  'Porcentaje 1
        DataGV.Columns(23).Visible = False  'Cantidad 1
        DataGV.Columns(24).Visible = False  'Compuesto 2
        DataGV.Columns(25).Visible = False  'Porcentaje 2
        DataGV.Columns(26).Visible = False  'Cantidad 2
    End Sub

    Shared Sub ConsultaDetalleSeparada(ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Produccion_Proceso '" & ConsultaProduccionProceso._IdFolioProceso & "','','','','','','','','',5"
        Try
            Dim sqlCmd As New SqlCommand(Q, Cnn.MSI(SessionUser._sAmbiente))
            sqlCmd.CommandTimeout = 3600
            objDa = New SqlDataAdapter(sqlCmd)
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
    End Sub

    Public Shared Sub FomatingProduccionProceso(DGV As DataGridView, Columna As Integer, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        Dim Status As Integer
        Status = (DGV.Rows(e.RowIndex).Cells(Columna).Value)

        If Status = 1 Then
            e.CellStyle.BackColor = Color.LightBlue
            e.CellStyle.ForeColor = Color.Black
        ElseIf Status = 2 Then
            e.CellStyle.BackColor = Color.LightYellow
            e.CellStyle.ForeColor = Color.Black
        ElseIf Status = 3 Then
            e.CellStyle.BackColor = Color.LightGreen
            e.CellStyle.ForeColor = Color.Black
        ElseIf Status = 4 Then
            e.CellStyle.BackColor = Color.LightCoral
            e.CellStyle.ForeColor = Color.Black
        End If

    End Sub

    Shared Sub ABC(ByVal Operacion As Integer)
        Cnn.LecturaQry("PA_Produccion_Proceso '" & abcProduccionProceso._IdFolioProceso & "','','','','','','','','','','','','','','','','','','','',''," & Operacion & "")
    End Sub

    Shared Sub CB_Causa(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Causas '" & SessionUser._sCentro.Trim & "', '" & ComboCausas._CodigoCausa.Trim & "', '" & ComboCausas._Area.Trim & "', '" & ComboCausas._TipoCausa.Trim & "' "
        Cnn.Combo(Q)
        NDataSet1 = Cnn.DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_Causa"
        CB.ValueMember = "C_Causa"
    End Sub
    Shared Sub CB_Defectos(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Defectos_2 '" & SessionUser._sCentro.Trim & "','" & ComboDefectos._CodigoCausa.Trim & "' "
        Cnn.Combo(Q)
        NDataSet1 = Cnn.DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Defecto"
        CB.ValueMember = "C_Defecto"
    End Sub
    Shared Sub CB_Estatus(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_EstatusProduccionSeparada '','','',1 "
        Cnn.Combo(Q)
        NDataSet1 = Cnn.DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "EstatusProceso"
        CB.ValueMember = "IdEstatusProceso"
    End Sub
    Public Shared Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function
    Public Shared Function Decimales(ByVal Keyascii As Short) As Short
        If InStr("1234567890.", Chr(Keyascii)) = 0 Then
            Decimales = 0
        Else
            Decimales = Keyascii
        End If
        Select Case Keyascii
            Case 8
                Decimales = Keyascii
            Case 13
                Decimales = Keyascii
        End Select
    End Function
    Public Shared Function NotificaProduccion() As Integer
        Dim Q As String

        Q = ""
        Q = "PA_NotificacionExtrusionPT '" & NPTExtrusion._iOrdenProduccion.Trim & "','" & SessionUser._sCentro.Trim & "','" & NPTExtrusion._iFechaPesaje.Trim & _
            "','" & NPTExtrusion._iHoraPesaje.Trim & "','" & NPTExtrusion._iIdBascula.Trim & "','" & NPTExtrusion._iIdRack.Trim & "'," & NPTExtrusion._iPB & "," & NPTExtrusion._iPT & "," & NPTExtrusion._iPN & _
            "," & NPTExtrusion._iEmpaques & "," & NPTExtrusion._iTramos & ",'" & NPTExtrusion._iUsuario.Trim & "','" & NPTExtrusion._iFechaTurno.Trim & "','" & NPTExtrusion._iTurno & _
            "','" & NPTExtrusion._iSupervisor.Trim & "','" & NPTExtrusion._iSobrePeso & "','','" & NPTExtrusion._iPuestoTrabajo.Trim.Trim & _
            "'," & NPTExtrusion._iPesoTeorico & ",'" & NPTExtrusion._iArea.Trim & "','" & NPTExtrusion._iTipoPT.Trim & "','" & NPTExtrusion._iEstatusSobrePeso.Trim & "','" & NPTExtrusion._iComp1.Trim & "','" & NPTExtrusion._iPorc1.Trim & "','" & NPTExtrusion._iCant1.Trim & _
            "','" & NPTExtrusion._iComp2.Trim & "','" & NPTExtrusion._iPorc2.Trim & "','" & NPTExtrusion._iCant2.Trim & "','" & NPTExtrusion._iVersion.Trim & "','" & NPTExtrusion._iFolioPesaje.Trim & "','" & dgvProduccionProceso._IdFolioProceso & "','" & NPTExtrusion._iIdOperadorPtoTra.Trim & "','','','','', 2"
        Cnn.LecturaQry(Q)

        If (Cnn.LecturaBD.Read) Then
            NotificaProduccion = Cnn.LecturaBD(0)
        Else
            NotificaProduccion = 0
        End If
    End Function

    Public Shared Function ActualizaNotificacionRecuperadaPT() As Boolean
        Cnn.LecturaQry("PA_NotificacionExtrusionPT '" & NPTExtrusion._iOrdenProduccion.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','" & NPTExtrusion._iPBR & "','" & NPTExtrusion._iPTR & "','" & NPTExtrusion._iPNR & "','','" & NPTExtrusion._iTramosR & "','','','','','','','','','','','','','','','','','','','" & NPTExtrusion._iFolioPesaje.Trim & "','" & dgvProduccionProceso._IdFolioProceso & "','','','','','',3")
        If (Cnn.LecturaBD.Read) Then
            ActualizaNotificacionRecuperadaPT = True
        Else
            ActualizaNotificacionRecuperadaPT = False
        End If
    End Function

    Public Shared Function ActualizaEnProceso() As Boolean
        Cnn.LecturaQry("PA_Produccion_Proceso '" & NPTExtrusion._iFolioProduccionProceso.Trim & "','','','','','" & NPTExtrusion._iEstatusProceso.Trim & "','','','',4")
        If (Cnn.LecturaBD.Read) Then
            ActualizaEnProceso = True
        Else
            ActualizaEnProceso = False
        End If
    End Function

    Public Shared Function NotificacionFallidaPT() As Boolean
        Cnn.LecturaQry("PA_NotificacionExtrusionPT '" & NPTExtrusion._iOrdenProduccion.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','" & NPTExtrusion._iFolioPesaje.Trim & "','','','','','','',4 ")
        If (Cnn.LecturaBD.Read) Then
            Compuestos.IdCompuestoBOM = Cnn.LecturaBD(0)
            NotificacionFallidaPT = True
        Else
            NotificacionFallidaPT = False
        End If
    End Function

    Public Shared Function NotificacionFallidaSC() As Boolean
        Cnn.LecturaQry("PA_NotificacionExtrusionSC '" & NPTExtrusion._iOrdenProduccion.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','" & NPTExtrusion._iFolioPesaje.Trim & "','','',2 ")
        If (Cnn.LecturaBD.Read) Then
            Compuestos.IdCompuestoBOM = Cnn.LecturaBD(0)
            NotificacionFallidaSC = True
        Else
            NotificacionFallidaSC = False
        End If
    End Function
    Public Shared Sub NotificacionExitosaPT()
        Cnn.LecturaQry("PA_NotificacionExtrusionPT '" & NPTExtrusion._iOrdenProduccion.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','" & NPTExtrusion._iFolioPesaje.Trim & "','','','" & NPTExtrusion.iIdReg & "','','" & NPTExtrusion.iDocSAP.Trim & "','" & NPTExtrusion.iNumSAP.Trim & "',5 ")
    End Sub
    Public Shared Sub NotificacionExitosaSC()
        Cnn.LecturaQry("PA_NotificacionExtrusionSC '" & NPTExtrusion._iOrdenProduccion.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','','','','','','','" & NPTExtrusion._iMensajeSAP & "','" & NPTExtrusion.iDocSAP.Trim & "','" & NPTExtrusion.iNumSAP.Trim & "','','','','','','','','','','','','','','','','','','" & NPTExtrusion._iFolioPesaje.Trim & "','','',3 ")
    End Sub
    Shared Function Compuesto_Bom(ByVal IdPt As String) As Boolean
        Cnn.LecturaQry("PA_Identifica_Compuesto_BOM '" & SessionUser._sCentro.Trim & "', '" & IdPt.Trim & "' ")
        If (Cnn.LecturaBD.Read) Then
            Compuestos.IdCompuestoBOM = Cnn.LecturaBD(0)
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function NotificaScrap() As Integer
        Dim Q As String

        Q = ""
        Q = "PA_NotificacionExtrusionSC '" & NPTExtrusion._iOrdenProduccion.Trim & "','" & SessionUser._sCentro.Trim & "','" & NPTExtrusion._iFechaPesaje.Trim & _
            "','" & NPTExtrusion._iHoraPesaje.Trim & "','" & NPTExtrusion._iIdBascula.Trim & "','" & NPTExtrusion._iTipoScrap.Trim & "'," & NPTExtrusion._iPB & "," & NPTExtrusion._iPT & "," & NPTExtrusion._iPN & _
            ",'" & NPTExtrusion._iUsuario.Trim & "','" & NPTExtrusion._iTurno & "','" & NPTExtrusion._iNotifica.Trim & "','Msg','0000000000','00000000','0','" & NPTExtrusion._iIdCausa.Trim & "','" & NPTExtrusion._iIdDefecto.Trim & "','" & NPTExtrusion._iFechaTurno & _
            "','" & NPTExtrusion._iPuestoTrabajo.Trim & "','" & NPTExtrusion._iRepGenerado.Trim & "','" & NPTExtrusion._iArea.Trim & "','" & NPTExtrusion._iIdOperadorPtoTra.Trim & "','" & NPTExtrusion._iSupervisor.Trim & _
            "'," & NPTExtrusion._iIdRack.Trim & ",'" & NPTExtrusion._iComp1.Trim & "','" & NPTExtrusion._iPorc1.Trim & "','" & NPTExtrusion._iCant1.Trim & "','" & NPTExtrusion._iComp2.Trim & "','" & NPTExtrusion._iPorc2.Trim & "','" & NPTExtrusion._iCant2.Trim & _
            "','','" & NPTExtrusion._iFolioPesaje.Trim & "','" & NPTExtrusion._iFolioRecuperacion.Trim & "','" & NPTExtrusion._iVersion.Trim & "', 1"
        Cnn.LecturaQry(Q)

        If (Cnn.LecturaBD.Read) Then
            NotificaScrap = Cnn.LecturaBD(0)
        Else
            NotificaScrap = 0
        End If
    End Function

    Public Shared Function Identifica_Reprocesado(Comp_Consumo As String) As String
        Dim Reprocesado_Genenerado As String = ""
        Dim Rep_Clase As String = ""

        Cnn.LecturaQry("PA_Reprocesados_Generados '" & SessionUser._sCentro & "', '" & Comp_Consumo.Trim & "', '" & EXTINY & "' ")
        If (Cnn.LecturaBD.Read) Then
            Rep_Clase = Cnn.LecturaBD(3)
            If Rep_Clase = "6" Then
                Reprocesado_Genenerado = Cnn.LecturaBD(2)
            Else
                Reprocesado_Genenerado = " "
            End If
        End If
        Cnn.LecturaBD.Close()
        Return Reprocesado_Genenerado
    End Function
End Class
