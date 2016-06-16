Imports System.Windows.Forms
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports Utili_Generales.ValueText
Imports SQL_DATA
Public Class CAT_Racks
    Inherits Atlas.Master_Cat
#Region "Variables de Miembro"
    'Variables para alta rack
    Dim I_CRack As String
    Dim I_DRack As String
    Dim I_PesoRack As String
    Dim I_Activo As String
#End Region

#Region "Eventos"
    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        CargaGrid()
    End Sub

    Private Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nuevo.Click
        FrontUtils.LimpiarText(Me)
        FrontUtils.ActivaText(Me)
        Btn_Guardar.Enabled = True
        CB_State.Checked = True
        TPesoRack.Text = "0"
        TCodRack.Focus()
        Accion = "Alta"
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim Exist_Rack As Integer = 0
        'Se asigna valor a variables --------------------------------------------------------------
        I_CRack = TCodRack.Text.Trim
        I_DRack = TDesRack.Text.Trim
        I_PesoRack = TPesoRack.Text
        I_Activo = CB_State.CheckState
        'Validaciones Campos Obligatorios ---------------------------------------------------------
        If I_CRack.Trim = "" Or I_DRack.Trim = "" Then
            MensajeBox.Mostrar("Los campos CODIGO Y DESCRIPCION deben tener valor", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            Exit Sub
        End If
        If I_PesoRack = "0" Then
            MensajeBox.Mostrar("El campo PESO debe tener valor", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            Exit Sub
        End If
        'Determinando proceso por tipo de accion --------------------------------------------------
        If Accion = "Alta" Then
            Exist_Rack = Catalogo_Racks.Valida_Existencia_Rack(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, TCodRack.Text)

            If Exist_Rack = 0 Then
                Label22.Visible = True
                Label22.Text = "SE ESTA INGRESANDO LA TARIMA/RACK CODIGO '" & I_CRack.Trim & "'"
            Else
                MensajeBox.Mostrar("El Tarima/Rack que intenta registrar ya existe", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                TCodRack.Focus()
                Exit Sub
            End If
        ElseIf Accion = "Modifica" Then
            Label22.Visible = True
            Label22.Text = "SE ESTA MODIFICANDO LA TARIMA/RACK CODIGO '" & I_CRack.Trim & "'"
        End If

        PBActualiza.Visible = True
        BGW1.WorkerReportsProgress = True
        BGW1.RunWorkerAsync()

    End Sub

    Private Sub Btn_Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifica.Click
        FrontUtils.ActivaText(Me)
        FrontUtils.ActivaCheckBox(Me)
        Btn_Nuevo.Enabled = False
        Btn_Guardar.Enabled = True
        Btn_Elimina.Enabled = False
        TCodRack.Enabled = False
        Accion = "Modifica"
    End Sub

    Private Sub Btn_Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Elimina.Click
        I_CRack = TCodRack.Text.Trim

        Result = MensajeBox.Mostrar("El código quedara en estatus deshabilitado,  ¿ esta seguro ?", "Baja", MensajeBox.TipoMensaje.Exclamation, MensajeBox.TipoBoton.OkCancel)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            Accion = "Baja"
            Label22.Visible = True
            Label22.Text = "SE ESTA DANDO DE BAJA LA TARIMA/RACK CODIGO '" & I_CRack.Trim & "'"
            PBActualiza.Visible = True
            BGW1.WorkerReportsProgress = True
            BGW1.RunWorkerAsync()
        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            Return
        End If
    End Sub

    Private Sub Btn_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Export.Click
        Util.ExportaExcel(DGV)
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        PBActualiza.Visible = False
        Btn_Elimina.Enabled = True
        Btn_Guardar.Enabled = False
        BloqueaText(Me)
        BloqueaCheckBox(Me)
        BloqueaCombo(Me)
        TCodRack.Enabled = True
    End Sub

    Private Sub TPesoRack_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPesoRack.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Decimales(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CAT_Racks_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Label22.Visible = False
        Label22.Text = ""
        PBActualiza.Visible = False
        Btn_Elimina.Enabled = True
        BloqueaText(Me)
        BloqueaCheckBox(Me)
        TPesoRack.Text = "0"
        TCodRack.Enabled = True
        CargaGrid()
    End Sub

    Private Sub DGV_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            ControlDataGridView.DGV_Formating(DGV, 5, e)
        End If
    End Sub

    Private Sub DGV_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DGV.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Try
                Dim Fila_Seleccionada As Integer = DGV.CurrentCell.RowIndex
                TCodRack.Text = DGV.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                TDesRack.Text = DGV.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                TPesoRack.Text = DGV.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                CB_State.Checked = DGV.Rows(Fila_Seleccionada).Cells(5).Value.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub
#End Region

#Region "Metodos"
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW1.DoWork
        BGW1.ReportProgress(15)
        System.Threading.Thread.Sleep(2000) ' Para simular tiempo de espera
        BGW1.ReportProgress(30)
        Select Case Accion
            Case Is = "Alta"
                Try
                    BGW1.ReportProgress(50)
                    Try
                        Catalogo_Racks.Insert_Rack(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, I_CRack.Trim, I_DRack.Trim, I_PesoRack.Trim)
                    Catch ex As Exception
                        MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                        Exit Sub
                    End Try

                    BGW1.ReportProgress(75)
                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
            Case Is = "Modifica"
                Try
                    BGW1.ReportProgress(50)
                    Try
                        Catalogo_Racks.Update_Rack(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, I_CRack.Trim, I_DRack.Trim, I_PesoRack.Trim, I_Activo)
                    Catch ex As Exception
                        MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                        Exit Sub
                    End Try
                    BGW1.ReportProgress(75)
                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
            Case Is = "Baja"
                Try
                    BGW1.ReportProgress(50)
                    Catalogo_Racks.Baja_Rack(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, I_CRack.Trim, "0")
                    BGW1.ReportProgress(75)
                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
        End Select
        BGW1.ReportProgress(100)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BGW1.ProgressChanged
        PBActualiza.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW1.RunWorkerCompleted
        FrontUtils.BloquearText(Me)
        BloqueaCheckBox(Me)
        Btn_Guardar.Enabled = False
        Btn_Nuevo.Enabled = True
        Btn_Modifica.Enabled = True
        TCodRack.Enabled = True
        PBActualiza.Value = 0
        PBActualiza.Visible = False
        Label22.Visible = False
        Label22.Text = ""
        Accion = ""
        CargaGrid()
    End Sub

    Private Sub CargaGrid()
        Catalogo_Racks.Catalogo_Racks(SessionUser._sCentro.Trim, TCodRack.Text.Trim, SessionUser._sAlias.Trim, DGV)
    End Sub
#End Region

End Class