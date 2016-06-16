Imports System.Data.SqlClient
Public Class Produccion_Scrap_Inyeccion
    Public Shared Function Valida_Bom(ByVal Centro As String, Usuario As String, Codigo As String)
        Dim Cod_Compuesto As String = "0"

        LecturaQry("PA_Identifica_Compuesto_BOM '" & Centro & "', '" & Codigo & "' ", Usuario)
        If (LecturaBD.Read) Then
            Cod_Compuesto = "" & LecturaBD(0)
        End If

        Return Cod_Compuesto
    End Function
End Class
