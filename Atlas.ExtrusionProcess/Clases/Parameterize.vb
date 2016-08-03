Imports System.Windows.Forms
Imports SQL_DATA

Public Class Parameterize
    Public Shared Function Forma(ByVal FrmName As String, IdParametro As String)
        Dim Valor As Boolean = False
        DB.LecturaQry_ADM("PA_Parametros_Forma '" & FrmName & "', '" & IdParametro & "', '" & SessionUser._sCentro.Trim & "' ")
        If (DB.LecturaBD_ADM.Read) Then
            Valor = DB.LecturaBD_ADM(0)
        End If
        Return Valor
    End Function
End Class
