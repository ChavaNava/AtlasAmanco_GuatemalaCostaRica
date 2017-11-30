Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmIMPAlm_AMEX
    Dim FIP As String   'Fecha de inicio pesaje
    Dim FFP As String   'Fecha de fin pesaje


    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Close()
    End Sub

    Private Sub BImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImp.Click
        FIP = DTP_FI.Value.ToString("yyyy-MM-dd")
        FFP = DTP_FF.Value.ToString("yyyy-MM-dd")

        If RB1.Checked = False And RB2.Checked = False Then
            MsgBox("Selecciones un tipo de reporte")
            Return
        End If

        QRY = ""
        QRY = "Select replicate('0', 8-len(a.folio)) + cast(a.folio as char(8)) as Folio,b.Producto,a.Fecha_Pesaje,"
        QRY = QRY & "a.Turno,a.Usuario,a.Tramos,a.Orden_Produccion,a.PuestoTrabajo,a.UsrAlm "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_PesoProductoTerminado a, " & SessionUser._sCentro.Trim & "_OrdenProduccion b "
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And a.Notifica not in ('9') "
        QRY = QRY & "And a.status_alm = '1' "
        If CB_Trasp.Checked = True Then
            QRY = QRY & "And a.Trasp = '1' "
        Else
            QRY = QRY & "And a.Trasp = '0' "
        End If
        If EXTINY = "1" Then
            QRY = QRY & "And a.Area =  'E' "
        Else
            QRY = QRY & "And a.Area = 'I' "
        End If
        If TOrden.Text <> "*" Then
            QRY = QRY & "And a.Orden_Produccion = '" & TOrden.Text.Trim & "' "
        End If
        QRY = QRY & "And a.Fecha_Pesaje  Between '" & FIP.Trim & "' and '" & FFP.Trim & "'  "
        QRY = QRY & "Order by a.Folio"
        LecturaQry(QRY)

        Try
            objDa = New SqlDataAdapter(QRY, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)

            'objDs.WriteXmlSchema("c:\atlas\PTE_ALM_AMEX.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
        End Try

        If RB1.Checked = True Then
            Dim info As New rptAlmBoletas
            Dim Fechas As SummaryInfo
            Fechas = info.SummaryInfo
            Fechas.ReportTitle = "BOLETAS DE PESAJE RECIBIDAS " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
            info.SetDataSource(objDs)
            FREP.CRV1.ReportSource = info
            FREP.Show()
        End If

        If RB2.Checked = True Then
            Dim info As New rptAlmProd_Boletas
            Dim Fechas As SummaryInfo
            Fechas = info.SummaryInfo
            Fechas.ReportTitle = "BOLETAS DE PESAJE RECIBIDAS ORDENADAS POR PRODUCTO " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
            info.SetDataSource(objDs)
            FREP.CRV1.ReportSource = info
            FREP.Show()
        End If

    End Sub
End Class