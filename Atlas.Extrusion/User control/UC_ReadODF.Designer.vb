<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ReadODF
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.RB_SC = New System.Windows.Forms.RadioButton()
        Me.RB_PT = New System.Windows.Forms.RadioButton()
        Me.TPtoTrabajo = New System.Windows.Forms.TextBox()
        Me.TNomPtoTrabajo = New System.Windows.Forms.TextBox()
        Me.lblPtoTrabajo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TUnidades = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TFolioVale = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOrden
        '
        Me.lblOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrden.ForeColor = System.Drawing.Color.Black
        Me.lblOrden.Location = New System.Drawing.Point(3, 34)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(66, 20)
        Me.lblOrden.TabIndex = 540
        Me.lblOrden.Text = "ODF"
        Me.lblOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TOrden
        '
        Me.TOrden.BackColor = System.Drawing.SystemColors.Window
        Me.TOrden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOrden.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TOrden.Location = New System.Drawing.Point(75, 32)
        Me.TOrden.MaxLength = 12
        Me.TOrden.Name = "TOrden"
        Me.TOrden.Size = New System.Drawing.Size(105, 22)
        Me.TOrden.TabIndex = 0
        '
        'RB_SC
        '
        Me.RB_SC.AutoSize = True
        Me.RB_SC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_SC.Location = New System.Drawing.Point(313, 6)
        Me.RB_SC.Name = "RB_SC"
        Me.RB_SC.Size = New System.Drawing.Size(67, 20)
        Me.RB_SC.TabIndex = 542
        Me.RB_SC.Text = "Scrap"
        Me.RB_SC.UseVisualStyleBackColor = True
        '
        'RB_PT
        '
        Me.RB_PT.AutoSize = True
        Me.RB_PT.Checked = True
        Me.RB_PT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_PT.Location = New System.Drawing.Point(75, 6)
        Me.RB_PT.Name = "RB_PT"
        Me.RB_PT.Size = New System.Drawing.Size(167, 20)
        Me.RB_PT.TabIndex = 541
        Me.RB_PT.TabStop = True
        Me.RB_PT.Text = "Producto Terminado"
        Me.RB_PT.UseVisualStyleBackColor = True
        '
        'TPtoTrabajo
        '
        Me.TPtoTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPtoTrabajo.Location = New System.Drawing.Point(75, 60)
        Me.TPtoTrabajo.MaxLength = 10
        Me.TPtoTrabajo.Name = "TPtoTrabajo"
        Me.TPtoTrabajo.ReadOnly = True
        Me.TPtoTrabajo.Size = New System.Drawing.Size(105, 22)
        Me.TPtoTrabajo.TabIndex = 548
        '
        'TNomPtoTrabajo
        '
        Me.TNomPtoTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNomPtoTrabajo.Location = New System.Drawing.Point(186, 60)
        Me.TNomPtoTrabajo.Name = "TNomPtoTrabajo"
        Me.TNomPtoTrabajo.ReadOnly = True
        Me.TNomPtoTrabajo.Size = New System.Drawing.Size(385, 22)
        Me.TNomPtoTrabajo.TabIndex = 550
        '
        'lblPtoTrabajo
        '
        Me.lblPtoTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtoTrabajo.ForeColor = System.Drawing.Color.Black
        Me.lblPtoTrabajo.Location = New System.Drawing.Point(0, 62)
        Me.lblPtoTrabajo.Name = "lblPtoTrabajo"
        Me.lblPtoTrabajo.Size = New System.Drawing.Size(69, 18)
        Me.lblPtoTrabajo.TabIndex = 549
        Me.lblPtoTrabajo.Text = "Equipo"
        Me.lblPtoTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(186, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 552
        Me.Label1.Text = "Unidades"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TUnidades
        '
        Me.TUnidades.BackColor = System.Drawing.SystemColors.Window
        Me.TUnidades.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TUnidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUnidades.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TUnidades.Location = New System.Drawing.Point(275, 32)
        Me.TUnidades.MaxLength = 12
        Me.TUnidades.Name = "TUnidades"
        Me.TUnidades.Size = New System.Drawing.Size(90, 22)
        Me.TUnidades.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(371, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 20)
        Me.Label17.TabIndex = 620
        Me.Label17.Text = "Folio Vale"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TFolioVale
        '
        Me.TFolioVale.BackColor = System.Drawing.SystemColors.Window
        Me.TFolioVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFolioVale.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TFolioVale.Location = New System.Drawing.Point(460, 32)
        Me.TFolioVale.MaxLength = 10
        Me.TFolioVale.Name = "TFolioVale"
        Me.TFolioVale.Size = New System.Drawing.Size(111, 22)
        Me.TFolioVale.TabIndex = 2
        Me.TFolioVale.Text = "00000"
        '
        'UC_ReadODF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TFolioVale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TUnidades)
        Me.Controls.Add(Me.TPtoTrabajo)
        Me.Controls.Add(Me.TNomPtoTrabajo)
        Me.Controls.Add(Me.lblPtoTrabajo)
        Me.Controls.Add(Me.RB_SC)
        Me.Controls.Add(Me.RB_PT)
        Me.Controls.Add(Me.lblOrden)
        Me.Controls.Add(Me.TOrden)
        Me.Name = "UC_ReadODF"
        Me.Size = New System.Drawing.Size(575, 86)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOrden As System.Windows.Forms.Label
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents RB_SC As System.Windows.Forms.RadioButton
    Friend WithEvents RB_PT As System.Windows.Forms.RadioButton
    Friend WithEvents TPtoTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents TNomPtoTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents lblPtoTrabajo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TUnidades As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TFolioVale As System.Windows.Forms.TextBox

End Class
