Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales

Public Class FrmSobreBajoPeso

    Dim Pass_md5 As String


    Private Sub FrmSobreBajoPeso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        AutorizaSobrepeso = "0"
        TSBPeso.Text = SP
        TObs.Enabled = False
        RB_SA.Enabled = False
        RB_NA.Enabled = False
        Btn_Aceptar.Enabled = False
        If SP > 0 Then
            Me.Text = "Autorización de Sobre Peso"
        Else
            Me.Text = "Autorización de Bajo Peso"
        End If
        Label1.Text = "Se requiere la " & Me.Text & " de:"
    End Sub

    Private Sub Btn_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Aceptar.Click
        If RB_SA.Checked Then
            If TObs.Text.Trim = "" Then
                MensajeBox.Mostrar("El campo observaciones no debe ir vacio ", "Campo vacio", MensajeBox.TipoMensaje.Critical)
                Return
            End If
            AutorizaSobrepeso = "1"
            Autoriza_SP = TUsr.Text.Trim
            Obs_Peso = TObs.Text.Trim
            Close()
        End If

        If RB_NA.Checked Then
            AutorizaSobrepeso = "2"
            Close()
        End If
    End Sub

    Private Sub TUsr_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TUsr.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TPass_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TPass_Leave(sender As System.Object, e As System.EventArgs) Handles TPass.Leave
        Pass_md5 = Crypto.MD5Calculate(TPass.Text.Trim)
        Gen_Valida.Valida_Permisos_Usuario(TUsr.Text.Trim, Pass_md5.Trim)
        ' ----------------------------------------- Clave Inexistente
        If Gen_Valida.valContador = 0 Then
            MensajeBox.Mostrar("Verifique Usuario y Clave de Acceso ", "Dato erroneo", MensajeBox.TipoMensaje.Information)
            TUsr.Text = ""
            TPass.Text = ""
            TUsr.Focus()
            Return
        End If
        ' ----------------------------------------- Usuario deshabilitado
        If SessionUser._sStatus = False Then
            MensajeBox.Mostrar("El Usuario está deshabilitado ", "Usuario dado de baja", MensajeBox.TipoMensaje.Information)
            TUsr.Text = ""
            TPass.Text = ""
            TUsr.Focus()
            Return
        End If
        ' ----------------------------------------- Usuario no existe
        If SessionUser._sAlias.Trim = "" Then
            MensajeBox.Mostrar("Verifique Clave de Acceso ", "Campo vacio", MensajeBox.TipoMensaje.Information)
            TUsr.Text = ""
            TPass.Text = ""
            TUsr.Focus()
            Return
        End If
        ' ---------- Valida si usuario puede autorizar Sobre / Bajo Peso 
        If Gen_Valida.Autoriza = True Then
            TObs.Enabled = True
            RB_SA.Enabled = True
            RB_NA.Enabled = True
            Btn_Aceptar.Enabled = True
            TObs.Focus()
        Else
            MensajeBox.Mostrar("Usuario no tiene permiso para autorizar Sobre/Bajo Peso ", "Permiso", MensajeBox.TipoMensaje.Information)
            TUsr.Text = ""
            TPass.Text = ""
            TUsr.Focus()
            Return
        End If
    End Sub

    Private Sub RB_NA_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_NA.CheckedChanged
        TObs.Text = ""
        TObs.Enabled = False
    End Sub

    Private Sub RB_SA_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_SA.CheckedChanged
        TObs.Enabled = True
    End Sub

    Private Sub Limpiar()
        TSBPeso.Text = ""
        TUsr.Text = ""
        TPass.Text = ""
        TObs.Text = ""
        Label1.Text = ""
        TObs.Enabled = False
        RB_SA.Enabled = False
        RB_NA.Enabled = False
        Btn_Aceptar.Enabled = False

    End Sub
End Class