Public Class Bascula
    Public Sub Habilitar(ByVal Perfil As String, ByVal TPC As TextBox, ByVal Time As System.Windows.Forms.Timer, ByVal ValCodigo As String, ByVal LPBM As Label)
        strNumeroBascula = ""
        strNumeroBascula = ValCodigo.Trim

        If ValCodigo = "M" Then
            TPC.Enabled = True
            TPC.Visible = True
            LPBM.Visible = True
            Time.Enabled = False
        Else
            Time.Enabled = True
        End If

    End Sub
End Class
