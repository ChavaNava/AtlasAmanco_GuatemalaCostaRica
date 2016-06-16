<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmCatEfecto_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmCatEfecto_AMEX))
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
        Me.DGV_Efectos = New System.Windows.Forms.DataGridView
        Me.lblUmPT = New System.Windows.Forms.Label
        Me.TCodEfecto = New System.Windows.Forms.TextBox
        Me.PBActualiza = New System.Windows.Forms.ProgressBar
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.TDesEfect = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CB_Status = New System.Windows.Forms.CheckBox
        Me.tsbPrincipal.SuspendLayout()
        Me.pnlConsulta.SuspendLayout()
        CType(Me.DGV_Efectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsbPrincipal
        '
        Me.tsbPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tsbPrincipal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCerrar, Me.ToolStripSeparator2, Me.tsbConsultar, Me.ToolStripSeparator1, Me.tsbAlta, Me.ToolStripSeparator4, Me.tsbGrabar, Me.ToolStripSeparator3, Me.tsbModificar, Me.ToolStripSeparator6, Me.tsbEliminar, Me.ToolStripSeparator5, Me.ToolStripButton1})
        Me.tsbPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsbPrincipal.Name = "tsbPrincipal"
        Me.tsbPrincipal.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.tsbPrincipal.Size = New System.Drawing.Size(820, 25)
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
        Me.tsbConsultar.Size = New System.Drawing.Size(87, 22)
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
        Me.tsbAlta.Size = New System.Drawing.Size(68, 22)
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
        Me.tsbGrabar.Size = New System.Drawing.Size(77, 22)
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
        Me.tsbModificar.Size = New System.Drawing.Size(87, 22)
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
        Me.tsbEliminar.Size = New System.Drawing.Size(54, 22)
        Me.tsbEliminar.Text = "Baja"
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
        Me.ToolStripButton1.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripButton1.Text = "Cancelar"
        '
        'pnlConsulta
        '
        Me.pnlConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConsulta.Controls.Add(Me.DGV_Efectos)
        Me.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlConsulta.Location = New System.Drawing.Point(0, 144)
        Me.pnlConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlConsulta.Name = "pnlConsulta"
        Me.pnlConsulta.Size = New System.Drawing.Size(820, 364)
        Me.pnlConsulta.TabIndex = 224
        '
        'DGV_Efectos
        '
        Me.DGV_Efectos.AllowUserToAddRows = False
        Me.DGV_Efectos.AllowUserToDeleteRows = False
        Me.DGV_Efectos.AllowUserToOrderColumns = True
        Me.DGV_Efectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_Efectos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Efectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Efectos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Efectos.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Efectos.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV_Efectos.Name = "DGV_Efectos"
        Me.DGV_Efectos.ReadOnly = True
        Me.DGV_Efectos.Size = New System.Drawing.Size(818, 362)
        Me.DGV_Efectos.TabIndex = 180
        '
        'lblUmPT
        '
        Me.lblUmPT.AutoSize = True
        Me.lblUmPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUmPT.Location = New System.Drawing.Point(88, 70)
        Me.lblUmPT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUmPT.Name = "lblUmPT"
        Me.lblUmPT.Size = New System.Drawing.Size(106, 16)
        Me.lblUmPT.TabIndex = 195
        Me.lblUmPT.Text = "Codigo Efecto"
        '
        'TCodEfecto
        '
        Me.TCodEfecto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCodEfecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodEfecto.Location = New System.Drawing.Point(202, 70)
        Me.TCodEfecto.Margin = New System.Windows.Forms.Padding(4)
        Me.TCodEfecto.MaxLength = 50
        Me.TCodEfecto.Name = "TCodEfecto"
        Me.TCodEfecto.Size = New System.Drawing.Size(102, 15)
        Me.TCodEfecto.TabIndex = 0
        '
        'PBActualiza
        '
        Me.PBActualiza.Location = New System.Drawing.Point(13, 34)
        Me.PBActualiza.Margin = New System.Windows.Forms.Padding(4)
        Me.PBActualiza.Name = "PBActualiza"
        Me.PBActualiza.Size = New System.Drawing.Size(794, 28)
        Me.PBActualiza.TabIndex = 303
        '
        'BackgroundWorker1
        '
        '
        'TDesEfect
        '
        Me.TDesEfect.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDesEfect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesEfect.Location = New System.Drawing.Point(202, 93)
        Me.TDesEfect.Margin = New System.Windows.Forms.Padding(4)
        Me.TDesEfect.MaxLength = 50
        Me.TDesEfect.Name = "TDesEfect"
        Me.TDesEfect.Size = New System.Drawing.Size(446, 15)
        Me.TDesEfect.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 309
        Me.Label1.Text = "Descripción"
        '
        'CB_Status
        '
        Me.CB_Status.AutoSize = True
        Me.CB_Status.Location = New System.Drawing.Point(202, 116)
        Me.CB_Status.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_Status.Name = "CB_Status"
        Me.CB_Status.Size = New System.Drawing.Size(104, 20)
        Me.CB_Status.TabIndex = 322
        Me.CB_Status.Text = "CheckBox1"
        Me.CB_Status.UseVisualStyleBackColor = True
        '
        'FrmAdmCatEfecto_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(820, 508)
        Me.Controls.Add(Me.CB_Status)
        Me.Controls.Add(Me.TDesEfect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBActualiza)
        Me.Controls.Add(Me.pnlConsulta)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.Controls.Add(Me.TCodEfecto)
        Me.Controls.Add(Me.lblUmPT)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAdmCatEfecto_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CatCausas_AMEX"
        Me.tsbPrincipal.ResumeLayout(False)
        Me.tsbPrincipal.PerformLayout()
        Me.pnlConsulta.ResumeLayout(False)
        CType(Me.DGV_Efectos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DGV_Efectos As System.Windows.Forms.DataGridView
    Friend WithEvents lblUmPT As System.Windows.Forms.Label
    Friend WithEvents TCodEfecto As System.Windows.Forms.TextBox
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
    Friend WithEvents TDesEfect As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CB_Status As System.Windows.Forms.CheckBox
End Class
