Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmNotMasivaSC_AMEX
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
    Dim Prod As String
    Dim Comp1 As String
    Dim Por1 As String
    Dim Comp2 As String
    Dim Por2 As String
    Dim Planta As String
    Dim StrEquip As String
    Dim StrProd As String
    Dim StrFec As String
    Dim FecPes As String
    Dim PesNet As Decimal
    Dim Tramos As Decimal
    Dim folio As String
    Dim Usr_Reg As String
    Dim Nva_DocSap As String
    Dim Nva_ConSap As String
    Dim TUnidadesS As Decimal

    '--- Variables WS 
    Dim Lt_Compuestos As String = ""
    Dim CompOriginal As String = ""
    Dim CadenaTexto As String = ""

    Dim FI_Scrap As String
    Dim FF_Scrap As String

    'Variables de error en WS
    Dim Err As String
    Dim Mns As String

    'Registro Masivo
    Dim myDataReader As SqlClient.SqlDataReader
    Dim RegistrosActualizados As Integer
    Dim Q As String
    Dim Cont As Integer
    Dim Nva_OrdProd As String
    Dim Nva_FecPesaje As String
    Dim Nva_PesoNeto As Decimal
    Dim Nva_Tramos As Integer
    Dim Nva_Folio As String
    Dim V_Mes As String
    Dim V_ToDay As Date
    Dim reg As String
    Dim Dia As String
    Dim Mes As String
    Dim Anio As String

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

            AbrirAmanco(SessionUser._sAmbiente)

            objCmd.Connection = objCnnAmanco
            Q = "Select a.orden_produccion, a.planta, a.equipo_basico, a.producto, a.fecha_inicio "
            Q = Q & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, "
            If EXTINY = "1" Then
                Q = Q & "ProductoTerminadoExtrusion b "
            Else
                Q = Q & "ProductoTerminadoInyeccion b "
            End If
            Q = Q & "Where a.planta = b.Centro "
            Q = Q & "And a.producto = b.Codigo "
            Q = Q & "And a.orden_produccion = '" & TxtOrdProd.Text.Trim & "' "
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

    Private Sub FrmNotMasivaSCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myDataReader As SqlClient.SqlDataReader
        Dim Q As String

        Me.Icon = Util.ApplicationIcon()

        BtnNotPeriodo.Enabled = False
        BtnNotif.Enabled = False

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
        Q = "Select ADM_StatusSAP.Planta, ADM_StatusSAP.Status FROM ADM_StatusSAP WHERE Planta='" & SessionUser._sCentro & "' And Modulo = 'E'"
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
            Me.Label15.Text = "NOTIFICANDO A SAP"
            Me.Label15.ForeColor = Color.Green
            Me.Label11.Text = "NOTIFICANDO A SAP"
            Me.Label11.ForeColor = Color.Green
        End If



        myDataReader.Close()
    End Sub

    Private Sub BtnNotif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotif.Click

        Dim Count As Integer = 0

        If TxtOrdProd.Text = "" Then
            MessageBox.Show("Tecleé Orden de Producción ")
            TxtOrdProd.Text = ""
            TxtOrdProd.Focus()
        End If

        BtnNotif.Enabled = False

        BtnCancel.Enabled = False
        Dim X As Integer
        X = 500

        AbrirAmanco(SessionUser._sAmbiente)

        Do Until X = 0

            Nva_OrdProd = ""
            Nva_FecPesaje = ""
            Nva_PesoNeto = 0.0
            Nva_Tramos = 0
            Nva_Folio = ""


            'Selecciona el primero de los registros a Notificar
            objCmd.Connection = objCnnAmanco
            Q = "SELECT top 1* FROM " & SessionUser._sCentro.Trim & "_PesoScrap "
            Q = Q & "WHERE Orden_Produccion = '" & TxtOrdProd.Text.Trim & "' "
            Q = Q & "AND Notifica in ('0', '4', '5')  "
            Q = Q & "AND notificacionmasiva = '0'  "
            Q = Q & "AND Status_Pesaje = '1'  "
            Q = Q & "AND Planta = '" & SessionUser._sCentro & "'"
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
                FecPes = myDataReader(1)
                PesNet = myDataReader(7)
                folio = myDataReader(11)
                Lt_Compuestos = myDataReader(21)
                Usr_Reg = myDataReader(8)
            Loop
            myDataReader.Close()

            If contador <> 0 Then

                CadenaTexto = Usr_Reg.Trim & "|" & folio.Trim

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

                Nva_OrdProd = OrdProd
                Nva_FecPesaje = "" & Anio & "-" & Mes & "-" & Dia & ""
                Nva_PesoNeto = PesNet
                Nva_Tramos = Tramos
                Nva_Folio = folio

                'Se comienza con la insercion de los datos a la tabla de orden de produccion

                If StrStatus = True Then
                    If SessionUser._sAlias.Trim() <> "ATLAS" Then

                        '  Variables WS Productivo

                        Dim lo_wsamancomxp As New PTConProd.ZPPMXF001Service
                        Dim ls_returnp As New PTConProd.ZBAPIRET2
                        Dim ls_Notificap As New PTConProd.ZEPP002
                        Dim ls_resultp As New PTConProd._ISDFPS_TCUPS_KEY

                        ls_Notificap.ZBUDAT = Nva_FecPesaje
                        ls_Notificap.ZCONSUME_REC = 0.0
                        ls_Notificap.ZENTRY_QNT = TUnidadesS
                        ls_Notificap.ZISM01 = 0.0
                        ls_Notificap.ZISM02 = 0.0
                        ls_Notificap.ZISM03 = 0.0
                        ls_Notificap.ZISMNGEH1 = ""
                        ls_Notificap.ZISMNGEH2 = ""
                        ls_Notificap.ZISMNGEH3 = ""
                        ls_Notificap.ZMATNR_REC = ""
                        ls_Notificap.ZORDERID = Nva_OrdProd.Trim
                        ls_Notificap.ZRECOVERED = Nva_PesoNeto
                        ls_Notificap.ZVIRGIN = 0.0

                        lo_wsamancomxp.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                        ls_resultp = lo_wsamancomxp.ZPPMXF001(CadenaTexto.Trim, Lt_Compuestos.Trim, ls_Notificap, ls_returnp)

                        Nva_DocSap = ls_resultp.RUECK
                        Nva_ConSap = ls_resultp.RMZHL
                        Err = ls_returnp.ZTYPE
                        Mns = ls_returnp.ZMESSAGE

                    ElseIf SessionUser._sAlias.Trim = "ATLAS" Then

                        '  Variables WS Desarrollo

                        Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
                        Dim ls_returnr As New PTConsumos.ZBAPIRET2
                        Dim ls_Notifica As New PTConsumos.ZEPP002
                        Dim ls_result As New PTConsumos._ISDFPS_TCUPS_KEY

                        ls_Notifica.ZBUDAT = Nva_FecPesaje
                        ls_Notifica.ZCONSUME_REC = 0.0
                        ls_Notifica.ZENTRY_QNT = TUnidadesS
                        ls_Notifica.ZISM01 = 0.0
                        ls_Notifica.ZISM02 = 0.0
                        ls_Notifica.ZISM03 = 0.0
                        ls_Notifica.ZISMNGEH1 = ""
                        ls_Notifica.ZISMNGEH2 = ""
                        ls_Notifica.ZISMNGEH3 = ""
                        ls_Notifica.ZMATNR_REC = ""
                        ls_Notifica.ZMATNR_REC = ""
                        ls_Notifica.ZORDERID = Nva_OrdProd
                        ls_Notifica.ZRECOVERED = Nva_PesoNeto
                        ls_Notifica.ZVIRGIN = 0.0

                        lo_wsamancomxr.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                        ls_result = lo_wsamancomxr.ZPPMXF001(CadenaTexto, Lt_Compuestos.Trim, ls_Notifica, ls_returnr)

                        Nva_DocSap = ls_result.RUECK
                        Nva_ConSap = ls_result.RMZHL
                        Err = ls_returnr.ZTYPE
                        Mns = ls_returnr.ZMESSAGE

                    End If

                Else
                    MessageBox.Show(" No se realizara notificación a SAP ")
                End If

                'Inicio verifica error de la orden de produccion
                If Err = "E" Then
                    MessageBox.Show(Mns, "Error en SAP Notifique al Supervisor")
                    BtnNotif.Enabled = True
                    Exit Do
                End If
                'Fin verifica error de la orden de produccion

                Dim reg As String

                If (Nva_ConSap = "" Or Nva_ConSap = "NULL" Or Nva_ConSap = "00000000") And (Nva_DocSap = "" Or Nva_DocSap = "NULL" Or Nva_DocSap = "0000000000") Then
                    reg = "0"
                Else
                    reg = "1"
                    objCmd.Connection = objCnnAmanco
                    Q = "UPDATE " & SessionUser._sCentro.Trim & "_PesoScrap SET Documento_SAP = '" & Nva_DocSap & "', "
                    Q = Q & "Consecutivo_SAP = '" & Nva_ConSap & "', "
                    Q = Q & "Notifica = '" & reg & "', "
                    Q = Q & "Notificacionmasiva = '" & reg & "' "
                    Q = Q & "WHERE Orden_Produccion = '" & Nva_OrdProd.Trim & "' "
                    Q = Q & "AND Folio = '" & Nva_Folio.Trim & "' "
                    Q = Q & "AND Planta = '" & SessionUser._sCentro.Trim & "'"
                    objCmd.CommandText = Q

                    Try
                        RegistrosActualizados = objCmd.ExecuteNonQuery()
                    Catch ex1 As Exception
                        MsgBox(ex1.Message)
                        BtnNotif.Enabled = True
                        Exit Sub
                    End Try
                    myDataReader.Close()

                End If

            Else
                MessageBox.Show(Mns, "No Existen Ordenes a notificar")
                Exit Do
            End If

            X = contador

        Loop

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

    Private Sub FrmNotMasivaSCE_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
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
        DGNotPerScrap.DataSource = Nothing
    End Sub

    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        FI_Scrap = DTP1.Value.ToString("yyyy-MM-dd")
        FF_Scrap = DTP2.Value.ToString("yyyy-MM-dd")

        QRY_Grid = ""
        NameTable = ""
        NameTable = "Notif_Scrap"
        QRY_Grid = "Select Orden_Produccion,Fecha_Pesaje,Peso_Neto,Documento_SAP,Consecutivo_SAP,"
        QRY_Grid = QRY_Grid & "Notifica,notificacionmasiva,Folio "
        QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_PesoScrap "
        QRY_Grid = QRY_Grid & "Where Fecha_Pesaje between '" & FI_Scrap.Trim & "' And '" & FF_Scrap.Trim & "' "
        QRY_Grid = QRY_Grid & "And Notifica in ('0', '4', '5') "
        QRY_Grid = QRY_Grid & "And notificacionmasiva = '0' "
        QRY_Grid = QRY_Grid & "And Status_Pesaje = '1' "
        If EXTINY = "1" Then
            QRY_Grid = QRY_Grid & "And Area = 'E' "
        Else
            QRY_Grid = QRY_Grid & "And Area = 'I' "
        End If
        GridInsert(QRY_Grid, NameTable)


        DGNotPerScrap.DataSource = bindingSource1

        DGNotPerScrap.Columns(0).HeaderText = "Orden Produccion"
        DGNotPerScrap.Columns(1).HeaderText = "Fecha Pesaje"
        DGNotPerScrap.Columns(2).HeaderText = "Peso Neto"
        DGNotPerScrap.Columns(3).HeaderText = "Documento SAP"
        DGNotPerScrap.Columns(4).HeaderText = "Consecutivo SAP"
        DGNotPerScrap.Columns(5).HeaderText = "Status Notificación"
        DGNotPerScrap.Columns(6).HeaderText = "Status Notificación Masiva"
        DGNotPerScrap.Columns(7).HeaderText = "Folio"


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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


        Do Until X = 0

            Nva_OrdProd = ""
            Nva_FecPesaje = ""
            Nva_PesoNeto = 0.0
            Nva_Tramos = 0
            Nva_Folio = ""
            CadenaTexto = ""

            'Selecciona el primero de los registros a Notificar
            QRY = ""
            NameTable = ""
            NameTable = "Notif_Scrap"
            QRY = "Select top 1 b.Orden_Produccion,a.Producto,b.Fecha_Pesaje,b.Peso_Neto,b.Tramos,b.folio,"
            QRY = QRY & "b.compuesto1,b.porcentaje1,b.compuesto2,b.porcentaje2,b.LTCompuestos "
            QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b "
            QRY = QRY & "Where a.Orden_Produccion = b.Orden_produccion "
            QRY = QRY & "And Fecha_Pesaje between '" & fecini & "' And '" & fecterm & "' "
            QRY = QRY & "And Notifica in ('0', '4', '5') "
            QRY = QRY & "And notificacionmasiva = '0' "
            QRY = QRY & "And Status_Pesaje = '1' "
            If EXTINY = "1" Then
                QRY = QRY & "And b.Area = 'E' "
            Else
                QRY = QRY & "And b.Area = 'I' "
            End If
            LecturaQry(QRY)

            Dim contador As Integer
            contador = 0

            Do While (LecturaBD.Read())
                contador = contador + 1
                OrdProd = LecturaBD(0)
                Prod = LecturaBD(1)
                FecPes = LecturaBD(2)
                PesNet = LecturaBD(3)
                Tramos = LecturaBD(4)
                folio = LecturaBD(5)
                Comp1 = LecturaBD(6)
                Por1 = LecturaBD(7)
                Comp2 = LecturaBD(8)
                Por2 = LecturaBD(9)
                Lt_Compuestos = LecturaBD(10)
            Loop

            LecturaBD.Close()


            If contador <> 0 Then

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

                Select Case StrStatus

                    Case "False"
                        MessageBox.Show(" No esta Activada la conexión a SAP ")
                        BtnNotPeriodo.Enabled = True
                        Exit Do
                    Case "True"

                        If SessionUser._sAlias.Trim <> "ATLAS" Then


                            '--- Variables WS Productivo
                            Dim lo_wsamancomx As New PTConProd.ZPPMXF001Service
                            Dim ls_return As New PTConProd.ZBAPIRET2
                            Dim ls_Notifica As New PTConProd.ZEPP002
                            Dim ls_result As New PTConProd._ISDFPS_TCUPS_KEY

                            ls_Notifica.ZBUDAT = Nva_FecPesaje
                            ls_Notifica.ZCONSUME_REC = 0.0
                            ls_Notifica.ZENTRY_QNT = 0
                            ls_Notifica.ZISM01 = 0.0
                            ls_Notifica.ZISM02 = 0.0
                            ls_Notifica.ZISM03 = 0.0
                            ls_Notifica.ZISMNGEH1 = ""
                            ls_Notifica.ZISMNGEH2 = ""
                            ls_Notifica.ZISMNGEH3 = ""
                            ls_Notifica.ZMATNR_REC = ""
                            ls_Notifica.ZORDERID = Nva_OrdProd.Trim
                            ls_Notifica.ZRECOVERED = Nva_PesoNeto
                            ls_Notifica.ZVIRGIN = 0

                            CadenaTexto = SessionUser._sAlias.Trim + "|" + folio.Trim


                            lo_wsamancomx.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                            ls_result = lo_wsamancomx.ZPPMXF001(CadenaTexto.Trim, Lt_Compuestos.Trim, ls_Notifica, ls_return)

                            Nva_DocSap = ls_result.RUECK
                            Nva_ConSap = ls_result.RMZHL
                            Err = ls_return.ZTYPE
                            Mns = ls_return.ZMESSAGE

                        ElseIf SessionUser._sAlias.Trim = "ATLAS" Then


                            '--- Variables WS Desarrollo
                            Dim lo_wsamancomxr As New PTConsumos.ZPPMXF001Service
                            Dim ls_returnr As New PTConsumos.ZBAPIRET2
                            Dim ls_Notifica As New PTConsumos.ZEPP002
                            Dim ls_result As New PTConsumos._ISDFPS_TCUPS_KEY

                            ls_Notifica.ZBUDAT = Nva_FecPesaje
                            ls_Notifica.ZCONSUME_REC = 0.0
                            ls_Notifica.ZENTRY_QNT = 0
                            ls_Notifica.ZISM01 = 0.0
                            ls_Notifica.ZISM02 = 0.0
                            ls_Notifica.ZISM03 = 0.0
                            ls_Notifica.ZISMNGEH1 = ""
                            ls_Notifica.ZISMNGEH2 = ""
                            ls_Notifica.ZISMNGEH3 = ""
                            ls_Notifica.ZMATNR_REC = ""
                            ls_Notifica.ZORDERID = Nva_OrdProd.Trim
                            ls_Notifica.ZRECOVERED = Nva_PesoNeto
                            ls_Notifica.ZVIRGIN = 0

                            CadenaTexto = SessionUser._sAlias.Trim + folio.Trim

                            lo_wsamancomxr.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
                            ls_result = lo_wsamancomxr.ZPPMXF001(CadenaTexto.Trim, Lt_Compuestos.Trim, ls_Notifica, ls_returnr)

                            Nva_DocSap = ls_result.RUECK
                            Nva_ConSap = ls_result.RMZHL
                            Err = ls_returnr.ZTYPE
                            Mns = ls_returnr.ZMESSAGE
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
                    Q = "UPDATE " & SessionUser._sCentro.Trim & "_PesoScrap SET Documento_SAP = '" & Nva_DocSap & "', "
                    Q = Q & "Consecutivo_SAP = '" & Nva_ConSap & "', "
                    Q = Q & "Notifica = '" & reg & "', "
                    Q = Q & "Notificacionmasiva = '" & reg & "' "
                    Q = Q & "WHERE Orden_Produccion = '" & Nva_OrdProd.Trim & "' "
                    Q = Q & "AND Folio = '" & Nva_Folio & "' "
                    Q = Q & "AND Planta = '" & SessionUser._sCentro.Trim & "' "
                    objCmd.CommandText = Q

                    DGNotPerScrap.DataSource = Nothing

                    Try
                        RegistrosActualizados = objCmd.ExecuteNonQuery()
                    Catch ex1 As Exception
                        MsgBox(ex1.Message)
                        Exit Sub
                    End Try

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
            DGNotPerScrap.DataSource = Nothing
            BtnNotif.Enabled = False
            BtnCancel.Enabled = True
        Else
            If Resultado = System.Windows.Forms.DialogResult.No Then
                BtnNotPeriodo.Enabled = True
                Close()
            End If
        End If
    End Sub

    Private Sub BtnConsulta1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta1.Click

        QRY_Grid = ""
        NameTable = ""
        NameTable = "Notif_ODF"
        QRY_Grid = "Select b.orden_produccion,b.Fecha_Pesaje,b.Peso_neto,b.Tramos,b.folio,b.documento_sap,"
        QRY_Grid = QRY_Grid & "b.consecutivo_sap,b.notifica,b.notificacionmasiva "
        QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b, "
        If EXTINY = "1" Then
            QRY_Grid = QRY_Grid & "ProductoTerminadoExtrusion c "
        Else
            QRY_Grid = QRY_Grid & "ProductoTerminadoInyeccion c "
        End If
        QRY_Grid = QRY_Grid & "Where a.orden_produccion = b.orden_produccion "
        QRY_Grid = QRY_Grid & "And a.planta = c.centro "
        QRY_Grid = QRY_Grid & "And a.producto = c.codigo "
        QRY_Grid = QRY_Grid & "And b.notifica in ('0', '4', '5') "
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
            DGNotODF.Columns(2).HeaderText = "Peso Neto"
            DGNotODF.Columns(3).HeaderText = "Tramos"
            DGNotODF.Columns(4).HeaderText = "Folio"
            DGNotODF.Columns(5).HeaderText = "Documento SAP"
            DGNotODF.Columns(6).HeaderText = "Consecutivo SAP"
            DGNotODF.Columns(7).HeaderText = "Status Notificación"
            DGNotODF.Columns(8).HeaderText = "Status Notificación Masiva"

        Else

            MessageBox.Show("No existen registros a Notificar de esta Orden de Producción")
            TxtFec.Text = ""
            TxtEquipo.Text = ""
            TxtProd.Text = ""
            TxtOrdProd.Text = ""
            TxtOrdProd.Focus()

        End If

    End Sub

    Private Sub CBNotif_ODF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBNotif_ODF.CheckedChanged
        If CBNotif_ODF.Checked = True Then
            BtnConsulta1.Enabled = False
            BtnNotif.Enabled = True
        Else
            BtnConsulta1.Enabled = True
            BtnNotif.Enabled = False
        End If
    End Sub

    Private Sub ChBoxNotiMasXOrden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBoxNotiMasXOrden.CheckedChanged
        'Validación de objetos para la notificación Masiva posterior al cierre por Orden de Fabricación
        If ChBoxNotiMasXOrden.Checked = True Then
            BtnNotif.Enabled = True
            BtnConsulta1.Enabled = False
            Label150.Visible = True
            DateTimeNotiMasXOrden.Visible = True
        Else
            BtnNotif.Enabled = False
            BtnConsulta1.Enabled = True
            Label150.Visible = False
            DateTimeNotiMasXOrden.Visible = False
        End If
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
End Class