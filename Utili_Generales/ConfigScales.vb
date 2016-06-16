Public Class ConfigScales
    Public Shared Function ReedFile(ByVal numeroLinea As Integer, ByVal nombreFichero As String) As String
        Dim fichero As New System.IO.FileInfo(nombreFichero)
        ReedFile = ""
        If fichero.Exists Then
            Dim sr As System.IO.StreamReader
            Dim lineaActual As Integer = 1
            Try
                sr = New System.IO.StreamReader(fichero.FullName)
                While lineaActual < numeroLinea And Not sr.EndOfStream
                    sr.ReadLine()
                    lineaActual += 1
                End While
                ReedFile = sr.ReadToEnd
            Catch ex As Exception
                MsgBox("No se pudo ejecutar la operación")
            Finally
                If sr IsNot Nothing Then
                    sr.Close()
                    sr.Dispose()
                End If
            End Try
        End If
    End Function
End Class
