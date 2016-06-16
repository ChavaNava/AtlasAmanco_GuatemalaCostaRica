<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmCatRacks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmCatRacks))
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtTara = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCapacidad = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tsbPrincipal = New System.Windows.Forms.ToolStrip
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton
        Me.pnlCriterios = New System.Windows.Forms.Panel
        Me.pnlConsultas = New System.Windows.Forms.Panel
        Me.grdConsulta = New System.Windows.Forms.DataGrid
        Me.tsbPrincipal.SuspendLayout()
        Me.pnlCriterios.SuspendLayout()
        Me.pnlConsultas.SuspendLayout()
        CType(Me.grdConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkActivo.Location = New System.Drawing.Point(363, 37)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(53, 17)
        Me.chkActivo.TabIndex = 4
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 39)
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
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(160, 12)
        Me.txtDescripcion.MaxLength = 40
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(707, 15)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(86, 12)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(66, 15)
        Me.txtCodigo.TabIndex = 2
        '
        'txtTara
        '
        Me.txtTara.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTara.Location = New System.Drawing.Point(210, 35)
        Me.txtTara.MaxLength = 15
        Me.txtTara.Name = "txtTara"
        Me.txtTara.Size = New System.Drawing.Size(67, 15)
        Me.txtTara.TabIndex = 145
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(161, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "TARA:"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidad.Location = New System.Drawing.Point(86, 35)
        Me.txtCapacidad.MaxLength = 15
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(66, 15)
        Me.txtCapacidad.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Capacidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código:"
        '
        'tsbPrincipal
        '
        Me.tsbPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tsbPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConsultar, Me.ToolStripSeparator1, Me.tsbGrabar, Me.tsbModificar, Me.tsbBorrar, Me.tsbCerrar})
        Me.tsbPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsbPrincipal.Name = "tsbPrincipal"
        Me.tsbPrincipal.Size = New System.Drawing.Size(883, 25)
        Me.tsbPrincipal.TabIndex = 220
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
        Me.pnlCriterios.Controls.Add(Me.txtTara)
        Me.pnlCriterios.Controls.Add(Me.Label4)
        Me.pnlCriterios.Controls.Add(Me.chkActivo)
        Me.pnlCriterios.Controls.Add(Me.txtCapacidad)
        Me.pnlCriterios.Controls.Add(Me.Label3)
        Me.pnlCriterios.Controls.Add(Me.Label1)
        Me.pnlCriterios.Controls.Add(Me.Label2)
        Me.pnlCriterios.Controls.Add(Me.txtDescripcion)
        Me.pnlCriterios.Controls.Add(Me.txtCodigo)
        Me.pnlCriterios.Location = New System.Drawing.Point(4, 28)
        Me.pnlCriterios.Name = "pnlCriterios"
        Me.pnlCriterios.Size = New System.Drawing.Size(874, 65)
        Me.pnlCriterios.TabIndex = 221
        '
        'pnlConsultas
        '
        Me.pnlConsultas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlConsultas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConsultas.Controls.Add(Me.grdConsulta)
        Me.pnlConsultas.Location = New System.Drawing.Point(4, 99)
        Me.pnlConsultas.Name = "pnlConsultas"
        Me.pnlConsultas.Size = New System.Drawing.Size(874, 302)
        Me.pnlConsultas.TabIndex = 222
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
        Me.grdConsulta.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdConsulta.CaptionForeColor = System.Drawing.Color.Black
        Me.grdConsulta.CaptionText = "Racks"
        Me.grdConsulta.DataMember = ""
        Me.grdConsulta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdConsulta.ForeColor = System.Drawing.Color.Black
        Me.grdConsulta.GridLineColor = System.Drawing.Color.LightSteelBlue
        Me.grdConsulta.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.grdConsulta.HeaderBackColor = System.Drawing.Color.LightSteelBlue
        Me.grdConsulta.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdConsulta.HeaderForeColor = System.Drawing.Color.Black
        Me.grdConsulta.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.grdConsulta.Location = New System.Drawing.Point(3, 3)
        Me.grdConsulta.Name = "grdConsulta"
        Me.grdConsulta.ParentRowsBackColor = System.Drawing.Color.LightSteelBlue
        Me.grdConsulta.ParentRowsForeColor = System.Drawing.Color.Black
        Me.grdConsulta.ReadOnly = True
        Me.grdConsulta.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        Me.grdConsulta.SelectionForeColor = System.Drawing.Color.Black
        Me.grdConsulta.Size = New System.Drawing.Size(866, 294)
        Me.grdConsulta.TabIndex = 179
        '
        'FrmAdmCatRacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(883, 405)
        Me.Controls.Add(Me.pnlConsultas)
        Me.Controls.Add(Me.pnlCriterios)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdmCatRacks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo RACKS"
        Me.tsbPrincipal.ResumeLayout(False)
        Me.tsbPrincipal.PerformLayout()
        Me.pnlCriterios.ResumeLayout(False)
        Me.pnlCriterios.PerformLayout()
        Me.pnlConsultas.ResumeLayout(False)
        CType(Me.grdConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTara As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsbPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlCriterios As System.Windows.Forms.Panel
    Friend WithEvents pnlConsultas As System.Windows.Forms.Panel
    Friend WithEvents grdConsulta As System.Windows.Forms.DataGrid
End Class
