Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmAdmCatCompExt_AMEX
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

    'Variables de lectura
    Dim C_CodComp As String
    Dim C_DesComp As String
    Dim C_CC As String
    Dim C_TC As String
    Dim C_DCC As String
    Dim C_DTC As String


    'Variables para grabar
    Dim CodPT As String

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub FrmAdmCatCompExt_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        PBActualiza.Visible = False
        tsbGrabar.Enabled = False
        BloqueaText(Me)
        BloqueaButton(Me)
        CargaGrid()

    End Sub

    Private Sub CargaGrid()

        QRY_Grid = ""
        NameTable = ""
        NameTable = "CatalogoEmpaques"
        QRY_Grid = "Select a.Compuesto,a.Descripcion,a.Clase_Compuesto,a.Tipo_Compuesto,b.Nombre_ClaseCompuesto,c.Tipo "
        QRY_Grid = QRY_Grid & "From MCPC_Compuesto a, MCPC_CompuestoClase b, MCPC_CompuestoTipo c "
        QRY_Grid = QRY_Grid & "Where a.Clase_Compuesto = b.Clase_Compuesto "
        QRY_Grid = QRY_Grid & "And a.Tipo_Compuesto = c.ClaveTipo "
        QRY_Grid = QRY_Grid & "And a.Planta = '" & SessionUser._sCentro.Trim & "' "

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGVProd.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGVProd.Columns(0).HeaderText = "Codigo Compuesto"
        DGVProd.Columns(1).HeaderText = "Descripción Compuesto"
        DGVProd.Columns(2).HeaderText = "Clase"
        DGVProd.Columns(3).HeaderText = "Tipo"
        DGVProd.Columns(4).Visible = False      'Nombre Clase Compuesto
        DGVProd.Columns(5).Visible = False      'Nombre Tipo Compuesto

    End Sub

    Private Sub DGVProd_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGVProd.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGVProd.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGVProd.CurrentCell.RowIndex
                C_CodComp = DGVProd.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                C_DesComp = DGVProd.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                C_CC = DGVProd.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                C_TC = DGVProd.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                C_DCC = DGVProd.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                C_DTC = DGVProd.Rows(Fila_Seleccionada).Cells(5).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            TCodComp.Text = C_CodComp
            TDesComp.Text = C_DesComp
            TClase.Text = C_CC
            TTipo.Text = C_TC
            TDesClase.Text = C_DCC
            TDesTipo.Text = C_DTC

            tsbGrabar.Enabled = False
            tsbModificar.Enabled = True
            BloqueaText(Me)
            BloqueaButton(Me)

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

                    InQry = ""
                    InQry = "INSERT INTO MCPC_Compuesto(Planta,Compuesto,Descripcion,Tara,Unidad_Compuesto,Clase_Compuesto,Tipo_Compuesto) "
                    InQry = InQry & " Values ( '" & SessionUser._sCentro.Trim & "','" & TCodComp.Text.Trim & "','" & TDesComp.Text.Trim & "',"
                    InQry = InQry & "0,'Kg','" & TClase.Text.Trim & "','" & TTipo.Text.Trim & "')"
                    InsertQry(InQry)

                    BackgroundWorker1.ReportProgress(75)

                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try

            Case Is = "Modifica"

                Try

                    BackgroundWorker1.ReportProgress(50)

                    InQry = ""
                    InQry = " UPDATE MCPC_Compuesto SET Descripcion = '" & TDesComp.Text.Trim & "', "
                    InQry = InQry & "Clase_Compuesto = '" & TClase.Text.Trim & "', "
                    InQry = InQry & "Tipo_Compuesto = '" & TTipo.Text.Trim & "' "
                    InQry = InQry & "WHERE Planta = '" & SessionUser._sCentro.Trim & "' "
                    InQry = InQry & "AND Compuesto = '" & C_CodComp.Trim & "'"
                    InsertQry(InQry)

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

        If TCodComp.Text.Trim = "" Then
            Mensajes("*** Capture la unidad de MEDIDA del Producto Terminado *** ", 1)
            Exit Sub
        End If

        Try

            If Accion = "Alta" Then
                QRY = ""
                QRY = QRY & " SELECT Compuesto FROM MCPC_Compuesto "
                QRY = QRY & " WHERE Compuesto = '" & TCodComp.Text.Trim & "' "
                QRY = QRY & "AND Planta ='" & SessionUser._sCentro.Trim & "' "
                LecturaQry(QRY)
                If LecturaBD.Read Then
                    Mensajes("***  Empaque ya existe *** ", 1)
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

        Message = "El código quedara eliminado definitivamente, esta seguro de querer eliminarlo"
        Caption = "Eliminar Código Compuesto"
        Result = MessageBox.Show(Message, Caption, Buttons)
        If Result = System.Windows.Forms.DialogResult.Yes Then

            QRY = ""
            QRY = QRY & " SELECT * FROM ProductoTerminadoExtrusion "
            QRY = QRY & " WHERE Empaque = '" & C_CodComp.Trim & "' "
            QRY = QRY & "AND Centro ='" & SessionUser._sCentro.Trim & "' "
            LecturaQry(QRY)
            If LecturaBD.Read Then
                Mensajes("***  Aun Existen Productos que tiene asociado este codigo de Compuesto *** ", 1)
                LecturaBD.Close()
                Exit Sub
            End If
            LecturaBD.Close()

            QRY = ""
            NameTable = ""
            NameTable = "Compuestos"
            QRY = "Delete MCPC_Compuesto "
            QRY = QRY & "Where Compuesto = '" & C_CodComp.Trim & "' "
            QRY = QRY & "And Planta = '" & SessionUser._sCentro.Trim & "' "
            LecturaQry(QRY)

            CargaGrid()


        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            Return
        End If

     

    End Sub

    Private Sub BtnEmpaque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpaque.Click
        'Q = ""
        'Q = "SELECT Clase_Compuesto,Nombre_ClaseCompuesto FROM MCPC_CompuestoClase "
        'frmSpro.SPRO_TITULO = "Descripción Clase Compuesto"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "CatCompuesto_Descr"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TClase.Text = frmSpro.SPRO_KEY.Trim
        '    Q = ""
        '    Q = "SELECT Nombre_ClaseCompuesto FROM MCPC_CompuestoClase "
        '    Q = Q & "Where Clase_Compuesto = '" & TClase.Text.Trim & "' "
        '    TDesClase.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub

    Private Sub BtnTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTipo.Click
        'Q = ""
        'Q = "SELECT ClaveTipo,Tipo FROM MCPC_CompuestoTipo "
        'frmSpro.SPRO_TITULO = "Descripción Tipo Compuesto"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "CatTipo_Descr"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TTipo.Text = frmSpro.SPRO_KEY.Trim
        '    Q = ""
        '    Q = "SELECT Tipo FROM MCPC_CompuestoTipo "
        '    Q = Q & "Where ClaveTipo = '" & TTipo.Text.Trim & "' "
        '    TDesTipo.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub
End Class