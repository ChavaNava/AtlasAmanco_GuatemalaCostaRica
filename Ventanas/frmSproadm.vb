Imports System.Data.SqlClient
Imports Utili_Generales
Public Class frmSproadm
    Dim myDataReader As SqlClient.SqlDataReader
    Dim xTabla As String
    Dim Q As String
    Public SPRO_TITULO As String = Nothing
    Public SPRO_SQL As String = Nothing
    Public SPRO_OK As Integer = 0
    Public SPRO_COLKEY As Integer = 0
    Public SPRO_KEY As String = Nothing
    Public SPRO_LIKE As String = Nothing
    Private Sub frmSproadm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = SPRO_TITULO
        Me.Icon = Util.ApplicationIcon()
        TSpro.Text = ""
        AbrirConfiguracion()
        Try
            If objCnn.State <> ConnectionState.Open Then
                objCnn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        objCmd.Connection = objCnn
        objDa = New SqlDataAdapter(SPRO_SQL, objCnn.ConnectionString)
        Try
            objDs = New DataSet
            objDa.Fill(objDs)
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        grdSpro.DataSource = objDs
        grdSpro.Expand(-1)
    End Sub
    Private Sub btnTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        Dim SPRO_SQL_LIKE As String = ""
        Me.Text = SPRO_TITULO
        AbrirConfiguracion()
        Try
            If objCnn.State <> ConnectionState.Open Then
                objCnn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        objCmd.Connection = objCnn
        SPRO_SQL_LIKE = SPRO_SQL & " AND " & SPRO_LIKE.Trim & " LIKE ('%" & TSpro.Text.Trim & "%')"
        objDa = New SqlDataAdapter(SPRO_SQL_LIKE, objCnn.ConnectionString)
        Try
            objDs = New DataSet
            objDa.Fill(objDs)
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        grdSpro.DataSource = objDs
        grdSpro.Expand(-1)
    End Sub
    Private Sub stbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stbAceptar.Click
        If grdSpro.CurrentRowIndex > -1 Then
            SPRO_KEY = grdSpro.Item(grdSpro.CurrentCell.RowNumber, SPRO_COLKEY).TRIM
            SPRO_OK = 1
        End If
        Close()
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Close()
    End Sub

    Private Sub grdSpro_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdSpro.MouseDoubleClick
        If grdSpro.CurrentRowIndex > -1 Then
            SPRO_KEY = grdSpro.Item(grdSpro.CurrentCell.RowNumber, SPRO_COLKEY).TRIM
            SPRO_OK = 1
        End If
        Close()
    End Sub
End Class