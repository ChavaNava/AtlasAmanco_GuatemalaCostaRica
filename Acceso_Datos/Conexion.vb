Imports System.Data.SqlClient

Public Class Conexion
    Private m_objConnection As SqlConnection
    Private m_strConnection As String
    Private m_dataReader As SqlClient.SqlDataReader

    Public Sub New(ByVal strConnection As String)
        m_strConnection = strConnection
        m_objConnection = New SqlConnection
    End Sub

    Public Function abrir() As SqlConnection
        m_objConnection = New SqlConnection
        m_objConnection.ConnectionString = m_strConnection
        m_objConnection.Open()
        Return m_objConnection
    End Function

    'Función para cerrar el dataReader
    Public Sub cerrarConsulta()
        If Not m_dataReader Is Nothing Then
            m_dataReader.Close()
        End If
    End Sub

    'Función para cerrar la conexión al sevidor
    Public Sub cerrar()
        Me.cerrarConsulta()
        m_objConnection.Close()
    End Sub

    ReadOnly Property cnn() As SqlConnection
        Get
            Return m_objConnection
        End Get
    End Property

    ReadOnly Property dataReader() As SqlClient.SqlDataReader
        Get
            Return m_dataReader
        End Get
    End Property

    Public Function consulta(ByVal strConsulta As String) As SqlClient.SqlDataReader
        If m_objConnection Is Nothing Or m_objConnection.State <> ConnectionState.Open Then
            Me.abrir()
        End If
        If Not m_dataReader Is Nothing Then
            If Not m_dataReader.IsClosed Then
                m_dataReader.Close()
            End If
        End If

        objCmd = New SqlCommand
        objCmd.CommandType = CommandType.Text
        objCmd.Connection = m_objConnection
        objCmd.CommandText = strConsulta
        m_dataReader = objCmd.ExecuteReader()
        Return m_dataReader
    End Function

    Public Function ejecuta(ByVal strQuery As String) As Integer
        Dim rowsAffected As Integer = -1
        Try
            If m_objConnection Is Nothing Or m_objConnection.State <> ConnectionState.Open Then
                Me.abrir()
            End If
            Me.cerrarConsulta()
            objCmd = New SqlCommand
            objCmd.CommandText = strQuery
            objCmd.CommandType = CommandType.Text
            objCmd.Connection = m_objConnection
            rowsAffected = objCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error Eliminar :" & ex.Message, " VENTANA DE ERROR * * * ")
        Finally
            Me.cerrar()
        End Try
        Return rowsAffected
    End Function

    Public Function ejecutaSP(ByVal nombreSP As String, ByVal parametroXML As String) As Boolean
        Dim res As Integer
        Dim objCmd As New SqlCommand
        Dim P_Out As SqlParameter

        P_1 = New SqlParameter

        P_Out = New SqlParameter

        Me.cerrarConsulta()
        If m_objConnection Is Nothing Or m_objConnection.State <> ConnectionState.Open Then
            Me.abrir()
        End If

        objCmd.Connection = Me.cnn
        objCmd.CommandType = CommandType.StoredProcedure
        objCmd.CommandText = nombreSP

        P_1.ParameterName = "@Registros"
        P_1.SqlDbType = System.Data.SqlDbType.VarChar
        P_1.Value = parametroXML
        objCmd.Parameters.Add(P_1)

        P_Out.ParameterName = "@Exito"
        P_Out.SqlDbType = System.Data.SqlDbType.Bit
        P_Out.Direction = ParameterDirection.Output

        objCmd.Parameters.Add(P_Out)

        res = objCmd.ExecuteNonQuery()

        Return P_Out.Value
    End Function

    Public Function ejecutaSPInsert(ByVal nombreSP As String, ByVal parametroXML As String) As Integer
        Dim res As Integer
        Dim objCmd As New SqlCommand
        Dim P_Out As SqlParameter

        P_1 = New SqlParameter

        P_Out = New SqlParameter

        Me.cerrarConsulta()
        If m_objConnection Is Nothing Or m_objConnection.State <> ConnectionState.Open Then
            Me.abrir()
        End If

        objCmd.Connection = Me.cnn
        objCmd.CommandType = CommandType.StoredProcedure
        objCmd.CommandText = nombreSP

        P_1.ParameterName = "@Registros"
        P_1.SqlDbType = System.Data.SqlDbType.VarChar
        P_1.Value = SinAcentos(parametroXML)
        'String.
        objCmd.Parameters.Add(P_1)

        P_Out.ParameterName = "@IdNuevo"
        P_Out.SqlDbType = System.Data.SqlDbType.Int
        P_Out.Direction = ParameterDirection.Output

        objCmd.Parameters.Add(P_Out)

        res = objCmd.ExecuteNonQuery()

        Return P_Out.Value
    End Function

    Public Function ejecutaSPInsert(ByVal nombreSP As String, ByVal parametroXML As String, _
                                    ByRef outAux As Integer) As Integer
        Dim res As Integer
        Dim objCmd As New SqlCommand
        Dim P_Out As SqlParameter
        Dim P_OutAux As SqlParameter

        P_1 = New SqlParameter

        P_Out = New SqlParameter
        P_OutAux = New SqlParameter

        Me.cerrarConsulta()
        If m_objConnection Is Nothing Or m_objConnection.State <> ConnectionState.Open Then
            Me.abrir()
        End If

        objCmd.Connection = Me.cnn
        objCmd.CommandType = CommandType.StoredProcedure
        objCmd.CommandText = nombreSP

        P_1.ParameterName = "@Registros"
        P_1.SqlDbType = System.Data.SqlDbType.VarChar
        P_1.Value = parametroXML
        objCmd.Parameters.Add(P_1)

        P_Out.ParameterName = "@IdNuevo"
        P_Out.SqlDbType = System.Data.SqlDbType.Int
        P_Out.Direction = ParameterDirection.Output
        objCmd.Parameters.Add(P_Out)

        P_OutAux.ParameterName = "@IntAux"
        P_OutAux.SqlDbType = System.Data.SqlDbType.Int
        P_OutAux.Direction = ParameterDirection.Output
        objCmd.Parameters.Add(P_OutAux)

        res = objCmd.ExecuteNonQuery()
        outAux = P_OutAux.Value

        Return P_Out.Value
    End Function
End Class
