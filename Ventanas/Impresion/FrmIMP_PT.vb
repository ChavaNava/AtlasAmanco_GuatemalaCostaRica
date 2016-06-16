Imports SQL_DATA
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmIMP_PT
#Region "Variables Miembro"
    Dim FIP As String   'Fecha de inicio pesaje
    Dim FFP As String   'Fecha de fin pesaje
    Dim HI As String    'Hora de inicio pesaje
    Dim HF As String    'Hora de fin pesaje

    Dim Var_Secc As String
    Dim Var_Secc1 As String
#End Region

    Private Sub Btn_Imp_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Imp.Click
        Dim Status_Notif As String

        FIP = DTP_FI.Value.ToString("yyyy-MM-dd")
        FFP = DTP_FF.Value.ToString("yyyy-MM-dd")
        HI = THI.Text.Trim
        HF = THF.Text.Trim

        If CB_Sub.Checked Then
            Var_Secc = "in (''36'')"
            Var_Secc1 = "="
        Else
            Var_Secc = "<> ''36''"
            Var_Secc1 = "<>"
        End If

        If CB_Notif.Checked Then
            Status_Notif = "(0,4,3)"
        Else
            Status_Notif = "(0,4,3,1)"
        End If

        If RB1.Checked Then
            Reportes.Detalle_X_Prd_Ord(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, Seccion, CB_Turno.Text.Trim, FIP.Trim, FFP.Trim, HI, HF, "Prd", Var_Secc)
        End If

        If RB2.Checked Then
            Reportes.Detalle_X_Prd_Ord(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, Seccion, CB_Turno.Text.Trim, FIP.Trim, FFP.Trim, HI, HF, "Ord", Var_Secc)
        End If

        If RB3.Checked Then
            Reportes.Resumen_X_Prd_Ord(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, Status_Notif.Trim, Seccion.Trim, Var_Secc.Trim, CB_Turno.Text.Trim, FIP.Trim, FFP.Trim, HI, HF)
        End If

        If RB4.Checked Then
            Reportes.Consumo_Compuesto_X_Producto(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, CB_Turno.Text.Trim, FIP.Trim, FFP.Trim, HI, HF, TOrden.Text.Trim)
        End If

        If RB5.Checked Then
            Reportes.Consumo_Compuesto_X_Orden(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, CB_Turno.Text.Trim, FIP.Trim, FFP.Trim, HI, HF, TOrden.Text.Trim)
        End If

        If RB6.Checked Then
            Reportes.Detalle_X_Prd_Ord(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, Seccion, CB_Turno.Text.Trim, FIP.Trim, FFP.Trim, HI, HF, "D_Eqp", Var_Secc)
        End If

        If RB7.Checked Then
            Reportes.Resumen_X_Eqp(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, Status_Notif.Trim, Seccion.Trim, Var_Secc.Trim, CB_Turno.Text.Trim, FIP.Trim, FFP.Trim, HI, HF)
        End If

        If RB8.Checked Then
            Reportes.Reporte_Entrega(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TOrden.Text.Trim, Status_Notif.Trim, Seccion.Trim, Var_Secc.Trim, CB_Turno.Text.Trim, FIP.Trim, FFP.Trim, HI, HF)
        End If

    End Sub

    Private Sub IMP_PTEI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Catalogo_Turnos.Combo_Turnos(CB_Turno)
        CB_Turno.Text = ""
        Me.Icon = Util.ApplicationIcon()
    End Sub

    Private Sub Btn_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Cancel.Click
        Close()
    End Sub
End Class