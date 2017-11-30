Imports System.Data.SqlClient
Imports System.Configuration
Public Class CnnFluent
    Private Shared ipBDHost As String = "10.1.2.30"
    Private Shared objCnn As SqlConnection
    Private Shared objCmd As SqlCommand
    Public Shared Function Fluent(ByVal Ambiente As String) As SqlConnection
        Dim varString As String
        If Ambiente.Trim = "D" Then
            varString = "Data Source=" & ipBDHost & ";Initial Catalog=AMANCO_DEV;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        Else
            varString = "Data Source=" & ipBDHost & ";Initial Catalog=Amanco;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        End If
        objCnn = New SqlConnection
        objCnn.ConnectionString = varString
        objCnn.Open()
        Return objCnn
    End Function

    Public Shared Function Combo(ByVal QryCombo As String) As DataSet
        DataSetCombo.Reset()
        Try
            Dim sqlCmd As New SqlCommand(QryCombo, Fluent(SessionUser._sAmbiente.Trim))
            Dim SQLCombo As New SqlClient.SqlDataAdapter(sqlCmd)
            SQLCombo.Fill(DataSetCombo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        Return DataSetCombo
    End Function

    Public Shared Function LecturaQry(ByVal Qry As String) As SqlDataReader
        Fluent(SessionUser._sAmbiente.Trim)
        If objCnn.State <> ConnectionState.Open Then
            objCnn.Open()
        End If
        objCmd = New SqlCommand
        objCmd.CommandType = CommandType.Text
        objCmd.Connection = objCnn
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
