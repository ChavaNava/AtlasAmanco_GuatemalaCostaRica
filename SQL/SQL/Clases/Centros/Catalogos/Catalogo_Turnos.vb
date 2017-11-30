Public Class Catalogo_Turnos
    Shared Sub Combo_Turnos(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Turno '" & SessionUser._sCentro.Trim & "' "
        Combo_ADM(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Descripcion"
        CB.ValueMember = "Turno"
    End Sub

    Public Shared Sub Asigna_turno(ByVal CB As ComboBox, HoraPlanta As String)
        Dim Q As String
        Dim strTurno As String
        'Se realiza de esta forma para que lea la hora y fecha del pais donde se encuentre y no tener que cambiar algo para ajustar 
        'la diferencia de horas
        Q = ""
        Q = "PA_Asigna_Turno '" & SessionUser._sCentro.Trim & "', '" & HoraPlanta.Trim & "' "
        LecturaQry_ADM(Q, SessionUser._sAlias)

        Do While (LecturaBD_ADM.Read)
            strTurno = LecturaBD_ADM(0)
            CB.Text = strTurno
        Loop
        LecturaBD_ADM.Close()
    End Sub

    Public Shared Function Turno(ByVal HoraPlanta As String) As String
        Dim Q As String
        'Se realiza de esta forma para que lea la hora y fecha del pais donde se encuentre y no tener que cambiar algo para ajustar 
        'la diferencia de horas
        Q = ""
        Q = "PA_Asigna_Turno '" & SessionUser._sCentro.Trim & "', '" & HoraPlanta.Trim & "' "
        LecturaQry_ADM(Q, SessionUser._sAlias)

        Do While (LecturaBD_ADM.Read)
            Turno = LecturaBD_ADM(0)
        Loop
        LecturaBD_ADM.Close()
    End Function


End Class
