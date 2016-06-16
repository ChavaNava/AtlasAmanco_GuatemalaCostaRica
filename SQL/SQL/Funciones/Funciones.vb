Public Class Funciones
    Public Shared Function Sumar(ByVal Nombre_Columna As String, ByVal Dgv As DataGridView) As Double
        Dim total As Double = 0
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item(Nombre_Columna.ToLower, i).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        ' retornar el valor  
        Return Format((total), "#0.000")
    End Function
End Class
