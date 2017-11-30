Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports System.Windows.Forms
Imports SQL_DATA

Public Class AutorizaSobrepeso

    Private Sub AutorizaSobrepeso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        EstatusAutoriza = "0"
        TSBPeso.Text = PorcentajeSobrePeso
        If PorcentajeSobrePeso > 0 Then
            Me.Text = "Autorización de Sobre Peso"
        Else
            Me.Text = "Autorización de Bajo Peso"
        End If
        Label1.Text = "Se requiere la " & Me.Text & " "
    End Sub

    Private Sub Btn_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Aceptar.Click
        If RB_SA.Checked Then
            If TObs.Text.Trim = "" Then
                MensajeBox.Mostrar("El campo observaciones no debe ir vacio ", "Campo vacio", MensajeBox.TipoMensaje.Critical)
                Return
            End If
            EstatusAutoriza = "1"
            RegistrarSBP.Autoriza = TUsr.Text.Trim
            RegistrarSBP.Observacion = TObs.Text.Trim
            Close()
        End If

        If RB_NA.Checked Then
            EstatusAutoriza = "2"
            Close()
        End If
    End Sub

    Private Sub TUsr_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TUsr.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub LoginUser()
        Dim Pass_md5 As String
        Dim IdLogin As Boolean
        Pass_md5 = Crypto.MD5Calculate(TPass.Text.Trim)
        IdLogin = Users.Login_Notifier(TUsr.Text.Trim, Pass_md5.Trim)

        If IdLogin = True Then
            If LoginNotifier._nsobrePeso = True Then
                TObs.Enabled = True
                RB_SA.Enabled = True
                RB_NA.Enabled = True
                Btn_Aceptar.Enabled = True
                TObs.Focus()
            Else
                MensajeBox.Mostrar("Usuario no puede autorizar sobre/bajopeso", "No autorizado", MensajeBox.TipoMensaje.Exclamation)
                TUsr.Text = ""
                TPass.Text = ""
                TUsr.Focus()
                Return
            End If
        Else
            MensajeBox.Mostrar("Nombre de usuario o contraseña incorrecta", "Verificar", MensajeBox.TipoMensaje.Exclamation)
            TUsr.Text = ""
            TPass.Text = ""
            TUsr.Focus()
            Return
        End If
    End Sub

    Private Sub TPass_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            LoginUser()
        End If
    End Sub
End Class