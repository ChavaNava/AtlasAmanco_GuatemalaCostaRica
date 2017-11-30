Imports Utili_Generales
Public Class FrmMaster
    Public Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        Close()
    End Sub

    Public Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click

    End Sub

    Public Sub Btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nuevo.Click

    End Sub

    Public Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click

    End Sub

    Public Sub Btn_Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifica.Click

    End Sub

    Public Sub Btn_Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Elimina.Click

    End Sub

    Public Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click

    End Sub

    Public Sub Btn_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Export.Click

    End Sub

    Public Sub Master_Cat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Btn_Guardar.Enabled = False
        Btn_Elimina.Enabled = False

        FrontUtils.BloquearText(Me)
        FrontUtils.BloqueaButton(Me)
        FrontUtils.BloqueaCheckBox(Me)
        PBActualiza.Visible = False
    End Sub

    Public Sub BGW1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW1.DoWork

    End Sub

    Public Sub BGW1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BGW1.ProgressChanged

    End Sub

    Public Sub BGW1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW1.RunWorkerCompleted

    End Sub

End Class