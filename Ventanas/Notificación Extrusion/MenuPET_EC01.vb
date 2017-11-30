Imports System.IO
Imports System.IO.Ports.SerialPort
Imports System.IO.Ports.SerialDataReceivedEventArgs
Imports System.IO.Ports.SerialPinChangedEventArgs
Imports System.Data.SqlClient
Imports System.Configuration
Imports Atlas.Accesos.CLVarGlobales
Imports Atlas.Accesos
Imports SQL_DATA
Imports Utili_Generales
Public Class MenuPET_EC01

#Region "Variables"
    Dim nvoOrden_Produccion As String
    Dim nvoTramosNoti As Decimal
    Dim nvoFecha_Pesaje As String
    Dim nvoHora_Pesaje As String
    Dim nvoBascula As String
    Dim nvoTipo_SCausa As String
    Dim nvoPeso_Bruto As Decimal
    Dim nvoTara As Decimal
    Dim nvoPeso_Neto As Decimal
    Dim nvoUsuario As String
    Dim nvoPesoTeorico As Decimal
    ' ---------------------------------------------------------------------------------
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
    Dim OrigInf As String = "SAP_R/3"
    Dim CantProgkg As Integer = 333
    ' ---------------------------------------------------------------------------------
    Dim StatusSap As String
    Dim NomTabOp As String
    Dim Message As String = "Tecleé un numero de Orden de Producción"
    Dim Caption As String = "Campo vacio"
    Dim CountValOP As Integer
    Dim Result As DialogResult
    Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
    Dim Botones As MessageBoxButtons = MessageBoxButtons.OK
    Dim VCountProducto As Boolean
    Dim VSumNotificaciones As Integer
    ' ---------------------------------------------------------------------------------
    Dim xAREA As String
    Dim descripcion As String = ""
    Dim CodigoEmpaque As String
    Dim taraempaque As Decimal
    Dim PesoTeorico As Decimal
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
    ' ---------------------------------------------------------------------------------
    Dim PesoBruto As Decimal
    Dim Turno As String
    Dim TurnoNombre As String
    Dim HIni As String
    Dim HFin As String
    Dim FolioSiguiente As String
    Dim reg As String
    ' ---------------------------------------------------------------------------------
    Dim dateRegistro As Date
    Dim FechaTurno As String
    Dim FechaPesaje As String
    Dim FechaPesajeSAP As String
    Dim HoraPesaje As String
    Dim dregistro As String = "0"
    ' ---------------------------------------------------------------------------------
    Dim ContadorRack As Integer
    ' ---------------------------------------------------------------------------------
    Dim strPB As Integer            'Puerto Bascula
    Dim strVP As String = ""        'Velocidad Puerto
    Dim strIP As String = ""        'Interface Puerto
    'Dim Lectura As String
    Dim Tipo As String = Chr(33)
    Dim Bascula As String = ""
    Dim Cadena As String = ""
    Dim Calculo As Decimal
    Dim totaltara As Decimal = 0
    ' ---------------------------------------------------------------------------------
    Dim Lectura As String = ""
    Dim Resultado As String = ""
    Dim Count1 As Integer = 0
    Dim ValCountBasculas As Integer
    ' ---------------------------------------------------------------------------------
    Dim Compuesto_1 As String = ""
    Dim Compuesto_2 As String = ""
    Dim CompuestoPorcent_1 As Integer = 0
    Dim CompuestoPorcent_2 As Integer = 0
    Dim ValControlCompuesto As String
    ' ---------------------------------------------------------------------------------
    Dim ContadorSobrepeso As Integer
    ' ---------------------------------------------------------------------------------
    Dim NumEmpaques As String
    ' ---------------------------------------------------------------------------------
    Dim Lt_Compuestos As String = ""
    Dim CompOriginal As String = ""
    Dim CadenaTexto As String = ""
    ' ---------------------------------------------------------------------------------
    Dim xUSUARIOREG As String
    Dim xFECHAREG As String
    Dim xHORAREG As String
    Dim xTGRUPO As String
    Dim xSPPERMITIDO As String
    ' ---------------------------------------------------------------------------------
    Dim myDataReader As SqlClient.SqlDataReader
    Dim xTabla As String
    Dim Q As String
    Dim tablaEXTINY As String = ""
#End Region

#Region "Eventos"

#End Region

#Region "Metodos"
    Private Sub Asigna_Turno()
        ' ---------------------------------------------------------------------------------
        'Se asigna turno que corresponde acorde al horario
        Dim HReal As String = DateTime.Now.ToString("HH:mm:ss")
        Catalogo_Turnos.Combo_Turnos(cmbTurnos)
        Catalogo_Turnos.Asigna_turno(cmbTurnos, HReal)
    End Sub
#End Region
   

    Private Sub MenuPET_EC01_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        FUERATURNO = 0
    End Sub

    Private Sub MenuPET_EC01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        StrProducto = ""
        TCentro.Text = SessionUser._sCentro.Trim 'Centro 
        '' ---------------------------------------------------------------------------------
        ValPublic_ReproConsumo = 0
        ValPublic_Ccompuesto1 = 0
        ValPublic_Ccompuesto2 = 0
        ValPublic_PorcentajeCom1 = 0
        ValPublic_PorcentajeCom2 = 0
        '' ---------------------------------------------------------------------------------
        LimpiaObjetos()
        ' ---------------------------------------------------------------------------------
        'Se verifica conexión con SAP
        Permiso.SAP_Status("E", tsImagen)
        ' ---------------------------------------------------------------------------------
        'Inicializan fecha Turno y SAP
        Inicializa_Frm_PTEI(dtpFECHA, dtpFECHASAP, chkSAP)
        ' ---------------------------------------------------------------------------------
        Asigna_Turno()
        ' ---------------------------------------------------------------------------------
        TSobrePeso.BackColor = Color.White
    End Sub

    Private Sub TOrden_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TOrden.KeyPress
        e.Handled = txtNumerico(TOrden, e.KeyChar, False)
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
        QRY = " Select Orden_Produccion, Estatus_Activa  FROM  [" & SessionUser._sCentro.Trim & "_OrdenProduccion] "
        QRY = QRY & " WHERE  Orden_Produccion = '" & TOrden.Text.Trim & "'"
        QRY = QRY & "   AND Planta = '" & SessionUser._sCentro.Trim & "'"
        LecturaQry(QRY)
        CountValOP = 0
        OrdenOP = ""
        StatusOP = ""
        If LecturaBD.Read() Then
            CountValOP = CountValOP + 1
            OrdenOP = LecturaBD(0)
            StatusOP = LecturaBD(1)
        End If
        LecturaBD.Close()
        ' ---------------------------------------------------------------------------------
        Select Case CountValOP
            Case Is = 0
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
                Select Case UsrLog
                    Case "ATLAS"
                        Dim lo_wsamancomx As New Read.ZPP001_91Service
                        Dim ls_return As New Read.ZBAPIRET2
                        Dim ls_values As New Read.ZEPP001

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
                        ' ---------------------------------------------------------------------------------
                    Case Is <> "ATLAS"
                        Dim lo_wsamancomx As New Lee_OFP.ZPP001_91Service
                        Dim ls_return As New Lee_OFP.ZBAPIRET2
                        Dim ls_values As New Lee_OFP.ZEPP001

                        lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                        ls_values = lo_wsamancomx.Z_PP001(Me.TOrden.Text.Trim, ls_return)
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
                            xHORAREG = Date.Now.TimeOfDay.ToString
                            xTGRUPO = ""
                            xSPPERMITIDO = ""
                            ' ---------------------------------------------------------------------------------
                            QRY = ""
                            QRY = "SELECT GrupMaterial, Sobrepeso FROM ProductoTerminadoExtrusion "
                            QRY = QRY & " WHERE Centro='" & NumeroPlanta & "' AND Codigo = '" & Producto.Trim & "' "
                            LecturaQry(QRY)
                            ' ---------------------------------------------------------------------------------
                            If LecturaBD.Read() Then
                                xTGRUPO = LecturaBD(0)
                                xSPPERMITIDO = LecturaBD(1)
                                TGrupo.Text = xTGRUPO
                                SP_Permitido.Text = xSPPERMITIDO
                                xCantProgPzs = Replace(CantProgPzs, GDECIMAL, ".")
                                xCantProgkg = Replace(CantProgkg, GDECIMAL, ".")
                            Else
                                CantProgPzs = 0
                                CantProgkg = 0
                                TGrupo.Text = ""
                                SP_Permitido.Text = "0"
                                xCantProgPzs = Replace(CantProgPzs, GDECIMAL, ".")
                                xCantProgkg = Replace(CantProgkg, GDECIMAL, ".")
                            End If

                            xUSUARIOREG = SessionUser._sAlias
                            xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
                            xHORAREG = Date.Now.TimeOfDay.ToString

                            ' ---------------------------------------------------------------------------------
                            InQry = ""
                            InQry = "INSERT INTO [" & SessionUser._sCentro.Trim & "_OrdenProduccion] (Orden_Produccion, Planta, Equipo_Basico, Producto, Cantidad_Programada_Tramos, Cantidad_Programada_Kilos, Fecha_Inicio, Fecha_Termino, Origen_Informacion, Estatus_Activa, Usuario_Actualiza, Fecha_Actualizacion, Observaciones, usuarioreg, fechareg, horareg, GrupMaterial) "
                            InQry = InQry & " VALUES ('" & OrdenProd & "','" & NumeroPlanta & "','" & Equipo & "'," & Producto & "," & xCantProgPzs & "," & xCantProgkg & "," & "'" & fecini & "','" & fecterm & "','" & OrigInf & "'," & Status & ",'" & UsrAct & "','" & FecAct & "','" & Obs.Trim & "','" & xUSUARIOREG.Trim & "','" & xFECHAREG & "','" & xHORAREG & "','" & xTGRUPO.Trim & "')"
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
                Else
                    If StatusOP = "9" Then
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
                    Else
                        If StatusOP = "5" Then
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
                    End If
                End If
                ' ---------------------------------------------------------------------------------
                Select Case UsrLog
                    Case "ATLAS"
                        Dim lo_wsamancomx As New Read.ZPP001_91Service
                        Dim ls_return As New Read.ZBAPIRET2
                        Dim ls_values As New Read.ZEPP001

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
                    Case Is <> "ATLAS"
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
                ' ---------------------------------------------------------------------------------
                If Err = "E" Then
                    MessageBox.Show(Mns, "Error SAP Notifique al Supervisor")
                    Me.TClaveOperador.Focus()
                    Return
                End If
                ' ---------------------------------------------------------------------------------
                Select Case Status1
                    Case Is <> "LIB."
                        If Status1 = "CTEC" Then
                            Message = " La Orden tiene CIERRE TECNICO ( - SAP - ), Desea continuar con otra Orden?  "
                            Caption = "Orden con CIERRE TECNICO - SAP"
                        Else
                            Message = " La Orden no se encuentra LIBERADA ( - SAP - ), Desea continuar con otra Orden?  "
                            Caption = "Orden no LIBERADA - SAP"
                        End If
                        Result = MessageBox.Show(Message, Caption, Botones, MessageBoxIcon.Error)
                        If Result = System.Windows.Forms.DialogResult.OK Then
                            Me.TOrden.Text = ""
                            Me.TOrden.Focus()
                            Exit Sub
                        End If
                    Case Is = "LIB."
                        ' ----------------------------------------- Si la orden existe en Atlas verificar que el producto a fabricar tambien exista.
                        QRY = ""
                        QRY = "SELECT PTE.Grpprod, PTE.Descr, PTE.Empaque, PTE.PesoTeorico, OP.Estatus_Activa, PTE.Codigo, "
                        QRY = QRY & " OP.cantidad_programada_tramos, OP.Equipo_Basico, OP.GrupMaterial, PTE.Sobrepeso "
                        QRY = QRY & " FROM [" & SessionUser._sCentro.Trim & "_OrdenProduccion] OP, " & tablaEXTINY & " PTE "
                        QRY = QRY & " WHERE PTE.Codigo = OP.Producto "
                        QRY = QRY & " AND PTE.Centro = OP.Planta "
                        QRY = QRY & " AND OP.Orden_Produccion = '" & Me.TOrden.Text.Trim & "' "
                        QRY = QRY & " AND OP.Planta = '" & SessionUser._sCentro.Trim & "' And OP.Estatus_Activa = 1"
                        LecturaQry(QRY)
                        VCountProducto = LecturaBD.HasRows
                        Select Case VCountProducto 'Case Para Identificar Sí el producto  y el Compuesto  Existen en la BD - True 
                            Case True
                                If LecturaBD.Read() Then
                                    xAREA = "" & LecturaBD(0)    'Descripción del PT
                                    descripcion = "" & LecturaBD(1)    'Descripción del PT
                                    CodigoEmpaque = "" & LecturaBD(2)  'Código del empaque 
                                    PesoTeorico = "" & LecturaBD(3)    ' Peso Teórico ( Calculo de Sobrepeso )
                                    EstatusActiva = "" & LecturaBD(4)
                                    StrProducto = "" & LecturaBD(5)    'Código PT
                                    StrTramos = "" & LecturaBD(6)      'Cantidad Programada 
                                    EqpBasico = "" & LecturaBD(7)
                                    grpMaterial = "" & LecturaBD(8)
                                    sobrePESO = "" & LecturaBD(9)
                                    WorkCenter = "" & UCase(EqpBasico)
                                End If
                                LecturaBD.Close()
                                ' ---------------------------------------------------------------------------------
                                Calcula_Cantidades()

                                TGrpprod.Text = xAREA.Trim
                                Q = " SELECT desgrupo FROM catgrupos  "
                                Q = Q & " WHERE centro = '" & SessionUser._sCentro.Trim & "' "
                                Q = Q & "   AND grpprod = '" & TGrpprod.Text.Trim & "' "
                                Q = Q & "   AND status = 'A'"
                                TGrpproddesc.Text = TraeDescripcion(Q)

                                TPtoTrabajo.Text = EqpBasico.Trim
                                Q = " SELECT Descripcion FROM MCPC_EquipoBasico "
                                Q = Q & " WHERE planta = '" & SessionUser._sCentro.Trim & "' "
                                Q = Q & " AND rtrim(Equipo_basico) = '" & TPtoTrabajo.Text.Trim & "'"
                                TNomPtoTrabajo.Text = TraeDescripcion(Q)

                                TGrupo.Text = grpMaterial.Trim
                                SP_Permitido.Text = sobrePESO.Trim
                                ValControlCompuesto = ""
                                ' ---------------------------------------------------------------------------------
                                QRY = ""
                                QRY = " Select ValCompuesto From " & tablaEXTINY & " Where Centro = '" & SessionUser._sCentro.Trim & "' And Codigo = '" & StrProducto.Trim & "'"
                                LecturaQry(QRY)
                                Do While (LecturaBD.Read())
                                    ValControlCompuesto = LecturaBD(0)
                                Loop
                                LecturaBD.Close()
                                ' ---------------------------------------------------------------------------------
                                CheckBox1.Checked = False
                                If Val(ValControlCompuesto.Trim) = 0 Then
                                    BCompuesto.Enabled = False
                                Else
                                    BCompuesto.Enabled = True
                                End If
                                BPesar.Enabled = True

                                If Val(CodigoEmpaque.Trim) > 0 Then
                                    taraempaque = 0
                                    ' ---------------------------------------------------------------------------------
                                    QRY = ""
                                    QRY = " Select Peso from Empaques_PTE where Centro = '" & SessionUser._sCentro.Trim & "' And CodEmp = '" & CodigoEmpaque.Trim & "'"
                                    LecturaQry(QRY)
                                    If LecturaBD.Read() Then
                                        taraempaque = LecturaBD(0)    'Peso Unitario del Empaque
                                    End If
                                    LecturaBD.Close()
                                    NumEmpaques = TtramosNoti.Text.Trim
                                Else
                                    taraempaque = 0
                                    NumEmpaques = 0
                                End If
                                'TCantProgra.Text = Format(Val(StrTramos.Trim), "####")     'Cantidad Programada 
                                'TCompOrig.Text = StrCompuesto.Trim  'Código Compuesto
                                TCodPT.Text = StrProducto.Trim   'Código PT
                                TCodPtDecr.Text = descripcion.Trim   'Descripción del PT
                                TPtoTrabajo.Text = EqpBasico.Trim  'Puesto de Trabajo
                                TPesoTeorico.Text = PesoTeorico.ToString.Trim  'Peso Teorico
                                Tempaque.Text = taraempaque.ToString.Trim 'Peso Unitario del Empaque

                                '' ----------------------------------------- Búsqueda de notificaciones para la OP
                                'QRY = "Select Count ( * ) Count from " & strPlanta.Trim & "_PesoProductoTerminado Where "
                                'QRY = QRY & " Orden_produccion = '" & Me.TOrden.Text.Trim & "'"
                                'QRY = QRY & " And Planta = '" & strPlanta.Trim & "'"
                                'LecturaQry(QRY)
                                'Do While (LecturaBD.Read())
                                '    VSumNotificaciones = LecturaBD(0)
                                'Loop
                                'Select Case VSumNotificaciones 'Verifica los Tramos ya notificados en SAP
                                '    Case Is > 0 'Verifica los Tramos ya notificados en SAP -- True
                                '        QRY = "Select Sum ( Tramos ) from  " & strPlanta.Trim & "_PesoProductoTerminado Where "
                                '        QRY = QRY & " Orden_produccion = '" & Me.TOrden.Text.Trim & "'"
                                '        QRY = QRY & " And Planta = '" & strPlanta.Trim & "'"
                                '        LecturaQry(QRY)
                                '        Do While (LecturaBD.Read())
                                '            CantEntregada = LecturaBD(0)
                                '        Loop
                                '        LecturaBD.Close()
                                '        TCantEntre.Text = CantEntregada.Trim
                                '        TCantPendiente.Text = Format(Val(TCantProgra.Text) - Val(TCantEntre.Text), "####")
                                '    Case Is = 0 'Verifica los Tramos ya notificados en SAP -- False
                                '        TCantEntre.Text = 0
                                '        TCantPendiente.Text = 0
                                'End Select


                            Case False  'Case Para Identificar Sí el producto  y el Compuesto  Existen en la BD - False
                                MessageBox.Show("No existe Producto en A-tlas para esta Orden ó la orden ya fue cerrada, Informe al Supervisor", " VENTANA DE ERROR * * * ")
                        End Select 'Case Para Identificar Sí el producto  y el Compuesto  Existen en la BD - True
                End Select
        End Select 'Case: Búsqueda de OF en BD ATLAS
        BPesar.Enabled = True
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
        'Qfup = " SELECT  PTYS.Orden_Produccion, OP.Cantidad_Programada_Tramos, SUM(PTYS.PRODUCCION), SUM(PTYS.SEPARADA), (OP.Cantidad_Programada_Tramos-(SUM(PTYS.PRODUCCION)+SUM(PTYS.SEPARADA))) "
        'Qfup = Qfup & " FROM (((sELECT planta, Orden_Produccion, PuestoTrabajo, 'PRODUCCION' as tipoprod, Notifica, notificacionmasiva, tramos as PRODUCCION, 0 as SEPARADA "
        'Qfup = Qfup & "  FROM [" & strPlanta.Trim & "_PesoProductoTerminado] WHERE tramos<>0 AND notifica in ('0','1','4')) "
        'Qfup = Qfup & " UNION ALL (sELECT planta, Orden_Produccion, PuestoTrabajo, 'EN PROCESO' as tipoprod, Notifica, notificacionmasiva, 0 as PRODUCCION, tramos as SEPARADA "
        'Qfup = Qfup & " FROM [" & strPlanta.Trim & "_PesoProductoTerminado] WHERE tramos<>0 AND notifica in ('3'))) PTYS "
        'Qfup = Qfup & " INNER JOIN [" & strPlanta.Trim & "_OrdenProduccion] OP ON PTYS.Orden_Produccion = OP.Orden_Produccion) "
        'Qfup = Qfup & "	INNER JOIN MCPC_EquipoBasico EB ON PTYS.planta = EB.Planta AND PTYS.PuestoTrabajo = EB.Equipo_basico "
        'Qfup = Qfup & " INNER JOIN " & tablaEXTINY & " PTE ON  PTE.CENTRO= PTYS.PLANTA and PTE.Codigo = OP.Producto "
        'Qfup = Qfup & " WHERE PTYS.planta= '" & strPlanta.Trim & "'"
        'Qfup = Qfup & " AND PTYS.notifica <> '9' "
        'Qfup = Qfup & " AND PTYS.Orden_Produccion = '" & TOrden.Text.Trim & "'"
        'Qfup = Qfup & " GROUP BY PTYS.Orden_Produccion, OP.Cantidad_Programada_Tramos "
        'xFechaUltpesaje = ""
        Try
            'LecturaQry(Qfup)
            regupdate = 0
            If LecturaBD.Read() Then
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
        TOrden.Text = ""  'Orden Producción
        TtramosNoti.Text = "" 'Tramos por Notificar
        TRack.Text = "" 'Rack
        TPesoRack.Text = "0" 'Peso Rack
        Descrack.Text = "" 'Peso Rack
        TCodPT.Text = ""  'Código Material
        SP_Permitido.Text = ""
        TGrupo.Text = ""  'Descripción GRUPO Material
        TCodPtDecr.Text = ""  'Descripción Material
        TGrpprod.Text = "" ' Codigo grupo produccion
        TGrpproddesc.Text = "" ' Descripcion grupo´produccion
        TPtoTrabajo.Text = "" 'Puesto de Trabajo
        TPesoTeorico.Text = "" ' Peso Teorico
        Tempaque.Text = ""    'Peso Unitario de empaques
        TempaquePesoTot.Text = ""  'Peso Total de empaques
        ' ---------------------------------------------------------------------------------
        TPesoCaptura.Text = "00" & GDECIMAL & "00" 'Peso Bruto Manual
        ' ---------------------------------------------------------------------------------
        TCantProgra.Text = "" 'Programada
        TCantEntre.Text = "" 'Entregada
        TCantEnproce.Text = "" 'Entregada
        TCantPendiente.Text = "" 'Pendiente
        ' ---------------------------------------------------------------------------------
        TFolioAtlas.Text = ""   'Folio ATLAS
        TNumNoti.Text = ""  'Número Notificación
        TConsNoti.Text = ""  'Consecutivo Notificación
        CheckBox1.Checked = False
        TCodOperador.Text = ""
        TNomOperador.Text = ""
        TNomPtoTrabajo.Text = ""
        BCompuesto.Enabled = False
        TCausas.Text = ""
        Desccausa.Text = ""
        ' ---------------------------------------------------------------------------------
        If FUERATURNO = 0 Then
            dateRegistro = Today()
            dtpFECHA.Value = Date.Today.ToString("yyyy-MM-dd")
            dtpFECHASAP.Value = Date.Today.ToString("yyyy-MM-dd")
            ' ---------------------------------------------------------------------------------
            QRY_AMD = ""
            QRY_AMD = " Select TT.Turno, TT.Descripcion, Convert(char(8),TT.Hora_Inicio,108) as Hora_Inicio, "
            QRY_AMD = QRY_AMD & " Convert(char(8),TT.Hora_Terminacion,108) as Hora_Terminacion, TT.registro "
            QRY_AMD = QRY_AMD & " FROM ADM_Turno TT INNER JOIN ADM_CambioHora CH ON TT.Planta=CH.Planta "
            QRY_AMD = QRY_AMD & " AND Convert(char(10), getdate(),102)between Convert(char(10), CH.Fecha_Inicio,102) AND Convert(char(10),CH.fecha_Terminacion,102) "
            QRY_AMD = QRY_AMD & " WHERE Convert(char(8), getdate()+(CH.CHora/24),108) between Convert(char(8), Hora_Inicio,108) "
            QRY_AMD = QRY_AMD & " AND Convert(char(8),Hora_Terminacion,108) and TT.Planta='" & SessionUser._sCentro.Trim & "' "
            LecturaQry_AMD(QRY_AMD)
            Turno = "1"
            If LecturaBD_AMD.Read() Then
                Turno = LecturaBD_AMD(0)
                dateRegistro = DateAdd(DateInterval.Day, -Val(LecturaBD_AMD(4)), dateRegistro)
            End If
            LecturaBD_AMD.Close()
            ' ---------------------------------------------------------------------------------
        End If
        ' ---------------------------------------------------------------------------------
        BPesar.Enabled = False
        BImprimir.Enabled = False
        rbtFinalSi.Checked = False
        rbtFinalNo.Checked = False
        lblFinalSi.BackColor = Me.BackColor
        lblFinalSi.ForeColor = Color.DarkBlue
        lblFinalNo.BackColor = Me.BackColor
        lblFinalNo.ForeColor = Color.DarkBlue
        TOrden.Enabled = True
    End Sub

    Private Sub TRack_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRack.Leave
        If Val(TRack.Text.Trim.Length) > 0 Then
            ' ---------------------------------------------------------------------------------
            QRY = ""
            QRY = " SELECT descripcion, tara FROM Racks "
            QRY = QRY & " WHERE Centro = '" & SessionUser._sCentro.Trim & "'"
            QRY = QRY & " AND rtrim(Rack) = '" & TRack.Text.Trim & "'"
            LecturaQry(QRY)
            If LecturaBD.Read() Then
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
        TRack.BackColor = Color.White
    End Sub

    Private Sub BPesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPesar.Click
        'Dim TipoNotificacion As Char = "0"
        'Forma = "Extrusion"
        'If TClaveOperador.Text = "" Then
        '    MessageBox.Show("***  Tecleé codigo de operador  *** ", " VENTANA DE ERROR * * * ")
        '    TClaveOperador.Focus()
        '    Exit Sub
        'End If
        '' ------------------------   Validacion Orden   
        'If TOrden.Text = "" Then
        '    MessageBox.Show("***  Tecleé la Orden de Producción  *** ", " VENTANA DE ERROR * * * ")
        '    TOrden.Focus()
        '    Exit Sub
        'End If
        '' ------------------------   Validacion Tramos   
        'If TtramosNoti.Text = "" Then
        '    MessageBox.Show("***  Tecleé el Número de Tramos  *** ", " VENTANA DE ERROR * * * ")
        '    TtramosNoti.Focus()
        '    Exit Sub
        '    ' ----------------------- Validacion puesto de trabajo
        'End If
        'If TPtoTrabajo.Text = "" Then
        '    MessageBox.Show("***  No hay puesto de trabajo, comuniquese con el Supervisor  *** ", " VENTANA DE ERROR * * * ")
        '    'TPtoTrabajo.Focus()
        '    Exit Sub
        'End If
        '' ----------------------- Validacion peso en Bascula
        'If (Val(TPesoNeto.Text) <= 0) Then
        '    MessageBox.Show("***  Coloque algo sobre la báscula  *** ", " VENTANA DE ERROR * * * ")
        '    Exit Sub
        'End If
        '' ----------------------- Validacion peso en Bascula
        'If (Val(TPesoBruto.Text) < Val(TPesoTara.Text)) Then
        '    MessageBox.Show("***  El Peso Bruto debe ser mayor que La Tara  *** ", " VENTANA DE ERROR * * * ")
        '    Exit Sub
        'End If
        '' ----------------------- Inicio : Status de Conexión
        'Try
        '    AbrirConfiguracion()
        '    If objCnn.State <> ConnectionState.Open Then
        '        objCnn.Open()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Exit Sub
        'End Try
        '' ----------------------- Inicio: Identificación del comunicación A-TLAS Vs. SAP 
        'QRY_AMD = ""
        'QRY_AMD = "Select ADM_StatusSAP.Planta, ADM_StatusSAP.Status"
        'QRY_AMD = QRY_AMD & "  FROM ADM_StatusSAP WHERE Planta='" & strPlanta.Trim & "'"

        'Try
        '    LecturaQry_AMD(QRY_AMD)
        '    Do While (LecturaBD_AMD.Read)
        '        StatusSap = LecturaBD_AMD("Status")
        '    Loop
        '    LecturaBD_AMD.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Exit Sub
        'End Try
        '' -----------------------  Se verifica el producto para determinar cual es el compuesto virgen que le corresponde
        'If Val(ValControlCompuesto.Trim) = 0 Or CheckBox1.Checked = False Then
        '    Compuesto_1 = "0"
        '    CompuestoPorcent_1 = 100
        '    Compuesto_2 = "0"
        '    CompuestoPorcent_2 = 0
        '    Lt_Compuestos = ""
        'Else
        '    Dim Count As Integer = 0
        '    QRY = ""
        '    QRY = "select b.ComExt_ComCodigo from productoterminadoextrusion a, CompuestoExtrusion b "
        '    QRY = QRY & "where a.centro = b.ComExt_PT_Centro "
        '    QRY = QRY & "and a.codigo = b.ComExt_PT_Codigo "
        '    QRY = QRY & "and a.centro = '" & strPlanta.Trim & "' "
        '    QRY = QRY & "and a.codigo = '" & TCodPT.Text.Trim & "' "
        '    QRY = QRY & "and b.bom = '1' "
        '    Try
        '        LecturaQry(QRY)
        '    Do While (LecturaBD.Read())
        '            Count = Count + 1
        '            CompOriginal = LecturaBD(0)
        '        Loop
        '        LecturaBD.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        Exit Sub
        '    End Try
        '    If Count = 0 Then
        '        MessageBox.Show(" No Existe compuesto definido como parte de la Bom para este Producto no se puede notificar esta orden ", " VENTANA DE ERROR * * * ")
        '        Return
        '    End If
        '    If ValPublic_ReproConsumo.Trim.Length > 0 Then
        '        Compuesto_1 = ValPublic_ReproConsumo.Trim
        '        CompuestoPorcent_1 = 100
        '        Compuesto_2 = "0"
        '        CompuestoPorcent_2 = 0
        '        Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1
        '    End If
        'End If

        '' ----------------------- < Work Center 

        ''If WorkCenter.Trim <> EqpBasico.Trim Then
        ''    InQry = ""
        ''    InQry = "Update " & strPlanta.Trim & "_OrdenProduccion Set Equipo_basico = '" & UCase(WorkCenter.Trim) & "'"
        ''    InQry = InQry & " where "
        ''    InQry = InQry & " Planta = '" & strPlanta.Trim & "' And Orden_Produccion = '" & TOrden.Text.Trim & "'"
        ''    InsertQry(InQry)
        ''End If

        '' ----------------------- DEFINICION FUERA DE TURNO
        'If FUERATURNO = 0 Then
        '    ' ----------------------- Fecha y Hora Pesaje 
        '    dateRegistro = Today()
        '    FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        '    HoraPesaje = Date.Now.TimeOfDay.ToString
        '    FechaTurno = FechaPesaje
        '    ' ----------------------- Determinación de Turnos 
        '    QRY_AMD = ""
        '    QRY_AMD = " Select TT.Turno, TT.Descripcion, Convert(char(8),TT.Hora_Inicio,108) as Hora_Inicio, "
        '    QRY_AMD = QRY_AMD & " Convert(char(8),TT.Hora_Terminacion,108) as Hora_Terminacion, TT.registro "
        '    QRY_AMD = QRY_AMD & " FROM ADM_Turno TT INNER JOIN ADM_CambioHora CH ON TT.Planta=CH.Planta "
        '    QRY_AMD = QRY_AMD & " AND Convert(char(10), getdate(),102)between Convert(char(10), CH.Fecha_Inicio,102) AND Convert(char(10),CH.fecha_Terminacion,102) "
        '    QRY_AMD = QRY_AMD & " WHERE Convert(char(8), getdate()+(CH.CHora/24),108) between Convert(char(8), Hora_Inicio,108) "
        '    QRY_AMD = QRY_AMD & " AND Convert(char(8),Hora_Terminacion,108) and TT.Planta='" & strPlanta.Trim & "' "
        '    Try
        '        LecturaQry_AMD(QRY_AMD)
        '        Turno = "1"
        '        Do While (LecturaBD_AMD.Read)
        '            Turno = LecturaBD_AMD(0)
        '            dateRegistro = DateAdd(DateInterval.Day, -Val(LecturaBD_AMD(4)), dateRegistro)
        '        Loop
        '        FechaTurno = dateRegistro.ToString("yyyy-MM-dd")
        '        LecturaQry_AMD.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        Exit Sub
        '    End Try
        '    If ValFiltroSeleccionCodigo.Trim = "0" Then
        '        ValFiltroSeleccionCodigo = "0"
        '    End If
        'Else
        '    FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        '    HoraPesaje = Date.Now.TimeOfDay.ToString
        '    FechaTurno = dtpFECHA.Value.ToString("yyyy-MM-dd")
        '    Turno = cmbTurnos.Text.Trim
        'End If

        '' ----------------------- Inicio Obtener Folio

        'FolioSiguiente = ""
        'QRY = ""
        'QRY = "Select Max(Producto_Terminado)+1 as folioSiguiente from MCPC_Foliador where  "
        'QRY = QRY & " Planta='" & strPlanta.Trim & "'"
        'Try
        '    LecturaQry(QRY)
        '    Do While (LecturaBD.Read)
        '        FolioSiguiente = LecturaBD(0)
        '    Loop
        '    LecturaBD.Close()
        '    InQry = ""
        '    InQry = "Update MCPC_Foliador set Producto_Terminado = '" & FolioSiguiente.Trim & "'"
        '    InQry = InQry & " where "
        '    InQry = InQry & " Planta = '" & strPlanta.Trim & "'"
        '    InsertQry(InQry)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Exit Sub
        'End Try

        '' -----------------------  Determinacion de la Cdena Texto

        'FolioSiguiente = FolioSiguiente.Trim
        'FolioSiguiente = Mid("00000000", 1, 8 - Len(FolioSiguiente)) & FolioSiguiente.Trim

        '' ----------------------- Sobrepeso
        'TipoNotificacion = "0"

        'RTOrden = TOrden.Text.Trim
        'RFechaPesaje = FechaPesaje.Trim
        'RHoraPesaje = HoraPesaje.Trim
        'RValCodigoBascula = ValCodigoBascula.Trim
        'RTRack = TRack.Text.Trim
        'RTtramosNoti = TtramosNoti.Text.Trim
        'RNumEmpaques = NumEmpaques
        'RTPesoBruto = TPesoBruto.Text.Trim
        'RTPesoTara = TPesoTara.Text.Trim
        'RTPesoNeto = TPesoNeto.Text.Trim
        'RTCodOperador = TCodOperador.Text.Trim
        'RTurno = Turno.Trim
        'RFolioSiguiente = FolioSiguiente.Trim
        'RTSobrePeso = TSobrePeso.Text.Trim
        'RTCausas = TCausas.Text.Trim
        'RCompuesto_1 = Compuesto_1.Trim
        'RCompuestoPorcent_1 = CompuestoPorcent_1
        'RCompuesto_2 = Compuesto_2.Trim
        'RCompuestoPorcent_2 = CompuestoPorcent_2
        'RFechaTurno = FechaTurno.Trim
        'RWorkCenter = WorkCenter.Trim
        'RTPesoTeorico = Me.TPesoTeorico.Text.Trim
        'RTNumNoti = "0000000000"
        'RTConsNoti = "00000000"

        'If rbtFinalNo.Checked = True Then
        '    '            ProcesoSeparada()
        '    AutorizaSobrepeso = 2
        '    SuperAutoSobrepeso = "S/N"
        '    ObserSobrepeso = ""
        '    If NumEmpaques = "" Then
        '        NumEmpaques = "0"
        '    End If
        '    ObserSobrepeso = ""
        '    InQry = ""
        '    InQry = "INSERT INTO MCPT_AutorizacionSeparada (Orden_produccion, Fecha_Pesaje, Hora_Pesaje, Bascula, Rack, Tramos, Empaques, Peso_Bruto, Tara, Peso_Neto, Usuario, Turno, Supervisor, Planta, Folio, Autoriza_Calidad, Recibe_Almacen, Autoriza_separada, Estatus_Autorizacion, Observaciones ,Porscrap, Causascrap, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos,Fecha_turno, puestotrabajo)"
        '    InQry = InQry & " Values ( '" & RTOrden & "' , '" & RFechaPesaje & "' , '" & RHoraPesaje & "','" & RValCodigoBascula & "' , '" & RTRack & "' , " & RTtramosNoti & " , " & RNumEmpaques & " , " & RTPesoBruto & " , "
        '    InQry = InQry & RTPesoTara & " , " & RTPesoNeto & " , '" & RTCodOperador & "' , " & RTurno & " , '" & SuperAutoSobrepeso.Trim & "', '" & strPlanta.Trim & "', '" & RFolioSiguiente & "' , '" & "S/N" & " ','" & "S/N" & "','" & SuperAutoSobrepeso.Trim & "','" & 0 & "','" & ObserSobrepeso.Trim & "','" & RTSobrePeso & "'"
        '    InQry = InQry & ",'9999','" & RCompuesto_1 & "'," & RCompuestoPorcent_1 & ",'" & RCompuesto_2 & "'," & RCompuestoPorcent_2 & ",'" & Lt_Compuestos & "','" & RFechaTurno & "','" & RWorkCenter & "')"
        '    Try
        '        InsertQry(InQry)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        Exit Sub
        '    End Try
        '    TipoNotificacion = "3"
        'End If



        'RTNumNoti = "0000000000"
        'RTConsNoti = "00000000"

        'If chkSAP.Checked = False Then
        '    TipoNotificacion = "4"
        '    InQry = ""
        '    InQry = "INSERT INTO " & strPlanta.Trim & "_PesoProductoTerminado (Orden_Produccion,Fecha_Pesaje,"
        '    InQry = InQry & "Hora_Pesaje, Bascula, Rack, Peso_Bruto, Tara, Peso_Neto, Empaques, Tramos,"
        '    InQry = InQry & "Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,Recibe_Almacen,Fecha_Turno,"
        '    InQry = InQry & "Documento_SAP,Consecutivo_SAP, Compuesto1, Notifica, notificacionmasiva,"
        '    InQry = InQry & "Porcentaje1,Compuesto2,Porcentaje2,PackID,EmbalajeInyeccion,Sobrepeso,CausaSobrepeso,PuestoTrabajo,LTCompuestos, Peso_Teorico) Values ("
        '    InQry = InQry & "'" & RTOrden & "','" & RFechaPesaje & "','" & RHoraPesaje & "','" & RValCodigoBascula & "','" & RTRack & "', "
        '    InQry = InQry & RTPesoBruto & "," & RTPesoTara & "," & RTPesoNeto & "," & RTtramosNoti & "," & RTtramosNoti & ", "
        '    InQry = InQry & "'" & RTCodOperador & "','" & RTurno & "','" & SuperAutoSobrepeso.Trim & "','" & strPlanta.Trim & "','" & RFolioSiguiente & "','SB','S/N','" & RFechaTurno & "', "
        '    InQry = InQry & "'" & RTNumNoti & "','" & RTConsNoti & "','" & RCompuesto_1 & "','" & TipoNotificacion & "','0'," & RCompuestoPorcent_1 & ",'" & RCompuesto_2 & "'," & RCompuestoPorcent_2
        '    InQry = InQry & ",'" & RFolioSiguiente & "','0'," & RTSobrePeso & ",'" & RTCausas & "','" & RWorkCenter & "','" & Lt_Compuestos & "'," & RTPesoTeorico & ") "
        '    Try
        '        InsertQry(InQry)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        Exit Sub
        '    End Try
        '    TFolioAtlas.Text = FolioSiguiente
        '    Mensajes("Registros Actualizados : " & InsertBD, 0)
        '    BPesar.Enabled = False
        '    BImprimir.Enabled = True
        '    TOrden.Enabled = False
        '    SuperAutoSobrepeso = ""
        '    '------------------------------------------------------------------------------------- PackID
        '    xORIGINAL = ""
        '    imprimir_PT()
        '    '------------------------------------------------------------------------------------- PackID
        'Else
        '    InQry = ""
        '    InQry = "INSERT INTO " & strPlanta.Trim & "_PesoProductoTerminado (Orden_Produccion,Fecha_Pesaje,"
        '    InQry = InQry & "Hora_Pesaje, Bascula, Rack, Peso_Bruto, Tara, Peso_Neto, Empaques, Tramos,"
        '    InQry = InQry & "Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,Recibe_Almacen,Fecha_Turno,"
        '    InQry = InQry & "Documento_SAP,Consecutivo_SAP, Compuesto1, Notifica, notificacionmasiva,"
        '    InQry = InQry & "Porcentaje1,Compuesto2,Porcentaje2,PackID,EmbalajeInyeccion,Sobrepeso,CausaSobrepeso,PuestoTrabajo,LTCompuestos, Peso_Teorico) Values ("
        '    InQry = InQry & "'" & RTOrden & "','" & RFechaPesaje & "','" & RHoraPesaje & "','" & RValCodigoBascula & "','" & RTRack & "', "
        '    InQry = InQry & RTPesoBruto & "," & RTPesoTara & "," & RTPesoNeto & "," & RTtramosNoti & "," & RTtramosNoti & ",'"
        '    InQry = InQry & RTCodOperador & "','" & RTurno & "','" & SuperAutoSobrepeso.Trim & "','" & strPlanta.Trim & "','" & RFolioSiguiente & "','SB','S/N','" & RFechaTurno & "',"
        '    InQry = InQry & "'" & RTNumNoti & "','" & RTConsNoti & "','" & RCompuesto_1 & "','" & TipoNotificacion & "','0'," & RCompuestoPorcent_1 & ",'" & RCompuesto_2 & "'," & RCompuestoPorcent_2
        '    InQry = InQry & ",'" & RFolioSiguiente & "','0'," & RTSobrePeso & ",'" & RTCausas & "','" & RWorkCenter & "','" & Lt_Compuestos & "'," & RTPesoTeorico & ") "
        '    Try
        '        InsertQry(InQry)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        Exit Sub
        '    End Try
        '    TFolioAtlas.Text = FolioSiguiente
        '    Mensajes("Registros Actualizados : " & InsertBD, 0)
        '    BPesar.Enabled = False
        '    BImprimir.Enabled = True
        '    TOrden.Enabled = False
        '    SuperAutoSobrepeso = ""
        '    '------------------------------------------------------------------------------------- PackID
        '    xORIGINAL = ""
        '    imprimir_PT()
        '    '------------------------------------------------------------------------------------- PackID

        '    AutorizaSobrepeso = 0
        '    SobrePeso(RTPesoTeorico, RTtramosNoti, RTPesoNeto, StrProducto.Trim, RTOrden)
        '    TSobrePeso.Text = Format(PorcentajeSobrePeso, "#0.00")
        '    If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
        '        While TCausas.Text = ""
        '            CausaSobrepeso()
        '        End While
        '        FormSobrePesoPE01.Label1.ForeColor = Color.RoyalBlue
        '        FormSobrePesoPE01.Label2.ForeColor = Color.RoyalBlue
        '        FormSobrePesoPE01.Label1.Text = "El pesaje  se  encuentra fuera de rango. "
        '        FormSobrePesoPE01.Label2.Text = "Por lo tanto se necesita  la autorización del supervisor en turno."
        '        FormSobrePesoPE01.ShowDialog()
        '    End If

        '    If AutorizaSobrepeso > 0 Then
        '        If AutorizaSobrepeso = 2 Then  ' ----------------------------------------- " NO " Autoriza Supervisor
        '            If NumEmpaques.Trim = "" Then
        '                NumEmpaques = "0"
        '            End If

        '            InQry = ""
        '            InQry = "INSERT INTO MCPT_AutorizacionSobrepeso (Orden_produccion, Fecha_Pesaje, Hora_Pesaje, Bascula, Rack, Tramos, Empaques, Peso_Bruto, Tara, Peso_Neto, Usuario, Turno, Supervisor, Planta, Folio, Autoriza_Calidad, Recibe_Almacen, Autoriza_Sobrepeso, Estatus_Autorizacion, Observaciones ,PorSobrePeso,CausasSobrepeso,Compuesto1,Porcentaje1,Compuesto2,Porcentaje2, LTCompuestos, Fecha_turno, Puestotrabajo )"
        '            InQry = InQry & " Values ('" & TOrden.Text.Trim & "','" & FechaPesaje.Trim & "','" & HoraPesaje.Trim & "','" & ValCodigoBascula.Trim & "','" & TPesoRack.Text.Trim & "','" & TtramosNoti.Text.Trim & "','" & NumEmpaques & "','" & TPesoBruto.Text.Trim & "' , "
        '            InQry = InQry & "'" & TPesoTara.Text.Trim & "','" & TPesoNeto.Text.Trim & "','" & TCodOperador.Text.Trim & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "','" & strPlanta.Trim & "','" & FolioSiguiente.Trim & " ','" & "S/N" & " ',' " & "S/N" & "','" & SuperAutoSobrepeso.Trim & "','0','" & ObserSobrepeso.Trim & "','" & TSobrePeso.Text.Trim & "'"
        '            InQry = InQry & ",'" & TCausas.Text.Trim & "','" & Compuesto_1.Trim & "','" & CompuestoPorcent_1 & "','" & Compuesto_2.Trim & "','" & CompuestoPorcent_2 & "','" & Lt_Compuestos & "','" & FechaTurno.Trim & "','" & WorkCenter.Trim & "')"
        '            InsertQry(InQry)
        '            MsgBox("Registros Actualizados (Rechazados) : " & InsertBD, MsgBoxStyle.OkOnly, "Sobrepeso")
        '        End If
        '    Else
        '        SuperAutoSobrepeso = "S/N"
        '    End If



        '    If AutorizaSobrepeso <> 2 Then

        '        ' ----------------------- Inicio WS ----> SAP 

        '        CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim
        '        FechaPesajeSAP = dtpFECHASAP.Value.ToString("yyyy-MM-dd")


        '        Select Case StatusSap
        '            Case "False"
        '                MessageBox.Show(" No se realizara notificación a SAP ", " VENTANA DE ERROR * * * ")
        '            Case "True"
        '                If MenuPrin.TxtUsuario.Text.Trim <> "ATLAS" Then
        '                    Dim lo_wsamancomx As New PTConProd.ZPPMXF001Service
        '                    Dim ls_return As New PTConProd.ZBAPIRET2
        '                    Dim ls_Notifica As New PTConProd.ZEPP002
        '                    Dim ls_result As New PTConProd.ISDFPS_TCUPS_KEY
        '                    ls_Notifica.ZBUDAT = FechaPesajeSAP.Trim
        '                    ls_Notifica.ZCONSUME_REC = 0.0
        '                    ls_Notifica.ZENTRY_QNT = TtramosNoti.Text.Trim
        '                    ls_Notifica.ZISM01 = 0.0
        '                    ls_Notifica.ZISM02 = 0.0
        '                    ls_Notifica.ZISM03 = 0.0
        '                    ls_Notifica.ZISMNGEH1 = ""
        '                    ls_Notifica.ZISMNGEH2 = ""
        '                    ls_Notifica.ZISMNGEH3 = ""
        '                    ls_Notifica.ZMATNR_REC = ""
        '                    ls_Notifica.ZORDERID = TOrden.Text.Trim
        '                    ls_Notifica.ZRECOVERED = 0.0
        '                    ls_Notifica.ZVIRGIN = TPesoNeto.Text.Trim
        '                    lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
        '                    ls_result = lo_wsamancomx.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notifica, ls_return)
        '                    TNumNoti.Text = ls_result.RUECK
        '                    TConsNoti.Text = ls_result.RMZHL
        '                    Err = ls_return.ZTYPE
        '                    Mns = ls_return.ZMESSAGE
        '                ElseIf MenuPrin.TxtUsuario.Text.Trim = "ATLAS" Then
        '                    ' ----------------------- Variables WS Desarrollo
        '                    Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
        '                    Dim ls_returnr As New PTConsumos.ZBAPIRET2
        '                    Dim ls_Notifica As New PTConsumos.ZEPP002
        '                    Dim ls_result As New PTConsumos.ISDFPS_TCUPS_KEY
        '                    ls_Notifica.ZBUDAT = FechaPesajeSAP.Trim
        '                    ls_Notifica.ZCONSUME_REC = 0.0
        '                    ls_Notifica.ZENTRY_QNT = TtramosNoti.Text.Trim
        '                    ls_Notifica.ZISM01 = 0.0
        '                    ls_Notifica.ZISM02 = 0.0
        '                    ls_Notifica.ZISM03 = 0.0
        '                    ls_Notifica.ZISMNGEH1 = ""
        '                    ls_Notifica.ZISMNGEH2 = ""
        '                    ls_Notifica.ZISMNGEH3 = ""
        '                    ls_Notifica.ZMATNR_REC = ""
        '                    ls_Notifica.ZORDERID = TOrden.Text.Trim
        '                    ls_Notifica.ZRECOVERED = 0.0
        '                    ls_Notifica.ZVIRGIN = TPesoNeto.Text.Trim
        '                    lo_wsamancomxr.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
        '                    ls_result = lo_wsamancomxr.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notifica, ls_returnr)
        '                    TNumNoti.Text = ls_result.RUECK
        '                    TConsNoti.Text = ls_result.RMZHL
        '                    Err = ls_returnr.ZTYPE
        '                    Mns = ls_returnr.ZMESSAGE
        '                End If
        '        End Select
        '        ' ----------------------- Inicio verifica error de la orden de produccion

        '        If Err = "E" Then
        '            MessageBox.Show(Mns, "Error en SAP Notifique al Supervisor")
        '            Me.TOrden.Text = ""
        '            BPesar.Enabled = False
        '            Me.TOrden.Focus()
        '            Exit Sub
        '        End If
        '        ' ----------------------- Fin verifica error de la orden de produccion
        '        If (Me.TNumNoti.Text = "" Or Me.TNumNoti.Text = "NULL" Or Me.TNumNoti.Text = "0000000000") And (Me.TConsNoti.Text = "" Or Me.TConsNoti.Text = "NULL" Or Me.TConsNoti.Text = "00000000") Then
        '            reg = "0"
        '        Else
        '            reg = "1"
        '        End If
        '        '======================================================
        '        '= Nota :                                             =
        '        '= Notifica = 1  --> Notificación Efectuada           = 
        '        '= Notifica = 0  --> Falta Por Notificar              =
        '        '=----------------------------------------------------=
        '        '= notificacionmasiva = 1  --> Notificación Masiva    = 
        '        '= notificacionmasiva = 0  --> Notificación Normar    =
        '        '======================================================
        '        InQry = ""
        '        InQry = "INSERT INTO " & strPlanta.Trim & "_PesoProductoTerminado (Orden_Produccion,Fecha_Pesaje,"
        '        InQry = InQry & "Hora_Pesaje, Bascula, Rack, Peso_Bruto, Tara, Peso_Neto, Empaques, Tramos,"
        '        InQry = InQry & "Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,Recibe_Almacen,Fecha_Turno,"
        '        InQry = InQry & "Documento_SAP,Consecutivo_SAP,Compuesto1,Notifica,notificacionmasiva,"
        '        InQry = InQry & "Porcentaje1,Compuesto2,Porcentaje2,PackID,EmbalajeInyeccion,Sobrepeso,CausaSobrepeso,PuestoTrabajo,LTCompuestos, Peso_Teorico) Values ("
        '        InQry = InQry & "'" & Me.TOrden.Text.Trim & "','" & FechaPesaje.Trim & "','" & HoraPesaje.Trim & "','" & ValCodigoBascula.Trim & "','" & Me.TRack.Text.Trim & "',"
        '        InQry = InQry & Me.TPesoBruto.Text.Trim & "," & Me.TPesoTara.Text.Trim & "," & Me.TPesoNeto.Text.Trim & "," & Me.TtramosNoti.Text.Trim & "," & Me.TtramosNoti.Text.Trim & " ,'"
        '        InQry = InQry & TCodOperador.Text.Trim & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "','" & strPlanta.Trim & "','" & FolioSiguiente.Trim & "','S/N','S/N','" & FechaTurno.Trim & "','"
        '        InQry = InQry & Me.TNumNoti.Text.Trim & "','" & Me.TConsNoti.Text.Trim & "','" & Compuesto_1.Trim & "','" & reg.Trim & "','0'," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2
        '        InQry = InQry & ",'" & FolioSiguiente.Trim & "','0'," & TSobrePeso.Text.Trim & ",'" & TCausas.Text.Trim & "','" & UCase(WorkCenter.Trim) & "','" & Lt_Compuestos & "'," & Me.TPesoTeorico.Text.Trim & ") "
        '        InsertQry(InQry)
        '        Mensajes("Registros Actualizados : " & InsertBD, 0)
        '        '------------------------------------------------------------------------------------- PackID
        '        xORIGINAL = ""
        '        imprimir_PT()
        '        '------------------------------------------------------------------------------------- PackID
        '        BPesar.Enabled = False
        '        BImprimir.Enabled = True
        '        TOrden.Enabled = False
        '        SuperAutoSobrepeso = ""
        '    Else
        '        InQry = ""
        '        InQry = "INSERT INTO " & strPlanta.Trim & "_PesoProductoTerminado (Orden_Produccion,Fecha_Pesaje,"
        '        InQry = InQry & "Hora_Pesaje, Bascula, Rack, Peso_Bruto, Tara, Peso_Neto, Empaques, Tramos,"
        '        InQry = InQry & "Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,Recibe_Almacen,Fecha_Turno,"
        '        InQry = InQry & "Documento_SAP,Consecutivo_SAP, Compuesto1, Notifica, notificacionmasiva,"
        '        InQry = InQry & "Porcentaje1,Compuesto2,Porcentaje2,PackID,EmbalajeInyeccion,Sobrepeso,CausaSobrepeso,PuestoTrabajo,LTCompuestos, Peso_Teorico) Values ("
        '        InQry = InQry & "'" & Me.TOrden.Text.Trim & "','" & FechaPesaje.Trim & "','" & HoraPesaje.Trim & "','" & ValCodigoBascula.Trim & "','" & Me.TRack.Text.Trim & "', "
        '        InQry = InQry & Me.TPesoBruto.Text.Trim & "," & Me.TPesoTara.Text.Trim & "," & Me.TPesoNeto.Text.Trim & "," & Me.TtramosNoti.Text.Trim & "," & Me.TtramosNoti.Text.Trim & ",'"
        '        InQry = InQry & Me.TCodOperador.Text.Trim & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "','" & strPlanta.Trim & "','" & FolioSiguiente.Trim & "','SB','S/N','" & FechaTurno.Trim & "',"
        '        InQry = InQry & "'" & Me.TNumNoti.Text.Trim & "','" & Me.TConsNoti.Text.Trim & "','" & Compuesto_1.Trim & "','" & TipoNotificacion & "','0'," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2
        '        InQry = InQry & ",'" & FolioSiguiente.Trim & "','0'," & Me.TSobrePeso.Text.Trim & ",'" & TCausas.Text.Trim & "','" & UCase(WorkCenter.Trim) & "','" & Lt_Compuestos & "'," & Me.TPesoTeorico.Text.Trim & ") "
        '        InsertQry(InQry)
        '        Mensajes("Registros Actualizados : " & InsertBD, 0)
        '        '------------------------------------------------------------------------------------- PackID
        '        xORIGINAL = ""
        '        imprimir_PT()
        '        '------------------------------------------------------------------------------------- PackID
        '        BPesar.Enabled = False
        '        BImprimir.Enabled = True
        '        TOrden.Enabled = False
        '        SuperAutoSobrepeso = ""
        '    End If
        'End If

        '*******************
        Dim TipoNotificacion As Char = "0"
        Dim xTIPOPROD As Char = ""
        Forma = "Extrusion"
        ' ---------------------------------------------------------------------------------
        If TClaveOperador.Text = "" Then
            Mensajes("***  Tecleé codigo de operador  *** ", 1)
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

        If rbtFinalSi.Checked = False And rbtFinalNo.Checked = False Then
            Mensajes("***  Selecciona si es TERMINADO ó EN PROCESO   *** ", 1)
            Exit Sub
        End If

        'If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
        '    If TCausas.Text.Trim.Length = 0 Then
        '        Mensajes("***  Seleccione una CAUSA de SOBREPESO  *** ", 1)
        '        TCausas.Focus()
        '        Exit Sub
        '    End If
        'End If
        ' ---------------------------------------------------------------------------------
        nvoBascula = "" & strNumeroBascula
        nvoFecha_Pesaje = Date.Today.ToString("yyyy-MM-dd")
        nvoHora_Pesaje = Date.Now.TimeOfDay.ToString()
        nvoOrden_Produccion = TOrden.Text.Trim

        Dim StrStatus As Boolean
        ' ---------------------------------------------------------------------------------
        QRY_AMD = ""
        QRY_AMD = "Select ADM_StatusSAP.Status FROM ADM_StatusSAP WHERE Planta='" & SessionUser._sCentro.Trim & "'"
        LecturaQry_AMD(QRY_AMD)
        If LecturaBD_AMD.Read() Then
            StrStatus = LecturaBD_AMD(0)
        End If
        LecturaBD_AMD.Close()
        ' ---------------------------------------------------------------------------------
        Select Case UsrLog
            Case "ATLAS"
                Dim lo_wsamancomx As New Read.ZPP001_91Service
                Dim ls_return As New Read.ZBAPIRET2
                Dim ls_values As New Read.ZEPP001
                lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                ls_values = lo_wsamancomx.Z_PP001(Me.TOrden.Text, ls_return)

                Err = ls_return.ZTYPE
                Mns = ls_return.ZMESSAGE
            Case Is <> "ATLAS" ' 
                'Dim lo_wsamancomx As New Lee_OF.ZPP001_91Service
                'Dim ls_return As New Lee_OF.ZBAPIRET2
                'Dim ls_values As New Lee_OF.ZEPP001
                'lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                'ls_values = lo_wsamancomx.Z_PP001(Me.TOrden.Text, ls_return)

                Err = ls_return.ZTYPE
                Mns = ls_return.ZMESSAGE

        End Select
        If Err = "E" Then
            MessageBox.Show(Mns, "Error SAP Notifique al Supervisor")
            Me.TClaveOperador.Focus()
            Return
        End If
        '' ---------------------------------------------------------------------------------
        'FolioSiguiente = ""
        'QRY = ""
        'QRY = "Select Max(Producto_Terminado)+1 as folioSiguiente from MCPC_Foliador  "
        'QRY = QRY & " where Planta='" & strPlanta.Trim & "'"
        'LecturaQry(QRY)
        'If (LecturaBD.Read) Then
        '    FolioSiguiente = LecturaBD(0)
        'End If
        'LecturaBD.Close()
        '' ---------------------------------------------------------------------------------
        'FolioSiguiente = FolioSiguiente.Trim
        'FolioSiguiente = Mid("00000000", 1, 8 - Len(FolioSiguiente)) & FolioSiguiente.Trim
        'TFolioAtlas.Text = FolioSiguiente
        '' ---------------------------------------------------------------------------------
        'InQry = ""
        'InQry = "Update MCPC_Foliador set Producto_Terminado = '" & FolioSiguiente.Trim & "'"
        'InQry = InQry & " where Planta = '" & strPlanta.Trim & "'"
        'InsertQry(InQry)
        '' ---------------------------------------------------------------------------------
        'CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim
        '' ---------------------------------------------------------------------------------

        If Val(ValControlCompuesto.Trim) = 0 Or CheckBox1.Checked = False Then
            Lt_Compuestos = ""
        Else
            ' ---------------------------------------------------------------------------------
            Dim Count As Integer = 0
            QRY = ""
            QRY = "select b.ComExt_ComCodigo from productoterminadoextrusion a, CompuestoExtrusion b "
            QRY = QRY & "where a.centro = b.ComExt_PT_Centro "
            QRY = QRY & "and a.codigo = b.ComExt_PT_Codigo "
            'QRY = QRY & "and a.centro = '" & strPlanta.Trim & "' "
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

            If ValPublic_ReproConsumo.Trim.Length > 0 Then
                Compuesto_1 = ValPublic_ReproConsumo.Trim
                CompuestoPorcent_1 = 100
                Compuesto_2 = "0"
                CompuestoPorcent_2 = 0
                Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1
            End If
        End If
        ' ---------------------------------------------------------------------------------
        If FUERATURNO = 0 Then
            dateRegistro = Today()
            FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
            HoraPesaje = Date.Now.TimeOfDay.ToString
            FechaTurno = FechaPesaje
            ' ---------------------------------------------------------------------------------
            QRY_AMD = ""
            QRY_AMD = " Select TT.Turno, TT.Descripcion, Convert(char(8),TT.Hora_Inicio,108) as Hora_Inicio, "
            QRY_AMD = QRY_AMD & " Convert(char(8),TT.Hora_Terminacion,108) as Hora_Terminacion, TT.registro "
            QRY_AMD = QRY_AMD & " FROM ADM_Turno TT INNER JOIN ADM_CambioHora CH ON TT.Planta=CH.Planta "
            QRY_AMD = QRY_AMD & " AND Convert(char(10), getdate(),102)between Convert(char(10), CH.Fecha_Inicio,102) AND Convert(char(10),CH.fecha_Terminacion,102) "
            QRY_AMD = QRY_AMD & " WHERE Convert(char(8), getdate()+(CH.CHora/24),108) between Convert(char(8), Hora_Inicio,108) "
            QRY_AMD = QRY_AMD & " AND Convert(char(8),Hora_Terminacion,108) and TT.Planta='" & SessionUser._sCentro.Trim & "' "
            LecturaQry_AMD(QRY_AMD)
            ' ---------------------------------------------------------------------------------
            Turno = "1"
            If LecturaBD_AMD.Read() Then
                Turno = LecturaBD_AMD(0)
                dateRegistro = DateAdd(DateInterval.Day, -Val(LecturaBD_AMD(4)), dateRegistro)
            End If
            FechaTurno = dateRegistro.ToString("yyyy-MM-dd")
            LecturaBD_AMD.Close()
            ' ---------------------------------------------------------------------------------
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
            ProcesoSeparada()
            TipoNotificacion = "3"
            xTIPOPROD = "P"
        Else
            ProcesoSobrepeso()
            TipoNotificacion = "2"
        End If
        nvoTipo_SCausa = TCausas.Text.Trim
        nvoPesoTeorico = TPesoTeorico.Text.Trim
        ' ---------------------------------------------------------------------------------
        'If AutorizaSobrepeso = 9 Then
        '    Exit Sub
        'End If
        ' ---------------------------------------------------------------------------------
        If chkSAP.Checked = True Then
            FechaPesajeSAP = dtpFECHASAP.Value.ToString("yyyy-MM-dd")
            TNumNoti.Text = "0000000000"
            TConsNoti.Text = "00000000"

            'If AutorizaSobrepeso <> 2 Then
            '    ' ---------------------------------------------------------------------------------
            '    Select Case StrStatus
            '        Case "False"
            '            MessageBox.Show(" No se realizara notificación a SAP ", " VENTANA DE ERROR * * * ")
            '        Case "True"
            '            If MenuPrin.TxtUsuario.Text.Trim <> "ATLAS" Then

            '                Dim lo_wsamancomx As New PTConProd.ZPPMXF001Service
            '                Dim ls_return As New PTConProd.ZBAPIRET2
            '                Dim ls_Notifica As New PTConProd.ZEPP002
            '                Dim ls_result As New PTConProd._ISDFPS_TCUPS_KEY

            '                ls_Notifica.ZBUDAT = FechaPesajeSAP.Trim
            '                ls_Notifica.ZCONSUME_REC = 0
            '                ls_Notifica.ZENTRY_QNT = nvoTramosNoti
            '                ls_Notifica.ZISM01 = 0
            '                ls_Notifica.ZISM02 = 0
            '                ls_Notifica.ZISM03 = 0
            '                ls_Notifica.ZISMNGEH1 = ""
            '                ls_Notifica.ZISMNGEH2 = ""
            '                ls_Notifica.ZISMNGEH3 = ""
            '                ls_Notifica.ZMATNR_REC = ""
            '                ls_Notifica.ZORDERID = nvoOrden_Produccion
            '                ls_Notifica.ZRECOVERED = 0
            '                ls_Notifica.ZVIRGIN = nvoPeso_Neto

            '                lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
            '                ls_result = lo_wsamancomx.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notifica, ls_return)

            '                TNumNoti.Text = ls_result.RUECK
            '                TConsNoti.Text = ls_result.RMZHL
            '                Err = ls_return.ZTYPE
            '                Mns = ls_return.ZMESSAGE

            '            ElseIf MenuPrin.TxtUsuario.Text.Trim = "ATLAS" Then
            '                Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
            '                Dim ls_returnr As New PTConsumos.ZBAPIRET2
            '                Dim ls_Notifica As New PTConsumos.ZEPP002
            '                Dim ls_result As New PTConsumos._ISDFPS_TCUPS_KEY

            '                ls_Notifica.ZBUDAT = FechaPesajeSAP.Trim
            '                ls_Notifica.ZCONSUME_REC = 0
            '                ls_Notifica.ZENTRY_QNT = nvoTramosNoti
            '                ls_Notifica.ZISM01 = 0
            '                ls_Notifica.ZISM02 = 0
            '                ls_Notifica.ZISM03 = 0
            '                ls_Notifica.ZISMNGEH1 = ""
            '                ls_Notifica.ZISMNGEH2 = ""
            '                ls_Notifica.ZISMNGEH3 = ""
            '                ls_Notifica.ZMATNR_REC = ""
            '                ls_Notifica.ZORDERID = nvoOrden_Produccion
            '                ls_Notifica.ZRECOVERED = 0
            '                ls_Notifica.ZVIRGIN = nvoPeso_Neto

            '                lo_wsamancomxr.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
            '                ls_result = lo_wsamancomxr.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notifica, ls_returnr)

            '                TNumNoti.Text = ls_result.RUECK
            '                TConsNoti.Text = ls_result.RMZHL
            '                Err = ls_returnr.ZTYPE
            '                Mns = ls_returnr.ZMESSAGE
            '            End If
            '    End Select
            '    ' ---------------------------------------------------------------------------------
            '    If Err = "E" Then
            '        MessageBox.Show(Mns, "Error en SAP Notifique al Supervisor")
            '        Me.TOrden.Text = ""
            '        BPesar.Enabled = False
            '        Me.TOrden.Focus()
            '        Exit Sub
            '    End If
            '    ' ---------------------------------------------------------------------------------
            '    If (Me.TNumNoti.Text = "" Or Me.TNumNoti.Text = "NULL" Or Me.TNumNoti.Text = "0000000000") And (Me.TConsNoti.Text = "" Or Me.TConsNoti.Text = "NULL" Or Me.TConsNoti.Text = "00000000") Then
            '        reg = "0"
            '    Else
            '        reg = "1"
            '    End If
            '    ' ---------------------------------------------------------------------------------
            '    InQry = ""
            '    InQry = "INSERT INTO [" & strPlanta.Trim & "_PesoProductoTerminado] (Orden_Produccion,Fecha_Pesaje,"
            '    InQry = InQry & "Hora_Pesaje, Bascula, Rack, Peso_Bruto, Tara, Peso_Neto, Empaques, Tramos,"
            '    InQry = InQry & "Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,Recibe_Almacen,Fecha_Turno,"
            '    InQry = InQry & "Documento_SAP,Consecutivo_SAP,Compuesto1,Notifica,notificacionmasiva,"
            '    InQry = InQry & "Porcentaje1,Compuesto2,Porcentaje2,PackID,EmbalajeInyeccion, Sobrepeso, CausaSobrepeso,PuestoTrabajo,LTCompuestos, Peso_Teorico, Tipo_PT, FolioR) Values ("
            '    InQry = InQry & "'" & nvoOrden_Produccion & "','" & FechaPesaje.Trim & "','" & HoraPesaje.Trim & "','" & ValCodigoBascula.Trim & "','" & Me.TRack.Text.Trim & "',"
            '    InQry = InQry & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & "," & Replace(nvoTramosNoti, GDECIMAL, ".") & "," & Replace(nvoTramosNoti, GDECIMAL, ".") & " ,'"
            '    InQry = InQry & nvoUsuario & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "','" & strPlanta.Trim & "','" & FolioSiguiente.Trim & "','S/N','S/N','" & FechaTurno.Trim & "','"
            '    InQry = InQry & Me.TNumNoti.Text.Trim & "','" & Me.TConsNoti.Text.Trim & "','" & Compuesto_1.Trim & "','" & reg.Trim & "',0," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2
            '    InQry = InQry & ",'" & FolioSiguiente.Trim & "','0'," & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & ",'" & nvoTipo_SCausa & "','" & UCase(WorkCenter.Trim) & "','" & Lt_Compuestos & "'," & Replace(nvoPesoTeorico, GDECIMAL, ".") & ",'" & xTIPOPROD & "', '') "
            '    InsertQry(InQry)
            '    ' ---------------------------------------------------------------------------------
            '    If GFOTOS = "S" Then
            '        GIMAGENNOM = GIMAGENURI & strPlanta.Trim & "-PT-O" & nvoOrden_Produccion & "F" & FolioSiguiente.Trim & ".jpg"
            '        GIMAGENDATOS = strPlanta.Trim & "-" & nvoOrden_Produccion & "-" & FolioSiguiente.Trim & "-" & Replace(nvoTramosNoti, GDECIMAL, ".")
            '        Try
            '            frmWebCamViewer.ShowDialog()
            '        Finally
            '            frmWebCamViewer.Dispose()
            '            frmWebCamViewer = Nothing
            '        End Try
            '    Else
            '        Mensajes("Registros Actualizados : " & InsertBD, 0)
            '    End If
            '    ' ---------------------------------------------------------------------------------
            '    xORIGINAL = ""
            '    imprimir_PT()
            '    ' ---------------------------------------------------------------------------------
            '    BPesar.Enabled = False
            '    BImprimir.Enabled = True
            '    TOrden.Enabled = False
            '    SuperAutoSobrepeso = ""
            'Else
            '    If xTIPOPROD = "T" Then
            '        xTIPOPROD = "S"
            '    End If
            '    ' ---------------------------------------------------------------------------------
            '    InQry = ""
            '    InQry = "INSERT INTO [" & strPlanta.Trim & "_PesoProductoTerminado] (Orden_Produccion,Fecha_Pesaje,"
            '    InQry = InQry & "Hora_Pesaje, Bascula, Rack, Peso_Bruto, Tara, Peso_Neto, Empaques, Tramos,"
            '    InQry = InQry & "Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,Recibe_Almacen,Fecha_Turno,"
            '    InQry = InQry & "Documento_SAP,Consecutivo_SAP, Compuesto1, Notifica, notificacionmasiva,"
            '    InQry = InQry & "Porcentaje1,Compuesto2,Porcentaje2,PackID,EmbalajeInyeccion,Sobrepeso,CausaSobrepeso,PuestoTrabajo,LTCompuestos, Peso_Teorico, Tipo_PT, FolioR) Values ("
            '    InQry = InQry & "'" & nvoOrden_Produccion & "','" & FechaPesaje.Trim & "','" & HoraPesaje.Trim & "','" & ValCodigoBascula.Trim & "','" & Me.TRack.Text.Trim & "', "
            '    InQry = InQry & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & "," & Replace(nvoTramosNoti, GDECIMAL, ".") & "," & Replace(nvoTramosNoti, GDECIMAL, ".") & ",'"
            '    InQry = InQry & nvoUsuario & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "','" & strPlanta.Trim & "','" & FolioSiguiente.Trim & "','SB','S/N','" & FechaTurno.Trim & "',"
            '    InQry = InQry & "'" & Me.TNumNoti.Text.Trim & "','" & Me.TConsNoti.Text.Trim & "','" & Compuesto_1.Trim & "','" & TipoNotificacion & "',0," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2
            '    InQry = InQry & ",'" & FolioSiguiente.Trim & "','0'," & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & ",'" & nvoTipo_SCausa & "','" & UCase(WorkCenter.Trim) & "','" & Lt_Compuestos & "'," & Replace(nvoPesoTeorico, GDECIMAL, ".") & ",'" & xTIPOPROD & "', '') "
            '    InsertQry(InQry)
            '    ' ---------------------------------------------------------------------------------
            '    If GFOTOS = "S" Then
            '        GIMAGENNOM = GIMAGENURI & nvoOrden_Produccion & "-" & FolioSiguiente.Trim & ".jpg"
            '        Try
            '            frmWebCamViewer.ShowDialog()
            '        Finally
            '            frmWebCamViewer.Dispose()
            '            frmWebCamViewer = Nothing
            '        End Try
            '    Else
            '        Mensajes("Registros Actualizados : " & InsertBD, 0)
            '    End If
            '    ' ---------------------------------------------------------------------------------
            '    xORIGINAL = ""
            '    imprimir_PT()
            '    ' ---------------------------------------------------------------------------------
            '    BPesar.Enabled = False
            '    BImprimir.Enabled = True
            '    TOrden.Enabled = False
            '    SuperAutoSobrepeso = ""
            'End If
        Else
            'TipoNotificacion = "4"
            'If xTIPOPROD = "T" And Not AutorizaSobrepeso <> 2 Then
            '    xTIPOPROD = "S"
            'End If
            '' ---------------------------------------------------------------------------------
            'InQry = ""
            'InQry = "INSERT INTO [" & strPlanta.Trim & "_PesoProductoTerminado] (Orden_Produccion,Fecha_Pesaje,"
            'InQry = InQry & "Hora_Pesaje, Bascula, Rack, Peso_Bruto, Tara, Peso_Neto, Empaques, Tramos,"
            'InQry = InQry & "Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,Recibe_Almacen,Fecha_Turno,"
            'InQry = InQry & "Documento_SAP,Consecutivo_SAP, Compuesto1, Notifica, notificacionmasiva,"
            'InQry = InQry & "Porcentaje1,Compuesto2,Porcentaje2,PackID,EmbalajeInyeccion,Sobrepeso,CausaSobrepeso,PuestoTrabajo,LTCompuestos, Peso_Teorico, Tipo_PT, FolioR) Values ("
            'InQry = InQry & "'" & nvoOrden_Produccion & "','" & FechaPesaje.Trim & "','" & HoraPesaje.Trim & "','" & ValCodigoBascula.Trim & "','" & Me.TRack.Text.Trim & "', "
            'InQry = InQry & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & "," & Replace(nvoTramosNoti, GDECIMAL, ".") & "," & Replace(nvoTramosNoti, GDECIMAL, ".") & ", "
            'InQry = InQry & "'" & nvoUsuario & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "','" & strPlanta.Trim & "','" & FolioSiguiente.Trim & "','SB','S/N','" & FechaTurno.Trim & "', "
            'InQry = InQry & "'" & Me.TNumNoti.Text.Trim & "','" & Me.TConsNoti.Text.Trim & "','" & Compuesto_1.Trim & "','" & TipoNotificacion & "',0," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2
            'InQry = InQry & ",'" & FolioSiguiente.Trim & "','0'," & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & ",'" & nvoTipo_SCausa & "','" & UCase(WorkCenter.Trim) & "','" & Lt_Compuestos & "'," & Replace(nvoPesoTeorico, GDECIMAL, ".") & ",'" & xTIPOPROD & "', '') "
            'InsertQry(InQry)

            '' ---------------------------------------------------------------------------------
            'If GFOTOS = "S" Then
            '    GIMAGENNOM = GIMAGENURI & nvoOrden_Produccion & "-" & FolioSiguiente.Trim & ".jpg"
            '    Try
            '        frmWebCamViewer.ShowDialog()
            '    Finally
            '        frmWebCamViewer.Dispose()
            '        frmWebCamViewer = Nothing
            '    End Try
            'Else
            '    Mensajes("Registros Actualizados : " & InsertBD, 0)
            'End If
            '' ---------------------------------------------------------------------------------
            'xORIGINAL = ""
            'imprimir_PT()
            '' ---------------------------------------------------------------------------------
            'BPesar.Enabled = False
            'BImprimir.Enabled = True
            'TOrden.Enabled = False
            'SuperAutoSobrepeso = ""
        End If
    End Sub

    Private Sub TPesoBruto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoBruto.TextChanged
        Dim xTPesoBruto As Double
        Dim xTPesoTara As Double
        Dim xTempaquePesoTot As Double
        Dim xTPesoNeto As Double
        xTPesoBruto = "0" & TPesoBruto.Text.Trim
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
        xTPesoBruto = "0" & TPesoBruto.Text.Trim
        xTPesoTara = "0" & TPesoTara.Text.Trim
        xTempaquePesoTot = "0" & TempaquePesoTot.Text.Trim
        xTPesoNeto = xTPesoBruto - xTPesoTara - xTempaquePesoTot
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

        '' sobrePESO(Val(PesoTeorico), Val(TtramosNoti.Text), Val(TPesoNeto.Text), StrProducto.Trim, TOrden.Text.Trim)
        'Dim xPSP As Double
        'Dim xTramosNoti As Double
        'Dim xPeso_Neto As Double
        'xTramosNoti = "0" & TtramosNoti.Text.Trim
        'xPeso_Neto = "" & TPesoNeto.Text.Trim
        'SobrepesoPermitido = "0" & SP_Permitido.Text.Trim
        'PorcentajeSobrePeso = 0
        'If PesoTeorico > 0 And xTramosNoti > 0 Then
        '    xPSP = (((xPeso_Neto / (PesoTeorico * xTramosNoti)) - 1) * 100)
        '    PorcentajeSobrePeso = Format(xPSP, xFormato)
        'Else
        '    PorcentajeSobrePeso = Format(100, xFormato)
        'End If

        'TSobrePeso.Text = Format(PorcentajeSobrePeso, "#0.00")
        ''TSobrePeso.Text = Format(PorcentajeSobrePeso, "#0" & GDECIMAL & "00")

        'If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
        '    TSobrePeso.BackColor = Color.Red
        '    TCausas.Enabled = True
        'Else
        '    TSobrePeso.BackColor = Color.Yellow
        'End If
        'TtramosNoti.BackColor = Color.White
    End Sub
    Private Sub BSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSiguiente.Click
        LimpiaObjetos()
        TSobrePeso.BackColor = Color.White
        TClaveOperador.Focus()
    End Sub
    Private Sub BImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImprimir.Click
        xORIGINAL = "  ============ COPIA   "
        imprimir_PT()
    End Sub
    Sub imprimir_PT()
        Dim PFolioAtlas As String = ""
        Dim PFechaPesaje As String = ""
        Dim PHoraPesaje As String = ""
        Dim PTurno As String = ""
        Dim PFechaTurno As String = ""
        Dim PrbtFinal As String = ""
        Dim PGrpprod As String = ""
        Dim PGrpproddesc As String = ""
        Dim POrden As String = ""
        Dim PCodPT As String = ""
        Dim PCodPtDecr As String = ""
        Dim PtramosNoti As String = ""
        Dim PPesoBruto As String = ""
        Dim PPesoTara As String = ""
        Dim PPesoNeto As String = ""
        Dim PSobrePeso As String = ""
        Dim PPesoTeorico As String = ""
        Dim PPtoTrabajo As String = ""
        Dim PCodOperador As String = ""
        Dim PNomOperador As String = ""
        Dim PTipoPT As String = ""
        Dim PFolioR As String = ""

        PFolioAtlas = TFolioAtlas.Text.Trim
        POrden = TOrden.Text.Trim

        'QRY = ""
        'QRY = QRY & " Select PPT.Folio, PPT.Fecha_Pesaje, PPT.Hora_Pesaje, PPT.Turno, PPT.Fecha_Turno, PPT.Notifica,  "
        'QRY = QRY & " PTE.Grpprod, CGR.desgrupo, PPT.Orden_Produccion, PTE.Codigo, PTE.Descr , PPT.Tramos,PPT.Peso_Bruto,  "
        'QRY = QRY & " PPT.Tara, PPT.Peso_Neto, PPT.Sobrepeso, PPT.Peso_teorico, PPT.PuestoTrabajo, PPT.Usuario, PPT.Tipo_PT, PPT.FolioR "
        'QRY = QRY & " FROM  ([" & strPlanta.Trim & "_PesoProductoTerminado] PPT "
        'QRY = QRY & " inner join [" & strPlanta.Trim & "_OrdenProduccion] OP ON OP.Planta= PPT.PLANTA and  PPT.Orden_Produccion = OP.Orden_Produccion)"
        'QRY = QRY & " inner join MCPC_EquipoBasico EB    ON PPT.planta = EB.Planta AND PPT.PuestoTrabajo = EB.Equipo_basico "
        'QRY = QRY & " inner join " & tablaEXTINY & " PTE ON PTE.CENTRO= OP.PLANTA and  PTE.Codigo = OP.Producto"
        'QRY = QRY & " inner join catgrupos CGR           ON PTE.CENTRO= CGR.CENTRO and  PTE.Grpprod = CGR.Grpprod"
        'QRY = QRY & " WHERE  PPT.Planta = '" & strPlanta.Trim & "' AND PPT.Orden_Produccion = '" & POrden.Trim & "' AND PPT.folio='" & PFolioAtlas.Trim & "'"
        'LecturaQry(QRY)

        If LecturaBD.Read() Then
            PFolioAtlas = LecturaBD(0)
            PFechaPesaje = LecturaBD(1)
            PHoraPesaje = LecturaBD(2)
            PTurno = LecturaBD(3)
            PFechaTurno = LecturaBD(4)
            PrbtFinal = LecturaBD(5)
            PGrpprod = LecturaBD(6)
            PGrpproddesc = LecturaBD(7)
            POrden = LecturaBD(8)
            PCodPT = LecturaBD(9)
            PCodPtDecr = LecturaBD(10)
            PtramosNoti = LecturaBD(11)
            PPesoBruto = LecturaBD(12)
            PPesoTara = LecturaBD(13)
            PPesoNeto = LecturaBD(14)
            PSobrePeso = LecturaBD(15)
            PPesoTeorico = LecturaBD(16)
            PPtoTrabajo = LecturaBD(17)
            PCodOperador = LecturaBD(18)
            PTipoPT = LecturaBD(19)
            PFolioR = LecturaBD(20)
        End If
        LecturaBD.Close()

        'QRY_AMD = ""
        'QRY_AMD = "Select Usuario, Nombre From  ADM_Usuario "
        'QRY_AMD = QRY_AMD & " WHERE  Usuario = '" & PCodOperador.Trim & "' And Planta = '" & strPlanta.Trim & "'"
        'LecturaQry_AMD(QRY_AMD)
        'PNomOperador = ""
        Do While (LecturaBD_AMD.Read)
            PNomOperador = LecturaBD_AMD(1)
        Loop
        LecturaBD_AMD.Close()

        'FileOpen(1, GETIQUETAS.Trim & "\barcode.TXT", OpenMode.Output)
        PrintLine(1)
        PrintLine(1, GEMPRESA)
        PrintLine(1, "PRODUCCION CONTROL DE PESAJE")
        PrintLine(1)
        PrintLine(1, "   FOLIO: " & PFolioAtlas.Trim)
        PrintLine(1, "F.PESAJE: " & PFechaPesaje.Trim)
        PrintLine(1, "H.PESAJE: " & Mid(PHoraPesaje.Trim, 1, 8))
        PrintLine(1)
        PrintLine(1, "TURNO: " & PTurno.Trim & "   F.TURNO: " & PFechaTurno.Trim)
        PrintLine(1)

        If PTipoPT.Trim = "T" Then
            PrintLine(1, "  * * * (" & PTipoPT.Trim & ") PRODUCCION FINAL  ")
        End If

        If PTipoPT.Trim = "S" Then
            PrintLine(1, "  * * *  (" & PTipoPT.Trim & ") PRODUCCION FINAL - SOBREPESO  ")
        End If

        If PTipoPT.Trim = "P" Then
            PrintLine(1, "  * * * (" & PTipoPT.Trim & ") PRODUCCION EN PROCESO  ")
        End If

        PrintLine(1)
        PrintLine(1, " TIPO PROD.: " & PGrpprod.Trim & "    " & PGrpproddesc.Trim)
        PrintLine(1)
        PrintLine(1, "   O.D.F.: " & POrden.Trim)
        PrintLine(1, " MATERIAL: " & PCodPT.Trim)
        PrintLine(1, " " & Mid(PCodPtDecr.Trim, 1, 30))
        PrintLine(1)
        PrintLine(1, " UNIDADES: " & PtramosNoti.Trim)
        PrintLine(1, " P. BRUTO: " & PPesoBruto.Trim)
        PrintLine(1, "     TARA: " & PPesoTara.Trim)
        PrintLine(1, "  P. NETO: " & PPesoNeto.Trim)
        PrintLine(1)
        PrintLine(1, "  % SOBREPESO: " & PSobrePeso.Trim)
        PrintLine(1, " PESO TEORICO: " & PPesoTeorico.Trim)
        PrintLine(1)
        PrintLine(1, xORIGINAL)
        PrintLine(1)
        PrintLine(1, "P.TRABAJO: " & PPtoTrabajo.Trim)
        PrintLine(1, " OPERADOR: " & PCodOperador.Trim & "    " & PNomOperador.Trim)
        FileClose(1)
        'Shell(GETIQUETAS.Trim & "\printcode.bat", AppWinStyle.Hide, True)
    End Sub

    Private Sub BCompuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCompuesto.Click
        'StrProces = "Est"
        'FormConfigurarCompuesto.CheckBox2.Checked = False
        'FormConfigurarCompuesto.CheckBox3.Checked = False
        'FormConfigurarCompuesto.ShowDialog()
        'If StatusConfiCompuesto = "1" Then
        '    CheckBox1.Checked = True
        'Else
        '    CheckBox1.Checked = False
        'End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        BPesar.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Cadena = MenuPrin.SerialPort1.ReadExisting

        'TPC = Chr(CH1)
        'TPC2 = Chr(CH2)

        'If Cadena.Length > 13 Then
        '    If Cadena.StartsWith(TPC) = True Then
        '        Lectura = Cadena.Substring((Cadena.IndexOf(TPC2) + AddChar), LenghtLec).Trim
        '    End If
        'End If

        'If ValCodigoBascula.Trim <> "BEXT1" Then
        '    TPesoBruto.Text = Format(Val(Lectura), xFormato)
        'Else
        '    TPesoBruto.Text = Format(Val(Lectura) / 100, xFormato)
        'End If

    End Sub
    Private Sub ProcesoSeparada()
        'AutorizaSobrepeso = 2
        'SuperAutoSobrepeso = "S/N"
        'ObserSobrepeso = ""
        'If NumEmpaques = "" Then
        '    NumEmpaques = "0"
        'End If
        'ObserSobrepeso = ""
        '' ---------------------------------------------------------------------------------
        'FolioSiguiente = ""
        'QRY = ""
        'QRY = "Select Max(Producto_Terminado)+1 as folioSiguiente from MCPC_Foliador  "
        'QRY = QRY & " where Planta='" & strPlanta.Trim & "'"
        'LecturaQry(QRY)
        'If LecturaBD.Read() Then
        '    FolioSiguiente = LecturaBD(0)
        'End If
        'LecturaBD.Close()
        '' ---------------------------------------------------------------------------------
        'FolioSiguiente = FolioSiguiente.Trim
        'FolioSiguiente = Mid("00000000", 1, 8 - Len(FolioSiguiente)) & FolioSiguiente.Trim
        'TFolioAtlas.Text = FolioSiguiente
        '' ---------------------------------------------------------------------------------
        'InQry = ""
        'InQry = "Update MCPC_Foliador set Producto_Terminado = '" & FolioSiguiente.Trim & "'"
        'InQry = InQry & " where Planta = '" & strPlanta.Trim & "'"
        'InsertQry(InQry)
        '' ---------------------------------------------------------------------------------
        'CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim
        '' ---------------------------------------------------------------------------------
        'InQry = ""
        'InQry = "INSERT INTO MCPT_AutorizacionSeparada (Orden_produccion, Fecha_Pesaje, Hora_Pesaje, Bascula, Rack, Tramos, Empaques, Peso_Bruto, Tara, Peso_Neto, "
        'InQry = InQry & " Usuario, Turno, Supervisor, Planta, Folio, Autoriza_Calidad, Recibe_Almacen, Autoriza_separada, Estatus_Autorizacion, Observaciones ,Porscrap, "
        'InQry = InQry & " Causascrap, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos,Fecha_turno, puestotrabajo) Values ('" & nvoOrden_Produccion & "','"
        'InQry = InQry & FechaPesaje.Trim & "' , '" & HoraPesaje.Trim & "','" & ValCodigoBascula.Trim & "','" & TRack.Text.Trim & "'," & Replace(nvoTramosNoti, GDECIMAL, ".") & ","
        'InQry = InQry & NumEmpaques & " , " & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & ",'"
        'InQry = InQry & nvoUsuario & " ' , " & Turno.Trim & " , '" & SuperAutoSobrepeso.Trim & "', '" & strPlanta.Trim & "', '" & FolioSiguiente.Trim & "' , '" & "S/N" & " ','"
        'InQry = InQry & "S/N" & "','" & SuperAutoSobrepeso.Trim & "','" & 0 & "','" & ObserSobrepeso.Trim & "','" & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & "'"
        'InQry = InQry & ",'9999','" & Compuesto_1.Trim & "'," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2 & ",'" & Lt_Compuestos & "','" & FechaTurno & "', "
        'InQry = InQry & "'" & WorkCenter.Trim & "')"
        'InsertQry(InQry)
        '' ---------------------------------------------------------------------------------
    End Sub
    Private Sub ProcesoSobrepeso()
        Dim xPSP As Double
        Dim xTramosNoti As Double
        Dim xPeso_Neto As Double
        xTramosNoti = "0" & TtramosNoti.Text.Trim
        xPeso_Neto = "" & TPesoNeto.Text.Trim
        SobrepesoPermitido = "0" & SP_Permitido.Text.Trim
        PorcentajeSobrePeso = 0
        SuperAutoSobrepeso = "S/N"
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
        If AutorizaSobrepeso >= 0 And AutorizaSobrepeso < 9 Then
            ' ---------------------------------------------------------------------------------
            FolioSiguiente = ""
            QRY = ""
            QRY = "Select Max(Producto_Terminado)+1 as folioSiguiente from MCPC_Foliador  "
            QRY = QRY & " where Planta='" & SessionUser._sCentro.Trim & "'"
            LecturaQry(QRY)
            If LecturaBD.Read() Then
                FolioSiguiente = LecturaBD(0)
            End If
            LecturaBD.Close()
            ' ---------------------------------------------------------------------------------
            FolioSiguiente = FolioSiguiente.Trim
            FolioSiguiente = Mid("00000000", 1, 8 - Len(FolioSiguiente)) & FolioSiguiente.Trim
            TFolioAtlas.Text = FolioSiguiente
            ' ---------------------------------------------------------------------------------
            InQry = ""
            InQry = "Update MCPC_Foliador set Producto_Terminado = '" & FolioSiguiente.Trim & "'"
            InQry = InQry & " where Planta = '" & SessionUser._sCentro.Trim & "'"
            InsertQry(InQry)
            ' ---------------------------------------------------------------------------------
            CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim
            ' ---------------------------------------------------------------------------------

            Select Case AutorizaSobrepeso
                Case Is = 2
                    If NumEmpaques.Trim = "" Then
                        NumEmpaques = "0"
                    End If

                    InQry = ""
                    InQry = "INSERT INTO MCPT_AutorizacionSobrepeso (Orden_produccion, Fecha_Pesaje, Hora_Pesaje, Bascula, Rack, Tramos, Empaques, Peso_Bruto, "
                    InQry = InQry & " Tara, Peso_Neto, Usuario, Turno, Supervisor, Planta, Folio, Autoriza_Calidad, Recibe_Almacen, Autoriza_Sobrepeso, "
                    InQry = InQry & " Estatus_Autorizacion, Observaciones ,PorSobrePeso,CausasSobrepeso,Compuesto1,Porcentaje1,Compuesto2,Porcentaje2, "
                    InQry = InQry & " LTCompuestos, Fecha_turno, Puestotrabajo) Values ('" & nvoOrden_Produccion & "','" & FechaPesaje.Trim & "','" & HoraPesaje.Trim & "', "
                    InQry = InQry & " '" & ValCodigoBascula.Trim & "','" & TPesoRack.Text.Trim & "','" & Replace(nvoTramosNoti, GDECIMAL, ".") & "','" & NumEmpaques & "','" & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "', "
                    InQry = InQry & "'" & Replace(nvoTara, GDECIMAL, ".") & "','" & Replace(nvoPeso_Neto, GDECIMAL, ".") & "','" & nvoUsuario & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "', "
                    InQry = InQry & " '" & SessionUser._sCentro.Trim & "','" & FolioSiguiente.Trim & " ','" & "S/N" & " ',' " & "S/N" & "','" & SuperAutoSobrepeso.Trim & "','0','" & ObserSobrepeso.Trim & "',' "
                    InQry = InQry & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & "','" & TCausas.Text.Trim & "','" & Compuesto_1.Trim & "','" & CompuestoPorcent_1 & "','" & Compuesto_2.Trim & "','" & CompuestoPorcent_2 & "',' "
                    InQry = InQry & Lt_Compuestos & "','" & FechaTurno.Trim & "','" & WorkCenter.Trim & "')"
                    InsertQry(InQry)
                    ' ---------------------------------------------------------------------------------
            End Select
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

    Private Sub TSobrePeso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSobrePeso.TextChanged
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
    Private Sub btnConsultaProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaProd.Click
        Try
            FrmAdminPPT.ShowDialog()
        Finally
            FrmAdminPPT.Dispose()
            FrmAdminPPT = Nothing
        End Try
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

    Private Sub rbtFinalNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub TPesoCaptura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TPesoCaptura.KeyPress
        e.Handled = txtNumerico(TPesoCaptura, e.KeyChar, True)
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

    Private Sub btnLookrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookrack.Click
        'Q = " SELECT rack, descripcion, tara FROM Racks "
        'Q = Q & " WHERE Centro = '" & strPlanta.Trim & "'"
        'Q = Q & " AND status='A'"
        'frmSpro.SPRO_TITULO = "Catalogo de RACKS"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "descripcion"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TRack.Text = frmSpro.SPRO_KEY
        '    Q = " SELECT descripcion FROM Racks"
        '    Q = Q & " WHERE Centro = '" & strPlanta.Trim & "' "
        '    Q = Q & " AND rack = '" & TRack.Text & "' AND status='A'"
        '    Descrack.Text = TraeDescripcion(Q)

        '    Q = " SELECT tara FROM Racks"
        '    Q = Q & " WHERE Centro = '" & strPlanta.Trim & "' "
        '    Q = Q & " AND rack = '" & TRack.Text & "' AND status='A'"
        '    TPesoRack.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub

    Private Sub lblFinalSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFinalSi.Click
        If rbtFinalSi.Checked = False Then
            rbtFinalSi.Checked = True
            lblFinalSi.BackColor = Color.DarkBlue
            lblFinalSi.ForeColor = Color.White
            lblFinalNo.BackColor = Me.BackColor
            lblFinalNo.ForeColor = Color.DarkBlue
            rbtFinalNo.Checked = False
        End If
    End Sub
    Private Sub lblFinalNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFinalNo.Click
        If rbtFinalNo.Checked = False Then
            rbtFinalNo.Checked = True
            lblFinalNo.BackColor = Color.DarkBlue
            lblFinalNo.ForeColor = Color.White
            lblFinalSi.BackColor = Me.BackColor
            lblFinalSi.ForeColor = Color.DarkBlue
            rbtFinalSi.Checked = False
        End If
    End Sub

    Private Sub rbtFinalSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFinalSi.Click
        If rbtFinalSi.Checked = False Then
            rbtFinalSi.Checked = True
            lblFinalSi.BackColor = Color.DarkBlue
            lblFinalSi.ForeColor = Color.White
            lblFinalNo.BackColor = Me.BackColor
            lblFinalNo.ForeColor = Color.DarkBlue
            rbtFinalNo.Checked = False
        End If
    End Sub

    Private Sub rbtFinalNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFinalNo.Click
        If rbtFinalNo.Checked = False Then
            rbtFinalNo.Checked = True
            lblFinalNo.BackColor = Color.DarkBlue
            lblFinalNo.ForeColor = Color.White
            lblFinalSi.BackColor = Me.BackColor
            lblFinalSi.ForeColor = Color.DarkBlue
            rbtFinalSi.Checked = False
        End If
    End Sub

    Private Sub btnLookcausa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookcausa.Click
        'Q = "SELECT CC.codcausagrupa, CAG.Descausagrupa FROM CatCausas CC "
        'Q = Q & " INNER JOIN CatAgrupaciones CAG ON  CC.centro = CAG.centro AND CC.codcausagrupa=CAG.codcausagrupa AND CAG.status='A'"
        'Q = Q & " WHERE CC.centro = '" & strPlanta.Trim & "' "
        'Q = Q & " AND CC.Grpprod = '" & TGrpprod.Text.Trim & "' "
        'Q = Q & " AND CC.TipoCausa = 'SP' "
        'Q = Q & " AND CC.status = 'A' "

        'frmSpro.SPRO_TITULO = "Catalogo de CAUSAS SOBREPESO"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "Descausagrupa"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TCausas.Text = frmSpro.SPRO_KEY
        '    Q = " SELECT Descausagrupa FROM CatAgrupaciones "
        '    Q = Q & " WHERE Centro = '" & strPlanta.Trim & "' "
        '    Q = Q & " AND codcausagrupa = '" & TCausas.Text & "' AND status='A'"
        '    Desccausa.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
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
        'Q = " SELECT Descausagrupa FROM CatAgrupaciones "
        'Q = Q & " WHERE Centro = '" & strPlanta.Trim & "' "
        'Q = Q & " AND codcausagrupa = '" & TCausas.Text & "' AND status='A'"
        'Desccausa.Text = TraeDescripcion(Q)
        'If TGrpprod.Text.Trim = "" Or Desccausa.Text.Trim = "" Then
        '    TCausas.Text = ""
        '    Desccausa.Text = ""
        'End If
        'TCausas.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        LimpiaObjetos()
        Close()
    End Sub

    Private Sub RB1_CheckedChanged(sender As Object, e As EventArgs) Handles RB1.CheckedChanged
        If RB1.Checked Then
            'strNumeroBascula = ValCodigoBascula.Trim
            If ValCodigoBascula.Trim = "M" Then
                TPesoCaptura.Enabled = True
                TPesoCaptura.Visible = True
                LPesoCaptura.Visible = True
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
            Else
                Timer1.Enabled = True
                Timer2.Enabled = False
                Timer3.Enabled = False
            End If
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub RB2_CheckedChanged(sender As Object, e As EventArgs) Handles RB2.CheckedChanged
        If RB2.Checked Then
            'strNumeroBascula = "BE02"
            If ValCodigoBascula_2.Trim = "M" Then
                TPesoCaptura.Enabled = True
                TPesoCaptura.Visible = True
                LPesoCaptura.Visible = True
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
            Else
                Timer1.Enabled = False
                Timer2.Enabled = True
                Timer3.Enabled = False
            End If
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub RB3_CheckedChanged(sender As Object, e As EventArgs) Handles RB3.CheckedChanged
        If RB3.Checked Then
            'strNumeroBascula = "BE03"
            If ValCodigoBascula_3.Trim = "M" Then
                TPesoCaptura.Enabled = True
                TPesoCaptura.Visible = True
                LPesoCaptura.Visible = True
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
            Else
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = True
            End If
        Else
            Timer3.Enabled = False
        End If
    End Sub
End Class