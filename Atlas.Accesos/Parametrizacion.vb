Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Imports System.Windows.Forms

Public Class Parametrizacion
    Public Shared Sub Parametrized_Form(ByVal frmForm As Form)
        Dim N_form As String = ""
        N_form = frmForm.Name

        Select Case Seccion
            Case Is = "E"
                P_SP = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias, N_form, "SOBREPESO")
                P_OP = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "OPERADOR_PT")
                P_CD = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "CAUSADFECTO")
                P_CC1 = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "COMPUESTO1")
                P_CC2 = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "COMPUESTO2")
                P_NM = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "NOT_MANUAL")
                P_MB = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "MULTIBASCULA")
                P_VU = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "VALIDA_USR")
                P_FV = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "FOLIOVALE")
                P_TPA = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "TIEMPOS_PROD")
                P_PS = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "PRODUCCIONSEPARADA")
                P_PR = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "PRODUCCIONENPROCESO")
                P_AT = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "ALERTATARA0")
                P_CS = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "CALENDARIOSAP")
                P_MP = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "MONITORPRODUCCION")
                P_EP = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "EXCEDENTEPRODUCCION")
            Case Is = "I"
                P_OP = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "OPERADOR_PT")
                P_VU = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "VALIDA_USR")

            Case Is = "R"
                P_CC = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, N_form, "CONSUME_COMP")

            Case Else

        End Select
    End Sub

    Public Shared Sub ParametrizedFormTiempos(ByVal frmForm As Form)
        Dim N_form As String = ""
        N_form = frmForm.Name

        'P_CT = Parametrizar_Form.PTE(SessionUser._sCentro.Trim, SessionUser._sAlias, N_form, "CALCULATIEMPOS")
    End Sub
End Class
