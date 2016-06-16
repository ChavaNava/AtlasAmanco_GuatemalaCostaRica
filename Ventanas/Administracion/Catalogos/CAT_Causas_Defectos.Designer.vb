<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAT_Causas_Defectos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAT_Causas_Defectos))
        Me.TDesTipoCausa = New System.Windows.Forms.TextBox()
        Me.CB_Tipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TDesArea = New System.Windows.Forms.TextBox()
        Me.CB_Area = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TDesCausa = New System.Windows.Forms.TextBox()
        Me.TCodCausa = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TDesTipoCausa
        '
        Me.TDesTipoCausa.Location = New System.Drawing.Point(291, 42)
        Me.TDesTipoCausa.Name = "TDesTipoCausa"
        Me.TDesTipoCausa.Size = New System.Drawing.Size(399, 22)
        Me.TDesTipoCausa.TabIndex = 395
        '
        'CB_Tipo
        '
        Me.CB_Tipo.FormattingEnabled = True
        Me.CB_Tipo.Location = New System.Drawing.Point(185, 42)
        Me.CB_Tipo.Name = "CB_Tipo"
        Me.CB_Tipo.Size = New System.Drawing.Size(100, 24)
        Me.CB_Tipo.TabIndex = 394
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(91, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 393
        Me.Label1.Text = "Tipo Causa"
        '
        'TDesArea
        '
        Me.TDesArea.Location = New System.Drawing.Point(291, 72)
        Me.TDesArea.Name = "TDesArea"
        Me.TDesArea.Size = New System.Drawing.Size(399, 22)
        Me.TDesArea.TabIndex = 398
        '
        'CB_Area
        '
        Me.CB_Area.FormattingEnabled = True
        Me.CB_Area.Location = New System.Drawing.Point(185, 72)
        Me.CB_Area.Name = "CB_Area"
        Me.CB_Area.Size = New System.Drawing.Size(100, 24)
        Me.CB_Area.TabIndex = 397
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(73, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 396
        Me.Label2.Text = "Código Causa"
        '
        'TDesCausa
        '
        Me.TDesCausa.Location = New System.Drawing.Point(291, 102)
        Me.TDesCausa.Name = "TDesCausa"
        Me.TDesCausa.Size = New System.Drawing.Size(399, 22)
        Me.TDesCausa.TabIndex = 401
        '
        'TCodCausa
        '
        Me.TCodCausa.Location = New System.Drawing.Point(185, 102)
        Me.TCodCausa.Name = "TCodCausa"
        Me.TCodCausa.Size = New System.Drawing.Size(100, 22)
        Me.TCodCausa.TabIndex = 400
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.BackColor = System.Drawing.SystemColors.Control
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblProducto.Location = New System.Drawing.Point(63, 105)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(116, 16)
        Me.lblProducto.TabIndex = 399
        Me.lblProducto.Text = "Código Defecto"
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
        Me.DGV.Location = New System.Drawing.Point(0, 169)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(984, 443)
        Me.DGV.TabIndex = 402
        '
        'CAT_Causas_Defectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TDesCausa)
        Me.Controls.Add(Me.TCodCausa)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.TDesArea)
        Me.Controls.Add(Me.CB_Area)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TDesTipoCausa)
        Me.Controls.Add(Me.CB_Tipo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CAT_Causas_Defectos"
        Me.Text = "CAT_Causas_Defectos"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CB_Tipo, 0)
        Me.Controls.SetChildIndex(Me.TDesTipoCausa, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CB_Area, 0)
        Me.Controls.SetChildIndex(Me.TDesArea, 0)
        Me.Controls.SetChildIndex(Me.lblProducto, 0)
        Me.Controls.SetChildIndex(Me.TCodCausa, 0)
        Me.Controls.SetChildIndex(Me.TDesCausa, 0)
        Me.Controls.SetChildIndex(Me.DGV, 0)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TDesTipoCausa As System.Windows.Forms.TextBox
    Friend WithEvents CB_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TDesArea As System.Windows.Forms.TextBox
    Friend WithEvents CB_Area As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TDesCausa As System.Windows.Forms.TextBox
    Friend WithEvents TCodCausa As System.Windows.Forms.TextBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
End Class
