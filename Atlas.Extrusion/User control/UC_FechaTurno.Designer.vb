<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_FechaTurno
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
        Me.chkSAP = New System.Windows.Forms.CheckBox()
        Me.dtpFECHASAP = New System.Windows.Forms.DateTimePicker()
        Me.dtpFECHA = New System.Windows.Forms.DateTimePicker()
        Me.cmbTurnos = New System.Windows.Forms.ComboBox()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkSAP
        '
        Me.chkSAP.AutoSize = True
        Me.chkSAP.Checked = True
        Me.chkSAP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSAP.Enabled = False
        Me.chkSAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSAP.Location = New System.Drawing.Point(405, 2)
        Me.chkSAP.Name = "chkSAP"
        Me.chkSAP.Size = New System.Drawing.Size(57, 20)
        Me.chkSAP.TabIndex = 503
        Me.chkSAP.Text = "SAP"
        Me.chkSAP.UseVisualStyleBackColor = True
        '
        'dtpFECHASAP
        '
        Me.dtpFECHASAP.Enabled = False
        Me.dtpFECHASAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFECHASAP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHASAP.Location = New System.Drawing.Point(468, 1)
        Me.dtpFECHASAP.Name = "dtpFECHASAP"
        Me.dtpFECHASAP.Size = New System.Drawing.Size(100, 22)
        Me.dtpFECHASAP.TabIndex = 504
        '
        'dtpFECHA
        '
        Me.dtpFECHA.Enabled = False
        Me.dtpFECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHA.Location = New System.Drawing.Point(251, 1)
        Me.dtpFECHA.Name = "dtpFECHA"
        Me.dtpFECHA.Size = New System.Drawing.Size(100, 22)
        Me.dtpFECHA.TabIndex = 502
        '
        'cmbTurnos
        '
        Me.cmbTurnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTurnos.FormattingEnabled = True
        Me.cmbTurnos.Location = New System.Drawing.Point(66, 0)
        Me.cmbTurnos.MaxLength = 15
        Me.cmbTurnos.Name = "cmbTurnos"
        Me.cmbTurnos.Size = New System.Drawing.Size(78, 24)
        Me.cmbTurnos.TabIndex = 501
        '
        'lblTurno
        '
        Me.lblTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.ForeColor = System.Drawing.Color.Black
        Me.lblTurno.Location = New System.Drawing.Point(3, 6)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(57, 17)
        Me.lblTurno.TabIndex = 506
        Me.lblTurno.Text = "Turno"
        Me.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(189, 5)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 16)
        Me.Label30.TabIndex = 505
        Me.Label30.Text = "ATLAS"
        '
        'UC_FechaTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkSAP)
        Me.Controls.Add(Me.dtpFECHASAP)
        Me.Controls.Add(Me.dtpFECHA)
        Me.Controls.Add(Me.cmbTurnos)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.Label30)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UC_FechaTurno"
        Me.Size = New System.Drawing.Size(571, 26)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkSAP As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFECHASAP As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbTurnos As System.Windows.Forms.ComboBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label

End Class
