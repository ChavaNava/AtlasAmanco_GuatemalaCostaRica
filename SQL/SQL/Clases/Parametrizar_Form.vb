Public Class Parametrizar_Form
    Public Shared Function PTE(Centro As String, Usuario As String, C_Form As String, C_Parametro As String)
        Dim Valor As Boolean = False
        LecturaQry_ADM("PA_Parametros_Forma '" & C_Form.Trim & "', '" & C_Parametro & "', '" & Centro & "' ", Usuario)
        If (LecturaBD_ADM.Read) Then
            Valor = LecturaBD_ADM(0)
        End If
        Return Valor
    End Function

End Class
