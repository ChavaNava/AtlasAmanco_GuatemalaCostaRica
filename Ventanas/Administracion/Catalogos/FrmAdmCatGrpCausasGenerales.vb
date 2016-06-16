Imports System.Data.SqlClient
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmAdmCatGrpcausasGenerales

    Dim ConexionSQL As SqlConnection
    Dim ConexComando As SqlCommand
    Dim Consulta_1 As String
    Dim Cadena_conexion As String
    Dim StrPlanta As String     'Planta

    Dim xCODIGO As String
    Dim xDESCRIPCION As String
    Dim xSTATUS As String

    Dim xUSUARIOREG As String
    Dim xFECHAREG As String
    Dim xHORAREG As String

    Dim myDataReader As SqlClient.SqlDataReader
    Dim Q As String

    Private Sub FrmAdmCatCausas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNumPlanta.Text = SessionUser._sCentro
        TxtPlanta.Text = SessionUser._sPlanta
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
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
            If Not xCODIGO = "" Then
                'Se realiza la insercion del nuevo registro
                objCmd.Connection = objCnnAmanco

                Q = "INSERT INTO catgrpgeneral (centro, codgrpgeneral, Desgrpgeneral, status, usuarioreg, fechareg, horareg) "
                Q = Q & " VALUES ('" & StrPlanta.Trim & "','" & xCODIGO.Trim & "','" & xDESCRIPCION.Trim & "','" & xSTATUS.Trim & "','" & xUSUARIOREG.Trim & "','" & xFECHAREG.Trim & "','" & xHORAREG.Trim & "')"
                objCmd.CommandText = Q

                Try
                    RegistrosActualizados = objCmd.ExecuteNonQuery()
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
                CargaGrid()
            Else
                MsgBox("El campo Codigo de grupo Causa General debe tener un valor....")
            End If
        End If
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

        xSQL = "Select * from catgrpgeneral WHERE centro = '" & StrPlanta & "'"

        If chkActivo.Checked Then
            xSQL = xSQL & "AND status='A'"
        Else
            xSQL = xSQL & "AND status='I'"
        End If

        xSQL = xSQL & "AND codgrpgeneral like ('%" & xCODIGO & "%') "
        xSQL = xSQL & "AND Desgrpgeneral like ('%" & xDESCRIPCION & "%') "
        objDa = New SqlDataAdapter(xSQL, objCnnAmanco.ConnectionString)
        Try
            objDs = New DataSet
            objDa.Fill(objDs)
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        grdConsulta.DataSource = objDs
        txtCodigo.Text = ""
        txtDescripcion.Text = ""

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        CargaGrid()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
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

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
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

            If Not xCODIGO = "" Then
                'Se realiza la insercion del nuevo registro
                objCmd.Connection = objCnnAmanco

                Q = "UPDATE catgrpgeneral SET Desgrpgeneral ='" & xDESCRIPCION.Trim & "', status='" & xSTATUS.Trim & "', usuarioreg='" & xUSUARIOREG.Trim & "', fechareg='" & xFECHAREG.Trim & "', horareg='" & xHORAREG.Trim & "'"
                Q = Q & " WHERE centro='" & StrPlanta.Trim & "' AND codgrpgeneral ='" & xCODIGO.Trim & "'"

                objCmd.CommandText = Q

                Try
                    RegistrosActualizados = objCmd.ExecuteNonQuery()
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
                CargaGrid()
            Else
                MsgBox("El campo Codigo de Grupo Causa General debe tener un valor....")
            End If
        End If

    End Sub

    Private Sub grdConsulta_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdConsulta.MouseDoubleClick
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


    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
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

                Q = "UPDATE catgrpgeneral SET status ='D', usuarioreg ='" & xUSUARIOREG.Trim & "', fechareg='" & xFECHAREG.Trim & "', horareg='" & xHORAREG.Trim & "'"
                Q = Q & " WHERE centro ='" & StrPlanta.Trim & "' AND codgrpgeneral ='" & xCODIGO.Trim & "'"

                objCmd.CommandText = Q

                Try
                    RegistrosActualizados = objCmd.ExecuteNonQuery()
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
                CargaGrid()
            Else
                MsgBox("El campo Codigo de Grupo Causa General debe tener un valor....")
            End If
        End If
    End Sub

End Class