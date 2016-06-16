Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmAdmCatProgramas_AMEX
    Dim ConexionSQL As SqlConnection
    Dim ConexComando As SqlCommand
    Dim Consulta_1 As String
    Dim Cadena_conexion As String
    Dim StrPlanta As String     'Planta

    Dim Message As String = ""
    Dim Caption As String = ""
    Dim Result As DialogResult
    Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
    Dim Botones As MessageBoxButtons = MessageBoxButtons.OK

    ' ---------------------------------------------------------------------------------

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub FrmAdmCatProgramas_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Text = "Catalogo PROGRAMAS" & "CENTRO : " & StrPlanta.Trim


        PBActualiza.Visible = False
        tsbGrabar.Enabled = False
        BloqueaText(Me)
        BloqueaButton(Me)

        CargaGrid()

    End Sub

    Private Sub CargaGrid()

        QRY_AMD = ""
        NameTable = ""
        NameTable = "Programas"
        QRY_AMD = "SELECT Codprograma,Desprograma,status,usuarioreg,fechareg,Horareg From CatProgramas "
        QRY_AMD = QRY_AMD & "WHERE Centro = '" & StrPlanta.Trim & "' "
        Try
            objDa = New SqlDataAdapter(QRY_AMD, AbrirConfiguracion)
            objDs = New DataSet
            objDa.Fill(objDs)
            DGVProd.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGVProd.Columns(0).HeaderText = "Codigo Programa / Aplicacion"
        DGVProd.Columns(1).HeaderText = "Descripción Programa / Aplicacion"
        DGVProd.Columns(2).Visible = False  'Status
        DGVProd.Columns(3).Visible = False  'Usuario Reigstro
        DGVProd.Columns(4).Visible = False  'Fecha Registro
        DGVProd.Columns(5).Visible = False  'Hora Registro

    End Sub

    Private Sub DGVProd_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGVProd.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGVProd.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                'Dim Fila_Seleccionada As Integer = DGVProd.CurrentCell.RowIndex
                'txtCodigo.Text = DGVProd.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                'txtDescripcion.Text = DGVProd.Rows(Fila_Seleccionada).Cells(1).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            tsbGrabar.Enabled = False
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
        tsbAlta.Enabled = False
        tsbGrabar.Enabled = True
        txtCodigo.Enabled = False
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
                    'If EXTINY = "1" Then
                    '    InQry = "INSERT INTO " & TablaEXTINY.Trim & " (Centro,Codigo,Descr,UM,PesoEstandar,PesoTeorico,Empaque,Longitud,DiametroMM,Sobrepeso,Grpprod,Codseccion,Codusomaq,ValCompuesto,NumUnPaq,grupmaterial) "
                    '    InQry = InQry & " Values ( '" & StrPlanta.Trim & "','" & xCODIGO.Trim & "','" & xDESCRIPCION.Trim & "','" & xTUmPT.Trim & "'," & xTPesoEstandar.Trim & ","
                    '    InQry = InQry & xTPesoTeorico.Trim & ",'" & xTEmp.Trim & "'," & xTLongitud.Trim & "," & xTDiametro.Trim & "," & xTSobrePeso.Trim & ",'" & xTAREA.Trim & "','"
                    '    InQry = InQry & xTSECCION.Trim & "','" & xTUsoMaquina.Trim & "','1',0,'" & xTGrupmaterial.Trim & "')"
                    'Else
                    '    InQry = "INSERT INTO " & TablaEXTINY.Trim & " (Centro,Codigo,Descr,UM,PesoStandart,PesoTeorico,Empaque,Longitud,DiametroMM,Sobrepeso,Grpprod,Codseccion,Codusomaq,ValCompuesto,grupmaterial) "
                    '    InQry = InQry & " Values ( '" & StrPlanta.Trim & "','" & xCODIGO.Trim & "','" & xDESCRIPCION.Trim & "','" & xTUmPT.Trim & "'," & xTPesoEstandar.Trim & ","
                    '    InQry = InQry & xTPesoTeorico.Trim & ",'0'," & xTLongitud.Trim & "," & xTDiametro.Trim & "," & xTSobrePeso.Trim & ",'" & xTAREA.Trim & "','"
                    '    InQry = InQry & xTSECCION.Trim & "','" & xTUsoMaquina.Trim & "','1','" & xTGrupmaterial.Trim & "')"
                    'End If
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
                    'If EXTINY = "1" Then
                    '    InQry = " UPDATE " & TablaEXTINY.Trim & " SET Descr='" & xDESCRIPCION.Trim & "', UM='" & xTUmPT.Trim & "', PesoEstandar=" & xTPesoEstandar.Trim & ", PesoTeorico=" & xTPesoTeorico.Trim & ", Longitud=" & xTLongitud.Trim & ", DiametroMM=" & xTDiametro.Trim & ", Sobrepeso=" & xTSobrePeso.Trim & ", "
                    '    InQry = InQry & " Grpprod='" & xTAREA.Trim & "', Codseccion='" & xTSECCION.Trim & "', Codusomaq='" & xTUsoMaquina.Trim & "', grupmaterial='" & xTGrupmaterial.Trim & "', Empaque = '" & TEmpaque.Text.Trim & "' "
                    '    InQry = InQry & " WHERE Centro='" & StrPlanta.Trim & "' AND codigo='" & xCODIGO.Trim & "'"
                    'Else
                    '    InQry = " UPDATE " & TablaEXTINY.Trim & " SET Descr='" & xDESCRIPCION.Trim & "', UM='" & xTUmPT.Trim & "', PesoStandart=" & xTPesoEstandar.Trim & ", PesoTeorico=" & xTPesoTeorico.Trim & ", Longitud=" & xTLongitud.Trim & ", DiametroMM=" & xTDiametro.Trim & ", Sobrepeso=" & xTSobrePeso.Trim & ", "
                    '    InQry = InQry & " Grpprod='" & xTAREA.Trim & "', Codseccion='" & xTSECCION.Trim & "', Codusomaq='" & xTUsoMaquina.Trim & "', grupmaterial='" & xTGrupmaterial.Trim & "' "
                    '    InQry = InQry & " WHERE Centro='" & StrPlanta.Trim & "' AND codigo='" & xCODIGO.Trim & "'"
                    'End If
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
 
        ' ---------------------------------------------------------------------------------
        If txtCodigo.Text.Trim = "" Or txtDescripcion.Text.Trim = "" Then
            Mensajes("*** Los campos CODIGO Y DESCRIPCION deben tener valor *** ", 1)
            Exit Sub
        End If


        ' ---------------------------------------------------------------------------------
        'xCODIGO = txtCodigo.Text.Trim
        'xDESCRIPCION = txtDescripcion.Text.Trim
        Try

            ' ---------------------------------------------------------------------------------
            'If Accion = "Alta" Then
            '    QRY = ""
            '    QRY = QRY & " SELECT codigo FROM " & TablaEXTINY.Trim & " "
            '    QRY = QRY & " WHERE centro ='" & StrPlanta.Trim & "' AND codigo='" & xCODIGO.Trim & "'"
            '    LecturaQry(QRY)
            '    If LecturaBD.Read Then
            '        Mensajes("***  Producto ya existe *** ", 1)
            '        LecturaBD.Close()
            '        Exit Sub
            '    End If
            '    LecturaBD.Close()
            'End If
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
    End Sub
End Class