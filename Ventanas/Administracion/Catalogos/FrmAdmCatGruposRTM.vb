Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmAdmCatGruposRTM
#Region "Variables miembro"
    Dim ConexionSQL As SqlConnection
    Dim ConexComando As SqlCommand
    Dim Consulta_1 As String
    Dim Cadena_conexion As String
    Dim StrPlanta As String     'Planta

    Dim xCODIGO As String
    Dim xDESCRIPCION As String

    Dim xTIPO As String
    Dim xSTATUS As String

    Dim xUSUARIOREG As String
    Dim xFECHAREG As String
    Dim xHORAREG As String

    Dim myDataReader As SqlClient.SqlDataReader
    Dim Q As String
    Dim xRegCount As Integer = 0
#End Region
    Private Sub FrmAdmCatGruposRTM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Text = "Catalogo GRUPOS DIAMETRO" & "                    CENTRO : " & StrPlanta.Trim
        grdConsulta.CaptionText = "Detalle GRUPOS DIAMETRO"
    End Sub

    Private Sub CargaGrid()
        Dim xSQL As String

        AbrirAmanco()

        Try
            If objCnnAmanco.State <> ConnectionState.Open Then
                objCnnAmanco.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        xCODIGO = txtCodigo.Text.Trim
        xDESCRIPCION = txtDescripcion.Text.Trim

        xSQL = " SELECT Centro, grupmaterial, Desgrupmaterial, Tpo_grupmaterial, status, usuarioreg, fechareg, Horareg "
        xSQL = xSQL & " FROM CatGrupMaterial WHERE Centro = '" & StrPlanta & "'"

        If rbtExtrusion.Checked Then
            xSQL = xSQL & " AND Tpo_grupmaterial='1'"
        Else
            xSQL = xSQL & " AND Tpo_grupmaterial='2'"
        End If
        xSQL = xSQL & " AND grupmaterial LIKE ('%" & xCODIGO & "%') "
        xSQL = xSQL & " AND Desgrupmaterial LIKE ('%" & xDESCRIPCION & "%') "

        objDa = New SqlDataAdapter(xSQL, objCnnAmanco.ConnectionString)

        Try
            objDs = New DataSet
            objDa.Fill(objDs)

            xRegCount = objDs.Tables(0).Rows.Count
            grdConsulta.CaptionText = "Detalle GRUPOS DIAMETRO        Registros: " & xRegCount

        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        grdConsulta.DataSource = objDs
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If grdConsulta.CurrentRowIndex > -1 Or grdConsulta.CurrentCell.RowNumber > 0 Then
            txtCodigo.Text = grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 1).ToString
            txtDescripcion.Text = grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 2).ToString
            If grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 3).ToString = "1" Then
                rbtExtrusion.Checked = True
            Else
                rbtInyeccion.Checked = True
            End If
            If grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 4).ToString = "A" Then
                chkActivo.Checked = True
            Else
                chkActivo.Checked = False
            End If
        End If
    End Sub

    Public Function txtNumerico(ByVal txtControl As TextBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "." Then
            If caracter = "." Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(".") <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        If Me.txtCodigo.Text.Trim = "" Or Me.txtDescripcion.Text.Trim = "" Then
            Mensajes("*** Los campos CODIGO Y DESCRIPCION deben tener valor *** ", 1)
            Exit Sub
        End If
        ' ---------------------------------------------------------------------------------
        xCODIGO = Me.txtCodigo.Text.Trim
        xDESCRIPCION = Me.txtDescripcion.Text.Trim

        xUSUARIOREG = SessionUser._sAlias.Trim
        xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
        xHORAREG = Date.Now.TimeOfDay.ToString
        ' ---------------------------------------------------------------------------------
        If rbtExtrusion.Checked Then
            xTIPO = "1"
        Else
            xTIPO = "2"
        End If

        If chkActivo.Checked Then
            xSTATUS = "A"
        Else
            xSTATUS = "I"
        End If
        ' ---------------------------------------------------------------------------------
        QRY = ""
        QRY = QRY & " SELECT grupmaterial FROM CatGrupMaterial "
        QRY = QRY & " WHERE centro ='" & StrPlanta.Trim & "' AND grupmaterial='" & xCODIGO.Trim & "'"
        QRY = QRY & " AND Tpo_grupmaterial='" & xTIPO.Trim & "' "
        LecturaQry(QRY)
        If LecturaBD.Read Then
            Mensajes("***  GRUPO DE MEDIDA ya existe *** ", 1)
            LecturaBD.Close()
            Exit Sub
        End If
        LecturaBD.Close()
        ' ---------------------------------------------------------------------------------
        Try
            InQry = ""
            InQry = "INSERT INTO CatGrupMaterial (Centro, grupmaterial, Desgrupmaterial, Tpo_grupmaterial, status, usuarioreg, fechareg, Horareg) "
            InQry = InQry & " VALUES ('" & StrPlanta.Trim & "','" & xCODIGO.Trim & "','" & xDESCRIPCION.Trim & "','"
            InQry = InQry & xTIPO.Trim & "','" & xSTATUS.Trim & "','" & xUSUARIOREG.Trim & "','" & xFECHAREG.Trim & "','" & xHORAREG.Trim & "')"
            InsertQry(InQry)
            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        CargaGrid()
    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click


        If Me.txtCodigo.Text.Trim = "" Or Me.txtDescripcion.Text.Trim = "" Then
            Mensajes("*** Los campos CODIGO Y DESCRIPCION deben tener valor *** ", 1)
            Exit Sub
        End If
        ' ---------------------------------------------------------------------------------
        xCODIGO = Me.txtCodigo.Text.Trim
        xDESCRIPCION = Me.txtDescripcion.Text.Trim

        xUSUARIOREG = SessionUser._sAlias.Trim
        xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
        xHORAREG = Date.Now.TimeOfDay.ToString
        ' ---------------------------------------------------------------------------------
        If rbtExtrusion.Checked Then
            xTIPO = "1"
        Else
            xTIPO = "2"
        End If

        If chkActivo.Checked Then
            xSTATUS = "A"
        Else
            xSTATUS = "I"
        End If
        ' ---------------------------------------------------------------------------------
        QRY = ""
        QRY = QRY & " SELECT grupmaterial FROM CatGrupMaterial "
        QRY = QRY & " WHERE centro ='" & StrPlanta.Trim & "' AND grupmaterial='" & xCODIGO.Trim & "'"
        QRY = QRY & " AND Tpo_grupmaterial='" & xTIPO.Trim & "' "
        LecturaQry(QRY)
        If Not LecturaBD.Read Then
            Mensajes("***  GRUPO DE MEDIDA no existe *** ", 1)
            LecturaBD.Close()
            Exit Sub
        End If
        LecturaBD.Close()
        ' ---------------------------------------------------------------------------------
        Try
            InQry = ""
            InQry = "UPDATE CatGrupMaterial SET Desgrupmaterial='" & xDESCRIPCION.Trim & "', Tpo_grupmaterial='" & xTIPO.Trim & "', "
            InQry = InQry & " status ='" & xSTATUS.Trim & "', usuarioreg='" & xUSUARIOREG.Trim & "', fechareg='" & xFECHAREG.Trim & "', horareg='" & xHORAREG.Trim & "'"
            InQry = InQry & " WHERE centro ='" & StrPlanta.Trim & "' AND grupmaterial ='" & xCODIGO.Trim & "'"
            InsertQry(InQry)
            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        CargaGrid()
    End Sub
    Private Sub tsbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBorrar.Click
        Me.Close()
    End Sub

    Private Sub grdConsulta_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdConsulta.MouseDoubleClick
        If grdConsulta.CurrentRowIndex > -1 Or grdConsulta.CurrentCell.RowNumber > 0 Then
            txtCodigo.Text = grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 1).ToString
            txtDescripcion.Text = grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 2).ToString
            If grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 3).ToString = "1" Then
                rbtExtrusion.Checked = True
            Else
                rbtInyeccion.Checked = True
            End If
            If grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 4).ToString = "A" Then
                chkActivo.Checked = True
            Else
                chkActivo.Checked = False
            End If
        End If
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Close()
    End Sub
End Class