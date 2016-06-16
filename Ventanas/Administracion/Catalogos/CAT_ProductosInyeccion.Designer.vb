<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAT_ProductosInyeccion
    Inherits Atlas.Master_Cat

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAT_ProductosInyeccion))
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TPT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TPS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TCod_Marca = New System.Windows.Forms.TextBox()
        Me.TCod_UM = New System.Windows.Forms.TextBox()
        Me.LCodBarr = New System.Windows.Forms.Label()
        Me.CB_Marcas = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TCodBarr = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_State = New System.Windows.Forms.CheckBox()
        Me.TCentro = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TDesProd = New System.Windows.Forms.TextBox()
        Me.TCodProd = New System.Windows.Forms.TextBox()
        Me.CB_UM = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TCod_UsoMaq = New System.Windows.Forms.TextBox()
        Me.TCod_Seccion = New System.Windows.Forms.TextBox()
        Me.TCod_TipoComp = New System.Windows.Forms.TextBox()
        Me.TCod_GrpDiam = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CB_TipoComp = New System.Windows.Forms.ComboBox()
        Me.CB_GpoDiam = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CB_Seccion = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CB_UsoMaq = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToOrderColumns = True
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV.Location = New System.Drawing.Point(0, 329)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(984, 283)
        Me.DGV.TabIndex = 338
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 208)
        Me.TabControl1.TabIndex = 339
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TPT)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TPS)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TCod_Marca)
        Me.TabPage1.Controls.Add(Me.TCod_UM)
        Me.TabPage1.Controls.Add(Me.LCodBarr)
        Me.TabPage1.Controls.Add(Me.CB_Marcas)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.TCodBarr)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.CB_State)
        Me.TabPage1.Controls.Add(Me.TCentro)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.TDesProd)
        Me.TabPage1.Controls.Add(Me.TCodProd)
        Me.TabPage1.Controls.Add(Me.CB_UM)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblProducto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(976, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Descripción Producto"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TPT
        '
        Me.TPT.Location = New System.Drawing.Point(505, 94)
        Me.TPT.Name = "TPT"
        Me.TPT.Size = New System.Drawing.Size(169, 22)
        Me.TPT.TabIndex = 6
        Me.TPT.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(397, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 391
        Me.Label3.Text = "Peso Teórico"
        '
        'TPS
        '
        Me.TPS.Location = New System.Drawing.Point(169, 94)
        Me.TPS.Name = "TPS"
        Me.TPS.Size = New System.Drawing.Size(169, 22)
        Me.TPS.TabIndex = 5
        Me.TPS.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(53, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 389
        Me.Label2.Text = "Peso Estándar"
        '
        'TCod_Marca
        '
        Me.TCod_Marca.Location = New System.Drawing.Point(604, 36)
        Me.TCod_Marca.Name = "TCod_Marca"
        Me.TCod_Marca.ReadOnly = True
        Me.TCod_Marca.Size = New System.Drawing.Size(70, 22)
        Me.TCod_Marca.TabIndex = 388
        '
        'TCod_UM
        '
        Me.TCod_UM.Location = New System.Drawing.Point(435, 64)
        Me.TCod_UM.Name = "TCod_UM"
        Me.TCod_UM.ReadOnly = True
        Me.TCod_UM.Size = New System.Drawing.Size(70, 22)
        Me.TCod_UM.TabIndex = 387
        '
        'LCodBarr
        '
        Me.LCodBarr.AutoSize = True
        Me.LCodBarr.Location = New System.Drawing.Point(680, 6)
        Me.LCodBarr.Name = "LCodBarr"
        Me.LCodBarr.Size = New System.Drawing.Size(63, 16)
        Me.LCodBarr.TabIndex = 385
        Me.LCodBarr.Text = "Label13"
        Me.LCodBarr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CB_Marcas
        '
        Me.CB_Marcas.FormattingEnabled = True
        Me.CB_Marcas.Location = New System.Drawing.Point(169, 34)
        Me.CB_Marcas.Name = "CB_Marcas"
        Me.CB_Marcas.Size = New System.Drawing.Size(429, 24)
        Me.CB_Marcas.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(112, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 16)
        Me.Label18.TabIndex = 380
        Me.Label18.Text = "Marca"
        '
        'TCodBarr
        '
        Me.TCodBarr.Location = New System.Drawing.Point(169, 122)
        Me.TCodBarr.Name = "TCodBarr"
        Me.TCodBarr.Size = New System.Drawing.Size(260, 22)
        Me.TCodBarr.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(33, 125)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(130, 16)
        Me.Label17.TabIndex = 378
        Me.Label17.Text = "Código de Barras"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(103, 151)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 16)
        Me.Label16.TabIndex = 377
        Me.Label16.Text = "Estado"
        '
        'CB_State
        '
        Me.CB_State.AutoSize = True
        Me.CB_State.BackColor = System.Drawing.SystemColors.Control
        Me.CB_State.Enabled = False
        Me.CB_State.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CB_State.Location = New System.Drawing.Point(169, 150)
        Me.CB_State.Name = "CB_State"
        Me.CB_State.Size = New System.Drawing.Size(70, 20)
        Me.CB_State.TabIndex = 8
        Me.CB_State.Text = "Activo"
        Me.CB_State.UseVisualStyleBackColor = False
        '
        'TCentro
        '
        Me.TCentro.Location = New System.Drawing.Point(574, 64)
        Me.TCentro.Name = "TCentro"
        Me.TCentro.Size = New System.Drawing.Size(100, 22)
        Me.TCentro.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(515, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 16)
        Me.Label15.TabIndex = 374
        Me.Label15.Text = "Centro"
        '
        'TDesProd
        '
        Me.TDesProd.Location = New System.Drawing.Point(275, 6)
        Me.TDesProd.Name = "TDesProd"
        Me.TDesProd.Size = New System.Drawing.Size(399, 22)
        Me.TDesProd.TabIndex = 1
        '
        'TCodProd
        '
        Me.TCodProd.Location = New System.Drawing.Point(169, 6)
        Me.TCodProd.Name = "TCodProd"
        Me.TCodProd.Size = New System.Drawing.Size(100, 22)
        Me.TCodProd.TabIndex = 0
        '
        'CB_UM
        '
        Me.CB_UM.FormattingEnabled = True
        Me.CB_UM.Location = New System.Drawing.Point(169, 64)
        Me.CB_UM.Name = "CB_UM"
        Me.CB_UM.Size = New System.Drawing.Size(260, 24)
        Me.CB_UM.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(132, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 344
        Me.Label1.Text = "UM"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.BackColor = System.Drawing.SystemColors.Control
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblProducto.Location = New System.Drawing.Point(6, 9)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(157, 16)
        Me.lblProducto.TabIndex = 343
        Me.lblProducto.Text = "Descripción Producto"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TCod_UsoMaq)
        Me.TabPage3.Controls.Add(Me.TCod_Seccion)
        Me.TabPage3.Controls.Add(Me.TCod_TipoComp)
        Me.TabPage3.Controls.Add(Me.TCod_GrpDiam)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.CB_TipoComp)
        Me.TabPage3.Controls.Add(Me.CB_GpoDiam)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.CB_Seccion)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.CB_UsoMaq)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(976, 179)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Categorización"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TCod_UsoMaq
        '
        Me.TCod_UsoMaq.Location = New System.Drawing.Point(606, 97)
        Me.TCod_UsoMaq.Name = "TCod_UsoMaq"
        Me.TCod_UsoMaq.ReadOnly = True
        Me.TCod_UsoMaq.Size = New System.Drawing.Size(70, 22)
        Me.TCod_UsoMaq.TabIndex = 384
        '
        'TCod_Seccion
        '
        Me.TCod_Seccion.Location = New System.Drawing.Point(606, 67)
        Me.TCod_Seccion.Name = "TCod_Seccion"
        Me.TCod_Seccion.ReadOnly = True
        Me.TCod_Seccion.Size = New System.Drawing.Size(70, 22)
        Me.TCod_Seccion.TabIndex = 382
        '
        'TCod_TipoComp
        '
        Me.TCod_TipoComp.Location = New System.Drawing.Point(606, 39)
        Me.TCod_TipoComp.Name = "TCod_TipoComp"
        Me.TCod_TipoComp.ReadOnly = True
        Me.TCod_TipoComp.Size = New System.Drawing.Size(70, 22)
        Me.TCod_TipoComp.TabIndex = 381
        '
        'TCod_GrpDiam
        '
        Me.TCod_GrpDiam.Location = New System.Drawing.Point(606, 9)
        Me.TCod_GrpDiam.Name = "TCod_GrpDiam"
        Me.TCod_GrpDiam.ReadOnly = True
        Me.TCod_GrpDiam.Size = New System.Drawing.Size(70, 22)
        Me.TCod_GrpDiam.TabIndex = 380
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(20, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 16)
        Me.Label14.TabIndex = 379
        Me.Label14.Text = "Familia Producto"
        '
        'CB_TipoComp
        '
        Me.CB_TipoComp.FormattingEnabled = True
        Me.CB_TipoComp.Location = New System.Drawing.Point(151, 39)
        Me.CB_TipoComp.Name = "CB_TipoComp"
        Me.CB_TipoComp.Size = New System.Drawing.Size(449, 24)
        Me.CB_TipoComp.TabIndex = 378
        '
        'CB_GpoDiam
        '
        Me.CB_GpoDiam.FormattingEnabled = True
        Me.CB_GpoDiam.Location = New System.Drawing.Point(151, 9)
        Me.CB_GpoDiam.Name = "CB_GpoDiam"
        Me.CB_GpoDiam.Size = New System.Drawing.Size(449, 24)
        Me.CB_GpoDiam.TabIndex = 377
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(35, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 16)
        Me.Label11.TabIndex = 376
        Me.Label11.Text = "Grupo Material"
        '
        'CB_Seccion
        '
        Me.CB_Seccion.FormattingEnabled = True
        Me.CB_Seccion.Location = New System.Drawing.Point(151, 67)
        Me.CB_Seccion.Name = "CB_Seccion"
        Me.CB_Seccion.Size = New System.Drawing.Size(449, 24)
        Me.CB_Seccion.TabIndex = 375
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(81, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 374
        Me.Label9.Text = "Sección"
        '
        'CB_UsoMaq
        '
        Me.CB_UsoMaq.FormattingEnabled = True
        Me.CB_UsoMaq.Location = New System.Drawing.Point(151, 97)
        Me.CB_UsoMaq.Name = "CB_UsoMaq"
        Me.CB_UsoMaq.Size = New System.Drawing.Size(449, 24)
        Me.CB_UsoMaq.TabIndex = 367
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(46, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 16)
        Me.Label10.TabIndex = 366
        Me.Label10.Text = "Uso Maquina"
        '
        'TTotal
        '
        Me.TTotal.Location = New System.Drawing.Point(880, 295)
        Me.TTotal.Name = "TTotal"
        Me.TTotal.ReadOnly = True
        Me.TTotal.Size = New System.Drawing.Size(100, 22)
        Me.TTotal.TabIndex = 370
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(748, 298)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 16)
        Me.Label12.TabIndex = 369
        Me.Label12.Text = "Total Productos :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(152, 253)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 24)
        Me.Label22.TabIndex = 372
        Me.Label22.Text = "Label22"
        '
        'CAT_ProductosInyeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CAT_ProductosInyeccion"
        Me.Text = "Productos Extrusión"
        Me.Controls.SetChildIndex(Me.DGV, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.TTotal, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CB_State As System.Windows.Forms.CheckBox
    Friend WithEvents TCentro As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TDesProd As System.Windows.Forms.TextBox
    Friend WithEvents TCodProd As System.Windows.Forms.TextBox
    Friend WithEvents CB_UM As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TCodBarr As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CB_TipoComp As System.Windows.Forms.ComboBox
    Friend WithEvents CB_GpoDiam As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CB_Seccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CB_UsoMaq As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CB_Marcas As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LCodBarr As System.Windows.Forms.Label
    Friend WithEvents TCod_UM As System.Windows.Forms.TextBox
    Friend WithEvents TCod_UsoMaq As System.Windows.Forms.TextBox
    Friend WithEvents TCod_Seccion As System.Windows.Forms.TextBox
    Friend WithEvents TCod_TipoComp As System.Windows.Forms.TextBox
    Friend WithEvents TCod_GrpDiam As System.Windows.Forms.TextBox
    Friend WithEvents TCod_Marca As System.Windows.Forms.TextBox
    Friend WithEvents TTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TPT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TPS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
