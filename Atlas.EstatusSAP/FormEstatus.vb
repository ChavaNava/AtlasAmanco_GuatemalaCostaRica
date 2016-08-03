Imports System.Windows.Forms
Imports Utili_Generales
Imports SQL_DATA

Public Class FormEstatus

#Region "Variables"
    Dim StrStatus As Boolean

#End Region

#Region "Eventos"

    Private Sub FormEstatus_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CBStatus.Enabled = False
        BtnAceptar.Enabled = False
    End Sub

    Private Sub TxtClaveE_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxContrasena.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            ValidaUser()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptar.Click
        If CBStatus.Text.Trim() = "" Then
            MessageBox.Show(" Elija un Status de Conexión ")
        Else
            Select Case CBStatus.SelectedValue
                Case Is = True
                    MensajeBox.Mostrar("Se activara conexión con SAP", "Activa Conexion", MensajeBox.TipoMensaje.Information)
                    SAP_Conexion.ActualizaEstatus(Atlas.Accesos.CLVarGlobales.Seccion.Trim, CBStatus.SelectedValue)
                    ModificaEstatus(CBStatus.SelectedValue)

                Case Is = False
                    MensajeBox.Mostrar("El Inactivar la conexión no permitira notificar en linea hacia SAP", "Inactivar Conexion", MensajeBox.TipoMensaje.Exclamation)
                    SAP_Conexion.ActualizaEstatus(Atlas.Accesos.CLVarGlobales.Seccion.Trim, CBStatus.SelectedValue)
                    ModificaEstatus(CBStatus.SelectedValue)
            End Select
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

#End Region

#Region "Metodos"
    Private Sub ValidaUser()
        Dim IdLogin As Boolean
        Dim Pass_md5 As String = Crypto.MD5Calculate(TxContrasena.Text.Trim)
        IdLogin = Users.Login_Estatus_SAP(Pass_md5.Trim, Atlas.Accesos.CLVarGlobales.Seccion.Trim)
        If IdLogin = True Then
            FillSet()
            DescribeEstatus()
            CBStatus.Enabled = True
            BtnAceptar.Enabled = True
            Conexion.CB_Estatus(CBStatus)
            CBStatus.Focus()
        Else
            MensajeBox.Mostrar("Contraseña incorrecta", "Verificar", MensajeBox.TipoMensaje.Exclamation)
            TxContrasena.Text = ""
            TxContrasena.Focus()
        End If
    End Sub

    Private Sub FillSet()
        TxAlias.Text = UserLogin._nAlias
        TxNombre.Text = UserLogin._nNombre
        TxCentro.Text = UserLogin._nPlanta
    End Sub

    Private Sub DescribeEstatus()
        If UserLogin._nEstatus_SAP = "False" Then
            TxEstatus.Text = "Inactivo"
        ElseIf UserLogin._nEstatus_SAP = "True" Then
            TxEstatus.Text = "Activo"
        End If
    End Sub

    Private Sub ModificaEstatus(ByVal IdEstatus As Boolean)
        If IdEstatus = "False" Then
            TxEstatus.Text = "Inactivo"
        ElseIf IdEstatus = "True" Then
            TxEstatus.Text = "Activo"
        End If
    End Sub

#End Region

End Class