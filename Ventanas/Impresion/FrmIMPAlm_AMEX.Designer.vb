<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIMPAlm_AMEX
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIMPAlm_AMEX))
        Me.Label6 = New System.Windows.Forms.Label
        Me.TOrden = New System.Windows.Forms.TextBox
        Me.BCancel = New System.Windows.Forms.Button
        Me.BImp = New System.Windows.Forms.Button
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.RB2 = New System.Windows.Forms.RadioButton
        Me.RB1 = New System.Windows.Forms.RadioButton
        Me.CB_Trasp = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Orden de Producción"
        '
        'TOrden
        '
        Me.TOrden.Location = New System.Drawing.Point(171, 12)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.Size = New System.Drawing.Size(116, 22)
        Me.TOrden.TabIndex = 31
        Me.TOrden.Text = "*"
        '
        'BCancel
        '
        Me.BCancel.Image = CType(resources.GetObject("BCancel.Image"), System.Drawing.Image)
        Me.BCancel.Location = New System.Drawing.Point(293, 54)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(166, 36)
        Me.BCancel.TabIndex = 24
        Me.BCancel.Text = "Cancelar"
        Me.BCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancel.UseVisualStyleBackColor = True
        '
        'BImp
        '
        Me.BImp.Image = CType(resources.GetObject("BImp.Image"), System.Drawing.Image)
        Me.BImp.Location = New System.Drawing.Point(293, 12)
        Me.BImp.Name = "BImp"
        Me.BImp.Size = New System.Drawing.Size(166, 36)
        Me.BImp.TabIndex = 23
        Me.BImp.Text = "Imprimir"
        Me.BImp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BImp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BImp.UseVisualStyleBackColor = True
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(171, 68)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(116, 22)
        Me.DTP_FF.TabIndex = 22
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(171, 40)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(116, 22)
        Me.DTP_FI.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Location = New System.Drawing.Point(14, 141)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(244, 20)
        Me.RB2.TabIndex = 34
        Me.RB2.TabStop = True
        Me.RB2.Text = "Boletas Ordendas por Producto"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Location = New System.Drawing.Point(14, 115)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(154, 20)
        Me.RB1.TabIndex = 33
        Me.RB1.TabStop = True
        Me.RB1.Text = "Boletas Recibidas"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'CB_Trasp
        '
        Me.CB_Trasp.AutoSize = True
        Me.CB_Trasp.Location = New System.Drawing.Point(14, 168)
        Me.CB_Trasp.Name = "CB_Trasp"
        Me.CB_Trasp.Size = New System.Drawing.Size(222, 20)
        Me.CB_Trasp.TabIndex = 35
        Me.CB_Trasp.Text = "Incluir Boletas Traspasadas"
        Me.CB_Trasp.UseVisualStyleBackColor = True
        '
        'FrmIMPAlm_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 200)
        Me.Controls.Add(Me.CB_Trasp)
        Me.Controls.Add(Me.RB2)
        Me.Controls.Add(Me.RB1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TOrden)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.BImp)
        Me.Controls.Add(Me.DTP_FF)
        Me.Controls.Add(Me.DTP_FI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIMPAlm_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents BCancel As System.Windows.Forms.Button
    Friend WithEvents BImp As System.Windows.Forms.Button
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents CB_Trasp As System.Windows.Forms.CheckBox
End Class
