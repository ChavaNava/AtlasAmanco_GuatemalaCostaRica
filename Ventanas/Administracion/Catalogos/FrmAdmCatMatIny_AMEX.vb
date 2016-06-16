Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmAdmCatMatIny_AMEX
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
    Dim C_CodMat As String
    Dim C_DesMat As String
    Dim C_DesCorta As String
    Dim C_TipoMat As String
    Dim C_DesTipo As String
    Dim C_UM As String
    Dim C_DesUM As String
    Dim C_Peso As String
    Dim C_Status As Boolean

    'Variables para grabar
    Dim CodPT As String

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub FrmAdmCatMatIny_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        NameTable = "Materiales"
        QRY_Grid = "Select a.Codigo,a.Descr,a.DescCorta,a.TipoMat,b.DesTipoEmb,a.UM,c.CatUM_descr,a.PesoUni,a.Status "
        QRY_Grid = QRY_Grid & "From CatMateriales a, EmbalajeTipo b, CatalogoUM c "
        QRY_Grid = QRY_Grid & "Where a.Centro = b.Centro "
        QRY_Grid = QRY_Grid & "And a.TipoMat = b.CveTipo "
        QRY_Grid = QRY_Grid & "And a.UM = c.CatUM_Clave "
        QRY_Grid = QRY_Grid & "And a.TipoProduccion = '2' "
        QRY_Grid = QRY_Grid & "And a.Centro = '" & SessionUser._sCentro.Trim & "' "
        QRY_Grid = QRY_Grid & "Order by a.Codigo "

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)
            DGVProd.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGVProd.Columns(0).HeaderText = "Codigo Material"
        DGVProd.Columns(1).HeaderText = "Descripción Material"
        DGVProd.Columns(2).HeaderText = "Descripción Corta"
        DGVProd.Columns(3).HeaderText = "Tipo Material"
        DGVProd.Columns(4).HeaderText = "Descripción Tipo"
        DGVProd.Columns(5).HeaderText = "Unidad de Medida"
        DGVProd.Columns(6).Visible = False      'Descripción Unidad de Medida
        DGVProd.Columns(7).HeaderText = "Peso Unitario"
        DGVProd.Columns(8).HeaderText = "Status"

    End Sub

    Private Sub DGVProd_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGVProd.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGVProd.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGVProd.CurrentCell.RowIndex
                C_CodMat = DGVProd.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                C_DesMat = DGVProd.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                C_DesCorta = DGVProd.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                C_TipoMat = DGVProd.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                C_DesTipo = DGVProd.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                C_UM = DGVProd.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                C_DesUM = DGVProd.Rows(Fila_Seleccionada).Cells(6).Value.ToString
                C_Peso = DGVProd.Rows(Fila_Seleccionada).Cells(7).Value.ToString
                C_Status = DGVProd.Rows(Fila_Seleccionada).Cells(8).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            TCodMat.Text = C_CodMat
            TDesMat.Text = C_DesMat
            TDesCorMat.Text = C_DesCorta
            TTipMat.Text = C_TipoMat
            TDesTipo.Text = C_DesTipo
            TUm.Text = C_UM
            TDesUm.Text = C_DesUM
            TPeso.Text = C_Peso
            CB_Status.Checked = C_Status


            tsbGrabar.Enabled = False
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
                    InQry = "INSERT INTO CatMateriales(Centro,Codigo,Descr,DescCorta,TipoMat,TipoProduccion,UM,PesoUni) "
                    InQry = InQry & "Values ( '" & SessionUser._sCentro.Trim & "','" & TCodMat.Text.Trim & "','" & TDesMat.Text.Trim & "',"
                    InQry = InQry & "'" & TDesCorMat.Text.Trim & "','" & TTipMat.Text.Trim & "','2','" & TUm.Text.Trim & "',"
                    InQry = InQry & "'" & TPeso.Text.Trim & "')"
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
                    InQry = " UPDATE CatMateriales SET Descr = '" & TDesMat.Text.Trim & "', "
                    InQry = InQry & "DescCorta = '" & TDesCorMat.Text.Trim & "', "
                    InQry = InQry & "TipoMat = '" & TTipMat.Text.Trim & "', "
                    InQry = InQry & "UM = '" & TUm.Text.Trim & "', "
                    InQry = InQry & "PesoUni = '" & TPeso.Text.Trim & "', "
                    InQry = InQry & "Status = '" & CB_Status.CheckState & "' "
                    InQry = InQry & "WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
                    InQry = InQry & "AND Codigo = '" & C_CodMat.Trim & "'"
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


        If TCodMat.Text.Trim = "" Then
            Mensajes("*** Capture la unidad de MEDIDA del Producto Terminado *** ", 1)
            Exit Sub
        End If


        Try
            If Accion = "Alta" Then
                QRY = ""
                QRY = QRY & " SELECT Codigo FROM CatMateriales "
                QRY = QRY & " WHERE Codigo = '" & TCodMat.Text.Trim & "' "
                QRY = QRY & "AND Centro ='" & SessionUser._sCentro.Trim & "' "
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
        ActivaText(Me)
        ActivaButton(Me)
        LimpiarText(Me)
        TCodMat.Focus()
    End Sub

    Private Sub btnLookUmPT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookUmPT.Click
        'Q = ""
        'Q = "SELECT CatUM_Clave, CatUM_Descr FROM CatalogoUM "
        'frmSpro.SPRO_TITULO = "Descripción de UM"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "CatUM_Descr"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TUm.Text = frmSpro.SPRO_KEY
        '    Q = ""
        '    Q = "SELECT CatUM_Descr FROM CatalogoUM "
        '    Q = Q & " WHERE CatUM_Clave = '" & TUm.Text.Trim & "' "
        '    TDesUm.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub

    Private Sub BtnEmpaque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpaque.Click
        'Q = ""
        'Q = "SELECT CveTipo,DesTipoEmb FROM EmbalajeTipo Where Centro = '" & strPlanta.Trim & "' "
        'frmSpro.SPRO_TITULO = "Descripción Tipo"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "DesTipoEmb"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TTipMat.Text = frmSpro.SPRO_KEY
        '    Q = ""
        '    Q = "SELECT DesTipoEmb FROM EmbalajeTipo "
        '    Q = Q & " WHERE CveTipo = '" & TTipMat.Text.Trim & "' "
        '    TDesTipo.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub

    Private Sub TSB_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSB_Cancelar.Click
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
        Caption = "Eliminar Código Tinta / Aditivo"
        Result = MessageBox.Show(Message, Caption, Buttons)
        If Result = System.Windows.Forms.DialogResult.Yes Then

            QRY = ""
            QRY = QRY & "Select * from Embalajes_PTI "
            QRY = QRY & "WHERE CodEmb = '" & C_CodMat.Trim & "' "
            QRY = QRY & "AND Centro ='" & SessionUser._sCentro.Trim & "' "
            LecturaQry(QRY)
            If LecturaBD.Read Then
                Mensajes("***  Aun Existen Productos que tiene asociado este codigo de Embalaje *** ", 1)
                LecturaBD.Close()
                Exit Sub
            End If
            LecturaBD.Close()

            QRY = ""
            NameTable = ""
            NameTable = "Tintas"
            QRY = "Delete CatMateriales "
            QRY = QRY & "Where Codigo = '" & C_CodMat.Trim & "' "
            QRY = QRY & "And Centro = '" & SessionUser._sCentro.Trim & "' "
            LecturaQry(QRY)

            CargaGrid()


        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            Return
        End If
    End Sub
End Class