<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAT_Racks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAT_Racks))
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TDesRack = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TCodRack = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.TPesoRack = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_State = New System.Windows.Forms.CheckBox()
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
        'TDesRack
        '
        Me.TDesRack.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TDesRack.Location = New System.Drawing.Point(132, 72)
        Me.TDesRack.Name = "TDesRack"
        Me.TDesRack.Size = New System.Drawing.Size(547, 22)
        Me.TDesRack.TabIndex = 343
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(35, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 16)
        Me.Label13.TabIndex = 342
        Me.Label13.Text = "Descripción"
        '
        'TCodRack
        '
        Me.TCodRack.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TCodRack.Location = New System.Drawing.Point(132, 44)
        Me.TCodRack.Name = "TCodRack"
        Me.TCodRack.Size = New System.Drawing.Size(100, 22)
        Me.TCodRack.TabIndex = 341
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.BackColor = System.Drawing.SystemColors.Control
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblProducto.Location = New System.Drawing.Point(68, 47)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(58, 16)
        Me.lblProducto.TabIndex = 340
        Me.lblProducto.Text = "Codigo"
        '
        'TPesoRack
        '
        Me.TPesoRack.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TPesoRack.Location = New System.Drawing.Point(132, 100)
        Me.TPesoRack.Name = "TPesoRack"
        Me.TPesoRack.Size = New System.Drawing.Size(100, 22)
        Me.TPesoRack.TabIndex = 345
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(82, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 344
        Me.Label1.Text = "Peso"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(164, 232)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(624, 19)
        Me.Label22.TabIndex = 381
        Me.Label22.Text = "Label22"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(69, 129)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 16)
        Me.Label16.TabIndex = 383
        Me.Label16.Text = "Estado"
        '
        'CB_State
        '
        Me.CB_State.AutoSize = True
        Me.CB_State.BackColor = System.Drawing.SystemColors.Control
        Me.CB_State.Enabled = False
        Me.CB_State.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CB_State.Location = New System.Drawing.Point(132, 128)
        Me.CB_State.Name = "CB_State"
        Me.CB_State.Size = New System.Drawing.Size(70, 20)
        Me.CB_State.TabIndex = 382
        Me.CB_State.Text = "Activo"
        Me.CB_State.UseVisualStyleBackColor = False
        '
        'CAT_Racks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CB_State)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TPesoRack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TDesRack)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TCodRack)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.DGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CAT_Racks"
        Me.Text = "Racks"
        Me.Controls.SetChildIndex(Me.DGV, 0)
        Me.Controls.SetChildIndex(Me.lblProducto, 0)
        Me.Controls.SetChildIndex(Me.TCodRack, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.TDesRack, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TPesoRack, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        Me.Controls.SetChildIndex(Me.CB_State, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TDesRack As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TCodRack As System.Windows.Forms.TextBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents TPesoRack As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CB_State As System.Windows.Forms.CheckBox
End Class
