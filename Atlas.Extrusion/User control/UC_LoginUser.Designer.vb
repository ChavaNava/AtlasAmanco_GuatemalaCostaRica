<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_LoginUser
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
        Me.TPassNotifier = New System.Windows.Forms.TextBox()
        Me.NomOperador = New System.Windows.Forms.TextBox()
        Me.CodOperador = New System.Windows.Forms.TextBox()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.lblCentro = New System.Windows.Forms.Label()
        Me.Centro = New System.Windows.Forms.TextBox()
        Me.NomCentro = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TPassNotifier
        '
        Me.TPassNotifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPassNotifier.Location = New System.Drawing.Point(112, 31)
        Me.TPassNotifier.MaxLength = 10
        Me.TPassNotifier.Name = "TPassNotifier"
        Me.TPassNotifier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TPassNotifier.Size = New System.Drawing.Size(105, 22)
        Me.TPassNotifier.TabIndex = 0
        '
        'NomOperador
        '
        Me.NomOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomOperador.Location = New System.Drawing.Point(345, 31)
        Me.NomOperador.Name = "NomOperador"
        Me.NomOperador.ReadOnly = True
        Me.NomOperador.Size = New System.Drawing.Size(267, 22)
        Me.NomOperador.TabIndex = 533
        '
        'CodOperador
        '
        Me.CodOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodOperador.Location = New System.Drawing.Point(223, 31)
        Me.CodOperador.MaxLength = 10
        Me.CodOperador.Name = "CodOperador"
        Me.CodOperador.ReadOnly = True
        Me.CodOperador.Size = New System.Drawing.Size(116, 22)
        Me.CodOperador.TabIndex = 530
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.ForeColor = System.Drawing.Color.Black
        Me.lblClave.Location = New System.Drawing.Point(17, 34)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(89, 16)
        Me.lblClave.TabIndex = 534
        Me.lblClave.Text = "Controlador"
        '
        'lblCentro
        '
        Me.lblCentro.AutoSize = True
        Me.lblCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentro.ForeColor = System.Drawing.Color.Black
        Me.lblCentro.Location = New System.Drawing.Point(53, 9)
        Me.lblCentro.Name = "lblCentro"
        Me.lblCentro.Size = New System.Drawing.Size(53, 16)
        Me.lblCentro.TabIndex = 531
        Me.lblCentro.Text = "Centro"
        '
        'Centro
        '
        Me.Centro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Centro.Location = New System.Drawing.Point(112, 6)
        Me.Centro.Name = "Centro"
        Me.Centro.ReadOnly = True
        Me.Centro.Size = New System.Drawing.Size(80, 22)
        Me.Centro.TabIndex = 532
        '
        'NomCentro
        '
        Me.NomCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomCentro.Location = New System.Drawing.Point(198, 6)
        Me.NomCentro.Name = "NomCentro"
        Me.NomCentro.ReadOnly = True
        Me.NomCentro.Size = New System.Drawing.Size(414, 22)
        Me.NomCentro.TabIndex = 613
        '
        'UC_LoginUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NomCentro)
        Me.Controls.Add(Me.TPassNotifier)
        Me.Controls.Add(Me.NomOperador)
        Me.Controls.Add(Me.CodOperador)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.lblCentro)
        Me.Controls.Add(Me.Centro)
        Me.Name = "UC_LoginUser"
        Me.Size = New System.Drawing.Size(616, 57)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TPassNotifier As System.Windows.Forms.TextBox
    Friend WithEvents NomOperador As System.Windows.Forms.TextBox
    Friend WithEvents CodOperador As System.Windows.Forms.TextBox
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents lblCentro As System.Windows.Forms.Label
    Friend WithEvents Centro As System.Windows.Forms.TextBox
    Friend WithEvents NomCentro As System.Windows.Forms.TextBox

End Class
