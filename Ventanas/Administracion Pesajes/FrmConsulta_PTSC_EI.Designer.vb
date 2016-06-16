<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsulta_PTSC_EI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsulta_PTSC_EI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GB_Pesajes = New System.Windows.Forms.GroupBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.GB_Hist = New System.Windows.Forms.GroupBox()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BConsulta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GB_Pesajes.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Hist.SuspendLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1192, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.Atlas.My.Resources.Resources.Exit_1
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Left
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GB_Pesajes)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GB_Hist)
        Me.SplitContainer2.Size = New System.Drawing.Size(914, 645)
        Me.SplitContainer2.SplitterDistance = 524
        Me.SplitContainer2.TabIndex = 2
        '
        'GB_Pesajes
        '
        Me.GB_Pesajes.Controls.Add(Me.DGV1)
        Me.GB_Pesajes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Pesajes.Location = New System.Drawing.Point(0, 0)
        Me.GB_Pesajes.Name = "GB_Pesajes"
        Me.GB_Pesajes.Size = New System.Drawing.Size(914, 524)
        Me.GB_Pesajes.TabIndex = 2
        Me.GB_Pesajes.TabStop = False
        Me.GB_Pesajes.Text = "Pesajes"
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
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.Size = New System.Drawing.Size(908, 503)
        Me.DGV1.TabIndex = 0
        '
        'GB_Hist
        '
        Me.GB_Hist.Controls.Add(Me.DGV2)
        Me.GB_Hist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Hist.Location = New System.Drawing.Point(0, 0)
        Me.GB_Hist.Name = "GB_Hist"
        Me.GB_Hist.Size = New System.Drawing.Size(914, 117)
        Me.GB_Hist.TabIndex = 21
        Me.GB_Hist.TabStop = False
        Me.GB_Hist.Text = "Historial Pesaje"
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AllowUserToDeleteRows = False
        Me.DGV2.AllowUserToOrderColumns = True
        Me.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV2.Location = New System.Drawing.Point(3, 18)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.Size = New System.Drawing.Size(908, 96)
        Me.DGV2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(933, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Orden Producción"
        '
        'TOrden
        '
        Me.TOrden.Location = New System.Drawing.Point(1071, 102)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.Size = New System.Drawing.Size(109, 22)
        Me.TOrden.TabIndex = 28
        '
        'BtnDel
        '
        Me.BtnDel.Image = CType(resources.GetObject("BtnDel.Image"), System.Drawing.Image)
        Me.BtnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDel.Location = New System.Drawing.Point(958, 187)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(189, 30)
        Me.BtnDel.TabIndex = 27
        Me.BtnDel.Text = "Baja Registro"
        Me.BtnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BConsulta
        '
        Me.BConsulta.Image = CType(resources.GetObject("BConsulta.Image"), System.Drawing.Image)
        Me.BConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BConsulta.Location = New System.Drawing.Point(958, 151)
        Me.BConsulta.Name = "BConsulta"
        Me.BConsulta.Size = New System.Drawing.Size(189, 30)
        Me.BConsulta.TabIndex = 26
        Me.BConsulta.Text = "Consulta"
        Me.BConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BConsulta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(936, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(1071, 74)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FF.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(920, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(1071, 46)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FI.TabIndex = 22
        '
        'FrmConsulta_PTSC_EI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 673)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TOrden)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BConsulta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTP_FF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_FI)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmConsulta_PTSC_EI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConsulta_PTSC_Ext"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GB_Pesajes.ResumeLayout(False)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Hist.ResumeLayout(False)
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GB_Pesajes As System.Windows.Forms.GroupBox
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Hist As System.Windows.Forms.GroupBox
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents BConsulta As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
End Class
