<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmCatCompExt_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmCatCompExt_AMEX))
        Me.tsbPrincipal = New System.Windows.Forms.ToolStrip()
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAlta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.pnlConsulta = New System.Windows.Forms.Panel()
        Me.DGVProd = New System.Windows.Forms.DataGridView()
        Me.lblUmPT = New System.Windows.Forms.Label()
        Me.TCodComp = New System.Windows.Forms.TextBox()
        Me.PBActualiza = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TDesComp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TClase = New System.Windows.Forms.TextBox()
        Me.TDesClase = New System.Windows.Forms.TextBox()
        Me.BtnEmpaque = New System.Windows.Forms.Button()
        Me.TTipo = New System.Windows.Forms.TextBox()
        Me.TDesTipo = New System.Windows.Forms.TextBox()
        Me.BtnTipo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tsbPrincipal.SuspendLayout()
        Me.pnlConsulta.SuspendLayout()
        CType(Me.DGVProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsbPrincipal
        '
        Me.tsbPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tsbPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCerrar, Me.ToolStripSeparator2, Me.tsbConsultar, Me.ToolStripSeparator1, Me.tsbAlta, Me.ToolStripSeparator4, Me.tsbGrabar, Me.ToolStripSeparator3, Me.tsbModificar, Me.ToolStripSeparator6, Me.tsbEliminar, Me.ToolStripSeparator5, Me.ToolStripButton1})
        Me.tsbPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsbPrincipal.Name = "tsbPrincipal"
        Me.tsbPrincipal.Size = New System.Drawing.Size(707, 25)
        Me.tsbPrincipal.TabIndex = 222
        Me.tsbPrincipal.Text = "ToolStrip1"
        '
        'tsbCerrar
        '
        Me.tsbCerrar.AutoSize = False
        Me.tsbCerrar.Image = CType(resources.GetObject("tsbCerrar.Image"), System.Drawing.Image)
        Me.tsbCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCerrar.Name = "tsbCerrar"
        Me.tsbCerrar.Size = New System.Drawing.Size(70, 22)
        Me.tsbCerrar.Text = "Cerrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(12, 25)
        '
        'tsbConsultar
        '
        Me.tsbConsultar.Image = CType(resources.GetObject("tsbConsultar.Image"), System.Drawing.Image)
        Me.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultar.Name = "tsbConsultar"
        Me.tsbConsultar.Size = New System.Drawing.Size(78, 22)
        Me.tsbConsultar.Text = "Consultar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(12, 25)
        '
        'tsbAlta
        '
        Me.tsbAlta.Image = CType(resources.GetObject("tsbAlta.Image"), System.Drawing.Image)
        Me.tsbAlta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAlta.Name = "tsbAlta"
        Me.tsbAlta.Size = New System.Drawing.Size(62, 22)
        Me.tsbAlta.Text = "Nuevo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(12, 25)
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Image = CType(resources.GetObject("tsbGrabar.Image"), System.Drawing.Image)
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGrabar.Text = "Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(12, 25)
        '
        'tsbModificar
        '
        Me.tsbModificar.Image = CType(resources.GetObject("tsbModificar.Image"), System.Drawing.Image)
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(78, 22)
        Me.tsbModificar.Text = "Modificar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(12, 25)
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(70, 22)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(12, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton1.Text = "Cancelar"
        '
        'pnlConsulta
        '
        Me.pnlConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConsulta.Controls.Add(Me.DGVProd)
        Me.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlConsulta.Location = New System.Drawing.Point(0, 157)
        Me.pnlConsulta.Name = "pnlConsulta"
        Me.pnlConsulta.Size = New System.Drawing.Size(707, 207)
        Me.pnlConsulta.TabIndex = 224
        '
        'DGVProd
        '
        Me.DGVProd.AllowUserToAddRows = False
        Me.DGVProd.AllowUserToDeleteRows = False
        Me.DGVProd.AllowUserToOrderColumns = True
        Me.DGVProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVProd.Location = New System.Drawing.Point(0, 0)
        Me.DGVProd.Name = "DGVProd"
        Me.DGVProd.ReadOnly = True
        Me.DGVProd.Size = New System.Drawing.Size(705, 205)
        Me.DGVProd.TabIndex = 180
        '
        'lblUmPT
        '
        Me.lblUmPT.AutoSize = True
        Me.lblUmPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUmPT.Location = New System.Drawing.Point(33, 59)
        Me.lblUmPT.Name = "lblUmPT"
        Me.lblUmPT.Size = New System.Drawing.Size(96, 13)
        Me.lblUmPT.TabIndex = 195
        Me.lblUmPT.Text = "Codigo Compuesto"
        '
        'TCodComp
        '
        Me.TCodComp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCodComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodComp.Location = New System.Drawing.Point(135, 57)
        Me.TCodComp.MaxLength = 50
        Me.TCodComp.Name = "TCodComp"
        Me.TCodComp.Size = New System.Drawing.Size(68, 16)
        Me.TCodComp.TabIndex = 0
        '
        'PBActualiza
        '
        Me.PBActualiza.Location = New System.Drawing.Point(47, 28)
        Me.PBActualiza.Name = "PBActualiza"
        Me.PBActualiza.Size = New System.Drawing.Size(624, 23)
        Me.PBActualiza.TabIndex = 303
        '
        'BackgroundWorker1
        '
        '
        'TDesComp
        '
        Me.TDesComp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDesComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesComp.Location = New System.Drawing.Point(135, 79)
        Me.TDesComp.MaxLength = 50
        Me.TDesComp.Name = "TDesComp"
        Me.TDesComp.Size = New System.Drawing.Size(326, 16)
        Me.TDesComp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 309
        Me.Label1.Text = "Descripción"
        '
        'TClase
        '
        Me.TClase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TClase.Location = New System.Drawing.Point(135, 104)
        Me.TClase.MaxLength = 50
        Me.TClase.Name = "TClase"
        Me.TClase.Size = New System.Drawing.Size(68, 16)
        Me.TClase.TabIndex = 2
        '
        'TDesClase
        '
        Me.TDesClase.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TDesClase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDesClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesClase.Location = New System.Drawing.Point(232, 104)
        Me.TDesClase.MaxLength = 5
        Me.TDesClase.Name = "TDesClase"
        Me.TDesClase.ReadOnly = True
        Me.TDesClase.Size = New System.Drawing.Size(200, 16)
        Me.TDesClase.TabIndex = 316
        '
        'BtnEmpaque
        '
        Me.BtnEmpaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpaque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpaque.Image = CType(resources.GetObject("BtnEmpaque.Image"), System.Drawing.Image)
        Me.BtnEmpaque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpaque.Location = New System.Drawing.Point(205, 101)
        Me.BtnEmpaque.Name = "BtnEmpaque"
        Me.BtnEmpaque.Size = New System.Drawing.Size(25, 22)
        Me.BtnEmpaque.TabIndex = 315
        Me.BtnEmpaque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEmpaque.UseVisualStyleBackColor = True
        '
        'TTipo
        '
        Me.TTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTipo.Location = New System.Drawing.Point(135, 132)
        Me.TTipo.MaxLength = 50
        Me.TTipo.Name = "TTipo"
        Me.TTipo.Size = New System.Drawing.Size(68, 16)
        Me.TTipo.TabIndex = 3
        '
        'TDesTipo
        '
        Me.TDesTipo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TDesTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDesTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesTipo.Location = New System.Drawing.Point(232, 132)
        Me.TDesTipo.MaxLength = 5
        Me.TDesTipo.Name = "TDesTipo"
        Me.TDesTipo.ReadOnly = True
        Me.TDesTipo.Size = New System.Drawing.Size(200, 16)
        Me.TDesTipo.TabIndex = 319
        '
        'BtnTipo
        '
        Me.BtnTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTipo.Image = CType(resources.GetObject("BtnTipo.Image"), System.Drawing.Image)
        Me.BtnTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTipo.Location = New System.Drawing.Point(205, 129)
        Me.BtnTipo.Name = "BtnTipo"
        Me.BtnTipo.Size = New System.Drawing.Size(25, 22)
        Me.BtnTipo.TabIndex = 318
        Me.BtnTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTipo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 320
        Me.Label2.Text = "Clase"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 321
        Me.Label3.Text = "Tipo"
        '
        'FrmAdmCatCompExt_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(707, 364)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TTipo)
        Me.Controls.Add(Me.TDesTipo)
        Me.Controls.Add(Me.BtnTipo)
        Me.Controls.Add(Me.TClase)
        Me.Controls.Add(Me.TDesClase)
        Me.Controls.Add(Me.BtnEmpaque)
        Me.Controls.Add(Me.TDesComp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBActualiza)
        Me.Controls.Add(Me.pnlConsulta)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.Controls.Add(Me.TCodComp)
        Me.Controls.Add(Me.lblUmPT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdmCatCompExt_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo Compuestos"
        Me.tsbPrincipal.ResumeLayout(False)
        Me.tsbPrincipal.PerformLayout()
        Me.pnlConsulta.ResumeLayout(False)
        CType(Me.DGVProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsbPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAlta As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlConsulta As System.Windows.Forms.Panel
    Friend WithEvents DGVProd As System.Windows.Forms.DataGridView
    Friend WithEvents lblUmPT As System.Windows.Forms.Label
    Friend WithEvents TCodComp As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PBActualiza As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TDesComp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TClase As System.Windows.Forms.TextBox
    Friend WithEvents TDesClase As System.Windows.Forms.TextBox
    Friend WithEvents BtnEmpaque As System.Windows.Forms.Button
    Friend WithEvents TTipo As System.Windows.Forms.TextBox
    Friend WithEvents TDesTipo As System.Windows.Forms.TextBox
    Friend WithEvents BtnTipo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
