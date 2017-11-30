Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos
Imports Atlas.Accesos.CLVarGlobales
Imports Utili_Generales.ValueText

Public Class MenuPTI

#Region "Variables miembro"
    Dim PO As New ProductionOrder_2
    Dim NP As New NotificationProcess
    Dim TipoProd As String  'T = Producto Terminado S = Scrap
    Dim Clean As String
    Dim Lista As New Generic.List(Of String)
    'Variables Notificación
    Dim N_FechaPesaje As String
    Dim N_HoraPesaje As String
    Dim N_PB As Decimal
    Dim N_PT As Decimal
    Dim N_PN As Decimal
    'Dim N_Empaques As Integer
    Dim N_Tramos As Integer
    Dim N_FechaTurno As String
    Dim N_Turno As Integer
    Dim N_Supervisor As String
    'Dim N_Sobrepeso As Decimal
    'Dim N_PesoTeorico As Decimal
    Dim N_Area As String
    Dim N_TipoScrap As String
    Dim N_StSobrePeso As String
    Dim N_Comp_1 As String
    Dim N_Porc_1 As String
    Dim N_Cant_1 As String
    Dim N_Comp_2 As String
    Dim N_Porc_2 As String
    Dim N_Cant_2 As String
    Dim N_Comp_3 As String
    Dim N_Porc_3 As String
    Dim N_Cant_3 As String
    Dim N_OperadorLinea As String
    Dim N_CodUser As String
    Dim N_Rack As String
    Dim CompOriginal As String = ""
    Dim FechaTurno As String
    Dim FechaPesajeSAP As String
    Dim FolioSiguiente As String
    Dim N_LTCompuestos As String

    Dim Reprocesado_Orig As String = ""
    Dim Reprocesado_Gen As String

    'Variables para bascula
    Dim Cadena As String = ""
    Dim Lectura As String = ""
    Dim Cod_Err As String
    Dim CadenaTexto As String = ""

    'Variable que toma el peso neto resultado de la lectura de la bascula
    Dim V_PesoNeto As Decimal

    'Variables para compuestos
    Dim Comp_1 As String = "0"
    Dim Comp_2 As String = "0"
    Dim Comp_3 As String = "0"

    Dim Pass_md5 As String

#End Region

#Region "Eventos"
    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Close()
    End Sub

    Private Sub MenuPTI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Centro.Text = SessionUser._sCentro      'Clave Centro 
        NomCentro.Text = SessionUser._sPlanta   'Nombre Centro
        ' ---------------------------------------------------------------------------------
        'Se habilita bascula
        Permiso.Habilita_Bascula(SessionUser._sIdPerfil, TPesoCaptura, Timer1, ValCodigoBascula.Trim, LPesoCaptura)
        ' ---------------------------------------------------------------------------------
        'Se verifica conexión con SAP
        Permiso.SAP_Status("I", tsImagen)
        ' ---------------------------------------------------------------------------------
        'Inicializan fecha Turno y SAP
        Inicializa_Frm_PTEI(dtpFECHA, dtpFECHASAP, chkSAP)
        ' ---------------------------------------------------------------------------------
        'Parametrizacion de la Form
        Parametrizacion.Parametrized_Form(Me)
        Parametrizacion_Forma()
        ' ---------------------------------------------------------------------------------
        LimpiaObjetos()
        PassNotifier.Focus()
    End Sub

    Private Sub ClaveOperador_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles PassNotifier.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ClaveOperador_Leave(sender As System.Object, e As System.EventArgs) Handles PassNotifier.Leave
        Dim IdLogin As Boolean
        Pass_md5 = Crypto.MD5Calculate(PassNotifier.Text.Trim)
        IdLogin = Users.Login_Notifier(SessionUser._sAlias, Pass_md5.Trim)
        CodOperador.Text = ""
        NomOperador.Text = ""

        If IdLogin = True Then
            CodOperador.Text = LoginNotifier._nAlias
            NomOperador.Text = LoginNotifier._nNombre
            RB_PT.Focus()
        Else
            MensajeBox.Mostrar("Nombre de usuario o contraseña incorrecta", "Verificar", MensajeBox.TipoMensaje.Exclamation)
            PassNotifier.Text = ""
            PassNotifier.Focus()
        End If
    End Sub

    Private Sub RB_PT_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PT.CheckedChanged
        TipoProd = ""
        TipoProd = "T"
        CB_TipoSc.Enabled = False
        TtramosNoti.ReadOnly = False
        TtramosNoti.BackColor = Color.White
        CB_Proceso.Checked = False
        TOrden.Text = ""
        TOrden.Enabled = True
    End Sub

    Private Sub RB_SC_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_SC.CheckedChanged
        TipoProd = ""
        TipoProd = "S"
        CB_TipoSc.Enabled = True
        TtramosNoti.ReadOnly = True
        TtramosNoti.BackColor = Color.White
        TOrden.Text = ""
        TOrden.Enabled = True
        BNotificar.Enabled = True
        CB_Proceso.Checked = True
        TOrden.Focus()
    End Sub

    Private Sub TC_Orden_Enter(sender As System.Object, e As System.EventArgs) Handles TOrden.Enter
        TOrden.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TC_Orden_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TOrden.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TC_Orden_Leave(sender As System.Object, e As System.EventArgs) Handles TOrden.Leave
        ValidaOrden()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TOrden.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese un numero de Orden", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            Exit Sub
        Else
            PO.Actualiza_Orden_Produccion(TOrden.Text.Trim, "T")
        End If
    End Sub

    Private Sub TtramosNoti_Enter(sender As System.Object, e As System.EventArgs) Handles TtramosNoti.Enter
        If RB_SC.Checked = False Then
            TtramosNoti.BackColor = Color.LightSkyBlue
        End If
    End Sub

    Private Sub TtramosNoti_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TtramosNoti.KeyPress
        e.Handled = txtNumerico(TtramosNoti, e.KeyChar, True)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TtramosNoti_Leave(sender As System.Object, e As System.EventArgs) Handles TtramosNoti.Leave
        Dim arryEmbalajes() As String
        If RB_PT.Checked Then
            'If TtramosNoti.Text.Trim <> 0 Then
            '    TPesoEmpaque.Text = "0.00"
            '    Utili_Generales.ControlDataGridView.Colums_CalculaEmbalajes(DGV_Emb)
            '    'arryEmbalajes = Inyeccion.Embalajes(DGV_Emb, SessionUser._sCentro.Trim, SessionUser._sCentro.Trim + "_OrdenProduccion", TOrden.Text.Trim, TtramosNoti.Text, SessionUser._sAlias, TPesoEmpaque).Split("|")
            '    Pzas_Cajas = "0" & arryEmbalajes(0)
            '    Peso_Cajas = "0" & arryEmbalajes(1)
            '    Pzas_Bolsas = "0" & arryEmbalajes(2)
            '    Peso_Bolsas = "0" & arryEmbalajes(3)
            '    BNotificar.Enabled = True
            'End If
        End If
        CB_Rack.Focus()
    End Sub

    Private Sub CB_Rack_Enter(sender As System.Object, e As System.EventArgs) Handles CB_Rack.Enter
        CB_Rack.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub CB_Rack_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Rack.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Rack_Leave(sender As System.Object, e As System.EventArgs) Handles CB_Rack.Leave
        If CB_Rack.Text.Trim = "M" Then
            TPesoRack.ReadOnly = False
            TPesoRack.Text = "0"
            TC_Descrack.Text = "Peso Asignado Manualmente"
            TPesoRack.Focus()
        Else
            TPesoRack.ReadOnly = True
            TPesoRack.Text = CB_Rack.SelectedValue
        End If
    End Sub

    Private Sub TPesoRack_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPesoRack.TextChanged
        Dim xTPesoTara As Double
        xTPesoTara = "0" & TPesoRack.Text.Trim
        TPesoTara.Text = Format(xTPesoTara, xFormato)
    End Sub

    Private Sub TPesoCaptura_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPesoCaptura.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Decimales(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TPesoCaptura_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPesoCaptura.TextChanged
        Dim xTPesoCaptura As Double
        xTPesoCaptura = TPesoCaptura.Text.Trim
        TPesoBruto.Text = Format(xTPesoCaptura, xFormato)
    End Sub

    Private Sub TPesoBruto_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPesoBruto.TextChanged
        Dim xTPesoBruto As Double
        Dim xTPesoTara As Double
        Dim xTempaquePesoTot As Double
        Dim xTPesoNeto As Double

        xTPesoBruto = TPesoBruto.Text.Trim
        xTPesoTara = "0" & TPesoTara.Text.Trim
        xTempaquePesoTot = "0" & TPesoEmpaque.Text.Trim
        xTPesoNeto = xTPesoBruto - xTPesoTara - xTempaquePesoTot
        TPesoNeto.Text = Format(xTPesoNeto, xFormato)
    End Sub

    Private Sub TPesoTara_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPesoTara.TextChanged
        Dim xTPesoBruto As Double
        Dim xTPesoTara As Double
        Dim xTempaquePesoTot As Double
        Dim xTPesoNeto As Double
        Dim xTramos As Double

        xTramos = "0" & TtramosNoti.Text.Trim
        xTPesoBruto = "0" & TPesoBruto.Text.Trim
        xTPesoTara = "0" & TPesoTara.Text.Trim
        xTempaquePesoTot = "0" & TPesoEmpaque.Text.Trim
        xTPesoNeto = xTPesoBruto - (xTPesoTara + xTempaquePesoTot)
        TPesoNeto.Text = Format(xTPesoNeto, xFormato)
    End Sub

    Private Sub TPesoEmpaque_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPesoEmpaque.TextChanged
        Dim xTPesoBruto As Double
        Dim xTPesoTara As Double
        Dim xTempaquePesoTot As Double
        Dim xTPesoNeto As Double
        Dim xTramos As Double

        xTramos = "0" & TtramosNoti.Text.Trim
        xTPesoBruto = "0" & TPesoBruto.Text.Trim
        xTPesoTara = "0" & TPesoTara.Text.Trim
        xTempaquePesoTot = "0" & TPesoEmpaque.Text.Trim
        xTPesoNeto = xTPesoBruto - (xTPesoTara + xTempaquePesoTot)
        TPesoNeto.Text = Format(xTPesoNeto, xFormato)
    End Sub

    Private Sub TPesoNeto_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPesoNeto.TextChanged
        Dim xTramosNoti As Double
        Dim xPeso_Neto As Double
        xTramosNoti = "0" & TtramosNoti.Text.Trim
        xPeso_Neto = "" & TPesoNeto.Text.Trim
    End Sub

    Private Sub CB_Com1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Com1_TextChanged(sender As System.Object, e As System.EventArgs)
        If Clean <> "1" Then
            If CB_Com1.Text.Trim = "" Then
                MsgBox("Debe de seleccionar un compuesto a consumir", MsgBoxStyle.Information)
                CB_Com1.DataSource = Nothing
                Catalogo_Compuestos.CB_Compuesto1(CB_Com1, "S", "1", P_CC1)
            End If
        End If
    End Sub

    Private Sub TPComp1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CB_Com2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Com3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TPComp2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CB_Comp1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_Comp1.CheckedChanged
        TPComp1.Text = "100"
    End Sub

    Private Sub CB_Comp2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_Comp2.CheckedChanged
        If CB_Comp2.Checked Then
            'CBG.Con_Comp_rep(CB_Com2, TCodPT.Text.Trim, EXTINY)
            Catalogo_Compuestos.CB_Compuesto2(CB_Com2, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TCodPT.Text.Trim, EXTINY)
            CB_Com2.Enabled = True
            Comp_2 = CB_Com2.SelectedValue
            TPComp2.Text = "0"
            TPComp1.Text = "100"
            TPComp1.ReadOnly = False
            CB_Comp3.Checked = False
            CB_Comp3.Enabled = True
        Else
            CB_Com2.DataSource = Nothing
            CB_Com2.Text = ""
            CB_Com2.Enabled = False
            TPComp2.Text = "0"
            TPComp2.ReadOnly = True
            TPComp2.Enabled = False
            Comp_2 = ""
            TPComp1.Text = "100"
            TPComp1.ReadOnly = True
            CB_Comp3.Checked = False
            CB_Comp3.Enabled = False
        End If
    End Sub

    Private Sub CB_Comp3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_Comp3.CheckedChanged
        If CB_Comp3.Checked Then
            'CBG.Con_Comp_rep(CB_Com3, TCodPT.Text.Trim, EXTINY)
            Catalogo_Compuestos.CB_Compuesto2(CB_Com3, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TCodPT.Text.Trim, EXTINY)
            CB_Com3.Enabled = True
            TPComp2.Enabled = True
            TPComp2.ReadOnly = False
            TPComp3.Text = 0
            TPComp1.ReadOnly = True
        Else
            CB_Com3.DataSource = Nothing
            CB_Com3.Text = ""
            CB_Com3.Enabled = False
            TPComp3.Text = "0"
            TPComp2.Text = 100 - Val(TPComp1.Text)
            TPComp2.Enabled = False
            TPComp2.ReadOnly = True
            TPComp3.Enabled = False
            TPComp1.ReadOnly = False
        End If
    End Sub

    Private Sub TPComp1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPComp1.TextChanged
        Try
            If TPComp1.Text.Trim = 100 Then
                CB_Com2.Text = ""
                Comp_2 = "0"
                TPComp2.Text = 0
            ElseIf TPComp1.Text.Trim > 100 Then
                MessageBox.Show("No se permiten valores mayores al 100%")
                TPComp1.Text = "100"
            ElseIf TPComp1.Text <= 0 Then
                TPComp2.Text = 0
            Else
                TPComp2.Text = 100 - Val(TPComp1.Text)
                Comp_2 = CB_Com2.SelectedValue
            End If
            If TPComp1.Text.Trim = 0 Then
                MessageBox.Show("No se permite valor de 0% o negativos ")
                TPComp1.Text = "100"
            End If
        Catch ex As Exception
            TPComp1.Text = "100"
        End Try
    End Sub

    Private Sub TPComp1_KeyPress_1(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPComp1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TPComp2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPComp2.TextChanged
        If CB_Comp3.Checked Then
            TPComp3.Text = 100 - (Val(TPComp1.Text) + Val(TPComp2.Text))
            If TPComp3.Text > 100 Then
                MessageBox.Show("No es permitido que la suma de los porcentajes de compuestos sea mayor al 100% ")
                TPComp2.Text = 100 - Val(TPComp1.Text)
            ElseIf TPComp3.Text <= 0 Then
                MessageBox.Show("No es permitido que la suma de los porcentajes de compuestos sea menor al 100% ")
                TPComp2.Text = 100 - Val(TPComp1.Text)
            End If
        End If
    End Sub

    Private Sub BLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles BLimpiar.Click
        Limpiar()
        TPesoBruto.Text = "0.00"
        TPesoTara.Text = "0.00"
        TPesoEmpaque.Text = "0.00"
        TPesoNeto.Text = "0.00"
        PassNotifier.Focus()
    End Sub

    Private Sub BPesar_Click(sender As System.Object, e As System.EventArgs) Handles BNotificar.Click

        'Valida campos obligatorios ----------------------------------------------------------------------------
        If CodOperador.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese clave de operador", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            CodOperador.Focus()
            Return
        End If

        If TOrden.Text.Trim = "" Then
            MensajeBox.Mostrar("Debe de asignar una orden de fabricación", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TOrden.Focus()
            Return
        End If

        If TPtoTrabajo.Text.Trim = "" Then
            MensajeBox.Mostrar("La Orden de Producción no asignado Puesto de Trabajo", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            Return
        End If

        If CB_Com1.Text.Trim = "" Then
            MensajeBox.Mostrar("Seleccione un compuesto a consumir", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            CB_Com1.Focus()
            Return
        End If

        If TPComp1.Text = 0 Then
            MensajeBox.Mostrar("El porcenatje de participacion del compuesto 1 no puede ser 0", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TPComp1.Focus()
            Return
        End If

        If TPComp2.Text > 0 Then
            If CB_Com2.Text.Trim = "" Then
                MensajeBox.Mostrar("Seleccione un segundo compuesto a consumir", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                CB_Com2.Focus()
                Return
            End If
        End If
        If RB_PT.Checked Then
            Dim Sum_Comp As Integer = 0

            Sum_Comp = Suma_Compuestos(Val(TPComp1.Text), Val(TPComp2.Text), Val(TPComp3.Text))

            If Sum_Comp = 0 Then
                MensajeBox.Mostrar("La suma de consumo de compuestos debe de ser 100% no puede tener un valor en cero o sin valor", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                Return
            End If

            If Sum_Comp <= 0 Then
                MensajeBox.Mostrar("El porcentaje de compuestos no debe de ser cero o negativo", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                Return
            End If

            If Sum_Comp > 100 Then
                MensajeBox.Mostrar("El porcentaje de compuestos no debe de ser mayor al 100%", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                Return
            End If

            Notifica_PTI()

        End If

        If RB_SC.Checked Then
            Notifica_SC()
        End If
    End Sub

    Private Sub Notifica_PTI()
        Btn_Notificar = "1"

        If TtramosNoti.Text = 0 Then
            MensajeBox.Mostrar("No se a asignado cantidad de producto a notifica", "Aviso", MensajeBox.TipoMensaje.Information)
            TtramosNoti.Focus()
            Exit Sub
        End If

        'Se asigna valor a variables --------------------------------------------------------------
        'N_CodUser = CodOperador.Text.Trim
        'N_Tramos = TtramosNoti.Text.Trim
        N_PB = TPesoBruto.Text.Trim
        N_PT = TPesoTara.Text.Trim
        N_PN = TPesoNeto.Text.Trim
        'N_FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        'N_HoraPesaje = Date.Now.TimeOfDay.ToString()
        'N_Turno = cmbTurnos.Text.Trim
        'N_OperadorLinea = CB_Ope.SelectedValue
        'N_FechaTurno = dtpFECHA.Value.ToString("yyyy-MM-dd")
        FechaPesajeSAP = dtpFECHASAP.Value.ToString("yyyyMMdd")
        'Se valida peso bascula -------------------------------------------------------------------
        If ValidacionesBascula.ValidaPeso(N_PB, N_PT, N_PN) = False Then
            Exit Sub
        End If
        'Se asigna valor a variables de consumo compuestos 1, 2 y 3 --------------------------------------
        Dim aryTextFile() As String
        Dim Stat_Comp As Boolean

        Comp_1 = CB_Com1.SelectedValue
        Comp_2 = CB_Com2.SelectedValue
        Comp_3 = CB_Com3.SelectedValue

        aryTextFile = ValidacionesCompuestos.ValidaCompuestos_Inyeccion(N_PN, Comp_1, TPComp1.Text, Comp_2, _
                                                                        TPComp2.Text, Comp_3, TPComp3.Text).Split("|")

        Stat_Comp = aryTextFile(0)
        If Stat_Comp = False Then
            Exit Sub
        Else
            N_Comp_1 = aryTextFile(1)
            N_Porc_1 = aryTextFile(2)
            N_Cant_1 = aryTextFile(3)
            N_Comp_2 = aryTextFile(4)
            N_Porc_2 = aryTextFile(5)
            N_Cant_2 = aryTextFile(6)
            N_Comp_3 = aryTextFile(7)
            N_Porc_3 = aryTextFile(8)
            N_Cant_3 = aryTextFile(9)


            If N_Comp_1.Trim <> 0 Then
                Lista.Add(Util.QuitarCerosIzquierda(N_Comp_1.Trim) + "|" + N_Cant_1)
            End If

            If N_Comp_2.Trim <> 0 Then
                Lista.Add(Util.QuitarCerosIzquierda(N_Comp_2.Trim) + "|" + N_Cant_2)
            End If

            If N_Comp_3.Trim <> 0 Then
                Lista.Add(Util.QuitarCerosIzquierda(N_Comp_3.Trim) + "|" + N_Cant_3)
            End If

        End If
        'Se verifica conexión con SAP -------------------------------------------------------------
        Permiso.SAP_Status("I", tsImagen)
        'Identificar Supervisor en Turno ----------------------------------------------------------
        'SQL.Inyeccion.Identifies_shift_supervisor(Date.Today.ToString("yyyy-MM-dd"), cmbTurnos.Text.Trim)
        N_Supervisor = SQL_DATA.Inyeccion.Identifies_shift_supervisor(SessionUser._sCentro.Trim, CodOperador.Text.Trim, Date.Today.ToString("yyyy-MM-dd"), cmbTurnos.Text.Trim)
        'Identificar Compuesto original de la bom ------------------------------------------------
        CompOriginal = Produccion_Scrap_Inyeccion.Valida_Bom(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, TCodPT.Text.Trim)
        If CompOriginal.Trim = "0" Then
            MsgBox("Este producto no tiene asignado compuesto virgen para su consumo", MsgBoxStyle.Critical)
            Return
        End If
        '------------------------------------------------------------------------------------------
        BNotificar.Enabled = False
        BLimpiar.Enabled = False
        'Se ingresa información de notificacion en la base de datos ------------------------------
        NotificacionPtIny.Orden = TOrden.Text.Trim
        NotificacionPtIny.FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        NotificacionPtIny.HoraPesaje = Date.Now.TimeOfDay.ToString()
        NotificacionPtIny.Bascula = strNumeroBascula
        NotificacionPtIny.Rack = CB_Rack.Text.Trim
        NotificacionPtIny.PB = TPesoBruto.Text.Trim
        NotificacionPtIny.PT = TPesoTara.Text.Trim
        NotificacionPtIny.PN = TPesoNeto.Text.Trim
        NotificacionPtIny.Empaques = "0"
        NotificacionPtIny.Piezas = TtramosNoti.Text.Trim
        NotificacionPtIny.Usuario = CodOperador.Text.Trim
        NotificacionPtIny.FechaTurno = dtpFECHA.Value.ToString("yyyy-MM-dd")
        NotificacionPtIny.Turno = cmbTurnos.Text.Trim
        NotificacionPtIny.Supervisor = N_Supervisor
        NotificacionPtIny.Sobrepeso = "0"
        NotificacionPtIny.Tipocausa = "0"
        NotificacionPtIny.PuestoTrabajo = TPtoTrabajo.Text.Trim
        NotificacionPtIny.PesoTeorico = "0"
        NotificacionPtIny.Area = Seccion.Trim
        NotificacionPtIny.StatusSobrepeso = "0"
        NotificacionPtIny.Peso_C = Peso_Cajas
        NotificacionPtIny.Pzas_C = Pzas_Cajas
        NotificacionPtIny.Peso_B = Peso_Bolsas
        NotificacionPtIny.Pzas_B = Pzas_Bolsas
        NotificacionPtIny.Comp1 = N_Comp_1
        NotificacionPtIny.Porc1 = N_Porc_1
        NotificacionPtIny.Cant1 = N_Cant_1
        NotificacionPtIny.Comp2 = N_Comp_2
        NotificacionPtIny.Porc2 = N_Porc_2
        NotificacionPtIny.Cant2 = N_Cant_2
        NotificacionPtIny.Comp3 = N_Comp_3
        NotificacionPtIny.Porc3 = N_Porc_3
        NotificacionPtIny.Cant3 = N_Cant_3

        Try
            Produccion_Scrap_Inyeccion.Notifica_PTI()
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error registro de peso", MensajeBox.TipoMensaje.Critical)
            Return
        End Try
        'Se crea el folio correspondiente al pesaje
        FolioSiguiente = ""
        QRY = ""
        QRY = "Select isnull((Max(IdFolio)),0) as folioSiguiente from " & SessionUser._sCentro.Trim & "_PesoProductoTerminado  "
        QRY = QRY & "Where Orden_Produccion = '" & TOrden.Text.Trim & "' "
        QRY = QRY & "And  Area = 'I' "
        LecturaQry(QRY)
        If (LecturaBD.Read) Then
            FolioSiguiente = LecturaBD(0)
        End If
        LecturaBD.Close()
        TFolioAtlas.Text = FolioSiguiente
        'Se verifica status de conexión y se determina si se envia a SAP o no --------------------
        Dim Conexion As Boolean = SAP_Conexion.Estatus("I")
        Select Case Conexion
            Case "False"
                MsgBox(" No se realizara notificación a SAP se encuntra deshabilitada la conexión ")
                TNumNoti.Text = "0000000000"
                TConsNoti.Text = "00000000"
            Case "True"
                Select Case chkSAP.Checked
                    Case True
                        'Lectura de WS Generico para realizar la notificación ------------------------------------
                        Label12.Visible = True
                        Label12.Text = "Se esta Notificando la orden '" & TOrden.Text.Trim & "' a SAP"
                        Dim Head As String
                        Head = "28|" + NotificacionPtIny._Orden.Trim + "|" + NotificacionPtIny._Piezas.Trim + "|" + FechaPesajeSAP + "|" + CompOriginal.Trim + "|" + "P" + "|" + SessionUser._sAlias.Trim + "|" + FolioSiguiente
                        NotificationProcess.Notifica_PTE(Head, Lista, FolioSiguiente.Trim, TNumNoti, TConsNoti, BNotificar, BImprimir, TOrden, CodOperador.Text.Trim)
                        Label12.Visible = False
                        Label12.Text = ""
                    Case False
                        MsgBox(" No se realizara notificación a SAP se encuntra deshabilitada la conexión ")
                        TNumNoti.Text = "0000000000"
                        TConsNoti.Text = "00000000"
                End Select
        End Select
        'Consulta cantidades
        ProductionOrder.CalCantIny(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, TCantProgra, TCantEntre, TCantEnproce, TCantPendiente, TCantPiso)
        'Porcentaje de avance de la orden
        ProductionOrder.Porcentaje_Orden(TCantEntre.Text, TCantEnproce.Text, TCantProgra.Text, Label8, Btn_Notificar)
        BLimpiar.Enabled = True
    End Sub

    Private Sub Notifica_SC()

        If TCScrap.Text = "" Or TCScrap.Text = "0" Then
            MensajeBox.Mostrar("Seleccione el tipo de Scrap", "Aviso", MensajeBox.TipoMensaje.Information)
            CB_TipoSc.Focus()
            Return
        End If
        'Se asigna valor a variables -------------------------------------------------------------
        N_CodUser = CodOperador.Text.Trim
        N_PB = TPesoBruto.Text.Trim
        N_PT = TPesoTara.Text.Trim
        N_PN = TPesoNeto.Text.Trim
        N_FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        N_HoraPesaje = Date.Now.TimeOfDay.ToString()
        N_FechaTurno = dtpFECHA.Value.ToString("yyyy-MM-dd")
        N_Turno = cmbTurnos.Text.Trim
        FechaPesajeSAP = dtpFECHASAP.Value.ToString("yyyyMMdd")
        N_TipoScrap = CB_TipoSc.SelectedValue.Trim
        N_Rack = CB_Rack.Text.Trim
        If CB_Ope.SelectedValue = Nothing Then
            N_OperadorLinea = "Operador"
        Else
            N_OperadorLinea = CB_Ope.SelectedValue
        End If
        'Se valida valores de pesos --------------------------------------------------------------
        If (N_PN <= 0) Then
            MensajeBox.Mostrar("***  Peso NETO es menor o igual a cero  ***", "Aviso", MensajeBox.TipoMensaje.Information)
            Exit Sub
        End If

        If (N_PB <= 0) Then
            MensajeBox.Mostrar("***  Peso BRUTO es menor o igual a cero  ***", "Aviso", MensajeBox.TipoMensaje.Information)
            Exit Sub
        End If

        If (N_PB < N_PT) Or (N_PB < N_PN) Then
            MensajeBox.Mostrar("***  El Peso Bruto debe ser mayor que La Tara y/o Peso Neto ***", "Aviso", MensajeBox.TipoMensaje.Information)
            Exit Sub
        End If
        'Se asigna valor a variables de consumo compuestos 1, 2 y 3 --------------------------------------
        Dim aryTextFile() As String
        Dim Stat_Comp As Boolean

        Comp_1 = CB_Com1.SelectedValue
        Comp_2 = CB_Com2.SelectedValue
        Comp_3 = CB_Com3.SelectedValue

        Lista.Clear()

        aryTextFile = ValidacionesCompuestos.ValidaCompuestos_Inyeccion(N_PN, Comp_1, TPComp1.Text, Comp_2, _
                                                                        TPComp2.Text, Comp_3, TPComp3.Text).Split("|")
        Stat_Comp = aryTextFile(0)
        If Stat_Comp = False Then
            Exit Sub
        Else
            N_Comp_1 = aryTextFile(1)
            N_Porc_1 = aryTextFile(2)
            N_Cant_1 = aryTextFile(3)
            N_Comp_2 = aryTextFile(4)
            N_Porc_2 = aryTextFile(5)
            N_Cant_2 = aryTextFile(6)
            N_Comp_3 = aryTextFile(7)
            N_Porc_3 = aryTextFile(8)
            N_Cant_3 = aryTextFile(9)

            If N_Comp_1.Trim <> 0 Then
                Lista.Add(Util.QuitarCerosIzquierda(N_Comp_1.Trim) + "|" + N_Cant_1)

            End If

            If N_Comp_2.Trim <> 0 Then
                Lista.Add(Util.QuitarCerosIzquierda(N_Comp_2.Trim) + "|" + N_Cant_2)
            End If

            If N_Comp_3.Trim <> 0 Then
                Lista.Add(Util.QuitarCerosIzquierda(N_Comp_3.Trim) + "|" + N_Cant_3)
            End If

        End If
        'Se verifica conexión con SAP --------------------------------------------------------------------------
        Permiso.SAP_Status(Seccion.Trim, tsImagen)
        'Identificar Supervisor en Turno -----------------------------------------------------------------------
        NP.Identifies_shift_supervisor(Date.Today.ToString("yyyy-MM-dd"), cmbTurnos.Text.Trim)
        'Identificar Compuesto original de la bom --------------------------------------------------------------
        Dim Compuesto As String = ""
        Dim arryCompuesto() As String
        Compuesto = NotificationProcess.Identifica_Compuesto_Original(TCodPT.Text.Trim)
        arryCompuesto = Compuesto.Split("|")
        CompOriginal = arryCompuesto(0)
        Reprocesado_Orig = arryCompuesto(1)
        If CompOriginal = "" Then
            MensajeBox.Mostrar("El producto no tiene asignado compuesto original BOM, corrija y vuelva a intentar ", "Aviso", MensajeBox.TipoMensaje.Information)
            Return
        End If
        'Identifica si el compuesto es de paros y arranques o normal
        Reprocesado_Gen = NotificationProcess.Identifica_Reprocesado(Comp_1.Trim)
        'Se deshabilta boton de Notificación para evitar duplicidad
        BNotificar.Enabled = False
        'Se genera campo LTCompuestos para notificacion de scrap de CR01

        If N_Comp_1.Trim <> 0 Then
            N_LTCompuestos = CompOriginal.Trim & "|" & N_Porc_1 & "|" & Util.QuitarCerosIzquierda(N_Comp_1.Trim)
        End If

        If N_Comp_2.Trim <> 0 Then
            N_LTCompuestos = CompOriginal.Trim & "|" & N_Porc_1 & "|" & Util.QuitarCerosIzquierda(N_Comp_1.Trim) & "||" & CompOriginal & "|" & N_Porc_2 & "|" & Util.QuitarCerosIzquierda(N_Comp_2.Trim)
        End If

        If N_Comp_3.Trim <> 0 Then
            N_LTCompuestos = CompOriginal.Trim & "|" & N_Porc_1 & "|" & Util.QuitarCerosIzquierda(N_Comp_1.Trim) & "||" & CompOriginal & "|" & N_Porc_2 & "|" & Util.QuitarCerosIzquierda(N_Comp_2.Trim) & "||" & CompOriginal & "|" & N_Porc_3 & "|" & Util.QuitarCerosIzquierda(N_Comp_3.Trim)
        End If

        'Se ingresa información de notificacion en la base de datos --------------------------------------------
        Try
            NotificaScrapIny.Orden = TOrden.Text.Trim
            NotificaScrapIny.FechaPesaje = N_FechaPesaje
            NotificaScrapIny.HoraPesaje = N_HoraPesaje
            NotificaScrapIny.Bascula = strNumeroBascula
            NotificaScrapIny.TipoScrap = N_TipoScrap
            NotificaScrapIny.PB = N_PB
            NotificaScrapIny.PT = N_PT
            NotificaScrapIny.PN = N_PN
            NotificaScrapIny.Usuario = N_CodUser
            NotificaScrapIny.Turno = N_Turno
            NotificaScrapIny.FechaTurno = N_FechaTurno
            NotificaScrapIny.PuestoTrabajo = TPtoTrabajo.Text.Trim
            NotificaScrapIny.RepGenerado = Reprocesado_Gen
            NotificaScrapIny.Area = "I"
            NotificaScrapIny.OpePtoTrabajo = N_OperadorLinea
            NotificaScrapIny.Supervisor = "Supervisor"
            NotificaScrapIny.Rack = N_Rack
            NotificaScrapIny.LTCompuestos = N_LTCompuestos
            NotificaScrapIny.Comp1 = N_Comp_1.Trim
            NotificaScrapIny.Porc1 = N_Porc_1
            NotificaScrapIny.Cant1 = N_Cant_1
            NotificaScrapIny.Comp2 = N_Comp_2.Trim
            NotificaScrapIny.Porc2 = N_Porc_2
            NotificaScrapIny.Cant2 = N_Cant_2
            NotificaScrapIny.Comp3 = N_Comp_3.Trim
            NotificaScrapIny.Porc3 = N_Porc_3
            NotificaScrapIny.Cant3 = N_Cant_3

            Produccion_Scrap_Inyeccion.Notifica_Scrap()
        Catch ex As Exception
            MensajeBox.Mostrar(ex.Message, "Critico", MensajeBox.TipoMensaje.Critical)
            Return
        End Try
        'Se crea el folio correspondiente al pesaje
        FolioSiguiente = ""
        QRY = ""
        QRY = "Select isnull((Max(IdFolio)),0) as folioSiguiente from " & SessionUser._sCentro.Trim & "_PesoScrap "
        QRY = QRY & "Where Orden_Produccion = '" & TOrden.Text.Trim & "' "
        QRY = QRY & "And  Area = 'I' "
        LecturaQry(QRY)
        If (LecturaBD.Read) Then
            FolioSiguiente = LecturaBD(0)
        End If
        LecturaBD.Close()
        TFolioAtlas.Text = FolioSiguiente

        If CB_Proceso.Checked Then
            MensajeBox.Mostrar("El pesaje quedara en proceso para su posterior notificación ", "Aviso", MensajeBox.TipoMensaje.Information)
            Exit Sub
        Else
            Select Case SAP_Conexion.Estatus(Seccion.Trim)
                Case "False"
                    MensajeBox.Mostrar("No se realizara notificación a SAP se encuntra deshabilitada la conexión", "Aviso", MensajeBox.TipoMensaje.Information)
                    TNumNoti.Text = "0000000000"
                    TConsNoti.Text = "00000000"
                Case "True"
                    Select Case chkSAP.Checked
                        Case True
                            Select Case SessionUser._sCentro
                                Case Is = "CR01"
                                    'Lectura de WS Generico para realizar la notificación ------------------------------------
                                    Label12.Visible = True
                                    Label12.Text = "Se esta Notificando la orden '" & TOrden.Text.Trim & "' a SAP"
                                    Dim Head As String
                                    Head = "28|" + TOrden.Text.Trim + _
                                             "|" + TPesoNeto.Text.Trim + _
                                             "|" + FechaPesajeSAP + _
                                             "|" + CompOriginal.Trim + _
                                             "|" + "S" + _
                                             "|" + SessionUser._sAlias.Trim + _
                                             "|" + FolioSiguiente + _
                                             "|" + Reprocesado_Gen
                                    NotificationProcess.Notifica_SCE(Head, Lista, FolioSiguiente.Trim, TNumNoti, TConsNoti, BNotificar, BImprimir, TOrden, _
                                                                     CodOperador.Text.Trim)
                                    Label12.Visible = False
                                    Label12.Text = ""
                                Case Else
                                    'Lectura de WS Generico para realizar la notificación ------------------------------------
                                    Label12.Visible = True
                                    Label12.Text = "Se esta Notificando la orden '" & TOrden.Text.Trim & "' a SAP"
                                    Dim CadenaTexto As String = ""
                                    CadenaTexto = N_CodUser.Trim & "|" & FolioSiguiente.Trim
                                    Consume_WS_CR01(SessionUser._sAmbiente.Trim, CadenaTexto.Trim, N_LTCompuestos.Trim, N_FechaPesaje, TOrden.Text.Trim, N_PN, FolioSiguiente.Trim, TNumNoti, TConsNoti)
                                    Label12.Visible = False
                                    Label12.Text = ""
                            End Select
                        Case False
                            MsgBox(" No se realizara notificación a SAP se encuntra deshabilitada la conexión ")
                            TNumNoti.Text = "0000000000"
                            TConsNoti.Text = "00000000"
                    End Select
            End Select
        End If
    End Sub

#End Region

#Region "Metodos"
    Private Sub ValidaOrden()
        Dim Exist_Prd As Integer = 0
        '------------------------------------------------------------------------------------------
        If TOrden.Text <> "" Then
            'Verficia Orden Producción
            Dim Orden_Prod As String = ""
            Orden_Prod = TOrden.Text.Trim
            '--------------------------------------------------------------------------------------
            Select Case ProductionOrder.Existe(Orden_Prod, EXTINY)
                Case Is = True
                    'Verifica si no esta inactiva
                    Select Case OrdenProduccionExiste._Estatus
                        Case Is = True
                            'Verificar que la orden no este cerrada
                            ProductionOrder.ValidaEstatus(Orden_Prod, "T")
                            Dim Estatus_Orden As String = OrdenProductionSap._IdStatus
                            Select Case Estatus_Orden
                                Case Is = "LIB."
                                    Me.Cursor = Cursors.WaitCursor
                                    'Verficia la existencia del producto
                                    Exist_Prd = ProductionOrder.Existencia_Producto(EXTINY)
                                    'Lee la orden y presenta la información
                                    ProductionOrder.Read_Production_Order_Iny(SessionUser._sAlias.Trim, Orden_Prod.Trim, SessionUser._sCentro.Trim, Me, TCodPT, TCodPtDecr, _
                                                                          TPtoTrabajo, TGrpprod, TGrupo, TGrpproddesc, TNomPtoTrabajo)
                                    'Activa Combo Box de compuestos 1
                                    Catalogo_Compuestos.CB_Compuesto1(CB_Com1, EXTINY, TipoProd, True)
                                    CB_Com1.Enabled = True
                                    If TipoProd = "S" Then
                                        'Activa Combo Box de Tipo Scrap
                                        Catalogo_Scrap.CB_Scrap(CB_TipoSc, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, Seccion, TipoProd)
                                    End If
                                    'Activa Combo Box Operdores de Linea
                                    Catalogo_Operador_Puesto_Trabajo.CB_Operador_Linea(CB_Ope, TipoProd)
                                    'Consulta cantidades
                                    ProductionOrder.CalCantIny(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, TCantProgra, TCantEntre, TCantEnproce, TCantPendiente, TCantPiso)
                                    'Porcentaje de avance de la orden
                                    ProductionOrder.Porcentaje_Orden(TCantEntre.Text, TCantEnproce.Text, TCantProgra.Text, Label8, Btn_Notificar)
                                    Me.Cursor = Cursors.Default
                                Case Else
                                    MensajeBox.Mostrar("La orden no puede ser notificada esta en estatus: " & OrdenProductionSap._Status & " ", " " & OrdenProductionSap._IdStatus & " ", MensajeBox.TipoMensaje.Critical)
                                    TOrden.Text = ""
                                    TOrden.Focus()
                                    Exit Sub
                            End Select
                        Case Is = False
                            MensajeBox.Mostrar("La orden esta inactiva", "Estatus", MensajeBox.TipoMensaje.Information)
                            TOrden.Text = ""
                            TOrden.Focus()
                            Exit Sub
                    End Select
                Case Is = False
                    Me.Cursor = Cursors.WaitCursor
                    'Dar de alta la orden
                    MensajeBox.Mostrar("Orden de Producción no existe en A-tlas se procede a darla de alta ", "Aviso", MensajeBox.TipoMensaje.Information)
                    ProductionOrder.Inserta_ODF_INY(Orden_Prod.Trim, "T", Me, CodOperador.Text.Trim, EXTINY, SessionUser._sAlias.Trim, _
                                                                  SessionUser._sCentro.Trim, SessionUser._sAmbiente, EXTINY, TCodPT, TCodPtDecr, TPtoTrabajo, _
                                                                  TGrpprod, TGrupo, TGrpproddesc, TNomPtoTrabajo)
                    Me.Cursor = Cursors.Default
            End Select
        End If
    End Sub

    Private Sub LimpiaObjetos()
        Lista.Clear()
        Clean = "1"
        CB_Com1.Enabled = False
        CB_Com2.Enabled = False
        CB_Com3.Enabled = False
        CB_Rack.DataSource = Nothing
        CB_Com1.DataSource = Nothing
        CB_Comp2.Checked = False
        CB_Comp3.Checked = False
        CB_Comp3.Enabled = False
        TPComp2.Enabled = False
        TPComp2.Enabled = False
        TPComp3.Enabled = False
        TPComp1.Text = "100"
        TPComp2.Text = "0"
        TPComp3.Text = "0"
        CB_Com2.Text = ""
        CB_TipoSc.DataSource = Nothing
        TCScrap.Text = "0"
        CB_Ope.DataSource = Nothing
        CBG.CB_Rack(CB_Rack)
        TOrden.Text = ""            'Orden Producción
        TOrden.Enabled = False
        TtramosNoti.Text = "0"       'Tramos por Notificar
        CB_Rack.Text = "M"           'Rack
        TPesoRack.Text = "0"        'Peso Rack
        TC_Descrack.Text = ""          'Peso Rack
        TCodPT.Text = ""            'Código Material
        TGrupo.Text = ""            'Descripción GRUPO Material
        TCodPtDecr.Text = ""        'Descripción Material
        TGrpprod.Text = ""          'Codigo grupo produccion
        TGrpproddesc.Text = ""      'Descripcion grupo´produccion
        TPtoTrabajo.Text = ""       'Puesto de Trabajo
        CB_Ope.Text = ""
        ' ---------------------------------------------------------------------------------
        RB_PT.Checked = True
        RB_SC.Checked = False
        ' ---------------------------------------------------------------------------------
        TPesoCaptura.Text = "0.00" 'Peso Bruto Manual
        TPesoBruto.Text = "0.00"
        TPesoTara.Text = "0.00"
        TPesoNeto.Text = "0.00"
        TPesoEmpaque.Text = "0.00"
        ' ---------------------------------------------------------------------------------
        TCantProgra.Text = ""       'Programada
        TCantEntre.Text = ""        'Entregada
        TCantEnproce.Text = ""      'Entregada
        TCantPendiente.Text = ""    'Pendiente
        ' ---------------------------------------------------------------------------------
        'Se asigna turno que corresponde acorde al horario
        Dim HReal As String = DateTime.Now
        Catalogo_Turnos.Combo_Turnos(cmbTurnos)
        Catalogo_Turnos.Asigna_turno(cmbTurnos, HReal)
        ' ---------------------------------------------------------------------------------
        TFolioAtlas.Text = ""       'Folio ATLAS
        TNumNoti.Text = ""          'Número Notificación
        TConsNoti.Text = ""         'Consecutivo Notificación
        TNomPtoTrabajo.Text = ""
        Label8.Text = ""
        ' ---------------------------------------------------------------------------------
        SP = "0"
        Autoriza_SP = ""
        ' ---------------------------------------------------------------------------------
        BNotificar.Enabled = False
        BImprimir.Enabled = False
        TOrden.Enabled = True
        Clean = "0"
        Btn_Notificar = "0"
    End Sub

    Private Sub Calcula_Cantidades()
        Dim xTCantProgra As Decimal = 0
        Dim xTCantEntre As Decimal = 0
        Dim xTCantEnproce As Decimal = 0
        Dim xTCantpendi As Decimal = 0
        ' ---------------------------------------------------------------------------------
        Try
            LecturaQry("PA_Calcula_Cantidades '" & SessionUser._sCentro & "',  '" & TOrden.Text.Trim & "', '1'")
            If (LecturaBD.Read) Then
                xTCantProgra = LecturaBD(1)
                xTCantEntre = LecturaBD(2)
                xTCantEnproce = LecturaBD(3)
                xTCantpendi = LecturaBD(4)
                TCantProgra.Text = Format(xTCantProgra, "###,##0" & GDECIMAL & "00")
                TCantEntre.Text = Format(xTCantEntre, "###,##0" & GDECIMAL & "00")
                TCantEnproce.Text = Format(xTCantEnproce, "##,###0" & GDECIMAL & "00")
                TCantPendiente.Text = Format(xTCantpendi, "##,###0" & GDECIMAL & "00")
            Else
                TCantProgra.Text = "0.00"
                TCantEntre.Text = "0.00"
                TCantEnproce.Text = "0.00"
                TCantPendiente.Text = "0.00"
            End If
            LecturaBD.Close()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
    End Sub

    Private Function Suma_Compuestos(ByVal C1 As Integer, C2 As Integer, C3 As Integer) As Integer
        Dim Sumatoria As Decimal

        Sumatoria = C1 + C2 + C3

        Return Sumatoria
    End Function

    Private Sub Consume_WS_CR01(ByVal ID As String, CadenaTexto As String, Lt_Compuestos As String, _
                              FechaPesajeSAP As String, Orden As String, PesoNeto As String, folio As String, TD As TextBox, _
                              TC As TextBox)

        Dim Err As String
        Dim Mns As String
        Dim reg As String = ""
        Dim Cod_Err As String = ""

        If ID.Trim = "D" Then
            'Variables Desarrollo
            Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
            Dim ls_returnr As New PTConsumos.ZBAPIRET2
            Dim ls_Notifica As New PTConsumos.ZEPP002
            Dim ls_result As New PTConsumos._ISDFPS_TCUPS_KEY
            Dim TNumNoti As String = ""
            Dim TConsNoti As String = ""
            Try
                ls_Notifica.ZBUDAT = FechaPesajeSAP.Trim
                ls_Notifica.ZCONSUME_REC = 0
                ls_Notifica.ZENTRY_QNT = 0
                ls_Notifica.ZISM01 = 0
                ls_Notifica.ZISM02 = 0
                ls_Notifica.ZISM03 = 0
                ls_Notifica.ZISMNGEH1 = ""
                ls_Notifica.ZISMNGEH2 = ""
                ls_Notifica.ZISMNGEH3 = ""
                ls_Notifica.ZMATNR_REC = ""
                ls_Notifica.ZMATNR_REC = ""
                ls_Notifica.ZORDERID = Orden.Trim
                ls_Notifica.ZRECOVERED = PesoNeto
                ls_Notifica.ZVIRGIN = 0
                lo_wsamancomxr.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3m4tl4s")
                ls_result = lo_wsamancomxr.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notifica, ls_returnr)
                TNumNoti = ls_result.RUECK
                TConsNoti = ls_result.RMZHL
                Err = ls_returnr.ZTYPE
                Mns = ls_returnr.ZMESSAGE
            Catch ex As Exception
                MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
            End Try
        ElseIf ID.Trim = "P" Then
            'Variables Productivo
            Dim lo_wsamancomxp As New PTConProd.ZPPMXF001Service
            Dim ls_returnp As New PTConProd.ZBAPIRET2
            Dim ls_Notificap As New PTConProd.ZEPP002
            Dim ls_resultp As New PTConProd._ISDFPS_TCUPS_KEY
            Dim TNumNoti As String = ""
            Dim TConsNoti As String = ""
            ls_Notificap.ZBUDAT = FechaPesajeSAP.Trim
            ls_Notificap.ZCONSUME_REC = 0.0
            ls_Notificap.ZENTRY_QNT = 0
            ls_Notificap.ZISM01 = 0.0
            ls_Notificap.ZISM02 = 0.0
            ls_Notificap.ZISM03 = 0.0
            ls_Notificap.ZISMNGEH1 = ""
            ls_Notificap.ZISMNGEH2 = ""
            ls_Notificap.ZISMNGEH3 = ""
            ls_Notificap.ZMATNR_REC = ""
            ls_Notificap.ZORDERID = Orden.Trim
            ls_Notificap.ZRECOVERED = PesoNeto
            ls_Notificap.ZVIRGIN = 0.0
            'lo_wsamancomxp.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3m4tl4s")
            ls_resultp = lo_wsamancomxp.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notificap, ls_returnp)
            TNumNoti = ls_resultp.RUECK
            TConsNoti = ls_resultp.RMZHL
            Err = ls_returnp.ZTYPE
            Mns = ls_returnp.ZMESSAGE

            If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                reg = "0"
                MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
                InQry = ""
                InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set MsgSAP = '" & Mns.Trim & "' "
                InQry = InQry & " Where Folio = '" & folio.Trim & "'"
                InsertQry(InQry)
                Exit Sub
            Else
                If (TNumNoti = "" Or TNumNoti = "NULL" Or TNumNoti = "0000000000") And (TConsNoti = "" Or TConsNoti = "NULL" Or TConsNoti = "00000000") Then
                    reg = "0"
                    LecturaQry("PA_Update_Not_Masiva_Scrap " & SessionUser._sCentro.Trim & "_PesoScrap, '" & TNumNoti & "', '" & TConsNoti & "', '" & reg & "', '" & reg & "', '" & Mns & "',  '" & folio & "' ")
                    MensajeBox.Mostrar("Error SAP: " & Mns & "", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                Else
                    reg = "1"
                    LecturaQry("PA_Update_Not_Masiva_Scrap " & SessionUser._sCentro.Trim & "_PesoScrap, '" & TNumNoti & "', '" & TConsNoti & "', '" & reg & "', '" & reg & "', '" & Mns & "',  '" & folio & "' ")
                    TD.Text = TNumNoti
                    TC.Text = TConsNoti
                    MensajeBox.Mostrar("Se realizó notificación a SAP de forma exitosa ", "Aviso", MensajeBox.TipoMensaje.Information)
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub CB_TipoSc_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_TipoSc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_TipoSc_Leave(sender As System.Object, e As System.EventArgs) Handles CB_TipoSc.Leave
        TCScrap.Text = CB_TipoSc.SelectedValue
        BNotificar.Focus()
    End Sub

    Private Sub Limpiar()
        SQL_DATA.Inyeccion.LimpiarForm(Me)
        DGV_Emb.Columns.Clear()
        CB_Ope.DataSource = Nothing
        CB_Com1.DataSource = Nothing
        CB_Com2.DataSource = Nothing
        CB_Com3.DataSource = Nothing
        CB_TipoSc.DataSource = Nothing
        CB_Comp2.Checked = False
        CB_Comp3.Checked = False
        CB_Comp3.Enabled = False
        RB_PT.Checked = True
        RB_SC.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim TPC As String = ""
        Dim TPC2 As String = ""

        Cadena = FrmMain.SerialPort1.ReadExisting

        TPC = Chr(CH1)
        TPC2 = Chr(CH2)
        If Cadena.Length > 13 Then
            If Cadena.StartsWith(TPC) = True Then
                Lectura = Cadena.Substring((Cadena.IndexOf(TPC2) + AddChar), LenghtLec).Trim
            End If
        End If
        TPesoBruto.Text = Format(Val(Lectura), xFormato)
    End Sub

    Private Sub ProductoTerminadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductoTerminadoToolStripMenuItem.Click
        Permiso.Accesos("MP_IMP_PT", "2", SessionUser._sIdPerfil, "I", "Reportes Producto Terminado ")
    End Sub

    Private Sub ScrapToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScrapToolStripMenuItem.Click
        Permiso.Accesos("MP_IMP_SC", "2", SessionUser._sIdPerfil, "I", "Reportes Scrap ")
    End Sub

    Private Sub Parametrizacion_Forma()
        Permiso.Parametros_MenuPTE(Label16, CB_Ope, Me.Name, BNotificar, BImprimir, MP_PTE_Consulta)
        If P_VU = True Then
            PassNotifier.Text = SessionUser._sAlias.Trim
            Gen_Valida.Valida_Usuario(SessionUser._sAlias.Trim, SessionUser._sPassword.Trim)
            CodOperador.Text = ""
            NomOperador.Text = ""
            PassNotifier.Enabled = False

            If Gen_Valida.valContador = 0 Then
                MessageBox.Show("*** USUARIO INEXISTENTE *** ")
                PassNotifier.Text = ""
                PassNotifier.Focus()
            Else
                CodOperador.Text = SessionUser._sAlias
                NomOperador.Text = SessionUser._sNombre
                RB_PT.Focus()
            End If
            RB_PT.Focus()
        Else
            PassNotifier.Focus()
        End If
    End Sub

    Private Sub CB_Com1_KeyPress_1(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Com1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Com2_KeyPress_1(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Com2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Com2_Leave(sender As System.Object, e As System.EventArgs) Handles CB_Com2.Leave

        If Comp_2.Trim = Comp_1.trim Then
            MsgBox("El compuesto seleccionado no puede ser el mismo que el primero", MsgBoxStyle.Information)
            CB_Com2.DataSource = Nothing
            'CBG.Con_Comp_rep(CB_Com2, StrProducto.Trim, EXTINY)
            Catalogo_Compuestos.CB_Compuesto2(CB_Com2, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TCodPT.Text.Trim, EXTINY)
            CB_Com2.Text = ""
            Comp_2 = "0"
            CB_Com2.Focus()
        End If
    End Sub

    Private Sub CB_Com1_Leave(sender As System.Object, e As System.EventArgs) Handles CB_Com1.Leave
        Comp_1 = CB_Com1.SelectedValue
    End Sub

    Private Sub chkSAP_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSAP.CheckedChanged
        If chkSAP.Checked Then
            dtpFECHASAP.Enabled = False
        Else
            dtpFECHASAP.Enabled = True
        End If
    End Sub

    Private Sub BImprimir_Click(sender As System.Object, e As System.EventArgs) Handles BImprimir.Click
        If RB_PT.Checked Then
            Reportes.Boleta_Pesaje_PTE_Iny(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, TFolioAtlas.Text.Trim, "0")
        End If

        If RB_SC.Checked Then
            Reportes.Boleta_Pesaje_SCE_Iny(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, TFolioAtlas.Text.Trim, "0")
        End If
    End Sub

    Private Sub MP_PT_SCE_Click(sender As System.Object, e As System.EventArgs) Handles MP_PT_SCE.Click
        Permiso.Accesos("MP_CON_DETALLE", "2", SessionUser._sIdPerfil, "I", "")
    End Sub

    Private Sub ScrapToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ScrapToolStripMenuItem1.Click
        Permiso.Accesos("MP_PT_SCE", "2", SessionUser._sIdPerfil, "I", "Consulta Analisis Scrap Inyección")
    End Sub

    Private Sub MenuPTI_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        InitializeComponent()
        Permiso.Cerrar(Me.Name, "Cerrar")
    End Sub
End Class