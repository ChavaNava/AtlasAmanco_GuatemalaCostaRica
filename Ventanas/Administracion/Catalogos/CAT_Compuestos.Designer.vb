<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAT_Compuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAT_Compuestos))
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TDesProd = New System.Windows.Forms.TextBox()
        Me.TCodProd = New System.Windows.Forms.TextBox()
        Me.LblCompuesto = New System.Windows.Forms.Label()
        Me.CB_Clase = New System.Windows.Forms.ComboBox()
        Me.CB_Area = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DGV.TabIndex = 339
        '
        'TDesProd
        '
        Me.TDesProd.Location = New System.Drawing.Point(396, 56)
        Me.TDesProd.Name = "TDesProd"
        Me.TDesProd.Size = New System.Drawing.Size(331, 22)
        Me.TDesProd.TabIndex = 374
        '
        'TCodProd
        '
        Me.TCodProd.Location = New System.Drawing.Point(290, 56)
        Me.TCodProd.Name = "TCodProd"
        Me.TCodProd.Size = New System.Drawing.Size(100, 22)
        Me.TCodProd.TabIndex = 373
        '
        'LblCompuesto
        '
        Me.LblCompuesto.AutoSize = True
        Me.LblCompuesto.BackColor = System.Drawing.SystemColors.Control
        Me.LblCompuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCompuesto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblCompuesto.Location = New System.Drawing.Point(144, 59)
        Me.LblCompuesto.Name = "LblCompuesto"
        Me.LblCompuesto.Size = New System.Drawing.Size(140, 16)
        Me.LblCompuesto.TabIndex = 372
        Me.LblCompuesto.Text = "Código Compuesto"
        '
        'CB_Clase
        '
        Me.CB_Clase.FormattingEnabled = True
        Me.CB_Clase.Location = New System.Drawing.Point(290, 84)
        Me.CB_Clase.Name = "CB_Clase"
        Me.CB_Clase.Size = New System.Drawing.Size(190, 24)
        Me.CB_Clase.TabIndex = 375
        '
        'CB_Area
        '
        Me.CB_Area.FormattingEnabled = True
        Me.CB_Area.Location = New System.Drawing.Point(537, 84)
        Me.CB_Area.Name = "CB_Area"
        Me.CB_Area.Size = New System.Drawing.Size(190, 24)
        Me.CB_Area.TabIndex = 376
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(236, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 377
        Me.Label1.Text = "Clase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(490, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 378
        Me.Label2.Text = "Area"
        '
        'CAT_Compuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_Area)
        Me.Controls.Add(Me.CB_Clase)
        Me.Controls.Add(Me.TDesProd)
        Me.Controls.Add(Me.TCodProd)
        Me.Controls.Add(Me.LblCompuesto)
        Me.Controls.Add(Me.DGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CAT_Compuestos"
        Me.Text = "Catalogo de Compuestos"
        Me.Controls.SetChildIndex(Me.DGV, 0)
        Me.Controls.SetChildIndex(Me.LblCompuesto, 0)
        Me.Controls.SetChildIndex(Me.TCodProd, 0)
        Me.Controls.SetChildIndex(Me.TDesProd, 0)
        Me.Controls.SetChildIndex(Me.CB_Clase, 0)
        Me.Controls.SetChildIndex(Me.CB_Area, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TDesProd As System.Windows.Forms.TextBox
    Friend WithEvents TCodProd As System.Windows.Forms.TextBox
    Friend WithEvents LblCompuesto As System.Windows.Forms.Label
    Friend WithEvents CB_Clase As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Area As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
