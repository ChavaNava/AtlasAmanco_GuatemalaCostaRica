Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class CAT_Prod_Compuesto
    Inherits Atlas.Master_Cat
#Region "Variables Miembro"
    Dim Status_Bom As Boolean
    Dim CodProd As String
    Dim CodComp As String
    Dim DesComp As String
    Dim DesClase As String
    Dim RepGen As String
    Dim Scrap As String
    Dim Accion As String
    Dim Estatus As Boolean
    'Variables proceso guardar
    Dim C_Mat As String
    Dim C_Comp As String
    Dim D_Comp As String
    Dim C_Clase As String
    'Variables combobox
    Dim INDX As Integer
    'Variables para compuestos nuevos
    Dim I_Clase As String
    Dim I_Tipo As String
#End Region

#Region "Constructores"

#End Region

#Region "Eventos"

    Private Sub CAT_Prod_Compuesto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Btn_Modifica.Enabled = False
        Btn_Modifica.Visible = False
        CB_CodComp.Enabled = False
        CB_CodProd.Enabled = True
        Catalogo_Materiales.Combo_Materiales(CB_CodProd, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, EXTINY)
        PBActualiza.Visible = False
        Label22.Visible = False
        Label22.Text = ""
        Btn_Guardar.Enabled = False
    End Sub

    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        CargaGrid()
    End Sub

    Private Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nuevo.Click
        Btn_Guardar.Enabled = True
        CB_Bom.Enabled = True
        CB_Bom.Checked = False
        CB_CodProd.Enabled = False
        CB_CodComp.Enabled = True
        Catalogo_Material_Compuesto.Combo_Mat_Comp(CB_CodComp, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, EXTINY)
        Accion = "Nuevo"
        Btn_Nuevo.Enabled = False
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        If CB_CodProd.Text.Trim = "*" Or CB_CodProd.Text.Trim = "" Then
            MensajeBox.Mostrar("El campo CODIGO debe tener valor ", "Campo Vacio", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End If

        If CB_CodComp.Text.Trim = "" Then
            MensajeBox.Mostrar("Capture la unidad de MEDIDA del Producto Terminado ", "Campo Vacio", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End If
        If Accion = "Nuevo" Then
            'Valida que el compuesto ya este asignado al material
            Try
                LecturaQry("PA_Consulta_Compuesto '" & SessionUser._sCentro.Trim & "', '" & CB_CodProd.SelectedValue.Trim & "', '" & CB_CodComp.SelectedValue.Trim & "' ")
                If (LecturaBD.Read) Then
                    MensajeBox.Mostrar("EL compuesto ya esta asignado a el Material ", "Aviso", MensajeBox.TipoMensaje.Information)
                    LecturaBD.Close()
                    Exit Sub
                Else
                    'Se extraen valores del compuesto seleccionado
                    Dim arryCompuesto() As String
                    Try
                        arryCompuesto = Catalogo_Material_Compuesto.Consulta_Compuesto(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, CB_CodComp.SelectedValue.Trim).Split("|")
                        I_Clase = arryCompuesto(1)
                        I_Tipo = arryCompuesto(2)
                    Catch ex As Exception
                        MensajeBox.Mostrar("Error '" & ex.ToString & "' ", "Error", MensajeBox.TipoMensaje.Critical)
                        Exit Sub
                    End Try
                    Label22.Visible = True
                    Label22.Text = "SE ASIGANARA COMPUESTO AL MATERIAL '" & CB_CodProd.SelectedValue.Trim & "'"
                End If
                LecturaBD.Close()
            Catch ex As Exception
                MensajeBox.Mostrar("Error '" & ex.ToString & "' ", "Error", MensajeBox.TipoMensaje.Critical)
                LecturaBD.Close()
                Exit Sub
            End Try
            'Valida que no exista mas de un compuesto bom
            If CB_Bom.Checked Then
                Try
                    LecturaQry("PA_Consulta_Compuesto_Bom '" & SessionUser._sCentro.Trim & "', '" & CB_CodProd.SelectedValue.Trim & "' ")
                    If (LecturaBD.Read) Then
                        MensajeBox.Mostrar("Ya existen un compuesto Bom dado de alta no puedes existir mas de uno ", "Aviso", MensajeBox.TipoMensaje.Information)
                        LecturaBD.Close()
                        Exit Sub
                    End If
                    LecturaBD.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    LecturaBD.Close()
                    Exit Sub
                End Try
            End If
        End If

        'Se asigna valores a variables
        C_Mat = CB_CodProd.SelectedValue.Trim
        C_Comp = CB_CodComp.SelectedValue.Trim
        D_Comp = CB_CodComp.Text.Trim

        PBActualiza.Visible = True
        BGW1.WorkerReportsProgress = True
        BGW1.RunWorkerAsync()
    End Sub

    Private Sub Btn_Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifica.Click

    End Sub

    Private Sub Btn_Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Elimina.Click

        C_Mat = CB_CodProd.SelectedValue.Trim
        'C_Comp = CB_CodComp.SelectedValue.Trim
        'D_Comp = CB_CodComp.Text.Trim

        Result = MensajeBox.Mostrar("La relacion Material/Compuesto sera eliminada de forma definitiva,  ¿ esta seguro ?", "Baja", MensajeBox.TipoMensaje.Exclamation, MensajeBox.TipoBoton.OkCancel)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            Accion = "Baja"
            Label22.Visible = True
            Label22.Text = "SE DARA DE BAJA EL COMPUESTO '" & CodComp.Trim & "' DEL MATERIAL '" & C_Mat.Trim & "'"
            PBActualiza.Visible = True
            BGW1.WorkerReportsProgress = True
            BGW1.RunWorkerAsync()
        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            Return
        End If



    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        If Btn_Guardar.Enabled = True Then
            Btn_Guardar.Enabled = False
        End If
        If Btn_Nuevo.Enabled = False Then
            Btn_Nuevo.Enabled = True
        End If
        BloqueaText(Me)
        BloqueaButton(Me)
        BloqueaCheckBox(Me)
        LimpiarText(Me)
        LimpiarCheckBox(Me)
        CB_CodComp.Enabled = False
        CB_CodProd.Enabled = True
    End Sub

    Private Sub Btn_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Export.Click
        Util.ExportaExcel(DGV)
    End Sub

    Private Sub DGV_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            ControlDataGridView.DGV_Formating(DGV, 6, e)
        End If
    End Sub

    Private Sub CB_CodProd_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_CodProd.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_CodComp_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_CodComp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargaGrid()
        Catalogo_Material_Compuesto.Catalogo_Materiales_Compuesto(DGV, SessionUser._sCentro.Trim, CB_CodProd.SelectedValue.Trim, SessionUser._sAlias.Trim, EXTINY)
    End Sub

    Private Sub DGV_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGV.CurrentCell.RowIndex
                CodComp = DGV.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                DesComp = DGV.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                DesClase = DGV.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                Status_Bom = DGV.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                RepGen = DGV.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                Scrap = DGV.Rows(Fila_Seleccionada).Cells(6).Value.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            CB_Bom.Checked = Status_Bom
            CB_CodComp.Text = CodComp.Trim + " " + DesComp.Trim
            Btn_Guardar.Enabled = False
            Btn_Elimina.Enabled = True
            BloqueaText(Me)
            BloqueaButton(Me)
            BloqueaCheckBox(Me)

        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW1.DoWork
        BGW1.ReportProgress(15)
        System.Threading.Thread.Sleep(2000) ' Para simular tiempo de espera
        BGW1.ReportProgress(30)

        Select Case Accion
            Case Is = "Nuevo"
                Try
                    BGW1.ReportProgress(50)
                    Catalogo_Material_Compuesto.Insert_Compuesto_Consumo(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, C_Mat.Trim, C_Comp.Trim, I_Clase.Trim, I_Tipo.Trim, CB_Bom.CheckState)
                    BGW1.ReportProgress(75)
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
            Case Is = "Baja"
                Try
                    BGW1.ReportProgress(50)
                    LecturaQry("PA_Borrar_Material_Compuesto '" & SessionUser._sCentro.Trim & "', '" & C_Mat.Trim & "', '" & CodComp.Trim & "' ")
                    BGW1.ReportProgress(75)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
        End Select
        BGW1.ReportProgress(100)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BGW1.ProgressChanged
        PBActualiza.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW1.RunWorkerCompleted
        MessageBox.Show("Información Actualizada")
        PBActualiza.Value = 0
        PBActualiza.Visible = False
        Label22.Visible = False
        Label22.Text = ""
        Accion = ""
        Btn_Guardar.Enabled = False
        Btn_Nuevo.Enabled = True
        PBActualiza.Value = 0
        PBActualiza.Visible = False
        CB_CodProd.Enabled = True
        CB_CodComp.Enabled = False
        CargaGrid()
    End Sub

#End Region

#Region "Propiedades"

#End Region
 

End Class