<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaScrapInyeccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaScrapInyeccion))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Btn_Cerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Export = New System.Windows.Forms.ToolStripMenuItem()
        Me.GB_Consulta = New System.Windows.Forms.GroupBox()
        Me.BtnConsultas = New System.Windows.Forms.Button()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GB_Scrap = New System.Windows.Forms.GroupBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.GB_Resumen = New System.Windows.Forms.GroupBox()
        Me.DGV_Resumen = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.GB_Consulta.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GB_Scrap.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Resumen.SuspendLayout()
        CType(Me.DGV_Resumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Cerrar, Me.Btn_Export})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Image = CType(resources.GetObject("Btn_Cerrar.Image"), System.Drawing.Image)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(82, 24)
        Me.Btn_Cerrar.Text = "Cerrar"
        '
        'Btn_Export
        '
        Me.Btn_Export.Image = CType(resources.GetObject("Btn_Export.Image"), System.Drawing.Image)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(138, 24)
        Me.Btn_Export.Text = "Exporta a Excel"
        '
        'GB_Consulta
        '
        Me.GB_Consulta.Controls.Add(Me.BtnConsultas)
        Me.GB_Consulta.Controls.Add(Me.RB2)
        Me.GB_Consulta.Controls.Add(Me.RB1)
        Me.GB_Consulta.Controls.Add(Me.DTP_FF)
        Me.GB_Consulta.Controls.Add(Me.Label1)
        Me.GB_Consulta.Controls.Add(Me.DTP_FI)
        Me.GB_Consulta.Location = New System.Drawing.Point(0, 32)
        Me.GB_Consulta.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_Consulta.Name = "GB_Consulta"
        Me.GB_Consulta.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_Consulta.Size = New System.Drawing.Size(378, 171)
        Me.GB_Consulta.TabIndex = 6
        Me.GB_Consulta.TabStop = False
        Me.GB_Consulta.Text = "Consulta"
        '
        'BtnConsultas
        '
        Me.BtnConsultas.BackColor = System.Drawing.Color.White
        Me.BtnConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultas.Image = Global.Atlas.My.Resources.Resources.Btn_Consulta
        Me.BtnConsultas.Location = New System.Drawing.Point(103, 123)
        Me.BtnConsultas.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnConsultas.Name = "BtnConsultas"
        Me.BtnConsultas.Size = New System.Drawing.Size(249, 40)
        Me.BtnConsultas.TabIndex = 351
        Me.BtnConsultas.Text = "Generar Consulta"
        Me.BtnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnConsultas.UseVisualStyleBackColor = False
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Location = New System.Drawing.Point(243, 68)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(76, 20)
        Me.RB2.TabIndex = 25
        Me.RB2.Text = "Detalle"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Checked = True
        Me.RB1.Location = New System.Drawing.Point(103, 68)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(91, 20)
        Me.RB1.TabIndex = 24
        Me.RB1.TabStop = True
        Me.RB1.Text = "Resumen"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(243, 30)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FF.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Periodo"
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(103, 30)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FI.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GB_Scrap)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 483)
        Me.Panel1.TabIndex = 8
        '
        'GB_Scrap
        '
        Me.GB_Scrap.Controls.Add(Me.DGV1)
        Me.GB_Scrap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Scrap.Location = New System.Drawing.Point(0, 0)
        Me.GB_Scrap.Name = "GB_Scrap"
        Me.GB_Scrap.Size = New System.Drawing.Size(1370, 483)
        Me.GB_Scrap.TabIndex = 2
        Me.GB_Scrap.TabStop = False
        Me.GB_Scrap.Text = "Scrap"
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
        Me.DGV1.Location = New System.Drawing.Point(3, 18)
        Me.DGV1.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.Size = New System.Drawing.Size(1364, 462)
        Me.DGV1.TabIndex = 2
        '
        'GB_Resumen
        '
        Me.GB_Resumen.Controls.Add(Me.DGV_Resumen)
        Me.GB_Resumen.Location = New System.Drawing.Point(385, 32)
        Me.GB_Resumen.Name = "GB_Resumen"
        Me.GB_Resumen.Size = New System.Drawing.Size(503, 172)
        Me.GB_Resumen.TabIndex = 9
        Me.GB_Resumen.TabStop = False
        Me.GB_Resumen.Text = "Resumen Tipo Scrap"
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
        Me.DGV_Resumen.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV_Resumen.Name = "DGV_Resumen"
        Me.DGV_Resumen.ReadOnly = True
        Me.DGV_Resumen.Size = New System.Drawing.Size(497, 151)
        Me.DGV_Resumen.TabIndex = 3
        '
        'FrmConsultaScrapInyeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 693)
        Me.Controls.Add(Me.GB_Resumen)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GB_Consulta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmConsultaScrapInyeccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConsultaScrapInyeccion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GB_Consulta.ResumeLayout(False)
        Me.GB_Consulta.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GB_Scrap.ResumeLayout(False)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Resumen.ResumeLayout(False)
        CType(Me.DGV_Resumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Export As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GB_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents GB_Scrap As System.Windows.Forms.GroupBox
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Resumen As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Resumen As System.Windows.Forms.DataGridView
    Friend WithEvents BtnConsultas As System.Windows.Forms.Button
End Class
