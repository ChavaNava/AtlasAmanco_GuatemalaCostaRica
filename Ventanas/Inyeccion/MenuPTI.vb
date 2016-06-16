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
    Dim N_Empaques As Integer
    Dim N_Tramos As Integer
    Dim N_FechaTurno As String
    Dim N_Turno As Integer
    Dim N_Supervisor As String
    Dim N_Sobrepeso As Decimal
    Dim N_PesoTeorico As Decimal
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

    Dim Reprocesado_Orig As String = ""
    Dim Reprocesado_Gen As String

    'Variables para bascula
    Dim Cadena As String = ""
    Dim Lectura As String = ""


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
        CveOperador.Focus()
    End Sub

    Private Sub ClaveOperador_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CveOperador.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ClaveOperador_Leave(sender As System.Object, e As System.EventArgs) Handles CveOperador.Leave
        'If P_VU = False Then
        '    Pass_md5 = Crypto.MD5Calculate(CveOperador.Text.Trim)
        '    Gen_Valida.Valida_Usuario(CveOperador.Text.Trim, Pass_md5.Trim)
        '    CodOperador.Text = ""
        '    NomOperador.Text = ""

        '    If Gen_Valida.valContador = 0 Then
        '        MessageBox.Show("*** USUARIO INEXISTENTE *** ")
        '        CveOperador.Text = ""
        '        CveOperador.Focus()
        '    Else
        '        CodOperador.Text = SessionUser._sAlias.Trim
        '        NomOperador.Text = Gen_Valida.valNomUser.Trim
        '        RB_PT.Focus()
        '    End If
        '    ' ---------------------------------------------------------------------------------
        '    CveOperador.BackColor = Color.White
        'Else
        Pass_md5 = Crypto.MD5Calculate(CveOperador.Text.Trim)
        'Gen_Valida.Valida_Usuario(SessionUser._sAlias.Trim, Pass_md5.Trim)
        CodOperador.Text = ""
        NomOperador.Text = ""

        If Gen_Valida.valContador = 0 Then
            MessageBox.Show("*** USUARIO INEXISTENTE *** ")
            CveOperador.Text = ""
            CveOperador.Focus()
        Else
            CodOperador.Text = SessionUser._sAlias
            NomOperador.Text = SessionUser._sNombre
            RB_PT.Focus()
        End If
        'End If
    End Sub

    Private Sub RB_PT_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PT.CheckedChanged
        TipoProd = ""
        TipoProd = "T"
        CB_TipoSc.Enabled = False
        TtramosNoti.ReadOnly = False
        TtramosNoti.BackColor = Color.White
        CB_Proceso.Checked = False
        TC_Orden.Text = ""
        TC_Orden.Enabled = True
    End Sub

    Private Sub RB_SC_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_SC.CheckedChanged
        TipoProd = ""
        TipoProd = "S"
        CB_TipoSc.Enabled = True
        TtramosNoti.ReadOnly = True
        TtramosNoti.BackColor = Color.White
        TC_Orden.Text = ""
        TC_Orden.Enabled = True
        BNotificar.Enabled = True
        CB_Proceso.Checked = True
        TC_Orden.Focus()
    End Sub

    Private Sub TC_Orden_Enter(sender As System.Object, e As System.EventArgs) Handles TC_Orden.Enter
        TC_Orden.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TC_Orden_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TC_Orden.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TC_Orden_Leave(sender As System.Object, e As System.EventArgs) Handles TC_Orden.Leave
        ValidaOrden()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TC_Orden.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese un numero de Orden", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            Exit Sub
        Else
            PO.Actualiza_Orden_Produccion(TC_Orden.Text.Trim, "T")
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
            If TtramosNoti.Text.Trim <> 0 Then
                TPesoEmpaque.Text = "0.00"
                Utili_Generales.ControlDataGridView.Colums_CalculaEmbalajes(DGV_Emb)
                arryEmbalajes = Inyeccion.Embalajes(DGV_Emb, SessionUser._sCentro.Trim, SessionUser._sCentro.Trim + "_OrdenProduccion", TC_Orden.Text.Trim, TtramosNoti.Text, SessionUser._sAlias, TPesoEmpaque).Split("|")
                Pzas_Cajas = "0" & arryEmbalajes(0)
                Peso_Cajas = "0" & arryEmbalajes(1)
                Pzas_Bolsas = "0" & arryEmbalajes(2)
                Peso_Bolsas = "0" & arryEmbalajes(3)
                BNotificar.Enabled = True
            End If
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
                Catalogo_Compuestos.CB_Compuesto1(CB_Com1, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, PO.r_CodigoProducto.Trim, "S", "1", True)
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
        CveOperador.Focus()
    End Sub

    Private Sub BPesar_Click(sender As System.Object, e As System.EventArgs) Handles BNotificar.Click

        'Valida campos obligatorios ----------------------------------------------------------------------------
        If CodOperador.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese clave de operador", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            CodOperador.Focus()
            Return
        End If

        If TC_Orden.Text.Trim = "" Then
            MensajeBox.Mostrar("Debe de asignar una orden de fabricación", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TC_Orden.Focus()
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

            Notifica_PT()

        End If

        If RB_SC.Checked Then
            Notifica_SC()
        End If
    End Sub

    Private Sub Notifica_PT()
        Btn_Notificar = "1"

        If TtramosNoti.Text = 0 Then
            MensajeBox.Mostrar("No se a asignado cantidad de producto a notifica", "Aviso", MensajeBox.TipoMensaje.Information)
            TtramosNoti.Focus()
            Exit Sub
        End If

        'Se asigna valor a variables --------------------------------------------------------------
        N_CodUser = CodOperador.Text.Trim
        N_Tramos = TtramosNoti.Text.Trim
        N_PB = TPesoBruto.Text.Trim
        N_PT = TPesoTara.Text.Trim
        N_PN = TPesoNeto.Text.Trim
        N_FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        N_HoraPesaje = Date.Now.TimeOfDay.ToString()
        N_Turno = cmbTurnos.Text.Trim
        N_OperadorLinea = CB_Ope.SelectedValue
        N_FechaTurno = dtpFECHA.Value.ToString("yyyy-MM-dd")
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

            Select Case SessionUser._sCentro.Trim
                Case Is <> "CR01"
                    If N_Comp_1.Trim <> 0 Then
                        Lista.Add(Util.QuitarCerosIzquierda(N_Comp_1.Trim) + "|" + N_Cant_1)
                    End If

                    If N_Comp_2.Trim <> 0 Then
                        Lista.Add(Util.QuitarCerosIzquierda(N_Comp_2.Trim) + "|" + N_Cant_2)
                    End If

                    If N_Comp_3.Trim <> 0 Then
                        Lista.Add(Util.QuitarCerosIzquierda(N_Comp_3.Trim) + "|" + N_Cant_3)
                    End If
                Case Is = "CR01"
                    If N_Comp_1.Trim <> 0 Then

                    End If
            End Select

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
        LecturaQry("PA_Insert_PPT_Inyeccion '" & TC_Orden.Text.Trim & "','" & SessionUser._sCentro & "','" & N_FechaPesaje & _
              "', '" & N_HoraPesaje & "','" & strNumeroBascula & "','" & CB_Rack.Text.Trim & "'," & N_PB & "," & N_PT & "," & N_PN & _
               "," & N_Empaques & ", " & N_Tramos & ",'" & N_CodUser & "','" & N_FechaTurno & "','" & N_Turno & _
               "','" & N_Supervisor & "','" & N_Sobrepeso & "','0','" & TPtoTrabajo.Text.Trim & _
               "'," & N_PesoTeorico & ",I,'" & N_StSobrePeso & "','" & Peso_Cajas & "', '" & Pzas_Cajas & "', '" & Peso_Bolsas & _
               "', '" & Pzas_Bolsas & "', '" & N_Comp_1 & "','" & N_Porc_1 & "','" & N_Cant_1 & "','" & N_Comp_2 & "','" & N_Porc_2 & _
               "','" & N_Cant_2 & "','" & N_Comp_3 & "','" & N_Porc_3 & "','" & N_Cant_3 & "'")
        'Se crea el folio correspondiente al pesaje
        FolioSiguiente = ""
        QRY = ""
        QRY = "Select isnull((Max(IdFolio)),0) as folioSiguiente from " & SessionUser._sCentro.Trim & "_PesoProductoTerminado  "
        QRY = QRY & "Where Orden_Produccion = '" & TC_Orden.Text.Trim & "' "
        QRY = QRY & "And  Area = 'I' "
        LecturaQry(QRY)
        If (LecturaBD.Read) Then
            FolioSiguiente = LecturaBD(0)
        End If
        LecturaBD.Close()
        TFolioAtlas.Text = FolioSiguiente
        'Se verifica status de conexión y se determina si se envia a SAP o no --------------------
        Dim Conexion As Boolean = SAP_Conexion.SAP_Status("I")
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
                        Label12.Text = "Se esta Notificando la orden '" & TC_Orden.Text.Trim & "' a SAP"
                        Dim Head As String
                        Head = "28|" + TC_Orden.Text.Trim + "|" + N_Tramos.ToString + "|" + FechaPesajeSAP + "|" + CompOriginal.Trim + "|" + "P" + "|" + SessionUser._sAlias.Trim + "|" + FolioSiguiente
                        NotificationProcess.Notifica_PTE(Head, Lista, FolioSiguiente.Trim, TNumNoti, TConsNoti, BNotificar, BImprimir, TC_Orden, CodOperador.Text.Trim)
                        Label12.Visible = False
                        Label12.Text = ""
                    Case False
                        MsgBox(" No se realizara notificación a SAP se encuntra deshabilitada la conexión ")
                        TNumNoti.Text = "0000000000"
                        TConsNoti.Text = "00000000"
                End Select
        End Select
        'Consulta cantidades
        ProductionOrder.CalCantIny(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TC_Orden.Text.Trim, TCantProgra, TCantEntre, TCantEnproce, TCantPendiente, TCantPiso)
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
        Permiso.SAP_Status("E", tsImagen)
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
            Return
        End If
        'Identifica si el compuesto es de paros y arranques o normal
        Reprocesado_Gen = NotificationProcess.Identifica_Reprocesado(Comp_1.Trim)
        'Se deshabilta boton de Notificación para evitar duplicidad
        BNotificar.Enabled = False
        'Se ingresa información de notificacion en la base de datos --------------------------------------------
        Try
            LecturaQry("PA_Insert_Scrap_Inyeccion " & SessionUser._sCentro.Trim & "_PesoScrap, '" & TC_Orden.Text.Trim & "', '" & N_FechaPesaje & _
                       "', '" & N_HoraPesaje & "','" & strNumeroBascula & "','" & N_TipoScrap & "'," & N_PB & "," & N_PT & "," & N_PN & _
                       ",'" & N_CodUser & "','" & N_Turno & "','0','0','" & N_FechaTurno & "','" & TPtoTrabajo.Text.Trim & _
                       "','" & Reprocesado_Gen & "', 'I', '" & N_OperadorLinea & "','Supervisor','" & N_Rack & "','" & N_Comp_1.Trim & _
                       "'," & N_Porc_1 & "," & N_Cant_1 & ",'" & N_Comp_2.Trim & "'," & N_Porc_2 & "," & N_Cant_2 & ",'" & N_Comp_3.Trim & _
                       "'," & N_Porc_3 & "," & N_Cant_3 & "")
        Catch ex As Exception
            MensajeBox.Mostrar(ex.Message, "Critico", MensajeBox.TipoMensaje.Critical)
        End Try
        'Se crea el folio correspondiente al pesaje
        FolioSiguiente = ""
        QRY = ""
        QRY = "Select isnull((Max(IdFolio)),0) as folioSiguiente from " & SessionUser._sCentro.Trim & "_PesoScrap "
        QRY = QRY & "Where Orden_Produccion = '" & TC_Orden.Text.Trim & "' "
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
            Select Case SAP_Conexion.SAP_Status(Modulo)
                Case "False"
                    MensajeBox.Mostrar("No se realizara notificación a SAP se encuntra deshabilitada la conexión", "Aviso", MensajeBox.TipoMensaje.Information)
                    TNumNoti.Text = "0000000000"
                    TConsNoti.Text = "00000000"
                Case "True"
                    Select Case chkSAP.Checked
                        Case True
                            'Lectura de WS Generico para realizar la notificación ------------------------------------
                            Label12.Visible = True
                            Label12.Text = "Se esta Notificando la orden '" & TC_Orden.Text.Trim & "' a SAP"
                            Dim Head As String
                            Head = "28|" + TC_Orden.Text.Trim + _
                                     "|" + TPesoNeto.Text.Trim + _
                                     "|" + FechaPesajeSAP + _
                                     "|" + CompOriginal.Trim + _
                                     "|" + "S" + _
                                     "|" + SessionUser._sAlias.Trim + _
                                     "|" + FolioSiguiente + _
                                     "|" + Reprocesado_Gen
                            NotificationProcess.Notifica_SCE(Head, Lista, FolioSiguiente.Trim, TNumNoti, TConsNoti, BNotificar, BImprimir, TC_Orden, _
                                                             CodOperador.Text.Trim)
                            Label12.Visible = False
                            Label12.Text = ""
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
        Dim strOrden As String = ""
        Dim aryTextFile() As String
        Dim Exist_Ord As Integer = 0
        Dim Exist_Prd As Integer = 0
        '------------------------------------------------------------------------------------------
        If TC_Orden.Text <> "" Then
            'Verficia Orden Producción
            Dim Orden_Prod As String = ""
            Orden_Prod = TC_Orden.Text.Trim
            '--------------------------------------------------------------------------------------
            strOrden = ProductionOrder.Valida_Exis_ODF_Atlas(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, Orden_Prod, EXTINY)
            aryTextFile = strOrden.Split("|")
            Exist_Ord = aryTextFile(0)
            Producto = aryTextFile(1)
            Select Case Exist_Ord
                Case Is = 1
                    Me.Cursor = Cursors.WaitCursor
                    'Verficia la existencia del producto
                    Exist_Prd = ProductionOrder.Valida_Existencia_Producto(SessionUser._sAlias.Trim, Producto.Trim, SessionUser._sCentro.Trim, EXTINY)
                    'Lee la orden y presenta la información
                    ProductionOrder.Read_Production_Order_Iny(SessionUser._sAlias.Trim, Orden_Prod.Trim, SessionUser._sCentro.Trim, Me, TCodPT, TCodPtDecr, _
                                                          TPtoTrabajo, TGrpprod, TGrupo, TGrpproddesc, TNomPtoTrabajo)
                    'Activa Combo Box de compuestos 1
                    Catalogo_Compuestos.CB_Compuesto1(CB_Com1, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, Producto, EXTINY, TipoProd, 1)
                    CB_Com1.Enabled = True
                    If TipoProd = "S" Then
                        'Activa Combo Box de Tipo Scrap
                        Catalogo_Scrap.CB_Scrap(CB_TipoSc, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, Seccion, TipoProd)
                    End If
                    'Activa Combo Box Operdores de Linea
                    Catalogo_Operador_Puesto_Trabajo.CB_Operador_Linea(CB_Ope, TipoProd)
                    'Consulta cantidades
                    ProductionOrder.CalCantIny(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TC_Orden.Text.Trim, TCantProgra, TCantEntre, TCantEnproce, TCantPendiente, TCantPiso)
                    'Porcentaje de avance de la orden
                    ProductionOrder.Porcentaje_Orden(TCantEntre.Text, TCantEnproce.Text, TCantProgra.Text, Label8, Btn_Notificar)
                    Me.Cursor = Cursors.Default
                Case Is = 0
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
        TC_Orden.Text = ""            'Orden Producción
        TC_Orden.Enabled = False
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
        TC_Orden.Enabled = True
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
            LecturaQry("PA_Calcula_Cantidades '" & SessionUser._sCentro & "',  '" & TC_Orden.Text.Trim & "', '1'")
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
            CveOperador.Text = SessionUser._sAlias.Trim
            Gen_Valida.Valida_Usuario(SessionUser._sAlias.Trim, SessionUser._sPassword.Trim)
            CodOperador.Text = ""
            NomOperador.Text = ""
            CveOperador.Enabled = False

            If Gen_Valida.valContador = 0 Then
                MessageBox.Show("*** USUARIO INEXISTENTE *** ")
                CveOperador.Text = ""
                CveOperador.Focus()
            Else
                CodOperador.Text = SessionUser._sAlias
                NomOperador.Text = SessionUser._sNombre
                RB_PT.Focus()
            End If
            RB_PT.Focus()
        Else
            CveOperador.Focus()
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
            Reportes.Boleta_Pesaje_PTE_Iny(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TC_Orden.Text.Trim, TFolioAtlas.Text.Trim, "0")
        End If

        If RB_SC.Checked Then
            Reportes.Boleta_Pesaje_SCE_Iny(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TC_Orden.Text.Trim, TFolioAtlas.Text.Trim, "0")
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