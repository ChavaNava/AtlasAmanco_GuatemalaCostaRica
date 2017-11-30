Imports System.Data.SqlClient
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmSupervision_Rol_AMEX
    Dim Str_FI As String    'Fecha inicio consulta
    Dim Str_FF As String    'Fecha fin consulta
    Dim C_Mes As String

    Dim Message As String = ""
    Dim Caption As String = ""
    Dim Result As DialogResult
    Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
    Dim Botones As MessageBoxButtons = MessageBoxButtons.OK

    'Variables Consulta
    Dim C_Sup As String
    Dim C_Fecha As String
    Dim C_Turno As Integer

    Sub FillCBSuper()
        Dim NDataSet1 As New DataSet
        QryCombo = ""
        QryCombo = "select * from ADM_Usuario "
        QryCombo = QryCombo & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
        QryCombo = QryCombo & "And Puesto = '3' "
        Combo_AMD(QryCombo)
        NDataSet1 = DataSetCombo.Copy
        CB_Sup.DataSource = NDataSet1.Tables(0)
        CB_Sup.DisplayMember = "Nombre"
        CB_Sup.ValueMember = "Usuario"
    End Sub

    Sub FillCBTurno()
        Dim NDataSet1 As New DataSet
        QryCombo = ""
        QryCombo = "Select * from ADM_Turno "
        QryCombo = QryCombo & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
        Combo_AMD(QryCombo)
        NDataSet1 = DataSetCombo.Copy
        CB_Turno.DataSource = NDataSet1.Tables(0)
        CB_Turno.DisplayMember = "Descripción"
        CB_Turno.ValueMember = "Turno"
    End Sub

    Public Sub Grid_Load()

        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim

        QRY_Grid = ""
        NameTable = ""
        NameTable = "Roles_Sup"
        QRY_Grid = "Select * From " & SessionUser._sCentro.Trim & "_Rol_Supervisor "
        QRY_Grid = QRY_Grid & "Where Fecha Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "' "
        If CB_Sup.Text <> "*" Then
            QRY_Grid = QRY_Grid & "And Clave_Usr = '" & CB_Sup.SelectedValue.Trim & "' "
        End If
        If CB_Turno.Text <> "*" Then
            QRY_Grid = QRY_Grid & "And Turno = " & CB_Turno.SelectedValue & " "
        End If

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGV_Rol.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGV_Rol.Columns(0).HeaderText = "Usuario"
        DGV_Rol.Columns(1).HeaderText = "Fecha"
        DGV_Rol.Columns(2).HeaderText = "Turno"
        DGV_Rol.Columns(3).Visible = False  'Mes'

    End Sub

    Private Sub DGV_Rol_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Rol.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV_Rol.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGV_Rol.CurrentCell.RowIndex
                C_Sup = DGV_Rol.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                C_Fecha = DGV_Rol.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                C_Turno = DGV_Rol.Rows(Fila_Seleccionada).Cells(2).Value.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub FrmSupervision_Rol_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCBSuper()
        FillCBTurno()
        CB_Sup.Text = "*"
        CB_Turno.Text = "*"
        Grid_Load()
    End Sub

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        Grid_Load()
    End Sub

    Private Sub tsbAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAlta.Click
        FrmSupervision_Rol_Ins_AMEX.ShowDialog()
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Message = "El código quedara eliminado definitivamente, esta seguro de querer eliminarlo"
        Caption = "Eliminar Código de Producto"
        Result = MessageBox.Show(Message, Caption, Buttons)
        If Result = System.Windows.Forms.DialogResult.Yes Then

            QRY = ""
            NameTable = ""
            NameTable = "BorrarProducto"
            QRY = "Delete " & SessionUser._sCentro.Trim & "_Rol_Supervisor "
            QRY = QRY & "WHERE Clave_Usr = '" & C_Sup.Trim & "' "
            QRY = QRY & "And Fecha = '" & C_Fecha.Trim & "' "
            QRY = QRY & "And Turno = '" & C_Turno & "' "
            LecturaQry(QRY)

            InQry = " UPDATE " & SessionUser._sCentro.Trim & "_PesoProductoTerminado SET Sup_Turno = 'Supervisor' "
            InQry = InQry & "WHERE Planta = '" & SessionUser._sCentro.Trim & "' "
            InQry = InQry & "AND Fecha_Pesaje = '" & C_Fecha.Trim & "' "
            InQry = InQry & "AND Turno = '" & C_Turno & "' "
            InsertQry(InQry)

            Grid_Load()

        Else
        If Result = System.Windows.Forms.DialogResult.No Then
            Return
        End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        CB_Sup.Text = "*"
        CB_Turno.Text = "*"
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Close()
    End Sub
End Class