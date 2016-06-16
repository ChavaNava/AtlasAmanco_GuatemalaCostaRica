<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificaSC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificaSC))
        Me.GB_Pesajes = New System.Windows.Forms.GroupBox
        Me.PBActualiza = New System.Windows.Forms.ProgressBar
        Me.DGV_BP = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TTC2 = New System.Windows.Forms.TextBox
        Me.TTC1 = New System.Windows.Forms.TextBox
        Me.TTPN = New System.Windows.Forms.TextBox
        Me.TTPT = New System.Windows.Forms.TextBox
        Me.TTPB = New System.Windows.Forms.TextBox
        Me.tsbPrincipal = New System.Windows.Forms.ToolStrip
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TFol = New System.Windows.Forms.TextBox
        Me.TOrd = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CB_Turno = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TcodPt = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.TPesoNeto = New System.Windows.Forms.TextBox
        Me.TPesoBruto = New System.Windows.Forms.TextBox
        Me.lblRack = New System.Windows.Forms.Label
        Me.TPesoRack = New System.Windows.Forms.TextBox
        Me.TOrden = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TFolioAtlas = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TKC2 = New System.Windows.Forms.TextBox
        Me.TKC1 = New System.Windows.Forms.TextBox
        Me.TPComp2 = New System.Windows.Forms.TextBox
        Me.TPComp1 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TComp2 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TComp1 = New System.Windows.Forms.TextBox
        Me.BCompuesto = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.GB_Pesajes.SuspendLayout()
        CType(Me.DGV_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tsbPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_Pesajes
        '
        Me.GB_Pesajes.Controls.Add(Me.DGV_BP)
        Me.GB_Pesajes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GB_Pesajes.Location = New System.Drawing.Point(0, 309)
        Me.GB_Pesajes.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_Pesajes.Name = "GB_Pesajes"
        Me.GB_Pesajes.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_Pesajes.Size = New System.Drawing.Size(1153, 374)
        Me.GB_Pesajes.TabIndex = 0
        Me.GB_Pesajes.TabStop = False
        Me.GB_Pesajes.Text = "Pesajes"
        '
        'PBActualiza
        '
        Me.PBActualiza.Location = New System.Drawing.Point(275, 289)
        Me.PBActualiza.Name = "PBActualiza"
        Me.PBActualiza.Size = New System.Drawing.Size(653, 23)
        Me.PBActualiza.TabIndex = 302
        '
        'DGV_BP
        '
        Me.DGV_BP.AllowUserToAddRows = False
        Me.DGV_BP.AllowUserToDeleteRows = False
        Me.DGV_BP.AllowUserToOrderColumns = True
        Me.DGV_BP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_BP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_BP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_BP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_BP.Location = New System.Drawing.Point(4, 19)
        Me.DGV_BP.Name = "DGV_BP"
        Me.DGV_BP.ReadOnly = True
        Me.DGV_BP.Size = New System.Drawing.Size(1145, 351)
        Me.DGV_BP.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TTC2)
        Me.GroupBox2.Controls.Add(Me.TTC1)
        Me.GroupBox2.Controls.Add(Me.TTPN)
        Me.GroupBox2.Controls.Add(Me.TTPT)
        Me.GroupBox2.Controls.Add(Me.TTPB)
        Me.GroupBox2.Location = New System.Drawing.Point(822, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 171)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales por consulta"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(11, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 19)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Compuesto Reprocesado"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(41, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Compuesto Virgen"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(126, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Peso Neto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(126, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Peso Tara"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(123, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Peso Bruto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TTC2
        '
        Me.TTC2.Location = New System.Drawing.Point(213, 130)
        Me.TTC2.Name = "TTC2"
        Me.TTC2.ReadOnly = True
        Me.TTC2.Size = New System.Drawing.Size(100, 22)
        Me.TTC2.TabIndex = 7
        Me.TTC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TTC1
        '
        Me.TTC1.Location = New System.Drawing.Point(213, 102)
        Me.TTC1.Name = "TTC1"
        Me.TTC1.ReadOnly = True
        Me.TTC1.Size = New System.Drawing.Size(100, 22)
        Me.TTC1.TabIndex = 6
        Me.TTC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TTPN
        '
        Me.TTPN.Location = New System.Drawing.Point(213, 74)
        Me.TTPN.Name = "TTPN"
        Me.TTPN.ReadOnly = True
        Me.TTPN.Size = New System.Drawing.Size(100, 22)
        Me.TTPN.TabIndex = 4
        Me.TTPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TTPT
        '
        Me.TTPT.Location = New System.Drawing.Point(213, 46)
        Me.TTPT.Name = "TTPT"
        Me.TTPT.ReadOnly = True
        Me.TTPT.Size = New System.Drawing.Size(100, 22)
        Me.TTPT.TabIndex = 3
        Me.TTPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TTPB
        '
        Me.TTPB.Location = New System.Drawing.Point(213, 18)
        Me.TTPB.Name = "TTPB"
        Me.TTPB.ReadOnly = True
        Me.TTPB.Size = New System.Drawing.Size(100, 22)
        Me.TTPB.TabIndex = 2
        Me.TTPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbPrincipal
        '
        Me.tsbPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tsbPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCerrar, Me.ToolStripSeparator2, Me.tsbConsultar, Me.ToolStripSeparator3, Me.tsbModificar, Me.ToolStripSeparator1, Me.tsbGrabar})
        Me.tsbPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsbPrincipal.Name = "tsbPrincipal"
        Me.tsbPrincipal.Size = New System.Drawing.Size(1153, 25)
        Me.tsbPrincipal.TabIndex = 223
        Me.tsbPrincipal.Text = "ToolStrip1"
        '
        'tsbCerrar
        '
        Me.tsbCerrar.AutoSize = False
        Me.tsbCerrar.Image = CType(resources.GetObject("tsbCerrar.Image"), System.Drawing.Image)
        Me.tsbCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCerrar.Name = "tsbCerrar"
        Me.tsbCerrar.Size = New System.Drawing.Size(70, 22)
        Me.tsbCerrar.Text = "Cerrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(12, 25)
        '
        'tsbConsultar
        '
        Me.tsbConsultar.Image = CType(resources.GetObject("tsbConsultar.Image"), System.Drawing.Image)
        Me.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultar.Name = "tsbConsultar"
        Me.tsbConsultar.Size = New System.Drawing.Size(73, 22)
        Me.tsbConsultar.Text = "Consultar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(12, 25)
        '
        'tsbModificar
        '
        Me.tsbModificar.Image = CType(resources.GetObject("tsbModificar.Image"), System.Drawing.Image)
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(70, 22)
        Me.tsbModificar.Text = "Modificar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(12, 25)
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Image = CType(resources.GetObject("tsbGrabar.Image"), System.Drawing.Image)
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(66, 22)
        Me.tsbGrabar.Text = "Guardar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TFol)
        Me.GroupBox1.Controls.Add(Me.TOrd)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CB_Turno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DTP_FF)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DTP_FI)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 171)
        Me.GroupBox1.TabIndex = 268
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro Consulta"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(120, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 16)
        Me.Label14.TabIndex = 279
        Me.Label14.Text = "Folio"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TFol
        '
        Me.TFol.BackColor = System.Drawing.SystemColors.Window
        Me.TFol.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TFol.Location = New System.Drawing.Point(169, 108)
        Me.TFol.MaxLength = 10
        Me.TFol.Name = "TFol"
        Me.TFol.Size = New System.Drawing.Size(122, 22)
        Me.TFol.TabIndex = 278
        Me.TFol.Text = "*"
        Me.TFol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TOrd
        '
        Me.TOrd.BackColor = System.Drawing.SystemColors.Window
        Me.TOrd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TOrd.Location = New System.Drawing.Point(169, 80)
        Me.TOrd.MaxLength = 10
        Me.TOrd.Name = "TOrd"
        Me.TOrd.Size = New System.Drawing.Size(122, 22)
        Me.TOrd.TabIndex = 277
        Me.TOrd.Text = "*"
        Me.TOrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(9, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 16)
        Me.Label11.TabIndex = 276
        Me.Label11.Text = "Orden de Producción"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CB_Turno
        '
        Me.CB_Turno.FormattingEnabled = True
        Me.CB_Turno.Location = New System.Drawing.Point(169, 136)
        Me.CB_Turno.Name = "CB_Turno"
        Me.CB_Turno.Size = New System.Drawing.Size(77, 24)
        Me.CB_Turno.TabIndex = 275
        Me.CB_Turno.Text = "*"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(115, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 274
        Me.Label3.Text = "Turno"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(34, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 273
        Me.Label2.Text = "Fecha Fin Pesaje"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(169, 52)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(122, 22)
        Me.DTP_FF.TabIndex = 272
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 271
        Me.Label1.Text = "Fecha Inicio Pesaje"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(169, 24)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(122, 22)
        Me.DTP_FI.TabIndex = 270
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TcodPt)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.TPesoNeto)
        Me.GroupBox3.Controls.Add(Me.TPesoBruto)
        Me.GroupBox3.Controls.Add(Me.lblRack)
        Me.GroupBox3.Controls.Add(Me.TPesoRack)
        Me.GroupBox3.Controls.Add(Me.TOrden)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TFolioAtlas)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(317, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(499, 171)
        Me.GroupBox3.TabIndex = 269
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información Pesaje"
        '
        'TcodPt
        '
        Me.TcodPt.Location = New System.Drawing.Point(389, 18)
        Me.TcodPt.Name = "TcodPt"
        Me.TcodPt.ReadOnly = True
        Me.TcodPt.Size = New System.Drawing.Size(100, 22)
        Me.TcodPt.TabIndex = 281
        Me.TcodPt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(265, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(118, 16)
        Me.Label22.TabIndex = 282
        Me.Label22.Text = "Código Material"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(72, 133)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 16)
        Me.Label20.TabIndex = 272
        Me.Label20.Text = "Peso Neto"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(69, 77)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 16)
        Me.Label19.TabIndex = 270
        Me.Label19.Text = "Peso Bruto"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TPesoNeto
        '
        Me.TPesoNeto.Location = New System.Drawing.Point(159, 130)
        Me.TPesoNeto.Name = "TPesoNeto"
        Me.TPesoNeto.ReadOnly = True
        Me.TPesoNeto.Size = New System.Drawing.Size(100, 22)
        Me.TPesoNeto.TabIndex = 268
        Me.TPesoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TPesoBruto
        '
        Me.TPesoBruto.Location = New System.Drawing.Point(159, 74)
        Me.TPesoBruto.Name = "TPesoBruto"
        Me.TPesoBruto.ReadOnly = True
        Me.TPesoBruto.Size = New System.Drawing.Size(100, 22)
        Me.TPesoBruto.TabIndex = 269
        Me.TPesoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRack
        '
        Me.lblRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRack.ForeColor = System.Drawing.Color.Black
        Me.lblRack.Location = New System.Drawing.Point(46, 105)
        Me.lblRack.Name = "lblRack"
        Me.lblRack.Size = New System.Drawing.Size(107, 19)
        Me.lblRack.TabIndex = 279
        Me.lblRack.Text = "Peso Tara"
        Me.lblRack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TPesoRack
        '
        Me.TPesoRack.Location = New System.Drawing.Point(159, 102)
        Me.TPesoRack.Name = "TPesoRack"
        Me.TPesoRack.ReadOnly = True
        Me.TPesoRack.Size = New System.Drawing.Size(100, 22)
        Me.TPesoRack.TabIndex = 280
        Me.TPesoRack.Text = "0"
        Me.TPesoRack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TOrden
        '
        Me.TOrden.Location = New System.Drawing.Point(159, 18)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.ReadOnly = True
        Me.TOrden.Size = New System.Drawing.Size(100, 22)
        Me.TOrden.TabIndex = 275
        Me.TOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(21, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 16)
        Me.Label13.TabIndex = 276
        Me.Label13.Text = "Orden Producción"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TFolioAtlas
        '
        Me.TFolioAtlas.Location = New System.Drawing.Point(159, 46)
        Me.TFolioAtlas.Name = "TFolioAtlas"
        Me.TFolioAtlas.ReadOnly = True
        Me.TFolioAtlas.Size = New System.Drawing.Size(100, 22)
        Me.TFolioAtlas.TabIndex = 273
        Me.TFolioAtlas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(110, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 274
        Me.Label12.Text = "Folio"
        '
        'TKC2
        '
        Me.TKC2.BackColor = System.Drawing.SystemColors.Window
        Me.TKC2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TKC2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TKC2.Location = New System.Drawing.Point(624, 257)
        Me.TKC2.MaxLength = 10
        Me.TKC2.Name = "TKC2"
        Me.TKC2.ReadOnly = True
        Me.TKC2.Size = New System.Drawing.Size(88, 22)
        Me.TKC2.TabIndex = 300
        Me.TKC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TKC1
        '
        Me.TKC1.BackColor = System.Drawing.SystemColors.Window
        Me.TKC1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TKC1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TKC1.Location = New System.Drawing.Point(624, 229)
        Me.TKC1.MaxLength = 10
        Me.TKC1.Name = "TKC1"
        Me.TKC1.ReadOnly = True
        Me.TKC1.Size = New System.Drawing.Size(88, 22)
        Me.TKC1.TabIndex = 299
        Me.TKC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TPComp2
        '
        Me.TPComp2.BackColor = System.Drawing.SystemColors.Window
        Me.TPComp2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TPComp2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TPComp2.Location = New System.Drawing.Point(538, 257)
        Me.TPComp2.MaxLength = 10
        Me.TPComp2.Name = "TPComp2"
        Me.TPComp2.Size = New System.Drawing.Size(80, 22)
        Me.TPComp2.TabIndex = 298
        Me.TPComp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TPComp1
        '
        Me.TPComp1.BackColor = System.Drawing.SystemColors.Window
        Me.TPComp1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TPComp1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TPComp1.Location = New System.Drawing.Point(538, 229)
        Me.TPComp1.MaxLength = 10
        Me.TPComp1.Name = "TPComp1"
        Me.TPComp1.Size = New System.Drawing.Size(80, 22)
        Me.TPComp1.TabIndex = 297
        Me.TPComp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(645, 210)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 16)
        Me.Label18.TabIndex = 296
        Me.Label18.Text = "Kilos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(535, 210)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 16)
        Me.Label17.TabIndex = 295
        Me.Label17.Text = "Porcentaje"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(316, 260)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 17)
        Me.Label16.TabIndex = 294
        Me.Label16.Text = "Compuesto 2"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TComp2
        '
        Me.TComp2.BackColor = System.Drawing.SystemColors.Window
        Me.TComp2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TComp2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TComp2.Location = New System.Drawing.Point(432, 257)
        Me.TComp2.MaxLength = 10
        Me.TComp2.Name = "TComp2"
        Me.TComp2.Size = New System.Drawing.Size(100, 22)
        Me.TComp2.TabIndex = 293
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(316, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 17)
        Me.Label15.TabIndex = 292
        Me.Label15.Text = "Compuesto 1"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TComp1
        '
        Me.TComp1.BackColor = System.Drawing.SystemColors.Window
        Me.TComp1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TComp1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TComp1.Location = New System.Drawing.Point(432, 229)
        Me.TComp1.MaxLength = 10
        Me.TComp1.Name = "TComp1"
        Me.TComp1.Size = New System.Drawing.Size(100, 22)
        Me.TComp1.TabIndex = 291
        '
        'BCompuesto
        '
        Me.BCompuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCompuesto.Enabled = False
        Me.BCompuesto.Image = CType(resources.GetObject("BCompuesto.Image"), System.Drawing.Image)
        Me.BCompuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCompuesto.Location = New System.Drawing.Point(718, 229)
        Me.BCompuesto.Name = "BCompuesto"
        Me.BCompuesto.Size = New System.Drawing.Size(156, 50)
        Me.BCompuesto.TabIndex = 301
        Me.BCompuesto.Text = "Configurar Compuesto"
        Me.BCompuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCompuesto.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'FrmModSC_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1153, 683)
        Me.Controls.Add(Me.PBActualiza)
        Me.Controls.Add(Me.BCompuesto)
        Me.Controls.Add(Me.TKC2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TKC1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TPComp2)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.Controls.Add(Me.TPComp1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GB_Pesajes)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TComp1)
        Me.Controls.Add(Me.TComp2)
        Me.Controls.Add(Me.Label15)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmModSC_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificación de Pesajes"
        Me.GB_Pesajes.ResumeLayout(False)
        CType(Me.DGV_BP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tsbPrincipal.ResumeLayout(False)
        Me.tsbPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB_Pesajes As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_BP As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TTC2 As System.Windows.Forms.TextBox
    Friend WithEvents TTC1 As System.Windows.Forms.TextBox
    Friend WithEvents TTPN As System.Windows.Forms.TextBox
    Friend WithEvents TTPT As System.Windows.Forms.TextBox
    Friend WithEvents TTPB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tsbPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TFol As System.Windows.Forms.TextBox
    Friend WithEvents TOrd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CB_Turno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TPesoNeto As System.Windows.Forms.TextBox
    Friend WithEvents TPesoBruto As System.Windows.Forms.TextBox
    Friend WithEvents lblRack As System.Windows.Forms.Label
    Friend WithEvents TPesoRack As System.Windows.Forms.TextBox
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TFolioAtlas As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TKC2 As System.Windows.Forms.TextBox
    Friend WithEvents TKC1 As System.Windows.Forms.TextBox
    Friend WithEvents TPComp2 As System.Windows.Forms.TextBox
    Friend WithEvents TPComp1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TComp2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TComp1 As System.Windows.Forms.TextBox
    Friend WithEvents BCompuesto As System.Windows.Forms.Button
    Friend WithEvents TcodPt As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PBActualiza As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
