<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIMP_PT
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.THF = New System.Windows.Forms.TextBox()
        Me.THI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_Turno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Imp = New System.Windows.Forms.Button()
        Me.GB_Reporte = New System.Windows.Forms.GroupBox()
        Me.RB7 = New System.Windows.Forms.RadioButton()
        Me.RB6 = New System.Windows.Forms.RadioButton()
        Me.RB5 = New System.Windows.Forms.RadioButton()
        Me.RB4 = New System.Windows.Forms.RadioButton()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.GB_Filtros = New System.Windows.Forms.GroupBox()
        Me.CB_Sub = New System.Windows.Forms.CheckBox()
        Me.CB_Notif = New System.Windows.Forms.CheckBox()
        Me.Btn_Preview = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.RB8 = New System.Windows.Forms.RadioButton()
        Me.GB_Reporte.SuspendLayout()
        Me.GB_Filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Orden de Producción"
        '
        'TOrden
        '
        Me.TOrden.Location = New System.Drawing.Point(174, 12)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.Size = New System.Drawing.Size(108, 22)
        Me.TOrden.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Hora Fin Pesaje"
        '
        'THF
        '
        Me.THF.Location = New System.Drawing.Point(174, 124)
        Me.THF.Name = "THF"
        Me.THF.Size = New System.Drawing.Size(108, 22)
        Me.THF.TabIndex = 27
        Me.THF.Text = "23:59:59"
        '
        'THI
        '
        Me.THI.Location = New System.Drawing.Point(174, 68)
        Me.THI.Name = "THI"
        Me.THI.Size = New System.Drawing.Size(108, 22)
        Me.THI.TabIndex = 26
        Me.THI.Text = "00:00:01"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Hora Inicio Pesaje"
        '
        'CB_Turno
        '
        Me.CB_Turno.FormattingEnabled = True
        Me.CB_Turno.Location = New System.Drawing.Point(174, 152)
        Me.CB_Turno.Name = "CB_Turno"
        Me.CB_Turno.Size = New System.Drawing.Size(108, 24)
        Me.CB_Turno.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Turno"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(174, 96)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(108, 22)
        Me.DTP_FF.TabIndex = 22
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(174, 40)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(108, 22)
        Me.DTP_FI.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'Btn_Imp
        '
        Me.Btn_Imp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Imp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Imp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imp.Location = New System.Drawing.Point(300, 12)
        Me.Btn_Imp.Name = "Btn_Imp"
        Me.Btn_Imp.Size = New System.Drawing.Size(139, 50)
        Me.Btn_Imp.TabIndex = 32
        Me.Btn_Imp.Text = "Imprimir"
        Me.Btn_Imp.UseVisualStyleBackColor = False
        '
        'GB_Reporte
        '
        Me.GB_Reporte.Controls.Add(Me.RB8)
        Me.GB_Reporte.Controls.Add(Me.RB7)
        Me.GB_Reporte.Controls.Add(Me.RB6)
        Me.GB_Reporte.Controls.Add(Me.RB5)
        Me.GB_Reporte.Controls.Add(Me.RB4)
        Me.GB_Reporte.Controls.Add(Me.RB3)
        Me.GB_Reporte.Controls.Add(Me.RB2)
        Me.GB_Reporte.Controls.Add(Me.RB1)
        Me.GB_Reporte.Location = New System.Drawing.Point(12, 182)
        Me.GB_Reporte.Name = "GB_Reporte"
        Me.GB_Reporte.Size = New System.Drawing.Size(427, 246)
        Me.GB_Reporte.TabIndex = 35
        Me.GB_Reporte.TabStop = False
        Me.GB_Reporte.Text = "Tipo Reporte"
        '
        'RB7
        '
        Me.RB7.Location = New System.Drawing.Point(14, 191)
        Me.RB7.Name = "RB7"
        Me.RB7.Size = New System.Drawing.Size(337, 20)
        Me.RB7.TabIndex = 41
        Me.RB7.Text = "Resumen ordenado Por Puesto de Trabajo"
        Me.RB7.UseVisualStyleBackColor = True
        '
        'RB6
        '
        Me.RB6.Location = New System.Drawing.Point(14, 165)
        Me.RB6.Name = "RB6"
        Me.RB6.Size = New System.Drawing.Size(337, 20)
        Me.RB6.TabIndex = 40
        Me.RB6.Text = "Detalle Ordenado Por  Puesto de Trabajo"
        Me.RB6.UseVisualStyleBackColor = True
        '
        'RB5
        '
        Me.RB5.Location = New System.Drawing.Point(14, 139)
        Me.RB5.Name = "RB5"
        Me.RB5.Size = New System.Drawing.Size(337, 20)
        Me.RB5.TabIndex = 39
        Me.RB5.Text = "Consumo Compuesto Por Número de Orden"
        Me.RB5.UseVisualStyleBackColor = True
        '
        'RB4
        '
        Me.RB4.Location = New System.Drawing.Point(14, 113)
        Me.RB4.Name = "RB4"
        Me.RB4.Size = New System.Drawing.Size(266, 20)
        Me.RB4.TabIndex = 38
        Me.RB4.Text = "Consumo Compuesto Por Producto"
        Me.RB4.UseVisualStyleBackColor = True
        '
        'RB3
        '
        Me.RB3.Location = New System.Drawing.Point(14, 87)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(318, 20)
        Me.RB3.TabIndex = 37
        Me.RB3.Text = "Resumen Ordenado Por Número de Orden"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.Location = New System.Drawing.Point(14, 61)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(303, 20)
        Me.RB2.TabIndex = 36
        Me.RB2.Text = "Detalle Ordenado Por Número de Orden"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.Checked = True
        Me.RB1.Location = New System.Drawing.Point(14, 35)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(243, 20)
        Me.RB1.TabIndex = 35
        Me.RB1.TabStop = True
        Me.RB1.Text = "Detalle Ordenado Por Producto"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'GB_Filtros
        '
        Me.GB_Filtros.Controls.Add(Me.CB_Sub)
        Me.GB_Filtros.Controls.Add(Me.CB_Notif)
        Me.GB_Filtros.Location = New System.Drawing.Point(12, 434)
        Me.GB_Filtros.Name = "GB_Filtros"
        Me.GB_Filtros.Size = New System.Drawing.Size(427, 70)
        Me.GB_Filtros.TabIndex = 36
        Me.GB_Filtros.TabStop = False
        Me.GB_Filtros.Text = "Filtros"
        '
        'CB_Sub
        '
        Me.CB_Sub.Location = New System.Drawing.Point(39, 47)
        Me.CB_Sub.Name = "CB_Sub"
        Me.CB_Sub.Size = New System.Drawing.Size(135, 20)
        Me.CB_Sub.TabIndex = 21
        Me.CB_Sub.Text = "Sub Ensambles"
        Me.CB_Sub.UseVisualStyleBackColor = True
        '
        'CB_Notif
        '
        Me.CB_Notif.Location = New System.Drawing.Point(39, 21)
        Me.CB_Notif.Name = "CB_Notif"
        Me.CB_Notif.Size = New System.Drawing.Size(156, 20)
        Me.CB_Notif.TabIndex = 20
        Me.CB_Notif.Text = "Excluir Notificados"
        Me.CB_Notif.UseVisualStyleBackColor = True
        '
        'Btn_Preview
        '
        Me.Btn_Preview.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Preview.Location = New System.Drawing.Point(300, 68)
        Me.Btn_Preview.Name = "Btn_Preview"
        Me.Btn_Preview.Size = New System.Drawing.Size(139, 50)
        Me.Btn_Preview.TabIndex = 37
        Me.Btn_Preview.Text = "Previsualizar"
        Me.Btn_Preview.UseVisualStyleBackColor = False
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancel.Location = New System.Drawing.Point(300, 124)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(139, 50)
        Me.Btn_Cancel.TabIndex = 38
        Me.Btn_Cancel.Text = "Cancelar"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'RB8
        '
        Me.RB8.Location = New System.Drawing.Point(14, 217)
        Me.RB8.Name = "RB8"
        Me.RB8.Size = New System.Drawing.Size(337, 20)
        Me.RB8.TabIndex = 42
        Me.RB8.Text = "Reporte Entrega Producto Terminado"
        Me.RB8.UseVisualStyleBackColor = True
        '
        'FrmIMP_PT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 516)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Preview)
        Me.Controls.Add(Me.GB_Filtros)
        Me.Controls.Add(Me.GB_Reporte)
        Me.Controls.Add(Me.Btn_Imp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TOrden)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.THF)
        Me.Controls.Add(Me.THI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_Turno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTP_FF)
        Me.Controls.Add(Me.DTP_FI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIMP_PT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes Producto Terminado Extrusión"
        Me.GB_Reporte.ResumeLayout(False)
        Me.GB_Filtros.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents THF As System.Windows.Forms.TextBox
    Friend WithEvents THI As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CB_Turno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Imp As System.Windows.Forms.Button
    Friend WithEvents GB_Reporte As System.Windows.Forms.GroupBox
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents GB_Filtros As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Preview As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents CB_Sub As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Notif As System.Windows.Forms.CheckBox
    Friend WithEvents RB4 As System.Windows.Forms.RadioButton
    Friend WithEvents RB5 As System.Windows.Forms.RadioButton
    Friend WithEvents RB6 As System.Windows.Forms.RadioButton
    Friend WithEvents RB7 As System.Windows.Forms.RadioButton
    Friend WithEvents RB8 As System.Windows.Forms.RadioButton
End Class
