Imports System.Data.SqlClient
Public Class Log
    Public Shared Sub Alta(Centro As String, Usuario As String, IdCadena As String, Password As String, Modulo As String, Accion As String)
        Dim Q As String

        Try
            Q = "PA_Log '" & Usuario.Trim & "', '" & Centro.Trim & "', '" & IdCadena & "', '" & Password & "', '" & Modulo & "', '" & Accion & "', '1'"
            LecturaQry_ADM(Q, SessionUser._sAlias)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "Login")
        End Try
        

    End Sub
End Class
