<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmCatProdTinta_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmCatProdTinta_AMEX))
        Me.tsbPrincipal = New System.Windows.Forms.ToolStrip
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAlta = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.pnlConsulta = New System.Windows.Forms.Panel
        Me.DGVProd = New System.Windows.Forms.DataGridView
        Me.btnTintas = New System.Windows.Forms.Button
        Me.lblUmPT = New System.Windows.Forms.Label
        Me.TCodTinta = New System.Windows.Forms.TextBox
        Me.TDesTinta = New System.Windows.Forms.TextBox
        Me.lblProducto = New System.Windows.Forms.Label
        Me.PBActualiza = New System.Windows.Forms.ProgressBar
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.CB_Codigo = New System.Windows.Forms.ComboBox
        Me.CB_Status = New System.Windows.Forms.CheckBox
        Me.CB_StatusBom = New System.Windows.Forms.CheckBox
        Me.TDesTipo = New System.Windows.Forms.TextBox
        Me.TCodTipo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.tsbPrincipal.Size = New System.Drawing.Size(876, 25)
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
        Me.pnlConsulta.Location = New System.Drawing.Point(0, 215)
        Me.pnlConsulta.Name = "pnlConsulta"
        Me.pnlConsulta.Size = New System.Drawing.Size(876, 308)
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
        Me.DGVProd.Size = New System.Drawing.Size(874, 306)
        Me.DGVProd.TabIndex = 180
        '
        'btnTintas
        '
        Me.btnTintas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTintas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTintas.Image = CType(resources.GetObject("btnTintas.Image"), System.Drawing.Image)
        Me.btnTintas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTintas.Location = New System.Drawing.Point(241, 91)
        Me.btnTintas.Name = "btnTintas"
        Me.btnTintas.Size = New System.Drawing.Size(25, 22)
        Me.btnTintas.TabIndex = 227
        Me.btnTintas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTintas.UseVisualStyleBackColor = True
        '
        'lblUmPT
        '
        Me.lblUmPT.AutoSize = True
        Me.lblUmPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUmPT.Location = New System.Drawing.Point(85, 96)
        Me.lblUmPT.Name = "lblUmPT"
        Me.lblUmPT.Size = New System.Drawing.Size(80, 13)
        Me.lblUmPT.TabIndex = 195
        Me.lblUmPT.Text = "Codigo Material"
        '
        'TCodTinta
        '
        Me.TCodTinta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCodTinta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodTinta.Location = New System.Drawing.Point(171, 94)
        Me.TCodTinta.MaxLength = 50
        Me.TCodTinta.Name = "TCodTinta"
        Me.TCodTinta.ReadOnly = True
        Me.TCodTinta.Size = New System.Drawing.Size(68, 16)
        Me.TCodTinta.TabIndex = 196
        '
        'TDesTinta
        '
        Me.TDesTinta.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TDesTinta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDesTinta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesTinta.Location = New System.Drawing.Point(272, 94)
        Me.TDesTinta.MaxLength = 5
        Me.TDesTinta.Name = "TDesTinta"
        Me.TDesTinta.ReadOnly = True
        Me.TDesTinta.Size = New System.Drawing.Size(345, 16)
        Me.TDesTinta.TabIndex = 198
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(79, 41)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(86, 13)
        Me.lblProducto.TabIndex = 193
        Me.lblProducto.Text = "Codigo Producto"
        '
        'PBActualiza
        '
        Me.PBActualiza.Location = New System.Drawing.Point(72, 65)
        Me.PBActualiza.Name = "PBActualiza"
        Me.PBActualiza.Size = New System.Drawing.Size(624, 23)
        Me.PBActualiza.TabIndex = 303
        '
        'BackgroundWorker1
        '
        '
        'CB_Codigo
        '
        Me.CB_Codigo.FormattingEnabled = True
        Me.CB_Codigo.Location = New System.Drawing.Point(171, 38)
        Me.CB_Codigo.Name = "CB_Codigo"
        Me.CB_Codigo.Size = New System.Drawing.Size(524, 21)
        Me.CB_Codigo.TabIndex = 304
        '
        'CB_Status
        '
        Me.CB_Status.AutoSize = True
        Me.CB_Status.Location = New System.Drawing.Point(171, 141)
        Me.CB_Status.Name = "CB_Status"
        Me.CB_Status.Size = New System.Drawing.Size(89, 17)
        Me.CB_Status.TabIndex = 313
        Me.CB_Status.Text = "Status Activo"
        Me.CB_Status.UseVisualStyleBackColor = True
        '
        'CB_StatusBom
        '
        Me.CB_StatusBom.AutoSize = True
        Me.CB_StatusBom.Location = New System.Drawing.Point(171, 164)
        Me.CB_StatusBom.Name = "CB_StatusBom"
        Me.CB_StatusBom.Size = New System.Drawing.Size(47, 17)
        Me.CB_StatusBom.TabIndex = 314
        Me.CB_StatusBom.Text = "Bom"
        Me.CB_StatusBom.UseVisualStyleBackColor = True
        '
        'TDesTipo
        '
        Me.TDesTipo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TDesTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDesTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesTipo.Location = New System.Drawing.Point(245, 119)
        Me.TDesTipo.MaxLength = 5
        Me.TDesTipo.Name = "TDesTipo"
        Me.TDesTipo.ReadOnly = True
        Me.TDesTipo.Size = New System.Drawing.Size(168, 16)
        Me.TDesTipo.TabIndex = 315
        '
        'TCodTipo
        '
        Me.TCodTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCodTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodTipo.Location = New System.Drawing.Point(171, 119)
        Me.TCodTipo.MaxLength = 50
        Me.TCodTipo.Name = "TCodTipo"
        Me.TCodTipo.ReadOnly = True
        Me.TCodTipo.Size = New System.Drawing.Size(68, 16)
        Me.TCodTipo.TabIndex = 316
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 317
        Me.Label1.Text = "Codigo Tipo"
        '
        'FrmAdmCatProdTinta_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(876, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TCodTipo)
        Me.Controls.Add(Me.TDesTipo)
        Me.Controls.Add(Me.CB_StatusBom)
        Me.Controls.Add(Me.CB_Status)
        Me.Controls.Add(Me.CB_Codigo)
        Me.Controls.Add(Me.PBActualiza)
        Me.Controls.Add(Me.pnlConsulta)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.Controls.Add(Me.btnTintas)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.TDesTinta)
        Me.Controls.Add(Me.TCodTinta)
        Me.Controls.Add(Me.lblUmPT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdmCatProdTinta_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Producto / Tintas"
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
    Friend WithEvents btnTintas As System.Windows.Forms.Button
    Friend WithEvents lblUmPT As System.Windows.Forms.Label
    Friend WithEvents TCodTinta As System.Windows.Forms.TextBox
    Friend WithEvents TDesTinta As System.Windows.Forms.TextBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PBActualiza As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CB_Codigo As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Status As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CB_StatusBom As System.Windows.Forms.CheckBox
    Friend WithEvents TDesTipo As System.Windows.Forms.TextBox
    Friend WithEvents TCodTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
