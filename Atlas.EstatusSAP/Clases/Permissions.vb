Imports Atlas.Accesos
Imports SQL_DATA
Imports Utili_Generales
Imports System.Windows.Forms

Public Class Permissions

    Public Shared Sub Access(ByVal Modulo As String, ByVal Area As String, ByVal Perfil As String, ByVal Secc As String, Texto_Cabeceras As String)
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
        Atlas.Accesos.CLVarGlobales.EXTINY = Area
        Atlas.Accesos.CLVarGlobales.Seccion = Secc
        strNameForm = ""
        If Area = "1" Then
            Titulo = "" & Texto_Cabeceras.Trim & " Extrusión"
        ElseIf Area = "2" Then
            Titulo = "" & Texto_Cabeceras.Trim & " Inyección"
        ElseIf Area = "3" Then
            Titulo = "" & Texto_Cabeceras.Trim & " Rotomoldeo"
        ElseIf Area = "" Then
            Titulo = "" & Texto_Cabeceras.Trim & ""
        End If

        'Verifica permisos del usuario

        Cnn.LecturaQry_ADM("PA_Permisos_Usuario '" & SessionUser._sCentro.Trim & "', '" & Modulo.Trim & "', '" & SessionUser._sIdPerfil.Trim & "' ")
        If (Cnn.LecturaBD_ADM.Read) Then
            strNameForm = Cnn.LecturaBD_ADM(1)
            gAlta = Cnn.LecturaBD_ADM(5)
            gBaja = Cnn.LecturaBD_ADM(6)
            gCambio = Cnn.LecturaBD_ADM(7)
            gVisualiza = Cnn.LecturaBD_ADM(8)
            gImprimir = Cnn.LecturaBD_ADM(9)
            gNotificar = Cnn.LecturaBD_ADM(10)
            Name_Raiz = Cnn.LecturaBD_ADM(11)
            Form_Atlas = Cnn.LecturaBD_ADM(12)
            stForm = Cnn.LecturaBD_ADM(13)
            Cnn.LecturaBD_ADM.Close()

            If Form_Atlas <> "NA" Then
                Atlas.Accesos.CLVarGlobales.gPermisos = gAlta & "," & gBaja & "," & gCambio & "," & gVisualiza & "," & gImprimir & "," & gNotificar

                If Atlas.Accesos.CLVarGlobales.gPermisos = "False,False,False,False,False,False" Or Atlas.Accesos.CLVarGlobales.gPermisos = "" Then
                    MensajeBox.Mostrar("El usuario no tiene permisos de ejecución del Modulo: ", strNameForm.Trim, MensajeBox.TipoMensaje.Critical)
                Else
                    Dim Frm As New Form
                    Dim formName As String = "Atlas.EstatusSAP." & Form_Atlas.Trim

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
            Cnn.LecturaBD_ADM.Close()
        End If
    End Sub
End Class
