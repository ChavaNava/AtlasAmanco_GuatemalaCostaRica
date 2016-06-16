Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmProduccion
    Dim FIP As String   'Fecha de inicio pesaje
    Dim FFP As String   'Fecha de fin pesaje
    Dim HI As String    'Hora de inicio pesaje
    Dim HF As String    'Hora de fin pesaje
    Dim Str_FI As String    'Fecha inicio consulta
    Dim Str_FF As String    'Fecha fin consulta
    Dim TProd As String
    Dim TP_Cell As String
    Dim TSaldo As Integer
    Dim TP_Scrap As String
    Dim Almacen As String
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

    Sub FillCBLinea()
        Dim NDataSet1 As New DataSet
        QryCombo = ""
        QryCombo = "Select Equipo_Basico,Descripcion,Equipo_basico+Descripcion as Eqp "
        QryCombo = QryCombo & "From EquipoBasico "
        QryCombo = QryCombo & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
        If RB4.Checked = True Then
            QryCombo = QryCombo & "And Tpo_Equipo_Basico = '1' "
        ElseIf RB5.Checked = True Then
            QryCombo = QryCombo & "And Tpo_Equipo_Basico = '2' "
        Else
            QryCombo = QryCombo & "And Tpo_Equipo_Basico in ('1', '2') "
        End If
        QryCombo = QryCombo & "And Status = '1' "
        Combo(QryCombo)
        NDataSet1 = DataSetCombo.Copy
        CB_Linea.DataSource = NDataSet1.Tables(0)
        CB_Linea.DisplayMember = "Eqp"
        CB_Linea.ValueMember = "Equipo_basico"
    End Sub

    Sub FillCBMaterial()
        Dim NDataSet1 As New DataSet
        QryCombo = ""
        QryCombo = "Select Codigo,Descr,Codigo+Descr as Mat "
        If RB4.Checked = True Then
            QryCombo = QryCombo & "From ProductoTerminadoExtrusion "
            QryCombo = QryCombo & "Where Centro = '" & SessionUser._sCentro.Trim & "' "
        ElseIf RB5.Checked = True Then
            QryCombo = QryCombo & "From ProductoTerminadoInyeccion "
            QryCombo = QryCombo & "Where Centro = '" & SessionUser._sCentro.Trim & "' "
        Else
            QryCombo = QryCombo & "From ProductoTerminadoExtrusion "
            QryCombo = QryCombo & "Where Centro = '" & SessionUser._sCentro.Trim & "' "
            QryCombo = QryCombo & "Union "
            QryCombo = QryCombo & "Select Codigo,Descr,Codigo+Descr as Mat "
            QryCombo = QryCombo & "From ProductoTerminadoInyeccion "
            QryCombo = QryCombo & "Where Centro = '" & SessionUser._sCentro.Trim & "' "
        End If
        Combo(QryCombo)
        NDataSet1 = DataSetCombo.Copy
        CB_Linea.DataSource = NDataSet1.Tables(0)
        CB_Linea.DisplayMember = "Mat"
        CB_Linea.ValueMember = "Codigo"
    End Sub

    Sub FillCBComp()
        Dim NDataSet1 As New DataSet
        QryCombo = ""
        QryCombo = "Select Compuesto,Descripcion,Compuesto+Descripcion as Comp "
        If RB4.Checked = True Then
            QryCombo = QryCombo & "From MCPC_Compuesto "
            QryCombo = QryCombo & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
            QryCombo = QryCombo & "And Tipo_Compuesto = '1' "
        ElseIf RB5.Checked = True Then
            QryCombo = QryCombo & "From MCPC_Compuesto "
            QryCombo = QryCombo & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
            QryCombo = QryCombo & "And Tipo_Compuesto = '2' "
        Else
            QryCombo = QryCombo & "From MCPC_Compuesto "
            QryCombo = QryCombo & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
            QryCombo = QryCombo & "And Tipo_Compuesto = '1' "
            QryCombo = QryCombo & "Union "
            QryCombo = QryCombo & "Select Compuesto,Descripcion,Compuesto+Descripcion as Comp "
            QryCombo = QryCombo & "From MCPC_Compuesto "
            QryCombo = QryCombo & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
            QryCombo = QryCombo & "And Tipo_Compuesto = '2' "
        End If
        Combo(QryCombo)
        NDataSet1 = DataSetCombo.Copy
        CB_Linea.DataSource = NDataSet1.Tables(0)
        CB_Linea.DisplayMember = "Comp"
        CB_Linea.ValueMember = "Compuesto"
    End Sub

    Public Sub Grid_Load()

        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim
        HI = THI.Text.Trim
        HF = THF.Text.Trim

        If RB4.Checked = True Then
            EXTINY = "1"
        End If

        If RB5.Checked = True Then
            EXTINY = "2"
        End If

        DGV_ConProd.DataSource = ""

        'Consulta por Puesto de trabajo
        If RB1.Checked = True Then

            DGV_ConProd.DataSource = ""

            QRY_Grid = ""
            NameTable = ""
            NameTable = "Produccion"
            QRY_Grid = "Select a.Equipo_basico,replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_produccion,"
            QRY_Grid = QRY_Grid & "a.Producto,b.Fecha_Pesaje,b.Hora_Pesaje,b.turno,'Producto Terminado' as Tipo,"
            QRY_Grid = QRY_Grid & "b.Bascula,b.Tramos,b.Peso_Bruto,b.Tara,b.Peso_Neto,b.Documento_SAP,b.Consecutivo_SAP,"
            QRY_Grid = QRY_Grid & "b.Status_Alm,b.Tipo_PT "
            QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b "
            QRY_Grid = QRY_Grid & "Where a.orden_produccion = b.orden_produccion "
            QRY_Grid = QRY_Grid & "And b.Status_Pesaje = '1' "
            QRY_Grid = QRY_Grid & "And b.Notifica  not in  ('9') "
            QRY_Grid = QRY_Grid & "And b.Tipo_PT = 'T' "
            If RB4.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'E' "
            ElseIf RB5.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'I' "
            Else
                QRY_Grid = QRY_Grid & "And b.Area in ('E', 'I') "
            End If
            If CB_Linea.Text.Trim <> "*" Then
                QRY_Grid = QRY_Grid & "And a.equipo_basico = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Turno.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            QRY_Grid = QRY_Grid & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY_Grid = QRY_Grid & "Union "
            QRY_Grid = QRY_Grid & "Select a.Equipo_basico,replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_produccion,"
            QRY_Grid = QRY_Grid & "a.Producto,b.Fecha_Pesaje,b.Hora_Pesaje,b.turno,'Scrap Recuperado' as Tipo,b.Bascula,"
            QRY_Grid = QRY_Grid & "'0' as Tramos,b.Peso_Bruto,b.Tara,b.Peso_Neto,b.Documento_SAP,b.Consecutivo_SAP,"
            QRY_Grid = QRY_Grid & "'0' as Status_Alm,b.Tipo_Scrap "
            QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b "
            QRY_Grid = QRY_Grid & "Where a.orden_produccion = b.orden_produccion "
            QRY_Grid = QRY_Grid & "And b.Status_Pesaje = '1' "
            QRY_Grid = QRY_Grid & "And b.Notifica  not in  ('9') "
            QRY_Grid = QRY_Grid & "And b.Tipo_Scrap = 'T' "
            If RB4.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'E' "
            ElseIf RB5.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'I' "
            Else
                QRY_Grid = QRY_Grid & "And b.Area in ('E', 'I') "
            End If
            If CB_Linea.Text.Trim <> "*" Then
                QRY_Grid = QRY_Grid & "And a.equipo_basico = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Turno.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            QRY_Grid = QRY_Grid & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY_Grid = QRY_Grid & "Union "
            QRY_Grid = QRY_Grid & "Select a.Equipo_basico,replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_produccion,"
            QRY_Grid = QRY_Grid & "a.Producto,b.Fecha_Pesaje,b.Hora_Pesaje,b.turno,'Scrap Basura' as Tipo,b.Bascula,"
            QRY_Grid = QRY_Grid & "'0' as Tramos,b.Peso_Bruto,b.Tara,b.Peso_Neto,b.Documento_SAP,b.Consecutivo_SAP,"
            QRY_Grid = QRY_Grid & "'0' as Status_Alm,b.Tipo_Scrap "
            QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b "
            QRY_Grid = QRY_Grid & "Where a.orden_produccion = b.orden_produccion "
            QRY_Grid = QRY_Grid & "And b.Status_Pesaje = '1' "
            QRY_Grid = QRY_Grid & "And b.Notifica  not in  ('9') "
            QRY_Grid = QRY_Grid & "And b.Tipo_Scrap = 'G' "
            If RB4.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'E' "
            ElseIf RB5.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'I' "
            Else
                QRY_Grid = QRY_Grid & "And b.Area in ('E', 'I') "
            End If
            If CB_Linea.Text.Trim <> "*" Then
                QRY_Grid = QRY_Grid & "And a.equipo_basico = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Turno.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            QRY_Grid = QRY_Grid & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY_Grid = QRY_Grid & "Order by Equipo_basico "

            Try
                objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco)
                objDs = New DataSet
                objDa.Fill(objDs)
                DGV_ConProd.DataSource = objDs.Tables(0)

            Catch ex As Exception
                MessageBox.Show("Error Conexion :" & ex.Message, "Produccion")
            End Try

            DGV_ConProd.Columns(0).HeaderText = "Equipo Basico"
            DGV_ConProd.Columns(1).HeaderText = "Folio"
            DGV_ConProd.Columns(2).HeaderText = "Orden de Producción"
            DGV_ConProd.Columns(3).HeaderText = "Producto"
            DGV_ConProd.Columns(4).HeaderText = "Fecha Pesaje"
            DGV_ConProd.Columns(5).HeaderText = "Hora Pesaje"
            DGV_ConProd.Columns(6).HeaderText = "Turno"
            DGV_ConProd.Columns(7).HeaderText = "Tipo Pesaje"
            DGV_ConProd.Columns(8).HeaderText = "Bascula"
            DGV_ConProd.Columns(9).HeaderText = "Tramos"
            DGV_ConProd.Columns(10).Visible = False     'Peso Bruto
            DGV_ConProd.Columns(11).Visible = False     'Peso Tara
            DGV_ConProd.Columns(12).HeaderText = "Peso Neto"
            DGV_ConProd.Columns(13).HeaderText = "Documento SAP"
            DGV_ConProd.Columns(14).HeaderText = "Consecutivo SAP"
            DGV_ConProd.Columns(15).Visible = False     'Status Almacen"
            DGV_ConProd.Columns(16).Visible = False     'Tipo Scrap

        End If

        'Consulta por producto
        If RB2.Checked = True Then

            DGV_ConProd.DataSource = ""

            QRY_Grid = ""
            NameTable = ""
            NameTable = "Productos"
            QRY_Grid = "Select a.Producto,Equipo_basico,replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_produccion,"
            QRY_Grid = QRY_Grid & "b.Fecha_Pesaje,b.Hora_Pesaje,b.turno,'Producto Terminado' as Tipo,"
            QRY_Grid = QRY_Grid & "b.Bascula,b.Tramos,b.Peso_Bruto,b.Tara,b.Peso_Neto,b.Documento_SAP,b.Consecutivo_SAP,"
            QRY_Grid = QRY_Grid & "b.Status_Alm,b.Tipo_PT "
            QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b "
            QRY_Grid = QRY_Grid & "Where a.orden_produccion = b.orden_produccion "
            QRY_Grid = QRY_Grid & "And b.Status_Pesaje = '1' "
            QRY_Grid = QRY_Grid & "And b.Notifica  not in  ('9') "
            QRY_Grid = QRY_Grid & "And b.Tipo_PT = 'T' "
            If RB4.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'E' "
            ElseIf RB5.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'I' "
            Else
                QRY_Grid = QRY_Grid & "And b.Area in ('E', 'I') "
            End If
            If CB_Linea.Text.Trim <> "*" Then
                QRY_Grid = QRY_Grid & "And a.Producto = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Turno.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            QRY_Grid = QRY_Grid & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY_Grid = QRY_Grid & "Union "
            QRY_Grid = QRY_Grid & "Select a.Producto,a.Equipo_basico,replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_produccion,"
            QRY_Grid = QRY_Grid & "b.Fecha_Pesaje,b.Hora_Pesaje,b.turno,'Scrap Recuperado' as Tipo,b.Bascula,"
            QRY_Grid = QRY_Grid & "'0' as Tramos,b.Peso_Bruto,b.Tara,b.Peso_Neto,b.Documento_SAP,b.Consecutivo_SAP,"
            QRY_Grid = QRY_Grid & "'0' as Status_Alm,b.Tipo_Scrap "
            QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b "
            QRY_Grid = QRY_Grid & "Where a.orden_produccion = b.orden_produccion "
            QRY_Grid = QRY_Grid & "And b.Status_Pesaje = '1' "
            QRY_Grid = QRY_Grid & "And b.Notifica  not in  ('9') "
            QRY_Grid = QRY_Grid & "And b.Tipo_Scrap = 'T' "
            If RB4.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'E' "
            ElseIf RB5.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'I' "
            Else
                QRY_Grid = QRY_Grid & "And b.Area in ('E', 'I') "
            End If
            If CB_Linea.Text.Trim <> "*" Then
                QRY_Grid = QRY_Grid & "And a.Producto = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Turno.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            QRY_Grid = QRY_Grid & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY_Grid = QRY_Grid & "Union "
            QRY_Grid = QRY_Grid & "Select a.Producto,a.Equipo_basico,replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_produccion,"
            QRY_Grid = QRY_Grid & "b.Fecha_Pesaje,b.Hora_Pesaje,b.turno,'Scrap Basura' as Tipo,b.Bascula,"
            QRY_Grid = QRY_Grid & "'0' as Tramos,b.Peso_Bruto,b.Tara,b.Peso_Neto,b.Documento_SAP,b.Consecutivo_SAP,"
            QRY_Grid = QRY_Grid & "'0' as Status_Alm,b.Tipo_Scrap "
            QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoScrap b "
            QRY_Grid = QRY_Grid & "Where a.orden_produccion = b.orden_produccion "
            QRY_Grid = QRY_Grid & "And b.Status_Pesaje = '1' "
            QRY_Grid = QRY_Grid & "And b.Notifica  not in  ('9') "
            QRY_Grid = QRY_Grid & "And b.Tipo_Scrap = 'G' "
            If RB4.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'E' "
            ElseIf RB5.Checked = True Then
                QRY_Grid = QRY_Grid & "And b.Area = 'I' "
            Else
                QRY_Grid = QRY_Grid & "And b.Area in ('E', 'I') "
            End If
            If CB_Linea.Text.Trim <> "*" Then
                QRY_Grid = QRY_Grid & "And a.Producto = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Turno.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            QRY_Grid = QRY_Grid & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY_Grid = QRY_Grid & "Order by a.Producto "

            Try
                objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco)
                objDs = New DataSet
                objDa.Fill(objDs)
                DGV_ConProd.DataSource = objDs.Tables(0)

            Catch ex As Exception
                MessageBox.Show("Error Conexion :" & ex.Message, "Produccion")
            End Try

            DGV_ConProd.Columns(0).HeaderText = "Producto"
            DGV_ConProd.Columns(1).HeaderText = "Equipo Basico"
            DGV_ConProd.Columns(2).HeaderText = "Folio"
            DGV_ConProd.Columns(3).HeaderText = "Orden de Producción"
            DGV_ConProd.Columns(4).HeaderText = "Fecha Pesaje"
            DGV_ConProd.Columns(5).HeaderText = "Hora Pesaje"
            DGV_ConProd.Columns(6).HeaderText = "Turno"
            DGV_ConProd.Columns(7).HeaderText = "Tipo Pesaje"
            DGV_ConProd.Columns(8).HeaderText = "Bascula"
            DGV_ConProd.Columns(9).HeaderText = "Tramos"
            DGV_ConProd.Columns(10).Visible = False     'Peso Bruto
            DGV_ConProd.Columns(11).Visible = False     'Peso Tara
            DGV_ConProd.Columns(12).HeaderText = "Peso Neto"
            DGV_ConProd.Columns(13).HeaderText = "Documento SAP"
            DGV_ConProd.Columns(14).HeaderText = "Consecutivo SAP"
            DGV_ConProd.Columns(15).Visible = False     'Status Almacen"
            DGV_ConProd.Columns(16).Visible = False     'Tipo Scrap

        End If

        'Consulta por compuesto
        If RB3.Checked = True Then

            DGV_ConProd.DataSource = ""

            QRY = ""
            QRY = QRY & "Select Compuesto1 as Compuesto,Porcentaje1 as Porcentaje,"
            QRY = QRY & "replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
            QRY = QRY & "c.Descr,b.Fecha_Pesaje,'Producto Terminado' as TipoProd,b.Hora_Pesaje,b.Usuario,b.Turno,b.Tramos,"
            QRY = QRY & "b.Peso_Bruto,b.Tara,b.Peso_Neto,b.Status_Alm,b.Pesonetomerma,"
            If EXTINY = "1" Then
                QRY = QRY & "((b.PesoNetoMerma * b.Porcentaje1)/100) as Compuesto,'V' as Tipo "
            Else
                QRY = QRY & "((b.Peso_Neto * b.Porcentaje1)/100) as Compuesto,'V' as Tipo "
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
            QRY = QRY & "And b.Notifica  not in  ('9') "
            QRY = QRY & "And c.Codseccion <> '36' "
            If EXTINY = "1" Then
                QRY = QRY & "And b.Area =  'E' "
            Else
                QRY = QRY & "And b.Area = 'I' "
            End If
            If CB_Turno.Text.Trim <> "*" Then
                QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY = QRY & "And b.Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Linea.Text <> "*" Then
                QRY = QRY & "And b.Compuesto1 = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            QRY = QRY & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY = QRY & "Union "
            QRY = QRY & "Select Compuesto2 as Compuesto,Porcentaje2 as Porcentaje,"
            QRY = QRY & "replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
            QRY = QRY & "c.Descr,b.Fecha_Pesaje,'Producto Terminado' as TipoProd,b.Hora_Pesaje,b.Usuario,b.Turno,b.Tramos,b.Peso_Bruto,b.Tara,"
            If EXTINY = "1" Then
                QRY = QRY & "b.Peso_Neto,b.Status_Alm,b.Pesonetomerma,((b.PesoNetoMerma * b.Porcentaje2)/100) as Compuesto,'V' as Tipo "
            Else
                QRY = QRY & "b.Peso_Neto,b.Status_Alm,b.Pesonetomerma,((b.Peso_Neto * b.Porcentaje2)/100) as Compuesto,'V' as Tipo "
            End If
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
            QRY = QRY & "And b.Notifica  not in  ('9') "
            QRY = QRY & "And c.Codseccion <> '36' "
            If EXTINY = "1" Then
                QRY = QRY & "And b.Area =  'E' "
            Else
                QRY = QRY & "And b.Area = 'I' "
            End If
            If CB_Turno.Text.Trim <> "*" Then
                QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY = QRY & "And b.Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Linea.Text <> "*" Then
                QRY = QRY & "And b.Compuesto2 = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            QRY = QRY & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY = QRY & "Union "
            QRY = QRY & "Select Compuesto1 as Compuesto,Porcentaje1 as Porcentaje,"
            QRY = QRY & "replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
            QRY = QRY & "c.Descr,b.Fecha_Pesaje,'Scrap' as TipoProd,b.Hora_Pesaje,b.Usuario,b.Turno,'0' as Tramos,b.Peso_Bruto,b.Tara,"
            QRY = QRY & "b.Peso_Neto,0 as Status_Alm,'0' as Pesonetomerma,((b.Peso_Neto * b.Porcentaje1)/100) as Compuesto,'V' as Tipo "
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
            QRY = QRY & "And b.Notifica  not in  ('9') "
            QRY = QRY & "And c.Codseccion <> '36' "
            If EXTINY = "1" Then
                QRY = QRY & "And b.Area =  'E' "
            Else
                QRY = QRY & "And b.Area = 'I' "
            End If
            If CB_Turno.Text.Trim <> "*" Then
                QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY = QRY & "And b.Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Linea.Text <> "*" Then
                QRY = QRY & "And b.Compuesto1 = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            QRY = QRY & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY = QRY & "Union "
            QRY = QRY & "Select Compuesto2 as Compuesto,Porcentaje2 as Porcentaje,"
            QRY = QRY & "replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
            QRY = QRY & "c.Descr,b.Fecha_Pesaje,'Scrap' as TipoProd,b.Hora_Pesaje,b.Usuario,b.Turno,'0' as Tramos,b.Peso_Bruto,b.Tara,"
            QRY = QRY & "b.Peso_Neto,0 as Status_Alm,'0' as Pesonetomerma,((b.Peso_Neto * b.Porcentaje2)/100) as Compuesto,'V' as Tipo "
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
            QRY = QRY & "And b.Notifica  not in  ('9') "
            QRY = QRY & "And c.Codseccion <> '36' "
            If EXTINY = "1" Then
                QRY = QRY & "And b.Area =  'E' "
            Else
                QRY = QRY & "And b.Area = 'I' "
            End If
            If CB_Turno.Text.Trim <> "*" Then
                QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY = QRY & "And b.Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Linea.Text <> "*" Then
                QRY = QRY & "And b.Compuesto2 = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            QRY = QRY & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY = QRY & "Union "
            QRY = QRY & "Select Compuesto1 as Compuesto,Porcentaje1 as Porcentaje,"
            QRY = QRY & "replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
            QRY = QRY & "c.Descr,b.Fecha_Pesaje,'Producto Terminado' as TipoProd,b.Hora_Pesaje,b.Usuario,b.Turno,b.Tramos,b.Peso_Bruto,b.Tara,"
            If EXTINY = "1" Then
                QRY = QRY & "b.Peso_Neto,b.Status_Alm,b.Pesonetomerma,((b.PesoNetoMerma * b.Porcentaje1)/100) as Compuesto,'R' as Tipo "
            Else
                QRY = QRY & "b.Peso_Neto,b.Status_Alm,b.Pesonetomerma,((b.Peso_Neto * b.Porcentaje1)/100) as Compuesto,'R' as Tipo "
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
            QRY = QRY & "And b.Notifica  not in  ('9') "
            QRY = QRY & "And c.Codseccion <> '36' "
            If EXTINY = "1" Then
                QRY = QRY & "And b.Area =  'E' "
            Else
                QRY = QRY & "And b.Area = 'I' "
            End If
            If CB_Turno.Text.Trim <> "*" Then
                QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY = QRY & "And b.Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Linea.Text <> "*" Then
                QRY = QRY & "And b.Compuesto1 = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            QRY = QRY & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY = QRY & "Union "
            QRY = QRY & "Select Compuesto2 as Compuesto,Porcentaje2 as Porcentaje,"
            QRY = QRY & "replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
            QRY = QRY & "c.Descr,b.Fecha_Pesaje,'Producto Terminado' as TipoProd,b.Hora_Pesaje,b.Usuario,b.Turno,b.Tramos,b.Peso_Bruto,b.Tara,"
            If EXTINY = "1" Then
                QRY = QRY & "b.Peso_Neto,b.Status_Alm,b.Pesonetomerma,((b.PesoNetoMerma * b.Porcentaje2)/100) as Compuesto,'R' as Tipo "
            Else
                QRY = QRY & "b.Peso_Neto,b.Status_Alm,b.Pesonetomerma,((b.Peso_Neto * b.Porcentaje2)/100) as Compuesto,'R' as Tipo "
            End If
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
            QRY = QRY & "And b.Notifica  not in  ('9') "
            QRY = QRY & "And c.Codseccion <> '36' "
            If EXTINY = "1" Then
                QRY = QRY & "And b.Area =  'E' "
            Else
                QRY = QRY & "And b.Area = 'I' "
            End If
            If CB_Turno.Text.Trim <> "*" Then
                QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY = QRY & "And b.Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Linea.Text <> "*" Then
                QRY = QRY & "And b.Compuesto2 = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            QRY = QRY & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY = QRY & "Union "
            QRY = QRY & "Select Compuesto1 as Compuesto,Porcentaje1 as Porcentaje,"
            QRY = QRY & "replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
            QRY = QRY & "c.Descr,b.Fecha_Pesaje,'Scrap' as TipoProd,b.Hora_Pesaje,b.Usuario,b.Turno,'0' as Tramos,b.Peso_Bruto,b.Tara,"
            QRY = QRY & "b.Peso_Neto,0 as Status_Alm,'0' as Pesonetomerma,((b.Peso_Neto * b.Porcentaje1)/100) as Compuesto,'R' as Tipo "
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
            QRY = QRY & "And b.Notifica  not in  ('9') "
            QRY = QRY & "And c.Codseccion <> '36' "
            If EXTINY = "1" Then
                QRY = QRY & "And b.Area =  'E' "
            Else
                QRY = QRY & "And b.Area = 'I' "
            End If
            If CB_Turno.Text.Trim <> "*" Then
                QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY = QRY & "And b.Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Linea.Text <> "*" Then
                QRY = QRY & "And b.Compuesto1 = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            QRY = QRY & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY = QRY & "Union "
            QRY = QRY & "Select Compuesto2 as Compuesto,Porcentaje2 as Porcentaje,"
            QRY = QRY & "replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,b.orden_Produccion,a.Producto,"
            QRY = QRY & "c.Descr,b.Fecha_Pesaje,'Scrap' as TipoProd,b.Hora_Pesaje,b.Usuario,b.Turno,'0' as Tramos,b.Peso_Bruto,b.Tara,"
            QRY = QRY & "b.Peso_Neto,0 as Status_Alm,'0' as Pesonetomerma,((b.Peso_Neto * b.Porcentaje2)/100) as Compuesto,'R' as Tipo "
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
            QRY = QRY & "And b.Notifica  not in  ('9') "
            QRY = QRY & "And c.Codseccion <> '36' "
            If EXTINY = "1" Then
                QRY = QRY & "And b.Area =  'E' "
            Else
                QRY = QRY & "And b.Area = 'I' "
            End If
            If CB_Turno.Text.Trim <> "*" Then
                QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
            End If
            If TOrdProd.Text <> "*" Then
                QRY = QRY & "And b.Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
            End If
            If CB_Linea.Text <> "*" Then
                QRY = QRY & "And b.Compuesto2 = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            QRY = QRY & "And (b.Fecha_Pesaje + '' + b.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
            QRY = QRY & "Order by Compuesto"
            LecturaQry(QRY)

            Try
                objDaC = New SqlDataAdapter(QRY, AbrirAmanco)
                objDsC = New DataSet
                objDaC.Fill(objDsC)
                DGV_ConProd.DataSource = objDsC.Tables(0)

            Catch ex As Exception
                MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
            End Try

            DGV_ConProd.Columns(0).HeaderText = "Compuesto"
            DGV_ConProd.Columns(1).HeaderText = "Porcentaje Consumo"
            DGV_ConProd.Columns(2).HeaderText = "Folio"
            DGV_ConProd.Columns(3).HeaderText = "Orden de Producción"
            DGV_ConProd.Columns(4).HeaderText = "Producto"
            DGV_ConProd.Columns(5).HeaderText = "Descripción"
            DGV_ConProd.Columns(6).HeaderText = "Fecha Pesaje"
            DGV_ConProd.Columns(7).HeaderText = ("Tipo Pesaje")
            DGV_ConProd.Columns(8).HeaderText = "Hora Pesaje"
            DGV_ConProd.Columns(9).HeaderText = "Usuario Notifica"
            DGV_ConProd.Columns(10).HeaderText = "Turno"
            DGV_ConProd.Columns(11).HeaderText = "Tramos"
            DGV_ConProd.Columns(12).Visible = False     'Peso Bruto
            DGV_ConProd.Columns(13).Visible = False     'Peso Tara
            DGV_ConProd.Columns(14).Visible = False     'Peso Neto
            DGV_ConProd.Columns(15).Visible = False     'Status Almacen"
            DGV_ConProd.Columns(16).HeaderText = "Peso Neto"
            DGV_ConProd.Columns(17).HeaderText = "Kilos Consumo"
            DGV_ConProd.Columns(18).HeaderText = "Tipo Compuesto"


        End If


        'Se determina la cantidad a fabricar de acuerdo al criterio del filtro de busqueda
        QRY = ""
        QRY = "Select isnull((sum(Cantidad_Programada_Tramos)),0) as Programado "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion "
        QRY = QRY & "Where Orden_Produccion in (Select a.Orden_Produccion "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_PesoProductoTerminado a, " & SessionUser._sCentro.Trim & "_OrdenProduccion b "
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And a.Status_Pesaje = '1' "
        QRY = QRY & "And a.Notifica  not in  ('9') "
        If CB_Linea.Text <> "*" Then
            If RB1.Checked = True Then
                QRY = QRY & "And a.PuestoTrabajo = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            If RB2.Checked = True Then
                QRY = QRY & "And b.Producto = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
            If RB3.Checked = True Then
                QRY = QRY & "And a.Compuesto1 = '" & CB_Linea.SelectedValue.Trim & "' "
                QRY = QRY & "And a.Compuesto2 = '" & CB_Linea.SelectedValue.Trim & "' "
            End If
        End If
        If TOrdProd.Text <> "*" Then
            QRY = QRY & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
        End If
        QRY = QRY & "And (a.Fecha_Pesaje + '' + a.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
        QRY = QRY & "group by a.Orden_Produccion)"

        Try
            objDa = New SqlDataAdapter(QRY, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "Produccion")
        End Try

        LecturaQry(QRY)

        Do While (LecturaBD.Read)
            TCantProgra.Text = LecturaBD(0)
        Loop


        LecturaBD.Close()

        'Se determina el total de producto entregado de acuerdo a las ordenes involucradas en el filtro de busqueda

        QRY = ""
        QRY = "Select isnull((sum(Tramos)),0) as 'Entregados' "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_PesoProductoTerminado "
        QRY = QRY & "Where Orden_Produccion in (Select a.Orden_Produccion "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_PesoProductoTerminado a, " & SessionUser._sCentro.Trim & "_OrdenProduccion b "
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And a.Status_Pesaje = '1' "
        QRY = QRY & "And a.Notifica = '1' "
        If CB_Linea.Text <> "*" Then
            QRY = QRY & "And a.PuestoTrabajo = '" & CB_Linea.SelectedValue.Trim & "' "
        End If
        If TOrdProd.Text <> "*" Then
            QRY = QRY & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
        End If
        QRY = QRY & "And (a.Fecha_Pesaje + '' + a.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
        QRY = QRY & "group by a.Orden_Produccion) "
        QRY = QRY & "And (Fecha_Pesaje + '' + Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
        QRY = QRY & "And Status_Pesaje = '1' "
        QRY = QRY & "And Notifica = '1' "

        Try
            objDa = New SqlDataAdapter(QRY, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "Produccion")
        End Try

        LecturaQry(QRY)

        Do While (LecturaBD.Read)
            TCantEntre.Text = LecturaBD(0)
        Loop

        LecturaBD.Close()

        'Se determina el total de producto en proceso de acuerdo a las ordenes involucradas en el filtro de busqueda

        QRY = ""
        QRY = "Select isnull((sum(b.Tramos)),0) as 'En Proceso' "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b "
        QRY = QRY & "Where a.Orden_Produccion in (Select a.Orden_Produccion "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_PesoProductoTerminado a, " & SessionUser._sCentro.Trim & "_OrdenProduccion b "
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And a.Status_Pesaje = '1' "
        QRY = QRY & "And a.Notifica in ('0', '4', '3') "
        If CB_Linea.Text <> "*" Then
            QRY = QRY & "And a.PuestoTrabajo = '" & CB_Linea.SelectedValue.Trim & "' "
        End If
        If TOrdProd.Text <> "*" Then
            QRY = QRY & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
        End If
        QRY = QRY & "And (a.Fecha_Pesaje + '' + a.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
        QRY = QRY & "group by a.Orden_Produccion) "
        QRY = QRY & "And b.Status_Pesaje = '1' "
        QRY = QRY & "And b.Notifica in ('0', '4', '3') "

        Try
            objDa = New SqlDataAdapter(QRY, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "Produccion")
        End Try

        LecturaQry(QRY)

        Do While (LecturaBD.Read)
            TCantEnproce.Text = LecturaBD(0)
        Loop

        LecturaBD.Close()


        'Se determina el total pendiente de producto de acuerdo a las ordenes involucradas en el filtro de busqueda

        TCantPendiente.Text = Format((Val(TCantProgra.Text) - ((Val(TCantEntre.Text)) + (Val(TCantEnproce.Text)))), "#########.00")

        'Se determina el total del consumo de PT de acuerdo a las ordenes involucradas en el filtro de busqueda

        'QRY = ""
        'QRY = "Select isnull((sum(Peso_Neto)),0) as T_PN,'PT' as 'Todo' "
        'QRY = QRY & "From " & strPlanta.Trim & "_PesoProductoTerminado "
        'QRY = QRY & "Where Orden_Produccion in (Select a.Orden_Produccion "
        'QRY = QRY & "From " & strPlanta.Trim & "_PesoProductoTerminado a, " & strPlanta.Trim & "_OrdenProduccion b "
        'QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        'QRY = QRY & "And a.Status_Pesaje = '1' "
        'QRY = QRY & "And a.Notifica not in ('9') "
        'If CB_Linea.Text <> "*" Then
        '    QRY = QRY & "And a.PuestoTrabajo = '" & CB_Linea.SelectedValue.Trim & "' "
        'End If
        'If TOrdProd.Text <> "*" Then
        '    QRY = QRY & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
        'End If
        'QRY = QRY & "And (Fecha_Pesaje + '' + Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
        'QRY = QRY & "group by a.Orden_Produccion) "
        'QRY = QRY & "And Status_Pesaje = '1' "
        'QRY = QRY & "And Notifica not in ('9') "

        'Try
        '    objDa = New SqlDataAdapter(QRY, AbrirAmanco)
        '    objDs = New DataSet
        '    objDa.Fill(objDs)

        'Catch ex As Exception
        '    MessageBox.Show("Error Conexion :" & ex.Message, "Produccion")
        'End Try

        'LecturaQry(QRY)

        'Do While (LecturaBD.Read)
        '    TCPt.Text = LecturaBD(0)
        'Loop

        'LecturaBD.Close()

        ''Se determina el total del consumo de Scrap de acuerdo a las ordenes involucradas en el filtro de busqueda

        'QRY = ""
        'QRY = "Select isnull((sum(Peso_Neto)),0) as T_PN,'SC' as 'Todo' "
        'QRY = QRY & "From " & strPlanta.Trim & "_PesoScrap "
        'QRY = QRY & "Where Orden_Produccion in (Select a.Orden_Produccion "
        'QRY = QRY & "From " & strPlanta.Trim & "_PesoScrap a, " & strPlanta.Trim & "_OrdenProduccion b "
        'QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        'QRY = QRY & "And a.Status_Pesaje = '1' "
        'QRY = QRY & "And a.Notifica not in ('9') "
        'If CB_Linea.Text <> "*" Then
        '    QRY = QRY & "And a.PuestoTrabajo = '" & CB_Linea.SelectedValue.Trim & "' "
        'End If
        'If TOrdProd.Text <> "*" Then
        '    QRY = QRY & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
        'End If
        'QRY = QRY & "And (a.Fecha_Pesaje + '' + a.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
        'QRY = QRY & "group by a.Orden_Produccion) "
        'QRY = QRY & "And Status_Pesaje = '1' "
        'QRY = QRY & "And Notifica not in ('9') "

        'Try
        '    objDa = New SqlDataAdapter(QRY, AbrirAmanco)
        '    objDs = New DataSet
        '    objDa.Fill(objDs)

        'Catch ex As Exception
        '    MessageBox.Show("Error Conexion :" & ex.Message, "Produccion")
        'End Try

        'LecturaQry(QRY)

        'Do While (LecturaBD.Read)
        '    TCScrap.Text = LecturaBD(0)
        'Loop

        'LecturaBD.Close()

        ''Se determina el total del consumo de Scrap Recuperable de acuerdo a las ordenes involucradas en el filtro de busqueda

        'QRY = ""
        'QRY = "Select isnull((sum(Peso_Neto)),0) as T_PN,'SC' as 'Todo' "
        'QRY = QRY & "From " & strPlanta.Trim & "_PesoScrap "
        'QRY = QRY & "Where Orden_Produccion in (Select a.Orden_Produccion "
        'QRY = QRY & "From " & strPlanta.Trim & "_PesoScrap a, " & strPlanta.Trim & "_OrdenProduccion b "
        'QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        'QRY = QRY & "And a.Status_Pesaje = '1' "
        'QRY = QRY & "And a.Notifica not in ('9') "
        'If CB_Linea.Text <> "*" Then
        '    QRY = QRY & "And a.PuestoTrabajo = '" & CB_Linea.SelectedValue.Trim & "' "
        'End If
        'If TOrdProd.Text <> "*" Then
        '    QRY = QRY & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
        'End If
        'QRY = QRY & "And (a.Fecha_Pesaje + '' + a.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
        'QRY = QRY & "group by a.Orden_Produccion) "
        'QRY = QRY & "And Status_Pesaje = '1' "
        'QRY = QRY & "And Tipo_Scrap = 'T' "
        'QRY = QRY & "And Notifica not in ('9') "

        'Try
        '    objDa = New SqlDataAdapter(QRY, AbrirAmanco)
        '    objDs = New DataSet
        '    objDa.Fill(objDs)

        'Catch ex As Exception
        '    MessageBox.Show("Error Conexion :" & ex.Message, "Produccion")
        'End Try

        'LecturaQry(QRY)

        'Do While (LecturaBD.Read)
        '    TSC_R.Text = LecturaBD(0)
        'Loop

        'LecturaBD.Close()

        ''Se determina el total del consumo de Scrap Basura de acuerdo a las ordenes involucradas en el filtro de busqueda

        'QRY = ""
        'QRY = "Select isnull((sum(Peso_Neto)),0) as T_PN,'SC' as 'Todo' "
        'QRY = QRY & "From " & strPlanta.Trim & "_PesoScrap "
        'QRY = QRY & "Where Orden_Produccion in (Select a.Orden_Produccion "
        'QRY = QRY & "From " & strPlanta.Trim & "_PesoScrap a, " & strPlanta.Trim & "_OrdenProduccion b "
        'QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        'QRY = QRY & "And a.Status_Pesaje = '1' "
        'QRY = QRY & "And a.Notifica not in ('9') "
        'If CB_Linea.Text <> "*" Then
        '    QRY = QRY & "And a.PuestoTrabajo = '" & CB_Linea.SelectedValue.Trim & "' "
        'End If
        'If TOrdProd.Text <> "*" Then
        '    QRY = QRY & "And a.orden_produccion = '" & TOrdProd.Text.Trim & "' "
        'End If
        'QRY = QRY & "And (a.Fecha_Pesaje + '' + a.Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "
        'QRY = QRY & "group by a.Orden_Produccion) "
        'QRY = QRY & "And Status_Pesaje = '1' "
        'QRY = QRY & "And Tipo_Scrap = 'G' "
        'QRY = QRY & "And Notifica not in ('9') "

        'Try
        '    objDa = New SqlDataAdapter(QRY, AbrirAmanco)
        '    objDs = New DataSet
        '    objDa.Fill(objDs)

        'Catch ex As Exception
        '    MessageBox.Show("Error Conexion :" & ex.Message, "Produccion")
        'End Try

        'LecturaQry(QRY)

        'Do While (LecturaBD.Read)
        '    TSC_B.Text = LecturaBD(0)
        'Loop

        'LecturaBD.Close()

        ''Se determina el total de compuesto consumido de acuerdo a las ordenes involucradas en el filtro de busqueda

        'GTC.Text = Format(Val(TCPt.Text) + (Val(TCScrap.Text)), "#########.00")

        ''Se determina el total de producto fabricado de acuerdo al filtro de busqueda

        'QRY = ""
        'QRY = "Select isnull((sum(tramos)),0) as Tramos, isnull((sum(PesoNetoMerma)),0) as Peso,"
        'QRY = QRY & "IsNull(((sum(PesoNetoMerma))/(sum(tramos))),0) as PesoPromedio "
        'QRY = QRY & "From " & strPlanta.Trim & "_PesoProductoTerminado "
        'QRY = QRY & "Where Status_Pesaje = '1' "
        'QRY = QRY & "And Notifica  not in ('9') "
        'If CB_Linea.Text <> "*" Then
        '    QRY = QRY & "And PuestoTrabajo = '" & CB_Linea.SelectedValue.Trim & "' "
        'End If
        'If TOrdProd.Text <> "*" Then
        '    QRY = QRY & "And orden_produccion = '" & TOrdProd.Text.Trim & "' "
        'End If
        'If CB_Turno.Text <> "*" Then
        '    QRY = QRY & "And Turno = '" & CB_Turno.SelectedValue & "' "
        'End If
        'QRY = QRY & "And (Fecha_Pesaje + '' + Hora_Pesaje) Between '" & Str_FI.Trim & "' + '" & HI.Trim & "'  and '" & Str_FF.Trim & "' + '" & HF.Trim & "' "

        'Try
        '    objDa = New SqlDataAdapter(QRY, AbrirAmanco)
        '    objDs = New DataSet
        '    objDa.Fill(objDs)

        'Catch ex As Exception
        '    MessageBox.Show("Error Conexion :" & ex.Message, "Produccion")
        'End Try

        'LecturaQry(QRY)

        'Do While (LecturaBD.Read)
        '    TTC.Text = LecturaBD(0)
        '    TPTPU.Text = LecturaBD(2)
        'Loop

        'LecturaBD.Close()



    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub FrmProduccion_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FIP = DTP_FI.Value.ToString("yyyy-MM-dd")
        FFP = DTP_FF.Value.ToString("yyyy-MM-dd")
        LimpiarCheckBox(Me)
        LimpiarText(Me)
        FillCBTurno()
        CB_Linea.Text = "*"
        CB_Turno.Text = "*"
        TOrdProd.Text = "*"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        Grid_Load()
        Timer1.Enabled = True
    End Sub

    Private Sub DGV_ConProd_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV_ConProd.CellFormatting

        If RB1.Checked = True Then
            TP_Cell = (DGV_ConProd.Rows(e.RowIndex).Cells(7).Value)
            Almacen = (DGV_ConProd.Rows(e.RowIndex).Cells(15).Value)

            If TP_Cell.Trim = "Producto Terminado" Then
                If Almacen = True Then
                    e.CellStyle.BackColor = Color.LimeGreen
                    e.CellStyle.ForeColor = Color.Black
                Else
                    e.CellStyle.BackColor = Color.MediumAquamarine
                    e.CellStyle.ForeColor = Color.Black
                End If
            ElseIf TP_Cell.Trim = "Scrap Recuperado" Then
                e.CellStyle.BackColor = Color.LightCoral
                e.CellStyle.ForeColor = Color.Black
            ElseIf TP_Cell.Trim = "Scrap Basura" Then
                e.CellStyle.BackColor = Color.Red
                e.CellStyle.ForeColor = Color.Black
            End If
        End If

        If RB2.Checked = True Then
            TP_Cell = (DGV_ConProd.Rows(e.RowIndex).Cells(7).Value)
            Almacen = (DGV_ConProd.Rows(e.RowIndex).Cells(15).Value)

            If TP_Cell.Trim = "Producto Terminado" Then
                If Almacen = True Then
                    e.CellStyle.BackColor = Color.LimeGreen
                    e.CellStyle.ForeColor = Color.Black
                Else
                    e.CellStyle.BackColor = Color.MediumAquamarine
                    e.CellStyle.ForeColor = Color.Black
                End If
            ElseIf TP_Cell.Trim = "Scrap Recuperado" Then
                e.CellStyle.BackColor = Color.LightCoral
                e.CellStyle.ForeColor = Color.Black
            ElseIf TP_Cell.Trim = "Scrap Basura" Then
                e.CellStyle.BackColor = Color.Red
                e.CellStyle.ForeColor = Color.Black
            End If
        End If

        If RB3.Checked = True Then
            TP_Cell = (DGV_ConProd.Rows(e.RowIndex).Cells(7).Value)
            Almacen = (DGV_ConProd.Rows(e.RowIndex).Cells(15).Value)

            If TP_Cell.Trim = "Producto Terminado" Then
                If Almacen = True Then
                    e.CellStyle.BackColor = Color.LimeGreen
                    e.CellStyle.ForeColor = Color.Black
                Else
                    e.CellStyle.BackColor = Color.MediumAquamarine
                    e.CellStyle.ForeColor = Color.Black
                End If
            ElseIf TP_Cell.Trim = "Scrap" Then
                e.CellStyle.BackColor = Color.LightCoral
                e.CellStyle.ForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Grid_Load()
    End Sub

    Private Sub FrmProduccion_AMEX_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        EXTINY = ""
        Timer1.Enabled = False
    End Sub

    Private Sub BExpExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExpExcel.Click
        Export_Excel(DGV_ConProd)
    End Sub

    Private Sub RB1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1.CheckedChanged
        If RB1.Checked = True Then
            Label1.Text = "Puesto de Trabajo"
            FillCBLinea()
        End If
    End Sub

    Private Sub RB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB2.CheckedChanged
        If RB2.Checked = True Then
            Label1.Text = "Producto Terminado"
            FillCBMaterial()
        End If
    End Sub

    Private Sub RB3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB3.CheckedChanged
        If RB3.Checked = True Then
            Label1.Text = "Compuesto"
            FillCBComp()
        End If
    End Sub

    Private Sub RB4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB4.CheckedChanged
        If RB1.Checked = True Then
            Label1.Text = "Puesto de Trabajo"
            FillCBLinea()
            CB_Linea.Text = "*"
        End If
        If RB2.Checked = True Then
            Label1.Text = "Producto Terminado"
            FillCBMaterial()
            CB_Linea.Text = "*"
        End If
        If RB3.Checked = True Then
            Label1.Text = "Compuesto"
            FillCBComp()
            CB_Linea.Text = "*"
        End If
    End Sub

    Private Sub RB5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB5.CheckedChanged
        If RB1.Checked = True Then
            Label1.Text = "Puesto de Trabajo"
            FillCBLinea()
            CB_Linea.Text = "*"
        End If
        If RB2.Checked = True Then
            Label1.Text = "Producto Terminado"
            FillCBMaterial()
            CB_Linea.Text = "*"
        End If
        If RB3.Checked = True Then
            Label1.Text = "Compuesto"
            FillCBComp()
            CB_Linea.Text = "*"
        End If
    End Sub

    Private Sub RB6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RB1.Checked = True Then
            Label1.Text = "Puesto de Trabajo"
            FillCBLinea()
            CB_Linea.Text = "*"
        End If
        If RB2.Checked = True Then
            Label1.Text = "Producto Terminado"
            FillCBMaterial()
            CB_Linea.Text = "*"
        End If
        If RB3.Checked = True Then
            Label1.Text = "Compuesto"
            FillCBComp()
            CB_Linea.Text = "*"
        End If
    End Sub
End Class