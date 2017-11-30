Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA

Public Class FrmSupervision_AMEX
    Dim Str_FI As String    'Fecha inicio consulta
    Dim Str_FF As String    'Fecha fin consulta
    Dim tipo As SeriesChartType

    Sub Fill_Tipo()
        Dim NDataSet1 As New DataSet
        QryCombo = ""
        QryCombo = "SELECT Id,Descripcion "
        QryCombo = QryCombo & "FROM CAT_Graficas "
        QryCombo = QryCombo & "Order by Tipo"
        Combo(QryCombo)
        NDataSet1 = DataSetCombo.Copy
        CB_Tipo.DataSource = NDataSet1.Tables(0)
        CB_Tipo.DisplayMember = "Descripcion"
        CB_Tipo.ValueMember = "Id"
    End Sub

    Sub Graficas()

        tipo = CB_Tipo.SelectedValue

        Chart1.DataSource = objDRes.Tables(0)
        Chart1.Series(0).IsValueShownAsLabel = True
        Chart1.Series(0).Name = "Producción"
        Chart1.Series(0).ChartType = tipo
        Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        If RB1.Checked = True Then
            Chart1.Series(0).XValueMember = "Sup_Turno"
            Chart1.Series(0).YValueMembers = "Tramos"
        Else
            Chart1.Series(0).XValueMember = "PuestoTrabajo"
            Chart1.Series(0).YValueMembers = "Tramos"
        End If

        Chart1.DataBind()

        Chart2.DataSource = objDRes.Tables(0)
        Chart2.Series(0).IsValueShownAsLabel = True
        Chart2.Series(0).Name = "Consumo Recuperado"
        Chart2.Series(0).ChartType = tipo
        Chart2.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        If RB1.Checked = True Then
            Chart2.Series(0).XValueMember = "Sup_Turno"
            Chart2.Series(0).YValueMembers = "Consumo Reprocesado"
        Else
            Chart2.Series(0).XValueMember = "PuestoTrabajo"
            Chart2.Series(0).YValueMembers = "Consumo Reprocesado"
        End If

        Chart2.DataBind()

        Chart4.DataSource = objDRes.Tables(0)
        Chart4.Series(0).IsValueShownAsLabel = True
        Chart4.Series(0).Name = "Sobre Peso"
        Chart4.Series(0).ChartType = tipo
        Chart4.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        If RB1.Checked = True Then
            Chart4.Series(0).XValueMember = "Sup_Turno"
            Chart4.Series(0).YValueMembers = "%SP"
        Else
            Chart4.Series(0).XValueMember = "PuestoTrabajo"
            Chart4.Series(0).YValueMembers = "%SP"
        End If
        Chart4.DataBind()

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub

    Sub FillCBSuper()
        Dim NDataSet1 As New DataSet
        QryCombo = ""
        QryCombo = "select * from ADM_Usuario "
        QryCombo = QryCombo & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
        QryCombo = QryCombo & "And Puesto = '3' "
        Combo_AMD(QryCombo)
        NDataSet1 = DataSetCombo.Copy
        CB_Sup.DataSource = NDataSet1.Tables(0)
        CB_Sup.DisplayMember = "Nombre"
        CB_Sup.ValueMember = "Usuario"
    End Sub

    Public Sub GL_Resumen()

        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim

        QRY_Grid = ""
        NameTable = ""
        NameTable = "Resumen"
        If RB1.Checked = True Then
            QRY_Grid = "Select Sup_Turno,sum(Tramos) as Tramos,sum(PesoReal_PT) as 'Kgs. Reales',"
            QRY_Grid = QRY_Grid & "Sum((tramos) * Peso_Teorico) as 'Kgs. Teoricos',(Sum(PesoReal_PT) / Sum(tramos)) as 'Peso_Promedio',"
            QRY_Grid = QRY_Grid & "(((sum(PesoReal_PT) - sum((tramos) * Peso_Teorico)) / sum(PesoReal_PT)) * 100) as '%SP',"
            QRY_Grid = QRY_Grid & "(sum(PesoReal_PT) - Sum((tramos) * Peso_Teorico)) as 'Variación Material',sum(VirgenPT) as 'Consumo Virgen',"
            QRY_Grid = QRY_Grid & "sum(ReprocesadoPT) as 'Consumo Reprocesado' "
            QRY_Grid = QRY_Grid & "From Super_A001 "
            QRY_Grid = QRY_Grid & "Where Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "' "
            If CB_Sup.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And Sup_Turno = '" & CB_Sup.SelectedValue.Trim & "' "
            Else
                QRY_Grid = QRY_Grid & "And Sup_Turno <> 'Supervisor' "
            End If
            QRY_Grid = QRY_Grid & "And Tipo = 'PT' "
            QRY_Grid = QRY_Grid & "Group by Sup_Turno "
        ElseIf RB2.Checked = True Then
            QRY_Grid = "Select PuestoTrabajo,sum(Tramos) as Tramos,sum(PesoReal_PT) as 'Kgs. Reales',"
            QRY_Grid = QRY_Grid & "Sum((tramos) * Peso_Teorico) as 'Kgs. Teoricos',(Sum(PesoReal_PT) / Sum(tramos)) as 'Peso_Promedio',"
            QRY_Grid = QRY_Grid & "(((sum(PesoReal_PT) - sum((tramos) * Peso_Teorico)) / sum(PesoReal_PT)) * 100) as '%SP',"
            QRY_Grid = QRY_Grid & "(sum(PesoReal_PT) - Sum((tramos) * Peso_Teorico)) as 'Variación Material',sum(VirgenPT) as 'Consumo Virgen',"
            QRY_Grid = QRY_Grid & "sum(ReprocesadoPT) as 'Consumo Reprocesado' "
            QRY_Grid = QRY_Grid & "From Super_A001 "
            QRY_Grid = QRY_Grid & "Where Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "' "
            If CB_Sup.Text <> "*" Then
                QRY_Grid = QRY_Grid & "And Sup_Turno = '" & CB_Sup.SelectedValue.Trim & "' "
            Else
                QRY_Grid = QRY_Grid & "And Sup_Turno <> 'Supervisor' "
            End If
            QRY_Grid = QRY_Grid & "And Tipo = 'PT' "
            QRY_Grid = QRY_Grid & "Group by PuestoTrabajo "
        End If

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDRes = New DataSet
            objDa.Fill(objDRes)
            DGV_Resumen.DataSource = objDRes.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "Supervision")
        End Try
        DGV_Resumen.Columns(0).HeaderText = "Supervisor"
        DGV_Resumen.Columns(1).HeaderText = "Produccion Aceptada Piezas"
        DGV_Resumen.Columns(2).HeaderText = "Produccion Aceptada Kgs"
        DGV_Resumen.Columns(3).Visible = False      'Produccion Aceptada Kgs Teorica
        DGV_Resumen.Columns(4).Visible = False      'Peso Promedio
        DGV_Resumen.Columns(5).HeaderText = "% Sobre Peso"
        DGV_Resumen.Columns(6).HeaderText = "Variación Material Kgs."
        DGV_Resumen.Columns(7).HeaderText = "Consumo Compuesto Virgen"
        DGV_Resumen.Columns(8).HeaderText = "Consumo Compuesto Reprocesado"

    End Sub


    Public Sub Grid_Load()
        Str_FI = DTP_FI.Text.Trim
        Str_FF = DTP_FF.Text.Trim

        QRY_Grid = ""
        NameTable = ""
        NameTable = "Supervision"
        QRY_Grid = "Select Sup_Turno,Fecha_Pesaje,PuestoTrabajo,Orden_Produccion,Turno,Producto,OpePtoTra,"
        QRY_Grid = QRY_Grid & "sum(Tramos) as Tramos,sum(PesoReal_PT) as 'Kgs. Reales',"
        QRY_Grid = QRY_Grid & "Case Peso_Teorico When 0 Then 0 Else Sum((tramos) * Peso_Teorico) "
        QRY_Grid = QRY_Grid & "End as 'Kgs. Teoricos',"
        QRY_Grid = QRY_Grid & "Case Peso_Teorico When 0 Then 0 Else (Sum(PesoReal_PT)/Sum(tramos)) End as 'Peso_Promedio',"
        QRY_Grid = QRY_Grid & "Peso_Teorico,Case Peso_Teorico When 0 Then 0 Else (((Sum(PesoReal_PT)/Sum(tramos)) - "
        QRY_Grid = QRY_Grid & "Peso_Teorico)/Peso_Teorico * 100) End as '% SP',Sobrepeso,sum(PesoReal_PT) - "
        QRY_Grid = QRY_Grid & "Sum((tramos) * Peso_Teorico) as 'Variación Material',sum(VirgenPT) as 'Virgen PT',"
        QRY_Grid = QRY_Grid & "sum(ReprocesadoPT) as 'Reprocesado PT',sum(VirgenSC) as 'Virgen Scrap',"
        QRY_Grid = QRY_Grid & "sum(ReprocesadoSC) as 'Reprocesado Scrap' "
        QRY_Grid = QRY_Grid & "From Super_" & SessionUser._sCentro.Trim & " "
        QRY_Grid = QRY_Grid & "Where Fecha_Pesaje Between '" & Str_FI.Trim & "' and '" & Str_FF.Trim & "' "
        If CB_Sup.Text <> "*" Then
            QRY_Grid = QRY_Grid & "And Sup_Turno = '" & CB_Sup.SelectedValue.Trim & "' "
        Else
            QRY_Grid = QRY_Grid & "And Sup_Turno <> 'Supervisor' "
        End If
        QRY_Grid = QRY_Grid & "And Tipo = 'PT' "
        QRY_Grid = QRY_Grid & "Group by Sup_Turno,Fecha_Pesaje,PuestoTrabajo,Orden_Produccion,Turno,Producto,OpePtoTra,Peso_Teorico,Sobrepeso "
        QRY_Grid = QRY_Grid & "Order by Fecha_pesaje,Turno,PuestoTrabajo "

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente))
            objDDet = New DataSet
            objDa.Fill(objDDet)
            DGV_Sup.DataSource = objDDet.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "Supervision")
        End Try
        DGV_Sup.Columns(0).HeaderText = "Supervisor"
        DGV_Sup.Columns(1).HeaderText = "Fecha Pesaje"
        DGV_Sup.Columns(2).HeaderText = "Puesto de Trabajo"
        DGV_Sup.Columns(3).HeaderText = "Orden Producción"
        DGV_Sup.Columns(4).HeaderText = "Turno"
        DGV_Sup.Columns(5).HeaderText = "Producto"
        DGV_Sup.Columns(6).HeaderText = "Operador"
        DGV_Sup.Columns(7).HeaderText = "Tramos/Piezas"
        DGV_Sup.Columns(8).HeaderText = "Kgs. Reales"
        DGV_Sup.Columns(9).HeaderText = "Kgs. Teoricos"
        DGV_Sup.Columns(10).HeaderText = "Peso Promedio"
        DGV_Sup.Columns(11).HeaderText = "Peso Teorico"
        DGV_Sup.Columns(12).HeaderText = "Porcentaje Sobre Peso"
        DGV_Sup.Columns(13).HeaderText = "Sobre Peso Autorizado"
        DGV_Sup.Columns(14).HeaderText = "Variación Material Kg."
        DGV_Sup.Columns(15).HeaderText = "PT Consumo Virgen"
        DGV_Sup.Columns(16).HeaderText = "PT Consumo Recuperado"
        DGV_Sup.Columns(17).HeaderText = "SC Consumo Virgen"
        DGV_Sup.Columns(18).HeaderText = "SC Consumo Recuperado"

    End Sub

    Private Sub FrmSupervision_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RB1.Checked = True
        FillCBSuper()
        Fill_Tipo()
    End Sub

    Private Sub RolSupervisoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RolSupervisoresToolStripMenuItem.Click
        FrmSupervision_Rol_AMEX.ShowDialog()
    End Sub

    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        Grid_Load()
        GL_Resumen()
        Graficas()
    End Sub

End Class