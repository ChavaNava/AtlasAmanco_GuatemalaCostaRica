Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmAdmCatGrupos_AMEX
    Dim myDataReader As SqlClient.SqlDataReader
    Dim Q As String
    Dim ConexionSQL As SqlConnection
    Dim ConexComando As SqlCommand

    Dim Message As String = ""
    Dim Caption As String = ""
    Dim Result As DialogResult
    Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
    Dim Botones As MessageBoxButtons = MessageBoxButtons.OK

    'Variables de lectura
    Dim Cve_Grp As String
    Dim Des_Grp As String
    Dim Stat As String
    Dim UsrReg As String
    Dim FecReg As String
    Dim HraReg As String

    'Variables de Alta o Modificación
    Dim A_Cve_Grp As String
    Dim A_Des_Grp As String
    Dim A_Stat As String
    Dim A_UsrReg As String
    Dim A_FecReg As String
    Dim A_HraReg As String

    'Variables para grabar
    Dim CodPT As String

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub FrmAdmCatGrupos_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        NameTable = "CatalogoGrupos"
        QRY_Grid = "Select grpprod,desgrupo,status,usuarioreg,fechareg,horareg "
        QRY_Grid = QRY_Grid & "From catgrupos "
        QRY_Grid = QRY_Grid & "Where Centro = '" & SessionUser._sCentro.Trim & "' "
        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)
            DGVGrupos.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGVGrupos.Columns(0).HeaderText = "Clave Grupo"
        DGVGrupos.Columns(1).HeaderText = "Descripción"
        DGVGrupos.Columns(2).Visible = False    'Status
        DGVGrupos.Columns(3).HeaderText = "Usuario Registro"
        DGVGrupos.Columns(4).HeaderText = "Fecha Alta"
        DGVGrupos.Columns(5).HeaderText = "Hora Alta"

    End Sub

    Private Sub DGVProd_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGVGrupos.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGVGrupos.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGVGrupos.CurrentCell.RowIndex
                Cve_Grp = DGVGrupos.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                Des_Grp = DGVGrupos.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                Stat = DGVGrupos.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                UsrReg = DGVGrupos.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                FecReg = DGVGrupos.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                HraReg = DGVGrupos.Rows(Fila_Seleccionada).Cells(5).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            TCodGrp.Text = Cve_Grp
            TDesGrp.Text = Des_Grp

            If Stat = "A" Then
                CB_Status.Checked = True
            Else
                CB_Status.Checked = False
            End If

            tsbGrabar.Enabled = False
            tsbModificar.Enabled = True
            BloqueaText(Me)
            BloqueaCheckBox(Me)
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
        If Stat = "A" Then
            CB_Status.Checked = True
        Else
            CB_Status.Checked = False
        End If
        TCodGrp.Enabled = False
        tsbAlta.Enabled = False
        tsbGrabar.Enabled = True
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

        If TCodGrp.Text.Trim = "" Then
            Mensajes("*** Capture La Clave del Area  *** ", 1)
            Exit Sub
        End If

        If TDesGrp.Text.Trim = "" Then
            Mensajes("*** Capture la Descripción del Area *** ", 1)
            Exit Sub
        End If

        A_Cve_Grp = TCodGrp.Text.Trim
        A_Des_Grp = TDesGrp.Text.Trim
        If CB_Status.Checked = True Then
            A_Stat = "A"
        Else
            A_Stat = "B"
        End If
        A_UsrReg = SessionUser._sAlias.Trim
        A_FecReg = Date.Today.ToString("yyyy-MM-dd")
        A_HraReg = Date.Now.TimeOfDay.ToString



        If Accion = "Alta" Then

            Try
                QRY = ""
                QRY = QRY & "SELECT grpprod FROM CatGrupos "
                QRY = QRY & "WHERE grpprod = '" & TCodGrp.Text.Trim & "' "
                QRY = QRY & "AND Centro ='" & SessionUser._sCentro.Trim & "' "
                LecturaQry(QRY)
                If LecturaBD.Read Then
                    Mensajes("***  Clave Area ya existe *** ", 1)
                    LecturaBD.Close()
                    Exit Sub
                End If
                LecturaBD.Close()

            Catch ex1 As Exception
                MsgBox(ex1.Message)
                Exit Sub
            End Try

        End If
        ' ---------------------------------------------------------------------------------

        PBActualiza.Visible = True

        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.RunWorkerAsync()

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
                    InQry = "INSERT INTO CatGrupos(Centro,grpprod,desgrupo,status,usuarioreg,fechareg,Horareg) "
                    InQry = InQry & " Values ( '" & SessionUser._sCentro.Trim & "','" & A_Cve_Grp.Trim & "','" & A_Des_Grp.Trim & "',"
                    InQry = InQry & "'" & A_Stat.Trim & "','" & A_UsrReg.Trim & "','" & A_FecReg & "','" & A_HraReg & "')"
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
                    InQry = " UPDATE CatGrupos SET desgrupo = '" & TDesGrp.Text.Trim & "', "
                    InQry = InQry & "Status = '" & A_Stat.Trim & "', "
                    InQry = InQry & "usuarioreg = '" & A_UsrReg.Trim & "', "
                    InQry = InQry & "fechareg = '" & A_FecReg.Trim & "', "
                    InQry = InQry & "Horareg = '" & A_HraReg.Trim & "' "
                    InQry = InQry & "WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
                    InQry = InQry & "AND grpprod = '" & TCodGrp.Text.Trim & "'"
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

    Private Sub tsbAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAlta.Click
        Accion = "Alta"
        tsbGrabar.Enabled = True
        ActivaButton(Me)
        ActivaText(Me)
        LimpiarText(Me)
        CB_Status.Checked = True
        TCodGrp.Focus()
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
        Message = "La Clave de Area quedara eliminada definitivamente, esta seguro de querer eliminarla"
        Caption = "Eliminar Clave de Area"
        Result = MessageBox.Show(Message, Caption, Buttons)
        If Result = System.Windows.Forms.DialogResult.Yes Then

            QRY = ""
            QRY = QRY & "SELECT * FROM ProductoTerminadoExtrusion "
            QRY = QRY & "WHERE grpprod = '" & Cve_Grp.Trim & "' "
            QRY = QRY & "AND Centro ='" & SessionUser._sCentro.Trim & "' "
            LecturaQry(QRY)
            If LecturaBD.Read Then
                Mensajes("***  Aun Existen Productos que tiene asociada esta clave *** ", 1)
                LecturaBD.Close()
                Exit Sub
            End If
            LecturaBD.Close()

            QRY = ""
            NameTable = ""
            NameTable = "Areas"
            QRY = "Delete CatGrupos "
            QRY = QRY & "Where grpprod = '" & Cve_Grp.Trim & "' "
            QRY = QRY & "And Centro = '" & SessionUser._sCentro.Trim & "' "
            LecturaQry(QRY)

            CargaGrid()

        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            Return
        End If

    End Sub
End Class