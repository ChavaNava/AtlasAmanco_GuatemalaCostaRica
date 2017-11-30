Imports SQL_DATA
Public Class FileLog
    Public Shared Sub Cerrar(Modulo As String, Accion As String)
        If SessionUser._sCentro <> Nothing Then
            Log.Alta(SessionUser._sCentro, SessionUser._sAlias, SessionUser._sCadena, SessionUser._sPassword, Modulo, Accion)
        End If
    End Sub
End Class
