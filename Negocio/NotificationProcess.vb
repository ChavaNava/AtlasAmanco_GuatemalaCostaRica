Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class NotificationProcess
#Region "Variables Miembro"
    'ValidaPermisos
    Dim Permiso As String = ""
    Dim ctlText As Object
    Dim ctlCombo As Object
    'Identifies_shift_supervisor
    Dim C_Supervisor As String
    'Validates_Overweight
    Dim St_Sobrepeso As String

#End Region

#Region "Enumeraciones"
#End Region

#Region "Constructores"
#End Region

#Region "Clases anidadas"
#End Region

#Region "Métodos"

    Public Sub Identifies_shift_supervisor(ByVal Fecha As String, ByVal Turno As Integer)
        LecturaQry("PA_IdentificarSupervisorTurno '" & SessionUser._sCentro.Trim & "', '" & Fecha & "', " & Turno & " ")
        If (LecturaBD.Read) Then
            C_Supervisor = "" & LecturaBD(0)
        Else
            C_Supervisor = "Supervisor"
        End If
        LecturaBD.Close()
    End Sub

    Public Sub Validates_Overweight(ByVal Causa As String, ByVal frmForm As Form)
        If PorcentajeSobrePeso < (SobrepesoPermitido * -1) Or PorcentajeSobrePeso > SobrepesoPermitido Then
            St_Sobrepeso = "1"
            If Causa.Length = 0 Then
                Mensajes("***  Seleccione una CAUSA de SOBREPESO  *** ", 1)
                On Error Resume Next
                For Each ctlCombo In frmForm.Controls
                    If TypeOf ctlText Is System.Windows.Forms.ComboBox Then
                        If ctlCombo.Name = "CB_Causa" Then
                            ctlCombo.Enabled = True
                            ctlCombo.Text = ""
                            Catalogo_Causas.Combo_Causas(ctlCombo, "", Seccion.Trim, "SP", False)
                            ctlCombo.ListIndex = -1
                        End If
                    End If
                Next ctlCombo
                On Error Resume Next
                For Each ctlText In frmForm.Controls
                    If TypeOf ctlText Is System.Windows.Forms.TextBox Then
                        If ctlText.Name = "CB_Causa" Then
                            ctlText.Enabled = True
                            ctlText.Focus()
                            ctlText.ListIndex = -1
                        End If
                    End If
                Next ctlText
            End If
        End If
    End Sub

    Public Sub Assign_Compound_1()

    End Sub

    Public Sub Assign_Compound_2()

    End Sub

    Public Shared Sub Notifica_PTE(ByVal strHead As String, List As Generic.List(Of String), strFolio As String, TBDocumento As TextBox, _
                                   TBConsecutivo As TextBox, BtnPesar As Button, BtnImp As Button, TBOrd As TextBox, UsrOperador As String)
        Dim Tbl As String()
        Dim Tbl_LM As New Generic.List(Of String)
        Dim SAP_Return As Object
        Dim Doc_Con As String
        Dim Cod_Err As String = ""
        Dim SAP As New Generic_SAP
        Dim reg As String

        Try
            WS_P.Consume_WS(strHead, List, SessionUser._sAmbiente)
            Tbl = WS_P.Tbl_resultado
            SAP_Return = WS_P.Return_SAP
            Err = SAP_Return.ZTYPE
            Mns = SAP_Return.ZMESSAGE
            Doc_Con = SAP_Return.zmessage_v1

            SAP.agregarConsecutivosSAP(Doc_Con)

            If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                LoadingForm.CloseForm()
                reg = "0"
                MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
                InQry = ""
                InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set MsgSAP = '" & Mns.Trim & "' "
                InQry = InQry & " Where Folio = '" & strFolio.Trim & "'"
                InsertQry(InQry)
                Exit Sub
            Else
                If (SAP.DocumentoSAP = "" Or SAP.DocumentoSAP = "NULL" Or SAP.DocumentoSAP = "0000000000") And (SAP.ConsecutivoSAP = "" Or SAP.ConsecutivoSAP = "NULL" Or SAP.ConsecutivoSAP = "00000000") Then
                    reg = "0"
                    LoadingForm.CloseForm()
                    MsgBox("No Notifico a SAP")
                    BtnPesar.Enabled = False
                    BtnImp.Enabled = True
                    TBOrd.Enabled = False
                    SuperAutoSobrepeso = ""
                    Return
                Else
                    reg = "1"
                    TBDocumento.Text = SAP.DocumentoSAP
                    TBConsecutivo.Text = SAP.ConsecutivoSAP
                    LecturaQry("PA_Actualiza_Notificacion_Produccion " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, '" & SAP.DocumentoSAP & "', '" & SAP.ConsecutivoSAP & "', '" & reg & "', '" & Mns & "', '" & strFolio & "' ")
                    'Rotomoldeo.Notificacion(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, strFolio, Mns, SAP.DocumentoSAP, SAP.ConsecutivoSAP, reg, 2)
                    BtnImp.Enabled = True
                    TBOrd.Enabled = False
                    SuperAutoSobrepeso = ""
                    LoadingForm.CloseForm()
                    MensajeBox.Mostrar("La notificación de la Orden '" & TBOrd.Text & "' a sido Exitosa ", "Notificación Exitosa", MensajeBox.TipoMensaje.Good)
                End If
            End If
        Catch ex As Exception
            LoadingForm.CloseForm()
            MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
        End Try
    End Sub

    Public Shared Sub Notifica_RTO(ByVal StrCadenas As String, Fecha_SAP As String, Piezas As String, ODF As String, Peso As String, _
                                   TBDocumento As TextBox, TBConsecutivo As TextBox, BtnPesar As Button, BtnImp As Button, TBOrd As TextBox, _
                                   StrFolio As String)

        Dim reg As String
        Dim Cod_Err As String = ""


        Try
            WS_P.Consume_Old_WS(StrCadenas, "", SessionUser._sAmbiente, Fecha_SAP, Piezas, ODF, Peso)

            Dim Doc_Noti As String = ""
            Dim Con_Noti As String = ""

            If SessionUser._sAmbiente = "D" Then
                Doc_Noti = WS_P.Tbl_resultado_d.RUECK
                Con_Noti = WS_P.Tbl_resultado_d.RMZHL
                Err = WS_P.Return_SAP.ZTYPE
                Mns = WS_P.Return_SAP.ZMESSAGE
            ElseIf SessionUser._sAmbiente = "Q" Then
                Doc_Noti = WS_P.Tbl_resultado_q.RUECK
                Con_Noti = WS_P.Tbl_resultado_q.RMZHL
                Err = WS_P.Return_SAP.ZTYPE
                Mns = WS_P.Return_SAP.ZMESSAGE
            Else
                Doc_Noti = WS_P.Tbl_resultado_p.RUECK
                Con_Noti = WS_P.Tbl_resultado_p.RMZHL
                Err = WS_P.Return_SAP.ZTYPE
                Mns = WS_P.Return_SAP.ZMESSAGE
            End If

            If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                reg = "0"
                MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
                InQry = ""
                InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set MsgSAP = '" & Mns.Trim & "' "
                InQry = InQry & " Where Folio = '" & StrFolio.Trim & "'"
                InsertQry(InQry)
                Exit Sub
            Else
                If (Doc_Noti = "" Or Doc_Noti = "NULL" Or Doc_Noti = "0000000000") And (Con_Noti = "" Or Con_Noti = "NULL" Or Con_Noti = "00000000") Then
                    reg = "0"
                    MsgBox("No Notifico a SAP")
                    BtnPesar.Enabled = False
                    BtnImp.Enabled = True
                    TBOrd.Enabled = False
                    SuperAutoSobrepeso = ""
                    Return
                Else
                    reg = "1"
                    TBDocumento.Text = Doc_Noti
                    TBConsecutivo.Text = Con_Noti
                    Rotomoldeo.Notificacion(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, StrFolio, Mns, Doc_Noti, Con_Noti, reg, 2)
                    BtnImp.Enabled = True
                    TBOrd.Enabled = False
                    SuperAutoSobrepeso = ""
                    MensajeBox.Mostrar("La notificación de la Orden '" & ODF.Trim & "' a sido Exitosa ", "Notificación Exitosa", MensajeBox.TipoMensaje.Good)
                End If
            End If
        Catch ex As Exception
            MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
        End Try
    End Sub

    Public Shared Sub NotificaMasivaScrap(ByVal strHead As String, List As Generic.List(Of String), FolioNotificacion As String)
        Dim Tbl As String()
        Dim Tbl_LM As New Generic.List(Of String)
        Dim SAP_Return As Object
        Dim Doc_Con As String
        Dim Cod_Err As String = ""
        Dim SAP As New Generic_SAP
        Dim reg As String
        Try
            WS_P.Consume_WS(strHead, List, SessionUser._sAmbiente)
            Tbl = WS_P.Tbl_resultado
            SAP_Return = WS_P.Return_SAP
            Err = SAP_Return.ZTYPE
            Mns = SAP_Return.ZMESSAGE
            Doc_Con = SAP_Return.zmessage_v1
            SAP.agregarConsecutivosSAP(Doc_Con)

            If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                reg = "0"
                MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
                InQry = ""
                InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set MsgSAP = '" & Mns.Trim & "' "
                InQry = InQry & " Where Folio = '" & FolioNotificacion.Trim & "'"
                InsertQry(InQry)
                Exit Sub
            Else
                If (SAP.DocumentoSAP = "" Or SAP.DocumentoSAP = "NULL" Or SAP.DocumentoSAP = "0000000000") And (SAP.ConsecutivoSAP = "" Or SAP.ConsecutivoSAP = "NULL" Or SAP.ConsecutivoSAP = "00000000") Then
                    reg = "0"
                    LecturaQry("PA_Actualiza_Notificacion_Scrap " & SessionUser._sCentro.Trim & "_PesoScrap, '" & SAP.DocumentoSAP & "', '" & SAP.ConsecutivoSAP & "', '" & reg & "', '" & Mns.Trim & "',  '" & FolioNotificacion.Trim & "' ")
                Else
                    reg = "1"
                    LecturaQry("PA_Actualiza_Notificacion_Scrap " & SessionUser._sCentro.Trim & "_PesoScrap, '" & SAP.DocumentoSAP & "', '" & SAP.ConsecutivoSAP & "', '" & reg & "', '" & Mns.Trim & "',  '" & FolioNotificacion.Trim & "' ")
                End If
            End If
        Catch ex As Exception
            MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
        End Try
    End Sub

    Public Shared Sub Notifica_SCE(ByVal strHead As String, List As Generic.List(Of String), strFolio As String, TBDocumento As TextBox, _
                                   TBConsecutivo As TextBox, BtnPesar As Button, BtnImp As Button, TBOrd As TextBox, UsrOperador As String)
        Dim Tbl As String()
        Dim Tbl_LM As New Generic.List(Of String)
        Dim SAP_Return As Object
        Dim Doc_Con As String
        Dim Cod_Err As String = ""
        Dim SAP As New Generic_SAP
        Dim reg As String
        Try
            WS_P.Consume_WS(strHead, List, SessionUser._sAmbiente)
            Tbl = WS_P.Tbl_resultado
            SAP_Return = WS_P.Return_SAP
            Err = SAP_Return.ZTYPE
            Mns = SAP_Return.ZMESSAGE
            Doc_Con = SAP_Return.zmessage_v1
            SAP.agregarConsecutivosSAP(Doc_Con)

            If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                LoadingForm.CloseForm()
                reg = "0"
                MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
                InQry = ""
                InQry = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set MsgSAP = '" & Mns.Trim & "' "
                InQry = InQry & " Where Folio = '" & strFolio.Trim & "'"
                InsertQry(InQry)
                Exit Sub
            Else
                If (SAP.DocumentoSAP = "" Or SAP.DocumentoSAP = "NULL" Or SAP.DocumentoSAP = "0000000000") And (SAP.ConsecutivoSAP = "" Or SAP.ConsecutivoSAP = "NULL" Or SAP.ConsecutivoSAP = "00000000") Then
                    LoadingForm.CloseForm()
                    reg = "0"
                    MsgBox("No Notifico a SAP")
                    BtnPesar.Enabled = False
                    BtnImp.Enabled = True
                    TBOrd.Enabled = False
                    SuperAutoSobrepeso = ""
                    Return
                Else
                    reg = "1"
                    TBDocumento.Text = SAP.DocumentoSAP
                    TBConsecutivo.Text = SAP.ConsecutivoSAP
                    LecturaQry("PA_Actualiza_Notificacion_Scrap " & SessionUser._sCentro.Trim & "_PesoScrap, '" & SAP.DocumentoSAP & "', '" & SAP.ConsecutivoSAP & "', '" & reg & "', '" & Mns.Trim & "',  '" & strFolio.Trim & "' ")
                    BtnImp.Enabled = True
                    TBOrd.Enabled = False
                    SuperAutoSobrepeso = ""
                    LoadingForm.CloseForm()
                    MensajeBox.Mostrar("La notificación de la Orden '" & TBOrd.Text & "' a sido Exitosa ", "Notificación Exitosa", MensajeBox.TipoMensaje.Good)
                End If
            End If
        Catch ex As Exception
            MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
        End Try
    End Sub

    Public Shared Sub Verifica_Notificacion(ByVal strHead As String, List As Generic.List(Of String), strFolio As String, UsrOperador As String, strOrden As String)
        Dim Tbl As String()
        Dim Tbl_LM As New Generic.List(Of String)
        Dim SAP_Return As Object
        Dim Doc_Con As String
        Dim Cod_Err As String = ""
        Dim SAP As New Generic_SAP

        Try
            WS_P.Consume_WS(strHead, List, SessionUser._sAmbiente)
            Tbl = WS_P.Tbl_resultado
            SAP_Return = WS_P.Return_SAP
            Err = SAP_Return.ZTYPE
            Mns = SAP_Return.ZMESSAGE
            Doc_Con = SAP_Return.zmessage_v1
            SAP.agregarConsecutivosSAP(Doc_Con)
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Function Identifica_Reprocesado(Comp_Consumo As String) As String
        Dim Reprocesado_Genenerado As String = ""
        Dim Rep_Clase As String = ""

        LecturaQry("PA_Reprocesados_Generados '" & SessionUser._sCentro & "', '" & Comp_Consumo.Trim & "', '" & EXTINY & "' ")
        If (LecturaBD.Read) Then
            Rep_Clase = LecturaBD(3)
            If Rep_Clase = "6" Then
                Reprocesado_Genenerado = LecturaBD(2)
            Else
                Reprocesado_Genenerado = " "
            End If
        End If
        LecturaBD.Close()
        Return Reprocesado_Genenerado
    End Function

    Public Shared Function Identifica_Compuesto_Original(Codigo_PT As String) As String
        Dim Count As Integer = 0
        Dim Comp_Orig As String = ""
        Dim Repr_Orig As String = ""
        LecturaQry("PA_Identifica_Compuesto_BOM '" & SessionUser._sCentro & "', '" & Codigo_PT & "' ")
        If (LecturaBD.Read) Then
            Count = Count + 1
            Comp_Orig = LecturaBD(0)
            Repr_Orig = LecturaBD(2)
        Else
            MensajeBox.Mostrar("Este producto no tiene asignado compuesto virgen para su consumo", "Aviso", MensajeBox.TipoMensaje.Information)
        End If
        LecturaBD.Close()
        Return Comp_Orig + "|" + Repr_Orig
    End Function

    Public Shared Function Verifica_Producto(ByVal Codigo_PT As String) As String
        Dim Count As Integer = 0
        Dim Tipo As String = ""
        LecturaQry("PA_Valida_Producto_Ext_Iny '" & Codigo_PT & "', '" & SessionUser._sCentro.Trim & "' ")
        If (LecturaBD.Read) Then
            Count = Count + 1
            Tipo = LecturaBD(0)
        End If
        LecturaBD.Close()
        Return Tipo
    End Function

    Public Shared Sub Reversa(ByVal strHead As String, List As Generic.List(Of String), UsrOperador As String)
        Dim Tbl As String()
        Dim Tbl_LM As New Generic.List(Of String)
        Dim SAP_Return As Object
        Dim Doc_Con As String
        Dim Cod_Err As String = ""
        Dim SAP As New Generic_SAP
        Dim reg As String

        Try
            WS_P.Consume_WS(strHead, List, SessionUser._sAmbiente)
            Tbl = WS_P.Tbl_resultado
            SAP_Return = WS_P.Return_SAP
            Err = SAP_Return.ZTYPE
            Mns = SAP_Return.ZMESSAGE
            Doc_Con = SAP_Return.zmessage_v1

            SAP.agregarConsecutivosSAP(Doc_Con)

            If Err = "E" Or Err = "505" Or Err = "S" Or Err = "W" Then
                reg = "0"
                MessageBox.Show(Mns + " " + Cod_Err + " ", "Error en SAP Notifique al Supervisor")
                InQry = ""
                InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado Set MsgSAP = '" & Mns.Trim & "' "
                InQry = InQry & " Where Folio = '" & StrFolio.Trim & "'"
                InsertQry(InQry)
                Exit Sub
            Else
                If (SAP.DocumentoSAP = "" Or SAP.DocumentoSAP = "NULL" Or SAP.DocumentoSAP = "0000000000") And (SAP.ConsecutivoSAP = "" Or SAP.ConsecutivoSAP = "NULL" Or SAP.ConsecutivoSAP = "00000000") Then
                    reg = "0"
                    MsgBox("No Notifico a SAP")
                    SuperAutoSobrepeso = ""
                    Return
                Else
                    reg = "1"
                    LecturaQry("PA_Actualiza_Notificacion_Produccion " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, '" & SAP.DocumentoSAP & "', '" & SAP.ConsecutivoSAP & "', '" & reg & "', '" & Mns & "', '" & StrFolio.Trim & "' ")
                    SuperAutoSobrepeso = ""
                    'MensajeBox.Mostrar("La notificación de la Orden '" & TBOrd.Text & "' a sido Exitosa ", "Notificación Exitosa", MensajeBox.TipoMensaje.Good)
                End If
            End If
        Catch ex As Exception
            MsgBox("No se realizar notificación a SAP ", MsgBoxStyle.Critical, ex.Message)
        End Try
    End Sub

#End Region

#Region "Propiedades"
    'Identifies_shift_supervisor
    Public Property r_Supervisor() As String
        Get
            Return C_Supervisor
        End Get
        Set(ByVal value As String)
            C_Supervisor = value
        End Set
    End Property
    'ValidaPermisos
    Public Property r_Permiso() As String
        Get
            Return Permiso
        End Get
        Set(ByVal value As String)
            Permiso = value
        End Set
    End Property
#End Region

#Region "Colección"
#End Region

#Region "Campos"
#End Region

#Region "Eventos"
#End Region

End Class
