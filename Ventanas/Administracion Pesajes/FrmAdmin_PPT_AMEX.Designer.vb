<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin_PPT_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin_PPT_AMEX))
        Me.GB_Pesajes = New System.Windows.Forms.GroupBox
        Me.DGV_Pesos = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker
        Me.BConsulta = New System.Windows.Forms.Button
        Me.BtnDel = New System.Windows.Forms.Button
        Me.TOrden = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GB_Hist = New System.Windows.Forms.GroupBox
        Me.DGV_Hst = New System.Windows.Forms.DataGridView
        Me.GB_Pesajes.SuspendLayout()
        CType(Me.DGV_Pesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Hist.SuspendLayout()
        CType(Me.DGV_Hst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Pesajes
        '
        Me.GB_Pesajes.Controls.Add(Me.DGV_Pesos)
        Me.GB_Pesajes.Location = New System.Drawing.Point(0, 27)
        Me.GB_Pesajes.Name = "GB_Pesajes"
        Me.GB_Pesajes.Size = New System.Drawing.Size(901, 447)
        Me.GB_Pesajes.TabIndex = 0
        Me.GB_Pesajes.TabStop = False
        Me.GB_Pesajes.Text = "Pesajes"
        '
        'DGV_Pesos
        '
        Me.DGV_Pesos.AllowUserToAddRows = False
        Me.DGV_Pesos.AllowUserToDeleteRows = False
        Me.DGV_Pesos.AllowUserToOrderColumns = True
        Me.DGV_Pesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_Pesos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Pesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pesos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Pesos.Location = New System.Drawing.Point(3, 18)
        Me.DGV_Pesos.Name = "DGV_Pesos"
        Me.DGV_Pesos.ReadOnly = True
        Me.DGV_Pesos.Size = New System.Drawing.Size(895, 426)
        Me.DGV_Pesos.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(934, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(1069, 79)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FF.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(918, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(1069, 51)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FI.TabIndex = 5
        '
        'BConsulta
        '
        Me.BConsulta.Image = CType(resources.GetObject("BConsulta.Image"), System.Drawing.Image)
        Me.BConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BConsulta.Location = New System.Drawing.Point(956, 156)
        Me.BConsulta.Name = "BConsulta"
        Me.BConsulta.Size = New System.Drawing.Size(189, 30)
        Me.BConsulta.TabIndex = 9
        Me.BConsulta.Text = "Consulta"
        Me.BConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BConsulta.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Image = CType(resources.GetObject("BtnDel.Image"), System.Drawing.Image)
        Me.BtnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDel.Location = New System.Drawing.Point(956, 256)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(189, 30)
        Me.BtnDel.TabIndex = 10
        Me.BtnDel.Text = "Baja Registro"
        Me.BtnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'TOrden
        '
        Me.TOrden.Location = New System.Drawing.Point(1069, 107)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.Size = New System.Drawing.Size(109, 22)
        Me.TOrden.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(931, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Orden Producción"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1192, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GB_Hist
        '
        Me.GB_Hist.Controls.Add(Me.DGV_Hst)
        Me.GB_Hist.Location = New System.Drawing.Point(0, 480)
        Me.GB_Hist.Name = "GB_Hist"
        Me.GB_Hist.Size = New System.Drawing.Size(901, 206)
        Me.GB_Hist.TabIndex = 19
        Me.GB_Hist.TabStop = False
        Me.GB_Hist.Text = "Historia Pesajes"
        '
        'DGV_Hst
        '
        Me.DGV_Hst.AllowUserToAddRows = False
        Me.DGV_Hst.AllowUserToDeleteRows = False
        Me.DGV_Hst.AllowUserToOrderColumns = True
        Me.DGV_Hst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_Hst.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Hst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Hst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Hst.Location = New System.Drawing.Point(3, 18)
        Me.DGV_Hst.Name = "DGV_Hst"
        Me.DGV_Hst.ReadOnly = True
        Me.DGV_Hst.Size = New System.Drawing.Size(895, 185)
        Me.DGV_Hst.TabIndex = 0
        '
        'FrmAdmin_PPT_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 687)
        Me.Controls.Add(Me.GB_Hist)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TOrden)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BConsulta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTP_FF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_FI)
        Me.Controls.Add(Me.GB_Pesajes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdmin_PPT_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAdminDel_PPT_AMEX"
        Me.GB_Pesajes.ResumeLayout(False)
        CType(Me.DGV_Pesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Hist.ResumeLayout(False)
        CType(Me.DGV_Hst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB_Pesajes As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents BConsulta As System.Windows.Forms.Button
    Friend WithEvents DGV_Pesos As System.Windows.Forms.DataGridView
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GB_Hist As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Hst As System.Windows.Forms.DataGridView
End Class
