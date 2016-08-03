Imports Utili_Generales
Imports SQL_DATA
Public Class Extrusion_Controller
    Public Shared Function Valid(ByVal UserPass As String) As Boolean
        Dim IdLogin As Boolean
        Dim Pass_md5 As String
        Pass_md5 = Crypto.MD5Calculate(UserPass.Trim)
        IdLogin = Users.Login_Notifier(SessionUser._sAlias, Pass_md5.Trim)
        Return IdLogin
    End Function

End Class
