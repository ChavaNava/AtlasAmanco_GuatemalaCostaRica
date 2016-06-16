Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmAdmCatPerfiles
    ' ---------------------------------------------------------------------------------
    Dim ConexionSQL As SqlConnection
    Dim ConexComando As SqlCommand
    Dim Consulta_1 As String
    Dim Cadena_conexion As String
    Dim StrPlanta As String
    ' ---------------------------------------------------------------------------------
    Dim xCODIGO As String
    Dim xDESCRIPCION As String
    Dim xCODPROGRAMA As String
    Dim xSTATUS As String
    ' ---------------------------------------------------------------------------------
    Dim xUSUARIOREG As String
    Dim xFECHAREG As String
    Dim xHORAREG As String
    ' ---------------------------------------------------------------------------------
    Dim myDataReader As SqlClient.SqlDataReader
    Dim xTabla As String
    Dim Q As String
    Dim xRegCount As Integer = 0
    ' ---------------------------------------------------------------------------------
    Public SPRO_OK As String
    Public SPRO_KEY As String
    ' ---------------------------------------------------------------------------------

    Private Sub FrmAdmCatPerfiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Me.Text = "Catalogo PERFILES" & "                    CENTRO : " & StrPlanta.Trim
        grdConsulta.CaptionText = "Detalle PERFILES"
    End Sub
    Private Sub CargaGrid()
        Dim xSQL As String
        ' ---------------------------------------------------------------------------------
        xCODIGO = txtCodigo.Text.Trim
        xDESCRIPCION = txtDescripcion.Text.Trim
        ' ---------------------------------------------------------------------------------
        xSQL = ""
        xSQL = "Select * from catperfiles WHERE centro = '" & StrPlanta.Trim & "'"
        If chkActivo.Checked Then
            xSQL = xSQL & "AND status='A'"
        Else
            xSQL = xSQL & "AND status='I'"
        End If
        xSQL = xSQL & "AND codper like ('%" & xCODIGO & "%') "
        xSQL = xSQL & "AND perfil like ('%" & xDESCRIPCION & "%') "
        If Not xCODPROGRAMA = "" Then
            xSQL = xSQL & "AND programa ='" & xCODPROGRAMA & "'"
        End If
        ' ---------------------------------------------------------------------------------
        Try
            AbrirConfiguracion()
            If objCnn.State <> ConnectionState.Open Then
                objCnn.Open()
            End If
            objDa = New SqlDataAdapter(xSQL, objCnn.ConnectionString)
            objDs = New DataSet
            objDa.Fill(objDs)
            xRegCount = objDs.Tables(0).Rows.Count
            grdConsulta.CaptionText = "Detalle PERFILES          Registros: " & xRegCount
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        ' ---------------------------------------------------------------------------------
        grdConsulta.DataSource = objDs
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
    End Sub
    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        If Me.txtCodigo.Text.Trim = "" Or Me.txtDescripcion.Text.Trim = "" Then
            Mensajes("*** Los campos CODIGO Y DESCRIPCION deben tener valor *** ", 1)
            Exit Sub
        End If
        ' ---------------------------------------------------------------------------------
        xUSUARIOREG = SessionUser._sAlias.Trim
        xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
        xHORAREG = Date.Now.TimeOfDay.ToString
        ' ---------------------------------------------------------------------------------
        xCODIGO = Me.txtCodigo.Text.Trim
        xDESCRIPCION = Me.txtDescripcion.Text.Trim
        If chkActivo.Checked Then
            xSTATUS = "A"
        Else
            xSTATUS = "I"
        End If
        ' ---------------------------------------------------------------------------------
        QRY = ""
        QRY = QRY & " SELECT codper FROM catperfiles "
        QRY = QRY & " WHERE centro ='" & StrPlanta.Trim & "' AND codper='" & xCODIGO.Trim & "'"
        LecturaQry_AMD(QRY)
        If LecturaBD_AMD.Read Then
            Mensajes("***  PERFIL ya existe *** ", 1)
            LecturaBD_AMD.Close()
            Exit Sub
        End If
        LecturaBD_AMD.Close()
        ' ---------------------------------------------------------------------------------
        Try
            InQry = "INSERT INTO catperfiles (centro, codper, perfil, status, usuarioreg, fechareg, horareg) "
            InQry = InQry & " VALUES ('" & StrPlanta & "','" & xCODIGO & "','" & xDESCRIPCION & "','" & xSTATUS & "','" & xUSUARIOREG & "','" & xFECHAREG & "','" & xHORAREG & "')"
            InsertQry_AMD(InQry)
            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        CargaGrid()
    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click

        ' ---------------------------------------------------------------------------------
        If Me.txtCodigo.Text.Trim = "" Or Me.txtDescripcion.Text.Trim = "" Then
            Mensajes("*** Los campos CODIGO Y DESCRIPCION deben tener valor *** ", 1)
            Exit Sub
        End If
        ' ---------------------------------------------------------------------------------
        xUSUARIOREG = SessionUser._sAlias.Trim
        xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
        xHORAREG = Date.Now.TimeOfDay.ToString
        ' ---------------------------------------------------------------------------------
        xCODIGO = Me.txtCodigo.Text.Trim
        xDESCRIPCION = Me.txtDescripcion.Text.Trim
        If chkActivo.Checked Then
            xSTATUS = "A"
        Else
            xSTATUS = "I"
        End If
        ' ---------------------------------------------------------------------------------
        QRY = ""
        QRY = QRY & " SELECT codper FROM catperfiles "
        QRY = QRY & " WHERE centro ='" & StrPlanta.Trim & "' AND codper='" & xCODIGO.Trim & "'"
        LecturaQry_AMD(QRY)
        If Not LecturaBD_AMD.Read Then
            Mensajes("***  PERFIL NO existe *** ", 1)
            LecturaBD_AMD.Close()
            Exit Sub
        End If
        LecturaBD_AMD.Close()
        ' ---------------------------------------------------------------------------------
        Try
            InQry = ""
            InQry = "UPDATE catperfiles SET perfil ='" & xDESCRIPCION & "', status='" & xSTATUS & "', usuarioreg='" & xUSUARIOREG & "', fechareg='" & xFECHAREG & "', horareg='" & xHORAREG & "'"
            InQry = InQry & " WHERE centro ='" & StrPlanta.Trim & "' AND codper ='" & xCODIGO & "'"
            InsertQry_AMD(InQry)
            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        CargaGrid()
    End Sub

    Private Sub tsbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBorrar.Click
        Dim RegistrosActualizados As Integer

        If txtCodigo.Text <> "" Then
            xCODIGO = txtCodigo.Text.Trim
            xSTATUS = "D"
            xUSUARIOREG = SessionUser._sAlias
            xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
            xHORAREG = Date.Now.TimeOfDay.ToString
            If Not xCODIGO = "" Then
                Try
                    AbrirConfiguracion()
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnn
                    Q = "UPDATE catperfiles SET status='" & xSTATUS & "', usuarioreg ='" & xUSUARIOREG & "', fechareg='" & xFECHAREG & "', horareg='" & xHORAREG & "'"
                    Q = Q & " WHERE centro ='" & StrPlanta & "' AND codper='" & xCODIGO & "' "
                    objCmd.CommandText = Q
                    RegistrosActualizados = objCmd.ExecuteNonQuery()
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
                CargaGrid()
            Else
                MsgBox("El campo Codigo de Perfil debe tener un valor....")
            End If
        End If
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Close()
    End Sub

    Private Sub grdConsulta_MouseDoubleClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdConsulta.MouseDoubleClick
        If grdConsulta.CurrentRowIndex > -1 Or grdConsulta.CurrentCell.RowNumber > 0 Then
            txtCodigo.Text = grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 1).ToString.Trim
            txtDescripcion.Text = grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 2).ToString.Trim
            If grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 3).ToString = "A" Then
                chkActivo.Checked = True
            Else
                chkActivo.Checked = False
            End If
        End If
    End Sub
End Class