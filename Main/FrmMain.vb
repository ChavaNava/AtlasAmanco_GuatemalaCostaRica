Imports System.Deployment.Application
Imports System.Threading
Imports System.Data.SqlClient
Imports System.Configuration
Imports Utili_Generales
Imports Utili_Generales.ConfigScales
Imports SQL_DATA
Imports System.IO
Imports System.Drawing.Text
Imports System.IO.Ports
Imports Atlas.Accesos.CLVarGlobales
Imports Atlas.Accesos.Puertos
Imports Atlas.Consultations
Imports Atlas.Calidad
Imports Atlas.Planeacion
Imports Atlas.Tiempos
Imports Atlas.ProduccionProceso
Imports Atlas.ExtrusionPeru


Public Class FrmMain
#Region "Variables miembro"
    Dim myDataReader As Data.SqlClient.SqlDataReader
    Dim Q As String
    Dim StrMod As SByte
    Dim Lectura As String = ""
    Dim Resultado As String = ""
    Dim Count1 As Integer = 0
    Dim Permiso As New Permisos
    Dim Seguridad As New FrontUtils
    Dim Pass_md5 As String

    Dim Bascula As String
    Dim Basculas() As String
    Dim C As Integer
    Dim Numbascula As String
    Dim SP As SerialPort

#End Region

#Region "Constructores"
    ' Llamada necesaria para el diseñador.
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region

#Region "Clases anidadas"
#End Region

#Region "Propiedades"
#End Region

#Region "Metodos"
    Private Sub Iniciar()
        'Deshabilita botones del MenuStrip
        DesButtons_Main(Me)
        'Hubicar el foco en el campo Usuario
        Login.TUser.Focus()
        'Establece que es una instancia unica y no permite abrir mas de una vez la aplicación
        Permiso.Instancia_Unica()
        'Presenta información de versión en StatusStrip
        Version()
    End Sub

    Private Sub Version()
        If My.Application.IsNetworkDeployed Then
            Dim ver As System.Deployment.Application.ApplicationDeployment
            ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment
            LVersion.Text = ver.CurrentVersion.ToString & "   "
            Atlas_Version.Version = LVersion.Text.Trim
        Else
            LVersion.Text = "Versión Desarrollo"
            Atlas_Version.Version = LVersion.Text.Trim
        End If
    End Sub

    Public Sub Logo(ByVal Cadena As Integer)
                Me.Text = "MEXICHEM SOLUCIONES INTEGRALES"
                MenuStrip1.Visible = True
    End Sub

    Private Sub Files()
        Dim Exist_Folder As Boolean
        Dim Exist_File As Boolean
        'Revisa qeu existe el directorio
        Exist_Folder = Boot_Files.Valida_folder

        If Exist_Folder <> True Then
            Boot_Files.Crea_folder()

            Exist_File = Boot_Files.Valida_file

            If Exist_File <> True Then
                Boot_Files.Write_File()
            End If
        Else
            Exist_File = Boot_Files.Valida_file

            If Exist_File <> True Then
                Boot_Files.Write_File()
            End If
        End If

    End Sub

#End Region

#Region "Colección"
#End Region

#Region "Campos"
#End Region

#Region "Eventos"
    Private Sub MenuPrin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Files()
        'Carga el icono de la aplicación
        Me.Icon = Util.ApplicationIcon()
        Util.CurrentCulture()
        'Seguridad.DeshabilitarMenus(MenuStrip1)
        Iniciar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub TxtClave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub BtnAmanProdTerm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Permiso.Accesos("PTE", "")
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Acercade.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Close()
    End Sub

    Private Sub Reiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reiniciar.Click
        restart_session()
    End Sub

    Private Sub MP_ADM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MP_ADM.Click
        Permiso.Accesos("MP_ADM", "", SessionUser._sIdPerfil, "", "Administración")
    End Sub

    Private Sub ExtrusiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MP_ALE.Click
        Permiso.Accesos("MP_ALE", "1", SessionUser._sIdPerfil, "E", "Almacen")
    End Sub

    Private Sub InyecciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MP_ALI.Click
        Permiso.Accesos("MP_ALI", "2", SessionUser._sIdPerfil, "I", "Almacen")
    End Sub

    Private Sub MP_PTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MP_PTE.Click
        If SessionUser._sCentro.Trim = "PE01" Then
            PermisosExtrusionPeru.Accesos("MP_PTE", "1", SessionUser._sIdPerfil, "E", "Captura de Pesaje")
        Else
            Permiso.Accesos("MP_PTE", "1", SessionUser._sIdPerfil, "E", "Captura de Pesaje")
        End If
    End Sub

    'Private Sub MP_SUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MP_SUP.Click
    '    Permiso.Accesos("MP_SUP", "", SessionUser._sIdPerfil, "", "Supervisión")
    'End Sub

    Private Sub MP_PTI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MP_PTI.Click
        Select Case SessionUser.sCentro
            Case Is = "AR01"

            Case Else
                Permiso.Accesos("MP_PTI", "2", SessionUser._sIdPerfil, "I", "Captura Pesaje")
        End Select
    End Sub

    Private Sub MP_CINY_Click(sender As System.Object, e As System.EventArgs)
        Permiso.Accesos("MP_CINY", "2", SessionUser._sIdPerfil, "I", "")
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Acerca_de.Click
        Acercade.ShowDialog()
    End Sub

    Private Sub MP_PRDDIA_Click(sender As System.Object, e As System.EventArgs)
        Permiso.Accesos("MP_PRDDIA", "", SessionUser._sIdPerfil, "", "")
    End Sub

    Private Sub MP_ACTUALIZA_Click(sender As System.Object, e As System.EventArgs) Handles MP_ACTUALIZA.Click
        AtlasUpdate.Actualiza_Version()
    End Sub

    Private Sub ProducciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Permiso.Accesos("MP_CPEXT", "1", SessionUser._sIdPerfil, "E", "")
    End Sub

    Private Sub MP_CPROD_Click(sender As System.Object, e As System.EventArgs) Handles MP_CPROD.Click
        Permiso.Accesos("MP_CPROD", "", SessionUser._sIdPerfil, "", "Producción")
    End Sub

    Private Sub CapturaScrapInyecciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MP_SCI.Click
        Permiso.Accesos("MP_SCI", "2", SessionUser._sIdPerfil, "I", "Captura Pesaje")
    End Sub

    Private Sub MP_PTP_Click(sender As System.Object, e As System.EventArgs) Handles MP_PTP.Click
        Permiso.Accesos("MP_PTP", "2", SessionUser._sIdPerfil, "I", "Producción Terminada en Piso ")
    End Sub

    Private Sub MP_PROD_DR_EXT_Click_1(sender As System.Object, e As System.EventArgs) Handles MP_PROD_DR_EXT.Click
        Permiso.Accesos("MP_PROD_DR_EXT", "1", SessionUser._sIdPerfil, "E", "Consulta Producción")
    End Sub

    Private Sub MP_PROD_DR_INY_Click(sender As System.Object, e As System.EventArgs) Handles MP_PROD_DR_INY.Click
        Permiso.Accesos("MP_PROD_DR_INY", "2", SessionUser._sIdPerfil, "I", "Consulta Producción")
    End Sub


#End Region

#Region "Basculas"

    Public Sub Activar_Bascula()
        Dim Scales() As String

        Scales = ReedFile(2, "C:\App Settings\Scales.ini").Split("|")
        Val_Bascula = Mid(Scales(0), 11, 6)
        Val_Bascula_2 = Mid(Scales(1), 13, 6)
        Val_Bascula_3 = Mid(Scales(2), 13, 6)

        'Bascula 1
        ValCodigoBascula = Val_Bascula.Trim
        'Bascula 2
        ValCodigoBascula_2 = Val_Bascula_2.Trim
        'Bascula 3
        ValCodigoBascula_3 = Val_Bascula_3.Trim


        'Se activan las basculas ------------------------------------------------------------------
        Bascula = Val_Bascula.Trim & "|" & Val_Bascula_2.Trim & "|" & Val_Bascula_3.Trim
        Basculas = Bascula.Split("|")

        For C = 0 To UBound(Basculas)
            Numbascula = Basculas(C)
            Select Case Numbascula.Trim
                Case Is = "M"
                    strNumeroBascula = "M"
                Case Else
                    If C = 0 Then
                        SP = SerialPort_1
                    ElseIf C = 1 Then
                        SP = SerialPort_2
                    ElseIf C = 2 Then
                        SP = SerialPort_3
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
                        Try
                            SP.PortName = "COM" + NumPto.ToString.Trim
                            SP.BaudRate = Baudios
                            SP.DataBits = DataBit
                            SP.Parity = IO.Ports.Parity.None
                            SP.StopBits = IO.Ports.StopBits.One
                            SP.Open()
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString + " ", "No Existe Bascula o el Puerto no Corresponde, Verifique la configuración")
                            Exit Sub
                        End Try

                    End If
                    strNumeroBascula = Numbascula
            End Select


            'If Numbascula.Trim Is "M" Then
            '    strNumeroBascula = "M"
            'Else

            'End If
        Next C

    End Sub

    Public Sub restart_session()
        Log.Alta(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, SessionUser._sCadena, SessionUser._sPassword, "Main", "Reiniciar Sesión")
        Dim Session As New SessionUser
        DesButtons_Main(Me)
        Login.CB_Centro.DataSource = Nothing
        Login.CB_Centro.Text = ""
        Login.CB_Centro.Enabled = False
        Login.GB_Login.Visible = True
        Login.TUser.Text = ""
        Login.TUser.Enabled = True
        Login.TPass.Text = ""
        Login.TPass.Enabled = True
        Login.TUser.Focus()
    End Sub

#End Region


    Private Sub MP_PTE_OLD_Click(sender As System.Object, e As System.EventArgs) Handles MP_PTE_OLD.Click
        Permiso.Accesos("MP_PTE_OLD", "1", SessionUser._sIdPerfil, "E", "Captura de Pesaje Producto Terminado Extrusión")
    End Sub

    Private Sub MP_SCE_OLD_Click(sender As System.Object, e As System.EventArgs) Handles MP_SCE_OLD.Click
        Permiso.Accesos("MP_SCE_OLD", "1", SessionUser._sIdPerfil, "E", "Captura de Pesaje Scrap Extrusión")
    End Sub

    Private Sub MP_PTR_Click(sender As System.Object, e As System.EventArgs) Handles MP_PTR.Click
        Permiso.Accesos("MP_PTR", "3", SessionUser._sIdPerfil, "R", "Captura de Pesaje ")
    End Sub

    Private Sub Atlas_Main_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Permiso.Cerrar(Me.Name, "Salir")
    End Sub

    Private Sub MP_MPExtrusion_Click(sender As System.Object, e As System.EventArgs) Handles MP_MPExtrusion.Click
        PermisoAdminPesajes.Accesos("MP_MPExtrusion", "1", SessionUser._sIdPerfil, "E", "Modificación de Pesajes ")
    End Sub

    Private Sub MP_NEXT_Click(sender As System.Object, e As System.EventArgs) Handles MP_NEXT.Click
        ExtrusionProcess.Permissions.Access("MP_NEXT", SessionUser._sIdPerfil, "Notifica ")
    End Sub

    Private Sub MP_REP_PTE_Click(sender As System.Object, e As System.EventArgs) Handles MP_REP_PTE.Click
        Permiso.Accesos("MP_REP_PTE", "1", SessionUser._sIdPerfil, "E", "Reportes Producto Terminado ")
    End Sub

    Private Sub MP_REP_SCE_Click(sender As System.Object, e As System.EventArgs) Handles MP_REP_SCE.Click
        Permiso.Accesos("MP_REP_SCE", "1", SessionUser._sIdPerfil, "E", "Reportes Scrap ")
    End Sub

    Private Sub MP_Control_Tiempos_Ext_Click(sender As Object, e As EventArgs) Handles MP_Control_Tiempos_Ext.Click
        PermisoTiempos.Accesos("MP_RHE", "1", SessionUser._sIdPerfil, "E", "Captura Tiempos Productivos / Paro")
    End Sub

    Private Sub MP_Control_Tiempos_Iny_Click(sender As Object, e As EventArgs) Handles MP_Control_Tiempos_Iny.Click
        'PermisoTiempos.Accesos("MP_Control_Tiempos_Iny", "2", SessionUser._sIdPerfil, "I", "Captura Tiempos Productivos / Paro")
    End Sub

    Private Sub MP_REXT_Click(sender As System.Object, e As System.EventArgs) Handles MP_REXT.Click
        Consultations.Permissions.Access("MP_REXT", "1", SessionUser._sIdPerfil, "E", "Reportes Producción ", 0)
    End Sub

    Private Sub MPE_A_Click(sender As System.Object, e As System.EventArgs) Handles MPE_A.Click
        Consultations.Permissions.Access("MP_MPEA", "1", SessionUser._sIdPerfil, "E", "Monitor Producción ", 1)
    End Sub

    Private Sub MP_AvanceProduccion_Click(sender As Object, e As EventArgs) Handles MP_AvanceProduccion.Click
        Calidad.Permissions.Access("MP_AvanceProduccion", "1", SessionUser._sIdPerfil, "E", "Consulta Avance Producción ", 0)
    End Sub

    Private Sub MP_ProduccionPlaneacion_Click(sender As Object, e As EventArgs) Handles MP_ProduccionPlaneacion.Click
        Planeacion.Permissions.Access("MP_ProduccionPlaneacion", "1", SessionUser._sIdPerfil, "E", "Consulta Avance Producción ", 1)
    End Sub

    Private Sub MP_RHE_Click(sender As Object, e As EventArgs) Handles MP_RHE.Click
        PermisoTiempos.Accesos("MP_RHE", 1, SessionUser._sIdPerfil, "E", "Registro Horas Paro Extrusion")
    End Sub

    Private Sub MP_RHI_Click(sender As Object, e As EventArgs) Handles MP_RHI.Click
        PermisoTiempos.Accesos("MP_RHI", 2, SessionUser._sIdPerfil, "I", "Registro Horas Paro Inyección")
    End Sub
    Private Sub MP_ORDEXT_Click(sender As Object, e As EventArgs) Handles MP_ORDEXT.Click
        PermisoProduccionProceso.Accesos("MP_ORDEXT", 1, SessionUser._sIdPerfil, "E", "Producción en Proceso Extrusión")
    End Sub

    Private Sub MP_ORDINY_Click(sender As Object, e As EventArgs) Handles MP_ORDINY.Click
        PermisoProduccionProceso.Accesos("MP_ORDINY", 2, SessionUser._sIdPerfil, "I", "Producción en Proceso Inyección")
    End Sub

    Private Sub MP_CEXTR_Click(sender As Object, e As EventArgs) Handles MP_CEXTR.Click
        Consultations.Permissions.Access("MP_CEXTR", "1", SessionUser._sIdPerfil, "E", "Consulta Producción Extrusión ", 1)
    End Sub
End Class