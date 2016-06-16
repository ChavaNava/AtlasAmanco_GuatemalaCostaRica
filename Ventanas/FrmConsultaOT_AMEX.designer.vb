<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaOT_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaOT_AMEX))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DGV_BP = New System.Windows.Forms.DataGridView
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker
        Me.BConsulta = New System.Windows.Forms.Button
        Me.BImp = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_BP)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1016, 418)
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
        Me.DGV_BP.Size = New System.Drawing.Size(1008, 395)
        Me.DGV_BP.TabIndex = 0
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(878, 425)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FI.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(727, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(743, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(878, 453)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FF.TabIndex = 3
        '
        'BConsulta
        '
        Me.BConsulta.Image = CType(resources.GetObject("BConsulta.Image"), System.Drawing.Image)
        Me.BConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BConsulta.Location = New System.Drawing.Point(798, 496)
        Me.BConsulta.Name = "BConsulta"
        Me.BConsulta.Size = New System.Drawing.Size(189, 30)
        Me.BConsulta.TabIndex = 5
        Me.BConsulta.Text = "Consulta"
        Me.BConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BConsulta.UseVisualStyleBackColor = True
        '
        'BImp
        '
        Me.BImp.Image = CType(resources.GetObject("BImp.Image"), System.Drawing.Image)
        Me.BImp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BImp.Location = New System.Drawing.Point(798, 532)
        Me.BImp.Name = "BImp"
        Me.BImp.Size = New System.Drawing.Size(189, 30)
        Me.BImp.TabIndex = 6
        Me.BImp.Text = "Boleta Pesaje"
        Me.BImp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BImp.UseVisualStyleBackColor = True
        '
        'FrmConsultaOT_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 633)
        Me.Controls.Add(Me.BImp)
        Me.Controls.Add(Me.BConsulta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTP_FF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_FI)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmConsultaOT_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Pesajes"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_BP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_BP As System.Windows.Forms.DataGridView
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents BConsulta As System.Windows.Forms.Button
    Friend WithEvents BImp As System.Windows.Forms.Button
End Class
