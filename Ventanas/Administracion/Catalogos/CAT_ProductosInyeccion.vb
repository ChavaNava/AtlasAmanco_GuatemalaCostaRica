Imports System.Windows.Forms
Imports Atlas.Accesos.CLVarGlobales
Imports System.Data.SqlClient
Imports Utili_Generales
Imports System.Drawing.Text
Imports System.IO
Imports SQL_DATA

Public Class CAT_ProductosInyeccion
    Inherits Atlas.Master_Cat
#Region "Variables de Miembro"
    Dim PT As New ProductoTerminadoExtrusion
    'Variables Guardar
    Dim dCodigo As String
    Dim dDescrip As String
    Dim dUM As String
    Dim dEmpaque As String
    Dim dMarca As String
    Dim dCodBarr As String
    Dim dArea As String
    Dim dSeccion As String
    Dim dUsoMaquina As String
    Dim dGpodiametro As String
    Dim dTipoComp As String
    Dim dPesoEstandar As String
    Dim dPesoTeorico As String
    Dim C_Status As Boolean
    Dim dTC As Integer
    Dim dVD As Integer
    Dim dCT As Integer
    'Variables combobox
    Dim INDX As Integer
    'Variables Parametros de la form
    Dim P_CC As Boolean
    'Variables para el calculo de pesos
    Dim TC As Boolean
    Dim VD As Boolean
    Dim CT As Boolean
#End Region

#Region "Eventos"
    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        Catalogo_Materiales.Materiales(TCodProd.Text, DGV, TTotal, TCentro.Text.Trim, Me, SessionUser._sAlias.Trim, EXTINY)
        TCodProd.Enabled = True
    End Sub

    Private Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nuevo.Click
        Accion = "Alta"
        Btn_Guardar.Enabled = True
        ActivaText(Me)
        LimpiarText(Me)
        ActivaCombo(Me)
        Catalogo_UM.CB_UM(CB_UM, SessionUser._sAlias.Trim, TCod_UM)
        Catalogo_Marcas.CB_Marcas(CB_Marcas, SessionUser._sAlias.Trim, TCod_Marca)
        Catalogo_Grupo_Materiales.CB_Gpo_Mat(CB_GpoDiam, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", EXTINY, TCod_GrpDiam)
        Catalogo_Familia_Producto.CB_Tip_Comp(CB_TipoComp, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_TipoComp)
        Catalogo_Secciones.CB_Secc(CB_Seccion, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_Seccion, EXTINY)
        'Catalogo_Grupos.CB_Grupos(CB_Area, SessionUser._sAlias.Trim, strPlanta.Trim, "", TCod_Area)
        Catalogo_Uso_Maquina.CB_Uso_Maq(CB_UsoMaq, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_UsoMaq)
        CB_State.Checked = True
        TCodBarr.Text = "0"
        TPS.Text = 0
        TPT.Text = 0
        TCodProd.Focus()
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        '------------------------------------------------------------------------------------------
        dCodigo = TCodProd.Text.Trim
        dDescrip = TDesProd.Text.Trim
        dUM = TCod_UM.Text.Trim
        dEmpaque = "0"
        dMarca = TCod_Marca.Text.Trim
        dCodBarr = TCodBarr.Text.Trim
        'dArea = TCod_Area.Text.Trim
        dSeccion = TCod_Seccion.Text.Trim
        dUsoMaquina = TCod_UsoMaq.Text.Trim
        dGpodiametro = TCod_GrpDiam.Text.Trim
        dTipoComp = TCod_TipoComp.Text.Trim
        dPesoEstandar = TPS.Text
        dPesoTeorico = TPT.Text
        LCodBarr.Font = fuente
        LCodBarr.Text = PT.FormatoCodigoBarras("0")
        '------------------------------------------------------------------------------------------
        If TCodProd.Text.Trim = "" Or TDesProd.Text.Trim = "" Then
            Mensajes("*** Los campos CODIGO Y DESCRIPCION deben tener valor *** ", 1)
            Exit Sub
        End If

        If dUM.Trim = "" Then
            Mensajes("*** Capture la unidad de MEDIDA del Producto Terminado *** ", 1)
            Exit Sub
        End If

        If dEmpaque.Trim = "" Then
            Mensajes("*** Capture EMPAQUE del Producto Terminado *** ", 1)
            Exit Sub
        End If
        'If dArea.Trim = "" Or dSeccion.Trim = "" Or dUsoMaquina.Trim = "" Or dGpodiametro.Trim = "" Or dTipoComp.Trim = "" Then
        '    Mensajes("*** Los campos de AREA, SECCION, USO DE MAQUINA, GRUPO RTM, FAMILIA PRODUCTO Y GRUPO MATERIAL deben tener valor *** ", 1)
        '    Exit Sub
        'End If
        Try
            ' ---------------------------------------------------------------------------------
            If Accion = "Alta" Then
                'Verifica que el producto no exista
                LecturaQry("PA_Consulta_Producto_Terminado_Contador '" & dCodigo.Trim & "', '" & SessionUser._sCentro.Trim & "', '" & EXTINY & "' ")
                If LecturaBD.Read Then
                    Mensajes("***  Producto ya existe *** ", 1)
                    LecturaBD.Close()
                    Exit Sub
                Else
                    Label22.Visible = True
                    Label22.Text = "SE ESTA INGRESANDO EL PRODUCTO CODIGO '" & dCodigo.Trim & "'"
                End If
                LecturaBD.Close()
            ElseIf Accion = "Modifica" Then
                Label22.Visible = True
                Label22.Text = "SE ESTA MODIFICANDO EL PRODUCTO CODIGO '" & dCodigo.Trim & "'"
            End If
            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        PBActualiza.Visible = True
        BGW1.WorkerReportsProgress = True
        BGW1.RunWorkerAsync()
    End Sub

    Private Sub Btn_Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifica.Click
        Accion = "Modifica"
        ActivaButton(Me)
        ActivaCheckBox(Me)
        ActivaCombo(Me)
        Btn_Nuevo.Enabled = False
        Btn_Guardar.Enabled = True
        Btn_Elimina.Enabled = False
        TCodProd.Enabled = False
        TDesProd.Enabled = True
        TCodBarr.Enabled = True
    End Sub

    Private Sub Btn_Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Elimina.Click
        Message = "El código quedara en estatus deshabilitado,  ¿ esta seguro ?"
        Caption = "Eliminar Código de Producto"
        Result = MessageBox.Show(Message, Caption, Buttons)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            QRY = ""
            NameTable = ""
            NameTable = "BorrarProducto"
            QRY = "Update CAT_ProductoTerminado "
            QRY = QRY & "Set Activo = 0  "
            QRY = QRY & "Where Codigo = '" & TCodProd.Text.Trim & "' "
            QRY = QRY & "And Centro = '" & SessionUser._sCentro.Trim & "' "
            QRY = QRY & "And C_Tipo = '" & EXTINY & "' "
            LecturaQry(QRY)
            Limpiar()
            Catalogo_Materiales.Materiales(TCodProd.Text, DGV, TTotal, TCentro.Text.Trim, Me, SessionUser._sAlias.Trim, EXTINY)
            TCodProd.Enabled = True
        Else
            If Result = System.Windows.Forms.DialogResult.No Then
                Return
            End If
        End If
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        PBActualiza.Visible = False
        Btn_Elimina.Enabled = True
        BloqueaText(Me)
        BloqueaCheckBox(Me)
        BloqueaCombo(Me)
        TCentro.Enabled = True
        TCentro.Text = SessionUser._sCentro.Trim
        TCodProd.Enabled = True
    End Sub

    Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Accion = ""
        Btn_Modifica.Enabled = False
        Btn_Elimina.Enabled = False
        Btn_Cancel.Enabled = False
        PBActualiza.Visible = False
        BloqueaText(Me)
        BloqueaCheckBox(Me)
        BloqueaCombo(Me)
        TCentro.Enabled = True
        TCentro.Text = SessionUser._sCentro.Trim
        TCodProd.Enabled = True
        PT.cargarfuente()
        LCodBarr.Text = ""
        'Parametrizacion de la Form
        P_CC = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, Me.Name, "CONSUMO_COMB")
        Parametrizacion_Forma()
        Label22.Visible = False
        Label22.Text = ""
    End Sub

    Private Sub DGV_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Btn_Modifica.Enabled = True
            Btn_Elimina.Enabled = True
            Btn_Cancel.Enabled = True
            Try
                Dim Fila_Seleccionada As Integer = DGV.CurrentCell.RowIndex
                TCentro.Text = DGV.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                TCodProd.Text = DGV.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                TDesProd.Text = DGV.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                TCod_UM.Text = DGV.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                'TCod_Area.Text = DGV.Rows(Fila_Seleccionada).Cells(11).Value.ToString
                CB_State.Checked = DGV.Rows(Fila_Seleccionada).Cells(12).Value.ToString
                TCod_Seccion.Text = DGV.Rows(Fila_Seleccionada).Cells(13).Value.ToString
                TCod_UsoMaq.Text = DGV.Rows(Fila_Seleccionada).Cells(14).Value.ToString
                TCod_GrpDiam.Text = DGV.Rows(Fila_Seleccionada).Cells(15).Value.ToString
                CB_UM.Text = DGV.Rows(Fila_Seleccionada).Cells(16).Value.ToString
                'CB_Area.Text = DGV.Rows(Fila_Seleccionada).Cells(19).Value.ToString
                CB_Seccion.Text = DGV.Rows(Fila_Seleccionada).Cells(20).Value.ToString
                CB_UsoMaq.Text = DGV.Rows(Fila_Seleccionada).Cells(21).Value.ToString
                CB_GpoDiam.Text = DGV.Rows(Fila_Seleccionada).Cells(22).Value.ToString
                TCod_TipoComp.Text = DGV.Rows(Fila_Seleccionada).Cells(26).Value.ToString
                CB_TipoComp.Text = DGV.Rows(Fila_Seleccionada).Cells(27).Value.ToString
                TCodBarr.Text = DGV.Rows(Fila_Seleccionada).Cells(28).Value.ToString
                TCod_Marca.Text = DGV.Rows(Fila_Seleccionada).Cells(29).Value.ToString
                CB_Marcas.Text = DGV.Rows(Fila_Seleccionada).Cells(30).Value.ToString
                LCodBarr.Font = fuente
                LCodBarr.Text = PT.FormatoCodigoBarras(TCodBarr.Text.Trim)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub Btn_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Export.Click
        Util.ExportaExcel(DGV)
    End Sub

    Private Sub DGV_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            ControlDataGridView.DGV_Formating(DGV, 12, e)
        End If
    End Sub

    Private Sub TCodProd_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TCodProd.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Marcas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Marcas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Marcas_Leave(sender As System.Object, e As System.EventArgs) Handles CB_Marcas.Leave
        INDX = CB_Marcas.SelectedIndex
        If INDX > -1 Then
            TCod_Marca.Text = CB_Marcas.SelectedValue
        End If
    End Sub

    Private Sub CB_UM_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_UM.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_UM_Leave(sender As System.Object, e As System.EventArgs) Handles CB_UM.Leave
        INDX = CB_UM.SelectedIndex
        If INDX > -1 Then
            TCod_UM.Text = CB_UM.SelectedValue
        End If
    End Sub

    Private Sub CB_GpoDiam_Leave(sender As System.Object, e As System.EventArgs) Handles CB_GpoDiam.Leave
        INDX = CB_GpoDiam.SelectedIndex
        If INDX > -1 Then
            TCod_GrpDiam.Text = CB_GpoDiam.SelectedValue
        End If
    End Sub

    Private Sub CB_GpoDiam_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_GpoDiam.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_TipoComp_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_TipoComp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Seccion_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Seccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_UsoMaq_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_UsoMaq.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_TipoComp_Leave(sender As System.Object, e As System.EventArgs) Handles CB_TipoComp.Leave
        INDX = CB_TipoComp.SelectedIndex
        If INDX > -1 Then
            TCod_TipoComp.Text = CB_TipoComp.SelectedValue
        End If
    End Sub

    Private Sub CB_Seccion_Leave(sender As System.Object, e As System.EventArgs) Handles CB_Seccion.Leave
        INDX = CB_Seccion.SelectedIndex
        If INDX > -1 Then
            TCod_Seccion.Text = CB_Seccion.SelectedValue
        End If
    End Sub

    Private Sub CB_UsoMaq_Leave(sender As System.Object, e As System.EventArgs) Handles CB_UsoMaq.Leave
        INDX = CB_UsoMaq.SelectedIndex
        If INDX > -1 Then
            TCod_UsoMaq.Text = CB_UsoMaq.SelectedValue
        End If
    End Sub

    Private Sub CB_Marcas_Click(sender As System.Object, e As System.EventArgs) Handles CB_Marcas.Click
        If Accion = "Modifica" Then
            Catalogo_Marcas.CB_Marcas(CB_Marcas, SessionUser._sAlias.Trim, TCod_Marca)
        End If
    End Sub

    Private Sub CB_UM_Click(sender As System.Object, e As System.EventArgs) Handles CB_UM.Click
        If Accion = "Modifica" Then
            Catalogo_UM.CB_UM(CB_UM, SessionUser._sAlias.Trim, TCod_UM)
        End If
    End Sub

    Private Sub CB_GpoDiam_Click(sender As System.Object, e As System.EventArgs) Handles CB_GpoDiam.Click
        If Accion = "Modifica" Then
            Catalogo_Grupo_Materiales.CB_Gpo_Mat(CB_GpoDiam, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", EXTINY, TCod_GrpDiam)
        End If
    End Sub

    Private Sub CB_TipoComp_Click(sender As System.Object, e As System.EventArgs) Handles CB_TipoComp.Click
        If Accion = "Modifica" Then
            Catalogo_Familia_Producto.CB_Tip_Comp(CB_TipoComp, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_TipoComp)
        End If
    End Sub

    Private Sub CB_Seccion_Click(sender As System.Object, e As System.EventArgs) Handles CB_Seccion.Click
        If Accion = "Modifica" Then
            Catalogo_Secciones.CB_Secc(CB_Seccion, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_Seccion, EXTINY)
        End If
    End Sub

    Private Sub CB_UsoMaq_Click(sender As System.Object, e As System.EventArgs) Handles CB_UsoMaq.Click
        Catalogo_Uso_Maquina.CB_Uso_Maq(CB_UsoMaq, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_UsoMaq)
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
                    Catalogo_Materiales.Insert_PTI(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, dCodigo.Trim, dDescrip.Trim, dUM.Trim, _
                                                                  dPesoEstandar, dPesoTeorico, dEmpaque.Trim, "0", "0", _
                                                                  "0", "30", dSeccion.Trim, dUsoMaquina.Trim, _
                                                                  dGpodiametro.Trim, 0, dTipoComp, SessionUser._sAlias.Trim, dCodBarr.Trim, _
                                                                  dTC, dVD, dCT, dMarca, EXTINY)
                    BGW1.ReportProgress(75)
                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
            Case Is = "Modifica"
                Try
                    BGW1.ReportProgress(50)
                    InQry = ""
                    InQry = " UPDATE CAT_ProductoTerminado SET Descr ='" & dDescrip.Trim & "', "
                    InQry = InQry & "UM = '" & dUM.Trim & "', "
                    InQry = InQry & "PesoEstandar = " & 0 & ", "
                    InQry = InQry & "PesoTeorico = " & 0 & ", "
                    InQry = InQry & "Longitud = " & 0 & ", "
                    InQry = InQry & "DiametroMM = " & 0 & ", "
                    InQry = InQry & "Sobrepeso = " & 0 & ", "
                    InQry = InQry & "Grpprod = '" & dArea.Trim & "', "
                    InQry = InQry & "Codseccion = '" & dSeccion.Trim & "', "
                    InQry = InQry & "Codusomaq = '" & dUsoMaquina.Trim & "', "
                    InQry = InQry & "grupmaterial = '" & dGpodiametro.Trim & "', "
                    InQry = InQry & "TipoCompuesto = '" & dTipoComp.Trim & "', "
                    InQry = InQry & "Empaque = '" & dEmpaque.Trim & "', "
                    InQry = InQry & "IdMarca = '" & dMarca.Trim & "', "
                    InQry = InQry & "CodBarr = '" & dCodBarr.Trim & "', "
                    InQry = InQry & "Usr_Cambio = '" & SessionUser._sAlias.Trim & "', "
                    InQry = InQry & "Activo = '" & CB_State.CheckState & "' "
                    InQry = InQry & "WHERE Centro ='" & SessionUser._sCentro.Trim & "' "
                    InQry = InQry & "AND codigo ='" & dCodigo.Trim & "' "
                    InQry = InQry & "AND C_Tipo ='" & EXTINY & "' "
                    InsertQry(InQry)
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
        Limpiar()
        Catalogo_Materiales.Materiales("", DGV, TTotal, TCentro.Text.Trim, Me, SessionUser._sAlias.Trim, EXTINY)
        MessageBox.Show("Información Actualizada")
        Btn_Guardar.Enabled = False
        Btn_Nuevo.Enabled = True
        PBActualiza.Value = 0
        PBActualiza.Visible = False
        Accion = ""
        Label22.Visible = False
        Label22.Text = ""
    End Sub

    Private Sub Limpiar()
        CB_UM.DataSource = Nothing
        'CB_Area.DataSource = Nothing
        CB_Seccion.DataSource = Nothing
        CB_UsoMaq.DataSource = Nothing
        CB_GpoDiam.DataSource = Nothing
        LimpiarText(Me)
        LimpiarCombo(Me)
        LimpiarCheckBox(Me)
        BloqueaText(Me)
        BloqueaCombo(Me)
        BloqueaCheckBox(Me)
    End Sub

    Private Sub Parametrizacion_Forma()

    End Sub

#End Region

End Class