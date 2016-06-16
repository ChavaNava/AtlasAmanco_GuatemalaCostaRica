Imports SQL_DATA.LoginExtrusion
Public Class Users
    Public Shared Sub Valida(ByVal Usr As String, ByVal Cve As String, Centro As String, Usuario As String)
        LecturaQry_ADM("PA_Autentifica_Usuario '" & Usr.Trim & "', '" & Cve.Trim & "', '" & Centro & "'", Usuario)
        Dim Contador As Integer = 0
        IdContador = Contador
        Do While (LecturaBD_ADM.Read)
            Contador = Contador + 1
            Status = LecturaBD_ADM(0)
            AliasUsuario = LecturaBD_ADM(1)
            IdCentro = LecturaBD_ADM(2)
            PasswordUsuario = LecturaBD_ADM(3)
            NombreUsuario = LecturaBD_ADM(4)
            NombrePlanta = LecturaBD_ADM(5)
            TipoPlanta = LecturaBD_ADM(6)
            NombrePerfil = LecturaBD_ADM(7)
            IdPerfil = LecturaBD_ADM(8)
            Ambiente = LecturaBD_ADM(9)
            IdCadena = LecturaBD_ADM(10)
            IdContador = Contador
        Loop
        LecturaBD_ADM.Close()
    End Sub

    Public Shared Function Login(ByVal Usuario As String, ByVal Password As String)
        Dim Contador As Integer = 0
        LecturaQry_ADM("PA_Login_User '" & Usuario.Trim & "', '" & Password.Trim & "'", Usuario)
        Do While (LecturaBD_ADM.Read)
            Contador = Contador + 1
            SessionUser.sStatus = LecturaBD_ADM(0)
            SessionUser.sAlias = LecturaBD_ADM(1)
            SessionUser.sCentro = LecturaBD_ADM(2)
            SessionUser.sNombre = LecturaBD_ADM(3)
            SessionUser.sPlanta = LecturaBD_ADM(4)
            SessionUser.sTipo = LecturaBD_ADM(5)
            SessionUser.sPerfil = LecturaBD_ADM(6)
            SessionUser.sIdPerfil = LecturaBD_ADM(7)
            SessionUser.sAmbiente = LecturaBD_ADM(8)
            SessionUser.sCadena = LecturaBD_ADM(9)
            SessionUser.sMultiCentro = LecturaBD_ADM(10)
            SessionUser.sPassword = LecturaBD_ADM(11)
        Loop
        Return Contador
    End Function

    Public Shared Function Login_Notifier(ByVal Usuario As String, ByVal Password As String)
        Dim Contador As Integer = 0
        LecturaQry_ADM("PA_Login_Notifier '" & SessionUser._sCentro & "', '" & Password.Trim & "'", Usuario)
        Do While (LecturaBD_ADM.Read)
            Contador = Contador + 1
            LoginNotifier.nStatus = LecturaBD_ADM(0)
            LoginNotifier.nAlias = LecturaBD_ADM(1)
            LoginNotifier.nCentro = LecturaBD_ADM(2)
            LoginNotifier.nNombre = LecturaBD_ADM(3)
            LoginNotifier.nPlanta = LecturaBD_ADM(4)
            LoginNotifier.nTipo = LecturaBD_ADM(5)
            LoginNotifier.nPerfil = LecturaBD_ADM(6)
            LoginNotifier.nIdPerfil = LecturaBD_ADM(7)
            LoginNotifier.nAmbiente = LecturaBD_ADM(8)
            LoginNotifier.nCadena = LecturaBD_ADM(9)
            LoginNotifier.nMultiCentro = LecturaBD_ADM(10)
            LoginNotifier.nPassword = LecturaBD_ADM(11)
            LoginNotifier.nAltas = LecturaBD_ADM(12)
            LoginNotifier.nBajas = LecturaBD_ADM(13)
            LoginNotifier.nCambios = LecturaBD_ADM(14)
            LoginNotifier.nImprimir = LecturaBD_ADM(15)
            LoginNotifier.nNotificar = LecturaBD_ADM(16)
            LoginNotifier.nContabilizar = LecturaBD_ADM(17)
            LoginNotifier.nsobrePeso = LecturaBD_ADM(18)
        Loop
        Return Contador
    End Function
End Class
