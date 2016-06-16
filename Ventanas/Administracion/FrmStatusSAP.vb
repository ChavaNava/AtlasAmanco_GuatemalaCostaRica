Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmStatusSAP
    Dim UsrLog As String  'el usuario actual logeado en el sistema
    Dim strclave As String 'la contraseña del usuario
    Dim strNumeroPlanta As String
    Dim StrStatus As Boolean

    Dim Message As String
    Dim Caption As String
    Dim Result As DialogResult
    Dim Botones As MessageBoxButtons = MessageBoxButtons.YesNo

    Dim Pass_md5 As String


    Private Sub FrmStatusSAP_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        limpiarCampos()
        TxtClaveE.Focus()
    End Sub
    Sub limpiarCampos()
        '--Modulo Extrusión
        TxtClaveE.Text = ""
        TxtUsrE.Text = ""
        TxtPlantaE.Text = ""
        TxtOpeE.Text = ""
        TxtStDescE.Text = ""
        CBStatusE.Text = ""
        CBStatusE.Enabled = False
        BtnActE.Enabled = False
        BtnCancE.Enabled = True
    End Sub

    Private Sub TxtClaveE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClaveE.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtClaveE_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClaveE.Leave
        'comienza
        Dim myDataReader As Data.SqlClient.SqlDataReader
        Dim Q As String
        Dim contador As Integer
        Dim habilitado As Boolean
        Dim IntPuesto As Integer

        AbrirConfiguracion()

        If (Me.BtnActE.Enabled = False) Then
            Try
                If objCnn.State <> ConnectionState.Open Then
                    objCnn.Open()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            objCmd = New SqlCommand
            objCmd.CommandType = CommandType.Text
            objCmd.Connection = objCnn
            'Una vez abierta la base se ejecuta el query necesario para poder trabajar
            Q = "SELECT ADM_Usuario.Deshabilitado,ADM_Usuario.Usuario, ADM_Usuario.Planta, ADM_Usuario.Turno, "
            Q = Q & "ADM_Usuario.Puesto, ADM_Usuario.Clave_Acceso, ADM_Usuario.Nombre, ADM_Planta.Descripcion, "
            Q = Q & "ADM_StatusSAP.Planta, ADM_StatusSAP.Status FROM ADM_Usuario, ADM_Planta, ADM_StatusSAP "
            Q = Q & "Where ADM_Usuario.Planta = ADM_Planta.Planta "
            Q = Q & "and ADM_Usuario.Planta = ADM_StatusSAP.Planta "
            Q = Q & "And ADM_StatusSAP.Modulo = '" & Seccion.Trim & "' "
            Q = Q & "And ADM_StatusSAP.Planta = '" & SessionUser._sCentro.Trim & "' "
            Q = Q & " AND ADM_Usuario.Clave_Acceso = '" & TxtClaveE.Text.Trim() & "'"
            objCmd.CommandText = Q
            Try
                myDataReader = objCmd.ExecuteReader()
            Catch ex1 As Exception
                'myDataReader.Close()
                MsgBox(ex1.Message)
                Exit Sub
            End Try

            contador = 0

            Do While (myDataReader.Read())
                contador = contador + 1
                UsrLog = myDataReader("Usuario")
                strclave = myDataReader("Clave_Acceso")
                TxtPlantaE.Text = myDataReader("Descripcion")
                TxtOpeE.Text = myDataReader("Nombre")
                StrStatus = myDataReader("Status")
                strNumeroPlanta = myDataReader("Planta")
                IntPuesto = myDataReader("Puesto")
                If (myDataReader("Deshabilitado").ToString() = "False") Then
                    habilitado = True
                End If
                If Me.StrStatus = "False" Then
                    Me.TxtStDescE.Text = "Desactivado"
                ElseIf Me.StrStatus = "True" Then
                    Me.TxtStDescE.Text = "Activado"
                End If
                TxtUsrE.Text = UsrLog
            Loop
            myDataReader.Close()

            If habilitado = False Then
                MessageBox.Show("***    El Usuario está deshabilitado    *** ")
                Me.TxtClaveE.Text = ""
                Me.TxtClaveE.Focus()
                Exit Sub
            End If
            If IntPuesto = 25 Then
                MessageBox.Show("***    El Usuario de Calidad no debe ingresar a esta aplicación    *** ")
                Me.TxtClaveE.Text = ""
                Me.TxtClaveE.Focus()
                Exit Sub
            End If

            If contador = 0 Then
                MessageBox.Show("***    Verifique Clave de Acceso    *** ")
                Me.TxtClaveE.Text = ""
                Me.TxtClaveE.Focus()
            Else
                CBStatusE.Enabled = True
                BtnActE.Enabled = True
                BtnCancE.Enabled = True
                BtnActE.Focus()
            End If
        End If
        objCnn.Close()
    End Sub

    Private Sub BtnActE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActE.Click
        Dim StatusCnn As String

        StrStatus = SAP_Conexion.SAP_Status(Seccion.Trim)

        If CBStatusE.Text.Trim() = "" Then
            MessageBox.Show(" Elija un Status de Conexión ")
        Else
            'Cambiar el Status a Activo
            If CBStatusE.Text.Trim() = "Activado" Then
                StatusCnn = 1
                Message = "Desea Activar la Conexión a SAP"
                Caption = "Status de Conexión Desactivado"
                Result = MessageBox.Show(Message, Caption, Botones)
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    If StrStatus = True Then
                        MessageBox.Show(" La conexión esta Activa ")
                    ElseIf StrStatus = False Then
                        Try
                            SAP_Conexion.SAPConecct(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, Seccion, StatusCnn)
                            MessageBox.Show(" Se Actualizo Status de Conexión ")
                            BtnActE.Enabled = False
                            CBStatusE.Enabled = False
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Sub
                        End Try
                    End If
                    Me.TxtStDescE.Text = ""
                    Me.TxtStDescE.Text = "Activado"
                ElseIf Result = System.Windows.Forms.DialogResult.No Then
                    Return
                End If
                'Cambiar el Status a Desactivado
            ElseIf CBStatusE.Text.Trim() = "Desactivado" Then
                StatusCnn = 0
                Message = "Desactivar la Conexión a SAP provocara que no se registren notificaciones de A-tlas a SAP esta seguro"
                Caption = "Status de Conexión Activo"
                Result = MessageBox.Show(Message, Caption, Botones)
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    If StrStatus = False Then
                        MessageBox.Show(" La conexión esta Desactivada ")
                    ElseIf StrStatus = True Then
                        Try
                            SAP_Conexion.SAPConecct(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, Seccion, StatusCnn)
                            MessageBox.Show(" Se Actualizo Status de Conexión ")
                            BtnActE.Enabled = False
                            CBStatusE.Enabled = False
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Sub
                        End Try
                        Me.TxtStDescE.Text = ""
                        Me.TxtStDescE.Text = "Desactivado"
                    End If
                ElseIf Result = System.Windows.Forms.DialogResult.No Then
                    Return
                End If

            End If
        End If
    End Sub

    Private Sub FrmStatusSAPE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiarCampos()
        Me.Icon = Util.ApplicationIcon()
    End Sub

    Private Sub BtnCancE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancE.Click
        Close()
    End Sub
End Class