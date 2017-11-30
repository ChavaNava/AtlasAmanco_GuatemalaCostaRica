Imports SQL_DATA
Public Class Indicadores
    Public Shared Sub Read(ByVal Area As Integer)
        Dim FrmMonitor As New FrmMonitorMasterConfig
        Cnn.LecturaQry("PA_Indicadores '" & SessionUser._sIdCentro.Trim & "', '" & Area & "'")
        Do While (Cnn.LecturaBD.Read)
            ReadIndicadores.IdIndicador = Cnn.LecturaBD(1)
            Select Case ReadIndicadores._IdIndicador
                Case Is = 1
                    ReadIndicadores.DM1 = Cnn.LecturaBD(3)
                    ReadIndicadores.DT1 = Cnn.LecturaBD(4)
                    ReadIndicadores.DMe1 = Cnn.LecturaBD(5)
                Case Is = 2
                    ReadIndicadores.SPM2 = Cnn.LecturaBD(3)
                Case Is = 3
                    ReadIndicadores.RM3 = Cnn.LecturaBD(3)
                    ReadIndicadores.RT3 = Cnn.LecturaBD(4)
                    ReadIndicadores.RMe3 = Cnn.LecturaBD(5)
                Case Is = 4
                    ReadIndicadores.TPM4 = Cnn.LecturaBD(3)
                    ReadIndicadores.TPR4 = Cnn.LecturaBD(5)
            End Select
        Loop
    End Sub
End Class
