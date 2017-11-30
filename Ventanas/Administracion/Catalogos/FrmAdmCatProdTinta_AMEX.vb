Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmAdmCatProdTinta_AMEX
    Dim myDataReader As SqlClient.SqlDataReader
    Dim Q As String
    Dim ConexionSQL As SqlConnection
    Dim ConexComando As SqlCommand

    'Variables de lectura
    Dim Status As Boolean
    Dim Status_Bom As Boolean
    Dim Cod_Tinta As String
    Dim Cod_Tipo As String
    Dim Des_Tinta As String
    Dim Des_Tipo As String

    'Variables para grabar
    Dim CodPT As String

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub FrmAdmCatProdTinta_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Text = "Catalogo PRODUCTO/TINTAS" & "CENTRO : " & SessionUser._sCentro.Trim

        CB_Mat()
        PBActualiza.Visible = False
        tsbGrabar.Enabled = False
        BloqueaText(Me)
        BloqueaButton(Me)
        BloqueaCheckBox(Me)

    End Sub

    Sub CB_Mat()
        Dim NDataSet1 As New DataSet
        QryCombo = ""
        QryCombo = "Select Codigo,Descr,Codigo+Descr as Producto  "
        QryCombo = QryCombo & "From productoterminadoextrusion "
        QryCombo = QryCombo & "Where Centro = '" & SessionUser._sCentro.Trim & " ' "
        QryCombo = QryCombo & "Order by Codigo "
        Combo(QryCombo)
        NDataSet1 = DataSetCombo.Copy
        CB_Codigo.DataSource = NDataSet1.Tables(0)
        CB_Codigo.DisplayMember = "Producto"
        CB_Codigo.ValueMember = "Codigo"
    End Sub

    Private Sub CargaGrid()

        QRY_Grid = ""
        NameTable = ""
        NameTable = "Tintas_Aditivos"
        QRY_Grid = "Select a.C_Tinta,b.D_Tinta,a.Cve_tipo,c.Descripcion,a.Status,a.Bom "
        QRY_Grid = QRY_Grid & "From AsignacionTintas a, CatTintas_Aditivos b, CatTipoTintaAditivo c "
        QRY_Grid = QRY_Grid & "Where a.C_tinta = b.C_Tinta "
        QRY_Grid = QRY_Grid & "And a.Centro = b.Centro "
        QRY_Grid = QRY_Grid & "And a.Cve_Tipo = c.Cve_Tipo "
        QRY_Grid = QRY_Grid & "And a.Centro = c.Centro "
        QRY_Grid = QRY_Grid & "And a.C_PT = '" & CB_Codigo.SelectedValue.Trim & "' "
        QRY_Grid = QRY_Grid & "And a.Centro = '" & SessionUser._sCentro.Trim & "'"

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGVProd.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message)
            Return
        End Try

        DGVProd.Columns(0).HeaderText = "Codigo"
        DGVProd.Columns(1).HeaderText = "Descripción"
        DGVProd.Columns(2).HeaderText = "Tipo"
        DGVProd.Columns(3).HeaderText = "Descripción Tipo"
        DGVProd.Columns(4).HeaderText = "Status"
        DGVProd.Columns(5).HeaderText = "Bom"

    End Sub

    Private Sub DGVProd_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGVProd.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGVProd.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGVProd.CurrentCell.RowIndex
                Cod_Tinta = DGVProd.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                Des_Tinta = DGVProd.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                Cod_Tipo = DGVProd.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                Des_Tipo = DGVProd.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                Status = DGVProd.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                Status_Bom = DGVProd.Rows(Fila_Seleccionada).Cells(5).Value.ToString
            

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            CB_Status.Checked = Status
            CB_StatusBom.Checked = Status_Bom
            TCodTinta.Text = Cod_Tinta
            TDesTinta.Text = Des_Tinta
            TCodTipo.Text = Cod_Tipo
            TDesTipo.Text = Des_Tipo

            tsbGrabar.Enabled = False
            BloqueaText(Me)
            BloqueaCheckBox(Me)

        End If
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Me.Close()
    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click
        Accion = "Modifica"
        If CB_Codigo.Text = "*" Then
            MsgBox("Seleccione un Producto para Modificar Compuesto")
            Return
        Else
            ActivaText(Me)
            ActivaButton(Me)
            ActivaCheckBox(Me)
            tsbAlta.Enabled = False
            tsbGrabar.Enabled = True
            CB_Codigo.Enabled = False
        End If
    End Sub

    Private Sub btnEmpaque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTintas.Click
        'Q = ""
        'Q = "SELECT a.C_tinta,a.D_Tinta "
        'Q = Q & "FROM CatTintas_Aditivos a, CatTipoTintaAditivo b "
        'Q = Q & "Where a.Cve_tipo = b.Cve_tipo "
        'Q = Q & "And a.Centro = b.Centro "
        'Q = Q & "And a.Centro = '" & SessionUser._sCentro.Trim & "' "
        'Q = Q & "And a.Status = '1' "
        'frmSpro.SPRO_TITULO = "Descripción de Tintas"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "C_tinta"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TCodTinta.Text = frmSpro.SPRO_KEY
        '    'Descripción Tinta
        '    Q = ""
        '    Q = "SELECT D_Tinta FROM CatTintas_Aditivos "
        '    Q = Q & " WHERE C_tinta = '" & TCodTinta.Text.Trim & "' "
        '    TDesTinta.Text = TraeDescripcion(Q)
        '    'Codigo Tipo
        '    Q = ""
        '    Q = "SELECT Cve_Tipo FROM CatTintas_Aditivos "
        '    Q = Q & " WHERE C_tinta = '" & TCodTinta.Text.Trim & "' "
        '    TCodTipo.Text = TraeDescripcion(Q)
        '    'Descripción Tipo
        '    Q = ""
        '    Q = "SELECT b.Descripcion FROM CatTintas_Aditivos a, CatTipoTintaAditivo b "
        '    Q = Q & "Where a.Cve_tipo = b.Cve_tipo "
        '    Q = Q & "And a.Centro = b.Centro "
        '    Q = Q & "And a.Centro = '" & SessionUser._sCentro.Trim & "' "
        '    Q = Q & "And a.C_tinta = '" & TCodTinta.Text.Trim & "' "
        '    Q = Q & "And a.Status = '1' "
        '    TDesTipo.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
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
                    InQry = "INSERT INTO AsignacionTintas(Centro,C_PT,C_Tinta,Cve_Tipo,Status,Bom) "
                    InQry = InQry & " Values ( '" & SessionUser._sCentro.Trim & "','" & CodPT.Trim & "','" & TCodTinta.Text.Trim & "',"
                    InQry = InQry & "'" & TCodTipo.Text.Trim & "','" & CB_Status.CheckState & "','" & CB_StatusBom.CheckState & "')"
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
                    InQry = " UPDATE AsignacionTintas SET Status = '" & CB_Status.CheckState & "', "
                    InQry = InQry & "Bom = '" & CB_StatusBom.CheckState & "', "
                    InQry = InQry & "Cve_Tipo = '" & TCodTipo.Text.Trim & "' "
                    InQry = InQry & "WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
                    InQry = InQry & "AND C_PT = '" & CodPT.Trim & "'"
                    InQry = InQry & "AND C_Tinta = '" & TCodTinta.Text.Trim & "'"
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
        CB_Codigo.Enabled = True
        Accion = ""
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click

        If CB_Codigo.Text.Trim = "*" Or CB_Codigo.Text.Trim = "" Then
            Mensajes("*** El campo CODIGO debe tener valor *** ", 1)
            Exit Sub
        End If

        If TCodTinta.Text.Trim = "" Then
            Mensajes("*** Capture la unidad de MEDIDA del Producto Terminado *** ", 1)
            Exit Sub
        End If

        CodPT = CB_Codigo.SelectedValue.Trim

        Try
            If Accion = "Alta" Then
                QRY = ""
                QRY = QRY & " SELECT C_Tinta FROM AsignacionTintas "
                QRY = QRY & " WHERE Centro ='" & SessionUser._sCentro.Trim & "' "
                QRY = QRY & "AND C_PT ='" & CB_Codigo.SelectedValue.Trim & "' "
                QRY = QRY & "AND C_Tinta ='" & TCodTinta.Text.Trim & "' "
                LecturaQry(QRY)
                If LecturaBD.Read Then
                    Mensajes("***  Producto ya existe *** ", 1)
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
        If CB_Codigo.Text = "*" Then
            MsgBox("Seleccione un Producto para Asignar Compuesto")
            Return
        Else
            tsbGrabar.Enabled = True
            ActivaText(Me)
            ActivaButton(Me)
            ActivaCheckBox(Me)
            LimpiarCheckBox(Me)
            LimpiarText(Me)
        End If
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
        CB_Codigo.Enabled = True
        CB_Codigo.Text = "*"
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click


        CodPT = CB_Codigo.SelectedValue.Trim

        QRY = ""
        NameTable = ""
        NameTable = "BorrarTinta"
        QRY = "Delete AsignacionTintas "
        QRY = QRY & "Where C_PT = '" & CodPT.Trim & "' "
        QRY = QRY & "And C_Tinta = '" & Cod_Tinta.Trim & "' "
        QRY = QRY & "And Centro = '" & SessionUser._sCentro.Trim & "' "
        LecturaQry(QRY)

        CargaGrid()

    End Sub
End Class