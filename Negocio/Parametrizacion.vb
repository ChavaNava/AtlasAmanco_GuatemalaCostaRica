Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class Parametrizacion
    Public Shared Sub Parametrized_Form(ByVal frmForm As Form)
        Dim N_form As String = ""
        N_form = frmForm.Name
        If Seccion = "E" Then
            P_SP = Parametrizar_Form.PTE(strPlanta.Trim, StrUsr.Trim, N_form, "SOBREPESO")
            P_OP = Parametrizar_Form.PTE(strPlanta.Trim, StrUsr.Trim, N_form, "OPERADOR_PT")
            P_CD = Parametrizar_Form.PTE(strPlanta.Trim, StrUsr.Trim, N_form, "CAUSADFECTO")
            P_CC1 = Parametrizar_Form.PTE(strPlanta.Trim, StrUsr.Trim, N_form, "COMPUESTO1")
            P_CC2 = Parametrizar_Form.PTE(strPlanta.Trim, StrUsr.Trim, N_form, "COMPUESTO2")
            P_NM = Parametrizar_Form.PTE(strPlanta.Trim, StrUsr.Trim, N_form, "NOT_MANUAL")
            P_MB = Parametrizar_Form.PTE(strPlanta.Trim, StrUsr.Trim, N_form, "MULTIBASCULA")
            P_VU = Parametrizar_Form.PTE(strPlanta.Trim, StrUsr.Trim, N_form, "VALIDA_USR")
        End If
    
        If Seccion = "I" Then
            P_OP = Parametrizar_Form.PTE(strPlanta.Trim, StrUsr.Trim, N_form, "OPERADOR_PT")
            P_VU = Parametrizar_Form.PTE(strPlanta.Trim, StrUsr.Trim, N_form, "VALIDA_USR")

        End If
    End Sub
End Class
