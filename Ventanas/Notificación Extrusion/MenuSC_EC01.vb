Imports System.IO
Imports System.IO.Ports.SerialPort
Imports System.IO.Ports.SerialDataReceivedEventArgs
Imports System.IO.Ports.SerialPinChangedEventArgs
Imports System.Data.SqlClient
Imports System.Configuration
Imports Atlas.Accesos.CLVarGlobales
Imports Atlas.Accesos
Imports SQL_DATA

Public Class MenuSC_EC01
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

    Dim descripcion As String = ""
    Dim taraempaque As Decimal
    Dim PesoTeorico As Decimal
    Dim CodigoEmpaque As String
    Dim grpMaterial As String
    Dim EstatusActiva As Integer
    Dim StrTramos As String
    Dim StrCompuesto As String
    Dim StrDescComp As String
    Dim EqpBasico As String
    Dim WorkCenter As String = ""
    Dim CantEntregada As String
    Dim ATLAS_PASS As String
    Dim xORIGINAL As String = ""

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

    Dim strPB As Integer
    Dim strVP As String = ""
    Dim strIP As String = ""

    Dim Tipo As String = Chr(33)
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
    Dim nvoDocumento_SAP As String
    Dim nvoConsecutivo_SAP As String
    Dim ValControlCompuesto As String
    Dim nvoPiezas_Scrap As Decimal
    Dim nvoPesoTeorico As Decimal
    Dim nvoGrupoMaterial As String

    Dim Lt_Compuestos As String
    Dim CompOriginal As String
    Dim CadenaTexto As String
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
    Dim tablaEXTINY As String

    Dim xTGRUPO As String
    Dim xUSUARIOREG As String
    Dim xFECHAREG As String
    Dim xHORAREG As String

    Private Sub MenuSC_EC01_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        FUERATURNO = 0
    End Sub

    Private Sub MenuSC_EC01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim mfor As Integer
        'StrProducto = ""
        'TCentro.Text = strPlanta.Trim
        'EXTINY = "1"
        'tablaEXTINY = "productoterminadoextrusion"
        'Titulos_ppal()
        'strNumeroBascula = ValCodigoBascula.Trim
        '' ---------------------------------------------------------------------------------
        'Select Case UsrLog
        '    Case Is = "ATLAS"
        '        Result = MessageBox.Show("Dev.Báscula", "Báscula", Buttons)
        '        Select Case Result
        '            Case 6
        '                If ValCodigoBascula = "M" Or ValCodigoBascula = "X" Or FUERATURNO = 1 Then
        '                    TPesoCaptura.Enabled = True
        '                    TPesoCaptura.Visible = True
        '                    LPesoCaptura.Visible = True
        '                Else
        '                    Timer1.Enabled = True
        '                End If
        '            Case 7 'No
        '                If ValCodigoBascula = "M" Or ValCodigoBascula = "X" Or FUERATURNO = 1 Then
        '                    TPesoCaptura.Enabled = True
        '                    TPesoCaptura.Visible = True
        '                    LPesoCaptura.Visible = True
        '                Else
        '                    Timer1.Enabled = True
        '                End If
        '        End Select
        '        ' ---------------------------------------------------------------------------------
        '    Case Is <> "ATLAS"
        '        If ValCodigoBascula = "M" Or ValCodigoBascula = "X" Or FUERATURNO = 1 Then
        '            TPesoCaptura.Enabled = True
        '            TPesoCaptura.Visible = True
        '            LPesoCaptura.Visible = True
        '        Else
        '            Timer1.Enabled = True
        '        End If
        'End Select
        '' ---------------------------------------------------------------------------------
        'QRY_AMD = ""
        'QRY_AMD = "Select Status FROM ADM_StatusSAP WHERE Planta='" & strPlanta.Trim & "'"
        'LecturaQry_AMD(QRY_AMD)
        'If LecturaBD_AMD.Read() Then
        '    StatusSap = LecturaBD_AMD(0)
        'End If
        'LecturaBD_AMD.Close()
        '' ---------------------------------------------------------------------------------
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
        '' ---------------------------------------------------------------------------------
        'Try
        '    Dim dsCombo As DataSet
        '    Q = ""
        '    Q = "SELECT RTRIM(Descripcion)  FROM dbo.ADM_Turno"
        '    Q = Q & " WHERE planta= '" & strPlanta.Trim & "'"
        '    Q = Q & " GROUP BY Descripcion"

        '    AbrirConfiguracion()

        '    objDa = New SqlDataAdapter(Q, objCnn)
        '    dsCombo = New DataSet
        '    objDa.Fill(dsCombo)
        '    With dsCombo.Tables(0)
        '        For mfor = 0 To .Rows.Count - 1
        '            cmbTurnos.Items.Add(.Rows(mfor).Item(0).ToString.Trim)
        '        Next
        '    End With
        'Catch ex As Exception
        '    MessageBox.Show("Error llenar Turnos :" & ex.Message, "  VENTANA DE ERROR * * * ")
        'End Try
        'LecturaBD_AMD.Close()
        '' ---------------------------------------------------------------------------------
        'dregistro = "0"
        'dateRegistro = Today()
        'FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
        'HoraPesaje = Date.Now.TimeOfDay.ToString
        'Try
        '    ' ---------------------------------------------------------------------------------
        '    QRY_AMD = ""
        '    QRY_AMD = " Select TT.Turno, TT.Descripcion, Convert(char(8),TT.Hora_Inicio,108) as Hora_Inicio, "
        '    QRY_AMD = QRY_AMD & " Convert(char(8),TT.Hora_Terminacion,108) as Hora_Terminacion, TT.registro "
        '    QRY_AMD = QRY_AMD & " FROM ADM_Turno TT INNER JOIN ADM_CambioHora CH ON TT.Planta=CH.Planta "
        '    QRY_AMD = QRY_AMD & " AND Convert(char(10), getdate(),102)between Convert(char(10), CH.Fecha_Inicio,102) AND Convert(char(10),CH.fecha_Terminacion,102) "
        '    QRY_AMD = QRY_AMD & " WHERE Convert(char(8), getdate()+(CH.CHora/24),108) between Convert(char(8), Hora_Inicio,108) "
        '    QRY_AMD = QRY_AMD & " AND Convert(char(8),Hora_Terminacion,108) and TT.Planta='" & strPlanta.Trim & "' "
        '    LecturaQry_AMD(QRY_AMD)
        '    Turno = "1"
        '    If LecturaBD_AMD.Read() Then
        '        Turno = LecturaBD_AMD(0)
        '        dateRegistro = DateAdd(DateInterval.Day, -Val(LecturaBD_AMD(4)), dateRegistro)
        '    End If
        '    If cmbTurnos.Items.Count > 0 Then
        '        cmbTurnos.SelectedIndex = Turno - 1
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Error llenar Turnos :" & ex.Message, "  VENTANA DE ERROR * * * ")
        'End Try
        'LecturaBD_AMD.Close()
        '' ---------------------------------------------------------------------------------
        'dtpFECHA.Value = Date.Today.ToString("yyyy-MM-dd")
        'dtpFECHASAP.Value = Date.Today.ToString("yyyy-MM-dd")
        'If FUERATURNO = 1 Then
        '    cmbTurnos.Enabled = True
        '    dtpFECHA.Enabled = True
        '    dtpFECHASAP.Enabled = True
        '    chkSAP.Enabled = True
        'Else
        '    cmbTurnos.Enabled = False
        '    dtpFECHA.Enabled = False
        '    dtpFECHASAP.Enabled = False
        '    chkSAP.Enabled = False
        'End If
        '' ---------------------------------------------------------------------------------
        'LimpiaObjetos()
        'TClaveOperador.Focus()
    End Sub
    Private Sub Titulos_ppal()
        elDato = Ini.LeeIni(GIDIOMA, "TMenuPET").Trim
        Me.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblSalir").Trim
        lblSalir.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblEspera").Trim
        lblEspera.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblSAP").Trim
        lblSAP.Text = Mid(elDato, 1, Len(elDato) - 1)
        ' ---------------------------------------------------------------------------------
        elDato = Ini.LeeIni(GIDIOMA, "lblCentro").Trim
        lblCentro.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblClave").Trim
        lblClave.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblOrden").Trim
        lblOrden.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblRack").Trim
        lblRack.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblPtoTrabajo").Trim
        lblPtoTrabajo.Text = Mid(elDato, 1, Len(elDato) - 1)
        ' ---------------------------------------------------------------------------------
        elDato = Ini.LeeIni(GIDIOMA, "lblTurno").Trim
        lblTurno.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblMaterial").Trim
        lblMaterial.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblArea").Trim
        lblArea.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblTeorico").Trim
        lblTeorico.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblCausa").Trim
        lblCausa.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "LPesoCaptura").Trim
        LPesoCaptura.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblGrupo").Trim
        lblGrupo.Text = Mid(elDato, 1, Len(elDato) - 1)
        ' ---------------------------------------------------------------------------------
        elDato = Ini.LeeIni(GIDIOMA, "lblScrapSi").Trim
        lblScrapSi.Text = "     " & Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblPurgaSi").Trim
        lblPurgaSi.Text = "     " & Mid(elDato, 1, Len(elDato) - 1)
        ' ---------------------------------------------------------------------------------
        elDato = Ini.LeeIni(GIDIOMA, "lblPesobruto").Trim
        lblPesobruto.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblPesotara").Trim
        lblPesotara.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblPesoneto").Trim
        lblPesoneto.Text = Mid(elDato, 1, Len(elDato) - 1)
        ' ---------------------------------------------------------------------------------
        elDato = Ini.LeeIni(GIDIOMA, "lblGraba").Trim
        lblGraba.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblImprime").Trim
        lblImprime.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblLimpia").Trim
        lblLimpia.Text = Mid(elDato, 1, Len(elDato) - 1)
        ' ---------------------------------------------------------------------------------
        elDato = Ini.LeeIni(GIDIOMA, "lblFolio").Trim
        lblFolio.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblNoti").Trim
        lblNoti.Text = Mid(elDato, 1, Len(elDato) - 1)
        elDato = Ini.LeeIni(GIDIOMA, "lblCons").Trim
        lblCons.Text = Mid(elDato, 1, Len(elDato) - 1)
    End Sub
    Private Sub TOrden_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TOrden.KeyPress
        e.Handled = txtNumerico(TOrden, e.KeyChar, False)
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
        If LecturaBD_AMD.Read() Then
            Turno = LecturaBD_AMD(0)
            dateRegistro = DateAdd(DateInterval.Day, -Val(LecturaBD_AMD(4)), dateRegistro)
        End If
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
        If FUERATURNO = 0 Then
            dateRegistro = Today()
            dtpFECHA.Value = Date.Today.ToString("yyyy-MM-dd")
            dtpFECHASAP.Value = Date.Today.ToString("yyyy-MM-dd")
            QRY_AMD = ""
            QRY_AMD = " Select TT.Turno, TT.Descripcion, Convert(char(8),TT.Hora_Inicio,108) as Hora_Inicio, "
            QRY_AMD = QRY_AMD & " Convert(char(8),TT.Hora_Terminacion,108) as Hora_Terminacion, TT.registro "
            QRY_AMD = QRY_AMD & " FROM ADM_Turno TT INNER JOIN ADM_CambioHora CH ON TT.Planta=CH.Planta "
            QRY_AMD = QRY_AMD & " AND Convert(char(10), getdate(),102)between Convert(char(10), CH.Fecha_Inicio,102) AND Convert(char(10),CH.fecha_Terminacion,102) "
            QRY_AMD = QRY_AMD & " WHERE Convert(char(8), getdate()+(CH.CHora/24),108) between Convert(char(8), Hora_Inicio,108) "
            QRY_AMD = QRY_AMD & " AND Convert(char(8),Hora_Terminacion,108) and TT.Planta='" & SessionUser._sCentro.Trim & "' "
            LecturaQry_AMD(QRY_AMD)
            Turno = "1"
            If LecturaBD_AMD.Read Then
                Turno = LecturaBD_AMD(0)
                dateRegistro = DateAdd(DateInterval.Day, -Val(LecturaBD_AMD(4)), dateRegistro)
            End If
            LecturaBD_AMD.Close()
            ' ---------------------------------------------------------------------------------
        End If
        ' ---------------------------------------------------------------------------------
        BPesar.Enabled = False
        BImprimir.Enabled = False
        rbtScrapSi.Checked = False
        rbtPurgaSi.Checked = False
        lblScrapSi.BackColor = Me.BackColor
        lblScrapSi.ForeColor = Color.DarkBlue
        lblPurgaSi.BackColor = Me.BackColor
        lblPurgaSi.ForeColor = Color.DarkBlue
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
        CountValOP = 0
        ' ---------------------------------------------------------------------------------
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
                Message = " Orden de Producción no Existe en (- ATLAS -), Desea dar de Alta? "
                Caption = "Orden de Producción Inexistente"
                Result = MessageBox.Show(Message, Caption, Buttons, MessageBoxIcon.Exclamation)
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
                    Case Is <> "ATLAS"
                        'Dim lo_wsamancomx As New Lee_OF.ZPP001_91Service
                        'Dim ls_return As New Lee_OF.ZBAPIRET2
                        'Dim ls_values As New Lee_OF.ZEPP001

                        'lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                        'ls_values = lo_wsamancomx.Z_PP001(Me.TOrden.Text, ls_return)
                        'OrdenProd = ls_values.ZORDER_NUMBER
                        'NumeroPlanta = ls_values.ZPRODUCTION_PLANT
                        'Equipo = ls_values.ZWORK_CENTER
                        'Producto = ls_values.ZMATERIAL
                        'CantProgPzs = ls_values.ZTARGET_QUANTITY
                        'Unidad = ls_values.ZUNIT
                        'Inicio = ls_values.ZSTART_DATE
                        'Fin = ls_values.ZFINISH_DATE
                        'Origen = ls_values.ZORIGIN
                        'Status1 = ls_values.ZSTATUS
                        'fecini = ls_values.ZACTUAL_START_DATE
                        'HrReal = ls_values.ZACTUAL_START_TIME
                        'fecterm = ls_values.ZACTUAL_FINISH_DATE
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
                    Me.TOrden.Text = ""
                    Me.TOrden.Focus()
                    Return
                End If
                ' ---------------------------------------------------------------------------------
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
                                xUSUARIOREG = SessionUser._sAlias.Trim
                            End If
                            xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
                            xHORAREG = Date.Now.TimeOfDay.ToString
                            ' ---------------------------------------------------------------------------------
                            xTGRUPO = ""
                            QRY = ""
                            QRY = "SELECT GrupMaterial FROM " & tablaEXTINY & " WHERE Centro = " & "'" & NumeroPlanta & "' "
                            QRY = QRY & " AND Codigo = '" & Producto.Trim & "'"
                            LecturaQry(QRY)

                            If LecturaBD.Read() Then
                                xTGRUPO = LecturaBD(0)
                                TGrupo.Text = xTGRUPO
                                xCantProgPzs = Replace(CantProgPzs, GDECIMAL, ".")
                                xCantProgkg = Replace(CantProgkg, GDECIMAL, ".")
                            Else
                                CantProgPzs = 0
                                CantProgkg = 0
                                TGrupo.Text = ""
                                xCantProgPzs = Replace(CantProgPzs, GDECIMAL, ".")
                                xCantProgkg = Replace(CantProgkg, GDECIMAL, ".")
                            End If
                            xUSUARIOREG = SessionUser._sAlias
                            xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
                            xHORAREG = Date.Now.TimeOfDay.ToString
                            ' ---------------------------------------------------------------------------------
                            InQry = ""
                            InQry = "INSERT INTO [" & SessionUser._sCentro.Trim & "_OrdenProduccion] (Orden_Produccion, Planta, Equipo_Basico, Producto, Cantidad_Programada_Tramos, Cantidad_Programada_Kilos, Fecha_Inicio, Fecha_Termino, Origen_Informacion, Estatus_Activa, Usuario_Actualiza, Fecha_Actualizacion, Observaciones, usuarioreg, fechareg, horareg,grupmaterial ) "
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
            Case Is > 0
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
                Else
                    If StatusOP = "9" Then
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
                        'Dim lo_wsamancomx As New Lee_OF.ZPP001_91Service
                        'Dim ls_return As New Lee_OF.ZBAPIRET2
                        'Dim ls_values As New Lee_OF.ZEPP001

                        'lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                        'ls_values = lo_wsamancomx.Z_PP001(Me.TOrden.Text, ls_return)
                        'OrdenProd = ls_values.ZORDER_NUMBER
                        'NumeroPlanta = ls_values.ZPRODUCTION_PLANT
                        'Equipo = ls_values.ZWORK_CENTER
                        'Producto = ls_values.ZMATERIAL
                        'CantProgPzs = ls_values.ZTARGET_QUANTITY
                        'Unidad = ls_values.ZUNIT
                        'Inicio = ls_values.ZSTART_DATE
                        'Fin = ls_values.ZFINISH_DATE
                        'Origen = ls_values.ZORIGIN
                        'Status1 = ls_values.ZSTATUS
                        'fecini = ls_values.ZACTUAL_START_DATE
                        'HrReal = ls_values.ZACTUAL_START_TIME
                        'fecterm = ls_values.ZACTUAL_FINISH_DATE
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
                    Me.TOrden.Text = ""
                    Me.TOrden.Focus()
                    Return
                End If
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
                        CerosIzquierda(OrdenProd)
                        OrdenProd = RegresaCeroIzq
                        Producto = CerosIzquierda(Producto)
                        Producto = RegresaCeroIzq
                End Select
                ' ---------------------------------------------------------------------------------
                'QRY = ""
                'QRY = "SELECT PTE.Grpprod, PTE.Descr, PTE.Empaque, PTE.PesoTeorico, OP.Estatus_Activa, PTE.Codigo, "
                'QRY = QRY & " OP.cantidad_programada_tramos, OP.Equipo_Basico, OP.GrupMaterial "
                'QRY = QRY & " FROM [" & strPlanta.Trim & "_OrdenProduccion] OP, " & tablaEXTINY & " PTE "
                'QRY = QRY & " WHERE PTE.Codigo = OP.Producto "
                'QRY = QRY & " AND PTE.Centro = OP.Planta "
                'QRY = QRY & " AND OP.Orden_Produccion = '" & Me.TOrden.Text.Trim & "' "
                'QRY = QRY & " AND OP.Planta = '" & strPlanta.Trim & "' And OP.Estatus_Activa = 1"
                LecturaQry(QRY)
                If LecturaBD.Read() Then
                    xAREA = LecturaBD(0)
                    descripcion = LecturaBD(1)
                    CodigoEmpaque = LecturaBD(2)
                    PesoTeorico = LecturaBD(3)
                    EstatusActiva = LecturaBD(4)
                    StrProducto = LecturaBD(5)
                    StrTramos = LecturaBD(6)
                    EqpBasico = LecturaBD(7)
                    grpMaterial = LecturaBD(8)
                    WorkCenter = UCase(EqpBasico)
                End If
                LecturaBD.Close()
                ' ---------------------------------------------------------------------------------

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
                '' ----------------------------------------- Datos del grupo de produccion
                'TGrpprod.Text = xAREA.Trim
                'Q = "SELECT desgrupo FROM catgrupos  "
                'Q = Q & "WHERE centro = '" & strPlanta.Trim & "' "
                'Q = Q & "AND grpprod = '" & TGrpprod.Text.Trim & "' "
                'Q = Q & "AND status = 'A'"
                'TGrpproddesc.Text = TraeDescripcion(Q)
                '' ----------------------------------------- Datos del Puesto de Trabajo
                'TPtoTrabajo.Text = EqpBasico.Trim
                'WorkCenter = TPtoTrabajo.Text
                'Q = " SELECT Descripcion FROM MCPC_EquipoBasico"
                'Q = Q & " WHERE planta = '" & strPlanta.Trim & "' "
                'Q = Q & " AND rtrim(Equipo_basico) = '" & TPtoTrabajo.Text.Trim & "'"
                'TNomPtoTrabajo.Text = TraeDescripcion(Q)
        End Select
        '' ----------------------------------------- Valor control de compuestos
        'TGrupo.Text = grpMaterial.Trim

        'ValControlCompuesto = ""
        'QRY = ""
        'QRY = " Select ValCompuesto  From  " & tablaEXTINY & "  Where Centro = '" & strPlanta.Trim & "' And Codigo = '" & StrProducto.Trim & "'"
        'LecturaQry(QRY)
        'If LecturaBD.Read() Then
        '    ValControlCompuesto = LecturaBD(0)    'Peso Unitario del Empaque
        'End If
        'LecturaBD.Close()
        ' ----------------------------------------- Activación BOTON para Compuestos
        TCodPT.Text = StrProducto.Trim   'Código PT
        TCodPtDesc.Text = descripcion.Trim   'Descripción del PT
        TPtoTrabajo.Text = EqpBasico.Trim  'Puesto de Trabajo
        TPesoTeorico.Text = PesoTeorico.ToString.Trim  'Peso Teorico
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

    Private Sub BTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTerminar.Click
        LimpiaObjetos()
        Close()
    End Sub

    Private Sub TPesoBruto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoBruto.TextChanged
        Dim xTPesoBruto As Double
        Dim xTPesoTara As Double
        Dim xTPesoNeto As Double
        xTPesoBruto = "0" & TPesoBruto.Text.Trim
        xTPesoTara = "0" & TPesoTara.Text.Trim
        xTPesoNeto = xTPesoBruto - xTPesoTara
        TPesoNeto.Text = Format(xTPesoNeto, xFormato)
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
        Dim TipoNotificacion As Char = "0"
        Dim xTIPOSCRAP As Char = ""
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

        ' ---------------------------------------------------------------------------------
        nvoPeso_Bruto = "0" & TPesoBruto.Text.Trim
        nvoTara = "0" & TPesoTara.Text.Trim
        nvoPeso_Neto = "" & TPesoNeto.Text.Trim
        nvoPesoTeorico = "0" & TPesoTeorico.Text.Trim
        nvoUsuario = TCodOperador.Text.Trim

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

        If rbtScrapSi.Checked = False And rbtPurgaSi.Checked = False Then
            Mensajes("***  Selecciona si es SCRAP ó PURGA   *** ", 1)
            Exit Sub
        End If
        ' ---------------------------------------------------------------------------------
        nvoFecha_Pesaje = Date.Today.ToString("yyyy-MM-dd")
        nvoHora_Pesaje = Date.Now.TimeOfDay.ToString()
        nvoOrden_Produccion = TOrden.Text.Trim

        nvoTipo_SCausa = TCausas.Text.Trim
        nvoTipo_SDefecto = TDefectos.Text.Trim

        Dim StrStatus As Boolean
        '' ---------------------------------------------------------------------------------
        'QRY_AMD = ""
        'QRY_AMD = "Select Status FROM ADM_StatusSAP WHERE Planta='" & strPlanta.Trim & "'"
        'LecturaQry_AMD(QRY_AMD)
        'If (LecturaBD_AMD.Read) Then
        '    StrStatus = LecturaBD_AMD(0)
        'End If
        'LecturaBD_AMD.Close()
        ' ---------------------------------------------------------------------------------
        If FUERATURNO = 0 Then
            dateRegistro = Today()
            FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
            HoraPesaje = Date.Now.TimeOfDay.ToString
            FechaTurno = FechaPesaje
            '' ---------------------------------------------------------------------------------
            'QRY_AMD = ""
            'QRY_AMD = " Select TT.Turno, TT.Descripcion, Convert(char(8),TT.Hora_Inicio,108) as Hora_Inicio, "
            'QRY_AMD = QRY_AMD & " Convert(char(8),TT.Hora_Terminacion,108) as Hora_Terminacion, TT.registro "
            'QRY_AMD = QRY_AMD & " FROM ADM_Turno TT INNER JOIN ADM_CambioHora CH ON TT.Planta=CH.Planta "
            'QRY_AMD = QRY_AMD & " AND Convert(char(10), getdate(),102)between Convert(char(10), CH.Fecha_Inicio,102) AND Convert(char(10),CH.fecha_Terminacion,102) "
            'QRY_AMD = QRY_AMD & " WHERE Convert(char(8), getdate()+(CH.CHora/24),108) between Convert(char(8), Hora_Inicio,108) "
            'QRY_AMD = QRY_AMD & " AND Convert(char(8),Hora_Terminacion,108) and TT.Planta='" & strPlanta.Trim & "' "
            'LecturaQry_AMD(QRY_AMD)
            'Turno = "1"
            'If LecturaBD_AMD.Read() Then
            '    Turno = LecturaBD_AMD(0)
            '    dateRegistro = DateAdd(DateInterval.Day, -Val(LecturaBD_AMD(4)), dateRegistro)
            'End If
            'FechaTurno = dateRegistro.ToString("yyyy-MM-dd")
            'LecturaBD_AMD.Close()
            ' ---------------------------------------------------------------------------------
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
        'ExecuteWebCam(1)
        ' ---------------------------------------------------------------------------------
        Dim FolioSiguiente As String

        'QRY = ""
        'QRY = "Select Max(Scrap)+1 as folioSiguiente from MCPC_Foliador where  "
        'QRY = QRY & " Planta='" & strPlanta.Trim & "'"
        'LecturaQry(QRY)
        'FolioSiguiente = "1"
        'If (LecturaBD.Read) Then
        '    FolioSiguiente = LecturaBD(0)
        'End If
        'LecturaBD.Close()
        ' ---------------------------------------------------------------------------------
        'InQry = "Update MCPC_Foliador set Scrap = '" & FolioSiguiente.Trim & "'"
        'InQry = InQry & " where "
        'InQry = InQry & " Planta='" & strPlanta & "'"
        'InsertQry(InQry)

        'FolioSiguiente = FolioSiguiente.Trim
        'FolioSiguiente = Mid("00000000", 1, 8 - Len(FolioSiguiente)) & FolioSiguiente.Trim
        'TFolioAtlas.Text = FolioSiguiente
        ' ---------------------------------------------------------------------------------
        'CadenaTexto = TCodOperador.Text.Trim & "|" & FolioSiguiente.Trim
        '' ---------------------------------------------------------------------------------
        'If Val(ValControlCompuesto.Trim) = 0 Or CheckBox1.Checked = False Then
        '    Lt_Compuestos = ""
        'Else
        '    ' ---------------------------------------------------------------------------------
        '    Dim Count As Integer = 0
        '    QRY = ""
        '    QRY = "select b.ComExt_ComCodigo from " & tablaEXTINY & " a, CompuestoExtrusion b "
        '    QRY = QRY & "where a.centro = b.ComExt_PT_Centro "
        '    QRY = QRY & "and a.codigo = b.ComExt_PT_Codigo "
        '    QRY = QRY & "and a.centro = '" & strPlanta.Trim & "' "
        '    QRY = QRY & "and a.codigo = '" & TCodPT.Text.Trim & "' "
        '    QRY = QRY & "and b.bom = '1' "
        '    LecturaQry(QRY)
        '    Do While (LecturaBD.Read())
        '        Count = Count + 1
        '        CompOriginal = LecturaBD(0)
        '    Loop
        '    LecturaBD.Close()
        'If Count = 0 Then
        '    MessageBox.Show(" No Existe compuesto definido como parte de la Bom para este Producto no se puede notificar esta orden ", " VENTANA DE ERROR * * * ")
        '    Return
        'End If
        If ValPublic_ReproConsumo.Trim.Length > 0 Then
            Compuesto_1 = ValPublic_ReproConsumo.Trim
            CompuestoPorcent_1 = 100
            Compuesto_2 = "0"
            CompuestoPorcent_2 = 0
            Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1
        End If
        'End If
        ' ---------------------------------------------------------------------------------
        If rbtScrapSi.Checked Then
            xTIPOSCRAP = "T"
            nvoPiezas_Scrap = nvoPeso_Neto / nvoPesoTeorico
            nvoPiezas_Scrap = Int(nvoPiezas_Scrap)
        Else
            xTIPOSCRAP = "G"
            nvoPiezas_Scrap = 0
        End If
        ' ---------------------------------------------------------------------------------
        If rbtScrapSi.Checked = True Then
            ' ---------------------------------------------------------------------------------
            If chkSAP.Checked = True Then
                FechaPesajeSAP = dtpFECHASAP.Value.ToString("yyyy-MM-dd")
                TNumNoti.Text = "0000000000"
                TConsNoti.Text = "00000000"

                If StrStatus = True Then
                    ' ---------------------------------------------------------------------------------
                    'If MenuPrin.TxtUsuario.Text.Trim <> "ATLAS" Then
                    '    Dim lo_wsamancomxp As New PTConProd.ZPPMXF001Service
                    '    Dim ls_returnp As New PTConProd.ZBAPIRET2
                    '    Dim ls_Notificap As New PTConProd.ZEPP002
                    '    Dim ls_resultp As New PTConProd._ISDFPS_TCUPS_KEY

                    '    ls_Notificap.ZBUDAT = FechaPesajeSAP.Trim
                    '    ls_Notificap.ZCONSUME_REC = 0
                    '    ls_Notificap.ZENTRY_QNT = nvoPiezas_Scrap
                    '    ls_Notificap.ZISM01 = 0
                    '    ls_Notificap.ZISM02 = 0
                    '    ls_Notificap.ZISM03 = 0
                    '    ls_Notificap.ZISMNGEH1 = ""
                    '    ls_Notificap.ZISMNGEH2 = ""
                    '    ls_Notificap.ZISMNGEH3 = ""
                    '    ls_Notificap.ZMATNR_REC = ""
                    '    ls_Notificap.ZORDERID = nvoOrden_Produccion
                    '    ls_Notificap.ZRECOVERED = nvoPeso_Neto
                    '    ls_Notificap.ZVIRGIN = 0
                    '    lo_wsamancomxp.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                    '    ls_resultp = lo_wsamancomxp.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notificap, ls_returnp)
                    '    TNumNoti.Text = ls_resultp.RUECK
                    '    TConsNoti.Text = ls_resultp.RMZHL
                    '    Err = ls_returnp.ZTYPE
                    '    Mns = ls_returnp.ZMESSAGE
                    '    ' ---------------------------------------------------------------------------------
                    'ElseIf MenuPrin.TxtUsuario.Text.Trim = "ATLAS" Then
                    '    Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
                    '    Dim ls_returnr As New PTConsumos.ZBAPIRET2
                    '    Dim ls_Notifica As New PTConsumos.ZEPP002
                    '    Dim ls_result As New PTConsumos._ISDFPS_TCUPS_KEY

                    '    ls_Notifica.ZBUDAT = FechaPesajeSAP.Trim
                    '    ls_Notifica.ZCONSUME_REC = 0
                    '    ls_Notifica.ZENTRY_QNT = nvoPiezas_Scrap
                    '    ls_Notifica.ZISM01 = 0
                    '    ls_Notifica.ZISM02 = 0
                    '    ls_Notifica.ZISM03 = 0
                    '    ls_Notifica.ZISMNGEH1 = ""
                    '    ls_Notifica.ZISMNGEH2 = ""
                    '    ls_Notifica.ZISMNGEH3 = ""
                    '    ls_Notifica.ZMATNR_REC = ""
                    '    ls_Notifica.ZMATNR_REC = ""
                    '    ls_Notifica.ZORDERID = nvoOrden_Produccion
                    '    ls_Notifica.ZRECOVERED = nvoPeso_Neto
                    '    ls_Notifica.ZVIRGIN = 0
                    '    lo_wsamancomxr.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                    '    ls_result = lo_wsamancomxr.ZPPMXF001(CadenaTexto, Lt_Compuestos, ls_Notifica, ls_returnr)
                    '    TNumNoti.Text = ls_result.RUECK
                    '    TConsNoti.Text = ls_result.RMZHL
                    '    Err = ls_returnr.ZTYPE
                    '    Mns = ls_returnr.ZMESSAGE
                    'End If
                Else
                    MessageBox.Show(" No se realizara notificación a SAP ")
                End If
                If Err = "E" Then
                    MessageBox.Show(Mns, "Error en SAP Notifique al Supervisor")
                    Exit Sub
                End If
                ' ---------------------------------------------------------------------------------
                Dim reg As String
                If (Me.TNumNoti.Text.Trim = "" Or Me.TNumNoti.Text.Trim = "NULL" Or Me.TNumNoti.Text.Trim = "0000000000") And (Me.TConsNoti.Text.Trim = "" Or Me.TConsNoti.Text.Trim = "NULL" Or Me.TConsNoti.Text.Trim = "00000000") Then
                    reg = "0"
                Else
                    reg = "1"
                End If
                ' ---------------------------------------------------------------------------------
                'InQry = ""
                'InQry = "INSERT INTO [" & strPlanta.Trim & "_PesoScrap] (Orden_Produccion, Fecha_Pesaje, Hora_Pesaje, Bascula, Tipo_Scrap, Peso_Bruto, Tara, Peso_Neto, Tramos, Usuario,Turno,Planta,Folio, Documento_SAP, Consecutivo_SAP, Notifica, "
                'InQry = InQry & " Causa, Efecto, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos, Fecha_Turno, notificacionmasiva, PuestoTrabajo, FolioR) VALUES ('" & nvoOrden_Produccion & "','" & nvoFecha_Pesaje & "',"
                'InQry = InQry & "'" & nvoHora_Pesaje & "','" & strNumeroBascula.Trim & "','" & xTIPOSCRAP & "'," & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & ","
                'InQry = InQry & Replace(nvoPiezas_Scrap, GDECIMAL, ".") & ",'" & TCodOperador.Text.Trim & "'," & Turno.Trim & ",'" & strPlanta.Trim & "','" & FolioSiguiente.Trim & "', '" & TNumNoti.Text.Trim & "', '" & TConsNoti.Text.Trim & "','"
                'InQry = InQry & reg & "','" & nvoTipo_SCausa & "','" & nvoTipo_SDefecto & "','" & Compuesto_1.Trim & "'," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2 & ",'" & Lt_Compuestos.Trim & "','" & FechaTurno.Trim & "', 0,'" & UCase(TPtoTrabajo.Text.Trim) & "','')"
                'InsertQry(InQry)
                ' ---------------------------------------------------------------------------------
                Mensajes("Registros Actualizados : " & InsertBD, 0)
                ' ---------------------------------------------------------------------------------
                xORIGINAL = ""
                imprimir_SC()
                ' ---------------------------------------------------------------------------------
                BPesar.Enabled = False
                BImprimir.Enabled = True
                TOrden.Enabled = False
            Else
                TipoNotificacion = "4"
                nvoDocumento_SAP = ""
                nvoConsecutivo_SAP = ""
                ' ---------------------------------------------------------------------------------
                'InQry = ""
                'InQry = "INSERT INTO [" & strPlanta.Trim & "_PesoScrap] (Orden_Produccion, Fecha_Pesaje, Hora_Pesaje, Bascula, Tipo_Scrap, Peso_Bruto, Tara, Peso_Neto, Tramos, Usuario,Turno,Planta,Folio, Documento_SAP, Consecutivo_SAP, Notifica, "
                'InQry = InQry & " Causa, Efecto, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos, Fecha_Turno, notificacionmasiva, PuestoTrabajo, FolioR) VALUES ('" & nvoOrden_Produccion & "','" & nvoFecha_Pesaje & "',"
                'InQry = InQry & "'" & nvoHora_Pesaje & "','" & strNumeroBascula.Trim & "','" & xTIPOSCRAP & "'," & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & ","
                'InQry = InQry & Replace(nvoPiezas_Scrap, GDECIMAL, ".") & ",'" & TCodOperador.Text.Trim & "'," & Turno.Trim & ",'" & strPlanta.Trim & "','" & FolioSiguiente.Trim & "', '" & TNumNoti.Text.Trim & "', '" & TConsNoti.Text.Trim & "','"
                'InQry = InQry & TipoNotificacion & "','" & nvoTipo_SCausa & "','" & nvoTipo_SDefecto & "','" & Compuesto_1.Trim & "'," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2 & ",'" & Lt_Compuestos.Trim & "','" & FechaTurno.Trim & "', 0,'" & UCase(TPtoTrabajo.Text.Trim) & "','')"
                'InsertQry(InQry)
                ' ---------------------------------------------------------------------------------
                Mensajes("Registros Actualizados : " & InsertBD, 0)
                ' ---------------------------------------------------------------------------------
                xORIGINAL = ""
                imprimir_SC()
                ' ---------------------------------------------------------------------------------
                BPesar.Enabled = False
                BImprimir.Enabled = True
                TOrden.Enabled = False
            End If
        Else
            TipoNotificacion = "5"
            nvoDocumento_SAP = ""
            nvoConsecutivo_SAP = ""
            ' ---------------------------------------------------------------------------------
            'InQry = ""
            'InQry = "INSERT INTO [" & strPlanta.Trim & "_PesoScrap] (Orden_Produccion, Fecha_Pesaje, Hora_Pesaje, Bascula, Tipo_Scrap, Peso_Bruto, Tara, Peso_Neto, Tramos, Usuario,Turno,Planta,Folio, Documento_SAP, Consecutivo_SAP, Notifica, "
            'InQry = InQry & " Causa, Efecto, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos, Fecha_Turno, notificacionmasiva, PuestoTrabajo, FolioR) VALUES ('" & nvoOrden_Produccion & "','" & nvoFecha_Pesaje & "',"
            'InQry = InQry & "'" & nvoHora_Pesaje & "','" & strNumeroBascula.Trim & "','" & xTIPOSCRAP & "'," & Replace(nvoPeso_Bruto, GDECIMAL, ".") & "," & Replace(nvoTara, GDECIMAL, ".") & "," & Replace(nvoPeso_Neto, GDECIMAL, ".") & ","
            'InQry = InQry & Replace(nvoPiezas_Scrap, GDECIMAL, ".") & ",'" & TCodOperador.Text.Trim & "'," & Turno.Trim & ",'" & strPlanta.Trim & "','" & FolioSiguiente.Trim & "', '" & TNumNoti.Text.Trim & "', '" & TConsNoti.Text.Trim & "','"
            'InQry = InQry & TipoNotificacion & "','" & nvoTipo_SCausa & "','" & nvoTipo_SDefecto & "','" & Compuesto_1.Trim & "'," & CompuestoPorcent_1 & ",'" & Compuesto_2.Trim & "'," & CompuestoPorcent_2 & ",'" & Lt_Compuestos.Trim & "','" & FechaTurno.Trim & "', 0,'" & UCase(TPtoTrabajo.Text.Trim) & "','')"
            'InsertQry(InQry)
            ' ---------------------------------------------------------------------------------
            Mensajes("Registros Actualizados : " & InsertBD, 0)
            ' ---------------------------------------------------------------------------------
            xORIGINAL = ""
            imprimir_SC()
            ' ---------------------------------------------------------------------------------
            BPesar.Enabled = False
            BImprimir.Enabled = True
            TOrden.Enabled = False
        End If
    End Sub

    Private Sub BImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImprimir.Click
        xORIGINAL = "  ============ COPIA   "
        imprimir_SC()
    End Sub
    Sub imprimir_SC()
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
        Dim PCausa As String = ""
        Dim PDesccausa As String = ""
        Dim PPtoTrabajo As String = ""
        Dim PCodOperador As String = ""
        Dim PNomOperador As String = ""
        Dim PTipoSC As String = ""
        Dim PFolioR As String = ""

        PFolioAtlas = TFolioAtlas.Text.Trim
        POrden = TOrden.Text.Trim
        ' ---------------------------------------------------------------------------------
        'QRY = ""
        'QRY = QRY & " Select PSC.Folio, PSC.Fecha_Pesaje, PSC.Hora_Pesaje, PSC.Turno, PSC.Fecha_Turno, PSC.Notifica,  "
        'QRY = QRY & " PTE.Grpprod, CGR.desgrupo, PSC.Orden_Produccion, PTE.Codigo, PTE.Descr , PSC.Tramos, PSC.Peso_Bruto,  "
        'QRY = QRY & " PSC.Tara, PSC.Peso_Neto, PSC.causa, CA.descausagrupa, PSC.PuestoTrabajo, PSC.Usuario, PSC.Tipo_scrap, PSC.FolioR "
        'QRY = QRY & " FROM  ([" & strPlanta.Trim & "_PesoScrap] PSC "
        'QRY = QRY & " INNER JOIN [" & strPlanta.Trim & "_OrdenProduccion] OP ON OP.Planta= PSC.PLANTA and  PSC.Orden_Produccion = OP.Orden_Produccion) "
        'QRY = QRY & " INNER JOIN MCPC_EquipoBasico EB      ON PSC.planta = EB.Planta AND PSC.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico= '" & EXTINY & "' "
        'QRY = QRY & " INNER JOIN " & tablaEXTINY & " PTE   ON PTE.CENTRO= OP.PLANTA and  PTE.Codigo = OP.Producto "
        'QRY = QRY & " INNER JOIN catgrupos CGR             ON PTE.Centro = CGR.CENTRO and  PTE.Grpprod = CGR.Grpprod "
        'QRY = QRY & " INNER JOIN CatCausas CC              ON CC.Centro=PTE.Centro   AND CC.grpprod=PTE.grpprod             AND CC.codcausagrupa=PSC.Causa  AND CC.codCausgeneral=PSC.efecto  AND CC.Tipocausa='SC' "
        'QRY = QRY & " INNER JOIN CatAgrupaciones CA        ON CA.centro= PTE.centro  AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A'                AND NOT CA.codgrpgeneral= '0' "
        'QRY = QRY & " INNER JOIN Catgrpgeneral   CGG       ON CGG.centro= CA.centro    AND CA.codgrpgeneral = CGG.codgrpgeneral  AND CGG.status = 'A' "
        'QRY = QRY & " WHERE  PSC.Planta = '" & strPlanta.Trim & "' AND PSC.Orden_Produccion = '" & POrden.Trim & "' AND PSC.folio='" & PFolioAtlas.Trim & "'"
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
            PCausa = LecturaBD(15)
            PDesccausa = LecturaBD(16)
            PPtoTrabajo = LecturaBD(17)
            PCodOperador = LecturaBD(18)
            PTipoSC = LecturaBD(19)
            PFolioR = LecturaBD(20)
        End If
        LecturaBD.Close()
        ' ---------------------------------------------------------------------------------
        QRY_AMD = ""
        QRY_AMD = "Select Usuario, Nombre From  ADM_Usuario "
        'QRY_AMD = QRY_AMD & " WHERE  Usuario = '" & PCodOperador.Trim & "' And Planta = '" & strPlanta.Trim & "'"
        LecturaQry_AMD(QRY_AMD)
        PNomOperador = ""
        If LecturaBD_AMD.Read() Then
            PNomOperador = LecturaBD_AMD(1)
        End If
        LecturaBD_AMD.Close()
        ' ---------------------------------------------------------------------------------
        'FileOpen(1, GETIQUETAS.Trim & "\barcode.TXT", OpenMode.Output)
        PrintLine(1)
        PrintLine(1, GEMPRESA.Trim)
        PrintLine(1, "PRODUCCION CONTROL DE PESAJE")
        PrintLine(1)
        PrintLine(1, "   FOLIO: " & PFolioAtlas.Trim)
        PrintLine(1, "F.PESAJE: " & PFechaPesaje.Trim)
        PrintLine(1, "H.PESAJE: " & Mid(PHoraPesaje.Trim, 1, 8))
        PrintLine(1)
        PrintLine(1, "TURNO: " & PTurno.Trim & "   F.TURNO: " & PFechaTurno.Trim)
        PrintLine(1)

        If PTipoSC.Trim = "T" Then
            PrintLine(1, "  * * * (" & PTipoSC.Trim & ") SCRAP  ")
        End If

        If PTipoSC.Trim = "G" Then
            PrintLine(1, "  * * *  (" & PTipoSC.Trim & ") PURGA ")
        End If

        PrintLine(1)
        PrintLine(1, " TIPO PROD.: " & PGrpprod.Trim & "    " & PGrpproddesc.Trim)
        PrintLine(1)
        PrintLine(1, "   O.D.F.: " & POrden.Trim)
        PrintLine(1, " MATERIAL: " & PCodPT.Trim)
        PrintLine(1, " " & Mid(PCodPtDecr.Trim, 1, 30))
        PrintLine(1)
        PrintLine(1, "U.RECHAZO: " & PtramosNoti.Trim)
        PrintLine(1, " P. BRUTO: " & PPesoBruto.Trim)
        PrintLine(1, "     TARA: " & PPesoTara.Trim)
        PrintLine(1, "  P. NETO: " & PPesoNeto.Trim)
        PrintLine(1)
        PrintLine(1, "CAUSA SCRAP: " & PCausa.Trim)
        PrintLine(1, "             " & PDesccausa.Trim)
        PrintLine(1)
        PrintLine(1, xORIGINAL)
        PrintLine(1)
        PrintLine(1, "P.TRABAJO: " & PPtoTrabajo.Trim)
        PrintLine(1, " OPERADOR: " & PCodOperador.Trim & "    " & PNomOperador.Trim)
        FileClose(1)
        'Shell(GETIQUETAS.Trim & "\printcode.bat", AppWinStyle.Hide, True)
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
    Private Sub TCausas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCausas.TextChanged
        Dim i As Integer
        Dim c As Char
        Dim invalido As Boolean
        invalido = False
        For i = 0 To TCausas.Text.Length - 1
            c = TCausas.Text.Substring(i, 1)
            If (Char.IsNumber(c) = False) Then
                MessageBox.Show("***  Caracteres Inválidos  *** ")
                TCausas.Text = ""
                invalido = True
                Exit For
            End If
        Next
    End Sub
    Private Sub TCausas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TCausas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub TCausas_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCausas.Leave
        'Q = ""
        'Q = " SELECT Descausagrupa FROM CatAgrupaciones "
        'Q = Q & " WHERE Centro = '" & strPlanta.Trim & "' "
        'Q = Q & " AND codcausagrupa = '" & TCausas.Text & "' AND status='A'"
        'Desccausa.Text = TraeDescripcion(Q)
        'If TGrpprod.Text.Trim = "" Or Desccausa.Text.Trim = "" Then
        '    TCausas.Text = ""
        '    Desccausa.Text = ""
        'End If
        'Desdefecto.Text = ""
        'TDefectos.Text = ""
        'TCausas.BackColor = Color.White
    End Sub
    Private Sub btnLookcausas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookcausas.Click
        'Q = ""
        'Q = "SELECT CC.codcausagrupa, CAG.Descausagrupa FROM CatCausas CC "
        'Q = Q & " INNER JOIN CatAgrupaciones CAG ON  CC.centro = CAG.centro AND CC.codcausagrupa=CAG.codcausagrupa AND CAG.status='A'"
        'Q = Q & " WHERE CC.centro = '" & strPlanta.Trim & "' "
        'Q = Q & " AND CC.Grpprod = '" & TGrpprod.Text.Trim & "' "
        'Q = Q & " AND CC.TipoCausa = 'SC' "
        'Q = Q & " AND CC.status = 'A' "
        'Q = Q & " GROUP BY  CC.codcausagrupa, CAG.Descausagrupa "
        'frmSpro.SPRO_TITULO = "Catalogo de CAUSAS SCRAP"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "Descausagrupa"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TCausas.Text = frmSpro.SPRO_KEY
        '    Q = ""
        '    Q = " SELECT Descausagrupa FROM CatAgrupaciones "
        '    Q = Q & " WHERE Centro = '" & strPlanta.Trim & "' "
        '    Q = Q & " AND codcausagrupa = '" & TCausas.Text & "' AND status='A'"
        '    Desccausa.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub
    Private Sub btnConsultaProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaProd.Click
        'Try
        '    FrmAdminPPT.ShowDialog()
        'Finally
        '    FrmAdminPPT.Dispose()
        '    FrmAdminPPT = Nothing
        'End Try
    End Sub
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
        'Q = ""
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
        '    Q = ""
        '    Q = " SELECT descripcion FROM Racks"
        '    Q = Q & " WHERE Centro = '" & strPlanta.Trim & "' "
        '    Q = Q & " AND rack = '" & TRack.Text & "' AND status='A'"
        '    Descrack.Text = TraeDescripcion(Q)
        '    Q = ""
        '    Q = " SELECT tara FROM Racks"
        '    Q = Q & " WHERE Centro = '" & strPlanta.Trim & "' "
        '    Q = Q & " AND rack = '" & TRack.Text & "' AND status='A'"
        '    TPesoRack.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub

    Private Sub lblScrapSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblScrapSi.Click
        If rbtScrapSi.Checked = False Then
            rbtScrapSi.Checked = True
            lblScrapSi.BackColor = Color.DarkBlue
            lblScrapSi.ForeColor = Color.White
            lblPurgaSi.BackColor = Me.BackColor
            lblPurgaSi.ForeColor = Color.DarkBlue
            rbtPurgaSi.Checked = False
        End If
    End Sub
    Private Sub lblPurgaSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPurgaSi.Click
        If rbtPurgaSi.Checked = False Then
            rbtPurgaSi.Checked = True
            lblPurgaSi.BackColor = Color.DarkBlue
            lblPurgaSi.ForeColor = Color.White
            lblScrapSi.BackColor = Me.BackColor
            lblScrapSi.ForeColor = Color.DarkBlue
            rbtScrapSi.Checked = False
        End If
    End Sub

    Private Sub rbtScrapSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtScrapSi.Click
        If rbtScrapSi.Checked = False Then
            rbtScrapSi.Checked = True
            lblScrapSi.BackColor = Color.DarkBlue
            lblScrapSi.ForeColor = Color.White
            lblPurgaSi.BackColor = Me.BackColor
            lblPurgaSi.ForeColor = Color.DarkBlue
            rbtPurgaSi.Checked = False
        End If
    End Sub

    Private Sub rbtPurgaSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPurgaSi.Click
        If rbtPurgaSi.Checked = False Then
            rbtPurgaSi.Checked = True
            lblPurgaSi.BackColor = Color.DarkBlue
            lblPurgaSi.ForeColor = Color.White
            lblScrapSi.BackColor = Me.BackColor
            lblScrapSi.ForeColor = Color.DarkBlue
            rbtScrapSi.Checked = False
        End If
    End Sub

    Private Sub btnLookdefectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookdefectos.Click
        'Q = ""
        'Q = "SELECT CC.codcausgeneral, CCG.Descausgeneral FROM CatCausas CC "
        'Q = Q & " INNER JOIN CatCausgeneral CCG ON  CC.centro = CCG.centro AND CC.codcausgeneral=CCG.codcausgeneral AND CCG.status='A'"
        'Q = Q & " WHERE CC.centro = '" & strPlanta.Trim & "' "
        'Q = Q & " AND CC.Grpprod = '" & TGrpprod.Text.Trim & "' "
        'Q = Q & " AND CC.codcausagrupa = '" & TCausas.Text.Trim & "' "
        'Q = Q & " AND CC.TipoCausa = 'SC' "
        'Q = Q & " AND CC.status = 'A' "
        'Q = Q & " GROUP BY CC.codcausgeneral, CCG.Descausgeneral "
        'frmSpro.SPRO_TITULO = "Catalogo de DEFECTOS"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "Descausgeneral"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TDefectos.Text = frmSpro.SPRO_KEY
        '    Q = " SELECT Descausgeneral FROM CatCausgeneral"
        '    Q = Q & " WHERE Centro = '" & strPlanta.Trim & "' "
        '    Q = Q & " AND codcausgeneral = '" & TDefectos.Text & "' AND status='A'"
        '    Desdefecto.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub

    Private Sub TDefectos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDefectos.Leave
        'Q = ""
        'Q = "SELECT DISTINCT CG.Descausgeneral "
        'Q = Q & " FROM CatCausas CC INNER JOIN CatCausgeneral  CG ON CC.centro= CG.centro "
        'Q = Q & "  AND CC.codcausgeneral =CG.codcausgeneral AND CG.status = 'A' " 'AND CG.codgrpgeneral= '" & TCausas.Text.Trim & "' "
        'Q = Q & "WHERE CC.centro = '" & strPlanta.Trim & "' "
        'Q = Q & "  AND CC.Grpprod = '" & TGrpprod.Text.Trim & "' "
        'Q = Q & "  AND CC.codcausagrupa = '" & TCausas.Text.Trim & "' "
        'Q = Q & "  AND CC.codcausgeneral = '" & TDefectos.Text & "' "
        'Q = Q & "  AND CC.TipoCausa = 'SC' "
        'Q = Q & "  AND CC.status = 'A'"
        'Desdefecto.Text = TraeDescripcion(Q)
        'If TGrpprod.Text.Trim = "" Or Desdefecto.Text = "" Then
        '    TDefectos.Text = ""
        '    Desdefecto.Text = ""
        'End If
        'TDefectos.BackColor = Color.White
    End Sub

    Private Sub TDefectos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDefectos.Enter
        TDefectos.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TDefectos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDefectos.TextChanged
        Dim i As Integer
        Dim c As Char
        Dim invalido As Boolean
        invalido = False
        For i = 0 To TCausas.Text.Length - 1
            c = TCausas.Text.Substring(i, 1)
            If (Char.IsNumber(c) = False) Then
                MessageBox.Show("***  Caracteres Inválidos  *** ")
                TCausas.Text = ""
                invalido = True
                Exit For
            End If
        Next
    End Sub

    Private Sub TRack_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TRack.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class