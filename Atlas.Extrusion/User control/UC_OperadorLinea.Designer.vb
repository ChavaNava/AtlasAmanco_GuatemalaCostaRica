<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_OperadorLinea
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
        Me.CB_Ope = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CB_Ope
        '
        Me.CB_Ope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Ope.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Ope.FormattingEnabled = True
        Me.CB_Ope.Location = New System.Drawing.Point(84, 3)
        Me.CB_Ope.Name = "CB_Ope"
        Me.CB_Ope.Size = New System.Drawing.Size(363, 24)
        Me.CB_Ope.TabIndex = 546
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(3, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 21)
        Me.Label16.TabIndex = 547
        Me.Label16.Text = "Operador"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UC_OperadorLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CB_Ope)
        Me.Controls.Add(Me.Label16)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UC_OperadorLinea"
        Me.Size = New System.Drawing.Size(451, 31)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CB_Ope As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
