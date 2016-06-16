<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpro))
        Me.grdSpro = New System.Windows.Forms.DataGrid
        Me.tsbPrincipal = New System.Windows.Forms.ToolStrip
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton
        Me.stbAceptar = New System.Windows.Forms.ToolStripButton
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton
        Me.pnlXxx = New System.Windows.Forms.Panel
        Me.TSpro = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.grdSpro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbPrincipal.SuspendLayout()
        Me.pnlXxx.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdSpro
        '
        Me.grdSpro.AlternatingBackColor = System.Drawing.Color.PaleTurquoise
        Me.grdSpro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSpro.BackColor = System.Drawing.Color.Honeydew
        Me.grdSpro.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.grdSpro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdSpro.CaptionBackColor = System.Drawing.Color.CornflowerBlue
        Me.grdSpro.CaptionFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSpro.CaptionForeColor = System.Drawing.Color.Black
        Me.grdSpro.DataMember = ""
        Me.grdSpro.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSpro.ForeColor = System.Drawing.Color.Black
        Me.grdSpro.GridLineColor = System.Drawing.Color.LightSteelBlue
        Me.grdSpro.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.grdSpro.HeaderBackColor = System.Drawing.Color.LightSteelBlue
        Me.grdSpro.HeaderFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSpro.HeaderForeColor = System.Drawing.Color.Black
        Me.grdSpro.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.grdSpro.Location = New System.Drawing.Point(-1, 3)
        Me.grdSpro.Name = "grdSpro"
        Me.grdSpro.ParentRowsBackColor = System.Drawing.Color.LightSteelBlue
        Me.grdSpro.ParentRowsForeColor = System.Drawing.Color.Black
        Me.grdSpro.PreferredColumnWidth = 200
        Me.grdSpro.ReadOnly = True
        Me.grdSpro.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        Me.grdSpro.SelectionForeColor = System.Drawing.Color.Black
        Me.grdSpro.Size = New System.Drawing.Size(666, 275)
        Me.grdSpro.TabIndex = 179
        '
        'tsbPrincipal
        '
        Me.tsbPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tsbPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConsultar, Me.stbAceptar, Me.tsbCerrar})
        Me.tsbPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsbPrincipal.Name = "tsbPrincipal"
        Me.tsbPrincipal.Size = New System.Drawing.Size(678, 25)
        Me.tsbPrincipal.TabIndex = 14
        Me.tsbPrincipal.Text = "ToolStrip1"
        '
        'tsbConsultar
        '
        Me.tsbConsultar.Image = CType(resources.GetObject("tsbConsultar.Image"), System.Drawing.Image)
        Me.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultar.Name = "tsbConsultar"
        Me.tsbConsultar.Size = New System.Drawing.Size(73, 22)
        Me.tsbConsultar.Text = "Consultar"
        '
        'stbAceptar
        '
        Me.stbAceptar.Image = CType(resources.GetObject("stbAceptar.Image"), System.Drawing.Image)
        Me.stbAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stbAceptar.Name = "stbAceptar"
        Me.stbAceptar.Size = New System.Drawing.Size(65, 22)
        Me.stbAceptar.Text = "Aceptar"
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
        Me.pnlXxx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlXxx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlXxx.Controls.Add(Me.grdSpro)
        Me.pnlXxx.Location = New System.Drawing.Point(4, 52)
        Me.pnlXxx.Name = "pnlXxx"
        Me.pnlXxx.Size = New System.Drawing.Size(670, 283)
        Me.pnlXxx.TabIndex = 220
        '
        'TSpro
        '
        Me.TSpro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSpro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TSpro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSpro.Location = New System.Drawing.Point(65, 30)
        Me.TSpro.MaxLength = 200
        Me.TSpro.Name = "TSpro"
        Me.TSpro.Size = New System.Drawing.Size(605, 16)
        Me.TSpro.TabIndex = 221
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(5, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 222
        Me.Label8.Text = "Buscar:"
        '
        'frmSpro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(678, 339)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TSpro)
        Me.Controls.Add(Me.pnlXxx)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSpro"
        CType(Me.grdSpro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbPrincipal.ResumeLayout(False)
        Me.tsbPrincipal.PerformLayout()
        Me.pnlXxx.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdSpro As System.Windows.Forms.DataGrid
    Friend WithEvents tsbPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents stbAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlXxx As System.Windows.Forms.Panel
    Friend WithEvents tsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSpro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
