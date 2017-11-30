Imports SQL_DATA
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmBaja_PTSC
    Dim B_Folio As String


    Private Sub FrmBaja_PTSC_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        TFecha.Text = Now.Date.ToString("yyyy/MM/dd")
        TFolio.Text = Baja_Folio
        TProceso.Text = Baja_Proceso
        TdocSap.Text = Baja_DocSap
        TNumSap.Text = Baja_NumSap
        TOrden.Text = Baja_Orden
    End Sub

    Private Sub BtnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptar.Click
        If Tobservaciones.Text = "" Then
            MensajeBox.Mostrar("Debe ingresar en observaciones el motivo de la baja del Folio: '" & TFolio.Text.Trim & "' ", "Campo Vacio", MensajeBox.TipoMensaje.Exclamation)
            Return
        Else
            'Se registra el movimiento de la baja
            Try
                Produccion_Scrap_Extrusion.Inser_Movimiento_Baja(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, TFolio.Text.Trim, _
                                                                 TdocSap.Text.Trim, TNumSap.Text.Trim, Baja_Notifica, Baja_Masiva, Tobservaciones.Text.Trim, _
                                                                 Baja_St_Pesaje, Seccion.Trim, TProceso.Text.Trim)
                'Se modifica el registro poniendo en status de cancelado
                Try
                    Produccion_Scrap_Extrusion.Baja_Pesaje(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, TFolio.Text.Trim, TOrden.Text.Trim, TProceso.Text.Trim)
                    MensajeBox.Mostrar("Se realizo la baja del pesaje con numero de folio '" & TFolio.Text.Trim & "' ", "Baja Exitosa", MensajeBox.TipoMensaje.Good)
                    Accion = "1"
                    Close()
                Catch ex As Exception
                    MensajeBox.Mostrar("Error '" & ex.ToString & "' ", "Error", MensajeBox.TipoMensaje.Critical)
                    Accion = "0"
                    Exit Sub
                End Try
            Catch ex As Exception
                MensajeBox.Mostrar("Error '" & ex.ToString & "' ", "Error", MensajeBox.TipoMensaje.Critical)
                Accion = "0"
                Exit Sub
            End Try

        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Function Button() As Object
        Throw New NotImplementedException
    End Function

End Class