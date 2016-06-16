Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmAdmin_PPT_AMEX
    Dim Str_FI As String    'Fecha inicio consulta
    Dim Str_FF As String    'Fecha fin consulta

    Dim Message As String = ""
    Dim Caption As String = ""
    Dim Result As DialogResult
    Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
    Dim Botones As MessageBoxButtons = MessageBoxButtons.OK

    'Variables Consulta
    Dim C_Folio As String
    Dim C_OrdenProd As String
    Dim C_Producto As String
    Dim C_Fec_Pesaje As String
    Dim C_Bascula As String
    Dim C_Rack As String
    Dim C_PBruto As String
    Dim C_PTara As String
    Dim C_PesoOtroas As String
    Dim C_PNeto As String
    Dim C_Tramos As String
    Dim C_Usr As String
    Dim C_Turno As String
    Dim C_DocSAP As String
    Dim C_NumSAP As String
    Dim C_Sp As String
    Dim C_Maquina As String
    Dim Status_Not As String
    Dim Status_Not_Mas As String
    Dim Status_Pesaje As String
    Dim C_Area As String

    'Variables Movimientos
    Dim Fec_Mov As String
    Dim Hra_Mov As String


    Public Sub Grid_Load()

        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim

        QRY_Grid = ""
        NameTable = ""
        NameTable = "PesoProductoTerminado"
        QRY_Grid = "Select b.Folio,a.orden_produccion,a.Producto,b.Fecha_Pesaje,b.Bascula,b.Rack,b.Peso_Bruto,b.Tara,"
        If EXTINY = "1" Then
            QRY_Grid = QRY_Grid & "b.Peso_Neto,b.PesoNetoMerma,"
        Else
            QRY_Grid = QRY_Grid & "b.EmbalajeInyeccion,b.Peso_Neto,"
        End If
        QRY_Grid = QRY_Grid & "b.Tramos,b.Usuario,b.Turno,b.Documento_SAP,b.Consecutivo_SAP,"
        QRY_Grid = QRY_Grid & "b.Sobrepeso,b.PuestoTrabajo,b.Notifica,b.notificacionmasiva,b.Status_Pesaje,b.Area "
        QRY_Grid = QRY_Grid & "From " & SessionUser._sCentro.Trim & "_OrdenProduccion a, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado b "
        QRY_Grid = QRY_Grid & "Where a.Orden_Produccion = b.Orden_Produccion "
        QRY_Grid = QRY_Grid & "And b.Planta = '" & SessionUser._sCentro.Trim & "' "
        If TOrden.Text <> "" Then
            QRY_Grid = QRY_Grid & "And b.Orden_Produccion = '" & TOrden.Text.Trim & "' "
        End If
        If EXTINY = "1" Then
            QRY_Grid = QRY_Grid & "And b.Area = 'E' "
        Else
            QRY_Grid = QRY_Grid & "And b.Area = 'I' "
        End If
        QRY_Grid = QRY_Grid & "And b.Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "
        QRY_Grid = QRY_Grid & "Order by b.Folio"

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)
            DGV_Pesos.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGV_Pesos.Columns(0).HeaderText = "Folio"
        DGV_Pesos.Columns(1).HeaderText = "Orden de Producción"
        DGV_Pesos.Columns(2).HeaderText = "Producto"
        DGV_Pesos.Columns(3).HeaderText = "Fecha Pesaje"
        DGV_Pesos.Columns(4).HeaderText = "Bascula"
        DGV_Pesos.Columns(5).HeaderText = "Num. Rack"
        DGV_Pesos.Columns(6).HeaderText = "Peso Bruto"
        DGV_Pesos.Columns(7).HeaderText = "Peso Tara"
        If EXTINY = "1" Then
            DGV_Pesos.Columns(8).HeaderText = "Peso Neto"
            DGV_Pesos.Columns(9).HeaderText = "Peso Neto + Merma"
        Else
            DGV_Pesos.Columns(8).HeaderText = "Peso Embalajes"
            DGV_Pesos.Columns(9).HeaderText = "Peso Neto"
        End If
        DGV_Pesos.Columns(10).HeaderText = "Cantidad de Tramos"
        DGV_Pesos.Columns(11).HeaderText = "Usuario"
        DGV_Pesos.Columns(12).HeaderText = "Turno"
        DGV_Pesos.Columns(13).HeaderText = "Documento SAP"
        DGV_Pesos.Columns(14).HeaderText = "Consecutivo SAP"
        DGV_Pesos.Columns(15).HeaderText = "Sobre Peso"
        DGV_Pesos.Columns(16).HeaderText = "Puesto de Trabajo"
        DGV_Pesos.Columns(17).Visible = False  'Status Notificacion
        DGV_Pesos.Columns(18).Visible = False  'Status Notificacion Masiva
        DGV_Pesos.Columns(19).Visible = False  'Status Pesaje
        DGV_Pesos.Columns(20).Visible = False  'Area

    End Sub

    Private Sub BConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BConsulta.Click
        Grid_Load()
    End Sub

    Private Sub FrmAdminDel_PPT_AMEX_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        EXTINY = ""
    End Sub

    Private Sub FrmAdminDel_PPT_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Grid_Load()
    End Sub

    Private Sub DGV_1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Pesos.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV_Pesos.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try
                C_Folio = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(0).Value.ToString
                C_OrdenProd = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(1).Value.ToString
                C_Producto = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(2).Value.ToString
                C_Fec_Pesaje = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(3).Value.ToString
                C_Bascula = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(4).Value.ToString
                C_Rack = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(5).Value.ToString
                C_PBruto = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(6).Value.ToString
                C_PTara = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(7).Value.ToString
                C_PesoOtroas = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(8).Value.ToString
                C_PNeto = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(9).Value.ToString
                C_Tramos = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(10).Value.ToString
                C_Usr = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(11).Value.ToString
                C_Turno = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(12).Value.ToString
                C_DocSAP = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(13).Value.ToString
                C_NumSAP = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(14).Value.ToString
                C_Sp = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(15).Value.ToString
                C_Maquina = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(16).Value.ToString
                Status_Not = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(17).Value.ToString
                Status_Not_Mas = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(18).Value.ToString
                Status_Pesaje = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(19).Value.ToString
                C_Area = DGV_Pesos.Rows(DGV_Pesos.CurrentCell.RowIndex).Cells(20).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub DGV_1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV_Pesos.CellFormatting
        Status_Not = (DGV_Pesos.Rows(e.RowIndex).Cells(17).Value)


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

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click

        Fec_Mov = Now.Date.ToString("yyyy-MM-dd")
        Hra_Mov = Now.TimeOfDay.ToString.Substring(0, 8)

        If EXTINY = "1" Then
            Message = "El Folio '" & C_Folio.Trim & "' de Extrusión sera dado de baja, ¿ esta seguro ? "
        Else
            Message = "El Folio '" & C_Folio.Trim & "' de Inyección sera dado de baja, ¿ esta seguro ? "
        End If

        Caption = "Eliminar Registro Pesaje"
        Result = MessageBox.Show(Message, Caption, Buttons)
        If Result = System.Windows.Forms.DialogResult.Yes Then

            Try

                InQry = ""
                InQry = " UPDATE " & SessionUser._sCentro.Trim & "_PesoProductoTerminado SET Status_Pesaje = '0', "
                InQry = InQry & " Notifica = '9' "
                InQry = InQry & " WHERE Planta = '" & SessionUser._sCentro.Trim & "' "
                If EXTINY = "1" Then
                    InQry = InQry & "AND Area = 'E' "
                Else
                    InQry = InQry & "AND Area = 'I' "
                End If
                InQry = InQry & "AND Folio = '" & C_Folio.Trim & "' "
                InQry = InQry & "AND Orden_Produccion = '" & C_OrdenProd.Trim & "' "
                InsertQry(InQry)

                ' ---------------------------------------------------------------------------------
            Catch ex1 As Exception
                MsgBox(ex1.Message)
                Exit Sub
            End Try

            'Se ingresa el status del registro previo al movimiento para dar seguimiento

            Try

                InQry = ""
                InQry = "INSERT INTO " & SessionUser._sCentro.Trim & "_Movimientos(Centro,Folio,Orden_Produccion,Fecha,Hora,Documento_SAP,"
                InQry = InQry & "Consecutivo_SAP,Notifica,Notificacionmasiva,Usuario,Observacion,Status_Pesaje,Area) "
                InQry = InQry & "VALUES('" & SessionUser._sCentro.Trim & "','" & C_Folio.Trim & "','" & C_OrdenProd.Trim & "',"
                InQry = InQry & "'" & Fec_Mov.Trim & "','" & Hra_Mov.Trim & "','" & C_DocSAP.Trim & "','" & C_NumSAP.Trim & "',"
                InQry = InQry & "'" & Status_Not.Trim & "','" & Status_Not_Mas.Trim & "','" & SessionUser._sAlias.Trim & "','Observaciones',"
                InQry = InQry & "'" & Status_Pesaje.Trim & "','" & C_Area.Trim & "')"
                InsertQry(InQry)

                ' ---------------------------------------------------------------------------------
            Catch ex1 As Exception
                MsgBox(ex1.Message)
                Exit Sub
            End Try

            Grid_Load()

        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            Return
        End If

    End Sub

End Class