Imports System.Data.SqlClient
Imports System.Configuration
Public Class Cnn
    Private Shared ipBDHost As String = "10.1.2.30"
    Private Shared objCmd As SqlCommand
    Private Shared objCnn As SqlConnection
    Private Shared objCnnMsi As SqlConnection
    Public Shared LecturaBD As SqlClient.SqlDataReader
    Public Shared LecturaBD_ADM As SqlClient.SqlDataReader
    Public Shared DataSetCombo As New DataSet

    Public Shared Function MSI(ByVal Ambiente As String) As SqlConnection
        Dim varString As String
        If Ambiente.Trim <> "P" Then
            varString = "Data Source=10.1.2.30;Initial Catalog=AMANCO_DEV;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        Else
            varString = "Data Source=10.1.2.30;Initial Catalog=Amanco;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        End If
        objCnnMsi = New SqlConnection
        objCnnMsi.ConnectionString = varString
        objCnnMsi.Open()
        Return objCnnMsi
    End Function

    Public Shared Function Usuarios(ByVal Usr As String) As SqlConnection
        Dim varString As String
        varString = "Data Source=10.1.2.30;Initial Catalog=USUARIOS;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        objCnn = New SqlConnection
        objCnn.ConnectionString = varString
        objCnn.Open()
        Return objCnn
    End Function

    Public Shared Function Combo(ByVal QryCombo As String) As DataSet
        DataSetCombo.Reset()
        Try
            Dim sqlCmd As New SqlCommand(QryCombo, MSI(SessionUser._sAmbiente.Trim))
            Dim SQLCombo As New SqlClient.SqlDataAdapter(sqlCmd)
            SQLCombo.Fill(DataSetCombo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        Return DataSetCombo
    End Function

    Public Shared Function LecturaQry_ADM(ByVal QRY_ADM As String) As SqlDataReader
        Usuarios(SessionUser._sAlias.Trim)
        If objCnn.State <> ConnectionState.Open Then
            objCnn.Open()
        End If
        objCmd = New SqlCommand
        objCmd.CommandType = CommandType.Text
        objCmd.Connection = objCnn
        objCmd.CommandText = QRY_ADM
        Try
            LecturaBD_ADM = objCmd.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error Lectura: ", ex.Message)
        End Try
        Return LecturaBD_ADM
    End Function

    Public Shared Function Combo_ADM(ByVal Q As String) As DataSet
        DataSetCombo.Reset()
        Try
            Dim sqlCmd As New SqlCommand(Q, Usuarios(SessionUser._sAlias.Trim))
            Dim SQLCombo As New SqlClient.SqlDataAdapter(sqlCmd)
            SQLCombo.Fill(DataSetCombo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        Return DataSetCombo
    End Function

    Public Shared Function LecturaQry(ByVal Qry As String) As SqlDataReader
        MSI(SessionUser._sAmbiente.Trim)
        If objCnnMsi.State <> ConnectionState.Open Then
            objCnnMsi.Open()
        End If
        objCmd = New SqlCommand
        objCmd.CommandType = CommandType.Text
        objCmd.Connection = objCnnMsi
        objCmd.CommandText = Qry
        Try
            LecturaBD = objCmd.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error Lectura: ", ex.Message)
            Return LecturaBD
            Exit Function
        End Try
        Return LecturaBD
    End Function

End Class
