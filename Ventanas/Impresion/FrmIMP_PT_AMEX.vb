Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports Utili_Generales
Imports Reporting
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmIMP_PT_AMEX
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

        Select Case Modulo

            Case Is = "PT"

                If CB_Prod.Checked = True Or CB_ODF.Checked = True Or CB_DetXPtoTra.Checked = True Or CB_EntPT.Checked = True Then

                    QRY = ""
                    QRY = "Select a.Orden_Produccion,a.Planta,b.Fecha_Pesaje,b.Hora_Pesaje,b.Bascula,b.Rack,b.Peso_Bruto,b.Tara,"
                    QRY = QRY & "b.Peso_Neto,b.Empaques,b.Tramos,b.Usuario,b.Supervisor,b.Folio,b.Documento_SAP,b.Consecutivo_SAP,"
                    QRY = QRY & "b.Compuesto1,b.Porcentaje1,b.Compuesto2,b.Porcentaje2,b.Sobrepeso,b.CausaSobrepeso,b.PuestoTrabajo,"
                    QRY = QRY & "b.LTCompuestos,b.Peso_teorico,b.PorcentajeMerma,b.PesoMerma,b.PesoNetoMerma,c.Codigo,"
                    QRY = QRY & "c.Descr,b.Turno,b.EmbalajeInyeccion,a.Equipo_Basico,a.Cantidad_Programada_Tramos "
                    If SessionUser._sCentro.Trim = "A015" Then
                        QRY = QRY & "b.Peso_C,b.Pzas_C,b.NumCalidad "
                    End If
                    If SessionUser._sCentro.Trim = "CR01" Then
                        QRY = QRY & ",b.Peso_C,b.Pzas_C "
                    End If
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
                    If EXTINY = "1" Then
                        QRY = QRY & "ProductoTerminadoExtrusion c "
                    Else
                        QRY = QRY & "ProductoTerminadoInyeccion c "
                    End If
                    QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                    QRY = QRY & "And a.Planta = c.Centro "
                    QRY = QRY & "And a.Producto = c.Codigo "
                    If CB_Notif.Checked = True Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    QRY = QRY & "Order by b.Fecha_Pesaje, b.Hora_Pesaje, b.Folio"
                    LecturaQry(QRY)

                    Try
                        objDa = New SqlDataAdapter(QRY, AbrirAmanco(SessionUser._sAmbiente))
                        objDs = New DataSet
                        objDa.Fill(objDs)

                        'objDs.WriteXmlSchema("c:\atlas\PTE_AMEX.xsd")
                        'MessageBox.Show("Field Definitions Written Successfully")

                    Catch ex As Exception
                        MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
                    End Try

                ElseIf CBODFRes.Checked = True Or CB_ResXPtoTra.Checked = True Then 'Reporte Resume de notificados PT y Scrap

                    QRY = ""
                    QRY = "Select a.Orden_Produccion,a.Planta,b.Fecha_Pesaje,b.Hora_Pesaje,b.Bascula,b.Peso_Bruto,b.Tara,"
                    QRY = QRY & "b.Peso_Neto,b.Tramos,b.Usuario,replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,"
                    QRY = QRY & "b.Documento_SAP,b.Consecutivo_SAP,b.Compuesto1,"
                    QRY = QRY & "b.Porcentaje1,b.Compuesto2,b.Porcentaje2,b.PuestoTrabajo,b.LTCompuestos,c.Codigo,c.Descr,"
                    QRY = QRY & "b.Turno,'PT' as Tipo,b.Peso_Teorico,b.SobrePeso,a.Equipo_Basico "
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
                    If EXTINY = "1" Then
                        QRY = QRY & "ProductoTerminadoExtrusion c "
                    Else
                        QRY = QRY & "ProductoTerminadoInyeccion c "
                    End If
                    QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                    QRY = QRY & "And a.Planta = c.Centro "
                    QRY = QRY & "And a.Producto = c.Codigo "
                    If CB_Notif.Checked = True Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    QRY = QRY & "Union "
                    QRY = QRY & "Select a.Orden_Produccion,a.Planta,b.Fecha_Pesaje,b.Hora_Pesaje,b.Bascula,b.Peso_Bruto,b.Tara,"
                    QRY = QRY & "b.Peso_Neto,0 as Tramos,b.Usuario,replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,"
                    QRY = QRY & "b.Documento_SAP,b.Consecutivo_SAP,b.Compuesto1,"
                    QRY = QRY & "b.Porcentaje1,b.Compuesto2,b.Porcentaje2,b.PuestoTrabajo,b.LTCompuestos,c.Codigo,c.Descr,"
                    QRY = QRY & "b.Turno,'SC' as Tipo,0 as Peso_Teorico,0 as SobrePeso,a.Equipo_Basico "
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b, "
                    If EXTINY = "1" Then
                        QRY = QRY & "ProductoTerminadoExtrusion c "
                    Else
                        QRY = QRY & "ProductoTerminadoInyeccion c "
                    End If
                    QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                    QRY = QRY & "And a.Planta = c.Centro "
                    QRY = QRY & "And a.Producto = c.Codigo "
                    If CB_Notif.Checked = True Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    QRY = QRY & "Order by b.Fecha_Pesaje, b.Hora_Pesaje, b.Folio"
                    LecturaQry(QRY)

                    Try
                        objDa = New SqlDataAdapter(QRY, AbrirAmanco(SessionUser._sAmbiente))
                        objDs = New DataSet
                        objDa.Fill(objDs)

                        'objDs.WriteXmlSchema("c:\atlas\ResumenPT_SC_E_AMEX.xsd")
                        'MessageBox.Show("Field Definitions Written Successfully")

                    Catch ex As Exception
                        MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
                    End Try


                ElseIf CB_CompXProd.Checked = True Or CB_CompXOrd.Checked = True Then

                    QRY = ""
                    QRY = QRY & "Select replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
                    QRY = QRY & "c.Descr,b.Fecha_Pesaje,b.Hora_Pesaje,Compuesto1,Porcentaje1,b.Usuario,b.Turno,b.Tramos,b.Peso_Bruto,b.Tara,"
                    QRY = QRY & "b.Peso_Neto,b.Pesonetomerma,"
                    If EXTINY = "1" Then
                        QRY = QRY & "((b.Peso_Neto * b.Porcentaje1)/100) as Compuesto,'V' as Tipo,'PT' as TipoProd "
                    Else
                        QRY = QRY & "((b.Peso_Neto * b.Porcentaje1)/100) as Compuesto,'V' as Tipo,'PT' as TipoProd "
                    End If
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
                    If EXTINY = "1" Then
                        QRY = QRY & "ProductoTerminadoExtrusion c, CompuestoExtrusion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
                        QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
                        QRY = QRY & "And b.Compuesto1 = d.ComExt_ComCodigo "
                        QRY = QRY & "And d.ComExt_ComClase = '1' "
                    Else
                        QRY = QRY & "ProductoTerminadoInyeccion c, CompuestoInyeccion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.Centro "
                        QRY = QRY & "And a.Producto = d.CodPTI "
                        QRY = QRY & "And b.Compuesto1 = d.CodComp "
                        QRY = QRY & "And d.Clase = '1' "
                    End If
                    If CB_Notif.Checked = True Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    QRY = QRY & "Union "
                    QRY = QRY & "Select replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
                    QRY = QRY & "c.Descr,b.Fecha_Pesaje,b.Hora_Pesaje,Compuesto2,Porcentaje2,b.Usuario,b.Turno,b.Tramos,b.Peso_Bruto,b.Tara,"
                    If EXTINY = "1" Then
                        QRY = QRY & "b.Peso_Neto,b.Pesonetomerma,((b.Peso_Neto * b.Porcentaje2)/100) as Compuesto,'V' as Tipo,"
                    Else
                        QRY = QRY & "b.Peso_Neto,b.Pesonetomerma,((b.Peso_Neto * b.Porcentaje2)/100) as Compuesto,'V' as Tipo,"
                    End If
                    QRY = QRY & "'PT' as TipoProd "
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
                    If EXTINY = "1" Then
                        QRY = QRY & "ProductoTerminadoExtrusion c, CompuestoExtrusion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
                        QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
                        QRY = QRY & "And b.Compuesto2 = d.ComExt_ComCodigo "
                        QRY = QRY & "And d.ComExt_ComClase = '1' "
                    Else
                        QRY = QRY & "ProductoTerminadoInyeccion c, CompuestoInyeccion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.Centro "
                        QRY = QRY & "And a.Producto = d.CodPTI "
                        QRY = QRY & "And b.Compuesto2 = d.CodComp "
                        QRY = QRY & "And d.Clase = '1' "
                    End If
                    If CB_Notif.Checked = True Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    QRY = QRY & "Union "
                    QRY = QRY & "Select replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
                    QRY = QRY & "c.Descr,b.Fecha_Pesaje,b.Hora_Pesaje,Compuesto1,Porcentaje1,b.Usuario,b.Turno,'0' as Tramos,b.Peso_Bruto,b.Tara,"
                    QRY = QRY & "b.Peso_Neto,'0' as Pesonetomerma,((b.Peso_Neto * b.Porcentaje1)/100) as Compuesto,'V' as Tipo,"
                    QRY = QRY & "'SC' as TipoProd "
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b, "
                    If EXTINY = "1" Then
                        QRY = QRY & "ProductoTerminadoExtrusion c, CompuestoExtrusion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
                        QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
                        QRY = QRY & "And b.Compuesto1 = d.ComExt_ComCodigo "
                        QRY = QRY & "And d.ComExt_ComClase = '1' "
                    Else
                        QRY = QRY & "ProductoTerminadoInyeccion c, CompuestoInyeccion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.Centro "
                        QRY = QRY & "And a.Producto = d.CodPTI "
                        QRY = QRY & "And b.Compuesto1 = d.CodComp "
                        QRY = QRY & "And d.Clase = '1' "
                    End If
                    If CB_Notif.Checked = True Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    QRY = QRY & "Union "
                    QRY = QRY & "Select replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
                    QRY = QRY & "c.Descr,b.Fecha_Pesaje,b.Hora_Pesaje,Compuesto2,Porcentaje2,b.Usuario,b.Turno,'0' as Tramos,b.Peso_Bruto,b.Tara,"
                    QRY = QRY & "b.Peso_Neto,'0' as Pesonetomerma,((b.Peso_Neto * b.Porcentaje2)/100) as Compuesto,'V' as Tipo,"
                    QRY = QRY & "'SC' as TipoProd "
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b, "
                    If EXTINY = "1" Then
                        QRY = QRY & "ProductoTerminadoExtrusion c, CompuestoExtrusion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
                        QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
                        QRY = QRY & "And b.Compuesto2 = d.ComExt_ComCodigo "
                        QRY = QRY & "And d.ComExt_ComClase = '1' "
                    Else
                        QRY = QRY & "ProductoTerminadoInyeccion c, CompuestoInyeccion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.Centro "
                        QRY = QRY & "And a.Producto = d.CodPTI "
                        QRY = QRY & "And b.Compuesto2 = d.CodComp "
                        QRY = QRY & "And d.Clase = '1' "
                    End If
                    If CB_Notif.Checked = True Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    QRY = QRY & "Union "
                    QRY = QRY & "Select replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
                    QRY = QRY & "c.Descr,b.Fecha_Pesaje,b.Hora_Pesaje,Compuesto1,Porcentaje1,b.Usuario,b.Turno,b.Tramos,b.Peso_Bruto,b.Tara,"
                    If EXTINY = "1" Then
                        QRY = QRY & "b.Peso_Neto,b.Pesonetomerma,((b.Peso_Neto * b.Porcentaje1)/100) as Compuesto,'R' as Tipo,"
                    Else
                        QRY = QRY & "b.Peso_Neto,b.Pesonetomerma,((b.Peso_Neto * b.Porcentaje1)/100) as Compuesto,'R' as Tipo,"
                    End If
                    QRY = QRY & "'PT' as TipoProd "
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
                    If EXTINY = "1" Then
                        QRY = QRY & "ProductoTerminadoExtrusion c, CompuestoExtrusion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
                        QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
                        QRY = QRY & "And b.Compuesto1 = d.ComExt_ComCodigo "
                        QRY = QRY & "And d.ComExt_ComClase = '2' "
                    Else
                        QRY = QRY & "ProductoTerminadoInyeccion c, CompuestoInyeccion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.Centro "
                        QRY = QRY & "And a.Producto = d.CodPTI "
                        QRY = QRY & "And b.Compuesto1 = d.CodComp "
                        QRY = QRY & "And d.Clase = '2' "
                    End If
                    If CB_Notif.Checked = True Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    QRY = QRY & "Union "
                    QRY = QRY & "Select replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
                    QRY = QRY & "c.Descr,b.Fecha_Pesaje,b.Hora_Pesaje,Compuesto2,Porcentaje2,b.Usuario,b.Turno,b.Tramos,b.Peso_Bruto,b.Tara,"
                    If EXTINY = "1" Then
                        QRY = QRY & "b.Peso_Neto,b.Pesonetomerma,((b.Peso_Neto * b.Porcentaje2)/100) as Compuesto,'R' as Tipo,"
                    Else
                        QRY = QRY & "b.Peso_Neto,b.Pesonetomerma,((b.Peso_Neto * b.Porcentaje2)/100) as Compuesto,'R' as Tipo,"
                    End If
                    QRY = QRY & "'PT' as TipoProd "
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
                    If EXTINY = "1" Then
                        QRY = QRY & "ProductoTerminadoExtrusion c, CompuestoExtrusion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
                        QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
                        QRY = QRY & "And b.Compuesto2 = d.ComExt_ComCodigo "
                        QRY = QRY & "And d.ComExt_ComClase = '2' "
                    Else
                        QRY = QRY & "ProductoTerminadoInyeccion c, CompuestoInyeccion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.Centro "
                        QRY = QRY & "And a.Producto = d.CodPTI "
                        QRY = QRY & "And b.Compuesto2 = d.CodComp "
                        QRY = QRY & "And d.Clase = '2' "
                    End If
                    If CB_Notif.Checked = True Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    QRY = QRY & "Union "
                    QRY = QRY & "Select replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
                    QRY = QRY & "c.Descr,b.Fecha_Pesaje,b.Hora_Pesaje,Compuesto1,Porcentaje1,b.Usuario,b.Turno,'0' as Tramos,b.Peso_Bruto,b.Tara,"
                    QRY = QRY & "b.Peso_Neto,'0' as Pesonetomerma,((b.Peso_Neto * b.Porcentaje1)/100) as Compuesto,'R' as Tipo,"
                    QRY = QRY & "'SC' as TipoProd "
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b, "
                    If EXTINY = "1" Then
                        QRY = QRY & "ProductoTerminadoExtrusion c, CompuestoExtrusion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
                        QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
                        QRY = QRY & "And b.Compuesto1 = d.ComExt_ComCodigo "
                        QRY = QRY & "And d.ComExt_ComClase = '2' "
                    Else
                        QRY = QRY & "ProductoTerminadoInyeccion c, CompuestoInyeccion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.Centro "
                        QRY = QRY & "And a.Producto = d.CodPTI "
                        QRY = QRY & "And b.Compuesto1 = d.CodComp "
                        QRY = QRY & "And d.Clase = '2' "
                    End If
                    If CB_Notif.Checked = True Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    QRY = QRY & "Union "
                    QRY = QRY & "Select replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
                    QRY = QRY & "c.Descr,b.Fecha_Pesaje,b.Hora_Pesaje,Compuesto2,Porcentaje2,b.Usuario,b.Turno,'0' as Tramos,b.Peso_Bruto,b.Tara,"
                    QRY = QRY & "b.Peso_Neto,'0' as Pesonetomerma,((b.Peso_Neto * b.Porcentaje2)/100) as Compuesto,'R' as Tipo,"
                    QRY = QRY & "'SC' as TipoProd "
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b, "
                    If EXTINY = "1" Then
                        QRY = QRY & "ProductoTerminadoExtrusion c, CompuestoExtrusion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
                        QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
                        QRY = QRY & "And b.Compuesto2 = d.ComExt_ComCodigo "
                        QRY = QRY & "And d.ComExt_ComClase = '2' "
                    Else
                        QRY = QRY & "ProductoTerminadoInyeccion c, CompuestoInyeccion d "
                        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
                        QRY = QRY & "And a.Producto = c.Codigo "
                        QRY = QRY & "And a.Planta = c.Centro "
                        QRY = QRY & "And a.Planta = d.Centro "
                        QRY = QRY & "And a.Producto = d.CodPTI "
                        QRY = QRY & "And b.Compuesto2 = d.CodComp "
                        QRY = QRY & "And d.Clase = '2' "
                    End If
                    If CB_Notif.Checked = True Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    LecturaQry(QRY)


                    Try
                        objDaC = New SqlDataAdapter(QRY, AbrirAmanco(SessionUser._sAmbiente))
                        objDsC = New DataSet
                        objDaC.Fill(objDsC)

                        'objDsC.WriteXmlSchema("c:\atlas\CONCOMP_PT_SC_AMEX.xsd")
                        'MessageBox.Show("Field Definitions Written Successfully")

                    Catch ex As Exception
                        MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
                    End Try

                ElseIf CB_ResXTipoComp.Checked Then     'Resumen por tipo de compuesto

                    QRY = ""
                    QRY = QRY & "Select d.D_TipoComp, sum(b.Tramos) as Tramos,sum(b.Peso_Bruto) as Peso_Bruto,sum(b.tara) as Peso_Tara,"
                    QRY = QRY & "sum(b.Peso_Neto) as Peso_Neto "
                    QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
                    QRY = QRY & "CAT_ProductoTerminado c, CAT_TipoCompuesto d "
                    QRY = QRY & "Where a.orden_produccion = b.orden_produccion "
                    QRY = QRY & "And a.planta = c.Centro "
                    QRY = QRY & "And a.producto = c.codigo "
                    QRY = QRY & "And c.centro = d.Centro "
                    QRY = QRY & "And c.TipoCompuesto = d.C_TipoComp "                    
                    If CB_Notif.Checked Then
                        QRY = QRY & "And b.Notifica in ('0', '4', '3') "
                    Else
                        QRY = QRY & "And b.Notifica in ('0', '4', '3', '1') "
                    End If
                    If EXTINY = "1" Then
                        QRY = QRY & "And b.Area =  'E' "
                    Else
                        QRY = QRY & "And b.Area = 'I' "
                    End If
                    If CB_Turno.Text.Trim <> "*" Then
                        QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                    End If
                    If CB_Sub.Checked = True Then
                        QRY = QRY & "And c.Codseccion = '36' "
                    Else
                        QRY = QRY & "And c.Codseccion <> '36' "
                    End If
                    If TOrden.Text <> "*" Then
                        QRY = QRY & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
                    End If
                    QRY = QRY & "And (rtrim(b.Fecha_Pesaje) + '' + rtrim(b.Hora_Pesaje)) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
                    QRY = QRY & "group by D_TipoComp "
                    LecturaQry(QRY)

                    Try
                        objDa = New SqlDataAdapter(QRY, AbrirAmanco(SessionUser._sAmbiente))
                        objDs = New DataSet
                        objDa.Fill(objDs)

                        'objDs.WriteXmlSchema("c:\atlas\ResumenTipo_Compuesto.xsd")
                        'MessageBox.Show("Field Definitions Written Successfully")

                    Catch ex As Exception
                        MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
                        Exit Sub
                    End Try

                End If

                If CB_Prod.Checked = True Then
                    'Poblar el informe con el dataSet y mostrarlo
                    If EXTINY = "1" Then
                        Select Case SessionUser._sCentro
                            Case Is = "A015"
                                Dim info As New rptPTECalidadXProd_AMEX
                                Dim Fechas As SummaryInfo
                                Fechas = info.SummaryInfo
                                Fechas.ReportTitle = "ENTREGA PRODUCTO TERMINADO DE EXTRUSIÓN A ALMACEN " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                                info.SetDataSource(objDs)
                                FREP.CRV1.ReportSource = info
                                FREP.Show()
                            Case Else
                                Dim info As New Reporting.rptPTEOrdEntXProd
                                Dim Fechas As SummaryInfo
                                Fechas = info.SummaryInfo
                                Fechas.ReportTitle = "PRODUCTO TERMINADO EXTRUSIÓN " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                                info.SetDataSource(objDs)
                                FREP.CRV1.ReportSource = info
                                FREP.Show()
                        End Select
                    Else
                        Dim info As New rptPTIOrdEntXProd_AMEX
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        Fechas.ReportTitle = "PRODUCTO TERMINADO INYECCIÓN " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                        info.SetDataSource(objDs)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    End If
                End If

                If CB_DetXPtoTra.Checked = True Then
                    If EXTINY = "1" Then
                        Dim info As New rptPTEOrdEntXEqp_AMEX
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        Fechas.ReportTitle = "PRODUCTO TERMINADO DE EXTRUSIÓN X PUESTO DE TRABAJO " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                        info.SetDataSource(objDs)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    Else
                        Dim info As New rptPTEOrdEntXEqp_AMEX
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        Fechas.ReportTitle = "PRODUCTO TERMINADO DE INYECCIÓN X PUESTO DE TRABAJO " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                        info.SetDataSource(objDs)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    End If
                Else

                End If

                If CB_ResXPtoTra.Checked = True Then
                    If EXTINY = "1" Then
                        Dim info As New rptPTEOrdEntXEqpResumen_AMEX
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        Fechas.ReportTitle = "PRODUCTO TERMINADO DE EXTRUSIÓN X PUESTO DE TRABAJO " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                        info.SetDataSource(objDs)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    Else
                        Dim info As New rptPTEOrdEntXEqpResumen_AMEX
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        Fechas.ReportTitle = "PRODUCTO TERMINADO DE INYECCIÓN X PUESTO DE TRABAJO " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                        info.SetDataSource(objDs)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    End If
                End If

                If CB_CompXProd.Checked = True Then
                    If EXTINY = "1" Then
                        Dim info As New rptCCEXProdDet_AMEX
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        Fechas.ReportTitle = "REPORTE CONSUMO DE COMPUESTO RODUCTO TERMINADO EXTRUSIÓN " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                        info.SetDataSource(objDsC)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    Else
                        Dim info As New rptCCEXProdDet_AMEX
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        Fechas.ReportTitle = "REPORTE CONSUMO DE COMPUESTO RODUCTO TERMINADO INYECCIÓN " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                        info.SetDataSource(objDsC)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    End If
                End If

                If CB_CompXOrd.Checked = True Then
                    'Poblar el informe con el dataSet y mostrarlo
                    If EXTINY = "1" Then
                        Dim info As New rptCCEXODFDet_AMEX
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        Fechas.ReportTitle = "REPORTE CONSUMO DE COMPUESTO PRODUCTO TERMINADO EXTRUSIÓN " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                        info.SetDataSource(objDsC)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    Else
                        Dim info As New rptCCEXODFDet_AMEX
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        Fechas.ReportTitle = "REPORTE CONSUMO DE COMPUESTO PRODUCTO TERMINADO INYECCIÓN " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                        info.SetDataSource(objDsC)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    End If
                End If

                If CB_ODF.Checked = True Then
                    'Poblar el informe con el dataSet y mostrarlo
                    If EXTINY = "1" Then
                        If SessionUser._sCentro = "A015" Then
                            Dim info As New rptPTECalidadXODF_AMEX
                            Dim Fechas As SummaryInfo
                            Fechas = info.SummaryInfo
                            Fechas.ReportTitle = "ENTREGA PRODUCTO TERMINADO DE EXTRUSIÓN A ALMACEN " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                            info.SetDataSource(objDs)
                            FREP.CRV1.ReportSource = info
                            FREP.Show()
                        Else
                            Dim info As New rptPTEOrdEntXODF
                            Dim Fechas As SummaryInfo
                            Fechas = info.SummaryInfo
                            Fechas.ReportTitle = "REPORTE DE ENTREGA PRODUCTO TERMINADO EXTRUSIÓN " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                            info.SetDataSource(objDs)
                            FREP.CRV1.ReportSource = info
                            FREP.Show()
                        End If
                    Else
                        Dim info As New rptPTIOrdEntXODF_AMEX
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        Fechas.ReportTitle = "REPORTE DE ENTREGA PRODUCTO TERMINADO INYECCIÓN " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                        info.SetDataSource(objDs)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    End If
                End If

                If CBODFRes.Checked = True Then
                    If EXTINY = "1" Then
                        Dim info As New rptPTEOrdEntXODFResumen_AMEX
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        Fechas.ReportTitle = "PRODUCTO TERMINADO EXTRUSIÓN TOTALES POR ODF " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                        info.SetDataSource(objDs)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    End If
                End If

                If CB_EntPT.Checked = True Then
                    If EXTINY = "1" Then
                        Dim info As New rptPTEntrega
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        If SessionUser._sCentro.Trim = "CR01" Then
                            Fechas.ReportTitle = "REPORTE DE PRODUCTO TERMINADO PLANTA DE EXTRUSIÓN AMANCO COSTA RICA " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim & vbCr & "FIG P1.8.PROD.CRC"
                        Else
                            Fechas.ReportTitle = "REPORTE DE PRODUCTO TERMINADO"
                        End If
                        info.SetDataSource(objDs)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    Else
                        Dim info As New rptPTEntrega
                        Dim Fechas As SummaryInfo
                        Fechas = info.SummaryInfo
                        If SessionUser._sCentro.Trim = "CR01" Then
                            Fechas.ReportTitle = "REPORTE DE PRODUCTO TERMINADO PLANTA DE INYECCIÓN AMANCO COSTA RICA " & vbCr & " del  " + FIP.Trim + "  al  " + FFP.Trim & vbCr & "FIG P1.8.PROD.CRC"
                        Else
                            Fechas.ReportTitle = "REPORTE DE PRODUCTO TERMINADO"
                        End If
                        info.SetDataSource(objDs)
                        FREP.CRV1.ReportSource = info
                        FREP.Show()
                    End If
                End If

                'If CB_ResXTipoComp.Checked Then
                '    If EXTINY = "1" Then
                '        Dim info As New rResTipoCompuesto
                '        Dim Fechas As SummaryInfo
                '        Fechas = info.SummaryInfo
                '        Fechas.ReportTitle = "Resume Consumo por Tipo Compuesto Extrusión " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                '        info.SetDataSource(objDs)
                '        FREP.CRV1.ReportSource = info
                '        FREP.Show()
                '    Else
                '        Dim info As New rResTipoCompuesto
                '        Dim Fechas As SummaryInfo
                '        Fechas = info.SummaryInfo
                '        Fechas.ReportTitle = "Resume Consumo por Tipo Compuesto Inyección  " & vbCr & " del " + FIP.Trim + "  al  " + FFP.Trim
                '        info.SetDataSource(objDs)
                '        FREP.CRV1.ReportSource = info
                '        FREP.Show()
                '    End If
                'End If

            Case Is = "SC"

                QRY = ""
                QRY = "Select a.Orden_Produccion,a.Planta,b.Fecha_Pesaje,b.Hora_Pesaje,b.Bascula,b.Tipo_Scrap,"
                QRY = QRY & "b.Peso_Bruto,b.Tara,b.Peso_Neto,b.Usuario,b.Turno,b.Folio,b.Documento_SAP,b.Consecutivo_SAP,"
                QRY = QRY & "b.Notifica,b.Causa,b.Efecto,b.PuestoTrabajo,b.RepGenerado,c.Codigo,c.Descr,c.PesoTeorico,c.Empaque "
                QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b, "
                If EXTINY = "1" Then
                    QRY = QRY & "ProductoTerminadoExtrusion c "
                Else
                    QRY = QRY & "ProductoTerminadoInyeccion c "
                End If
                QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion  "
                QRY = QRY & "And a.Planta = c.Centro "
                QRY = QRY & "And a.Producto = c.Codigo "
                QRY = QRY & "And b.Notifica <> '9' "
                If CB_Turno.Text.Trim <> "*" Then
                    QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
                End If
                QRY = QRY & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & FIP.Trim & "' + '" & HI.Trim & "'  and '" & FFP.Trim & "' + '" & HF.Trim & "' "
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

                If CB_Prod.Checked = True Then
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

                If CB_ODF.Checked = True Then
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

        End Select
    End Sub

    Private Sub FrmPET_AMEX_IMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCBTurno()
        Me.Icon = Util.ApplicationIcon()
        CB_Notif.Enabled = False
        CB_Sub.Enabled = False
        CB_Turno.Text = "*"
        DTP_FI.Value = Now.Date.ToString("yyyy-MM-dd")
        DTP_FF.Value = Now.Date.ToString("yyyy-MM-dd")
        THI.Text = "00:00:01"
        THF.Text = "23:59:59"
        If Modulo = "SC" Then
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = False
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = False
            CBODFRes.Checked = False
            CBODFRes.Enabled = False
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
        Else
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = True
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = True
            CBODFRes.Checked = False
            CBODFRes.Enabled = True
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
        End If

        BImp.Enabled = False
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Close()
    End Sub

    Private Sub CB_Prod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Prod.CheckedChanged
        If CB_Prod.Checked = True Then
            CBODFRes.Checked = False
            CBODFRes.Enabled = False
            CB_ODF.Checked = False
            CB_ODF.Enabled = False
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = False
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = False
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = False
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = False
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = False
            CB_Notif.Checked = False
            CB_Notif.Enabled = True
            CB_Sub.Checked = False
            CB_Sub.Enabled = True
            BImp.Enabled = True
        Else
            CBODFRes.Checked = False
            CBODFRes.Enabled = True
            CB_ODF.Checked = False
            CB_ODF.Enabled = True
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = True
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = True
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = True
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = True
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = True
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
            BImp.Enabled = False

        End If
    End Sub

    Private Sub CB_ODF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ODF.CheckedChanged
        If CB_ODF.Checked = True Then
            CBODFRes.Checked = False
            CBODFRes.Enabled = False
            CB_Prod.Checked = False
            CB_Prod.Enabled = False
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = False
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = False
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = False
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = False
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = False
            CB_Notif.Checked = False
            CB_Notif.Enabled = True
            CB_Sub.Checked = False
            CB_Sub.Enabled = True
            BImp.Enabled = True
        Else
            CBODFRes.Checked = False
            CBODFRes.Enabled = True
            CB_Prod.Checked = False
            CB_Prod.Enabled = True
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = True
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = True
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = True
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = True
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = True
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
            BImp.Enabled = False
        End If
    End Sub

    Private Sub CB_CompXProd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_CompXProd.CheckedChanged
        If CB_CompXProd.Checked = True Then
            CBODFRes.Checked = False
            CBODFRes.Enabled = False
            CB_Prod.Checked = False
            CB_Prod.Enabled = False
            CB_ODF.Checked = False
            CB_ODF.Enabled = False
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = False
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = False
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = False
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = False
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
            BImp.Enabled = True
        Else
            CBODFRes.Checked = False
            CBODFRes.Enabled = True
            CB_Prod.Checked = False
            CB_Prod.Enabled = True
            CB_ODF.Checked = False
            CB_ODF.Enabled = True
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = True
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = True
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = True
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = True
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
            BImp.Enabled = False
        End If
    End Sub

    Private Sub CB_CompXOrd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_CompXOrd.CheckedChanged
        If CB_CompXOrd.Checked = True Then
            CBODFRes.Checked = False
            CBODFRes.Enabled = False
            CB_Prod.Checked = False
            CB_Prod.Enabled = False
            CB_ODF.Checked = False
            CB_ODF.Enabled = False
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = False
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = False
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = False
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = False
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
            BImp.Enabled = True
        Else
            CBODFRes.Checked = False
            CBODFRes.Enabled = True
            CB_Prod.Checked = False
            CB_Prod.Enabled = True
            CB_ODF.Checked = False
            CB_ODF.Enabled = True
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = True
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = True
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = True
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = True
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
            BImp.Enabled = False
        End If
    End Sub

    Private Sub FrmPET_AMEX_IMP_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Modulo = ""
        CB_Turno.Text = "*"
        CB_Prod.Checked = False
        CB_ODF.Checked = False
    End Sub

    Private Sub CBODFRes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBODFRes.CheckedChanged
        If CBODFRes.Checked = True Then
            CB_Prod.Checked = False
            CB_Prod.Enabled = False
            CB_ODF.Checked = False
            CB_ODF.Enabled = False
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = False
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = False
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = False
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = False
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = False
            CB_Notif.Checked = False
            CB_Notif.Enabled = True
            CB_Sub.Checked = False
            CB_Sub.Enabled = True
            BImp.Enabled = True
        Else
            CB_Prod.Checked = False
            CB_Prod.Enabled = True
            CB_ODF.Checked = False
            CB_ODF.Enabled = True
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = True
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = True
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = True
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = True
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = True
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
            BImp.Enabled = False

        End If
    End Sub

    Private Sub CB_DetXPtoTra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_DetXPtoTra.CheckedChanged
        If CB_DetXPtoTra.Checked = True Then
            CB_Prod.Checked = False
            CB_Prod.Enabled = False
            CB_ODF.Checked = False
            CB_ODF.Enabled = False
            CBODFRes.Checked = False
            CBODFRes.Enabled = False
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = False
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = False
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = False
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = False
            CB_Notif.Checked = False
            CB_Notif.Enabled = True
            CB_Sub.Checked = False
            CB_Sub.Enabled = True
            BImp.Enabled = True
        Else
            CB_Prod.Checked = False
            CB_Prod.Enabled = True
            CB_ODF.Checked = False
            CB_ODF.Enabled = True
            CBODFRes.Checked = False
            CBODFRes.Enabled = True
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = True
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = True
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = True
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = True
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
            BImp.Enabled = False
        End If
    End Sub

    Private Sub CB_ResXPtoTra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ResXPtoTra.CheckedChanged
        If CB_ResXPtoTra.Checked = True Then
            CB_Prod.Checked = False
            CB_Prod.Enabled = False
            CB_ODF.Checked = False
            CB_ODF.Enabled = False
            CBODFRes.Checked = False
            CBODFRes.Enabled = False
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = False
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = False
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = False
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = False
            CB_Notif.Checked = False
            CB_Notif.Enabled = True
            CB_Sub.Checked = False
            CB_Sub.Enabled = True
            BImp.Enabled = True
        Else
            CB_Prod.Checked = False
            CB_Prod.Enabled = True
            CB_ODF.Checked = False
            CB_ODF.Enabled = True
            CBODFRes.Checked = False
            CBODFRes.Enabled = True
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = True
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = True
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = True
            CB_ResXTipoComp.Checked = False
            CB_ResXTipoComp.Enabled = True
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
            BImp.Enabled = False
        End If
    End Sub

    Private Sub CB_EntPT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_EntPT.CheckedChanged
        If CB_EntPT.Checked = True Then
            CB_Prod.Checked = False
            CB_Prod.Enabled = False
            CBODFRes.Checked = False
            CBODFRes.Enabled = False
            CB_ODF.Checked = False
            CB_ODF.Enabled = False
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = False
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = False
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = False
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = False
            CB_Notif.Checked = False
            CB_Notif.Enabled = True
            CB_Sub.Checked = False
            CB_Sub.Enabled = True
            BImp.Enabled = True
        Else
            CB_Prod.Checked = False
            CB_Prod.Enabled = True
            CBODFRes.Checked = False
            CBODFRes.Enabled = True
            CB_ODF.Checked = False
            CB_ODF.Enabled = True
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = True
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = True
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = True
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = True
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
            BImp.Enabled = False

        End If
    End Sub

    Private Sub CB_ResXTipoComp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ResXTipoComp.CheckedChanged
        If CB_ResXTipoComp.Checked Then
            CB_Prod.Checked = False
            CB_Prod.Enabled = False
            CB_ODF.Checked = False
            CB_ODF.Enabled = False
            CBODFRes.Checked = False
            CBODFRes.Enabled = False
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = False
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = False
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = False
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = False
            CB_Notif.Checked = False
            CB_Notif.Enabled = True
            CB_Sub.Checked = False
            CB_Sub.Enabled = True
            BImp.Enabled = True
        Else
            CB_Prod.Checked = False
            CB_Prod.Enabled = True
            CB_ODF.Checked = False
            CB_ODF.Enabled = True
            CBODFRes.Checked = False
            CBODFRes.Enabled = True
            CB_DetXPtoTra.Checked = False
            CB_DetXPtoTra.Enabled = True
            CB_CompXProd.Checked = False
            CB_CompXProd.Enabled = True
            CB_CompXOrd.Checked = False
            CB_CompXOrd.Enabled = True
            CB_ResXPtoTra.Checked = False
            CB_ResXPtoTra.Enabled = True
            CB_Notif.Checked = False
            CB_Notif.Enabled = False
            CB_Sub.Checked = False
            CB_Sub.Enabled = False
            BImp.Enabled = False
        End If
    End Sub
End Class