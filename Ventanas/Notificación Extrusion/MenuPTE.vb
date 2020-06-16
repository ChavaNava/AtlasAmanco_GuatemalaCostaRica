Imports System.IO
Imports System.IO.Ports.SerialPort
Imports System.IO.Ports.SerialDataReceivedEventArgs
Imports System.IO.Ports.SerialPinChangedEventArgs
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Net.Mail
Imports System.Diagnostics
Imports Utili_Generales
Imports Reporting
Imports SQL_DATA
Imports SQL_DATA.PublicVariables
Imports System.Threading
Imports Atlas.Accesos.CLVarGlobales
Imports Atlas.Accesos.Puertos
Imports Atlas.Accesos
Imports Utili_Generales.ValueText
Imports Atlas.AutorizaSobrePesos
Public Class MenuPTE

    Private EmailThread As Thread = Nothing


#Region "Variables miembro"
    Dim Clean As String
    Dim PO As New ProductionOrder_2
    Dim NP As New NotificationProcess
    Dim TipoProd As String  'T = Producto Terminado S = Scrap
    'Variables Notificación
    Dim Reprocesado_Gen As String
    Dim Conexion_SAP As String
    'Variables Identifica Scrap de Purga
    Dim arryComp() As String
    Dim R_Compuesto As String
    Dim R_Clase As String
    Dim Pass_md5 As String

    'Variables registros duplicados
    Dim SAP_dup As New Generic_SAP

#End Region

#Region "Variables"

    Dim db As New Generica_DB
    Dim SAP As New Generic_SAP
    Dim CBR As SQL_DATA.Catalogo_Racks
    '----- Variables para envio de correo ------
    Dim correo As New MailMessage()
    Dim cuerpodemensaje As String
    Dim smtp As New SmtpClient
    Dim Email As String
    '----- Variables para ingreso de orden de fabricación ------   
    'Variables Supervisor
    Dim Supervisor As String

    'Variables Sobre Peso
    Dim StatusSobrepeso As String

    ' ----------------------------------------- Variables Boton Pesar
    Dim nvoTramosNoti As Integer
    Dim nvoEmpaques As Integer

    '----- Definición de  Variables -----

    Dim StatusSap As String  'Status de conexión Atlas - SAP  
    Dim NomTabOp As String   'Variable para controlar el nombre de la tabla de Orden Producción    
    Dim Message As String = "Tecleé un numero de Orden de Producción"
    Dim Caption As String = "Campo vacio"
    Dim CountValOP As Integer 'Validacón para determinar  si la OF ya existe en la DB


    '----- Variables para  lectura de PT y compuesto asociados a la OF -----
    Dim PesoTeorico As Decimal
    Dim CantEntregada As String
    Dim ATLAS_PASS As String
    Dim xORIGINAL As String = ""
    Dim xFormato As String = "#####0.00"
    Dim xFormato2 As String = "#####0.000"

    '----- Variables para Grabado de OF  -----
    Dim Turno As String
    Dim TurnoNombre As String
    Dim HIni As String
    Dim HFin As String
    'Dim FolioSiguiente As String


    '----- Variables para Turnos  -----
    Dim FechaTurno As String

    '---- Información Bascula  -----
    Dim Cadena As String = ""
    '----  Báscula  ----

    Dim Lectura As String = ""

    '----  Compuesto  ----

    Dim Compuesto_1 As String = ""
    Dim Compuesto_2 As String = ""
    Dim CompuestoPorcent_1 As Integer = 0
    Dim CompuestoPorcent_2 As Integer = 0

    '--- Variables WS 
    Dim Lt_Compuestos As String = ""
    Dim Lt_Tintas As String = ""
    Dim Lt_Aditivos As String = ""
    Dim Lt_Anillos As String = ""
    'Dim CompOriginal As String = ""
    Dim Reprocesado_Orig As String = ""
    Dim TintaOriginal As String = ""
    Dim AditivoOriginal As String = ""
    Dim CadenaTexto As String = ""

    Dim Lista As New Generic.List(Of String)
#End Region

#Region "Constructores"
    ' Llamada necesaria para el diseñador.
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region

#Region "Metodos"

    Private Sub Limpia_Variables()
        Btn_Notificar = "1"
    End Sub
    Private Sub LimpiaObjetos()
        Lista.Clear()
        Clean = "1"
        cmbProceso.Checked = False
        FrontUtils.LimpiarText(Me)
        CB_Com2.Enabled = False
        CB_Rack.DataSource = Nothing
        CB_Com1.DataSource = Nothing
        TPComp2.Enabled = False
        TPComp1.Text = "100"
        NPTExtrusion.iCompuesto1 = "0"
        TPComp2.Text = "0"
        CB_Com2.Text = ""

        TCausas.Text = "0"
        TCCausas.Text = "0"
        TCDefecto.Text = "0"
        TCScrap.Text = "0"
        CB_Ope.DataSource = Nothing
        TOrden.Text = ""                'Orden Producción
        TtramosNoti.Text = "0"          'Tramos por Notificar
        CB_Rack.Text = "M"              'Rack
        TPesoRack.Text = "0"            'Peso Rack
        TempaquePesoTot.Text = "0"      'Peso Total de empaques
        CB_Ope.Text = ""
        TFolioAtlas.Text = "0"
        TDocSAP.Text = "0"
        TConSAP.Text = "0"
        TFolioVale.Text = "00000"
        ' ---------------------------------------------------------------------------------
        RB_SC.Checked = False
        ' ---------------------------------------------------------------------------------
        TPesoCaptura.Text = "0.00" 'Peso Bruto Manual
        TPesoBruto.Text = "0.00"
        TPesoTara.Text = "0.00"
        TPesoNeto.Text = "0.00"
        ' ---------------------------------------------------------------------------------
        TCantProgra.Text = "0"       'Programada
        TCantEntre.Text = "0"        'Entregada
        TCantEnproce.Text = "0"      'Entregada
        TCantPendiente.Text = "0"    'Pendiente

        ' ---------------------------------------------------------------------------------
        Label8.Text = ""
        ' ---------------------------------------------------------------------------------
        SP = "0"
        Autoriza_SP = ""
        ' ---------------------------------------------------------------------------------
        'Se carga catalogos de Racks's
        Catalogo_Racks.Combo_Rack(CB_Rack, SessionUser._sCentro, SessionUser._sAlias)
        ' ---------------------------------------------------------------------------------
        BPesar.Enabled = False
        BImprimir.Enabled = False
        Clean = "0"
        Btn_Notificar = "0"
        PassNotifier.Focus()
    End Sub
    Private Sub Asigna_Turno()
        ' ---------------------------------------------------------------------------------
        'Se asigna turno que corresponde acorde al horario
        Dim HReal As String = DateTime.Now.ToString("HH:mm:ss")
        Catalogo_Turnos.Combo_Turnos(cmbTurnos)
        Catalogo_Turnos.Asigna_turno(cmbTurnos, HReal)
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
        SobrepesoPermitido = "0" & TSP_Permitido.Text.Trim
        PorcentajeSobrePeso = 0
        If PesoTeorico > 0 And xTramosNoti > 0 Then
            xPSP = (((xPeso_Neto / (PesoTeorico * xTramosNoti)) - 1) * 100)
            PorcentajeSobrePeso = Format(xPSP, xFormato)
        Else
            PorcentajeSobrePeso = Format(100, xFormato)
        End If
        EstatusAutoriza = 0
        TSobrePeso.Text = Format(PorcentajeSobrePeso, "#0.00")
        If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
            'FormSobrePesoTf.Label1.ForeColor = Color.RoyalBlue
            'FormSobrePesoTf.Label2.ForeColor = Color.RoyalBlue
            'FormSobrePesoTf.Label1.Text = "El pesaje  se  encuentra fuera de rango. "
            'FormSobrePesoTf.Label2.Text = "Por lo tanto se necesita  la autorización del supervisor en turno."
            'FormSobrePesoTf.ShowDialog()
        End If
        If EstatusAutoriza > 0 Then

            Select Case EstatusAutoriza
                Case Is = 1 ' "SI" Autoriza Supervisor
                    StatusSobrepeso = "Aceptado"
                Case Is = 2 ' " NO " Autoriza Supervisor
                    StatusSobrepeso = "Rechazado"
            End Select

            ' ---------------------------------------------------------------------------------
            InQry = ""
            InQry = "INSERT INTO MCPT_AutorizacionSobrepeso (Orden_produccion,Fecha_Pesaje,Hora_Pesaje,Bascula,Rack,Tramos,"
            InQry = InQry & "Empaques,Peso_Bruto,Tara,Peso_Neto,Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,"
            InQry = InQry & "Recibe_Almacen,Autoriza_Sobrepeso,Estatus_Autorizacion,Observaciones,PorSobrePeso,CausasSobrepeso,"
            InQry = InQry & "Compuesto1,Porcentaje1,Compuesto2,Porcentaje2,LTCompuestos, Fecha_turno, Puestotrabajo) Values "
            InQry = InQry & "('" & TOrden.Text.Trim & "','" & NPTExtrusion._iFechaPesaje.Trim & "','" & NPTExtrusion._iHoraPesaje.Trim & "',"
            InQry = InQry & "'" & ValCodigoBascula.Trim & "','" & TPesoRack.Text.Trim & "','" & nvoTramosNoti & "',"
            InQry = InQry & "" & nvoEmpaques & ",'" & NPTExtrusion._iPB & "','" & NPTExtrusion._iPT & "','" & NPTExtrusion._iPN & "',"
            InQry = InQry & "'" & CodOperador.Text.Trim & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "',"
            InQry = InQry & "'" & SessionUser._sCentro.Trim & "','" & Folio_SP & "','" & "S/N" & " ',' " & "S/N" & "',"
            InQry = InQry & "'" & SuperAutoSobrepeso.Trim & "','0','" & ObserSobrepeso.Trim & "',"
            InQry = InQry & "'" & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & "','" & TCausas.Text.Trim & "',"
            InQry = InQry & "'" & Compuesto_1.Trim & "','" & CompuestoPorcent_1 & "','" & Compuesto_2.Trim & "',"
            InQry = InQry & "'" & CompuestoPorcent_2 & "','" & Lt_Compuestos & "','" & FechaTurno.Trim & "',"
            InQry = InQry & "'" & WorkCenter.Trim & "')"
            InsertQry(InQry)

            InQry = ""
            InQry = "Update MCPC_Foliador set sobrepeso = '" & Folio_SP.Trim & "'"
            InQry = InQry & " where Planta = '" & SessionUser._sCentro.Trim & "'"
            InsertQry(InQry)
            ' ---------------------------------------------------------------------------------
            'End Select

            Select Case SessionUser._sCentro

                Case Is = "A001"

                    'Generación del formato para el cuerpo del correo

                    Email = ""
                    Email = Email & "Reporte de Sobre Peso " & vbCr & ""
                    Email = Email & "" & vbCr & ""
                    Email = Email & "Numero ODF:            " & TOrden.Text.Trim & " " & vbCr & ""
                    Email = Email & "Folio Atlas:           " & FolioNotifica._rIdFolio.Trim & " " & vbCr & ""
                    Email = Email & "Status Autorización:   " & StatusSobrepeso.Trim & " " & vbCr & ""
                    Email = Email & "Producto:              " & TCodPT.Text.Trim & " " & vbCr & ""
                    Email = Email & "Descripción:           " & TCodPtDecr.Text.Trim & " " & vbCr & ""
                    Email = Email & "Fecha:                 " & Date.Today.ToString("yyyy-MM-dd") & " " & vbCr & ""
                    Email = Email & "Hora:                  " & Date.Now.TimeOfDay.ToString.Substring(0, 8) & " " & vbCr & ""
                    Email = Email & "Rack:                  " & CB_Rack.Text.Trim & " " & vbCr & ""
                    Email = Email & "Tramos:                " & nvoTramosNoti & " " & vbCr & ""
                    Email = Email & "Peso Bruto:            " & TPesoBruto.Text.Trim & " " & vbCr & ""
                    Email = Email & "Peso Tara:             " & TPesoTara.Text.Trim & " " & vbCr & ""
                    Email = Email & "Peso Neto:             " & TPesoNeto.Text.Trim & " " & vbCr & ""
                    Email = Email & "Sobre Peso:            " & TSobrePeso.Text.Trim & " '%' " & vbCr & ""
                    Email = Email & "" & vbCr & ""
                    Email = Email & "Usuario Notifica:      " & SessionUser._sAlias.Trim & " " & vbCr & ""
                    Email = Email & "Supervisor Autoriza:   " & SuperAutoSobrepeso.Trim & " " & vbCr & ""
                    Email = Email & "Maquina:               " & TPtoTrabajo.Text.Trim & " " & vbCr & ""
                    Email = Email & "Turno:                 " & Turno.Trim & " " & vbCr & ""
                    Email = Email & "Observación:           " & ObserSobrepeso.Trim & " " & vbCr & ""
                    Email = Email & "Causa Sobre Peso:      " & TCausas.Text.Trim & " " & TCausas.Text.Trim & ""

                    'Preparación para el envio del correo
                    Select Case SessionUser._sCentro
                        Case Is = "A001"
                            correo.From = New MailAddress("atlas_amanmex@mexichem.com", "Amanco Mexico")
                        Case Is = "A013"
                            correo.From = New MailAddress("atlas_amanmex@mexichem.com", "Amanco Mexico")
                    End Select


                    If SessionUser._sAlias.Trim = "ATLAS" Then
                        correo.To.Add("jsalinas@mexichem.com")
                    Else
                        Select Case SessionUser._sCentro
                            Case Is = "A001"
                                correo.To.Add("facosta@mexichem.com")
                                correo.CC.Add("jcescobar@mexichem.com")
                                correo.CC.Add("zpalomino@mexichem.com")
                                correo.CC.Add("esarabia@mexichem.com")
                                correo.CC.Add("masanchezc@mexichem.com")
                                correo.CC.Add("jmgonzalez@mexichem.com")
                                correo.CC.Add("goliva@mexichem.com")
                                correo.CC.Add("arruizh@mexichem.com")
                                correo.CC.Add("agrajeda@mexichem.com")
                                'correo.CC.Add("jsalinas@mexichem.com")
                            Case Is = "A013"
                                correo.To.Add("ggonzalezg@mexichem.com")
                                correo.CC.Add("agea@mexichem.com")
                                correo.CC.Add("econtrerasp@mexichem.com")
                                correo.CC.Add("atorresl@mexichem.com")
                        End Select
                    End If

                    correo.Subject = "Notificación de Sobre Peso en Producto Terminado de la ODF " & TOrden.Text.Trim & ""
                    'correo.Attachments.Add(New Attachment("C:\Sobrepeso_" & FolioSiguiente & ".txt"))
                    correo.Body = Email
                    correo.IsBodyHtml = False
                    Select Case SessionUser._sCentro
                        Case Is = "A001"
                            smtp.Host = "ammxlonw002.mexichem.corp"
                            smtp.Port = 25
                            smtp.EnableSsl = False
                            smtp.Credentials = New System.Net.NetworkCredential("atlasleon@mexichem.com", "leona0358")
                        Case Is = "A013"
                            smtp.Host = "TFMXCUW001.mexichem.corp"
                            smtp.Port = 25
                            smtp.EnableSsl = False
                            smtp.Credentials = New System.Net.NetworkCredential("atlas_amanmex@mexichem.com", "extrusion0127")
                    End Select

                    Try
                        smtp.Send(correo)
                        MsgBox("Mensaje enviado satisfactoriamente")
                        correo.Dispose()
                    Catch ex As Exception
                        MsgBox("ERROR: " & ex.Message)
                    End Try

            End Select

        Else
            SuperAutoSobrepeso = "S/N"
        End If
    End Sub

    Private Function DeterminaTipoPT() As Boolean
        Select Case SessionUser._sCentro.Trim
            Case Is = "PE01", "PE12"
                If cmbProceso.Checked = True Then
                    NPTExtrusion.iTipoPT = "P"
                    NPTExtrusion.iNotifica = "3"
                    DeterminaTipoPT = True
                ElseIf cmbProceso.Checked = False Then
                    NPTExtrusion.iTipoPT = "T"
                    NPTExtrusion.iNotifica = "0"
                    DeterminaTipoPT = True
                Else
                    NPTExtrusion.iTipoPT = ""
                    NPTExtrusion.iNotifica = "0"
                    DeterminaTipoPT = False
                End If
            Case Else
                If cmbProceso.Checked = True Then
                    NPTExtrusion.iTipoPT = "T"
                    NPTExtrusion.iNotifica = "0"
                    DeterminaTipoPT = True
                ElseIf cmbProceso.Checked = False Then
                    NPTExtrusion.iTipoPT = "T"
                    NPTExtrusion.iNotifica = "0"
                    DeterminaTipoPT = True
                Else
                    NPTExtrusion.iTipoPT = ""
                    NPTExtrusion.iNotifica = "0"
                    DeterminaTipoPT = False
                End If
        End Select

    End Function
    Private Sub Notifica_PT()
        Limpia_Variables()
        Asigna_Turno()
        Conexion_SAP = SAP_Conexion.Estatus(Seccion)
        If TPesoTeorico.Text = "" Then
            MensajeBox.Mostrar("El producto no tiene Peso Teorico Avise al Administrador", "Aviso", MensajeBox.TipoMensaje.Information)
            Exit Sub
        End If

        If TtramosNoti.Text = 0 Then
            MensajeBox.Mostrar("No se a asignado cantidad de producto a notifica", "Aviso", MensajeBox.TipoMensaje.Information)
            TtramosNoti.Focus()
            Exit Sub
        End If

        'Se asigna valor a variables -------------------------------------------------------------

        NPTExtrusion.iOrdenProduccion = TOrden.Text.Trim
        NPTExtrusion.iUsuario = CodOperador.Text.Trim
        NPTExtrusion.iTramos = TtramosNoti.Text.Trim
        NPTExtrusion.iIdRack = CB_Rack.Text.Trim
        NPTExtrusion.iPB = TPesoBruto.Text.Trim
        NPTExtrusion.iPT = TPesoTara.Text.Trim
        NPTExtrusion.iPN = TPesoNeto.Text.Trim
        NPTExtrusion.iIdBascula = ValCodigoBascula
        NPTExtrusion.iPuestoTrabajo = TPtoTrabajo.Text.Trim
        NPTExtrusion.iEstatusSobrePeso = "0"
        NPTExtrusion.iEmpaques = "0"
        NPTExtrusion.iFechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        NPTExtrusion.iHoraPesaje = Date.Now.TimeOfDay.ToString()
        NPTExtrusion.iTurno = cmbTurnos.Text.Trim
        NPTExtrusion.iPesoTeorico = TPesoTeorico.Text.Trim
        NPTExtrusion.iIdOperadorPtoTra = CB_Ope.SelectedValue
        NPTExtrusion.iFechaTurno = dtpFECHA.Value.ToString("yyyy-MM-dd")
        NPTExtrusion.iSobrePeso = Format(Val(TSobrePeso.Text), xFormato)
        NPTExtrusion.iFechaPesajeSAP = dtpFECHASAP.Value.ToString("yyyyMMdd")
        NPTExtrusion.iTipoCausa = CB_SP_Causa.SelectedValue
        NPTExtrusion.iArea = "E"
        NPTExtrusion.iFolioVale = TFolioVale.Text
        NPTExtrusion.iVersion = Atlas_Version.Version
        NPTExtrusion.iSupervisor = "Supervisor"

        If DeterminaTipoPT() = False Then
            MensajeBox.Mostrar("No puede determinar el tipo de producción informe a su supervisor", "Aviso", MensajeBox.TipoMensaje.Information)
            Return
        End If

        If P_OP = True Then
            NPTExtrusion.iIdOperadorPtoTra = CB_Ope.SelectedValue
        Else
            NPTExtrusion.iIdOperadorPtoTra = "N/A"
        End If

        If NPTExtrusion._iTipoCausa = Nothing Then
            NPTExtrusion.iTipoCausa = "0"
        End If
        'Se valida peso bascula -------------------------------------------------------------------
        If ValidacionesBascula.ValidaPeso(NPTExtrusion._iPB, NPTExtrusion._iPT, NPTExtrusion._iPN) = False Then
            Exit Sub
        End If

        LSP = SobrepesoPermitido
        LBP = SobrepesoPermitido * -1
        EstatusAutoriza = 0

        Select Case P_SP
            Case Is = True
                If (PorcentajeSobrePeso < LBP Or PorcentajeSobrePeso > LSP) Then
                    If TCausas.Text.Trim = 0 Then
                        MensajeBox.Mostrar("Seleccione una CAUSA de SOBREPESO ", "Aviso", MensajeBox.TipoMensaje.Information)
                        CB_SP_Causa.Enabled = True
                        TCausas.Enabled = True
                        Catalogo_Causas.Combo_Causas(CB_SP_Causa, "", Seccion.Trim, "SP", False)
                        TCausas.Focus()
                        Return
                    Else
                        EstatusAutoriza = 2
                        Dim FrmSobreBajoPeso As New Atlas.AutorizaSobrePesos.AutorizaSobrepeso
                        FrmSobreBajoPeso.ShowDialog()
                        Select Case EstatusAutoriza
                            Case Is = 1
                                RegistrarSBP.Orden = TOrden.Text.Trim
                                RegistrarSBP.Sobrepeso = TSobrePeso.Text.Trim
                                RegistrarSBP.Causa = CB_SP_Causa.SelectedValue
                                RegistrarSBP.Aviso = 0
                            Case Is = 2
                                MensajeBox.Mostrar("El Sobre/Bajopeso no ha sido autorizado", "Sobre/Bajopeso", MensajeBox.TipoMensaje.Information)
                                LimpiaObjetos()
                                Exit Sub
                        End Select
                    End If
                End If
        End Select


        'Se asigna valor a variables de consumo compuestos 1, 2 -----------------------------------
        Dim aryTextFile() As String
        Dim Stat_Comp As Boolean

        NPTExtrusion.iCompuesto1 = CB_Com1.SelectedValue
        NPTExtrusion.iCompuesto2 = CB_Com2.SelectedValue

        aryTextFile = ValidacionesCompuestos.ValidaCompuestos_Extrusion(NPTExtrusion._iPN, NPTExtrusion._iCompuesto1, TPComp1.Text, NPTExtrusion._iCompuesto2, TPComp2.Text).Split("|")
        Stat_Comp = aryTextFile(0)
        If Stat_Comp = False Then
            Exit Sub
        Else
            NPTExtrusion.iComp1 = aryTextFile(1)
            NPTExtrusion.iPorc1 = aryTextFile(2)
            NPTExtrusion.iCant1 = aryTextFile(3)
            NPTExtrusion.iComp2 = aryTextFile(4)
            NPTExtrusion.iPorc2 = aryTextFile(5)
            NPTExtrusion.iCant2 = aryTextFile(6)

            Lista.Clear()

            If NPTExtrusion.iComp1.Trim <> 0 Then
                Lista.Add(Util.QuitarCerosIzquierda(NPTExtrusion._iComp1.Trim) + "|" + NPTExtrusion._iCant1.Trim)
            End If

            If NPTExtrusion.iComp2.Trim <> 0 Then
                Lista.Add(Util.QuitarCerosIzquierda(NPTExtrusion._iComp2.Trim) + "|" + NPTExtrusion._iCant2.Trim)
            End If

        End If
        'Se verifica conexión con SAP --------------------------------------------------------------------------
        Permiso.SAP_Status("E", tsImagen)
        'Identificar Supervisor en Turno ---------------------------------------------------------
        NP.Identifies_shift_supervisor(Date.Today.ToString("yyyy-MM-dd"), cmbTurnos.Text.Trim)
        'Identificar Compuesto original de la bom ------------------------------------------------
        Dim IdComEstatus As Boolean
        If P_CC1 = False Then
            CompuestoVirgen.IdCompOriginal = "0"
        Else
            IdComEstatus = CatalogosOperacion.Compuesto_Bom(TCodPT.Text.Trim)
            If IdComEstatus = False Then
                MsgBox("Este producto no tiene asignado compuesto virgen para su consumo", MsgBoxStyle.Critical)
                Return
            End If
        End If

        LecturaBD.Close()
        BPesar.Enabled = False
        BSiguiente.Enabled = False
        '----------------------------------------- Inicio : Identificar si el producto usa empaques
        NPTExtrusion.iEmpaques = Produccion_Scrap_Extrusion.Empaques(TCodAnillo.Text.Trim, NPTExtrusion.iTramos)
        '------------------------------------------- Fin : Identificar si el producto usa empaques
        'Se ingresa información de notificacion en la base de datos ------------------------------

        Try
            FolioNotifica.rIdFolio = OperacionExtrusion.Notifica_PT
            TFolioAtlas.Text = FolioNotifica._rIdFolio
        Catch ex As Exception
            LoadingForm.CloseForm()
            MensajeBox.Mostrar(ex.Message, "Error Intente Nuevamente", MensajeBox.TipoMensaje.Critical)
            BtnActualiza.Enabled = True
            BtnActualiza.Focus()
            Return
        End Try

        'Se registra el Sobre / Bajo Peso
        If P_SP = True And EstatusAutoriza = 1 Then
            RegistrarSBP.FolioAtlas = FolioNotifica._rIdFolio.Trim
            ReportOverweight.Notification(1)
            ''Envio de correo notificando de sobrepeso
            EmailSBP.Orden = TOrden.Text.Trim
            EmailSBP.Producto = TCodPT.Text.Trim & " " & TCodPtDecr.Text.Trim
            EmailSBP.FolioAtlas = FolioNotifica._rIdFolio.Trim
            EmailSBP.Justifica = RegistrarSBP._Observacion
            EmailSBP.FH = Date.Today.ToString("yyyy-MM-dd")
            EmailSBP.PB = NPTExtrusion._iPB
            EmailSBP.PT = NPTExtrusion._iPT
            EmailSBP.PN = NPTExtrusion._iPN
            EmailSBP.SBPKilos = KilosSobrepeso
            EmailSBP.SBPPorcentaje = Format(Val(TSobrePeso.Text), xFormato)
            EmailSBP.Centro = SessionUser._sCentro.Trim
            EmailSBP.IdAccion = 1
            Sobrepesos.Email()
        End If
        'Se valida que no este activo el check box de en proceso
        If cmbProceso.Checked = True Then
            LoadingForm.CloseForm()
            MensajeBox.Mostrar("Producción se registra en proceso", "Producción en Proceso", MensajeBox.TipoMensaje.Information)
            ProduccionSeparada()
        Else
            'Se verifica status de conexión y se determina si se envia a SAP o no --------------------
            Select Case Conexion_SAP
                Case "False"
                    LoadingForm.CloseForm()
                    MsgBox(" No se realizara notificación a SAP se encuntra deshabilitada la conexión ")
                    TDocSAP.Text = "0000000000"
                    TConSAP.Text = "00000000"
                Case "True"
                    Select Case chkSAP.Checked
                        Case True
                            'Se arma la cadena del Header de verificacion de duplicados
                            Header_Duplicado = "74" + _
                                            "|" + "CO15" + _
                                            "|" + TOrden.Text.Trim + _
                                            "|" + SessionUser._sAlias.Trim + _
                                            "|" + FolioNotifica._rIdFolio.Trim
                            'Variables WS Duplicados
                            Dim Err_dup As String = ""
                            Dim Mns_dup As String = ""
                            Dim Return_dup As Object
                            Dim Tbl_dup As String()
                            WS_P.Consume_WS(Header_Duplicado, Lista, SessionUser._sAmbiente)
                            Tbl_dup = WS_P.Tbl_resultado
                            Return_dup = WS_P.Return_SAP
                            Err_dup = Return_dup.ZTYPE
                            Mns_dup = Return_dup.ZMESSAGE

                            Select Case Err_dup
                                '------Si no existe la notificacion regresa Error y se realiza la notificación normal
                                Case Is = "E"
                                    'Lectura de WS Generico para realizar la notificación ------------------------------------
                                    Label12.Visible = True
                                    Label12.Text = "Se esta Notificando la orden '" & TOrden.Text.Trim & "' a SAP"
                                    Dim Head As String
                                    Head = "28|" + TOrden.Text.Trim + "|" + NPTExtrusion._iTramos.ToString + "|" + NPTExtrusion._iFechaPesajeSAP.Trim + "|" + CompuestoVirgen._IdCompOriginal.Trim + "|" + "P" + "|" + SessionUser._sAlias.Trim + "|" + FolioNotifica._rIdFolio.Trim
                                    NotificationProcess.Notifica_PTE(Head, Lista, FolioNotifica._rIdFolio.Trim, TDocSAP, TConSAP, BPesar, BImprimir, TOrden, PassNotifier.Text.Trim)
                                    Label12.Visible = False
                                    Label12.Text = ""
                                Case Else
                                    '------Si fue notificado se actualiza el registro
                                    Dim Doc_Con_dup As String = ""
                                    Dim reg As String = ""

                                    Doc_Con_dup = Tbl_dup(0)
                                    SAP_dup.agregarConsecutivosSAP(Doc_Con_dup)
                                    reg = "1"
                                    InQry = ""
                                    InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set Notifica = '" & reg.Trim & "', "
                                    InQry = InQry & "notificacionmasiva = '" & reg.Trim & "', "
                                    InQry = InQry & "Documento_SAP = '" & SAP_dup.DocumentoSAP & "', "
                                    InQry = InQry & "Consecutivo_SAP = '" & SAP_dup.ConsecutivoSAP & "' "
                                    InQry = InQry & " Where Folio = '" & FolioNotifica._rIdFolio.Trim & "'"
                                    InsertQry(InQry)
                                    '------Fin Se ejecuta el WS verificacion duplicados
                            End Select
                        Case False
                            LoadingForm.CloseForm()
                            MsgBox(" No se realizara notificación a SAP se encuntra deshabilitada la conexión ")
                            TDocSAP.Text = "0000000000"
                            TConSAP.Text = "00000000"
                    End Select
            End Select
        End If
      
        'Consulta cantidades
        ProductionOrder.CalCantExt(TOrden.Text.Trim, TCantProgra, TCantEntre, TCantEnproce, TCantPendiente, EXTINY)
        'Porcentaje de avance de la orden
        ProductionOrder_2.Porcentaje_Orden(TCantEntre.Text, TCantEnproce.Text, TCantProgra.Text, Label8)
        BSiguiente.Enabled = True
        BImprimir.Enabled = True

    End Sub
    Private Sub Notifica_SC()
        Conexion_SAP = SAP_Conexion.Estatus(Seccion)
        Dim Lt_Compuestos As String = ""
        If CB_Causas.Text = "" Then
            LoadingForm.CloseForm()
            MensajeBox.Mostrar("Seleccione una Causa de Scrap", "Aviso", MensajeBox.TipoMensaje.Information)
            CB_Causas.Focus()
            Return
        End If

        If CB_Defecto.Text = "" Then
            LoadingForm.CloseForm()
            MensajeBox.Mostrar("Seleccione un Defecto de Scrap", "Aviso", MensajeBox.TipoMensaje.Information)
            CB_Defecto.Focus()
            Return
        End If

        If CB_TipoSc.Text = "" Then
            LoadingForm.CloseForm()
            MensajeBox.Mostrar("Seleccione el tipo de Scrap", "Aviso", MensajeBox.TipoMensaje.Information)
            CB_Defecto.Focus()
            Return
        End If

        'Se asigna valor a variables -------------------------------------------------------------
        NPTExtrusion.iCentro = SessionUser._sCentro.Trim
        NPTExtrusion.iOrdenProduccion = TOrden.Text.Trim
        NPTExtrusion.iUsuario = CodOperador.Text.Trim
        NPTExtrusion.iTramos = TtramosNoti.Text.Trim
        NPTExtrusion.iIdRack = CB_Rack.Text.Trim
        NPTExtrusion.iPB = TPesoBruto.Text.Trim
        NPTExtrusion.iPT = TPesoTara.Text.Trim
        NPTExtrusion.iPN = TPesoNeto.Text.Trim
        NPTExtrusion.iIdBascula = ValCodigoBascula
        NPTExtrusion.iPuestoTrabajo = TPtoTrabajo.Text.Trim
        NPTExtrusion.iPesoTeorico = TPesoTeorico.Text.Trim
        NPTExtrusion.iFechaPesajeSAP_CR = dtpFECHASAP.Value.ToString("yyyy-MM-dd")
        NPTExtrusion.iFechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        NPTExtrusion.iHoraPesaje = Date.Now.TimeOfDay.ToString()
        NPTExtrusion.iFechaTurno = dtpFECHA.Value.ToString("yyyy-MM-dd")
        NPTExtrusion.iTurno = cmbTurnos.Text.Trim
        NPTExtrusion.iFechaPesajeSAP = dtpFECHASAP.Value.ToString("yyyyMMdd")
        NPTExtrusion.iTipoScrap = CB_TipoSc.SelectedValue.Trim
        NPTExtrusion.iArea = "E"
        NPTExtrusion.iRepGenerado = "0"
        NPTExtrusion.iVersion = Atlas_Version.Version
        NPTExtrusion.iSupervisor = "Supervisor"
        NPTExtrusion.iIdCausa = TCCausas.Text.Trim
        NPTExtrusion.iIdDefecto = TCDefecto.Text.Trim

        If CB_Ope.SelectedValue = Nothing Then
            NPTExtrusion.iIdOperadorPtoTra = "Operador"
        Else
            NPTExtrusion.iIdOperadorPtoTra = CB_Ope.SelectedValue
        End If
        'Se valida valores de pesos --------------------------------------------------------------
        If (NPTExtrusion._iPN <= 0) Then
            LoadingForm.CloseForm()
            MensajeBox.Mostrar("***  Peso NETO es menor o igual a cero  ***", "Aviso", MensajeBox.TipoMensaje.Information)
            Exit Sub
        End If

        If (NPTExtrusion._iPB <= 0) Then
            LoadingForm.CloseForm()
            MensajeBox.Mostrar("***  Peso BRUTO es menor o igual a cero  ***", "Aviso", MensajeBox.TipoMensaje.Information)
            Exit Sub
        End If

        If (NPTExtrusion._iPB < NPTExtrusion._iPT) Or (NPTExtrusion._iPB < NPTExtrusion._iPN) Then
            LoadingForm.CloseForm()
            MensajeBox.Mostrar("***  El Peso Bruto debe ser mayor que La Tara y/o Peso Neto ***", "Aviso", MensajeBox.TipoMensaje.Information)
            Exit Sub
        End If
        'Se asigna valor a variables de consumo compuestos 1, 2 y 3 --------------------------------------
        Dim aryTextFile() As String
        Dim Stat_Comp As Boolean

        NPTExtrusion.iCompuesto1 = CB_Com1.SelectedValue
        NPTExtrusion.iCompuesto2 = CB_Com2.SelectedValue

        aryTextFile = ValidacionesCompuestos.ValidaCompuestos_Extrusion(NPTExtrusion._iPN, NPTExtrusion._iCompuesto1, TPComp1.Text, NPTExtrusion._iCompuesto2, TPComp2.Text).Split("|")
        Stat_Comp = aryTextFile(0)
        If Stat_Comp = False Then
            Exit Sub
        Else
            NPTExtrusion.iComp1 = aryTextFile(1)
            NPTExtrusion.iPorc1 = aryTextFile(2)
            NPTExtrusion.iCant1 = aryTextFile(3)
            NPTExtrusion.iComp2 = aryTextFile(4)
            NPTExtrusion.iPorc2 = aryTextFile(5)
            NPTExtrusion.iCant2 = aryTextFile(6)

            Lista.Clear()

            If NPTExtrusion.iComp1.Trim <> 0 Then
                Lista.Add(Util.QuitarCerosIzquierda(NPTExtrusion._iComp1.Trim) + "|" + NPTExtrusion._iCant1.Trim)
            End If

            If NPTExtrusion.iComp2.Trim <> 0 Then
                Lista.Add(Util.QuitarCerosIzquierda(NPTExtrusion._iComp2.Trim) + "|" + NPTExtrusion._iCant2.Trim)
            End If

        End If
        'Se verifica conexión con SAP --------------------------------------------------------------------------
        Permiso.SAP_Status("E", tsImagen)
        'Identificar Supervisor en Turno -----------------------------------------------------------------------
        NP.Identifies_shift_supervisor(Date.Today.ToString("yyyy-MM-dd"), cmbTurnos.Text.Trim)
        'Identificar Compuesto original de la bom ------------------------------------------------
        Dim IdComEstatus As Boolean
        If P_CC1 = False Then
            CompuestoVirgen.IdCompOriginal = "0"
        Else
            IdComEstatus = CatalogosOperacion.Compuesto_Bom(TCodPT.Text.Trim)
            If IdComEstatus = False Then
                LoadingForm.CloseForm()
                MsgBox("Este producto no tiene asignado compuesto virgen para su consumo", MsgBoxStyle.Critical)
                Return
            End If
        End If

        If CompuestoVirgen._IdCompOriginal.Trim = NPTExtrusion._iCompuesto1.Trim And TPComp1.Text = 100 Then
            Lt_Compuestos = ""
        ElseIf CompuestoVirgen._IdCompOriginal.Trim <> NPTExtrusion._iCompuesto1.Trim And TPComp1.Text = 100 Then
            Lt_Compuestos = CompuestoVirgen._IdCompOriginal.Trim & "|" & TPComp1.Text & "|" & NPTExtrusion._iCompuesto1.Trim
        ElseIf TPComp1.Text < 100 Then
            Lt_Compuestos = CompuestoVirgen._IdCompOriginal.Trim & "|" & TPComp1.Text & "|" & NPTExtrusion._iCompuesto1.Trim & "||" & CompuestoVirgen._IdCompOriginal.Trim & "|" & TPComp2.Text & "|" & NPTExtrusion._iCompuesto2.Trim
            If NPTExtrusion._iCompuesto2.Trim = "" Then
                LoadingForm.CloseForm()
                MensajeBox.Mostrar("Selecciones un segundo compuesto", "Aviso", MensajeBox.TipoMensaje.Information)
                Return
            End If
        End If
        NPTExtrusion.iLtCompuestos = Lt_Compuestos
        'Identifica si el compuesto es de paros y arranques o normal
        Reprocesado_Gen = NotificationProcess.Identifica_Reprocesado(NPTExtrusion._iCompuesto1.Trim)
        'Se deshabilta boton de Notificación para evitar duplicidad
        BPesar.Enabled = False
        'Se ingresa información de notificacion en la base de datos --------------------------------------------
        'Se crea el folio correspondiente al pesaje

        Try
            FolioNotifica.rIdFolio = OperacionExtrusion.Notifica_SC
            TFolioAtlas.Text = FolioNotifica._rIdFolio
        Catch ex As Exception
            LoadingForm.CloseForm()
            MensajeBox.Mostrar(ex.Message, "Error Intente Nuevamente", MensajeBox.TipoMensaje.Critical)
            BtnActualiza.Enabled = True
            BtnActualiza.Focus()
            Return
        End Try
        TFolioAtlas.Text = FolioNotifica._rIdFolio.Trim
        Select Case Conexion_SAP
            Case "False"
                LoadingForm.CloseForm()
                MsgBox(" No se realizara notificación a SAP se encuentra deshabilitada la conexión ")
                TDocSAP.Text = "0000000000"
                TConSAP.Text = "00000000"
            Case "True"
                Select Case chkSAP.Checked
                    Case True
                        If NPTExtrusion._iCentro = "A001" Or NPTExtrusion._iCentro = "CR01" Then
                            LoadingForm.CloseForm()
                            Label12.Visible = True
                            Label12.Text = "Se esta Notificando la orden '" & TOrden.Text.Trim & "' a SAP"
                            CadenaTexto = SessionUser._sAlias.Trim & "|" & FolioNotifica._rIdFolio.Trim
                            Consume_WS_CR01(SessionUser._sAlias, SessionUser._sAmbiente, CadenaTexto.Trim, Lt_Compuestos.Trim, NPTExtrusion._iFechaPesajeSAP_CR.Trim, TOrden.Text.Trim, TPesoNeto.Text, FolioNotifica._rIdFolio.Trim)
                            Label12.Visible = False
                            Label12.Text = ""
                        Else
                            LoadingForm.CloseForm()
                            Label12.Visible = True
                            Label12.Text = "Se esta Notificando la orden '" & TOrden.Text.Trim & "' a SAP"
                            Dim Head As String
                            Head = "28|" + TOrden.Text.Trim + _
                                     "|" + TPesoNeto.Text.Trim + _
                                     "|" + NPTExtrusion._iFechaPesajeSAP.Trim + _
                                     "|" + CompuestoVirgen._IdCompOriginal.Trim + _
                                     "|" + "S" + _
                                     "|" + SessionUser._sAlias.Trim + _
                                     "|" + FolioNotifica._rIdFolio.Trim + _
                                     "|" + Reprocesado_Gen
                            NotificationProcess.Notifica_SCE(Head, Lista, FolioNotifica._rIdFolio.Trim, TDocSAP, TConSAP, BPesar, BImprimir, TOrden, _
                                                             CodOperador.Text.Trim)
                            Label12.Visible = False
                            Label12.Text = ""
                        End If
                        'Lectura de WS Generico para realizar la notificación ------------------------------------
                    Case False
                        LoadingForm.CloseForm()
                        MsgBox(" No se realizara notificación a SAP se encuntra deshabilitada la conexión ")
                        TDocSAP.Text = "0000000000"
                        TConSAP.Text = "00000000"
                End Select
        End Select
    End Sub
    Private Sub Parametrizacion_Forma()
        tsbMonitor.Enabled = P_MP
        dtpFECHASAP.Visible = P_CS
        dtpFECHASAP.Enabled = P_CS
        chkSAP.Visible = P_CS
        chkSAP.Enabled = P_CS
        Label16.Visible = P_OP
        CB_Ope.Visible = P_OP
        CB_Com1.Enabled = P_CC1
        TPComp1.Enabled = P_CC1
        TPComp1.Text = "100"
        CB_Manual.Visible = P_NM
        GB_Basculas.Enabled = P_MB
        cmbProceso.Enabled = P_PR
        cmbProceso.Visible = P_PR
        If P_CD = True Then
            Label5.Location = New Point(731, 275)
            TCausas.Location = New Point(722, 294)
            CB_SP_Causa.Location = New Point(800, 294)
            TCCausas.Location = New Point(722, 320)
            CB_Causas.Location = New Point(800, 320)
            TCDefecto.Location = New Point(722, 346)
            CB_Defecto.Location = New Point(800, 346)
            If SessionUser._sCentro.Trim = "PE01" Or SessionUser._sCentro.Trim = "PE12" Then
                TCScrap.Location = New Point(722, 372)
                CB_TipoSc.Location = New Point(800, 372)
            End If
        Else
            Label5.Location = New Point(1123, 275)
            TCausas.Location = New Point(1117, 294)
            CB_SP_Causa.Location = New Point(726, 294)
            TCCausas.Location = New Point(1117, 320)
            CB_Causas.Location = New Point(726, 320)
            TCDefecto.Location = New Point(1117, 346)
            CB_Defecto.Location = New Point(726, 346)
            TCScrap.Location = New Point(1117, 372)
            CB_TipoSc.Location = New Point(726, 372)
        End If

        If P_VU = True Then
            PassNotifier.Text = SessionUser._sAlias.Trim
            Gen_Valida.Valida_Usuario(SessionUser._sAlias.Trim, SessionUser._sPassword)
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
                PassNotifier.Text = SessionUser._sPassword
                RB_PT.Focus()
            End If
            RB_PT.Focus()
        Else
            PassNotifier.Focus()
        End If

        TFolioVale.Enabled = P_FV
        TFolioVale.Visible = P_FV
        Label17.Visible = P_FV

    End Sub
    Private Sub ProduccionSeparada()
        ProduccionSeparadaABC.IdFolioPeso = FolioNotifica.rIdFolio
        ProduccionSeparadaABC.OrdenProduccion = TOrden.Text.Trim
        ProduccionSeparadaABC.FH_Registro = DateTime.Now.ToString("yyyyMMdd HH:mm:ss")
        Try
            OperacionExtrusion.ABC(1)
        Catch ex As Exception

        End Try


    End Sub

    Private Function NotificaExtPT() As Boolean

    End Function
#End Region

#Region "Eventos"
    Private Sub MenuPTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        StrProducto = ""
        Centro.Text = SessionUser._sCentro.Trim       'Clave Centro 
        TCausas.Enabled = False

        CB_SP_Causa.Enabled = False
        TCCausas.Enabled = False
        CB_Causas.Enabled = False
        TCDefecto.Enabled = False
        CB_Defecto.Enabled = False
        TCScrap.Enabled = False
        CB_TipoSc.Enabled = False

        LimpiaObjetos()
        ' ---------------------------------------------------------------------------------
        'Se verifica conexión con SAP
        Permiso.SAP_Status("E", tsImagen)
        ' ---------------------------------------------------------------------------------
        'Inicializan fecha Turno y SAP
        Inicializa_Frm_PTEI(dtpFECHA, dtpFECHASAP, chkSAP)
        ' ---------------------------------------------------------------------------------
        Parametrizacion.Parametrized_Form(Me)
        Parametrizacion_Forma()
        Asigna_Turno()
        ' ---------------------------------------------------------------------------------
        TSobrePeso.BackColor = Color.White
    End Sub

    Private Sub TOrden_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TOrden.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TOrden_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOrden.Leave

        Dim Estatus_Orden As String
        If TOrden.Text <> "" Then
            LoadingForm.ShowLoading()
            'Verficia Orden Producción
            Dim Orden_Prod As String = ""
            Orden_Prod = TOrden.Text.Trim
            '--------------------------------------------------------------------------------------
            Select Case ProductionOrder.Existe(Orden_Prod, EXTINY)
                Case Is = True
                    'Verifica si no esta inactiva
                    'Select Case OrdenProduccionExiste._Estatus
                    '    Case Is = True
                    'If OrdenProduccionExiste._OrigenInformacion.Trim <> "A-tlas" Then
                    '    'Verificar que la orden no este cerrada
                    '    ProductionOrder.ValidaEstatus(Orden_Prod, "T")
                    '    Estatus_Orden = OrdenProductionSap._IdStatus
                    'Else
                    'Estatus_Orden = "LIB."
                    'End If

                    'If Estatus_Orden = "LIB." Or Estatus_Orden = "ABIE" Then
                    'Verficia la existencia del producto
                    Select Case ProductionOrder.Existencia_Producto(EXTINY)
                        Case Is = True
                            'Lee la orden y presenta la información
                            ProductionOrder.Read_Production_Order_Ext(Orden_Prod.Trim, Me, TCodPT, TCodPtDecr, TPtoTrabajo, _
                                                                      TPesoTeorico, Tempaque, TCodAnillo, TDAnillo, TGrpprod, TGrupo, _
                                                                      TSP_Permitido, TGrpproddesc, TNomPtoTrabajo)
                            'Activa Combo Box de compuestos 1
                            Catalogo_Compuestos.CB_Compuesto1(CB_Com1, EXTINY, TipoProd, P_CC1)
                            If TipoProd = "S" Then
                                'Inicio ***************************************************************************************************
                                'Se desactiva la opcion de tipo scrap, se determina se haga cuando selecciona el compuesto a consumir
                                '02/Spet/2014 JJSM
                                ''Activa Combo Box de Tipo Scrap                                   
                                'Catalogo_Scrap.CB_Scrap(CB_TipoSc, SessionUser._sAlias.Trim, strPlanta.Trim, Seccion, TipoProd)
                                'Fin ******************************************************************************************************
                                'Activa Combo Box Causa de Scrap
                                Catalogo_Causas.Combo_Causas(CB_Causas, "", Seccion.Trim, "SC", P_CD)
                            End If
                            TOrden.BackColor = Color.White
                            'Activa Combo Box Operdores de Linea
                            Select Case SessionUser._sCentro
                                Case Is = "A013"
                                    Catalogo_Operador_Puesto_Trabajo.CBOperadorLinea_PTSC(CB_Ope)
                                Case Else
                                    Catalogo_Operador_Puesto_Trabajo.CB_Operador_Linea(CB_Ope, TipoProd)
                            End Select
                            'Consulta cantidades
                            ProductionOrder.CalCantExt(Orden_Prod, TCantProgra, TCantEntre, TCantEnproce, TCantPendiente, EXTINY)
                            'Porcentaje de avance de la orden
                            ProductionOrder.Porcentaje_Orden(TCantEntre.Text, TCantEnproce.Text, TCantProgra.Text, Label8, Btn_Notificar)
                            'Asigan Peso Teorico
                            PesoTeorico = "0" & TPesoTeorico.Text
                            If RB_PT.Checked = True Then
                                TtramosNoti.Focus()
                            End If

                            If RB_SC.Checked = True Then
                                CB_Rack.Focus()
                            End If
                            LoadingForm.CloseForm()
                        Case Is = False
                            LoadingForm.CloseForm()
                            MensajeBox.Mostrar("El producto no esta dado de alta en A-tlas ", "Error", MensajeBox.TipoMensaje.Critical)
                            TOrden.Focus()
                            Exit Sub
                    End Select
                    'Else
                    '    LoadingForm.CloseForm()
                    '    MensajeBox.Mostrar("La orden no puede ser notificada esta en estatus: " & OrdenProductionSap._Status & " ", " " & OrdenProductionSap._IdStatus & " ", MensajeBox.TipoMensaje.Critical)
                    '    TOrden.Text = ""
                    '    TOrden.Focus()
                    '    Exit Sub
                    'End If
                    '    Case Is = False
                    '        LoadingForm.CloseForm()
                    '        MensajeBox.Mostrar("La orden esta inactiva", "Estatus", MensajeBox.TipoMensaje.Information)
                    '        TOrden.Text = ""
                    '        TOrden.Focus()
                    '        Exit Sub
                    'End Select
                Case Is = False
                    'Dar de alta la orden
                    LoadingForm.CloseForm()
                    MensajeBox.Mostrar("Orden de Producción no existe en A-tlas se procede a darla de alta ", "Aviso", MensajeBox.TipoMensaje.Information)
                    ProductionOrder.Inserta_ODF_EXT(Orden_Prod.Trim, "T", Me, CodOperador.Text.Trim, EXTINY, SessionUser._sAlias.Trim, _
                                                                   SessionUser._sCentro.Trim, SessionUser._sAmbiente, EXTINY, TCodPT, TCodPtDecr, TPtoTrabajo, _
                                                                   TPesoTeorico, Tempaque, TCodAnillo, TDAnillo, TGrpprod, TGrupo, TSP_Permitido, _
                                                                   TGrpproddesc, TNomPtoTrabajo, Atlas_Version._Version.Trim)
            End Select
        End If
        LoadingForm.CloseForm()
    End Sub

    Private Sub TtramosNoti_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TtramosNoti.Leave
        If RB_SC.Checked = False Then
            Dim xPSP As Double
            Dim PesoAnillos As Decimal
            Dim PesoReten As Decimal
            Dim PesoEmbalaje As Decimal
            Dim xTramosNoti As Double
            Dim xPeso_Neto As Double
            Dim strOrden As String
            Dim aryTextFile() As String

            'Porcentaje de avance de la orden
            ProductionOrder.Porcentaje_Orden_Excedido(TCantEntre.Text, TtramosNoti.Text.Trim, TCantEnproce.Text, TCantProgra.Text, Label8, Btn_Notificar)
            'Se valida si requiere bloquear por excedente de producción
            Select Case P_EP
                Case Is = True
                    If Porcentaje_Avance > 10 Then
                        LoadingForm.CloseForm()
                        MensajeBox.Mostrar("La orden con esta notificación se excede " & Porcentaje_Avance & " %, no se puede continuar con la notificación", "Aviso excedido" & Porcentaje_Avance & " % ", MensajeBox.TipoMensaje.Information)
                        LimpiaObjetos()
                        Asigna_Turno()
                        TSobrePeso.BackColor = Color.White
                        PassNotifier.Focus()
                        Return
                    End If
            End Select

            xTramosNoti = "0" & TtramosNoti.Text.Trim
            xPeso_Neto = TPesoNeto.Text.Trim
            SobrepesoPermitido = "0" & TSP_Permitido.Text.Trim
            PorcentajeSobrePeso = 0

            'Valida que tenga embalajes
            strOrden = Proceso_Extrusion.Peso_Embalajes(TOrden.Text.Trim, TtramosNoti.Text)
            aryTextFile = strOrden.Split("|")
            TCodEmb.Text = aryTextFile(0)
            TDEmb.Text = aryTextFile(1)
            TPEmb.Text = aryTextFile(4)

            PesoEmbalaje = Format(Val(TPEmb.Text), xFormato)

            If TCodAnillo.Text > "0" Or TCodAnillo.Text <> "" Then
                PesoAnillos = Format((Val(Tempaque.Text) * Val(TtramosNoti.Text)), xFormato)
            Else
                PesoAnillos = "0"
            End If

            If TCodReten.Text > "0" Or TCodReten.Text <> "" Then
                PesoReten = Format((Val(TPReten) * Val(TtramosNoti.Text)), xFormato)
            Else
                PesoReten = "0"
            End If

            TempaquePesoTot.Text = PesoAnillos + PesoReten + PesoEmbalaje
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

            If TtramosNoti.Text.Trim.Length > 0 Then
                BPesar.Enabled = True
            End If
            If RB_PT.Checked = True Then
                TtramosNoti.BackColor = Color.White
            End If

            If RB_SC.Checked = True Then
                TtramosNoti.BackColor = Color.LightGray
            End If


            If TPesoBruto.Text <> "0.00" Or TPesoTara.Text <> "0.00" Or TempaquePesoTot.Text <> "" Then
                TPesoNeto.Text = Format((TPesoBruto.Text - TPesoTara.Text - TempaquePesoTot.Text), xFormato)
            End If
        End If
        CB_Rack.Focus()
    End Sub
#End Region

    Private Sub BPesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPesar.Click

        'Valida tara en ceros ----------------------------------------------------------------------------------
        If P_AT = True Then
            If TPesoRack.Text <= 0 Then
                MensajeBox.Mostrar("El peso de la tara esta en O es correcto", "Tara en 0", MensajeBox.TipoMensaje.Exclamation, MensajeBox.TipoBoton.OkCancel)
                If MensajeBox.Respuesta = False Then
                    CB_Rack.Focus()
                    Return
                End If
            End If
        End If
        'Valida campos obligatorios ----------------------------------------------------------------------------
        If PassNotifier.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese clave de operador", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            PassNotifier.Focus()
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

        If CB_Com1.SelectedValue.Trim = "" And P_CC1 = True Then
            MensajeBox.Mostrar("Seleccione un compuesto a consumir", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            CB_Com1.Focus()
            Return
        End If

        If TPComp1.Text = 0 And P_CC1 = False Then
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

        LoadingForm.ShowLoading()
        'Selecciona proceso de Notificacion Producto Terminado o Scrap -----------------------------------------
        If RB_PT.Checked Then
            Notifica_PT()
        End If

        If RB_SC.Checked Then
            Notifica_SC()
        End If
        '-------------------------------------------------------------------------------------------------------
        LoadingForm.CloseForm()
    End Sub

    Private Sub TPesoBruto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoBruto.TextChanged
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

    Private Sub TPesoTara_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoTara.TextChanged
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

    Private Sub TtramosNoti_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TtramosNoti.KeyPress
        e.Handled = txtNumerico(TtramosNoti, e.KeyChar, True)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TRack_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub BSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSiguiente.Click
        LoadingForm.CloseForm()
        LimpiaObjetos()
        Asigna_Turno()
        TSobrePeso.BackColor = Color.White
        PassNotifier.Focus()
    End Sub

    Private Sub BImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImprimir.Click

        If RB_PT.Checked Then
            If SessionUser._sCentro.Trim = "A001" Then
                WeighingInquiry.IdOrden = TOrden.Text.Trim
                Reportes.Boleta_Pesaje_PTE_Ext(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, TFolioAtlas.Text.Trim, "0")
            Else
                Reportes.Boleta_Pesaje_PTE_Ext(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, TFolioAtlas.Text.Trim, "0")
            End If
        End If

        If RB_SC.Checked Then
            Reportes.Boleta_Pesaje_SCE_Ext(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, TFolioAtlas.Text.Trim, "0")
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim TPC As String = ""
        Dim TPC2 As String = ""

        'Cadena = FrmMain.SerialPort1.ReadExisting
        Cadena = SerialPort_1.ReadExisting

        TPC = Chr(CH1)
        TPC2 = Chr(CH2)
        If Cadena.Length > 13 Then
            If Cadena.StartsWith(TPC) = True Then
                Lectura = Cadena.Substring((Cadena.IndexOf(TPC2) + AddChar), LenghtLec).Trim
            End If
        End If

        If SessionUser._sCentro.Trim = "GT01" Then
            TPesoBruto.Text = Format((Val(Lectura) / 10), xFormato)
        Else
            TPesoBruto.Text = Format(Val(Lectura), xFormato)
        End If
    End Sub

    Private Sub TPesoNeto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoNeto.TextChanged
        Dim xPSP As Double
        Dim xTramosNoti As Double
        Dim xPeso_Neto As Double

        xTramosNoti = "0" & TtramosNoti.Text.Trim
        xPeso_Neto = "" & TPesoNeto.Text.Trim
        SobrepesoPermitido = "0" & TSP_Permitido.Text.Trim
        PorcentajeSobrePeso = 0

        If RB_PT.Checked Then
            If PesoTeorico > 0 And xTramosNoti > 0 Then
                xPSP = (((xPeso_Neto / (PesoTeorico * xTramosNoti)) - 1) * 100)
                PorcentajeSobrePeso = Format(xPSP, xFormato)
                KilosSobrepeso = (xPeso_Neto - (PesoTeorico * xTramosNoti))
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
        End If
    End Sub

    Private Sub TSobrePeso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSobrePeso.TextChanged
        If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
            TSobrePeso.BackColor = Color.Red
            CB_SP_Causa.Enabled = True
            TCausas.Enabled = True
            'If P_CD = True Then
            '    CB_SP_Causa.DataSource = Nothing
            '    CB_SP_Causa.Enabled = False
            'Else
            CB_SP_Causa.DataSource = Nothing
            CB_SP_Causa.Enabled = True
            Catalogo_Causas.Combo_Causas(CB_SP_Causa, "", Seccion.Trim, "SP", P_CD)
            'End If
        Else
            TSobrePeso.BackColor = Color.Yellow
            TCausas.Enabled = False
            TCausas.Text = "0"
            CB_SP_Causa.DataSource = Nothing
            CB_SP_Causa.Enabled = False
        End If
    End Sub

    Private Sub TOrden_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOrden.Enter
        If RB_SC.Checked = False Then
            TtramosNoti.BackColor = Color.LightSkyBlue
        Else
            TtramosNoti.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub TtramosNoti_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TtramosNoti.Enter
        If RB_SC.Checked = False Then
            TtramosNoti.BackColor = Color.LightSkyBlue
        Else
            TtramosNoti.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub BImprimir_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImprimir.Leave
        BSiguiente.Focus()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub TPesoCaptura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoCaptura.TextChanged
        Dim xTPesoCaptura As Double
        xTPesoCaptura = TPesoCaptura.Text.Trim
        TPesoBruto.Text = Format(xTPesoCaptura, xFormato)
    End Sub

    Private Sub TPesoCaptura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TPesoCaptura.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Decimales(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub chkSAP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chkSAP.Checked = True Then
            dtpFECHASAP.Enabled = True
        Else
            dtpFECHASAP.Enabled = False
        End If
    End Sub

    Private Sub TClaveOperador_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassNotifier.Enter
        PassNotifier.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TClaveOperador_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PassNotifier.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TClaveOperador_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassNotifier.Leave
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

    Private Sub MenuPTE_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        LoadingForm.CloseForm()
        PassNotifier.Text = ""
        EXTINY = ""
        Seccion = ""
        Timer1.Enabled = False
        LimpiaObjetos()
        Permiso.Cerrar(Me.Name, "Cerrar")
    End Sub

    Private Sub TCodTinta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        MdFormControl.Calculadora()
    End Sub

    Private Sub TCveOpe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        LimpiaObjetos()
        Close()
    End Sub

    Private Sub TPComp1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPComp1.TextChanged
        Try
            If TPComp1.Text.Trim = 100 Then
                CB_Com2.DataSource = Nothing
                CB_Com2.Text = ""
                NPTExtrusion.iCompuesto2 = "0"
                TPComp2.Text = 0
                CB_Com2.Enabled = False
                TPComp2.Enabled = False
            ElseIf TPComp1.Text.Trim > 100 Then
                MessageBox.Show("No se permiten valores mayores al 100%")
                TPComp1.Text = "100"
            ElseIf TPComp1.Text <= 0 Then
                TPComp2.Text = 0
            Else
                CB_Com2.Enabled = True
                TPComp2.Enabled = True
                Catalogo_Compuestos.CB_Compuesto2(CB_Com2, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TCodPT.Text.Trim.Trim, EXTINY)
                'CBG.Con_Comp_rep(CB_Com2, TCodPT.Text.Trim.Trim, EXTINY)
                TPComp2.Text = 100 - Val(TPComp1.Text)
                NPTExtrusion.iCompuesto2 = CB_Com2.SelectedValue
            End If
            If TPComp1.Text.Trim = 0 Then
                MessageBox.Show("No se permite valor de 0% o negativos ")
                TPComp1.Text = "100"
            End If
        Catch ex As Exception
            TPComp1.Text = "100"
        End Try

    End Sub

    Private Sub TPComp1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TPComp1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CB_Com2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Com2.Leave
        NPTExtrusion.iCompuesto2 = CB_Com2.SelectedValue
        If NPTExtrusion.iCompuesto2.Trim = NPTExtrusion._iCompuesto1.Trim Then
            MsgBox("El compuesto seleccionado no puede ser el mismo que el primero", MsgBoxStyle.Information)
            CB_Com2.DataSource = Nothing
            'CBG.Con_Comp_rep(CB_Com2, StrProducto.Trim, EXTINY)
            Catalogo_Compuestos.CB_Compuesto2(CB_Com2, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, StrProducto.Trim, EXTINY)
            CB_Com2.Text = ""
            NPTExtrusion.iCompuesto2 = "0"
            CB_Com2.Focus()
        End If
    End Sub

    Private Sub CB_Com1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Com1.TextChanged
        If Clean <> "1" Then
            If CB_Com1.Text.Trim = "" Then
                MsgBox("Debe de seleccionar un compuesto a consumir", MsgBoxStyle.Information)
                CB_Com1.DataSource = Nothing
                Catalogo_Compuestos.CB_Compuesto1(CB_Com1, EXTINY, TipoProd, P_CC1)
            End If
        End If
    End Sub

    Private Sub CB_Causa_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SP_Causa.Leave
        TCausas.Text = CB_SP_Causa.SelectedValue
        BPesar.Focus()
    End Sub

    Private Sub CB_Com1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Com1.Leave
        NPTExtrusion.iCompuesto1 = CB_Com1.SelectedValue
    End Sub

    Private Sub CB_Rack_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Rack.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Rack_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Rack.Leave
        If CB_Rack.Text.Trim = "M" Then
            TPesoRack.ReadOnly = False
            TPesoRack.Text = "0"
            TDescrack.Text = "Peso Asignado Manualmente"
            TPesoRack.Focus()
        ElseIf CB_Rack.Text.Trim <> "M" Then
            TPesoRack.ReadOnly = True
            TPesoRack.Text = CB_Rack.SelectedValue
            TDescrack.Text = Catalogo_Racks.Desc_Rack(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, CB_Rack.Text.Trim)
        End If
    End Sub

    Private Sub CB_Rack_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Rack.Enter
        CB_Rack.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub CB_Com1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Com1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Com2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Com2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkSAP_CheckedChanged_1(sender As System.Object, e As System.EventArgs)
        If chkSAP.Checked Then
            dtpFECHASAP.Enabled = True
        Else
            dtpFECHASAP.Enabled = False
        End If
    End Sub

    Private Sub RB_PT_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PT.CheckedChanged
        If RB_PT.Checked = True Then
            TipoProd = ""
            TipoProd = "T"
            If P_CD = True Then
                TCCausas.Enabled = False
                CB_Causas.Enabled = False
                TCDefecto.Enabled = False
                CB_Defecto.Enabled = False
                TCScrap.Enabled = False
                CB_TipoSc.Enabled = False
            End If
            TtramosNoti.ReadOnly = False
            TtramosNoti.BackColor = Color.White
            TOrden.Enabled = True
            cmbProceso.Enabled = True
            TOrden.Focus()
        End If
    End Sub

    Private Sub RB_SC_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_SC.CheckedChanged
        If RB_SC.Checked = True Then
            TipoProd = ""
            TipoProd = "S"
            TCCausas.Enabled = True
            TCCausas.ReadOnly = False
            CB_Causas.Enabled = True
            TCDefecto.Enabled = True
            TCDefecto.ReadOnly = False
            CB_Defecto.Enabled = True
            TCScrap.Enabled = True
            TCScrap.ReadOnly = False
            CB_TipoSc.Enabled = True
            'If P_CD = True Then
            '    TCCausas.Enabled = True
            '    TCCausas.ReadOnly = False
            '    CB_Causas.Enabled = True
            '    TCDefecto.Enabled = True
            '    TCDefecto.ReadOnly = False
            '    CB_Defecto.Enabled = True
            '    TCScrap.Enabled = True
            '    TCScrap.ReadOnly = False
            '    CB_TipoSc.Enabled = True
            'End If
            TCausas.Text = "0"
            TtramosNoti.Text = "0"
            TtramosNoti.ReadOnly = True
            TtramosNoti.BackColor = Color.LightGray
            TOrden.Text = ""
            TOrden.Enabled = True
            BPesar.Enabled = True
            cmbProceso.Enabled = False
            TOrden.Focus()
        End If
    End Sub

    Private Sub CB_Causa_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_SP_Causa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Causas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Causas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Causas_Leave(sender As System.Object, e As System.EventArgs) Handles CB_Causas.Leave
        CausaScrap()
    End Sub

    Private Sub CB_Defecto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Defecto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Defecto_Leave(sender As System.Object, e As System.EventArgs) Handles CB_Defecto.Leave
        TCDefecto.Text = CB_Defecto.SelectedValue
        CB_TipoSc.Focus()
    End Sub

    Private Sub CB_TipoSc_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_TipoSc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_TipoSc_Leave(sender As System.Object, e As System.EventArgs) Handles CB_TipoSc.Leave
        TCScrap.Text = CB_TipoSc.SelectedValue
        BPesar.Focus()
    End Sub

    Private Sub TempaquePesoTot_TextChanged(sender As System.Object, e As System.EventArgs) Handles TempaquePesoTot.TextChanged
        Dim xTPesoEmpaque As Double
        xTPesoEmpaque = "0" & TempaquePesoTot.Text.Trim
        TPesoEmpaque.Text = Format(xTPesoEmpaque, xFormato)
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

    Private Sub ProductoTerminadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductoTerminadoToolStripMenuItem.Click
        Permiso.Accesos("MP_IMP_PT", "1", SessionUser._sIdPerfil, "E", "Reportes Producto Terminado ")
    End Sub

    Private Sub ScrapToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScrapToolStripMenuItem.Click
        Permiso.Accesos("MP_IMP_SC", "1", SessionUser._sIdPerfil, "E", "Reportes Scrap ")
    End Sub

    Private Sub BtnActualiza_Click(sender As System.Object, e As System.EventArgs) Handles BtnActualiza.Click
        If TOrden.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese un numero de Orden", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            Exit Sub
        Else
            PO.Actualiza_Orden_Produccion(TOrden.Text.Trim, "T")
            SQL_DATA.ProductionOrder.Act_Ins_ProductionOrder(TOrden.Text.Trim, TipoProd.Trim)
            LimpiaObjetos()
            MensajeBox.Mostrar("La orden de producción a sido actualizada ingrese nuevamente el numero de orden", "Actualizado", MensajeBox.TipoMensaje.Good)
            TOrden.Focus()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Dim TPC As String = ""
        Dim TPC2 As String = ""

        'Cadena = FrmMain.SerialPort2.ReadExisting
        Cadena = SerialPort_2.ReadExisting

        TPC = Chr(CH1)
        TPC2 = Chr(CH2)
        If Cadena.Length > 13 Then
            If Cadena.StartsWith(TPC) = True Then
                Lectura = Cadena.Substring((Cadena.IndexOf(TPC2) + AddChar), LenghtLec).Trim
            End If
        End If
 
        If SessionUser._sCentro.Trim = "GT01" Then
            TPesoBruto.Text = Format((Val(Lectura) / 10), xFormato)
        Else
            TPesoBruto.Text = Format(Val(Lectura), xFormato)
        End If
    End Sub

    Private Sub MP_CON_PROD_Click(sender As System.Object, e As System.EventArgs) Handles MP_CON_PROD.Click
        Permiso.Accesos("MP_CON_PROD", "1", SessionUser._sIdPerfil, "E", "Consulta Produccion / Scrap ")
    End Sub

    Private Sub MP_CON_SP_Click(sender As System.Object, e As System.EventArgs) Handles MP_CON_SP.Click
        Permiso.Accesos("MP_CON_SP", "1", SessionUser._sIdPerfil, "E", "Consulta Sobre / Bajo Pesos ")
    End Sub

    Private Sub RB1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB1.CheckedChanged
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
        'strNumeroBascula = ""
    End Sub

    Private Sub RB2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB2.CheckedChanged
        'strNumeroBascula = ""
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

    Private Sub chkSAP_CheckedChanged_2(sender As System.Object, e As System.EventArgs) Handles chkSAP.CheckedChanged
        If chkSAP.Checked Then
            dtpFECHASAP.Enabled = False
        Else
            dtpFECHASAP.Enabled = True
        End If
    End Sub

    Private Sub TCausas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TCausas.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
            SendKeys.Send("{TAB}")
            CausaSobrePeso()
            End If

    End Sub

    Private Sub TCCausas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TCCausas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            cmbCausasScrap()
        End If
    End Sub

    Private Sub TCDefecto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TCDefecto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            cmbDefectoScrap()
        End If
    End Sub

    Private Sub TCScrap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCScrap.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            cmbTipoScrap()
        End If
    End Sub

    Private Sub Consume_WS_CR01(ByVal Usr_Atlas As String, ID As String, CadenaTexto As String, Lt_Compuestos As String, _
                                      FechaPesajeSAP As String, Orden As String, PesoNeto As String, folio As String)


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
            Try
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
                lo_wsamancomxp.Credentials = New System.Net.NetworkCredential("libra", "mxlibra$")
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
                        MsgBox("No Notifico a SAP")
                        BPesar.Enabled = False
                        BImprimir.Enabled = True
                        TOrden.Enabled = False
                        SuperAutoSobrepeso = ""
                        Return
                    Else
                        reg = "1"
                        TDocSAP.Text = TNumNoti
                        TConSAP.Text = TConsNoti
                        LecturaQry("PA_Actualiza_Notificacion_Scrap " & SessionUser._sCentro.Trim & "_PesoScrap, '" & TNumNoti & "', '" & TConsNoti & "', '" & reg & "', '" & Mns & "',  '" & folio & "' ")
                        BPesar.Enabled = True
                        TOrden.Enabled = False
                        SuperAutoSobrepeso = ""
                        MensajeBox.Mostrar("La notificación de la Orden '" & Orden.Trim & "' a sido Exitosa ", "Notificación Exitosa", MensajeBox.TipoMensaje.Good)
                    End If
                End If
            Catch ex As Exception
                MensajeBox.Mostrar(ex.ToString, "No se realizar notificación a SAP", MensajeBox.TipoMensaje.Critical)
            End Try
        End If
    End Sub

    Private Sub CB_Manual_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_Manual.CheckedChanged
        If CB_Manual.Checked Then
            GB_Basculas.Enabled = False
            RB1.Checked = False
            RB2.Checked = False
            RB3.Checked = False
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
        Else
            GB_Basculas.Enabled = P_MB
            RB1.Checked = True
            RB2.Checked = False
            RB3.Checked = False
        End If
    End Sub

    Private Sub RB3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB3.CheckedChanged
        'strNumeroBascula = ""
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

    Public Sub Mensaje_Correo()
        Dim Email As String = ""
        'Generación del formato para el cuerpo del correo
        Email = Email & "Reporte de Sobre Peso " & vbCr & ""
        Email = Email & "" & vbCr & ""
        Email = Email & "Numero ODF:            " & TOrden.Text.Trim & " " & vbCr & ""
        Email = Email & "Folio Atlas:           " & FolioNotifica._rIdFolio.Trim & " " & vbCr & ""
        Email = Email & "Producto:              " & TCodPT.Text.Trim & " " & vbCr & ""
        Email = Email & "Descripción:           " & TCodPtDecr.Text.Trim & " " & vbCr & ""
        Email = Email & "Fecha:                 " & Date.Today.ToString("yyyy-MM-dd") & " " & vbCr & ""
        Email = Email & "Hora:                  " & Date.Now.TimeOfDay.ToString.Substring(0, 8) & " " & vbCr & ""
        Email = Email & "Rack:                  " & TDescrack.Text.Trim & " " & vbCr & ""
        Email = Email & "Tramos:                " & nvoTramosNoti & " " & vbCr & ""
        Email = Email & "Peso Bruto:            " & NPTExtrusion._iPB & " " & vbCr & ""
        Email = Email & "Peso Tara:             " & NPTExtrusion._iPT & " " & vbCr & ""
        Email = Email & "Peso Neto:             " & NPTExtrusion._iPN & " " & vbCr & ""
        Email = Email & "Sobre Peso:            " & TSobrePeso.Text.Trim & " '%' " & vbCr & ""
        Email = Email & "" & vbCr & ""
        Email = Email & "Usuario Notifica:      " & SessionUser._sAlias.Trim & " " & vbCr & ""
        Email = Email & "Supervisor Autoriza:   " & SuperAutoSobrepeso.Trim & " " & vbCr & ""
        Email = Email & "Maquina:               " & TPtoTrabajo.Text.Trim & " " & vbCr & ""
        Email = Email & "Turno:                 " & Turno.Trim & " " & vbCr & ""
        Email = Email & "Observación:           " & ObserSobrepeso.Trim & " " & vbCr & ""
        Email = Email & "Causa Sobre Peso:      " & TCausas.Text.Trim & " " & CB_SP_Causa.Text.Trim & ""
    End Sub

    Private Sub CB_TipoSc_Click(sender As System.Object, e As System.EventArgs) Handles CB_TipoSc.Click
        'Activa Combo Box de Tipo Scrap
        CB_TipoSc.DataSource = Nothing
        CB_TipoSc.Enabled = True
        TCScrap.Text = ""
        Catalogo_Scrap.CB_Scrap(CB_TipoSc, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, Seccion, TipoProd)
        TPComp1.Enabled = True
        TCScrap.Text = CB_TipoSc.SelectedValue
    End Sub

    Private Sub CausaScrap()
        ''If P_CD = False Then
        If CB_Causas.SelectedValue = Nothing Then
            MsgBox("Selecciones una causa", MsgBoxStyle.Information)
            CB_Causas.Focus()
            Return
        Else
            Select Case SessionUser._sCentro.Trim
                Case Is = "CR01", "VE02"
                    TCCausas.Text = CB_Causas.SelectedValue
                    Catalogo_Defectos.Combo_Defectos(CB_Defecto, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, "E000")
                Case Else
                    TCCausas.Text = CB_Causas.SelectedValue
                    Catalogo_Defectos.Combo_Defectos(CB_Defecto, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, TCCausas.Text.Trim)
                    CB_Defecto.Text = ""
                    CB_Defecto.Focus()
            End Select
        End If
        '' End If
    End Sub

    Private Sub CausaSobrePeso()
        If P_CD = True Then
            If TCausas.Text.Trim = "" Then
                MensajeBox.Mostrar("Ingrese Codigo de Causa Sobrepeso", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                TCausas.Focus()
                Return
            Else
                Catalogo_Causas.Combo_Causas(CB_SP_Causa, TCausas.Text.Trim, Seccion.Trim, "SP", P_CD)
                If CB_SP_Causa.SelectedValue = Nothing Then
                    MensajeBox.Mostrar("No Existe Codigo de Causa Sobrepeso", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                    TCausas.Text = ""
                    TCausas.Focus()
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub cmbCausasScrap()
        If P_CD = True Then
            If TCCausas.Text.Trim = "" Then
                MensajeBox.Mostrar("Ingrese Codigo de Causa Scrap", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                TCCausas.Focus()
                Return
            Else
                If TCCausas.Text.Trim = "" Then
                    Catalogo_Causas.Combo_Causas(CB_Causas, "", Seccion.Trim, "SC", False)
                Else
                    Catalogo_Causas.Combo_Causas(CB_Causas, TCCausas.Text.Trim, Seccion.Trim, "SC", False)
                End If
                If CB_Causas.SelectedValue = Nothing Then
                    MensajeBox.Mostrar("No Existe Codigo de Causa", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                    TCCausas.Text = ""
                    TCCausas.Focus()
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub cmbDefectoScrap()
        If P_CD = True Then
            If TCDefecto.Text.Trim = "" Then
                MensajeBox.Mostrar("Ingrese Codigo de Defecto Scrap", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                TCCausas.Focus()
                Return
            Else
                Select Case SessionUser._sCentro.Trim
                    Case Is = "CR01", "VE02"
                        Catalogo_Defectos.Combo_Defectos(CB_Defecto, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, "E000")
                    Case Is = "PE01", "PE12"
                        Catalogo_Defectos.Combo_Defectos(CB_Defecto, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, TCCausas.Text.Trim)
                        If CB_Defecto.SelectedValue = Nothing Then
                            MensajeBox.Mostrar("No Existe Codigo de Defecto", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                            TCDefecto.Text = ""
                            TCDefecto.Focus()
                            Return
                        End If
                    Case Else
                        Catalogo_Defectos.Combo_Defectos(CB_Defecto, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, TCDefecto.Text.Trim)
                        If CB_Defecto.SelectedValue = Nothing Then
                            MensajeBox.Mostrar("No Existe Codigo de Defecto", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                            TCDefecto.Text = ""
                            TCDefecto.Focus()
                            Return
                        End If
                End Select
            End If
        End If
    End Sub

    Private Sub cmbTipoScrap()
        If P_CD = True Then
            If TCDefecto.Text.Trim = "" Then
                MensajeBox.Mostrar("Ingrese Codigo de Tipo Scrap", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                TCCausas.Focus()
                Return
            Else
                Select Case SessionUser._sCentro.Trim
                    Case Is = "PE01", "PE12"
                        Catalogo_TipoScrap.TipoScrap(CB_TipoSc, "E", "S", TCScrap.Text.Trim, 1)
                        If CB_TipoSc.SelectedValue = Nothing Then
                            MensajeBox.Mostrar("No Existe Tipo Scrap seleccionado", "Aviso", MensajeBox.TipoMensaje.Exclamation)
                            TCScrap.Text = ""
                            TCScrap.Focus()
                            Return
                        End If
                End Select
            End If
        End If
    End Sub

    Private Sub MPE_A_Click(sender As Object, e As EventArgs) Handles MPE_A.Click
        'Consultations.Permissions.Access("MP_MPEA", "1", SessionUser._sIdPerfil, "E", "Monitor Producción ", 1)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

    End Sub
End Class