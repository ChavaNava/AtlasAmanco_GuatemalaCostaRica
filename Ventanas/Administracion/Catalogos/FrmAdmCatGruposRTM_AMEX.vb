Imports System.Data.SqlClient
Imports Atlas.Accesos.CLVarGlobales
Imports Utili_Generales
Imports SQL_DATA
Public Class FrmAdmCatGruposRTM_AMEX
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
    Dim Cve_Sec As String
    Dim Des_Sec As String
    Dim Stat As String
    Dim UsrReg As String
    Dim FecReg As String
    Dim HraReg As String

    'Variables de Alta o Modificación
    Dim A_Cve_Sec As String
    Dim A_Des_Sec As String
    Dim A_Stat As String
    Dim A_UsrReg As String
    Dim A_FecReg As String
    Dim A_HraReg As String

    'Variables para grabar
    Dim CodPT As String

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub FrmAdmCatGruposRTM_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        NameTable = "RTM"
        QRY_Grid = "Select codseccion,Desseccion,status,usuarioreg,fechareg,Horareg "
        QRY_Grid = QRY_Grid & "From CatSecciones "
        QRY_Grid = QRY_Grid & "Where Centro = '" & SessionUser._sCentro.Trim & "' "
        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGVSecc.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGVSecc.Columns(0).HeaderText = "Código Sección"
        DGVSecc.Columns(1).HeaderText = "Descripción"
        DGVSecc.Columns(2).Visible = False    'Status
        DGVSecc.Columns(3).HeaderText = "Usuario Registro"
        DGVSecc.Columns(4).HeaderText = "Fecha Alta"
        DGVSecc.Columns(5).HeaderText = "Hora Alta"

    End Sub

    Private Sub DGVProd_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGVSecc.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGVSecc.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGVSecc.CurrentCell.RowIndex
                Cve_Sec = DGVSecc.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                Des_Sec = DGVSecc.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                Stat = DGVSecc.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                UsrReg = DGVSecc.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                FecReg = DGVSecc.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                HraReg = DGVSecc.Rows(Fila_Seleccionada).Cells(5).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            TCodSec.Text = Cve_Sec
            TDesSec.Text = Des_Sec

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
        TCodSec.Enabled = False
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

        If TCodSec.Text.Trim = "" Then
            Mensajes("*** Capture La Clave del Area  *** ", 1)
            Exit Sub
        End If

        If TDesSec.Text.Trim = "" Then
            Mensajes("*** Capture la Descripción del Area *** ", 1)
            Exit Sub
        End If

        A_Cve_Sec = TCodSec.Text.Trim
        A_Des_Sec = TDesSec.Text.Trim
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
                QRY = QRY & "SELECT codseccion FROM CatSecciones "
                QRY = QRY & "WHERE codseccion = '" & TCodSec.Text.Trim & "' "
                QRY = QRY & "AND Centro ='" & SessionUser._sCentro.Trim & "' "
                LecturaQry(QRY)
                If LecturaBD.Read Then
                    Mensajes("***  Código de Sección ya existe *** ", 1)
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
                    InQry = "INSERT INTO CatSecciones(Centro,codseccion,Desseccion,status,usuarioreg,fechareg,Horareg) "
                    InQry = InQry & " Values ( '" & SessionUser._sCentro.Trim & "','" & A_Cve_Sec.Trim & "','" & A_Des_Sec.Trim & "',"
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
                    InQry = " UPDATE CatSecciones SET Desseccion = '" & TDesSec.Text.Trim & "', "
                    InQry = InQry & "Status = '" & A_Stat.Trim & "', "
                    InQry = InQry & "usuarioreg = '" & A_UsrReg.Trim & "', "
                    InQry = InQry & "fechareg = '" & A_FecReg.Trim & "', "
                    InQry = InQry & "Horareg = '" & A_HraReg.Trim & "' "
                    InQry = InQry & "WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
                    InQry = InQry & "AND codseccion = '" & TCodSec.Text.Trim & "'"
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
        TCodSec.Focus()
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
            QRY = QRY & "WHERE CodSeccion = '" & Cve_Sec.Trim & "' "
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
            NameTable = "Secciones"
            QRY = "Delete CatSecciones "
            QRY = QRY & "Where codseccion = '" & Cve_Sec.Trim & "' "
            QRY = QRY & "And Centro = '" & SessionUser._sCentro.Trim & "' "
            LecturaQry(QRY)

            CargaGrid()

        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            Return
        End If

    End Sub
End Class