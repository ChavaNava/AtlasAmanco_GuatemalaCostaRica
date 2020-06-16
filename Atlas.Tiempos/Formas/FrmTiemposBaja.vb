Imports Atlas.Accesos.CLVarGlobales
Imports Utili_Generales
Public Class FrmTiemposBaja
#Region "Variables"

#End Region

#Region "Eventos"
    Private Sub FrmTiemposBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSetData()
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        LoadingForm.ShowLoading()
        Try
            Tiemposabc.iIdTiempo = txtIdFolio.Text.Trim
            Tiemposabc.iPuestoTrabajo = ""
            Tiemposabc.iOrden_Produccion = ""
            Tiemposabc.iTurno = 0
            Tiemposabc.iHorasProdParo = ""
            Tiemposabc.iFechaRegistra = ""
            Tiemposabc.iUserRegistra = ""
            Tiemposabc.iIdGrupo = ""
            Tiemposabc.iIdSeccion = ""
            Tiemposabc.iIdGrupoMaterial = ""
            Tiemposabc.iFechaAlta = ""
            Tiemposabc.iIdCausa = ""
            Tiemposabc.iHoraRegistra = ""
            Tiemposabc.iFolio = dgv_DetalleHoras._Folio
            OperacionTiempos.abc(4)
            LoadingForm.CloseForm()
            Accion = 1
            Close()
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error consulta recibo", MensajeBox.TipoMensaje.Critical)
            LoadingForm.CloseForm()
            Close()
        End Try
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
#End Region

#Region "Metodos"
    Private Sub FillSetData()
        txtIdFolio.Text = dgv_DetalleHoras._Folio
        txtFecha.Text = dgv_DetalleHoras._FechaRegistro
        txtOrden.Text = dgv_DetalleHoras._OrdenProduccion
        txtEquipo.Text = dgv_DetalleHoras._IdPuestoTrabajo
        txtTurno.Text = dgv_DetalleHoras._Turno
        txtHoras.Text = dgv_DetalleHoras._Horas
        txtConcepto.Text = dgv_DetalleHoras._Causa
    End Sub
#End Region

End Class