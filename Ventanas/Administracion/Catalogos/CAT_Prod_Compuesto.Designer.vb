<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAT_Prod_Compuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAT_Prod_Compuesto))
        Me.CB_CodProd = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.CB_Bom = New System.Windows.Forms.CheckBox()
        Me.lblUmPT = New System.Windows.Forms.Label()
        Me.CB_CodComp = New System.Windows.Forms.ComboBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_CodProd
        '
        Me.CB_CodProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CodProd.FormattingEnabled = True
        Me.CB_CodProd.Location = New System.Drawing.Point(196, 47)
        Me.CB_CodProd.Name = "CB_CodProd"
        Me.CB_CodProd.Size = New System.Drawing.Size(512, 24)
        Me.CB_CodProd.TabIndex = 306
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(67, 50)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(124, 16)
        Me.lblProducto.TabIndex = 305
        Me.lblProducto.Text = "Codigo Producto"
        '
        'CB_Bom
        '
        Me.CB_Bom.AutoSize = True
        Me.CB_Bom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Bom.Location = New System.Drawing.Point(196, 107)
        Me.CB_Bom.Name = "CB_Bom"
        Me.CB_Bom.Size = New System.Drawing.Size(58, 20)
        Me.CB_Bom.TabIndex = 326
        Me.CB_Bom.Text = "Bom"
        Me.CB_Bom.UseVisualStyleBackColor = True
        '
        'lblUmPT
        '
        Me.lblUmPT.AutoSize = True
        Me.lblUmPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUmPT.Location = New System.Drawing.Point(51, 80)
        Me.lblUmPT.Name = "lblUmPT"
        Me.lblUmPT.Size = New System.Drawing.Size(140, 16)
        Me.lblUmPT.TabIndex = 316
        Me.lblUmPT.Text = "Codigo Compuesto"
        '
        'CB_CodComp
        '
        Me.CB_CodComp.FormattingEnabled = True
        Me.CB_CodComp.Location = New System.Drawing.Point(196, 77)
        Me.CB_CodComp.Name = "CB_CodComp"
        Me.CB_CodComp.Size = New System.Drawing.Size(512, 24)
        Me.CB_CodComp.TabIndex = 329
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
        Me.DGV.Location = New System.Drawing.Point(0, 338)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(984, 274)
        Me.DGV.TabIndex = 339
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(164, 232)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(624, 19)
        Me.Label22.TabIndex = 382
        Me.Label22.Text = "Label22"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CAT_Prod_Compuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.CB_CodComp)
        Me.Controls.Add(Me.CB_Bom)
        Me.Controls.Add(Me.lblUmPT)
        Me.Controls.Add(Me.CB_CodProd)
        Me.Controls.Add(Me.lblProducto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CAT_Prod_Compuesto"
        Me.Text = "Prod_Compuesto"
        Me.Controls.SetChildIndex(Me.lblProducto, 0)
        Me.Controls.SetChildIndex(Me.CB_CodProd, 0)
        Me.Controls.SetChildIndex(Me.lblUmPT, 0)
        Me.Controls.SetChildIndex(Me.CB_Bom, 0)
        Me.Controls.SetChildIndex(Me.CB_CodComp, 0)
        Me.Controls.SetChildIndex(Me.DGV, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_CodProd As System.Windows.Forms.ComboBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents CB_Bom As System.Windows.Forms.CheckBox
    Friend WithEvents lblUmPT As System.Windows.Forms.Label
    Friend WithEvents CB_CodComp As System.Windows.Forms.ComboBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
