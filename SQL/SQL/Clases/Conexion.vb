Public Class Conexion
    Public Shared Function SAP(ByVal Modulo As String) As Boolean
        Return False
        LecturaQry_ADM("PA_VerificaConexionSAP '" & SessionUser._sCentro.Trim & "', '" & Modulo & "' ", SessionUser._sAlias.Trim)
        If (LecturaBD_ADM.Read) Then
            Return True
        End If
        LecturaBD_ADM.Close()
    End Function

   
End Class
