<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIMP_SC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIMP_SC))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.BImp = New System.Windows.Forms.Button()
        Me.BCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_Turno = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.THI = New System.Windows.Forms.TextBox()
        Me.THF = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.GB_Reportes = New System.Windows.Forms.GroupBox()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.GB_Reportes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(168, 35)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(108, 22)
        Me.DTP_FI.TabIndex = 2
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(168, 91)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(108, 22)
        Me.DTP_FF.TabIndex = 3
        '
        'BImp
        '
        Me.BImp.Image = CType(resources.GetObject("BImp.Image"), System.Drawing.Image)
        Me.BImp.Location = New System.Drawing.Point(300, 12)
        Me.BImp.Name = "BImp"
        Me.BImp.Size = New System.Drawing.Size(166, 36)
        Me.BImp.TabIndex = 4
        Me.BImp.Text = "Imprimir"
        Me.BImp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BImp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BImp.UseVisualStyleBackColor = True
        '
        'BCancel
        '
        Me.BCancel.Image = CType(resources.GetObject("BCancel.Image"), System.Drawing.Image)
        Me.BCancel.Location = New System.Drawing.Point(300, 54)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(166, 36)
        Me.BCancel.TabIndex = 5
        Me.BCancel.Text = "Cancelar"
        Me.BCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Turno"
        '
        'CB_Turno
        '
        Me.CB_Turno.FormattingEnabled = True
        Me.CB_Turno.Location = New System.Drawing.Point(168, 147)
        Me.CB_Turno.Name = "CB_Turno"
        Me.CB_Turno.Size = New System.Drawing.Size(108, 24)
        Me.CB_Turno.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Hora Inicio Pesaje"
        '
        'THI
        '
        Me.THI.Location = New System.Drawing.Point(168, 63)
        Me.THI.Name = "THI"
        Me.THI.Size = New System.Drawing.Size(108, 22)
        Me.THI.TabIndex = 11
        Me.THI.Text = "00:00:01"
        '
        'THF
        '
        Me.THF.Location = New System.Drawing.Point(168, 119)
        Me.THF.Name = "THF"
        Me.THF.Size = New System.Drawing.Size(108, 22)
        Me.THF.TabIndex = 12
        Me.THF.Text = "23:59:59"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Hora Fin Pesaje"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Orden de Producción"
        '
        'TOrden
        '
        Me.TOrden.Location = New System.Drawing.Point(168, 7)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.Size = New System.Drawing.Size(108, 22)
        Me.TOrden.TabIndex = 17
        Me.TOrden.Text = "*"
        '
        'GB_Reportes
        '
        Me.GB_Reportes.Controls.Add(Me.RB3)
        Me.GB_Reportes.Controls.Add(Me.RB2)
        Me.GB_Reportes.Controls.Add(Me.RB1)
        Me.GB_Reportes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GB_Reportes.Location = New System.Drawing.Point(0, 177)
        Me.GB_Reportes.Name = "GB_Reportes"
        Me.GB_Reportes.Size = New System.Drawing.Size(478, 129)
        Me.GB_Reportes.TabIndex = 21
        Me.GB_Reportes.TabStop = False
        Me.GB_Reportes.Text = "Reportes"
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Location = New System.Drawing.Point(26, 84)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(203, 20)
        Me.RB3.TabIndex = 2
        Me.RB3.TabStop = True
        Me.RB3.Text = "Scrap Generado y Merma"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Location = New System.Drawing.Point(26, 58)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(303, 20)
        Me.RB2.TabIndex = 1
        Me.RB2.TabStop = True
        Me.RB2.Text = "Detalle Ordenado Por Número de Orden"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Checked = True
        Me.RB1.Location = New System.Drawing.Point(26, 32)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(243, 20)
        Me.RB1.TabIndex = 0
        Me.RB1.TabStop = True
        Me.RB1.Text = "Detalle Ordenado Por Producto"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'FrmIMP_SC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 306)
        Me.Controls.Add(Me.GB_Reportes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TOrden)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.THF)
        Me.Controls.Add(Me.THI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_Turno)
        Me.Controls.Add(Me.Label3)
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
        Me.Name = "FrmIMP_SC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir"
        Me.GB_Reportes.ResumeLayout(False)
        Me.GB_Reportes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents BImp As System.Windows.Forms.Button
    Friend WithEvents BCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CB_Turno As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents THI As System.Windows.Forms.TextBox
    Friend WithEvents THF As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents GB_Reportes As System.Windows.Forms.GroupBox
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
End Class
