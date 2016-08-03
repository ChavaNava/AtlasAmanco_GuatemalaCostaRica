Imports System.Windows.Forms
Imports SQL_DATA

Public Class InitializesFormExtrusion
    Public Shared Sub Dates(ByVal DT_Turno As DateTimePicker, DT_SAP As DateTimePicker, ByVal CB_SAP As CheckBox)
        DT_Turno.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_SAP.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_Turno.Enabled = True
        CB_SAP.Enabled = True
    End Sub

    Public Shared Sub Choose_Shift(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Turno '" & SessionUser._sCentro.Trim & "' "

        DB.Combo_ADM(Q)
        NDataSet1 = DB.DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Descripcion"
        CB.ValueMember = "Turno"
        CB.Text = ""
    End Sub

    Public Shared Sub Assign_Shift(ByVal CB As ComboBox, HoraPlanta As String)
        Dim Q As String
        Dim strTurno As String
        'Se realiza de esta forma para que lea la hora y fecha del pais donde se encuentre y no tener que cambiar algo para ajustar 
        'la diferencia de horas
        Q = ""
        Q = "PA_Asigna_Turno '" & SessionUser._sCentro.Trim & "', '" & HoraPlanta.Trim & "' "
        DB.LecturaQry_ADM(Q)

        Do While (DB.LecturaBD_ADM.Read)
            strTurno = DB.LecturaBD_ADM(0)
            CB.Text = strTurno
        Loop
        DB.LecturaBD_ADM.Close()
    End Sub

End Class
