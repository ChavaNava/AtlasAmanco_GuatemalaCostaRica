<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmCatGrupos_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmCatGrupos_AMEX))
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
        Me.DGVGrupos = New System.Windows.Forms.DataGridView
        Me.lblUmPT = New System.Windows.Forms.Label
        Me.TCodGrp = New System.Windows.Forms.TextBox
        Me.PBActualiza = New System.Windows.Forms.ProgressBar
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.TDesGrp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CB_Status = New System.Windows.Forms.CheckBox
        Me.tsbPrincipal.SuspendLayout()
        Me.pnlConsulta.SuspendLayout()
        CType(Me.DGVGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tsbConsultar.Size = New System.Drawing.Size(73, 22)
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
        Me.tsbAlta.Size = New System.Drawing.Size(58, 22)
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
        Me.tsbGrabar.Size = New System.Drawing.Size(66, 22)
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
        Me.tsbModificar.Size = New System.Drawing.Size(70, 22)
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
        Me.tsbEliminar.Size = New System.Drawing.Size(63, 22)
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
        Me.ToolStripButton1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton1.Text = "Cancelar"
        '
        'pnlConsulta
        '
        Me.pnlConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConsulta.Controls.Add(Me.DGVGrupos)
        Me.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlConsulta.Location = New System.Drawing.Point(0, 124)
        Me.pnlConsulta.Name = "pnlConsulta"
        Me.pnlConsulta.Size = New System.Drawing.Size(707, 240)
        Me.pnlConsulta.TabIndex = 224
        '
        'DGVGrupos
        '
        Me.DGVGrupos.AllowUserToAddRows = False
        Me.DGVGrupos.AllowUserToDeleteRows = False
        Me.DGVGrupos.AllowUserToOrderColumns = True
        Me.DGVGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVGrupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVGrupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVGrupos.Location = New System.Drawing.Point(0, 0)
        Me.DGVGrupos.Name = "DGVGrupos"
        Me.DGVGrupos.ReadOnly = True
        Me.DGVGrupos.Size = New System.Drawing.Size(705, 238)
        Me.DGVGrupos.TabIndex = 180
        '
        'lblUmPT
        '
        Me.lblUmPT.AutoSize = True
        Me.lblUmPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUmPT.Location = New System.Drawing.Point(118, 59)
        Me.lblUmPT.Name = "lblUmPT"
        Me.lblUmPT.Size = New System.Drawing.Size(40, 13)
        Me.lblUmPT.TabIndex = 195
        Me.lblUmPT.Text = "Codigo"
        '
        'TCodGrp
        '
        Me.TCodGrp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCodGrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodGrp.Location = New System.Drawing.Point(165, 57)
        Me.TCodGrp.MaxLength = 50
        Me.TCodGrp.Name = "TCodGrp"
        Me.TCodGrp.Size = New System.Drawing.Size(68, 16)
        Me.TCodGrp.TabIndex = 0
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
        'TDesGrp
        '
        Me.TDesGrp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDesGrp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TDesGrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesGrp.Location = New System.Drawing.Point(165, 79)
        Me.TDesGrp.MaxLength = 50
        Me.TDesGrp.Name = "TDesGrp"
        Me.TDesGrp.Size = New System.Drawing.Size(326, 16)
        Me.TDesGrp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 309
        Me.Label1.Text = "Descripción"
        '
        'CB_Status
        '
        Me.CB_Status.AutoSize = True
        Me.CB_Status.Location = New System.Drawing.Point(165, 101)
        Me.CB_Status.Name = "CB_Status"
        Me.CB_Status.Size = New System.Drawing.Size(89, 17)
        Me.CB_Status.TabIndex = 310
        Me.CB_Status.Text = "Status Activo"
        Me.CB_Status.UseVisualStyleBackColor = True
        '
        'FrmAdmCatGrupos_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(707, 364)
        Me.Controls.Add(Me.CB_Status)
        Me.Controls.Add(Me.TDesGrp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBActualiza)
        Me.Controls.Add(Me.pnlConsulta)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.Controls.Add(Me.TCodGrp)
        Me.Controls.Add(Me.lblUmPT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdmCatGrupos_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo Areas de Producción"
        Me.tsbPrincipal.ResumeLayout(False)
        Me.tsbPrincipal.PerformLayout()
        Me.pnlConsulta.ResumeLayout(False)
        CType(Me.DGVGrupos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DGVGrupos As System.Windows.Forms.DataGridView
    Friend WithEvents lblUmPT As System.Windows.Forms.Label
    Friend WithEvents TCodGrp As System.Windows.Forms.TextBox
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
    Friend WithEvents TDesGrp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CB_Status As System.Windows.Forms.CheckBox
End Class
