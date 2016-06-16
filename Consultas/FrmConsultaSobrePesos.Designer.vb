<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaSobrePesos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaSobrePesos))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Btn_Cerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Export = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GB_Consulta = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TOrdProd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.GB_Pesajes = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GB_Consulta.SuspendLayout()
        Me.GB_Pesajes.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Cerrar, Me.Btn_Consulta, Me.Btn_Export})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1001, 28)
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
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = CType(resources.GetObject("Btn_Consulta.Image"), System.Drawing.Image)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(96, 24)
        Me.Btn_Consulta.Text = "Consulta"
        '
        'Btn_Export
        '
        Me.Btn_Export.Image = CType(resources.GetObject("Btn_Export.Image"), System.Drawing.Image)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(138, 24)
        Me.Btn_Export.Text = "Exporta a Excel"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GB_Consulta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1001, 111)
        Me.Panel1.TabIndex = 7
        '
        'GB_Consulta
        '
        Me.GB_Consulta.Controls.Add(Me.Label3)
        Me.GB_Consulta.Controls.Add(Me.TOrdProd)
        Me.GB_Consulta.Controls.Add(Me.Label2)
        Me.GB_Consulta.Controls.Add(Me.DTP_FF)
        Me.GB_Consulta.Controls.Add(Me.Label1)
        Me.GB_Consulta.Controls.Add(Me.DTP_FI)
        Me.GB_Consulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Consulta.Location = New System.Drawing.Point(0, 0)
        Me.GB_Consulta.Name = "GB_Consulta"
        Me.GB_Consulta.Size = New System.Drawing.Size(1001, 111)
        Me.GB_Consulta.TabIndex = 11
        Me.GB_Consulta.TabStop = False
        Me.GB_Consulta.Text = "Consulta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Orden de Producción"
        '
        'TOrdProd
        '
        Me.TOrdProd.Location = New System.Drawing.Point(213, 21)
        Me.TOrdProd.Name = "TOrdProd"
        Me.TOrdProd.Size = New System.Drawing.Size(109, 22)
        Me.TOrdProd.TabIndex = 21
        Me.TOrdProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(213, 77)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FF.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(213, 49)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FI.TabIndex = 17
        '
        'GB_Pesajes
        '
        Me.GB_Pesajes.Controls.Add(Me.DGV)
        Me.GB_Pesajes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Pesajes.Location = New System.Drawing.Point(0, 139)
        Me.GB_Pesajes.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GB_Pesajes.Name = "GB_Pesajes"
        Me.GB_Pesajes.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GB_Pesajes.Size = New System.Drawing.Size(1001, 444)
        Me.GB_Pesajes.TabIndex = 8
        Me.GB_Pesajes.TabStop = False
        Me.GB_Pesajes.Text = "Pesajes"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToOrderColumns = True
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(6, 20)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(989, 419)
        Me.DGV.TabIndex = 0
        '
        'FrmConsultaSobrePesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 583)
        Me.Controls.Add(Me.GB_Pesajes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmConsultaSobrePesos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConsultaSobrePesos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GB_Consulta.ResumeLayout(False)
        Me.GB_Consulta.PerformLayout()
        Me.GB_Pesajes.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Export As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GB_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TOrdProd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents GB_Pesajes As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
End Class
