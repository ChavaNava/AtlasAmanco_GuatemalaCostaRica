Imports Utili_Generales
Public Class Consulta
    Public Event ButtonClick As EventHandler

    Private Sub Btn_Consulta_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Consulta.Click
        If DTP_FI.Value > DTP_FF.Value Then
            MensajeBox.Mostrar("La Fecha Inicio no puede ser mayor a la fecha Fin ", "Fechas", MensajeBox.TipoMensaje.Exclamation)
            Return
        End If

        If DTP_FF.Value < DTP_FI.Value Then
            MensajeBox.Mostrar("La Fecha Fin no puede ser menor a la fecha Inicio ", "Fechas", MensajeBox.TipoMensaje.Exclamation)
            Return
        End If
        RaiseEvent ButtonClick(sender, e)
    End Sub
End Class
