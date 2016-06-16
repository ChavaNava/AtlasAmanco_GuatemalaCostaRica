Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Public Class IMP_Reporte
    Public Shared Sub Imprimir(ByVal Reporte As ReportClass, DS As DataSet, Titulo As String, Datos As SummaryInfo, Centro As String, _
                               Status As String, Formato As String)
        Dim REP As New FREP
        Datos = Reporte.SummaryInfo
        Datos.ReportTitle = Titulo
        Reporte.SetDataSource(DS)
        If Formato = "BPE" Or Formato = "BSCE" Then
            If Centro = "CR01" Then
                Parametros_Boleta_Pesaje_CR01(Reporte, Centro.Trim, Status)
            Else
                Parametros_Boleta_Pesaje(Reporte, Centro.Trim, Status)
            End If
        End If
        If Centro = "CR01" Then
            If Formato <> "BPE" Or Formato <> "BSCE" Then
                'Reporte.SetParameterValue("@LogoEmpresa", AppDomain.CurrentDomain.BaseDirectory.ToString() + "Resources\Mexichem.png")
                Reporte.SetParameterValue("@LogoEmpresa", "C:\App Settings\Reportes\Mexichem.png")
            End If
        Else
            'Reporte.SetParameterValue("@LogoEmpresa", AppDomain.CurrentDomain.BaseDirectory.ToString() + "Resources\Mexichem.png")
            Reporte.SetParameterValue("@LogoEmpresa", "C:\App Settings\Reportes\Mexichem.png")
        End If

        REP.CRV1.ReportSource = Reporte
        REP.Show()
    End Sub

    Public Shared Sub Parametros_Boleta_Pesaje(ByVal Reporte As ReportClass, Centro As String, St As String)
        Dim RpDatos As New CrystalDecisions.Shared.ParameterValues()
        Dim Firma1 As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim Firma2 As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim Firma3 As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim TxtISO As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim St_Documento As New CrystalDecisions.Shared.ParameterDiscreteValue()


        ' Asignar valores a los parametros
        If Centro.Trim = "A022" Then
            Firma1.Value = "SUPERVISOR DE PRODUCCION"
        Else
            Firma1.Value = "ASEGURAMIENTO DE CALIDAD"
        End If
        Firma2.Value = "ENTREGA"
        Firma3.Value = "RECIBE"
        TxtISO.Value = "FQX-101"
        If St.Trim = "9" Then
            St_Documento.Value = "CANCELADO"
        Else
            St_Documento.Value = " "
        End If

        'Enviar los parametros con datos al reporte
        RpDatos.Add(Firma1)
        Reporte.DataDefinition.ParameterFields("@Firma_1").ApplyCurrentValues(RpDatos)
        RpDatos.Clear()
        RpDatos.Add(Firma2)
        Reporte.DataDefinition.ParameterFields("@Firma_2").ApplyCurrentValues(RpDatos)
        RpDatos.Clear()
        RpDatos.Add(Firma3)
        Reporte.DataDefinition.ParameterFields("@Firma_3").ApplyCurrentValues(RpDatos)
        RpDatos.Clear()
        RpDatos.Add(TxtISO)
        Reporte.DataDefinition.ParameterFields("@Leyenda_ISO").ApplyCurrentValues(RpDatos)
        RpDatos.Clear()
        RpDatos.Add(St_Documento)
        Reporte.DataDefinition.ParameterFields("@Status").ApplyCurrentValues(RpDatos)
        RpDatos.Clear()
    End Sub

    Public Shared Sub Parametros_Boleta_Pesaje_CR01(ByVal Reporte As ReportClass, Centro As String, St As String)
        Dim RpDatos As New CrystalDecisions.Shared.ParameterValues()
        Dim St_Documento As New CrystalDecisions.Shared.ParameterDiscreteValue()

        If St.Trim = "9" Then
            St_Documento.Value = "CANCELADO"
        Else
            St_Documento.Value = " "
        End If
        'Enviar los parametros con datos al reporte
        RpDatos.Add(St_Documento)
        Reporte.DataDefinition.ParameterFields("@Status").ApplyCurrentValues(RpDatos)
        RpDatos.Clear()
    End Sub
End Class
