Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmAdmCatRacks

    Dim ConexionSQL As SqlConnection
    Dim ConexComando As SqlCommand
    Dim Consulta_1 As String
    Dim Cadena_conexion As String
    Dim StrPlanta As String     'Planta

    Dim xCODIGO As String
    Dim xDESCRIPCION As String
    Dim xCAPACIDAD As String
    Dim xTARA As String
    Dim xSTATUS As String

    Dim xUSUARIOREG As String
    Dim xFECHAREG As String
    Dim xHORAREG As String

    Dim myDataReader As SqlClient.SqlDataReader
    Dim Q As String
    Dim xRegCount As Integer = 0

    Private Sub FrmAdmCatCausas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Me.Text = "Catalogo RACKS" & "                    CENTRO : " & StrPlanta.Trim
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

        xSQL = "SELECT * FROM racks WHERE centro = '" & StrPlanta & "'"

        If chkActivo.Checked Then
            xSQL = xSQL & "AND status='A'"
        Else
            xSQL = xSQL & "AND status='I'"
        End If

        xSQL = xSQL & "AND rack LIKE ('%" & xCODIGO & "%') "
        xSQL = xSQL & "AND Descripcion LIKE ('%" & xDESCRIPCION & "%') "
        objDa = New SqlDataAdapter(xSQL, objCnnAmanco.ConnectionString)
        Try
            objDs = New DataSet
            objDa.Fill(objDs)
            grdConsulta.DataSource = objDs

            xRegCount = objDs.Tables(0).Rows.Count
            grdConsulta.CaptionText = "Racks        Registros: " & xRegCount

        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtCapacidad.Text = "0"
        txtTara.Text = "0"
    End Sub

    Private Sub txtCapacidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapacidad.KeyPress
        e.Handled = txtNumerico(txtCapacidad, e.KeyChar, True)
    End Sub

    Private Sub txtTara_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTara.KeyPress
        e.Handled = txtNumerico(txtTara, e.KeyChar, True)
    End Sub

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Dim RegistrosActualizados As Integer

        If txtCodigo.Text <> "" Then

            AbrirAmanco()

            objCmd = New SqlCommand
            objCmd.CommandType = CommandType.Text
            objCmd.Connection = objCnnAmanco

            'Asignar valor a variables
            xCODIGO = txtCodigo.Text.Trim
            xDESCRIPCION = txtDescripcion.Text.Trim

            If chkActivo.Checked Then
                xSTATUS = "A"
            Else
                xSTATUS = "I"
            End If

            xUSUARIOREG = SessionUser._sAlias
            xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
            xHORAREG = Date.Now.TimeOfDay.ToString

            xCAPACIDAD = "0"
            xTARA = "0"
            xCAPACIDAD = Replace(txtCapacidad.Text.Trim, GDECIMAL, ".")
            xTARA = Replace(txtTara.Text.Trim, GDECIMAL, ".")

            If Not xCODIGO = "" Then
                'Se realiza la insercion del nuevo registro
                objCmd.Connection = objCnnAmanco

                Q = "INSERT INTO racks (centro, rack, descripcion,status, usuarioreg, fechareg, horareg,Capacidad,Tara) "
                Q = Q & " VALUES ('" & StrPlanta.Trim & "','" & xCODIGO.Trim & "','" & xDESCRIPCION.Trim & "','" & xSTATUS.Trim & "','" & xUSUARIOREG.Trim & "','"
                Q = Q & xFECHAREG.Trim & "','" & xHORAREG.Trim & "'," & xCAPACIDAD & "," & xTARA & ")"
                objCmd.CommandText = Q

                Try
                    RegistrosActualizados = objCmd.ExecuteNonQuery()
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
                CargaGrid()
            Else
                MsgBox("El campo Codigo de RACK debe tener un valor....")
            End If
        End If
    End Sub

    Private Sub tsbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBorrar.Click
        Dim RegistrosActualizados As Integer

        If txtCodigo.Text <> "" Then

            AbrirAmanco()

            objCmd = New SqlCommand
            objCmd.CommandType = CommandType.Text
            objCmd.Connection = objCnnAmanco

            'Asignar valor a variables
            xCODIGO = txtCodigo.Text.Trim

            xSTATUS = "D"

            xUSUARIOREG = SessionUser._sAlias
            xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
            xHORAREG = Date.Now.TimeOfDay.ToString
            If Not xCODIGO = "" Then
                'Se realiza la insercion del nuevo registro
                objCmd.Connection = objCnnAmanco

                Q = "UPDATE racks SET status='D', usuarioreg='" & xUSUARIOREG.Trim & "', fechareg='" & xFECHAREG.Trim & "', horareg='" & xHORAREG.Trim & "'"
                Q = Q & " WHERE centro ='" & StrPlanta.Trim & "' AND rack ='" & xCODIGO.Trim & "'"

                objCmd.CommandText = Q

                Try
                    RegistrosActualizados = objCmd.ExecuteNonQuery()
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
                CargaGrid()
            Else
                MsgBox("El campo Codigo de RACK debe tener un valor....")
            End If
        End If
    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click
        Dim RegistrosActualizados As Integer

        If txtCodigo.Text <> "" Then

            AbrirAmanco()

            objCmd = New SqlCommand
            objCmd.CommandType = CommandType.Text
            objCmd.Connection = objCnnAmanco

            'Asignar valor a variables
            xCODIGO = txtCodigo.Text.Trim
            xDESCRIPCION = txtDescripcion.Text.Trim
            xCAPACIDAD = "0"
            xTARA = "0"
            xCAPACIDAD = Replace(txtCapacidad.Text.Trim, GDECIMAL, ".")
            xTARA = Replace(txtTara.Text.Trim, GDECIMAL, ".")

            If chkActivo.Checked Then
                xSTATUS = "A"
            Else
                xSTATUS = "I"
            End If

            xUSUARIOREG = SessionUser._sAlias
            xFECHAREG = Date.Today.ToString("yyyy-MM-dd")
            xHORAREG = Date.Now.TimeOfDay.ToString
            If Not xCODIGO = "" Then
                'Se realiza la insercion del nuevo registro
                objCmd.Connection = objCnnAmanco

                Q = "UPDATE racks SET descripcion='" & xDESCRIPCION.Trim & "', capacidad=" & xCAPACIDAD.Trim & ", tara =" & xTARA.Trim & ", status ='" & xSTATUS.Trim & "', usuarioreg='" & xUSUARIOREG.Trim & "', fechareg='" & xFECHAREG.Trim & "', horareg='" & xHORAREG.Trim & "'"
                Q = Q & " WHERE centro ='" & StrPlanta.Trim & "' AND rack ='" & xCODIGO.Trim & "'"

                objCmd.CommandText = Q

                Try
                    RegistrosActualizados = objCmd.ExecuteNonQuery()
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
                CargaGrid()
            Else
                MsgBox("El campo Codigo de RACK debe tener un valor....")
            End If
        End If

    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Me.Close()
    End Sub

    Private Sub grdConsulta_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdConsulta.DoubleClick
        If grdConsulta.CurrentRowIndex > -1 Or grdConsulta.CurrentCell.RowNumber > 0 Then
            txtCodigo.Text = grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 1).ToString.Trim
            txtDescripcion.Text = grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 2).ToString.Trim
            txtCapacidad.Text = grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 3).ToString
            txtTara.Text = grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 4).ToString
            If grdConsulta.Item(grdConsulta.CurrentCell.RowNumber, 5).ToString = "A" Then
                chkActivo.Checked = True
            Else
                chkActivo.Checked = False
            End If
        End If
    End Sub
End Class