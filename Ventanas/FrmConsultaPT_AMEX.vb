Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmConsultaPesajes
    Dim Str_FI As String    'Fecha inicio consulta
    Dim Str_FF As String    'Fecha fin consulta
    Dim N_Folio As String   'Numero de Folio
    Dim N_Ord As String     'Numero de Orden de Producción
    Dim N_Prod As String    'Numero de producto

    'Variables Impresion Centro A014
    Dim ODF As String
    Dim FolioAtlas As String
    Dim Eqp As String
    Dim F_Pesaje As String
    Dim H_Pesaje As String
    Dim N_Bascula As String
    Dim N_Rack As String
    Dim PB As String
    Dim PT As String
    Dim PN As String
    Dim Tramos As String
    Dim Usr As String
    Dim N_Turno As String
    Dim DocSAP As String
    Dim ConSAP As String
    Dim N_SP As String
    Dim Porc_Merma As String
    Dim PesoMermas As String
    Dim PesoNetoMerma As String
    Dim CodProducto As String
    Dim DesProducto As String
    Dim Status_Not As String

    Public Sub Grid_Load()

        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim

        QRY_Grid = ""
        NameTable = ""
        NameTable = "PesoProductoTerminado"
        QRY_Grid = "Select replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,a.orden_produccion,"
        QRY_Grid = QRY_Grid & "a.Producto,b.Fecha_Pesaje,b.Bascula,b.Tramos,b.Rack,b.Peso_Bruto,b.Tara,b.Peso_Neto,"
        If EXTINY = "1" Then
            QRY_Grid = QRY_Grid & "b.Empaques,b.Usuario,b.Turno,b.Documento_SAP,b.Consecutivo_SAP,"
        Else
            QRY_Grid = QRY_Grid & "b.EmbalajeInyeccion,b.Usuario,b.Turno,b.Documento_SAP,b.Consecutivo_SAP,"
        End If
        QRY_Grid = QRY_Grid & "b.Sobrepeso,b.PuestoTrabajo,b.Notifica,b.MsgSAP "
        QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b "
        QRY_Grid = QRY_Grid & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY_Grid = QRY_Grid & "And b.Planta = '" & SessionUser._sCentro.Trim & "' "
        If EXTINY = "1" Then
            QRY_Grid = QRY_Grid & "And b.Area = 'E' "
        Else
            QRY_Grid = QRY_Grid & "And b.Area = 'I' "
        End If
        If TOrdProd.Text <> "*" Then
            QRY_Grid = QRY_Grid & "And a.Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
        End If
        If RB0.Checked Then
            QRY_Grid = QRY_Grid & "And b.Notifica <> '9' "
        End If
        If RB1.Checked Then
            QRY_Grid = QRY_Grid & "And b.St_Sobrepeso = '1' "
            QRY_Grid = QRY_Grid & "And b.Notifica <> '9' "
        End If
        If RB3.Checked Then
            QRY_Grid = QRY_Grid & "And b.Notifica = '9' "
        End If
        QRY_Grid = QRY_Grid & "And b.Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "
        QRY_Grid = QRY_Grid & "Order by b.Folio"

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)
            DGV_BP.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DGV_BP.Columns(0).HeaderText = "Folio"
        DGV_BP.Columns(1).HeaderText = "Orden de Producción"
        DGV_BP.Columns(2).HeaderText = "Producto"
        DGV_BP.Columns(3).HeaderText = "Fecha Pesaje"
        DGV_BP.Columns(4).HeaderText = "Bascula"
        DGV_BP.Columns(5).HeaderText = "Cantidad de Tramos"
        DGV_BP.Columns(6).HeaderText = "Num. Rack"
        DGV_BP.Columns(7).HeaderText = "Peso Bruto"
        DGV_BP.Columns(8).HeaderText = "Peso Tara"
        DGV_BP.Columns(9).HeaderText = "Peso Neto"
        DGV_BP.Columns(10).HeaderText = "Peso Empaques"
        DGV_BP.Columns(11).HeaderText = "Usuario"
        DGV_BP.Columns(12).HeaderText = "Turno"
        DGV_BP.Columns(13).HeaderText = "Documento SAP"
        DGV_BP.Columns(14).HeaderText = "Consecutivo SAP"
        DGV_BP.Columns(15).HeaderText = "Sobre Peso"
        DGV_BP.Columns(16).HeaderText = "Puesto de Trabajo"
        DGV_BP.Columns(17).Visible = False  'Status Notificacion
        DGV_BP.Columns(18).HeaderText = "Mensaje SAP"

        'Total de registros por consulta
        QRY = "Select count(*) "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b "
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And b.Planta = '" & SessionUser._sCentro.Trim & "' "
        If EXTINY = "1" Then
            QRY = QRY & "And b.Area = 'E' "
        Else
            QRY = QRY & "And b.Area = 'I' "
        End If
        If TOrdProd.Text <> "*" Then
            QRY = QRY & "And a.Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
        End If
        QRY = QRY & "And b.Notifica <> '9' "
        QRY = QRY & "And b.Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "

        LecturaQry(QRY)

        Do While (LecturaBD.Read)
            TotReg.Text = LecturaBD(0)
        Loop

        LecturaBD.Close()

        'Total de tramos por consulta
        QRY = "Select IsNull((sum(tramos)),0) "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b "
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And b.Planta = '" & SessionUser._sCentro.Trim & "' "
        If EXTINY = "1" Then
            QRY = QRY & "And b.Area = 'E' "
        Else
            QRY = QRY & "And b.Area = 'I' "
        End If
        If TOrdProd.Text <> "*" Then
            QRY = QRY & "And a.Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
        End If
        QRY = QRY & "And b.Notifica <> '9' "
        QRY = QRY & "And b.Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "

        LecturaQry(QRY)

        Do While (LecturaBD.Read)
            TotTramos.Text = LecturaBD(0)
        Loop

        LecturaBD.Close()

    End Sub

    Private Sub FrmBoletaPesaje_A013_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BImp.Enabled = False
        Me.Icon = Util.ApplicationIcon()
        Grid_Load()
    End Sub

    Private Sub BConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BConsulta.Click
        Grid_Load()
    End Sub

    Sub imprimir_PT()

        QRY = ""
        QRY = QRY & "Select a.Orden_Produccion,b.Folio,a.Planta,a.Equipo_Basico,b.Fecha_Pesaje,b.Hora_Pesaje,b.Bascula,b.Rack,"
        QRY = QRY & "b.Peso_Bruto,b.Tara,b.Peso_Neto,b.Tramos,b.Usuario,b.Turno,b.Documento_SAP,b.Consecutivo_SAP,b.Sobrepeso,"
        QRY = QRY & "b.PorcentajeMerma,b.PesoMerma,b.PesoNetoMerma,c.Codigo,c.Descr,b.OpePtoTra "
        QRY = QRY & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b, "
        QRY = QRY & "ProductoTerminadoExtrusion c "
        QRY = QRY & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY = QRY & "And a.Producto = c.Codigo "
        QRY = QRY & "And a.Planta = c.Centro "
        QRY = QRY & "And a.Planta = '" & SessionUser._sCentro.Trim & "' "
        QRY = QRY & "And a.Orden_Produccion = '" & N_Ord.Trim & "' "
        QRY = QRY & "And b.Folio = Convert(Int, '" & N_Folio.Trim & "') "
        LecturaQry(QRY)

        Try
            objDa = New SqlDataAdapter(QRY, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)

            'objDs.WriteXmlSchema("c:\atlas\BP_PTE.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
        End Try

        Select Case SessionUser._sCentro.Trim
            Case Is = "GT01"
                Dim BoletaPesaje As New RValePTE_GT
                BoletaPesaje.SetDataSource(objDs)
                FREP.CRV1.ReportSource = BoletaPesaje
                'Case Is = "A014"
                '    Dim BoletaPesaje As New rptTicketExt_AMEX
                '    BoletaPesaje.SetDataSource(objDs)
                '    FREP.CRV1.ReportSource = BoletaPesaje
                'Case Is = "A021", "A022"
                '    Dim BoletaPesaje As New rptValeExtDoble_AMEX
                '    BoletaPesaje.SetDataSource(objDs)
                '    FREP.CRV1.ReportSource = BoletaPesaje
                '    'BoletaPesaje.PrintToPrinter(1, False, 1, 1)
                'Case Else
                '    Dim BoletaPesaje As New rptValeExt_AMEX
                '    BoletaPesaje.SetDataSource(objDs)
                '    FREP.CRV1.ReportSource = BoletaPesaje
        End Select
        FREP.Show()

    End Sub


    Private Sub DGV_BP_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_BP.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV_BP.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try

                N_Folio = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(0).Value.ToString
                N_Ord = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(1).Value.ToString
                N_Prod = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(2).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            BImp.Enabled = True

        End If
    End Sub

    Private Sub BImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImp.Click
        imprimir_PT()
    End Sub

    Private Sub FrmConsultaPT_AMEX_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        EXTINY = ""
    End Sub

    Private Sub DGV_BP_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV_BP.CellFormatting
        Status_Not = (DGV_BP.Rows(e.RowIndex).Cells(17).Value)

        If Status_Not = "1" Then
            e.CellStyle.BackColor = Color.LightGreen
            e.CellStyle.ForeColor = Color.Black
        ElseIf Status_Not = "0" Or Status_Not = "4" Or Status_Not = "3" Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Black
        ElseIf Status_Not = "9" Then
            e.CellStyle.BackColor = Color.Red
            e.CellStyle.ForeColor = Color.White
        End If
    End Sub

End Class