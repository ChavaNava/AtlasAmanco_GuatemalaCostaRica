<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Compuestos
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CB_Com2 = New System.Windows.Forms.ComboBox()
        Me.CB_Com1 = New System.Windows.Forms.ComboBox()
        Me.TPComp2 = New System.Windows.Forms.TextBox()
        Me.TPComp1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(476, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 20)
        Me.Label13.TabIndex = 620
        Me.Label13.Text = "%"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CB_Com2
        '
        Me.CB_Com2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Com2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Com2.FormattingEnabled = True
        Me.CB_Com2.Location = New System.Drawing.Point(111, 29)
        Me.CB_Com2.Name = "CB_Com2"
        Me.CB_Com2.Size = New System.Drawing.Size(363, 24)
        Me.CB_Com2.TabIndex = 614
        '
        'CB_Com1
        '
        Me.CB_Com1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Com1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Com1.FormattingEnabled = True
        Me.CB_Com1.Location = New System.Drawing.Point(111, 3)
        Me.CB_Com1.Name = "CB_Com1"
        Me.CB_Com1.Size = New System.Drawing.Size(363, 24)
        Me.CB_Com1.TabIndex = 613
        '
        'TPComp2
        '
        Me.TPComp2.BackColor = System.Drawing.SystemColors.Window
        Me.TPComp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPComp2.Location = New System.Drawing.Point(502, 29)
        Me.TPComp2.Name = "TPComp2"
        Me.TPComp2.ReadOnly = True
        Me.TPComp2.Size = New System.Drawing.Size(72, 22)
        Me.TPComp2.TabIndex = 619
        Me.TPComp2.Text = "0"
        '
        'TPComp1
        '
        Me.TPComp1.BackColor = System.Drawing.SystemColors.Window
        Me.TPComp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPComp1.Location = New System.Drawing.Point(502, 3)
        Me.TPComp1.Name = "TPComp1"
        Me.TPComp1.Size = New System.Drawing.Size(72, 22)
        Me.TPComp1.TabIndex = 618
        Me.TPComp1.Text = "100"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(476, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 20)
        Me.Label3.TabIndex = 617
        Me.Label3.Text = "%"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 616
        Me.Label2.Text = "Compuesto 2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 615
        Me.Label1.Text = "Compuesto 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UC_Compuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CB_Com2)
        Me.Controls.Add(Me.CB_Com1)
        Me.Controls.Add(Me.TPComp2)
        Me.Controls.Add(Me.TPComp1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UC_Compuestos"
        Me.Size = New System.Drawing.Size(578, 58)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CB_Com2 As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Com1 As System.Windows.Forms.ComboBox
    Friend WithEvents TPComp2 As System.Windows.Forms.TextBox
    Friend WithEvents TPComp1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
