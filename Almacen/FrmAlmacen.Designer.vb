<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlmacen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DGV_Alm = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnRev = New System.Windows.Forms.Button
        Me.BtnCon = New System.Windows.Forms.Button
        Me.TOrdProd = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker
        Me.BtnTraspaso = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Alm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = CType(resources.GetObject("CerrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.AutoSize = False
        Me.ReportesToolStripMenuItem.Image = CType(resources.GetObject("ReportesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(100, 21)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGV_Alm)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(873, 689)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado"
        '
        'DGV_Alm
        '
        Me.DGV_Alm.AllowUserToAddRows = False
        Me.DGV_Alm.AllowUserToDeleteRows = False
        Me.DGV_Alm.AllowUserToOrderColumns = True
        Me.DGV_Alm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_Alm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Alm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Alm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Alm.Location = New System.Drawing.Point(3, 18)
        Me.DGV_Alm.Name = "DGV_Alm"
        Me.DGV_Alm.ReadOnly = True
        Me.DGV_Alm.Size = New System.Drawing.Size(867, 668)
        Me.DGV_Alm.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnTraspaso)
        Me.GroupBox2.Controls.Add(Me.BtnRev)
        Me.GroupBox2.Controls.Add(Me.BtnCon)
        Me.GroupBox2.Controls.Add(Me.TOrdProd)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DTP_FF)
        Me.GroupBox2.Controls.Add(Me.DTP_FI)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(879, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 689)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consulta"
        '
        'BtnRev
        '
        Me.BtnRev.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRev.Image = CType(resources.GetObject("BtnRev.Image"), System.Drawing.Image)
        Me.BtnRev.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRev.Location = New System.Drawing.Point(25, 232)
        Me.BtnRev.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRev.Name = "BtnRev"
        Me.BtnRev.Size = New System.Drawing.Size(257, 43)
        Me.BtnRev.TabIndex = 74
        Me.BtnRev.Text = "Reversar Recibo"
        Me.BtnRev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRev.UseVisualStyleBackColor = True
        '
        'BtnCon
        '
        Me.BtnCon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCon.Image = CType(resources.GetObject("BtnCon.Image"), System.Drawing.Image)
        Me.BtnCon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCon.Location = New System.Drawing.Point(23, 130)
        Me.BtnCon.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCon.Name = "BtnCon"
        Me.BtnCon.Size = New System.Drawing.Size(257, 43)
        Me.BtnCon.TabIndex = 73
        Me.BtnCon.Text = "Consulta Boletas"
        Me.BtnCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCon.UseVisualStyleBackColor = True
        '
        'TOrdProd
        '
        Me.TOrdProd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TOrdProd.Location = New System.Drawing.Point(170, 81)
        Me.TOrdProd.Name = "TOrdProd"
        Me.TOrdProd.Size = New System.Drawing.Size(110, 22)
        Me.TOrdProd.TabIndex = 72
        Me.TOrdProd.Text = "*"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Orden Fabricación:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 16)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Fecha Fin Orden:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Fecha Inicio Orden:"
        '
        'DTP_FF
        '
        Me.DTP_FF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(170, 52)
        Me.DTP_FF.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(110, 22)
        Me.DTP_FF.TabIndex = 68
        '
        'DTP_FI
        '
        Me.DTP_FI.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(170, 22)
        Me.DTP_FI.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(110, 22)
        Me.DTP_FI.TabIndex = 67
        '
        'BtnTraspaso
        '
        Me.BtnTraspaso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnTraspaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTraspaso.Image = CType(resources.GetObject("BtnTraspaso.Image"), System.Drawing.Image)
        Me.BtnTraspaso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTraspaso.Location = New System.Drawing.Point(25, 181)
        Me.BtnTraspaso.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTraspaso.Name = "BtnTraspaso"
        Me.BtnTraspaso.Size = New System.Drawing.Size(257, 43)
        Me.BtnTraspaso.TabIndex = 75
        Me.BtnTraspaso.Text = "Boletas Traspasadas"
        Me.BtnTraspaso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTraspaso.UseVisualStyleBackColor = True
        '
        'FrmAlmacen_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 714)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAlmacen_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Almacen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_Alm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TOrdProd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnCon As System.Windows.Forms.Button
    Friend WithEvents DGV_Alm As System.Windows.Forms.DataGridView
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnRev As System.Windows.Forms.Button
    Friend WithEvents BtnTraspaso As System.Windows.Forms.Button
End Class
