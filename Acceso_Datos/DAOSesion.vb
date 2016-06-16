Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class DAOSesion
#Region "Variables miembro"
    Private m_Conexion As Conexion
#End Region

#Region "Enumeraciones"
#End Region

#Region "Constructores"
    Public Sub New(ByVal conexion As Conexion)
        m_Conexion = conexion
    End Sub
#End Region

#Region "Clases anidadas"
#End Region

#Region "Propiedades"
#End Region

#Region "Métodos"
    Public Function iniciar(ByVal usuario As String, ByVal clave As String) As Sesion
        Dim sesion As Sesion = Nothing
        Dim nvoUsuario As Usuario
        Dim query As String = ""

        query = "SELECT a.Deshabilitado, a.Usuario, a.Planta, a.Turno, a.Puesto, a.Clave_Acceso, a.Nombre, a.codper, a.Modulo, "
        query &= " a.Numero_Empleado, a.Supervisor, a.Grupo, ISNULL(a.Depto, '') Depto, b.Descripcion, b.Tipo tipoPlanta, "
        query &= " b.Texto1, b.Texto2, b.operaciones, c.DescPto "
        query &= " FROM ADM_Usuario a, ADM_Planta b, ADM_Puesto c "
        query &= " Where a.Planta = b.Planta "
        query &= " AND a.Puesto = c.Puesto "
        query &= " AND a.usuario = '" & usuario.Trim & "' "
        query &= " AND a.Clave_Acceso = '" & clave.Trim & "' "

        With m_Conexion
            .consulta(query)
            If .dataReader.Read Then
                nvoUsuario = New Usuario(.dataReader("Usuario"), .dataReader("Planta"), .dataReader("Turno"), .dataReader("Puesto"), _
                                      .dataReader("Clave_Acceso"), .dataReader("Nombre"), "", "", "", _
                                      .dataReader("Supervisor"), .dataReader("DesHabilitado"), .dataReader("Numero_Empleado"), _
                                      .dataReader("tipoPlanta"), .dataReader("codper"), .dataReader("Modulo"), False, _
                                      .dataReader("Grupo"), .dataReader("Depto"))

                sesion = New Sesion(nvoUsuario, .dataReader("Planta"), .dataReader("tipoPlanta"), .dataReader("operaciones"), .dataReader("DescPto"))
            End If
            .cerrarConsulta()
        End With

        Return sesion
    End Function

    Public Function iniciar(ByVal sesion As Sesion, ByVal clave As String) As Sesion
        Dim nvaSesion As Sesion = Nothing
        Dim nvoUsuario As Usuario
        Dim query As String = ""

        query = "SELECT a.Deshabilitado, a.Usuario, a.Planta, a.Turno, a.Puesto, a.Clave_Acceso, a.Nombre, a.codper, a.Modulo, "
        query &= " a.Numero_Empleado, a.Supervisor, a.Grupo, ISNULL(a.Depto, '') Depto, b.Descripcion, b.Tipo tipoPlanta, "
        query &= " b.Texto1, b.Texto2, b.operaciones, c.DescPto "
        query &= " FROM ADM_Usuario a, ADM_Planta b, ADM_Puesto c "
        query &= " Where a.Planta = b.Planta "
        query &= " AND a.Puesto = c.Puesto "
        query &= " AND a.Clave_Acceso = '" & clave.Trim & "' "
        query &= " AND a.Planta = '" & SessionUser._sCentro & "' "

        With m_Conexion
            .consulta(query)
            If .dataReader.Read Then
                nvoUsuario = New Usuario(.dataReader("Usuario"), .dataReader("Planta"), .dataReader("Turno"), .dataReader("Puesto"), _
                                      .dataReader("Clave_Acceso"), .dataReader("Nombre"), "", "", "", _
                                      .dataReader("Supervisor"), .dataReader("DesHabilitado"), .dataReader("Numero_Empleado"), _
                                      .dataReader("tipoPlanta"), .dataReader("codper"), .dataReader("Modulo"), 0, _
                                      .dataReader("Grupo"), .dataReader("Depto"))
                nvaSesion = New Sesion(nvoUsuario, sesion.planta, .dataReader("tipoPlanta"), .dataReader("operaciones"), .dataReader("DescPto"))
            End If
            .cerrarConsulta()
        End With

        Return nvaSesion
    End Function
#End Region

#Region "Colección"
#End Region

#Region "Campos"
#End Region

#Region "Eventos"
#End Region
End Class
