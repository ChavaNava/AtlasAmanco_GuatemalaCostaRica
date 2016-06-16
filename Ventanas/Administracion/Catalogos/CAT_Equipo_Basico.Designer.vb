<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAT_Equipo_Basico
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
        Me.TMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TDesEqp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TCodEqp = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TModelo = New System.Windows.Forms.TextBox()
        Me.TCapacidad = New System.Windows.Forms.TextBox()
        Me.TLimite = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_State = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TMarca
        '
        Me.TMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TMarca.Location = New System.Drawing.Point(210, 74)
        Me.TMarca.Name = "TMarca"
        Me.TMarca.Size = New System.Drawing.Size(563, 22)
        Me.TMarca.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(144, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 350
        Me.Label1.Text = "Modelo"
        '
        'TDesEqp
        '
        Me.TDesEqp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TDesEqp.Location = New System.Drawing.Point(316, 46)
        Me.TDesEqp.Name = "TDesEqp"
        Me.TDesEqp.Size = New System.Drawing.Size(457, 22)
        Me.TDesEqp.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(153, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 16)
        Me.Label13.TabIndex = 348
        Me.Label13.Text = "Marca"
        '
        'TCodEqp
        '
        Me.TCodEqp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TCodEqp.Location = New System.Drawing.Point(210, 46)
        Me.TCodEqp.Name = "TCodEqp"
        Me.TCodEqp.Size = New System.Drawing.Size(100, 22)
        Me.TCodEqp.TabIndex = 0
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.BackColor = System.Drawing.SystemColors.Control
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblProducto.Location = New System.Drawing.Point(73, 49)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(131, 16)
        Me.lblProducto.TabIndex = 346
        Me.lblProducto.Text = "Puesto de trabajo"
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
        Me.DGV.TabIndex = 352
        '
        'TModelo
        '
        Me.TModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TModelo.Location = New System.Drawing.Point(210, 102)
        Me.TModelo.Name = "TModelo"
        Me.TModelo.Size = New System.Drawing.Size(563, 22)
        Me.TModelo.TabIndex = 3
        '
        'TCapacidad
        '
        Me.TCapacidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TCapacidad.Location = New System.Drawing.Point(210, 130)
        Me.TCapacidad.Name = "TCapacidad"
        Me.TCapacidad.Size = New System.Drawing.Size(100, 22)
        Me.TCapacidad.TabIndex = 4
        '
        'TLimite
        '
        Me.TLimite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TLimite.Location = New System.Drawing.Point(499, 130)
        Me.TLimite.Name = "TLimite"
        Me.TLimite.Size = New System.Drawing.Size(100, 22)
        Me.TLimite.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(120, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 356
        Me.Label2.Text = "Capacidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(363, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 16)
        Me.Label3.TabIndex = 357
        Me.Label3.Text = "Limite Sobrepeso"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(640, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 16)
        Me.Label16.TabIndex = 379
        Me.Label16.Text = "Estado"
        '
        'CB_State
        '
        Me.CB_State.AutoSize = True
        Me.CB_State.BackColor = System.Drawing.SystemColors.Control
        Me.CB_State.Enabled = False
        Me.CB_State.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CB_State.Location = New System.Drawing.Point(703, 132)
        Me.CB_State.Name = "CB_State"
        Me.CB_State.Size = New System.Drawing.Size(70, 20)
        Me.CB_State.TabIndex = 6
        Me.CB_State.Text = "Activo"
        Me.CB_State.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(164, 232)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(624, 19)
        Me.Label22.TabIndex = 380
        Me.Label22.Text = "Label22"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CAT_Equipo_Basico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CB_State)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TLimite)
        Me.Controls.Add(Me.TCapacidad)
        Me.Controls.Add(Me.TModelo)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TDesEqp)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TCodEqp)
        Me.Controls.Add(Me.lblProducto)
        Me.Name = "CAT_Equipo_Basico"
        Me.Text = "CAT_EquipoBasico"
        Me.Controls.SetChildIndex(Me.lblProducto, 0)
        Me.Controls.SetChildIndex(Me.TCodEqp, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.TDesEqp, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TMarca, 0)
        Me.Controls.SetChildIndex(Me.DGV, 0)
        Me.Controls.SetChildIndex(Me.TModelo, 0)
        Me.Controls.SetChildIndex(Me.TCapacidad, 0)
        Me.Controls.SetChildIndex(Me.TLimite, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CB_State, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TDesEqp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TCodEqp As System.Windows.Forms.TextBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TModelo As System.Windows.Forms.TextBox
    Friend WithEvents TCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents TLimite As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CB_State As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
