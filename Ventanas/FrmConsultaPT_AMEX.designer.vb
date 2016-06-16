<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaPesajes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaPesajes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV_BP = New System.Windows.Forms.DataGridView()
        Me.GB_Tot = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TotKilos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotTramos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotReg = New System.Windows.Forms.TextBox()
        Me.GB_Consulta = New System.Windows.Forms.GroupBox()
        Me.RB0 = New System.Windows.Forms.RadioButton()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TOrdProd = New System.Windows.Forms.TextBox()
        Me.BImp = New System.Windows.Forms.Button()
        Me.BConsulta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Tot.SuspendLayout()
        Me.GB_Consulta.SuspendLayout()
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
        Me.GroupBox1.Size = New System.Drawing.Size(1368, 418)
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
        Me.DGV_BP.Size = New System.Drawing.Size(1360, 395)
        Me.DGV_BP.TabIndex = 0
        '
        'GB_Tot
        '
        Me.GB_Tot.Controls.Add(Me.Label6)
        Me.GB_Tot.Controls.Add(Me.TotKilos)
        Me.GB_Tot.Controls.Add(Me.Label5)
        Me.GB_Tot.Controls.Add(Me.TotTramos)
        Me.GB_Tot.Controls.Add(Me.Label4)
        Me.GB_Tot.Controls.Add(Me.TotReg)
        Me.GB_Tot.Dock = System.Windows.Forms.DockStyle.Left
        Me.GB_Tot.Location = New System.Drawing.Point(0, 418)
        Me.GB_Tot.Name = "GB_Tot"
        Me.GB_Tot.Size = New System.Drawing.Size(464, 238)
        Me.GB_Tot.TabIndex = 9
        Me.GB_Tot.TabStop = False
        Me.GB_Tot.Text = "Totales Consulta"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(133, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Total Kilos"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotKilos
        '
        Me.TotKilos.Location = New System.Drawing.Point(349, 80)
        Me.TotKilos.Name = "TotKilos"
        Me.TotKilos.ReadOnly = True
        Me.TotKilos.Size = New System.Drawing.Size(109, 22)
        Me.TotKilos.TabIndex = 21
        Me.TotKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(133, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Total Tramos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotTramos
        '
        Me.TotTramos.Location = New System.Drawing.Point(349, 52)
        Me.TotTramos.Name = "TotTramos"
        Me.TotTramos.ReadOnly = True
        Me.TotTramos.Size = New System.Drawing.Size(109, 22)
        Me.TotTramos.TabIndex = 19
        Me.TotTramos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(133, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total Registros Consultados"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotReg
        '
        Me.TotReg.Location = New System.Drawing.Point(349, 24)
        Me.TotReg.Name = "TotReg"
        Me.TotReg.ReadOnly = True
        Me.TotReg.Size = New System.Drawing.Size(109, 22)
        Me.TotReg.TabIndex = 17
        Me.TotReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GB_Consulta
        '
        Me.GB_Consulta.Controls.Add(Me.RB0)
        Me.GB_Consulta.Controls.Add(Me.RB3)
        Me.GB_Consulta.Controls.Add(Me.RB1)
        Me.GB_Consulta.Controls.Add(Me.Label3)
        Me.GB_Consulta.Controls.Add(Me.TOrdProd)
        Me.GB_Consulta.Controls.Add(Me.BImp)
        Me.GB_Consulta.Controls.Add(Me.BConsulta)
        Me.GB_Consulta.Controls.Add(Me.Label2)
        Me.GB_Consulta.Controls.Add(Me.DTP_FF)
        Me.GB_Consulta.Controls.Add(Me.Label1)
        Me.GB_Consulta.Controls.Add(Me.DTP_FI)
        Me.GB_Consulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.GB_Consulta.Location = New System.Drawing.Point(721, 418)
        Me.GB_Consulta.Name = "GB_Consulta"
        Me.GB_Consulta.Size = New System.Drawing.Size(647, 238)
        Me.GB_Consulta.TabIndex = 10
        Me.GB_Consulta.TabStop = False
        Me.GB_Consulta.Text = "Consulta"
        '
        'RB0
        '
        Me.RB0.AutoSize = True
        Me.RB0.Checked = True
        Me.RB0.Location = New System.Drawing.Point(346, 22)
        Me.RB0.Name = "RB0"
        Me.RB0.Size = New System.Drawing.Size(261, 20)
        Me.RB0.TabIndex = 21
        Me.RB0.TabStop = True
        Me.RB0.Text = "Pesajes Notificados y en Proceso"
        Me.RB0.UseVisualStyleBackColor = True
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Location = New System.Drawing.Point(346, 74)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(168, 20)
        Me.RB3.TabIndex = 20
        Me.RB3.Text = "Pesajes cancelados"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Location = New System.Drawing.Point(346, 48)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(193, 20)
        Me.RB1.TabIndex = 18
        Me.RB1.Text = "Pesajes con Sobrepeso"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Orden de Producción"
        '
        'TOrdProd
        '
        Me.TOrdProd.Location = New System.Drawing.Point(222, 21)
        Me.TOrdProd.Name = "TOrdProd"
        Me.TOrdProd.Size = New System.Drawing.Size(109, 22)
        Me.TOrdProd.TabIndex = 15
        Me.TOrdProd.Text = "*"
        Me.TOrdProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BImp
        '
        Me.BImp.Image = CType(resources.GetObject("BImp.Image"), System.Drawing.Image)
        Me.BImp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BImp.Location = New System.Drawing.Point(142, 156)
        Me.BImp.Name = "BImp"
        Me.BImp.Size = New System.Drawing.Size(189, 30)
        Me.BImp.TabIndex = 14
        Me.BImp.Text = "Boleta Pesaje"
        Me.BImp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BImp.UseVisualStyleBackColor = True
        '
        'BConsulta
        '
        Me.BConsulta.Image = CType(resources.GetObject("BConsulta.Image"), System.Drawing.Image)
        Me.BConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BConsulta.Location = New System.Drawing.Point(142, 120)
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
        Me.Label2.Location = New System.Drawing.Point(87, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(222, 77)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FF.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(222, 49)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FI.TabIndex = 9
        '
        'FrmConsultaPesajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 656)
        Me.Controls.Add(Me.GB_Consulta)
        Me.Controls.Add(Me.GB_Tot)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultaPesajes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Pesajes"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_BP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Tot.ResumeLayout(False)
        Me.GB_Tot.PerformLayout()
        Me.GB_Consulta.ResumeLayout(False)
        Me.GB_Consulta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_BP As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Tot As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TOrdProd As System.Windows.Forms.TextBox
    Friend WithEvents BImp As System.Windows.Forms.Button
    Friend WithEvents BConsulta As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TotTramos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TotReg As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TotKilos As System.Windows.Forms.TextBox
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB0 As System.Windows.Forms.RadioButton
End Class
