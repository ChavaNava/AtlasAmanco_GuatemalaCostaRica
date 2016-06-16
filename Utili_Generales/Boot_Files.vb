Imports System.IO
Imports System.Windows.Forms

Public Class Boot_Files

    Private m_Ini As String
    Private Declare Function GetPrivateProfileStringKey Lib "kernel32" Alias _
    "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal _
    lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString _
    As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    Property Archivo() As String
        Get
            Archivo = m_Ini
        End Get
        Set(ByVal value As String)
            m_Ini = value
        End Set
    End Property


    Public Shared Function Valida_folder()
        Dim exists As Boolean
        exists = System.IO.Directory.Exists("C:\App Settings")

        Return exists
    End Function

    Public Shared Function Crea_folder()
        My.Computer.FileSystem.CreateDirectory("C:\App Settings")
    End Function

    Public Shared Function Valida_file()
        Dim exists As Boolean
        exists = System.IO.File.Exists("C:\App Settings\Scales.ini")
        Return exists
    End Function

    Public Shared Sub Write_File()
        Dim Q As String = ""

        Q = ""
        Q = "[Bascula]" & vbCrLf
        Q = Q & "Bascula = M" & vbCrLf
        Q = Q & "|Bascula_2 = M" & vbCrLf
        Q = Q & "|Bascula_3 = M"

        Try
            Dim ruta As String = "C:\App Settings\Scales.ini"
            Dim escritor As StreamWriter
            escritor = File.AppendText(ruta)
            escritor.Write(Q)
            escritor.Flush()
            escritor.Close()
        Catch ex As Exception
            MessageBox.Show("Escritura realizada incorrectamente")
        End Try
    End Sub

    Public Shared Sub Edit_File(ByVal B1 As String, B2 As String, B3 As String)
        Dim Q As String = ""

        Q = ""
        Q = "[Bascula]" & vbCrLf
        Q = Q & "Bascula = " & B1 & "" & vbCrLf
        Q = Q & "|Bascula_2 = " & B2 & "" & vbCrLf
        Q = Q & "|Bascula_3 = " & B3 & ""

        Try
            Dim ruta As String = "C:\App Settings\Scales.ini"
            Dim escritor As StreamWriter
            escritor = File.AppendText(ruta)
            escritor.Write(Q)
            escritor.Flush()
            escritor.Close()
        Catch ex As Exception
            MessageBox.Show("Escritura realizada incorrectamente")
        End Try
    End Sub

    Public Shared Sub Delete_File()
        My.Computer.FileSystem.DeleteFile("C:\App Settings\Scales.ini")
    End Sub

    Public Function LeeIni(ByVal Seccion As String, ByVal Llave As String) As String
        Dim lret As Long
        Dim ret As String
        ret = New String(CChar(" "), 255)
        lret = GetPrivateProfileStringKey(Seccion, Llave, "", ret, Len(ret), m_Ini)
        If InStr(ret, Chr(0)) Then
            ret = Mid(ret, 1, Len(ret) - 3)
        End If
        LeeIni = ret
    End Function

End Class
