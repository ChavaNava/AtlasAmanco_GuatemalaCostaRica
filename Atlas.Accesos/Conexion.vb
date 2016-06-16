Imports System
Imports System.IO.Ports
Imports System.Threading
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Configuration

Imports System.Drawing

Public Class Conexion
    Public Shared Sub SAP_Status(ByVal Modulo As String, ByVal TSS As ToolStripStatusLabel)
        'StatusSap = SAP_Conexion.SAP_Status(SessionUser._sAlias.Trim, strPlanta.Trim, Modulo)
        Select Case CLVarGlobales.StatusSap
            Case "True"
                TSS.Image = Global.Atlas.Accesos.My.Resources.btn_SAPOk
                TSS.Text = "En comunicación con SAP"
                TSS.ForeColor = Color.Blue
            Case "False"
                TSS.Image = Global.Atlas.Accesos.My.Resources.btn_SAPFail
                TSS.Text = "No hay comunicación con SAP"
                TSS.ForeColor = Color.Red
        End Select
    End Sub
End Class
