Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Windows.Forms
Public Class Crypto
  Public Shared Function MD5Calculate(ByVal stringToCalculate As String) As String
        Dim MD5Result As String
        MD5Result = ""
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer
        bytValue = System.Text.Encoding.UTF8.GetBytes(stringToCalculate)
        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()
        For i = 0 To bytHash.Length - 1
            MD5Result &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return MD5Result
    End Function
End Class