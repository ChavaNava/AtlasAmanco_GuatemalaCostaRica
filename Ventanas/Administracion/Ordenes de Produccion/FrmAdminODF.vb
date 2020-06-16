Imports System.Configuration
Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmAdminODF
#Region "Variables de Miembro"
    Dim PO As New ProductionOrder_2
    'Variables Generales
    Dim Result As DialogResult
    Dim RegistrosActualizados As Integer
    Dim myDataReader As SqlClient.SqlDataReader
    Dim Q As String
    Dim contador As Integer
    Dim prod As Integer
    Dim ProdFin As String

    Dim SupervisorCalidad As String
    Dim nvoOrden_Produccion As String
    Dim NumeroPlanta As String
    Dim OrdenProd As String
    Dim Equipo As String
    Dim Producto As String
    Dim CantProgPzs As Integer
    Dim CantProgkg As Integer = 333
    Dim fecini As String
    Dim fecterm As String
    Dim OrigInf As String = "SAP_R/3"
    Dim Status As String
    Dim UsrAct As String
    Dim FecAct As String = Today
    Dim Obs As String
    Dim Unidad As String
    Dim Inicio As String
    Dim Fin As String
    Dim Origen As String
    Dim Status1 As String
    Dim HrReal As String
    Dim EstatusActiva As Integer
    Dim actualizados As Integer
    Dim taraempaque As Decimal
    Dim PesoTeorico As Decimal
    Dim descripcion As String = ""
    Dim EqpBasico As String
    Dim StrProducto As String
    Dim StrTramos As String
    Dim StrCompuesto As String
    Dim StrDescComp As String
    Dim StrPiezas As String
    Dim TotOrd As Integer
    Dim OP As Integer

    'Variables de error en WS
    Dim Err As String
    Dim Mns As String

    'Variables para consulta de ordenes
    Dim StrFecIni As String
    Dim StrFecFin As String
    Dim C_ODF As String
    Dim C_EB As String
    Dim C_CM As String
    Dim C_CPT As String
    Dim C_CPK As String
    Dim C_FI As String
    Dim C_FT As String
    Dim C_OI As String
    Dim C_ST As String
    Dim C_UA As String
    Dim C_FA As String
    Dim C_OBS As String
    Dim C_FIP As String
    Dim C_HIP As String
    Dim C_URI As String
    Dim C_UAR As String
    Dim C_FAR As String
    Dim C_HAR As String
    Dim C_GP As String
    Dim ST As String
    Dim ODF As String
    Dim j As Integer

    Dim Lee_ODF As String
#End Region

#Region "Eventos"

    Private Sub DGV_ODF_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles DGV_ODF.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV_ODF.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then
            Try
                C_ODF = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(0).Value.ToString
                C_EB = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(1).Value.ToString
                C_CM = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(2).Value.ToString
                C_CPT = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(3).Value.ToString
                C_CPK = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(4).Value.ToString
                C_FI = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(5).Value.ToString
                C_FT = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(6).Value.ToString
                C_OI = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(7).Value.ToString
                C_ST = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(8).Value.ToString
                C_UA = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(9).Value.ToString
                C_FA = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(10).Value.ToString
                C_OBS = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(11).Value.ToString
                C_FIP = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(12).Value.ToString
                C_HIP = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(13).Value.ToString
                C_URI = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(14).Value.ToString
                C_UAR = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(15).Value.ToString
                C_FAR = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(16).Value.ToString
                C_HAR = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(17).Value.ToString
                C_GP = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(18).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

        End If
    End Sub


    Private Sub FrmAdminODF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Label4.Visible = False
        pgbAvance.Visible = False
        If EXTINY = "1" Then
            Me.Text = "Ordenes de Fabricación Extrusión"
        Else
            Me.Text = "Ordenes de Fabricación Inyección"
        End If
        CargaGrid()
    End Sub

    Private Sub DGODF_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModificaODP.Enabled = True
        FinalizaODP.Enabled = True
        ReactivarODF.Enabled = True
    End Sub

    Private Sub DGV_ODF_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV_ODF.CellFormatting
        With DGV_ODF
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub Btn_Consulta_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Consulta.Click
        CargaGrid()
    End Sub

    Private Sub ImportarODPDeSAPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportarODPDeSAPToolStripMenuItem.Click
        PO.Valid_Existence(TOrden.Text.Trim, EXTINY)
        If PO.r_Accion = "E" Then
            TOrden.Text = ""
            TOrden.Focus()
            Exit Sub
        ElseIf PO.r_Count_1 <= 0 Then
            'PO.Inserta_Nueva_Orden_Produccion(TOrden.Text.Trim, "T", Me, SessionUser._sAlias.Trim, EXTINY)
            PO.Inserta_ODF(TOrden.Text.Trim, "T", Me, SessionUser._sAlias.Trim, EXTINY)
        End If
    End Sub

    Private Sub NuevaODPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaODPToolStripMenuItem.Click
        Accion = "Altas"
        _Termina = 0
        FrmCtrlODF_AMEX.ShowDialog()
        If _Termina = 1 Then
            CargaGrid()
        End If
    End Sub

    Private Sub ModificaODPT_Click(sender As System.Object, e As System.EventArgs) Handles ModificaODP.Click
        OrdOld = DGV_ODF.Rows(DGV_ODF.CurrentCell.RowIndex).Cells(0).Value.ToString
        Accion = "Cambios"
        OrdPrd = ""
        _Termina = 0
        FrmCtrlODF_AMEX.ShowDialog()
        If _Termina = 1 Then
            CargaGrid()
        End If
    End Sub

    Private Sub FinalizaODPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FinalizaODP.Click
        objCmd.Connection = objCnnAmanco
        Q = ""
        Q = "Update " & SessionUser._sCentro.Trim & "_ordenproduccion set Estatus_Activa = '0' "
        Q = Q & "Where Orden_Produccion = '" & C_ODF.Trim & "' "
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show(" Registro Actualizado ")

        Btn_Consulta_Click(sender, Nothing)
    End Sub

    Private Sub ReactivarODFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReactivarODF.Click
        objCmd.Connection = objCnnAmanco
        Q = ""
        Q = "Update " & SessionUser._sCentro.Trim & "_ordenproduccion set Estatus_Activa = '1' "
        Q = Q & "Where Orden_Produccion = '" & C_ODF.Trim & "' "
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show(" Registro Actualizado ")

        Btn_Consulta_Click(sender, Nothing)
    End Sub

    Private Sub ActualizaODPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActualizaODPToolStripMenuItem.Click
        Label4.Text = ""
        Label4.Visible = True
        MenuStrip1.Enabled = False
        pgbAvance.Visible = True
        Avance_Consulta.WorkerReportsProgress = True
        Avance_Consulta.RunWorkerAsync()
    End Sub

    Private Sub Btn_Cerrar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Cerrar.Click
        Close()
    End Sub
#End Region

#Region "Metodos"
    Sub CargaGrid()
        Dim Contador As Integer = 0
        StrFecIni = ""
        StrFecFin = ""
        StrFecIni = DTP1.Value.ToString("yyyyMMdd")
        StrFecFin = DTP2.Value.AddDays(1).ToString("yyyyMMdd")
        Contador = Catalogo_Ordenes_Produccion.Consulta_Ordenes_Produccion(DGV_ODF, SessionUser._sCentro.Trim, StrFecIni, StrFecFin, TOrden.Text.Trim, EXTINY, SessionUser._sAlias.Trim)
        LBContador.Text = Contador
    End Sub

    Private Sub Avance_Consulta_ProgressChanged(sender As System.Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles Avance_Consulta.ProgressChanged
        Label4.Text = "Actualizando Orden '" & Lee_ODF.Trim & "'"
        Label6.Visible = True
        Label6.Text = "Ordenes Actualizadas:"
        Label7.Visible = True
        DGV_ODF.Refresh()
        Label7.Text = j
        pgbAvance.Value = e.ProgressPercentage
    End Sub

    Private Sub Avance_Consulta_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Avance_Consulta.DoWork
        System.Threading.Thread.Sleep(500)
        For j = 0 To DGV_ODF.RowCount - 1
            System.Threading.Thread.Sleep(1000)
            Lee_ODF = DGV_ODF.Rows(j).Cells(0).Value.ToString()
            PO.Actualiza_Orden_Produccion(Lee_ODF, "T")
            Avance_Consulta.ReportProgress((j / LBContador.Text) * 100)
            System.Threading.Thread.Sleep(1000)
        Next
        Avance_Consulta.ReportProgress(100)
        System.Threading.Thread.Sleep(1500)
    End Sub

    Private Sub Avance_Consulta_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Avance_Consulta.RunWorkerCompleted
        Label4.Visible = False
        pgbAvance.Visible = False
        pgbAvance.Value = 0
        CargaGrid()
        Label6.Visible = False
        Label6.Text = ""
        Label7.Visible = False
        MenuStrip1.Enabled = True
    End Sub
#End Region


    Private Sub IniciaODP_Click(sender As System.Object, e As System.EventArgs) Handles IniciaODP.Click
        Dim FrmInicia As New Form
        FrmInicia.Icon = Util.ApplicationIcon()

        FrmInicia.Show()
    End Sub
End Class