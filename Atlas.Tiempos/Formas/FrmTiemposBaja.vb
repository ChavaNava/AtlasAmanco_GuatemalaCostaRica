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
            Tiemposabc.iIdTiempo = txtIdTiempo.Text.Trim
            Tiemposabc.iPuestoTrabajo = ""
            Tiemposabc.iOrden_Produccion = ""
            Tiemposabc.iTurno = ""
            Tiemposabc.iHorasProdParo = ""
            Tiemposabc.iFechaRegistra = ""
            Tiemposabc.iUserRegistra = ""
            Tiemposabc.iIdGrupo = 0
            Tiemposabc.iIdSeccion = 0
            Tiemposabc.iIdGrupoMaterial = 0
            OperacionTiempos.abc(5)
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
        txtIdTiempo.Text = dgv_DetalleHoras._IdTiempo
        txtFecha.Text = dgv_DetalleHoras._Fecha
        txtOrden.Text = dgv_DetalleHoras._OrdenProduccion
        txtEquipo.Text = dgv_DetalleHoras._PuestoTrabajo
        txtTurno.Text = dgv_DetalleHoras._Turno
        txtHoras.Text = dgv_DetalleHoras._Horas
        txtConcepto.Text = dgv_DetalleHoras._ConceptoParo
    End Sub
#End Region

End Class