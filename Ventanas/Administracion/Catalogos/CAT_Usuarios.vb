Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Atlas.Accesos.CLVarGlobales
Imports Utili_Generales
Imports SQL_DATA
Public Class Cat_Usuarios
#Region "Variables de Miembro"
    'Varaibles de consulta
    Dim C_Status As Boolean
    Dim C_Perfil As String
    Dim D_Perfil As String
    'Variables para insert
    Dim I_Perfil As String
    'Alta Usuario
    Dim A_Usuario As String
    Dim A_Password As String
    Dim A_Nombre As String
    Dim A_Correo As String
    Dim A_TelFijo As String
    Dim A_TelCel As String
    Dim A_NumEmp As String
    Dim A_Habilitado As Integer
    Dim A_Area As String
    Dim A_Pass_md5 As String
    Dim A_md5 As String
    Dim A_ASC As String
#End Region

#Region "Eventos"
    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        Catalogo_Usuarios.Catalogo_Usuarios(DGV, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", Seccion.Trim)
    End Sub

    Private Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nuevo.Click
        Accion = "Alta"
        Btn_Guardar.Enabled = True
        ActivaText(Me)
        ActivaCheckBox(Me)
        ActivaButton(Me)
        ActivaCombo(Me)
        LimpiarText(Me)
        LimpiarCheckBox(Me)
        Btn_Consulta.Enabled = False
        Btn_Modifica.Enabled = False
        Btn_Elimina.Enabled = False
        Btn_Export.Enabled = False
        Btn_Nuevo.Enabled = False
        TEmail.Text = "E-mail"
        TTelFijo.Text = "Telefono Fijo"
        TTelMovil.Text = "Telefono Movil"
        TNumEmp.Text = "00000"
        CB_Status.Checked = True
        Catalogo_Perfiles.Combo_Perfiles(CB_Perfil, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim)
        TAlias.Focus()
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        If TAlias.Text.Trim = "" Or TPassword.Text.Trim = "" Then
            Mensajes("*** Los campos CODIGO Y DESCRIPCION deben tener valor *** ", 1)
            Exit Sub
        End If
        Try
            ' ---------------------------------------------------------------------------------
            If Accion = "Alta" Then
                QRY = ""
                QRY = QRY & "SELECT Usuario FROM ADM_Usuarios "
                QRY = QRY & "WHERE Centro ='" & SessionUser._sCentro.Trim & "' "
                QRY = QRY & "AND Usuario = '" & TAlias.Text.Trim & "' "
                LecturaQry_AMD(QRY)
                If LecturaBD_AMD.Read Then
                    Mensajes("***  Usuario ya existe *** ", 1)
                    LecturaBD_AMD.Close()
                    CB_Status.Checked = False
                    Exit Sub
                Else
                    I_Perfil = CB_Perfil.SelectedValue
                    CB_Status.Checked = True
                    A_Usuario = TAlias.Text.Trim
                    A_Password = TPassword.Text.Trim
                    A_Nombre = TNombre.Text.Trim
                    A_Correo = TEmail.Text.Trim
                    A_TelFijo = TTelFijo.Text.Trim
                    A_TelCel = TTelMovil.Text.Trim
                    A_NumEmp = TNumEmp.Text.Trim
                    A_Area = Seccion.Trim
                    A_Pass_md5 = Crypto.MD5Calculate(TPassword.Text.Trim)
                End If
                LecturaBD_AMD.Close()
                Btn_Guardar.Enabled = False
            Else
                If CB_Perfil.SelectedValue = Nothing Then
                    I_Perfil = C_Perfil.Trim
                Else
                    I_Perfil = CB_Perfil.SelectedValue.Trim
                End If
                A_Usuario = TAlias.Text.Trim
                A_Password = TPassword.Text.Trim
                A_Nombre = TNombre.Text.Trim
                A_Correo = TEmail.Text.Trim
                A_TelFijo = TTelFijo.Text.Trim
                A_TelCel = TTelMovil.Text.Trim
                A_NumEmp = TNumEmp.Text.Trim
                A_Habilitado = CB_Status.CheckState
                A_Pass_md5 = Crypto.MD5Calculate(TPassword.Text.Trim)
                Btn_Guardar.Enabled = False
            End If
            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        PBActualiza.Visible = True
        BGW1.WorkerReportsProgress = True
        BGW1.RunWorkerAsync()
    End Sub

    Private Sub Btn_Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifica.Click
        Accion = "Modifica"
        ActivaText(Me)
        ActivaButton(Me)
        ActivaCombo(Me)
        ActivaCheckBox(Me)
        'Catalogo_Perfiles.Combo_Perfiles(CB_Perfil, strPlanta.Trim, SessionUser._sAlias.Trim)
        Btn_Nuevo.Enabled = False
        Btn_Guardar.Enabled = True
        Btn_Elimina.Enabled = False
    End Sub

    Private Sub Btn_Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Elimina.Click
        abcSQL_ADM("PA_Baja_Usuarios '" & TAlias.Text.Trim & "','" & SessionUser._sCentro.Trim & "', '" & TPassword.Text.Trim & "', '" & SessionUser._sAlias & "'")
        Catalogo_Usuarios.Catalogo_Usuarios(DGV, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", Seccion.Trim)
        MessageBox.Show("Información Actualizada")
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        PBActualiza.Visible = False
        Btn_Guardar.Enabled = False
        Btn_Elimina.Enabled = True
        Btn_Nuevo.Enabled = True
        BloqueaText(Me)
        BloqueaCheckBox(Me)
        BloqueaButton(Me)
        LimpiarText(Me)
        BloqueaCombo(Me)
    End Sub

    Private Sub Btn_Export_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Export.Click
        Export_Excel(DGV)
    End Sub

    Private Sub Usuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Text = "Catalogo de Usuarios" + " " + "CENTRO : '" & SessionUser._sCentro.Trim & "'"
        PBActualiza.Visible = False
        Btn_Guardar.Enabled = False
        Btn_Elimina.Enabled = False
        BloqueaText(Me)
        BloqueaCheckBox(Me)
        BloqueaButton(Me)
        LimpiarText(Me)
        BloqueaCombo(Me)
        Catalogo_Usuarios.Catalogo_Usuarios(DGV, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", Seccion.Trim)
    End Sub

    Private Sub DGV_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DGV.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            Try
                Dim Fila_Seleccionada As Integer = DGV.CurrentCell.RowIndex
                TAlias.Text = DGV.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                A_md5 = DGV.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                TNombre.Text = DGV.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                TNumEmp.Text = DGV.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                C_Perfil = DGV.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                D_Perfil = DGV.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                TEmail.Text = DGV.Rows(Fila_Seleccionada).Cells(6).Value.ToString
                TTelFijo.Text = DGV.Rows(Fila_Seleccionada).Cells(7).Value.ToString
                TTelMovil.Text = DGV.Rows(Fila_Seleccionada).Cells(8).Value.ToString
                C_Status = DGV.Rows(Fila_Seleccionada).Cells(11).Value.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
            TPassword.Text = A_md5
            CB_Status.Checked = C_Status
            CB_Perfil.Text = D_Perfil
            Btn_Guardar.Enabled = False
            Btn_Elimina.Enabled = True
            BloqueaText(Me)
            BloqueaButton(Me)
            BloqueaCombo(Me)

        End If
    End Sub

    Private Sub DGV_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            C_Status = (DGV.Rows(e.RowIndex).Cells(11).Value)
            If C_Status = True Then
                e.CellStyle.BackColor = Color.LightGreen
                e.CellStyle.ForeColor = Color.Black
            ElseIf C_Status = False Then
                e.CellStyle.BackColor = Color.LightSalmon
                e.CellStyle.ForeColor = Color.Black
            End If
        End If
    End Sub

#End Region

#Region "Metodos"
    Private Sub BGW1_ProgressChanged(sender As System.Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BGW1.ProgressChanged
        PBActualiza.Value = e.ProgressPercentage
    End Sub

    Private Sub BGW1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW1.DoWork
        BGW1.ReportProgress(15)
        System.Threading.Thread.Sleep(2000) ' Para simular tiempo de espera
        BGW1.ReportProgress(30)
        Select Case Accion
            Case Is = "Alta"
                Try
                    BGW1.ReportProgress(50)
                    abcSQL_ADM("PA_Insert_Usuarios '" & A_Usuario.Trim & "','" & SessionUser._sCentro.Trim & "', '" & A_Pass_md5.Trim & "', '" & A_Nombre.Trim & "','" & A_Correo.Trim & "', '" & A_TelFijo.Trim & "','" & A_TelCel.Trim & "','ATLAS', '" & A_NumEmp.Trim & "','" & I_Perfil.Trim & "','" & SessionUser._sAlias.Trim & "', '" & Seccion.Trim & "','1'")
                    BGW1.ReportProgress(75)
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
            Case Is = "Modifica"
                Try
                    BGW1.ReportProgress(50)
                    abcSQL_ADM("PA_Update_Usuarios '" & A_Usuario.Trim & "','" & SessionUser._sCentro.Trim & "', '" & A_Pass_md5.Trim & "', '" & A_Nombre.Trim & "','" & A_Correo.Trim & "', '" & A_TelFijo.Trim & "','" & A_TelCel.Trim & "','" & A_NumEmp.Trim & "','" & I_Perfil.Trim & "','" & SessionUser._sAlias.Trim & "','" & A_Habilitado & "'")
                    BGW1.ReportProgress(75)
                    ' ---------------------------------------------------------------------------------
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
        End Select
        BGW1.ReportProgress(100)
    End Sub

    Private Sub BGW1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW1.RunWorkerCompleted
        Catalogo_Usuarios.Catalogo_Usuarios(DGV, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, "", Seccion.Trim)
        MessageBox.Show("Información Actualizada")
        PBActualiza.Visible = False
        BGW1.WorkerReportsProgress = False
        BloqueaText(Me)
        BloqueaButton(Me)
        BloqueaCheckBox(Me)
        BloqueaCombo(Me)
        Btn_Guardar.Enabled = False
        Btn_Nuevo.Enabled = True
        Btn_Elimina.Enabled = True
        Btn_Export.Enabled = True
        Btn_Consulta.Enabled = True
        PBActualiza.Value = 0
        PBActualiza.Visible = False
        Accion = ""
    End Sub
#End Region

#Region "Propiedades"

#End Region


End Class