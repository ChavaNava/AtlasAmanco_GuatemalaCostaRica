Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmTiemposAlta

#Region "Variables"
    Dim Pass_md5 As String
#End Region

#Region "Eventos"
    Private Sub txtOrden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrden.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Util.Decimales(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            ConsultaOrden()
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            LoginUser()
        End If
    End Sub
    Private Sub FrmTiemposAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbTiempos.Enabled = False
        cmbDefault()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
    Private Sub cbSinOrden_CheckedChanged(sender As Object, e As EventArgs) Handles cbSinOrden.CheckedChanged
        If cbSinOrden.Checked Then
            If EXTINY = 1 Then
                txtOrden.Text = "99999991"
            Else
                txtOrden.Text = "99999992"
            End If

            txtOrden.Enabled = False
            BloqueCamposSinOrden()

        Else
            abilitaCampos()
            txtOrden.Text = ""
            txtOrden.Enabled = False
        End If
    End Sub
    Private Sub cmbGpoCausa_Click(sender As Object, e As EventArgs) Handles cmbGpoCausa.Click
        OperacionTiempos.GrupoParos(cmbGpoCausa)
    End Sub
    Private Sub cmbConceptoParo_Click(sender As Object, e As EventArgs) Handles cmbConceptoParo.Click
        OperacionTiempos.GrupoProductivo(cmbConceptoParo, cmbGpoCausa.SelectedValue)
    End Sub
    Private Sub cmbPuestoTrabajo_Click(sender As Object, e As EventArgs) Handles cmbPuestoTrabajo.Click
        OperacionTiempos.WorkCenter(cmbPuestoTrabajo)
    End Sub
    Private Sub cmbPuestoTrabajo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbPuestoTrabajo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            ConsultaEquipo()
        End If
    End Sub
    Private Sub cmbGpoDiametro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbGpoDiametro.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            txtGpoDiametro.Text = cmbGpoDiametro.SelectedValue
            DescGrupMaterial()
        End If
    End Sub
    Private Sub cmbGpoDiametro_Click(sender As Object, e As EventArgs) Handles cmbGpoDiametro.Click
        OperacionTiempos.GrupoDiametros(cmbGpoDiametro)
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        LoadingForm.ShowLoading()

        Tiemposabc.iPuestoTrabajo = cmbPuestoTrabajo.Text.Trim
        Tiemposabc.iOrden_Produccion = txtOrden.Text.Trim
        Tiemposabc.iTurno = cmbTurno.SelectedValue
        Tiemposabc.iHorasProdParo = txtHoras.Text.Trim
        Tiemposabc.iFechaAlta = DTP_FI.Value.ToString("yyyy-MM-dd")
        Tiemposabc.iFechaRegistra = Date.Today.ToString("yyyy-MM-dd")
        Tiemposabc.iHoraRegistra = Date.Now.TimeOfDay.ToString()
        Tiemposabc.iUserRegistra = LoginNotifier._nAlias
        Tiemposabc.iIdGrupo = txtIdArea.Text.Trim
        Tiemposabc.iIdSeccion = txtIdSeccion.Text.Trim
        Tiemposabc.iIdGrupoMaterial = cmbGpoDiametro.Text.Trim

        'Valida que se halla seleccionado GrupoCausa y Causa
        If cmbGpoCausa.SelectedValue = Nothing Then
            LoadingForm.CloseForm()
            MensajeBox.Mostrar("Debe Seleccionar un Grupo de Causas ", "Grupo Causas", MensajeBox.TipoMensaje.Information)
            Return
        Else
            Tiemposabc.iIdGrupoCausa = cmbGpoCausa.SelectedValue
        End If

        If cmbConceptoParo.SelectedValue = Nothing Then
            LoadingForm.CloseForm()
            MensajeBox.Mostrar("Debe Seleccionar una causa ", "Causa", MensajeBox.TipoMensaje.Information)
            Return
        Else
            Tiemposabc.iIdCausa = cmbConceptoParo.SelectedValue
        End If
        'Se realiza el guardado del registro de horas
        Try
            OperacionTiempos.abc(1)
            LoadingForm.CloseForm()
            MensajeBox.Mostrar("Se realizo el registro de las horas exitosamente ", "Registro Exitoso", MensajeBox.TipoMensaje.Good)
            Accion = "1"
            Close()
        Catch ex As Exception
            LoadingForm.CloseForm()
            MensajeBox.Mostrar(ex.ToString, "Error en el registro de horas", MensajeBox.TipoMensaje.Exclamation)
            Accion = "0"
            Close()
        End Try
    End Sub
#End Region

#Region "Metodos"
    Private Sub LoginUser()
        Dim IdLogin As Boolean
        Pass_md5 = Crypto.MD5Calculate(txtPassword.Text.Trim)
        IdLogin = Users.Login_Notifier(SessionUser._sAlias, Pass_md5.Trim)

        If IdLogin = True Then
            txtNombre.Text = LoginNotifier._nNombre
            gbTiempos.Enabled = True
            txtOrden.Focus()
        Else
            MensajeBox.Mostrar("Nombre de usuario o contraseña incorrecta", "Verificar", MensajeBox.TipoMensaje.Exclamation)
            gbTiempos.Enabled = False
            txtPassword.Text = ""
            txtNombre.Text = ""
            txtPassword.Focus()
        End If
    End Sub
    Private Sub ConsultaOrden()
        Dim FechaAlta As String
        Try
            Select Case OperacionTiempos.LeerOrdenProduccion(txtOrden.Text.Trim, 9)
                Case Is = True
                    FechaAlta = DTP_FI.Value.ToString("yyyy-MM-dd")
                    Select Case OperacionTiempos.ValidaHoras(3, cmbTurno.Text, txtOrden.Text, ReadOrderProducction._rIdPuestoTrabajo, FechaAlta)
                        Case Is = True
                            Select Case TiemposReportados._Horas
                                Case Is = "8.00"
                                    txtHorasRegistradas.Text = TiemposReportados._Horas.Trim
                                    MensajeBox.Mostrar("La orden, Fecha y Turno ya tiene registradas sus 8 horas ", "Aviso", MensajeBox.TipoMensaje.Information)
                                    txtHoras.Text = (8 - TiemposReportados._Horas.Trim)
                                    Accion = "0"
                                    Close()
                                Case Is < "8"
                                    txtHorasRegistradas.Text = TiemposReportados._Horas.Trim
                                    txtHoras.Text = (8 - TiemposReportados._Horas.Trim)
                                    FillSet()
                                    BloqueCampos()
                            End Select
                        Case Is = False
                            txtHorasRegistradas.Text = TiemposReportados._Horas.Trim
                            FillSet()
                            BloqueCampos()
                    End Select

                Case Is = False
                    MensajeBox.Mostrar("No existe la orden " & txtOrden.Text.Trim & "", "Orden Produccón", MensajeBox.TipoMensaje.Critical)
            End Select

        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error consulta recibo", MensajeBox.TipoMensaje.Critical)
        End Try
    End Sub

    Private Sub ConsultaEquipo()
        Dim FechaAlta As String
        Try
            Select Case OperacionTiempos.LeerEquipo(cmbPuestoTrabajo.Text.Trim, 10)
                Case Is = True
                    FechaAlta = DTP_FI.Value.ToString("yyyy-MM-dd")
                    Select Case OperacionTiempos.ValidaHoras(3, cmbTurno.Text, txtOrden.Text, cmbPuestoTrabajo.Text.Trim, FechaAlta)
                        Case Is = True
                            Select Case TiemposReportados._Horas
                                Case Is = "8.00"
                                    txtHorasRegistradas.Text = TiemposReportados._Horas.Trim
                                    MensajeBox.Mostrar("El Equipo, Fecha y Turno ya tiene registradas sus 8 horas ", "Aviso", MensajeBox.TipoMensaje.Information)
                                    txtHoras.Text = (8 - TiemposReportados._Horas.Trim)
                                    Return
                                Case Is < "8"
                                    txtHorasRegistradas.Text = TiemposReportados._Horas.Trim
                                    txtHoras.Text = (8 - TiemposReportados._Horas.Trim)
                                    FillSetEquipo()
                                    GrupoProd()
                            End Select
                        Case Is = False
                            txtHorasRegistradas.Text = TiemposReportados._Horas.Trim
                            FillSetEquipo()
                            GrupoProd()
                    End Select

                Case Is = False
                    MensajeBox.Mostrar("No existe la orden " & txtOrden.Text.Trim & "", "Orden Produccón", MensajeBox.TipoMensaje.Critical)
            End Select

        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error consulta recibo", MensajeBox.TipoMensaje.Critical)
        End Try

    End Sub
    Private Sub DescGrupMaterial()

    End Sub
    Private Sub FillSet()
        cmbPuestoTrabajo.Text = ReadOrderProducction._rIdPuestoTrabajo
        txtPuestoTrabajo.Text = ReadOrderProducction._rPuestoTrabajo
        txtIdArea.Text = ReadOrderProducction._rGrupProd
        txtArea.Text = ReadOrderProducction._rGrupProdDesc
        txtIdSeccion.Text = ReadOrderProducction._rCodSeccion
        txtSeccion.Text = ReadOrderProducction._rSeccion
        txtIdProducto.Text = ReadOrderProducction._rIdProducto
        txtProducto.Text = ReadOrderProducction._rProducto
        cmbGpoDiametro.Text = ReadOrderProducction._rClaveGrupMaterial
        txtGpoDiametro.Text = ReadOrderProducction._rGrupMaterial
    End Sub
    Private Sub FillSetEquipo()
        txtIdArea.Text = ReadWorkCenter._rGrupProd
        txtArea.Text = ReadWorkCenter._rGrupProdDesc
        txtIdSeccion.Text = ReadWorkCenter._rCodSeccion
        txtSeccion.Text = ReadWorkCenter._rSeccion
        txtIdProducto.Text = ReadWorkCenter._rIdProducto
        txtProducto.Text = ReadWorkCenter._rProducto
        cmbGpoDiametro.Text = ReadWorkCenter._rClaveGrupMaterial
        txtGpoDiametro.Text = ReadWorkCenter._rGrupMaterial
    End Sub
    Private Sub abilitaCampos()
        cmbPuestoTrabajo.Enabled = True
        txtPuestoTrabajo.Enabled = True
        txtIdArea.Enabled = True
        txtArea.Enabled = True
        txtIdSeccion.Enabled = True
        txtSeccion.Enabled = True
        txtIdProducto.Enabled = True
        txtProducto.Enabled = True
        cmbGpoDiametro.Enabled = True
        txtGpoDiametro.Enabled = True
    End Sub
    Private Sub BloqueCampos()
        cmbPuestoTrabajo.Enabled = False
        txtPuestoTrabajo.Enabled = False
        txtIdArea.Enabled = False
        txtArea.Enabled = False
        txtIdSeccion.Enabled = False
        txtSeccion.Enabled = False
        txtIdProducto.Enabled = False
        txtProducto.Enabled = False
        cmbGpoDiametro.Enabled = False
        txtGpoDiametro.Enabled = False
    End Sub
    Private Sub BloqueCamposSinOrden()
        txtIdArea.Enabled = False
        txtArea.Enabled = False
        txtIdSeccion.Enabled = False
        txtSeccion.Enabled = False
        txtIdProducto.Enabled = False
        txtProducto.Enabled = False
        cmbGpoDiametro.Enabled = False
    End Sub
    Private Sub cmbDefault()
        OperacionTiempos.Turnos(cmbTurno)
    End Sub
    Private Sub Initcmb()
        OperacionTiempos.WorkCenter(cmbPuestoTrabajo)
    End Sub
    Private Sub GrupoProd()
        OperacionTiempos.ValidaGrpProd(txtIdArea.Text.Trim, 3)
    End Sub
    Private Sub LimpiarCampos()
        cmbTurno.DataSource = Nothing
        cmbTurno.Text = ""
        cmbPuestoTrabajo.DataSource = Nothing
        cmbPuestoTrabajo.Text = ""
        txtPuestoTrabajo.Text = ""
        txtIdArea.Text = ""
        txtArea.Text = ""
    End Sub
#End Region

End Class