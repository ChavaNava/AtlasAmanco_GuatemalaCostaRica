Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales

Public Class FrmAdmCatEfecto_AMEX
    Dim myDataReader As SqlClient.SqlDataReader
    Dim Q As String
    Dim ConexionSQL As SqlConnection
    Dim ConexComando As SqlCommand
    Dim Consulta_1 As String
    Dim Cadena_conexion As String
    Dim TablaEXTINY As String

    Dim Message As String = ""
    Dim Caption As String = ""
    Dim Result As DialogResult
    Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
    Dim Botones As MessageBoxButtons = MessageBoxButtons.OK

    'Variables Registro Causa
    Dim Fec As String
    Dim Hra As String

    'Variables consulta
    Dim CCausa As String
    Dim DCausa As String
    Dim CEfecto As String
    Dim DEfecto As String
    Dim CArea As String
    Dim ST_Efecto As Boolean
    Dim ST_Causa As String
    Dim ST_Cell As String


    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub FrmAdmCatEfectos_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        PBActualiza.Visible = False
        tsbGrabar.Enabled = False
        BloqueaText(Me)
        BloqueaButton(Me)
        BloqueaCheckBox(Me)
        CargaGrid()
    End Sub

    Private Sub CargaGrid()

        QRY_Grid = ""
        NameTable = ""
        NameTable = "CatalogoEfectos"
        QRY_Grid = "Select a.C_Causa,b.D_Causa,a.C_Efecto,a.D_Efecto,a.Status,b.Area,b.St "
        QRY_Grid = QRY_Grid & "From CatEfectos_Amex a, CatCausas_Amex b  "
        QRY_Grid = QRY_Grid & "Where a.Centro = b.Centro "
        QRY_Grid = QRY_Grid & "And a.C_Causa = b.C_Causa "
        QRY_Grid = QRY_Grid & "And b.T_Causa = 'SC' "
        QRY_Grid = QRY_Grid & "And b.Area = 'EXT' "
        QRY_Grid = QRY_Grid & "And b.St = 'A' "
        QRY_Grid = QRY_Grid & "And a.Centro = '" & SessionUser._sCentro.Trim & "' "

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGV_Efectos.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGV_Efectos.Columns(0).HeaderText = "Codigo Causa"
        DGV_Efectos.Columns(1).HeaderText = "Descripción Causa"
        DGV_Efectos.Columns(2).HeaderText = "Codigo Efecto"
        DGV_Efectos.Columns(3).HeaderText = "Descripción Efecto"
        DGV_Efectos.Columns(4).Visible = False 'Status Efecto
        DGV_Efectos.Columns(5).Visible = False 'Area
        DGV_Efectos.Columns(6).Visible = False 'Status Causa


    End Sub

    Private Sub DGVProd_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Efectos.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV_Efectos.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGV_Efectos.CurrentCell.RowIndex
                CCausa = DGV_Efectos.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                DCausa = DGV_Efectos.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                CEfecto = DGV_Efectos.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                DEfecto = DGV_Efectos.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                ST_Efecto = DGV_Efectos.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                CArea = DGV_Efectos.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                ST_Causa = DGV_Efectos.Rows(Fila_Seleccionada).Cells(6).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            'TCodEfecto.Text = CCausa
            'TDesEfect.Text = DCausa
            'TC_Causa.Text = CArea
            'TTipo.Text = CTCausa
            'TD_Causa.Text = DArea
            'TDesTipo.Text = DTCausa
            'CB_Status.Checked = ST

            If ST_Efecto = True Then
                CB_Status.Text = "Alta"
            Else
                CB_Status.Text = "Baja"
            End If

            tsbGrabar.Enabled = False
            tsbModificar.Enabled = True
            BloqueaText(Me)
            BloqueaButton(Me)
            BloqueaCheckBox(Me)

        End If
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Me.Close()
    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click
        Accion = "Modifica"
        ActivaText(Me)
        ActivaButton(Me)
        ActivaCheckBox(Me)
        TCodEfecto.Enabled = False
        tsbAlta.Enabled = False
        tsbGrabar.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BackgroundWorker1.ReportProgress(15)

        System.Threading.Thread.Sleep(2000) ' Para simular tiempo de espera


        BackgroundWorker1.ReportProgress(30)

        Select Case Accion

            Case Is = "Alta"

                Try
                    BackgroundWorker1.ReportProgress(50)

                    'InQry = ""
                    'InQry = "INSERT INTO CatCausas_Amex(Centro,C_Causa,D_Causa,T_Causa,Area,UsrReg,Fecha_Reg,Hora_Reg) "
                    'InQry = InQry & " Values ( '" & strPlanta.Trim & "','" & TCodEfecto.Text.Trim & "','" & TDesEfect.Text.Trim & "',"
                    'InQry = InQry & "'" & TTipo.Text.Trim & "','" & TC_Causa.Text.Trim & "','" & SessionUser._sAlias.Trim & "','" & Fec.Trim & "',"
                    'InQry = InQry & "'" & Hra.Trim & "')"
                    'InsertQry(InQry)

                    BackgroundWorker1.ReportProgress(75)

                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try

            Case Is = "Modifica"

                Try

                    BackgroundWorker1.ReportProgress(50)

                    'InQry = ""
                    'InQry = " UPDATE CatCausas_Amex SET D_Causa = '" & TDesEfect.Text.Trim & "', "
                    'InQry = InQry & "T_Causa = '" & TTipo.Text.Trim & "', "
                    'InQry = InQry & "Area = '" & TC_Causa.Text.Trim & "', "
                    'InQry = InQry & "Status = '" & CB_Status.CheckState & "' "
                    'InQry = InQry & "WHERE Centro = '" & strPlanta.Trim & "' "
                    'InQry = InQry & "AND C_Causa = '" & TCodEfecto.Text.Trim & "'"
                    'InsertQry(InQry)

                    BackgroundWorker1.ReportProgress(75)

                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try

        End Select

        BackgroundWorker1.ReportProgress(100)

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        PBActualiza.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        CargaGrid()
        MessageBox.Show("Información Actualizada")
        tsbGrabar.Enabled = False
        tsbAlta.Enabled = True
        PBActualiza.Value = 0
        PBActualiza.Visible = False
        Accion = ""
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click

        If TCodEfecto.Text.Trim = "" Then
            Mensajes("*** Capture la unidad de MEDIDA del Producto Terminado *** ", 1)
            Exit Sub
        End If

        Try

            If Accion = "Alta" Then
                QRY = ""
                QRY = QRY & " SELECT C_Causa FROM CatCausas_Amex "
                QRY = QRY & " WHERE C_Causa = '" & TCodEfecto.Text.Trim & "' "
                QRY = QRY & "AND Centro ='" & SessionUser._sCentro.Trim & "' "
                LecturaQry(QRY)
                If LecturaBD.Read Then
                    Mensajes("***  Causa ya existe *** ", 1)
                    LecturaBD.Close()
                    Exit Sub
                End If
                LecturaBD.Close()

            End If
            ' ---------------------------------------------------------------------------------

        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        Fec = Date.Today.ToString("yyyy-MM-dd")
        Hra = Date.Now.TimeOfDay.ToString.Substring(0, 8)

        PBActualiza.Visible = True

        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub tsbAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAlta.Click
        Accion = "Alta"
        tsbGrabar.Enabled = True
        ActivaButton(Me)
        ActivaText(Me)
        LimpiarText(Me)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If tsbGrabar.Enabled = True Then
            tsbGrabar.Enabled = False
        End If
        If tsbModificar.Enabled = True Then
            tsbModificar.Enabled = False
        End If
        If tsbAlta.Enabled = False Then
            tsbAlta.Enabled = True
        End If
        BloqueaText(Me)
        BloqueaButton(Me)
        BloqueaCheckBox(Me)
        LimpiarText(Me)
        LimpiarCheckBox(Me)
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click

        Message = "El código quedara en Status de Baja, ¿Esta Seguro? "
        Caption = "Eliminar Código Causa"
        Result = MessageBox.Show(Message, Caption, Buttons)
        If Result = System.Windows.Forms.DialogResult.Yes Then

            InQry = ""
            InQry = " UPDATE CatCausas_Amex SET Status = '0' "
            InQry = InQry & "WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
            InQry = InQry & "AND C_Causa = '" & TCodEfecto.Text.Trim & "'"
            InsertQry(InQry)

            CargaGrid()

        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            Return
        End If

    End Sub

    Private Sub BtnEmpaque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Q = ""
        'Q = "SELECT C_Causa,D_Causa FROM CatCausas_Amex "
        'Q = Q & "Where Centro = '" & strPlanta.Trim & "' "
        'Q = Q & "And T_Causa = 'SC' "
        'Q = Q & "And Area = 'EXT' "
        'Q = Q & "And Status = '1' "
        'frmSpro.SPRO_TITULO = "Catalogo Causas"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "Causa"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TC_Causa.Text = frmSpro.SPRO_KEY.Trim
        '    Q = ""
        '    Q = "SELECT D_Causa FROM CatCausas_Amex "
        '    Q = Q & "Where C_Causa = '" & TC_Causa.Text.Trim & "' "
        '    Q = Q & "And Centro = '" & strPlanta.Trim & "' "
        '    Q = Q & "And T_Causa = 'SC' "
        '    Q = Q & "And Area = 'EXT' "
        '    Q = Q & "And Status = '1' "
        '    TD_Causa.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub
    Private Sub DGV_Causas_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV_Efectos.CellFormatting
        ST_Cell = (DGV_Efectos.Rows(e.RowIndex).Cells(6).Value)

        If ST_Cell = "A" Then
            e.CellStyle.BackColor = Color.LightGreen
            e.CellStyle.ForeColor = Color.Black
        Else
            e.CellStyle.BackColor = Color.Red
            e.CellStyle.ForeColor = Color.Black
        End If
    End Sub
End Class