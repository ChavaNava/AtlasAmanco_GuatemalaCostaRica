Imports System.IO
Public Class LoggingService
    Private m_FileName As String
    Private m_DateFormat As String
    Private Sub SaveEntry(ByVal type As Integer, ByVal desc As String, ByVal usuario As String)
        Dim writer As StreamWriter
        Dim pila As New StackTrace
        Dim sPath As String = AppDomain.CurrentDomain.BaseDirectory.ToString()

        Try
            writer = New StreamWriter( _
                                sPath + _
                                m_FileName + "_" + Environment.MachineName + "_" + _
                                Date.Now.ToString(m_DateFormat) + ".txt", True)

            Dim texto As String = usuario + "|" + Date.Now.ToString("dd/MM/yyyy HH:mm:ss") + "|" + _
                   pila.GetFrame(2).GetMethod().DeclaringType.ToString + "|" + _
                     pila.GetFrame(2).GetMethod().Name + "|" + GetTypeEntry(type) + "|" + desc
            'writer.WriteLine(SecurityService.Obfuscate(texto))
            writer.Flush()
            writer.Close()
            writer.Dispose()
            writer = Nothing

        Catch ex As Exception

        End Try

    End Sub

    Private Function GetTypeEntry(ByVal type As Integer) As String
        Select Case type
            Case 0
                Return "INFO"
            Case 1
                Return "SUCCESS"
            Case 2
                Return "WARNING"
            Case 3
                Return "ERROR"
            Case 4
                Return "IPORTANT"
            Case Else
                Return "UNCLASSIFIED"
        End Select
    End Function

End Class
