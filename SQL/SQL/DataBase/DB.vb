Imports System.Data.SqlClient
Imports System.Configuration
Public Class DB
    Private Shared ipBDHost As String = "10.1.2.30"
    Private Shared objCmd As SqlCommand
    Private Shared objCnn As SqlConnection
    Private Shared LecturaBD As SqlClient.SqlDataReader
    Public Shared LecturaBD_ADM As SqlClient.SqlDataReader
    Public Shared DataSetCombo As New DataSet

    Public Shared Function MSI(ByVal Usr As String) As SqlConnection
        Dim objCnnMsi As SqlConnection
        Dim varString As String
        If Usr.Trim = "ATLAS" Or Usr.Trim = "CALIDAD" Then
            varString = "Data Source=" & ipBDHost & ";Initial Catalog=Amanco_Dev;Persist Security Info=True;User ID=sa;Password=sqlm3x1ch3m;Trusted_Connection=False"
            'varString = "Data Source=10.1.2.30;Initial Catalog=MSI_A013_DEV;Persist Security Info=True;User ID=msi_atlas;Password=msi;Trusted_Connection=False"
        Else
            varString = "Data Source=" & ipBDHost & ";Initial Catalog=Amanco;Persist Security Info=True;User ID=sa;Password=sqlm3x1ch3m;Trusted_Connection=False"
        End If
        objCnnMsi = New SqlConnection
        objCnnMsi.ConnectionString = varString
        objCnnMsi.Open()
        Return objCnnMsi
    End Function

    Public Shared Function Usuarios(ByVal Usr As String) As SqlConnection
        Dim varString As String
        If Usr.Trim = "ATLAS" Or Usr.Trim = "CALIDAD" Then
            varString = "Data Source=10.1.2.30;Initial Catalog=Usuarios_Dev;Persist Security Info=True;User ID=sa;Password=sqlm3x1ch3m;Trusted_Connection=False"
        Else
            varString = "Data Source=10.1.2.30;Initial Catalog=Usuarios;Persist Security Info=True;User ID=sa;Password=sqlm3x1ch3m;Trusted_Connection=False"
        End If
        objCnn = New SqlConnection
        objCnn.ConnectionString = varString
        objCnn.Open()
        Return objCnn
    End Function

    Public Shared Function Combo(ByVal QryCombo As String, Usuario As String) As DataSet
        DataSetCombo.Reset()
        Try
            Dim SQLCombo As New SqlClient.SqlDataAdapter(QryCombo, MSI(Usuario))
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
            Dim SQLCombo As New SqlClient.SqlDataAdapter(Q, Usuarios(SessionUser._sAlias.Trim))
            SQLCombo.Fill(DataSetCombo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        Return DataSetCombo
    End Function
End Class
