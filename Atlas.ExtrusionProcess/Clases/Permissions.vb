Imports Atlas.Accesos
Imports SQL_DATA
Imports Utili_Generales
Imports System.Windows.Forms

Public Class Permissions

    Public Shared Sub Access(ByVal Modulo As String, ByVal Perfil As String, Texto_Cabeceras As String)
        Dim strNameForm As String        'Nombre de la Form
        Dim gAlta As Boolean             'Permiso Alta
        Dim gBaja As Boolean             'Permiso Baja
        Dim gCambio As Boolean           'Permiso Cambio
        Dim gVisualiza As Boolean        'Permiso Visualizar
        Dim gImprimir As Boolean         'Permiso Imprimir
        Dim gNotificar As Boolean        'Permiso Notificar
        Dim stForm As Boolean            'Status de la Form
        Dim Form_Atlas As String
        Dim Titulo As String = ""
        Dim Name_Raiz As String = ""
        Atlas.Accesos.CLVarGlobales.EXTINY = 1
        Atlas.Accesos.CLVarGlobales.Seccion = "E"
        strNameForm = ""
        Titulo = "" & Texto_Cabeceras.Trim & " Extrusión"
        'Verifica permisos del usuario
        DB.LecturaQry_ADM("PA_Permisos_Usuario '" & SessionUser._sCentro.Trim & "', '" & Modulo.Trim & "', '" & SessionUser._sIdPerfil.Trim & "' ")
        If (DB.LecturaBD_ADM.Read) Then
            strNameForm = DB.LecturaBD_ADM(1)
            gAlta = DB.LecturaBD_ADM(5)
            gBaja = DB.LecturaBD_ADM(6)
            gCambio = DB.LecturaBD_ADM(7)
            gVisualiza = DB.LecturaBD_ADM(8)
            gImprimir = DB.LecturaBD_ADM(9)
            gNotificar = DB.LecturaBD_ADM(10)
            Name_Raiz = DB.LecturaBD_ADM(11)
            Form_Atlas = DB.LecturaBD_ADM(12)
            stForm = DB.LecturaBD_ADM(13)
            DB.LecturaBD_ADM.Close()

            If Form_Atlas <> "NA" Then
                Atlas.Accesos.CLVarGlobales.gPermisos = gAlta & "," & gBaja & "," & gCambio & "," & gVisualiza & "," & gImprimir & "," & gNotificar

                If Atlas.Accesos.CLVarGlobales.gPermisos = "False,False,False,False,False,False" Or Atlas.Accesos.CLVarGlobales.gPermisos = "" Then
                    MensajeBox.Mostrar("El usuario no tiene permisos de ejecución del Modulo: ", strNameForm.Trim, MensajeBox.TipoMensaje.Critical)
                Else
                    Dim Frm As New Form
                    Dim formName As String = "Atlas.ExtrusionProcess." & Form_Atlas.Trim

                    Frm = Activator.CreateInstance(Type.GetType(formName, True, True))
                    Frm.Icon = Util.ApplicationIcon()
                    'Log
                    'Log.Alta(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, SessionUser._sCadena, SessionUser._sPassword, Form_Atlas, "Ingreso")
                    Frm.Text = Titulo.Trim
                    Frm.ShowDialog()
                End If
            End If
        Else
            MensajeBox.Mostrar("El usuario no tiene permisos de ejecución del Modulo: ", strNameForm.Trim, MensajeBox.TipoMensaje.Critical)
            DB.LecturaBD_ADM.Close()
        End If
    End Sub
End Class
