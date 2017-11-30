<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminTiempos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdminTiempos))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsbClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.pCabecera = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRegTiemposParoProd = New System.Windows.Forms.Button()
        Me.gbProcesos = New System.Windows.Forms.GroupBox()
        Me.btnCalculaTiempos = New System.Windows.Forms.Button()
        Me.GB_Consulta = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbPuestoTrabajo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrdenProduccion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Btn_Consulta = New System.Windows.Forms.Button()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.splContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvOrdenes = New System.Windows.Forms.DataGridView()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.btnCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GBDetalle = New System.Windows.Forms.GroupBox()
        Me.dgvDetalleHoras = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.pCabecera.SuspendLayout()
        Me.gbAcciones.SuspendLayout()
        Me.gbProcesos.SuspendLayout()
        Me.GB_Consulta.SuspendLayout()
        CType(Me.splContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splContainer1.Panel1.SuspendLayout()
        Me.splContainer1.Panel2.SuspendLayout()
        Me.splContainer1.SuspendLayout()
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDetalle.SuspendLayout()
        CType(Me.dgvDetalleHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbClose})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1484, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsbClose
        '
        Me.tsbClose.Image = CType(resources.GetObject("tsbClose.Image"), System.Drawing.Image)
        Me.tsbClose.Name = "tsbClose"
        Me.tsbClose.Size = New System.Drawing.Size(87, 34)
        Me.tsbClose.Text = "Cerrar"
        '
        'pCabecera
        '
        Me.pCabecera.Controls.Add(Me.Label3)
        Me.pCabecera.Controls.Add(Me.Panel3)
        Me.pCabecera.Controls.Add(Me.Label2)
        Me.pCabecera.Controls.Add(Me.Panel2)
        Me.pCabecera.Controls.Add(Me.Label1)
        Me.pCabecera.Controls.Add(Me.Panel1)
        Me.pCabecera.Controls.Add(Me.Label13)
        Me.pCabecera.Controls.Add(Me.Panel10)
        Me.pCabecera.Controls.Add(Me.gbAcciones)
        Me.pCabecera.Controls.Add(Me.gbProcesos)
        Me.pCabecera.Controls.Add(Me.GB_Consulta)
        Me.pCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pCabecera.Location = New System.Drawing.Point(0, 38)
        Me.pCabecera.Name = "pCabecera"
        Me.pCabecera.Size = New System.Drawing.Size(1484, 261)
        Me.pCabecera.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1207, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 302
        Me.Label3.Text = "Registro cancelado"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightCoral
        Me.Panel3.Location = New System.Drawing.Point(1173, 137)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(28, 20)
        Me.Panel3.TabIndex = 301
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1207, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 300
        Me.Label2.Text = "Registro activo"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Aquamarine
        Me.Panel2.Location = New System.Drawing.Point(1173, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(28, 20)
        Me.Panel2.TabIndex = 299
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1207, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 16)
        Me.Label1.TabIndex = 298
        Me.Label1.Text = "Registro Fecha/Turno en Proceso"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.Location = New System.Drawing.Point(1173, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(28, 20)
        Me.Panel1.TabIndex = 297
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1207, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(229, 16)
        Me.Label13.TabIndex = 296
        Me.Label13.Text = "Registro Fecha/Turno Completo"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LightGreen
        Me.Panel10.Location = New System.Drawing.Point(1173, 26)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(28, 20)
        Me.Panel10.TabIndex = 295
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.btnEdit)
        Me.gbAcciones.Controls.Add(Me.btnDelete)
        Me.gbAcciones.Controls.Add(Me.btnRegTiemposParoProd)
        Me.gbAcciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbAcciones.Location = New System.Drawing.Point(783, 0)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(371, 261)
        Me.gbAcciones.TabIndex = 294
        Me.gbAcciones.TabStop = False
        Me.gbAcciones.Text = "Registra tiempos"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.White
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(19, 152)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(340, 57)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Modifica Registro Horas"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(19, 89)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(340, 57)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Baja Registro Horas"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnRegTiemposParoProd
        '
        Me.btnRegTiemposParoProd.BackColor = System.Drawing.Color.White
        Me.btnRegTiemposParoProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegTiemposParoProd.Image = CType(resources.GetObject("btnRegTiemposParoProd.Image"), System.Drawing.Image)
        Me.btnRegTiemposParoProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegTiemposParoProd.Location = New System.Drawing.Point(19, 26)
        Me.btnRegTiemposParoProd.Name = "btnRegTiemposParoProd"
        Me.btnRegTiemposParoProd.Size = New System.Drawing.Size(340, 57)
        Me.btnRegTiemposParoProd.TabIndex = 0
        Me.btnRegTiemposParoProd.Text = "Registra Horas Paro / Productivas"
        Me.btnRegTiemposParoProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegTiemposParoProd.UseVisualStyleBackColor = False
        '
        'gbProcesos
        '
        Me.gbProcesos.Controls.Add(Me.btnCalculaTiempos)
        Me.gbProcesos.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbProcesos.Location = New System.Drawing.Point(424, 0)
        Me.gbProcesos.Name = "gbProcesos"
        Me.gbProcesos.Size = New System.Drawing.Size(359, 261)
        Me.gbProcesos.TabIndex = 293
        Me.gbProcesos.TabStop = False
        Me.gbProcesos.Text = "Calcula tiempos"
        '
        'btnCalculaTiempos
        '
        Me.btnCalculaTiempos.BackColor = System.Drawing.Color.White
        Me.btnCalculaTiempos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculaTiempos.Image = CType(resources.GetObject("btnCalculaTiempos.Image"), System.Drawing.Image)
        Me.btnCalculaTiempos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalculaTiempos.Location = New System.Drawing.Point(13, 26)
        Me.btnCalculaTiempos.Name = "btnCalculaTiempos"
        Me.btnCalculaTiempos.Size = New System.Drawing.Size(340, 57)
        Me.btnCalculaTiempos.TabIndex = 0
        Me.btnCalculaTiempos.Text = "Calcula Tiempo Productivo"
        Me.btnCalculaTiempos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalculaTiempos.UseVisualStyleBackColor = False
        '
        'GB_Consulta
        '
        Me.GB_Consulta.Controls.Add(Me.Label5)
        Me.GB_Consulta.Controls.Add(Me.ComboBox1)
        Me.GB_Consulta.Controls.Add(Me.cmbPuestoTrabajo)
        Me.GB_Consulta.Controls.Add(Me.Label4)
        Me.GB_Consulta.Controls.Add(Me.txtOrdenProduccion)
        Me.GB_Consulta.Controls.Add(Me.Label11)
        Me.GB_Consulta.Controls.Add(Me.Btn_Consulta)
        Me.GB_Consulta.Controls.Add(Me.DTP_FI)
        Me.GB_Consulta.Controls.Add(Me.Label6)
        Me.GB_Consulta.Controls.Add(Me.DTP_FF)
        Me.GB_Consulta.Dock = System.Windows.Forms.DockStyle.Left
        Me.GB_Consulta.Location = New System.Drawing.Point(0, 0)
        Me.GB_Consulta.Name = "GB_Consulta"
        Me.GB_Consulta.Size = New System.Drawing.Size(424, 261)
        Me.GB_Consulta.TabIndex = 292
        Me.GB_Consulta.TabStop = False
        Me.GB_Consulta.Text = "Consulta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 296
        Me.Label5.Text = "Turno"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(147, 119)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(119, 24)
        Me.ComboBox1.TabIndex = 295
        '
        'cmbPuestoTrabajo
        '
        Me.cmbPuestoTrabajo.FormattingEnabled = True
        Me.cmbPuestoTrabajo.Location = New System.Drawing.Point(147, 59)
        Me.cmbPuestoTrabajo.Name = "cmbPuestoTrabajo"
        Me.cmbPuestoTrabajo.Size = New System.Drawing.Size(263, 24)
        Me.cmbPuestoTrabajo.TabIndex = 294
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 16)
        Me.Label4.TabIndex = 292
        Me.Label4.Text = "Orden Producción"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOrdenProduccion
        '
        Me.txtOrdenProduccion.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrdenProduccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrdenProduccion.Location = New System.Drawing.Point(147, 90)
        Me.txtOrdenProduccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrdenProduccion.MaxLength = 10
        Me.txtOrdenProduccion.Name = "txtOrdenProduccion"
        Me.txtOrdenProduccion.Size = New System.Drawing.Size(119, 22)
        Me.txtOrdenProduccion.TabIndex = 293
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 62)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 16)
        Me.Label11.TabIndex = 286
        Me.Label11.Text = "Puesto Trabajo"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.BackColor = System.Drawing.Color.White
        Me.Btn_Consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Consulta.Image = CType(resources.GetObject("Btn_Consulta.Image"), System.Drawing.Image)
        Me.Btn_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Consulta.Location = New System.Drawing.Point(79, 181)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(283, 49)
        Me.Btn_Consulta.TabIndex = 291
        Me.Btn_Consulta.Text = "Consulta"
        Me.Btn_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Consulta.UseVisualStyleBackColor = False
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(147, 30)
        Me.DTP_FI.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(119, 22)
        Me.DTP_FI.TabIndex = 280
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 35)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 281
        Me.Label6.Text = "Periodo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(291, 30)
        Me.DTP_FF.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(119, 22)
        Me.DTP_FF.TabIndex = 282
        '
        'splContainer1
        '
        Me.splContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.splContainer1.Location = New System.Drawing.Point(0, 299)
        Me.splContainer1.Name = "splContainer1"
        Me.splContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splContainer1.Panel1
        '
        Me.splContainer1.Panel1.Controls.Add(Me.dgvOrdenes)
        '
        'splContainer1.Panel2
        '
        Me.splContainer1.Panel2.Controls.Add(Me.dgvDetalle)
        Me.splContainer1.Size = New System.Drawing.Size(1484, 428)
        Me.splContainer1.SplitterDistance = 221
        Me.splContainer1.TabIndex = 12
        '
        'dgvOrdenes
        '
        Me.dgvOrdenes.AllowUserToAddRows = False
        Me.dgvOrdenes.AllowUserToDeleteRows = False
        Me.dgvOrdenes.AllowUserToOrderColumns = True
        Me.dgvOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvOrdenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrdenes.Location = New System.Drawing.Point(0, 0)
        Me.dgvOrdenes.Name = "dgvOrdenes"
        Me.dgvOrdenes.ReadOnly = True
        Me.dgvOrdenes.Size = New System.Drawing.Size(1484, 221)
        Me.dgvOrdenes.TabIndex = 342
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
        Me.dgvDetalle.Location = New System.Drawing.Point(0, 0)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(1484, 203)
        Me.dgvDetalle.TabIndex = 342
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(87, 34)
        Me.btnCerrar.Text = "Cerrar"
        '
        'GBDetalle
        '
        Me.GBDetalle.Controls.Add(Me.dgvDetalleHoras)
        Me.GBDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GBDetalle.Location = New System.Drawing.Point(0, 694)
        Me.GBDetalle.Name = "GBDetalle"
        Me.GBDetalle.Size = New System.Drawing.Size(1484, 184)
        Me.GBDetalle.TabIndex = 13
        Me.GBDetalle.TabStop = False
        Me.GBDetalle.Text = "Detalle Pesaje"
        '
        'dgvDetalleHoras
        '
        Me.dgvDetalleHoras.AllowUserToAddRows = False
        Me.dgvDetalleHoras.AllowUserToDeleteRows = False
        Me.dgvDetalleHoras.AllowUserToOrderColumns = True
        Me.dgvDetalleHoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvDetalleHoras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDetalleHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleHoras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalleHoras.Location = New System.Drawing.Point(3, 18)
        Me.dgvDetalleHoras.Name = "dgvDetalleHoras"
        Me.dgvDetalleHoras.ReadOnly = True
        Me.dgvDetalleHoras.Size = New System.Drawing.Size(1478, 163)
        Me.dgvDetalleHoras.TabIndex = 343
        '
        'FrmAdminTiempos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1484, 878)
        Me.Controls.Add(Me.GBDetalle)
        Me.Controls.Add(Me.splContainer1)
        Me.Controls.Add(Me.pCabecera)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAdminTiempos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAdminTiemposParo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pCabecera.ResumeLayout(False)
        Me.pCabecera.PerformLayout()
        Me.gbAcciones.ResumeLayout(False)
        Me.gbProcesos.ResumeLayout(False)
        Me.GB_Consulta.ResumeLayout(False)
        Me.GB_Consulta.PerformLayout()
        Me.splContainer1.Panel1.ResumeLayout(False)
        Me.splContainer1.Panel2.ResumeLayout(False)
        CType(Me.splContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splContainer1.ResumeLayout(False)
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDetalle.ResumeLayout(False)
        CType(Me.dgvDetalleHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pCabecera As System.Windows.Forms.Panel
    Friend WithEvents GB_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Consulta As System.Windows.Forms.Button
    Public WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents splContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvOrdenes As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents gbProcesos As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculaTiempos As System.Windows.Forms.Button
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnRegTiemposParoProd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents GBDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalleHoras As System.Windows.Forms.DataGridView
    Friend WithEvents tsbClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbPuestoTrabajo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOrdenProduccion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
