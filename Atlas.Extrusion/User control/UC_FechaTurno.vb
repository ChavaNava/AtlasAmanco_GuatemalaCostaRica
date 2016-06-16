Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales

Public Class UC_FechaTurno

    Private Sub UC_FechaTurno_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Inicializan fecha Turno y SAP
        Inicializa_Frm_PTEI(dtpFECHA, dtpFECHASAP, chkSAP)
    End Sub

    Public Sub Inicializa_Frm_PTEI(ByVal DT_Turno As DateTimePicker, DT_SAP As DateTimePicker, ByVal CB_SAP As CheckBox)
        DT_Turno.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_SAP.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_Turno.Enabled = True
        CB_SAP.Enabled = True
    End Sub

    Private Sub chkSAP_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSAP.CheckedChanged
        If chkSAP.Checked Then
            dtpFECHASAP.Enabled = False
        Else
            dtpFECHASAP.Enabled = True
        End If
    End Sub

    Public Sub Asigna_Turno()
        ' ---------------------------------------------------------------------------------
        'Se asigna turno que corresponde acorde al horario
        Dim HReal As String = DateTime.Now.ToString("HH:mm:ss")
        Catalogo_Turnos.Combo_Turnos(cmbTurnos, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim)
        Catalogo_Turnos.Asigna_turno(cmbTurnos, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, HReal)
    End Sub
End Class
