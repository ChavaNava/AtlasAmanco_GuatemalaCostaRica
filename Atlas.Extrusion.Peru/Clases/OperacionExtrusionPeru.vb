Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Imports System.Drawing

Public Class OperacionExtrusionPeru
    Shared Sub Combo_Turnos(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Turno '" & SessionUser._sCentro.Trim & "' "
        Cnn.Combo_ADM(Q)
        NDataSet1 = Cnn.DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Descripcion"
        CB.ValueMember = "Turno"
        CB.Text = ""
    End Sub

    Public Shared Sub Fecha_Turno(ByVal DT_Turno As DateTimePicker, DT_SAP As DateTimePicker, ByVal CB_SAP As CheckBox)
        DT_Turno.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_SAP.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_Turno.Enabled = True
        CB_SAP.Enabled = True
    End Sub

    Public Shared Sub SAP_Status(ByVal Modulo As String, ByVal TSS As ToolStripStatusLabel)
        StatusSap = SAP_Conexion.Estatus(Modulo)
        Select Case StatusSap
            Case "True"
                TSS.Image = Global.Atlas.ExtrusionPeru.My.Resources.btn_SAPOk
                TSS.Text = "En comunicación con SAP"
                TSS.ForeColor = Color.Blue
            Case "False"
                TSS.Image = Global.Atlas.ExtrusionPeru.My.Resources.btn_SAPFail
                TSS.Text = "No hay comunicación con SAP"
                TSS.ForeColor = Color.Red
        End Select
    End Sub
    Public Shared Sub Cerrar(Modulo As String, Accion As String)
        If SessionUser._sCentro <> Nothing Then
            Log.Alta(SessionUser._sCentro, SessionUser._sAlias, SessionUser._sCadena, SessionUser._sPassword, Modulo, Accion)
        End If
    End Sub
    Public Shared Sub Inicializa_Frm_PTEI(ByVal DT_Turno As DateTimePicker, DT_SAP As DateTimePicker, ByVal CB_SAP As CheckBox)
        DT_Turno.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_SAP.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_Turno.Enabled = True
        CB_SAP.Enabled = True
    End Sub
End Class
