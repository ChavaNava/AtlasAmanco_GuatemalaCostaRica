Imports Atlas.Accesos.CLVarGlobales
Imports Atlas.Accesos
Imports SQL_DATA
Imports Utili_Generales
Public Class ReadProductionOrder
    Public Shared Sub read()
        Select Case SessionUser._sAmbiente
            Case Is = "P"

            Case Is = "D"

            Case Is = "Q"

        End Select
    End Sub
End Class
