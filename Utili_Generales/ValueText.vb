Public Class ValueText
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
End Class
