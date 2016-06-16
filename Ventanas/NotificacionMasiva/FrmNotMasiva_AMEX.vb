Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmNotMasiva_AMEX
    Dim StrStatus As Boolean
    Dim OrdenProd As String
    Dim NumeroPlanta As String
    Dim Equipo As String
    Dim Producto As String
    Dim CantProgPzs As Integer
    Dim CantProgkg As Integer = 333
    Dim fecini As String
    Dim fecterm As String
    Dim Unidad As String
    Dim Inicio As String
    Dim Fin As String
    Dim Origen As String
    Dim Status1 As String
    Dim HrReal As String
    Dim StrNumOrd As String
    Dim OrdProd As String
    Dim Planta As String
    Dim StrEquip As String
    Dim StrProd As String
    Dim StrFec As String
    Dim FecPes As String
    Dim PesNet As Decimal
    Dim Tramos As Decimal
    Dim Prod_Comp As String
    Dim Prod As String
    Dim Comp1 As String
    Dim Por1 As String
    Dim Comp2 As String
    Dim Por2 As String
    Dim folio As String
    Dim Nva_DocSap As String
    Dim Nva_ConSap As String
    Dim ProdNot As String

    'Variables de error en WS
    Dim Err As String
    Dim Mns As String

    'Registro Masivo
    Dim myDataReader As SqlClient.SqlDataReader
    Dim RegistrosActualizados As Integer
    Dim Q As String
    Dim Nva_OrdProd As String
    Dim Nva_FecPesaje As String
    Dim Nva_PesoNeto As Decimal
    Dim Nva_Tramos As Integer
    Dim Nva_Folio As String
    Dim Nvo_Compuesto As String
    Dim reg As String
    Dim Dia As String
    Dim Mes As String
    Dim Anio As String
    Dim Cont As Integer

    '--- Variables WS 
    Dim Lt_Compuestos As String
    Dim Lt_Tintas As String
    Dim Lt_Aditivos As String
    Dim Lt_Anillos As String
    Dim CompOriginal As String
    Dim StrComp As String
    Dim CadenaTexto As String

    Dim StatusSap As String  'Status de conexión Atlas - SAP
    Dim Status_Not As String

    Private Sub TxtOrdProd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOrdProd.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtOrdProd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOrdProd.Leave
        Dim Q As String
        Dim contador As Integer

        'Se verifica si digitaron un numero de orden en caja de texto

        If TxtOrdProd.Text = "" Then
            BtnConsulta1.Enabled = False
        ElseIf TxtOrdProd.Text <> "" Then

            AbrirAmanco()

            objCmd.Connection = objCnnAmanco
            Q = "select a.orden_produccion, a.planta, a.equipo_basico, a.producto, a.fecha_inicio "
            Q = Q & "from " & SessionUser._sCentro.Trim & "_OrdenProduccion a, "
            If EXTINY = "1" Then
                Q = Q & "ProductoTerminadoExtrusion b "
            Else
                Q = Q & "ProductoTerminadoInyeccion b "
            End If
            Q = Q & "where a.planta = b.centro "
            Q = Q & "and a.producto = b.codigo "
            Q = Q & "and a.orden_produccion = '" & TxtOrdProd.Text.Trim & "' "
            objCmd.CommandText = Q

            Try
                myDataReader = objCmd.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try

            contador = 0

            Do While (myDataReader.Read())
                contador = contador + 1
                OrdProd = myDataReader(0)
                Planta = myDataReader(1)
                StrEquip = myDataReader(2)
                StrProd = myDataReader(3)
                StrFec = myDataReader(4)
            Loop

            If contador = 0 Then
                If EXTINY = "1" Then
                    MessageBox.Show(" La Orden de Producción '" & TxtOrdProd.Text.Trim & "' no es de Extrusión ")
                Else
                    MessageBox.Show(" La Orden de Producción '" & TxtOrdProd.Text.Trim & "' no es de Inyección ")
                End If
                Return
            End If

            myDataReader.Close()

            TxtFec.Text = StrFec
            TxtEquipo.Text = StrEquip
            TxtProd.Text = StrProd
            BtnConsulta1.Enabled = True
        End If

    End Sub

    Private Sub FrmNotificaMasiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myDataReader As SqlClient.SqlDataReader
        Dim Q As String
        Me.Icon = Util.ApplicationIcon()

        DTP1.Value = Date.Today.ToString("yyyy-MM-dd")
        DTP2.Value = Date.Today.ToString("yyyy-MM-dd")
        BtnNotPeriodo.Enabled = False
        BtnNotif.Enabled = False

        'Validación de Check Box para Notificación Masiva.  
        ChBoxNotiMasXOrden.Checked = False
        ChBoxNotiCierre.Checked = False


        'Verifica el status de la conexión a SAP
        AbrirConfiguracion()

        Try
            If objCnn.State <> ConnectionState.Open Then
                objCnn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        objCmd = New SqlCommand
        objCmd.CommandType = CommandType.Text
        objCmd.Connection = objCnn
        Q = "Select ADM_StatusSAP.Planta, ADM_StatusSAP.Status FROM ADM_StatusSAP WHERE Modulo = 'E' and Planta='" & SessionUser._sCentro.Trim & "'"
        '
        objCmd.CommandText = Q

        Try
            myDataReader = objCmd.ExecuteReader()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        Do While (myDataReader.Read())
            StrStatus = myDataReader("Status")
        Loop
        '
        myDataReader.Close()

        If StrStatus = False Then
            MessageBox.Show("Se debe de habilitar la conexión a SAP")
            myDataReader.Close()
            Me.Close()
            Exit Sub

        ElseIf StrStatus = True Then
            Me.Label5.Text = "NOTIFICANDO A SAP"
            Me.Label5.ForeColor = Color.Green
            Me.Label11.Text = "NOTIFICANDO A SAP"
            Me.Label11.ForeColor = Color.Green
        End If

        BtnConsulta1.Enabled = False

        myDataReader.Close()
    End Sub

    Private Sub BtnNotif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotif.Click

        ' Variales para la notificación posterior al cierre de mes

        Dim V_Mes As String
        Dim V_ToDay As Date


        If TxtOrdProd.Text = "" Then
            MessageBox.Show("Tecleé Orden de Producción ")
            TxtOrdProd.Text = ""
            TxtOrdProd.Focus()
            Return
        End If

        BtnNotif.Enabled = False

        BtnCancel.Enabled = False
        Dim X As Integer
        X = 1000

        AbrirAmanco()

        Do Until X = 0

            Nva_FecPesaje = ""
            Nva_Tramos = 0
            Nva_OrdProd = ""
            Nva_PesoNeto = 0.0
            Nva_Folio = ""
            CadenaTexto = ""
            Lt_Compuestos = ""


            'Selecciona el primero de los registros a Notificar
            objCmd.Connection = objCnnAmanco
            Q = "SELECT top 1 a.orden_produccion,a.producto,b.fecha_pesaje,b.hora_pesaje,b.peso_neto,b.tramos,"
            Q = Q & "b.folio,b.notifica,b.compuesto1,b.porcentaje1,b.compuesto2,b.porcentaje2,"
            If EXTINY = "1" Then
                Q = Q & "b.peso_neto,b.LTCompuestos "
            Else
                Q = Q & "b.peso_neto,b.LTCompuestos "
            End If
            Q = Q & "FROM " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
            If EXTINY = "1" Then
                Q = Q & "ProductoTerminadoExtrusion c "
            Else
                Q = Q & "ProductoTerminadoInyeccion c "
            End If
            Q = Q & "Where a.orden_produccion = b.orden_produccion "
            Q = Q & "And a.planta = c.centro "
            Q = Q & "And a.producto = c.codigo "
            'If EXTINY = "1" Then
            '    If strPlanta.Trim = "A013" Then
            '        Q = Q & "And b.Folio = d.folio "
            '        Q = Q & "And b.Orden_produccion = d.Orden_produccion "
            '    End If
            'End If
            Q = Q & "And a.Orden_Produccion = '" & TxtOrdProd.Text.Trim & "' "
            Q = Q & "And b.Notifica in ('0', '3', '4') "
            Q = Q & "And b.notificacionmasiva = '0' "
            Q = Q & "And b.Status_Pesaje = '1' "
            objCmd.CommandText = Q

            Try
                myDataReader = objCmd.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                BtnNotif.Enabled = True
                Exit Sub
            End Try

            Dim contador As Integer
            contador = 0

            Do While (myDataReader.Read())
                contador = contador + 1
                OrdProd = myDataReader(0)
                Prod = myDataReader(1)
                FecPes = myDataReader(2)
                Tramos = myDataReader(5)
                folio = myDataReader(6)
                Comp1 = myDataReader(8)
                Por1 = myDataReader(9)
                Comp2 = myDataReader(10)
                Por2 = myDataReader(11)
                PesNet = myDataReader(12)
                Lt_Compuestos = myDataReader(13)
            Loop
            myDataReader.Close()

            If contador > 0 Then

                If ChBoxNotiMasXOrden.Checked = True Then

                    V_ToDay = Today
                    V_Mes = V_ToDay.Month
                    Dia = Mid(DateTimeNotiMasXOrden.Text, 9, 2)
                    Mes = Mid(DateTimeNotiMasXOrden.Text, 6, 2)
                    Anio = Mid(DateTimeNotiMasXOrden.Text, 1, 4)

                    If V_Mes < Mes Then
                        MsgBox(" La Fecha se encuentra en el pasado no se puede contabilizar. ", MsgBoxStyle.Exclamation, "Error")
                        BtnNotif.Enabled = True
                        Exit Sub
                    End If

                Else

                    Dia = Mid(FecPes, 9, 2)
                    Mes = Mid(FecPes, 6, 2)
                    Anio = Mid(FecPes, 1, 4)


                End If


                Nva_OrdProd = OrdProd.Trim
                Nva_FecPesaje = "" & Anio & "-" & Mes & "-" & Dia & ""
                Nva_PesoNeto = PesNet
                Nva_Tramos = Tramos
                Nva_Folio = folio

                'Inicio WS ----> SAP 

                Nva_DocSap = "0000000000"
                Nva_ConSap = "00000000"
                CadenaTexto = SessionUser._sAlias.Trim + "|" + folio.Trim
                Err = "000"

                Select Case StrStatus

                    Case "False"
                        MessageBox.Show(" No esta Activada la conexión a SAP ")
                        BtnNotif.Enabled = True
                        Exit Do
                    Case "True"

                        If SessionUser._sAlias.Trim <> "ATLAS" Then

                            Select Case SessionUser._sCentro

                                Case Is = "A013", "A014", "A015"

                                    Dim Not_Prod As PT_ConMat_Prod._ISDFPS_TCUPS_KEY

                                    Not_Prod = Notifica_Prod(Nva_FecPesaje.Trim, Nva_Tramos, Nva_OrdProd, Nva_PesoNeto, 0, CadenaTexto, Lt_Compuestos.Trim)

                                    Nva_ConSap = Not_Prod.RMZHL
                                    Nva_DocSap = Not_Prod.RUECK
                                    Err = ls_return_p.ZTYPE
                                    Mns = ls_return_p.ZMESSAGE

                                Case Else

                                    Dim Notificacion As PTConProd._ISDFPS_TCUPS_KEY

                                    Notificacion = Notifica_PT(Nva_FecPesaje.Trim, Nva_Tramos, Nva_OrdProd, Nva_PesoNeto, 0, CadenaTexto, Lt_Compuestos.Trim)

                                    Nva_ConSap = Notificacion.RMZHL
                                    Nva_DocSap = Notificacion.RUECK
                                    Err = ls_return.ZTYPE
                                    Mns = ls_return.ZMESSAGE

                            End Select

                            'Dim Notificacion As PTConProd.ISDFPS_TCUPS_KEY

                            'Notificacion = Notifica_PT(Nva_FecPesaje.Trim, Nva_Tramos, Nva_OrdProd, Nva_PesoNeto, 0, CadenaTexto, Lt_Compuestos)

                            'Nva_ConSap = Notificacion.RMZHL
                            'Nva_DocSap = Notificacion.RUECK
                            'Err = ls_return.ZTYPE
                            'Mns = ls_return.ZMESSAGE
                            ''Err = ls_return.ZNUMBER

                        ElseIf SessionUser._sAlias.Trim = "ATLAS" Then

                            Dim Not_Atlas As PTConsumos._ISDFPS_TCUPS_KEY

                            Not_Atlas = Notifica_Atlas(Nva_FecPesaje.Trim, Nva_Tramos, Nva_OrdProd, Nva_PesoNeto, 0, CadenaTexto, Lt_Compuestos)

                            Nva_ConSap = Not_Atlas.RMZHL
                            Nva_DocSap = Not_Atlas.RUECK
                            Err = ls_returnr.ZTYPE
                            Mns = ls_returnr.ZMESSAGE
                            Err = ls_returnr.ZNUMBER

                        End If

                End Select

                'Inicio verifica error de la orden de produccion
                If Err = "E" Then
                    MessageBox.Show(Mns, "Error en SAP Notifique al Supervisor")
                    BtnNotif.Enabled = True
                    Exit Do
                End If
                'Fin verifica error de la orden de produccion


                If (Nva_ConSap.Trim = "" Or Nva_ConSap.Trim = " " Or Nva_ConSap.Trim = "NULL" Or Nva_ConSap.Trim = "00000000") And (Nva_DocSap.Trim = "" Or Nva_DocSap.Trim = " " Or Nva_DocSap.Trim = "NULL" Or Nva_DocSap.Trim = "0000000000") Then
                    reg = "0"
                Else
                    reg = "1"

                    objCmd.Connection = objCnnAmanco
                    Q = "UPDATE " & SessionUser._sCentro.Trim & "_PesoProductoTerminado SET Documento_SAP = '" & Nva_DocSap & "', "
                    Q = Q & "Consecutivo_SAP = '" & Nva_ConSap & "', "
                    Q = Q & "Notifica = '" & reg & "', "
                    Q = Q & "Notificacionmasiva = '" & reg & "', "
                    Q = Q & "Tipo_PT = 'T' "
                    Q = Q & "WHERE Orden_Produccion = '" & Nva_OrdProd.Trim & "' "
                    Q = Q & "AND Folio = '" & Nva_Folio.Trim & "' "
                    objCmd.CommandText = Q

                    DGNotODF.DataSource = Nothing

                    Try
                        RegistrosActualizados = objCmd.ExecuteNonQuery()
                    Catch ex1 As Exception
                        MsgBox(ex1.Message)
                        BtnNotif.Enabled = True
                        Exit Sub
                    End Try
                    myDataReader.Close()

                End If

            End If
            X = contador
        Loop

        MessageBox.Show("Registros Actualizados")
        Dim Message As String = "Desea Notificar otra Orden de Produccion"
        Dim Caption As String = "Finalizo Notificación"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim Resultado As DialogResult
        'Se presenta el mensaje en pantalla
        Resultado = MessageBox.Show(Message, Caption, Buttons)
        ' Se toma ejecuta el proceso de acuerdo a la decision tomada
        If Resultado = System.Windows.Forms.DialogResult.Yes Then

            TxtOrdProd.Text = ""
            TxtFec.Text = ""
            TxtEquipo.Text = ""
            TxtProd.Text = ""
            DGNotODF.DataSource = Nothing
            BtnNotif.Enabled = False
            BtnCancel.Enabled = True
        Else
            If Resultado = System.Windows.Forms.DialogResult.No Then
                BtnNotif.Enabled = True
                Close()
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()

    End Sub

    Private Sub FrmNotificaMasiva_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        EXTINY = ""
        TxtOrdProd.Text = ""
        TxtFec.Text = ""
        TxtEquipo.Text = ""
        TxtProd.Text = ""
        BtnNotif.Enabled = False
        BtnNotPeriodo.Enabled = False
        CBNot.Checked = False
        BtnCancel.Enabled = True
        DGNotODF.DataSource = Nothing
        DGNotPer.DataSource = Nothing
    End Sub

    Private Sub CBNot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBNot.CheckedChanged
        If CBNot.Checked = True Then
            BtnNotPeriodo.Enabled = True
            BtnConsulta.Enabled = False
            DTP1.Enabled = False
            DTP2.Enabled = False
        Else
            BtnNotPeriodo.Enabled = False
            BtnConsulta.Enabled = True
            DTP1.Enabled = True
            DTP2.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        Dim FecIni As String
        Dim FecFin As String

        FecIni = DTP1.Value.ToString("yyyy-MM-dd")
        FecFin = DTP2.Value.ToString("yyyy-MM-dd")


        QRY_Grid = ""
        NameTable = ""
        NameTable = "Notificaciones"
        QRY_Grid = "Select b.orden_produccion,b.Fecha_Pesaje,b.Tramos,b.folio,Peso_neto,b.documento_sap,"
        QRY_Grid = QRY_Grid & "b.consecutivo_sap,b.notifica,b.notificacionmasiva "
        QRY_Grid = QRY_Grid & "from " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
        If EXTINY = "1" Then
            QRY_Grid = QRY_Grid & "ProductoTerminadoExtrusion c "
        Else
            QRY_Grid = QRY_Grid & "ProductoTerminadoInyeccion c "
        End If
        QRY_Grid = QRY_Grid & "Where a.orden_produccion = b.orden_produccion "
        QRY_Grid = QRY_Grid & "and b.planta = c.centro "
        QRY_Grid = QRY_Grid & "and a.producto = c.codigo "
        QRY_Grid = QRY_Grid & "and b.fecha_Pesaje between '" & FecIni & "' and '" & FecFin & "' "
        QRY_Grid = QRY_Grid & "and b.notifica in ('0', '3', '4') "
        QRY_Grid = QRY_Grid & "and notificacionmasiva = '0' "
        QRY_Grid = QRY_Grid & "and b.Status_Pesaje = '1' "
        GridInsert(QRY_Grid, NameTable)

        DGNotPer.DataSource = bindingSource1

        DGNotPer.Columns(0).HeaderText = "Orden Produccion"
        DGNotPer.Columns(1).HeaderText = "Fecha Pesaje"
        If EXTINY = "1" Then
            DGNotPer.Columns(2).HeaderText = "Tramos"
        Else
            DGNotPer.Columns(2).HeaderText = "Piezas"
        End If
        DGNotPer.Columns(3).HeaderText = "Folio"
        DGNotPer.Columns(4).HeaderText = "Peso Neto"
        DGNotPer.Columns(5).HeaderText = "Documento SAP"
        DGNotPer.Columns(6).HeaderText = "Consecutivo SAP"
        DGNotPer.Columns(7).HeaderText = "Status Notificación"
        DGNotPer.Columns(8).HeaderText = "Status Notificación Masiva"


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Close()

    End Sub

    Private Sub BtnNotPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotPeriodo.Click

        ' Variales para la notificación posterior al cierre de mes

        Dim V_Mes As String
        Dim V_ToDay As Date

        fecini = DTP1.Value.ToString("yyyy-MM-dd")
        fecterm = DTP2.Value.ToString("yyyy-MM-dd")

        BtnNotPeriodo.Enabled = False

        BtnCancel.Enabled = False
        Dim X As Integer
        X = 1000

        AbrirAmanco()

        Do Until X = 0

            Nva_FecPesaje = ""
            Nva_Tramos = 0
            Nva_OrdProd = ""
            Nva_PesoNeto = 0.0
            Nva_Folio = ""
            CadenaTexto = ""
            Lt_Compuestos = ""

            'Selecciona el primero de los registros a Notificar
            objCmd.Connection = objCnnAmanco
            Q = "SELECT top 1 a.orden_produccion,a.producto,b.fecha_pesaje,b.hora_pesaje,b.peso_neto,b.tramos,"
            Q = Q & "b.folio,b.notifica,b.compuesto1,b.porcentaje1,b.compuesto2,b.porcentaje2,"
            If EXTINY = "1" Then
                Q = Q & "b.pesonetomerma,b.LTCompuestos "
            Else
                Q = Q & "b.peso_neto,b.LTCompuestos "
            End If
            Q = Q & "FROM " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
            If EXTINY = "1" Then
                Q = Q & "ProductoTerminadoExtrusion c "
            Else
                Q = Q & "ProductoTerminadoInyeccion c "
            End If
            Q = Q & "where a.orden_produccion = b.orden_produccion "
            Q = Q & "and a.planta = c.centro "
            Q = Q & "and a.producto = c.codigo "
            Q = Q & "and b.Notifica in ('0', '3', '4') "
            Q = Q & "and b.notificacionmasiva = '0' "
            Q = Q & "and b.Status_Pesaje = '1' "
            Q = Q & "and b.fecha_pesaje between '" & fecini & "' and '" & fecterm & "' "
            objCmd.CommandText = Q

            Try
                myDataReader = objCmd.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                BtnNotPeriodo.Enabled = True
                Exit Sub
            End Try

            Dim contador As Integer
            contador = 0

            Do While (myDataReader.Read())
                contador = contador + 1
                OrdProd = myDataReader(0)
                Prod = myDataReader(1)
                FecPes = myDataReader(2)
                PesNet = myDataReader(4)
                Tramos = myDataReader(5)
                folio = myDataReader(6)
                Comp1 = myDataReader(8)
                Por1 = myDataReader(9)
                Comp2 = myDataReader(10)
                Por2 = myDataReader(11)
                StrComp = myDataReader(13)
            Loop
            myDataReader.Close()
            If contador > 0 Then
                Lt_Compuestos = StrComp.Trim
                If ChBoxNotiCierre.Checked = True Then
                    V_ToDay = Today
                    V_Mes = V_ToDay.Month
                    Dia = Mid(DateTimeNotiMasiva.Text, 9, 2)
                    Mes = Mid(DateTimeNotiMasiva.Text, 6, 2)
                    Anio = Mid(DateTimeNotiMasiva.Text, 1, 4)
                    If V_Mes < Mes Then
                        MsgBox(" La Fecha se encuentra en el pasado no se puede contabilizar. ", MsgBoxStyle.Exclamation, "Error")
                        BtnNotPeriodo.Enabled = True
                        Exit Sub
                    End If
                Else
                    Dia = Mid(FecPes, 9, 2)
                    Mes = Mid(FecPes, 6, 2)
                    Anio = Mid(FecPes, 1, 4)
                End If
                Nva_OrdProd = OrdProd
                Nva_FecPesaje = "" & Anio & "-" & Mes & "-" & Dia & ""
                Nva_PesoNeto = PesNet
                Nva_Tramos = Tramos
                Nva_Folio = folio
                'Inicio WS ----> SAP 
                Nva_DocSap = "0000000000"
                Nva_ConSap = "00000000"
                CadenaTexto = SessionUser._sAlias.Trim + "|" + folio.Trim
                Select Case StrStatus
                    Case "False"
                        MessageBox.Show(" No esta Activada la conexión a SAP ")
                        BtnNotif.Enabled = True
                        Exit Do
                    Case "True"

                        If SessionUser._sAlias.Trim <> "ATLAS" Then


                            Dim Notificacion As PTConProd._ISDFPS_TCUPS_KEY

                            Notificacion = Notifica_PT(Nva_FecPesaje, Nva_Tramos, Nva_OrdProd, Nva_PesoNeto, 0, CadenaTexto, Lt_Compuestos.Trim)

                            Nva_ConSap = Notificacion.RMZHL
                            Nva_DocSap = Notificacion.RUECK
                            Err = ls_return.ZTYPE
                            Mns = ls_return.ZMESSAGE



                        ElseIf SessionUser._sAlias.Trim = "ATLAS" Then

                            Select Case SessionUser._sCentro

                                Case Is = "A013"

                                    Dim Not_Atlas As PTConsumos._ISDFPS_TCUPS_KEY

                                    If EXTINY = "1" Then
                                        Lt_Compuestos = Lt_Compuestos + Lt_Tintas + Lt_Aditivos + Lt_Anillos
                                    End If

                                    Not_Atlas = Notifica_Atlas(Nva_FecPesaje.Trim, Nva_Tramos, Nva_OrdProd, Nva_PesoNeto, 0, CadenaTexto, Lt_Compuestos.Trim)

                                    Nva_ConSap = Not_Atlas.RMZHL
                                    Nva_DocSap = Not_Atlas.RUECK
                                    Err = ls_returnr.ZTYPE
                                    Mns = ls_returnr.ZMESSAGE

                                Case Else

                                    Dim Not_Atlas As PTConsumos._ISDFPS_TCUPS_KEY

                                    Not_Atlas = Notifica_Atlas(Nva_FecPesaje.Trim, Nva_Tramos, Nva_OrdProd, Nva_PesoNeto, 0, CadenaTexto, Lt_Compuestos.Trim)

                                    Nva_ConSap = Not_Atlas.RMZHL
                                    Nva_DocSap = Not_Atlas.RUECK
                                    Err = ls_returnr.ZTYPE
                                    Mns = ls_returnr.ZMESSAGE

                            End Select
                        End If

                End Select


                'Inicio verifica error de la orden de produccion
                If Err = "E" Then
                    MessageBox.Show(Mns, "Error en SAP Notifique al Supervisor")
                    BtnNotPeriodo.Enabled = True
                    Exit Do
                End If
                'Fin verifica error de la orden de produccion


                If (Nva_ConSap = "" Or Nva_ConSap = " " Or Nva_ConSap = "NULL" Or Nva_ConSap = "00000000") And (Nva_DocSap = "" Or Nva_DocSap = " " Or Nva_DocSap = "NULL" Or Nva_DocSap = "0000000000") Then
                    reg = "0"
                Else
                    reg = "1"

                    objCmd.Connection = objCnnAmanco
                    Q = "UPDATE " & SessionUser._sCentro.Trim & "_PesoProductoTerminado SET Documento_SAP = '" & Nva_DocSap & "', "
                    Q = Q & "Consecutivo_SAP = '" & Nva_ConSap & "', "
                    Q = Q & "Notifica = '" & reg & "', "
                    Q = Q & "Notificacionmasiva = '" & reg & "', "
                    Q = Q & "Tipo_PT = 'T' "
                    Q = Q & "WHERE Orden_Produccion = '" & Nva_OrdProd.Trim & "' "
                    Q = Q & "AND Folio = '" & Nva_Folio.Trim & "' "
                    objCmd.CommandText = Q

                    DGNotPer.DataSource = Nothing

                    Try
                        RegistrosActualizados = objCmd.ExecuteNonQuery()
                    Catch ex1 As Exception
                        MsgBox(ex1.Message)
                        BtnNotPeriodo.Enabled = True
                        Exit Sub
                    End Try
                    myDataReader.Close()

                End If
            Else
                MessageBox.Show("No existen pesajes para notificar")
                Exit Sub
            End If
            X = contador
        Loop

        MessageBox.Show("Registros Actualizados")
        Dim Message As String = "Desea Notificar otra Orden de Produccion"
        Dim Caption As String = "Finalizo Notificación"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim Resultado As DialogResult
        'Se presenta el mensaje en pantalla
        Resultado = MessageBox.Show(Message, Caption, Buttons)
        ' Se toma ejecuta el proceso de acuerdo a la decision tomada
        If Resultado = System.Windows.Forms.DialogResult.Yes Then

            DTP1.Value = DateTime.Today.ToString("yyyy-MM-dd")
            DTP2.Value = DateTime.Today.ToString("yyyy-MM-dd")
        Else
            If Resultado = System.Windows.Forms.DialogResult.No Then
                BtnNotPeriodo.Enabled = True
                CBNot.CheckState = CheckState.Unchecked
                ChBoxNotiCierre.CheckState = CheckState.Unchecked
                Close()
            End If
        End If
    End Sub

    Private Sub ChBoxNotiCierre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBoxNotiCierre.CheckedChanged

        'Validación de objetos para la notificación Masiva posterior al cierre

        If CBNot.Enabled = True Then
            CBNot.Enabled = False
        Else
            CBNot.Enabled = True
        End If

        If ChBoxNotiCierre.Checked = True Then
            Label12.Visible = True
            DateTimeNotiMasiva.Visible = True
        Else
            Label12.Visible = False
            DateTimeNotiMasiva.Visible = False
        End If

        If BtnNotPeriodo.Enabled = False Then
            BtnNotPeriodo.Enabled = True
        Else
            BtnNotPeriodo.Enabled = False
        End If

        If BtnConsulta.Enabled = True Then
            BtnConsulta.Enabled = False
        Else
            BtnConsulta.Enabled = True
        End If

    End Sub

    Private Sub BtnConsulta1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta1.Click

        QRY_Grid = ""
        NameTable = ""
        NameTable = "Notif_ODF"
        QRY_Grid = "Select b.orden_produccion,b.Fecha_Pesaje,b.Tramos,b.folio,b.documento_sap,"
        QRY_Grid = QRY_Grid & "b.consecutivo_sap,b.notifica,b.notificacionmasiva,"
        If EXTINY = "1" Then
            QRY_Grid = QRY_Grid & "b.pesonetomerma "
        Else
            QRY_Grid = QRY_Grid & "b.Peso_neto "
        End If
        QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
        If EXTINY = "1" Then
            QRY_Grid = QRY_Grid & "ProductoTerminadoExtrusion c "
        Else
            QRY_Grid = QRY_Grid & "ProductoTerminadoInyeccion c "
        End If
        QRY_Grid = QRY_Grid & "Where a.orden_produccion = b.orden_produccion "
        QRY_Grid = QRY_Grid & "And a.planta = c.centro "
        QRY_Grid = QRY_Grid & "And a.producto = c.codigo "
        QRY_Grid = QRY_Grid & "And b.notifica in ('0', '3', '4') "
        QRY_Grid = QRY_Grid & "And b.notificacionmasiva = 0 "
        QRY_Grid = QRY_Grid & "And b.Status_Pesaje = '1' "
        QRY_Grid = QRY_Grid & "And a.orden_produccion = '" & TxtOrdProd.Text.Trim & "' "
        QRY_Grid = QRY_Grid & "And b.Planta = '" & SessionUser._sCentro.Trim & "' "
        LecturaQry(QRY_Grid)

        Cont = 0

        Do While (LecturaBD.Read)
            Cont = Cont + 1
        Loop

        If Cont > 0 Then

            GridInsert(QRY_Grid, NameTable)

            DGNotODF.DataSource = bindingSource1

            DGNotODF.Columns(0).HeaderText = "Orden Produccion"
            DGNotODF.Columns(1).HeaderText = "Fecha Pesaje"
            If EXTINY = "1" Then
                DGNotODF.Columns(2).HeaderText = "Tramos"
            Else
                DGNotODF.Columns(2).HeaderText = "Piezas"
            End If
            DGNotODF.Columns(3).HeaderText = "Folio"
            DGNotODF.Columns(4).HeaderText = "Documento SAP"
            DGNotODF.Columns(5).HeaderText = "Consecutivo SAP"
            DGNotODF.Columns(6).HeaderText = "Status Notificación"
            DGNotODF.Columns(7).HeaderText = "Status Notificación Masiva"
            DGNotODF.Columns(8).HeaderText = "Peso Neto"

        Else

            MessageBox.Show("No existen registros a Notificar de esta Orden de Producción")
            TxtFec.Text = ""
            TxtEquipo.Text = ""
            TxtProd.Text = ""
            TxtOrdProd.Text = ""
            TxtOrdProd.Focus()

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBNotif_ODF.CheckedChanged
        If CBNotif_ODF.Checked = True Then
            BtnNotif.Enabled = True
            BtnConsulta1.Enabled = False
        Else
            BtnNotif.Enabled = False
            BtnConsulta1.Enabled = True
        End If
    End Sub
    Private Sub ChBoxNotiMasXOrden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBoxNotiMasXOrden.CheckedChanged

        If ChBoxNotiMasXOrden.Checked = True Then
            BtnNotif.Enabled = True
            BtnConsulta1.Enabled = False
            Label15.Visible = True
            DateTimeNotiMasXOrden.Visible = True
        Else
            BtnNotif.Enabled = False
            BtnConsulta1.Enabled = True
            Label15.Visible = False
            DateTimeNotiMasXOrden.Visible = False
        End If

    End Sub

    Private Sub DGNotPer_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGNotPer.CellFormatting
        Status_Not = (DGNotPer.Rows(e.RowIndex).Cells(7).Value)

        If Status_Not = "0" Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Black
        End If
    End Sub
End Class