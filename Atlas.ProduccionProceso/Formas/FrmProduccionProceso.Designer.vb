<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProduccionProceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProduccionProceso))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsbSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbCalculadora = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbBoleta = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbExportaExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbNotificacion = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDefecto = New System.Windows.Forms.ComboBox()
        Me.cmbCausa = New System.Windows.Forms.ComboBox()
        Me.txtPorFinal = New System.Windows.Forms.TextBox()
        Me.txtPesoFinal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUnidadesFinales = New System.Windows.Forms.TextBox()
        Me.lblDefecto = New System.Windows.Forms.Label()
        Me.lblCausa = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbProcesos = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNotificar = New System.Windows.Forms.Button()
        Me.rbProduccion = New System.Windows.Forms.RadioButton()
        Me.rbScrap = New System.Windows.Forms.RadioButton()
        Me.gbOrden = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPesoBruto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbTurnos = New System.Windows.Forms.ComboBox()
        Me.txtPesoTara = New System.Windows.Forms.TextBox()
        Me.dtpFechaSAP = New System.Windows.Forms.DateTimePicker()
        Me.chbSAP = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.txtPesoNeto = New System.Windows.Forms.TextBox()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtOrdenProduccion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbConsulta = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConsultaOrden = New System.Windows.Forms.TextBox()
        Me.cmbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtFolioAtlas = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDocSAP = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtConSAP = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.gbEstatus = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.spcRegistros = New System.Windows.Forms.SplitContainer()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.gbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgvNuevos = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbNotificacion.SuspendLayout()
        Me.gbProcesos.SuspendLayout()
        Me.gbOrden.SuspendLayout()
        Me.gbConsulta.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbEstatus.SuspendLayout()
        CType(Me.spcRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcRegistros.Panel1.SuspendLayout()
        Me.spcRegistros.Panel2.SuspendLayout()
        Me.spcRegistros.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRegistros.SuspendLayout()
        CType(Me.dgvNuevos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSalir, Me.tsbCalculadora, Me.tsbBoleta, Me.tsbExportaExcel})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1677, 40)
        Me.MenuStrip1.TabIndex = 176
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsbSalir
        '
        Me.tsbSalir.AutoSize = False
        Me.tsbSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbSalir.Image = Global.Atlas.ProduccionProceso.My.Resources.Resources.Exit_1
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(90, 25)
        Me.tsbSalir.Text = "Salir"
        '
        'tsbCalculadora
        '
        Me.tsbCalculadora.AutoSize = False
        Me.tsbCalculadora.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbCalculadora.Image = Global.Atlas.ProduccionProceso.My.Resources.Resources.Calculadora
        Me.tsbCalculadora.Name = "tsbCalculadora"
        Me.tsbCalculadora.Size = New System.Drawing.Size(110, 25)
        Me.tsbCalculadora.Text = "Calculadora"
        '
        'tsbBoleta
        '
        Me.tsbBoleta.Image = CType(resources.GetObject("tsbBoleta.Image"), System.Drawing.Image)
        Me.tsbBoleta.Name = "tsbBoleta"
        Me.tsbBoleta.Size = New System.Drawing.Size(140, 36)
        Me.tsbBoleta.Text = "Boleta Pesaje"
        '
        'tsbExportaExcel
        '
        Me.tsbExportaExcel.Image = CType(resources.GetObject("tsbExportaExcel.Image"), System.Drawing.Image)
        Me.tsbExportaExcel.Name = "tsbExportaExcel"
        Me.tsbExportaExcel.Size = New System.Drawing.Size(144, 36)
        Me.tsbExportaExcel.Text = "Exportar Excel"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gbNotificacion)
        Me.Panel1.Controls.Add(Me.gbProcesos)
        Me.Panel1.Controls.Add(Me.gbOrden)
        Me.Panel1.Controls.Add(Me.gbConsulta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1677, 297)
        Me.Panel1.TabIndex = 177
        '
        'gbNotificacion
        '
        Me.gbNotificacion.Controls.Add(Me.Label3)
        Me.gbNotificacion.Controls.Add(Me.Label2)
        Me.gbNotificacion.Controls.Add(Me.Label1)
        Me.gbNotificacion.Controls.Add(Me.cmbDefecto)
        Me.gbNotificacion.Controls.Add(Me.cmbCausa)
        Me.gbNotificacion.Controls.Add(Me.txtPorFinal)
        Me.gbNotificacion.Controls.Add(Me.txtPesoFinal)
        Me.gbNotificacion.Controls.Add(Me.Label5)
        Me.gbNotificacion.Controls.Add(Me.txtUnidadesFinales)
        Me.gbNotificacion.Controls.Add(Me.lblDefecto)
        Me.gbNotificacion.Controls.Add(Me.lblCausa)
        Me.gbNotificacion.Controls.Add(Me.Label9)
        Me.gbNotificacion.Location = New System.Drawing.Point(389, 155)
        Me.gbNotificacion.Name = "gbNotificacion"
        Me.gbNotificacion.Size = New System.Drawing.Size(718, 142)
        Me.gbNotificacion.TabIndex = 4
        Me.gbNotificacion.TabStop = False
        Me.gbNotificacion.Text = "Notificar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(324, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 265
        Me.Label3.Text = "Porcentaje"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 264
        Me.Label2.Text = "Peso Neto (Kg)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 264
        Me.Label1.Text = "Tramos (Ud)"
        '
        'cmbDefecto
        '
        Me.cmbDefecto.FormattingEnabled = True
        Me.cmbDefecto.Location = New System.Drawing.Point(78, 101)
        Me.cmbDefecto.Name = "cmbDefecto"
        Me.cmbDefecto.Size = New System.Drawing.Size(458, 24)
        Me.cmbDefecto.TabIndex = 257
        '
        'cmbCausa
        '
        Me.cmbCausa.FormattingEnabled = True
        Me.cmbCausa.Location = New System.Drawing.Point(78, 71)
        Me.cmbCausa.Name = "cmbCausa"
        Me.cmbCausa.Size = New System.Drawing.Size(458, 24)
        Me.cmbCausa.TabIndex = 256
        '
        'txtPorFinal
        '
        Me.txtPorFinal.Location = New System.Drawing.Point(310, 43)
        Me.txtPorFinal.Name = "txtPorFinal"
        Me.txtPorFinal.ReadOnly = True
        Me.txtPorFinal.Size = New System.Drawing.Size(110, 22)
        Me.txtPorFinal.TabIndex = 255
        '
        'txtPesoFinal
        '
        Me.txtPesoFinal.Location = New System.Drawing.Point(194, 43)
        Me.txtPesoFinal.Name = "txtPesoFinal"
        Me.txtPesoFinal.ReadOnly = True
        Me.txtPesoFinal.Size = New System.Drawing.Size(110, 22)
        Me.txtPesoFinal.TabIndex = 254
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Notificar"
        '
        'txtUnidadesFinales
        '
        Me.txtUnidadesFinales.Location = New System.Drawing.Point(78, 43)
        Me.txtUnidadesFinales.Name = "txtUnidadesFinales"
        Me.txtUnidadesFinales.Size = New System.Drawing.Size(110, 22)
        Me.txtUnidadesFinales.TabIndex = 252
        Me.txtUnidadesFinales.Text = "0"
        '
        'lblDefecto
        '
        Me.lblDefecto.AutoSize = True
        Me.lblDefecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefecto.ForeColor = System.Drawing.Color.Black
        Me.lblDefecto.Location = New System.Drawing.Point(10, 104)
        Me.lblDefecto.Name = "lblDefecto"
        Me.lblDefecto.Size = New System.Drawing.Size(62, 16)
        Me.lblDefecto.TabIndex = 251
        Me.lblDefecto.Text = "Defecto"
        '
        'lblCausa
        '
        Me.lblCausa.AutoSize = True
        Me.lblCausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCausa.ForeColor = System.Drawing.Color.Black
        Me.lblCausa.Location = New System.Drawing.Point(20, 74)
        Me.lblCausa.Name = "lblCausa"
        Me.lblCausa.Size = New System.Drawing.Size(52, 16)
        Me.lblCausa.TabIndex = 250
        Me.lblCausa.Text = "Causa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(426, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 16)
        Me.Label9.TabIndex = 249
        Me.Label9.Text = "%"
        '
        'gbProcesos
        '
        Me.gbProcesos.Controls.Add(Me.txtConSAP)
        Me.gbProcesos.Controls.Add(Me.Label24)
        Me.gbProcesos.Controls.Add(Me.txtDocSAP)
        Me.gbProcesos.Controls.Add(Me.Label23)
        Me.gbProcesos.Controls.Add(Me.txtFolioAtlas)
        Me.gbProcesos.Controls.Add(Me.Label22)
        Me.gbProcesos.Controls.Add(Me.btnCancel)
        Me.gbProcesos.Controls.Add(Me.btnNotificar)
        Me.gbProcesos.Controls.Add(Me.rbProduccion)
        Me.gbProcesos.Controls.Add(Me.rbScrap)
        Me.gbProcesos.Location = New System.Drawing.Point(1107, 0)
        Me.gbProcesos.Name = "gbProcesos"
        Me.gbProcesos.Size = New System.Drawing.Size(318, 297)
        Me.gbProcesos.TabIndex = 3
        Me.gbProcesos.TabStop = False
        Me.gbProcesos.Text = "Procesos"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(28, 75)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(273, 43)
        Me.btnCancel.TabIndex = 80
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnNotificar
        '
        Me.btnNotificar.BackColor = System.Drawing.Color.White
        Me.btnNotificar.Enabled = False
        Me.btnNotificar.Image = CType(resources.GetObject("btnNotificar.Image"), System.Drawing.Image)
        Me.btnNotificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNotificar.Location = New System.Drawing.Point(28, 26)
        Me.btnNotificar.Name = "btnNotificar"
        Me.btnNotificar.Size = New System.Drawing.Size(273, 43)
        Me.btnNotificar.TabIndex = 79
        Me.btnNotificar.Text = "Notificar"
        Me.btnNotificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNotificar.UseVisualStyleBackColor = False
        '
        'rbProduccion
        '
        Me.rbProduccion.AutoSize = True
        Me.rbProduccion.Location = New System.Drawing.Point(94, 227)
        Me.rbProduccion.Name = "rbProduccion"
        Me.rbProduccion.Size = New System.Drawing.Size(167, 20)
        Me.rbProduccion.TabIndex = 249
        Me.rbProduccion.Text = "Producto Terminado"
        Me.rbProduccion.UseVisualStyleBackColor = True
        '
        'rbScrap
        '
        Me.rbScrap.AutoSize = True
        Me.rbScrap.Location = New System.Drawing.Point(94, 257)
        Me.rbScrap.Name = "rbScrap"
        Me.rbScrap.Size = New System.Drawing.Size(67, 20)
        Me.rbScrap.TabIndex = 250
        Me.rbScrap.Text = "Scrap"
        Me.rbScrap.UseVisualStyleBackColor = True
        '
        'gbOrden
        '
        Me.gbOrden.Controls.Add(Me.Label13)
        Me.gbOrden.Controls.Add(Me.Label8)
        Me.gbOrden.Controls.Add(Me.txtPesoBruto)
        Me.gbOrden.Controls.Add(Me.Label10)
        Me.gbOrden.Controls.Add(Me.cmbTurnos)
        Me.gbOrden.Controls.Add(Me.txtPesoTara)
        Me.gbOrden.Controls.Add(Me.dtpFechaSAP)
        Me.gbOrden.Controls.Add(Me.chbSAP)
        Me.gbOrden.Controls.Add(Me.Label7)
        Me.gbOrden.Controls.Add(Me.dtpFecha)
        Me.gbOrden.Controls.Add(Me.txtFolio)
        Me.gbOrden.Controls.Add(Me.txtPesoNeto)
        Me.gbOrden.Controls.Add(Me.txtUnidades)
        Me.gbOrden.Controls.Add(Me.txtProducto)
        Me.gbOrden.Controls.Add(Me.txtIdProducto)
        Me.gbOrden.Controls.Add(Me.Label12)
        Me.gbOrden.Controls.Add(Me.txtOrdenProduccion)
        Me.gbOrden.Controls.Add(Me.Label11)
        Me.gbOrden.Controls.Add(Me.Label18)
        Me.gbOrden.Controls.Add(Me.Label16)
        Me.gbOrden.Controls.Add(Me.Label15)
        Me.gbOrden.Location = New System.Drawing.Point(387, 0)
        Me.gbOrden.Name = "gbOrden"
        Me.gbOrden.Size = New System.Drawing.Size(720, 151)
        Me.gbOrden.TabIndex = 1
        Me.gbOrden.TabStop = False
        Me.gbOrden.Text = "Notificación"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(309, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 16)
        Me.Label13.TabIndex = 263
        Me.Label13.Text = "Peso Bruto (Kg)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(428, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 16)
        Me.Label8.TabIndex = 262
        Me.Label8.Text = "Peso Tara (Kg)"
        '
        'txtPesoBruto
        '
        Me.txtPesoBruto.Location = New System.Drawing.Point(312, 114)
        Me.txtPesoBruto.Name = "txtPesoBruto"
        Me.txtPesoBruto.ReadOnly = True
        Me.txtPesoBruto.Size = New System.Drawing.Size(110, 22)
        Me.txtPesoBruto.TabIndex = 261
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 260
        Me.Label10.Text = "Turno"
        '
        'cmbTurnos
        '
        Me.cmbTurnos.FormattingEnabled = True
        Me.cmbTurnos.Location = New System.Drawing.Point(88, 18)
        Me.cmbTurnos.Name = "cmbTurnos"
        Me.cmbTurnos.Size = New System.Drawing.Size(102, 24)
        Me.cmbTurnos.TabIndex = 259
        '
        'txtPesoTara
        '
        Me.txtPesoTara.Location = New System.Drawing.Point(428, 114)
        Me.txtPesoTara.Name = "txtPesoTara"
        Me.txtPesoTara.ReadOnly = True
        Me.txtPesoTara.Size = New System.Drawing.Size(110, 22)
        Me.txtPesoTara.TabIndex = 258
        '
        'dtpFechaSAP
        '
        Me.dtpFechaSAP.CustomFormat = "yyyy-MM-dd"
        Me.dtpFechaSAP.Enabled = False
        Me.dtpFechaSAP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSAP.Location = New System.Drawing.Point(475, 20)
        Me.dtpFechaSAP.Name = "dtpFechaSAP"
        Me.dtpFechaSAP.Size = New System.Drawing.Size(128, 22)
        Me.dtpFechaSAP.TabIndex = 257
        '
        'chbSAP
        '
        Me.chbSAP.AutoSize = True
        Me.chbSAP.Checked = True
        Me.chbSAP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbSAP.Location = New System.Drawing.Point(412, 24)
        Me.chbSAP.Name = "chbSAP"
        Me.chbSAP.Size = New System.Drawing.Size(57, 20)
        Me.chbSAP.TabIndex = 256
        Me.chbSAP.Text = "SAP"
        Me.chbSAP.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(211, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 255
        Me.Label7.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "yyyy-MM-dd"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(268, 20)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(128, 22)
        Me.dtpFecha.TabIndex = 254
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(80, 114)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(110, 22)
        Me.txtFolio.TabIndex = 240
        '
        'txtPesoNeto
        '
        Me.txtPesoNeto.Location = New System.Drawing.Point(544, 114)
        Me.txtPesoNeto.Name = "txtPesoNeto"
        Me.txtPesoNeto.ReadOnly = True
        Me.txtPesoNeto.Size = New System.Drawing.Size(110, 22)
        Me.txtPesoNeto.TabIndex = 239
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(196, 114)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.ReadOnly = True
        Me.txtUnidades.Size = New System.Drawing.Size(110, 22)
        Me.txtUnidades.TabIndex = 238
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(380, 54)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(331, 22)
        Me.txtProducto.TabIndex = 237
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(272, 54)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.ReadOnly = True
        Me.txtIdProducto.Size = New System.Drawing.Size(102, 22)
        Me.txtIdProducto.TabIndex = 236
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(196, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 235
        Me.Label12.Text = "Producto"
        '
        'txtOrdenProduccion
        '
        Me.txtOrdenProduccion.Location = New System.Drawing.Point(88, 54)
        Me.txtOrdenProduccion.Name = "txtOrdenProduccion"
        Me.txtOrdenProduccion.ReadOnly = True
        Me.txtOrdenProduccion.Size = New System.Drawing.Size(102, 22)
        Me.txtOrdenProduccion.TabIndex = 234
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 16)
        Me.Label11.TabIndex = 233
        Me.Label11.Text = "O.D.F."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(107, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 16)
        Me.Label18.TabIndex = 224
        Me.Label18.Text = "Folio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(200, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 16)
        Me.Label16.TabIndex = 220
        Me.Label16.Text = "Tramos (Ud)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(541, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 16)
        Me.Label15.TabIndex = 219
        Me.Label15.Text = "Peso Neto (Kg)"
        '
        'gbConsulta
        '
        Me.gbConsulta.Controls.Add(Me.Label21)
        Me.gbConsulta.Controls.Add(Me.cmbEstatus)
        Me.gbConsulta.Controls.Add(Me.txtConsultaOrden)
        Me.gbConsulta.Controls.Add(Me.Label4)
        Me.gbConsulta.Controls.Add(Me.BtnConsulta)
        Me.gbConsulta.Controls.Add(Me.DTP_FF)
        Me.gbConsulta.Controls.Add(Me.DTP_FI)
        Me.gbConsulta.Controls.Add(Me.Label6)
        Me.gbConsulta.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbConsulta.Location = New System.Drawing.Point(0, 0)
        Me.gbConsulta.Name = "gbConsulta"
        Me.gbConsulta.Size = New System.Drawing.Size(387, 297)
        Me.gbConsulta.TabIndex = 0
        Me.gbConsulta.TabStop = False
        Me.gbConsulta.Text = "Consulta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 268
        Me.Label4.Text = "Orden"
        '
        'BtnConsulta
        '
        Me.BtnConsulta.BackColor = System.Drawing.Color.White
        Me.BtnConsulta.Image = CType(resources.GetObject("BtnConsulta.Image"), System.Drawing.Image)
        Me.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsulta.Location = New System.Drawing.Point(65, 145)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(284, 43)
        Me.BtnConsulta.TabIndex = 78
        Me.BtnConsulta.Text = "Consulta"
        Me.BtnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnConsulta.UseVisualStyleBackColor = False
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(245, 28)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(128, 22)
        Me.DTP_FF.TabIndex = 76
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(89, 28)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(128, 22)
        Me.DTP_FI.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Periodo"
        '
        'txtConsultaOrden
        '
        Me.txtConsultaOrden.Location = New System.Drawing.Point(89, 86)
        Me.txtConsultaOrden.Name = "txtConsultaOrden"
        Me.txtConsultaOrden.Size = New System.Drawing.Size(128, 22)
        Me.txtConsultaOrden.TabIndex = 274
        '
        'cmbEstatus
        '
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(89, 56)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(282, 24)
        Me.cmbEstatus.TabIndex = 264
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(24, 59)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 16)
        Me.Label21.TabIndex = 275
        Me.Label21.Text = "Estatus"
        '
        'txtFolioAtlas
        '
        Me.txtFolioAtlas.Location = New System.Drawing.Point(124, 129)
        Me.txtFolioAtlas.Name = "txtFolioAtlas"
        Me.txtFolioAtlas.ReadOnly = True
        Me.txtFolioAtlas.Size = New System.Drawing.Size(128, 22)
        Me.txtFolioAtlas.TabIndex = 276
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(75, 132)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 16)
        Me.Label22.TabIndex = 275
        Me.Label22.Text = "Folio"
        '
        'txtDocSAP
        '
        Me.txtDocSAP.Location = New System.Drawing.Point(124, 157)
        Me.txtDocSAP.Name = "txtDocSAP"
        Me.txtDocSAP.ReadOnly = True
        Me.txtDocSAP.Size = New System.Drawing.Size(128, 22)
        Me.txtDocSAP.TabIndex = 278
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(28, 160)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 16)
        Me.Label23.TabIndex = 277
        Me.Label23.Text = "Notificación"
        '
        'txtConSAP
        '
        Me.txtConSAP.Location = New System.Drawing.Point(124, 185)
        Me.txtConSAP.Name = "txtConSAP"
        Me.txtConSAP.ReadOnly = True
        Me.txtConSAP.Size = New System.Drawing.Size(128, 22)
        Me.txtConSAP.TabIndex = 280
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(25, 188)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(93, 16)
        Me.Label24.TabIndex = 279
        Me.Label24.Text = "Consecutivo"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.gbEstatus)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1677, 64)
        Me.Panel3.TabIndex = 10
        '
        'gbEstatus
        '
        Me.gbEstatus.Controls.Add(Me.Label20)
        Me.gbEstatus.Controls.Add(Me.Panel7)
        Me.gbEstatus.Controls.Add(Me.Label19)
        Me.gbEstatus.Controls.Add(Me.Panel6)
        Me.gbEstatus.Controls.Add(Me.Label17)
        Me.gbEstatus.Controls.Add(Me.Panel5)
        Me.gbEstatus.Controls.Add(Me.Label14)
        Me.gbEstatus.Controls.Add(Me.Panel4)
        Me.gbEstatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbEstatus.Location = New System.Drawing.Point(0, 0)
        Me.gbEstatus.Name = "gbEstatus"
        Me.gbEstatus.Size = New System.Drawing.Size(1677, 64)
        Me.gbEstatus.TabIndex = 0
        Me.gbEstatus.TabStop = False
        Me.gbEstatus.Text = "Estatus"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.Location = New System.Drawing.Point(12, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(25, 21)
        Me.Panel4.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(43, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Registro Nuevo"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightYellow
        Me.Panel5.Location = New System.Drawing.Point(165, 28)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(25, 21)
        Me.Panel5.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(196, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(175, 16)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Registro en Tratamiento"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightGreen
        Me.Panel6.Location = New System.Drawing.Point(377, 28)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(25, 21)
        Me.Panel6.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(408, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(143, 16)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Registro Finalizado"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightCoral
        Me.Panel7.Location = New System.Drawing.Point(557, 28)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(25, 21)
        Me.Panel7.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(588, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(146, 16)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Registro Cancelado"
        '
        'spcRegistros
        '
        Me.spcRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcRegistros.Location = New System.Drawing.Point(0, 64)
        Me.spcRegistros.Name = "spcRegistros"
        Me.spcRegistros.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcRegistros.Panel1
        '
        Me.spcRegistros.Panel1.Controls.Add(Me.gbRegistros)
        '
        'spcRegistros.Panel2
        '
        Me.spcRegistros.Panel2.Controls.Add(Me.gbDetalle)
        Me.spcRegistros.Size = New System.Drawing.Size(1677, 499)
        Me.spcRegistros.SplitterDistance = 355
        Me.spcRegistros.TabIndex = 11
        '
        'gbDetalle
        '
        Me.gbDetalle.Controls.Add(Me.dgvDetalle)
        Me.gbDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbDetalle.Location = New System.Drawing.Point(0, 0)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(1677, 140)
        Me.gbDetalle.TabIndex = 1
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Detalle"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.AllowUserToOrderColumns = True
        Me.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalle.Location = New System.Drawing.Point(3, 18)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(1671, 119)
        Me.dgvDetalle.TabIndex = 11
        '
        'gbRegistros
        '
        Me.gbRegistros.Controls.Add(Me.dgvNuevos)
        Me.gbRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbRegistros.Location = New System.Drawing.Point(0, 0)
        Me.gbRegistros.Name = "gbRegistros"
        Me.gbRegistros.Size = New System.Drawing.Size(1677, 355)
        Me.gbRegistros.TabIndex = 1
        Me.gbRegistros.TabStop = False
        Me.gbRegistros.Text = "Producción Separada"
        '
        'dgvNuevos
        '
        Me.dgvNuevos.AllowUserToAddRows = False
        Me.dgvNuevos.AllowUserToDeleteRows = False
        Me.dgvNuevos.AllowUserToOrderColumns = True
        Me.dgvNuevos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvNuevos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvNuevos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNuevos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNuevos.Location = New System.Drawing.Point(3, 18)
        Me.dgvNuevos.Name = "dgvNuevos"
        Me.dgvNuevos.ReadOnly = True
        Me.dgvNuevos.Size = New System.Drawing.Size(1671, 334)
        Me.dgvNuevos.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.spcRegistros)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 337)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1677, 563)
        Me.Panel2.TabIndex = 178
        '
        'FrmProduccionProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1677, 900)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProduccionProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProduccionProceso"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gbNotificacion.ResumeLayout(False)
        Me.gbNotificacion.PerformLayout()
        Me.gbProcesos.ResumeLayout(False)
        Me.gbProcesos.PerformLayout()
        Me.gbOrden.ResumeLayout(False)
        Me.gbOrden.PerformLayout()
        Me.gbConsulta.ResumeLayout(False)
        Me.gbConsulta.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.gbEstatus.ResumeLayout(False)
        Me.gbEstatus.PerformLayout()
        Me.spcRegistros.Panel1.ResumeLayout(False)
        Me.spcRegistros.Panel2.ResumeLayout(False)
        CType(Me.spcRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcRegistros.ResumeLayout(False)
        Me.gbDetalle.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRegistros.ResumeLayout(False)
        CType(Me.dgvNuevos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbCalculadora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents gbOrden As System.Windows.Forms.GroupBox
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents gbProcesos As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnNotificar As System.Windows.Forms.Button
    Friend WithEvents rbScrap As System.Windows.Forms.RadioButton
    Friend WithEvents rbProduccion As System.Windows.Forms.RadioButton
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoNeto As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtIdProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtOrdenProduccion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dtpFechaSAP As System.Windows.Forms.DateTimePicker
    Friend WithEvents chbSAP As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPesoTara As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbTurnos As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPesoBruto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbNotificacion As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDefecto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCausa As System.Windows.Forms.ComboBox
    Friend WithEvents txtPorFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUnidadesFinales As System.Windows.Forms.TextBox
    Friend WithEvents lblDefecto As System.Windows.Forms.Label
    Friend WithEvents lblCausa As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tsbBoleta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbExportaExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtConsultaOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtConSAP As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDocSAP As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtFolioAtlas As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents gbEstatus As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents spcRegistros As System.Windows.Forms.SplitContainer
    Friend WithEvents gbRegistros As System.Windows.Forms.GroupBox
    Friend WithEvents dgvNuevos As System.Windows.Forms.DataGridView
    Friend WithEvents gbDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
