Imports Utili_Generales
Imports SQL_DATA
Imports SQL_DATA.PublicVariables
Imports System.Drawing

Public Class ProductionOrder
    Public Shared Function Alta_ODF(ByVal ODF As String, Tipo As String, Ambiente As String)
        Dim Alta_Ok As Boolean = 0
        Dim Head As String
        Dim Lista As New Generic.List(Of String)
        Dim Tbl As String()
        Dim SAP_Return As Object
        Dim aryTextFile() As String
        Dim Linea As String
        Dim WSG As New WebServices.WSG
        'Error y mensaje de WS
        Dim Err As String
        Dim Mns As String


        Head = "31" & "|" & ODF.Trim & "|" & "10" & "|" & Tipo
        WSG.Consume_WS(Head, Lista, Ambiente.Trim)
        Tbl = WSG.Tbl_resultado
        SAP_Return = WSG.Return_SAP

        If SAP_Return.ZTYPE = "E" Then
            MensajeBox.Mostrar(SAP_Return.ZMESSAGE, "Error SAP", MensajeBox.TipoMensaje.Critical)
            Return Alta_Ok = 0
            Exit Function
        Else
            For i As Integer = 0 To Tbl.Length - 1
                aryTextFile = Tbl(i).Split("|")
                Linea = aryTextFile(0)
                If Linea = "I" Then
                    New_ODF.nOrden_Produccion = aryTextFile(1)
                    New_ODF.nCentro = aryTextFile(2)
                    New_ODF.nPuesto_Trabajo = aryTextFile(3)
                    New_ODF.nCodigo = aryTextFile(4)
                    New_ODF._nCantidad_Programada_Tramos = aryTextFile(5)
                    New_ODF.nUM = aryTextFile(6)
                    New_ODF.nFecha_Inicio = aryTextFile(7)
                    New_ODF.nFecha_Termino = aryTextFile(8)
                    New_ODF.nOrigen_Informacion = aryTextFile(9)
                    New_ODF.nEstatus = aryTextFile(10)
                    New_ODF.nEstatus_Desc = aryTextFile(11)
                    New_ODF.nFecha_Inicio_Prod = aryTextFile(12)
                    New_ODF.nTipo_Orden = aryTextFile(13)
                    Err = SAP_Return.ZTYPE
                    Mns = SAP_Return.ZMESSAGE


                ElseIf Linea = "H" Then

                End If
            Next
        End If
    End Function
    Public Shared Sub Inserta_ODF_EXT(odf As String, Tipo As String, frmForm As Form, CodOperador As String, Seccion As String, _
                                              Usuario As String, Centro As String, Ambiente As String, Area As String, TB_CodPT As TextBox, _
                                              TB_CodPtDecr As TextBox, TB_PtoTrabajo As TextBox, TB_PesoTeorico As TextBox, _
                                              TB_empaque As TextBox, TB_CodAnillo As TextBox, TB_DAnillo As TextBox, TB_Grpprod As TextBox, _
                                              TB_Grupo As TextBox, TB_SP_Permitido As TextBox, TB_Grpproddesc As TextBox, _
                                              TB_NomPtoTrabajo As TextBox, Version As String)
        Dim Q As String
        Dim Head As String
        Dim Lista As New Generic.List(Of String)
        Dim Tbl As String()
        Dim SAP_Return As Object
        Dim aryTextFile() As String
        Dim Linea As String
        Dim OrdenProd As String
        Dim NumeroPlanta As String
        Dim Equipo As String
        Dim Producto As String
        Dim CantProgPzs As String
        Dim Unidad As String
        Dim Inicio As String
        Dim Fin As String
        Dim Origen As String
        Dim Status1 As String
        Dim Desc_Status As String
        Dim fecini As String
        Dim Tipo_Ord As String
        Dim Grupo As String
        'Error y mensaje de WS
        Dim Err As String
        Dim Mns As String
        'Variables publicas para mensajes
        Dim Message As String = ""
        Dim Caption As String = ""
        Dim Result As DialogResult
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim Botones As MessageBoxButtons = MessageBoxButtons.OK
        Dim WSG As New WebServices.WSG

        Head = "31" & "|" & odf.Trim & "|" & "10" & "|" & Tipo
        WSG.Consume_WS(Head, Lista, Ambiente.Trim)
        'WS_P.Consume_WS(SessionUser._sAlias.Trim, Head, Lista, strAmbiente.Trim)
        Tbl = WSG.Tbl_resultado
        SAP_Return = WSG.Return_SAP
        ' ---------------------------------------------------------------------------------
        If SAP_Return.ZTYPE = "E" Then
            LoadingForm.CloseForm()
            MessageBox.Show(SAP_Return.ZMESSAGE, "Error SAP Notifique al Supervisor")
            On Error Resume Next
            For Each ctlText In frmForm.Controls
                If TypeOf ctlText Is System.Windows.Forms.TextBox Then
                    If ctlText.Name = "TOrden" Then
                        ctlText.Text = ""
                        ctlText.Focus()
                        ctlText.ListIndex = -1
                    End If
                End If
            Next ctlText
            Return
        End If
        ' ---------------------------------------------------------------------------------
        For i As Integer = 0 To Tbl.Length - 1
            aryTextFile = Tbl(i).Split("|")
            Linea = aryTextFile(0)
            If Linea = "I" Then
                OrdenProd = aryTextFile(1)
                NumeroPlanta = aryTextFile(2)
                Equipo = aryTextFile(3)
                Producto = aryTextFile(4)
                CantProgPzs = aryTextFile(5)
                Unidad = aryTextFile(6)
                Inicio = aryTextFile(7)
                Fin = aryTextFile(8)
                Origen = aryTextFile(9)
                Status1 = aryTextFile(10)
                Desc_Status = aryTextFile(11)
                fecini = aryTextFile(12)
                Tipo_Ord = aryTextFile(13)
                Err = SAP_Return.ZTYPE
                Mns = SAP_Return.ZMESSAGE
            End If
        Next





        ' ---------------------------------------------------------------------------------
        If Err = "E" Then
            LoadingForm.CloseForm()
            MessageBox.Show(Mns, "Error SAP Notifique al Supervisor")
            On Error Resume Next
            For Each ctlText In frmForm.Controls
                If TypeOf ctlText Is System.Windows.Forms.TextBox Then
                    If ctlText.Name = "TOrden" Then
                        ctlText.Focus()
                        ctlText.ListIndex = -1
                    End If
                End If
            Next ctlText
            Return
        End If
        ' ---------------------------------------------------------------------------------
        Select Case Status1

            Case Is <> "LIB."
                LoadingForm.CloseForm()
                Message = "Orden de Producción no esta liberada"
                Caption = "Orden no liberada"
                Result = MessageBox.Show(Message, Caption, Botones)
                If Result = System.Windows.Forms.DialogResult.OK Then
                    On Error Resume Next
                    For Each ctlText In frmForm.Controls
                        If TypeOf ctlText Is System.Windows.Forms.TextBox Then
                            If ctlText.Name = "TOrden" Then
                                ctlText.Text = ""
                                ctlText.Focus()
                                ctlText.ListIndex = -1
                            End If
                        End If
                    Next ctlText
                    Exit Sub
                End If
            Case Is = "LIB."
                If Not NumeroPlanta.Trim = Centro.Trim Then
                    LoadingForm.CloseForm()
                    Message = "Orden de Producción no pertenece al centro " & Centro.Trim
                    Caption = "Orden de otro centro"
                    Result = MessageBox.Show(Message, Caption, Botones)
                    If Result = System.Windows.Forms.DialogResult.OK Then
                        On Error Resume Next
                        For Each ctlText In frmForm.Controls
                            If TypeOf ctlText Is System.Windows.Forms.TextBox Then
                                If ctlText.Name = "TOrden" Then
                                    ctlText.Text = ""
                                    ctlText.Focus()
                                    ctlText.ListIndex = -1
                                End If
                            End If
                        Next ctlText
                        Exit Sub
                    End If
                Else
                    ' --------------------------------------------------------------------------------------------
                    'Selecciona el grupo al que pertenece el material
                    Q = ""
                    Q = "SELECT GrupMaterial, Sobrepeso FROM CAT_ProductoTerminado "
                    Q = Q & "WHERE Centro = " & "'" & Centro.Trim & "' "
                    Q = Q & "AND Codigo = '" & Producto.Trim & "'"
                    LecturaQry(Q)
                    If LecturaBD.Read() Then
                        Grupo = LecturaBD(0)
                        'Verifica si el producto es de inyección o extrusión
                        Dim Tipo_Prod As String = Verifica_Producto(Producto.Trim, Centro, Usuario)
                        If Seccion = "1" And Tipo_Prod = "2" Then
                            LoadingForm.CloseForm()
                            MensajeBox.Mostrar("El producto no es de Extrusión, no se dara de Alta la Orden ", "Error", MensajeBox.TipoMensaje.Information)
                            Exit Sub
                        ElseIf Seccion = "2" And Tipo_Prod = "1" Then
                            LoadingForm.CloseForm()
                            MensajeBox.Mostrar("El producto no es de Inyección, no se dara de Alta la Orden", "Error", MensajeBox.TipoMensaje.Information)
                            Exit Sub
                        End If
                    Else
                        LoadingForm.CloseForm()
                        MensajeBox.Mostrar("El producton '" & Producto.Trim & "' no esta dado de Alta en A-tlas informe al Administrador ", "Campo Vacio", MensajeBox.TipoMensaje.Information)
                        Exit Sub
                    End If
                    ' --------------------------------------------------------------------------------------------
                    'Insert la ifnormacion de la orden de produccion en la tabla Ordens de Produccion de A-tlas
                    Dim Fec_Act As String = DateTime.Now.ToString("yyyy/MM/dd")
                    Dim Fec_reg As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim Hra_Act As String = DateTime.Now.ToString("HH:MM:ss")
                    LecturaQry("PA_Inserta_Orden_Fabricacion '" & OrdenProd.Trim & "','" & Centro & "','" & Equipo & "','" _
                               & Producto & "','" & CantProgPzs & "','" & Inicio & "','" & Fin & "','" & Origen & "','" _
                               & CodOperador.Trim & "','" & Fec_Act & "','Ingreso Por SAP','" & Fec_Act & "','" & Hra_Act & "','" _
                               & Usuario.Trim & "','" & Fec_Act & "','" & Hra_Act & "','Usuario Fin','Usuario Reg','" & Fec_reg & "','" _
                               & Hra_Act & "','" & Grupo.Trim & "', '" & Usuario.Trim & "','" & Version.Trim & "'")
                    On Error Resume Next
                    LoadingForm.CloseForm()
                    MensajeBox.Mostrar("La orden a sido dada de alta intente nuevamente ", "Orden de Producción", MensajeBox.TipoMensaje.Information)
                End If
        End Select
    End Sub

    Public Shared Sub Inserta_ODF_INY(odf As String, Tipo As String, frmForm As Form, CodOperador As String, Seccion As String, _
                                          Usuario As String, Centro As String, Ambiente As String, Area As String, TB_CodPT As TextBox, _
                                          TB_CodPtDecr As TextBox, TB_PtoTrabajo As TextBox, TB_Grpprod As TextBox, _
                                          TB_Grupo As TextBox, TB_Grpproddesc As TextBox, TB_NomPtoTrabajo As TextBox)
        Dim Q As String
        Dim Head As String
        Dim Lista As New Generic.List(Of String)
        Dim Tbl As String()
        Dim SAP_Return As Object
        Dim aryTextFile() As String
        Dim Message As String = ""
        Dim Caption As String = ""
        Dim Result As DialogResult
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim Botones As MessageBoxButtons = MessageBoxButtons.OK
        Dim WSG As New WebServices.WSG

        Head = "31" & "|" & odf.Trim & "|" & "10" & "|" & Tipo
        WSG.Consume_WS(Head, Lista, Ambiente.Trim)
        'WS_P.Consume_WS(SessionUser._sAlias.Trim, Head, Lista, strAmbiente.Trim)
        Tbl = WSG.Tbl_resultado
        SAP_Return = WSG.Return_SAP
        ' ---------------------------------------------------------------------------------
        If SAP_Return.ZTYPE = "E" Then
            MessageBox.Show(SAP_Return.ZMESSAGE, "Error SAP Notifique al Supervisor")
            On Error Resume Next
            For Each ctlText In frmForm.Controls
                If TypeOf ctlText Is System.Windows.Forms.TextBox Then
                    If ctlText.Name = "TOrden" Then
                        ctlText.Text = ""
                        ctlText.Focus()
                        ctlText.ListIndex = -1
                    End If
                End If
            Next ctlText
            Return
        End If
        ' ---------------------------------------------------------------------------------
        aryTextFile = Tbl(0).Split("|")
        AltaProductionOrders.OrdenProd = aryTextFile(1)
        AltaProductionOrders.Centro = aryTextFile(2)
        AltaProductionOrders.PuestoTrabajo = aryTextFile(3)
        AltaProductionOrders.IdProducto = aryTextFile(4)
        AltaProductionOrders.PzasProgramadas = aryTextFile(5)
        AltaProductionOrders.UM = aryTextFile(6)
        AltaProductionOrders.FechaInicio = aryTextFile(7)
        AltaProductionOrders.FechaFin = aryTextFile(8)
        AltaProductionOrders.Origen = aryTextFile(9)
        AltaProductionOrders.Status_Orden = aryTextFile(10)
        AltaProductionOrders.Status_Desc = aryTextFile(11)
        AltaProductionOrders.FechaInicioProduccion = aryTextFile(12)
        AltaProductionOrders.Tipo_Orden = aryTextFile(13)
        AltaProductionOrders.Suceso = SAP_Return.ZTYPE
        AltaProductionOrders.Mensaje_Suceso = SAP_Return.ZMESSAGE
        ' ---------------------------------------------------------------------------------
        If AltaProductionOrders._Suceso = "E" Then
            MessageBox.Show(AltaProductionOrders._Mensaje_Suceso, "Error SAP Notifique al Supervisor")
            On Error Resume Next
            For Each ctlText In frmForm.Controls
                If TypeOf ctlText Is System.Windows.Forms.TextBox Then
                    If ctlText.Name = "TOrden" Then
                        ctlText.Focus()
                        ctlText.ListIndex = -1
                    End If
                End If
            Next ctlText
            Return
        End If
        ' ---------------------------------------------------------------------------------
        Select Case AltaProductionOrders._Status_Orden
            Case Is <> "LIB."
                Message = "Orden de Producción no esta liberada"
                Caption = "Orden no liberada"
                Result = MessageBox.Show(Message, Caption, Botones)
                If Result = System.Windows.Forms.DialogResult.OK Then
                    On Error Resume Next
                    For Each ctlText In frmForm.Controls
                        If TypeOf ctlText Is System.Windows.Forms.TextBox Then
                            If ctlText.Name = "TOrden" Then
                                ctlText.Text = ""
                                ctlText.Focus()
                                ctlText.ListIndex = -1
                            End If
                        End If
                    Next ctlText
                    Exit Sub
                End If
            Case Is = "LIB."
                If Not AltaProductionOrders._Centro.Trim = Centro.Trim Then
                    Message = "Orden de Producción no pertenece al centro " & Centro.Trim
                    Caption = "Orden de otro centro"
                    Result = MessageBox.Show(Message, Caption, Botones)
                    If Result = System.Windows.Forms.DialogResult.OK Then
                        On Error Resume Next
                        For Each ctlText In frmForm.Controls
                            If TypeOf ctlText Is System.Windows.Forms.TextBox Then
                                If ctlText.Name = "TOrden" Then
                                    ctlText.Text = ""
                                    ctlText.Focus()
                                    ctlText.ListIndex = -1
                                End If
                            End If
                        Next ctlText
                        Exit Sub
                    End If
                Else
                    ' --------------------------------------------------------------------------------------------
                    'Selecciona el grupo al que pertenece el material
                    Q = ""
                    Q = "SELECT GrupMaterial, Sobrepeso FROM CAT_ProductoTerminado "
                    Q = Q & "WHERE Centro = " & "'" & Centro.Trim & "' "
                    Q = Q & "AND Codigo = '" & AltaProductionOrders._IdProducto.Trim & "'"
                    LecturaQry(Q)
                    If LecturaBD.Read() Then
                        AltaProductionOrders._GrupoProducto = LecturaBD(0)
                        'Verifica si el producto es de inyección o extrusión
                        Dim Tipo_Prod As String = Verifica_Producto(AltaProductionOrders._IdProducto.Trim, Centro, Usuario)
                        If Seccion = "1" And Tipo_Prod = "2" Then
                            MensajeBox.Mostrar("El producto no es de Extrusión, no se dara de Alta la Orden ", "Error", MensajeBox.TipoMensaje.Information)
                            Exit Sub
                        ElseIf Seccion = "2" And Tipo_Prod = "1" Then
                            MensajeBox.Mostrar("El producto no es de Inyección, no se dara de Alta la Orden", "Error", MensajeBox.TipoMensaje.Information)
                            Exit Sub
                        End If
                    Else
                        MensajeBox.Mostrar("El producton '" & AltaProductionOrders._IdProducto.Trim & "' no esta dado de Alta en A-tlas informe al Administrador ", "Campo Vacio", MensajeBox.TipoMensaje.Information)
                        Exit Sub
                    End If
                    ' --------------------------------------------------------------------------------------------
                    'Insert la ifnormacion de la orden de produccion en la tabla Ordens de Produccion de A-tlas
                    Dim Fec_Act As String = DateTime.Now.ToString("yyyy/MM/dd")
                    Dim Fec_reg As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim Hra_Act As String = DateTime.Now.ToString("HH:MM:ss")
                    LecturaQry("PA_Inserta_Orden_Produccion '" & AltaProductionOrders._OrdenProd.Trim & "','" & AltaProductionOrders._Centro & "','" & AltaProductionOrders._PuestoTrabajo & "','" _
                               & AltaProductionOrders._IdProducto & "','" & AltaProductionOrders._PzasProgramadas & "','" & AltaProductionOrders._FechaInicio & "','" & AltaProductionOrders._FechaFin & "','" & AltaProductionOrders._Origen & "','" _
                               & CodOperador.Trim & "','" & Fec_Act & "','Ingreso Por SAP','" & Fec_Act & "','" & Hra_Act & "','" _
                               & Usuario.Trim & "','" & Fec_Act & "','" & Hra_Act & "','Usuario Fin','Usuario Reg','" & Fec_reg & "','" _
                               & Hra_Act & "','" & AltaProductionOrders._GrupoProducto.Trim & "'")
                    On Error Resume Next
                    MensajeBox.Mostrar("La orden a sido dada de alta ", "Orden de Producción", MensajeBox.TipoMensaje.Information)
                    'ProductionOrder.Valida_Existencia_Producto(Usuario.Trim, Producto.Trim, NumeroPlanta.Trim, Area)

                End If
        End Select
    End Sub

    Public Shared Sub Actualiza_Orden_Produccion(ByVal odf As String, Tipo As String, Usuario As String, Centro As String, Ambiente As String)
        Dim Head As String
        Dim Lista As New Generic.List(Of String)
        Dim Tbl As String()
        Dim SAP_Return As Object
        Dim FH_Update As String
        Dim aryTextFile() As String
        Dim OrdenProd As String
        Dim NumeroPlanta As String
        Dim Equipo As String
        Dim Producto As String
        Dim CantProgPzs As String
        Dim Unidad As String
        Dim Inicio As String
        Dim Fin As String
        Dim Origen As String
        Dim Status1 As String
        Dim Desc_Status As String
        Dim fecini As String
        Dim Tipo_Ord As String
        'Error y mensaje de WS
        Dim Err As String
        Dim Mns As String
        Dim WSG As New WebServices.WSG

        Head = "31" & "|" & odf.Trim & "|" & "10" & "|" & Tipo
        WSG.Consume_WS(Head, Lista, Ambiente)
        Tbl = WSG.Tbl_resultado
        SAP_Return = WSG.Return_SAP
        FH_Update = DateTime.Now.ToString("yyyyMMdd hh:mm:ss")
        ' ---------------------------------------------------------------------------------
        If SAP_Return.ztype <> "E" Then
            aryTextFile = Tbl(0).Split("|")
            OrdenProd = aryTextFile(1)
            NumeroPlanta = aryTextFile(2)
            Equipo = aryTextFile(3)
            Producto = aryTextFile(4)
            CantProgPzs = aryTextFile(5)
            Unidad = aryTextFile(6)
            Inicio = aryTextFile(7)
            Fin = aryTextFile(8)
            Origen = aryTextFile(9)
            Status1 = aryTextFile(10)
            Desc_Status = aryTextFile(11)
            fecini = aryTextFile(12)
            Tipo_Ord = aryTextFile(13)
            Err = SAP_Return.ZTYPE
            Mns = SAP_Return.ZMESSAGE
            ' ---------------------------------------------------------------------------------
            LecturaQry("PA_Actualiza_Orden_Produccion  " & Centro & "_OrdenProduccion, '" & OrdenProd.Trim & "' , '" & Equipo.Trim & "', '" & Producto.Trim & "', " & CantProgPzs & ", '" & Usuario.Trim & "', '" & FH_Update & "'")
        End If
    End Sub

    Public Shared Sub ValidaEstatus(ByVal ODF As String, Tipo As String)
        Dim Lista As New Generic.List(Of String)
        Dim Tbl As String()
        Dim SAP_Return As Object
        Dim aryTextFile() As String
        Dim Estatus_Activo As Integer
        Dim WSG As New WebServices.WSG

        OrdenProductionSap.Head = "31" & "|" & ODF.Trim & "|" & "10" & "|" & Tipo
        WSG.Consume_WS(OrdenProductionSap.Head, Lista, SessionUser._sAmbiente)
        Tbl = WSG.Tbl_resultado
        SAP_Return = WSG.Return_SAP
        ' ---------------------------------------------------------------------------------
        If SAP_Return.ztype <> "E" Then
            aryTextFile = Tbl(0).Split("|")
            OrdenProductionSap.Order = aryTextFile(1)
            OrdenProductionSap.Centro = aryTextFile(2)
            OrdenProductionSap.PuestoTrabajo = aryTextFile(3)
            OrdenProductionSap.IdProducto = aryTextFile(4)
            OrdenProductionSap.CantProduccion = aryTextFile(5)
            OrdenProductionSap.Unidad = aryTextFile(6)
            OrdenProductionSap.FI_Produccion = aryTextFile(7)
            OrdenProductionSap.FF_Produccion = aryTextFile(8)
            OrdenProductionSap.Origen = aryTextFile(9)
            OrdenProductionSap.IdStatus = aryTextFile(10)
            OrdenProductionSap.Status = aryTextFile(11)
            OrdenProductionSap.F_Inicio = aryTextFile(12)
            OrdenProductionSap.Type_Order = aryTextFile(13)
            OrdenProductionSap.IdMessage = SAP_Return.ZTYPE
            OrdenProductionSap.Message = SAP_Return.ZMESSAGE

            If OrdenProductionSap._IdStatus = "LIB." Then
                Estatus_Activo = 1
            Else
                Estatus_Activo = 0
            End If

            LecturaQry("PA_Orden_Fabricacion '" & OrdenProductionSap._Order & "', '" & SessionUser._sCentro.Trim & "','','','','','','','','" & Estatus_Activo & "','','','','','','','','','','','','','','','','','','','" & OrdenProductionSap._IdStatus & "','','','','','',7")
        Else
            aryTextFile = Tbl(0).Split("|")
            OrdenProductionSap.Order = aryTextFile(1)
            OrdenProductionSap.Centro = aryTextFile(2)
            OrdenProductionSap.PuestoTrabajo = aryTextFile(3)
            OrdenProductionSap.IdProducto = aryTextFile(4)
            OrdenProductionSap.CantProduccion = aryTextFile(5)
            OrdenProductionSap.Unidad = aryTextFile(6)
            OrdenProductionSap.FI_Produccion = aryTextFile(7)
            OrdenProductionSap.FF_Produccion = aryTextFile(8)
            OrdenProductionSap.Origen = aryTextFile(9)
            OrdenProductionSap.IdStatus = aryTextFile(10)
            OrdenProductionSap.Status = aryTextFile(11)
            OrdenProductionSap.F_Inicio = aryTextFile(12)
            OrdenProductionSap.Type_Order = aryTextFile(13)
            OrdenProductionSap.IdMessage = SAP_Return.ZTYPE
            OrdenProductionSap.Message = SAP_Return.ZMESSAGE

            If OrdenProductionSap._IdStatus = "ABIE" Then
                Estatus_Activo = 1
            Else
                Estatus_Activo = 0
            End If

            LecturaQry("PA_Orden_Fabricacion '" & OrdenProductionSap._Order & "', '" & SessionUser._sCentro.Trim & "','','','','','','','','" & Estatus_Activo & "','','','','','','','','','','','','','','','','','','','" & OrdenProductionSap._IdStatus & "','','','','','',7")
        End If
    End Sub


    Public Shared Function Verifica_Producto(ByVal Codigo_PT As String, Centro As String, Usuario As String) As String
        Dim Count As Integer = 0
        Dim Tipo As String = ""
        LecturaQry("PA_Valida_Producto_Ext_Iny '" & Codigo_PT & "', '" & Centro.Trim & "' ")
        If (LecturaBD.Read) Then
            Count = Count + 1
            Tipo = LecturaBD(0)
        End If
        LecturaBD.Close()
        Return Tipo
    End Function

    Public Shared Sub Act_Ins_ProductionOrder(ByVal odf As String, Tipo As String)
        'Verifica que exista la orden en la DB de A-tlas
        LecturaQry("PA_Check_Existence_Production_Order '" & odf.Trim & "', '" & SessionUser._sCentro.Trim & "' ")
        If (LecturaBD.Read) Then
            Actualiza_Orden_Produccion(odf, Tipo, SessionUser._sAlias, SessionUser._sCentro.Trim, SessionUser._sAmbiente)
        Else
            Actualiza_Orden_Produccion(odf, Tipo, SessionUser._sAlias, SessionUser._sCentro.Trim, SessionUser._sAmbiente)
        End If
        LecturaBD.Close()
    End Sub

    Public Shared Function ODF(ByVal Usuario As String, Orden As String, Opcion As String)
        Dim Existe As Boolean = 0
        Dim Contador As Integer = 0

        LecturaQry("PA_Orden_Fabricacion '" & Orden.Trim & "', '" & SessionUser._sCentro & "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','" & Opcion.Trim & "'")

        If Opcion = "1" Then
            If (LecturaBD.Read) Then
                Existe = LecturaBD(0)
            End If
            LecturaBD.Close()
        End If

        If Opcion = "2" Then
            If (LecturaBD.Read) Then
                Contador = Contador + 1
                Read_ODF.rGrpProd = LecturaBD(0)
                Read_ODF.rDescProd = LecturaBD(1)
                Read_ODF.rPesoTeorico = LecturaBD(2)
                Read_ODF.rEstatus = LecturaBD(3)
                Read_ODF.rCodigo = LecturaBD(4)
                Read_ODF.rCantProgramada = LecturaBD(5)
                Read_ODF.rPuestoTrabajo = LecturaBD(6)
                Read_ODF.rGrupMaterial = LecturaBD(7)
                Read_ODF.rSobrePeso = LecturaBD(8)
                Read_ODF.rConCombinado = LecturaBD(9)
                Read_ODF.rPesoAcc = LecturaBD(10)
                Read_ODF.rPesoEmb = LecturaBD(11)
                Read_ODF.rCEmpaque = LecturaBD(12)
                Read_ODF.rDEmpaque = LecturaBD(13)
                Read_ODF.rPeso = LecturaBD(14)
                Read_ODF.rDescGrupo = LecturaBD(15)
                Read_ODF.rDescPtoTrabajo = LecturaBD(16)
            End If
            Existe = Contador
            LecturaBD.Close()
        End If
        Return Existe
    End Function

    Public Shared Function Valida_PT(ByVal Usuario As String, Codigo As String, Area As String, Opcion As String)
        Dim PT_OK As Boolean = 0
        LecturaQry("PA_PT '" & SessionUser._sCentro & "', '" & Codigo.Trim & "','','','','','','','','','','','','','','','','','','','" & Area.Trim & "','','','','','','','','','','','','','','','','" & Opcion.Trim & "'")
        If Opcion = "1" Then
            If (LecturaBD.Read) Then
                PT_OK = LecturaBD(0)
            End If
            LecturaBD.Close()
        End If
        Return PT_OK
    End Function

    Public Shared Function Valida_Work_Center(ByVal Usuario As String, Equipo As String, Opcion As String)
        Dim WC_OK As Boolean = 0
        LecturaQry("PA_PuestoTrabajo '" & SessionUser._sCentro & "','" & Equipo.Trim & "','','','','','','','','','','','','','','" & Opcion.Trim & "'")
        If Opcion = "1" Then
            If (LecturaBD.Read) Then
                WC_OK = LecturaBD(0)
            End If
            LecturaBD.Close()
        End If
        Return WC_OK
    End Function

    Public Shared Function Compuesto_Bom(ByVal Usuario As String, Producto As String, Opcion As String)
        Dim Bom_Ok As Boolean = 0
        LecturaQry("PA_Compuesto_BOM '" & SessionUser._sCentro & "','" & Producto.Trim & "','','','','','','','','','','','','','','','','" & Opcion.Trim & "'")
        If Opcion = "1" Then
            If (LecturaBD.Read) Then
                Bom_Ok = LecturaBD(0)
            End If
            LecturaBD.Close()
        End If
        Return Bom_Ok
    End Function

    Public Shared Function Existe(ByVal Orden As String, Seccion As String) As Boolean
        'Verfica que la orden este registrada en la DB de Atlas
        Try
            LecturaQry("PA_Check_Existence_Production_Order '" & Orden.Trim & "', '" & SessionUser._sCentro.Trim & "' ")
            If (LecturaBD.Read) Then
                OrdenProduccionExiste.Orden = LecturaBD(0)
                OrdenProduccionExiste.IdProducto = LecturaBD(1)
                OrdenProduccionExiste.Estatus = LecturaBD(2)
                OrdenProduccionExiste.PuestoTrabajo = LecturaBD(3)
                OrdenProduccionExiste.Producto = LecturaBD(4)
                OrdenProduccionExiste.IdTipo = LecturaBD(5)
                OrdenProduccionExiste.OrigenInformacion = LecturaBD(6)
                Return True
            Else
                Return False
            End If
            LecturaBD.Close()
        Catch ex As Exception
            LoadingForm.CloseForm()
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
        End Try
    End Function

    Public Shared Function ValExistencia()
        Dim Count As Integer = 0

        LecturaQry("PA_Verifica_ODF '" & ValidaODF._rODF & "', '" & SessionUser._sCentro & "' ")
        If (LecturaBD.Read) Then
            Count = Count + 1
            ValidaODF.rODF = "" & LecturaBD(0)
            ValidaODF.rIdProducto = "" & LecturaBD(1)
            ValidaODF.rProducto = "" & LecturaBD(2)
            ValidaODF.rEstatus = "" & LecturaBD(3)
            ValidaODF.rIdEquipo = "" & LecturaBD(4)
            ValidaODF.rEquipo = "" & LecturaBD(5)
            ValidaODF.rIdGrpProd = "" & LecturaBD(6)
            ValidaODF.rGrpProd = "" & LecturaBD(7)
            ValidaODF.rGrupoMat = "" & LecturaBD(8)
            ValidaODF.rPesoTeorico = "" & LecturaBD(9)
            ValidaODF.rSPPermitido = "" & LecturaBD(10)
        End If
        LecturaBD.Close()
        Return Count
    End Function

    Public Shared Function ValProducto(ByVal Area As String)
        Dim Count As Integer = 0
        Try
            LecturaQry("PA_Check_Existence_Product '" & ValidaODF._rIdProducto & "', '" & SessionUser._sCentro & "', '" & Area & "' ")
            If (LecturaBD.Read) Then
                Count = Count + 1
            End If
            LecturaBD.Close()
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Campo Vacio", MensajeBox.TipoMensaje.Critical)
        End Try
        Return Count
    End Function

    Public Shared Function ValEquipo()
        Dim Count As Integer = 0
        Try
            LecturaQry("PA_PuestoTrabajo '" & SessionUser._sCentro & "','" & ValidaODF._rIdEquipo & "','','','','','','','','','','','','','',1")
            If (LecturaBD.Read) Then
                Count = Count + 1
            End If
            LecturaBD.Close()
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Campo Vacio", MensajeBox.TipoMensaje.Critical)
        End Try
        Return Count
    End Function

    Public Shared Function Existencia_Producto(ByVal Area As String) As Boolean
        Try
            LecturaQry("PA_Check_Existence_Product '" & OrdenProduccionExiste._IdProducto.Trim & "', '" & SessionUser._sCentro.Trim & "', '" & Area & "' ")
            If (LecturaBD.Read) Then
                Existencia_Producto = True
            Else
                Existencia_Producto = False
            End If
            LecturaBD.Close()
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Campo Vacio", MensajeBox.TipoMensaje.Critical)
        End Try
    End Function

    Public Shared Sub Read_Production_Order_Ext(ByVal Orden As String, Frm As Form, TB_CodPT As TextBox, TB_CodPtDecr As TextBox, _
                                                TB_PtoTrabajo As TextBox, TB_PesoTeorico As TextBox, TB_empaque As TextBox, _
                                                TB_CodAnillo As TextBox, TB_DAnillo As TextBox, TB_Grpprod As TextBox, TB_Grupo As TextBox, _
                                                TB_SP_Permitido As TextBox, TB_Grpproddesc As TextBox, TB_NomPtoTrabajo As TextBox)

        Dim GrpProd As String = ""
        Dim Descripcion As String = ""
        Dim StatusOrden As String = ""
        Dim CodigoProducto As String = ""
        Dim EqpBasico As String = ""
        Dim grpMaterial As String = ""
        Dim StatusConsumo As String = ""
        Dim CodEmp As String = ""
        Dim DesEmp As String = ""
        Dim DescGrupo As String = ""
        Dim DesEqpBasico As String = ""
        Dim Tramos As Decimal = 0
        Dim PesoTeorico As Decimal = 0
        Dim sobrePESO As Decimal = 0
        Dim PesoAcc As Decimal = 0
        Dim PesoEmb As Decimal = 0
        Dim PesoEmp As Decimal = 0

        LecturaQry("PA_Read_Production_Order '" & Orden.Trim & "', '" & SessionUser._sCentro.Trim & "' ")
        Dim Count As Integer = 0
        If (LecturaBD.Read) Then
            Count = Count + 1
            GrpProd = "" & LecturaBD(0)
            Descripcion = "" & LecturaBD(1)
            PesoTeorico = "" & LecturaBD(2)
            StatusOrden = "" & LecturaBD(3)
            CodigoProducto = "" & LecturaBD(4)
            Tramos = "" & LecturaBD(5)
            EqpBasico = "" & LecturaBD(6)
            grpMaterial = "" & LecturaBD(7)
            sobrePESO = "" & LecturaBD(8)
            StatusConsumo = "" & LecturaBD(9)
            PesoAcc = "" & LecturaBD(10)
            PesoEmb = "" & LecturaBD(11)
            CodEmp = "" & LecturaBD(12)
            DesEmp = "" & LecturaBD(13)
            PesoEmp = "" & LecturaBD(14)
            DescGrupo = "" & LecturaBD(15)
            DesEqpBasico = "" & LecturaBD(16)
        End If
        LecturaBD.Close()
        'Se asigna valor a TextBox
        TB_CodPT.Text = CodigoProducto               'Código PT
        TB_CodPtDecr.Text = Descripcion              'Descripción del PT   
        TB_PtoTrabajo.Text = EqpBasico               'EqpBasico.Trim  'Puesto de Trabajo
        TB_PesoTeorico.Text = PesoTeorico            'Peso Teorico
        TB_empaque.Text = PesoEmp                    'Peso Unitario del Empaque
        TB_CodAnillo.Text = CodEmp                   'CodigoEmpaque
        TB_DAnillo.Text = DesEmp                     'Descripción Empaque
        TB_Grpprod.Text = GrpProd
        TB_Grupo.Text = grpMaterial                  'Codigo Grupo Material
        TB_SP_Permitido.Text = sobrePESO             'Sobre Peso Permitido
        TB_Grpproddesc.Text = DescGrupo              'Descricpion Grupo
        TB_NomPtoTrabajo.Text = DesEqpBasico         'Descripcion Puesto de Trabajo
        'Valida si existe compuesto asignado a este producto
        Valida_Existencia_Compuesto_BOM(SessionUser._sAlias, SessionUser._sCentro, CodigoProducto.Trim, Frm)
    End Sub

    Public Shared Sub Read_Production_Order_Iny(ByVal Usuario As String, Orden As String, Centro As String, Frm As Form, _
                                         TB_CodPT As TextBox, TB_CodPtDecr As TextBox, TB_PtoTrabajo As TextBox, TB_Grpprod As TextBox, _
                                         TB_Grupo As TextBox, TB_Grpproddesc As TextBox, TB_NomPtoTrabajo As TextBox)

        Dim GrpProd As String = ""
        Dim Descripcion As String = ""
        Dim StatusOrden As String = ""
        Dim CodigoProducto As String = ""
        Dim EqpBasico As String = ""
        Dim grpMaterial As String = ""
        Dim StatusConsumo As String = ""
        Dim CodEmp As String = ""
        Dim DesEmp As String = ""
        Dim DescGrupo As String = ""
        Dim DesEqpBasico As String = ""
        Dim Tramos As Decimal = 0
        Dim PesoTeorico As Decimal = 0
        Dim sobrePESO As Decimal = 0
        Dim PesoAcc As Decimal = 0
        Dim PesoEmb As Decimal = 0
        Dim PesoEmp As Decimal = 0

        LecturaQry("PA_Read_Production_Order '" & Orden.Trim & "', '" & Centro.Trim & "' ")
        Dim Count As Integer = 0
        If (LecturaBD.Read) Then
            Count = Count + 1
            GrpProd = "" & LecturaBD(0)
            Descripcion = "" & LecturaBD(1)
            PesoTeorico = "" & LecturaBD(2)
            StatusOrden = "" & LecturaBD(3)
            CodigoProducto = "" & LecturaBD(4)
            Tramos = "" & LecturaBD(5)
            EqpBasico = "" & LecturaBD(6)
            grpMaterial = "" & LecturaBD(7)
            sobrePESO = "" & LecturaBD(8)
            StatusConsumo = "" & LecturaBD(9)
            PesoAcc = "" & LecturaBD(10)
            PesoEmb = "" & LecturaBD(11)
            CodEmp = "" & LecturaBD(12)
            DesEmp = "" & LecturaBD(13)
            PesoEmp = "" & LecturaBD(14)
            DescGrupo = "" & LecturaBD(15)
            DesEqpBasico = "" & LecturaBD(16)
        End If
        LecturaBD.Close()
        'Se asigna valor a TextBox
        TB_CodPT.Text = CodigoProducto               'Código PT
        TB_CodPtDecr.Text = Descripcion              'Descripción del PT   
        TB_PtoTrabajo.Text = EqpBasico               'EqpBasico.Trim  'Puesto de Trabajo
        TB_Grpprod.Text = GrpProd
        TB_Grupo.Text = grpMaterial                  'Codigo Grupo Material
        TB_Grpproddesc.Text = DescGrupo              'Descricpion Grupo
        TB_NomPtoTrabajo.Text = DesEqpBasico         'Descripcion Puesto de Trabajo
        'Valida si existe compuesto asignado a este producto
        Valida_Existencia_Compuesto_BOM(Usuario, Centro, CodigoProducto.Trim, Frm)
    End Sub

    Public Shared Sub CalCant(ByVal Usuario As String, Orden As String, TB_CantProgra As TextBox, TB_CantEntre As TextBox, TB_CantEnproce As TextBox, _
                              TBC_CantPendiente As TextBox, Centro As String)
        Dim xTCantProgra As Decimal = 0
        Dim xTCantEntre As Decimal = 0
        Dim xTCantEnproce As Decimal = 0
        Dim xTCantpendi As Decimal = 0
        ' ---------------------------------------------------------------------------------
        Try
            LecturaQry("PA_Calcula_Cantidades '" & Centro & "',  '" & Orden.Trim & "', '3' ")
            If (LecturaBD.Read) Then
                xTCantProgra = LecturaBD(1)
                xTCantEntre = LecturaBD(2)
                xTCantEnproce = LecturaBD(3)
                xTCantpendi = LecturaBD(4)
                TB_CantProgra.Text = Format(xTCantProgra, "###,##0.00")
                TB_CantEntre.Text = Format(xTCantEntre, "###,##0.00")
                TB_CantEnproce.Text = Format(xTCantEnproce, "##,###0.00")
                TBC_CantPendiente.Text = Format(xTCantpendi, "##,###0.00")
            Else
                TB_CantProgra.Text = "0"
                TB_CantEntre.Text = "0"
                TB_CantEnproce.Text = "0"
                TBC_CantPendiente.Text = "0"
            End If
            LecturaBD.Close()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub CalCantExt(ByVal Orden As String, TB_CantProgra As TextBox, TB_CantEntre As TextBox, TB_CantEnproce As TextBox, _
                                TBC_CantPendiente As TextBox, Area As String)
        ' ---------------------------------------------------------------------------------
        Try
            LecturaQry("PA_Calcula_Cantidades_3 '" & SessionUser._sCentro.Trim & "',  '" & Orden.Trim & "',  '" & Area.Trim & "' ")
            If (LecturaBD.Read) Then
                xTCantProgra = LecturaBD(1)
                xTCantEntre = LecturaBD(2)
                xTCantEnproce = LecturaBD(3)
                xTCantpendi = LecturaBD(4)
                TB_CantProgra.Text = Format(xTCantProgra, "###,##0.00")
                TB_CantEntre.Text = Format(xTCantEntre, "###,##0.00")
                TB_CantEnproce.Text = Format(xTCantEnproce, "##,###0.00")
                TBC_CantPendiente.Text = Format(xTCantpendi, "##,###0.00")
            Else
                TB_CantProgra.Text = "0"
                TB_CantEntre.Text = "0"
                TB_CantEnproce.Text = "0"
                TBC_CantPendiente.Text = "0"
            End If
            LecturaBD.Close()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub CalCantIny(ByVal Usuario As String, Centro As String, ByVal Orden As String, TB_CantProgra As TextBox, TB_CantEntre As TextBox, TB_CantEnproce As TextBox, _
                            TBC_CantPendiente As TextBox, TBC_CantPiso As TextBox)
        Dim xTCantProgra As Decimal = 0
        Dim xTCantEntre As Decimal = 0
        Dim xTCantEnproce As Decimal = 0
        Dim xTCantpendi As Decimal = 0
        Dim xTCantPiso As Decimal = 0
        ' ---------------------------------------------------------------------------------
        Try
            LecturaQry("PA_Calcula_Cantidades_Iny '" & Centro & "',  '" & Orden.Trim & "'")
            If (LecturaBD.Read) Then
                xTCantProgra = LecturaBD(1)
                xTCantEntre = LecturaBD(2)
                xTCantEnproce = LecturaBD(3)
                xTCantpendi = LecturaBD(4)
                xTCantPiso = LecturaBD(5)
                TB_CantProgra.Text = Format(xTCantProgra, "###,##0.00")
                TB_CantEntre.Text = Format(xTCantEntre, "###,##0.00")
                TB_CantEnproce.Text = Format(xTCantEnproce, "###,##0.00")
                TBC_CantPendiente.Text = Format(xTCantpendi, "###,##0.00")
                TBC_CantPiso.Text = Format(xTCantPiso, "###,##0.00")
            Else
                TB_CantProgra.Text = "0"
                TB_CantEntre.Text = "0"
                TB_CantEnproce.Text = "0"
                TBC_CantPendiente.Text = "0"
                TBC_CantPiso.Text = "0"
            End If
            LecturaBD.Close()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub CalCantRot(ByVal Usuario As String, Centro As String, ByVal Orden As String, TB_CantProgra As TextBox, TB_CantEntre As TextBox, TB_CantEnproce As TextBox, _
                            TBC_CantPendiente As TextBox)
        ' ---------------------------------------------------------------------------------
        Try
            LecturaQry("PA_Calcula_Cantidades_Rot '" & Centro & "',  '" & Orden.Trim & "'")
            If (LecturaBD.Read) Then
                xTCantProgra = LecturaBD(1)
                xTCantEntre = LecturaBD(2)
                xTCantEnproce = LecturaBD(3)
                xTCantpendi = LecturaBD(4)
                TB_CantProgra.Text = Format(xTCantProgra, "###,##0.00")
                TB_CantEntre.Text = Format(xTCantEntre, "###,##0.00")
                TB_CantEnproce.Text = Format(xTCantEnproce, "###,##0.00")
                TBC_CantPendiente.Text = Format(xTCantpendi, "###,##0.00")
            Else
                TB_CantProgra.Text = "0"
                TB_CantEntre.Text = "0"
                TB_CantEnproce.Text = "0"
                TBC_CantPendiente.Text = "0"
            End If
            LecturaBD.Close()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub Valida_Existencia_Compuesto_BOM(ByVal Usuario As String, Centro As String, Producto As String, ByVal frmForm As Form)
        Dim CodCompuesto As Integer = 0
        'Valida si existe compuesto asignado a este producto
        LecturaQry("SP_Valida_Compuesto_BOM  '" & Producto.Trim & "' , '" & Centro & "'")
        If (LecturaBD.Read) Then
            CodCompuesto = LecturaBD(0)
            LecturaBD.Close()
        Else
            MensajeBox.Mostrar("No esta dado de alta compuesto de la BOM, para este material", "Campo Vacio", MensajeBox.TipoMensaje.Information)
            On Error Resume Next
            For Each ctlText In frmForm.Controls
                If TypeOf ctlText Is System.Windows.Forms.TextBox Then
                    If ctlText.Name = "TOrden" Then
                        ctlText.Text = ""
                        ctlText.Focus()
                        ctlText.ListIndex = -1
                    End If
                End If
            Next ctlText
            Return
        End If
    End Sub

    Public Shared Sub Porcentaje_Orden(ByVal Entregada As String, ByVal Proceso As String, ByVal Programada As String, Lbl As Label, Notifica As String)
        If (Entregada = "0" And Proceso = "0") Or Programada = "0" Or (Entregada = "" And Proceso = "") Or Programada = "" Then
            Lbl.Text = " "
        Else
            Cant_Ent = Entregada
            Cant_Proc = Proceso
            Cant_Porg = Programada
            Cant_Entregada = Cant_Ent + Cant_Proc

            If Cant_Entregada < Programada Then
                Lbl.ForeColor = Color.YellowGreen
                Res = Format((Cant_Entregada / Programada) * 100, "##0.00")
                Lbl.Text = "Orden al : " & Res & " % "
            ElseIf Cant_Entregada = Programada Then
                Lbl.ForeColor = Color.Green
                Res = Format((Cant_Entregada / Programada) * 100, "##0.00")
                Lbl.Text = "Orden Completada al : " & Res & " %  "
            ElseIf Cant_Entregada > Programada Then
                Lbl.ForeColor = Color.Red
                Res = Format(((Cant_Entregada / Programada) * 100) - (Programada / Programada) * 100, "##0.00")
                Lbl.Text = "Orden Excedida en : " & Res & " % "
                If Notifica = "1" Then
                    MensajeBox.Mostrar("Orden Excedida en : " & Res & " %  ", "Orden Excedida", MensajeBox.TipoMensaje.Critical)
                End If
            End If
            Porcentaje_Avance = Res
        End If
    End Sub

    Public Shared Sub Porcentaje_Orden_Excedido(ByVal Entregada As String, PorNotificar As String, ByVal Proceso As String, ByVal Programada As String, Lbl As Label, Notifica As String)
        If (Entregada = "0" And Proceso = "0") Or Programada = "0" Or (Entregada = "" And Proceso = "") Or Programada = "" Then
            Lbl.Text = " "
        Else
            Cant_Ent = Entregada
            Cant_Proc = Proceso
            Cant_Porg = Programada
            Cant_Entregada = Cant_Ent + Cant_Proc + PorNotificar

            Porcentaje_Avance = 0

            If Cant_Entregada < Programada Then
                Lbl.ForeColor = Color.YellowGreen
                Res = Format((Cant_Entregada / Programada) * 100, "##0.00")
                Lbl.Text = "Orden al : " & Res & " % "
            ElseIf Cant_Entregada = Programada Then
                Lbl.ForeColor = Color.Green
                Res = Format((Cant_Entregada / Programada) * 100, "##0.00")
                Lbl.Text = "Orden Completada al : " & Res & " %  "
            ElseIf Cant_Entregada > Programada Then
                Lbl.ForeColor = Color.Red
                Res = Format(((Cant_Entregada / Programada) * 100) - (Programada / Programada) * 100, "##0.00")
                Lbl.Text = "Orden Excedida en : " & Res & " % "
                Porcentaje_Avance = Res
                If Notifica = "1" Then
                    MensajeBox.Mostrar("Orden Excedida en : " & Res & " %  ", "Orden Excedida", MensajeBox.TipoMensaje.Critical)
                End If
            End If

        End If
    End Sub

End Class
