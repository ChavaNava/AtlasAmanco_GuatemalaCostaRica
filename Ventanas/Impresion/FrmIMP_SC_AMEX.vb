Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmIMP_SC_AMEX
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

        If CB_Turno.Text = "" Then
            MsgBox("Seleccione Turno")
            Return
        End If

        QRY = ""
        QRY = "Select a.Orden_Produccion,a.Planta,b.Fecha_Pesaje,b.Hora_Pesaje,b.Bascula,b.Tipo_Scrap,b.Peso_Bruto,"
        QRY = QRY & "replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.Documento_SAP,"
        QRY = QRY & "b.Consecutivo_SAP,b.Tara,b.Peso_Neto,b.Usuario,b.Turno,b.Notifica,b.Causa,b.Efecto,"
        QRY = QRY & "b.PuestoTrabajo,b.RepGenerado,c.Codigo,c.Descr,c.PesoTeorico,c.Empaque "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b, "
        If EXTINY = "1" Then
            QRY = QRY & "ProductoTerminadoExtrusion c "
        Else
            QRY = QRY & "ProductoTerminadoInyeccion c "
        End If
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion  "
        QRY = QRY & "And a.Planta = c.Centro "
        QRY = QRY & "And a.Producto = c.Codigo "
        QRY = QRY & "And b.Notifica = '1' "
        If CB_Turno.Text.Trim <> "*" Then
            QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
        End If
        QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
        LecturaQry(QRY)

        Try
            objDa = New SqlDataAdapter(QRY, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)

            'objDs.WriteXmlSchema("c:\atlas\SCE_AMEX.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
        End Try

        If CB_Prod.Checked = True Then          'Reporte Scrap Ordenado por Producto

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

        ElseIf CB_ODF.Checked = True Then       'Reporte Scrap Ordenado por Orden de Fabricacion

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

        ElseIf CB_SM.Checked = True Then        'Reporte Scrap Clasificado por Recuperado y Merma

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
        If Modulo = "SC" Then
            CB_SM.Checked = False
            CB_SM.Enabled = False
        Else
            CB_SM.Checked = False
            CB_SM.Enabled = True
        End If

        BImp.Enabled = False
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Close()
    End Sub

    Private Sub CB_Prod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Prod.CheckedChanged
        If CB_Prod.Checked = True Then
            CB_SM.Checked = False
            CB_SM.Enabled = False
            CB_ODF.Checked = False
            CB_ODF.Enabled = False
            BImp.Enabled = True
        Else
            CB_SM.Checked = False
            CB_SM.Enabled = True
            CB_ODF.Checked = False
            CB_ODF.Enabled = True
            BImp.Enabled = False

        End If
    End Sub

    Private Sub CB_ODF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ODF.CheckedChanged
        If CB_ODF.Checked = True Then
            CB_SM.Checked = False
            CB_SM.Enabled = False
            CB_Prod.Checked = False
            CB_Prod.Enabled = False
            BImp.Enabled = True
        Else
            CB_SM.Checked = False
            CB_SM.Enabled = True
            CB_Prod.Checked = False
            CB_Prod.Enabled = True
            BImp.Enabled = False
        End If
    End Sub

    Private Sub FrmPET_AMEX_IMP_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Modulo = ""
        CB_Turno.Text = "*"
        CB_Prod.Checked = False
        CB_ODF.Checked = False
    End Sub

    Private Sub CB_SM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SM.CheckedChanged
        If CB_SM.Checked = True Then
            CB_ODF.Checked = False
            CB_ODF.Enabled = False
            CB_Prod.Checked = False
            CB_Prod.Enabled = False
            BImp.Enabled = True
        Else
            CB_ODF.Checked = False
            CB_ODF.Enabled = True
            CB_Prod.Checked = False
            CB_Prod.Enabled = True
            BImp.Enabled = False
        End If
    End Sub
End Class