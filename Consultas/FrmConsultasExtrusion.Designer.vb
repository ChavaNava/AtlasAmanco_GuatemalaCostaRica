<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultasExtrusion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GB2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TCentro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.THF = New System.Windows.Forms.TextBox()
        Me.THI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_Turno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB3 = New System.Windows.Forms.GroupBox()
        Me.RB_Resumen = New System.Windows.Forms.RadioButton()
        Me.RB_Detalle = New System.Windows.Forms.RadioButton()
        Me.CB_Sub = New System.Windows.Forms.CheckBox()
        Me.CB_Notif = New System.Windows.Forms.CheckBox()
        Me.GB4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TCantpendi = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TCantEntre = New System.Windows.Forms.TextBox()
        Me.TCantEnproce = New System.Windows.Forms.TextBox()
        Me.TOrdProdSel = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TCantProgra = New System.Windows.Forms.TextBox()
        Me.GB5 = New System.Windows.Forms.GroupBox()
        Me.txtPorsprut = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotunproceso = New System.Windows.Forms.TextBox()
        Me.txtTotunprod = New System.Windows.Forms.TextBox()
        Me.txtTotunscrap = New System.Windows.Forms.TextBox()
        Me.txtTotkilosproceso = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotkilospurga = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotkilossprut = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPorscrap = New System.Windows.Forms.TextBox()
        Me.txtTotkilosprod = New System.Windows.Forms.TextBox()
        Me.txtSobrepeso = New System.Windows.Forms.TextBox()
        Me.txtTotkilosscrap = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPorcsobrepeso = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GB2.SuspendLayout()
        Me.GB3.SuspendLayout()
        Me.GB4.SuspendLayout()
        Me.GB5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1428, 506)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 22)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1422, 481)
        Me.TabControl1.TabIndex = 52
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGV1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1414, 448)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consulta Producción X Orden"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToOrderColumns = True
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV1.Location = New System.Drawing.Point(3, 3)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.Size = New System.Drawing.Size(1408, 442)
        Me.DGV1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGV2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1232, 393)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consulta Producción X Puesto de Trabajo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AllowUserToDeleteRows = False
        Me.DGV2.AllowUserToOrderColumns = True
        Me.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV2.Location = New System.Drawing.Point(3, 3)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.Size = New System.Drawing.Size(1226, 387)
        Me.DGV2.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ExportarAExcelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1428, 29)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.Atlas.My.Resources.Resources.Exit_1
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(94, 25)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Image = Global.Atlas.My.Resources.Resources.Btn_Consulta
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(117, 25)
        Me.ConsultarToolStripMenuItem.Text = "Consulta"
        '
        'ExportarAExcelToolStripMenuItem
        '
        Me.ExportarAExcelToolStripMenuItem.Image = Global.Atlas.My.Resources.Resources.Btn_Excel
        Me.ExportarAExcelToolStripMenuItem.Name = "ExportarAExcelToolStripMenuItem"
        Me.ExportarAExcelToolStripMenuItem.Size = New System.Drawing.Size(179, 25)
        Me.ExportarAExcelToolStripMenuItem.Text = "Exportar a Excel"
        '
        'GB2
        '
        Me.GB2.Controls.Add(Me.Label7)
        Me.GB2.Controls.Add(Me.TCentro)
        Me.GB2.Controls.Add(Me.Label6)
        Me.GB2.Controls.Add(Me.TOrden)
        Me.GB2.Controls.Add(Me.Label5)
        Me.GB2.Controls.Add(Me.THF)
        Me.GB2.Controls.Add(Me.THI)
        Me.GB2.Controls.Add(Me.Label4)
        Me.GB2.Controls.Add(Me.CB_Turno)
        Me.GB2.Controls.Add(Me.Label3)
        Me.GB2.Controls.Add(Me.DTP_FF)
        Me.GB2.Controls.Add(Me.DTP_FI)
        Me.GB2.Controls.Add(Me.Label2)
        Me.GB2.Controls.Add(Me.Label1)
        Me.GB2.Location = New System.Drawing.Point(0, 31)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(349, 231)
        Me.GB2.TabIndex = 51
        Me.GB2.TabStop = False
        Me.GB2.Text = "Filtros Consulta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(114, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Centro"
        '
        'TCentro
        '
        Me.TCentro.Location = New System.Drawing.Point(205, 165)
        Me.TCentro.Name = "TCentro"
        Me.TCentro.Size = New System.Drawing.Size(125, 26)
        Me.TCentro.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 20)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Orden de Producción"
        '
        'TOrden
        '
        Me.TOrden.Location = New System.Drawing.Point(205, 25)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.Size = New System.Drawing.Size(125, 26)
        Me.TOrden.TabIndex = 61
        Me.TOrden.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 20)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Hora Fin Pesaje"
        '
        'THF
        '
        Me.THF.Location = New System.Drawing.Point(205, 137)
        Me.THF.Name = "THF"
        Me.THF.Size = New System.Drawing.Size(125, 26)
        Me.THF.TabIndex = 59
        Me.THF.Text = "23:59:59"
        '
        'THI
        '
        Me.THI.Location = New System.Drawing.Point(205, 81)
        Me.THI.Name = "THI"
        Me.THI.Size = New System.Drawing.Size(125, 26)
        Me.THI.TabIndex = 58
        Me.THI.Text = "00:00:01"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Hora Inicio Pesaje"
        '
        'CB_Turno
        '
        Me.CB_Turno.FormattingEnabled = True
        Me.CB_Turno.Location = New System.Drawing.Point(205, 193)
        Me.CB_Turno.Name = "CB_Turno"
        Me.CB_Turno.Size = New System.Drawing.Size(125, 28)
        Me.CB_Turno.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Turno"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(205, 109)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(125, 26)
        Me.DTP_FF.TabIndex = 54
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(205, 53)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(125, 26)
        Me.DTP_FI.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 20)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'GB3
        '
        Me.GB3.Controls.Add(Me.RB_Resumen)
        Me.GB3.Controls.Add(Me.RB_Detalle)
        Me.GB3.Controls.Add(Me.CB_Sub)
        Me.GB3.Controls.Add(Me.CB_Notif)
        Me.GB3.Location = New System.Drawing.Point(355, 31)
        Me.GB3.Name = "GB3"
        Me.GB3.Size = New System.Drawing.Size(391, 231)
        Me.GB3.TabIndex = 52
        Me.GB3.TabStop = False
        Me.GB3.Text = "Tipo Consulta"
        '
        'RB_Resumen
        '
        Me.RB_Resumen.AutoSize = True
        Me.RB_Resumen.Location = New System.Drawing.Point(6, 57)
        Me.RB_Resumen.Name = "RB_Resumen"
        Me.RB_Resumen.Size = New System.Drawing.Size(363, 24)
        Me.RB_Resumen.TabIndex = 52
        Me.RB_Resumen.Text = "Consulta Producción X Orden Resumen"
        Me.RB_Resumen.UseVisualStyleBackColor = True
        '
        'RB_Detalle
        '
        Me.RB_Detalle.AutoSize = True
        Me.RB_Detalle.Checked = True
        Me.RB_Detalle.Location = New System.Drawing.Point(6, 27)
        Me.RB_Detalle.Name = "RB_Detalle"
        Me.RB_Detalle.Size = New System.Drawing.Size(345, 24)
        Me.RB_Detalle.TabIndex = 51
        Me.RB_Detalle.TabStop = True
        Me.RB_Detalle.Text = "Consulta Producción X Orden Detalle"
        Me.RB_Detalle.UseVisualStyleBackColor = True
        '
        'CB_Sub
        '
        Me.CB_Sub.AutoSize = True
        Me.CB_Sub.Location = New System.Drawing.Point(6, 117)
        Me.CB_Sub.Name = "CB_Sub"
        Me.CB_Sub.Size = New System.Drawing.Size(219, 24)
        Me.CB_Sub.TabIndex = 50
        Me.CB_Sub.Text = "Incluir Sub Ensambles"
        Me.CB_Sub.UseVisualStyleBackColor = True
        '
        'CB_Notif
        '
        Me.CB_Notif.AutoSize = True
        Me.CB_Notif.Location = New System.Drawing.Point(6, 87)
        Me.CB_Notif.Name = "CB_Notif"
        Me.CB_Notif.Size = New System.Drawing.Size(190, 24)
        Me.CB_Notif.TabIndex = 49
        Me.CB_Notif.Text = "Excluir Notificados"
        Me.CB_Notif.UseVisualStyleBackColor = True
        '
        'GB4
        '
        Me.GB4.Controls.Add(Me.Label14)
        Me.GB4.Controls.Add(Me.Label15)
        Me.GB4.Controls.Add(Me.TCantpendi)
        Me.GB4.Controls.Add(Me.Label17)
        Me.GB4.Controls.Add(Me.TCantEntre)
        Me.GB4.Controls.Add(Me.TCantEnproce)
        Me.GB4.Controls.Add(Me.TOrdProdSel)
        Me.GB4.Controls.Add(Me.Label16)
        Me.GB4.Controls.Add(Me.Label10)
        Me.GB4.Controls.Add(Me.TCantProgra)
        Me.GB4.Location = New System.Drawing.Point(752, 31)
        Me.GB4.Name = "GB4"
        Me.GB4.Size = New System.Drawing.Size(236, 231)
        Me.GB4.TabIndex = 53
        Me.GB4.TabStop = False
        Me.GB4.Text = "Cantidades"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(8, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 20)
        Me.Label14.TabIndex = 131
        Me.Label14.Text = "Pendiente"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(6, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 20)
        Me.Label15.TabIndex = 134
        Me.Label15.Text = "O.D.F"
        '
        'TCantpendi
        '
        Me.TCantpendi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TCantpendi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCantpendi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantpendi.Location = New System.Drawing.Point(126, 135)
        Me.TCantpendi.Name = "TCantpendi"
        Me.TCantpendi.ReadOnly = True
        Me.TCantpendi.Size = New System.Drawing.Size(87, 19)
        Me.TCantpendi.TabIndex = 132
        Me.TCantpendi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(6, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 20)
        Me.Label17.TabIndex = 127
        Me.Label17.Text = "En proceso"
        '
        'TCantEntre
        '
        Me.TCantEntre.BackColor = System.Drawing.Color.White
        Me.TCantEntre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCantEntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantEntre.Location = New System.Drawing.Point(126, 93)
        Me.TCantEntre.Name = "TCantEntre"
        Me.TCantEntre.ReadOnly = True
        Me.TCantEntre.Size = New System.Drawing.Size(87, 19)
        Me.TCantEntre.TabIndex = 129
        Me.TCantEntre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TCantEnproce
        '
        Me.TCantEnproce.BackColor = System.Drawing.Color.White
        Me.TCantEnproce.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCantEnproce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantEnproce.Location = New System.Drawing.Point(126, 114)
        Me.TCantEnproce.Name = "TCantEnproce"
        Me.TCantEnproce.ReadOnly = True
        Me.TCantEnproce.Size = New System.Drawing.Size(87, 19)
        Me.TCantEnproce.TabIndex = 130
        Me.TCantEnproce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TOrdProdSel
        '
        Me.TOrdProdSel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TOrdProdSel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TOrdProdSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOrdProdSel.ForeColor = System.Drawing.Color.White
        Me.TOrdProdSel.Location = New System.Drawing.Point(126, 51)
        Me.TOrdProdSel.Name = "TOrdProdSel"
        Me.TOrdProdSel.ReadOnly = True
        Me.TOrdProdSel.Size = New System.Drawing.Size(87, 19)
        Me.TOrdProdSel.TabIndex = 133
        Me.TOrdProdSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 93)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 20)
        Me.Label16.TabIndex = 126
        Me.Label16.Text = "Entregada"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 20)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "Programada"
        '
        'TCantProgra
        '
        Me.TCantProgra.BackColor = System.Drawing.Color.White
        Me.TCantProgra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCantProgra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantProgra.Location = New System.Drawing.Point(126, 72)
        Me.TCantProgra.Name = "TCantProgra"
        Me.TCantProgra.ReadOnly = True
        Me.TCantProgra.Size = New System.Drawing.Size(87, 19)
        Me.TCantProgra.TabIndex = 128
        Me.TCantProgra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GB5
        '
        Me.GB5.Controls.Add(Me.txtPorsprut)
        Me.GB5.Controls.Add(Me.Label8)
        Me.GB5.Controls.Add(Me.Label9)
        Me.GB5.Controls.Add(Me.Label11)
        Me.GB5.Controls.Add(Me.txtTotunproceso)
        Me.GB5.Controls.Add(Me.txtTotunprod)
        Me.GB5.Controls.Add(Me.txtTotunscrap)
        Me.GB5.Controls.Add(Me.txtTotkilosproceso)
        Me.GB5.Controls.Add(Me.Label12)
        Me.GB5.Controls.Add(Me.txtTotkilospurga)
        Me.GB5.Controls.Add(Me.Label13)
        Me.GB5.Controls.Add(Me.txtTotkilossprut)
        Me.GB5.Controls.Add(Me.Label18)
        Me.GB5.Controls.Add(Me.txtPorscrap)
        Me.GB5.Controls.Add(Me.txtTotkilosprod)
        Me.GB5.Controls.Add(Me.txtSobrepeso)
        Me.GB5.Controls.Add(Me.txtTotkilosscrap)
        Me.GB5.Controls.Add(Me.Label19)
        Me.GB5.Controls.Add(Me.Label20)
        Me.GB5.Controls.Add(Me.Label21)
        Me.GB5.Controls.Add(Me.txtPorcsobrepeso)
        Me.GB5.Location = New System.Drawing.Point(994, 31)
        Me.GB5.Name = "GB5"
        Me.GB5.Size = New System.Drawing.Size(427, 231)
        Me.GB5.TabIndex = 54
        Me.GB5.TabStop = False
        Me.GB5.Text = "Totales"
        '
        'txtPorsprut
        '
        Me.txtPorsprut.BackColor = System.Drawing.Color.Navy
        Me.txtPorsprut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPorsprut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorsprut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorsprut.ForeColor = System.Drawing.Color.White
        Me.txtPorsprut.Location = New System.Drawing.Point(316, 135)
        Me.txtPorsprut.Name = "txtPorsprut"
        Me.txtPorsprut.ReadOnly = True
        Me.txtPorsprut.Size = New System.Drawing.Size(48, 19)
        Me.txtPorsprut.TabIndex = 122
        Me.txtPorsprut.Text = "0.00"
        Me.txtPorsprut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(313, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 20)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(206, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 20)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Unidades"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(108, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 20)
        Me.Label11.TabIndex = 119
        Me.Label11.Text = "Kilos"
        '
        'txtTotunproceso
        '
        Me.txtTotunproceso.BackColor = System.Drawing.Color.White
        Me.txtTotunproceso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotunproceso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotunproceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotunproceso.Location = New System.Drawing.Point(209, 72)
        Me.txtTotunproceso.Name = "txtTotunproceso"
        Me.txtTotunproceso.ReadOnly = True
        Me.txtTotunproceso.Size = New System.Drawing.Size(78, 19)
        Me.txtTotunproceso.TabIndex = 118
        Me.txtTotunproceso.Text = "0.00"
        Me.txtTotunproceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotunprod
        '
        Me.txtTotunprod.BackColor = System.Drawing.Color.White
        Me.txtTotunprod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotunprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotunprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotunprod.Location = New System.Drawing.Point(209, 51)
        Me.txtTotunprod.Name = "txtTotunprod"
        Me.txtTotunprod.ReadOnly = True
        Me.txtTotunprod.Size = New System.Drawing.Size(78, 19)
        Me.txtTotunprod.TabIndex = 117
        Me.txtTotunprod.Text = "0.00"
        Me.txtTotunprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotunscrap
        '
        Me.txtTotunscrap.BackColor = System.Drawing.Color.White
        Me.txtTotunscrap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotunscrap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotunscrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotunscrap.Location = New System.Drawing.Point(209, 114)
        Me.txtTotunscrap.Name = "txtTotunscrap"
        Me.txtTotunscrap.ReadOnly = True
        Me.txtTotunscrap.Size = New System.Drawing.Size(78, 19)
        Me.txtTotunscrap.TabIndex = 116
        Me.txtTotunscrap.Text = "0.00"
        Me.txtTotunscrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotkilosproceso
        '
        Me.txtTotkilosproceso.BackColor = System.Drawing.Color.White
        Me.txtTotkilosproceso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotkilosproceso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotkilosproceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotkilosproceso.Location = New System.Drawing.Point(111, 72)
        Me.txtTotkilosproceso.Name = "txtTotkilosproceso"
        Me.txtTotkilosproceso.ReadOnly = True
        Me.txtTotkilosproceso.Size = New System.Drawing.Size(84, 19)
        Me.txtTotkilosproceso.TabIndex = 115
        Me.txtTotkilosproceso.Text = "0.00"
        Me.txtTotkilosproceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 20)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Proceso"
        '
        'txtTotkilospurga
        '
        Me.txtTotkilospurga.BackColor = System.Drawing.Color.White
        Me.txtTotkilospurga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotkilospurga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotkilospurga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotkilospurga.Location = New System.Drawing.Point(111, 156)
        Me.txtTotkilospurga.Name = "txtTotkilospurga"
        Me.txtTotkilospurga.ReadOnly = True
        Me.txtTotkilospurga.Size = New System.Drawing.Size(84, 19)
        Me.txtTotkilospurga.TabIndex = 113
        Me.txtTotkilospurga.Text = "0.00"
        Me.txtTotkilospurga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 20)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "Purga"
        '
        'txtTotkilossprut
        '
        Me.txtTotkilossprut.BackColor = System.Drawing.Color.White
        Me.txtTotkilossprut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotkilossprut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotkilossprut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotkilossprut.Location = New System.Drawing.Point(111, 135)
        Me.txtTotkilossprut.Name = "txtTotkilossprut"
        Me.txtTotkilossprut.ReadOnly = True
        Me.txtTotkilossprut.Size = New System.Drawing.Size(84, 19)
        Me.txtTotkilossprut.TabIndex = 111
        Me.txtTotkilossprut.Text = "0.00"
        Me.txtTotkilossprut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 135)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 20)
        Me.Label18.TabIndex = 110
        Me.Label18.Text = "Sprut"
        '
        'txtPorscrap
        '
        Me.txtPorscrap.BackColor = System.Drawing.Color.Navy
        Me.txtPorscrap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPorscrap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorscrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorscrap.ForeColor = System.Drawing.Color.White
        Me.txtPorscrap.Location = New System.Drawing.Point(316, 114)
        Me.txtPorscrap.Name = "txtPorscrap"
        Me.txtPorscrap.ReadOnly = True
        Me.txtPorscrap.Size = New System.Drawing.Size(48, 19)
        Me.txtPorscrap.TabIndex = 109
        Me.txtPorscrap.Text = "0.00"
        Me.txtPorscrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotkilosprod
        '
        Me.txtTotkilosprod.BackColor = System.Drawing.Color.White
        Me.txtTotkilosprod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotkilosprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotkilosprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotkilosprod.Location = New System.Drawing.Point(111, 51)
        Me.txtTotkilosprod.Name = "txtTotkilosprod"
        Me.txtTotkilosprod.ReadOnly = True
        Me.txtTotkilosprod.Size = New System.Drawing.Size(84, 19)
        Me.txtTotkilosprod.TabIndex = 108
        Me.txtTotkilosprod.Text = "0.00"
        Me.txtTotkilosprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSobrepeso
        '
        Me.txtSobrepeso.BackColor = System.Drawing.Color.White
        Me.txtSobrepeso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSobrepeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSobrepeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSobrepeso.Location = New System.Drawing.Point(111, 93)
        Me.txtSobrepeso.Name = "txtSobrepeso"
        Me.txtSobrepeso.ReadOnly = True
        Me.txtSobrepeso.Size = New System.Drawing.Size(84, 19)
        Me.txtSobrepeso.TabIndex = 107
        Me.txtSobrepeso.Text = "0.00"
        Me.txtSobrepeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotkilosscrap
        '
        Me.txtTotkilosscrap.BackColor = System.Drawing.Color.White
        Me.txtTotkilosscrap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotkilosscrap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotkilosscrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotkilosscrap.Location = New System.Drawing.Point(111, 114)
        Me.txtTotkilosscrap.Name = "txtTotkilosscrap"
        Me.txtTotkilosscrap.ReadOnly = True
        Me.txtTotkilosscrap.Size = New System.Drawing.Size(84, 19)
        Me.txtTotkilosscrap.TabIndex = 106
        Me.txtTotkilosscrap.Text = "0.00"
        Me.txtTotkilosscrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 114)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 20)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "Scrap"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 51)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 20)
        Me.Label20.TabIndex = 104
        Me.Label20.Text = "Producción"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 93)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 20)
        Me.Label21.TabIndex = 103
        Me.Label21.Text = "Sobrepeso"
        '
        'txtPorcsobrepeso
        '
        Me.txtPorcsobrepeso.BackColor = System.Drawing.Color.Navy
        Me.txtPorcsobrepeso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPorcsobrepeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcsobrepeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcsobrepeso.ForeColor = System.Drawing.Color.White
        Me.txtPorcsobrepeso.Location = New System.Drawing.Point(316, 93)
        Me.txtPorcsobrepeso.Name = "txtPorcsobrepeso"
        Me.txtPorcsobrepeso.ReadOnly = True
        Me.txtPorcsobrepeso.Size = New System.Drawing.Size(48, 19)
        Me.txtPorcsobrepeso.TabIndex = 102
        Me.txtPorcsobrepeso.Text = "0.00"
        Me.txtPorcsobrepeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmConsultasExtrusion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 774)
        Me.Controls.Add(Me.GB5)
        Me.Controls.Add(Me.GB4)
        Me.Controls.Add(Me.GB3)
        Me.Controls.Add(Me.GB2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmConsultasExtrusion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConsultasInyExt"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GB2.ResumeLayout(False)
        Me.GB2.PerformLayout()
        Me.GB3.ResumeLayout(False)
        Me.GB3.PerformLayout()
        Me.GB4.ResumeLayout(False)
        Me.GB4.PerformLayout()
        Me.GB5.ResumeLayout(False)
        Me.GB5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarAExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TCentro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents THF As System.Windows.Forms.TextBox
    Friend WithEvents THI As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CB_Turno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GB3 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Resumen As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Detalle As System.Windows.Forms.RadioButton
    Friend WithEvents CB_Sub As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Notif As System.Windows.Forms.CheckBox
    Friend WithEvents GB4 As System.Windows.Forms.GroupBox
    Friend WithEvents GB5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TCantpendi As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TCantEntre As System.Windows.Forms.TextBox
    Friend WithEvents TCantEnproce As System.Windows.Forms.TextBox
    Friend WithEvents TOrdProdSel As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TCantProgra As System.Windows.Forms.TextBox
    Friend WithEvents txtPorsprut As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotunproceso As System.Windows.Forms.TextBox
    Friend WithEvents txtTotunprod As System.Windows.Forms.TextBox
    Friend WithEvents txtTotunscrap As System.Windows.Forms.TextBox
    Friend WithEvents txtTotkilosproceso As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotkilospurga As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotkilossprut As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPorscrap As System.Windows.Forms.TextBox
    Friend WithEvents txtTotkilosprod As System.Windows.Forms.TextBox
    Friend WithEvents txtSobrepeso As System.Windows.Forms.TextBox
    Friend WithEvents txtTotkilosscrap As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPorcsobrepeso As System.Windows.Forms.TextBox
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
End Class
