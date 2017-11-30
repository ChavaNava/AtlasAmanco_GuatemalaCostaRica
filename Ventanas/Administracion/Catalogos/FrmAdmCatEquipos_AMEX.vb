Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmAdmCatEquipos_AMEX
#Region "Variables miembro"
    Dim ConexionSQL As SqlConnection
    Dim ConexComando As SqlCommand
    Dim Consulta_1 As String
    Dim Cadena_conexion As String

    Dim xCODIGO As String
    Dim xDESCRIPCION As String

    Dim xTIPO As String
    Dim xMARCA As String
    Dim xMODELO As String

    Dim xAREA As String
    Dim xSECCION As String
    Dim xGRPMATERIAL As String

    Dim xCAPACIDAD As String
    Dim xSOBREPESO As String

    'Variables consulta Grid
    Dim C_EqpBasico As String
    Dim C_Marca As String
    Dim C_Desc As String
    Dim C_Modelo As String
    Dim C_GrpProd As String
    Dim C_Secc As String
    Dim C_GrpMat As String
    Dim C_Cap As String
    Dim C_Limite As String
    Dim C_Status As Boolean

    Dim myDataReader As SqlClient.SqlDataReader
    Dim Q As String
    Dim xRegCount As Integer = 0
#End Region

    Private Sub FrmAdmCatEquipos_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Me.Text = "Catalogo EQUIPOS" & "                    CENTRO : " & SessionUser._sCentro.Trim
    End Sub

    Private Sub CargaGrid()
        QRY_Grid = ""
        NameTable = ""
        NameTable = "Equipobasico"
        QRY_Grid = "Select Equipo_Basico,Marca,Descripcion,Modelo,grpprod,codseccion,grupmaterial,"
        QRY_Grid = QRY_Grid & "Capacidad_KgHora,Limite_Sobrepeso,Status "
        QRY_Grid = QRY_Grid & "From EquipoBasico "
        QRY_Grid = QRY_Grid & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
        If rbtExtrusion.Checked = True Then
            QRY_Grid = QRY_Grid & "And Tpo_Equipo_basico = '1' "
        Else : rbtInyeccion.Checked = True
            QRY_Grid = QRY_Grid & "And Tpo_Equipo_basico = '2' "
        End If

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGV_EQP.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGV_EQP.Columns(0).HeaderText = "Codigo Equipo"
        DGV_EQP.Columns(1).HeaderText = "Marca"
        DGV_EQP.Columns(2).HeaderText = "Descripción"
        DGV_EQP.Columns(3).HeaderText = "Modelo"
        DGV_EQP.Columns(4).HeaderText = "Grupo Productivo"
        DGV_EQP.Columns(5).HeaderText = "Sección"
        DGV_EQP.Columns(6).HeaderText = "Grupo Material"
        DGV_EQP.Columns(7).HeaderText = "Capacidad Kg / Hora"
        DGV_EQP.Columns(8).HeaderText = "Limite de Sobrepeso"
        DGV_EQP.Columns(9).Visible = False      'Status Equipo

    End Sub

    Private Sub txtCapacidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapacidad.KeyPress
        e.Handled = txtNumerico(txtCapacidad, e.KeyChar, True)
    End Sub

    Private Sub txtTara_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSobrepeso.KeyPress
        e.Handled = txtNumerico(txtSobrepeso, e.KeyChar, True)
    End Sub

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Dim dCapacidad As Decimal = 0
        Dim dSobrepeso As Decimal = 0
        ' ---------------------------------------------------------------------------------
        dCapacidad = "0" & Me.txtCapacidad.Text.Trim
        dSobrepeso = "0" & Me.txtSobrepeso.Text.Trim
        ' ---------------------------------------------------------------------------------
        If txtCodigo.Text.Trim = "" Or txtDescripcion.Text.Trim = "" Then
            Mensajes("*** Los campos CODIGO Y DESCRIPCION deben tener valor *** ", 1)
            Exit Sub
        End If
        If txtMarca.Text.Trim = "" Or txtModelo.Text.Trim = "" Then
            Mensajes("*** Los campos MARCA Y MODELO deben tener valor *** ", 1)
            Exit Sub
        End If
        If TArea.Text.Trim = "" Or TSeccion.Text.Trim = "" Or Tgrpmaterial.Text.Trim = "" Then
            Mensajes("*** Los campos AREA, SECCION y GRUPO MEDIDA deben tener valor *** ", 1)
            Exit Sub
        End If
        If txtCapacidad.Text.Trim = "" Or txtSobrepeso.Text.Trim = "" Or dCapacidad = 0 Or dSobrepeso < 0 Then
            Mensajes("*** Los campos CAPACIDAD Y SOBREPESO deben tener valor *** ", 1)
            Exit Sub
        End If
        ' ---------------------------------------------------------------------------------
        xCODIGO = Me.txtCodigo.Text.Trim
        xDESCRIPCION = Me.txtDescripcion.Text.Trim
        xMARCA = Me.txtMarca.Text.Trim
        xMODELO = Me.txtModelo.Text.Trim
        xAREA = TArea.Text.Trim
        xSECCION = TSeccion.Text.Trim
        xGRPMATERIAL = Tgrpmaterial.Text.Trim

        xCAPACIDAD = Replace(Me.txtCapacidad.Text.Trim, GDECIMAL, ".")
        xSOBREPESO = Replace(Me.txtSobrepeso.Text.Trim, GDECIMAL, ".")
        If rbtExtrusion.Checked Then
            xTIPO = "1"
        Else
            xTIPO = "2"
        End If
        ' ---------------------------------------------------------------------------------
        QRY = ""
        QRY = QRY & " SELECT Equipo_basico FROM EquipoBasico "
        QRY = QRY & " WHERE planta ='" & SessionUser._sCentro.Trim & "' AND Equipo_basico='" & xCODIGO.Trim & "'"
        QRY = QRY & " AND tpo_equipo_basico='" & xTIPO.Trim & "'"
        LecturaQry(QRY)
        If LecturaBD.Read Then
            Mensajes("***  EQUIPO ya existe *** ", 1)
            LecturaBD.Close()
            Exit Sub
        End If
        LecturaBD.Close()
        ' ---------------------------------------------------------------------------------
        Try
            InQry = ""
            InQry = "INSERT INTO EquipoBasico (planta, Equipo_basico, Descripcion, Marca, Modelo, tpo_equipo_basico, Capacidad_KgHora, Limite_sobrepeso, grpprod, codseccion, grupmaterial) "
            InQry = InQry & " VALUES ('" & SessionUser._sCentro.Trim & "','" & xCODIGO.Trim & "','" & xDESCRIPCION.Trim & "','" & xMARCA.Trim & "','" & xMODELO.Trim & "','"
            InQry = InQry & xTIPO.Trim & "'," & xCAPACIDAD.Trim & "," & xSOBREPESO.Trim & ",'" & xAREA.Trim & "','" & xSECCION.Trim & "','" & xGRPMATERIAL.Trim & "')"
            InsertQry(InQry)
            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        CargaGrid()
    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click
        Dim dCapacidad As Decimal = 0
        Dim dSobrepeso As Decimal = 0
        ' ---------------------------------------------------------------------------------
        dCapacidad = "0" & Me.txtCapacidad.Text.Trim
        dSobrepeso = "0" & Me.txtSobrepeso.Text.Trim
        ' ---------------------------------------------------------------------------------
        If txtCodigo.Text.Trim = "" Or txtDescripcion.Text.Trim = "" Then
            Mensajes("*** Los campos CODIGO Y DESCRIPCION deben tener valor *** ", 1)
            Exit Sub
        End If
        If txtMarca.Text.Trim = "" Or txtModelo.Text.Trim = "" Then
            Mensajes("*** Los campos MARCA Y MODELO deben tener valor *** ", 1)
            Exit Sub
        End If
        If TArea.Text.Trim = "" Or TSeccion.Text.Trim = "" Or Tgrpmaterial.Text.Trim = "" Then
            Mensajes("*** Los campos AREA, SECCION y GRUPO MEDIDA deben tener valor *** ", 1)
            Exit Sub
        End If
        If txtCapacidad.Text.Trim = "" Or txtSobrepeso.Text.Trim = "" Or dCapacidad < 0 Or dSobrepeso < 0 Then
            Mensajes("*** Los campos CAPACIDAD Y SOBREPESO deben tener valor *** ", 1)
            Exit Sub
        End If
        ' ---------------------------------------------------------------------------------
        xCODIGO = Me.txtCodigo.Text.Trim
        xDESCRIPCION = Me.txtDescripcion.Text.Trim
        xMARCA = Me.txtMarca.Text.Trim
        xMODELO = Me.txtModelo.Text.Trim
        xAREA = TArea.Text.Trim
        xSECCION = TSeccion.Text.Trim
        xGRPMATERIAL = Tgrpmaterial.Text.Trim

        xCAPACIDAD = Replace(Me.txtCapacidad.Text.Trim, GDECIMAL, ".")
        xSOBREPESO = Replace(Me.txtSobrepeso.Text.Trim, GDECIMAL, ".")

        If rbtExtrusion.Checked Then
            xTIPO = "1"
        Else
            xTIPO = "2"
        End If
        ' ---------------------------------------------------------------------------------
        QRY = ""
        QRY = QRY & " SELECT Equipo_basico FROM EquipoBasico "
        QRY = QRY & " WHERE planta ='" & SessionUser._sCentro.Trim & "' AND Equipo_basico='" & xCODIGO.Trim & "'"
        QRY = QRY & " AND tpo_equipo_basico='" & xTIPO.Trim & "'"
        LecturaQry(QRY)
        If Not LecturaBD.Read Then
            Mensajes("***  EQUIPO NO existe *** ", 1)
            LecturaBD.Close()
            Exit Sub
        End If
        LecturaBD.Close()
        ' ---------------------------------------------------------------------------------
        Try
            InQry = ""
            InQry = "UPDATE EquipoBasico SET Descripcion='" & xDESCRIPCION.Trim & "', tpo_equipo_basico='" & xTIPO.Trim & "', Capacidad_KgHora=" & xCAPACIDAD.Trim & ", Marca ='" & xMARCA.Trim & "', "
            InQry = InQry & " Modelo ='" & xMODELO.Trim & "', Limite_sobrepeso=" & xSOBREPESO.Trim & ", grpprod='" & xAREA.Trim & "', codseccion='" & xSECCION.Trim & "', grupmaterial='" & xGRPMATERIAL.Trim & "' "
            InQry = InQry & " WHERE planta ='" & SessionUser._sCentro.Trim & "' AND Equipo_basico ='" & xCODIGO.Trim & "'"
            InsertQry(InQry)
            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        CargaGrid()
    End Sub
    Private Sub tsbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnLookArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookArea.Click
        'Q = "SELECT grpprod, desgrupo FROM catgrupos "
        'Q = Q & "WHERE centro = '" & strPlanta.Trim & "' "
        'frmSpro.SPRO_TITULO = "Catalogo de GRUPOS"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "desgrupo"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TArea.Text = frmSpro.SPRO_KEY
        '    Q = " SELECT desgrupo FROM catgrupos"
        '    Q = Q & " WHERE centro = '" & strPlanta.Trim & "' "
        '    Q = Q & " AND grpprod = '" & TArea.Text & "'"
        '    TNomArea.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub

    Private Sub btnLookSeccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookSeccion.Click
        'Q = "SELECT codseccion, desseccion FROM catsecciones "
        'Q = Q & "WHERE centro = '" & strPlanta.Trim & "' "
        'frmSpro.SPRO_TITULO = "Catalogo de SECCIONES"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "desseccion"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    TSeccion.Text = frmSpro.SPRO_KEY
        '    Q = " SELECT desseccion FROM catsecciones "
        '    Q = Q & " WHERE centro = '" & strPlanta.Trim & "' "
        '    Q = Q & " AND codseccion = '" & TSeccion.Text & "'"
        '    TNomSeccion.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub

    Private Sub TSeccion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSeccion.Leave
        AbrirAmanco(SessionUser._sAmbiente)
        objCmd.Connection = objCnnAmanco
        Q = " SELECT desseccion FROM catsecciones"
        Q = Q & " WHERE centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & " AND rtrim(codseccion) = '" & TSeccion.Text.Trim & "'"
        objCmd.CommandText = Q
        Try
            myDataReader = objCmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        If myDataReader.Read Then
            TNomSeccion.Text = myDataReader(0)
        Else
            TSeccion.Text = ""
            TNomSeccion.Text = ""
        End If
        myDataReader.Close()
        TSeccion.BackColor = Color.White
    End Sub

    Private Sub TSeccion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSeccion.Enter
        TSeccion.BackColor = Color.Yellow
    End Sub

    Private Sub TArea_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TArea.Enter
        TArea.BackColor = Color.Yellow
    End Sub

    Private Sub TArea_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TArea.Leave
        AbrirAmanco(SessionUser._sAmbiente)
        objCmd.Connection = objCnnAmanco
        Q = " SELECT desgrupo FROM catgrupos"
        Q = Q & " WHERE centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & " AND rtrim(grpprod) = '" & TArea.Text.Trim & "'"
        objCmd.CommandText = Q
        Try
            myDataReader = objCmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        If myDataReader.Read Then
            TNomArea.Text = myDataReader(0)
        Else
            TArea.Text = ""
            TNomArea.Text = ""
        End If
        myDataReader.Close()
        TArea.BackColor = Color.White
    End Sub

    Private Sub TArea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TArea.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TSeccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TSeccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnLookGrMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookGrMaterial.Click
        'If rbtExtrusion.Checked Then
        '    xTIPO = "1"
        'Else
        '    xTIPO = "2"
        'End If
        'Q = "SELECT grupmaterial, Desgrupmaterial FROM CatGrupMaterial "
        'Q = Q & "WHERE centro = '" & strPlanta.Trim & "' "
        'Q = Q & " AND Tpo_grupmaterial='" & xTIPO & "'"
        'frmSpro.SPRO_TITULO = "Catalogo de GRUPOS DIAMETROS"
        'frmSpro.SPRO_SQL = Q
        'frmSpro.SPRO_OK = 0
        'frmSpro.SPRO_COLKEY = 0
        'frmSpro.SPRO_KEY = ""
        'frmSpro.SPRO_LIKE = "Desgrupmaterial"
        'frmSpro.ShowDialog()
        'If frmSpro.SPRO_OK = 1 Then
        '    Tgrpmaterial.Text = frmSpro.SPRO_KEY
        '    Q = " SELECT Desgrupmaterial FROM CatGrupMaterial "
        '    Q = Q & " WHERE centro = '" & strPlanta.Trim & "' "
        '    Q = Q & " AND Tpo_grupmaterial='" & xTIPO & "'"
        '    Q = Q & " AND grupmaterial = '" & Tgrpmaterial.Text & "'"
        '    TNomgrpmaterial.Text = TraeDescripcion(Q)
        '    frmSpro.SPRO_OK = 0
        'End If
    End Sub

    Private Sub Tgrpmaterial_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tgrpmaterial.Enter
        Tgrpmaterial.BackColor = Color.Yellow
    End Sub

    Private Sub Tgrpmaterial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tgrpmaterial.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Tgrpmaterial_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tgrpmaterial.Leave
        If rbtExtrusion.Checked Then
            xTIPO = "1"
        Else
            xTIPO = "2"
        End If
        AbrirAmanco(SessionUser._sAmbiente)
        objCmd.Connection = objCnnAmanco
        Q = " SELECT Desgrupmaterial FROM CatGrupMaterial "
        Q = Q & " WHERE centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & " AND Tpo_grupmaterial='" & xTIPO & "'"
        Q = Q & " AND rtrim(grupmaterial) = '" & Tgrpmaterial.Text.Trim & "'"
        objCmd.CommandText = Q
        Try
            myDataReader = objCmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        If myDataReader.Read Then
            TNomgrpmaterial.Text = myDataReader(0)
        Else
            Tgrpmaterial.Text = ""
            TNomgrpmaterial.Text = ""
        End If
        myDataReader.Close()
        Tgrpmaterial.BackColor = Color.White
    End Sub

    Private Sub DGV_EQP_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_EQP.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV_EQP.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGV_EQP.CurrentCell.RowIndex
                C_EqpBasico = DGV_EQP.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                C_Marca = DGV_EQP.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                C_Desc = DGV_EQP.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                C_Modelo = DGV_EQP.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                C_GrpProd = DGV_EQP.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                C_Secc = DGV_EQP.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                C_GrpMat = DGV_EQP.Rows(Fila_Seleccionada).Cells(6).Value.ToString
                C_Cap = DGV_EQP.Rows(Fila_Seleccionada).Cells(7).Value.ToString
                C_Limite = DGV_EQP.Rows(Fila_Seleccionada).Cells(8).Value.ToString
                C_Status = DGV_EQP.Rows(Fila_Seleccionada).Cells(9).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            txtCodigo.Text = C_EqpBasico
            txtDescripcion.Text = C_Desc
            txtMarca.Text = C_Marca
            txtModelo.Text = C_Modelo
            TArea.Text = C_GrpProd
            TSeccion.Text = C_Secc
            Tgrpmaterial.Text = C_GrpMat
            txtCapacidad.Text = C_Cap
            txtSobrepeso.Text = C_Limite

            If C_Status = True Then
                chkActivo.Checked = C_Status
                chkActivo.Text = "Activo"
            Else
                chkActivo.Checked = C_Status
                chkActivo.Text = "Inactivo"
            End If


        End If
    End Sub
End Class