Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmModificaPT
    Dim Str_FI As String        'Fecha inicio consulta
    Dim Str_FF As String        'Fecha fin consulta
    Dim N_Folio As String       'Numero de Folio
    Dim N_Ord As String         'Numero de Orden de Producción
    Dim N_Tramos As String
    Dim N_Prod As String        'Numero de producto
    Dim N_FecPesaje As String
    Dim N_PB As String
    Dim N_PT As String
    Dim N_PN As String
    Dim N_PNM As String
    Dim N_CC1 As String
    Dim N_PC1 As String
    Dim N_ConC1 As String
    Dim N_CC2 As String
    Dim N_PC2 As String
    Dim N_ConC2 As String
    Dim N_Bas As String
    Dim N_Rack As String
    Dim N_UsrReg As String
    Dim N_Turno As String
    Dim N_DocSAP As String
    Dim N_ConSAP As String
    Dim N_PS As String
    Dim N_PtoT As String

    'Variables para determinar compuesto
    Dim CompOriginal As String = ""
    Dim Compuesto_1 As String = ""
    Dim Compuesto_2 As String = ""
    Dim CompuestoPorcent_1 As Integer = 0
    Dim CompuestoPorcent_2 As Integer = 0
    Dim ValControlCompuesto As String
    Dim Lt_Compuestos As String = ""
    Dim CodEmpaque As String

    'Variables para los totales por consulta
    Dim Ttramos As String
    Dim Tpb As String
    Dim Tpt As String
    Dim Tpn As String
    Dim Tpnm As String
    Dim TPC1_V As Decimal
    Dim TPC2_V As Decimal
    Dim TPC1_R As Decimal
    Dim TPC2_R As Decimal
    Dim Cont As Integer

    Dim Q As String

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

    Private Sub DGV_BP_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_BP.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV_BP.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                N_Folio = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(0).Value.ToString
                N_Ord = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(1).Value.ToString
                N_Tramos = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(2).Value.ToString
                N_Prod = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(3).Value.ToString
                N_FecPesaje = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(4).Value.ToString
                N_PB = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(5).Value.ToString
                N_PT = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(6).Value.ToString
                N_PN = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(7).Value.ToString
                N_PNM = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(8).Value.ToString
                N_CC1 = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(9).Value.ToString
                N_PC1 = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(10).Value.ToString
                N_ConC1 = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(11).Value.ToString
                N_CC2 = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(12).Value.ToString
                N_PC2 = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(13).Value.ToString
                N_ConC2 = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(14).Value.ToString
                N_Bas = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(15).Value.ToString
                N_Rack = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(16).Value.ToString
                N_UsrReg = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(17).Value.ToString
                N_Turno = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(18).Value.ToString
                N_DocSAP = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(19).Value.ToString
                N_ConSAP = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(20).Value.ToString
                N_PS = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(21).Value.ToString
                N_PtoT = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(22).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            TFolioAtlas.Text = N_Folio
            TOrden.Text = N_Ord
            TtramosNoti.Text = N_Tramos
            TPesoBruto.Text = N_PB
            TPesoRack.Text = N_PT
            TPesoNeto.Text = N_PN
            TPEmp.Text = FormatNumber(((N_PB - N_PT) - N_PN), 2)
            TPesoNetoMerma.Text = N_PNM
            TComp1.Text = N_CC1
            TPComp1.Text = N_PC1
            TKC1.Text = N_ConC1
            TComp2.Text = N_CC2
            TPComp2.Text = N_PC2
            TKC2.Text = N_ConC2
            TcodPt.Text = N_Prod
            tsbGrabar.Enabled = False

            BloqueaText(Me)
            BloqueaButton(Me)

        End If
    End Sub

    Public Sub Grid_Load()

        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim

        QRY_Grid = ""
        NameTable = ""
        NameTable = "ProductoTerminado"
        QRY_Grid = "Select b.Folio,a.orden_produccion,b.Tramos,a.Producto,b.Fecha_Pesaje,b.Peso_Bruto,b.Tara,b.Peso_Neto,"
        QRY_Grid = QRY_Grid & "b.PesoNetoMerma,b.Compuesto1,b.Porcentaje1,((b.PesoNetoMerma * b.Porcentaje1)/100) as Consumo1,"
        QRY_Grid = QRY_Grid & "b.Compuesto2,b.Porcentaje2,((b.PesoNetoMerma * b.Porcentaje2)/100) as Consumo2,b.Bascula,b.Rack,"
        QRY_Grid = QRY_Grid & "b.Usuario,b.Turno,b.Documento_SAP,b.Consecutivo_SAP,b.Sobrepeso,"
        QRY_Grid = QRY_Grid & "b.PuestoTrabajo "
        QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
        QRY_Grid = QRY_Grid & "CAT_ProductoTerminado c "
        QRY_Grid = QRY_Grid & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY_Grid = QRY_Grid & "And a.Producto = c.Codigo "
        QRY_Grid = QRY_Grid & "And a.Planta = c.Centro "
        If TOrd.Text.Trim <> "*" Then
            QRY_Grid = QRY_Grid & "And b.Orden_Produccion = '" & TOrd.Text.Trim & "' "
        End If
        If TFol.Text.Trim <> "*" Then
            QRY_Grid = QRY_Grid & "And b.Folio = '" & TFol.Text.Trim & "' "
        End If
        If CB_Turno.Text <> "*" Then
            QRY_Grid = QRY_Grid & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
        End If
        QRY_Grid = QRY_Grid & "And b.Notifica Not IN ('9') "
        QRY_Grid = QRY_Grid & "And b.Status_Pesaje = '1' "
        QRY_Grid = QRY_Grid & "And b.Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "
        QRY_Grid = QRY_Grid & "Order by b.Folio"

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGV_BP.DataSource = objDs.Tables(0)

            DGV_BP.Columns(0).HeaderText = "Folio"                  'Numero de Folio
            DGV_BP.Columns(1).HeaderText = "Orden de Producción"    'Numero de Orden de Produccion
            DGV_BP.Columns(2).HeaderText = "Tramos"                 'Cantidad de Tramos
            DGV_BP.Columns(3).HeaderText = "Producto"               'Codigo del producto
            DGV_BP.Columns(4).HeaderText = "Fecha Pesaje"           'Fecha del Pesaje
            DGV_BP.Columns(5).HeaderText = "Peso Bruto"             'Peso Bruto
            DGV_BP.Columns(6).HeaderText = "Peso Tara"              'Peso Tara
            DGV_BP.Columns(7).HeaderText = "Peso Neto"              'Peso Neto
            DGV_BP.Columns(8).HeaderText = "Peso Neto + Merma"      'Peso Neto + Merma
            DGV_BP.Columns(9).HeaderText = "Compuesto 1"            'Codigo compuesto 1
            DGV_BP.Columns(10).HeaderText = "Porcentaje 1"          'Porcentaje consumo compuesto 1
            DGV_BP.Columns(11).HeaderText = "Consumo en kilos"      'Consumo compuesto 1
            DGV_BP.Columns(12).HeaderText = "Compuesto 2"           'Codigo compuesto 2
            DGV_BP.Columns(13).HeaderText = "Porcentaje 2"          'Porcentaje consumo compuesto 2
            DGV_BP.Columns(14).HeaderText = "Consumo en kilos"      'Consumo compuesto 2
            DGV_BP.Columns(15).HeaderText = "Bascula"               'Numero de bascula
            DGV_BP.Columns(16).HeaderText = "Num. Rack"             'Numero de rack utilizado
            DGV_BP.Columns(17).HeaderText = "Usuario"               'Usuario que registra
            DGV_BP.Columns(18).HeaderText = "Turno"                 'Turno en el que se ingresa la notificacion
            DGV_BP.Columns(19).HeaderText = "Documento SAP"         'Num. Documento SAP
            DGV_BP.Columns(20).HeaderText = "Consecutivo SAP"       'Num. Consecutivo SAP
            DGV_BP.Columns(21).HeaderText = "Sobre Peso"            'Porcentaje Sobre Peso
            DGV_BP.Columns(22).HeaderText = "Puesto de Trabajo"     'Puesto de trabajo


        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try



        'Proceso para determinar totales de tramos, peso bruto, peso tara, peso neto, y peso neto mas merma de acuerdo a la consulta
        QRY = ""
        QRY = "Select IsNull(sum(b.Tramos),0) as Tramos,IsNull(sum(b.Peso_Bruto),0) as Peso_Bruto,"
        QRY = QRY & "IsNull(sum(b.Tara),0)as Peso_Tara,IsNull(sum(b.Peso_Neto),0) as Peso_Neto,"
        QRY = QRY & "IsNull(sum(b.PesoNetoMerma),0) as Peso_Neto_Merma "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
        If EXTINY = "1" Then
            QRY = QRY & "ProductoTerminadoExtrusion c "
        Else
            QRY = QRY & "ProductoTerminadoInyeccion c "
        End If
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And a.Producto = c.Codigo "
        QRY = QRY & "And a.Planta = c.Centro "
        If TOrd.Text.Trim <> "*" Then
            QRY = QRY & "And b.Orden_Produccion = '" & TOrd.Text.Trim & "' "
        End If
        If CB_Turno.Text <> "*" Then
            QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
        End If
        If TFol.Text.Trim <> "*" Then
            QRY = QRY & "And b.Folio = '" & TFol.Text.Trim & "' "
        End If
        QRY = QRY & "And b.Notifica Not IN ('9', '1') "
        QRY = QRY & "And b.Status_Pesaje = '1' "
        QRY = QRY & "And b.Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "
        LecturaQry(QRY)

        Do While (LecturaBD.Read())
            Ttramos = LecturaBD(0)
            Tpb = LecturaBD(1)
            Tpt = LecturaBD(2)
            Tpn = LecturaBD(3)
            Tpnm = LecturaBD(4)
        Loop

        LecturaBD.Close()


        'Proceso para determinar totales de compuesto virgen de acuerdo a la consulta
        QRY = ""
        QRY = "Select IsNull(Sum(((b.PesoNetoMerma * b.Porcentaje1)/100)),0) as CV1 "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
        If EXTINY = "1" Then
            QRY = QRY & "ProductoTerminadoExtrusion c, "
            QRY = QRY & "CompuestoExtrusion d "
        Else
            QRY = QRY & "ProductoTerminadoInyeccion c, "
            QRY = QRY & "CompuestoInyeccion d "
        End If
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And a.Producto = c.Codigo "
        QRY = QRY & "And a.Planta = c.Centro "
        If EXTINY = "1" Then
            QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
            QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
            QRY = QRY & "And b.Compuesto1 = d.ComExt_ComCodigo "
        Else
            QRY = QRY & "And a.Planta = d.Centro "
            QRY = QRY & "And a.Producto = d.CodPTI "
            QRY = QRY & "And b.Compuesto1 = d.CodComp "
        End If
        If TOrd.Text.Trim <> "*" Then
            QRY = QRY & "And b.Orden_Produccion = '" & TOrd.Text.Trim & "' "
        End If
        If CB_Turno.Text <> "*" Then
            QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
        End If
        If TFol.Text.Trim <> "*" Then
            QRY = QRY & "And b.Folio = '" & TFol.Text.Trim & "' "
        End If
        If EXTINY = "1" Then
            QRY = QRY & "And d.ComExt_ComClase = '1' "
        Else
            QRY = QRY & "And d.Clase = '1' "
        End If
        QRY = QRY & "And b.Notifica Not IN ('9', '1') "
        QRY = QRY & "And b.Status_Pesaje = '1' "
        QRY = QRY & "And b.Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "
        LecturaQry(QRY)

        Do While (LecturaBD.Read())
            TPC1_V = LecturaBD(0)
        Loop

        LecturaBD.Close()

        QRY = ""
        QRY = "Select IsNull(sum(((b.PesoNetoMerma * b.Porcentaje2)/100)),0) as CV2 "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
        If EXTINY = "1" Then
            QRY = QRY & "ProductoTerminadoExtrusion c, "
            QRY = QRY & "CompuestoExtrusion d "
        Else
            QRY = QRY & "ProductoTerminadoInyeccion c, "
            QRY = QRY & "CompuestoInyeccion d "
        End If
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And a.Producto = c.Codigo "
        QRY = QRY & "And a.Planta = c.Centro "
        If EXTINY = "1" Then
            QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
            QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
            QRY = QRY & "And b.Compuesto2 = d.ComExt_ComCodigo "
        Else
            QRY = QRY & "And a.Planta = d.Centro "
            QRY = QRY & "And a.Producto = d.CodPTI "
            QRY = QRY & "And b.Compuesto2 = d.CodComp "
        End If
        If TOrd.Text.Trim <> "*" Then
            QRY = QRY & "And b.Orden_Produccion = '" & TOrd.Text.Trim & "' "
        End If
        If CB_Turno.Text <> "*" Then
            QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
        End If
        If TFol.Text.Trim <> "*" Then
            QRY = QRY & "And b.Folio = '" & TFol.Text.Trim & "' "
        End If
        If EXTINY = "1" Then
            QRY = QRY & "And d.ComExt_ComClase = '1' "
        Else
            QRY = QRY & "And d.Clase = '1' "
        End If
        QRY = QRY & "And b.Notifica Not IN ('9', '1') "
        QRY = QRY & "And b.Status_Pesaje = '1' "
        QRY = QRY & "And b.Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "
        LecturaQry(QRY)

        Do While (LecturaBD.Read())
            TPC2_V = LecturaBD(0)
        Loop

        LecturaBD.Close()

        'Proceso para determinar totales de compuesto recuperado de acuerdo a la consulta
        QRY = ""
        QRY = "Select IsNull(Sum(((b.PesoNetoMerma * b.Porcentaje1)/100)),0) as CR1 "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
        If EXTINY = "1" Then
            QRY = QRY & "ProductoTerminadoExtrusion c, "
            QRY = QRY & "CompuestoExtrusion d "
        Else
            QRY = QRY & "ProductoTerminadoInyeccion c, "
            QRY = QRY & "CompuestoInyeccion d "
        End If
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And a.Producto = c.Codigo "
        QRY = QRY & "And a.Planta = c.Centro "
        If EXTINY = "1" Then
            QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
            QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
            QRY = QRY & "And b.Compuesto1 = d.ComExt_ComCodigo "
        Else
            QRY = QRY & "And a.Planta = d.Centro "
            QRY = QRY & "And a.Producto = d.CodPTI "
            QRY = QRY & "And b.Compuesto1 = d.CodComp "
        End If
        If TOrd.Text.Trim <> "*" Then
            QRY = QRY & "And b.Orden_Produccion = '" & TOrd.Text.Trim & "' "
        End If
        If CB_Turno.Text <> "*" Then
            QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
        End If
        If TFol.Text.Trim <> "*" Then
            QRY = QRY & "And b.Folio = '" & TFol.Text.Trim & "' "
        End If
        If EXTINY = "1" Then
            QRY = QRY & "And d.ComExt_ComClase = '2' "
        Else
            QRY = QRY & "And d.Clase = '2' "
        End If
        QRY = QRY & "And b.Notifica Not IN ('9', '1') "
        QRY = QRY & "And b.Status_Pesaje = '1' "
        QRY = QRY & "And b.Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "
        LecturaQry(QRY)

        Do While (LecturaBD.Read())
            TPC1_R = LecturaBD(0)
        Loop

        LecturaBD.Close()

        QRY = ""
        QRY = "Select IsNull(Sum(((b.PesoNetoMerma * b.Porcentaje2)/100)),0) as CR2 "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
        If EXTINY = "1" Then
            QRY = QRY & "ProductoTerminadoExtrusion c, "
            QRY = QRY & "CompuestoExtrusion d "
        Else
            QRY = QRY & "ProductoTerminadoInyeccion c, "
            QRY = QRY & "CompuestoInyeccion d "
        End If
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And a.Producto = c.Codigo "
        QRY = QRY & "And a.Planta = c.Centro "
        If EXTINY = "1" Then
            QRY = QRY & "And a.Planta = d.ComExt_PT_Centro "
            QRY = QRY & "And a.Producto = d.ComExt_PT_Codigo "
            QRY = QRY & "And b.Compuesto2 = d.ComExt_ComCodigo "
        Else
            QRY = QRY & "And a.Planta = d.Centro "
            QRY = QRY & "And a.Producto = d.CodPTI "
            QRY = QRY & "And b.Compuesto2 = d.CodComp "
        End If
        If TOrd.Text.Trim <> "*" Then
            QRY = QRY & "And b.Orden_Produccion = '" & TOrd.Text.Trim & "' "
        End If
        If CB_Turno.Text <> "*" Then
            QRY = QRY & "And b.Turno = '" & CB_Turno.SelectedValue & "' "
        End If
        If TFol.Text.Trim <> "*" Then
            QRY = QRY & "And b.Folio = '" & TFol.Text.Trim & "' "
        End If
        If EXTINY = "1" Then
            QRY = QRY & "And d.ComExt_ComClase = '2' "
        Else
            QRY = QRY & "And d.Clase = '2' "
        End If
        QRY = QRY & "And b.Notifica Not IN ('9', '1') "
        QRY = QRY & "And b.Status_Pesaje = '1' "
        QRY = QRY & "And b.Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "
        LecturaQry(QRY)

        Do While (LecturaBD.Read())
            TPC2_R = LecturaBD(0)
        Loop

        LecturaBD.Close()


        TTTramos.Text = FormatNumber((Ttramos), 0)
        TTPB.Text = FormatNumber((Tpb), 2)
        TTPT.Text = FormatNumber((Tpt), 2)
        TTPN.Text = FormatNumber((Tpn), 2)
        TTPNM.Text = FormatNumber((Tpnm), 3)
        TTC1.Text = FormatNumber((TPC1_V + TPC2_V), 3)
        TTC2.Text = FormatNumber((TPC1_R + TPC2_R), 3)

    End Sub

    Private Sub FrmModPT_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        If EXTINY = "1" Then
            Me.Text = "Modificación de Pesaje en Proceso Producto Terminado Extrusión"
        Else
            Me.Text = "Modificación de Pesaje en Proceso Producto Terminado Inyección"
        End If
        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim
        LimpiarText(Me)
        BloqueaText(Me)
        BloqueaButton(Me)
        tsbGrabar.Enabled = False
        PBActualiza.Visible = False
        TKC1.Enabled = False
        TKC2.Enabled = False
        TOrd.Enabled = True
        TFol.Enabled = True
        StrProducto = ""
        FillCBTurno()
        CB_Turno.Text = "*"
        Grid_Load()
    End Sub



    Private Sub FrmModPT_AMEX_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        EXTINY = ""
    End Sub

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        Grid_Load()
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Close()
    End Sub

    Private Sub TComp1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TComp1.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TComp2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TComp2.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TPComp1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TPComp1.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TPComp2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TPComp2.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click
        ActivaButton(Me)
        tsbGrabar.Enabled = True
    End Sub

    Private Sub TPComp1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPComp1.TextChanged
        If TPComp1.Text.Trim > 0 Or TPComp1.Text.Trim <> "" Then
            TKC1.Text = FormatNumber(((TPesoNetoMerma.Text * TPComp1.Text) / 100), 3)
        End If
    End Sub

    Private Sub TPComp2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPComp2.TextChanged
        If TPComp2.Text.Trim > 0 Or TPComp2.Text.Trim <> "" Then
            TKC2.Text = FormatNumber(((TPesoNetoMerma.Text * TPComp2.Text) / 100), 3)
        End If
    End Sub

    Private Sub BCompuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCompuesto.Click
        If EXTINY = "1" Then
            StrProces = "Est"
        Else
            StrProces = "Iny"
        End If

        StrProducto = TcodPt.Text.Trim
        FormConfigurarCompuesto_AMEX.CB1.Checked = False
        FormConfigurarCompuesto_AMEX.CB2.Checked = False
        FormConfigurarCompuesto_AMEX.CB3.Checked = False
        FormConfigurarCompuesto_AMEX.ShowDialog()

        '--- ----------- --------- ------- Inicio : Variables de Configuración Compuesto
        Dim Count As Integer = 0

        If EXTINY = "1" Then
            QRY = ""
            QRY = "select b.ComExt_ComCodigo from productoterminadoextrusion a, CompuestoExtrusion b "
            QRY = QRY & "where a.centro = b.ComExt_PT_Centro "
            QRY = QRY & "and a.codigo = b.ComExt_PT_Codigo "
            QRY = QRY & "and a.centro = '" & SessionUser._sCentro.Trim & "' "
            QRY = QRY & "and a.codigo = '" & TcodPt.Text.Trim & "' "
            QRY = QRY & "and b.bom = '1' "
            LecturaQry(QRY)
            Do While (LecturaBD.Read())
                Count = Count + 1
                CompOriginal = LecturaBD(0)
            Loop
            LecturaBD.Close()
        Else
            QRY = ""
            QRY = "select b.CodComp from productoterminadoInyeccion a, CompuestoInyeccion b "
            QRY = QRY & "where a.centro = b.Centro "
            QRY = QRY & "and a.codigo = b.CodPTI "
            QRY = QRY & "and a.centro = '" & SessionUser._sCentro.Trim & "' "
            QRY = QRY & "and a.codigo = '" & TcodPt.Text.Trim & "' "
            QRY = QRY & "and b.bom = '1' "
            LecturaQry(QRY)
            Do While (LecturaBD.Read())
                Count = Count + 1
                CompOriginal = LecturaBD(0)
            Loop
            LecturaBD.Close()
        End If


        ' ---------------------------------------------------------------------------------
        If Count = 0 Then
            MessageBox.Show(" No Existe compuesto definido como parte de la Bom para este Producto no se puede notificar esta orden ", " VENTANA DE ERROR * * * ")
            Return
        End If

        '                 ----- Reproceso -----
        'ValPublic_ReproConsumo
        If ValPublic_ReproConsumo.Trim.Length > 0 Then
            Compuesto_1 = ValPublic_ReproConsumo.Trim
            CompuestoPorcent_1 = 100
            Compuesto_2 = "0"
            CompuestoPorcent_2 = 0

            Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1

        End If

        '                 ----- Virgen -----
        'ValPublic_CompuestoVirgen()
        If ValPublic_CompuestoVirgen.Trim.Length > 0 Then
            Compuesto_1 = ValPublic_CompuestoVirgen.Trim
            CompuestoPorcent_1 = 100
            Compuesto_2 = "0"
            CompuestoPorcent_2 = 0

            If Compuesto_1 <> CompOriginal.Trim Then

                Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1

            Else

                Lt_Compuestos = ""

            End If

        End If

        '             ----- Mezcla de Compuestos -----
        If ValPublic_Ccompuesto1.Trim.Length > 0 And ValPublic_Ccompuesto2.Trim.Length > 0 Then
            'ValPublic_Ccompuesto1
            'ValPublic_PorcentajeCom1
            Compuesto_1 = ValPublic_Ccompuesto1.Trim
            CompuestoPorcent_1 = ValPublic_PorcentajeCom1

            'ValPublic_Ccompuesto2
            'ValPublic_PorcentajeCom2
            Compuesto_2 = ValPublic_Ccompuesto2.Trim
            CompuestoPorcent_2 = ValPublic_PorcentajeCom2

            Lt_Compuestos = CompOriginal.Trim + "|" + CompuestoPorcent_1.ToString + "|" + Compuesto_1 + "||" + CompOriginal.Trim + "|" + CompuestoPorcent_2.ToString + "|" + Compuesto_2

        End If
        '--- ----------- --------- ------- Fin : Variables de Configuración Compuesto


        TComp1.Text = Compuesto_1
        TComp2.Text = Compuesto_2
        TPComp1.Text = CompuestoPorcent_1
        TPComp2.Text = CompuestoPorcent_2

    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click

        PBActualiza.Visible = True

        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BackgroundWorker1.ReportProgress(25)

        System.Threading.Thread.Sleep(2000) ' Para simular tiempo de espera

        BackgroundWorker1.ReportProgress(50)

        BloqueaText(Me)
        BloqueaButton(Me)

        BackgroundWorker1.ReportProgress(75)

        InQry = ""
        InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado "
        InQry = InQry & "set Compuesto1 = '" & TComp1.Text.Trim & "', "
        InQry = InQry & "Porcentaje1 = " & TPComp1.Text & ", "
        InQry = InQry & "Compuesto2 =  '" & TComp2.Text.Trim & "', "
        InQry = InQry & "Porcentaje2 =  " & TPComp2.Text & ", "
        InQry = InQry & "LTCompuestos =  '" & Lt_Compuestos.Trim & "' "
        InQry = InQry & " Where Orden_Produccion = '" & TOrden.Text.Trim & "'"
        InQry = InQry & " And Folio = '" & TFolioAtlas.Text.Trim & "'"
        InsertQry(InQry)

        BackgroundWorker1.ReportProgress(100)

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        PBActualiza.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Grid_Load()
        MessageBox.Show("Información Actualizada")
        tsbGrabar.Enabled = False
        PBActualiza.Value = 0
        PBActualiza.Visible = False
    End Sub

    'Private Sub TPesoBruto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoBruto.TextChanged
    '    If TPesoBruto.Text >= "0" And TPesoRack.Text >= "0" Then
    '        TPesoNeto.Text = (TPesoBruto.Text - TPesoRack.Text)
    '    End If
    'End Sub

    'Private Sub TPesoRack_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TPesoRack.TextChanged
    '    If TPesoBruto.Text >= "0" And TPesoRack.Text >= "0" Then
    '        TPesoNeto.Text = (TPesoBruto.Text - TPesoRack.Text)
    '    End If
    'End Sub

    Private Sub TtramosNoti_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TtramosNoti.KeyPress
        e.Handled = txtNumerico(TOrden, e.KeyChar, False)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TtramosNoti_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TtramosNoti.Leave

        CodEmpaque = TcodPt.Text.Trim

        QRY = ""
        QRY = " Select Empaque from CAT_ProductoTerminado "
        QRY = QRY & "Where Centro = '" & SessionUser._sCentro.Trim & "' "
        QRY = QRY & "And Codigo = '" & CodEmpaque.Trim & "' "

        LecturaQry(QRY)
        Do While (LecturaBD.Read())
            CodEmpaque = LecturaBD(0)    'Codigo del Empaque
        Loop

        If CodEmpaque = 0 Then

        Else

        End If

    End Sub

    Private Sub BtnGdaPesos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGdaPesos.Click
        InQry = ""
        InQry = "Update " & SessionUser._sCentro.Trim & "_PesoProductoTerminado "
        InQry = InQry & "Set Tramos = '" & TtramosNoti.Text.Trim & "' "
        InQry = InQry & " Where Orden_Produccion = '" & TOrden.Text.Trim & "' "
        If EXTINY = "1" Then
            InQry = InQry & " And Area = 'E' "
        Else
            InQry = InQry & " And Area = 'I' "
        End If
        InQry = InQry & " And Folio = '" & TFolioAtlas.Text.Trim & "' "
        InsertQry(InQry)

        Grid_Load()
    End Sub

    Private Sub BtnGda_ODF_Click(sender As System.Object, e As System.EventArgs) Handles BtnGda_ODF.Click

    End Sub
End Class