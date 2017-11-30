Imports System.Drawing
Imports Utili_Generales
Public Class SAP_Conexion

    Public Shared Function Estatus(ByVal Modulo As String) As Boolean
        Dim Estatus_SAP As Boolean = False
        LecturaQry_ADM("PA_VerificaConexionSAP '" & SessionUser._sCentro.Trim & "', '" & Modulo & "' ", SessionUser._sAlias)
        Do While (LecturaBD_ADM.Read())
            Estatus_SAP = LecturaBD_ADM(0)
        Loop
        LecturaBD_ADM.Close()
        Return Estatus_SAP
    End Function

    Public Shared Sub SAPConecct(ByVal Usuario As String, Centro As String, Modulo As String, Estatus As String)
        LecturaQry_ADM("PA_Estatus_Conexion '" & SessionUser._sCentro.Trim & "', '" & Modulo & "', '" & Estatus & "' ", SessionUser._sAlias)
    End Sub

    Public Shared Sub ActualizaEstatus(ByVal Modulo As String, IdEstatus As Integer)
        LecturaQry_ADM("PA_Actualiza_Estatus_SAP  '" & SessionUser._sCentro.Trim & "' , '" & Modulo.Trim & "', " & IdEstatus & "", SessionUser._sAlias)
    End Sub

    Public Shared Sub EstatusBarr(ByVal Modulo As String, TSSL As ToolStripStatusLabel)
        LecturaQry_ADM("PA_VerificaConexionSAP '" & SessionUser._sCentro.Trim & "', '" & Modulo & "' ", SessionUser._sAlias)

        If (LecturaBD_ADM.Read) Then
            Dim EstatusConexion As Boolean = LecturaBD_ADM(0)
            Select Case EstatusConexion
                Case Is = True
                    TSSL.Image = Global.SQL_DATA.My.Resources.btn_SAPOk
                    TSSL.Text = "En comunicación con SAP"
                    TSSL.ForeColor = Color.Blue
                Case Is = False
                    TSSL.Image = Global.SQL_DATA.My.Resources.btn_SAPFail
                    TSSL.Text = "No hay comunicación con SAP"
                    TSSL.ForeColor = Color.Red
            End Select
        End If
        LecturaBD_ADM.Close()
    End Sub
End Class
