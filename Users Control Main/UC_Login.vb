Imports Utili_Generales
Imports Utili_Generales.ConfigScales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Imports Atlas.Validaciones
Imports IdentityModel.OidcClient
Imports WinFormsSSO
Imports System.Text
Imports System.Collections.Generic

Public Class UC_Login

	Public Event TPassLeave As EventHandler

#Region "Variables"
	Dim _oidcClient As OidcClient
	Dim email As String
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
	Private Sub LoginValidate(Optional ByVal sso As Boolean = False)
		Dim IdSession As Boolean

		If sso = True Then
			LoginUser.Login_Alias = email
			LoginUser.Login_Pass = ""
		Else

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
		End If


		IdSession = Users.Login(LoginUser._Login_Alias, LoginUser._Login_Pass, sso)
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
				BtnLoginSSO.Visible = False
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
			BtnLoginSSO.Visible = False
		End If
	End Sub

	Public Sub Logo(ByVal Cadena As Integer)
		Me.Text = "MEXICHEM SOLUCIONES INTEGRALES"
		FrmMain.MenuStrip1.Visible = True
	End Sub

	Private Async Sub BtnLoginSSO_Click(sender As Object, e As EventArgs) Handles BtnLoginSSO.Click
		Dim options As New OidcClientOptions With
		{
			.Authority = "https://sso.domoapps.mx/sts",
			.ClientId = "Atlas_Amanco",
			.Scope = "openid email client_api offline_access",
			.RedirectUri = "https://localhost/winforms.client",
			.Browser = New WinFormsWebView()
		}

		_oidcClient = New OidcClient(options)

		Dim result = Await _oidcClient.LoginAsync()

		If result.IsError Then
			MessageBox.Show(Me, result.[Error], "Login", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		Else
			Dim l_claims As New List(Of String)
			For Each claim As Security.Claims.Claim In result.User.Claims

				If claim.Type = "email" Then
					l_claims.Add(claim.Value)
				End If
			Next

			email = l_claims(0)


			LoginValidate(True)
			'Dim sb = New StringBuilder(128)

			'For Each claim As Security.Claims.Claim In result.User.Claims
			'	sb.AppendLine($"{claim.Type}: {claim.Value}")
			'Next

			'If Not String.IsNullOrWhiteSpace(result.RefreshToken) Then
			'	sb.AppendLine()
			'	sb.AppendLine($"refresh token: {result.RefreshToken}")
			'End If

			'If Not String.IsNullOrWhiteSpace(result.IdentityToken) Then
			'	sb.AppendLine()
			'	sb.AppendLine($"identity token: {result.IdentityToken}")
			'End If

			'If Not String.IsNullOrWhiteSpace(result.AccessToken) Then
			'	sb.AppendLine()
			'	sb.AppendLine($"access token: {result.AccessToken}")
			'End If

			'Dim text As String = sb.ToString()
		End If
	End Sub


#End Region

End Class
