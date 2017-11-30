Imports Reporting
Imports Utili_Generales
Imports SQL_DATA
Public Class ReportesProduccion
    Public Shared Sub CPG(ByVal Operacion As Integer)
        Dim rTitulo1 As String = "REPORTE CONSOLIDADO PRODUCCIÓN"
        Dim rLeyenda1 As String = "Mexichem Flúor, S.A. de C.V. Salitrera Villa de Zaragoza Domicilio Conocido Villa de Zaragoza, S.L.P."
        Dim RPT1 As New rptProduccionConsolidado
        IMP_Reporte.ImpReportes(RPT1, CPGDataSet(Operacion, rTitulo1, rLeyenda1))
    End Sub

    Public Shared Function CPGDataSet(ByVal Operacion As Integer, TxtTitulo As String, TxtLeyenda As String) As List(Of ConsolidatedPeriod)
        Dim listaInfos As New List(Of ConsolidatedPeriod)
        Dim Info As New ConsolidatedPeriod
        Dim ListDif As New List(Of ConsolidatedPeriod)
        Dim Q As String

        Q = ""
        Q = "PA_ReportesProduccionPeru '" & ConsultasProduccion._Centro.Trim & "' , '" & ConsultasProduccion._Area.Trim & "', '" & ConsultasProduccion._Seccion.Trim & "', '" & ConsultasProduccion._Turno.Trim & "', '" & ConsultasProduccion._FI.Trim & "', '" & ConsultasProduccion._FF.Trim & "', '" & ConsultasProduccion._PuestoTrabajo.Trim & "', '" & ConsultasProduccion._Orden.Trim & "', '" & ConsultasProduccion._Producto.Trim & "', '" & ConsultasProduccion._GrpDiametro.Trim & "', '" & ConsultasProduccion._AreaProductiva.Trim & "', " & Operacion & " "
        LecturaQry(Q)

        Do While (LecturaBD.Read)
            Dim EstDif As New ConsolidatedPeriod
            EstDif.Tipo = LecturaBD(0)
            EstDif.Unidades = LecturaBD(1)
            EstDif.KilosReales = LecturaBD(2)
            EstDif.KilosTeoricos = LecturaBD(3)
            EstDif.KilosScrap = LecturaBD(4)
            EstDif.KilosSprut = LecturaBD(5)
            EstDif.Total = LecturaBD(6)
            EstDif.HorasProgramadas = LecturaBD(7)
            EstDif.HorasReportadas = LecturaBD(8)
            EstDif.HorasParo = LecturaBD(8)
            EstDif.Centro = LecturaBD(8)
            EstDif.Logo = Util.ConvertImageFiletoBytes("C:\App Settings\Reportes\mexichem.png")
            ListDif.Add(EstDif)
        Loop
        LecturaBD.Close()

        Return ListDif

    End Function
End Class
