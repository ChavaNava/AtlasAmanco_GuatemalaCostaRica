Imports System.Data.SqlClient
Imports Utili_Generales
Public Class Prod_Piso
    Public Shared Function Valida_Usr(ByVal Usuario As String, Centro As String, Pass_Usr As String)
        Dim Q As String
        Dim Sta_Usr As Boolean
        Dim Cve_Usr As String = ""
        Dim Nom_Usr As String = ""

        Q = ""
        Q = "PA_Valida_Controlador '" & Centro & "', '" & Pass_Usr.Trim & "' "

        LecturaQry_ADM(Q)
        If LecturaBD_ADM.Read Then
            Sta_Usr = LecturaBD_ADM(0)
            Nom_Usr = LecturaBD_ADM(1)
            Cve_Usr = LecturaBD_ADM(2)
        End If
        LecturaBD_ADM.Close()
        Return Sta_Usr & "|" & Nom_Usr & "|" & Cve_Usr
    End Function

    Public Shared Sub Read_Order(ByVal Usuario As String, Orden As String, Centro As String, T_CodProd As TextBox, T_DesProd As TextBox, _
                                 T_CodMaq As TextBox, T_DesMaq As TextBox)
        Dim Q As String
        Q = ""
        Q = "PA_Read_Production_Order '" & Orden.Trim & "', '" & Centro.Trim & "' "

        LecturaQry(Q, Usuario)
        If LecturaBD.Read Then
            T_DesProd.Text = LecturaBD(1)
            T_CodProd.Text = LecturaBD(4)
            T_CodMaq.Text = LecturaBD(6)
            T_DesMaq.Text = LecturaBD(16)
        Else
            MensajeBox.Mostrar("Orden de Producción no existe en A-tlas se procede a darla de alta ", "Aviso", MensajeBox.TipoMensaje.Information)
            'Inserta_Nueva_Orden_Produccion(Orden, "T", frmForm, CodOper, EXTINY)
        End If
        LecturaBD_ADM.Close()

    End Sub
End Class
