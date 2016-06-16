Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class PermisoAdminPesajes
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
        DB.LecturaQry_ADM("PA_Permisos_Usuario '" & SessionUser._sCentro.Trim & "', '" & Modulo.Trim & "', '" & Perfil.Trim & "' ", SessionUser._sAlias.Trim)
        'LecturaQry_ADM("PA_Permisos_Usuario '" & strPlanta.Trim & "', '" & Modulo.Trim & "', '" & Perfil.Trim & "' ")
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
                gPermisos = gAlta & "," & gBaja & "," & gCambio & "," & gVisualiza & "," & gImprimir & "," & gNotificar

                If gPermisos = "False,False,False,False,False,False" Or gPermisos = "" Then
                    MensajeBox.Mostrar("El usuario no tiene permisos de ejecución del Modulo: ", strNameForm.Trim, MensajeBox.TipoMensaje.Critical)
                Else

                    Dim formName As String = "Atlas.Administracion.Pesajes." & Form_Atlas
                    Frm = Activator.CreateInstance(Type.GetType(formName, True, True))
                    Frm.Icon = Util.ApplicationIcon()
                    'Valida parametrizacion de form

                    'Catalogos

                    'Log
                    Log.Alta(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, SessionUser._sCadena, SessionUser._sPassword, Form_Atlas, "Ingreso")
                    'Se activa form
                    Frm.Text = Titulo.Trim
                    Frm.ShowDialog()
                End If
            End If
        Else
            MensajeBox.Mostrar("El usuario no tiene permisos de ejecución del Modulo: ", strNameForm.Trim, MensajeBox.TipoMensaje.Critical)
            DB.LecturaBD_ADM.Close()
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
