<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportesProduccion
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
        Me.PHeader = New System.Windows.Forms.Panel()
        Me.RdbDetalle = New System.Windows.Forms.RadioButton()
        Me.GBQuery = New System.Windows.Forms.GroupBox()
        Me.txtOrdenProduccion = New System.Windows.Forms.TextBox()
        Me.Btn_Consulta = New System.Windows.Forms.Button()
        Me.RBGrp = New System.Windows.Forms.RadioButton()
        Me.RBProducto = New System.Windows.Forms.RadioButton()
        Me.RBOrden = New System.Windows.Forms.RadioButton()
        Me.RBPuesto = New System.Windows.Forms.RadioButton()
        Me.RBSeccion = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBGrupo = New System.Windows.Forms.ComboBox()
        Me.CBProducto = New System.Windows.Forms.ComboBox()
        Me.CBPuesto = New System.Windows.Forms.ComboBox()
        Me.CBSeccion = New System.Windows.Forms.ComboBox()
        Me.RBTurno = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBTurno = New System.Windows.Forms.ComboBox()
        Me.RBPeriod = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPF = New System.Windows.Forms.DateTimePicker()
        Me.DTPI = New System.Windows.Forms.DateTimePicker()
        Me.CBArea = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RdbConsolidado = New System.Windows.Forms.RadioButton()
        Me.PDetail = New System.Windows.Forms.Panel()
        Me.GB_Pesajes = New System.Windows.Forms.GroupBox()
        Me.DGVQuery = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExportExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.PHeader.SuspendLayout()
        Me.GBQuery.SuspendLayout()
        Me.PDetail.SuspendLayout()
        Me.GB_Pesajes.SuspendLayout()
        CType(Me.DGVQuery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PHeader
        '
        Me.PHeader.Controls.Add(Me.RdbDetalle)
        Me.PHeader.Controls.Add(Me.GBQuery)
        Me.PHeader.Controls.Add(Me.RdbConsolidado)
        Me.PHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PHeader.Location = New System.Drawing.Point(0, 33)
        Me.PHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PHeader.Name = "PHeader"
        Me.PHeader.Size = New System.Drawing.Size(1433, 290)
        Me.PHeader.TabIndex = 0
        '
        'RdbDetalle
        '
        Me.RdbDetalle.AutoSize = True
        Me.RdbDetalle.Location = New System.Drawing.Point(618, 46)
        Me.RdbDetalle.Name = "RdbDetalle"
        Me.RdbDetalle.Size = New System.Drawing.Size(110, 24)
        Me.RdbDetalle.TabIndex = 7
        Me.RdbDetalle.TabStop = True
        Me.RdbDetalle.Text = "Detallado"
        Me.RdbDetalle.UseVisualStyleBackColor = True
        '
        'GBQuery
        '
        Me.GBQuery.Controls.Add(Me.txtOrdenProduccion)
        Me.GBQuery.Controls.Add(Me.Btn_Consulta)
        Me.GBQuery.Controls.Add(Me.RBGrp)
        Me.GBQuery.Controls.Add(Me.RBProducto)
        Me.GBQuery.Controls.Add(Me.RBOrden)
        Me.GBQuery.Controls.Add(Me.RBPuesto)
        Me.GBQuery.Controls.Add(Me.RBSeccion)
        Me.GBQuery.Controls.Add(Me.Label8)
        Me.GBQuery.Controls.Add(Me.Label7)
        Me.GBQuery.Controls.Add(Me.Label6)
        Me.GBQuery.Controls.Add(Me.Label5)
        Me.GBQuery.Controls.Add(Me.Label4)
        Me.GBQuery.Controls.Add(Me.CBGrupo)
        Me.GBQuery.Controls.Add(Me.CBProducto)
        Me.GBQuery.Controls.Add(Me.CBPuesto)
        Me.GBQuery.Controls.Add(Me.CBSeccion)
        Me.GBQuery.Controls.Add(Me.RBTurno)
        Me.GBQuery.Controls.Add(Me.Label3)
        Me.GBQuery.Controls.Add(Me.CBTurno)
        Me.GBQuery.Controls.Add(Me.RBPeriod)
        Me.GBQuery.Controls.Add(Me.Label2)
        Me.GBQuery.Controls.Add(Me.DTPF)
        Me.GBQuery.Controls.Add(Me.DTPI)
        Me.GBQuery.Controls.Add(Me.CBArea)
        Me.GBQuery.Controls.Add(Me.Label1)
        Me.GBQuery.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBQuery.Location = New System.Drawing.Point(0, 0)
        Me.GBQuery.Name = "GBQuery"
        Me.GBQuery.Size = New System.Drawing.Size(587, 290)
        Me.GBQuery.TabIndex = 0
        Me.GBQuery.TabStop = False
        Me.GBQuery.Text = "Consulta"
        '
        'txtOrdenProduccion
        '
        Me.txtOrdenProduccion.Location = New System.Drawing.Point(140, 154)
        Me.txtOrdenProduccion.Name = "txtOrdenProduccion"
        Me.txtOrdenProduccion.Size = New System.Drawing.Size(384, 26)
        Me.txtOrdenProduccion.TabIndex = 25
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = Global.Atlas.Consultations.My.Resources.Resources.Btn_Consulta
        Me.Btn_Consulta.Location = New System.Drawing.Point(140, 238)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(384, 42)
        Me.Btn_Consulta.TabIndex = 24
        Me.Btn_Consulta.Text = "Consulta"
        Me.Btn_Consulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Consulta.UseVisualStyleBackColor = True
        '
        'RBGrp
        '
        Me.RBGrp.AutoSize = True
        Me.RBGrp.Location = New System.Drawing.Point(551, 213)
        Me.RBGrp.Name = "RBGrp"
        Me.RBGrp.Size = New System.Drawing.Size(17, 16)
        Me.RBGrp.TabIndex = 23
        Me.RBGrp.TabStop = True
        Me.RBGrp.UseVisualStyleBackColor = True
        '
        'RBProducto
        '
        Me.RBProducto.AutoSize = True
        Me.RBProducto.Location = New System.Drawing.Point(551, 185)
        Me.RBProducto.Name = "RBProducto"
        Me.RBProducto.Size = New System.Drawing.Size(17, 16)
        Me.RBProducto.TabIndex = 22
        Me.RBProducto.TabStop = True
        Me.RBProducto.UseVisualStyleBackColor = True
        '
        'RBOrden
        '
        Me.RBOrden.AutoSize = True
        Me.RBOrden.Location = New System.Drawing.Point(551, 159)
        Me.RBOrden.Name = "RBOrden"
        Me.RBOrden.Size = New System.Drawing.Size(17, 16)
        Me.RBOrden.TabIndex = 21
        Me.RBOrden.TabStop = True
        Me.RBOrden.UseVisualStyleBackColor = True
        '
        'RBPuesto
        '
        Me.RBPuesto.AutoSize = True
        Me.RBPuesto.Location = New System.Drawing.Point(551, 131)
        Me.RBPuesto.Name = "RBPuesto"
        Me.RBPuesto.Size = New System.Drawing.Size(17, 16)
        Me.RBPuesto.TabIndex = 20
        Me.RBPuesto.TabStop = True
        Me.RBPuesto.UseVisualStyleBackColor = True
        '
        'RBSeccion
        '
        Me.RBSeccion.AutoSize = True
        Me.RBSeccion.Location = New System.Drawing.Point(551, 103)
        Me.RBSeccion.Name = "RBSeccion"
        Me.RBSeccion.Size = New System.Drawing.Size(17, 16)
        Me.RBSeccion.TabIndex = 19
        Me.RBSeccion.TabStop = True
        Me.RBSeccion.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Grp. Diametro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Orden"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "P. Trabajo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Sección"
        '
        'CBGrupo
        '
        Me.CBGrupo.FormattingEnabled = True
        Me.CBGrupo.Location = New System.Drawing.Point(140, 208)
        Me.CBGrupo.Name = "CBGrupo"
        Me.CBGrupo.Size = New System.Drawing.Size(384, 28)
        Me.CBGrupo.TabIndex = 13
        '
        'CBProducto
        '
        Me.CBProducto.FormattingEnabled = True
        Me.CBProducto.Location = New System.Drawing.Point(140, 180)
        Me.CBProducto.Name = "CBProducto"
        Me.CBProducto.Size = New System.Drawing.Size(384, 28)
        Me.CBProducto.TabIndex = 12
        '
        'CBPuesto
        '
        Me.CBPuesto.FormattingEnabled = True
        Me.CBPuesto.Location = New System.Drawing.Point(140, 126)
        Me.CBPuesto.Name = "CBPuesto"
        Me.CBPuesto.Size = New System.Drawing.Size(384, 28)
        Me.CBPuesto.TabIndex = 10
        '
        'CBSeccion
        '
        Me.CBSeccion.FormattingEnabled = True
        Me.CBSeccion.Location = New System.Drawing.Point(140, 98)
        Me.CBSeccion.Name = "CBSeccion"
        Me.CBSeccion.Size = New System.Drawing.Size(384, 28)
        Me.CBSeccion.TabIndex = 9
        '
        'RBTurno
        '
        Me.RBTurno.AutoSize = True
        Me.RBTurno.Location = New System.Drawing.Point(551, 75)
        Me.RBTurno.Name = "RBTurno"
        Me.RBTurno.Size = New System.Drawing.Size(17, 16)
        Me.RBTurno.TabIndex = 8
        Me.RBTurno.TabStop = True
        Me.RBTurno.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Turno"
        '
        'CBTurno
        '
        Me.CBTurno.FormattingEnabled = True
        Me.CBTurno.Location = New System.Drawing.Point(140, 70)
        Me.CBTurno.Name = "CBTurno"
        Me.CBTurno.Size = New System.Drawing.Size(384, 28)
        Me.CBTurno.TabIndex = 6
        '
        'RBPeriod
        '
        Me.RBPeriod.AutoSize = True
        Me.RBPeriod.Checked = True
        Me.RBPeriod.Location = New System.Drawing.Point(551, 51)
        Me.RBPeriod.Name = "RBPeriod"
        Me.RBPeriod.Size = New System.Drawing.Size(17, 16)
        Me.RBPeriod.TabIndex = 5
        Me.RBPeriod.TabStop = True
        Me.RBPeriod.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Periodo"
        '
        'DTPF
        '
        Me.DTPF.CustomFormat = "yyyy-MM-dd"
        Me.DTPF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPF.Location = New System.Drawing.Point(398, 44)
        Me.DTPF.Name = "DTPF"
        Me.DTPF.Size = New System.Drawing.Size(126, 26)
        Me.DTPF.TabIndex = 3
        '
        'DTPI
        '
        Me.DTPI.CustomFormat = "yyyy-MM-dd"
        Me.DTPI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPI.Location = New System.Drawing.Point(140, 44)
        Me.DTPI.Name = "DTPI"
        Me.DTPI.Size = New System.Drawing.Size(126, 26)
        Me.DTPI.TabIndex = 2
        '
        'CBArea
        '
        Me.CBArea.FormattingEnabled = True
        Me.CBArea.Location = New System.Drawing.Point(140, 16)
        Me.CBArea.Name = "CBArea"
        Me.CBArea.Size = New System.Drawing.Size(384, 28)
        Me.CBArea.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Área"
        '
        'RdbConsolidado
        '
        Me.RdbConsolidado.AutoSize = True
        Me.RdbConsolidado.Checked = True
        Me.RdbConsolidado.Location = New System.Drawing.Point(618, 20)
        Me.RdbConsolidado.Name = "RdbConsolidado"
        Me.RdbConsolidado.Size = New System.Drawing.Size(133, 24)
        Me.RdbConsolidado.TabIndex = 6
        Me.RdbConsolidado.TabStop = True
        Me.RdbConsolidado.Text = "Consolidado"
        Me.RdbConsolidado.UseVisualStyleBackColor = True
        '
        'PDetail
        '
        Me.PDetail.Controls.Add(Me.GB_Pesajes)
        Me.PDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PDetail.Location = New System.Drawing.Point(0, 323)
        Me.PDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.PDetail.Name = "PDetail"
        Me.PDetail.Size = New System.Drawing.Size(1433, 304)
        Me.PDetail.TabIndex = 1
        '
        'GB_Pesajes
        '
        Me.GB_Pesajes.Controls.Add(Me.DGVQuery)
        Me.GB_Pesajes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Pesajes.Location = New System.Drawing.Point(0, 0)
        Me.GB_Pesajes.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.GB_Pesajes.Name = "GB_Pesajes"
        Me.GB_Pesajes.Padding = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.GB_Pesajes.Size = New System.Drawing.Size(1433, 304)
        Me.GB_Pesajes.TabIndex = 3
        Me.GB_Pesajes.TabStop = False
        Me.GB_Pesajes.Text = "Pesajes"
        '
        'DGVQuery
        '
        Me.DGVQuery.AllowUserToAddRows = False
        Me.DGVQuery.AllowUserToDeleteRows = False
        Me.DGVQuery.AllowUserToOrderColumns = True
        Me.DGVQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVQuery.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVQuery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVQuery.Location = New System.Drawing.Point(9, 25)
        Me.DGVQuery.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.DGVQuery.Name = "DGVQuery"
        Me.DGVQuery.ReadOnly = True
        Me.DGVQuery.Size = New System.Drawing.Size(1415, 273)
        Me.DGVQuery.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.BtnImprimir, Me.BtnExportExcel})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1433, 33)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.Atlas.Consultations.My.Resources.Resources.Exit_1
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(99, 29)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Image = Global.Atlas.Consultations.My.Resources.Resources.imprimir
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(122, 29)
        Me.BtnImprimir.Text = "Imprimir"
        '
        'BtnExportExcel
        '
        Me.BtnExportExcel.Image = Global.Atlas.Consultations.My.Resources.Resources.Btn_Excel
        Me.BtnExportExcel.Name = "BtnExportExcel"
        Me.BtnExportExcel.Size = New System.Drawing.Size(184, 29)
        Me.BtnExportExcel.Text = "Exportar a Excel"
        '
        'FrmReportesProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1433, 627)
        Me.Controls.Add(Me.PDetail)
        Me.Controls.Add(Me.PHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmReportesProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReportesProduccion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PHeader.ResumeLayout(False)
        Me.PHeader.PerformLayout()
        Me.GBQuery.ResumeLayout(False)
        Me.GBQuery.PerformLayout()
        Me.PDetail.ResumeLayout(False)
        Me.GB_Pesajes.ResumeLayout(False)
        CType(Me.DGVQuery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PHeader As System.Windows.Forms.Panel
    Friend WithEvents PDetail As System.Windows.Forms.Panel
    Friend WithEvents GB_Pesajes As System.Windows.Forms.GroupBox
    Friend WithEvents DGVQuery As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnExportExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GBQuery As System.Windows.Forms.GroupBox
    Friend WithEvents RBPuesto As System.Windows.Forms.RadioButton
    Friend WithEvents RBSeccion As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents CBProducto As System.Windows.Forms.ComboBox
    Friend WithEvents CBPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents CBSeccion As System.Windows.Forms.ComboBox
    Friend WithEvents RBTurno As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBTurno As System.Windows.Forms.ComboBox
    Friend WithEvents RBPeriod As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPF As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPI As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RBOrden As System.Windows.Forms.RadioButton
    Friend WithEvents RBGrp As System.Windows.Forms.RadioButton
    Friend WithEvents RBProducto As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Consulta As System.Windows.Forms.Button
    Friend WithEvents RdbDetalle As System.Windows.Forms.RadioButton
    Friend WithEvents RdbConsolidado As System.Windows.Forms.RadioButton
    Friend WithEvents BtnImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtOrdenProduccion As System.Windows.Forms.TextBox
End Class
