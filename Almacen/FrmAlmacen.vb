Imports System.Data.SqlClient
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmAlmacen
    Dim Str_FI As String    'Fecha inicio consulta
    Dim Str_FF As String    'Fecha fin consulta
    Dim N_Folio As String   'Numero de Folio
    Dim N_Ord As String     'Numero de Orden de Producción
    Dim N_Prod As String    'Numero de producto
    Dim Status_Cell As Boolean
    Dim Cell_Trasp As Boolean
    'Variables Consulta Registros
    Dim C_OrdProd As String
    Dim C_Folio As String
    Dim C_Area As String
    Dim C_StaAlm As Boolean
    Dim C_Trasp As Boolean

    Public Sub Grid_Load()
        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim

        QRY_Grid = ""
        NameTable = ""
        NameTable = "ProductoTerminado"
        QRY_Grid = "Select replicate('0', 8-len(b.folio)) + cast(b.folio as char(8)) as Folio,a.orden_produccion,"
        QRY_Grid = QRY_Grid & "a.Producto,b.Fecha_Pesaje,b.Hora_Pesaje,b.Bascula,b.Tramos,b.Rack,b.Peso_Bruto,b.Tara,"
        If EXTINY = "1" Then
            QRY_Grid = QRY_Grid & "b.Peso_Neto,b.PesoNetoMerma,"
        Else
            QRY_Grid = QRY_Grid & "b.EmbalajeInyeccion,b.Peso_Neto,"
        End If
        QRY_Grid = QRY_Grid & "b.Usuario,b.Turno,b.Documento_SAP,b.Consecutivo_SAP,"
        QRY_Grid = QRY_Grid & "b.Sobrepeso,b.PuestoTrabajo,b.Notifica,b.Status_Alm,b.Area,b.UsrAlm,b.trasp "
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
        QRY_Grid = QRY_Grid & "And b.Notifica = '1' "
        QRY_Grid = QRY_Grid & "And b.Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "
        QRY_Grid = QRY_Grid & "Order by b.Folio"

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGV_Alm.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGV_Alm.Columns(0).HeaderText = "Folio"
        DGV_Alm.Columns(1).HeaderText = "Orden de Producción"
        DGV_Alm.Columns(2).HeaderText = "Producto"
        DGV_Alm.Columns(3).HeaderText = "Fecha Pesaje"
        DGV_Alm.Columns(4).HeaderText = "Hora Pesaje"
        DGV_Alm.Columns(5).Visible = False  'Bascula'
        DGV_Alm.Columns(6).HeaderText = "Cantidad de Tramos"
        DGV_Alm.Columns(7).Visible = False  'Num. Rack'
        DGV_Alm.Columns(8).Visible = False  'Peso Bruto'
        DGV_Alm.Columns(9).Visible = False  'Peso Tara'
        If EXTINY = "1" Then
            DGV_Alm.Columns(10).HeaderText = "Peso Neto"
            DGV_Alm.Columns(11).HeaderText = "Peso Neto + Merma"
        Else
            DGV_Alm.Columns(10).HeaderText = "Peso Embalajes"
            DGV_Alm.Columns(11).HeaderText = "Peso Neto"
        End If
        DGV_Alm.Columns(12).HeaderText = "Usuario Peso"
        DGV_Alm.Columns(13).HeaderText = "Turno"
        DGV_Alm.Columns(14).Visible = False 'Documento SAP'
        DGV_Alm.Columns(15).Visible = False 'Consecutivo SAP'
        DGV_Alm.Columns(16).Visible = False 'Sobre Peso'
        DGV_Alm.Columns(17).HeaderText = "Puesto de Trabajo"
        DGV_Alm.Columns(18).Visible = False 'Status Notificacion
        DGV_Alm.Columns(19).Visible = False 'Status Almacen
        DGV_Alm.Columns(20).Visible = False 'Area Extrusión/Inyección
        DGV_Alm.Columns(21).HeaderText = "Usuario Recibe Almacen"
        DGV_Alm.Columns(22).Visible = False 'Status de Traspaso

    End Sub

    Private Sub DGV_Alm_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Alm.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV_Alm.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                Dim Fila_Seleccionada As Integer = DGV_Alm.CurrentCell.RowIndex
                C_Folio = DGV_Alm.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                C_OrdProd = DGV_Alm.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                C_StaAlm = DGV_Alm.Rows(Fila_Seleccionada).Cells(19).Value.ToString
                C_Area = DGV_Alm.Rows(Fila_Seleccionada).Cells(20).Value.ToString
                C_Trasp = DGV_Alm.Rows(Fila_Seleccionada).Cells(22).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            If C_StaAlm = False And C_Trasp = False Then
                BtnRev.Enabled = False
            ElseIf C_StaAlm = True And C_Trasp = False Then
                BtnRev.Enabled = True
            ElseIf C_StaAlm = True And C_Trasp = True Then
                BtnRev.Enabled = False
            End If

        End If
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub FrmAlmacen_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid_Load()
    End Sub

    Private Sub BtnCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCon.Click
        Grid_Load()
    End Sub

    Private Sub DGV_Alm_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV_Alm.CellFormatting
        Status_Cell = (DGV_Alm.Rows(e.RowIndex).Cells(19).Value)
        Cell_Trasp = (DGV_Alm.Rows(e.RowIndex).Cells(22).Value)

        If Status_Cell = True Then
            If Cell_Trasp = True Then
                e.CellStyle.BackColor = Color.LimeGreen
                e.CellStyle.ForeColor = Color.Black
            Else
                e.CellStyle.BackColor = Color.LightGreen
                e.CellStyle.ForeColor = Color.Black
            End If
        Else
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub DGV_Alm_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Alm.DoubleClick
        If C_StaAlm = True Then
            MsgBox("Ya esta recibido")
            Return
        Else

            Try

                InQry = ""
                InQry = " UPDATE " & SessionUser._sCentro.Trim & "_PesoProductoTerminado  "
                InQry = InQry & "SET Status_Alm = '1', "
                InQry = InQry & "UsrAlm = '" & SessionUser._sAlias.Trim & "' "
                InQry = InQry & "WHERE Orden_produccion = '" & C_OrdProd.Trim & "' "
                InQry = InQry & "AND Folio = Convert(Int, '" & C_Folio.Trim & "') "
                InQry = InQry & "AND Area = '" & C_Area.Trim & "' "
                InsertQry(InQry)

                ' ---------------------------------------------------------------------------------
            Catch ex1 As Exception
                MsgBox(ex1.Message)
                Exit Sub
            End Try

            MsgBox("Actualización Exitosa")

        End If
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem.Click
        FrmIMPAlm_AMEX.ShowDialog()
    End Sub

    Private Sub FrmAlmacen_AMEX_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        EXTINY = ""
    End Sub

    Private Sub BtnRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRev.Click
        Try

            InQry = ""
            InQry = " UPDATE " & SessionUser._sCentro.Trim & "_PesoProductoTerminado  "
            InQry = InQry & "SET Status_Alm = '0', "
            InQry = InQry & "UsrAlm = '" & SessionUser._sAlias.Trim & "' "
            InQry = InQry & "WHERE Orden_produccion = '" & C_OrdProd.Trim & "' "
            InQry = InQry & "AND Folio = Convert(Int, '" & C_Folio.Trim & "') "
            InQry = InQry & "AND Area = '" & C_Area.Trim & "' "
            InsertQry(InQry)

            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MsgBox("Actualización Exitosa")
    End Sub

    Private Sub BtnTraspaso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTraspaso.Click

        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim

        Try

            InQry = ""
            InQry = " UPDATE " & SessionUser._sCentro.Trim & "_PesoProductoTerminado  "
            InQry = InQry & "SET Trasp = '1' "
            InQry = InQry & "Where status_alm = '1' "
            InQry = InQry & "And Fecha_Pesaje between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "' "
            InQry = InQry & "AND Area = 'E' "
            InQry = InQry & "AND Status_Pesaje = '1' "
            InsertQry(InQry)

            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        Grid_Load()
        MsgBox("Actualización Exitosa")
    End Sub
End Class