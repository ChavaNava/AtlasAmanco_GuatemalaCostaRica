<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminPPT
    Inherits Atlas.FrmAdminMaster

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdminPPT))
        Me.tsbPrincipal = New System.Windows.Forms.ToolStrip
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton
        Me.tsbExportar = New System.Windows.Forms.ToolStripButton
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton
        Me.CB4 = New System.Windows.Forms.CheckBox
        Me.CB3 = New System.Windows.Forms.CheckBox
        Me.CB2 = New System.Windows.Forms.CheckBox
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.DTP2 = New System.Windows.Forms.DateTimePicker
        Me.TxtOrdProd = New System.Windows.Forms.TextBox
        Me.cmbTurnos = New System.Windows.Forms.ComboBox
        Me.lblODF = New System.Windows.Forms.Label
        Me.lblTurno = New System.Windows.Forms.Label
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.lblEQUIPO = New System.Windows.Forms.Label
        Me.txtEquipo = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtOrdProdSel = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TCantpendi = New System.Windows.Forms.TextBox
        Me.TCantProgra = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TCantEntre = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TCantEnproce = New System.Windows.Forms.TextBox
        Me.splConsultas = New System.Windows.Forms.SplitContainer
        Me.DGPPT = New System.Windows.Forms.DataGrid
        Me.DGOP = New System.Windows.Forms.DataGrid
        Me.pnlCriterios = New System.Windows.Forms.Panel
        Me.pnlTotales = New System.Windows.Forms.Panel
        Me.txtPorsprut = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTotunproceso = New System.Windows.Forms.TextBox
        Me.txtTotunprod = New System.Windows.Forms.TextBox
        Me.txtTotunscrap = New System.Windows.Forms.TextBox
        Me.txtTotkilosproceso = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTotkilospurga = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTotkilossprut = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPorscrap = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTotkilosprod = New System.Windows.Forms.TextBox
        Me.txtSobrepeso = New System.Windows.Forms.TextBox
        Me.txtTotkilosscrap = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPorcsobrepeso = New System.Windows.Forms.TextBox
        Me.pnlcantidades = New System.Windows.Forms.Panel
        Me.TxtFolioSel = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlEficiencia = New System.Windows.Forms.Panel
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.TOtro = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.TMant = New System.Windows.Forms.TextBox
        Me.TSetu = New System.Windows.Forms.TextBox
        Me.TTrabajadas = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.TProg = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtTotHorasotro = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtTotHorasmant = New System.Windows.Forms.TextBox
        Me.txtTotHorassetu = New System.Windows.Forms.TextBox
        Me.txtTotHorastrab = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtTotHorasprog = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.DGSC = New System.Windows.Forms.DataGrid
        Me.tsbPrincipal.SuspendLayout()
        Me.splConsultas.Panel1.SuspendLayout()
        Me.splConsultas.Panel2.SuspendLayout()
        Me.splConsultas.SuspendLayout()
        CType(Me.DGPPT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGOP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCriterios.SuspendLayout()
        Me.pnlTotales.SuspendLayout()
        Me.pnlcantidades.SuspendLayout()
        Me.pnlEficiencia.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGSC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsbPrincipal
        '
        Me.tsbPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tsbPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConsultar, Me.tsbImprimir, Me.tsbExportar, Me.tsbCerrar})
        Me.tsbPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsbPrincipal.Name = "tsbPrincipal"
        Me.tsbPrincipal.Size = New System.Drawing.Size(1168, 25)
        Me.tsbPrincipal.TabIndex = 13
        Me.tsbPrincipal.Text = "ToolStrip1"
        '
        'tsbConsultar
        '
        Me.tsbConsultar.Image = CType(resources.GetObject("tsbConsultar.Image"), System.Drawing.Image)
        Me.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultar.Name = "tsbConsultar"
        Me.tsbConsultar.Size = New System.Drawing.Size(78, 22)
        Me.tsbConsultar.Text = "Consultar"
        '
        'tsbImprimir
        '
        Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(119, 22)
        Me.tsbImprimir.Text = "Imprimir Etiqueta"
        '
        'tsbExportar
        '
        Me.tsbExportar.Image = CType(resources.GetObject("tsbExportar.Image"), System.Drawing.Image)
        Me.tsbExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportar.Name = "tsbExportar"
        Me.tsbExportar.Size = New System.Drawing.Size(120, 22)
        Me.tsbExportar.Text = "Exportar Consulta"
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
        'CB4
        '
        Me.CB4.AutoSize = True
        Me.CB4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB4.Location = New System.Drawing.Point(19, 53)
        Me.CB4.Name = "CB4"
        Me.CB4.Size = New System.Drawing.Size(103, 17)
        Me.CB4.TabIndex = 5
        Me.CB4.Text = "Equipo / Periodo"
        Me.CB4.UseVisualStyleBackColor = True
        '
        'CB3
        '
        Me.CB3.AutoSize = True
        Me.CB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB3.Location = New System.Drawing.Point(19, 31)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(171, 17)
        Me.CB3.TabIndex = 2
        Me.CB3.Text = "Orden de Producción / Periodo"
        Me.CB3.UseVisualStyleBackColor = True
        '
        'CB2
        '
        Me.CB2.AutoSize = True
        Me.CB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB2.Location = New System.Drawing.Point(19, 10)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(124, 17)
        Me.CB2.TabIndex = 1
        Me.CB2.Text = "Orden de Producción"
        Me.CB2.UseVisualStyleBackColor = True
        '
        'DTP1
        '
        Me.DTP1.CustomFormat = "yyyy-MM-dd"
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(59, 119)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(81, 20)
        Me.DTP1.TabIndex = 6
        Me.DTP1.Visible = False
        '
        'DTP2
        '
        Me.DTP2.CustomFormat = "yyyy-MM-dd"
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP2.Location = New System.Drawing.Point(143, 119)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(81, 20)
        Me.DTP2.TabIndex = 7
        Me.DTP2.Visible = False
        '
        'TxtOrdProd
        '
        Me.TxtOrdProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOrdProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOrdProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdProd.Location = New System.Drawing.Point(59, 89)
        Me.TxtOrdProd.MaxLength = 15
        Me.TxtOrdProd.Name = "TxtOrdProd"
        Me.TxtOrdProd.Size = New System.Drawing.Size(100, 15)
        Me.TxtOrdProd.TabIndex = 17
        Me.TxtOrdProd.Visible = False
        '
        'cmbTurnos
        '
        Me.cmbTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTurnos.FormattingEnabled = True
        Me.cmbTurnos.Location = New System.Drawing.Point(176, 86)
        Me.cmbTurnos.MaxLength = 15
        Me.cmbTurnos.Name = "cmbTurnos"
        Me.cmbTurnos.Size = New System.Drawing.Size(43, 21)
        Me.cmbTurnos.TabIndex = 22
        Me.cmbTurnos.Visible = False
        '
        'lblODF
        '
        Me.lblODF.AutoSize = True
        Me.lblODF.Location = New System.Drawing.Point(18, 91)
        Me.lblODF.Name = "lblODF"
        Me.lblODF.Size = New System.Drawing.Size(32, 13)
        Me.lblODF.TabIndex = 23
        Me.lblODF.Text = "ODF:"
        Me.lblODF.Visible = False
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Location = New System.Drawing.Point(179, 69)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(38, 13)
        Me.lblTurno.TabIndex = 24
        Me.lblTurno.Text = "Turno:"
        Me.lblTurno.Visible = False
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(8, 122)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(46, 13)
        Me.lblPeriodo.TabIndex = 25
        Me.lblPeriodo.Text = "Periodo:"
        Me.lblPeriodo.Visible = False
        '
        'lblEQUIPO
        '
        Me.lblEQUIPO.AutoSize = True
        Me.lblEQUIPO.Location = New System.Drawing.Point(11, 91)
        Me.lblEQUIPO.Name = "lblEQUIPO"
        Me.lblEQUIPO.Size = New System.Drawing.Size(43, 13)
        Me.lblEQUIPO.TabIndex = 38
        Me.lblEQUIPO.Text = "Equipo:"
        Me.lblEQUIPO.Visible = False
        '
        'txtEquipo
        '
        Me.txtEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipo.Location = New System.Drawing.Point(59, 89)
        Me.txtEquipo.MaxLength = 15
        Me.txtEquipo.Name = "txtEquipo"
        Me.txtEquipo.Size = New System.Drawing.Size(100, 15)
        Me.txtEquipo.TabIndex = 37
        Me.txtEquipo.Text = "*"
        Me.txtEquipo.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(11, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "O.D.F"
        '
        'TxtOrdProdSel
        '
        Me.TxtOrdProdSel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtOrdProdSel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOrdProdSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdProdSel.ForeColor = System.Drawing.Color.White
        Me.TxtOrdProdSel.Location = New System.Drawing.Point(94, 28)
        Me.TxtOrdProdSel.Name = "TxtOrdProdSel"
        Me.TxtOrdProdSel.ReadOnly = True
        Me.TxtOrdProdSel.Size = New System.Drawing.Size(87, 16)
        Me.TxtOrdProdSel.TabIndex = 123
        Me.TxtOrdProdSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Pendiente"
        '
        'TCantpendi
        '
        Me.TCantpendi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TCantpendi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCantpendi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantpendi.Location = New System.Drawing.Point(94, 117)
        Me.TCantpendi.Name = "TCantpendi"
        Me.TCantpendi.ReadOnly = True
        Me.TCantpendi.Size = New System.Drawing.Size(87, 16)
        Me.TCantpendi.TabIndex = 122
        Me.TCantpendi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TCantProgra
        '
        Me.TCantProgra.BackColor = System.Drawing.Color.White
        Me.TCantProgra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCantProgra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantProgra.Location = New System.Drawing.Point(94, 51)
        Me.TCantProgra.Name = "TCantProgra"
        Me.TCantProgra.ReadOnly = True
        Me.TCantProgra.Size = New System.Drawing.Size(87, 16)
        Me.TCantProgra.TabIndex = 118
        Me.TCantProgra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Programada"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(11, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "Entregada"
        '
        'TCantEntre
        '
        Me.TCantEntre.BackColor = System.Drawing.Color.White
        Me.TCantEntre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCantEntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantEntre.Location = New System.Drawing.Point(94, 73)
        Me.TCantEntre.Name = "TCantEntre"
        Me.TCantEntre.ReadOnly = True
        Me.TCantEntre.Size = New System.Drawing.Size(87, 16)
        Me.TCantEntre.TabIndex = 119
        Me.TCantEntre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(11, 97)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "En proceso"
        '
        'TCantEnproce
        '
        Me.TCantEnproce.BackColor = System.Drawing.Color.White
        Me.TCantEnproce.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCantEnproce.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantEnproce.Location = New System.Drawing.Point(94, 95)
        Me.TCantEnproce.Name = "TCantEnproce"
        Me.TCantEnproce.ReadOnly = True
        Me.TCantEnproce.Size = New System.Drawing.Size(87, 16)
        Me.TCantEnproce.TabIndex = 120
        Me.TCantEnproce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'splConsultas
        '
        Me.splConsultas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splConsultas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.splConsultas.Location = New System.Drawing.Point(3, 190)
        Me.splConsultas.Name = "splConsultas"
        Me.splConsultas.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splConsultas.Panel1
        '
        Me.splConsultas.Panel1.Controls.Add(Me.DGPPT)
        '
        'splConsultas.Panel2
        '
        Me.splConsultas.Panel2.Controls.Add(Me.DGOP)
        Me.splConsultas.Size = New System.Drawing.Size(1152, 240)
        Me.splConsultas.SplitterDistance = 135
        Me.splConsultas.TabIndex = 178
        '
        'DGPPT
        '
        Me.DGPPT.AlternatingBackColor = System.Drawing.Color.PaleTurquoise
        Me.DGPPT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGPPT.BackColor = System.Drawing.Color.Honeydew
        Me.DGPPT.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DGPPT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGPPT.CaptionBackColor = System.Drawing.Color.CornflowerBlue
        Me.DGPPT.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGPPT.CaptionForeColor = System.Drawing.Color.Black
        Me.DGPPT.CaptionText = "Detalle Pesaje por ORDEN-MAQUINA"
        Me.DGPPT.DataMember = ""
        Me.DGPPT.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGPPT.ForeColor = System.Drawing.Color.Black
        Me.DGPPT.GridLineColor = System.Drawing.Color.LightSteelBlue
        Me.DGPPT.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DGPPT.HeaderBackColor = System.Drawing.Color.LightSteelBlue
        Me.DGPPT.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGPPT.HeaderForeColor = System.Drawing.Color.Black
        Me.DGPPT.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.DGPPT.Location = New System.Drawing.Point(3, 3)
        Me.DGPPT.Name = "DGPPT"
        Me.DGPPT.ParentRowsBackColor = System.Drawing.Color.LightSteelBlue
        Me.DGPPT.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGPPT.ReadOnly = True
        Me.DGPPT.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        Me.DGPPT.SelectionForeColor = System.Drawing.Color.Black
        Me.DGPPT.Size = New System.Drawing.Size(1142, 127)
        Me.DGPPT.TabIndex = 179
        '
        'DGOP
        '
        Me.DGOP.AlternatingBackColor = System.Drawing.Color.PaleTurquoise
        Me.DGOP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGOP.BackColor = System.Drawing.Color.Honeydew
        Me.DGOP.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DGOP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGOP.CaptionBackColor = System.Drawing.Color.CornflowerBlue
        Me.DGOP.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGOP.CaptionForeColor = System.Drawing.Color.Black
        Me.DGOP.CaptionText = "Resumen pesaje por ORDEN-MAQUINA"
        Me.DGOP.DataMember = ""
        Me.DGOP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGOP.ForeColor = System.Drawing.Color.Black
        Me.DGOP.GridLineColor = System.Drawing.Color.LightSteelBlue
        Me.DGOP.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DGOP.HeaderBackColor = System.Drawing.Color.LightSteelBlue
        Me.DGOP.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGOP.HeaderForeColor = System.Drawing.Color.Black
        Me.DGOP.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.DGOP.Location = New System.Drawing.Point(3, 3)
        Me.DGOP.Name = "DGOP"
        Me.DGOP.ParentRowsBackColor = System.Drawing.Color.LightSteelBlue
        Me.DGOP.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGOP.ReadOnly = True
        Me.DGOP.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        Me.DGOP.SelectionForeColor = System.Drawing.Color.Black
        Me.DGOP.Size = New System.Drawing.Size(1142, 93)
        Me.DGOP.TabIndex = 179
        '
        'pnlCriterios
        '
        Me.pnlCriterios.Controls.Add(Me.CB4)
        Me.pnlCriterios.Controls.Add(Me.CB3)
        Me.pnlCriterios.Controls.Add(Me.CB2)
        Me.pnlCriterios.Controls.Add(Me.lblEQUIPO)
        Me.pnlCriterios.Controls.Add(Me.DTP1)
        Me.pnlCriterios.Controls.Add(Me.DTP2)
        Me.pnlCriterios.Controls.Add(Me.txtEquipo)
        Me.pnlCriterios.Controls.Add(Me.lblPeriodo)
        Me.pnlCriterios.Controls.Add(Me.TxtOrdProd)
        Me.pnlCriterios.Controls.Add(Me.lblTurno)
        Me.pnlCriterios.Controls.Add(Me.cmbTurnos)
        Me.pnlCriterios.Controls.Add(Me.lblODF)
        Me.pnlCriterios.Location = New System.Drawing.Point(3, 29)
        Me.pnlCriterios.Name = "pnlCriterios"
        Me.pnlCriterios.Size = New System.Drawing.Size(234, 156)
        Me.pnlCriterios.TabIndex = 220
        '
        'pnlTotales
        '
        Me.pnlTotales.Controls.Add(Me.txtPorsprut)
        Me.pnlTotales.Controls.Add(Me.Label13)
        Me.pnlTotales.Controls.Add(Me.Label4)
        Me.pnlTotales.Controls.Add(Me.Label2)
        Me.pnlTotales.Controls.Add(Me.txtTotunproceso)
        Me.pnlTotales.Controls.Add(Me.txtTotunprod)
        Me.pnlTotales.Controls.Add(Me.txtTotunscrap)
        Me.pnlTotales.Controls.Add(Me.txtTotkilosproceso)
        Me.pnlTotales.Controls.Add(Me.Label1)
        Me.pnlTotales.Controls.Add(Me.txtTotkilospurga)
        Me.pnlTotales.Controls.Add(Me.Label12)
        Me.pnlTotales.Controls.Add(Me.txtTotkilossprut)
        Me.pnlTotales.Controls.Add(Me.Label11)
        Me.pnlTotales.Controls.Add(Me.txtPorscrap)
        Me.pnlTotales.Controls.Add(Me.Label7)
        Me.pnlTotales.Controls.Add(Me.txtTotkilosprod)
        Me.pnlTotales.Controls.Add(Me.txtSobrepeso)
        Me.pnlTotales.Controls.Add(Me.txtTotkilosscrap)
        Me.pnlTotales.Controls.Add(Me.Label8)
        Me.pnlTotales.Controls.Add(Me.Label3)
        Me.pnlTotales.Controls.Add(Me.Label6)
        Me.pnlTotales.Controls.Add(Me.txtPorcsobrepeso)
        Me.pnlTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTotales.Location = New System.Drawing.Point(635, 29)
        Me.pnlTotales.Name = "pnlTotales"
        Me.pnlTotales.Size = New System.Drawing.Size(324, 156)
        Me.pnlTotales.TabIndex = 221
        '
        'txtPorsprut
        '
        Me.txtPorsprut.BackColor = System.Drawing.Color.Navy
        Me.txtPorsprut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPorsprut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorsprut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorsprut.ForeColor = System.Drawing.Color.White
        Me.txtPorsprut.Location = New System.Drawing.Point(260, 114)
        Me.txtPorsprut.Name = "txtPorsprut"
        Me.txtPorsprut.ReadOnly = True
        Me.txtPorsprut.Size = New System.Drawing.Size(48, 16)
        Me.txtPorsprut.TabIndex = 101
        Me.txtPorsprut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(275, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 13)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(184, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Unidades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Kilos"
        '
        'txtTotunproceso
        '
        Me.txtTotunproceso.BackColor = System.Drawing.Color.White
        Me.txtTotunproceso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotunproceso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotunproceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotunproceso.Location = New System.Drawing.Point(175, 51)
        Me.txtTotunproceso.Name = "txtTotunproceso"
        Me.txtTotunproceso.ReadOnly = True
        Me.txtTotunproceso.Size = New System.Drawing.Size(78, 16)
        Me.txtTotunproceso.TabIndex = 96
        Me.txtTotunproceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotunprod
        '
        Me.txtTotunprod.BackColor = System.Drawing.Color.White
        Me.txtTotunprod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotunprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotunprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotunprod.Location = New System.Drawing.Point(175, 31)
        Me.txtTotunprod.Name = "txtTotunprod"
        Me.txtTotunprod.ReadOnly = True
        Me.txtTotunprod.Size = New System.Drawing.Size(78, 16)
        Me.txtTotunprod.TabIndex = 95
        Me.txtTotunprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotunscrap
        '
        Me.txtTotunscrap.BackColor = System.Drawing.Color.White
        Me.txtTotunscrap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotunscrap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotunscrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotunscrap.Location = New System.Drawing.Point(175, 91)
        Me.txtTotunscrap.Name = "txtTotunscrap"
        Me.txtTotunscrap.ReadOnly = True
        Me.txtTotunscrap.Size = New System.Drawing.Size(78, 16)
        Me.txtTotunscrap.TabIndex = 94
        Me.txtTotunscrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotkilosproceso
        '
        Me.txtTotkilosproceso.BackColor = System.Drawing.Color.White
        Me.txtTotkilosproceso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotkilosproceso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotkilosproceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotkilosproceso.Location = New System.Drawing.Point(83, 51)
        Me.txtTotkilosproceso.Name = "txtTotkilosproceso"
        Me.txtTotkilosproceso.ReadOnly = True
        Me.txtTotkilosproceso.Size = New System.Drawing.Size(84, 16)
        Me.txtTotkilosproceso.TabIndex = 93
        Me.txtTotkilosproceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Separada"
        '
        'txtTotkilospurga
        '
        Me.txtTotkilospurga.BackColor = System.Drawing.Color.White
        Me.txtTotkilospurga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotkilospurga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotkilospurga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotkilospurga.Location = New System.Drawing.Point(83, 131)
        Me.txtTotkilospurga.Name = "txtTotkilospurga"
        Me.txtTotkilospurga.ReadOnly = True
        Me.txtTotkilospurga.Size = New System.Drawing.Size(84, 16)
        Me.txtTotkilospurga.TabIndex = 91
        Me.txtTotkilospurga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Purga"
        '
        'txtTotkilossprut
        '
        Me.txtTotkilossprut.BackColor = System.Drawing.Color.White
        Me.txtTotkilossprut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotkilossprut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotkilossprut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotkilossprut.Location = New System.Drawing.Point(83, 111)
        Me.txtTotkilossprut.Name = "txtTotkilossprut"
        Me.txtTotkilossprut.ReadOnly = True
        Me.txtTotkilossprut.Size = New System.Drawing.Size(84, 16)
        Me.txtTotkilossprut.TabIndex = 89
        Me.txtTotkilossprut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Sprut"
        '
        'txtPorscrap
        '
        Me.txtPorscrap.BackColor = System.Drawing.Color.Navy
        Me.txtPorscrap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPorscrap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorscrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorscrap.ForeColor = System.Drawing.Color.White
        Me.txtPorscrap.Location = New System.Drawing.Point(260, 92)
        Me.txtPorscrap.Name = "txtPorscrap"
        Me.txtPorscrap.ReadOnly = True
        Me.txtPorscrap.Size = New System.Drawing.Size(48, 16)
        Me.txtPorscrap.TabIndex = 87
        Me.txtPorscrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "TOTALES:"
        '
        'txtTotkilosprod
        '
        Me.txtTotkilosprod.BackColor = System.Drawing.Color.White
        Me.txtTotkilosprod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotkilosprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotkilosprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotkilosprod.Location = New System.Drawing.Point(83, 31)
        Me.txtTotkilosprod.Name = "txtTotkilosprod"
        Me.txtTotkilosprod.ReadOnly = True
        Me.txtTotkilosprod.Size = New System.Drawing.Size(84, 16)
        Me.txtTotkilosprod.TabIndex = 85
        Me.txtTotkilosprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSobrepeso
        '
        Me.txtSobrepeso.BackColor = System.Drawing.Color.White
        Me.txtSobrepeso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSobrepeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSobrepeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSobrepeso.Location = New System.Drawing.Point(83, 71)
        Me.txtSobrepeso.Name = "txtSobrepeso"
        Me.txtSobrepeso.ReadOnly = True
        Me.txtSobrepeso.Size = New System.Drawing.Size(84, 16)
        Me.txtSobrepeso.TabIndex = 84
        Me.txtSobrepeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotkilosscrap
        '
        Me.txtTotkilosscrap.BackColor = System.Drawing.Color.White
        Me.txtTotkilosscrap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotkilosscrap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotkilosscrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotkilosscrap.Location = New System.Drawing.Point(83, 91)
        Me.txtTotkilosscrap.Name = "txtTotkilosscrap"
        Me.txtTotkilosscrap.ReadOnly = True
        Me.txtTotkilosscrap.Size = New System.Drawing.Size(84, 16)
        Me.txtTotkilosscrap.TabIndex = 83
        Me.txtTotkilosscrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Scrap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Producción"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Sobrepeso"
        '
        'txtPorcsobrepeso
        '
        Me.txtPorcsobrepeso.BackColor = System.Drawing.Color.Navy
        Me.txtPorcsobrepeso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPorcsobrepeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcsobrepeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcsobrepeso.ForeColor = System.Drawing.Color.White
        Me.txtPorcsobrepeso.Location = New System.Drawing.Point(260, 70)
        Me.txtPorcsobrepeso.Name = "txtPorcsobrepeso"
        Me.txtPorcsobrepeso.ReadOnly = True
        Me.txtPorcsobrepeso.Size = New System.Drawing.Size(48, 16)
        Me.txtPorcsobrepeso.TabIndex = 79
        Me.txtPorcsobrepeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlcantidades
        '
        Me.pnlcantidades.Controls.Add(Me.TxtFolioSel)
        Me.pnlcantidades.Controls.Add(Me.Label5)
        Me.pnlcantidades.Controls.Add(Me.Label14)
        Me.pnlcantidades.Controls.Add(Me.Label15)
        Me.pnlcantidades.Controls.Add(Me.TCantpendi)
        Me.pnlcantidades.Controls.Add(Me.Label17)
        Me.pnlcantidades.Controls.Add(Me.TCantEntre)
        Me.pnlcantidades.Controls.Add(Me.TCantEnproce)
        Me.pnlcantidades.Controls.Add(Me.TxtOrdProdSel)
        Me.pnlcantidades.Controls.Add(Me.Label16)
        Me.pnlcantidades.Controls.Add(Me.Label10)
        Me.pnlcantidades.Controls.Add(Me.TCantProgra)
        Me.pnlcantidades.Location = New System.Drawing.Point(243, 29)
        Me.pnlcantidades.Name = "pnlcantidades"
        Me.pnlcantidades.Size = New System.Drawing.Size(192, 156)
        Me.pnlcantidades.TabIndex = 222
        '
        'TxtFolioSel
        '
        Me.TxtFolioSel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtFolioSel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFolioSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFolioSel.ForeColor = System.Drawing.Color.White
        Me.TxtFolioSel.Location = New System.Drawing.Point(94, 6)
        Me.TxtFolioSel.Name = "TxtFolioSel"
        Me.TxtFolioSel.ReadOnly = True
        Me.TxtFolioSel.Size = New System.Drawing.Size(87, 16)
        Me.TxtFolioSel.TabIndex = 126
        Me.TxtFolioSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtFolioSel.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "CANTIDADES:"
        '
        'pnlEficiencia
        '
        Me.pnlEficiencia.Controls.Add(Me.Label22)
        Me.pnlEficiencia.Controls.Add(Me.Label23)
        Me.pnlEficiencia.Controls.Add(Me.TOtro)
        Me.pnlEficiencia.Controls.Add(Me.Label18)
        Me.pnlEficiencia.Controls.Add(Me.Label19)
        Me.pnlEficiencia.Controls.Add(Me.TMant)
        Me.pnlEficiencia.Controls.Add(Me.TSetu)
        Me.pnlEficiencia.Controls.Add(Me.TTrabajadas)
        Me.pnlEficiencia.Controls.Add(Me.Label20)
        Me.pnlEficiencia.Controls.Add(Me.Label21)
        Me.pnlEficiencia.Controls.Add(Me.TProg)
        Me.pnlEficiencia.Controls.Add(Me.Label9)
        Me.pnlEficiencia.Location = New System.Drawing.Point(441, 29)
        Me.pnlEficiencia.Name = "pnlEficiencia"
        Me.pnlEficiencia.Size = New System.Drawing.Size(187, 156)
        Me.pnlEficiencia.TabIndex = 223
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(11, 51)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 13)
        Me.Label22.TabIndex = 140
        Me.Label22.Text = "Horas PARO"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(11, 130)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 13)
        Me.Label23.TabIndex = 137
        Me.Label23.Text = "Otros"
        '
        'TOtro
        '
        Me.TOtro.BackColor = System.Drawing.Color.White
        Me.TOtro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOtro.Location = New System.Drawing.Point(107, 130)
        Me.TOtro.Name = "TOtro"
        Me.TOtro.ReadOnly = True
        Me.TOtro.Size = New System.Drawing.Size(72, 16)
        Me.TOtro.TabIndex = 138
        Me.TOtro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(11, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 13)
        Me.Label18.TabIndex = 134
        Me.Label18.Text = "H. Trabajadas"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(11, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 129
        Me.Label19.Text = "Por SETUP"
        '
        'TMant
        '
        Me.TMant.BackColor = System.Drawing.Color.White
        Me.TMant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TMant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TMant.Location = New System.Drawing.Point(107, 90)
        Me.TMant.Name = "TMant"
        Me.TMant.ReadOnly = True
        Me.TMant.Size = New System.Drawing.Size(72, 16)
        Me.TMant.TabIndex = 131
        Me.TMant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TSetu
        '
        Me.TSetu.BackColor = System.Drawing.Color.White
        Me.TSetu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TSetu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSetu.Location = New System.Drawing.Point(107, 110)
        Me.TSetu.Name = "TSetu"
        Me.TSetu.ReadOnly = True
        Me.TSetu.Size = New System.Drawing.Size(72, 16)
        Me.TSetu.TabIndex = 132
        Me.TSetu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TTrabajadas
        '
        Me.TTrabajadas.BackColor = System.Drawing.Color.Yellow
        Me.TTrabajadas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TTrabajadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTrabajadas.ForeColor = System.Drawing.Color.Black
        Me.TTrabajadas.Location = New System.Drawing.Point(107, 31)
        Me.TTrabajadas.Name = "TTrabajadas"
        Me.TTrabajadas.ReadOnly = True
        Me.TTrabajadas.Size = New System.Drawing.Size(72, 16)
        Me.TTrabajadas.TabIndex = 133
        Me.TTrabajadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(11, 90)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 13)
        Me.Label20.TabIndex = 128
        Me.Label20.Text = "Por Mantenimiento"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(11, 70)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 13)
        Me.Label21.TabIndex = 127
        Me.Label21.Text = "Por Programa"
        '
        'TProg
        '
        Me.TProg.BackColor = System.Drawing.Color.White
        Me.TProg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TProg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TProg.Location = New System.Drawing.Point(107, 70)
        Me.TProg.Name = "TProg"
        Me.TProg.ReadOnly = True
        Me.TProg.Size = New System.Drawing.Size(72, 16)
        Me.TProg.TabIndex = 130
        Me.TProg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "EFICIENCIA (Horas):"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.txtTotHorasotro)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.txtTotHorasmant)
        Me.Panel2.Controls.Add(Me.txtTotHorassetu)
        Me.Panel2.Controls.Add(Me.txtTotHorastrab)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.txtTotHorasprog)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Location = New System.Drawing.Point(965, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(187, 156)
        Me.Panel2.TabIndex = 224
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(9, 52)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 13)
        Me.Label25.TabIndex = 139
        Me.Label25.Text = "Horas PARO"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(9, 131)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 13)
        Me.Label24.TabIndex = 137
        Me.Label24.Text = "Otros"
        '
        'txtTotHorasotro
        '
        Me.txtTotHorasotro.BackColor = System.Drawing.Color.White
        Me.txtTotHorasotro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotHorasotro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotHorasotro.Location = New System.Drawing.Point(107, 131)
        Me.txtTotHorasotro.Name = "txtTotHorasotro"
        Me.txtTotHorasotro.ReadOnly = True
        Me.txtTotHorasotro.Size = New System.Drawing.Size(66, 16)
        Me.txtTotHorasotro.TabIndex = 138
        Me.txtTotHorasotro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(9, 31)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 13)
        Me.Label26.TabIndex = 134
        Me.Label26.Text = "H. Trabajadas"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(9, 111)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 13)
        Me.Label27.TabIndex = 129
        Me.Label27.Text = "Por SETUP"
        '
        'txtTotHorasmant
        '
        Me.txtTotHorasmant.BackColor = System.Drawing.Color.White
        Me.txtTotHorasmant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotHorasmant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotHorasmant.Location = New System.Drawing.Point(107, 92)
        Me.txtTotHorasmant.Name = "txtTotHorasmant"
        Me.txtTotHorasmant.ReadOnly = True
        Me.txtTotHorasmant.Size = New System.Drawing.Size(66, 16)
        Me.txtTotHorasmant.TabIndex = 131
        Me.txtTotHorasmant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotHorassetu
        '
        Me.txtTotHorassetu.BackColor = System.Drawing.Color.White
        Me.txtTotHorassetu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotHorassetu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotHorassetu.Location = New System.Drawing.Point(107, 111)
        Me.txtTotHorassetu.Name = "txtTotHorassetu"
        Me.txtTotHorassetu.ReadOnly = True
        Me.txtTotHorassetu.Size = New System.Drawing.Size(66, 16)
        Me.txtTotHorassetu.TabIndex = 132
        Me.txtTotHorassetu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotHorastrab
        '
        Me.txtTotHorastrab.BackColor = System.Drawing.Color.Yellow
        Me.txtTotHorastrab.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotHorastrab.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotHorastrab.ForeColor = System.Drawing.Color.Black
        Me.txtTotHorastrab.Location = New System.Drawing.Point(107, 31)
        Me.txtTotHorastrab.Name = "txtTotHorastrab"
        Me.txtTotHorastrab.ReadOnly = True
        Me.txtTotHorastrab.Size = New System.Drawing.Size(66, 16)
        Me.txtTotHorastrab.TabIndex = 133
        Me.txtTotHorastrab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(9, 92)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(95, 13)
        Me.Label28.TabIndex = 128
        Me.Label28.Text = "Por Mantenimiento"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(9, 72)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 13)
        Me.Label29.TabIndex = 127
        Me.Label29.Text = "Por Programa"
        '
        'txtTotHorasprog
        '
        Me.txtTotHorasprog.BackColor = System.Drawing.Color.White
        Me.txtTotHorasprog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotHorasprog.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotHorasprog.Location = New System.Drawing.Point(107, 72)
        Me.txtTotHorasprog.Name = "txtTotHorasprog"
        Me.txtTotHorasprog.ReadOnly = True
        Me.txtTotHorasprog.Size = New System.Drawing.Size(66, 16)
        Me.txtTotHorasprog.TabIndex = 130
        Me.txtTotHorasprog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(2, 2)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(112, 13)
        Me.Label30.TabIndex = 126
        Me.Label30.Text = "TOTALES (Horas):"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DGSC)
        Me.Panel3.Location = New System.Drawing.Point(3, 436)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1152, 127)
        Me.Panel3.TabIndex = 225
        '
        'DGSC
        '
        Me.DGSC.AlternatingBackColor = System.Drawing.Color.PaleTurquoise
        Me.DGSC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGSC.BackColor = System.Drawing.Color.Honeydew
        Me.DGSC.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DGSC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGSC.CaptionBackColor = System.Drawing.Color.CornflowerBlue
        Me.DGSC.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGSC.CaptionForeColor = System.Drawing.Color.Black
        Me.DGSC.CaptionText = "Resumen pesaje por SECCIÓN"
        Me.DGSC.DataMember = ""
        Me.DGSC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGSC.ForeColor = System.Drawing.Color.Black
        Me.DGSC.GridLineColor = System.Drawing.Color.LightSteelBlue
        Me.DGSC.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DGSC.HeaderBackColor = System.Drawing.Color.LightSteelBlue
        Me.DGSC.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGSC.HeaderForeColor = System.Drawing.Color.Black
        Me.DGSC.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.DGSC.Location = New System.Drawing.Point(3, 3)
        Me.DGSC.Name = "DGSC"
        Me.DGSC.ParentRowsBackColor = System.Drawing.Color.LightSteelBlue
        Me.DGSC.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGSC.ReadOnly = True
        Me.DGSC.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        Me.DGSC.SelectionForeColor = System.Drawing.Color.Black
        Me.DGSC.Size = New System.Drawing.Size(1142, 119)
        Me.DGSC.TabIndex = 179
        '
        'FrmAdminPPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1168, 588)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlcantidades)
        Me.Controls.Add(Me.pnlEficiencia)
        Me.Controls.Add(Me.pnlTotales)
        Me.Controls.Add(Me.pnlCriterios)
        Me.Controls.Add(Me.splConsultas)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MinimizeBox = False
        Me.Name = "FrmAdminPPT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesaje Producto Terminado Extrusión"
        Me.Controls.SetChildIndex(Me.tsbPrincipal, 0)
        Me.Controls.SetChildIndex(Me.splConsultas, 0)
        Me.Controls.SetChildIndex(Me.pnlCriterios, 0)
        Me.Controls.SetChildIndex(Me.pnlTotales, 0)
        Me.Controls.SetChildIndex(Me.pnlEficiencia, 0)
        Me.Controls.SetChildIndex(Me.pnlcantidades, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.tsbPrincipal.ResumeLayout(False)
        Me.tsbPrincipal.PerformLayout()
        Me.splConsultas.Panel1.ResumeLayout(False)
        Me.splConsultas.Panel2.ResumeLayout(False)
        Me.splConsultas.ResumeLayout(False)
        CType(Me.DGPPT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGOP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCriterios.ResumeLayout(False)
        Me.pnlCriterios.PerformLayout()
        Me.pnlTotales.ResumeLayout(False)
        Me.pnlTotales.PerformLayout()
        Me.pnlcantidades.ResumeLayout(False)
        Me.pnlcantidades.PerformLayout()
        Me.pnlEficiencia.ResumeLayout(False)
        Me.pnlEficiencia.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGSC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsbPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CB3 As System.Windows.Forms.CheckBox
    Friend WithEvents CB2 As System.Windows.Forms.CheckBox
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtOrdProd As System.Windows.Forms.TextBox
    Friend WithEvents cmbTurnos As System.Windows.Forms.ComboBox
    Friend WithEvents lblODF As System.Windows.Forms.Label
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblEQUIPO As System.Windows.Forms.Label
    Friend WithEvents txtEquipo As System.Windows.Forms.TextBox
    Friend WithEvents CB4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtOrdProdSel As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TCantpendi As System.Windows.Forms.TextBox
    Friend WithEvents TCantProgra As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TCantEntre As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TCantEnproce As System.Windows.Forms.TextBox
    Friend WithEvents splConsultas As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlCriterios As System.Windows.Forms.Panel
    Friend WithEvents DGPPT As System.Windows.Forms.DataGrid
    Friend WithEvents DGOP As System.Windows.Forms.DataGrid
    Friend WithEvents pnlTotales As System.Windows.Forms.Panel
    Friend WithEvents txtPorsprut As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotunproceso As System.Windows.Forms.TextBox
    Friend WithEvents txtTotunprod As System.Windows.Forms.TextBox
    Friend WithEvents txtTotunscrap As System.Windows.Forms.TextBox
    Friend WithEvents txtTotkilosproceso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotkilospurga As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotkilossprut As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPorscrap As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotkilosprod As System.Windows.Forms.TextBox
    Friend WithEvents txtSobrepeso As System.Windows.Forms.TextBox
    Friend WithEvents txtTotkilosscrap As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPorcsobrepeso As System.Windows.Forms.TextBox
    Friend WithEvents pnlcantidades As System.Windows.Forms.Panel
    Friend WithEvents pnlEficiencia As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TMant As System.Windows.Forms.TextBox
    Friend WithEvents TSetu As System.Windows.Forms.TextBox
    Friend WithEvents TTrabajadas As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TProg As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TOtro As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtTotHorasotro As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtTotHorasmant As System.Windows.Forms.TextBox
    Friend WithEvents txtTotHorassetu As System.Windows.Forms.TextBox
    Friend WithEvents txtTotHorastrab As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtTotHorasprog As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents tsbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DGSC As System.Windows.Forms.DataGrid
    Friend WithEvents TxtFolioSel As System.Windows.Forms.TextBox

End Class
