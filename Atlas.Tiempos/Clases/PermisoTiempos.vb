Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales

Public Class PermisoTiempos

#Region "Metodos"
    Public Shared Sub Accesos(ByVal Modulo As String, ByVal Area As String, ByVal Perfil As String, ByVal Secc As String, Texto_Cabeceras As String)
        Dim strNameForm As String        'Nombre de la Form
        Dim gAlta As Boolean             'Permiso Alta
        Dim gBaja As Boolean             'Permiso Baja
        Dim gCambio As Boolean           'Permiso Cambio
        Dim gVisualiza As Boolean        'Permiso Visualizar
        Dim gImprimir As Boolean         'Permiso Imprimir
        Dim gNotificar As Boolean        'Permiso Notificar
        Dim Form_Atlas As String
        Dim stForm As Boolean            'Status de la Form
        Dim Frm As Form
        Dim Titulo As String = ""
        Dim Name_Raiz As String = ""
        EXTINY = Area
        Seccion = Secc
        strNameForm = ""
        Titulo = "" & Texto_Cabeceras.Trim & " Extrusión"
        'Verifica permisos del usuario
        Cnn.LecturaQry_ADM("PA_Permisos_Usuario '" & SessionUser._sCentro.Trim & "', '" & Modulo.Trim & "', '" & Perfil.Trim & "' ")
        'LecturaQry_ADM("PA_Permisos_Usuario '" & strPlanta.Trim & "', '" & Modulo.Trim & "', '" & Perfil.Trim & "' ")
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
                gPermisos = gAlta & "," & gBaja & "," & gCambio & "," & gVisualiza & "," & gImprimir & "," & gNotificar

                If gPermisos = "False,False,False,False,False,False" Or gPermisos = "" Then
                    MensajeBox.Mostrar("El usuario no tiene permisos de ejecución del Modulo: ", strNameForm.Trim, MensajeBox.TipoMensaje.Critical)
                Else

                    Dim formName As String = "Atlas.Tiempos." & Form_Atlas.Trim
                    Frm = Activator.CreateInstance(Type.GetType(formName, True, True))
                    Frm.Icon = Util.ApplicationIcon()
                    'Valida parametrizacion de form

                    'Catalogos

                    'Se activa form

                    'Log
                    Log.Alta(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, SessionUser._sCadena, SessionUser._sPassword, Form_Atlas, "Ingreso")
                    Frm.Text = Titulo.Trim
                    Frm.ShowDialog()
                End If
            End If
        Else
            MensajeBox.Mostrar("El usuario no tiene permisos de ejecución del Modulo: ", strNameForm.Trim, MensajeBox.TipoMensaje.Critical)
            Cnn.LecturaBD_ADM.Close()
        End If
    End Sub

    'Public Sub Cerrar(Modulo As String, Accion As String)
    '    If strPlanta <> Nothing Then
    '        Log.Alta(strPlanta.Trim, SessionUser._sAlias.Trim, IdCadenas, Password_Usr, Modulo, Accion)
    '    End If
    'End Sub

#End Region

#Region "Propiedades"



#End Region

End Class
