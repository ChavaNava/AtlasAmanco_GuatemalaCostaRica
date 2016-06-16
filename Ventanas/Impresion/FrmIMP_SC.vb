Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmIMP_SC
    Dim FIP As String   'Fecha de inicio pesaje
    Dim FFP As String   'Fecha de fin pesaje
    Dim HI As String    'Hora de inicio pesaje
    Dim HF As String    'Hora de fin pesaje

    Sub FillCBTurno()
        Dim NDataSet1 As New DataSet
        QryCombo = ""
        QryCombo = "select * from ADM_Turno Where Planta = '" & SessionUser._sCentro.Trim & "' And Registro = '0' "
        Combo_AMD(QryCombo)
        NDataSet1 = DataSetCombo.Copy
        CB_Turno.DataSource = NDataSet1.Tables(0)
        CB_Turno.DisplayMember = "Descripcion"
        CB_Turno.ValueMember = "Turno"
    End Sub

    Private Sub BImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImp.Click
        FIP = DTP_FI.Value.ToString("yyyy-MM-dd")
        FFP = DTP_FF.Value.ToString("yyyy-MM-dd")
        HI = THI.Text.Trim
        HF = THF.Text.Trim

        If CB_Turno.Text = "*" Then
            CB_Turno.Text = ""
        End If

        If TOrden.Text.Trim = "*" Then
            TOrden.Text = ""
        End If

        QRY = ""
        QRY = "PA_Reportes_Scrap_1 '" & FIP.Trim & "', '" & FFP.Trim & "', '" & HI.Trim & "', '" & HF.Trim & "'," & SessionUser._sCentro.Trim & "_OrdenProduccion," & SessionUser._sCentro.Trim & "_PesoScrap, '" & CB_Turno.Text & "', '" & Seccion & "', '" & TOrden.Text.Trim & "', '1'"

        LecturaQry(QRY)

        Try
            objDa = New SqlDataAdapter(QRY, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)

            'objDs.WriteXmlSchema("c:\atlas\SCE_AMEX.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
        End Try
        If RB1.Checked Then
            If EXTINY = "1" Then
                'Poblar el informe con el dataSet y mostrarlo
                Dim info As New rptSCOrdEntXProd_AMEX
                Dim Fechas As SummaryInfo
                Fechas = info.SummaryInfo
                Fechas.ReportTitle = "REPORTE DE SCRAP EXTRUSIÓN" & vbCr & "del " + FIP.Trim + "  al  " + FFP.Trim
                info.SetDataSource(objDs)
                FREP.CRV1.ReportSource = info
                FREP.Show()
            Else
                'Poblar el informe con el dataSet y mostrarlo
                Dim info As New rptSCIOrdEntXProd_AMEX
                Dim Fechas As SummaryInfo
                Fechas = info.SummaryInfo
                Fechas.ReportTitle = "REPORTE DE SCRAP INYECCIÓN" & vbCr & "del " + FIP.Trim + "  al  " + FFP.Trim
                info.SetDataSource(objDs)
                FREP.CRV1.ReportSource = info
                FREP.Show()
            End If
        End If

        If RB2.Checked Then
            If EXTINY = "1" Then
                'Poblar el informe con el dataSet y mostrarlo
                Dim info As New rptSCOrdEntXODF_AMEX
                Dim Fechas As SummaryInfo
                Fechas = info.SummaryInfo
                Fechas.ReportTitle = "REPORTE DE SCRAP EXTRUSIÓN" & vbCr & "del " + FIP.Trim + "  al  " + FFP.Trim
                info.SetDataSource(objDs)
                FREP.CRV1.ReportSource = info
                FREP.Show()
            Else
                'Poblar el informe con el dataSet y mostrarlo
                Dim info As New rptSCIOrdEntXODF_AMEX
                Dim Fechas As SummaryInfo
                Fechas = info.SummaryInfo
                Fechas.ReportTitle = "REPORTE DE SCRAP INYECCIÓN" & vbCr & "del " + FIP.Trim + "  al  " + FFP.Trim
                info.SetDataSource(objDs)
                FREP.CRV1.ReportSource = info
                FREP.Show()
            End If
        End If

        If RB3.Checked Then
            If EXTINY = "1" Then
                'Poblar el informe con el dataSet y mostrarlo
                Dim info As New rptSC_GM_AMEX
                Dim Fechas As SummaryInfo
                Fechas = info.SummaryInfo
                Fechas.ReportTitle = "REPORTE DE SCRAP EXTRUSIÓN" & vbCr & "del " + FIP.Trim + "  al  " + FFP.Trim
                info.SetDataSource(objDs)
                FREP.CRV1.ReportSource = info
                FREP.Show()
            Else
                'Poblar el informe con el dataSet y mostrarlo
                Dim info As New rptSC_GM_AMEX
                Dim Fechas As SummaryInfo
                Fechas = info.SummaryInfo
                Fechas.ReportTitle = "REPORTE DE SCRAP INYECCIÓN" & vbCr & "del " + FIP.Trim + "  al  " + FFP.Trim
                info.SetDataSource(objDs)
                FREP.CRV1.ReportSource = info
                FREP.Show()
            End If
        End If

    End Sub

    Private Sub FrmPET_AMEX_IMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCBTurno()
        Me.Icon = Util.ApplicationIcon()
        CB_Turno.Text = "*"
        DTP_FI.Value = Now.Date.ToString("yyyy-MM-dd")
        DTP_FF.Value = Now.Date.ToString("yyyy-MM-dd")
        THI.Text = "00:00:01"
        THF.Text = "23:59:59"
        BImp.Enabled = True
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Close()
    End Sub

    Private Sub FrmPET_AMEX_IMP_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Modulo = ""
        CB_Turno.Text = "*"
    End Sub

End Class