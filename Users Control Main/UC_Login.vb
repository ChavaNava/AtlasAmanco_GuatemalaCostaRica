Imports Utili_Generales
Imports Utili_Generales.ConfigScales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Imports Atlas.Validaciones
Public Class UC_Login

    Public Event TPassLeave As EventHandler

#Region "Variables"

#End Region

#Region "Eventos"
    Private Sub TUser_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TUser.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TPass_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            LoginValidate()
        End If
    End Sub

    Private Sub CB_Centro_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Centro.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Validate_Centro()
        End If
    End Sub

    Private Sub CB_Centro_Click(sender As System.Object, e As System.EventArgs) Handles CB_Centro.Click
        If SessionUser._sMultiCentro = True Then
            CB_Centro.DataSource = Nothing
            Centros.CB_Centros(CB_Centro, SessionUser._sAlias.Trim, SessionUser._sPassword.Trim)
        End If
    End Sub

#End Region

#Region "Metodos"
    Private Sub LoginValidate()
        Dim IdSession As Boolean
        If TUser.Text = "" Then
            MensajeBox.Mostrar("Ingresar el nombre de usuario", "Verificar", MensajeBox.TipoMensaje.Exclamation)
            Exit Sub
        End If

        If TPass.Text = "" Then
            MensajeBox.Mostrar("Ingrese su contraseña para continuar", "Verificar", MensajeBox.TipoMensaje.Exclamation)
            Exit Sub
        End If

        LoginUser.Login_Alias = TUser.Text.Trim()
        LoginUser.Login_Pass = Crypto.MD5Calculate(TPass.Text.Trim)
        IdSession = Users.Login(LoginUser._Login_Alias, LoginUser._Login_Pass)
        If IdSession = True Then
            TUser.Enabled = False
            TPass.Enabled = False
            Logo(SessionUser.sCadena)
            If SessionUser._sMultiCentro = True Then
                CB_Centro.Focus()
                CB_Centro.Enabled = True
            Else
                CB_Centro.Text = SessionUser._sCentro
                FrmMain.Activar_Bascula()
                Gen_Valida.Valida_Acceso_Main(SessionUser._sIdPerfil, FrmMain, "MP%")
                Log.Alta(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, SessionUser._sCadena, SessionUser._sPassword, "Main", "Ingreso")
                FrmMain.Reiniciar.Enabled = True
                GB_Login.Visible = False
            End If
        Else
            MensajeBox.Mostrar("Nombre de usuario o contraseña incorrecta", "Verificar", MensajeBox.TipoMensaje.Exclamation)
            TUser.Text = ""
            TPass.Text = ""
            TUser.Focus()
        End If

    End Sub

    Private Sub Validate_Centro()
        If CB_Centro.SelectedValue Is Nothing Or CB_Centro.Text = "" Then
            MensajeBox.Mostrar("Seleccione un centro de operaciones", "Centro", MensajeBox.TipoMensaje.Exclamation)
            Exit Sub
        Else
            FrmMain.Activar_Bascula()
            Gen_Valida.Valida_Acceso_Main(SessionUser._sIdPerfil, FrmMain, "MP%")
            Log.Alta(SessionUser._sCentro, SessionUser._sAlias, SessionUser._sCadena, SessionUser._sPassword, "Main", "Ingreso")
            FrmMain.Reiniciar.Enabled = True
            SessionUser.sCentro = CB_Centro.SelectedValue
            GB_Login.Visible = False
        End If
    End Sub

    Public Sub Logo(ByVal Cadena As Integer)
        Select Case Cadena
            Case Is = 1
                FrmMain.Panel3.BackgroundImage = Global.Atlas.My.Resources.Logo_Fluent
                FrmMain.Panel3.BackgroundImageLayout = ImageLayout.Zoom
                Me.Text = "MEXICHEM SOLUCIONES INTEGRALES"
                FrmMain.MenuStrip1.Visible = True
        End Select
    End Sub

#End Region

End Class
