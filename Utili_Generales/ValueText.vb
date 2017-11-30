Imports System.Windows.Forms

Public Class ValueText
    Private Shared GDECIMAL As String = "."
    Public Shared Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function
    Public Shared Function Decimales(ByVal Keyascii As Short) As Short
        If InStr("1234567890.", Chr(Keyascii)) = 0 Then
            Decimales = 0
        Else
            Decimales = Keyascii
        End If
        Select Case Keyascii
            Case 8
                Decimales = Keyascii
            Case 13
                Decimales = Keyascii
        End Select
    End Function

    Public Shared Function txtNumerico(ByVal txtControl As TextBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = GDECIMAL.Trim Then
            If caracter = GDECIMAL.Trim Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(GDECIMAL.Trim) <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function
End Class
