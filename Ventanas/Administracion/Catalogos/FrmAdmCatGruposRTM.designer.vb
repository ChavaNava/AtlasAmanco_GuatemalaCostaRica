<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmCatGruposRTM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmCatGruposRTM))
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.rbtInyeccion = New System.Windows.Forms.RadioButton
        Me.rbtExtrusion = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tsbPrincipal = New System.Windows.Forms.ToolStrip
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton
        Me.pnlCriterios = New System.Windows.Forms.Panel
        Me.pnlConsulta = New System.Windows.Forms.Panel
        Me.grdConsulta = New System.Windows.Forms.DataGrid
        Me.tsbPrincipal.SuspendLayout()
        Me.pnlCriterios.SuspendLayout()
        Me.pnlConsulta.SuspendLayout()
        CType(Me.grdConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkActivo
        '
        Me.chkActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkActivo.Location = New System.Drawing.Point(745, 73)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(53, 17)
        Me.chkActivo.TabIndex = 4
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(100, 11)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(109, 16)
        Me.txtCodigo.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 154
        Me.Label8.Text = "Tipo Equipo:"
        '
        'rbtInyeccion
        '
        Me.rbtInyeccion.AutoSize = True
        Me.rbtInyeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtInyeccion.Location = New System.Drawing.Point(308, 74)
        Me.rbtInyeccion.Name = "rbtInyeccion"
        Me.rbtInyeccion.Size = New System.Drawing.Size(80, 17)
        Me.rbtInyeccion.TabIndex = 153
        Me.rbtInyeccion.Text = "Inyección"
        Me.rbtInyeccion.UseVisualStyleBackColor = True
        '
        'rbtExtrusion
        '
        Me.rbtExtrusion.AutoSize = True
        Me.rbtExtrusion.Checked = True
        Me.rbtExtrusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtExtrusion.Location = New System.Drawing.Point(212, 75)
        Me.rbtExtrusion.Name = "rbtExtrusion"
        Me.rbtExtrusion.Size = New System.Drawing.Size(77, 17)
        Me.rbtExtrusion.TabIndex = 152
        Me.rbtExtrusion.TabStop = True
        Me.rbtExtrusion.Text = "Extrusión"
        Me.rbtExtrusion.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(686, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Estado:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(100, 42)
        Me.txtDescripcion.MaxLength = 80
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(710, 16)
        Me.txtDescripcion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Grupo:"
        '
        'tsbPrincipal
        '
        Me.tsbPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tsbPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConsultar, Me.ToolStripSeparator1, Me.tsbGrabar, Me.tsbModificar, Me.tsbBorrar, Me.tsbCerrar})
        Me.tsbPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsbPrincipal.Name = "tsbPrincipal"
        Me.tsbPrincipal.Size = New System.Drawing.Size(906, 25)
        Me.tsbPrincipal.TabIndex = 221
        Me.tsbPrincipal.Text = "ToolStrip1"
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
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Image = CType(resources.GetObject("tsbGrabar.Image"), System.Drawing.Image)
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(115, 22)
        Me.tsbGrabar.Text = "Agregar Registro"
        '
        'tsbModificar
        '
        Me.tsbModificar.Image = CType(resources.GetObject("tsbModificar.Image"), System.Drawing.Image)
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(78, 22)
        Me.tsbModificar.Text = "Modificar"
        '
        'tsbBorrar
        '
        Me.tsbBorrar.Image = CType(resources.GetObject("tsbBorrar.Image"), System.Drawing.Image)
        Me.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBorrar.Name = "tsbBorrar"
        Me.tsbBorrar.Size = New System.Drawing.Size(70, 22)
        Me.tsbBorrar.Text = "Eliminar"
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
        'pnlCriterios
        '
        Me.pnlCriterios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCriterios.BackColor = System.Drawing.Color.Lavender
        Me.pnlCriterios.Controls.Add(Me.chkActivo)
        Me.pnlCriterios.Controls.Add(Me.Label3)
        Me.pnlCriterios.Controls.Add(Me.Label8)
        Me.pnlCriterios.Controls.Add(Me.txtDescripcion)
        Me.pnlCriterios.Controls.Add(Me.rbtInyeccion)
        Me.pnlCriterios.Controls.Add(Me.Label2)
        Me.pnlCriterios.Controls.Add(Me.rbtExtrusion)
        Me.pnlCriterios.Controls.Add(Me.txtCodigo)
        Me.pnlCriterios.Controls.Add(Me.Label6)
        Me.pnlCriterios.Location = New System.Drawing.Point(3, 28)
        Me.pnlCriterios.Name = "pnlCriterios"
        Me.pnlCriterios.Size = New System.Drawing.Size(898, 103)
        Me.pnlCriterios.TabIndex = 222
        '
        'pnlConsulta
        '
        Me.pnlConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConsulta.Controls.Add(Me.grdConsulta)
        Me.pnlConsulta.Location = New System.Drawing.Point(3, 135)
        Me.pnlConsulta.Name = "pnlConsulta"
        Me.pnlConsulta.Size = New System.Drawing.Size(898, 383)
        Me.pnlConsulta.TabIndex = 223
        '
        'grdConsulta
        '
        Me.grdConsulta.AlternatingBackColor = System.Drawing.Color.PaleTurquoise
        Me.grdConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdConsulta.BackColor = System.Drawing.Color.Honeydew
        Me.grdConsulta.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.grdConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdConsulta.CaptionBackColor = System.Drawing.Color.CornflowerBlue
        Me.grdConsulta.CaptionFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdConsulta.CaptionForeColor = System.Drawing.Color.Black
        Me.grdConsulta.DataMember = ""
        Me.grdConsulta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdConsulta.ForeColor = System.Drawing.Color.Black
        Me.grdConsulta.GridLineColor = System.Drawing.Color.LightSteelBlue
        Me.grdConsulta.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.grdConsulta.HeaderBackColor = System.Drawing.Color.LightSteelBlue
        Me.grdConsulta.HeaderFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdConsulta.HeaderForeColor = System.Drawing.Color.Black
        Me.grdConsulta.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.grdConsulta.Location = New System.Drawing.Point(3, 3)
        Me.grdConsulta.Name = "grdConsulta"
        Me.grdConsulta.ParentRowsBackColor = System.Drawing.Color.LightSteelBlue
        Me.grdConsulta.ParentRowsForeColor = System.Drawing.Color.Black
        Me.grdConsulta.ReadOnly = True
        Me.grdConsulta.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        Me.grdConsulta.SelectionForeColor = System.Drawing.Color.Black
        Me.grdConsulta.Size = New System.Drawing.Size(890, 375)
        Me.grdConsulta.TabIndex = 179
        '
        'FrmAdmCatGruposRTM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(906, 523)
        Me.Controls.Add(Me.pnlConsulta)
        Me.Controls.Add(Me.pnlCriterios)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdmCatGruposRTM"
        Me.tsbPrincipal.ResumeLayout(False)
        Me.tsbPrincipal.PerformLayout()
        Me.pnlCriterios.ResumeLayout(False)
        Me.pnlCriterios.PerformLayout()
        Me.pnlConsulta.ResumeLayout(False)
        CType(Me.grdConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbtInyeccion As System.Windows.Forms.RadioButton
    Friend WithEvents rbtExtrusion As System.Windows.Forms.RadioButton
    Friend WithEvents tsbPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlCriterios As System.Windows.Forms.Panel
    Friend WithEvents pnlConsulta As System.Windows.Forms.Panel
    Friend WithEvents grdConsulta As System.Windows.Forms.DataGrid
End Class
