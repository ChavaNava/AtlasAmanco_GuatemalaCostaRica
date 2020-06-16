<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaProduccion
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
        Me.BtnImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExportExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.PHeader = New System.Windows.Forms.Panel()
        Me.scProduccion = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DGVQuery = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.pConsultation = New System.Windows.Forms.Panel()
        Me.pAmounts = New System.Windows.Forms.Panel()
        Me.pEfficiency = New System.Windows.Forms.Panel()
        Me.pTotalsProduction = New System.Windows.Forms.Panel()
        Me.pTotalsHours = New System.Windows.Forms.Panel()
        Me.gbConsulta = New System.Windows.Forms.GroupBox()
        Me.DTPI = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrdenEquipo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.DTPF = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.PHeader.SuspendLayout()
        CType(Me.scProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.scProduccion.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DGVQuery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pConsultation.SuspendLayout()
        Me.gbConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.BtnImprimir, Me.BtnExportExcel})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1575, 33)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.Atlas.Consultations.My.Resources.Resources.Exit_1
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(87, 29)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Image = Global.Atlas.Consultations.My.Resources.Resources.imprimir
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(98, 29)
        Me.BtnImprimir.Text = "Imprimir"
        '
        'BtnExportExcel
        '
        Me.BtnExportExcel.Image = Global.Atlas.Consultations.My.Resources.Resources.Btn_Excel
        Me.BtnExportExcel.Name = "BtnExportExcel"
        Me.BtnExportExcel.Size = New System.Drawing.Size(149, 29)
        Me.BtnExportExcel.Text = "Exportar a Excel"
        '
        'PHeader
        '
        Me.PHeader.Controls.Add(Me.pTotalsHours)
        Me.PHeader.Controls.Add(Me.pTotalsProduction)
        Me.PHeader.Controls.Add(Me.pEfficiency)
        Me.PHeader.Controls.Add(Me.pAmounts)
        Me.PHeader.Controls.Add(Me.pConsultation)
        Me.PHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PHeader.Location = New System.Drawing.Point(0, 33)
        Me.PHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PHeader.Name = "PHeader"
        Me.PHeader.Size = New System.Drawing.Size(1575, 286)
        Me.PHeader.TabIndex = 4
        '
        'scProduccion
        '
        Me.scProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scProduccion.Location = New System.Drawing.Point(0, 319)
        Me.scProduccion.Name = "scProduccion"
        Me.scProduccion.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scProduccion.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGVQuery)
        '
        'scProduccion.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer1)
        Me.scProduccion.Size = New System.Drawing.Size(1575, 426)
        Me.scProduccion.SplitterDistance = 168
        Me.scProduccion.TabIndex = 5
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1575, 254)
        Me.SplitContainer1.SplitterDistance = 136
        Me.SplitContainer1.TabIndex = 0
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
        Me.DGVQuery.Location = New System.Drawing.Point(0, 0)
        Me.DGVQuery.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.DGVQuery.Name = "DGVQuery"
        Me.DGVQuery.ReadOnly = True
        Me.DGVQuery.Size = New System.Drawing.Size(1575, 168)
        Me.DGVQuery.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1575, 136)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(1575, 114)
        Me.DataGridView2.TabIndex = 1
        '
        'pConsultation
        '
        Me.pConsultation.Controls.Add(Me.gbConsulta)
        Me.pConsultation.Dock = System.Windows.Forms.DockStyle.Left
        Me.pConsultation.Location = New System.Drawing.Point(0, 0)
        Me.pConsultation.Name = "pConsultation"
        Me.pConsultation.Size = New System.Drawing.Size(384, 286)
        Me.pConsultation.TabIndex = 0
        '
        'pAmounts
        '
        Me.pAmounts.Dock = System.Windows.Forms.DockStyle.Left
        Me.pAmounts.Location = New System.Drawing.Point(384, 0)
        Me.pAmounts.Name = "pAmounts"
        Me.pAmounts.Size = New System.Drawing.Size(214, 286)
        Me.pAmounts.TabIndex = 1
        '
        'pEfficiency
        '
        Me.pEfficiency.Dock = System.Windows.Forms.DockStyle.Left
        Me.pEfficiency.Location = New System.Drawing.Point(598, 0)
        Me.pEfficiency.Name = "pEfficiency"
        Me.pEfficiency.Size = New System.Drawing.Size(234, 286)
        Me.pEfficiency.TabIndex = 2
        '
        'pTotalsProduction
        '
        Me.pTotalsProduction.Dock = System.Windows.Forms.DockStyle.Left
        Me.pTotalsProduction.Location = New System.Drawing.Point(832, 0)
        Me.pTotalsProduction.Name = "pTotalsProduction"
        Me.pTotalsProduction.Size = New System.Drawing.Size(398, 286)
        Me.pTotalsProduction.TabIndex = 3
        '
        'pTotalsHours
        '
        Me.pTotalsHours.Dock = System.Windows.Forms.DockStyle.Left
        Me.pTotalsHours.Location = New System.Drawing.Point(1230, 0)
        Me.pTotalsHours.Name = "pTotalsHours"
        Me.pTotalsHours.Size = New System.Drawing.Size(333, 286)
        Me.pTotalsHours.TabIndex = 4
        '
        'gbConsulta
        '
        Me.gbConsulta.Controls.Add(Me.Label4)
        Me.gbConsulta.Controls.Add(Me.cmbTurno)
        Me.gbConsulta.Controls.Add(Me.Label3)
        Me.gbConsulta.Controls.Add(Me.DTPF)
        Me.gbConsulta.Controls.Add(Me.DTPI)
        Me.gbConsulta.Controls.Add(Me.Label2)
        Me.gbConsulta.Controls.Add(Me.txtOrdenEquipo)
        Me.gbConsulta.Controls.Add(Me.Label1)
        Me.gbConsulta.Controls.Add(Me.rb3)
        Me.gbConsulta.Controls.Add(Me.rb2)
        Me.gbConsulta.Controls.Add(Me.rb1)
        Me.gbConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbConsulta.Location = New System.Drawing.Point(0, 0)
        Me.gbConsulta.Name = "gbConsulta"
        Me.gbConsulta.Size = New System.Drawing.Size(384, 286)
        Me.gbConsulta.TabIndex = 0
        Me.gbConsulta.TabStop = False
        Me.gbConsulta.Text = "Consultas"
        '
        'DTPI
        '
        Me.DTPI.CustomFormat = "dd-MMM-yyyy"
        Me.DTPI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPI.Location = New System.Drawing.Point(138, 171)
        Me.DTPI.Name = "DTPI"
        Me.DTPI.Size = New System.Drawing.Size(130, 22)
        Me.DTPI.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Inicio"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOrdenEquipo
        '
        Me.txtOrdenEquipo.Location = New System.Drawing.Point(138, 113)
        Me.txtOrdenEquipo.Name = "txtOrdenEquipo"
        Me.txtOrdenEquipo.Size = New System.Drawing.Size(112, 22)
        Me.txtOrdenEquipo.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Orden / Equipo"
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Location = New System.Drawing.Point(12, 73)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(143, 20)
        Me.rb3.TabIndex = 9
        Me.rb3.Text = "Equipo / Período"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(12, 47)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(218, 20)
        Me.rb2.TabIndex = 8
        Me.rb2.Text = "Orden Producción / Período"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Checked = True
        Me.rb1.Location = New System.Drawing.Point(12, 21)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(150, 20)
        Me.rb1.TabIndex = 7
        Me.rb1.TabStop = True
        Me.rb1.Text = "Orden Producción"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'DTPF
        '
        Me.DTPF.CustomFormat = "dd-MMM-yyyy"
        Me.DTPF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPF.Location = New System.Drawing.Point(138, 199)
        Me.DTPF.Name = "DTPF"
        Me.DTPF.Size = New System.Drawing.Size(130, 22)
        Me.DTPF.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Turno"
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Location = New System.Drawing.Point(138, 141)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(96, 24)
        Me.cmbTurno.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Fin"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConsultaProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1575, 745)
        Me.Controls.Add(Me.scProduccion)
        Me.Controls.Add(Me.PHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmConsultaProduccion"
        Me.Text = "FrmConsultaProduccion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PHeader.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.scProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scProduccion.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DGVQuery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pConsultation.ResumeLayout(False)
        Me.gbConsulta.ResumeLayout(False)
        Me.gbConsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnExportExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PHeader As System.Windows.Forms.Panel
    Friend WithEvents scProduccion As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DGVQuery As System.Windows.Forms.DataGridView
    Friend WithEvents pTotalsHours As System.Windows.Forms.Panel
    Friend WithEvents pTotalsProduction As System.Windows.Forms.Panel
    Friend WithEvents pEfficiency As System.Windows.Forms.Panel
    Friend WithEvents pAmounts As System.Windows.Forms.Panel
    Friend WithEvents pConsultation As System.Windows.Forms.Panel
    Friend WithEvents gbConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTPF As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOrdenEquipo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
