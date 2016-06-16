<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Tara
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
        Me.TC_Descrack = New System.Windows.Forms.TextBox()
        Me.CB_Rack = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TPesoRack = New System.Windows.Forms.TextBox()
        Me.lblRack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TC_Descrack
        '
        Me.TC_Descrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC_Descrack.Location = New System.Drawing.Point(308, 3)
        Me.TC_Descrack.Name = "TC_Descrack"
        Me.TC_Descrack.ReadOnly = True
        Me.TC_Descrack.Size = New System.Drawing.Size(266, 22)
        Me.TC_Descrack.TabIndex = 616
        '
        'CB_Rack
        '
        Me.CB_Rack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Rack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Rack.FormattingEnabled = True
        Me.CB_Rack.Location = New System.Drawing.Point(77, 3)
        Me.CB_Rack.Name = "CB_Rack"
        Me.CB_Rack.Size = New System.Drawing.Size(79, 24)
        Me.CB_Rack.TabIndex = 612
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(254, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 615
        Me.Label11.Text = " ( Kg )"
        '
        'TPesoRack
        '
        Me.TPesoRack.BackColor = System.Drawing.SystemColors.Window
        Me.TPesoRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPesoRack.Location = New System.Drawing.Point(162, 3)
        Me.TPesoRack.Name = "TPesoRack"
        Me.TPesoRack.Size = New System.Drawing.Size(85, 22)
        Me.TPesoRack.TabIndex = 613
        Me.TPesoRack.Text = "0"
        '
        'lblRack
        '
        Me.lblRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRack.ForeColor = System.Drawing.Color.Black
        Me.lblRack.Location = New System.Drawing.Point(3, 6)
        Me.lblRack.Name = "lblRack"
        Me.lblRack.Size = New System.Drawing.Size(70, 17)
        Me.lblRack.TabIndex = 614
        Me.lblRack.Text = "Tarima"
        Me.lblRack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UC_Tara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TC_Descrack)
        Me.Controls.Add(Me.CB_Rack)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TPesoRack)
        Me.Controls.Add(Me.lblRack)
        Me.Name = "UC_Tara"
        Me.Size = New System.Drawing.Size(589, 29)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TC_Descrack As System.Windows.Forms.TextBox
    Friend WithEvents CB_Rack As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TPesoRack As System.Windows.Forms.TextBox
    Friend WithEvents lblRack As System.Windows.Forms.Label

End Class
