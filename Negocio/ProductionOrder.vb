Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class ProductionOrder_2

#Region "Variables miembro"
    'Valid_Existence
    Dim C_Orden As String
    Dim C_Prod As String
    Dim C_Status As String
    Dim C_Eqp As String
    Dim C_DesProd As String
    Dim C_Area As String
    Dim Count_1 As Integer = 0
    Dim Accion As String
    'Valida_Existencia_Producto
    Dim PrdCodigo As String
    Dim PrdDescrip As String
    Dim Count_2 As Integer
    'Read_Production_Order
    Dim Area,
        Descripcion,
        StatusOrden,
        CodigoProducto,
        EqpBasico,
        grpMaterial,
        StatusConsumo,
        CodEmp,
        DesEmp,
        DescGrupo,
        DesEqpBasico As String
    Dim Tramos, _
        PesoTeorico, _
        sobrePESO, _
        PesoAcc, _
        PesoEmb, _
        PesoEmp As Decimal
    Dim Count_3 As Integer = 0
    'Valida_Existencia_Sello_Peso
    Dim PesoEmpaque As String
    Dim CantEmpaques As String
    'Valida_Existencia_Compuesto_BOM
    Dim ctlText As Object
    Dim CodCompuesto As Integer = 0
    'Inserta_Nueva_Orden_Produccion
    Dim Head As String
    Dim Lista As New Generic.List(Of String)
    Dim Tbl As String()
    Dim SAP_Return As Object
    Dim aryTextFile() As String
    'Datos que retorna lectura de WS de SAP
    Dim SAP_OrdenProd As String
    Dim SAP_NumeroPlanta As String
    Dim SAP_Equipo As String
    Dim SAP_StrProducto As String
    Dim SAP_CantProgPzs As String
    Dim SAP_Unidad As String
    Dim SAP_Inicio As String
    Dim SAP_Fin As String
    Dim SAP_Origen As String
    Dim SAP_Status1 As String
    Dim SAP_Desc_Status As String
    Dim SAP_fecini As String
    Dim SAP_Tipo_Ord As String
    Dim SAP_Err As String
    Dim SAP_Mns As String
    Dim Grupo As String
    Dim FH_Update As String
#End Region

#Region "Enumeraciones"
#End Region

#Region "Constructores"
#End Region

#Region "Clases anidadas"
#End Region

#Region "Métodos"
    Public Sub Valid_Existence(ByVal Orden As String, Seccion As String)
        Accion = ""
        Count_1 = 0
        C_Orden = ""
        C_Prod = ""
        C_Status = ""
        C_Eqp = ""
        C_DesProd = ""
        C_Area = ""

        If Orden = "" Then
            MensajeBox.Mostrar("Tecleé un numero de Orden de Producción ", "Campo Vacio", MensajeBox.TipoMensaje.Critical)
            Accion = "E"
            Exit Sub
        Else
            LecturaQry("PA_Check_Existence_Production_Order '" & Orden.Trim & "', '" & SessionUser._sCentro.Trim & "' ")
            If (LecturaBD.Read) Then
                Count_1 = Count_1 + 1
                C_Orden = "" & LecturaBD(0)
                C_Prod = "" & LecturaBD(1)
                C_Status = "" & LecturaBD(2)
                C_Eqp = "" & LecturaBD(3)
                C_DesProd = "" & LecturaBD(4)
                C_Area = "" & LecturaBD(5)
            End If
            LecturaBD.Close()
        End If
    End Sub

    Public Sub Valida_Existencia_Producto(ByVal Producto As String, ByVal Area As String)
        Accion = ""
        Count_2 = 0
        PrdCodigo = ""
        PrdDescrip = ""
        Try
            LecturaQry("PA_Check_Existence_Product '" & Producto.Trim & "', '" & SessionUser._sCentro.Trim & "', '" & Area & "' ")
            If (LecturaBD.Read) Then
                Count_2 = Count_2 + 1
                PrdCodigo = "" & LecturaBD(0)
                PrdDescrip = "" & LecturaBD(1)
            End If
            LecturaBD.Close()
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Campo Vacio", MensajeBox.TipoMensaje.Critical)
            Accion = "E"
        End Try
    End Sub

    Public Sub Read_Production_Order(ByVal Orden As String)
        LecturaQry("PA_Read_Production_Order '" & Orden.Trim & "', '" & SessionUser._sCentro.Trim & "' ")
        Count_3 = 0
        If (LecturaBD.Read) Then
            Count_3 = Count_3 + 1
            Area = "" & LecturaBD(0)
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
    End Sub

    Public Sub Valida_Existencia_Compuesto_BOM(ByVal Producto As String, ByVal frmForm As Form)
        'Valida si existe compuesto asignado a este producto
        LecturaQry("SP_Valida_Compuesto_BOM  '" & Producto.Trim & "' , '" & SessionUser._sCentro & "'")
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

    Public Sub Inserta_Nueva_Orden_Produccion(odf As String, Tipo As String, frmForm As Form, CodOperador As String, Seccion As String)
        Head = "31" & "|" & odf.Trim & "|" & "10" & "|" & Tipo
        WS_P.Consume_WS(Head, Lista, SessionUser._sAmbiente)
        Tbl = WS_P.Tbl_resultado
        SAP_Return = WS_P.Return_SAP
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
        OrdenProd = aryTextFile(1)
        NumeroPlanta = aryTextFile(2)
        Equipo = aryTextFile(3)
        StrProducto = aryTextFile(4)
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
        If Err = "E" Then
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
                If Not NumeroPlanta.Trim = SessionUser._sCentro.Trim Then
                    Message = "Orden de Producción no pertenece al centro " & SessionUser._sCentro.Trim
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
                    QRY = ""
                    QRY = "SELECT GrupMaterial, Sobrepeso FROM CAT_ProductoTerminado "
                    QRY = QRY & "WHERE Centro = " & "'" & SessionUser._sCentro.Trim & "' "
                    QRY = QRY & "AND Codigo = '" & StrProducto.Trim & "'"
                    LecturaQry(QRY)
                    If LecturaBD.Read() Then
                        Grupo = LecturaBD(0)
                        'Verifica si el producto es de inyección o extrusión
                        Dim Tipo_Prod As String = NotificationProcess.Verifica_Producto(StrProducto.Trim)
                        If Seccion = "1" And Tipo_Prod = "2" Then
                            MensajeBox.Mostrar("El producto no es de Extrusión, no se dara de Alta la Orden ", "Error", MensajeBox.TipoMensaje.Information)
                            Exit Sub
                        ElseIf Seccion = "2" And Tipo_Prod = "1" Then
                            MensajeBox.Mostrar("El producto no es de Inyección, no se dara de Alta la Orden", "Error", MensajeBox.TipoMensaje.Information)
                            Exit Sub
                        End If
                    Else
                        'If Seccion = "1" Then
                        MensajeBox.Mostrar("El producton o esta dado de Alta en A-tlas informe al Administrador ", "Campo Vacio", MensajeBox.TipoMensaje.Information)
                        Exit Sub
                        'End If
                        'If Seccion = "2" Then
                        '    'SQL.Cat_Materiales.Insert_Producto_terminado(CodOperador.Trim, SessionUser._sCentro, StrProducto)
                        'End If
                    End If
                    ' --------------------------------------------------------------------------------------------
                    'Insert la ifnormacion de la orden de produccion en la tabla Ordens de Produccion de A-tlas
                    Dim Fec_Act As String = DateTime.Now.ToString("yyyy/MM/dd")
                    Dim Fec_reg As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim Hra_Act As String = DateTime.Now.ToString("HH:MM:ss")
                    LecturaQry("PA_Inserta_Orden_Produccion '" & OrdenProd.Trim & "','" & SessionUser._sCentro & "','" & Equipo & "','" _
                               & StrProducto & "','" & CantProgPzs & "','" & Inicio & "','" & Fin & "','" & Origen & "','" _
                               & CodOperador.Trim & "','" & Fec_Act & "','Ingreso Por SAP','" & Fec_Act & "','" & Hra_Act & "','" _
                               & SessionUser._sAlias.Trim & "','" & Fec_Act & "','" & Hra_Act & "','Usuario Fin','Usuario Reg','" & Fec_reg & "','" _
                               & Hra_Act & "','" & Grupo.Trim & "'")
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
                    MensajeBox.Mostrar("La orden a sido dada de alta ingrese nuevamente el numero de orden", "Campo Vacio", MensajeBox.TipoMensaje.Information)
                End If
        End Select
    End Sub

    Public Sub Inserta_ODF(odf As String, Tipo As String, frmForm As Form, CodOperador As String, Seccion As String)
        Head = "31" & "|" & odf.Trim & "|" & "10" & "|" & Tipo
        WS_P.Consume_WS(Head, Lista, SessionUser._sAmbiente)
        Tbl = WS_P.Tbl_resultado
        SAP_Return = WS_P.Return_SAP
        ' ---------------------------------------------------------------------------------
        aryTextFile = Tbl(0).Split("|")
        OrdenProd = aryTextFile(1)
        NumeroPlanta = aryTextFile(2)
        Equipo = aryTextFile(3)
        StrProducto = aryTextFile(4)
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
        If Not NumeroPlanta.Trim = SessionUser._sCentro.Trim Then
            Message = "Orden de Producción no pertenece al centro " & SessionUser._sCentro.Trim
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
            QRY = ""
            QRY = "SELECT GrupMaterial, Sobrepeso FROM CAT_ProductoTerminado "
            QRY = QRY & "WHERE Centro = " & "'" & SessionUser._sCentro.Trim & "' "
            QRY = QRY & "AND Codigo = '" & StrProducto.Trim & "'"
            LecturaQry(QRY)
            If LecturaBD.Read() Then
                Grupo = LecturaBD(0)
                'Verifica si el producto es de inyección o extrusión
                Dim Tipo_Prod As String = NotificationProcess.Verifica_Producto(StrProducto.Trim)
                If Seccion = "1" And Tipo_Prod = "2" Then
                    MensajeBox.Mostrar("El producto no es de Extrusión, no se dara de Alta la Orden ", "Error", MensajeBox.TipoMensaje.Information)
                    Exit Sub
                ElseIf Seccion = "2" And Tipo_Prod = "1" Then
                    MensajeBox.Mostrar("El producto no es de Inyección, no se dara de Alta la Orden", "Error", MensajeBox.TipoMensaje.Information)
                    Exit Sub
                End If
            Else
                'If Seccion = "1" Then
                MensajeBox.Mostrar("El producton o esta dado de Alta en A-tlas informe al Administrador ", "Campo Vacio", MensajeBox.TipoMensaje.Information)
                Exit Sub
                'End If
                'If Seccion = "2" Then
                '    'SQL.Cat_Materiales.Insert_Producto_terminado(CodOperador.Trim, SessionUser._sCentro, StrProducto)
                'End If
            End If
            ' --------------------------------------------------------------------------------------------
            'Insert la ifnormacion de la orden de produccion en la tabla Ordens de Produccion de A-tlas
            Dim Fec_Act As String = DateTime.Now.ToString("yyyy/MM/dd")
            Dim Fec_reg As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim Hra_Act As String = DateTime.Now.ToString("HH:MM:ss")
            LecturaQry("PA_Inserta_Orden_Produccion '" & OrdenProd.Trim & "','" & SessionUser._sCentro.Trim & "','" & Equipo & "','" _
                       & StrProducto & "','" & CantProgPzs & "','" & Inicio & "','" & Fin & "','" & Origen & "','" _
                       & CodOperador.Trim & "','" & Fec_Act & "','Ingreso Por SAP','" & Fec_Act & "','" & Hra_Act & "','" _
                       & SessionUser._sAlias.Trim & "','" & Fec_Act & "','" & Hra_Act & "','Usuario Fin','Usuario Reg','" & Fec_reg & "','" _
                       & Hra_Act & "','" & Grupo.Trim & "'")
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
            MensajeBox.Mostrar("La orden a sido dada de alta ingrese nuevamente el numero de orden", "Campo Vacio", MensajeBox.TipoMensaje.Information)
        End If
    End Sub

    Public Sub Actualiza_Orden_Produccion(ByVal odf As String, Tipo As String)
        Head = "31" & "|" & odf.Trim & "|" & "10" & "|" & Tipo
        WS_P.Consume_WS(Head, Lista, SessionUser._sAmbiente)
        Tbl = WS_P.Tbl_resultado
        SAP_Return = WS_P.Return_SAP
        FH_Update = DateTime.Now.ToString("yyyyMMdd hh:mm:ss")
        ' ---------------------------------------------------------------------------------
        If SAP_Return.ztype <> "E" Then
            aryTextFile = Tbl(0).Split("|")
            OrdenProd = aryTextFile(1)
            NumeroPlanta = aryTextFile(2)
            Equipo = aryTextFile(3)
            StrProducto = aryTextFile(4)
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
            LecturaQry("PA_Actualiza_Orden_Produccion  " & SessionUser._sCentro & "_OrdenProduccion, '" & OrdenProd.Trim & "' , '" & Equipo.Trim & "', '" & StrProducto.Trim & "', " & CantProgPzs & ", '" & SessionUser._sAlias.Trim & "', '" & FH_Update & "'")
        End If
    End Sub

    Public Shared Sub Porcentaje_Orden(ByVal Entregada As String, ByVal Proceso As String, ByVal Programada As String, Lbl As Label)
        Dim Res As Double
        Dim Cant_Ent As Double
        Dim Cant_Proc As Double
        Dim Cant_Porg As Double
        Dim Cant_Entregada As Double


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
                If Btn_Notificar = "1" Then
                    MensajeBox.Mostrar("Orden Excedida en : " & Res & " %  ", "Orden Excedida", MensajeBox.TipoMensaje.Critical)
                End If
            End If
        End If
    End Sub

    Public Sub Lectura_Orden_EXT(ByVal Orden As String, TBOrden As TextBox, frmForm As Form, TipoProd As String, _
                             TB_CodPT As TextBox, TB_CodPtDecr As TextBox, TB_PtoTrabajo As TextBox, TB_PesoTeorico As TextBox, _
                             TB_empaque As TextBox, TB_CodAnillo As TextBox, TB_DAnillo As TextBox, _
                             TB_Grpprod As TextBox, TB_Grupo As TextBox, TB_SP_Permitido As TextBox, TB_Grpproddesc As TextBox, _
                             TB_NomPtoTrabajo As TextBox, CodOper As String, CB_Com1 As ComboBox, TB_CComp1 As TextBox, _
                             CB_Causas As ComboBox, CB_TipoSc As ComboBox, CB_Ope As ComboBox, PAR_CD As Boolean, CC As Boolean, _
                             Usuario As String, Centro As String)
        'Limpiar Variables
        TB_CodPT.Text = ""          'Código PT
        TB_CodPtDecr.Text = ""      'Descripción del PT   
        TB_PtoTrabajo.Text = ""     'EqpBasico.Trim  'Puesto de Trabajo
        TB_PesoTeorico.Text = ""    'Peso Teorico
        TB_empaque.Text = ""        'Peso Unitario del Empaque
        TB_CodAnillo.Text = ""      'CodigoEmpaque
        TB_DAnillo.Text = ""        'Descripción Empaque
        TB_Grpprod.Text = ""        'Area (1 Extrusion, 2 Inyección)
        TB_Grupo.Text = ""          'Codigo Grupo Material
        TB_SP_Permitido.Text = ""   'Sobre Peso Permitido
        TB_Grpproddesc.Text = ""    'Descricpion Grupo
        TB_NomPtoTrabajo.Text = ""  'Descripcion Puesto de Trabajo

        'Verifica Existencia de la orden de producción en A-tlas
        Valid_Existence(Orden, EXTINY)
        If r_Accion = Seccion Then
            TBOrden.Focus()
            Exit Sub
        ElseIf r_Count_1 > 0 Then
            'Valida si esta dado de alta el producto
            Valida_Existencia_Producto(r_C_Prod, EXTINY)
            If r_Accion = Seccion Then
                Exit Sub
            ElseIf r_Count_2 > 0 Then
                'Lee la orden y presenta la informacion
                Read_Production_Order(Orden)
                If r_Count_3 > 0 Then
                    'Asigna valores a los textbox
                    TB_CodPT.Text = r_CodigoProducto               'Código PT
                    TB_CodPtDecr.Text = r_Descripcion              'Descripción del PT   
                    TB_PtoTrabajo.Text = r_EqpBasico               'EqpBasico.Trim  'Puesto de Trabajo
                    TB_PesoTeorico.Text = r_PesoTeorico            'Peso Teorico
                    TB_empaque.Text = r_PesoEmp                    'Peso Unitario del Empaque
                    TB_CodAnillo.Text = r_CodEmp                   'CodigoEmpaque
                    TB_DAnillo.Text = r_DesEmp                     'Descripción Empaque
                    TB_Grpprod.Text = r_Area                       'Area (1 Extrusion, 2 Inyección)
                    TB_Grupo.Text = r_grpMaterial                  'Codigo Grupo Material
                    TB_SP_Permitido.Text = r_sobrePESO             'Sobre Peso Permitido
                    TB_Grpproddesc.Text = r_DescGrupo              'Descricpion Grupo
                    TB_NomPtoTrabajo.Text = r_DesEqpBasico         'Descripcion Puesto de Trabajo
                    'Valida si existe compuesto asignado a este producto
                    Valida_Existencia_Compuesto_BOM(r_CodigoProducto.Trim, frmForm)
                    'Activa Combo Box de compuestos 1
                    If CC = True Then 'Si esta activa el parametro de seleccionar compuestos
                        Catalogo_Compuestos.CB_Compuesto1(CB_Com1, EXTINY, TipoProd, P_CC1)
                    End If
                    If PAR_CD = True Then 'Elije la opcion de presentar la causa y defecto
                        If TipoProd.Trim = "S" Then
                            CB_Causas.DataSource = Nothing
                            CB_Causas.Text = ""
                            CBG.Tipo_SC(CB_TipoSc, Seccion)
                            CB_TipoSc.Text = ""
                        End If
                    Else
                        If TipoProd.Trim = "S" Then
                            CB_Causas.Text = ""
                            Catalogo_Causas.Combo_Causas(CB_Causas, "", Seccion.Trim, "SC", PAR_CD)
                            CBG.Tipo_SC(CB_TipoSc, Seccion)
                            CB_TipoSc.Text = ""

                        End If
                    End If
                    TBOrden.BackColor = Color.White
                    CBG.Operador(CB_Ope)
                    CB_Ope.Text = ""
                End If
            Else
                MensajeBox.Mostrar("El producto no esta dado de alta en A-tlas ", "Error", MensajeBox.TipoMensaje.Critical)
                Exit Sub
            End If
        Else
            MensajeBox.Mostrar("Orden de Producción no existe en A-tlas se procede a darla de alta ", "Aviso", MensajeBox.TipoMensaje.Information)
            Inserta_Nueva_Orden_Produccion(Orden, "T", frmForm, CodOper, EXTINY)
        End If
    End Sub

    Public Sub Lectura_Orden_INY(ByVal Orden As String, TBOrden As TextBox, frmForm As Form, TipoProd As String, _
                          TB_CodPT As TextBox, TB_CodPtDecr As TextBox, TB_PtoTrabajo As TextBox, TB_Grpprod As TextBox, _
                          TB_Grupo As TextBox, TB_Grpproddesc As TextBox, TB_NomPtoTrabajo As TextBox, CodOper As String, _
                          CB_Com1 As ComboBox, TB_CComp1 As TextBox, CB_TipoSc As ComboBox, CB_Ope As ComboBox, CC As Boolean, _
                          Usuario As String, Centro As String)

        'Verifica Existencia de la orden de producción en A-tlas
        Valid_Existence(Orden, EXTINY)
        If r_Accion = Seccion Then
            TBOrden.Focus()
            Exit Sub
        ElseIf r_Count_1 > 0 Then
            'Valida si esta dado de alta el producto
            Valida_Existencia_Producto(r_C_Prod, EXTINY)
            If r_Accion = Seccion Then
                Exit Sub
            ElseIf r_Count_2 > 0 Then
                'Lee la orden y presenta la informacion
                Read_Production_Order(Orden)
                If r_Count_3 > 0 Then
                    'Asigna valores a los textbox
                    TB_CodPT.Text = r_CodigoProducto               'Código PT
                    TB_CodPtDecr.Text = r_Descripcion              'Descripción del PT   
                    TB_PtoTrabajo.Text = r_EqpBasico               'EqpBasico.Trim  'Puesto de Trabajo
                    TB_Grpprod.Text = r_Area                       'Area (1 Extrusion, 2 Inyección)
                    TB_Grupo.Text = r_grpMaterial                  'Codigo Grupo Material
                    TB_Grpproddesc.Text = r_DescGrupo              'Descricpion Grupo
                    TB_NomPtoTrabajo.Text = r_DesEqpBasico         'Descripcion Puesto de Trabajo
                    'Valida si existe compuesto asignado a este producto
                    Valida_Existencia_Compuesto_BOM(r_CodigoProducto.Trim, frmForm)
                    'Activa Combo Box de compuestos 1
                    Catalogo_Compuestos.CB_Compuesto1(CB_Com1, EXTINY, TipoProd, P_CC1)
                    CBG.Tipo_SC(CB_TipoSc, Seccion)
                    CB_TipoSc.Text = CB_TipoSc.SelectedValue
                    TBOrden.BackColor = Color.White
                    CBG.Operador(CB_Ope)
                    CB_Ope.Text = ""
                End If
            Else
                MensajeBox.Mostrar("El producto no esta dado de alta en A-tlas ", "Error", MensajeBox.TipoMensaje.Critical)
                Exit Sub
            End If
        Else
            MensajeBox.Mostrar("Orden de Producción no existe en A-tlas se procede a darla de alta ", "Aviso", MensajeBox.TipoMensaje.Information)
            Inserta_Nueva_Orden_Produccion(Orden, "T", frmForm, CodOper, EXTINY)
        End If

    End Sub

#End Region

#Region "Propiedades"
    Public Property r_Accion() As String
        Get
            Return Accion
        End Get
        Set(ByVal value As String)
            Accion = value
        End Set
    End Property

    Public Property r_Count_1() As Integer
        Get
            Return Count_1
        End Get
        Set(ByVal value As Integer)
            Count_1 = value
        End Set
    End Property

    Public Property r_C_Orden() As String
        Get
            Return C_Orden
        End Get
        Set(ByVal value As String)
            C_Orden = value
        End Set
    End Property

    Public Property r_C_Status() As String
        Get
            Return C_Status
        End Get
        Set(ByVal value As String)
            C_Status = value
        End Set
    End Property

    Public Property r_C_Prod() As String
        Get
            Return C_Prod
        End Get
        Set(ByVal value As String)
            C_Prod = value
        End Set
    End Property


    Public Property r_Count_2() As Integer
        Get
            Return Count_2
        End Get
        Set(ByVal value As Integer)
            Count_2 = value
        End Set
    End Property

    Public Property r_PrdCodigo() As String
        Get
            Return PrdCodigo
        End Get
        Set(ByVal value As String)
            PrdCodigo = value
        End Set
    End Property

    Public Property r_PrdDescrip() As String
        Get
            Return PrdDescrip
        End Get
        Set(ByVal value As String)
            PrdDescrip = value
        End Set
    End Property


    Public Property r_Area() As String
        Get
            Return Area
        End Get
        Set(ByVal value As String)
            Area = value
        End Set
    End Property

    Public Property r_Descripcion() As String
        Get
            Return Descripcion
        End Get
        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property
    Public Property r_PesoTeorico() As Decimal
        Get
            Return PesoTeorico
        End Get
        Set(ByVal value As Decimal)
            PesoTeorico = value
        End Set
    End Property
    Public Property r_StatusOrden() As String
        Get
            Return StatusOrden
        End Get
        Set(ByVal value As String)
            StatusOrden = value
        End Set
    End Property
    Public Property r_CodigoProducto() As String
        Get
            Return CodigoProducto
        End Get
        Set(ByVal value As String)
            CodigoProducto = value
        End Set
    End Property
    Public Property r_Tramos() As Decimal
        Get
            Return Tramos
        End Get
        Set(ByVal value As Decimal)
            Tramos = value
        End Set
    End Property
    Public Property r_EqpBasico() As String
        Get
            Return EqpBasico
        End Get
        Set(ByVal value As String)
            EqpBasico = value
        End Set
    End Property
    Public Property r_grpMaterial() As String
        Get
            Return grpMaterial
        End Get
        Set(ByVal value As String)
            grpMaterial = value
        End Set
    End Property
    Public Property r_sobrePESO() As Decimal
        Get
            Return sobrePESO
        End Get
        Set(ByVal value As Decimal)
            sobrePESO = value
        End Set
    End Property
    Public Property r_StatusConsumo() As String
        Get
            Return StatusConsumo
        End Get
        Set(ByVal value As String)
            StatusConsumo = value
        End Set
    End Property
    Public Property r_PesoAcc() As Decimal
        Get
            Return PesoAcc
        End Get
        Set(ByVal value As Decimal)
            PesoAcc = value
        End Set
    End Property
    Public Property r_PesoEmb() As Decimal
        Get
            Return PesoEmb
        End Get
        Set(ByVal value As Decimal)
            PesoEmb = value
        End Set
    End Property
    Public Property r_CodEmp() As String
        Get
            Return CodEmp
        End Get
        Set(ByVal value As String)
            CodEmp = value
        End Set
    End Property
    Public Property r_DesEmp() As String
        Get
            Return DesEmp
        End Get
        Set(ByVal value As String)
            DesEmp = value
        End Set
    End Property
    Public Property r_DescGrupo() As String
        Get
            Return DescGrupo
        End Get
        Set(ByVal value As String)
            DescGrupo = value
        End Set
    End Property
    Public Property r_PesoEmp() As Decimal
        Get
            Return PesoEmp
        End Get
        Set(ByVal value As Decimal)
            PesoEmp = value
        End Set
    End Property
    Public Property r_DesEqpBasico() As String
        Get
            Return DesEqpBasico
        End Get
        Set(ByVal value As String)
            DesEqpBasico = value
        End Set
    End Property
    Public Property r_Count_3() As Integer
        Get
            Return Count_3
        End Get
        Set(ByVal value As Integer)
            Count_3 = value
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
