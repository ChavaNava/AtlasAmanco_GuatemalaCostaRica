Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmAdmCatProdEmb
    Dim myDataReader As SqlClient.SqlDataReader
    Dim Q As String
    Dim ConexionSQL As SqlConnection
    Dim ConexComando As SqlCommand
    Dim Consulta_1 As String
    Dim Cadena_conexion As String

    'Variables de lectura
    Dim CodPT As String
    Dim C_CodEmb As String
    Dim C_DesEmb As String
    Dim C_CodTipo As String
    Dim C_DesTipo As String
    Dim C_Cantidad As String
    Dim C_PesoUni As String
    Dim C_Tipo As String = ""

    'Variables Tipo
    Dim TipEmb As String

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        CargaGrid()
    End Sub

    Private Sub FrmAdmCatProdEmb_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Text = "Catalogo PRODUCTO/MATERIAL" & "CENTRO : " & SessionUser._sCentro.Trim
        ProductoTerminadoExtrusion.CB_Productos(CB_Codigo, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", EXTINY)
        PBActualiza.Visible = False
        tsbGrabar.Enabled = False
        BloqueaText(Me)
        BloqueaButton(Me)
        BloqueaCheckBox(Me)

    End Sub

    'Sub CB_Mat()
    '    Dim NDataSet1 As New DataSet
    '    QryCombo = ""
    '    QryCombo = "Select Codigo,Descr,Codigo+Descr as Producto  "
    '    If EXTINY = "1" Then
    '        QryCombo = QryCombo & "From productoterminadoextrusion "
    '    Else
    '        QryCombo = QryCombo & "From productoterminadoinyeccion "
    '    End If
    '    QryCombo = QryCombo & "Where Centro = '" & SessionUser._sCentro.Trim & " ' "
    '    QryCombo = QryCombo & "Order by Codigo "
    '    Combo(QryCombo)
    '    NDataSet1 = DataSetCombo.Copy
    '    CB_Codigo.DataSource = NDataSet1.Tables(0)
    '    CB_Codigo.DisplayMember = "Producto"
    '    CB_Codigo.ValueMember = "Codigo"
    'End Sub

    Private Sub CargaGrid()

        QRY_Grid = ""
        NameTable = ""
        NameTable = "CatalogoEmbalajes"
        QRY_Grid = "Select a.CodEmb,b.Descr,a.CveTipo,c.DesTipoEmb,a.PXProdCaja,b.PesoUni "
        QRY_Grid = QRY_Grid & "From Embalajes_PTI a, CatMateriales b, EmbalajeTipo c "
        QRY_Grid = QRY_Grid & "Where a. Centro = b.Centro "
        QRY_Grid = QRY_Grid & "And a.CodEmb = b.Codigo "
        QRY_Grid = QRY_Grid & "And a.Centro = c.Centro "
        QRY_Grid = QRY_Grid & "And a.CveTipo = c.CveTipo "
        QRY_Grid = QRY_Grid & "And a.CodPTI = '" & CB_Codigo.SelectedValue.Trim & "' "
        QRY_Grid = QRY_Grid & "And a.Centro = '" & SessionUser._sCentro.Trim & "' "

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGVProd.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGVProd.Columns(0).HeaderText = "Código Embalaje"
        DGVProd.Columns(1).HeaderText = "Descripción"
        DGVProd.Columns(2).HeaderText = "Código Tipo"
        DGVProd.Columns(3).HeaderText = "Descripción Tipo"
        DGVProd.Columns(4).HeaderText = "Piezas X Producto ó Productos X Caja/Bolsa"
        DGVProd.Columns(5).HeaderText = "Peso Unitario"

    End Sub

    Private Sub DGVProd_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGVProd.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGVProd.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGVProd.CurrentCell.RowIndex
                C_CodEmb = DGVProd.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                C_DesEmb = DGVProd.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                C_CodTipo = DGVProd.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                C_DesTipo = DGVProd.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                C_Cantidad = DGVProd.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                C_PesoUni = DGVProd.Rows(Fila_Seleccionada).Cells(5).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            TCodEmb.Text = C_CodEmb
            TDesEmb.Text = C_DesEmb
            TPesoUni.Text = C_PesoUni
            TCant.Text = C_Cantidad
            CodPT = CB_Codigo.SelectedValue.Trim


            If C_CodTipo.Trim = "B" Or C_CodTipo.Trim = "C" Then
                Label4.Text = "Producto X Caja/Bolsa"
            Else
                Label4.Text = "Piezas X Producto"
            End If

            tsbGrabar.Enabled = False
            BloqueaText(Me)
            BloqueaButton(Me)

        End If
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Me.Close()
    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click
        Accion = "Modifica"
        If CB_Codigo.Text = "*" Then
            MsgBox("Seleccione un Producto para Modificar Compuesto")
            Return
        Else
            ActivaText(Me)
            ActivaButton(Me)
            tsbAlta.Enabled = False
            tsbGrabar.Enabled = True
            CB_Codigo.Enabled = False
        End If
    End Sub

    Private Sub btnEmpaque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpaque.Click

        C_Tipo = ""

        Q = ""
        Q = "SELECT Codigo,Descr FROM CatMateriales Where Centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & "And TipoProduccion = '2' "
        frmSpro.SPRO_TITULO = "Descripción de Embalajes"
        frmSpro.SPRO_SQL = Q
        frmSpro.SPRO_OK = 0
        frmSpro.SPRO_COLKEY = 0
        frmSpro.SPRO_KEY = ""
        frmSpro.SPRO_LIKE = "DesEmb"
        frmSpro.ShowDialog()
        If frmSpro.SPRO_OK = 1 Then
            TCodEmb.Text = frmSpro.SPRO_KEY
            'Descripcion Embalaje
            Q = ""
            Q = "SELECT Descr FROM CatMateriales "
            Q = Q & " WHERE Codigo = '" & TCodEmb.Text.Trim & "' "
            TDesEmb.Text = TraeDescripcion(Q)
            frmSpro.SPRO_OK = 0
            'Peso Unitario Embalaje
            Q = ""
            Q = "SELECT PesoUni FROM CatMateriales "
            Q = Q & " WHERE Codigo = '" & TCodEmb.Text.Trim & "' "
            TPesoUni.Text = TraeDescripcion(Q)
            frmSpro.SPRO_OK = 0
            'Clave Tipo
            Q = ""
            Q = "SELECT TipoMat FROM CatMateriales "
            Q = Q & " WHERE Codigo = '" & TCodEmb.Text.Trim & "' "
            C_Tipo = TraeDescripcion(Q)
            frmSpro.SPRO_OK = 0
            'Tipo Embalaje
            Q = ""
            Q = "SELECT TipoMat FROM CatMateriales "
            Q = Q & " WHERE Codigo = '" & TCodEmb.Text.Trim & "' "
            TipEmb = TraeDescripcion(Q)
            frmSpro.SPRO_OK = 0

            If TipEmb.Trim = "B" Or TipEmb = "C" Then
                Label4.Text = "Producto X Caja/Bolsa"
            Else
                Label4.Text = "Piezas X Producto"
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BackgroundWorker1.ReportProgress(15)

        System.Threading.Thread.Sleep(2000) ' Para simular tiempo de espera


        BackgroundWorker1.ReportProgress(30)

        Select Case Accion

            Case Is = "Alta"

                Try
                    BackgroundWorker1.ReportProgress(50)

                    InQry = ""
                    InQry = "INSERT INTO Embalajes_PTI(Centro,CodPTI,CodEmb,DesEmb,CveTipo,PXProdCaja,PesoAccCaja) "
                    InQry = InQry & "Values('" & SessionUser._sCentro.Trim & "','" & CodPT.Trim & "','" & TCodEmb.Text.Trim & "',"
                    InQry = InQry & "'" & TDesEmb.Text.Trim & "','" & C_Tipo.Trim & "','" & TCant.Text & "','0')"
                    InsertQry(InQry)

                    BackgroundWorker1.ReportProgress(75)

                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try

            Case Is = "Modifica"

                Try

                    BackgroundWorker1.ReportProgress(50)

                    InQry = ""
                    InQry = " UPDATE Embalajes_PTI SET CodEmb = '" & TCodEmb.Text.Trim & "', "
                    InQry = InQry & "DesEmb = '" & TDesEmb.Text.Trim & "', "
                    InQry = InQry & "CveTipo = '" & C_Tipo.Trim & "', "
                    InQry = InQry & "PXProdCaja = '" & TCant.Text & "', "
                    InQry = InQry & "PesoAccCaja = '" & TPesoUni.Text.Trim & "' "
                    InQry = InQry & "WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
                    InQry = InQry & "AND CodPTI = '" & CodPT.Trim & "'"
                    InQry = InQry & "AND CodEmb = '" & C_CodEmb.Trim & "'"
                    InsertQry(InQry)

                    BackgroundWorker1.ReportProgress(75)

                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try

        End Select

        BackgroundWorker1.ReportProgress(100)

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        PBActualiza.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        CargaGrid()
        MessageBox.Show("Información Actualizada")
        tsbGrabar.Enabled = False
        tsbAlta.Enabled = True
        PBActualiza.Value = 0
        PBActualiza.Visible = False
        CB_Codigo.Enabled = True
        Accion = ""
    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click

        If CB_Codigo.Text.Trim = "*" Or CB_Codigo.Text.Trim = "" Then
            Mensajes("*** El campo CODIGO debe tener valor *** ", 1)
            Exit Sub
        End If

        If TCodEmb.Text.Trim = "" Then
            Mensajes("*** Capture el Código del Embalaje *** ", 1)
            Exit Sub
        End If

        If TPesoUni.Text.Trim = "" Then
            Mensajes("*** El embalaje no tiene asignado peso unitario *** ", 1)
            Exit Sub
        End If

        If TCant.Text.Trim = "" Then
            Mensajes("*** El campo '" & Label4.Text.Trim & "' no tiene asignado valor *** ", 1)
            Exit Sub
        End If

        CodPT = CB_Codigo.SelectedValue.Trim

        Try
            If Accion = "Alta" Then
                QRY = ""
                QRY = QRY & " SELECT CodEmb FROM Embalajes_PTI "
                QRY = QRY & " WHERE Centro = '" & SessionUser._sCentro.Trim & "' "
                QRY = QRY & "AND CodPTI = '" & CB_Codigo.SelectedValue.Trim & "' "
                QRY = QRY & "AND CodEmb = '" & TCodEmb.Text.Trim & "' "
                LecturaQry(QRY)

                If LecturaBD.Read Then
                    Mensajes("***  Producto ya existe *** ", 1)
                    LecturaBD.Close()
                    Exit Sub
                End If
                LecturaBD.Close()
            End If
            ' ---------------------------------------------------------------------------------

        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        PBActualiza.Visible = True

        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub tsbAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAlta.Click
        Accion = "Alta"
        If CB_Codigo.Text = "*" Then
            MsgBox("Seleccione un Producto para Asignar Embalajes")
            Return
        Else
            tsbGrabar.Enabled = True
            ActivaText(Me)
            ActivaButton(Me)
            LimpiarText(Me)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If tsbGrabar.Enabled = True Then
            tsbGrabar.Enabled = False
        End If
        If tsbModificar.Enabled = True Then
            tsbModificar.Enabled = False
        End If
        If tsbAlta.Enabled = False Then
            tsbAlta.Enabled = True
        End If
        BloqueaText(Me)
        BloqueaButton(Me)
        BloqueaCheckBox(Me)
        LimpiarText(Me)
        LimpiarCheckBox(Me)
        CB_Codigo.Enabled = True
        CB_Codigo.Text = "*"
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click


        CodPT = CB_Codigo.SelectedValue.Trim

        QRY = ""
        NameTable = ""
        NameTable = "BorrarEmbalaje"
        QRY = "Delete Embalajes_PTI "
        QRY = QRY & "Where CodPTI = '" & CodPT.Trim & "' "
        QRY = QRY & "And CodEmb = '" & C_CodEmb.Trim & "' "
        QRY = QRY & "And Centro = '" & SessionUser._sCentro.Trim & "' "
        LecturaQry(QRY)

        CargaGrid()

    End Sub
End Class