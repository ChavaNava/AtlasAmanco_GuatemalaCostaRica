Imports System.IO
Imports System.IO.Ports.SerialPort
Imports System.IO.Ports.SerialDataReceivedEventArgs
Imports System.IO.Ports.SerialPinChangedEventArgs
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Net.Mail
Imports System.Diagnostics
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class MenuPTE_AMEX

    Dim Permiso As New Permisos
    Dim Combos As New Generic_CB

    '----- Variables para envio de correo ------
    Dim correo As New MailMessage()
    Dim cuerpodemensaje As String
    Dim smtp As New SmtpClient
    Dim Email As String

    'Variables Supervisor
    Dim Supervisor As String

    'Variables Sobre Peso
    Dim StatusSobrepeso As String

    'Variables Bascula Leon
    Dim Cadena_1 As String
    Dim LecBascula As String
    Dim Resultado_1 As String

    ' ----------------------------------------- Variables Boton Pesar
    Dim nvoOrden_Produccion As String
    Dim nvoTramosNoti As Integer
    Dim nvoEmpaques As Integer
    Dim nvoFecha_Pesaje As String
    Dim nvoHora_Pesaje As String
    Dim nvoBascula As String
    Dim nvoOperadorLinea As String
    Dim nvoTipo_SCausa As String
    Dim nvoPeso_Bruto As Decimal
    Dim nvoTara As Decimal
    Dim nvoPeso_Neto As Decimal
    Dim nvoUsuario As String
    Dim nvoPesoTeorico As Decimal
    Dim nvoPesoNetoMerma As Decimal = 3

    '----- Variables Web Service -----

    Dim OrdenProd As String
    Dim NumeroPlanta As String
    Dim Equipo As String
    Dim Producto As String
    Dim CantProgPzs As Decimal
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
    Dim Cod_Err As String
    Dim OrigInf As String = "SAP_R/3"
    Dim CantProgkg As Integer = 333

    '----- Definición de  Variables -----

    Dim NomTabOp As String   'Variable para controlar el nombre de la tabla de Orden Producción    
    Dim Message As String = "Tecleé un numero de Orden de Producción"
    Dim Caption As String = "Campo vacio"
    Dim CountValOP As Integer 'Validacón para determinar  si la OF ya existe en la DB
    Dim Result As DialogResult
    Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
    Dim Botones As MessageBoxButtons = MessageBoxButtons.OK
    Dim VCountProducto As Boolean       'Validación para identificar si existe  el PT y compuesto en la BD A-TLAS
    Dim VCountTinta As Boolean          'Validación para identificar la Tinta
    Dim VCountAditivo As Boolean        'Validación para identificar el Aditivo
    Dim VCountMerma As Boolean          'Valor de Merma
    Dim VSumNotificaciones As Integer   'Validación Sum para Notificaciones

    '----- Variables para  lectura de PT y compuesto asociados a la OF -----

    Dim xAREA As String
    Dim descripcion As String = ""

    Dim CodigoEmpaque As String '---Nuevo

    Dim taraempaque As Decimal
    Dim PesoTeorico As Decimal
    Dim PesoAcc As String
    Dim PesoEmb As String
    Dim DesEmp As String
    Dim EstatusActiva As Integer
    'Dim StrProducto As String
    Dim StrTramos As String
    Dim StrCompuesto As String
    Dim StrDescComp As String
    Dim EqpBasico As String
    Dim grpMaterial As String
    Dim sobrePESO As String
    Dim WorkCenter As String = ""
    Dim CantEntregada As String
    Dim ATLAS_PASS As String
    Dim xORIGINAL As String = ""
    Dim xFormato As String = "#####0.00"
    Dim xFormato2 As String = "#####0.000"

    '----- Variables para Grabado de OF  -----

    Dim PesoBruto As Decimal
    Dim Turno As String
    Dim TurnoNombre As String
    Dim HIni As String
    Dim HFin As String
    Dim FolioSiguiente As String
    Dim reg As String

    '----- Variables para Turnos  -----
    Dim dateRegistro As Date
    Dim FechaTurno As String
    Dim FechaPesaje As String
    Dim FechaPesajeSAP As String
    Dim HoraPesaje As String
    Dim dregistro As String = "0"


    '----- Variables para Rack  -----

    Dim ContadorRack As Integer


    '---- Información Bascula  -----

    Dim strPB As Integer            'Puerto Bascula
    Dim strVP As String = ""        'Velocidad Puerto
    Dim strIP As String = ""        'Interface Puerto
    'Dim Lectura As String
    Dim Tipo As String = Chr(33)
    Dim Tipo_1 As String = Chr(75)
    Dim Tipo_2 As String = Chr(2)
    Dim Tipo_3 As String = Chr(32)
    Dim Tipo_4 As String = Chr(58)
    Dim Bascula As String = ""
    Dim Cadena As String = ""
    Dim Calculo As Decimal
    Dim totaltara As Decimal = 0

    '----  Báscula  ----

    Dim Lectura As String = ""
    Dim Resultado As String = ""
    Dim Count1 As Integer = 0
    Dim FolioVerif As String


    Dim ValCountBasculas As Integer

    '----  Compuesto  ----

    Dim Compuesto_1 As String = ""
    Dim Compuesto_2 As String = ""
    Dim Tinta_Extra As Decimal = 0.0
    Dim Anillos_Extra As Integer = 0
    Dim Aditivo_Extra As Decimal = 0.0
    Dim CompuestoPorcent_1 As Integer = 0
    Dim CompuestoPorcent_2 As Integer = 0
    Dim ValControlCompuesto As String

    '----  Sobrepeso  ----

    Dim ContadorSobrepeso As Integer

    '----  Empauqes ----

    Dim NumEmpaques As String
    Dim CodEmpaque As String

    '--- Variables WS 
    Dim Lt_Compuestos As String = ""
    Dim Lt_Tintas As String = ""
    Dim Lt_Aditivos As String = ""
    Dim Lt_Anillos As String = ""
    Dim CompOriginal As String = ""
    Dim TintaOriginal As String = ""
    Dim AditivoOriginal As String = ""
    Dim CadenaTexto As String = ""

    Dim xUSUARIOREG As String
    Dim xFECHAREG As String
    Dim xHORAREG As String
    Dim xTGRUPO As String
    Dim xSPPERMITIDO As String

    Dim myDataReader As SqlClient.SqlDataReader
    Dim xTabla As String
    Dim Q As String
    Dim xMerma As Decimal = 0

    Dim StatusConsumo As String
    Dim CompReprocesado As String

    Private Sub MenuPET_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        xMerma = 0
        StrProducto = ""
        TCentro.Text = SessionUser._sCentro.Trim 'Centro 
        'Titulos_ppal()
        ' ---------------------------------------------------------------------------------
        ValPublic_ReproConsumo = 0
        ValPublic_Ccompuesto1 = 0
        ValPublic_Ccompuesto2 = 0
        ValPublic_PorcentajeCom1 = 0
        ValPublic_PorcentajeCom2 = 0
        ' ---------------------------------------------------------------------------------
        'Se habilita bascula
        'Permiso.Habilita_Bascula(gPerfil.Trim, TPesoCaptura, Timer1, ValCodigoBascula.Trim)
        Permiso.Habilita_Bascula(SessionUser._sIdPerfil, TPesoCaptura, Timer1, ValCodigoBascula.Trim, LPesoCaptura)
        ' ---------------------------------------------------------------------------------
        'Se verifica conexión con SAP
        Permiso.SAP_Status("E", tsImagen)
        ' ---------------------------------------------------------------------------------
        Catalogo_Turnos.Combo_Turnos(cmbTurnos)
        ' ---------------------------------------------------------------------------------
        dregistro = "0"
        dateRegistro = Today()
        FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        HoraPesaje = Date.Now.TimeOfDay.ToString
        ' ---------------------------------------------------------------------------------
        'Se asigna turno que corresponde acorde al horario
        cmbTurnos.Text = Permiso.Turno
        ' ---------------------------------------------------------------------------------
        dtpFECHA.Value = Date.Today.ToString("yyyy-MM-dd")
        dtpFECHASAP.Value = Date.Today.ToString("yyyy-MM-dd")
        cmbTurnos.Enabled = True
        dtpFECHA.Enabled = True
        dtpFECHASAP.Enabled = True
        chkSAP.Enabled = True
        ' ---------------------------------------------------------------------------------
        LimpiaObjetos()
        TSobrePeso.BackColor = Color.White
        TClaveOperador.Focus()
    End Sub

    Private Sub TOrden_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TOrden.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TOrden_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOrden.Leave
        Dim Q As String
        Dim CountValOP As Integer
        Dim OrdenOP As String
        Dim StatusOP As Char
        Dim xCantProgPzs As String = ""
        Dim xCantProgkg As String = ""
        Tempaque.Text = ""
        OrdenOP = ""
        StatusOP = ""
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
        'Consulta que la orden exista en A-tlas
        QRY = ""
        QRY = " Select Orden_Produccion, Estatus_Activa  FROM  " & SessionUser._sCentro.Trim & "_OrdenProduccion "
        QRY = QRY & "WHERE  Orden_Produccion = '" & TOrden.Text.Trim & "' "
        QRY = QRY & "AND Planta = '" & SessionUser._sCentro.Trim & "' "
        LecturaQry(QRY)

        CountValOP = 0

        Do While (LecturaBD.Read())
            CountValOP = CountValOP + 1
            OrdenOP = LecturaBD(0)
            StatusOP = LecturaBD(1).ToString
        Loop
        LecturaBD.Close()

        If StatusOP = "T" Then
            StatusOP = "1"
        ElseIf StatusOP = "F" Then
            StatusOP = "0"
        End If
        ' ---------------------------------------------------------------------------------
        Select Case CountValOP
            Case Is = 0 'Case: Búsqueda de OF en BD ATLAS -- 0 
                Message = "Orden de Producción no Existe en A-tlas desea dar de Alta"
                Caption = "Orden de Producción Inexistente"
                Result = MessageBox.Show(Message, Caption, Buttons)
                ' ---------------------------------------------------------------------------------
                If Result = System.Windows.Forms.DialogResult.No Then
                    Me.TOrden.Text = ""
                    Me.TOrden.Focus()
                    Exit Sub
                End If
                ' ---------------------------------------------------------------------------------
                Select Case UsrLog 'Identificación de Usuario
                    Case "ATLAS"

                        Dim Lectura_Dev As Read.ZEPP001
                        Lectura_Dev = Leer_ODP_D(TOrden.Text.Trim)

                        OrdenProd = Lectura_Dev.ZORDER_NUMBER
                        NumeroPlanta = Lectura_Dev.ZPRODUCTION_PLANT
                        Equipo = Lectura_Dev.ZWORK_CENTER
                        Producto = Lectura_Dev.ZMATERIAL
                        CantProgPzs = Lectura_Dev.ZTARGET_QUANTITY
                        Unidad = Lectura_Dev.ZUNIT
                        Inicio = Lectura_Dev.ZSTART_DATE
                        Fin = Lectura_Dev.ZFINISH_DATE
                        Origen = Lectura_Dev.ZORIGIN
                        Status1 = Lectura_Dev.ZSTATUS
                        fecini = Lectura_Dev.ZACTUAL_START_DATE
                        HrReal = Lectura_Dev.ZACTUAL_START_TIME
                        fecterm = Lectura_Dev.ZACTUAL_FINISH_DATE
                        Status = "1"
                        UsrAct = Usrsap
                        FecAct = Date.Today.ToString("yyyy/MM/dd")
                        Obs = "Carga SAP"
                        Err = ls_return_d.ZTYPE
                        Mns = ls_return_d.ZMESSAGE

                        ' ---------------------------------------------------------------------------------
                    Case Is <> "ATLAS"


                        'Variables WS Lectura de ordenes Productivo
                        Dim lo_wsamancomx As New Lee_OFP.ZPP001_91Service
                        Dim ls_return As New Lee_OFP.ZBAPIRET2
                        Dim ls_values As New Lee_OFP.ZEPP001


                        'Dim Lectura_Prod As Lee_OF.ZEPP001
                        'Lectura_Prod = Leer_ODP_PR(TOrden.Text.Trim)
                        lo_wsamancomx.Credentials = New System.Net.NetworkCredential("libra", "mxlibra$")
                        ls_values = lo_wsamancomx.Z_PP001(TOrden.Text.Trim, ls_return)
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
                        FecAct = Date.Today.ToString("yyyy/MM/dd")
                        Obs = "Carga SAP"
                        Err = ls_return.ZTYPE
                        Mns = ls_return.ZMESSAGE

                        'OrdenProd = Lectura_Prod.ZORDER_NUMBER
                        'NumeroPlanta = Lectura_Prod.ZPRODUCTION_PLANT
                        'Equipo = Lectura_Prod.ZWORK_CENTER
                        'Producto = Lectura_Prod.ZMATERIAL
                        'CantProgPzs = Lectura_Prod.ZTARGET_QUANTITY
                        'Unidad = Lectura_Prod.ZUNIT
                        'Inicio = Lectura_Prod.ZSTART_DATE
                        'Fin = Lectura_Prod.ZFINISH_DATE
                        'Origen = Lectura_Prod.ZORIGIN
                        'Status1 = Lectura_Prod.ZSTATUS
                        'fecini = Lectura_Prod.ZACTUAL_START_DATE
                        'HrReal = Lectura_Prod.ZACTUAL_START_TIME
                        'fecterm = Lectura_Prod.ZACTUAL_FINISH_DATE
                        'Status = "1"
                        'UsrAct = Usrsap
                        'FecAct = Date.Today.ToString("yyyy/MM/dd")
                        'Obs = "Carga SAP"
                        'Err = ls_return_pr.ZTYPE
                        'Mns = ls_return_pr.ZMESSAGE

                End Select
                ' ---------------------------------------------------------------------------------
                If Err = "E" Then
                    MessageBox.Show(Mns, "Error SAP Notifique al Supervisor")
                    Me.TClaveOperador.Focus()
                    Return
                End If
                ' ---------------------------------------------------------------------------------
                Select Case Status1
                    Case Is <> "LIB."
                        Message = "Orden de Producción no esta liberada"
                        Caption = "Orden no liberada"
                        Result = MessageBox.Show(Message, Caption, Botones)
                        If Result = System.Windows.Forms.DialogResult.OK Then
                            Me.TOrden.Text = ""
                            Me.TOrden.Focus()
                            Exit Sub
                        End If
                    Case Is = "LIB."
                        ' ---------------------------------------------------------------------------------
                        CerosIzquierda(OrdenProd)
                        OrdenProd = RegresaCeroIzq
                        Producto = CerosIzquierda(Producto)
                        Producto = RegresaCeroIzq
                        ' ---------------------------------------------------------------------------------
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
                            ' ---------------------------------------------------------------------------------
                            If TCodOperador.Text.Trim <> "" Then
                                xUSUARIOREG = TCodOperador.Text.Trim
                            Else
                                xUSUARIOREG = SessionUser._sAlias
                            End If
                            xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
                            xHORAREG = Date.Now.TimeOfDay.ToString.Substring(0, 8)
                            xTGRUPO = ""
                            xSPPERMITIDO = ""
                            ' ---------------------------------------------------------------------------------
                            QRY = ""
                            QRY = "SELECT GrupMaterial, Sobrepeso FROM ProductoTerminadoExtrusion WHERE Centro = " & "'" & NumeroPlanta & "' AND Codigo = '" & Producto.Trim & "'"
                            LecturaQry(QRY)
                            ' ---------------------------------------------------------------------------------
                            If LecturaBD.Read() Then
                                xTGRUPO = LecturaBD(0)
                                xSPPERMITIDO = LecturaBD(1)
                            End If
                            TGrupo.Text = xTGRUPO
                            SP_Permitido.Text = xSPPERMITIDO
                            xCantProgPzs = Replace(CantProgPzs, GDECIMAL, ".")
                            xCantProgkg = Replace(CantProgkg, GDECIMAL, ".")
                            ' ---------------------------------------------------------------------------------
                            InQry = ""
                            InQry = "INSERT INTO " & SessionUser._sCentro.Trim & "_OrdenProduccion (Orden_Produccion,Planta,Equipo_Basico,Producto,"
                            InQry = InQry & "Cantidad_Programada_Tramos,Cantidad_Programada_Kilos,Fecha_Inicio,Fecha_Termino,"
                            InQry = InQry & "Origen_Informacion,Estatus_Activa,Usuario_Actualiza,Fecha_Actualizacion,Observaciones,usuarioreg,"
                            InQry = InQry & "fechareg,horareg,GrupMaterial) "
                            InQry = InQry & " VALUES('" & OrdenProd & "','" & NumeroPlanta & "','" & Equipo & "'," & Producto & ","
                            InQry = InQry & "" & xCantProgPzs & "," & xCantProgkg & "," & "'" & fecini & "','" & fecterm & "',"
                            InQry = InQry & "'" & OrigInf & "'," & Status & ",'" & UsrAct & "','" & FecAct & "','" & Obs.Trim & "',"
                            InQry = InQry & "'" & xUSUARIOREG.Trim & "','" & xFECHAREG & "','" & xHORAREG & "','" & xTGRUPO.Trim & "') "
                            InsertQry(InQry)
                            ' ---------------------------------------------------------------------------------                            
                        End If
                End Select
                Message = "Se ha dado de Alta la Orden de Producción : " & OrdenProd.Trim & " en ATLAS"
                Caption = "Alta Orden de Producción. "
                Result = MessageBox.Show(Message, Caption, MessageBoxButtons.OK)

                If Result = System.Windows.Forms.DialogResult.OK Then
                    TOrden.Text = ""
                    TOrden.Focus()
                    Exit Sub
                End If
                ' ---------------------------------------------------------------------------------
            Case Is > 0
                If StatusOP = "0" Then
                    Message = "La Orden se encuentra Desactivada en ATLAS, continuar con otra orden? "
                    Caption = "La Orden fue DESACTIVADA ( - ATLAS - ), Desea continuar con otra Orden? "
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
                    Caption = "ORDEN ELIMINADA- ATLAS"
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
                ElseIf StatusOP = "1" Then

                    Select Case StatusSap

                        Case "True"

                            Select Case UsrLog 'Identificación de Usuario
                                Case "ATLAS"

                                    Dim Lectura_Dev As Read.ZEPP001
                                    Lectura_Dev = Leer_ODP_D(TOrden.Text.Trim)

                                    OrdenProd = Lectura_Dev.ZORDER_NUMBER
                                    NumeroPlanta = Lectura_Dev.ZPRODUCTION_PLANT
                                    Equipo = Lectura_Dev.ZWORK_CENTER
                                    Producto = Lectura_Dev.ZMATERIAL
                                    CantProgPzs = Lectura_Dev.ZTARGET_QUANTITY
                                    Unidad = Lectura_Dev.ZUNIT
                                    Inicio = Lectura_Dev.ZSTART_DATE
                                    Fin = Lectura_Dev.ZFINISH_DATE
                                    Origen = Lectura_Dev.ZORIGIN
                                    Status1 = Lectura_Dev.ZSTATUS
                                    fecini = Lectura_Dev.ZACTUAL_START_DATE
                                    HrReal = Lectura_Dev.ZACTUAL_START_TIME
                                    fecterm = Lectura_Dev.ZACTUAL_FINISH_DATE
                                    Status = "1"
                                    UsrAct = Usrsap
                                    FecAct = Date.Today.ToString("yyyy/MM/dd")
                                    Obs = "Carga SAP"
                                    Err = ls_return_d.ZTYPE
                                    Mns = ls_return_d.ZMESSAGE


                                    ' ---------------------------------------------------------------------------------

                                Case Is <> "ATLAS"

                                    'Variables WS Lectura de ordenes Productivo
                                    Dim lo_wsamancomx As New Lee_OFP.ZPP001_91Service
                                    Dim ls_return As New Lee_OFP.ZBAPIRET2
                                    Dim ls_values As New Lee_OFP.ZEPP001

                                    'Dim Lectura_Prod As Lee_OF.ZEPP001
                                    'Lectura_Prod = Leer_ODP_PR(TOrden.Text.Trim)
                                    lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)

                                    ls_values = lo_wsamancomx.Z_PP001(TOrden.Text.Trim, ls_return)
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
                                    FecAct = Date.Today.ToString("yyyy/MM/dd")
                                    Obs = "Carga SAP"
                                    Err = ls_return.ZTYPE
                                    Mns = ls_return.ZMESSAGE

                            End Select
                            ' ---------------------------------------------------------------------------------
                            If Err = "E" Then
                                MessageBox.Show(Mns, "Error SAP Notifique al Supervisor")
                                Me.TClaveOperador.Focus()
                                Return
                            End If
                            ' ---------------------------------------------------------------------------------
                            Select Case Status1
                                Case Is <> "LIB."
                                    Message = "Orden de Producción no esta liberada"
                                    Caption = "Orden no liberada"
                                    Result = MessageBox.Show(Message, Caption, Botones)
                                    If Result = System.Windows.Forms.DialogResult.OK Then
                                        Me.TOrden.Text = ""
                                        Me.TOrden.Focus()
                                        Return
                                    End If

                            End Select

                    End Select

                    ' --------------- Si la orden existe en Atlas verificar que el producto a fabricar tambien exista.
                    QRY = ""
                    QRY = "SELECT PTE.Grpprod,PTE.Descr,PTE.Empaque,PTE.PesoTeorico,OP.Estatus_Activa, PTE.Codigo,"
                    QRY = QRY & "OP.cantidad_programada_tramos,OP.Equipo_Basico,OP.GrupMaterial,PTE.Sobrepeso,"
                    QRY = QRY & "PTE.ConCombinado,PTE.PesoAcc,PTE.PesoEmb,c.DesEmp "
                    QRY = QRY & "FROM " & SessionUser._sCentro.Trim & "_OrdenProduccion OP, ProductoTerminadoExtrusion PTE, Empaques_PTE c "
                    QRY = QRY & "WHERE PTE.Codigo =OP.Producto  "
                    QRY = QRY & "AND PTE.Centro = OP.Planta "
                    QRY = QRY & "AND c.Centro = PTE.Centro "
                    QRY = QRY & "AND c.CodEmp = PTE.Empaque "
                    QRY = QRY & "AND OP.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    QRY = QRY & "AND OP.Planta = '" & SessionUser._sCentro.Trim & "' "
                    QRY = QRY & "And OP.Estatus_Activa = 1 "
                    LecturaQry(QRY)
                    VCountProducto = LecturaBD.HasRows
                    Select Case VCountProducto 'Case Para Identificar Sí el producto  y el Compuesto  Existen en la BD - True 
                        Case True
                            Do While (LecturaBD.Read())
                                xAREA = "" & LecturaBD(0)
                                descripcion = "" & LecturaBD(1)
                                CodigoEmpaque = "" & LecturaBD(2)
                                PesoTeorico = "" & LecturaBD(3)
                                'EstatusActiva = "" & LecturaBD(4)
                                StrProducto = "" & LecturaBD(5)
                                StrTramos = "" & LecturaBD(6)
                                EqpBasico = "" & LecturaBD(7)
                                grpMaterial = "" & LecturaBD(8)
                                sobrePESO = "" & LecturaBD(9)
                                StatusConsumo = "" & LecturaBD(10)
                                PesoAcc = "" & LecturaBD(11)
                                PesoEmb = "" & LecturaBD(12)
                                DesEmp = "" & LecturaBD(13)
                                WorkCenter = "" & UCase(EqpBasico)
                            Loop
                            LecturaBD.Close()

                            Calcula_Cantidades()

                            TGrpprod.Text = xAREA.Trim
                            Q = "SELECT desgrupo FROM catgrupos  "
                            Q = Q & "WHERE centro = '" & SessionUser._sCentro.Trim & "' "
                            Q = Q & "AND grpprod = '" & TGrpprod.Text.Trim & "' "
                            Q = Q & "AND status = 'A'"
                            TGrpproddesc.Text = TraeDescripcion(Q)

                            TPtoTrabajo.Text = EqpBasico.Trim
                            Q = " SELECT Descripcion FROM EquipoBasico"
                            Q = Q & " WHERE planta = '" & SessionUser._sCentro.Trim & "' "
                            Q = Q & " AND rtrim(Equipo_basico) = '" & TPtoTrabajo.Text.Trim & "'"
                            TNomPtoTrabajo.Text = TraeDescripcion(Q)

                            TGrupo.Text = grpMaterial.Trim
                            SP_Permitido.Text = sobrePESO.Trim
                            ValControlCompuesto = ""
                            QRY = ""
                            QRY = "Select ValCompuesto  From  ProductoTerminadoExtrusion Where Centro = '" & SessionUser._sCentro.Trim & "' And Codigo = '" & StrProducto.Trim & "'"
                            LecturaQry(QRY)
                            Do While (LecturaBD.Read())
                                ValControlCompuesto = LecturaBD(0)
                            Loop
                            LecturaBD.Close()
                            CheckBox1.Checked = False
                            If Val(ValControlCompuesto.Trim) = 0 Then
                                BCompuesto.Enabled = False
                            Else
                                BCompuesto.Enabled = True
                            End If

                            ' --- Validación : Qry para determinar empaque -- No Aplica para EC01 --
                            If Val(CodigoEmpaque.Trim) > 0 Then
                                taraempaque = 0
                                QRY = ""
                                QRY = " Select Peso from Empaques_PTE where Centro = '" & SessionUser._sCentro.Trim & "' And CodEmp = '" & CodigoEmpaque.Trim & "'"
                                LecturaQry(QRY)
                                Do While (LecturaBD.Read())
                                    taraempaque = LecturaBD(0)    'Peso Unitario del Empaque
                                Loop
                                LecturaBD.Close()
                            Else
                                taraempaque = 0
                                NumEmpaques = 0
                            End If
                            TCodPT.Text = StrProducto.Trim   'Código PT
                            TCodPtDecr.Text = descripcion.Trim   'Descripción del PT
                            TPtoTrabajo.Text = EqpBasico.Trim  'Puesto de Trabajo
                            TPesoTeorico.Text = PesoTeorico.ToString.Trim  'Peso Teorico
                            Tempaque.Text = taraempaque.ToString.Trim 'Peso Unitario del Empaque
                            TCodAnillo.Text = CodigoEmpaque
                            TDAnillo.Text = DesEmp

                        Case False  'Case Para Identificar Sí el producto  y el Compuesto  Existen en la BD - False
                            MessageBox.Show("No existe Producto en A-tlas para esta Orden ó la orden ya fue cerrada, Informe al Supervisor", " VENTANA DE ERROR * * * ")

                            Dim lo_WSNAC_Ope As New Dev_Gen.ZGLMX_ATLAS_GRService
                            Dim E_Return As New Dev_Gen.ZBAPIRET2
                            Dim List As New Generic.List(Of String)
                            Dim Tbl_Oper As String()
                            Dim Header As String


                            Header = "3" + "|" + SessionUser._sCentro.Trim + "|" + Producto.Trim

                            lo_WSNAC_Ope.Credentials = New System.Net.NetworkCredential("libra", "mxlibra$")
                            Tbl_Oper = lo_WSNAC_Ope.Z_GLMX_ATLAS_GR(List.ToArray, Header, E_Return)

                    End Select 'Case Para Identificar Sí el producto  y el Compuesto  Existen en la BD - True

                End If

                ' -----------------------------------------  Cierre revisión de orden

        End Select 'Case: Búsqueda de OF en BD ATLAS

        TOrden.BackColor = Color.White
    End Sub
    Private Sub Calcula_Cantidades()
        Dim regupdate As Integer
        Dim Qfup As String
        Dim xTCantProgra As Decimal = 0
        Dim xTCantEntre As Decimal = 0
        Dim xTCantEnproce As Decimal = 0
        Dim xTCantpendi As Decimal = 0
        Dim xFechaUltpesaje As String
        ' ---------------------------------------------------------------------------------
        Qfup = " SELECT  PTYS.Orden_Produccion, OP.Cantidad_Programada_Tramos, SUM(PTYS.PRODUCCION), SUM(PTYS.SEPARADA), (OP.Cantidad_Programada_Tramos-(SUM(PTYS.PRODUCCION)+SUM(PTYS.SEPARADA))) "
        Qfup = Qfup & " FROM (((sELECT planta, Orden_Produccion, PuestoTrabajo, 'PRODUCCION' as tipoprod, Notifica, notificacionmasiva, tramos as PRODUCCION, 0 as SEPARADA "
        Qfup = Qfup & "  FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos<>0 AND notifica in ('0','1','4')) "
        Qfup = Qfup & " UNION ALL (sELECT planta, Orden_Produccion, PuestoTrabajo, 'EN PROCESO' as tipoprod, Notifica, notificacionmasiva, 0 as PRODUCCION, tramos as SEPARADA "
        Qfup = Qfup & " FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos<>0 AND notifica in ('3'))) PTYS "
        Qfup = Qfup & " INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON PTYS.Orden_Produccion = OP.Orden_Produccion) "
        Qfup = Qfup & "	INNER JOIN EquipoBasico EB ON PTYS.planta = EB.Planta AND PTYS.PuestoTrabajo = EB.Equipo_basico "
        Qfup = Qfup & " INNER JOIN ProductoTerminadoExtrusion PTE ON  PTE.CENTRO= PTYS.PLANTA and PTE.Codigo = OP.Producto "
        Qfup = Qfup & " WHERE PTYS.planta= '" & SessionUser._sCentro.Trim & "'"
        Qfup = Qfup & " AND PTYS.notifica <> '9' "
        Qfup = Qfup & " AND PTYS.Orden_Produccion = '" & TOrden.Text.Trim & "'"
        Qfup = Qfup & " GROUP BY PTYS.Orden_Produccion, OP.Cantidad_Programada_Tramos "
        xFechaUltpesaje = ""
        Try
            LecturaQry(Qfup)
            regupdate = 0
            If (LecturaBD.Read) Then
                xTCantProgra = LecturaBD(1)
                xTCantEntre = LecturaBD(2)
                xTCantEnproce = LecturaBD(3)
                xTCantpendi = LecturaBD(4)
            End If
            TCantProgra.Text = Format(xTCantProgra, "###,##0" & GDECIMAL & "00")
            TCantEntre.Text = Format(xTCantEntre, "###,##0" & GDECIMAL & "00")
            TCantEnproce.Text = Format(xTCantEnproce, "##,###0" & GDECIMAL & "00")
            TCantPendiente.Text = Format(xTCantpendi, "##,###0" & GDECIMAL & "00")
            LecturaBD.Close()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub LimpiaVariables()
        Message.Remove(0)
        Caption.Remove(0)
    End Sub
    Private Sub LimpiaObjetos()
        TOrden.Text = ""            'Orden Producción
        TtramosNoti.Text = ""       'Tramos por Notificar
        TRack.Text = ""             'Rack
        TPesoRack.Text = "0"        'Peso Rack
        Descrack.Text = ""          'Peso Rack
        TCodPT.Text = ""            'Código Material
        SP_Permitido.Text = ""
        TGrupo.Text = ""            'Descripción GRUPO Material
        TCodPtDecr.Text = ""        'Descripción Material
        TGrpprod.Text = ""          'Codigo grupo produccion
        TGrpproddesc.Text = ""      'Descripcion grupo´produccion
        TPtoTrabajo.Text = ""       'Puesto de Trabajo
        TPesoTeorico.Text = ""      'Peso Teorico
        Tempaque.Text = ""          'Peso Unitario de empaques
        TempaquePesoTot.Text = ""   'Peso Total de empaques
        TCodAnillo.Text = ""
        TDAnillo.Text = ""
        ' ---------------------------------------------------------------------------------
        TPesoCaptura.Text = "00" & GDECIMAL & "00" 'Peso Bruto Manual
        ' ---------------------------------------------------------------------------------
        TCantProgra.Text = ""       'Programada
        TCantEntre.Text = ""        'Entregada
        TCantEnproce.Text = ""      'Entregada
        TCantPendiente.Text = ""    'Pendiente
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
        TFolioAtlas.Text = ""       'Folio ATLAS
        TNumNoti.Text = ""          'Número Notificación
        TConsNoti.Text = ""         'Consecutivo Notificación
        CheckBox1.Checked = False
        TClaveOperador.Text = ""
        TCodOperador.Text = ""
        TNomOperador.Text = ""
        TNomPtoTrabajo.Text = ""
        BCompuesto.Enabled = False
        TCausas.Text = ""
        Desccausa.Text = ""
        ' ---------------------------------------------------------------------------------
        BPesar.Enabled = False
        BImprimir.Enabled = False
        rbtFinalSi.Checked = True
        rbtFinalNo.Checked = False
        lblFinalSi.BackColor = Me.BackColor
        lblFinalSi.ForeColor = Color.DarkBlue
        lblFinalNo.BackColor = Me.BackColor
        lblFinalNo.ForeColor = Color.DarkBlue
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

    Private Sub BPesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPesar.Click

        Lt_Compuestos = ""

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
            End If
        Else
            MsgBox("Selecciona Un Compuesto ", MsgBoxStyle.Critical)
            Return
        End If

        '*******************
        Dim TipoNotificacion As Char = "0"
        Dim xTIPOPROD As Char = ""
        Forma = "Extrusion"
        ' ---------------------------------------------------------------------------------
        If TClaveOperador.Text = "" Then
            Mensajes("***  Tecleé codigo de controlador  *** ", 1)
            TClaveOperador.Focus()
            Exit Sub
        End If
        If TOrden.Text.Trim = "" Then
            Mensajes("***  Tecleé la Orden de Producción  *** ", 1)
            TOrden.Focus()
            Exit Sub
        End If
        If TPtoTrabajo.Text = "" Then
            Mensajes("***  No hay puesto de trabajo, comuniquese con el Supervisor  *** ", 1)
            Exit Sub
        End If
        ' ---------------------------------------------------------------------------------
        nvoTramosNoti = "0" & TtramosNoti.Text.Trim
        nvoPeso_Bruto = "0" & TPesoBruto.Text.Trim
        nvoTara = "0" & TPesoTara.Text.Trim
        nvoPeso_Neto = "" & TPesoNeto.Text.Trim
        nvoPesoTeorico = "0" & TPesoTeorico.Text.Trim
        nvoUsuario = TCodOperador.Text.Trim
        nvoOperadorLinea = "Operador"


        If TtramosNoti.Text = "" Or Val(TtramosNoti.Text) = 0 Then
            Mensajes("***  Tecleé el Número de Tramos  *** ", 1)
            TtramosNoti.Focus()
            Exit Sub
        End If

        If (nvoPeso_Neto <= 0) Then
            Mensajes("***  Peso NETO es menor o igual a cero  *** ", 1)
            Exit Sub
        End If

        If (nvoPeso_Bruto < nvoTara) Then
            Mensajes("***  El Peso Bruto debe ser mayor que La Tara  *** ", 1)
            Exit Sub
        End If

        If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
            If TCausas.Text.Trim.Length = 0 Then
                Mensajes("***  Seleccione una CAUSA de SOBREPESO  *** ", 1)
                TCausas.Focus()
                Exit Sub
            End If
        End If

        If rbtFinalSi.Checked = False And rbtFinalNo.Checked = False Then
            Mensajes("***  Selecciona si es TERMINADO ó EN PROCESO   *** ", 1)
            Exit Sub
        End If

        ' ---------------------------------------------------------------------------------
        nvoBascula = "" & strNumeroBascula
        nvoFecha_Pesaje = Date.Today.ToString("yyyy-MM-dd")
        nvoHora_Pesaje = Date.Now.TimeOfDay.ToString()
        nvoOrden_Produccion = TOrden.Text.Trim
        BPesar.Enabled = False

        Dim StrStatus As Boolean
        ' ---------------------------------------------------------------------------------
        QRY_AMD = ""
        QRY_AMD = "Select Status FROM ADM_StatusSAP WHERE Planta='" & SessionUser._sCentro.Trim & "' And Modulo = 'E' "
        LecturaQry_AMD(QRY_AMD)
        If (LecturaBD_AMD.Read) Then
            StrStatus = LecturaBD_AMD(0)
        End If
        LecturaBD_AMD.Close()
        '--- ----------- --------- ------- Inicio : Identificar si el producto usa empaques
        Dim ContEmp As Integer = 0
        QRY = ""
        QRY = "Select * From ProductoTerminadoExtrusion "
        QRY = QRY & "where centro = '" & SessionUser._sCentro.Trim & "' "
        QRY = QRY & "and codigo = '" & TCodPT.Text.Trim & "' "
        QRY = QRY & "and Empaque <> '0' "
        LecturaQry(QRY)
        Do While (LecturaBD.Read())
            CodEmpaque = LecturaBD(6)
            ContEmp = ContEmp + 1
        Loop
        LecturaBD.Close()

        If ContEmp <> 0 Then
            nvoEmpaques = nvoTramosNoti
        Else
            nvoEmpaques = 0
        End If

        Select Case SessionUser._sCentro

            Case Is = "GT01"

                Dim Count_r As Integer = 0

                'Amanco Guatemala
                '--- ----------- --------- ------- Inicio : Variables de Configuración Reprocesado

                QRY = ""
                QRY = "select b.ComExt_ComCodigo from productoterminadoextrusion a, CompuestoExtrusion b "
                QRY = QRY & "where a.centro = b.ComExt_PT_Centro "
                QRY = QRY & "and a.codigo = b.ComExt_PT_Codigo "
                QRY = QRY & "and a.centro = '" & SessionUser._sCentro.Trim & "' "
                QRY = QRY & "and a.codigo = '" & TCodPT.Text.Trim & "' "
                QRY = QRY & "and b.bom = '1' "
                '--QRY = QRY & "and b.ComExt_ComTipo = '1' "
                LecturaQry(QRY)

                Do While (LecturaBD.Read())
                    Count_r = Count_r + 1
                    CompReprocesado = LecturaBD(0)
                Loop

                LecturaBD.Close()

                If Count_r = 0 Then
                    MessageBox.Show(" No Existe compuesto definido como parte de la Bom para este Producto no se puede notificar esta orden ", " VENTANA DE ERROR * * * ")
                    Return
                End If

            Case Else

                Dim Count As Integer = 0

                '--- ----------- --------- ------- Inicio : Variables de Configuración Compuesto

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

        End Select


        Select Case SessionUser._sCentro

            Case Is = "GT01"

                '--- ----------- --------- ------- Inicio : Variables de Configuración Compuesto

                Lt_Compuestos = ""

                '                 ----- Reproceso -----
                If StatusConsumo = True Then

                    'ValPublic_ReproConsumo
                    If ValPublic_ReproConsumo.Trim.Length > 0 Then
                        Compuesto_1 = ValPublic_ReproConsumo.Trim
                        CompuestoPorcent_1 = 100
                        Compuesto_2 = "0"
                        CompuestoPorcent_2 = 0

                        If Compuesto_1 <> CompOriginal.Trim And Compuesto_1 <> CompReprocesado.Trim Then

                            Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + CompReprocesado.Trim + "||" + CompReprocesado.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1

                        Else
                            Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1

                        End If

                    End If
                Else
                    'ValPublic_ReproConsumo
                    If ValPublic_ReproConsumo.Trim.Length > 0 Then
                        Compuesto_1 = ValPublic_ReproConsumo.Trim
                        CompuestoPorcent_1 = 100
                        Compuesto_2 = "0"
                        CompuestoPorcent_2 = 0

                        Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1

                    End If

                End If


                '                 ----- Virgen -----

                If StatusConsumo = True Then
                    'ValPublic_CompuestoVirgen()
                    If ValPublic_CompuestoVirgen.Trim.Length > 0 Then
                        Compuesto_1 = ValPublic_CompuestoVirgen.Trim
                        CompuestoPorcent_1 = 100
                        Compuesto_2 = "0"
                        CompuestoPorcent_2 = 0

                        Lt_Compuestos = CompReprocesado.Trim + "|" + CompuestoPorcent_1.ToString + "|" + CompOriginal.Trim

                    End If
                Else
                    'ValPublic_CompuestoVirgen()
                    If ValPublic_CompuestoVirgen.Trim.Length > 0 Then
                        Compuesto_1 = ValPublic_CompuestoVirgen.Trim
                        CompuestoPorcent_1 = 100
                        Compuesto_2 = "0"
                        CompuestoPorcent_2 = 0
                    End If
                End If


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

                End If
                '--- ----------- --------- ------- Fin : Variables de Configuración Compuesto


            Case Else


                '                 ----- Reproceso -----
                'ValPublic_ReproConsumo
                If ValPublic_ReproConsumo.Trim.Length > 0 Then
                    Compuesto_1 = ValPublic_ReproConsumo.Trim
                    CompuestoPorcent_1 = 100
                    Compuesto_2 = ""
                    CompuestoPorcent_2 = 0

                    Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1

                End If

                '                 ----- Virgen -----
                'ValPublic_CompuestoVirgen()
                If ValPublic_CompuestoVirgen.Trim.Length > 0 Then
                    Compuesto_1 = ValPublic_CompuestoVirgen.Trim
                    CompuestoPorcent_1 = 100
                    Compuesto_2 = ""
                    CompuestoPorcent_2 = 0

                    Lt_Compuestos = ""

                End If

                '             ----- Mezcla de Compuestos -----
                If ValPublic_Ccompuesto1.Trim.Length > 0 And ValPublic_Ccompuesto2.Trim.Length > 0 Then
                    Compuesto_1 = ValPublic_Ccompuesto1.Trim
                    CompuestoPorcent_1 = ValPublic_PorcentajeCom1
                    Compuesto_2 = ValPublic_Ccompuesto2.Trim
                    CompuestoPorcent_2 = ValPublic_PorcentajeCom2

                    Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1 + "||" + CompOriginal.Trim + "|" + CompuestoPorcent_2.ToString + "|" + Compuesto_2

                End If
                '--- ----------- --------- ------- Fin : Variables de Configuración Compuesto


        End Select

        ' ---Identificar Supervisor en Turno-------------------------------------------------
        QRY = ""
        QRY = "Select clave_usr From " & SessionUser._sCentro.Trim & "_Rol_Supervisor "
        QRY = QRY & "Where fecha = '" & Date.Today.ToString("yyyy-MM-dd") & "' "
        QRY = QRY & "And Turno = '" & cmbTurnos.Text.Trim & "' "
        LecturaQry(QRY)
        If (LecturaBD.Read) Then
            Supervisor = LecturaBD(0)
        Else
            Supervisor = "Supervisor"
        End If

        LecturaBD.Close()

        ' ---------------------------------------------------------------------------------
        If FUERATURNO = 0 Then
            dateRegistro = Today()
            FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
            HoraPesaje = Date.Now.TimeOfDay.ToString
            FechaTurno = FechaPesaje
            Turno = cmbTurnos.Text.Trim

            If ValFiltroSeleccionCodigo.Trim = "0" Then
                ValFiltroSeleccionCodigo = "0"
            End If
        Else
            FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
            HoraPesaje = Date.Now.TimeOfDay.ToString
            FechaTurno = dtpFECHA.Value.ToString("yyyy-MM-dd")
            Turno = cmbTurnos.Text.Trim
        End If
        ' ---------------------------------------------------------------------------------
        TipoNotificacion = "0"
        xTIPOPROD = "T"

        If rbtFinalNo.Checked = True Then
            TipoNotificacion = "0"
            xTIPOPROD = "P"
        Else
            SuperAutoSobrepeso = "S/N"
            TipoNotificacion = "2"
        End If
        nvoTipo_SCausa = TCausas.Text.Trim
        nvoPesoTeorico = TPesoTeorico.Text.Trim
        ' ---------------------------------------------------------------------------------

        FechaPesajeSAP = dtpFECHASAP.Value.ToString("yyyy-MM-dd")
        TNumNoti.Text = "0000000000"
        TConsNoti.Text = "00000000"
        FolioSiguiente = "00000000"

        If chkSAP.Checked = True Then

            If TipoNotificacion = "2" Then

                ' ---------------------------------------------------------------------------------
                InQry = ""
                InQry = "INSERT INTO " & SessionUser._sCentro.Trim & "_PesoProductoTerminado (Orden_Produccion,Fecha_Pesaje,Hora_Pesaje,"
                InQry = InQry & "Bascula,Rack,Peso_Bruto,Tara,Peso_Neto,Empaques,Tramos,Usuario,Turno,Supervisor,Planta,Folio,"
                InQry = InQry & "Autoriza_Calidad,Recibe_Almacen,Fecha_Turno,Documento_SAP,Consecutivo_SAP,Compuesto1,Notifica,"
                InQry = InQry & "notificacionmasiva,Porcentaje1,Compuesto2,Porcentaje2,EmbalajeInyeccion,Sobrepeso,"
                InQry = InQry & " CausaSobrepeso,PuestoTrabajo,LTCompuestos,Peso_Teorico,Tipo_PT,FolioR,PorcentajeMerma,PesoMerma,"
                InQry = InQry & "PesoNetoMerma,NumCalidad,Area,OpePtoTra,Sup_Turno) Values ('" & nvoOrden_Produccion & "','" & FechaPesaje.Trim & "',"
                InQry = InQry & "'" & HoraPesaje.Trim & "','" & ValCodigoBascula.Trim & "','" & TRack.Text.Trim & "',"
                InQry = InQry & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & "," & nvoEmpaques & "," & nvoTramosNoti & " ,'"
                InQry = InQry & nvoUsuario & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "','" & SessionUser._sCentro.Trim & "','" & FolioSiguiente.Trim & "','S/N','S/N','" & FechaTurno.Trim & "','"
                InQry = InQry & TNumNoti.Text.Trim & "','" & TConsNoti.Text.Trim & "','" & Compuesto_1.Trim & "','0',0," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2
                InQry = InQry & ",'0'," & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & ",'" & nvoTipo_SCausa & "','" & UCase(WorkCenter.Trim) & "','" & Lt_Compuestos & "'," & Replace(nvoPesoTeorico, GDECIMAL, ".") & ",'" & xTIPOPROD & "', '0', "
                InQry = InQry & "'0',0, 0,'0','E','" & nvoOperadorLinea.Trim & "','" & Supervisor.Trim & "') "
                InsertQry(InQry)

                Mensajes("Registros Actualizados : " & InsertBD, 0)

                FolioSiguiente = ""
                QRY = ""
                QRY = "Select Max(IdFolio) as folioSiguiente from " & SessionUser._sCentro.Trim & "_PesoProductoTerminado  "
                QRY = QRY & "Where Orden_Produccion = '" & TOrden.Text.Trim & "' "
                QRY = QRY & "And  Area = 'E' "
                LecturaQry(QRY)
                If (LecturaBD.Read) Then
                    FolioSiguiente = LecturaBD(0)
                End If
                LecturaBD.Close()
                TFolioAtlas.Text = FolioSiguiente
                CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim
                'Sobrepeso
                ProcesoSobrepeso()
                ' ---- Notificar a SAP

                Select Case StatusSap
                    Case "False"
                        MessageBox.Show(" No se realizara notificación a SAP ", " VENTANA DE ERROR * * * ")
                    Case "True"
                        If SessionUser._sAlias.Trim <> "ATLAS" Then

                            Dim Notificacion As PTConProd._ISDFPS_TCUPS_KEY

                            Notificacion = Notifica_PT(FechaPesajeSAP.Trim, nvoTramosNoti, nvoOrden_Produccion, nvoPeso_Neto, 0, CadenaTexto, Lt_Compuestos)

                            TConsNoti.Text = Notificacion.RMZHL
                            TNumNoti.Text = Notificacion.RUECK
                            Err = ls_return.ZTYPE
                            Mns = ls_return.ZMESSAGE
                            Cod_Err = ls_return.ZNUMBER


                        ElseIf SessionUser._sAlias.Trim = "ATLAS" Then


                            Dim Not_Atlas As PTConsumos._ISDFPS_TCUPS_KEY

                            Not_Atlas = Notifica_Atlas(FechaPesajeSAP.Trim, nvoTramosNoti, nvoOrden_Produccion, nvoPeso_Neto, 0, CadenaTexto, Lt_Compuestos)

                            TConsNoti.Text = Not_Atlas.RMZHL
                            TNumNoti.Text = Not_Atlas.RUECK
                            Err = ls_returnr.ZTYPE
                            Mns = ls_returnr.ZMESSAGE
                            Cod_Err = ls_returnr.ZNUMBER

                        End If
                End Select

                ' ---------------------------------------------------------------------------------
                If Cod_Err = "E" Or Cod_Err = "505" Then
                    MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
                    Exit Sub
                End If
                ' ---------------------------------------------------------------------------------
                If (Me.TNumNoti.Text = "" Or Me.TNumNoti.Text = "NULL" Or Me.TNumNoti.Text = "0000000000") And (Me.TConsNoti.Text = "" Or Me.TConsNoti.Text = "NULL" Or Me.TConsNoti.Text = "00000000") Then
                    reg = "0"
                    MsgBox("No Notifico a SAP")
                    BPesar.Enabled = False
                    BImprimir.Enabled = True
                    TOrden.Enabled = False
                    SuperAutoSobrepeso = ""
                    Return
                Else
                    reg = "1"

                    InQry = ""
                    InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set Notifica = '" & reg.Trim & "', "
                    InQry = InQry & "Documento_SAP = '" & TNumNoti.Text.Trim & "', "
                    InQry = InQry & "Consecutivo_SAP = '" & TConsNoti.Text.Trim & "' "
                    InQry = InQry & " Where Folio = '" & FolioSiguiente.Trim & "'"
                    InsertQry(InQry)

                    Mensajes("Notificación a SAP Exitosa : " & InsertBD, 0)

                End If

                BPesar.Enabled = False
                BImprimir.Enabled = True
                TOrden.Enabled = False
                SuperAutoSobrepeso = ""

            Else
                If xTIPOPROD = "T" Then
                    xTIPOPROD = "S"
                End If
                ' ---------------------------------------------------------------------------------
                InQry = ""
                InQry = "INSERT INTO " & SessionUser._sCentro.Trim & "_PesoProductoTerminado (Orden_Produccion,Fecha_Pesaje,"
                InQry = InQry & "Hora_Pesaje, Bascula, Rack, Peso_Bruto, Tara, Peso_Neto, Empaques, Tramos,"
                InQry = InQry & "Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,Recibe_Almacen,Fecha_Turno,"
                InQry = InQry & "Documento_SAP,Consecutivo_SAP, Compuesto1, Notifica, notificacionmasiva,"
                InQry = InQry & "Porcentaje1,Compuesto2,Porcentaje2,PackID,EmbalajeInyeccion,Sobrepeso,CausaSobrepeso,PuestoTrabajo,"
                InQry = InQry & "LTCompuestos,Peso_Teorico,Tipo_PT,FolioR,PorcentajeMerma,PesoMerma,PesoNetoMerma,NumCalidad,Area,OpePtoTra,Sup_Turno) Values ("
                InQry = InQry & "'" & nvoOrden_Produccion & "','" & FechaPesaje.Trim & "','" & HoraPesaje.Trim & "','" & ValCodigoBascula.Trim & "','" & TRack.Text.Trim & "', "
                InQry = InQry & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & "," & nvoEmpaques & "," & nvoTramosNoti & ",'"
                InQry = InQry & nvoUsuario & "','" & Turno.Trim & "','Supervisor','" & SessionUser._sCentro.Trim & "','" & FolioSiguiente.Trim & "','SB','S/N','" & FechaTurno.Trim & "',"
                InQry = InQry & "'" & TNumNoti.Text.Trim & "','" & TConsNoti.Text.Trim & "','" & Compuesto_1.Trim & "','0',0," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2
                InQry = InQry & ",'" & FolioSiguiente.Trim & "','0'," & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & ",'" & nvoTipo_SCausa & "','" & UCase(WorkCenter.Trim) & "','" & Lt_Compuestos & "'," & Replace(nvoPesoTeorico, GDECIMAL, ".") & ",'" & xTIPOPROD & "', '' , "
                InQry = InQry & "'0',0,0,'0','E','" & nvoOperadorLinea.Trim & "','" & Supervisor.Trim & "') "
                InsertQry(InQry)
                ' ---------------------------------------------------------------------------------
                Mensajes("Registros Actualizados : " & InsertBD, 0)

                FolioSiguiente = ""
                QRY = ""
                QRY = "Select Max(IdFolio) as folioSiguiente from " & SessionUser._sCentro.Trim & "_PesoProductoTerminado  "
                QRY = QRY & "Where Orden_Produccion = '" & TOrden.Text.Trim & "' "
                QRY = QRY & "And  Area = 'E' "
                LecturaQry(QRY)
                If (LecturaBD.Read) Then
                    FolioSiguiente = LecturaBD(0)
                End If
                LecturaBD.Close()
                TFolioAtlas.Text = FolioSiguiente
                CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim
                'Sobrepeso
                ProcesoSobrepeso()
                'Registra notificaciones separadas

                If rbtFinalNo.Checked = True Then
                    ProcesoSeparada()
                End If

                BPesar.Enabled = False
                BImprimir.Enabled = True
                TOrden.Enabled = False
                SuperAutoSobrepeso = ""
            End If
        Else
            TipoNotificacion = "4"
            If xTIPOPROD = "T" And Not AutorizaSobrepeso <> 2 Then
                xTIPOPROD = "S"
            End If
            ' ---------------------------------------------------------------------------------
            InQry = ""
            InQry = "INSERT INTO " & SessionUser._sCentro.Trim & "_PesoProductoTerminado (Orden_Produccion,Fecha_Pesaje,"
            InQry = InQry & "Hora_Pesaje, Bascula, Rack, Peso_Bruto, Tara, Peso_Neto, Empaques, Tramos,"
            InQry = InQry & "Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,Recibe_Almacen,Fecha_Turno,"
            InQry = InQry & "Documento_SAP,Consecutivo_SAP, Compuesto1, Notifica, notificacionmasiva,"
            InQry = InQry & "Porcentaje1,Compuesto2,Porcentaje2,PackID,EmbalajeInyeccion,Sobrepeso,CausaSobrepeso,PuestoTrabajo,"
            InQry = InQry & "LTCompuestos,Peso_Teorico,Tipo_PT,FolioR,PorcentajeMerma,PesoMerma,PesoNetoMerma,NumCalidad,Area,OpePtoTra,Sup_Turno) Values ("
            InQry = InQry & "'" & nvoOrden_Produccion & "','" & FechaPesaje.Trim & "','" & HoraPesaje.Trim & "','" & ValCodigoBascula.Trim & "','" & Me.TRack.Text.Trim & "', "
            InQry = InQry & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & "," & nvoEmpaques & "," & nvoTramosNoti & ", "
            InQry = InQry & "'" & nvoUsuario & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "','" & SessionUser._sCentro.Trim & "','" & FolioSiguiente.Trim & "','SB','S/N','" & FechaTurno.Trim & "', "
            InQry = InQry & "'" & TNumNoti.Text.Trim & "','" & TConsNoti.Text.Trim & "','" & Compuesto_1.Trim & "','0',0," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2
            InQry = InQry & ",'" & FolioSiguiente.Trim & "','0'," & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & ",'" & nvoTipo_SCausa & "','" & UCase(WorkCenter.Trim) & "','" & Lt_Compuestos & "'," & Replace(nvoPesoTeorico, GDECIMAL, ".") & ",'" & xTIPOPROD & "', '' , "
            InQry = InQry & "'0',0,0,'0','E','" & nvoOperadorLinea.Trim & "','" & Supervisor.Trim & "') "
            InsertQry(InQry)
            ' ---------------------------------------------------------------------------------
            Mensajes("Registros Actualizados : " & InsertBD, 0)
            ' ---------------------------------------------------------------------------------

            FolioSiguiente = ""
            QRY = ""
            QRY = "Select Max(IdFolio) as folioSiguiente from " & SessionUser._sCentro.Trim & "_PesoProductoTerminado  "
            QRY = QRY & "Where Orden_Produccion = '" & TOrden.Text.Trim & "' "
            QRY = QRY & "And  Area = 'E' "
            LecturaQry(QRY)
            If (LecturaBD.Read) Then
                FolioSiguiente = LecturaBD(0)
            End If
            LecturaBD.Close()
            TFolioAtlas.Text = FolioSiguiente
            CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim
            'Sobrepeso
            ProcesoSobrepeso()
            'Registra notificaciones separadas
            ProcesoSeparada()


            BPesar.Enabled = False
            BCompuesto.Enabled = False
            TOrden.Enabled = False
            SuperAutoSobrepeso = ""

            If SessionUser._sCentro.Trim = "GT01" Then
                BImprimir.Enabled = False
                imprimir_PT()
            Else
                BImprimir.Enabled = True
            End If
        End If
    End Sub

    Private Sub TPesoBruto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoBruto.TextChanged
        Dim xTPesoBruto As Double
        Dim xTPesoTara As Double
        Dim xTempaquePesoTot As Double
        Dim xTPesoNeto As Double
        xTPesoBruto = TPesoBruto.Text.Trim
        xTPesoTara = "0" & TPesoTara.Text.Trim
        xTempaquePesoTot = "0" & TempaquePesoTot.Text.Trim
        xTPesoNeto = xTPesoBruto - xTPesoTara - xTempaquePesoTot
        TPesoNeto.Text = Format(xTPesoNeto, xFormato)

    End Sub

    Private Sub TPesoTara_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoTara.TextChanged
        Dim xTPesoBruto As Double
        Dim xTPesoTara As Double
        Dim xTempaquePesoTot As Double
        Dim xTPesoNeto As Double
        Dim xTramos As Double
        xTramos = "0" & TtramosNoti.Text.Trim
        xTPesoBruto = "0" & TPesoBruto.Text.Trim
        xTPesoTara = "0" & TPesoTara.Text.Trim
        xTempaquePesoTot = "0" & TempaquePesoTot.Text.Trim
        'TPesoTara.Text = xTPesoTara + (xTPesoAcc * xTramos) + (xTPEsoEmb * xTramos)
        xTPesoNeto = xTPesoBruto - (xTPesoTara + xTempaquePesoTot)
        TPesoNeto.Text = Format(xTPesoNeto, xFormato)

    End Sub
    Private Sub TtramosNoti_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TtramosNoti.KeyPress
        e.Handled = txtNumerico(TtramosNoti, e.KeyChar, True)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub TRack_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TRack.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub TPesoRack_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoRack.TextChanged
        Dim xTPesoTara As Double
        xTPesoTara = "0" & TPesoRack.Text.Trim
        TPesoTara.Text = Format(xTPesoTara, xFormato)
    End Sub
    Private Sub TtramosNoti_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TtramosNoti.Leave

        Dim xPSP As Double
        Dim xTramosNoti As Double
        Dim xPeso_Neto As Double

        xTramosNoti = "0" & TtramosNoti.Text.Trim
        xPeso_Neto = TPesoNeto.Text.Trim
        SobrepesoPermitido = "0" & SP_Permitido.Text.Trim
        PorcentajeSobrePeso = 0

        If taraempaque > 0 Then
            TempaquePesoTot.Text = Format((Val(taraempaque) * Val(TtramosNoti.Text)), xFormato)
        Else
            TempaquePesoTot.Text = "0"
        End If

        TPesoTara.Text = Format(Val(TPesoRack.Text), xFormato)

        If PesoTeorico > 0 And xTramosNoti > 0 Then
            xPSP = (((xPeso_Neto / (PesoTeorico * xTramosNoti)) - 1) * 100)
            PorcentajeSobrePeso = Format(xPSP, xFormato)
        Else
            PorcentajeSobrePeso = Format(100, xFormato)
        End If

        TSobrePeso.Text = Format(PorcentajeSobrePeso, "#0.00")

        If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
            TSobrePeso.BackColor = Color.Red
            TCausas.Enabled = True
        Else
            TSobrePeso.BackColor = Color.Yellow
        End If

        'If TtramosNoti.Text.Trim.Length > 0 Then
        '    If Permiso.gNotificar = "S" Then
        '        BPesar.Enabled = True
        '    Else
        '        BPesar.Enabled = False
        '    End If
        'End If
        TtramosNoti.BackColor = Color.White

        If TPesoBruto.Text <> "0.00" Or TPesoTara.Text <> "0.00" Or TempaquePesoTot.Text <> "" Then
            TPesoNeto.Text = Format((TPesoBruto.Text - TPesoTara.Text - TempaquePesoTot.Text), xFormato)
        End If

        BCompuesto.Enabled = True

    End Sub
    Private Sub BSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSiguiente.Click
        LimpiaObjetos()
        TSobrePeso.BackColor = Color.White
        TClaveOperador.Focus()
    End Sub
    Private Sub BImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImprimir.Click
        EXTINY = "1"
        imprimir_PT()
    End Sub
    Sub imprimir_PT()

        QRY = ""
        QRY = QRY & "Select a.Orden_Produccion,b.Folio,a.Planta,a.Equipo_Basico,b.Fecha_Pesaje,b.Hora_Pesaje,b.Bascula,b.Rack,"
        QRY = QRY & "b.Peso_Bruto,b.Tara,b.Peso_Neto,b.Tramos,b.Usuario,b.Turno,b.Documento_SAP,b.Consecutivo_SAP,b.Sobrepeso,"
        QRY = QRY & "b.PorcentajeMerma,b.PesoMerma,b.PesoNetoMerma,c.Codigo,c.Descr,b.OpePtoTra "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
        QRY = QRY & "ProductoTerminadoExtrusion c "
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And a.Producto = c.Codigo "
        QRY = QRY & "And a.Planta = c.Centro "
        QRY = QRY & "And a.Planta = '" & SessionUser._sCentro.Trim & "' "
        QRY = QRY & "And a.Orden_Produccion = '" & TOrden.Text.Trim & "' "
        QRY = QRY & "And b.Folio = Convert(int, '" & TFolioAtlas.Text.Trim & "') "
        LecturaQry(QRY)

        Try
            objDa = New SqlDataAdapter(QRY, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)

            'objDs.WriteXmlSchema("c:\atlas\BP_PTE.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
        End Try

        Select Case SessionUser._sCentro.Trim
            Case Is = "GT01"
                If SessionUser._sAlias.Trim = "YONY" Then
                    Dim BoletaPesaje As New RValePTE_GT
                    FREP.CRV1.ReportSource = BoletaPesaje
                    FREP.Show()
                Else
                    Dim BoletaPesaje As New RValePTE_GT
                    BoletaPesaje.SetDataSource(objDs)
                    BoletaPesaje.PrintToPrinter(1, False, 1, 1)
                End If
            Case Is = "A014"
                'Dim BoletaPesaje As New rptTicketExt_AMEX
                'BoletaPesaje.SetDataSource(objDs)
                'BoletaPesaje.PrintToPrinter(1, False, 1, 1)
                'Case Is = "A021", "A022"
                '    Dim BoletaPesaje As New rptValeExtDoble_AMEX
                '    BoletaPesaje.SetDataSource(objDs)
                '    BoletaPesaje.PrintToPrinter(1, False, 1, 1)
                'Case Else
                '    Dim BoletaPesaje As New rptValeExt_AMEX
                '    BoletaPesaje.SetDataSource(objDs)
                '    FREP.CRV1.ReportSource = BoletaPesaje
                '    FREP.Show()
        End Select


    End Sub

    Private Sub BCompuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCompuesto.Click
        StrProces = "Est"
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
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        BPesar.Enabled = True
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
    Private Sub ProcesoSeparada()
        AutorizaSobrepeso = 2
        SuperAutoSobrepeso = "S/N"
        ObserSobrepeso = ""
        InQry = ""
        InQry = "INSERT INTO MCPT_AutorizacionSeparada (Orden_produccion, Fecha_Pesaje, Hora_Pesaje, Bascula, Rack, Tramos, Empaques, Peso_Bruto, Tara, Peso_Neto, "
        InQry = InQry & " Usuario, Turno, Supervisor, Planta, Folio, Autoriza_Calidad, Recibe_Almacen, Autoriza_separada, Estatus_Autorizacion, Observaciones ,Porscrap, "
        InQry = InQry & " Causascrap, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos,Fecha_turno, puestotrabajo) Values ( '" & nvoOrden_Produccion & "','"
        InQry = InQry & FechaPesaje.Trim & "' , '" & HoraPesaje.Trim & "','" & ValCodigoBascula.Trim & "','" & TRack.Text.Trim & "'," & nvoTramosNoti & ","
        InQry = InQry & nvoEmpaques & " , " & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & ",'"
        InQry = InQry & nvoUsuario & " ' , " & Turno.Trim & " , '" & SuperAutoSobrepeso.Trim & "', '" & SessionUser._sCentro.Trim & "', '" & FolioSiguiente.Trim & "' , '" & "S/N" & " ','"
        InQry = InQry & "S/N" & "','" & SuperAutoSobrepeso.Trim & "','" & 0 & "','" & ObserSobrepeso.Trim & "','" & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & "'"
        InQry = InQry & ",'9999','" & Compuesto_1.Trim & "'," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2 & ",'" & Lt_Compuestos & "','" & FechaTurno & "', "
        InQry = InQry & "'" & WorkCenter.Trim & "')"
        InsertQry(InQry)
    End Sub
    Private Sub ProcesoSobrepeso()
        Dim xPSP As Double
        Dim xTramosNoti As Double
        Dim xPeso_Neto As Double
        Dim Folio_SP As String

        ' ---------------------------------------------------------------------------------
        Folio_SP = ""
        QRY = ""
        QRY = "Select isnull((Max(Sobrepeso)+1),0) as Folio_SP from MCPC_Foliador  "
        QRY = QRY & " where Planta = '" & SessionUser._sCentro.Trim & "'"
        LecturaQry(QRY)
        If (LecturaBD.Read) Then
            Folio_SP = LecturaBD(0)
        End If
        LecturaBD.Close()
        ' ---------------------------------------------------------------------------------
        Folio_SP = Folio_SP.Trim
        Folio_SP = Mid("00000000", 1, 8 - Len(Folio_SP)) & Folio_SP.Trim
        ' ---------------------------------------------------------------------------------

        xTramosNoti = "0" & TtramosNoti.Text.Trim
        xPeso_Neto = "" & TPesoNeto.Text.Trim
        SobrepesoPermitido = "0" & SP_Permitido.Text.Trim
        PorcentajeSobrePeso = 0
        If PesoTeorico > 0 And xTramosNoti > 0 Then
            xPSP = (((xPeso_Neto / (PesoTeorico * xTramosNoti)) - 1) * 100)
            PorcentajeSobrePeso = Format(xPSP, xFormato)
        Else
            PorcentajeSobrePeso = Format(100, xFormato)
        End If
        AutorizaSobrepeso = 0
        TSobrePeso.Text = Format(PorcentajeSobrePeso, "#0.00")
        If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
            While TCausas.Text = ""
                CausaSobrepeso()
            End While
            FormSobrePesoTf.Label1.ForeColor = Color.RoyalBlue
            FormSobrePesoTf.Label2.ForeColor = Color.RoyalBlue
            FormSobrePesoTf.Label1.Text = "El pesaje  se  encuentra fuera de rango. "
            FormSobrePesoTf.Label2.Text = "Por lo tanto se necesita  la autorización del supervisor en turno."
            FormSobrePesoTf.ShowDialog()
        End If
        If AutorizaSobrepeso > 0 Then

            Select Case AutorizaSobrepeso
                Case Is = 1 ' "SI" Autoriza Supervisor
                    StatusSobrepeso = "Aceptado"
                Case Is = 2 ' " NO " Autoriza Supervisor
                    StatusSobrepeso = "Rechazado"
            End Select

            LecturaQry("PA_Insert_Sobrepesos " & SessionUser._sCentro.Trim & "_Sobrepesos, '" & TOrden.Text.Trim & "', '" & FolioSiguiente & "', '" & SP & "', '" & TCausas.Text.Trim & "', '" & Autoriza_SP & "', '" & Obs_Peso & "' ")

            'Select Case strPlanta
            'Case Is = "A022"
            '    ' ---------------------------------------------------------------------------------
            '    InQry = ""
            '    InQry = "INSERT INTO " & strPlanta.Trim & "_AutorizacionSobrepeso(Orden_Produccion,Fecha_Pesaje,Hora_Pesaje,"
            '    InQry = InQry & "Folio,Bascula,Rack,Peso_Bruto,Peso_Taras,Peso_Neto,Empaques,Tramos,Usuario,Turno,Supervisor,"
            '    InQry = InQry & "Folio_SP,Autoriza_Sobrepeso,Observaciones,CausaSobrepeso,Compuesto1,Porcentaje1,"
            '    InQry = InQry & "Compuesto2,Porcentaje2,Area) Values "
            '    InQry = InQry & "('" & nvoOrden_Produccion & "','" & FechaPesaje.Trim & "','" & HoraPesaje.Trim & "',"
            '    InQry = InQry & "'" & FolioSiguiente & "','" & ValCodigoBascula.Trim & "','" & TPesoRack.Text.Trim & "',"
            '    InQry = InQry & "" & nvoEmpaques & ",'" & nvoTramosNoti & "','" & nvoUsuario & "','" & Turno.Trim & "',"
            '    InQry = InQry & "'" & SuperAutoSobrepeso.Trim & "','" & Folio_SP & "','" & SuperAutoSobrepeso.Trim & "',"
            '    InQry = InQry & "'" & ObserSobrepeso.Trim & "','" & TCausas.Text.Trim & "','" & Compuesto_1.Trim & "',"
            '    InQry = InQry & "'" & CompuestoPorcent_1 & "','" & Compuesto_2.Trim & "','" & CompuestoPorcent_2 & "',"
            '    InQry = InQry & ""

            '    InQry = InQry & "'" & Replace(nvoTara, GDECIMAL, ".") & "','" & Replace(nvoPeso_Neto, GDECIMAL, ".") & "',"
            '    InQry = InQry & "'" & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "',"
            '    InQry = InQry & "'" & "S/N" & " ',' " & "S/N" & "',"
            '    InQry = InQry & "'0',"
            '    InQry = InQry & "'" & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & "',"
            '    InQry = InQry & ""
            '    InQry = InQry & "'" & Lt_Compuestos & "','" & FechaTurno.Trim & "',"
            '    InQry = InQry & "'" & WorkCenter.Trim & "')"
            '    InsertQry(InQry)

            '    InQry = ""
            '    InQry = "Update MCPC_Foliador set sobrepeso = '" & Folio_SP.Trim & "'"
            '    InQry = InQry & " where Planta = '" & strPlanta.Trim & "'"
            '    InsertQry(InQry)
            '    ' ---------------------------------------------------------------------------------
            'Case Else
            '' ---------------------------------------------------------------------------------
            'InQry = ""
            'InQry = "INSERT INTO MCPT_AutorizacionSobrepeso (Orden_produccion,Fecha_Pesaje,Hora_Pesaje,Bascula,Rack,Tramos,"
            'InQry = InQry & "Empaques,Peso_Bruto,Tara,Peso_Neto,Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,"
            'InQry = InQry & "Recibe_Almacen,Autoriza_Sobrepeso,Estatus_Autorizacion,Observaciones,PorSobrePeso,CausasSobrepeso,"
            'InQry = InQry & "Compuesto1,Porcentaje1,Compuesto2,Porcentaje2,LTCompuestos, Fecha_turno, Puestotrabajo) Values "
            'InQry = InQry & "('" & nvoOrden_Produccion & "','" & FechaPesaje.Trim & "','" & HoraPesaje.Trim & "',"
            'InQry = InQry & "'" & ValCodigoBascula.Trim & "','" & TPesoRack.Text.Trim & "','" & nvoTramosNoti & "',"
            'InQry = InQry & "" & nvoEmpaques & ",'" & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "',"
            'InQry = InQry & "'" & Replace(nvoTara, GDECIMAL, ".") & "','" & Replace(nvoPeso_Neto, GDECIMAL, ".") & "',"
            'InQry = InQry & "'" & nvoUsuario & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "',"
            'InQry = InQry & "'" & strPlanta.Trim & "','" & Folio_SP & "','" & "S/N" & " ',' " & "S/N" & "',"
            'InQry = InQry & "'" & SuperAutoSobrepeso.Trim & "','0','" & ObserSobrepeso.Trim & "',"
            'InQry = InQry & "'" & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & "','" & TCausas.Text.Trim & "',"
            'InQry = InQry & "'" & Compuesto_1.Trim & "','" & CompuestoPorcent_1 & "','" & Compuesto_2.Trim & "',"
            'InQry = InQry & "'" & CompuestoPorcent_2 & "','" & Lt_Compuestos & "','" & FechaTurno.Trim & "',"
            'InQry = InQry & "'" & WorkCenter.Trim & "')"
            'InsertQry(InQry)

            'InQry = ""
            'InQry = "Update MCPC_Foliador set sobrepeso = '" & Folio_SP.Trim & "'"
            'InQry = InQry & " where Planta = '" & strPlanta.Trim & "'"
            'InsertQry(InQry)
            ' ---------------------------------------------------------------------------------
            'End Select

            'Select Case strPlanta

            '    Case Is = "A001"

            '        'Generación del formato para el cuerpo del correo

            '        Email = ""
            '        Email = Email & "Reporte de Sobre Peso " & vbCr & ""
            '        Email = Email & "" & vbCr & ""
            '        Email = Email & "Numero ODF:            " & TOrden.Text.Trim & " " & vbCr & ""
            '        Email = Email & "Folio Atlas:           " & FolioSiguiente.Trim & " " & vbCr & ""
            '        Email = Email & "Status Autorización:   " & StatusSobrepeso.Trim & " " & vbCr & ""
            '        Email = Email & "Producto:              " & TCodPT.Text.Trim & " " & vbCr & ""
            '        Email = Email & "Descripción:           " & TCodPtDecr.Text.Trim & " " & vbCr & ""
            '        Email = Email & "Fecha:                 " & Date.Today.ToString("yyyy-MM-dd") & " " & vbCr & ""
            '        Email = Email & "Hora:                  " & Date.Now.TimeOfDay.ToString.Substring(0, 8) & " " & vbCr & ""
            '        Email = Email & "Rack:                  " & TRack.Text.Trim & " " & vbCr & ""
            '        Email = Email & "Tramos:                " & nvoTramosNoti & " " & vbCr & ""
            '        Email = Email & "Peso Bruto:            " & TPesoBruto.Text.Trim & " " & vbCr & ""
            '        Email = Email & "Peso Tara:             " & TPesoTara.Text.Trim & " " & vbCr & ""
            '        Email = Email & "Peso Neto:             " & TPesoNeto.Text.Trim & " " & vbCr & ""
            '        Email = Email & "Sobre Peso:            " & TSobrePeso.Text.Trim & " '%' " & vbCr & ""
            '        Email = Email & "" & vbCr & ""
            '        Email = Email & "Usuario Notifica:      " & SessionUser._sAlias.Trim & " " & vbCr & ""
            '        Email = Email & "Supervisor Autoriza:   " & SuperAutoSobrepeso.Trim & " " & vbCr & ""
            '        Email = Email & "Maquina:               " & TPtoTrabajo.Text.Trim & " " & vbCr & ""
            '        Email = Email & "Turno:                 " & Turno.Trim & " " & vbCr & ""
            '        Email = Email & "Observación:           " & ObserSobrepeso.Trim & " " & vbCr & ""
            '        Email = Email & "Causa Sobre Peso:      " & TCausas.Text.Trim & " " & Desccausa.Text.Trim & ""

            '        'Preparación para el envio del correo
            '        Select Case strPlanta
            '            Case Is = "A001"
            '                correo.From = New MailAddress("atlas_amanmex@mexichem.com", "Amanco Mexico")
            '            Case Is = "A013"
            '                correo.From = New MailAddress("atlas_amanmex@mexichem.com", "Amanco Mexico")
            '        End Select


            '        If SessionUser._sAlias.Trim = "ATLAS" Then
            '            correo.To.Add("jsalinas@mexichem.com")
            '        Else
            '            Select Case strPlanta
            '                Case Is = "A001"
            '                    correo.To.Add("facosta@mexichem.com")
            '                    correo.CC.Add("jcescobar@mexichem.com")
            '                    correo.CC.Add("zpalomino@mexichem.com")
            '                    correo.CC.Add("esarabia@mexichem.com")
            '                    correo.CC.Add("masanchezc@mexichem.com")
            '                    correo.CC.Add("jmgonzalez@mexichem.com")
            '                    correo.CC.Add("goliva@mexichem.com")
            '                    correo.CC.Add("arruizh@mexichem.com")
            '                    correo.CC.Add("agrajeda@mexichem.com")
            '                    'correo.CC.Add("jsalinas@mexichem.com")
            '                Case Is = "A013"
            '                    correo.To.Add("ggonzalezg@mexichem.com")
            '                    correo.CC.Add("agea@mexichem.com")
            '                    correo.CC.Add("econtrerasp@mexichem.com")
            '                    correo.CC.Add("atorresl@mexichem.com")
            '            End Select
            '        End If

            '        correo.Subject = "Notificación de Sobre Peso en Producto Terminado de la ODF " & TOrden.Text.Trim & ""
            '        'correo.Attachments.Add(New Attachment("C:\Sobrepeso_" & FolioSiguiente & ".txt"))
            '        correo.Body = Email
            '        correo.IsBodyHtml = False
            '        Select Case strPlanta
            '            Case Is = "A001"
            '                smtp.Host = "ammxlonw002.mexichem.corp"
            '                smtp.Port = 25
            '                smtp.EnableSsl = False
            '                smtp.Credentials = New System.Net.NetworkCredential("atlasleon@mexichem.com", "leona0358")
            '            Case Is = "A013"
            '                smtp.Host = "TFMXCUW001.mexichem.corp"
            '                smtp.Port = 25
            '                smtp.EnableSsl = False
            '                smtp.Credentials = New System.Net.NetworkCredential("atlas_amanmex@mexichem.com", "extrusion0127")
            '        End Select

            '        Try
            '            smtp.Send(correo)
            '            MsgBox("Mensaje enviado satisfactoriamente")
            '            correo.Dispose()
            '        Catch ex As Exception
            '            MsgBox("ERROR: " & ex.Message)
            '        End Try

            'End Select

        Else
            SuperAutoSobrepeso = "S/N"
        End If
    End Sub

    Private Sub TPesoNeto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoNeto.TextChanged
        Dim xPSP As Double
        Dim xTramosNoti As Double
        Dim xPeso_Neto As Double

        xTramosNoti = "0" & TtramosNoti.Text.Trim
        xPeso_Neto = "" & TPesoNeto.Text.Trim
        SobrepesoPermitido = "0" & SP_Permitido.Text.Trim
        PorcentajeSobrePeso = 0

        If PesoTeorico > 0 And xTramosNoti > 0 Then
            xPSP = (((xPeso_Neto / (PesoTeorico * xTramosNoti)) - 1) * 100)
            PorcentajeSobrePeso = Format(xPSP, xFormato)
        Else
            PorcentajeSobrePeso = Format(100, xFormato)
        End If

        TSobrePeso.Text = Format(PorcentajeSobrePeso, "#0.00")

        If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
            TSobrePeso.BackColor = Color.Red
            TCausas.Enabled = True
        Else
            TSobrePeso.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub TSobrePeso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
            TSobrePeso.BackColor = Color.Red
            TCausas.Enabled = True
        Else
            TSobrePeso.BackColor = Color.Yellow
            TCausas.Enabled = True
        End If
    End Sub

    Private Sub CausaSobrepeso()
        Q = "SELECT Codcausa, descausa FROM CatCausas "
        Q = Q & "WHERE centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & "AND Grpprod = '" & TGrpprod.Text.Trim & "' "
        Q = Q & "AND TipoCausa = 'SP' "
        Q = Q & "AND status = 'A'"
        frmSpro.SPRO_TITULO = "Catalogo de CAUSAS SCRAP"
        frmSpro.SPRO_SQL = Q
        frmSpro.SPRO_OK = 0
        frmSpro.SPRO_COLKEY = 0
        frmSpro.SPRO_KEY = ""
        frmSpro.SPRO_LIKE = "descausa"
        frmSpro.ShowDialog()
        If frmSpro.SPRO_OK = 1 Then
            TCausas.Text = frmSpro.SPRO_KEY
            Q = " SELECT DesCausa FROM CatCausas"
            Q = Q & " WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
            Q = Q & " AND TipoCausa = 'SP' "
            Q = Q & " AND CodCausa = '" & TCausas.Text & "' AND status='A'"
            Desccausa.Text = TraeDescripcion(Q)
            frmSpro.SPRO_OK = 0
        End If
    End Sub
    Private Sub BCauSobrepeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Q = "SELECT centro, Grpprod, Codcausa, descausa FROM CatCausas "
        Q = Q & "WHERE centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & "AND Grpprod = '" & TGrpprod.Text.Trim & "' "
        Q = Q & "AND TipoCausa = 'SP' "
        Q = Q & "AND status = 'A'"
        frmSpro.SPRO_TITULO = "Catalogo de CAUSAS"
        frmSpro.SPRO_SQL = Q
        frmSpro.SPRO_OK = 0
        frmSpro.SPRO_COLKEY = 2
        frmSpro.SPRO_KEY = ""
        frmSpro.ShowDialog()
        If frmSpro.SPRO_OK = 1 Then
            TCausas.Text = frmSpro.SPRO_KEY
            Q = " SELECT DesCausa FROM CatCausas"
            Q = Q & " WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
            Q = Q & " AND TipoCausa = 'SP' "
            Q = Q & " AND CodCausa = '" & TCausas.Text & "' AND status='A'"
            Desccausa.Text = TraeDescripcion(Q)
            frmSpro.SPRO_OK = 0
        End If
    End Sub

    Private Sub TOrden_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOrden.Enter
        TOrden.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TRack_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRack.Enter
        TRack.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TtramosNoti_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TtramosNoti.Enter
        TtramosNoti.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub rbtFinalNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFinalNo.Click, rbtFinalNo.Leave
        BPesar.Focus()
    End Sub

    Private Sub BImprimir_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImprimir.Leave
        BSiguiente.Focus()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub TPesoCaptura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoCaptura.TextChanged
        Dim xTPesoCaptura As Double
        xTPesoCaptura = "0" & TPesoCaptura.Text.Trim
        TPesoBruto.Text = Format(xTPesoCaptura, xFormato)
    End Sub

    Private Sub TPesoCaptura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = txtNumerico(TPesoCaptura, e.KeyChar, True)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkSAP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chkSAP.Checked = True Then
            dtpFECHASAP.Enabled = True
        Else
            dtpFECHASAP.Enabled = False
        End If
    End Sub

    Private Sub TClaveOperador_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TClaveOperador.Enter
        TClaveOperador.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TClaveOperador_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TClaveOperador.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TClaveOperador_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TClaveOperador.Leave
        Gen_Valida.Valida_Operador(TClaveOperador.Text.Trim)
        If Gen_Valida.strCodigo.Trim = "" Then
            MessageBox.Show("*** USUARIO INEXISTENTE *** ")
            TClaveOperador.Text = ""
            TCodOperador.Text = ""
            TNomOperador.Text = ""
            TClaveOperador.Focus()
        Else
            TCodOperador.Text = Gen_Valida.strCodigo.Trim
            TNomOperador.Text = Gen_Valida.strNombre.Trim
            TOrden.Focus()
        End If
        ' ---------------------------------------------------------------------------------
        TClaveOperador.BackColor = Color.White
    End Sub

    Private Sub btnLookrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub lblFinalSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFinalSi.Click
        If SessionUser._sCentro.Trim <> "A001" Then
            If rbtFinalSi.Checked = False Then
                rbtFinalSi.Checked = True
                lblFinalSi.BackColor = Color.DarkBlue
                lblFinalSi.ForeColor = Color.White
                lblFinalNo.BackColor = Me.BackColor
                lblFinalNo.ForeColor = Color.DarkBlue
                rbtFinalNo.Checked = False
            End If
        End If
    End Sub
    Private Sub lblFinalNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFinalNo.Click
        If SessionUser._sCentro.Trim <> "A001" Then
            If rbtFinalNo.Checked = False Then
                rbtFinalNo.Checked = True
                lblFinalNo.BackColor = Color.DarkBlue
                lblFinalNo.ForeColor = Color.White
                lblFinalSi.BackColor = Me.BackColor
                lblFinalSi.ForeColor = Color.DarkBlue
                rbtFinalSi.Checked = False
            End If
        End If
    End Sub

    Private Sub rbtFinalSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFinalSi.Click
        If SessionUser._sCentro.Trim <> "A001" Then
            If rbtFinalSi.Checked = False Then
                rbtFinalSi.Checked = True
                lblFinalSi.BackColor = Color.DarkBlue
                lblFinalSi.ForeColor = Color.White
                lblFinalNo.BackColor = Me.BackColor
                lblFinalNo.ForeColor = Color.DarkBlue
                rbtFinalNo.Checked = False
            End If
        End If
    End Sub

    Private Sub rbtFinalNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SessionUser._sCentro.Trim <> "A001" Then
            If rbtFinalNo.Checked = False Then
                rbtFinalNo.Checked = True
                lblFinalNo.BackColor = Color.DarkBlue
                lblFinalNo.ForeColor = Color.White
                lblFinalSi.BackColor = Me.BackColor
                lblFinalSi.ForeColor = Color.DarkBlue
                rbtFinalSi.Checked = False
            End If
        End If
    End Sub

    Private Sub btnLookcausa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookcausa.Click
        Q = "SELECT C_Causa,D_Causa FROM CatCausas_Amex  "
        Q = Q & "Where Centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & "And T_Causa = 'SP' "
        Q = Q & "And Area = 'EXT' "
        Q = Q & "And St = 'A' "
        frmSpro.SPRO_TITULO = "Catalogo de Causas Sobrepeso"
        frmSpro.SPRO_SQL = Q
        frmSpro.SPRO_OK = 0
        frmSpro.SPRO_COLKEY = 0
        frmSpro.SPRO_KEY = ""
        frmSpro.SPRO_LIKE = "Descausagrupa"
        frmSpro.ShowDialog()
        If frmSpro.SPRO_OK = 1 Then
            TCausas.Text = frmSpro.SPRO_KEY
            Q = " SELECT D_Causa FROM CatCausas_Amex "
            Q = Q & " WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
            Q = Q & " AND C_Causa = '" & TCausas.Text & "' "
            Desccausa.Text = TraeDescripcion(Q)
            frmSpro.SPRO_OK = 0
        End If
    End Sub

    Private Sub TCausas_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCausas.Enter
        TCausas.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TCausas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TCausas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TCausas_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCausas.Leave
        Q = "SELECT D_Causa FROM CatCausas_Amex "
        Q = Q & "WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & "And C_Causa = '" & TCausas.Text.Trim & "' "
        Q = Q & "And T_Causa = 'SP' "
        Q = Q & "And Area = 'EXT' "
        Q = Q & "And St = 'A' "
        Desccausa.Text = TraeDescripcion(Q)
        If Desccausa.Text.Trim = "" Then
            MsgBox("Causa Inexistente")
            TCausas.Text = ""
            Desccausa.Text = ""
            Return
        End If
        TCausas.BackColor = Color.White
    End Sub

    Private Sub TPesoRack_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = txtNumerico(TRack, e.KeyChar, True)
    End Sub
    Private Sub ReportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem.Click
        Modulo = "PT"
        EXTINY = "1"
        'FrmIMP_PT_AMEX.ShowDialog()
        FrmIMP_PT.ShowDialog()
    End Sub

    Private Sub MenuPET_AMEX_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        EXTINY = ""
    End Sub

    Private Sub TCodTinta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub TCveOpe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub NotificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotificacionesToolStripMenuItem.Click
        EXTINY = "1"
        FrmConsultaPesajes.Show()
    End Sub

    Private Sub SobrepesosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobrepesosToolStripMenuItem.Click
        Permiso.Accesos("MP_CON_SP", "1", SessionUser._sIdPerfil, "E", "Consulta Sobre / Bajo Pesos ")
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Close()
    End Sub

End Class