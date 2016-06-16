<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TFol = New System.Windows.Forms.TextBox()
        Me.TOrd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CB_Turno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.GB_Consulta = New System.Windows.Forms.GroupBox()
        Me.Btn_Consulta = New System.Windows.Forms.Button()
        Me.GB_Consulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(106, 122)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 20)
        Me.Label14.TabIndex = 289
        Me.Label14.Text = "Folio"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TFol
        '
        Me.TFol.BackColor = System.Drawing.SystemColors.Window
        Me.TFol.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TFol.Location = New System.Drawing.Point(178, 121)
        Me.TFol.Margin = New System.Windows.Forms.Padding(4)
        Me.TFol.MaxLength = 10
        Me.TFol.Name = "TFol"
        Me.TFol.Size = New System.Drawing.Size(103, 22)
        Me.TFol.TabIndex = 288
        '
        'TOrd
        '
        Me.TOrd.BackColor = System.Drawing.SystemColors.Window
        Me.TOrd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TOrd.Location = New System.Drawing.Point(178, 91)
        Me.TOrd.Margin = New System.Windows.Forms.Padding(4)
        Me.TOrd.MaxLength = 10
        Me.TOrd.Name = "TOrd"
        Me.TOrd.Size = New System.Drawing.Size(103, 22)
        Me.TOrd.TabIndex = 287
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(10, 91)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 23)
        Me.Label11.TabIndex = 286
        Me.Label11.Text = "Orden Producción"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CB_Turno
        '
        Me.CB_Turno.FormattingEnabled = True
        Me.CB_Turno.Location = New System.Drawing.Point(178, 151)
        Me.CB_Turno.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_Turno.Name = "CB_Turno"
        Me.CB_Turno.Size = New System.Drawing.Size(103, 24)
        Me.CB_Turno.TabIndex = 285
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(98, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 284
        Me.Label3.Text = "Turno"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 283
        Me.Label2.Text = "Fecha Fin Pesaje"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(178, 61)
        Me.DTP_FF.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(103, 22)
        Me.DTP_FF.TabIndex = 282
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.TabIndex = 281
        Me.Label1.Text = "Fecha Inicio Pesaje"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(178, 31)
        Me.DTP_FI.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(103, 22)
        Me.DTP_FI.TabIndex = 280
        '
        'GB_Consulta
        '
        Me.GB_Consulta.Controls.Add(Me.Btn_Consulta)
        Me.GB_Consulta.Controls.Add(Me.DTP_FI)
        Me.GB_Consulta.Controls.Add(Me.Label14)
        Me.GB_Consulta.Controls.Add(Me.Label1)
        Me.GB_Consulta.Controls.Add(Me.TFol)
        Me.GB_Consulta.Controls.Add(Me.DTP_FF)
        Me.GB_Consulta.Controls.Add(Me.TOrd)
        Me.GB_Consulta.Controls.Add(Me.Label2)
        Me.GB_Consulta.Controls.Add(Me.Label11)
        Me.GB_Consulta.Controls.Add(Me.Label3)
        Me.GB_Consulta.Controls.Add(Me.CB_Turno)
        Me.GB_Consulta.Location = New System.Drawing.Point(3, 3)
        Me.GB_Consulta.Name = "GB_Consulta"
        Me.GB_Consulta.Size = New System.Drawing.Size(288, 248)
        Me.GB_Consulta.TabIndex = 290
        Me.GB_Consulta.TabStop = False
        Me.GB_Consulta.Text = "Consulta"
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = Global.Atlas.Administracion.Pesajes.My.Resources.Resources.Btn_Consulta
        Me.Btn_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Consulta.Location = New System.Drawing.Point(7, 189)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(275, 49)
        Me.Btn_Consulta.TabIndex = 291
        Me.Btn_Consulta.Text = "Consulta"
        Me.Btn_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Consulta.UseVisualStyleBackColor = True
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GB_Consulta)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Consulta"
        Me.Size = New System.Drawing.Size(294, 254)
        Me.GB_Consulta.ResumeLayout(False)
        Me.GB_Consulta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TFol As System.Windows.Forms.TextBox
    Friend WithEvents TOrd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CB_Turno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GB_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Consulta As System.Windows.Forms.Button
    Public WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Public WithEvents DTP_FI As System.Windows.Forms.DateTimePicker

End Class
