Imports Atlas.Accesos.CLVarGlobales
Imports Atlas.Accesos
Imports SQL_DATA
Public Class IAC_ODF
#Region "Variables Insert Nueva ODF"
    'Variables Insert New ODF
    Dim xUSUARIOREG As String
    Dim xFECHAREG As String
    Dim xHORAREG As String
    Dim xTGRUPO As String
    Dim xSPPERMITIDO As String
    'Leer orden de producción
    Dim Lista As New Generic.List(Of String)
    Dim Tbl As String()
    Dim Tbl_LM As New Generic.List(Of String)
    Dim SAP_Return As Object
    Dim Head As String
    Dim aryTextFile() As String
    Dim ctlText As Object
#End Region
#Region "Variables Consulta ODF"
    Dim xAREA As String
    Dim descripcion As String = ""
    Dim CodigoEmpaque As String
    Dim PesoTeorico As Decimal
    Dim StrTramos As String
    Dim EqpBasico As String
    Dim grpMaterial As String
    Dim sobrePESO As String
    Dim StatusConsumo As String
    Dim PesoAcc As String
    Dim PesoEmb As String
    Dim DesEmp As String
#End Region

    Public Sub I_New_ODF(odf As String, Tipo As String, frmForm As Form, Grupo As String, CodOperador As String)
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
                    ' Identificar compuesto de la bom -----------------------------------------------------------      
                    Gen_Valida.Compuesto_bom(StrProducto.Trim)
                    ' ---------------------------------------------------------------------------------
                    xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
                    xHORAREG = Date.Now.TimeOfDay.ToString.Substring(0, 8)
                    xTGRUPO = ""
                    xSPPERMITIDO = ""
                    ' ---------------------------------------------------------------------------------
                    'Selecciona el grupo al que pertenece el material
                    QRY = ""
                    QRY = "SELECT GrupMaterial, Sobrepeso FROM CAT_ProductoTerminado "
                    QRY = QRY & "WHERE Centro = " & "'" & SessionUser._sCentro.Trim & "' "
                    QRY = QRY & "AND Codigo = '" & StrProducto.Trim & "'"
                    LecturaQry(QRY)
                    ' ---------------------------------------------------------------------------------
                    If LecturaBD.Read() Then
                        xTGRUPO = LecturaBD(0)
                        xSPPERMITIDO = LecturaBD(1)
                    End If
                    Dim Fec_Act As String = DateTime.Now.ToString("yyyy/MM/dd")
                    Dim Fec_reg As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim Hra_Act As String = DateTime.Now.ToString("HH:MM:ss")
                    xTGRUPO = Grupo
                    ' Guarda Información de la orden de fabricación -----------------------------------
                    DBG.Insert_ODF(OrdenProd, SessionUser._sCentro, Equipo, StrProducto, CantProgPzs, Inicio, Fin, _
                                       Origen, "1", CodOperador.Trim, Fec_Act, "Ingreso Por SAP", Fec_Act, Hra_Act, _
                                    SessionUser._sAlias, Fec_Act, Hra_Act, "Usuario Fin", "Usuario Reg", Fec_reg, Hra_Act, _
                                    xTGRUPO)
                End If
                MsgBox("Se ha dado de Alta la Orden de Producción : " & OrdenProd.Trim & " en ATLAS", MsgBoxStyle.Information)
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
        End Select
    End Sub
    Public Sub C_ODF(odf As String, Tipo As String, frmForm As Form)
        ' --------------- Si la orden existe en Atlas verificar que el producto a fabricar tambien existe
        Gen_Valida.Valida_Producto(odf.Trim)
        Select Case Gen_Valida.valVCountProducto  'Si el producto existe regreso la informacion del mismo
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
                'Valida si existe compuesto asignado a este producto
                LecturaQry("SP_Valida_Compuesto_BOM  '" & StrProducto & "' , '" & SessionUser._sCentro & "'")
                If (LecturaBD.Read) Then
                    ValStatus = LecturaBD(0)
                Else
                    MsgBox("No esta dado de alta compuesto de la BOM, para este material", MsgBoxStyle.Information)
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

            Case False  'Case Para Identificar Sí el producto  y el Compuesto  Existen en la BD - False
                MessageBox.Show("No existe Producto en A-tlas para esta Orden ó la orden ya fue cerrada, Informe al Supervisor", " VENTANA DE ERROR * * * ")
        End Select 'Case Para Identificar Sí el producto  y el Compuesto  Existen en la BD - True      
        ' -----------------------------------------  Cierre revisión de orden
    End Sub
    ReadOnly Property strDescripcion() As String
        Get
            Return descripcion
        End Get
    End Property
    ReadOnly Property strEquipobasico() As String
        Get
            Return EqpBasico
        End Get
    End Property
    ReadOnly Property strCodigoEmpaque() As String
        Get
            Return CodigoEmpaque
        End Get
    End Property
    ReadOnly Property strDesEmp() As String
        Get
            Return DesEmp
        End Get
    End Property
    ReadOnly Property strxAREA() As String
        Get
            Return xAREA
        End Get
    End Property
    ReadOnly Property strgrpMaterial() As String
        Get
            Return grpMaterial
        End Get
    End Property
    ReadOnly Property strPesoTeorico() As String
        Get
            Return PesoTeorico
        End Get
    End Property
    ReadOnly Property strsobrePESO() As String
        Get
            Return sobrePESO
        End Get
    End Property

    'Public Sub E_ODF(odf As String, Tipo As String, frmForm As Form)
    '    ValStatus = ""
    '    Select Case Permiso.StatusSap
    '        Case "True"
    '            'Lectura de WS Generico
    '            Dim Lista As New Generic.List(Of String)
    '            Dim Tbl As String()
    '            Dim Tbl_LM As New Generic.List(Of String)
    '            Dim SAP_Return As Object
    '            Dim Head As String = "31" & "|" & odf.Trim & "|" & "10" & "|" & Tipo
    '            Dim aryTextFile() As String

    '            WS_P.Consume_WS(SessionUser._sAlias.Trim, Head, Lista, strAmbiente)
    '            Tbl = WS_P.Tbl_resultado
    '            SAP_Return = WS_P.Return_SAP

    '            Err = SAP_Return.ZTYPE
    '            Mns = SAP_Return.ZMESSAGE
    '            ' ---------------------------------------------------------------------------------
    '            If Err = "E" Then
    '                MessageBox.Show(Mns, "Error SAP Notifique al Supervisor")
    '                On Error Resume Next
    '                For Each ctlText In frmForm.Controls
    '                    If TypeOf ctlText Is System.Windows.Forms.TextBox Then
    '                        If ctlText.Name = "TOrden" Then
    '                            ctlText.Text = ""
    '                            ctlText.Focus()
    '                            ctlText.ListIndex = -1
    '                        End If
    '                    End If
    '                Next ctlText
    '                Return
    '            Else
    '                aryTextFile = Tbl(0).Split("|")

    '                OrdenProd = aryTextFile(1)
    '                NumeroPlanta = aryTextFile(2)
    '                Equipo = aryTextFile(3)
    '                StrProducto = aryTextFile(4)
    '                CantProgPzs = aryTextFile(5)
    '                Unidad = aryTextFile(6)
    '                Inicio = aryTextFile(7)
    '                Fin = aryTextFile(8)
    '                Origen = aryTextFile(9)
    '                Status1 = aryTextFile(10)
    '                Desc_Status = aryTextFile(11)
    '                fecini = aryTextFile(12)
    '                Tipo_Ord = aryTextFile(13)

    '                DBG.Update_ODF(OrdenProd.Trim, NumeroPlanta.Trim, Equipo.Trim, StrProducto.Trim, CantProgPzs, Inicio, Fin)
    '            End If

    '            ' ---------------------------------------------------------------------------------
    '            Select Case Status1
    '                Case Is <> "LIB."
    '                    Message = "Orden de Producción no esta liberada"
    '                    Caption = "Orden no liberada"
    '                    Result = MessageBox.Show(Message, Caption, Botones)
    '                    If Result = System.Windows.Forms.DialogResult.OK Then
    '                        On Error Resume Next
    '                        For Each ctlText In frmForm.Controls
    '                            If TypeOf ctlText Is System.Windows.Forms.TextBox Then
    '                                If ctlText.Name = "TOrden" Then
    '                                    ctlText.Text = ""
    '                                    ctlText.Focus()
    '                                    ctlText.ListIndex = -1
    '                                End If
    '                            End If
    '                        Next ctlText
    '                        Return
    '                    End If
    '            End Select
    '    End Select
    '    ' --------------- Si la orden existe en Atlas verificar que el producto a fabricar tambien exista.
    '    Gen_Valida.Valida_Producto(odf.Trim)
    '    Select Case Gen_Valida.valVCountProducto  'Case Para Identificar Sí el producto  y el Compuesto  Existen en la BD - True 
    '        Case True
    '            Do While (LecturaBD.Read())
    '                xAREA = "" & LecturaBD(0)
    '                descripcion = "" & LecturaBD(1)
    '                CodigoEmpaque = "" & LecturaBD(2)
    '                PesoTeorico = "" & LecturaBD(3)
    '                'EstatusActiva = "" & LecturaBD(4)
    '                StrProducto = "" & LecturaBD(5)
    '                StrTramos = "" & LecturaBD(6)
    '                EqpBasico = "" & LecturaBD(7)
    '                grpMaterial = "" & LecturaBD(8)
    '                sobrePESO = "" & LecturaBD(9)
    '                StatusConsumo = "" & LecturaBD(10)
    '                PesoAcc = "" & LecturaBD(11)
    '                PesoEmb = "" & LecturaBD(12)
    '                DesEmp = "" & LecturaBD(13)
    '                WorkCenter = "" & UCase(EqpBasico)
    '            Loop
    '            LecturaBD.Close()
    '            'Valida si existe compuesto asignado a este producto
    '            LecturaQry("SP_Valida_Compuesto_BOM  '" & StrProducto & "' , '" & strPlanta & "'")
    '            If (LecturaBD.Read) Then
    '                ValStatus = LecturaBD(0)
    '            Else
    '                MsgBox("No esta dado de alta compuesto de la BOM, para este material", MsgBoxStyle.Information)
    '                On Error Resume Next
    '                For Each ctlText In frmForm.Controls
    '                    If TypeOf ctlText Is System.Windows.Forms.TextBox Then
    '                        If ctlText.Name = "TOrden" Then
    '                            ctlText.Text = ""
    '                            ctlText.Focus()
    '                            ctlText.ListIndex = -1
    '                        End If
    '                    End If
    '                Next ctlText
    '                Return
    '            End If

    '        Case False  'Case Para Identificar Sí el producto  y el Compuesto  Existen en la BD - False
    '            MessageBox.Show("No existe Producto en A-tlas para esta Orden ó la orden ya fue cerrada, Informe al Supervisor", " VENTANA DE ERROR * * * ")

    '            Dim lo_WSNAC_Ope As New Dev_Gen.ZGLMX_ATLAS_GRService
    '            Dim E_Return As New Dev_Gen.ZBAPIRET2
    '            Dim List As New Generic.List(Of String)
    '            Dim Tbl_Oper As String()
    '            Dim Header As String
    '            Header = "3" + "|" + strPlanta.Trim + "|" + StrProducto.Trim
    '            lo_WSNAC_Ope.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
    '            Tbl_Oper = lo_WSNAC_Ope.Z_GLMX_ATLAS_GR(List.ToArray, Header, E_Return)

    '    End Select 'Case Para Identificar Sí el producto  y el Compuesto  Existen en la BD - True      
    '    ' -----------------------------------------  Cierre revisión de orden
    'End Sub
End Class
