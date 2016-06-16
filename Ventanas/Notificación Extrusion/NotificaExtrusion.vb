Imports System.IO
Imports System.IO.Ports.SerialPort
Imports System.IO.Ports.SerialDataReceivedEventArgs
Imports System.IO.Ports.SerialPinChangedEventArgs
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Net.Mail
Imports System.Diagnostics
Imports System.Threading
Imports System.Drawing
Imports System.Windows.Forms
Imports SQL_DATA
Imports Utili_Generales
Imports Atlas.Accesos
Imports Atlas.Accesos.CLVarGlobales



Public Class NotificaExtrusion

    Private EmailThread As Thread = Nothing


#Region "Variables miembro"
    Dim Clean As String
    Dim TipoProd As String  'T = Producto Terminado S = Scrap
    'Variables Notificaci�n
    Dim N_Orden As String
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
    Dim N_OperadorLinea As String
    Dim N_CodUser As String
    Dim N_Rack As String
    Dim N_Version As String
    Dim N_Causa_SP As String
    Dim N_Folio_Vale As String
    'Variables Notificacion Scrap
    Dim Reprocesado_Gen As String
    Dim Conexion_SAP As String

    'Variables para compuestos
    Dim Comp1 As String = "0"
    Dim Comp2 As String = "0"
    Dim Comp3 As String = "0"
    'Variables Identifica Scrap de Purga
    Dim arryComp() As String
    Dim R_Compuesto As String
    Dim R_Clase As String
    Dim Pass_md5 As String

    'Variable estatus registro pesajes A-tlas
    Dim PesajeAtlas As Boolean

    'Variables registros duplicados
    Dim SAP_dup As New Generic_SAP

#End Region

#Region "Variables"

    Dim SAP As New Generic_SAP
    '----- Variables para envio de correo ------
    Dim correo As New MailMessage()
    Dim cuerpodemensaje As String
    Dim smtp As New SmtpClient
    Dim Email As String
    '----- Variables para ingreso de orden de fabricaci�n ------   
    'Variables Supervisor
    Dim Supervisor As String

    'Variables Sobre Peso
    Dim StatusSobrepeso As String

    ' ----------------------------------------- Variables Boton Pesar
    Dim nvoTramosNoti As Integer
    Dim nvoEmpaques As Integer

    '----- Definici�n de  Variables -----

    Dim StatusSap As String  'Status de conexi�n Atlas - SAP  
    Dim NomTabOp As String   'Variable para controlar el nombre de la tabla de Orden Producci�n    
    Dim Message As String = "Tecle� un numero de Orden de Producci�n"
    Dim Caption As String = "Campo vacio"
    Dim CountValOP As Integer 'Validac�n para determinar  si la OF ya existe en la DB


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
    Dim FolioSiguiente As String


    '----- Variables para Turnos  -----
    Dim FechaTurno As String
    Dim FechaPesajeSAP As String
    Dim FechaPesajeSAP_CR As String

    '---- Informaci�n Bascula  -----
    Dim Cadena As String = ""
    '----  B�scula  ----

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
    Dim CompOriginal As String = ""
    Dim Reprocesado_Orig As String = ""
    Dim TintaOriginal As String = ""
    Dim AditivoOriginal As String = ""
    Dim CadenaTexto As String = ""

    Dim Lista As New Generic.List(Of String)
#End Region

#Region "Constructores"
    ' Llamada necesaria para el dise�ador.
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region

#Region "Metodos"

    Private Sub Limpia_Variables()
        N_Orden = ""
        N_FechaPesaje = ""
        N_HoraPesaje = ""
        N_PB = 0.0
        N_PT = 0.0
        N_PN = 0.0
        N_Empaques = 0
        N_Tramos = 0
        N_FechaTurno = ""
        N_Turno = 0
        N_Supervisor = ""
        N_Sobrepeso = 0.0
        N_PesoTeorico = 0.0
        N_Area = ""
        N_TipoScrap = ""
        N_StSobrePeso = "0"
        N_Comp_1 = ""
        N_Porc_1 = ""
        N_Cant_1 = ""
        N_Comp_2 = ""
        N_Porc_2 = ""
        N_Cant_2 = ""
        N_OperadorLinea = ""
        N_CodUser = ""
        N_Rack = ""
        'Btn_Notificar = "1"
    End Sub

    Private Sub LimpiaObjetos()
        Lista.Clear()
        Clean = "1"
        'FrontUtils.LimpiarText(Me)
        CB_Rack.DataSource = Nothing
        Comp1 = "0"
        CB_Ope.DataSource = Nothing
        TOrden.Text = ""                'Orden Producci�n
        TOrden.Enabled = False
        TtramosNoti.Text = "0"          'Tramos por Notificar
        CB_Rack.Text = "M"              'Rack
        TPesoRack.Text = "0"            'Peso Rack
        'TempaquePesoTot.Text = "0"      'Peso Total de empaques
        CB_Ope.Text = ""
        TFolioAtlas.Text = "0"
        TDocSAP.Text = "0"
        TConSAP.Text = "0"
        TFolioVale.Text = "00000"
        TSP_Permitido.Text = "0"
        TPesoTeorico.Text = "0"
        ' ---------------------------------------------------------------------------------
        RB_PT.Checked = False
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
        'SP = "0"
        'Autoriza_SP = ""
        ' ---------------------------------------------------------------------------------
        'Se carga catalogos de Racks's
        'Catalogo_Racks.Combo_Rack(CB_Rack, SessionUser._sCentro, SessionUser._sAlias)
        'Valida Turno ---------------------------------------------------------------------
        Dim HReal As String = DateTime.Now.ToString("HH:mm:ss")
        Catalogo_Turnos.Combo_Turnos(cmbTurnos)
        Catalogo_Turnos.Asigna_turno(cmbTurnos, HReal)
        ' ---------------------------------------------------------------------------------
        TBP1.Parent = Nothing
        TBP2.Parent = Nothing
        BNotificar.Enabled = False
        BImprimir.Enabled = False
        TOrden.Enabled = True
        Clean = "0"
        'Btn_Notificar = "0"
    End Sub

    Private Sub ProcesoSobrepeso()
        'Dim xPSP As Double
        'Dim xTramosNoti As Double
        'Dim xPeso_Neto As Double
        'Dim Folio_SP As String

        '' ---------------------------------------------------------------------------------
        'Folio_SP = ""
        'QRY = ""
        'QRY = "Select isnull((Max(Sobrepeso)+1),0) as Folio_SP from MCPC_Foliador  "
        'QRY = QRY & " where Planta = '" & SessionUser._sCentro.Trim & "'"
        'LecturaQry(QRY)
        'If (LecturaBD.Read) Then
        '    Folio_SP = LecturaBD(0)
        'End If
        'LecturaBD.Close()
        '' ---------------------------------------------------------------------------------
        'Folio_SP = Folio_SP.Trim
        'Folio_SP = Mid("00000000", 1, 8 - Len(Folio_SP)) & Folio_SP.Trim
        '' ---------------------------------------------------------------------------------

        'xTramosNoti = "0" & TtramosNoti.Text.Trim
        'xPeso_Neto = "" & TPesoNeto.Text.Trim
        'SobrepesoPermitido = "0" & TSP_Permitido.Text.Trim
        'PorcentajeSobrePeso = 0
        'If PesoTeorico > 0 And xTramosNoti > 0 Then
        '    xPSP = (((xPeso_Neto / (PesoTeorico * xTramosNoti)) - 1) * 100)
        '    PorcentajeSobrePeso = Format(xPSP, xFormato)
        'Else
        '    PorcentajeSobrePeso = Format(100, xFormato)
        'End If
        'AutorizaSobrepeso = 0
        'TSobrePeso.Text = Format(PorcentajeSobrePeso, "#0.00")
        'If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
        '    FormSobrePesoTf.Label1.ForeColor = Color.RoyalBlue
        '    FormSobrePesoTf.Label2.ForeColor = Color.RoyalBlue
        '    FormSobrePesoTf.Label1.Text = "El pesaje  se  encuentra fuera de rango. "
        '    FormSobrePesoTf.Label2.Text = "Por lo tanto se necesita  la autorizaci�n del supervisor en turno."
        '    FormSobrePesoTf.ShowDialog()
        'End If
        'If AutorizaSobrepeso > 0 Then

        '    Select Case AutorizaSobrepeso
        '        Case Is = 1 ' "SI" Autoriza Supervisor
        '            StatusSobrepeso = "Aceptado"
        '        Case Is = 2 ' " NO " Autoriza Supervisor
        '            StatusSobrepeso = "Rechazado"
        '    End Select

        '    ' ---------------------------------------------------------------------------------
        '    InQry = ""
        '    InQry = "INSERT INTO MCPT_AutorizacionSobrepeso (Orden_produccion,Fecha_Pesaje,Hora_Pesaje,Bascula,Rack,Tramos,"
        '    InQry = InQry & "Empaques,Peso_Bruto,Tara,Peso_Neto,Usuario,Turno,Supervisor,Planta,Folio,Autoriza_Calidad,"
        '    InQry = InQry & "Recibe_Almacen,Autoriza_Sobrepeso,Estatus_Autorizacion,Observaciones,PorSobrePeso,CausasSobrepeso,"
        '    InQry = InQry & "Compuesto1,Porcentaje1,Compuesto2,Porcentaje2,LTCompuestos, Fecha_turno, Puestotrabajo) Values "
        '    InQry = InQry & "('" & TOrden.Text.Trim & "','" & N_FechaPesaje.Trim & "','" & N_HoraPesaje.Trim & "',"
        '    InQry = InQry & "'" & ValCodigoBascula.Trim & "','" & TPesoRack.Text.Trim & "','" & nvoTramosNoti & "',"
        '    InQry = InQry & "" & nvoEmpaques & ",'" & N_PB & "','" & N_PT & "','" & N_PN & "',"
        '    InQry = InQry & "'" & CodOperador.Text.Trim & "','" & Turno.Trim & "','" & SuperAutoSobrepeso.Trim & "',"
        '    InQry = InQry & "'" & SessionUser._sCentro.Trim & "','" & Folio_SP & "','" & "S/N" & " ',' " & "S/N" & "',"
        '    InQry = InQry & "'" & SuperAutoSobrepeso.Trim & "','0','" & ObserSobrepeso.Trim & "',"
        '    'InQry = InQry & "'" & Replace(TSobrePeso.Text.Trim, GDECIMAL, ".") & "','" & TCausas.Text.Trim & "',"
        '    InQry = InQry & "'" & Compuesto_1.Trim & "','" & CompuestoPorcent_1 & "','" & Compuesto_2.Trim & "',"
        '    InQry = InQry & "'" & CompuestoPorcent_2 & "','" & Lt_Compuestos & "','" & FechaTurno.Trim & "',"
        '    InQry = InQry & "'" & WorkCenter.Trim & "')"
        '    InsertQry(InQry)

        '    InQry = ""
        '    InQry = "Update MCPC_Foliador set sobrepeso = '" & Folio_SP.Trim & "'"
        '    InQry = InQry & " where Planta = '" & SessionUser._sCentro.Trim & "'"
        '    InsertQry(InQry)
        '    ' ---------------------------------------------------------------------------------
        '    'End Select

        '    Select Case SessionUser._sCentro

        '        Case Is = "A001"

        '            'Generaci�n del formato para el cuerpo del correo

        '            Email = ""
        '            Email = Email & "Reporte de Sobre Peso " & vbCr & ""
        '            Email = Email & "" & vbCr & ""
        '            Email = Email & "Numero ODF:            " & TOrden.Text.Trim & " " & vbCr & ""
        '            Email = Email & "Folio Atlas:           " & FolioSiguiente.Trim & " " & vbCr & ""
        '            Email = Email & "Status Autorizaci�n:   " & StatusSobrepeso.Trim & " " & vbCr & ""
        '            Email = Email & "Producto:              " & TCodPT.Text.Trim & " " & vbCr & ""
        '            Email = Email & "Descripci�n:           " & TCodPtDecr.Text.Trim & " " & vbCr & ""
        '            Email = Email & "Fecha:                 " & Date.Today.ToString("yyyy-MM-dd") & " " & vbCr & ""
        '            Email = Email & "Hora:                  " & Date.Now.TimeOfDay.ToString.Substring(0, 8) & " " & vbCr & ""
        '            Email = Email & "Rack:                  " & CB_Rack.Text.Trim & " " & vbCr & ""
        '            Email = Email & "Tramos:                " & nvoTramosNoti & " " & vbCr & ""
        '            Email = Email & "Peso Bruto:            " & TPesoBruto.Text.Trim & " " & vbCr & ""
        '            Email = Email & "Peso Tara:             " & TPesoTara.Text.Trim & " " & vbCr & ""
        '            Email = Email & "Peso Neto:             " & TPesoNeto.Text.Trim & " " & vbCr & ""
        '            Email = Email & "Sobre Peso:            " & TSobrePeso.Text.Trim & " '%' " & vbCr & ""
        '            Email = Email & "" & vbCr & ""
        '            Email = Email & "Usuario Notifica:      " & SessionUser._sAlias.Trim & " " & vbCr & ""
        '            Email = Email & "Supervisor Autoriza:   " & SuperAutoSobrepeso.Trim & " " & vbCr & ""
        '            Email = Email & "Maquina:               " & TPtoTrabajo.Text.Trim & " " & vbCr & ""
        '            Email = Email & "Turno:                 " & Turno.Trim & " " & vbCr & ""
        '            Email = Email & "Observaci�n:           " & ObserSobrepeso.Trim & " " & vbCr & ""
        '            'Email = Email & "Causa Sobre Peso:      " & TCausas.Text.Trim & " " & TCausas.Text.Trim & ""

        '            'Preparaci�n para el envio del correo
        '            Select Case SessionUser._sCentro
        '                Case Is = "A001"
        '                    correo.From = New MailAddress("atlas_amanmex@mexichem.com", "Amanco Mexico")
        '                Case Is = "A013"
        '                    correo.From = New MailAddress("atlas_amanmex@mexichem.com", "Amanco Mexico")
        '            End Select


        '            If SessionUser._sAlias.Trim = "ATLAS" Then
        '                correo.To.Add("jsalinas@mexichem.com")
        '            Else
        '                Select Case SessionUser._sCentro
        '                    Case Is = "A001"
        '                        correo.To.Add("facosta@mexichem.com")
        '                        correo.CC.Add("jcescobar@mexichem.com")
        '                        correo.CC.Add("zpalomino@mexichem.com")
        '                        correo.CC.Add("esarabia@mexichem.com")
        '                        correo.CC.Add("masanchezc@mexichem.com")
        '                        correo.CC.Add("jmgonzalez@mexichem.com")
        '                        correo.CC.Add("goliva@mexichem.com")
        '                        correo.CC.Add("arruizh@mexichem.com")
        '                        correo.CC.Add("agrajeda@mexichem.com")
        '                        'correo.CC.Add("jsalinas@mexichem.com")
        '                    Case Is = "A013"
        '                        correo.To.Add("ggonzalezg@mexichem.com")
        '                        correo.CC.Add("agea@mexichem.com")
        '                        correo.CC.Add("econtrerasp@mexichem.com")
        '                        correo.CC.Add("atorresl@mexichem.com")
        '                End Select
        '            End If

        '            correo.Subject = "Notificaci�n de Sobre Peso en Producto Terminado de la ODF " & TOrden.Text.Trim & ""
        '            'correo.Attachments.Add(New Attachment("C:\Sobrepeso_" & FolioSiguiente & ".txt"))
        '            correo.Body = Email
        '            correo.IsBodyHtml = False
        '            Select Case SessionUser._sCentro
        '                Case Is = "A001"
        '                    smtp.Host = "ammxlonw002.mexichem.corp"
        '                    smtp.Port = 25
        '                    smtp.EnableSsl = False
        '                    smtp.Credentials = New System.Net.NetworkCredential("atlasleon@mexichem.com", "leona0358")
        '                Case Is = "A013"
        '                    smtp.Host = "TFMXCUW001.mexichem.corp"
        '                    smtp.Port = 25
        '                    smtp.EnableSsl = False
        '                    smtp.Credentials = New System.Net.NetworkCredential("atlas_amanmex@mexichem.com", "extrusion0127")
        '            End Select

        '            Try
        '                smtp.Send(correo)
        '                MsgBox("Mensaje enviado satisfactoriamente")
        '                correo.Dispose()
        '            Catch ex As Exception
        '                MsgBox("ERROR: " & ex.Message)
        '            End Try

        '    End Select

        'Else
        '    SuperAutoSobrepeso = "S/N"
        'End If
    End Sub

    Private Sub Notifica_PT()
        Limpia_Variables()
        Conexion_SAP = SAP_Conexion.SAP_Status(Seccion)
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
        N_Orden = TOrden.Text.Trim
        N_CodUser = CodOperador.Text.Trim
        N_Tramos = TtramosNoti.Text.Trim
        N_PB = TPesoBruto.Text.Trim
        N_PT = TPesoTara.Text.Trim
        N_PN = TPesoNeto.Text.Trim
        N_Empaques = "0"
        N_FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        N_HoraPesaje = Date.Now.TimeOfDay.ToString()
        N_Turno = cmbTurnos.Text.Trim
        N_PesoTeorico = TPesoTeorico.Text.Trim
        N_OperadorLinea = CB_Ope.SelectedValue
        N_FechaTurno = dtpFECHA.Value.ToString("yyyy-MM-dd")
        N_Sobrepeso = Format(Val(TSobrePeso.Text), xFormato)
        FechaPesajeSAP = dtpFECHASAP.Value.ToString("yyyyMMdd")

        N_Folio_Vale = TFolioVale.Text

        If N_Causa_SP = Nothing Then
            N_Causa_SP = "0"
        End If
        'Se valida peso bascula -------------------------------------------------------------------
        If ValidacionesBascula.ValidaPeso(N_PB, N_PT, N_PN) = False Then
            Exit Sub
        End If
        'Se verifica sobrepeso permitido ---------------------------------------------------------
        If RB_PT.Checked Then
            If (PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido) And P_SP = True Then
                N_StSobrePeso = "1"
                SP = TSobrePeso.Text
                'If TCausas.Text.Trim.Length = 0 Then
                '    MensajeBox.Mostrar("Seleccione una CAUSA de SOBREPESO ", "Aviso", MensajeBox.TipoMensaje.Information)
                '    CB_SP_Causa.Enabled = True
                '    TCausas.Enabled = True
                '    Catalogo_Causas.Combo_Causas(CB_SP_Causa, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, "", Seccion.Trim, "SP", False)
                '    TCausas.Focus()
                '    Exit Sub
                'End If
                FrmSobreBajoPeso.ShowDialog()
                If AutorizaSobrepeso = "2" Or AutorizaSobrepeso = "0" Then
                    MensajeBox.Mostrar("El Sobre/Bajo Peso no ha sido Autorizado ", "No Autorizado", MensajeBox.TipoMensaje.Information)
                    'LimpiaObjetos()
                    Exit Sub
                End If
            End If
        End If
        'Se asigna valor a variables de consumo compuestos 1, 2 -----------------------------------
        Dim aryTextFile() As String
        Dim Stat_Comp As Boolean


        'aryTextFile = ValidacionesCompuestos.ValidaCompuestos_Extrusion(N_PN, Comp_1, TPComp1.Text, Comp_2, TPComp2.Text).Split("|")
        'Stat_Comp = aryTextFile(0)
        'If Stat_Comp = False Then
        '    Exit Sub
        'Else
        '    N_Comp_1 = aryTextFile(1)
        '    N_Porc_1 = aryTextFile(2)
        '    N_Cant_1 = aryTextFile(3)
        '    N_Comp_2 = aryTextFile(4)
        '    N_Porc_2 = aryTextFile(5)
        '    N_Cant_2 = aryTextFile(6)

        '    Lista.Clear()

        '    If N_Comp_1 <> 0 Then
        '        Lista.Add(Util.QuitarCerosIzquierda(N_Comp_1.Trim) + "|" + N_Cant_1)
        '    End If

        '    If N_Comp_2 <> 0 Then
        '        Lista.Add(Util.QuitarCerosIzquierda(N_Comp_2.Trim) + "|" + N_Cant_2)
        '    End If

        'End If
        'Se verifica conexi�n con SAP --------------------------------------------------------------------------
        Permiso.SAP_Status("E", tsImagen)
        'Identificar Supervisor en Turno ---------------------------------------------------------
        'NP.Identifies_shift_supervisor(Date.Today.ToString("yyyy-MM-dd"), cmbTurnos.Text.Trim)
        'Identificar Compuesto original de la bom ------------------------------------------------
        'If P_CC1 = False Then
        '    CompOriginal = "0"
        'Else
        '    Dim Count As Integer = 0
        '    LecturaQry("PA_Identifica_Compuesto_BOM '" & SessionUser._sCentro & "', '" & TCodPT.Text.Trim & "' ")
        '    If (LecturaBD.Read) Then
        '        Count = Count + 1
        '        CompOriginal = LecturaBD(0)
        '    Else
        '        MsgBox("Este producto no tiene asignado compuesto virgen para su consumo", MsgBoxStyle.Critical)
        '        Return
        '    End If
        'End If

        'LecturaBD.Close()
        BNotificar.Enabled = False
        BSiguiente.Enabled = False
        '----------------------------------------- Inicio : Identificar si el producto usa empaques
        'N_Empaques = Produccion_Scrap_Extrusion.Empaques(TCodAnillo.Text.Trim, N_Tramos)
        '------------------------------------------- Fin : Identificar si el producto usa empaques
        'Se ingresa informaci�n de notificacion en la base de datos ------------------------------
        FolioSiguiente = ""
        'FolioSiguiente = Proceso_Extrusion.Alta_PT(SessionUser._sAlias.Trim, N_Orden, SessionUser._sCentro, N_FechaPesaje, N_HoraPesaje, strNumeroBascula, CB_Rack.Text.Trim,
        '                                N_PB, N_PT, N_PN, N_Empaques, N_Tramos, N_CodUser, N_FechaTurno, N_Turno, NP.r_Supervisor, N_Sobrepeso,
        '                                N_Causa_SP.Trim, TPtoTrabajo.Text.Trim, N_PesoTeorico, N_StSobrePeso, N_Comp_1.Trim, N_Porc_1, N_Cant_1,
        '                                N_Comp_2.Trim, N_Porc_2, N_Cant_2, Ver_Atlas, N_Folio_Vale)
        TFolioAtlas.Text = FolioSiguiente
        'Se registra el Sobre / Bajo Peso
        'If P_SP = True And N_StSobrePeso = "1" Then
        '    LecturaQry("PA_Insert_Sobrepesos " & SessionUser._sCentro & "_Sobrepesos, '" & TOrden.Text.Trim & "', '" & FolioSiguiente & "', '" & SP & "', '" & N_Causa_SP.Trim & "', '" & Autoriza_SP & "', '" & Obs_Peso & "' ")
        '    'Proceso en fondo para el envio de E-mail
        '    EmailThread = New Thread(New ThreadStart(AddressOf Me.ThreadProcSafe))
        '    EmailThread.IsBackground = True
        '    EmailThread.Start()
        'End If
        'Se verifica status de conexi�n y se determina si se envia a SAP o no --------------------
        Select Case Conexion_SAP
            Case "False"
                MsgBox(" No se realizara notificaci�n a SAP se encuntra deshabilitada la conexi�n ")
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
                                        "|" + FolioSiguiente.Trim
                        'Variables WS Duplicados
                        Dim Err_dup As String = ""
                        Dim Mns_dup As String = ""
                        Dim Return_dup As Object
                        Dim Tbl_dup As String()
                        WS_P.Consume_WS(SessionUser._sAlias.Trim, Header_Duplicado, Lista, SessionUser._sAmbiente)
                        Tbl_dup = WS_P.Tbl_resultado
                        Return_dup = WS_P.Return_SAP
                        Err_dup = Return_dup.ZTYPE
                        Mns_dup = Return_dup.ZMESSAGE

                        Select Case Err_dup
                            '------Si no existe la notificacion regresa Error y se realiza la notificaci�n normal
                            Case Is = "E"
                                'Lectura de WS Generico para realizar la notificaci�n ------------------------------------
                                Label22.Visible = True
                                Label22.Text = "Se esta Notificando la orden '" & TOrden.Text.Trim & "' a SAP"
                                Dim Head As String
                                Head = "28|" + TOrden.Text.Trim + "|" + N_Tramos.ToString + "|" + FechaPesajeSAP + "|" + CompOriginal.Trim + "|" + "P" + "|" + SessionUser._sAlias.Trim + "|" + FolioSiguiente
                                'NotificationProcess.Notifica_PTE(Head, Lista, FolioSiguiente.Trim, TDocSAP, TConSAP, BNotificar, BImprimir, TOrden, TPassNotifier.Text.Trim)
                                Label22.Visible = False
                                Label22.Text = ""
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
                                InQry = InQry & " Where Folio = '" & FolioSiguiente.Trim & "'"
                                InsertQry(InQry)
                                '------Fin Se ejecuta el WS verificacion duplicados
                        End Select
                    Case False
                        MsgBox(" No se realizara notificaci�n a SAP se encuntra deshabilitada la conexi�n ")
                        TDocSAP.Text = "0000000000"
                        TConSAP.Text = "00000000"
                End Select
        End Select
        'Consulta cantidades
        'ProductionOrder.CalCantExt(SessionUser._sAlias.Trim, TOrden.Text.Trim, TCantProgra, TCantEntre, TCantEnproce, TCantPendiente, SessionUser._sCentro.Trim)
        'Porcentaje de avance de la orden
        'ProductionOrder_2.Porcentaje_Orden(TCantEntre.Text, TCantEnproce.Text, TCantProgra.Text, Label8)
        BSiguiente.Enabled = True
        BImprimir.Enabled = True

    End Sub

    Private Sub Notifica_SC()
          Conexion_SAP = SAP_Conexion.SAP_Status(Seccion)
        Dim Lt_Compuestos As String = ""
        'If CB_Causas.Text = "" Then
        '    MensajeBox.Mostrar("Seleccione una Causa de Scrap", "Aviso", MensajeBox.TipoMensaje.Information)
        '    CB_Causas.Focus()
        '    Return
        'End If

        'If CB_Defecto.Text = "" Then
        '    MensajeBox.Mostrar("Seleccione un Defecto de Scrap", "Aviso", MensajeBox.TipoMensaje.Information)
        '    CB_Defecto.Focus()
        '    Return
        'End If

        'If CB_TipoSc.Text = "" Then
        '    MensajeBox.Mostrar("Seleccione el tipo de Scrap", "Aviso", MensajeBox.TipoMensaje.Information)
        '    CB_Defecto.Focus()
        '    Return
        'End If

        'Se asigna valor a variables -------------------------------------------------------------
        N_CodUser = CodOperador.Text.Trim
        N_PB = TPesoBruto.Text.Trim
        N_PT = TPesoTara.Text.Trim
        N_PN = TPesoNeto.Text.Trim
        N_PesoTeorico = TPesoTeorico.Text.Trim
        FechaPesajeSAP_CR = dtpFECHASAP.Value.ToString("yyyy-MM-dd")
        N_FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        N_HoraPesaje = Date.Now.TimeOfDay.ToString()
        N_FechaTurno = dtpFECHA.Value.ToString("yyyy-MM-dd")
        N_Turno = cmbTurnos.Text.Trim
        FechaPesajeSAP = dtpFECHASAP.Value.ToString("yyyyMMdd")
        'N_TipoScrap = CB_TipoSc.SelectedValue.Trim
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

        'aryTextFile = ValidacionesCompuestos.ValidaCompuestos_Extrusion(N_PN, Comp_1, TPComp1.Text, Comp_2, TPComp2.Text).Split("|")
        'Stat_Comp = aryTextFile(0)
        'If Stat_Comp = False Then
        '    Exit Sub
        'Else
        '    N_Comp_1 = aryTextFile(1)
        '    N_Porc_1 = aryTextFile(2)
        '    N_Cant_1 = aryTextFile(3)
        '    N_Comp_2 = aryTextFile(4)
        '    N_Porc_2 = aryTextFile(5)
        '    N_Cant_2 = aryTextFile(6)

        '    Lista.Clear()

        '    If N_Comp_1.Trim <> 0 Then
        '        Lista.Add(Util.QuitarCerosIzquierda(N_Comp_1.Trim) + "|" + N_Cant_1)
        '    End If

        '    If N_Comp_2.Trim <> 0 Then
        '        Lista.Add(Util.QuitarCerosIzquierda(N_Comp_2.Trim) + "|" + N_Cant_2)
        '    End If

        'End If
        'Se verifica conexi�n con SAP --------------------------------------------------------------------------
        Permiso.SAP_Status("E", tsImagen)
        'Identificar Supervisor en Turno -----------------------------------------------------------------------
        'NP.Identifies_shift_supervisor(Date.Today.ToString("yyyy-MM-dd"), cmbTurnos.Text.Trim)
        'Identificar Compuesto original de la bom --------------------------------------------------------------
        'If P_CC1 = False Then
        '    CompOriginal = "0"
        'Else
        '    Dim Compuesto As String = ""
        '    Dim arryText() As String
        '    arryText = NotificationProcess.Identifica_Compuesto_Original(TCodPT.Text.Trim).Split("|")
        '    CompOriginal = arryText(0)
        '    Reprocesado_Orig = arryText(1)
        '    If CompOriginal = "" Then
        '        Return
        '    End If
        'End If

        'If CompOriginal.Trim = Comp_1.Trim And TPComp1.Text = 100 Then
        '    Lt_Compuestos = ""
        'ElseIf CompOriginal.Trim <> Comp_1.Trim And TPComp1.Text = 100 Then
        '    Lt_Compuestos = CompOriginal.Trim & "|" & TPComp1.Text & "|" & Comp_1.Trim
        'ElseIf TPComp1.Text < 100 Then
        '    Lt_Compuestos = CompOriginal.Trim & "|" & TPComp1.Text & "|" & Comp_1.Trim & "||" & CompOriginal.Trim & "|" & TPComp2.Text & "|" & Comp_2.Trim
        '    If Comp_2.Trim = "" Then
        '        MensajeBox.Mostrar("Selecciones un segundo compuesto", "Aviso", MensajeBox.TipoMensaje.Information)
        '        Return
        '    End If
        'End If
        'Identifica si el compuesto es de paros y arranques o normal
        'Reprocesado_Gen = NotificationProcess.Identifica_Reprocesado(Comp_1.Trim)
        'Se deshabilta boton de Notificaci�n para evitar duplicidad
        BNotificar.Enabled = False
        'Se ingresa informaci�n de notificacion en la base de datos --------------------------------------------
        'Se crea el folio correspondiente al pesaje
        FolioSiguiente = ""

        Try
            'FolioSiguiente = Proceso_Extrusion.Alta_SC(SessionUser._sAlias.Trim, TOrden.Text.Trim, SessionUser._sCentro.Trim, N_FechaPesaje, N_HoraPesaje, strNumeroBascula,
            '                                   N_TipoScrap, N_PB, N_PT, N_PN, N_CodUser, N_Turno, CB_Causas.SelectedValue.Trim,
            '                                   CB_Defecto.SelectedValue.Trim, N_FechaTurno, TPtoTrabajo.Text.Trim, Reprocesado_Gen,
            '                                   N_OperadorLinea.Trim, N_Rack, N_Comp_1, N_Porc_1, N_Cant_1, N_Comp_2, N_Porc_2, N_Cant_2,
            '                                   Lt_Compuestos.Trim, Ver_Atlas.Trim)
        Catch ex As Exception
            MensajeBox.Mostrar(ex.Message, "Critico", MensajeBox.TipoMensaje.Critical)
        End Try
        TFolioAtlas.Text = FolioSiguiente
        Select Case Conexion_SAP
            Case "False"
                MsgBox(" No se realizara notificaci�n a SAP se encuntra deshabilitada la conexi�n ")
                TDocSAP.Text = "0000000000"
                TConSAP.Text = "00000000"
            Case "True"
                Select Case chkSAP.Checked
                    Case True
                        Select Case SessionUser._sCentro.Trim
                            Case Is <> "CR01"
                                Label22.Visible = True
                                Label22.Text = "Se esta Notificando la orden '" & TOrden.Text.Trim & "' a SAP"
                                Dim Head As String
                                Head = "28|" + TOrden.Text.Trim + _
                                         "|" + TPesoNeto.Text.Trim + _
                                         "|" + FechaPesajeSAP + _
                                         "|" + CompOriginal.Trim + _
                                         "|" + "S" + _
                                         "|" + SessionUser._sAlias.Trim + _
                                         "|" + FolioSiguiente + _
                                         "|" + Reprocesado_Gen
                                'NotificationProcess.Notifica_SCE(Head, Lista, FolioSiguiente.Trim, TDocSAP, TConSAP, BNotificar, BImprimir, TOrden, _
                                '                                 CodOperador.Text.Trim)
                                Label22.Visible = False
                                Label22.Text = ""
                            Case Is = "CR01"
                                Label22.Visible = True
                                Label22.Text = "Se esta Notificando la orden '" & TOrden.Text.Trim & "' a SAP"
                                CadenaTexto = SessionUser._sAlias.Trim & "|" & FolioSiguiente.Trim
                                Consume_WS_CR01(SessionUser._sAlias, SessionUser._sAmbiente, CadenaTexto.Trim, Lt_Compuestos.Trim, FechaPesajeSAP_CR, TOrden.Text.Trim, TPesoNeto.Text, FolioSiguiente.Trim)
                                Label22.Visible = False
                                Label22.Text = ""
                        End Select
                        'Lectura de WS Generico para realizar la notificaci�n ------------------------------------
                    Case False
                        MsgBox(" No se realizara notificaci�n a SAP se encuntra deshabilitada la conexi�n ")
                        TDocSAP.Text = "0000000000"
                        TConSAP.Text = "00000000"
                End Select
        End Select
    End Sub

    Private Sub ValidaOrden()
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
                        SQL_DATA.OrdenProduccion.Cantidades(TOrden.Text.Trim)
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

    Private Sub SetRedOrden()
        'TCodPT.Text = ValidaODF._rIdProducto
        'TCodPtDecr.Text = ValidaODF._rProducto
        'TGrpprod.Text = ValidaODF._rIdGrpProd
        'TGrpproddesc.Text = ValidaODF._rGrpProd
        'TGrupo.Text = ValidaODF._rGrupoMat
        'TPesoTeorico.Text = ValidaODF._rPesoTeorico
        'TSP_Permitido.Text = ValidaODF._rSPPermitido
        'TPtoTrabajo.Text = ValidaODF._rIdEquipo
        'TNomPtoTrabajo.Text = ValidaODF._rEquipo
    End Sub

    Private Sub Compuestos()
        'Activa Combo Box de compuestos 1
        'Catalogo_Compuestos.CB_Compuesto1(CBCom1, SessionUser._sAlias, SessionUser._sCentro, ValidaODF._rIdProducto, EXTINY, TipoProd, P_CC1)
    End Sub

#End Region

#Region "Eventos"

    Private Sub TOrden_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TOrden.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            ValidaOrden()
        End If
    End Sub

    Private Sub TtramosNoti_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TtramosNoti.Leave
        If TtramosNoti.Text.Trim <> "0" Then
            If RB_SC.Checked = False Then
                SQL_DATA.OrdenProduccion.DetallePiezasPesos(DGV_Emb, TOrden.Text, Val(TtramosNoti.Text))
                PesoEmbalajes()
                TPesoTara.Text = Format(Val(TPesoRack.Text), xFormato)
                If TtramosNoti.Text.Trim.Length > 0 Then
                    BNotificar.Enabled = True
                End If
                TtramosNoti.BackColor = Color.White
            End If
            CB_Rack.Focus()
        End If
    End Sub

    Private Sub BPesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNotificar.Click
        'Valida campos obligatorios ----------------------------------------------------------------------------
        If TPassNotifier.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese clave de operador", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TPassNotifier.Focus()
            Return
        End If

        If TOrden.Text.Trim = "" Then
            MensajeBox.Mostrar("Debe de asignar una orden de fabricaci�n", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TOrden.Focus()
            Return
        End If

        If TPtoTrabajo.Text.Trim = "" Then
            MensajeBox.Mostrar("La Orden de Producci�n no asignado Puesto de Trabajo", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            Return
        End If

        'If CB_Com1.SelectedValue.Trim = "" And P_CC1 = True Then
        '    MensajeBox.Mostrar("Seleccione un compuesto a consumir", "Aviso", MensajeBox.TipoMensaje.Exclamation)
        '    CB_Com1.Focus()
        '    Return
        'End If

        'If TPComp1.Text = 0 And P_CC1 = False Then
        '    MensajeBox.Mostrar("El porcenatje de participacion del compuesto 1 no puede ser 0", "Aviso", MensajeBox.TipoMensaje.Exclamation)
        '    TPComp1.Focus()
        '    Return
        'End If

        'Selecciona proceso de Notificacion Producto Terminado o Scrap -----------------------------------------
        If RB_PT.Checked Then
            Notifica_PT()
        End If

        If RB_SC.Checked Then
            Notifica_SC()
        End If
        '-------------------------------------------------------------------------------------------------------
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
        LimpiaObjetos()
        TSobrePeso.BackColor = Color.White
        TPassNotifier.Focus()
    End Sub

    Private Sub BImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImprimir.Click

        If RB_PT.Checked Then
            'Reportes.Boleta_Pesaje_PTE_Ext(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, TFolioAtlas.Text.Trim, "0")
        End If

        If RB_SC.Checked Then
            'Reportes.Boleta_Pesaje_SCE_Ext(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, TFolioAtlas.Text.Trim, "0")
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Dim TPC As String = ""
        'Dim TPC2 As String = ""

        'Cadena = FrmMain.SerialPort1.ReadExisting

        'TPC = Chr(CH1)
        'TPC2 = Chr(CH2)
        'If Cadena.Length > 13 Then
        '    If Cadena.StartsWith(TPC) = True Then
        '        Lectura = Cadena.Substring((Cadena.IndexOf(TPC2) + AddChar), LenghtLec).Trim
        '    End If
        'End If
        'If SessionUser._sCentro.Trim = "GT01" Then
        '    TPesoBruto.Text = Format((Val(Lectura) / 10), xFormato)
        'Else
        '    TPesoBruto.Text = Format(Val(Lectura), xFormato)
        'End If
    End Sub

    Private Sub TPesoNeto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoNeto.TextChanged
        Dim xPSP As Double
        Dim xTramosNoti As Double
        Dim xPeso_Neto As Double

        PorcentajePeso()
        PesoTeorico = "0" & TPesoTeorico.Text.Trim
        xTramosNoti = "0" & TtramosNoti.Text.Trim
        xPeso_Neto = "" & TPesoNeto.Text.Trim
        SobrepesoPermitido = "0" & TSP_Permitido.Text.Trim
        PorcentajeSobrePeso = 0

        If RB_PT.Checked Then
            If PesoTeorico > 0 And xTramosNoti > 0 Then
                xPSP = (((xPeso_Neto / (PesoTeorico * xTramosNoti)) - 1) * 100)
                PorcentajeSobrePeso = Format(xPSP, xFormato)
            Else
                PorcentajeSobrePeso = Format(100, xFormato)
            End If

            TSobrePeso.Text = Format(PorcentajeSobrePeso, "#0.00")

            If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
                TSobrePeso.BackColor = Color.Red
                'TCausas.Enabled = True
            Else
                TSobrePeso.BackColor = Color.Yellow
            End If

        End If
        If TOrden.Text.Trim <> "" Then
            If TCodPT.Text.Trim <> "" Then
                If TtramosNoti.Text.Trim <> "0" Then
                    'SQL_DATA.OrdenProduccion.ConsumosCompuestos(DGVResumen, TOrden.Text.Trim, TCodPT.Text.Trim, TtramosNoti.Text, TPesoNeto.Text.Trim, ConfigCompuestos._Lista.Trim)                    
                End If
            End If
        End If


    End Sub

    Private Sub TSobrePeso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSobrePeso.TextChanged
        If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
            TSobrePeso.BackColor = Color.Red
            CB_SP_Causa.Enabled = True
            If P_CD = True Then
                CB_SP_Causa.DataSource = Nothing
                CB_SP_Causa.Enabled = False
            Else
                CB_SP_Causa.DataSource = Nothing
                CB_SP_Causa.Enabled = True
                Catalogo_Causas.Combo_Causas(CB_SP_Causa, "", Seccion.Trim, "SP", P_CD)
            End If
        Else
            TSobrePeso.BackColor = Color.Yellow
            CB_SP_Causa.DataSource = Nothing
            CB_SP_Causa.Enabled = False
        End If
    End Sub

    Private Sub TOrden_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOrden.Enter
        TOrden.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TtramosNoti_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TtramosNoti.Enter
        If RB_SC.Checked = False Then
            TtramosNoti.BackColor = Color.LightSkyBlue
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
        KeyAscii = CShort(Util.Decimales(KeyAscii))
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

    Private Sub TClaveOperador_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPassNotifier.Enter
        TPassNotifier.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TClaveOperador_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TPassNotifier.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            ValidaControlador()
        End If
    End Sub


    Private Sub NotificaExtrusion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Timer1.Enabled = False
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
            'TDescrack.Text = Catalogo_Racks.Desc_Rack(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, CB_Rack.Text.Trim)
        End If
    End Sub

    Private Sub CB_Rack_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Rack.Enter
        CB_Rack.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub CB_Com1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Com2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
        TipoProd = ""
        TipoProd = "T"
        If RB_PT.Checked = True Then
            TBP1.Parent = Nothing
            TBP2.Parent = TBC1
            TtramosNoti.ReadOnly = False
            TtramosNoti.BackColor = Color.White
            TOrden.Enabled = True
            TOrden.Focus()
        End If
    End Sub

    Private Sub RB_SC_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_SC.CheckedChanged
        TipoProd = ""
        TipoProd = "S"
        If RB_SC.Checked = True Then
            TBP1.Parent = TBC1
            TBP2.Parent = Nothing
            TtramosNoti.Text = "0"
            TtramosNoti.ReadOnly = True
            TtramosNoti.BackColor = Color.White
            TOrden.Text = ""
            TOrden.Enabled = True
            BNotificar.Enabled = True
            TOrden.Focus()
        End If
    End Sub

    Private Sub CB_Causa_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Causas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Defecto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_TipoSc_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_TipoSc_Leave(sender As System.Object, e As System.EventArgs)
        BNotificar.Focus()
    End Sub

    Private Sub TempaquePesoTot_TextChanged(sender As System.Object, e As System.EventArgs)
        Dim xTPesoEmpaque As Double
        'xTPesoEmpaque = "0" & TempaquePesoTot.Text.Trim
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
        'Permiso.Accesos("MP_IMP_PT", "1", SessionUser._sIdPerfil, "E", "Reportes Producto Terminado ")
    End Sub

    Private Sub ScrapToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScrapToolStripMenuItem.Click
        'Permiso.Accesos("MP_IMP_SC", "1", SessionUser._sIdPerfil, "E", "Reportes Scrap ")
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        'Dim TPC As String = ""
        'Dim TPC2 As String = ""

        'Cadena = FrmMain.SerialPort2.ReadExisting

        'TPC = Chr(CH1)
        'TPC2 = Chr(CH2)
        'If Cadena.Length > 13 Then
        '    If Cadena.StartsWith(TPC) = True Then
        '        Lectura = Cadena.Substring((Cadena.IndexOf(TPC2) + AddChar), LenghtLec).Trim
        '    End If
        'End If
        'If SessionUser._sCentro.Trim = "GT01" Then
        '    TPesoBruto.Text = Format((Val(Lectura) / 10), xFormato)
        'Else
        '    TPesoBruto.Text = Format(Val(Lectura), xFormato)
        'End If
    End Sub

    Private Sub MP_CON_PROD_Click(sender As System.Object, e As System.EventArgs) Handles MP_CON_PROD.Click
        'Permiso.Accesos("MP_CON_PROD", "1", SessionUser._sIdPerfil, "E", "Consulta Produccion / Scrap ")
    End Sub

    Private Sub MP_CON_SP_Click(sender As System.Object, e As System.EventArgs) Handles MP_CON_SP.Click
        'Permiso.Accesos("MP_CON_SP", "1", SessionUser._sIdPerfil, "E", "Consulta Sobre / Bajo Pesos ")
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

    Private Sub TCausas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If SessionUser._sCentro.Trim = "CR01" Then
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End If
    End Sub

    Private Sub TCCausas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TCDefecto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Consume_WS_CR01(ByVal Usr_Atlas As String, ID As String, CadenaTexto As String, Lt_Compuestos As String, _
                                      FechaPesajeSAP As String, Orden As String, PesoNeto As String, folio As String)
        'Dim Err As String
        'Dim Mns As String
        'Dim reg As String = ""
        'Dim Cod_Err As String = ""


        'If ID.Trim = "D" Then
        '    'Variables Desarrollo
        '    Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
        '    Dim ls_returnr As New PTConsumos.ZBAPIRET2
        '    Dim ls_Notifica As New PTConsumos.ZEPP002
        '    Dim ls_result As New PTConsumos._ISDFPS_TCUPS_KEY
        '    Dim TNumNoti As String = ""
        '    Dim TConsNoti As String = ""
        '    Try
        '        ls_Notifica.ZBUDAT = FechaPesajeSAP.Trim
        '        ls_Notifica.ZCONSUME_REC = 0
        '        ls_Notifica.ZENTRY_QNT = 0
        '        ls_Notifica.ZISM01 = 0
        '        ls_Notifica.ZISM02 = 0
        '        ls_Notifica.ZISM03 = 0
        '        ls_Notifica.ZISMNGEH1 = ""
        '        ls_Notifica.ZISMNGEH2 = ""
        '        ls_Notifica.ZISMNGEH3 = ""
        '        ls_Notifica.ZMATNR_REC = ""
        '        ls_Notifica.ZMATNR_REC = ""
        '        ls_Notifica.ZORDERID = Orden.Trim
        '        ls_Notifica.ZRECOVERED = PesoNeto
        '        ls_Notifica.ZVIRGIN = 0
        '        lo_wsamancomxr.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3m4tl4s")
        '        ls_result = lo_wsamancomxr.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notifica, ls_returnr)
        '        TNumNoti = ls_result.RUECK
        '        TConsNoti = ls_result.RMZHL
        '        Err = ls_returnr.ZTYPE
        '        Mns = ls_returnr.ZMESSAGE
        '    Catch ex As Exception
        '        MsgBox("No se realizar notificaci�n a SAP ", MsgBoxStyle.Critical, ex.Message)
        '    End Try
        'ElseIf ID.Trim = "P" Then
        '    'Variables Productivo
        '    Dim lo_wsamancomxp As New PTConProd.ZPPMXF001Service
        '    Dim ls_returnp As New PTConProd.ZBAPIRET2
        '    Dim ls_Notificap As New PTConProd.ZEPP002
        '    Dim ls_resultp As New PTConProd._ISDFPS_TCUPS_KEy
        '    Dim TNumNoti As String = ""
        '    Dim TConsNoti As String = ""
        '    Try
        '        ls_Notificap.ZBUDAT = FechaPesajeSAP.Trim
        '        ls_Notificap.ZCONSUME_REC = 0.0
        '        ls_Notificap.ZENTRY_QNT = 0
        '        ls_Notificap.ZISM01 = 0.0
        '        ls_Notificap.ZISM02 = 0.0
        '        ls_Notificap.ZISM03 = 0.0
        '        ls_Notificap.ZISMNGEH1 = ""
        '        ls_Notificap.ZISMNGEH2 = ""
        '        ls_Notificap.ZISMNGEH3 = ""
        '        ls_Notificap.ZMATNR_REC = ""
        '        ls_Notificap.ZORDERID = Orden.Trim
        '        ls_Notificap.ZRECOVERED = PesoNeto
        '        ls_Notificap.ZVIRGIN = 0.0
        '        lo_wsamancomxp.Credentials = New System.Net.NetworkCredential("ATLAS", "m3x1ch3m4tl4s")
        '        ls_resultp = lo_wsamancomxp.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notificap, ls_returnp)
        '        TNumNoti = ls_resultp.RUECK
        '        TConsNoti = ls_resultp.RMZHL
        '        Err = ls_returnp.ZTYPE
        '        Mns = ls_returnp.ZMESSAGE

        '        If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
        '            reg = "0"
        '            MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
        '            InQry = ""
        '            InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set MsgSAP = '" & Mns.Trim & "' "
        '            InQry = InQry & " Where Folio = '" & folio.Trim & "'"
        '            db.InsertQry(InQry)
        '            Exit Sub
        '        Else
        '            If (TNumNoti = "" Or TNumNoti = "NULL" Or TNumNoti = "0000000000") And (TConsNoti = "" Or TConsNoti = "NULL" Or TConsNoti = "00000000") Then
        '                reg = "0"
        '                MsgBox("No Notifico a SAP")
        '                BNotificar.Enabled = False
        '                BImprimir.Enabled = True
        '                TOrden.Enabled = False
        '                'SuperAutoSobrepeso = ""
        '                Return
        '            Else
        '                reg = "1"
        '                TDocSAP.Text = TNumNoti
        '                TConSAP.Text = TConsNoti
        '                'LecturaQry("PA_Actualiza_Notificacion_Scrap " & SessionUser._sCentro.Trim & "_PesoScrap, '" & TNumNoti & "', '" & TConsNoti & "', '" & reg & "', '" & Mns & "',  '" & folio & "' ")
        '                BNotificar.Enabled = True
        '                TOrden.Enabled = False
        '                'SuperAutoSobrepeso = ""
        '                MensajeBox.Mostrar("La notificaci�n de la Orden '" & Orden.Trim & "' a sido Exitosa ", "Notificaci�n Exitosa", MensajeBox.TipoMensaje.Good)
        '            End If
        '        End If
        '    Catch ex As Exception
        '        MsgBox("No se realizar notificaci�n a SAP ", MsgBoxStyle.Critical, ex.Message)
        '    End Try
        'End If
    End Sub

    Private Sub CB_Manual_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_Manual.CheckedChanged
        'If CB_Manual.Checked Then
        '    GB_Basculas.Enabled = False
        '    RB1.Checked = False
        '    RB2.Checked = False
        '    RB3.Checked = False
        '    Timer1.Enabled = False
        '    Timer2.Enabled = False
        '    Timer3.Enabled = False
        'Else
        '    GB_Basculas.Enabled = P_MB
        '    RB1.Checked = True
        '    RB2.Checked = False
        '    RB3.Checked = False
        'End If
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

#End Region


#Region "METODOS"
    Private Sub ValidaControlador()
        Dim IdLogin As Boolean
        Pass_md5 = Crypto.MD5Calculate(TPassNotifier.Text.Trim)
        IdLogin = Users.Login_Notifier(SessionUser._sAlias, Pass_md5.Trim)
        CodOperador.Text = ""
        NomOperador.Text = ""

        If IdLogin = True Then
            CodOperador.Text = LoginNotifier._nAlias
            NomOperador.Text = LoginNotifier._nNombre
            RB_PT.Focus()
        Else
            MensajeBox.Mostrar("Nombre de usuario o contraseña incorrecta", "Verificar", MensajeBox.TipoMensaje.Exclamation)
            TPassNotifier.Text = ""
            TPassNotifier.Focus()
        End If
    End Sub

    Private Sub SetInfoOrden()
        TPtoTrabajo.Text = ""

    End Sub
#End Region


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
        Select Case PesajeAtlas = True
            Case Is = True
                ValidaOrden()
        End Select
    End Sub

    Private Sub NotificaExtrusion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Centro.Text = SessionUser._sCentro
        ' ---------------------------------------------------------------------------------
        'Se verifica conexi�n con SAP
        Status("E")
        ' ---------------------------------------------------------------------------------
        'Inicializan fecha Turno y SAP
        Inicializa_Frm_PTEI(dtpFECHA, dtpFECHASAP, chkSAP)
        ' ---------------------------------------------------------------------------------
        'Parametrizacion.Parametrized_Form(Me)
        'Parametrizacion_Forma()
        ' ---------------------------------------------------------------------------------
        LimpiaObjetos()
        TSobrePeso.BackColor = Color.White
        TPassNotifier.Focus()
    End Sub

    Private Sub Status(ByVal Modulo As String)
        Select Case SQL_DATA.Conexion.SAP(Modulo)
            Case "True"
                tsImagen.Image = Global.Atlas.My.Resources.btn_SAPOk
                tsImagen.Text = "En comunicación con SAP"
                tsImagen.ForeColor = Color.Blue
            Case "False"
                tsImagen.Image = Global.Atlas.My.Resources.btn_SAPFail
                tsImagen.Text = "No hay comunicación con SAP"
                tsImagen.ForeColor = Color.Red
        End Select
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
                If Btn_Notificar = "1" Then
                    MensajeBox.Mostrar("Orden Excedida en : " & Res & " %  ", "Orden Excedida", MensajeBox.TipoMensaje.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub CB_Comp1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_Comp1.CheckedChanged
        Select Case ConfigCompuestos._Cantidad
            Case Is = 1
                TPComp1.Text = "100"
        End Select
    End Sub

    Private Sub CB_Comp2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_Comp2.CheckedChanged
        If CB_Comp2.Checked Then
            Select Case ConfigCompuestos._Cantidad
                Case Is = 1
                    Select Case TipoProd
                        Case Is = "T"
                            SQL_DATA.Compuestos.CBComp1(CB_Com2, ConfigCompuestos._Codigo.Trim, ConfigCompuestos._Lista.Trim, 2)
                        Case Is = "S"
                            SQL_DATA.Compuestos.CBComp1(CB_Com2, ConfigCompuestos._Codigo.Trim, ConfigCompuestos._Lista.Trim, 3)
                    End Select
                    CB_Com2.Enabled = True
                    Comp2 = CB_Com2.SelectedValue
                    TPComp2.Text = "0"
                    TPComp1.Text = "100"
                    TPComp1.ReadOnly = False
                    CB_Comp3.Checked = False
                    CB_Comp3.Enabled = True
            End Select
        Else
            CB_Com2.DataSource = Nothing
            CB_Com2.Text = ""
            Select Case ConfigCompuestos._Cantidad
                Case Is = 1
                    CB_Com2.Enabled = False
                    TPComp2.Text = "0"
                    TPComp2.ReadOnly = True
                    TPComp2.Enabled = False
                    Comp2 = ""
                    TPComp1.Text = "100"
                    TPComp1.ReadOnly = True
                    CB_Comp3.Checked = False
                    CB_Comp3.Enabled = False
                Case Is = 3
                    CB_Com2.Enabled = True
            End Select
        End If
    End Sub

    Private Sub CB_Comp3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_Comp3.CheckedChanged
        If CB_Comp3.Checked Then
            Select Case ConfigCompuestos._Cantidad
                Case Is = 1
                    Select Case TipoProd
                        Case Is = "T"
                            SQL_DATA.Compuestos.CBComp1(CB_Com3, ConfigCompuestos._Codigo, ConfigCompuestos._Lista, 2)
                        Case Is = "S"
                            SQL_DATA.Compuestos.CBComp1(CB_Com3, ConfigCompuestos._Codigo, ConfigCompuestos._Lista, 3)
                    End Select
                    CB_Com3.Enabled = True
                    TPComp2.Enabled = True
                    TPComp2.ReadOnly = False
                    TPComp3.Text = 0
                    TPComp1.ReadOnly = True
            End Select
        Else
            Select Case ConfigCompuestos._Cantidad
                Case Is = 1
                    CB_Com3.DataSource = Nothing
                    CB_Com3.Text = ""
                    CB_Com3.Enabled = False
                    TPComp3.Text = "0"
                    TPComp2.Text = 100 - Val(TPComp1.Text)
                    TPComp2.Enabled = False
                    TPComp2.ReadOnly = True
                    TPComp3.Enabled = False
                    TPComp1.ReadOnly = False
                Case Is = 3
                    CB_Com3.DataSource = Nothing
                    CB_Com3.Text = ""
                    CB_Com3.Enabled = True
            End Select
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

    Private Sub CB_Com3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Com3.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Com1_Leave(sender As System.Object, e As System.EventArgs) Handles CB_Com1.Leave
        Select Case ConfigCompuestos._Cantidad
            Case Is = 1
                Comp1 = CB_Com1.SelectedValue
        End Select
    End Sub

    Private Sub CB_Com2_Leave(sender As System.Object, e As System.EventArgs) Handles CB_Com2.Leave
        Select Case ConfigCompuestos._Cantidad
            Case Is = 1
                If Comp2.Trim = Comp1.Trim Then
                    MsgBox("El compuesto seleccionado no puede ser el mismo que el primero", MsgBoxStyle.Information)
                    CB_Com2.DataSource = Nothing
                    Select Case TipoProd
                        Case Is = "T"
                            SQL_DATA.Compuestos.CBComp1(CB_Com3, ConfigCompuestos._Codigo, ConfigCompuestos._Lista, 2)
                        Case Is = "S"
                            SQL_DATA.Compuestos.CBComp1(CB_Com3, ConfigCompuestos._Codigo, ConfigCompuestos._Lista, 3)
                    End Select
                    CB_Com2.Text = ""
                    Comp2 = "0"
                    CB_Com2.Focus()
                End If
        End Select
    End Sub

    Private Sub TPComp1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPComp1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Util.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TPComp1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPComp1.TextChanged
        Try
            If TPComp1.Text.Trim = 100 Then
                CB_Com2.Text = ""
                Comp2 = "0"
                TPComp2.Text = 0
            ElseIf TPComp1.Text.Trim > 100 Then
                MessageBox.Show("No se permiten valores mayores al 100%")
                TPComp1.Text = "100"
            ElseIf TPComp1.Text <= 0 Then
                TPComp2.Text = 0
            Else
                TPComp2.Text = 100 - Val(TPComp1.Text)
                Comp2 = CB_Com2.SelectedValue                
            End If
            If TPComp1.Text.Trim = 0 Then
                MessageBox.Show("No se permite valor de 0% o negativos ")
                TPComp1.Text = "100"
            End If
        Catch ex As Exception
            TPComp1.Text = "100"
        End Try
    End Sub

    Private Sub TPComp2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPComp2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Util.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TPComp3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPComp3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Util.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PorcentajePeso()
        TP1.Text = (Val(TPesoNeto.Text) * Val(TPComp1.Text) / 100)
        TP2.Text = (Val(TPesoNeto.Text) * Val(TPComp2.Text) / 100)
        TP3.Text = (Val(TPesoNeto.Text) * Val(TPComp3.Text) / 100)
    End Sub

    Private Sub TP2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TP2.TextChanged
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

    Private Sub PesoEmbalajes()
        Dim xTPesoEmpaque As Double = 0
        SQL_DATA.OrdenProduccion.TotalPiezasPesos(TOrden.Text.Trim, TtramosNoti.Text)
        xTPesoEmpaque = "0" & PesosPiezas._Pesos.Trim
        TPesoEmpaque.Text = Format(xTPesoEmpaque, xFormato)
    End Sub

End Class