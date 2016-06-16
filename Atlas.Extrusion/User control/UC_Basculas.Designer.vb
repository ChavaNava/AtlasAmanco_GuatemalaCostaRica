<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Basculas
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
        Me.GB_Basculas = New System.Windows.Forms.GroupBox()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.GB_Basculas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_Basculas
        '
        Me.GB_Basculas.Controls.Add(Me.RB3)
        Me.GB_Basculas.Controls.Add(Me.RB2)
        Me.GB_Basculas.Controls.Add(Me.RB1)
        Me.GB_Basculas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Basculas.Location = New System.Drawing.Point(3, 3)
        Me.GB_Basculas.Name = "GB_Basculas"
        Me.GB_Basculas.Size = New System.Drawing.Size(641, 34)
        Me.GB_Basculas.TabIndex = 603
        Me.GB_Basculas.TabStop = False
        Me.GB_Basculas.Text = "Bascula"
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB3.Location = New System.Drawing.Point(373, 9)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(94, 20)
        Me.RB3.TabIndex = 606
        Me.RB3.TabStop = True
        Me.RB3.Text = "Bascula 3"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB2.Location = New System.Drawing.Point(225, 9)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(94, 20)
        Me.RB2.TabIndex = 605
        Me.RB2.TabStop = True
        Me.RB2.Text = "Bascula 2"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Checked = True
        Me.RB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB1.Location = New System.Drawing.Point(89, 9)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(94, 20)
        Me.RB1.TabIndex = 604
        Me.RB1.TabStop = True
        Me.RB1.Text = "Bascula 1"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'UC_Basculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GB_Basculas)
        Me.Name = "UC_Basculas"
        Me.Size = New System.Drawing.Size(647, 39)
        Me.GB_Basculas.ResumeLayout(False)
        Me.GB_Basculas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_Basculas As System.Windows.Forms.GroupBox
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton

End Class
