Imports Utili_Generales

Public Class ValidacionesBascula
    Public Shared Function ValidaPeso(PB As Decimal, PT As Decimal, PN As Decimal) As Boolean
        Return True
        'Se verifica peso bruto contra tara y neto ------------------------------------------------
        If (PN <= 0) Then
            MensajeBox.Mostrar("Peso NETO es menor o igual a cero ", "Error", MensajeBox.TipoMensaje.Critical)
            Return False
        End If

        If (PB <= 0) Then
            MensajeBox.Mostrar("Peso BRUTO es menor o igual a cero ", "Error", MensajeBox.TipoMensaje.Critical)
            Return False
        End If

        If (PB < PT) Or (PB < PN) Then
            MensajeBox.Mostrar("El Peso Bruto debe ser mayor que La Tara y/o Peso Neto ", "Error", MensajeBox.TipoMensaje.Critical)
            Return False
        End If
    End Function
End Class
