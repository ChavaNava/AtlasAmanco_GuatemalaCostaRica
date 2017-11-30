Imports Atlas.Accesos.CLVarGlobales
Imports Atlas.Accesos
Imports SQL_DATA
Public Class FormSobrePesoTf
    Dim Contador As Integer
    Dim Turno As String
    Dim HIni As String
    Dim HFin As String
    Dim Result As String
    Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
    Dim PuestoAdminSobrePeso As String

    Private Sub FormSobrePesoTf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutorizaSobrepeso = 0
        SuperAutoSobrepeso = ""
        LimpiaObjetos()
        TClaveAutoriza.Focus()
    End Sub

    Private Sub LimpiaObjetos()
        TtextoInfo.Text = ""
        TClaveAutoriza.Text = ""
    End Sub

    Private Sub BAutoCalSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAutoCalSi.Click

        If TClaveAutoriza.Text.Length > 0 Or Not TClaveAutoriza.Text = "" Then
            QRY_AMD = ""
            QRY_AMD = " SELECT Puesto FROM ADM_Usuario "
            QRY_AMD = QRY_AMD & " Where ADM_Usuario.Clave_Acceso = '" & Me.TClaveAutoriza.Text.Trim & "'"
            LecturaQry_AMD(QRY_AMD)

            If LecturaBD_AMD.Read() Then
                PuestoAdminSobrePeso = LecturaBD_AMD(0)
            End If
            LecturaBD_AMD.Close()
            ' ---------------------------------------------------------------------------------

            If (PuestoAdminSobrePeso >= 1 And PuestoAdminSobrePeso <= 3) Or PuestoAdminSobrePeso = 10 Then
                AutorizaSobrepeso = 1
                SuperAutoSobrepeso = TClaveAutoriza.Text.Trim
                ObserSobrepeso = TtextoInfo.Text.Trim
                Close()
            Else
                MessageBox.Show("Clave de Autorización Invalida ...", "Clave Invalida")
                Me.TClaveAutoriza.Text = ""
                Me.TClaveAutoriza.Focus()
            End If
        Else
            Mensajes("Clave de Autorización Invalida ...", 1)
            Me.TClaveAutoriza.Text = ""
            Me.TClaveAutoriza.Focus()
        End If
    End Sub

    Private Sub TClaveAutoriza_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TClaveAutoriza.Leave

        Select Case TClaveAutoriza.Text.Trim.Length
            Case Is = 0
                ''  Result = MessageBox.Show("Tecleé Clave de Autorización ", "Campo Vacio", Buttons)
                'MessageBox.Show("Tecleé Clave de Autorización ", "Campo Vacio")
                ''If Result = System.Windows.Forms.DialogResult.Yes Then
                'TClaveAutoriza.Text = ""
                'TClaveAutoriza.Focus()
                'Return
                'ElseIf Result = System.Windows.Forms.DialogResult.No Then
                'MenuPTETF.BPesar.Enabled = False
                'Close()
                'Exit Sub
                'End If
            Case Is > 0
                'QRY_AMD = "SELECT Puesto FROM ADM_Usuario Where ADM_Usuario.Clave_Acceso = '" & Me.TClaveAutoriza.Text.Trim & "'"
                'LecturaQry_AMD(QRY_AMD)

                'Do While (LecturaBD_AMD.Read)
                '    PuestoAdminSobrePeso = LecturaBD_AMD(0)
                'Loop

                'If (PuestoAdminSobrePeso >= 1 And PuestoAdminSobrePeso <= 3) Or PuestoAdminSobrePeso = 10 Then
                '    Me.BAutoCalSi.Enabled = True
                '    Me.BAutoCalNo.Enabled = True
                'Else
                '    'Result = MessageBox.Show("Clave de Autorización Invalida ", "Clave Invalida", Buttons)
                '    '
                '    '   If Result = System.Windows.Forms.DialogResult.Yes Then
                '    MessageBox.Show("Clave de Autorización Invalida ...", "Clave Invalida")
                '    Me.TClaveAutoriza.Text = ""
                '    Me.TClaveAutoriza.Focus()
                '    Return
                '    '   Else
                '    '      If Result = System.Windows.Forms.DialogResult.No Then
                '    '         MenuPTETF.BPesar.Enabled = False
                '    '         Close()
                '    '         Exit Sub
                '    '      End If
                '    '   End If
                'End If
        End Select
    End Sub

    Private Sub BAutoCalNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAutoCalNo.Click
        If TClaveAutoriza.Text.Length > 0 Or Not TClaveAutoriza.Text = "" Then
            QRY_AMD = ""
            QRY_AMD = " SELECT Puesto FROM ADM_Usuario "
            QRY_AMD = QRY_AMD & " Where ADM_Usuario.Clave_Acceso = '" & Me.TClaveAutoriza.Text.Trim & "'"
            LecturaQry_AMD(QRY_AMD)

            If LecturaBD_AMD.Read() Then
                PuestoAdminSobrePeso = LecturaBD_AMD(0)
            End If
            LecturaBD_AMD.Close()
            ' ---------------------------------------------------------------------------------

            If (PuestoAdminSobrePeso >= 1 And PuestoAdminSobrePeso <= 3) Or PuestoAdminSobrePeso = 10 Then
                AutorizaSobrepeso = 2
                SuperAutoSobrepeso = TClaveAutoriza.Text.Trim
                ObserSobrepeso = TtextoInfo.Text.Trim
                Close()
            Else
                MessageBox.Show("Clave de Autorización Invalida ...", "Clave Invalida")
                Me.TClaveAutoriza.Text = ""
                Me.TClaveAutoriza.Focus()
            End If
        Else
            Mensajes("Clave de Autorización Invalida ...", 1)
            Me.TClaveAutoriza.Text = ""
            Me.TClaveAutoriza.Focus()
        End If
    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        AutorizaSobrepeso = 9
        SuperAutoSobrepeso = ""
        ObserSobrepeso = ""
        Close()
    End Sub
End Class