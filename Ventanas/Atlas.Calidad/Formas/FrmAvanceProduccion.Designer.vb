<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAvanceProduccion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PFiltro = New System.Windows.Forms.Panel()
        Me.rbtEquipo = New System.Windows.Forms.RadioButton()
        Me.rbtOrden = New System.Windows.Forms.RadioButton()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCentro = New System.Windows.Forms.ComboBox()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PConsulta = New System.Windows.Forms.Panel()
        Me.GbConsulta = New System.Windows.Forms.GroupBox()
        Me.TCCalidad = New System.Windows.Forms.TabControl()
        Me.Resumen = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.dgvResumen = New System.Windows.Forms.DataGridView()
        Me.GBEstatusResumen = New System.Windows.Forms.GroupBox()
        Me.LSobrepeso = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LScrap = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Produccion = New System.Windows.Forms.TabPage()
        Me.gbProduccion = New System.Windows.Forms.GroupBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TxPOrden = New System.Windows.Forms.TextBox()
        Me.RBPPuesto = New System.Windows.Forms.RadioButton()
        Me.BtnProduccion = New System.Windows.Forms.Button()
        Me.RBPOrden = New System.Windows.Forms.RadioButton()
        Me.DTP_HPF = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DTP_HPI = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbCentroProd = New System.Windows.Forms.ComboBox()
        Me.cmbTurnoProd = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DTP_PFF = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DTP_PFI = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgvProduccion = New System.Windows.Forms.DataGridView()
        Me.GBEstatusProduccion = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Scrap = New System.Windows.Forms.TabPage()
        Me.gbScrap = New System.Windows.Forms.GroupBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.TxSOrden = New System.Windows.Forms.TextBox()
        Me.RBSPuesto = New System.Windows.Forms.RadioButton()
        Me.BtnScrap = New System.Windows.Forms.Button()
        Me.RBSOrden = New System.Windows.Forms.RadioButton()
        Me.DTP_SHF = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.DTP_SHI = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbCentroScrap = New System.Windows.Forms.ComboBox()
        Me.cmbTurnoScrap = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DTP_SFF = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DTP_SFI = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dgvScrap = New System.Windows.Forms.DataGridView()
        Me.GBEstatusScrap = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.PFiltro.SuspendLayout()
        Me.PConsulta.SuspendLayout()
        Me.GbConsulta.SuspendLayout()
        Me.TCCalidad.SuspendLayout()
        Me.Resumen.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBEstatusResumen.SuspendLayout()
        Me.Produccion.SuspendLayout()
        Me.gbProduccion.SuspendLayout()
        CType(Me.dgvProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBEstatusProduccion.SuspendLayout()
        Me.Scrap.SuspendLayout()
        Me.gbScrap.SuspendLayout()
        CType(Me.dgvScrap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBEstatusScrap.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.ExportarAExcelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1482, 28)
        Me.MenuStrip1.TabIndex = 47
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.Atlas.Calidad.My.Resources.Resources.Exit_1
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ExportarAExcelToolStripMenuItem
        '
        Me.ExportarAExcelToolStripMenuItem.Image = Global.Atlas.Calidad.My.Resources.Resources.Btn_Excel
        Me.ExportarAExcelToolStripMenuItem.Name = "ExportarAExcelToolStripMenuItem"
        Me.ExportarAExcelToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.ExportarAExcelToolStripMenuItem.Text = "Exportar a Excel"
        '
        'PFiltro
        '
        Me.PFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PFiltro.Controls.Add(Me.rbtEquipo)
        Me.PFiltro.Controls.Add(Me.rbtOrden)
        Me.PFiltro.Controls.Add(Me.BtnConsulta)
        Me.PFiltro.Controls.Add(Me.Label4)
        Me.PFiltro.Controls.Add(Me.cmbCentro)
        Me.PFiltro.Controls.Add(Me.cmbTurno)
        Me.PFiltro.Controls.Add(Me.Label3)
        Me.PFiltro.Controls.Add(Me.DTP_FF)
        Me.PFiltro.Controls.Add(Me.Label2)
        Me.PFiltro.Controls.Add(Me.DTP_FI)
        Me.PFiltro.Controls.Add(Me.Label1)
        Me.PFiltro.Location = New System.Drawing.Point(0, 29)
        Me.PFiltro.Name = "PFiltro"
        Me.PFiltro.Size = New System.Drawing.Size(1482, 203)
        Me.PFiltro.TabIndex = 48
        '
        'rbtEquipo
        '
        Me.rbtEquipo.AutoSize = True
        Me.rbtEquipo.Location = New System.Drawing.Point(319, 84)
        Me.rbtEquipo.Name = "rbtEquipo"
        Me.rbtEquipo.Size = New System.Drawing.Size(160, 21)
        Me.rbtEquipo.TabIndex = 2
        Me.rbtEquipo.Text = "Puesto de Trabajo"
        Me.rbtEquipo.UseVisualStyleBackColor = True
        '
        'rbtOrden
        '
        Me.rbtOrden.AutoSize = True
        Me.rbtOrden.Checked = True
        Me.rbtOrden.Location = New System.Drawing.Point(53, 84)
        Me.rbtOrden.Name = "rbtOrden"
        Me.rbtOrden.Size = New System.Drawing.Size(180, 21)
        Me.rbtOrden.TabIndex = 1
        Me.rbtOrden.TabStop = True
        Me.rbtOrden.Text = "Orden de Producción"
        Me.rbtOrden.UseVisualStyleBackColor = True
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Image = Global.Atlas.Calidad.My.Resources.Resources.Btn_Consulta
        Me.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsulta.Location = New System.Drawing.Point(158, 129)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(283, 43)
        Me.BtnConsulta.TabIndex = 62
        Me.BtnConsulta.Text = "Consulta"
        Me.BtnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Turno"
        '
        'cmbCentro
        '
        Me.cmbCentro.FormattingEnabled = True
        Me.cmbCentro.Location = New System.Drawing.Point(129, 41)
        Me.cmbCentro.Name = "cmbCentro"
        Me.cmbCentro.Size = New System.Drawing.Size(120, 25)
        Me.cmbCentro.TabIndex = 60
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Location = New System.Drawing.Point(382, 41)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(120, 25)
        Me.cmbTurno.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Centro"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(382, 8)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(120, 23)
        Me.DTP_FF.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Fecha Fin"
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(129, 8)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(120, 23)
        Me.DTP_FI.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Fecha Inicio"
        '
        'PConsulta
        '
        Me.PConsulta.Controls.Add(Me.GbConsulta)
        Me.PConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PConsulta.Location = New System.Drawing.Point(0, 233)
        Me.PConsulta.Name = "PConsulta"
        Me.PConsulta.Size = New System.Drawing.Size(1482, 480)
        Me.PConsulta.TabIndex = 50
        '
        'GbConsulta
        '
        Me.GbConsulta.Controls.Add(Me.TCCalidad)
        Me.GbConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbConsulta.Location = New System.Drawing.Point(0, 0)
        Me.GbConsulta.Name = "GbConsulta"
        Me.GbConsulta.Size = New System.Drawing.Size(1482, 480)
        Me.GbConsulta.TabIndex = 51
        Me.GbConsulta.TabStop = False
        Me.GbConsulta.Text = "Consulta"
        '
        'TCCalidad
        '
        Me.TCCalidad.Controls.Add(Me.Resumen)
        Me.TCCalidad.Controls.Add(Me.Produccion)
        Me.TCCalidad.Controls.Add(Me.Scrap)
        Me.TCCalidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCCalidad.Location = New System.Drawing.Point(3, 19)
        Me.TCCalidad.Name = "TCCalidad"
        Me.TCCalidad.SelectedIndex = 0
        Me.TCCalidad.Size = New System.Drawing.Size(1476, 458)
        Me.TCCalidad.TabIndex = 0
        '
        'Resumen
        '
        Me.Resumen.Controls.Add(Me.Panel11)
        Me.Resumen.Controls.Add(Me.GBEstatusResumen)
        Me.Resumen.Location = New System.Drawing.Point(4, 26)
        Me.Resumen.Name = "Resumen"
        Me.Resumen.Padding = New System.Windows.Forms.Padding(3)
        Me.Resumen.Size = New System.Drawing.Size(1468, 428)
        Me.Resumen.TabIndex = 0
        Me.Resumen.Text = "Resumen"
        Me.Resumen.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.dgvResumen)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(3, 82)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1462, 343)
        Me.Panel11.TabIndex = 7
        '
        'dgvResumen
        '
        Me.dgvResumen.AllowUserToAddRows = False
        Me.dgvResumen.AllowUserToDeleteRows = False
        Me.dgvResumen.AllowUserToOrderColumns = True
        Me.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvResumen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResumen.Location = New System.Drawing.Point(0, 0)
        Me.dgvResumen.Name = "dgvResumen"
        Me.dgvResumen.ReadOnly = True
        Me.dgvResumen.Size = New System.Drawing.Size(1462, 343)
        Me.dgvResumen.TabIndex = 6
        '
        'GBEstatusResumen
        '
        Me.GBEstatusResumen.Controls.Add(Me.LSobrepeso)
        Me.GBEstatusResumen.Controls.Add(Me.Label17)
        Me.GBEstatusResumen.Controls.Add(Me.LScrap)
        Me.GBEstatusResumen.Controls.Add(Me.Label14)
        Me.GBEstatusResumen.Controls.Add(Me.Label11)
        Me.GBEstatusResumen.Controls.Add(Me.Label12)
        Me.GBEstatusResumen.Controls.Add(Me.Panel8)
        Me.GBEstatusResumen.Controls.Add(Me.Panel9)
        Me.GBEstatusResumen.Controls.Add(Me.Label13)
        Me.GBEstatusResumen.Controls.Add(Me.Panel10)
        Me.GBEstatusResumen.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBEstatusResumen.Location = New System.Drawing.Point(3, 3)
        Me.GBEstatusResumen.Name = "GBEstatusResumen"
        Me.GBEstatusResumen.Size = New System.Drawing.Size(1462, 79)
        Me.GBEstatusResumen.TabIndex = 6
        Me.GBEstatusResumen.TabStop = False
        Me.GBEstatusResumen.Text = "Estatus Resumen"
        '
        'LSobrepeso
        '
        Me.LSobrepeso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LSobrepeso.Location = New System.Drawing.Point(1258, 23)
        Me.LSobrepeso.Name = "LSobrepeso"
        Me.LSobrepeso.Size = New System.Drawing.Size(140, 40)
        Me.LSobrepeso.TabIndex = 15
        Me.LSobrepeso.Text = "0.00"
        Me.LSobrepeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(1132, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 40)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "% Global Sobrepeso"
        '
        'LScrap
        '
        Me.LScrap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LScrap.Location = New System.Drawing.Point(959, 23)
        Me.LScrap.Name = "LScrap"
        Me.LScrap.Size = New System.Drawing.Size(140, 40)
        Me.LScrap.TabIndex = 13
        Me.LScrap.Text = "0.00"
        Me.LScrap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(837, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 40)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "% Global Scrap"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(581, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(164, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Avance mayor al 85%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(312, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Avance mayor al 70%"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Red
        Me.Panel8.Location = New System.Drawing.Point(547, 33)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(28, 20)
        Me.Panel8.TabIndex = 10
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Yellow
        Me.Panel9.Location = New System.Drawing.Point(278, 33)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(28, 20)
        Me.Panel9.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(56, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 17)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Notificando Producción"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LightGreen
        Me.Panel10.Location = New System.Drawing.Point(22, 33)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(28, 20)
        Me.Panel10.TabIndex = 6
        '
        'Produccion
        '
        Me.Produccion.Controls.Add(Me.gbProduccion)
        Me.Produccion.Controls.Add(Me.GBEstatusProduccion)
        Me.Produccion.Location = New System.Drawing.Point(4, 26)
        Me.Produccion.Name = "Produccion"
        Me.Produccion.Padding = New System.Windows.Forms.Padding(3)
        Me.Produccion.Size = New System.Drawing.Size(1468, 428)
        Me.Produccion.TabIndex = 1
        Me.Produccion.Text = "Detalle Producción"
        Me.Produccion.UseVisualStyleBackColor = True
        '
        'gbProduccion
        '
        Me.gbProduccion.Controls.Add(Me.Label52)
        Me.gbProduccion.Controls.Add(Me.TxPOrden)
        Me.gbProduccion.Controls.Add(Me.RBPPuesto)
        Me.gbProduccion.Controls.Add(Me.BtnProduccion)
        Me.gbProduccion.Controls.Add(Me.RBPOrden)
        Me.gbProduccion.Controls.Add(Me.DTP_HPF)
        Me.gbProduccion.Controls.Add(Me.Label19)
        Me.gbProduccion.Controls.Add(Me.DTP_HPI)
        Me.gbProduccion.Controls.Add(Me.Label20)
        Me.gbProduccion.Controls.Add(Me.Label21)
        Me.gbProduccion.Controls.Add(Me.cmbCentroProd)
        Me.gbProduccion.Controls.Add(Me.cmbTurnoProd)
        Me.gbProduccion.Controls.Add(Me.Label22)
        Me.gbProduccion.Controls.Add(Me.DTP_PFF)
        Me.gbProduccion.Controls.Add(Me.Label15)
        Me.gbProduccion.Controls.Add(Me.DTP_PFI)
        Me.gbProduccion.Controls.Add(Me.Label18)
        Me.gbProduccion.Controls.Add(Me.dgvProduccion)
        Me.gbProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbProduccion.Location = New System.Drawing.Point(3, 69)
        Me.gbProduccion.Name = "gbProduccion"
        Me.gbProduccion.Size = New System.Drawing.Size(1462, 356)
        Me.gbProduccion.TabIndex = 8
        Me.gbProduccion.TabStop = False
        Me.gbProduccion.Text = "Consulta Producción"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(943, 122)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(53, 17)
        Me.Label52.TabIndex = 93
        Me.Label52.Text = "Orden"
        '
        'TxPOrden
        '
        Me.TxPOrden.Location = New System.Drawing.Point(1009, 119)
        Me.TxPOrden.Name = "TxPOrden"
        Me.TxPOrden.Size = New System.Drawing.Size(120, 23)
        Me.TxPOrden.TabIndex = 92
        '
        'RBPPuesto
        '
        Me.RBPPuesto.AutoSize = True
        Me.RBPPuesto.Location = New System.Drawing.Point(1009, 191)
        Me.RBPPuesto.Name = "RBPPuesto"
        Me.RBPPuesto.Size = New System.Drawing.Size(160, 21)
        Me.RBPPuesto.TabIndex = 84
        Me.RBPPuesto.Text = "Puesto de Trabajo"
        Me.RBPPuesto.UseVisualStyleBackColor = True
        '
        'BtnProduccion
        '
        Me.BtnProduccion.Image = Global.Atlas.Calidad.My.Resources.Resources.Btn_Consulta
        Me.BtnProduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProduccion.Location = New System.Drawing.Point(1053, 242)
        Me.BtnProduccion.Name = "BtnProduccion"
        Me.BtnProduccion.Size = New System.Drawing.Size(283, 43)
        Me.BtnProduccion.TabIndex = 81
        Me.BtnProduccion.Text = "Consulta"
        Me.BtnProduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProduccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnProduccion.UseVisualStyleBackColor = True
        '
        'RBPOrden
        '
        Me.RBPOrden.AutoSize = True
        Me.RBPOrden.Checked = True
        Me.RBPOrden.Location = New System.Drawing.Point(1009, 161)
        Me.RBPOrden.Name = "RBPOrden"
        Me.RBPOrden.Size = New System.Drawing.Size(180, 21)
        Me.RBPOrden.TabIndex = 82
        Me.RBPOrden.TabStop = True
        Me.RBPOrden.Text = "Orden de Producción"
        Me.RBPOrden.UseVisualStyleBackColor = True
        '
        'DTP_HPF
        '
        Me.DTP_HPF.CustomFormat = "HH:mm:ss"
        Me.DTP_HPF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_HPF.Location = New System.Drawing.Point(1252, 55)
        Me.DTP_HPF.Name = "DTP_HPF"
        Me.DTP_HPF.ShowUpDown = True
        Me.DTP_HPF.Size = New System.Drawing.Size(120, 23)
        Me.DTP_HPF.TabIndex = 91
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1164, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 17)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = "Hora Fin"
        '
        'DTP_HPI
        '
        Me.DTP_HPI.CustomFormat = "HH:mm:ss"
        Me.DTP_HPI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_HPI.Location = New System.Drawing.Point(1009, 55)
        Me.DTP_HPI.Name = "DTP_HPI"
        Me.DTP_HPI.ShowUpDown = True
        Me.DTP_HPI.Size = New System.Drawing.Size(120, 23)
        Me.DTP_HPI.TabIndex = 89
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(902, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 17)
        Me.Label20.TabIndex = 88
        Me.Label20.Text = "Hora Inicio"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1189, 91)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 17)
        Me.Label21.TabIndex = 87
        Me.Label21.Text = "Turno"
        '
        'cmbCentroProd
        '
        Me.cmbCentroProd.FormattingEnabled = True
        Me.cmbCentroProd.Location = New System.Drawing.Point(1009, 88)
        Me.cmbCentroProd.Name = "cmbCentroProd"
        Me.cmbCentroProd.Size = New System.Drawing.Size(120, 25)
        Me.cmbCentroProd.TabIndex = 86
        '
        'cmbTurnoProd
        '
        Me.cmbTurnoProd.FormattingEnabled = True
        Me.cmbTurnoProd.Location = New System.Drawing.Point(1252, 88)
        Me.cmbTurnoProd.Name = "cmbTurnoProd"
        Me.cmbTurnoProd.Size = New System.Drawing.Size(120, 25)
        Me.cmbTurnoProd.TabIndex = 85
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(938, 91)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 17)
        Me.Label22.TabIndex = 83
        Me.Label22.Text = "Centro"
        '
        'DTP_PFF
        '
        Me.DTP_PFF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_PFF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_PFF.Location = New System.Drawing.Point(1252, 22)
        Me.DTP_PFF.Name = "DTP_PFF"
        Me.DTP_PFF.Size = New System.Drawing.Size(120, 23)
        Me.DTP_PFF.TabIndex = 80
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1154, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 17)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "Fecha Fin"
        '
        'DTP_PFI
        '
        Me.DTP_PFI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_PFI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_PFI.Location = New System.Drawing.Point(1009, 22)
        Me.DTP_PFI.Name = "DTP_PFI"
        Me.DTP_PFI.Size = New System.Drawing.Size(120, 23)
        Me.DTP_PFI.TabIndex = 78
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(892, 27)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 17)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Fecha Inicio"
        '
        'dgvProduccion
        '
        Me.dgvProduccion.AllowUserToAddRows = False
        Me.dgvProduccion.AllowUserToDeleteRows = False
        Me.dgvProduccion.AllowUserToOrderColumns = True
        Me.dgvProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvProduccion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduccion.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvProduccion.Location = New System.Drawing.Point(3, 19)
        Me.dgvProduccion.Name = "dgvProduccion"
        Me.dgvProduccion.ReadOnly = True
        Me.dgvProduccion.Size = New System.Drawing.Size(770, 334)
        Me.dgvProduccion.TabIndex = 7
        '
        'GBEstatusProduccion
        '
        Me.GBEstatusProduccion.Controls.Add(Me.Label8)
        Me.GBEstatusProduccion.Controls.Add(Me.Label9)
        Me.GBEstatusProduccion.Controls.Add(Me.Panel5)
        Me.GBEstatusProduccion.Controls.Add(Me.Panel6)
        Me.GBEstatusProduccion.Controls.Add(Me.Label10)
        Me.GBEstatusProduccion.Controls.Add(Me.Panel7)
        Me.GBEstatusProduccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBEstatusProduccion.Location = New System.Drawing.Point(3, 3)
        Me.GBEstatusProduccion.Name = "GBEstatusProduccion"
        Me.GBEstatusProduccion.Size = New System.Drawing.Size(1462, 66)
        Me.GBEstatusProduccion.TabIndex = 7
        Me.GBEstatusProduccion.TabStop = False
        Me.GBEstatusProduccion.Text = "Estatus Producción"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(576, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Producción Cancelada"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(312, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Producción en Proceso"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Red
        Me.Panel5.Location = New System.Drawing.Point(542, 33)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(28, 20)
        Me.Panel5.TabIndex = 10
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Yellow
        Me.Panel6.Location = New System.Drawing.Point(278, 33)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(28, 20)
        Me.Panel6.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Producción Notificada"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightGreen
        Me.Panel7.Location = New System.Drawing.Point(22, 33)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(28, 20)
        Me.Panel7.TabIndex = 6
        '
        'Scrap
        '
        Me.Scrap.Controls.Add(Me.gbScrap)
        Me.Scrap.Controls.Add(Me.GBEstatusScrap)
        Me.Scrap.Location = New System.Drawing.Point(4, 26)
        Me.Scrap.Name = "Scrap"
        Me.Scrap.Padding = New System.Windows.Forms.Padding(3)
        Me.Scrap.Size = New System.Drawing.Size(1468, 424)
        Me.Scrap.TabIndex = 2
        Me.Scrap.Text = "Detalle Scrap"
        Me.Scrap.UseVisualStyleBackColor = True
        '
        'gbScrap
        '
        Me.gbScrap.Controls.Add(Me.Label53)
        Me.gbScrap.Controls.Add(Me.TxSOrden)
        Me.gbScrap.Controls.Add(Me.RBSPuesto)
        Me.gbScrap.Controls.Add(Me.BtnScrap)
        Me.gbScrap.Controls.Add(Me.RBSOrden)
        Me.gbScrap.Controls.Add(Me.DTP_SHF)
        Me.gbScrap.Controls.Add(Me.Label23)
        Me.gbScrap.Controls.Add(Me.DTP_SHI)
        Me.gbScrap.Controls.Add(Me.Label24)
        Me.gbScrap.Controls.Add(Me.Label25)
        Me.gbScrap.Controls.Add(Me.cmbCentroScrap)
        Me.gbScrap.Controls.Add(Me.cmbTurnoScrap)
        Me.gbScrap.Controls.Add(Me.Label26)
        Me.gbScrap.Controls.Add(Me.DTP_SFF)
        Me.gbScrap.Controls.Add(Me.Label27)
        Me.gbScrap.Controls.Add(Me.DTP_SFI)
        Me.gbScrap.Controls.Add(Me.Label28)
        Me.gbScrap.Controls.Add(Me.dgvScrap)
        Me.gbScrap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbScrap.Location = New System.Drawing.Point(3, 69)
        Me.gbScrap.Name = "gbScrap"
        Me.gbScrap.Size = New System.Drawing.Size(1462, 352)
        Me.gbScrap.TabIndex = 9
        Me.gbScrap.TabStop = False
        Me.gbScrap.Text = "Consulta Scrap"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(843, 129)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(53, 17)
        Me.Label53.TabIndex = 108
        Me.Label53.Text = "Orden"
        '
        'TxSOrden
        '
        Me.TxSOrden.Location = New System.Drawing.Point(909, 126)
        Me.TxSOrden.Name = "TxSOrden"
        Me.TxSOrden.Size = New System.Drawing.Size(173, 23)
        Me.TxSOrden.TabIndex = 107
        '
        'RBSPuesto
        '
        Me.RBSPuesto.AutoSize = True
        Me.RBSPuesto.Location = New System.Drawing.Point(909, 218)
        Me.RBSPuesto.Name = "RBSPuesto"
        Me.RBSPuesto.Size = New System.Drawing.Size(160, 21)
        Me.RBSPuesto.TabIndex = 99
        Me.RBSPuesto.Text = "Puesto de Trabajo"
        Me.RBSPuesto.UseVisualStyleBackColor = True
        '
        'BtnScrap
        '
        Me.BtnScrap.Image = Global.Atlas.Calidad.My.Resources.Resources.Btn_Consulta
        Me.BtnScrap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnScrap.Location = New System.Drawing.Point(943, 283)
        Me.BtnScrap.Name = "BtnScrap"
        Me.BtnScrap.Size = New System.Drawing.Size(283, 43)
        Me.BtnScrap.TabIndex = 96
        Me.BtnScrap.Text = "Consulta"
        Me.BtnScrap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnScrap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnScrap.UseVisualStyleBackColor = True
        '
        'RBSOrden
        '
        Me.RBSOrden.AutoSize = True
        Me.RBSOrden.Checked = True
        Me.RBSOrden.Location = New System.Drawing.Point(909, 188)
        Me.RBSOrden.Name = "RBSOrden"
        Me.RBSOrden.Size = New System.Drawing.Size(180, 21)
        Me.RBSOrden.TabIndex = 97
        Me.RBSOrden.TabStop = True
        Me.RBSOrden.Text = "Orden de Producción"
        Me.RBSOrden.UseVisualStyleBackColor = True
        '
        'DTP_SHF
        '
        Me.DTP_SHF.CustomFormat = "HH:mm:ss"
        Me.DTP_SHF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_SHF.Location = New System.Drawing.Point(1152, 59)
        Me.DTP_SHF.Name = "DTP_SHF"
        Me.DTP_SHF.ShowUpDown = True
        Me.DTP_SHF.Size = New System.Drawing.Size(120, 23)
        Me.DTP_SHF.TabIndex = 106
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(1064, 64)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 17)
        Me.Label23.TabIndex = 105
        Me.Label23.Text = "Hora Fin"
        '
        'DTP_SHI
        '
        Me.DTP_SHI.CustomFormat = "HH:mm:ss"
        Me.DTP_SHI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_SHI.Location = New System.Drawing.Point(909, 59)
        Me.DTP_SHI.Name = "DTP_SHI"
        Me.DTP_SHI.ShowUpDown = True
        Me.DTP_SHI.Size = New System.Drawing.Size(120, 23)
        Me.DTP_SHI.TabIndex = 104
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(802, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 17)
        Me.Label24.TabIndex = 103
        Me.Label24.Text = "Hora Inicio"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(1089, 95)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 17)
        Me.Label25.TabIndex = 102
        Me.Label25.Text = "Turno"
        '
        'cmbCentroScrap
        '
        Me.cmbCentroScrap.FormattingEnabled = True
        Me.cmbCentroScrap.Location = New System.Drawing.Point(909, 92)
        Me.cmbCentroScrap.Name = "cmbCentroScrap"
        Me.cmbCentroScrap.Size = New System.Drawing.Size(120, 25)
        Me.cmbCentroScrap.TabIndex = 101
        '
        'cmbTurnoScrap
        '
        Me.cmbTurnoScrap.FormattingEnabled = True
        Me.cmbTurnoScrap.Location = New System.Drawing.Point(1152, 92)
        Me.cmbTurnoScrap.Name = "cmbTurnoScrap"
        Me.cmbTurnoScrap.Size = New System.Drawing.Size(120, 25)
        Me.cmbTurnoScrap.TabIndex = 100
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(838, 95)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(56, 17)
        Me.Label26.TabIndex = 98
        Me.Label26.Text = "Centro"
        '
        'DTP_SFF
        '
        Me.DTP_SFF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_SFF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_SFF.Location = New System.Drawing.Point(1152, 26)
        Me.DTP_SFF.Name = "DTP_SFF"
        Me.DTP_SFF.Size = New System.Drawing.Size(120, 23)
        Me.DTP_SFF.TabIndex = 95
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(1054, 31)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 17)
        Me.Label27.TabIndex = 94
        Me.Label27.Text = "Fecha Fin"
        '
        'DTP_SFI
        '
        Me.DTP_SFI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_SFI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_SFI.Location = New System.Drawing.Point(909, 26)
        Me.DTP_SFI.Name = "DTP_SFI"
        Me.DTP_SFI.Size = New System.Drawing.Size(120, 23)
        Me.DTP_SFI.TabIndex = 93
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(792, 31)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(95, 17)
        Me.Label28.TabIndex = 92
        Me.Label28.Text = "Fecha Inicio"
        '
        'dgvScrap
        '
        Me.dgvScrap.AllowUserToAddRows = False
        Me.dgvScrap.AllowUserToDeleteRows = False
        Me.dgvScrap.AllowUserToOrderColumns = True
        Me.dgvScrap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvScrap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvScrap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScrap.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvScrap.Location = New System.Drawing.Point(3, 19)
        Me.dgvScrap.Name = "dgvScrap"
        Me.dgvScrap.ReadOnly = True
        Me.dgvScrap.Size = New System.Drawing.Size(770, 330)
        Me.dgvScrap.TabIndex = 8
        '
        'GBEstatusScrap
        '
        Me.GBEstatusScrap.Controls.Add(Me.Label7)
        Me.GBEstatusScrap.Controls.Add(Me.Label6)
        Me.GBEstatusScrap.Controls.Add(Me.Panel4)
        Me.GBEstatusScrap.Controls.Add(Me.Panel3)
        Me.GBEstatusScrap.Controls.Add(Me.Label5)
        Me.GBEstatusScrap.Controls.Add(Me.Panel1)
        Me.GBEstatusScrap.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBEstatusScrap.Location = New System.Drawing.Point(3, 3)
        Me.GBEstatusScrap.Name = "GBEstatusScrap"
        Me.GBEstatusScrap.Size = New System.Drawing.Size(1462, 66)
        Me.GBEstatusScrap.TabIndex = 8
        Me.GBEstatusScrap.TabStop = False
        Me.GBEstatusScrap.Text = "Estatus Scrap"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(478, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Scrap Cancelado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(263, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Scrap en Proceso"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Location = New System.Drawing.Point(444, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(28, 20)
        Me.Panel4.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Yellow
        Me.Panel3.Location = New System.Drawing.Point(229, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(28, 20)
        Me.Panel3.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Scrap Notificado"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Location = New System.Drawing.Point(22, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(28, 20)
        Me.Panel1.TabIndex = 0
        '
        'FrmAvanceProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 713)
        Me.Controls.Add(Me.PConsulta)
        Me.Controls.Add(Me.PFiltro)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAvanceProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAvanceProduccion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PFiltro.ResumeLayout(False)
        Me.PFiltro.PerformLayout()
        Me.PConsulta.ResumeLayout(False)
        Me.GbConsulta.ResumeLayout(False)
        Me.TCCalidad.ResumeLayout(False)
        Me.Resumen.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBEstatusResumen.ResumeLayout(False)
        Me.GBEstatusResumen.PerformLayout()
        Me.Produccion.ResumeLayout(False)
        Me.gbProduccion.ResumeLayout(False)
        Me.gbProduccion.PerformLayout()
        CType(Me.dgvProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBEstatusProduccion.ResumeLayout(False)
        Me.GBEstatusProduccion.PerformLayout()
        Me.Scrap.ResumeLayout(False)
        Me.gbScrap.ResumeLayout(False)
        Me.gbScrap.PerformLayout()
        CType(Me.dgvScrap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBEstatusScrap.ResumeLayout(False)
        Me.GBEstatusScrap.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarAExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PFiltro As System.Windows.Forms.Panel
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCentro As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents PConsulta As System.Windows.Forms.Panel
    Friend WithEvents GbConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents rbtEquipo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtOrden As System.Windows.Forms.RadioButton
    Friend WithEvents TCCalidad As System.Windows.Forms.TabControl
    Friend WithEvents Resumen As System.Windows.Forms.TabPage
    Friend WithEvents GBEstatusResumen As System.Windows.Forms.GroupBox
    Friend WithEvents Produccion As System.Windows.Forms.TabPage
    Friend WithEvents GBEstatusProduccion As System.Windows.Forms.GroupBox
    Friend WithEvents Scrap As System.Windows.Forms.TabPage
    Friend WithEvents GBEstatusScrap As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents LSobrepeso As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LScrap As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents gbProduccion As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProduccion As System.Windows.Forms.DataGridView
    Friend WithEvents gbScrap As System.Windows.Forms.GroupBox
    Friend WithEvents dgvScrap As System.Windows.Forms.DataGridView
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents TxPOrden As System.Windows.Forms.TextBox
    Friend WithEvents RBPPuesto As System.Windows.Forms.RadioButton
    Friend WithEvents BtnProduccion As System.Windows.Forms.Button
    Friend WithEvents RBPOrden As System.Windows.Forms.RadioButton
    Friend WithEvents DTP_HPF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DTP_HPI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbCentroProd As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTurnoProd As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents DTP_PFF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DTP_PFI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents TxSOrden As System.Windows.Forms.TextBox
    Friend WithEvents RBSPuesto As System.Windows.Forms.RadioButton
    Friend WithEvents BtnScrap As System.Windows.Forms.Button
    Friend WithEvents RBSOrden As System.Windows.Forms.RadioButton
    Friend WithEvents DTP_SHF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents DTP_SHI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbCentroScrap As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTurnoScrap As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents DTP_SFF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents DTP_SFI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
End Class
