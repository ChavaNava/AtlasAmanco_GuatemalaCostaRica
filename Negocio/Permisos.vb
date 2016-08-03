Imports System
Imports System.IO.Ports
Imports System.Threading
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Configuration
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class Permisos
#Region "Variables Acceso"
    Dim arryTextFile() As String
    Dim Form_Atlas As String
    Dim Form_Descripcion As String
    Dim Form_Name As String
    Dim Frm As Form
    Dim gPrograma As String = ""
    Dim xSQL As String
    Public strNameForm As String        'Nombre de la Form
    Public gAlta As Boolean             'Permiso Alta
    Public gBaja As Boolean             'Permiso Baja
    Public gCambio As Boolean           'Permiso Cambio
    Public gVisualiza As Boolean        'Permiso Visualizar
    Public gImprimir As Boolean         'Permiso Imprimir
    Public gNotificar As Boolean        'Permiso Notificar
    Public stForm As Boolean            'Status de la Form
    Public TipoForm As String           'Tipo Form
#End Region

#Region "Variables SAP_Status"

#End Region

#Region "Variables Asigna turno"
    Dim dateRegistro As Date
    Dim strTurno As String
#End Region

#Region "Variables Habilita Bascula"
    Dim Result As DialogResult
    Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
#End Region

#Region "Activar Basculas"
    Dim Bascula As String
    Dim Basculas() As String
    Dim C As Integer
    Dim Numbascula As String
    Dim SP As SerialPort
#End Region

#Region "Instancia Unica"
    Dim objMutex As Mutex
#End Region

#Region "Metodos"
    Public Sub Accesos(ByVal Modulo As String, ByVal Area As String, ByVal Perfil As String, ByVal Secc As String, Texto_Cabeceras As String)
        Dim Titulo As String = ""
        Dim Name_Raiz As String = ""
        EXTINY = Area
        Seccion = Secc
        strNameForm = ""
        If Area = "1" Then
            Titulo = "" & Texto_Cabeceras.Trim & " Extrusión"
        ElseIf Area = "2" Then
            Titulo = "" & Texto_Cabeceras.Trim & " Inyección"
        ElseIf Area = "3" Then
            Titulo = "" & Texto_Cabeceras.Trim & " Rotomoldeo"
        ElseIf Area = "" Then
            Titulo = "" & Texto_Cabeceras.Trim & ""
        End If

        'Verifica permisos del usuario
        LecturaQry_AMD("PA_Permisos_Usuario '" & SessionUser._sCentro.Trim & "', '" & Modulo.Trim & "', '" & SessionUser._sIdPerfil.Trim & "' ")
        If (LecturaBD_AMD.Read) Then
            strNameForm = LecturaBD_AMD(1)
            gAlta = LecturaBD_AMD(5)
            gBaja = LecturaBD_AMD(6)
            gCambio = LecturaBD_AMD(7)
            gVisualiza = LecturaBD_AMD(8)
            gImprimir = LecturaBD_AMD(9)
            gNotificar = LecturaBD_AMD(10)
            Name_Raiz = LecturaBD_AMD(11)
            Form_Atlas = LecturaBD_AMD(12)
            stForm = LecturaBD_AMD(13)
            LecturaBD_AMD.Close()

            If Form_Atlas <> "NA" Then
                gPermisos = gAlta & "," & gBaja & "," & gCambio & "," & gVisualiza & "," & gImprimir & "," & gNotificar

                If gPermisos = "False,False,False,False,False,False" Or gPermisos = "" Then
                    MensajeBox.Mostrar("El usuario no tiene permisos de ejecución del Modulo: ", strNameForm.Trim, MensajeBox.TipoMensaje.Critical)
                Else

                    Dim formName As String = "Atlas." & Form_Atlas.Trim

                    Frm = Activator.CreateInstance(Type.GetType(formName, True, True))
                    Frm.Icon = Util.ApplicationIcon()
                    'Valida parametrizacion de form

                    'Catalogos

                    'Se activa form

                    'Log
                    'Log.Alta(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, SessionUser._sCadena, SessionUser._sPassword, Form_Atlas, "Ingreso")
                    Frm.Text = Titulo.Trim
                    Frm.ShowDialog()
                End If
            End If
        Else
            MensajeBox.Mostrar("El usuario no tiene permisos de ejecución del Modulo: ", strNameForm.Trim, MensajeBox.TipoMensaje.Critical)
            LecturaBD_AMD.Close()
        End If
    End Sub

    Public Sub Cerrar(Modulo As String, Accion As String)
        If SessionUser._sCentro <> Nothing Then
            Log.Alta(SessionUser._sCentro, SessionUser._sAlias, SessionUser._sCadena, SessionUser._sPassword, Modulo, Accion)
        End If
    End Sub

    Private Function fetchInstance(ByVal fullyQualifiedClassName As String) As Object
        Dim nspc As String = fullyQualifiedClassName.Substring(0, fullyQualifiedClassName.LastIndexOf("."c))
        Dim o As Object = Nothing
        Dim ay As Object
        Try
            For Each ay In Assembly.GetExecutingAssembly().GetReferencedAssemblies()
                If (ay.Name = "Atlas") Then
                    o = Assembly.Load(ay).CreateInstance(fullyQualifiedClassName)
                    Exit For
                End If
            Next
        Catch
        End Try
        Return o
    End Function

    Public Sub SAP_Status(ByVal Modulo As String, ByVal TSS As ToolStripStatusLabel)
        StatusSap = SAP_Conexion.Estatus(Modulo)
        Select Case StatusSap
            Case "True"
                TSS.Image = Global.Atlas.My.Resources.btn_SAPOk
                TSS.Text = "En comunicación con SAP"
                TSS.ForeColor = Color.Blue
            Case "False"
                TSS.Image = Global.Atlas.My.Resources.btn_SAPFail
                TSS.Text = "No hay comunicación con SAP"
                TSS.ForeColor = Color.Red
        End Select
    End Sub

    Public Sub Parametros_MenuPTE(ByVal LbOpe As Label, CBOpe As ComboBox, NameForm As String, BtnPesar As Button, BtnImp As Button, TSConsulta As ToolStripMenuItem)
        Dim id As String = ""
        Dim St As Boolean
        LecturaQry_AMD("PA_Parametros '" & SessionUser._sCentro.Trim & "', '" & NameForm & "' ")
        Do While (LecturaBD_AMD.Read)
            id = LecturaBD_AMD(0)
            St = LecturaBD_AMD(4)

            Select Case id
                Case Is = "4"
                    Idp_4 = St
                Case Is = "6"
                    If St = True Then
                        LbOpe.Visible = St
                        LbOpe.Enabled = St
                        CBOpe.Visible = St
                        CBOpe.Enabled = St
                    Else
                        LbOpe.Visible = St
                        LbOpe.Enabled = St
                        CBOpe.Visible = St
                        CBOpe.Enabled = St
                    End If

            End Select
        Loop
        LecturaBD_AMD.Close()

        'BtnPesar.Enabled = gNotificar
        'BtnImp.Enabled = gImprimir
        'TSConsulta.Enabled = gVisualiza

    End Sub

    Public Sub Habilita_Bascula(ByVal Perfil As String, ByVal TPC As TextBox, ByVal Time As System.Windows.Forms.Timer, ByVal ValCodigo As String, ByVal LPBM As Label)
        strNumeroBascula = ""
        strNumeroBascula = ValCodigo.Trim

        If ValCodigo = "M" Then
            TPC.Enabled = True
            TPC.Visible = True
            LPBM.Visible = True
            Time.Enabled = False
        Else
            Time.Enabled = True
        End If

    End Sub

    Public Sub Activar_Bascula()
        'Se lee el archivo de configuración--------------------------------------------------------
        Ini.Archivo = "c:\atlas\temp\atlas.ini"
        Try
            elDato = Ini.LeeIni("Bascula", "Bascula").Trim
            C_Bascula = Mid(elDato, 1, Len(elDato) - 1)
            Val_Bascula = C_Bascula
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            elDato = ""
        End Try

        ValCodigoBascula = Val_Bascula.Trim

        Try
            elDato = Ini.LeeIni("Bascula", "Bascula_2").Trim
            C_Bascula_2 = Mid(elDato, 1, Len(elDato) - 1)
            Val_Bascula_2 = C_Bascula_2
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            elDato = ""
        End Try

        ValCodigoBascula_2 = Val_Bascula_2.Trim

        Try
            elDato = Ini.LeeIni("Bascula", "Bascula_3").Trim
            C_Bascula_3 = Mid(elDato, 1, Len(elDato) - 1)
            Val_Bascula_3 = C_Bascula_3
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            elDato = ""
        End Try

        ValCodigoBascula_3 = Val_Bascula_3.Trim
        'Se activan las basculas ------------------------------------------------------------------
        Bascula = C_Bascula & "|" & C_Bascula_2 & "|" & C_Bascula_3
        Basculas = Bascula.Split("|")



        For C = 0 To UBound(Basculas)
            Numbascula = Basculas(C)

            If Numbascula <> "M" Then
                If C = 0 Then
                    SP = FrmMain.SerialPort1
                ElseIf C = 1 Then
                    SP = FrmMain.SerialPort2
                ElseIf C = 2 Then
                    SP = FrmMain.SerialPort3
                End If
                QRY = "Select Puerto,Baudios,BitsDatos,Ch1,Ch2,LenghtLec,AddChar "
                QRY = QRY & "From CNF_basculas "
                QRY = QRY & "Where C_Bascula = '" & Numbascula.Trim & "' "
                QRY = QRY & "And Centro = '" & SessionUser._sCentro & "' "
                LecturaQry_AMD(QRY)

                Do While (LecturaBD_AMD.Read)
                    NumPto = LecturaBD_AMD(0)
                    Baudios = LecturaBD_AMD(1)
                    DataBit = LecturaBD_AMD(2)
                    CH1 = LecturaBD_AMD(3)
                    CH2 = LecturaBD_AMD(4)
                    LenghtLec = LecturaBD_AMD(5)
                    AddChar = LecturaBD_AMD(6)
                Loop
                LecturaBD_AMD.Close()
                If SP.IsOpen = True Then
                    SP.Close()
                    SP.Dispose()
                End If
                If SP.IsOpen <> True Then
                    SP.PortName = "COM" + NumPto.ToString.Trim
                    SP.BaudRate = Baudios
                    SP.DataBits = DataBit
                    SP.Parity = IO.Ports.Parity.None
                    SP.StopBits = IO.Ports.StopBits.One
                    SP.Open()
                End If
            End If
        Next C
    End Sub

    Public Sub Instancia_Unica()
        Ini = New CIniClass
        objMutex = New Mutex(False, "SINGLE_INSTANCE_APP_MUTEX")
        If objMutex.WaitOne(0, False) = False Then
            objMutex.Close()
            objMutex = Nothing
            MessageBox.Show("****  La aplicacion ya se encuentra ejecutandose   ******")
            FrmMain.Close()
            Application.Exit()
        End If
    End Sub

    'Public Sub Reset_Sesion()
    '    AbrirAmanco.Close()
    '    Atlas_Main.Text = ""
    '    SessionUser._sIdPerfil = ""
    '    Atlas_Main.TClave.Text = ""
    '    Atlas_Main.TClave.Enabled = True
    '    DesButtons_Main(Atlas_Main)
    '    Atlas_Main.TUsr.Enabled = True
    '    Atlas_Main.TUsr.Text = ""
    '    Atlas_Main.TClave.Enabled = True
    '    Atlas_Main.TClave.Text = ""
    '    Atlas_Main.GB_Login.Visible = True
    '    Atlas_Main.TUsr.Focus()
    '    Log.Alta(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, SessionUser._sCadena, SessionUser._sPassword, "Main", "Reiniciar Sesión")
    'End Sub

    Public Sub Consulta_Parametrizacion(ByVal NomForma As String)

    End Sub
#End Region

#Region "Propiedades"

    ReadOnly Property FName() As String
        Get
            Return Form_Atlas
        End Get
    End Property

    ReadOnly Property Turno() As String
        Get
            Return strTurno
        End Get
    End Property
    'Status SAP
    ReadOnly Property r_Conexion_SAP As String
        Get
            Return StatusSap
        End Get
    End Property

#End Region

End Class
