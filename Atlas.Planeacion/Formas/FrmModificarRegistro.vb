Imports Utili_Generales
Public Class FrmModificarRegistro

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If rbCerrar.Checked = True Then
            Planeacion.ModificaOrden(7)
            CtrlVariablesGlobal._Estado = "1"
            Close()
        End If

        If rbReabrir.Checked = True Then
            Planeacion.ModificaOrden(8)
            CtrlVariablesGlobal._Estado = "1"
            Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        CtrlVariablesGlobal._Estado = "0"
        Close()
    End Sub
End Class