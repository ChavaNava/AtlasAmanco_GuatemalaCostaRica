Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Imports Utili_Generales
Imports Utili_Generales.ValueText
Public Class CAT_Equipo_Basico
    Inherits Atlas.Master_Cat
#Region "Variables de Miembro"
    'Variables para insertar registro
    Dim iCodEqp As String
    Dim iDesEqp As String
    Dim iMarca As String
    Dim iModelo As String
    Dim iCapacidad As String
    Dim iLimites As String
    Dim iEstatus As String
#End Region

#Region "Eventos"

    Private Sub CAT_Equipo_Basico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.Icon = Util.ApplicationIcon()
        Label22.Visible = False
        Label22.Text = ""
        TCodEqp.Enabled = True
        CargaGrid()
    End Sub

    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        CargaGrid()
    End Sub

    Private Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nuevo.Click
        FrontUtils.LimpiarText(Me)
        FrontUtils.ActivaText(Me)
        Btn_Guardar.Enabled = True
        CB_State.Checked = True
        TLimite.Text = 0
        TCapacidad.Text = 0
        Accion = "Alta"
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim Exis_Equipo As String = ""
        'Se asigna valor a variables --------------------------------------------------------------
        iCodEqp = TCodEqp.Text.Trim
        iDesEqp = TDesEqp.Text.Trim
        iMarca = TMarca.Text.Trim
        iModelo = TModelo.Text.Trim
        iCapacidad = TCapacidad.Text.Trim
        iLimites = TLimite.Text.Trim
        iEstatus = CB_State.CheckState
        'Validaciones Campos Obligatorios ---------------------------------------------------------
        If iCodEqp = "" Then
            MensajeBox.Mostrar("El campo código del equipo no puede ir vacio", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TCodEqp.Focus()
            Return
        End If

        If iDesEqp = "" Then
            MensajeBox.Mostrar("El campo descripción del equipo no puede ir vacio", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TDesEqp.Focus()
            Return
        End If

        If Accion = "Alta" Then
            Exis_Equipo = Catalogo_Puestos_Trabajo.Valida_Existencia_Puesto(TCodEqp.Text.Trim, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, EXTINY)

            If Exis_Equipo = "1" Then
                MensajeBox.Mostrar("El Puesto de trabajo que intenta registrar ya existe", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                TCodEqp.Focus()
                Return
            Else
                Label22.Visible = True
                Label22.Text = "SE ESTA INGRESANDO EL PUESTO DE TRABAJO CODIGO '" & iCodEqp.Trim & "'"
            End If
        ElseIf Accion = "Modifica" Then
            Label22.Visible = True
            Label22.Text = "SE ESTA MODIFICANDO EL PUESTO DE TRABAJO CODIGO '" & iCodEqp.Trim & "'"
        End If
        'Se activa proceso de fondo para la accion a realizar -------------------------------------
        PBActualiza.Visible = True
        BGW1.WorkerReportsProgress = True
        BGW1.RunWorkerAsync()
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub Btn_Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifica.Click
        FrontUtils.ActivaText(Me)
        FrontUtils.ActivaCheckBox(Me)
        Btn_Nuevo.Enabled = False
        Btn_Guardar.Enabled = True
        Btn_Elimina.Enabled = False
        TCodEqp.Enabled = False
        Accion = "Modifica"
    End Sub

    Private Sub Btn_Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Elimina.Click
        iCodEqp = TCodEqp.Text.Trim

        Result = MensajeBox.Mostrar("El código quedara en estatus deshabilitado,  ¿ esta seguro ?", "Baja", MensajeBox.TipoMensaje.Exclamation, MensajeBox.TipoBoton.OkCancel)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            Accion = "Baja"
            Label22.Visible = True
            Label22.Text = "SE ESTA DANDO DE BAJA EL PUESTO DE TRABAJO CODIGO '" & iCodEqp.Trim & "'"
            PBActualiza.Visible = True
            BGW1.WorkerReportsProgress = True
            BGW1.RunWorkerAsync()
        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            Return
        End If
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        FrontUtils.BloquearText(Me)
        Btn_Guardar.Enabled = False
        Btn_Nuevo.Enabled = True
        Btn_Modifica.Enabled = True
        TCodEqp.Enabled = True
        CargaGrid()
    End Sub

    Private Sub Btn_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Export.Click
        Util.ExportaExcel(DGV)
    End Sub

    Private Sub Btn_Actualiza_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Actualiza.Click

    End Sub

    Private Sub DGV_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            ControlDataGridView.DGV_Formating(DGV, 6, e)
        End If
    End Sub

    Private Sub DGV_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DGV.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            FrontUtils.BloquearText(Me)
            TCodEqp.Enabled = True
            Btn_Modifica.Enabled = True
            Btn_Elimina.Enabled = True
            Btn_Cancel.Enabled = True
            Try
                Dim Fila_Seleccionada As Integer = DGV.CurrentCell.RowIndex
                TCodEqp.Text = DGV.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                TDesEqp.Text = DGV.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                TMarca.Text = DGV.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                TModelo.Text = DGV.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                TCapacidad.Text = DGV.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                TLimite.Text = DGV.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                CB_State.Checked = DGV.Rows(Fila_Seleccionada).Cells(6).Value.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub TCapacidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TCapacidad.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TLimite_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TLimite.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub BGW1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW1.DoWork
        BGW1.ReportProgress(15)
        System.Threading.Thread.Sleep(2000) ' Para simular tiempo de espera
        BGW1.ReportProgress(30)
        Select Case Accion
            Case Is = "Alta"
                Try
                    BGW1.ReportProgress(50)
                    Catalogo_Puestos_Trabajo.Insert_Puesto_Trabajo(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, iCodEqp.Trim, iDesEqp.Trim, _
                                                                   EXTINY, iMarca.Trim, iModelo.Trim, iCapacidad, iLimites)
                    BGW1.ReportProgress(75)
                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
            Case Is = "Modifica"
                Try
                    BGW1.ReportProgress(50)
                    Catalogo_Puestos_Trabajo.Update_Puesto_Trabajo(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, iCodEqp.Trim, iDesEqp.Trim, _
                                                                   EXTINY, iMarca.Trim, iModelo.Trim, iCapacidad, iLimites, iEstatus)
                    BGW1.ReportProgress(75)
                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
            Case Is = "Baja"
                Try
                    BGW1.ReportProgress(50)
                    Catalogo_Puestos_Trabajo.Baja_Puesto_Trabajo(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TCodEqp.Text.Trim, EXTINY, 0)
                    BGW1.ReportProgress(75)
                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
        End Select
        BGW1.ReportProgress(100)
    End Sub

    Private Sub BGW1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BGW1.ProgressChanged
        PBActualiza.Value = e.ProgressPercentage
    End Sub

    Private Sub BGW1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW1.RunWorkerCompleted
        FrontUtils.BloquearText(Me)
        BloqueaCheckBox(Me)
        Btn_Guardar.Enabled = False
        Btn_Nuevo.Enabled = True
        Btn_Modifica.Enabled = True
        TCodEqp.Enabled = True
        PBActualiza.Value = 0
        PBActualiza.Visible = False
        Label22.Visible = False
        Label22.Text = ""
        Accion = ""
        CargaGrid()
    End Sub

    Private Sub CargaGrid()
        Catalogo_Puestos_Trabajo.Catalogo_Equipos(DGV, TCodEqp.Text.Trim, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, EXTINY)
    End Sub

#End Region

End Class