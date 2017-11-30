Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmAdmCatEmpExt_AMEX
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
    Dim C_CodEmp As String
    Dim C_DesEmp As String
    Dim C_Peso As String

    'Variables para grabar
    Dim CodPT As String

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub FrmAdmCatEmpExt_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        NameTable = "CatalogoEmpaques"
        QRY_Grid = "Select CodEmp,DesEmp,Peso,UMed "
        QRY_Grid = QRY_Grid & "From Empaques_PTE "
        QRY_Grid = QRY_Grid & "Where Centro = '" & SessionUser._sCentro.Trim & "' "

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGVProd.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGVProd.Columns(0).HeaderText = "Codigo Empaque"
        DGVProd.Columns(1).HeaderText = "Descripción Empaque"
        DGVProd.Columns(2).HeaderText = "Peso"
        DGVProd.Columns(3).HeaderText = "Unidad de Medida"
   
    End Sub

    Private Sub DGVProd_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGVProd.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGVProd.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGVProd.CurrentCell.RowIndex
                C_CodEmp = DGVProd.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                C_DesEmp = DGVProd.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                C_Peso = DGVProd.Rows(Fila_Seleccionada).Cells(2).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            TCodEmp.Text = C_CodEmp
            TDesEmp.Text = C_DesEmp
            TPeso.Text = C_Peso


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
                    InQry = "INSERT INTO CAT_Empaques(Centro,C_Empaque,D_Empaque,Peso,C_UM) "
                    InQry = InQry & " Values ( '" & SessionUser._sCentro.Trim & "','" & TCodEmp.Text.Trim & "','" & TDesEmp.Text.Trim & "',"
                    InQry = InQry & "'" & TPeso.Text.Trim & "','Kg')"
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
                    InQry = " UPDATE Empaques_PTE SET DesEmp = '" & TDesEmp.Text.Trim & "', "
                    InQry = InQry & "Peso = '" & TPeso.Text.Trim & "' "
                    InQry = InQry & "WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
                    InQry = InQry & "AND CodEmp = '" & C_CodEmp.Trim & "'"
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


        If TCodEmp.Text.Trim = "" Then
            Mensajes("*** Capture la unidad de MEDIDA del Producto Terminado *** ", 1)
            Exit Sub
        End If


        Try
            If Accion = "Alta" Then
                QRY = ""
                QRY = QRY & " SELECT CodEmp FROM CAT_Empaques "
                QRY = QRY & " WHERE C_Empaque = '" & TCodEmp.Text.Trim & "' "
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
        Caption = "Eliminar Código Empaque"
        Result = MessageBox.Show(Message, Caption, Buttons)
        If Result = System.Windows.Forms.DialogResult.Yes Then


            QRY = ""
            QRY = QRY & " SELECT * FROM ProductoTerminadoExtrusion "
            QRY = QRY & " WHERE Empaque = '" & C_CodEmp.Trim & "' "
            QRY = QRY & "AND Centro ='" & SessionUser._sCentro.Trim & "' "
            LecturaQry(QRY)
            If LecturaBD.Read Then
                Mensajes("***  Aun Existen Productos que tienen asociado este codigo de Empaque *** ", 1)
                LecturaBD.Close()
                Exit Sub
            End If
            LecturaBD.Close()

            QRY = ""
            NameTable = ""
            NameTable = "Empaque"
            QRY = "Delete Empaques_PTE "
            QRY = QRY & "Where CodEmp = '" & C_CodEmp.Trim & "' "
            QRY = QRY & "And Centro = '" & SessionUser._sCentro.Trim & "' "
            LecturaQry(QRY)

            CargaGrid()

        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            Return
        End If

    End Sub

End Class