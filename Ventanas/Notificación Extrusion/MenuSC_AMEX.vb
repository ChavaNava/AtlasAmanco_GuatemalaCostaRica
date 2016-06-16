Imports System.IO
Imports System.IO.Ports.SerialPort
Imports System.IO.Ports.SerialDataReceivedEventArgs
Imports System.IO.Ports.SerialPinChangedEventArgs
Imports System.Data.SqlClient
Imports System.Configuration
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Net.Mail
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class MenuSC_AMEX
    Dim Permiso As New Permisos

    Dim OrdenProd As String
    Dim NumeroPlanta As String
    Dim Equipo As String
    Dim Producto As String
    Dim CantProgPzs As Integer
    Dim Unidad As String
    Dim Inicio As String
    Dim Fin As String
    Dim Origen As String
    Dim Status1 As String
    Dim fecini As String
    Dim HrReal As String
    Dim fecterm As String
    Dim Status As String
    Dim UsrAct As String
    Dim FecAct As String = Today
    Dim Obs As String
    Dim Err As String
    Dim Mns As String
    Dim OrigInf As String = "SAP_R/3"
    Dim CantProgkg As Integer = 333

    'Variables Bascula Leon
    Dim Cadena_1 As String
    Dim LecBascula As String
    Dim Resultado_1 As String

    Dim StatusSap As String  'Status de conexión Atlas - SAP  
    Dim NomTabOp As String   'Variable para controlar el nombre de la tabla de Orden Producción    
    Dim Message As String = "Tecleé un numero de Orden de Producción"
    Dim Caption As String = "Campo vacio"
    Dim CountValOP As Integer 'Validacón para determinar  si la OF ya existe en la DB
    Dim Result As DialogResult
    Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
    Dim Botones As MessageBoxButtons = MessageBoxButtons.OK
    Dim VCountProducto As Boolean      'Validación para identificar si existe  el PT y compuesto en la BD A-TLAS
    Dim VSumNotificaciones As Integer  'Validación Sum para Notificaciones


    Dim descripcion As String = ""
    Dim taraempaque As Decimal
    Dim PesoTeorico As Decimal
    Dim CodigoEmpaque As String '---Nuevo
    Dim grpMaterial As String
    Dim EstatusActiva As Integer
    'Dim StrProducto As String
    Dim StrTramos As String
    Dim StrCompuesto As String
    Dim StrDescComp As String
    Dim EqpBasico As String
    Dim DesEqpBasico As String
    Dim WorkCenter As String = ""
    Dim CantEntregada As String
    Dim ATLAS_PASS As String
    Dim xORIGINAL As String = ""
    Dim xTIPOSCRAP As String = ""

    Dim PesoBruto As Decimal
    Dim TurnoNombre As String
    Dim HIni As String
    Dim HFin As String
    Dim FolioSiguiente As String
    Dim reg As String

    Dim ContadorRack As Integer

    Dim Compuesto_1 As String = ""
    Dim Compuesto_2 As String = ""
    Dim CompuestoPorcent_1 As Integer = 0
    Dim CompuestoPorcent_2 As Integer = 0
    Dim RecGen As String                    'Reprocesado Generado

    'Variables para determinacion de Scrap
    Dim SC_Recuperado As String     'Identifica Scrap recuperable
    Dim SC_Basura As String         'Identifica Scrap basura
    Dim SC_R As String              'Scrap recuperable
    Dim SC_B As String              'Scrap basura

    Dim strPB As Integer            'Puerto Bascula
    Dim strVP As String = ""        'Velocidad Puerto
    Dim strIP As String = ""        'Interface Puerto

    Dim Tipo As String = Chr(33)
    Dim Tipo_2 As String = Chr(2)
    Dim Tipo_3 As String = Chr(32)
    Dim Tipo_4 As String = Chr(58)
    Dim Bascula As String = ""
    Dim Cadena As String = ""
    Dim Calculo As Decimal
    Dim totaltara As Decimal = 0.0

    Dim Lectura As String = ""
    Dim Resultado As String = ""
    Dim Count1 As Integer = 0
    Dim ValCountBasculas As Integer

    Dim nvoMateria_Prima As Decimal
    Dim nvoNota_Almacen As String
    Dim nvoFecha_Pesaje As String
    Dim nvoHora_Pesaje As String
    Dim nvoBascula As String
    Dim nvoOrden_Produccion As String
    Dim nvoTipo_SCausa As String
    Dim nvoTipo_SDefecto As String
    Dim nvo_folio As String
    Dim nvoPeso_Proveedor As Decimal
    Dim nvoPorcentaje_Humedad As Decimal
    Dim nvoPeso_Bruto As Decimal
    Dim nvoTara As Decimal
    Dim nvoPeso_Neto As Decimal
    Dim nvoUsuario As String
    Dim nvoOperador As String
    Dim nvoDocumento_SAP As String
    Dim nvoConsecutivo_SAP As String
    Dim ValControlCompuesto As String
    Dim nvoPiezas_Scrap As Decimal
    Dim nvoPesoTeorico As Decimal
    Dim nvoGrupoMaterial As String

    Dim Lt_Compuestos As String
    Dim CompOriginal As String
    Dim CadenaTexto As String
    Dim Cod_Err As String
    Dim myDataReader As SqlClient.SqlDataReader
    Dim xTabla As String
    Dim Q As String
    Dim xAREA As String
    Dim FechaTurno As String
    Dim dateRegistro As Date
    Dim FechaPesaje As String
    Dim FechaPesajeSAP As String
    Dim HoraPesaje As String
    Dim Turno As String
    Dim dregistro As String = "0"
    Dim xTGRUPO As String
    Dim xUSUARIOREG As String
    Dim xFECHAREG As String
    Dim xHORAREG As String

    Private Sub MenuSC_AMEX_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        FUERATURNO = 0
    End Sub

    Private Sub MenuSC_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mfor As Integer
        Me.Icon = Util.ApplicationIcon()
        StrProducto = ""
        TCentro.Text = SessionUser._sCentro.Trim
        strNumeroBascula = ValCodigoBascula.Trim
        ' ---------------------------------------------------------------------------------
        Select Case UsrLog
            Case Is = "ATLAS"
                Result = MessageBox.Show("Dev.Báscula", "Báscula", Buttons)
                Select Case Result
                    Case 6
                        If ValCodigoBascula = "M" Or ValCodigoBascula = "X" Or FUERATURNO = 1 Then
                            TPesoCaptura.Enabled = True
                            TPesoCaptura.Visible = True
                            LPesoCaptura.Visible = True
                        Else
                            Timer1.Enabled = True
                        End If
                    Case 7 'No
                        If ValCodigoBascula = "M" Or ValCodigoBascula = "X" Or FUERATURNO = 1 Then
                            TPesoCaptura.Enabled = True
                            TPesoCaptura.Visible = True
                            LPesoCaptura.Visible = True
                        Else
                            Timer1.Enabled = True
                        End If
                End Select
                ' ---------------------------------------------------------------------------------
            Case Is <> "ATLAS"
                If ValCodigoBascula = "M" Or ValCodigoBascula = "X" Or FUERATURNO = 1 Then
                    TPesoCaptura.Enabled = True
                    TPesoCaptura.Visible = True
                    LPesoCaptura.Visible = True
                Else
                    Timer1.Enabled = True
                End If
        End Select
        ' ---------------------------------------------------------------------------------
        'QRY_AMD = ""
        'QRY_AMD = "Select ADM_StatusSAP.Status FROM ADM_StatusSAP WHERE Planta='" & strPlanta.Trim & "'"
        'LecturaQry_AMD(QRY_AMD)
        'If (LecturaBD_AMD.Read) Then
        '    StatusSap = LecturaBD_AMD(0)
        'End If
        'LecturaBD_AMD.Close()
        ' ---------------------------------------------------------------------------------
        'Se verifica conexión con SAP
        Permiso.SAP_Status("E", tsImagen)
        ' ---------------------------------------------------------------------------------
        'Select Case StatusSap
        '    Case "True"
        '        PicBoxStop.Visible = False
        '        PicBoxSatelite.Visible = True
        '        lblEspera.Text = "ON"
        '        lblEspera.ForeColor = Color.Lime
        '    Case "False"
        '        PicBoxStop.Visible = True
        '        PicBoxSatelite.Visible = False
        '        lblEspera.Text = "OFF"
        '        lblEspera.ForeColor = Color.Red
        'End Select
        ' ---------------------------------------------------------------------------------
        Try
            Dim dsCombo As DataSet
            Q = ""
            Q = "SELECT RTRIM(Descripcion)  FROM dbo.ADM_Turno"
            Q = Q & " WHERE planta= '" & SessionUser._sCentro.Trim & "'"
            Q = Q & " GROUP BY Descripcion"

            AbrirConfiguracion()

            objDa = New SqlDataAdapter(Q, objCnn)
            dsCombo = New DataSet
            objDa.Fill(dsCombo)
            With dsCombo.Tables(0)
                For mfor = 0 To .Rows.Count - 1
                    cmbTurnos.Items.Add(.Rows(mfor).Item(0).ToString.Trim)
                Next
            End With
        Catch ex As Exception
            MessageBox.Show("Error llenar Turnos :" & ex.Message, "  VENTANA DE ERROR * * * ")
        End Try
        LecturaBD_AMD.Close()
        ' ---------------------------------------------------------------------------------
        dregistro = "0"
        dateRegistro = Today()
        FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        HoraPesaje = Date.Now.TimeOfDay.ToString
        QRY_AMD = ""
        QRY_AMD = "Select Turno, Descripcion, Convert(char(8),Hora_Inicio,108) as HoraIni, "
        QRY_AMD = QRY_AMD & "Convert(char(8),Hora_Terminacion,108) as HoraFin, "
        QRY_AMD = QRY_AMD & "Convert(char(8),getdate(),108) as Hora_Real "
        QRY_AMD = QRY_AMD & "From ADM_Turno "
        QRY_AMD = QRY_AMD & "Where Convert(char(8),getdate(),108) Between Convert(char(8),Hora_Inicio,108) "
        QRY_AMD = QRY_AMD & "And Convert(char(8),Hora_Terminacion,108) "
        QRY_AMD = QRY_AMD & "And Planta = '" & SessionUser._sCentro.Trim & "'"
        LecturaQry_AMD(QRY_AMD)

        Do While (LecturaBD_AMD.Read)
            cmbTurnos.Text = LecturaBD_AMD(0)
            dateRegistro = DateAdd(DateInterval.Day, -Val(LecturaBD_AMD(4)), dateRegistro)
        Loop
        LecturaBD_AMD.Close()
        ' ---------------------------------------------------------------------------------
        dtpFECHA.Value = Date.Today.ToString("yyyy-MM-dd")
        dtpFECHASAP.Value = Date.Today.ToString("yyyy-MM-dd")
        'If FUERATURNO = 1 Then
        cmbTurnos.Enabled = True
        dtpFECHA.Enabled = True
        dtpFECHASAP.Enabled = True
        chkSAP.Enabled = True
        'Else
        '    cmbTurnos.Enabled = False
        '    dtpFECHA.Enabled = False
        '    dtpFECHASAP.Enabled = False
        '    chkSAP.Enabled = False
        'End If
        ' ---------------------------------------------------------------------------------
        Select Case SessionUser._sCentro.Trim
            Case Is = "A022"
                Label16.Visible = True
                Label16.Enabled = True
                TCveOpe.Visible = True
                TCveOpe.Enabled = True
                btnLookOpe.Visible = True
                btnLookOpe.Enabled = True
                TNOpe.Visible = True
                TNOpe.Enabled = True
            Case Else
                Label16.Visible = False
                Label16.Enabled = False
                TCveOpe.Visible = False
                TCveOpe.Enabled = False
                btnLookOpe.Visible = False
                btnLookOpe.Enabled = False
                TNOpe.Visible = False
                TNOpe.Enabled = False
        End Select
        LimpiaObjetos()
        TClaveOperador.Focus()
    End Sub

    Private Sub TOrden_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TOrden.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub LimpiaVariables()
        Message.Remove(0)
        Caption.Remove(0)
    End Sub
    Private Sub Actualiza_turnos()
        QRY_AMD = ""
        QRY_AMD = " Select TT.Turno, TT.Descripcion, Convert(char(8),TT.Hora_Inicio,108) as Hora_Inicio, "
        QRY_AMD = QRY_AMD & " Convert(char(8),TT.Hora_Terminacion,108) as Hora_Terminacion, TT.registro "
        QRY_AMD = QRY_AMD & " FROM ADM_Turno TT INNER JOIN ADM_CambioHora CH ON TT.Planta=CH.Planta "
        QRY_AMD = QRY_AMD & " AND Convert(char(10), getdate(),102)between Convert(char(10), CH.Fecha_Inicio,102) AND Convert(char(10),CH.fecha_Terminacion,102) "
        QRY_AMD = QRY_AMD & " WHERE Convert(char(8), getdate()+(CH.CHora/24),108) between Convert(char(8), Hora_Inicio,108) "
        QRY_AMD = QRY_AMD & " AND Convert(char(8),Hora_Terminacion,108) and TT.Planta='" & SessionUser._sCentro.Trim & "' "
        LecturaQry_AMD(QRY_AMD)
        Turno = "1"
        Do While (LecturaBD_AMD.Read)
            Turno = LecturaBD_AMD(0)
            dateRegistro = DateAdd(DateInterval.Day, -Val(LecturaBD_AMD(4)), dateRegistro)
        Loop
        If cmbTurnos.Items.Count > 0 Then
            cmbTurnos.SelectedIndex = Turno - 1
        End If
        LecturaBD_AMD.Close()

        If FUERATURNO = 1 Then
            cmbTurnos.Enabled = True
            dtpFECHA.Enabled = True
            dtpFECHASAP.Enabled = True
            chkSAP.Enabled = True
        Else
            cmbTurnos.Enabled = False
            dtpFECHA.Enabled = False
            dtpFECHASAP.Enabled = False
            chkSAP.Enabled = False
        End If
    End Sub

    Private Sub LimpiaObjetos()
        TOrden.Text = ""
        TRack.Text = ""
        TPesoRack.Text = "0"
        Descrack.Text = ""
        TCodPT.Text = ""
        TCodPtDesc.Text = ""
        TGrpprod.Text = ""
        TGrpproddesc.Text = ""
        TPesoTeorico.Text = ""
        TGrupo.Text = ""
        TPtoTrabajo.Text = ""
        TPesoCaptura.Text = "00" & GDECIMAL & "00"
        TFolioAtlas.Text = ""
        TNumNoti.Text = ""
        TConsNoti.Text = ""
        TOrden.Enabled = True
        TRack.Enabled = True
        TCausas.Text = ""
        Desccausa.Text = ""
        TDefectos.Text = ""
        Desdefecto.Text = ""
        TClaveOperador.Text = ""
        TCodOperador.Text = ""
        TNomOperador.Text = ""
        TNomPtoTrabajo.Text = ""
        CheckBox1.Checked = False
        BCompuesto.Enabled = False
        ' ---------------------------------------------------------------------------------
        QRY_AMD = ""
        QRY_AMD = "Select Turno, Descripcion, Convert(char(8),Hora_Inicio,108) as HoraIni, "
        QRY_AMD = QRY_AMD & "Convert(char(8),Hora_Terminacion,108) as HoraFin, "
        QRY_AMD = QRY_AMD & "Convert(char(8),getdate(),108) as Hora_Real "
        QRY_AMD = QRY_AMD & "From ADM_Turno "
        QRY_AMD = QRY_AMD & "Where Convert(char(8),getdate(),108) Between Convert(char(8),Hora_Inicio,108) "
        QRY_AMD = QRY_AMD & "And Convert(char(8),Hora_Terminacion,108) "
        QRY_AMD = QRY_AMD & "And Planta = '" & SessionUser._sCentro.Trim & "'"
        LecturaQry_AMD(QRY_AMD)

        Do While (LecturaBD_AMD.Read)
            cmbTurnos.Text = LecturaBD_AMD(0)
            dateRegistro = DateAdd(DateInterval.Day, -Val(LecturaBD_AMD(4)), dateRegistro)
        Loop
        LecturaBD_AMD.Close()
        ' ---------------------------------------------------------------------------------
        BPesar.Enabled = False
        BImprimir.Enabled = False
        TOrden.Enabled = True
    End Sub

    Private Sub TRack_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRack.Leave
        If TRack.Text.Trim = "M" Then
            Me.TPesoRack.ReadOnly = False
            Me.Descrack.Text = " Peso Asignado Manualmente"
            Me.TPesoRack.Focus()
        Else
            Me.TPesoRack.ReadOnly = True
            If Val(TRack.Text.Trim.Length) > 0 Then
                ' ---------------------------------------------------------------------------------
                QRY = ""
                QRY = " SELECT descripcion, tara FROM Racks "
                QRY = QRY & " WHERE Centro = '" & SessionUser._sCentro.Trim & "'"
                QRY = QRY & " AND rtrim(Rack) = '" & TRack.Text.Trim & "'"
                LecturaQry(QRY)
                If LecturaBD.Read Then
                    Descrack.Text = LecturaBD(0)
                    TPesoRack.Text = LecturaBD(1)
                Else
                    Me.TRack.Text = ""
                    Me.TPesoRack.Text = "0"
                    Me.Descrack.Text = ""
                End If
                LecturaBD.Close()
                ' ---------------------------------------------------------------------------------
            Else
                Me.TRack.Text = ""
                Me.TPesoRack.Text = "0"
                Me.Descrack.Text = ""
            End If
            ' ---------------------------------------------------------------------------------
        End If

        TRack.BackColor = Color.White
    End Sub
    Private Sub TPesoRack_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoRack.TextChanged
        TPesoTara.Text = Format(Val(TPesoRack.Text), "#####0.00")
    End Sub
    Private Sub BSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSiguiente.Click
        LimpiaObjetos()
        TClaveOperador.Focus()
    End Sub
    Private Sub TOrden_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOrden.Leave
        Dim Q As String
        Dim CountValOP As Integer
        Dim OrdenOP As String
        Dim StatusOP As Char
        Dim xCantProgPzs As String = ""
        Dim xCantProgkg As String = ""
        ' ---------------------------------------------------------------------------------
        If TOrden.Text = "" Then
            Message = "Tecleé un numero de Orden de Producción"
            Caption = "Campo vacio"
            Result = MessageBox.Show(Message, Caption, Buttons)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                TOrden.Text = ""
                TOrden.Focus()
                Exit Sub
            Else
                If Result = System.Windows.Forms.DialogResult.No Then
                    Close()
                    Return
                End If
            End If
        End If
        ' ---------------------------------------------------------------------------------
        CountValOP = 0
        QRY = ""
        QRY = " Select Orden_Produccion, Estatus_Activa  FROM  " & SessionUser._sCentro.Trim & "_OrdenProduccion"
        QRY = QRY & " WHERE  " & SessionUser._sCentro.Trim & "_OrdenProduccion.Orden_Produccion = '" & TOrden.Text.Trim & "'"
        QRY = QRY & " AND " & SessionUser._sCentro.Trim & "_OrdenProduccion.Planta = '" & SessionUser._sCentro.Trim & "'"
        LecturaQry(QRY)
        CountValOP = 0
        OrdenOP = ""
        StatusOP = ""
        Do While (LecturaBD.Read())
            CountValOP = CountValOP + 1
            OrdenOP = LecturaBD(0)
            StatusOP = LecturaBD(1).ToString
        Loop
        LecturaBD.Close()

        If StatusOP = "True" Then
            StatusOP = "1"
        ElseIf StatusOP = "False" Then
            StatusOP = "0"
        End If
        ' -----------------------------------------Inicio : Case: Búsqueda de OF en BD ATLAS
        Select Case CountValOP
            Case Is = 0 'Case: Búsqueda de OF en BD ATLAS -- 0 
                Message = " Orden de Producción no Existe en (- ATLAS -), Desea dar de Alta? "
                Caption = "Orden de Producción Inexistente"
                Result = MessageBox.Show(Message, Caption, Buttons, MessageBoxIcon.Exclamation)
                ' ----------------------------------------- Reultado " NO " 
                If Result = System.Windows.Forms.DialogResult.No Then
                    Me.TOrden.Text = ""
                    Me.TOrden.Focus()
                    Exit Sub
                End If
                ' ----------------------------------------- Inicio : Identificación de Usuario
                Select Case UsrLog 'Identificación de Usuario
                    Case "ATLAS"
                        Dim lo_wsamancomx As New Read.ZPP001_91Service
                        Dim ls_return As New Read.ZBAPIRET2
                        Dim ls_values As New Read.ZEPP001
                        lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                        ' ----------------------------------------- Regresa Datos de la OP
                        ls_values = lo_wsamancomx.Z_PP001(Me.TOrden.Text, ls_return)
                        OrdenProd = ls_values.ZORDER_NUMBER
                        NumeroPlanta = ls_values.ZPRODUCTION_PLANT
                        Equipo = ls_values.ZWORK_CENTER
                        Producto = ls_values.ZMATERIAL
                        CantProgPzs = ls_values.ZTARGET_QUANTITY
                        Unidad = ls_values.ZUNIT
                        Inicio = ls_values.ZSTART_DATE
                        Fin = ls_values.ZFINISH_DATE
                        Origen = ls_values.ZORIGIN
                        Status1 = ls_values.ZSTATUS
                        fecini = ls_values.ZACTUAL_START_DATE
                        HrReal = ls_values.ZACTUAL_START_TIME
                        fecterm = ls_values.ZACTUAL_FINISH_DATE
                        Status = "1"
                        UsrAct = Usrsap
                        FecAct = Date.Today.ToString("yyyy/MM/dd")
                        Obs = "Carga SAP"
                        Err = ls_return.ZTYPE
                        Mns = ls_return.ZMESSAGE
                    Case Is <> "ATLAS" '--------------- Identificación de Usuario
                        Dim lo_wsamancomx As New Lee_OFP.ZPP001_91Service
                        Dim ls_return As New Lee_OFP.ZBAPIRET2
                        Dim ls_values As New Lee_OFP.ZEPP001
                        lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                        ls_values = lo_wsamancomx.Z_PP001(Me.TOrden.Text, ls_return)
                        OrdenProd = ls_values.ZORDER_NUMBER
                        NumeroPlanta = ls_values.ZPRODUCTION_PLANT
                        Equipo = ls_values.ZWORK_CENTER
                        Producto = ls_values.ZMATERIAL
                        CantProgPzs = ls_values.ZTARGET_QUANTITY
                        Unidad = ls_values.ZUNIT
                        Inicio = ls_values.ZSTART_DATE
                        Fin = ls_values.ZFINISH_DATE
                        Origen = ls_values.ZORIGIN
                        Status1 = ls_values.ZSTATUS
                        fecini = ls_values.ZACTUAL_START_DATE
                        HrReal = ls_values.ZACTUAL_START_TIME
                        fecterm = ls_values.ZACTUAL_FINISH_DATE
                        Status = "1"
                        UsrAct = Usrsap
                        FecAct = Date.Today.ToString("yyyy/MM/dd")
                        Obs = "Carga SAP"
                        Err = ls_return.ZTYPE
                        Mns = ls_return.ZMESSAGE
                End Select
                ' ----------------------------------------- Inicio : Verifica si existe algún error  en la  OP
                If Err = "E" Then
                    MessageBox.Show(Mns, "Error SAP Notifique al Supervisor")
                    Me.TOrden.Text = ""
                    Me.TOrden.Focus()
                    Return
                End If
                ' ----------------------------------------- Inicio : Análisis  de Status SAP de OP
                Select Case Status1
                    Case Is <> "LIB."
                        Message = "Orden de Producción no esta liberada"
                        Caption = "Orden no liberada"
                        Result = MessageBox.Show(Message, Caption, Botones, MessageBoxIcon.Exclamation)
                        If Result = System.Windows.Forms.DialogResult.OK Then
                            Me.TOrden.Text = ""
                            Me.TOrden.Focus()
                            Exit Sub
                        End If
                    Case Is = "LIB."
                        ' ----------------------------------------- Inicio : Funciones que eliminan  ceros a la Izquierda 
                        If SessionUser._sCentro.Trim <> "A001" Then
                            CerosIzquierda(OrdenProd)
                            OrdenProd = RegresaCeroIzq
                            Producto = CerosIzquierda(Producto)
                            Producto = RegresaCeroIzq
                        End If
                        ' ----------------------------------------- Validacion CENTRO 
                        If Not NumeroPlanta.Trim = SessionUser._sCentro.Trim Then
                            Message = "Orden de Producción no pertenece al centro " & SessionUser._sCentro.Trim
                            Caption = "Orden de otro centro"
                            Result = MessageBox.Show(Message, Caption, Botones)
                            If Result = System.Windows.Forms.DialogResult.OK Then
                                Me.TOrden.Text = ""
                                Me.TOrden.Focus()
                                Exit Sub
                            End If
                        Else
                            ' ----------------------------------------- Inicio : Insert de la  OP inexistente  en BD Atlas 
                            If TCodOperador.Text.Trim <> "" Then
                                xUSUARIOREG = TCodOperador.Text.Trim
                            Else
                                xUSUARIOREG = SessionUser._sAlias
                            End If
                            xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
                            xHORAREG = Date.Now.TimeOfDay.ToString

                            '-- Grupo Material --

                            xTGRUPO = ""
                            QRY = ""
                            QRY = "SELECT GrupMaterial FROM ProductoTerminadoExtrusion WHERE Centro = " & "'" & NumeroPlanta & "' AND Codigo = '" & Producto.Trim & "'"
                            LecturaQry(QRY)

                            If LecturaBD.Read() Then
                                xTGRUPO = LecturaBD(0)
                            End If

                            TGrupo.Text = xTGRUPO.Trim
                            xCantProgPzs = Replace(CantProgPzs, GDECIMAL, ".")
                            xCantProgkg = Replace(CantProgkg, GDECIMAL, ".")
                            ' ---------------------------------------------------------------------------------
                            InQry = ""
                            InQry = "INSERT INTO " & SessionUser._sCentro.Trim & "_OrdenProduccion (Orden_Produccion, Planta, Equipo_Basico, Producto, Cantidad_Programada_Tramos, Cantidad_Programada_Kilos, Fecha_Inicio, Fecha_Termino, Origen_Informacion, Estatus_Activa, Usuario_Actualiza, Fecha_Actualizacion, Observaciones, usuarioreg, fechareg, horareg,grupmaterial ) "
                            InQry = InQry & " VALUES('" & OrdenProd & "'" & "," & "'" & NumeroPlanta & "'" & "," & "'" & Equipo & "'" & "," & Producto & "," & xCantProgPzs & "," & xCantProgkg & "," & "'" & fecini & "'" & "," & "'" & fecterm & "'" & "," & "'" & OrigInf & "'" & "," & Status & "," & "'" & UsrAct.Trim & "'" & "," & "'" & FecAct & "'" & "," & " '" & Obs.Trim & "','" & xUSUARIOREG & "','" & xFECHAREG & "','" & xHORAREG & "', '" & xTGRUPO.Trim & "')"
                            InsertQry(InQry)
                            ' ---------------------------------------------------------------------------------
                            Message = "Digite la orden creada para cargar datos...."
                            Caption = "Orden Creada"
                            Result = MessageBox.Show(Message, Caption)
                            Me.TOrden.Text = ""
                            Me.TOrden.Focus()
                            Exit Sub
                        End If
                End Select
                ' ----------------------------------------- Fin : Análisis  de Status SAP de OP
            Case Is > 0 ' ----------------------------------------- Case: Búsqueda de OF en BD ATLAS -- >0
                ' ----------------------------------------- Inicio Revisión de orden
                If StatusOP = "0" Then
                    Message = "La Orden fue DESACTIVADA ( - ATLAS - ), Desea continuar con otra Orden?  "
                    Caption = "ORDEN DESACTIVADA - ATLAS"
                    Result = MessageBox.Show(Message, Caption, Buttons, MessageBoxIcon.Error)
                    If Result = System.Windows.Forms.DialogResult.Yes Then
                        TOrden.Text = ""
                        TOrden.Focus()
                        Exit Sub
                    Else
                        If Result = System.Windows.Forms.DialogResult.No Then
                            Close()
                            Return
                        End If
                    End If
                ElseIf StatusOP = "9" Then
                    Message = " La Orden fue ELIMINADA ( - ATLAS - ), Desea continuar con otra Orden? "
                    Caption = "ORDEN ELIMINADA - ATLAS"
                    Result = MessageBox.Show(Message, Caption, Buttons, MessageBoxIcon.Error)
                    If Result = System.Windows.Forms.DialogResult.Yes Then
                        TOrden.Text = ""
                        TOrden.Focus()
                        Exit Sub
                    Else
                        If Result = System.Windows.Forms.DialogResult.No Then
                            Close()
                            Return
                        End If
                    End If
                ElseIf StatusOP = "5" Then
                    Message = " La Orden tiene CIERRE TECNICO ( - ATLAS - ), Desea continuar con otra Orden? "
                    Caption = "ORDEN CERRADA - ATLAS"
                    Result = MessageBox.Show(Message, Caption, Buttons, MessageBoxIcon.Information)
                    If Result = System.Windows.Forms.DialogResult.Yes Then
                        TOrden.Text = ""
                        TOrden.Focus()
                        Exit Sub
                    Else
                        If Result = System.Windows.Forms.DialogResult.No Then
                            Close()
                            Return
                        End If
                    End If
                End If
                ' ----------------------------------------- REVISION Cierre TECNICO SAP
                Select Case StatusSap

                    Case "True"

                        Select Case UsrLog 'Identificación de Usuario
                            Case "ATLAS"
                                Dim lo_wsamancomx As New Read.ZPP001_91Service
                                Dim ls_return As New Read.ZBAPIRET2
                                Dim ls_values As New Read.ZEPP001
                                lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                                ' ----------------------------------------- Regresa Datos de la OP
                                ls_values = lo_wsamancomx.Z_PP001(Me.TOrden.Text, ls_return)
                                OrdenProd = ls_values.ZORDER_NUMBER
                                NumeroPlanta = ls_values.ZPRODUCTION_PLANT
                                Equipo = ls_values.ZWORK_CENTER
                                Producto = ls_values.ZMATERIAL
                                CantProgPzs = ls_values.ZTARGET_QUANTITY
                                Unidad = ls_values.ZUNIT
                                Inicio = ls_values.ZSTART_DATE
                                Fin = ls_values.ZFINISH_DATE
                                Origen = ls_values.ZORIGIN
                                Status1 = ls_values.ZSTATUS
                                fecini = ls_values.ZACTUAL_START_DATE
                                HrReal = ls_values.ZACTUAL_START_TIME
                                fecterm = ls_values.ZACTUAL_FINISH_DATE
                                Status = "1"
                                UsrAct = Usrsap
                                FecAct = Date.Today.ToString("yyyy/MM/dd")
                                Obs = "Carga SAP"
                                Err = ls_return.ZTYPE
                                Mns = ls_return.ZMESSAGE
                            Case Is <> "ATLAS" 'Identificación de Usuario
                                Dim lo_wsamancomx As New Lee_OFP.ZPP001_91Service
                                Dim ls_return As New Lee_OFP.ZBAPIRET2
                                Dim ls_values As New Lee_OFP.ZEPP001
                                lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                                ls_values = lo_wsamancomx.Z_PP001(Me.TOrden.Text, ls_return)
                                OrdenProd = ls_values.ZORDER_NUMBER
                                NumeroPlanta = ls_values.ZPRODUCTION_PLANT
                                Equipo = ls_values.ZWORK_CENTER
                                Producto = ls_values.ZMATERIAL
                                CantProgPzs = ls_values.ZTARGET_QUANTITY
                                Unidad = ls_values.ZUNIT
                                Inicio = ls_values.ZSTART_DATE
                                Fin = ls_values.ZFINISH_DATE
                                Origen = ls_values.ZORIGIN
                                Status1 = ls_values.ZSTATUS
                                fecini = ls_values.ZACTUAL_START_DATE
                                HrReal = ls_values.ZACTUAL_START_TIME
                                fecterm = ls_values.ZACTUAL_FINISH_DATE
                                Status = "1"
                                UsrAct = Usrsap
                                FecAct = Date.Today.ToString("yyyy/MM/dd")
                                Obs = "Carga SAP"
                                Err = ls_return.ZTYPE
                                Mns = ls_return.ZMESSAGE
                        End Select ' -----------------------------------------Identificación de Usuario
                        ' ----------------------------------------- Fin : Identificación de Usuario
                        ' ----------------------------------------- Inicio : Verifica si existe algún error  en la  OP
                        If Err = "E" Then
                            MessageBox.Show(Mns, "Error SAP Notifique al Supervisor")
                            Me.TOrden.Text = ""
                            Me.TOrden.Focus()
                            Return
                        End If
                        ' ----------------------------------------- Inicio : Verifica si existe algún error  en la  OP
                        ' ----------------------------------------- Inicio : Análisis  de Status SAP de OP
                        Select Case Status1
                            Case Is <> "LIB."
                                If Status1 = "CTEC" Then
                                    Message = "Orden de Producción SE encuentra con cierre TECNICO."
                                    Caption = "Orden con CIERRE TECNICO"
                                Else
                                    Message = "Orden de Producción no se encuentra liberada."
                                    Caption = "Orden no liberada"
                                End If
                                Result = MessageBox.Show(Message, Caption, Botones)
                                If Result = System.Windows.Forms.DialogResult.OK Then
                                    Me.TOrden.Text = ""
                                    Me.TOrden.Focus()
                                    Exit Sub
                                End If
                            Case Is = "LIB."
                                ' ----------------------------------------- Inicio : Funciones que eliminan  ceros a la Izquierda 
                                If SessionUser._sCentro.Trim <> "A001" Then
                                    CerosIzquierda(OrdenProd)
                                    OrdenProd = RegresaCeroIzq
                                    Producto = CerosIzquierda(Producto)
                                    Producto = RegresaCeroIzq
                                End If
                        End Select
                End Select
                ' ----------------------------------------- Verificacion puestos de trabajo
                '     QRY = ""
                '      QRY = "Select Producto, Estatus_Activa, Equipo_basico, grupmaterial From " & strPlanta.Trim & "_OrdenProduccion "
                '       QRY = QRY & "   Where Planta = '" & strPlanta.Trim & "' And Orden_Produccion = '" & TOrden.Text.Trim & "'"

                QRY = ""
                QRY = "SELECT PTE.Grpprod, PTE.Descr, PTE.Empaque, PTE.PesoTeorico,"
                QRY = QRY & " OP.Estatus_Activa, PTE.Codigo, "
                QRY = QRY & " OP.cantidad_programada_tramos, OP.Equipo_Basico, OP.GrupMaterial,a.Descripcion "
                QRY = QRY & " FROM " & SessionUser._sCentro.Trim & "_OrdenProduccion OP, ProductoTerminadoExtrusion PTE, EquipoBasico a "
                QRY = QRY & " WHERE PTE.Codigo = OP.Producto "
                QRY = QRY & " AND PTE.Centro = OP.Planta "
                QRY = QRY & " AND OP.Planta = a.Planta "
                QRY = QRY & " AND OP.Equipo_Basico = a.Equipo_Basico "
                QRY = QRY & " AND OP.Orden_Produccion = '" & Me.TOrden.Text.Trim & "' "
                QRY = QRY & " AND OP.Planta = '" & SessionUser._sCentro.Trim & "' And OP.Estatus_Activa = 1"
                LecturaQry(QRY)
                Do While (LecturaBD.Read())
                    xAREA = LecturaBD(0)            'Descripción del PT
                    descripcion = LecturaBD(1)      'Descripción del PT
                    CodigoEmpaque = LecturaBD(2)    'Código del empaque 
                    PesoTeorico = LecturaBD(3)      ' Peso Teórico ( Calculo de Sobrepeso )
                    EstatusActiva = LecturaBD(4)
                    StrProducto = LecturaBD(5)      'Código PT
                    StrTramos = LecturaBD(6)        'Cantidad Programada 
                    EqpBasico = LecturaBD(7)
                    grpMaterial = LecturaBD(8)
                    DesEqpBasico = LecturaBD(9)
                    WorkCenter = UCase(EqpBasico)
                Loop

                If xAREA = Nothing Then
                    MsgBox("No esta dado de alta en A-tlas Puesto de Trabajo")
                    TOrden.Text = ""
                    TOrden.Focus()
                    LecturaBD.Close()
                    Exit Sub
                End If

                If StrProducto = Nothing Then
                    MsgBox("No esta dado de alta en A-tlas Codigo de Producto")
                    TOrden.Text = ""
                    TOrden.Focus()
                    LecturaBD.Close()
                    Exit Sub
                End If



                LecturaBD.Close()

                'Dim Identificador1 As Integer = 0
                'Dim DescPT As String = ""
                'QRY = ""
                'QRY = "Select Grpprod, Codigo , Descr , PesoTeorico, grupmaterial FROM ProductoTerminadoExtrusion where Centro = '" & strPlanta.Trim & "'"
                'QRY = QRY & " And Codigo = '" & TCodPT.Text.Trim & "'"
                'LecturaQry(QRY)
                'Do While (LecturaBD.Read())
                '    xAREA = "" & LecturaBD(0)    'Area PTI  
                '    Identificador1 = 1
                '    DescPT = "" & LecturaBD(2)    'Código PTI  
                '    PesoTeorico = "0" & LecturaBD(3)    ' Peso Teórico ( Calculo de Sobrepeso )
                '    GrupoMaterial = "" & LecturaBD(4)    ' grupo material
                '    TPesoTeorico.Text = PesoTeorico
                '    TGrupo.Text = GrupoMaterial
                'Loop
                'LecturaBD.Close()
                'If Identificador1 = 1 Then
                '    TCodPtDesc.Text = DescPT
                'Else
                '    QRY = ""
                '    QRY = "Select Grpprod, Codigo , Descr, PesoTeorico From ProductoTerminadoInyeccion where Centro = '" & strPlanta.Trim & "'"
                '    QRY = QRY & "And Codigo = '" & TCodPT.Text.Trim & "'"
                '    LecturaQry(QRY)
                '    Do While (LecturaBD.Read())
                '        xAREA = LecturaBD(0)    'Area PTI  
                '        TCodPtDesc.Text = LecturaBD(2)    'Código PTI  
                '        PesoTeorico = LecturaBD(3)    ' Peso Teórico ( Calculo de Sobrepeso )
                '        TPesoTeorico.Text = PesoTeorico
                '    Loop
                'End If
                'LecturaBD.Close()
                ' ----------------------------------------- Datos del grupo de produccion
                TGrpprod.Text = xAREA.Trim
                Q = "SELECT desgrupo FROM catgrupos  "
                Q = Q & "WHERE centro = '" & SessionUser._sCentro.Trim & "' "
                Q = Q & "AND grpprod = '" & TGrpprod.Text.Trim & "' "
                Q = Q & "AND status = 'A'"
                TGrpproddesc.Text = TraeDescripcion(Q)
                ' ----------------------------------------- Datos del Puesto de Trabajo
                TPtoTrabajo.Text = EqpBasico.Trim
                WorkCenter = TPtoTrabajo.Text
                Q = " SELECT Descripcion FROM MCPC_EquipoBasico"
                Q = Q & " WHERE planta = '" & SessionUser._sCentro.Trim & "' "
                Q = Q & " AND rtrim(Equipo_basico) = '" & TPtoTrabajo.Text.Trim & "'"
                TNomPtoTrabajo.Text = TraeDescripcion(Q)
        End Select
        ' ----------------------------------------- Valor control de compuestos
        TGrupo.Text = grpMaterial.Trim

        ValControlCompuesto = ""
        QRY = ""
        QRY = " Select ValCompuesto  From  ProductoTerminadoExtrusion  Where Centro = '" & SessionUser._sCentro.Trim & "' And Codigo = '" & StrProducto.Trim & "'"
        LecturaQry(QRY)
        Do While (LecturaBD.Read())
            ValControlCompuesto = LecturaBD(0)    'Peso Unitario del Empaque
        Loop
        LecturaBD.Close()
        ' ----------------------------------------- Activación BOTON para Compuestos
        TCodPT.Text = StrProducto.Trim   'Código PT
        TCodPtDesc.Text = descripcion.Trim   'Descripción del PT
        TPtoTrabajo.Text = EqpBasico.Trim  'Puesto de Trabajo
        TPesoTeorico.Text = PesoTeorico.ToString.Trim  'Peso Teorico
        TNomPtoTrabajo.Text = DesEqpBasico.Trim
        '  Tempaque.Text = taraempaque.ToString.Trim 'Peso Unitario del Empaque

        CheckBox1.Checked = False
        If Val(ValControlCompuesto.Trim) = 0 Then
            BCompuesto.Enabled = False
            '    BImprimir.Enabled = True
        Else
            BCompuesto.Enabled = True
        End If
        BPesar.Enabled = True
        TOrden.BackColor = Color.White
    End Sub

    Private Sub TPesoBruto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoBruto.TextChanged
        Dim xTPesoBruto As Double
        Dim xTPesoTara As Double
        Dim xTPesoNeto As Double
        xTPesoBruto = TPesoBruto.Text.Trim
        xTPesoTara = "0" & TPesoTara.Text.Trim

        If xTPesoBruto >= 0 Then
            xTPesoNeto = xTPesoBruto - xTPesoTara
            TPesoNeto.Text = Format(xTPesoNeto, xFormato)
        Else
            TPesoNeto.Text = 0
        End If

    End Sub

    Private Sub TPesoTara_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoTara.TextChanged
        Dim xTPesoBruto As Double
        Dim xTPesoTara As Double
        Dim xTempaquePesoTot As Double
        Dim xTPesoNeto As Double
        xTPesoBruto = "0" & TPesoBruto.Text.Trim
        xTPesoTara = "0" & TPesoTara.Text.Trim
        xTPesoNeto = xTPesoBruto - xTPesoTara - xTempaquePesoTot
        TPesoNeto.Text = Format(xTPesoNeto, xFormato)
    End Sub

    Private Sub BPesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPesar.Click

        If Val(ValControlCompuesto.Trim) > 0 Then
            If CheckBox1.Checked = True Then
                If ValPublic_CompuestoVirgen.Trim.Length = 0 Then
                    If ValPublic_ReproConsumo.Trim.Length = 0 Then
                        If ValPublic_Ccompuesto1.Trim.Length = 0 Or ValPublic_Ccompuesto2.Trim.Length = 0 Or ValPublic_PorcentajeCom1 = 0 Or ValPublic_PorcentajeCom2 = 0 Then
                            MsgBox("Selecciona Un Compuesto ", MsgBoxStyle.Critical)

                            Exit Sub
                        End If
                    End If
                End If
            Else
                MsgBox("Selecciona Un Compuesto ", MsgBoxStyle.Critical)
                Return
            End If
        End If

        Dim TipoNotificacion As Char = "0"
        ' ---------------------------------------------------------------------------------
        If TClaveOperador.Text = "" Then
            Mensajes("***  Tecleé clave de operador  *** ", 1)
            TClaveOperador.Focus()
            Exit Sub
        End If

        If TOrden.Text = "" Then
            Mensajes("***  Tecleé Orden de Producción  *** ", 1)
            TOrden.Focus()
            Exit Sub
        End If

        If TRack.Text = "" Then
            Mensajes("***  Tecleé codigo de CARRO/RACK   *** ", 1)
            TRack.Focus()
            Exit Sub
        End If

        If TCausas.Text.Trim.Length = 0 Then
            Mensajes("***  Seleccione una CAUSA de Scrap   *** ", 1)
            TCausas.Focus()
            Exit Sub
        End If

        If TDefectos.Text.Trim.Length = 0 Then
            Mensajes("***  Seleccione un DEFECTO de Scrap   *** ", 1)
            TDefectos.Focus()
            Exit Sub
        End If

        If TPtoTrabajo.Text = "" Then
            Mensajes("***  No hay puesto de trabajo, comuniquese con el Supervisor  *** ", 1)
            Exit Sub
        End If

        If SessionUser._sCentro.Trim = "A022" Then
            If TCveOpe.Text.Trim = "" Then
                Mensajes("***  Seleccione operador de linea  *** ", 1)
                Exit Sub
            End If
        End If
        ' ---------------------------------------------------------------------------------
        nvoPeso_Bruto = "0" & TPesoBruto.Text.Trim
        nvoTara = "0" & TPesoTara.Text.Trim
        nvoPeso_Neto = "" & TPesoNeto.Text.Trim
        nvoPesoTeorico = "0" & TPesoTeorico.Text.Trim
        nvoUsuario = TCodOperador.Text.Trim
        nvoOperador = TCveOpe.Text.Trim

        If (nvoPeso_Neto <= 0) Then
            Mensajes("***  Peso NETO es menor o igual a cero  *** ", 1)
            Exit Sub
        End If

        If (nvoPesoTeorico <= 0) Then
            Mensajes("***  Peso TEORICO es menor o igual a cero  *** ", 1)
            Exit Sub
        End If

        If (nvoPeso_Bruto < nvoTara) Then
            Mensajes("***  El Peso Bruto debe ser mayor que La Tara  *** ", 1)
            Exit Sub
        End If

        If (nvoPeso_Bruto <= 0) Then
            MessageBox.Show("***  Coloque algo sobre la báscula  *** ")
            Exit Sub
        End If

        If TCveScrap.Text = "" Then
            Mensajes("***  Selecciona si es SCRAP ó PURGA   *** ", 1)
            Exit Sub
        End If
        ' ---------------------------------------------------------------------------------
        nvoBascula = "" & strNumeroBascula
        nvoFecha_Pesaje = Date.Today.ToString("yyyy-MM-dd")
        nvoHora_Pesaje = Date.Now.TimeOfDay.ToString()
        nvoOrden_Produccion = TOrden.Text.Trim

        nvoTipo_SCausa = TCausas.Text.Trim
        nvoTipo_SDefecto = TDefectos.Text.Trim

        Dim StrStatus As Boolean
        ' ---------------------------------------------------------------------------------
        QRY_AMD = ""
        QRY_AMD = "Select ADM_StatusSAP.Status FROM ADM_StatusSAP WHERE Planta='" & SessionUser._sCentro.Trim & "'"
        LecturaQry_AMD(QRY_AMD)
        If (LecturaBD_AMD.Read) Then
            StrStatus = LecturaBD_AMD(0)
        End If
        LecturaBD_AMD.Close()
        ' ---------------------------------------------------------------------------------
        If FUERATURNO = 0 Then
            dateRegistro = Today()
            FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
            HoraPesaje = Date.Now.TimeOfDay.ToString
            FechaTurno = dateRegistro.ToString("yyyy-MM-dd")
            Turno = cmbTurnos.Text.Trim
        Else
            FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
            HoraPesaje = Date.Now.TimeOfDay.ToString
            FechaTurno = dtpFECHA.Value.ToString("yyyy-MM-dd")
            Turno = cmbTurnos.Text.Trim
        End If
        ' ---------------------------------------------------------------------------------
        If ValFiltroSeleccionCodigo.Trim = "0" Then
            ValFiltroSeleccionCodigo = "0"
        End If
        ' ---------------------------------------------------------------------------------
        Dim FolioSiguiente As String

        QRY = ""
        QRY = "Select Max(Scrap)+1 as folioSiguiente from MCPC_Foliador where  "
        QRY = QRY & " Planta='" & SessionUser._sCentro.Trim & "'"
        LecturaQry(QRY)
        FolioSiguiente = "1"
        If (LecturaBD.Read) Then
            FolioSiguiente = LecturaBD(0)
        End If
        LecturaBD.Close()

        FolioSiguiente = FolioSiguiente.Trim

        InQry = "Update MCPC_Foliador set Scrap = '" & FolioSiguiente.Trim & "'"
        InQry = InQry & " where "
        InQry = InQry & " Planta='" & SessionUser._sCentro & "'"
        InsertQry(InQry)

        ' ---------------------------------------------------------------------------------
        Dim Count As Integer = 0
        QRY = ""
        QRY = "select b.ComExt_ComCodigo from productoterminadoextrusion a, CompuestoExtrusion b "
        QRY = QRY & "where a.centro = b.ComExt_PT_Centro "
        QRY = QRY & "and a.codigo = b.ComExt_PT_Codigo "
        QRY = QRY & "and a.centro = '" & SessionUser._sCentro.Trim & "' "
        QRY = QRY & "and a.codigo = '" & TCodPT.Text.Trim & "' "
        QRY = QRY & "and b.bom = '1' "
        LecturaQry(QRY)
        Do While (LecturaBD.Read())
            Count = Count + 1
            CompOriginal = LecturaBD(0)
        Loop
        LecturaBD.Close()
        ' ---------------------------------------------------------------------------------
        If Count = 0 Then
            MessageBox.Show(" No Existe compuesto definido como parte de la Bom para este Producto no se puede notificar esta orden ", " VENTANA DE ERROR * * * ")
            Return
        End If


        '                 ----- Reproceso -----
        'ValPublic_ReproConsumo
        If ValPublic_ReproConsumo.Trim.Length > 0 Then
            Compuesto_1 = ValPublic_ReproConsumo.Trim
            CompuestoPorcent_1 = 100
            Compuesto_2 = "0"
            CompuestoPorcent_2 = 0


            Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1

            ' ------------------------------------------Inicia Identifica el Recuperado Generado
            QRY = ""
            QRY = "Select RepGenerado from CompuestoExtrusion  "
            QRY = QRY & "Where comext_pt_centro = '" & SessionUser._sCentro.Trim & "' "
            QRY = QRY & "And ComExt_PT_Codigo = '" & TCodPT.Text.Trim & "' "
            QRY = QRY & "And ComExt_ComCodigo = '" & Compuesto_1.Trim & "' "

            LecturaQry(QRY)
            If (LecturaBD.Read) Then
                RecGen = LecturaBD(0)
            ElseIf Compuesto_1.Trim = "924179" Then
                RecGen = "924181"
            Else
                RecGen = "0"
            End If
            LecturaBD.Close()

            ' ----------------------------------------Finaliza Identifica el Recuperado Generado


        End If

        '                 ----- Virgen -----
        'ValPublic_CompuestoVirgen()
        If ValPublic_CompuestoVirgen.Trim.Length > 0 Then
            Compuesto_1 = ValPublic_CompuestoVirgen.Trim
            CompuestoPorcent_1 = 100
            Compuesto_2 = "0"
            CompuestoPorcent_2 = 0

            If Compuesto_1 <> CompOriginal.Trim Then
                Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1
            Else
                Lt_Compuestos = ""
            End If

            ' ------------------------------------------Inicia Identifica el Recuperado Generado
            QRY = ""
            QRY = "Select RepGenerado from CompuestoExtrusion  "
            QRY = QRY & "Where comext_pt_centro = '" & SessionUser._sCentro.Trim & "' "
            QRY = QRY & "And ComExt_PT_Codigo = '" & TCodPT.Text.Trim & "' "
            QRY = QRY & "And ComExt_ComCodigo = '" & Compuesto_1.Trim & "' "

            LecturaQry(QRY)
            If (LecturaBD.Read) Then
                RecGen = LecturaBD(0)
            ElseIf Compuesto_1.Trim = "922217" Then
                RecGen = "924181"
            Else
                RecGen = "0"
            End If
            LecturaBD.Close()

        End If

        ' ----------------------------------------Finaliza Identifica el Recuperado Generado


        '             ----- Mezcla de Compuestos -----
        If ValPublic_Ccompuesto1.Trim.Length > 0 And ValPublic_Ccompuesto2.Trim.Length > 0 Then
            'ValPublic_Ccompuesto1
            'ValPublic_PorcentajeCom1
            Compuesto_1 = ValPublic_Ccompuesto1.Trim
            CompuestoPorcent_1 = ValPublic_PorcentajeCom1

            'ValPublic_Ccompuesto2
            'ValPublic_PorcentajeCom2
            Compuesto_2 = ValPublic_Ccompuesto2.Trim
            CompuestoPorcent_2 = ValPublic_PorcentajeCom2

            Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1 + "||" + CompOriginal.Trim + "|" + CompuestoPorcent_2.ToString + "|" + Compuesto_2

            ' ------------------------------------------Inicia Identifica el Recuperado Generado
            QRY = ""
            QRY = "Select RepGenerado from CompuestoExtrusion  "
            QRY = QRY & "Where comext_pt_centro = '" & SessionUser._sCentro.Trim & "' "
            QRY = QRY & "And ComExt_PT_Codigo = '" & TCodPT.Text.Trim & "' "
            QRY = QRY & "And ComExt_ComCodigo = '" & Compuesto_1.Trim & "' "

            LecturaQry(QRY)
            If (LecturaBD.Read) Then
                RecGen = LecturaBD(0)
            End If
            LecturaBD.Close()

            ' ----------------------------------------Finaliza Identifica el Recuperado Generado


        End If
        '--- ----------- --------- ------- Fin : Variables de Configuración Compuesto


        '-------------Inicia: Determinar el codigo Scrap Generado y Scrap Basura
        QRY = ""
        QRY = "Select RepGenerado,Scrap_Basura from CompuestoExtrusion  "
        QRY = QRY & "Where comext_pt_centro = '" & SessionUser._sCentro.Trim & "' "
        QRY = QRY & "And ComExt_PT_Codigo = '" & TCodPT.Text.Trim & "' "

        LecturaQry(QRY)
        If (LecturaBD.Read) Then
            SC_Recuperado = LecturaBD(0)
            SC_Basura = LecturaBD(1)
        End If
        LecturaBD.Close()
        '-------------Fin: Determinar el codigo Scrap Generado y Scrap Basura

        CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim

        'If xTIPOSCRAP = "T" Then
        '    nvoPiezas_Scrap = nvoPeso_Neto / nvoPesoTeorico
        '    nvoPiezas_Scrap = Int(nvoPiezas_Scrap)
        '    Select Case Tipo_Scrap
        '        Case Is = True
        '            CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim & "||" & SC_Basura.Trim
        '            SC_B = SC_Basura.Trim
        '            SC_R = "0"
        '        Case Else
        '            CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim & "||" & "0"
        '            SC_B = "0"
        '            SC_R = "0"
        '    End Select
        'ElseIf xTIPOSCRAP = "G" Then
        '    nvoPiezas_Scrap = 0
        '    Select Case Tipo_Scrap
        '        Case Is = True
        '            CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim & "||" & SC_Recuperado.Trim
        '            SC_B = "0"
        '            SC_R = SC_Recuperado
        '        Case Else
        '            CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim & "||" & "0"
        '            SC_B = "0"
        '            SC_R = "0"
        '    End Select
        'End If
        ' ---------------------------------------------------------------------------------
        'If rbtFinalSi.Checked = True Then
        ' ---------------------------------------------------------------------------------
        If chkSAP.Checked = True Then
            FechaPesajeSAP = dtpFECHASAP.Value.ToString("yyyy-MM-dd")
            TNumNoti.Text = "0000000000"
            TConsNoti.Text = "00000000"

            InQry = ""
            InQry = "INSERT INTO " & SessionUser._sCentro.Trim & "_PesoScrap (Orden_Produccion,Fecha_Pesaje,Hora_Pesaje,Bascula,"
            InQry = InQry & "Tipo_Scrap,Peso_Bruto,Tara,Peso_Neto,Tramos,Usuario,Turno,Planta,Folio,Documento_SAP,"
            InQry = InQry & "Consecutivo_SAP, Notifica,Causa,Efecto,Compuesto1,Porcentaje1,Compuesto2,Porcentaje2,"
            InQry = InQry & "LTCompuestos,Fecha_Turno,notificacionmasiva,PuestoTrabajo,FolioR,RepGenerado,Area,OpePtoTra,"
            InQry = InQry & "SC_Recupera,SC_Basura) "
            InQry = InQry & "VALUES ('" & nvoOrden_Produccion & "','" & nvoFecha_Pesaje & "','" & nvoHora_Pesaje & "',"
            InQry = InQry & "'" & strNumeroBascula.Trim & "','" & xTIPOSCRAP & "',"
            InQry = InQry & "" & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & ","
            InQry = InQry & "" & Replace(nvoPeso_Neto, GDECIMAL, ".") & "," & Replace(nvoPiezas_Scrap, GDECIMAL, ".") & ","
            InQry = InQry & "'" & TCodOperador.Text.Trim & "'," & Turno.Trim & ",'" & SessionUser._sCentro.Trim & "',"
            InQry = InQry & "'" & FolioSiguiente.Trim & "', '" & TNumNoti.Text & "', '" & TConsNoti.Text & "','0',"
            InQry = InQry & "'" & nvoTipo_SCausa & "','" & nvoTipo_SDefecto & "','" & Compuesto_1 & "',"
            InQry = InQry & "" & CompuestoPorcent_1 & ",'" & Compuesto_2 & "'," & CompuestoPorcent_2 & ","
            InQry = InQry & "'" & Lt_Compuestos & "','" & FechaTurno & "', 0,'" & UCase(TPtoTrabajo.Text) & "','0',"
            InQry = InQry & "'" & RecGen.Trim & "','E','" & nvoOperador.Trim & "','0','0')"
            InsertQry(InQry)

            ' ---------------------------------------------------------------------------------
            Mensajes("Registros Actualizados : " & InsertBD, 0)
            ' ---------------------------------------------------------------------------------
            TFolioAtlas.Text = FolioSiguiente

            'Notificar a SAP

            If StrStatus = True Then
                ' ---------------------------------------------------------------------------------

                If SessionUser._sAlias.Trim <> "ATLAS" Then
                    Dim lo_wsamancomxp As New PTConProd.ZPPMXF001Service
                    Dim ls_returnp As New PTConProd.ZBAPIRET2
                    Dim ls_Notificap As New PTConProd.ZEPP002
                    Dim ls_resultp As New PTConProd._ISDFPS_TCUPS_KEY

                    ls_Notificap.ZBUDAT = FechaPesajeSAP.Trim
                    ls_Notificap.ZCONSUME_REC = 0
                    ls_Notificap.ZENTRY_QNT = 0
                    ls_Notificap.ZISM01 = 0
                    ls_Notificap.ZISM02 = 0
                    ls_Notificap.ZISM03 = 0
                    ls_Notificap.ZISMNGEH1 = ""
                    ls_Notificap.ZISMNGEH2 = ""
                    ls_Notificap.ZISMNGEH3 = ""
                    ls_Notificap.ZMATNR_REC = ""
                    ls_Notificap.ZORDERID = nvoOrden_Produccion.Trim
                    ls_Notificap.ZRECOVERED = nvoPeso_Neto
                    ls_Notificap.ZVIRGIN = 0
                    lo_wsamancomxp.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                    ls_resultp = lo_wsamancomxp.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notificap, ls_returnp)
                    TNumNoti.Text = ls_resultp.RUECK
                    TConsNoti.Text = ls_resultp.RMZHL
                    Err = ls_returnp.ZTYPE
                    Mns = ls_returnp.ZMESSAGE
                    ' ---------------------------------------------------------------------------------
                ElseIf SessionUser._sAlias.Trim = "ATLAS" Then
                    Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
                    Dim ls_returnr As New PTConsumos.ZBAPIRET2
                    Dim ls_Notifica As New PTConsumos.ZEPP002
                    Dim ls_result As New PTConsumos._ISDFPS_TCUPS_KEY

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
                    ls_Notifica.ZORDERID = nvoOrden_Produccion
                    ls_Notifica.ZRECOVERED = nvoPeso_Neto
                    ls_Notifica.ZVIRGIN = 0
                    lo_wsamancomxr.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                    ls_result = lo_wsamancomxr.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notifica, ls_returnr)
                    TNumNoti.Text = ls_result.RUECK
                    TConsNoti.Text = ls_result.RMZHL
                    Err = ls_returnr.ZTYPE
                    Mns = ls_returnr.ZMESSAGE
                End If
            Else
                MessageBox.Show(Mns + " " + Cod_Err + " ", " No se realizara notificación a SAP ")
            End If
            If Err = "E" Then
                MessageBox.Show(Mns, "Error en SAP Notifique al Supervisor")
                Exit Sub
            End If
            ' ---------------------------------------------------------------------------------
            Dim reg As String
            If (TNumNoti.Text.Trim = "" Or TNumNoti.Text.Trim = "NULL" Or TNumNoti.Text.Trim = "0000000000") And (TConsNoti.Text.Trim = "" Or TConsNoti.Text.Trim = "NULL" Or TConsNoti.Text.Trim = "00000000") Then
                reg = "0"
                MsgBox("No se Notifico a SAP")
                BPesar.Enabled = False
                BImprimir.Enabled = True
                TOrden.Enabled = False
            Else
                reg = "1"


                InQry = ""
                InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set Notifica = '" & reg.Trim & "', "
                InQry = InQry & "Documento_SAP = '" & TNumNoti.Text.Trim & "', "
                InQry = InQry & "Consecutivo_SAP = '" & TConsNoti.Text.Trim & "' "
                InQry = InQry & " Where Folio = '" & FolioSiguiente.Trim & "'"
                InsertQry(InQry)

                Mensajes("Notificación a SAP Exitosa : " & InsertBD, 0)

            End If
            ' ---------------------------------------------------------------------------------

            BPesar.Enabled = False
            BImprimir.Enabled = True
            TOrden.Enabled = False
        Else
            TipoNotificacion = "4"
            nvoDocumento_SAP = ""
            nvoConsecutivo_SAP = ""
            ' ---------------------------------------------------------------------------------
            InQry = ""
            InQry = "INSERT INTO " & SessionUser._sCentro.Trim & "_PesoScrap (Orden_Produccion, Fecha_Pesaje, Hora_Pesaje, Bascula, Tipo_Scrap, Peso_Bruto, Tara, Peso_Neto, Tramos, Usuario,Turno,Planta,Folio, Documento_SAP, Consecutivo_SAP, Notifica, "
            InQry = InQry & " Causa, Efecto, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos, Fecha_Turno, notificacionmasiva, PuestoTrabajo, FolioR,RepGenerado,Area,OpePtoTra) VALUES ('" & nvoOrden_Produccion & "','" & nvoFecha_Pesaje & "',"
            InQry = InQry & "'" & nvoHora_Pesaje & "','" & strNumeroBascula.Trim & "','" & xTIPOSCRAP & "'," & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & ","
            InQry = InQry & Replace(nvoPiezas_Scrap, GDECIMAL, ".") & ",'" & TCodOperador.Text.Trim & "'," & Turno.Trim & ",'" & SessionUser._sCentro.Trim & "','" & FolioSiguiente.Trim & "', '" & TNumNoti.Text.Trim & "', '" & TConsNoti.Text.Trim & "','"
            InQry = InQry & TipoNotificacion & "','" & nvoTipo_SCausa & "','" & nvoTipo_SDefecto & "','" & Compuesto_1.Trim & "'," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2 & ",'" & Lt_Compuestos.Trim & "','" & FechaTurno.Trim & "', 0,'" & UCase(TPtoTrabajo.Text.Trim) & "','0','" & RecGen.Trim & "','E','" & nvoOperador.Trim & "')"
            InsertQry(InQry)
            ' ---------------------------------------------------------------------------------
            Mensajes("Registros Actualizados : " & InsertBD, 0)
            ' ---------------------------------------------------------------------------------
            TFolioAtlas.Text = FolioSiguiente

            ' ---------------------------------------------------------------------------------
            BPesar.Enabled = False
            BImprimir.Enabled = True
            TOrden.Enabled = False
        End If
        ' ---------------------------------------------------------------------------------
        BPesar.Enabled = False
        BCompuesto.Enabled = False
        BImprimir.Enabled = True
        TOrden.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
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
        If SessionUser._sCentro.Trim = "GT01" Then
            TPesoBruto.Text = Format((Val(Lectura) / 100), xFormato)
        Else
            TPesoBruto.Text = Format(Val(Lectura), xFormato)
        End If
    End Sub
    Private Sub BCompuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCompuesto.Click
        StrProces = "Est"
        Modulo = "SCE"
        FormConfigurarCompuesto_AMEX.CB1.Checked = False
        FormConfigurarCompuesto_AMEX.CB2.Checked = False
        FormConfigurarCompuesto_AMEX.CB3.Checked = False
        FormConfigurarCompuesto_AMEX.ShowDialog()
        If StatusConfiCompuesto = "1" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub TCausas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TCausas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TCausas_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCausas.Leave
        Me.Icon = Util.ApplicationIcon()
        Q = " SELECT Descausagrupa FROM CatAgrupaciones "
        Q = Q & " WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & " AND codcausagrupa = '" & TCausas.Text & "' AND status='A'"
        Desccausa.Text = TraeDescripcion(Q)
        If TGrpprod.Text.Trim = "" Or Desccausa.Text.Trim = "" Then
            TCausas.Text = ""
            Desccausa.Text = ""
        End If
        Desdefecto.Text = ""
        TDefectos.Text = ""
        TCausas.BackColor = Color.White
    End Sub
    Private Sub btnLookcausas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookcausas.Click
        Q = "Select C_Causa,D_Causa "
        Q = Q & "From CatCausas_Amex "
        Q = Q & "Where T_Causa = 'SC' "
        Q = Q & "And St = 'A' "
        Q = Q & "And Centro = '" & SessionUser._sCentro.Trim & "' "

        frmSpro.SPRO_TITULO = "Catalogo de CAUSAS SCRAP"
        frmSpro.SPRO_SQL = Q
        frmSpro.SPRO_OK = 0
        frmSpro.SPRO_COLKEY = 0
        frmSpro.SPRO_KEY = ""
        frmSpro.SPRO_LIKE = "Descausagrupa"
        frmSpro.ShowDialog()
        If frmSpro.SPRO_OK = 1 Then
            TCausas.Text = frmSpro.SPRO_KEY.Trim
            Q = " SELECT D_Causa FROM CatCausas_Amex "
            Q = Q & " WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
            Q = Q & " AND St ='A'"
            Q = Q & " AND C_Causa = '" & TCausas.Text & "' "
            Desccausa.Text = TraeDescripcion(Q)
            frmSpro.SPRO_OK = 0
        End If
    End Sub
    'Private Sub btnConsultaProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        FrmAdminPPT.ShowDialog()
    '    Finally
    '        FrmAdminPPT.Dispose()
    '        FrmAdminPPT = Nothing
    '    End Try
    'End Sub
    Private Sub TOrden_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOrden.Enter
        TOrden.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TRack_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRack.Enter
        TRack.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TCausas_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCausas.Enter
        TCausas.BackColor = Color.LightSkyBlue
    End Sub
    Private Sub TPesoCaptura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoCaptura.TextChanged
        Dim xTPesoCaptura As Double
        xTPesoCaptura = TPesoCaptura.Text.Trim
        TPesoBruto.Text = Format(xTPesoCaptura, xFormato)
    End Sub

    Private Sub TPesoCaptura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TPesoCaptura.KeyPress
        'e.Handled = txtNumerico(TPesoCaptura, e.KeyChar, True)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkSAP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSAP.CheckedChanged
        If chkSAP.Checked = True Then
            dtpFECHASAP.Enabled = True
        Else
            dtpFECHASAP.Enabled = False
        End If
    End Sub

    Private Sub TClaveOperador_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TClaveOperador.Leave
        Dim Codigo As String = ""
        Dim Nombre As String = ""

        If Val(TClaveOperador.Text.Trim.Length) > 0 Then
            ' ---------------------------------------------------------------------------------
            QRY_AMD = ""
            QRY_AMD = "Select Usuario, Nombre From ADM_Usuario Where  Deshabilitado =  '0' "
            QRY_AMD = QRY_AMD & " And Clave_Acceso = '" & TClaveOperador.Text.Trim & "' And Planta = '" & SessionUser._sCentro.Trim & "' "
            LecturaQry_AMD(QRY_AMD)
            If LecturaBD_AMD.Read Then
                Codigo = LecturaBD_AMD(0)
                Nombre = LecturaBD_AMD(1)
            End If
            LecturaBD_AMD.Close()
            ' ---------------------------------------------------------------------------------
            If Codigo.Trim = "" Then
                MessageBox.Show("*** USUARIO INEXISTENTE *** ")
                Me.TClaveOperador.Text = ""
                Me.TCodOperador.Text = ""
                Me.TNomOperador.Text = ""
                Me.TClaveOperador.Focus()
            Else
                Me.TCodOperador.Text = Codigo.Trim
                Me.TNomOperador.Text = Nombre.Trim
                Me.TOrden.Focus()
            End If
        Else
            Me.TCodOperador.Text = ""
            Me.TNomOperador.Text = ""
        End If
        ' ---------------------------------------------------------------------------------
        TClaveOperador.BackColor = Color.White
    End Sub

    Private Sub TClaveOperador_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TClaveOperador.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TClaveOperador_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TClaveOperador.Enter
        TClaveOperador.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub btnLookrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookrack.Click

        Q = " SELECT rack, descripcion, tara FROM Racks "
        Q = Q & " WHERE Centro = '" & SessionUser._sCentro.Trim & "'"
        Q = Q & " AND status='A'"

        frmSpro.SPRO_TITULO = "Catalogo de RACKS"
        frmSpro.SPRO_SQL = Q
        frmSpro.SPRO_OK = 0
        frmSpro.SPRO_COLKEY = 0
        frmSpro.SPRO_KEY = ""
        frmSpro.SPRO_LIKE = "descripcion"
        frmSpro.ShowDialog()
        If frmSpro.SPRO_OK = 1 Then
            TRack.Text = frmSpro.SPRO_KEY
            Q = " SELECT descripcion FROM Racks"
            Q = Q & " WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
            Q = Q & " AND rack = '" & TRack.Text & "' AND status='A'"
            Descrack.Text = TraeDescripcion(Q)

            Q = " SELECT tara FROM Racks"
            Q = Q & " WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
            Q = Q & " AND rack = '" & TRack.Text & "' AND status='A'"
            TPesoRack.Text = TraeDescripcion(Q)

            frmSpro.SPRO_OK = 0
        End If

    End Sub

    Private Sub btnLookdefectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookdefectos.Click

        Q = "Select a.C_Efecto,b.D_Efecto "
        Q = Q & "From CatCausaEfecto_AMEX a, CatEfecto_AMEX b "
        Q = Q & "Where a.centro = b.centro "
        Q = Q & "And a.C_Efecto = b.C_Efecto "
        Q = Q & "And a.C_Causa = '" & TCausas.Text.Trim & "' "
        Q = Q & "And a.St = 'A' "
        Q = Q & "And a.Centro = '" & SessionUser._sCentro.Trim & "' "

        frmSpro.SPRO_TITULO = "Catalogo de DEFECTOS"
        frmSpro.SPRO_SQL = Q
        frmSpro.SPRO_OK = 0
        frmSpro.SPRO_COLKEY = 0
        frmSpro.SPRO_KEY = ""
        frmSpro.SPRO_LIKE = "Descausgeneral"
        frmSpro.ShowDialog()
        If frmSpro.SPRO_OK = 1 Then
            TDefectos.Text = frmSpro.SPRO_KEY
            Q = "Select D_Efecto From CatEfecto_AMEX "
            Q = Q & "Where C_Efecto = '" & TDefectos.Text & "' "
            Q = Q & "And Centro = '" & SessionUser._sCentro.Trim & "' "
            Q = Q & "AND status='A' "
            Desdefecto.Text = TraeDescripcion(Q)
            frmSpro.SPRO_OK = 0
        End If
    End Sub

    Private Sub TDefectos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDefectos.Leave
        Q = " SELECT Descausgeneral FROM CatCausgeneral"
        Q = Q & " WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & " AND codcausgeneral = '" & TDefectos.Text & "' AND status='A'"
        Desdefecto.Text = TraeDescripcion(Q)
        If TGrpprod.Text.Trim = "" Or Desdefecto.Text = "" Then
            TDefectos.Text = ""
            Desdefecto.Text = ""
        End If
        TDefectos.BackColor = Color.White
    End Sub

    Private Sub TDefectos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDefectos.Enter
        TDefectos.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TRack_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TRack.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem.Click
        EXTINY = "1"
        FrmIMP_SC_AMEX.ShowDialog()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub btnLookOpe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookOpe.Click
        Q = " SELECT usuario, nombre FROM ADM_Usuario "
        Q = Q & " WHERE Planta = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & " AND Deshabilitado = '0' "
        Q = Q & " AND Puesto = '50' "
        frmSproadm.SPRO_TITULO = "Catalogo Usuarios"
        frmSproadm.SPRO_SQL = Q
        frmSproadm.SPRO_OK = 0
        frmSproadm.SPRO_COLKEY = 0
        frmSproadm.SPRO_KEY = ""
        frmSproadm.SPRO_LIKE = "nombre"
        frmSproadm.ShowDialog()
        If frmSproadm.SPRO_OK = 1 Then
            TCveOpe.Text = frmSproadm.SPRO_KEY
            Q = " SELECT nombre FROM ADM_Usuario "
            Q = Q & "WHERE Planta = '" & SessionUser._sCentro.Trim & "' "
            Q = Q & "AND usuario = '" & TCveOpe.Text & "' "
            TNOpe.Text = TraeDescripcion_AMD(Q)
        End If
    End Sub

    Private Sub TCveOpe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TCveOpe.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TCveOpe_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCveOpe.Leave
        If TCveOpe.Text.Trim <> "" Then
            Try
                QRY = ""
                QRY = " SELECT Usuario,Nombre FROM ADM_Usuario "
                QRY = QRY & "WHERE Planta = '" & SessionUser._sCentro.Trim & "' "
                QRY = QRY & "AND Usuario = '" & TCveOpe.Text.Trim & "' "
                QRY = QRY & "AND Deshabilitado = '0' "
                QRY = QRY & "AND Puesto = '50' "
                LecturaQry_AMD(QRY)
                If LecturaBD_AMD.Read Then
                    TNOpe.Text = LecturaBD_AMD(1)
                Else
                    MsgBox("Operador inexistente o dado de baja")
                End If
                LecturaBD_AMD.Close()
            Catch ex As Exception
                MessageBox.Show("Error Conexion :" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnLookScrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLookScrap.Click
        Q = "Select C_Scrap,D_Scrap "
        Q = Q & "From CAT_TipoScrap "
        Q = Q & "Where Centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & "And Status = '1' "

        frmSpro.SPRO_TITULO = "Catalogo Tipo Scrap"
        frmSpro.SPRO_SQL = Q
        frmSpro.SPRO_OK = 0
        frmSpro.SPRO_COLKEY = 0
        frmSpro.SPRO_KEY = ""
        frmSpro.SPRO_LIKE = "T_Scrap"
        frmSpro.ShowDialog()
        If frmSpro.SPRO_OK = 1 Then
            TCveScrap.Text = frmSpro.SPRO_KEY
            Q = "Select D_Scrap,Tipo From CAT_TipoScrap "
            Q = Q & "Where C_Scrap = '" & TCveScrap.Text & "' "
            Q = Q & "And Centro = '" & SessionUser._sCentro.Trim & "' "
            Q = Q & "AND status = '1' "
            LecturaQry(Q)

            Do While (LecturaBD.Read)
                TDescScrap.Text = LecturaBD(0)
                xTIPOSCRAP = LecturaBD(1)
            Loop
            LecturaBD.Close()
            frmSpro.SPRO_OK = 0
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        LimpiaObjetos()
        Close()
    End Sub
End Class