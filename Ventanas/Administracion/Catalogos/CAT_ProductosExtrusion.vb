Imports System.Windows.Forms
Imports Atlas.Accesos.CLVarGlobales
Imports System.Data.SqlClient
Imports Utili_Generales
Imports System.Drawing.Text
Imports System.IO
Imports SQL_DATA

Public Class CAT_ProductosExtrusion
    Inherits Atlas.Master_Cat

#Region "Variables de Miembro"
    Dim PT As New ProductoTerminadoExtrusion
    'Variables Guardar
    Dim dCodigo As String
    Dim dDescrip As String
    Dim dUM As String
    Dim dEmpaque As String
    Dim dReten As String
    Dim dMarca As String
    Dim dCodBarr As String
    Dim dTSobrePeso As String
    Dim dTPesoTeorico As String
    Dim dTPesoEstandar As String
    Dim dTDiametro As String
    Dim dTLongitud As String
    Dim dArea As String
    Dim dSeccion As String
    Dim dUsoMaquina As String
    Dim dGpodiametro As String
    Dim dTipoComp As String
    Dim C_Status As Boolean
    Dim dTC As Integer
    Dim dVD As Integer
    Dim dCT As Integer
    'Variables combobox
    Dim INDX As Integer
    'Variables Parametros de la form
    Dim P_CC As Boolean = False     'Se habilita el consumo combinado
    Dim P_CRET As Boolean = False   'Se habilita el ComboBox de Retenes
    'Variables para el calculo de pesos
    Dim TC As Boolean
    Dim VD As Boolean
    Dim CT As Boolean
#End Region

#Region "Eventos"

    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        Carga_Grid()
        TCodProd.Enabled = True
    End Sub

    Private Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nuevo.Click
        Accion = "Alta"
        Btn_Guardar.Enabled = True
        ActivaText(Me)
        LimpiarText(Me)
        ActivaCombo(Me)
        Parametrizacion_Forma()
        Catalogo_Empaques.CB_Empaques(CB_EMP, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", "S", True, TCod_Empaque)
        Catalogo_Empaques.CB_Empaques(CB_Reten, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", Seccion, P_CRET, TCod_Reten)
        Catalogo_UM.CB_UM(CB_UM, SessionUser._sAlias.Trim, TCod_UM)
        Catalogo_Marcas.CB_Marcas(CB_Marcas, SessionUser._sAlias.Trim, TCod_Marca)
        Catalogo_Grupo_Materiales.CB_Gpo_Mat(CB_GpoDiam, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", EXTINY, TCod_GrpDiam)
        Catalogo_Familia_Producto.CB_Tip_Comp(CB_TipoComp, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_TipoComp)
        Catalogo_Secciones.CB_Secc(CB_Seccion, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_Seccion, EXTINY)
        Catalogo_Grupos.CB_Grupos(CB_Area, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_Area)
        Catalogo_Uso_Maquina.CB_Uso_Maq(CB_UsoMaq, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_UsoMaq)
        Dim_Pesos_Insert()
        RB_Dim_Pesos_Insert()
        CB_CC.Checked = False
        CB_State.Checked = True
        TCodBarr.Text = "0"
        TCodProd.Focus()
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        '------------------------------------------------------------------------------------------
        dCodigo = TCodProd.Text.Trim
        dDescrip = TDesProd.Text.Trim
        dUM = TCod_UM.Text.Trim
        dEmpaque = TCod_Empaque.Text.Trim
        dReten = TCod_Reten.Text.Trim
        dMarca = TCod_Marca.Text.Trim
        dCodBarr = TCodBarr.Text.Trim
        dArea = TCod_Area.Text.Trim
        dSeccion = TCod_Seccion.Text.Trim
        dUsoMaquina = TCod_UsoMaq.Text.Trim
        dGpodiametro = TCod_GrpDiam.Text.Trim
        dTipoComp = TCod_TipoComp.Text.Trim
        dTPesoTeorico = TPesoTeo.Text.Trim
        dTPesoEstandar = TPesoStn.Text.Trim
        dTLongitud = TLongitud.Text.Trim
        dTDiametro = TDiametro.Text.Trim
        dTSobrePeso = TSobrepeso.Text.Trim
        If RB_TC.Checked Then
            dTC = 1
        Else
            dTC = 0
        End If
        If RB_VD.Checked Then
            dVD = 1
        Else
            dVD = 0
        End If
        If RB_CT.Checked Then
            dCT = 1
        Else
            dCT = 0
        End If
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

        If TPesoTeo.Text.Trim = "" Or TPesoStn.Text.Trim = "" Or dTPesoTeorico = 0 Or dTPesoEstandar = 0 Then
            Mensajes("*** Los campos P. TEORICO Y P. ESTANDAR deben tener valor *** ", 1)
            Exit Sub
        End If

        If TLongitud.Text.Trim = "" Or TDiametro.Text.Trim = "" Or dTLongitud = 0 Or dTDiametro = 0 Then
            Mensajes("*** Los campos LONGITUD Y DIAMETRO deben tener valor *** ", 1)
            Exit Sub
        End If

        If TSobrepeso.Text.Trim = "" Or dTSobrePeso = -0 Then
            Mensajes("*** El campos SOBREPESO debe tener valor *** ", 1)
            TSobrepeso.Focus()
            Exit Sub
        End If
        If dArea.Trim = "" Or dSeccion.Trim = "" Or dUsoMaquina.Trim = "" Or dGpodiametro.Trim = "" Or dTipoComp.Trim = "" Then
            Mensajes("*** Los campos de AREA, SECCION, USO DE MAQUINA, GRUPO RTM, FAMILIA PRODUCTO Y GRUPO MATERIAL deben tener valor *** ", 1)
            TDiametro.Focus()
            Exit Sub
        End If
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
        Parametrizacion_Forma()
        Btn_Nuevo.Enabled = False
        Btn_Guardar.Enabled = True
        Btn_Elimina.Enabled = False
        TCodProd.Enabled = False
        TDesProd.Enabled = True
        TCodBarr.Enabled = True
        RB_Dim_Pesos_Edit()
    End Sub

    Private Sub Btn_Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Elimina.Click
        Message = "El código quedara en estatus deshabilitado,  ¿ esta seguro ?"
        Caption = "Eliminar Código de Producto"
        Result = MessageBox.Show(Message, Caption, Buttons)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            Catalogo_Materiales.Baja_PTE(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TCodProd.Text.Trim, EXTINY, 0)
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
        Btn_Nuevo.Enabled = True
        Btn_Guardar.Enabled = False
        BloqueaText(Me)
        BloqueaCheckBox(Me)
        BloqueaCombo(Me)
        TCentro.Enabled = True
        TCentro.Text = SessionUser._sCentro.Trim
        TCodProd.Enabled = True
    End Sub

    Private Sub Btn_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Export.Click
        Util.ExportaExcel(DGV)
    End Sub

    Private Sub CAT_ProductosExtrusion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Accion = ""
        Btn_Modifica.Enabled = False
        Btn_Elimina.Enabled = False
        Btn_Cancel.Enabled = True
        PBActualiza.Visible = False
        BloqueaText(Me)
        BloqueaCheckBox(Me)
        BloqueaCombo(Me)
        RB_TC.Enabled = False
        RB_TC.Checked = False
        RB_VD.Enabled = False
        RB_VD.Checked = False
        RB_CT.Enabled = False
        RB_CT.Checked = False
        TCentro.Enabled = True
        TCentro.Text = SessionUser._sCentro.Trim
        TCodProd.Enabled = True
        PT.cargarfuente()
        LCodBarr.Text = ""
        '--------------------------------------------------------------------------------------------
        'Parametrizacion de la Form
        P_CC = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, Me.Name, "CONSUMO_COMB")
        P_CRET = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, Me.Name, "RETENES")
        '--------------------------------------------------------------------------------------------
        Label22.Visible = False
        Label22.Text = ""
    End Sub

    Private Sub DGV_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            ControlDataGridView.DGV_Formating(DGV, 12, e)
        End If
    End Sub

    Private Sub TCodProd_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub CB_EMP_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_EMP.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Reten_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Reten.KeyPress
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

    Private Sub CB_Area_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Area.KeyPress
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

    Private Sub CB_Area_Leave(sender As System.Object, e As System.EventArgs) Handles CB_Area.Leave
        INDX = CB_Area.SelectedIndex
        If INDX > -1 Then
            TCod_Area.Text = CB_Area.SelectedValue
        End If
    End Sub

    Private Sub CB_UsoMaq_Leave(sender As System.Object, e As System.EventArgs) Handles CB_UsoMaq.Leave
        INDX = CB_UsoMaq.SelectedIndex
        If INDX > -1 Then
            TCod_UsoMaq.Text = CB_UsoMaq.SelectedValue
        End If
    End Sub

    Private Sub VD_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_VD.CheckedChanged
        If Accion = "Modifica" Or Accion = "Alta" Then
            If RB_VD.Checked Then
                TBEMT.Enabled = False
                TBEMN.Enabled = False
                TDiametro.Enabled = True
                TLongitud.Enabled = True
                TBEngroso.Enabled = False
                TBArea.Enabled = False
                TBExpMax.Enabled = False
                TBDiamMax.Enabled = False
                TBLongEngroso.Enabled = False
                TBPitch.Enabled = False
                TBGama.Enabled = False
                TPesoStn.Enabled = True
                TPesoTeo.Enabled = True
                TSobHist.Enabled = False
                TSobProm.Enabled = False
                TSobrepeso.Enabled = True
            End If
        End If
    End Sub

    Private Sub TC_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_TC.CheckedChanged
        If Accion = "Modifica" Or Accion = "Alta" Then
            If RB_TC.Checked Then
                TBEMT.Enabled = False
                TBEMN.Enabled = False
                TDiametro.Enabled = False
                TLongitud.Enabled = False
                TBEngroso.Enabled = False
                TBArea.Enabled = False
                TBExpMax.Enabled = False
                TBDiamMax.Enabled = False
                TBLongEngroso.Enabled = False
                TBPitch.Enabled = False
                TBGama.Enabled = False
                TPesoStn.Enabled = False
                TPesoTeo.Enabled = False
                TSobHist.Enabled = False
                TSobProm.Enabled = False
                TSobrepeso.Enabled = False
            End If
        End If
    End Sub

    Private Sub CT_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_CT.CheckedChanged
        If Accion = "Modifica" Or Accion = "Alta" Then
            If RB_CT.Checked Then
                TBEMT.Enabled = False
                TBEMN.Enabled = False
                TDiametro.Enabled = False
                TLongitud.Enabled = False
                TBEngroso.Enabled = False
                TBArea.Enabled = False
                TBExpMax.Enabled = False
                TBDiamMax.Enabled = False
                TBLongEngroso.Enabled = False
                TBPitch.Enabled = False
                TBGama.Enabled = False
                TPesoStn.Enabled = False
                TPesoTeo.Enabled = False
                TSobHist.Enabled = False
                TSobProm.Enabled = False
                TSobrepeso.Enabled = False
            End If
        End If
    End Sub

    Private Sub CB_EMP_Click(sender As System.Object, e As System.EventArgs) Handles CB_EMP.Click
        If Accion = "Modifica" Then
            Catalogo_Empaques.CB_Empaques(CB_EMP, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", "S", True, TCod_Empaque)
        End If
    End Sub

    Private Sub CB_EMP_Leave(sender As System.Object, e As System.EventArgs) Handles CB_EMP.Leave
        INDX = CB_EMP.SelectedIndex
        If INDX > -1 Then
            TCod_Empaque.Text = CB_EMP.SelectedValue
        End If
    End Sub

    Private Sub CB_Reten_Click(sender As System.Object, e As System.EventArgs) Handles CB_Reten.Click
        If Accion = "Modifica" Then
            Catalogo_Empaques.CB_Empaques(CB_Reten, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", "R", P_CRET, TCod_Reten)
        End If
    End Sub

    Private Sub CB_Reten_Leave(sender As System.Object, e As System.EventArgs) Handles CB_Reten.Leave
        INDX = CB_Reten.SelectedIndex
        If INDX > -1 Then
            TCod_Reten.Text = CB_Reten.SelectedValue
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

    Private Sub CB_Area_Click(sender As System.Object, e As System.EventArgs) Handles CB_Area.Click
        If Accion = "Modifica" Then
            Catalogo_Grupos.CB_Grupos(CB_Area, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_Area)
        End If
    End Sub

    Private Sub CB_UsoMaq_Click(sender As System.Object, e As System.EventArgs) Handles CB_UsoMaq.Click
        Catalogo_Uso_Maquina.CB_Uso_Maq(CB_UsoMaq, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", TCod_UsoMaq)
    End Sub

    Private Sub DGV_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DGV.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Btn_Modifica.Enabled = True
            Btn_Elimina.Enabled = True
            Try
                Dim Fila_Seleccionada As Integer = DGV.CurrentCell.RowIndex
                TCentro.Text = DGV.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                TCodProd.Text = DGV.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                TDesProd.Text = DGV.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                TCod_UM.Text = DGV.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                TPesoTeo.Text = DGV.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                TPesoStn.Text = DGV.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                TCod_Empaque.Text = DGV.Rows(Fila_Seleccionada).Cells(6).Value.ToString
                TCod_Reten.Text = DGV.Rows(Fila_Seleccionada).Cells(7).Value.ToString
                TLongitud.Text = DGV.Rows(Fila_Seleccionada).Cells(8).Value.ToString
                TDiametro.Text = DGV.Rows(Fila_Seleccionada).Cells(9).Value.ToString
                TSobrepeso.Text = DGV.Rows(Fila_Seleccionada).Cells(10).Value.ToString
                TCod_Area.Text = DGV.Rows(Fila_Seleccionada).Cells(11).Value.ToString
                CB_State.Checked = DGV.Rows(Fila_Seleccionada).Cells(12).Value.ToString
                TCod_Seccion.Text = DGV.Rows(Fila_Seleccionada).Cells(13).Value.ToString
                TCod_UsoMaq.Text = DGV.Rows(Fila_Seleccionada).Cells(14).Value.ToString
                TCod_GrpDiam.Text = DGV.Rows(Fila_Seleccionada).Cells(15).Value.ToString
                CB_UM.Text = DGV.Rows(Fila_Seleccionada).Cells(16).Value.ToString
                CB_EMP.Text = DGV.Rows(Fila_Seleccionada).Cells(17).Value.ToString
                CB_Reten.Text = DGV.Rows(Fila_Seleccionada).Cells(18).Value.ToString
                CB_Area.Text = DGV.Rows(Fila_Seleccionada).Cells(19).Value.ToString
                CB_Seccion.Text = DGV.Rows(Fila_Seleccionada).Cells(20).Value.ToString
                CB_UsoMaq.Text = DGV.Rows(Fila_Seleccionada).Cells(21).Value.ToString
                CB_GpoDiam.Text = DGV.Rows(Fila_Seleccionada).Cells(22).Value.ToString
                CB_CC.Checked = DGV.Rows(Fila_Seleccionada).Cells(23).Value.ToString
                TCod_TipoComp.Text = DGV.Rows(Fila_Seleccionada).Cells(26).Value.ToString
                CB_TipoComp.Text = DGV.Rows(Fila_Seleccionada).Cells(27).Value.ToString
                TCodBarr.Text = DGV.Rows(Fila_Seleccionada).Cells(28).Value.ToString
                TCod_Marca.Text = DGV.Rows(Fila_Seleccionada).Cells(29).Value.ToString
                CB_Marcas.Text = DGV.Rows(Fila_Seleccionada).Cells(30).Value.ToString
                TC = DGV.Rows(Fila_Seleccionada).Cells(31).Value.ToString
                VD = DGV.Rows(Fila_Seleccionada).Cells(32).Value.ToString
                CT = DGV.Rows(Fila_Seleccionada).Cells(33).Value.ToString
                'LCodBarr.Font = fuente
                'LCodBarr.Text = PT.FormatoCodigoBarras(TCodBarr.Text.Trim)
                RB_TC.Checked = TC
                RB_VD.Checked = VD
                RB_CT.Checked = CT
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub

#End Region

#Region "Metodos"
    Private Sub Carga_Grid()
        Catalogo_Materiales.Materiales(TCodProd.Text, DGV, TTotal, TCentro.Text.Trim, Me, SessionUser._sAlias.Trim, EXTINY)
    End Sub


    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW1.DoWork
        BGW1.ReportProgress(15)
        System.Threading.Thread.Sleep(2000) ' Para simular tiempo de espera
        BGW1.ReportProgress(30)
        Select Case Accion
            Case Is = "Alta"
                Try
                    BGW1.ReportProgress(50)
                    Catalogo_Materiales.Insert_PTE(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, dCodigo.Trim, dDescrip.Trim, dUM.Trim, _
                                                                  dTPesoEstandar, dTPesoTeorico, dEmpaque.Trim, dReten.Trim, dTLongitud, _
                                                                  dTDiametro, dTSobrePeso, dArea.Trim, dSeccion.Trim, dUsoMaquina.Trim, _
                                                                  dGpodiametro.Trim, CB_CC.CheckState, dTipoComp, SessionUser._sAlias.Trim, dCodBarr.Trim, _
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
                    Catalogo_Materiales.Update_PTE(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, dCodigo.Trim, dDescrip.Trim, dUM.Trim, _
                                                                dTPesoEstandar, dTPesoTeorico, dEmpaque.Trim, dReten.Trim, dTLongitud, _
                                                                dTDiametro, dTSobrePeso, dArea.Trim, dSeccion.Trim, dUsoMaquina.Trim, _
                                                                dGpodiametro.Trim, CB_CC.CheckState, dTipoComp, SessionUser._sAlias.Trim, dCodBarr.Trim, _
                                                                dTC, dVD, dCT, dMarca, EXTINY, CB_State.CheckState)
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
        RB_TC.Enabled = False
        RB_VD.Enabled = False
        RB_CT.Enabled = False
    End Sub

    Private Sub Limpiar()
        CB_UM.DataSource = Nothing
        CB_EMP.DataSource = Nothing
        CB_Area.DataSource = Nothing
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
        CB_CC.Enabled = P_CC
        CB_CC.Visible = P_CC
        CB_Reten.Enabled = P_CRET
        TCod_Reten.Enabled = P_CRET
    End Sub

    Private Sub Dim_Pesos_Insert()
        TBEMT.Text = "0"
        TBEMN.Text = "0"
        TDiametro.Text = "0"
        TLongitud.Text = "0"
        TBEngroso.Text = "0"
        TBArea.Text = "0"
        TBExpMax.Text = "0"
        TBDiamMax.Text = "0"
        TBLongEngroso.Text = "0"
        TBPitch.Text = "0"
        TBGama.Text = "0"
        TPesoStn.Text = "0"
        TPesoTeo.Text = "0"
        TSobHist.Text = "0"
        TSobProm.Text = "0"
        TSobrepeso.Text = "0"
        TBEMT.Enabled = False
        TBEMN.Enabled = False
        TDiametro.Enabled = False
        TLongitud.Enabled = False
        TBEngroso.Enabled = False
        TBArea.Enabled = False
        TBExpMax.Enabled = False
        TBDiamMax.Enabled = False
        TBLongEngroso.Enabled = False
        TBPitch.Enabled = False
        TBGama.Enabled = False
        TPesoStn.Enabled = False
        TPesoTeo.Enabled = False
        TSobHist.Enabled = False
        TSobProm.Enabled = False
        TSobrepeso.Enabled = False
    End Sub

    Private Sub RB_Dim_Pesos_Insert()
        RB_TC.Enabled = True
        RB_TC.Checked = False
        RB_VD.Enabled = True
        RB_VD.Checked = False
        RB_CT.Enabled = True
        RB_CT.Checked = False
    End Sub

    Private Sub RB_Dim_Pesos_Edit()
        RB_TC.Enabled = True
        RB_TC.Checked = TC
        RB_VD.Enabled = True
        RB_VD.Checked = VD
        RB_CT.Enabled = True
        RB_CT.Checked = CT
    End Sub
#End Region

End Class