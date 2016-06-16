<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmCatPerfiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmCatPerfiles))
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tsbPrincipal = New System.Windows.Forms.ToolStrip
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton
        Me.pnlXxx = New System.Windows.Forms.Panel
        Me.pnlConsulta = New System.Windows.Forms.Panel
        Me.grdConsulta = New System.Windows.Forms.DataGrid
        Me.tsbPrincipal.SuspendLayout()
        Me.pnlXxx.SuspendLayout()
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
        Me.chkActivo.Location = New System.Drawing.Point(642, 16)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(53, 17)
        Me.chkActivo.TabIndex = 143
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(580, 17)
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
        Me.txtDescripcion.Location = New System.Drawing.Point(212, 15)
        Me.txtDescripcion.MaxLength = 40
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(349, 16)
        Me.txtDescripcion.TabIndex = 86
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(56, 15)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(150, 16)
        Me.txtCodigo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Perfil:"
        '
        'tsbPrincipal
        '
        Me.tsbPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tsbPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConsultar, Me.ToolStripSeparator1, Me.tsbGrabar, Me.tsbModificar, Me.tsbBorrar, Me.tsbCerrar})
        Me.tsbPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsbPrincipal.Name = "tsbPrincipal"
        Me.tsbPrincipal.Size = New System.Drawing.Size(742, 25)
        Me.tsbPrincipal.TabIndex = 222
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
        'pnlXxx
        '
        Me.pnlXxx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlXxx.BackColor = System.Drawing.Color.Lavender
        Me.pnlXxx.Controls.Add(Me.chkActivo)
        Me.pnlXxx.Controls.Add(Me.txtCodigo)
        Me.pnlXxx.Controls.Add(Me.Label3)
        Me.pnlXxx.Controls.Add(Me.Label2)
        Me.pnlXxx.Controls.Add(Me.txtDescripcion)
        Me.pnlXxx.Location = New System.Drawing.Point(3, 28)
        Me.pnlXxx.Name = "pnlXxx"
        Me.pnlXxx.Size = New System.Drawing.Size(735, 46)
        Me.pnlXxx.TabIndex = 223
        '
        'pnlConsulta
        '
        Me.pnlConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConsulta.Controls.Add(Me.grdConsulta)
        Me.pnlConsulta.Location = New System.Drawing.Point(3, 80)
        Me.pnlConsulta.Name = "pnlConsulta"
        Me.pnlConsulta.Size = New System.Drawing.Size(735, 309)
        Me.pnlConsulta.TabIndex = 224
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
        Me.grdConsulta.Location = New System.Drawing.Point(2, 3)
        Me.grdConsulta.Name = "grdConsulta"
        Me.grdConsulta.ParentRowsBackColor = System.Drawing.Color.LightSteelBlue
        Me.grdConsulta.ParentRowsForeColor = System.Drawing.Color.Black
        Me.grdConsulta.ReadOnly = True
        Me.grdConsulta.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        Me.grdConsulta.SelectionForeColor = System.Drawing.Color.Black
        Me.grdConsulta.Size = New System.Drawing.Size(728, 301)
        Me.grdConsulta.TabIndex = 179
        '
        'FrmAdmCatPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(742, 393)
        Me.Controls.Add(Me.pnlConsulta)
        Me.Controls.Add(Me.pnlXxx)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdmCatPerfiles"
        Me.tsbPrincipal.ResumeLayout(False)
        Me.tsbPrincipal.PerformLayout()
        Me.pnlXxx.ResumeLayout(False)
        Me.pnlXxx.PerformLayout()
        Me.pnlConsulta.ResumeLayout(False)
        CType(Me.grdConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tsbPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlXxx As System.Windows.Forms.Panel
    Friend WithEvents pnlConsulta As System.Windows.Forms.Panel
    Friend WithEvents grdConsulta As System.Windows.Forms.DataGrid
End Class
