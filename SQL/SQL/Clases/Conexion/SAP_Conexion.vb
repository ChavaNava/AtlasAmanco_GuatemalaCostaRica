Imports System.Drawing
Public Class SAP_Conexion

    Public Shared Function SAP_Status(ByVal Modulo As String) As Boolean

        LecturaQry_ADM("PA_VerificaConexionSAP '" & SessionUser._sCentro.Trim & "', '" & Modulo & "' ", SessionUser._sAlias.Trim)
        If (LecturaBD_ADM.Read) Then
            Return True
        Else
            Return False
        End If
        LecturaBD_ADM.Close()
    End Function

    Public Shared Sub SAPConecct(ByVal Usuario As String, Centro As String, Modulo As String, Estatus As String)
        LecturaQry_ADM("PA_Estatus_Conexion '" & Centro.Trim & "', '" & Modulo & "', '" & Estatus & "' ", Usuario)
    End Sub
End Class
