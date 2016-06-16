<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupervision_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupervision_AMEX))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RolSupervisoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GB_Consulta = New System.Windows.Forms.GroupBox
        Me.Btn_Consulta = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.CB_Sup = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TC1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GB_Resumen = New System.Windows.Forms.GroupBox
        Me.DGV_Resumen = New System.Windows.Forms.DataGridView
        Me.GB_Detalle = New System.Windows.Forms.GroupBox
        Me.DGV_Sup = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.GB_Grafico = New System.Windows.Forms.GroupBox
        Me.CB_Tipo = New System.Windows.Forms.ComboBox
        Me.RB1 = New System.Windows.Forms.RadioButton
        Me.RB2 = New System.Windows.Forms.RadioButton
        Me.MenuStrip1.SuspendLayout()
        Me.GB_Consulta.SuspendLayout()
        Me.TC1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GB_Resumen.SuspendLayout()
        CType(Me.DGV_Resumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Detalle.SuspendLayout()
        CType(Me.DGV_Sup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Grafico.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.RolSupervisoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1234, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.AutoSize = False
        Me.CerrarToolStripMenuItem.Image = CType(resources.GetObject("CerrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(100, 21)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'RolSupervisoresToolStripMenuItem
        '
        Me.RolSupervisoresToolStripMenuItem.Image = CType(resources.GetObject("RolSupervisoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RolSupervisoresToolStripMenuItem.Name = "RolSupervisoresToolStripMenuItem"
        Me.RolSupervisoresToolStripMenuItem.Size = New System.Drawing.Size(138, 21)
        Me.RolSupervisoresToolStripMenuItem.Text = "Rol Supervisores"
        '
        'GB_Consulta
        '
        Me.GB_Consulta.Controls.Add(Me.RB2)
        Me.GB_Consulta.Controls.Add(Me.RB1)
        Me.GB_Consulta.Controls.Add(Me.Btn_Consulta)
        Me.GB_Consulta.Controls.Add(Me.Label3)
        Me.GB_Consulta.Controls.Add(Me.DTP_FF)
        Me.GB_Consulta.Controls.Add(Me.DTP_FI)
        Me.GB_Consulta.Controls.Add(Me.Label2)
        Me.GB_Consulta.Controls.Add(Me.CB_Sup)
        Me.GB_Consulta.Controls.Add(Me.Label1)
        Me.GB_Consulta.Location = New System.Drawing.Point(0, 25)
        Me.GB_Consulta.Name = "GB_Consulta"
        Me.GB_Consulta.Size = New System.Drawing.Size(699, 136)
        Me.GB_Consulta.TabIndex = 1
        Me.GB_Consulta.TabStop = False
        Me.GB_Consulta.Text = "Consulta"
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = CType(resources.GetObject("Btn_Consulta.Image"), System.Drawing.Image)
        Me.Btn_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Consulta.Location = New System.Drawing.Point(528, 21)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(158, 57)
        Me.Btn_Consulta.TabIndex = 6
        Me.Btn_Consulta.Text = "Genera Consulta"
        Me.Btn_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Consulta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(378, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Al"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(406, 48)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(116, 22)
        Me.DTP_FF.TabIndex = 4
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(127, 51)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(116, 22)
        Me.DTP_FI.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Periodo del"
        '
        'CB_Sup
        '
        Me.CB_Sup.FormattingEnabled = True
        Me.CB_Sup.Location = New System.Drawing.Point(127, 21)
        Me.CB_Sup.Name = "CB_Sup"
        Me.CB_Sup.Size = New System.Drawing.Size(395, 24)
        Me.CB_Sup.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supervisor"
        '
        'TC1
        '
        Me.TC1.Controls.Add(Me.TabPage1)
        Me.TC1.Controls.Add(Me.TabPage3)
        Me.TC1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TC1.Location = New System.Drawing.Point(0, 167)
        Me.TC1.Name = "TC1"
        Me.TC1.SelectedIndex = 0
        Me.TC1.Size = New System.Drawing.Size(1234, 545)
        Me.TC1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GB_Resumen)
        Me.TabPage1.Controls.Add(Me.GB_Detalle)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1226, 516)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resultado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GB_Resumen
        '
        Me.GB_Resumen.Controls.Add(Me.DGV_Resumen)
        Me.GB_Resumen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GB_Resumen.Location = New System.Drawing.Point(3, 309)
        Me.GB_Resumen.Name = "GB_Resumen"
        Me.GB_Resumen.Size = New System.Drawing.Size(1220, 204)
        Me.GB_Resumen.TabIndex = 1
        Me.GB_Resumen.TabStop = False
        Me.GB_Resumen.Text = "Resumen"
        '
        'DGV_Resumen
        '
        Me.DGV_Resumen.AllowUserToAddRows = False
        Me.DGV_Resumen.AllowUserToDeleteRows = False
        Me.DGV_Resumen.AllowUserToOrderColumns = True
        Me.DGV_Resumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_Resumen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Resumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Resumen.Location = New System.Drawing.Point(3, 18)
        Me.DGV_Resumen.Name = "DGV_Resumen"
        Me.DGV_Resumen.ReadOnly = True
        Me.DGV_Resumen.Size = New System.Drawing.Size(1214, 183)
        Me.DGV_Resumen.TabIndex = 3
        '
        'GB_Detalle
        '
        Me.GB_Detalle.Controls.Add(Me.DGV_Sup)
        Me.GB_Detalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.GB_Detalle.Location = New System.Drawing.Point(3, 3)
        Me.GB_Detalle.Name = "GB_Detalle"
        Me.GB_Detalle.Size = New System.Drawing.Size(1220, 281)
        Me.GB_Detalle.TabIndex = 0
        Me.GB_Detalle.TabStop = False
        Me.GB_Detalle.Text = "Detalle"
        '
        'DGV_Sup
        '
        Me.DGV_Sup.AllowUserToAddRows = False
        Me.DGV_Sup.AllowUserToDeleteRows = False
        Me.DGV_Sup.AllowUserToOrderColumns = True
        Me.DGV_Sup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_Sup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Sup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Sup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Sup.Location = New System.Drawing.Point(3, 18)
        Me.DGV_Sup.Name = "DGV_Sup"
        Me.DGV_Sup.ReadOnly = True
        Me.DGV_Sup.Size = New System.Drawing.Size(1214, 260)
        Me.DGV_Sup.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TabControl1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1226, 555)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Graficas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1220, 549)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1191, 541)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Produccion"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1185, 535)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Chart2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1191, 541)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Recuperado"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(3, 3)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(1185, 535)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "Chart2"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Chart4)
        Me.TabPage6.Location = New System.Drawing.Point(4, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1191, 541)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Sobre Peso"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Chart4
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea3)
        Me.Chart4.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend3)
        Me.Chart4.Location = New System.Drawing.Point(3, 3)
        Me.Chart4.Name = "Chart4"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart4.Series.Add(Series3)
        Me.Chart4.Size = New System.Drawing.Size(1185, 535)
        Me.Chart4.TabIndex = 1
        Me.Chart4.Text = "Chart4"
        '
        'GB_Grafico
        '
        Me.GB_Grafico.Controls.Add(Me.CB_Tipo)
        Me.GB_Grafico.Location = New System.Drawing.Point(705, 25)
        Me.GB_Grafico.Name = "GB_Grafico"
        Me.GB_Grafico.Size = New System.Drawing.Size(525, 136)
        Me.GB_Grafico.TabIndex = 3
        Me.GB_Grafico.TabStop = False
        Me.GB_Grafico.Text = "Tipo Grafica"
        '
        'CB_Tipo
        '
        Me.CB_Tipo.FormattingEnabled = True
        Me.CB_Tipo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.CB_Tipo.Location = New System.Drawing.Point(52, 41)
        Me.CB_Tipo.Name = "CB_Tipo"
        Me.CB_Tipo.Size = New System.Drawing.Size(420, 24)
        Me.CB_Tipo.TabIndex = 0
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Location = New System.Drawing.Point(127, 79)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(195, 20)
        Me.RB1.TabIndex = 7
        Me.RB1.TabStop = True
        Me.RB1.Text = "Resumen por supervisor"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Location = New System.Drawing.Point(127, 105)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(244, 20)
        Me.RB2.TabIndex = 8
        Me.RB2.TabStop = True
        Me.RB2.Text = "Resumen por puesto de trabajo"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'FrmSupervision_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1234, 712)
        Me.Controls.Add(Me.GB_Grafico)
        Me.Controls.Add(Me.TC1)
        Me.Controls.Add(Me.GB_Consulta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSupervision_AMEX"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSupervision_AMEX"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GB_Consulta.ResumeLayout(False)
        Me.GB_Consulta.PerformLayout()
        Me.TC1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GB_Resumen.ResumeLayout(False)
        CType(Me.DGV_Resumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Detalle.ResumeLayout(False)
        CType(Me.DGV_Sup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Grafico.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RolSupervisoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GB_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents CB_Sup As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_Consulta As System.Windows.Forms.Button
    Friend WithEvents TC1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GB_Resumen As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Sup As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Resumen As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart4 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GB_Grafico As System.Windows.Forms.GroupBox
    Friend WithEvents CB_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
End Class
