Imports System.Data.SqlClient
Imports System.Configuration
Module DataBase
    Dim usuario As String
    'Dim ipBDHost As String = "10.1.2.30"
    Dim ipBDHost As String = "167.86.92.160"
    Dim objCnnMsi As SqlConnection
    Dim objCmd As SqlCommand
    Public objCnn As SqlConnection
    Public LecturaBD As SqlClient.SqlDataReader
    Public LecturaBD_ADM As SqlClient.SqlDataReader

    Public Function MSI(ByVal Ambiente As String) As SqlConnection
        Dim varString As String
        If Ambiente.Trim = "D" Or Ambiente.Trim = "Q" Then
            varString = "Data Source=10.1.2.30;Initial Catalog=AMANCO_DEV;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        Else
            varString = "Data Source=10.1.2.30;Initial Catalog=AMANCO;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        End If
        objCnnMsi = New SqlConnection
        objCnnMsi.ConnectionString = varString
        objCnnMsi.Open()
        Return objCnnMsi
    End Function

    Public Function Usuarios(ByVal User As String) As SqlConnection
        Dim varString As String
        'varString = "Data Source=10.1.2.30;Initial Catalog=USUARIOS;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        varString = "Data Source=167.86.92.160;Initial Catalog=USUARIOS;Persist Security Info=True;User ID=sa;Password=Domo2018!$;Trusted_Connection=False"
        objCnn = New SqlConnection
        objCnn.ConnectionString = varString
        objCnn.Open()
        Return objCnn
    End Function

    Public Function LecturaQry(ByVal Qry As String) As SqlDataReader
        Try
            MSI(SessionUser._sAmbiente)
            objCmd = New SqlCommand
            objCmd.CommandType = CommandType.Text
            objCmd.Connection = objCnnMsi
            objCmd.CommandText = Qry
            LecturaBD = objCmd.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error Lectura: ", ex.Message)
            Return LecturaBD
            Exit Function
        End Try
        Return LecturaBD
    End Function

    Public Function LecturaQry_ADM(ByVal QRY_ADM As String, LoginUser As String) As SqlDataReader
        Usuarios(LoginUser)
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

    Public Function Combo(ByVal QryCombo As String) As DataSet
        DataSetCombo.Reset()
        Try
            Dim sqlCmd As New SqlCommand(QryCombo, MSI(SessionUser._sAmbiente))
            Dim SQLCombo As New SqlClient.SqlDataAdapter(sqlCmd)
            SQLCombo.Fill(DataSetCombo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        Return DataSetCombo
    End Function

    Public Function Combo2(ByVal QryCombo As String, Ambiente As String) As DataSet
        DataSetCombo2.Reset()
        Try
            Dim sqlCmd As New SqlCommand(QryCombo, MSI(SessionUser._sAmbiente))
            Dim SQLCombo As New SqlClient.SqlDataAdapter(sqlCmd)
            SQLCombo.Fill(DataSetCombo2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        Return DataSetCombo2
    End Function

    Public Function Combo3(ByVal QryCombo As String, Ambiente As String) As DataSet
        DataSetCombo3.Reset()
        Try
            Dim sqlCmd As New SqlCommand(QryCombo, MSI(SessionUser._sAmbiente))
            Dim SQLCombo As New SqlClient.SqlDataAdapter(sqlCmd)
            SQLCombo.Fill(DataSetCombo3)
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        Return DataSetCombo3
    End Function

    Public Function Combo_ADM(ByVal QryCombo_ADM As String) As DataSet
        DataSetCombo.Reset()
        Try
            Dim sqlCmd As New SqlCommand(QryCombo_ADM, Usuarios(SessionUser._sAlias))
            Dim SQLCombo As New SqlClient.SqlDataAdapter(sqlCmd)
            SQLCombo.Fill(DataSetCombo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        Return DataSetCombo
    End Function
End Module
