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
        BAutoCalSi.Enabled = False
        BAutoCalNo.Enabled = False
        TClaveAutoriza.Focus()
    End Sub

    Private Sub LimpiaObjetos()
        TtextoInfo.Text = "" 'Descripción del Motivo de Sobrepeso
        TClaveAutoriza.Text = "" 'Clave de Autorización
    End Sub

    Private Sub BAutoCalSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAutoCalSi.Click
        AutorizaSobrepeso = 1
        ObserSobrepeso = TtextoInfo.Text.Trim
        Close()
    End Sub

    Private Sub TClaveAutoriza_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TClaveAutoriza.Leave

        Select Case TClaveAutoriza.Text.Trim.Length
            Case Is = 0
                MessageBox.Show("Tecleé Clave de Autorización ", "Campo Vacio")
                TClaveAutoriza.Text = ""
                TClaveAutoriza.Focus()
                Return
                'ElseIf Result = System.Windows.Forms.DialogResult.No Then
                'MenuPTETF.BPesar.Enabled = False
                'Close()
                'Exit Sub
                'End If
            Case Is > 0
                QRY_AMD = "SELECT Puesto,Nombre FROM ADM_Usuario Where ADM_Usuario.Clave_Acceso = '" & Me.TClaveAutoriza.Text.Trim & "'"
                LecturaQry_AMD(QRY_AMD)

                Do While (LecturaBD_AMD.Read)
                    PuestoAdminSobrePeso = LecturaBD_AMD(0)
                    SuperAutoSobrepeso = LecturaBD_AMD(1)
                Loop

                If (PuestoAdminSobrePeso >= 1 And PuestoAdminSobrePeso <= 5) Or PuestoAdminSobrePeso = 10 Then
                    Me.BAutoCalSi.Enabled = True
                    Me.BAutoCalNo.Enabled = True
                Else
                    'Result = MessageBox.Show("Clave de Autorización Invalida ", "Clave Invalida", Buttons)
                    '
                    '   If Result = System.Windows.Forms.DialogResult.Yes Then
                    MessageBox.Show("Clave de Autorización Invalida ...", "Clave Invalida")
                    Me.TClaveAutoriza.Text = ""
                    Me.TClaveAutoriza.Focus()
                    Return
                    '   Else
                    '      If Result = System.Windows.Forms.DialogResult.No Then
                    '         MenuPTETF.BPesar.Enabled = False
                    '         Close()
                    '         Exit Sub
                    '      End If
                    '   End If
                End If
        End Select
    End Sub

    Private Sub BAutoCalNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAutoCalNo.Click
        AutorizaSobrepeso = 2
        SuperAutoSobrepeso = TClaveAutoriza.Text.Trim
        ObserSobrepeso = TtextoInfo.Text.Trim
        Close()
    End Sub

    Private Sub TClaveAutoriza_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TClaveAutoriza.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class