Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class Validaciones
#Region "Valida Operador"
    Dim Codigo As String = ""
    Dim Nombre As String = ""
#End Region
#Region "Fecha_Hora_dia"
    Public FH_dia As String
#End Region
#Region "Status_Orden"
    Dim CountValOP As Integer
    Dim OrdenOP As String
    Dim StatusOP As Char
#End Region
#Region "Compuesto_bom"
    Dim Cod_Comp As String
#End Region
#Region "Valida_Producto"
    Dim VCountProducto As Boolean       'Validación para identificar si existe  el PT y compuesto en la BD A-TLAS
#End Region
#Region "Valida_Usuario"
    Dim Contador As Integer = 0
    Dim Usr_Cont As Integer
#End Region

    Public Sub Valida_Operador(ByVal CveOperador As String)
        Codigo = ""
        Nombre = ""
        If Val(CveOperador.Trim.Length) > 0 Then
            ' ---------------------------------------------------------------------------------
            Q = ""
            Q = "Select Usuario, Nombre From ADM_Usuarios "
            Q = Q & "Where  Habilitado =  '1'  "
            Q = Q & "And Clave_Acceso = '" & CveOperador.Trim & "' "
            Q = Q & "And Centro = '" & SessionUser._sCentro.Trim & "'  "
            LecturaQry_AMD(Q)
            If LecturaBD_AMD.Read Then
                Codigo = LecturaBD_AMD(0)
                Nombre = LecturaBD_AMD(1)
            End If
            LecturaBD_AMD.Close()
        End If
    End Sub
    ReadOnly Property strCodigo() As String
        Get
            Return Codigo
        End Get
    End Property
    ReadOnly Property strNombre() As String
        Get
            Return Nombre
        End Get
    End Property
    Public Sub Fecha_Hora_dia()
        FH_dia = DateAndTime.Today.ToString("yyyy-MM-dd ")
    End Sub
    Public Sub Status_Orden(ByVal Orden As String)
        LecturaQry("PA_Check_Existence_Production_Order '" & Orden.Trim & "', '" & SessionUser._sCentro.Trim & "' ")
    End Sub
    ReadOnly Property valStatusOP() As String
        Get
            Return StatusOP
        End Get
    End Property
    ReadOnly Property valCountOP() As String
        Get
            Return CountValOP
        End Get
    End Property
    Public Sub Compuesto_bom(ByVal Producto As String)
        QRY = ""
        QRY = "Select ComExt_ComCodigo From CompuestoExtrusion "
        QRY = QRY & "Where comext_pt_centro = '" & SessionUser._sCentro.Trim & "' "
        QRY = QRY & "And comext_pt_codigo = '" & Producto.Trim & "' "
        QRY = QRY & "And bom = '1' "
        cnnMsi.consulta(QRY)
        Do While (cnnMsi.dataReader.Read())
            Cod_Comp = cnnMsi.dataReader(0)
        Loop
        cnnMsi.cerrar()
    End Sub
    Public Sub Valida_Producto(ByVal ODF As String)
        QRY = ""
        QRY = "SELECT PTE.Grpprod,PTE.Descr,PTE.Empaque,PTE.PesoTeorico,OP.Estatus_Activa, PTE.Codigo,"
        QRY = QRY & "OP.cantidad_programada_tramos,OP.Equipo_Basico,OP.GrupMaterial,PTE.Sobrepeso,"
        QRY = QRY & "PTE.ConCombinado,PTE.PesoAcc,PTE.PesoEmb,c.DesEmp "
        QRY = QRY & "FROM " & SessionUser._sCentro.Trim & "_OrdenProduccion OP, CAT_ProductoTerminado PTE, Empaques_PTE c "
        QRY = QRY & "WHERE PTE.Codigo =OP.Producto  "
        QRY = QRY & "AND PTE.Centro = OP.Planta "
        QRY = QRY & "AND c.Centro = PTE.Centro "
        QRY = QRY & "AND c.CodEmp = PTE.Empaque "
        QRY = QRY & "AND OP.Orden_Produccion = '" & ODF.Trim & "' "
        QRY = QRY & "AND OP.Planta = '" & SessionUser._sCentro.Trim & "' "
        QRY = QRY & "And OP.Estatus_Activa = 1 "
        LecturaQry(QRY)
        VCountProducto = LecturaBD.HasRows
    End Sub
    ReadOnly Property valVCountProducto() As String
        Get
            Return VCountProducto
        End Get
    End Property
    Public Sub Valida_Usuario(ByVal Usr As String, ByVal Cve As String)
        LecturaQry_AMD("PA_Autentifica_Usuario_3 '" & Usr.Trim & "', '" & Cve.Trim & "'")
        Contador = 0
        Do While (LecturaBD_AMD.Read)
            'habilitado = "" & LecturaBD_AMD(0)
            'SessionUser._sAlias = "" & LecturaBD_AMD(1)
            'strPlanta = "" & LecturaBD_AMD(2)
            'strPlanta = strPlanta.Trim
            'Password_Usr = "" & LecturaBD_AMD(3)
            'StrusrNom = "" & LecturaBD_AMD(4)
            'strNomPlanta = "" & LecturaBD_AMD(5)
            'Strtipo = "" & LecturaBD_AMD(6)
            'Depto = "" & LecturaBD_AMD(7)
            'gPerfil = "" & LecturaBD_AMD(8)
            'strAmbiente = "" & LecturaBD_AMD(10)
            'IdCadenas = "" & LecturaBD_AMD(11)
            Contador = Contador + 1
        Loop
        LecturaBD_AMD.Close()
    End Sub
    ReadOnly Property valContador() As String
        Get
            Return Contador
        End Get
    End Property

    'ReadOnly Property valNomUser() As String
    '    Get
    '        Return StrusrNom
    '    End Get
    'End Property

    Public Sub Valida_Permisos_Usuario(ByVal Usr As String, ByVal Cve As String)
        LecturaQry_AMD("PA_Autentifica_Usuario_3 '" & Usr.Trim & "', '" & Cve.Trim & "'")
        Usr_Cont = 0
        Do While (LecturaBD_AMD.Read)
            pHabilitado = "" & LecturaBD_AMD(0)
            pstrusr = "" & LecturaBD_AMD(1)
            pPlanta = "" & LecturaBD_AMD(2)
            pUsrNom = "" & LecturaBD_AMD(4)
            pCodPer = "" & LecturaBD_AMD(8)
            pAlta = "" & LecturaBD_AMD(12)
            pBaja = "" & LecturaBD_AMD(13)
            pCambio = "" & LecturaBD_AMD(14)
            pImp = "" & LecturaBD_AMD(15)
            pNotif = "" & LecturaBD_AMD(16)
            pContab = "" & LecturaBD_AMD(17)
            pAutSBPeso = "" & LecturaBD_AMD(18)
            Usr_Cont = Usr_Cont + 1
        Loop
        LecturaBD_AMD.Close()
    End Sub
    ReadOnly Property pContador() As String
        Get
            Return Usr_Cont
        End Get
    End Property
    ReadOnly Property Alta() As String
        Get
            Return pAlta
        End Get
    End Property
    ReadOnly Property Baja() As String
        Get
            Return pBaja
        End Get
    End Property
    ReadOnly Property Cambio() As String
        Get
            Return pCambio
        End Get
    End Property
    ReadOnly Property Imprime() As String
        Get
            Return pImp
        End Get
    End Property
    ReadOnly Property Notifica() As String
        Get
            Return pAlta
        End Get
    End Property
    ReadOnly Property Contabiliza() As String
        Get
            Return pContab
        End Get
    End Property
    ReadOnly Property Autoriza() As String
        Get
            Return pAutSBPeso
        End Get
    End Property
    Public Sub Valida_Acceso_Main(ByVal CvePuesto As String, ByVal frmName As Form, Area As String)
        Dim Count As Integer
        LecturaQry_AMD("PA_Valida_Accesos '" & SessionUser._sCentro.Trim & "', '" & SessionUser._sIdPerfil.Trim & "', '" & Area.Trim & "'")
        Count = 0
        Notif_Manual = False
        Do While (LecturaBD_AMD.Read())
            Count = Count + 1
            strAccMod = LecturaBD_AMD(2)
            'Tipo_Prog = LecturaBD_AMD(11)
            ActButMS_Main(frmName, strAccMod.Trim)
            'If strAccMod.Trim = "NM" And Tipo_Prog.Trim = "NOTIF" Then
            'Notif_Manual = True
            'End If
        Loop
        LecturaBD_AMD.Close()
    End Sub

    Public Sub Valida_Acceso_Admin(ByVal CvePuesto As String, ByVal frmName As Form, Area As String)
        LecturaQry_AMD("PA_Valida_Accesos '" & SessionUser._sCentro.Trim & "', '" & CvePuesto.Trim & "', '" & Area.Trim & "'")
        Contador = 0
        Notif_Manual = False
        Do While (LecturaBD_AMD.Read())
            Contador = Contador + 1
            strAccMod = LecturaBD_AMD(2)
            'Tipo_Prog = LecturaBD_AMD(11)
            ActButMS_Admin(frmName, strAccMod.Trim)
            'If strAccMod.Trim = "NM" And Tipo_Prog.Trim = "NOTIF" Then
            'Notif_Manual = True
            'End If
        Loop
        LecturaBD_AMD.Close()
    End Sub
End Class
