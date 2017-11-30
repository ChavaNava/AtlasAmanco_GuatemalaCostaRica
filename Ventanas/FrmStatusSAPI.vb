Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmStatusSAPI
    Dim UsrLog As String  'el usuario actual logeado en el sistema
    Dim strclave As String 'la contraseña del usuario
    Dim strNumeroPlanta As String
    Dim StrStatus As Boolean

    Dim Message As String
    Dim Caption As String
    Dim Result As DialogResult
    Dim Botones As MessageBoxButtons = MessageBoxButtons.YesNo

    Private Sub FrmStatusSAPI_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        limpiarCampos()
    End Sub
    Sub limpiarCampos()
        '--Modulo Inyección
        TxtClaveI.Text = ""
        TxtUsrI.Text = ""
        TxtPlantaI.Text = ""
        TxtOpeI.Text = ""
        TxtTurnoI.Text = ""
        TxtStDescI.Text = ""
        CBStatusI.Text = ""
        CBStatusI.Enabled = False
        BtnActI.Enabled = False
        BtnCancI.Enabled = True
    End Sub

    Private Sub TxtClaveI_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClaveI.Leave
        'comienza
        Dim myDataReader As Data.SqlClient.SqlDataReader
        Dim Q As String
        Dim contador As Integer
        Dim habilitado As Boolean
        Dim IntPuesto As Integer

        AbrirConfiguracion()

        If (Me.BtnActI.Enabled = False) Then
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
            Q = "SELECT ADM_Usuario.Deshabilitado,ADM_Usuario.Usuario, ADM_Usuario.Planta, ADM_Usuario.Turno, ADM_Usuario.Puesto, ADM_Usuario.Clave_Acceso, ADM_Usuario.Nombre, ADM_Planta.Descripcion, ADM_StatusSAP.Planta, ADM_StatusSAP.Status FROM ADM_Usuario, ADM_Planta, ADM_StatusSAP Where ADM_Usuario.Planta = ADM_Planta.Planta and ADM_Usuario.Planta = ADM_StatusSAP.Planta"
            Q = Q & " AND ADM_Usuario.Clave_Acceso = '" & Me.TxtClaveI.Text.Trim() & "' And ADM_StatusSAP.mODULO = 'I' "
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
                TxtPlantaI.Text = myDataReader("Descripcion")
                TxtOpeI.Text = myDataReader("Nombre")
                TxtTurnoI.Text = myDataReader("Turno")
                StrStatus = myDataReader("Status")
                strNumeroPlanta = myDataReader("Planta")
                IntPuesto = myDataReader("Puesto")
                If (myDataReader("Deshabilitado").ToString() = "False") Then
                    habilitado = True
                End If
                If Me.StrStatus = "False" Then
                    Me.TxtStDescI.Text = "Desactivado"
                ElseIf Me.StrStatus = "True" Then
                    Me.TxtStDescI.Text = "Activado"
                End If
                TxtUsrI.Text = UsrLog
            Loop
            myDataReader.Close()

            If habilitado = False Then
                MessageBox.Show("***    El Usuario está deshabilitado    *** ")
                Me.TxtClaveI.Text = ""
                Me.TxtClaveI.Focus()
                Exit Sub
            End If
            If IntPuesto = 25 Then
                MessageBox.Show("***    El Usuario de Calidad no debe ingresar a esta aplicación    *** ")
                Me.TxtClaveI.Text = ""
                Me.TxtClaveI.Focus()
                Exit Sub
            End If

            If contador = 0 Then
                MessageBox.Show("***    Verifique Clave de Acceso    *** ")
                Me.TxtClaveI.Text = ""
                Me.TxtClaveI.Focus()
            Else
                CBStatusI.Enabled = True
                BtnActI.Enabled = True
                BtnCancI.Enabled = True
                BtnActI.Focus()
            End If
        End If
        objCnn.Close()
    End Sub

    Private Sub TxtClaveI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClaveI.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub BtnActI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActI.Click
        Dim myDataReader As SqlClient.SqlDataReader
        Dim RegistrosActualizados As Integer
        Dim StatusCnn As String
        Dim Q As String
        Dim Q1 As String
        Dim Q2 As String

        If CBStatusI.Text.Trim() = "" Then
            MessageBox.Show(" Elija un Status de Conexión ")
        End If
        'Cambiar el Status a Activo
        If CBStatusI.Text.Trim() = "Activado" Then
            StatusCnn = 1
            Message = "Desea Activar la Conexión a SAP"
            Caption = "Status de Conexión Desactivado"
            Result = MessageBox.Show(Message, Caption, Botones)
            If Result = System.Windows.Forms.DialogResult.Yes Then

                Try
                    If objCnn.State <> ConnectionState.Open Then
                        objCnn.Open()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try

                objCmd.Connection = objCnn
                Q = "Select Planta, Status FROM ADM_StatusSAP WHERE Planta = '" & SessionUser._sCentro.Trim() & "' and Modulo = 'I' "
                objCmd.CommandText = Q
                Try
                    myDataReader = objCmd.ExecuteReader()
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
                Do While (myDataReader.Read())
                    StrStatus = myDataReader("Status")
                Loop
                myDataReader.Close()

                If StrStatus = True Then
                    MessageBox.Show(" La conexión esta Activa ")
                ElseIf StrStatus = False Then

                    Q1 = "Update ADM_StatusSAP set Status = '" & StatusCnn & "'"
                    Q1 = Q1 & " where Planta = '" & SessionUser._sCentro.Trim() & "' "
                    Q1 = Q1 & " And Modulo = 'I' "

                    objCmd.CommandText = Q1
                    Try
                        RegistrosActualizados = objCmd.ExecuteNonQuery()
                    Catch ex1 As Exception
                        MsgBox(ex1.Message)
                        Exit Sub
                    End Try
                    Me.TxtStDescI.Text = ""
                    Me.TxtStDescI.Text = "Activado"
                End If

                MessageBox.Show(" Se Actualizo Status de Conexión ")
                BtnActI.Enabled = False
                CBStatusI.Enabled = False

            ElseIf Result = System.Windows.Forms.DialogResult.No Then
                Return
            End If

        ElseIf CBStatusI.Text.Trim() = "Desactivado" Then
            StatusCnn = 0
            Message = "Desactivar la Conexión a SAP provocara que no se registren notificaciones de A-tlas a SAP esta seguro"
            Caption = "Status de Conexión Activo"
            Result = MessageBox.Show(Message, Caption, Botones)
            If Result = System.Windows.Forms.DialogResult.Yes Then

                Try
                    If objCnn.State <> ConnectionState.Open Then
                        objCnn.Open()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try

                objCmd.Connection = objCnn
                Q = "Select Planta, Status FROM ADM_StatusSAP WHERE Planta='" & SessionUser._sCentro.Trim() & "' and Modulo = 'I' "
                objCmd.CommandText = Q
                Try
                    myDataReader = objCmd.ExecuteReader()
                Catch ex1 As Exception
                    MsgBox(ex1.Message)
                    Exit Sub
                End Try
                Do While (myDataReader.Read())
                    StrStatus = myDataReader("Status")
                Loop
                myDataReader.Close()

                If StrStatus = False Then
                    MessageBox.Show(" La conexión esta Desactivada ")
                ElseIf StrStatus = True Then
                    Q2 = "Update ADM_StatusSAP set Status = '" & StatusCnn & "'"
                    Q2 = Q2 & " where Planta = '" & SessionUser._sCentro.Trim() & "' "
                    Q2 = Q2 & " And Modulo = 'I' "

                    objCmd.CommandText = Q2
                    Try
                        RegistrosActualizados = objCmd.ExecuteNonQuery()
                    Catch ex1 As Exception
                        MsgBox(ex1.Message)
                        Exit Sub
                    End Try
                    Me.TxtStDescI.Text = ""
                    Me.TxtStDescI.Text = "Desactivado"
                End If

                MessageBox.Show(" Se Actualizo Status de Conexión ")
                BtnActI.Enabled = False
                CBStatusI.Enabled = False

            ElseIf Result = System.Windows.Forms.DialogResult.No Then
                Return
            End If
        End If
    End Sub

    Private Sub FrmStatusSAPI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiarCampos()
        Me.Icon = Util.ApplicationIcon()
        TxtClaveI.Focus()
    End Sub

    Private Sub BtnCancI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancI.Click
        Close()
    End Sub
End Class