Imports Utili_Generales
Imports Utili_Generales.ValueText
Public Class FrmMonitorMasterConfig
#Region "Variables"

#End Region

#Region "Eventos"
    Private Sub FrmMonitorMasterConfig_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BtnGuardar.Enabled = False
        ReadData()
        FrontUtils.BloquearText_GroupBox(Me)
    End Sub

    Private Sub BtnEditar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditar.Click
        BtnGuardar.Enabled = True
        FrontUtils.ActivarText_GroupBox(Me)
    End Sub
    Private Sub TDM1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TDM1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Decimales(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TDT1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TDT1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Decimales(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Metodos"
    Private Sub ReadData()
        Indicadores.Read(1)
        FillSet()
    End Sub

    Private Sub FillSet()
        TDM1.Text = ReadIndicadores._DM1
        TDT1.Text = ReadIndicadores._DT1
        TDMe1.Text = ReadIndicadores._DMe1
        TSPM2.Text = ReadIndicadores._SPM2
        TRM3.Text = ReadIndicadores._RM3
        TRT3.Text = ReadIndicadores._RT3
        TRMe3.Text = ReadIndicadores._RMe3
        TPM4.Text = ReadIndicadores._TPM4
        TPR4.Text = ReadIndicadores._TPR4
    End Sub
#End Region

End Class