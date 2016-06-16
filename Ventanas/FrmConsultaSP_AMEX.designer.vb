<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaSP_AMEX
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaSP_AMEX))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DGV_BP = New System.Windows.Forms.DataGridView
        Me.GB_Consulta = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TOrdProd = New System.Windows.Forms.TextBox
        Me.BConsulta = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BExpExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Consulta.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_BP)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1016, 443)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesajes"
        '
        'DGV_BP
        '
        Me.DGV_BP.AllowUserToAddRows = False
        Me.DGV_BP.AllowUserToDeleteRows = False
        Me.DGV_BP.AllowUserToOrderColumns = True
        Me.DGV_BP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_BP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_BP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_BP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_BP.Location = New System.Drawing.Point(4, 19)
        Me.DGV_BP.Name = "DGV_BP"
        Me.DGV_BP.ReadOnly = True
        Me.DGV_BP.Size = New System.Drawing.Size(1008, 420)
        Me.DGV_BP.TabIndex = 0
        '
        'GB_Consulta
        '
        Me.GB_Consulta.Controls.Add(Me.Label3)
        Me.GB_Consulta.Controls.Add(Me.TOrdProd)
        Me.GB_Consulta.Controls.Add(Me.BConsulta)
        Me.GB_Consulta.Controls.Add(Me.Label2)
        Me.GB_Consulta.Controls.Add(Me.DTP_FF)
        Me.GB_Consulta.Controls.Add(Me.Label1)
        Me.GB_Consulta.Controls.Add(Me.DTP_FI)
        Me.GB_Consulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GB_Consulta.Location = New System.Drawing.Point(0, 474)
        Me.GB_Consulta.Name = "GB_Consulta"
        Me.GB_Consulta.Size = New System.Drawing.Size(1016, 159)
        Me.GB_Consulta.TabIndex = 10
        Me.GB_Consulta.TabStop = False
        Me.GB_Consulta.Text = "Consulta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(735, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Orden de Producción"
        '
        'TOrdProd
        '
        Me.TOrdProd.Location = New System.Drawing.Point(895, 21)
        Me.TOrdProd.Name = "TOrdProd"
        Me.TOrdProd.Size = New System.Drawing.Size(109, 22)
        Me.TOrdProd.TabIndex = 15
        Me.TOrdProd.Text = "*"
        Me.TOrdProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BConsulta
        '
        Me.BConsulta.Image = CType(resources.GetObject("BConsulta.Image"), System.Drawing.Image)
        Me.BConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BConsulta.Location = New System.Drawing.Point(815, 120)
        Me.BConsulta.Name = "BConsulta"
        Me.BConsulta.Size = New System.Drawing.Size(189, 30)
        Me.BConsulta.TabIndex = 13
        Me.BConsulta.Text = "Consulta"
        Me.BConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BConsulta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(760, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(895, 77)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FF.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(744, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(895, 49)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FI.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BExpExcel})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1016, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BExpExcel
        '
        Me.BExpExcel.Image = CType(resources.GetObject("BExpExcel.Image"), System.Drawing.Image)
        Me.BExpExcel.Name = "BExpExcel"
        Me.BExpExcel.Size = New System.Drawing.Size(107, 20)
        Me.BExpExcel.Text = "Exportar Excel"
        '
        'FrmConsultaSP_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 633)
        Me.Controls.Add(Me.GB_Consulta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultaSP_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Sobrepeso"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_BP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Consulta.ResumeLayout(False)
        Me.GB_Consulta.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_BP As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TOrdProd As System.Windows.Forms.TextBox
    Friend WithEvents BConsulta As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BExpExcel As System.Windows.Forms.ToolStripMenuItem
End Class
