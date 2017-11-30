Imports SQL_DATA
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales

Public Class FrmAltaUsuarioAvisoSobrepeso

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub FrmAltaUsuarioAvisoSobrepeso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Catalogo_Usuarios.CB(CBUsuarios, 1)
    End Sub

    Private Sub BtnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptar.Click
        Accionesabc.IdAccion = 1
        Accionesabc.IdUsuario = CBUsuarios.SelectedValue
        Try
            Acciones.abc(1)
            MensajeBox.Mostrar("Se ingreso el registros exitosamente", "Aviso", MensajeBox.TipoMensaje.Good)
            Accion = "1"
            Close()
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Accion = "0"
            Close()
        End Try

    End Sub

    Private Sub CBUsuarios_Leave(sender As System.Object, e As System.EventArgs) Handles CBUsuarios.Leave
        Accionesabc.IdUsuario = CBUsuarios.SelectedValue
        Catalogo_Usuarios.Email(2)
        TxEmail.Text = AccionCatalog._Email
    End Sub
End Class