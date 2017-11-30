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
Public Class FrmConsultaSP_AMEX
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
        NameTable = "Sobrepeso"
        QRY_Grid = "Select Orden_Produccion,PuestoTrabajo,Fecha_Pesaje,Hora_Pesaje,Bascula,Tramos,Rack,Peso_Bruto,"
        QRY_Grid = QRY_Grid & "Tara,Peso_Neto,Usuario,Turno,Autoriza_Sobrepeso,Observaciones,PorSobrePeso "
        QRY_Grid = QRY_Grid & "From MCPT_AutorizacionSobrepeso "
        QRY_Grid = QRY_Grid & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
        If TOrdProd.Text <> "*" Then
            QRY_Grid = QRY_Grid & "And Orden_Produccion = '" & TOrdProd.Text.Trim & "' "
        End If
        QRY_Grid = QRY_Grid & "And Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "'  "

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DGV_BP.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DGV_BP.Columns(0).HeaderText = "Orden de Producción"
        DGV_BP.Columns(1).HeaderText = "Puesto Trabajo"
        DGV_BP.Columns(2).HeaderText = "Fecha Pesaje"
        DGV_BP.Columns(3).HeaderText = "Hora Pesaje"
        DGV_BP.Columns(4).HeaderText = "Bascula"
        DGV_BP.Columns(5).HeaderText = "Cantidad de Tramos"
        DGV_BP.Columns(6).HeaderText = "Num. Rack"
        DGV_BP.Columns(7).HeaderText = "Peso Bruto"
        DGV_BP.Columns(8).HeaderText = "Peso Tara"
        DGV_BP.Columns(9).HeaderText = "Peso Neto"
        DGV_BP.Columns(10).HeaderText = "Usuario"
        DGV_BP.Columns(11).HeaderText = "Turno"
        DGV_BP.Columns(12).HeaderText = "Supervisor Autoriza"
        DGV_BP.Columns(13).HeaderText = "Descripción Sobrepeso"
        DGV_BP.Columns(13).HeaderText = "Porcentaje Sobrepeso"

    End Sub

    Private Sub FrmBoletaPesaje_A013_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Grid_Load()
    End Sub

    Private Sub BConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BConsulta.Click
        Grid_Load()
    End Sub

    Private Sub FrmConsultaSP_AMEX_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        EXTINY = ""
    End Sub

    Private Sub BExpExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExpExcel.Click
        Export_Excel(DGV_BP)
    End Sub
End Class