Module MDPublicClass
    Public Function Caracteres(ByVal sCadena As String) As String
        If sCadena <> "" Then
            sCadena = Replace(sCadena, "'", " ")
            sCadena = Replace(sCadena, "(", " ")
            sCadena = Replace(sCadena, ")", " ")
            sCadena = Replace(sCadena, "*", " ")
        End If

        Return sCadena
    End Function
End Module
