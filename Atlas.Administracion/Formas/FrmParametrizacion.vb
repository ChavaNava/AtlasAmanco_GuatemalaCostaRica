Imports SQL_DATA
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmParametrizacion
#Region "Variables"

#End Region

#Region "Eventos SobrePeso"
    Private Sub Btn_Consulta_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Consulta.Click
        AccionQuery.IdAccion = 1
        AccionQuery.Operacion = 1
        CargaGridSobrePeso()
    End Sub

    Private Sub BtnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevo.Click
        Accion = "0"
        Dim FrmAlta As New FrmAltaUsuarioAvisoSobrepeso
        FrmAlta.Icon = Util.ApplicationIcon()
        FrmAlta.Text = "Alta Usuario notificación sobrepesos"
        FrmAlta.ShowDialog()
        Select Case Accion
            Case Is = "1"
                CargaGridSobrePeso()
        End Select
    End Sub

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        Accionesabc.IdUsuario = AccionCatalog._IdUsuario
        Accionesabc.IdAccion = AccionCatalog._IdAccion
        Try
            Acciones.abc(2)
            MensajeBox.Mostrar("Se borro el registros exitosamente", "Aviso", MensajeBox.TipoMensaje.Good)
            CargaGridSobrePeso()
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
        End Try
    End Sub

    Private Sub DGVSobrePeso_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DGVSobrePeso.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = DGVSobrePeso.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Try
                Dim Fila_Seleccionada As Integer = DGVSobrePeso.CurrentCell.RowIndex
                AccionCatalog.IdAccion = DGVSobrePeso.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                AccionCatalog.Descripcion = DGVSobrePeso.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                AccionCatalog.IdUsuario = DGVSobrePeso.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                AccionCatalog.Usuario = DGVSobrePeso.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                AccionCatalog.Nombre = DGVSobrePeso.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                AccionCatalog.Email = DGVSobrePeso.Rows(Fila_Seleccionada).Cells(5).Value.ToString
            Catch ex As Exception
                MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                Exit Sub
            End Try
        End If
    End Sub

#End Region

#Region "Eventos Extrusión"
    Private Sub BtnExtConsulta_Click(sender As System.Object, e As System.EventArgs) Handles BtnExtConsulta.Click
        CargaGridExtrusion()
    End Sub
#End Region


#Region "Metodos Sobrepeso"
    Private Sub CargaGridSobrePeso()
        Acciones.QueryRecords(DGVSobrePeso)
    End Sub
#End Region

#Region "Metodos Extrusión"
    Private Sub CargaGridExtrusion()
        Parametros.Extrusion(DGVExt, 1)
    End Sub
#End Region
 



 



 


End Class