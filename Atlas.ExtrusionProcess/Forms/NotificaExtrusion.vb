Imports SQL_DATA
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports System.Drawing
Imports System.Windows.Forms

Public Class NotificaExtrusion

#Region "Variables"
    Dim Btn_Notificar As Integer = 0
    Dim TipoProd As String  'T = Producto Terminado S = Scrap
    'Variable estatus registro pesajes A-tlas
    Dim PesajeAtlas As Boolean

#End Region

#Region "Eventos"

#Region "Seleccion Bascula"
    Private Sub RB1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB1.CheckedChanged
        strNumeroBascula = ValCodigoBascula.Trim
        'If RB1.Checked Then
        '    Bascula.Selecciona(TPesoCaptura, Timer1, Timer2, Timer3, ValCodigoBascula.Trim, False, False, False, True, 1)
        'Else
        '    Bascula.Selecciona(TPesoCaptura, Timer1, Timer2, Timer3, ValCodigoBascula.Trim, True, False, False, False, 1)
        'End If
    End Sub

    Private Sub RB2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB2.CheckedChanged
        strNumeroBascula = ValCodigoBascula_2.Trim
        'If RB2.Checked Then
        '    Bascula.Selecciona(TPesoCaptura, Timer1, Timer2, Timer3, ValCodigoBascula.Trim, False, False, False, True, 2)
        'Else
        '    Bascula.Selecciona(TPesoCaptura, Timer1, Timer2, Timer3, ValCodigoBascula.Trim, False, True, False, False, 2)
        'End If
    End Sub

    Private Sub RB3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB3.CheckedChanged
        strNumeroBascula = ValCodigoBascula_3.Trim
        'If RB3.Checked Then
        '    Bascula.Selecciona(TPesoCaptura, Timer1, Timer2, Timer3, ValCodigoBascula.Trim, False, False, False, True, 3)
        'Else
        '    Bascula.Selecciona(TPesoCaptura, Timer1, Timer2, Timer3, ValCodigoBascula.Trim, False, False, True, False, 3)
        'End If
    End Sub
#End Region

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Close()
    End Sub

    Private Sub NotificaExtrusion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Centro.Text = SessionUser._sCentro
        'Se verifica conexión con SAP
        SAP_Conexion.EstatusBarr("E", tsImagen)
        'Inicializan fecha Turno y SAP
        InitializesFormExtrusion.Dates(dtpFECHA, dtpFECHASAP, chkSAP)
        InitializeForm()
        CustomizedForm()
    End Sub

    Private Sub TPassNotifier_Enter(sender As System.Object, e As System.EventArgs) Handles TPassNotifier.Enter
        TPassNotifier.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TPassNotifier_Leave(sender As System.Object, e As System.EventArgs) Handles TPassNotifier.Leave
        TPassNotifier.BackColor = Color.White
    End Sub

    Private Sub TPassNotifier_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPassNotifier.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            ValidaControlador()
        End If
    End Sub

    Private Sub TOrden_Enter(sender As System.Object, e As System.EventArgs) Handles TOrden.Enter
        TOrden.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TOrden_Leave(sender As System.Object, e As System.EventArgs) Handles TOrden.Leave
        TOrden.BackColor = Color.White
    End Sub

    Private Sub TOrden_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TOrden.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            ValidatesOrder()
        End If
    End Sub

    Private Sub BNotificar_Click(sender As System.Object, e As System.EventArgs) Handles BNotificar.Click
        If RB_PT.Checked Then
            'Notifica_PT()
        End If

        If RB_SC.Checked Then
            'Notifica_SC()
        End If
        '-------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub RB_SC_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_SC.CheckedChanged
        TipoProd = ""
        TipoProd = "S"
        If RB_SC.Checked = True Then
            TtramosNoti.Text = "0"
            TtramosNoti.ReadOnly = True
            TtramosNoti.BackColor = Color.White
            TOrden.Text = ""
            TOrden.Enabled = True
            BNotificar.Enabled = True
            TOrden.Focus()
        End If
    End Sub

    Private Sub TtramosNoti_Enter(sender As System.Object, e As System.EventArgs) Handles TtramosNoti.Enter
        If RB_SC.Checked = False Then
            TtramosNoti.BackColor = Color.LightSkyBlue
        End If
    End Sub

#End Region

#Region "Background Worker"
    Private Sub BGW1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW1.DoWork
        BGW1.ReportProgress(15)
        System.Threading.Thread.Sleep(2000) ' Para simular tiempo de espera
        BGW1.ReportProgress(30)
        Try
            BGW1.ReportProgress(50)
            BGW1.ReportProgress(60)
            BGW1.ReportProgress(70)
            BGW1.ReportProgress(80)
            BGW1.ReportProgress(90)
            BGW1.ReportProgress(95)
            Select Case SQL_DATA.OrdenProduccion.Alta("T", TOrden.Text)
                Case Is = True
                    PesajeAtlas = True
                    MensajeBox.Mostrar("Orden de Producción se ingreso correctamente  ", "Aviso", MensajeBox.TipoMensaje.Information)
                Case Is = False
                    PesajeAtlas = False
                    MensajeBox.Mostrar("Orden de Producción presenta errores revisar y volver a intentar  ", "Aviso", MensajeBox.TipoMensaje.Information)
            End Select
            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        BGW1.ReportProgress(100)
    End Sub

    Private Sub BGW1_ProgressChanged(sender As System.Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BGW1.ProgressChanged
        PBActualiza.Value = e.ProgressPercentage
    End Sub

    Private Sub BGW1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW1.RunWorkerCompleted
        PBActualiza.Value = 0
        PBActualiza.Visible = False
        Label22.Visible = False
        Label22.Text = ""
        Select Case PesajeAtlas
            Case Is = True
                ValidatesOrder()
            Case Is = False
                TOrden.Text = ""
                TOrden.Focus()
        End Select
    End Sub
#End Region

#Region "Metodos"

    Private Sub InitializeForm()
        Dim HReal As String = DateTime.Now.ToString("HH:mm:ss")
        InitializesFormExtrusion.Choose_Shift(cmbTurnos)
        InitializesFormExtrusion.Assign_Shift(cmbTurnos, HReal)
    End Sub

    Private Sub ValidaControlador()
        Dim Validate As Boolean
        Validate = Extrusion_Controller.Valid(TPassNotifier.Text.Trim)

        Select Case Validate
            Case Is = True
                CodOperador.Text = LoginNotifier._nAlias
                NomOperador.Text = LoginNotifier._nNombre
                RB_PT.Focus()
            Case Is = False
                MensajeBox.Mostrar("Nombre de usuario o contraseña incorrecta", "Verificar", MensajeBox.TipoMensaje.Exclamation)
                TPassNotifier.Text = ""
                TPassNotifier.Focus()
        End Select
    End Sub

    Private Sub CustomizedForm()
        ValidateUser(Parameterize.Forma(Me.Name, "VALIDA_USR"))
        GB_Basculas.Enabled = Parameterize.Forma(Me.Name, "MULTIBASCULA")
        LabelFolioVale.Visible = Parameterize.Forma(Me.Name, "FOLIOVALE")
        TFolioVale.Visible = Parameterize.Forma(Me.Name, "FOLIOVALE")
        CB_Ope.Enabled = Parameterize.Forma(Me.Name, "OPERADOR_PT")
    End Sub

    Private Sub ValidateUser(ByVal Valor As Boolean)
        Select Case Valor
            Case Is = True
                CodOperador.Text = SessionUser._sAlias
                NomOperador.Text = SessionUser._sNombre
                RB_PT.Focus()
            Case Is = False
                TPassNotifier.Focus()
        End Select
    End Sub

    Private Sub ValidatesOrder()
        If TOrden.Text <> "" Then
            'Verificar Existencia de Orden en A-tlas
            If SQL_DATA.OrdenProduccion.ValExistencia(TOrden.Text) Then
                Select Case SQL_DATA.OrdenProduccion.ValidaOrden(TOrden.Text)
                    Case Is = False
                        MensajeBox.Mostrar("Orden de Producción presenta errores revisar y volver a intentar  ", "Aviso", MensajeBox.TipoMensaje.Information, MensajeBox.TipoBoton.OkCancel)
                        TOrden.Text = ""
                        TOrden.Focus()
                        Exit Select
                    Case Is = True
                        SetFillOrden()
                        OrdenProduccion.Cantidades(TOrden.Text.Trim)
                        SetFillCantidades()
                        'Valida compuestos
                        Select Case SQL_DATA.Compuestos.ValidaConfigCompuesto(TCodPT.Text.Trim, TOrden.Text.Trim)
                            Case Is = False
                                MensajeBox.Mostrar("Este Material no tiene asignado compuesto para su consumo configurelo y vuelva a intentar ", "Aviso", MensajeBox.TipoMensaje.Information, MensajeBox.TipoBoton.OkOnly)
                                TOrden.Text = ""
                                TOrden.Focus()
                                Exit Select
                            Case Is = True
                                SQL_DATA.Catalogo_Operador_Puesto_Trabajo.CB_Operador_Linea(CB_Ope, TipoProd)
                                Select Case ConfigCompuestos._Cantidad
                                    Case Is = 1
                                        Select Case TipoProd
                                            Case Is = "T"
                                                SQL_DATA.Compuestos.CBComp1(CB_Com1, ConfigCompuestos._Codigo, ConfigCompuestos._Lista, 2)
                                            Case Is = "S"
                                                SQL_DATA.Compuestos.CBComp1(CB_Com1, ConfigCompuestos._Codigo, ConfigCompuestos._Lista, 3)
                                        End Select
                                    Case Is = 3
                                        CB_Comp1.Checked = True
                                        Dim Compuestos1() As String = New String() {Compuestos_1._Descripcion}
                                        CB_Com1.DropDownStyle = ComboBoxStyle.DropDown
                                        CB_Com1.DataSource = Compuestos1
                                        TPComp1.Text = Compuestos_1._Porcentaje

                                        CB_Comp2.Checked = True
                                        Dim Compuestos2() As String = New String() {Compuestos_2._Descripcion}
                                        CB_Com2.DropDownStyle = ComboBoxStyle.DropDown
                                        CB_Com2.DataSource = Compuestos2
                                        TPComp2.Text = Compuestos_2._Porcentaje


                                        CB_Comp3.Checked = True
                                        Dim Compuestos3() As String = New String() {Compuestos_3._Descripcion}
                                        CB_Com3.DropDownStyle = ComboBoxStyle.DropDown
                                        CB_Com3.DataSource = Compuestos3
                                        TPComp3.Text = Compuestos_3._Porcentaje

                                End Select

                        End Select
                End Select
            Else
                MensajeBox.Mostrar("Orden de Producción no existe en A-tlas desea darla de alta ", "Aviso", MensajeBox.TipoMensaje.Information, MensajeBox.TipoBoton.OkCancel)
                If MensajeBox.Respuesta = True Then
                    Label22.Visible = True
                    Label22.Text = "SE ESTA DANDO DE ALTA LA ORDEN " & TOrden.Text.Trim & ""
                    PBActualiza.Visible = True
                    BGW1.WorkerReportsProgress = True
                    BGW1.RunWorkerAsync()
                Else
                    TOrden.Text = ""
                    TOrden.Focus()
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub SetFillOrden()
        TPtoTrabajo.Text = OrderFill._Equipo
        TNomPtoTrabajo.Text = OrderFill._DEquipo
        TCodPT.Text = OrderFill._Codigo
        TCodPtDecr.Text = OrderFill._DCodigo
        TGrpprod.Text = OrderFill._GrupoProductivo
        TGrpproddesc.Text = OrderFill._DGrupoProductivo
        TPesoTeorico.Text = OrderFill._PesoTeorico
        TSP_Permitido.Text = OrderFill._SobrePeso
        TGrupo.Text = OrderFill._GrupoMaterial
        TPesoTeorico.Text = OrderFill._PesoTeorico
    End Sub

    Private Sub SetFillCantidades()
        Dim Res As Double
        Dim Programada As Double
        Dim Cant_Ent As Double
        Dim Cant_Proc As Double
        Dim Cant_Porg As Double
        Dim Cant_Entregada As Double

        TCantProgra.Text = OrdenCantidades._Cantidad
        TCantEntre.Text = OrdenCantidades._CantEntregada
        TCantEnproce.Text = OrdenCantidades._CantProceso
        TCantPendiente.Text = OrdenCantidades._CantPendientes

        If (OrdenCantidades._CantEntregada = "0" And OrdenCantidades._CantProceso = "0") Or OrdenCantidades._Cantidad = "0" Or (OrdenCantidades._CantEntregada = "" And OrdenCantidades._CantProceso = "") Or OrdenCantidades._Cantidad = "" Then
            Label8.Text = " "
        Else
            Programada = OrdenCantidades._Cantidad
            Cant_Ent = OrdenCantidades._CantEntregada
            Cant_Proc = OrdenCantidades._CantProceso
            Cant_Porg = OrdenCantidades._Cantidad
            Cant_Entregada = Cant_Ent + Cant_Proc

            If Cant_Entregada < OrdenCantidades._Cantidad Then
                Label8.ForeColor = Color.YellowGreen
                Res = Format((Cant_Entregada / Programada) * 100, "##0.00")
                Label8.Text = "Orden al : " & Res & " % "
            ElseIf Cant_Entregada = Programada Then
                Label8.ForeColor = Color.Green
                Res = Format((Cant_Entregada / Programada) * 100, "##0.00")
                Label8.Text = "Orden Completada al : " & Res & " %  "
            ElseIf Cant_Entregada > Programada Then
                Label8.ForeColor = Color.Red
                Res = Format(((Cant_Entregada / Programada) * 100) - (Programada / Programada) * 100, "##0.00")
                Label8.Text = "Orden Excedida en : " & Res & " % "
                If Btn_Notificar = 1 Then
                    MensajeBox.Mostrar("Orden Excedida en : " & Res & " %  ", "Orden Excedida", MensajeBox.TipoMensaje.Critical)
                End If
            End If
        End If
    End Sub

#End Region



End Class