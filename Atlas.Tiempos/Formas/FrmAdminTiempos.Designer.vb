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
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRegTiemposParoProd = New System.Windows.Forms.Button()
        Me.GB_Consulta = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTurnos = New System.Windows.Forms.ComboBox()
        Me.Btn_Consulta = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTP_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.btnCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvOrdenes = New System.Windows.Forms.DataGridView()
        Me.splContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.pCabecera.SuspendLayout()
        Me.gbAcciones.SuspendLayout()
        Me.GB_Consulta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splContainer1.Panel1.SuspendLayout()
        Me.splContainer1.Panel2.SuspendLayout()
        Me.splContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tsbClose.Size = New System.Drawing.Size(102, 34)
        Me.tsbClose.Text = "Cerrar"
        '
        'pCabecera
        '
        Me.pCabecera.Controls.Add(Me.gbAcciones)
        Me.pCabecera.Controls.Add(Me.GB_Consulta)
        Me.pCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pCabecera.Location = New System.Drawing.Point(0, 38)
        Me.pCabecera.Name = "pCabecera"
        Me.pCabecera.Size = New System.Drawing.Size(1484, 223)
        Me.pCabecera.TabIndex = 9
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.btnDelete)
        Me.gbAcciones.Controls.Add(Me.btnRegTiemposParoProd)
        Me.gbAcciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbAcciones.Location = New System.Drawing.Point(552, 0)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(767, 223)
        Me.gbAcciones.TabIndex = 294
        Me.gbAcciones.TabStop = False
        Me.gbAcciones.Text = "Registra tiempos"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(19, 112)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(340, 80)
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
        Me.btnRegTiemposParoProd.Size = New System.Drawing.Size(340, 80)
        Me.btnRegTiemposParoProd.TabIndex = 0
        Me.btnRegTiemposParoProd.Text = "Registra Horas Paro / Productivas"
        Me.btnRegTiemposParoProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegTiemposParoProd.UseVisualStyleBackColor = False
        '
        'GB_Consulta
        '
        Me.GB_Consulta.Controls.Add(Me.Label4)
        Me.GB_Consulta.Controls.Add(Me.cmbTurnos)
        Me.GB_Consulta.Controls.Add(Me.Btn_Consulta)
        Me.GB_Consulta.Controls.Add(Me.Label6)
        Me.GB_Consulta.Controls.Add(Me.DTP_Fecha)
        Me.GB_Consulta.Dock = System.Windows.Forms.DockStyle.Left
        Me.GB_Consulta.Location = New System.Drawing.Point(0, 0)
        Me.GB_Consulta.Name = "GB_Consulta"
        Me.GB_Consulta.Size = New System.Drawing.Size(552, 223)
        Me.GB_Consulta.TabIndex = 292
        Me.GB_Consulta.TabStop = False
        Me.GB_Consulta.Text = "Consulta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 293
        Me.Label4.Text = "Turno"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTurnos
        '
        Me.cmbTurnos.FormattingEnabled = True
        Me.cmbTurnos.Location = New System.Drawing.Point(234, 58)
        Me.cmbTurnos.Name = "cmbTurnos"
        Me.cmbTurnos.Size = New System.Drawing.Size(121, 28)
        Me.cmbTurnos.TabIndex = 292
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.BackColor = System.Drawing.Color.White
        Me.Btn_Consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Consulta.Image = CType(resources.GetObject("Btn_Consulta.Image"), System.Drawing.Image)
        Me.Btn_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Consulta.Location = New System.Drawing.Point(120, 125)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(283, 49)
        Me.Btn_Consulta.TabIndex = 291
        Me.Btn_Consulta.Text = "Consulta"
        Me.Btn_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Consulta.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 30)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 281
        Me.Label6.Text = "Fecha Reporte"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTP_Fecha
        '
        Me.DTP_Fecha.CustomFormat = "yyyy-MM-dd"
        Me.DTP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_Fecha.Location = New System.Drawing.Point(234, 25)
        Me.DTP_Fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP_Fecha.Name = "DTP_Fecha"
        Me.DTP_Fecha.Size = New System.Drawing.Size(149, 26)
        Me.DTP_Fecha.TabIndex = 282
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(87, 34)
        Me.btnCerrar.Text = "Cerrar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvOrdenes)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1484, 200)
        Me.GroupBox1.TabIndex = 343
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle Horas Paro por Turno"
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
        Me.dgvOrdenes.Location = New System.Drawing.Point(3, 22)
        Me.dgvOrdenes.Name = "dgvOrdenes"
        Me.dgvOrdenes.ReadOnly = True
        Me.dgvOrdenes.Size = New System.Drawing.Size(1478, 175)
        Me.dgvOrdenes.TabIndex = 343
        '
        'splContainer1
        '
        Me.splContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splContainer1.Location = New System.Drawing.Point(0, 261)
        Me.splContainer1.Name = "splContainer1"
        Me.splContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splContainer1.Panel1
        '
        Me.splContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'splContainer1.Panel2
        '
        Me.splContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.splContainer1.Size = New System.Drawing.Size(1484, 389)
        Me.splContainer1.SplitterDistance = 200
        Me.splContainer1.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvDetalle)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1484, 185)
        Me.GroupBox2.TabIndex = 344
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resumen Horas Paro por Maquina"
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
        Me.dgvDetalle.Location = New System.Drawing.Point(3, 22)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(1478, 160)
        Me.dgvDetalle.TabIndex = 344
        '
        'FrmAdminTiempos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1484, 650)
        Me.Controls.Add(Me.splContainer1)
        Me.Controls.Add(Me.pCabecera)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAdminTiempos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAdminTiemposParo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pCabecera.ResumeLayout(False)
        Me.gbAcciones.ResumeLayout(False)
        Me.GB_Consulta.ResumeLayout(False)
        Me.GB_Consulta.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splContainer1.Panel1.ResumeLayout(False)
        Me.splContainer1.Panel2.ResumeLayout(False)
        CType(Me.splContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pCabecera As System.Windows.Forms.Panel
    Friend WithEvents GB_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Consulta As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents DTP_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnRegTiemposParoProd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents tsbClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvOrdenes As System.Windows.Forms.DataGridView
    Friend WithEvents splContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTurnos As System.Windows.Forms.ComboBox
End Class
