Imports Utili_Generales
Imports SQL_DATA

Public Class ReportOverweight
    Public Shared Sub Notification(ByVal Operacion As Integer)
        Try
            LecturaQry("PA_NotificaSobreBajoPeso '" & SessionUser._sCentro.Trim & "','" & RegistrarSBP._Orden & "','" & RegistrarSBP._FolioAtlas & "','','" & RegistrarSBP._Sobrepeso & "','" & RegistrarSBP._Causa & "','" & RegistrarSBP._Autoriza & "','" & RegistrarSBP._Observacion & "','" & RegistrarSBP._Aviso & "','" & Operacion & "'")
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try
    End Sub

End Class
