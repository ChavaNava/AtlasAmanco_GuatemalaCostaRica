Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class UC_LoginUser
    Public Event Leave1 As EventHandler
#Region "Variables Miembro"
    Dim Pass_md5 As String
#End Region

#Region "Eventos"

    Private Sub TPassNotifier_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            Validate_Notifier()
        End If
    End Sub

    Private Sub TPassNotifier_Enter(sender As System.Object, e As System.EventArgs)
        TPassNotifier.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TPassNotifier_KeyPress_1(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPassNotifier.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TPassNotifier_Enter_1(sender As System.Object, e As System.EventArgs) Handles TPassNotifier.Enter
        TPassNotifier.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TPassNotifier_Leave(sender As System.Object, e As System.EventArgs) Handles TPassNotifier.Leave
        Dim IdLogin As Boolean
        Pass_md5 = Crypto.MD5Calculate(TPassNotifier.Text.Trim)
        IdLogin = Users.Login_Notifier(SessionUser._sAlias, Pass_md5.Trim)
        CodOperador.Text = ""
        NomOperador.Text = ""

        If IdLogin = True Then
            CodOperador.Text = LoginNotifier._nAlias
            NomOperador.Text = LoginNotifier._nNombre
            RaiseEvent Leave1(sender, e)
        Else
            MensajeBox.Mostrar("Nombre de usuario o contraseña incorrecta", "Verificar", MensajeBox.TipoMensaje.Exclamation)
            TPassNotifier.Text = ""
            TPassNotifier.Focus()
        End If
    End Sub
#End Region

#Region "Metodos"
    Public Sub Validate_Notifier()
        Dim ValueNotifier As Integer = 0
        If TPassNotifier.Text = "" Then
            MensajeBox.Mostrar("Ingrese su contraseña para continuar", "Verificar", MensajeBox.TipoMensaje.Exclamation)
            Exit Sub
        Else
            Dim Notifier As Boolean
            Pass_md5 = Crypto.MD5Calculate(TPassNotifier.Text.Trim)
            Notifier = Users.Login_Notifier(SessionUser._sAlias, SessionUser._sPassword)
            CodOperador.Text = ""
            NomOperador.Text = ""

            If Notifier = True Then
                CodOperador.Text = LoginNotifier._nAlias
                NomOperador.Text = LoginNotifier._nNombre
                TPassNotifier.BackColor = Color.White
            Else
                MensajeBox.Mostrar("Nombre de usuario o contraseña incorrecta", "Verificar", MensajeBox.TipoMensaje.Exclamation)
                TPassNotifier.Text = ""
                TPassNotifier.Focus()
            End If

        End If
    End Sub
#End Region

End Class
