Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmConsultaOT_AMEX
    Dim Str_FI As String    'Fecha inicio consulta
    Dim Str_FF As String    'Fecha fin consulta
    Dim N_Folio As String   'Numero de Folio
    Dim N_Ord As String     'Numero de Orden de Producción
    Dim N_Prod As String    'Numero de producto

    Public Sub ImpBoleta()

        QRY = ""
        QRY = QRY & "Select * From " & SessionUser._sCentro.Trim & "_PesoOtros "
        QRY = QRY & "Where Folio = '" & N_Folio.Trim & "' "

        LecturaQry(QRY)

        Try
            objDa = New SqlDataAdapter(QRY, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)

            'objDs.WriteXmlSchema("c:\atlas\OT_GT01.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
        End Try

        If SessionUser._sAlias.Trim = "YONY" Then
            Dim BP_GT01 As New RValeOT_GT
            BP_GT01.SetDataSource(objDs)
            FREP.CRV1.ReportSource = BP_GT01
            FREP.Show()
        Else
            Dim BP_GT01 As New RValeOT_GT
            BP_GT01.SetDataSource(objDs)
            BP_GT01.PrintToPrinter(1, False, 1, 1)
        End If
    End Sub

    Public Sub Grid_Load()

        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim

        QRY_Grid = ""
        NameTable = ""
        NameTable = "A013_PesoScrap"
        QRY_Grid = "Select * From " & SessionUser._sCentro.Trim & "_PesoOtros "
        QRY_Grid = QRY_Grid & "Where Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "
        QRY_Grid = QRY_Grid & "Order by Folio"

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGV_BP.DataSource = objDs.Tables(0)
            DGV_BP.Columns(1).HeaderText = "Folio"
            DGV_BP.Columns(2).HeaderText = "Fecha Pesaje"
            DGV_BP.Columns(4).HeaderText = "Bascula"
            DGV_BP.Columns(5).HeaderText = "Carreta o Rack"
            DGV_BP.Columns(6).HeaderText = "Peso Bruto"
            DGV_BP.Columns(7).HeaderText = "Peso Tara"
            DGV_BP.Columns(8).HeaderText = "Peso Neto"
            DGV_BP.Columns(9).HeaderText = "Usuario"
            DGV_BP.Columns(10).HeaderText = "Turno"
            DGV_BP.Columns(11).HeaderText = "Descripción Pesaje"


        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

    End Sub

    Private Sub FrmConsultaSCE_A013_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BImp.Enabled = False
        Me.Icon = Util.ApplicationIcon()
        Grid_Load()
    End Sub

    Private Sub BConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BConsulta.Click
        Grid_Load()
    End Sub

    Private Sub DGV_BP_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_BP.CurrentCellChanged
        Dim oldRowIndex As Object

        oldRowIndex = DGV_BP.CurrentCellAddress.Y

        If oldRowIndex <> -1 Then

            Try

                N_Folio = DGV_BP.Rows(DGV_BP.CurrentCell.RowIndex).Cells(1).Value.ToString

            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try

            BImp.Enabled = True

        End If
    End Sub

    Private Sub BImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImp.Click
        ImpBoleta()
    End Sub
End Class