<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSobreBajoPeso
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TSBPeso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TUsr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TObs = New System.Windows.Forms.TextBox()
        Me.RB_SA = New System.Windows.Forms.RadioButton()
        Me.RB_NA = New System.Windows.Forms.RadioButton()
        Me.Btn_Aceptar = New System.Windows.Forms.Button()
        Me.TPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'TSBPeso
        '
        Me.TSBPeso.Enabled = False
        Me.TSBPeso.Location = New System.Drawing.Point(452, 12)
        Me.TSBPeso.Name = "TSBPeso"
        Me.TSBPeso.Size = New System.Drawing.Size(76, 22)
        Me.TSBPeso.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario:"
        '
        'TUsr
        '
        Me.TUsr.Location = New System.Drawing.Point(135, 40)
        Me.TUsr.Name = "TUsr"
        Me.TUsr.Size = New System.Drawing.Size(138, 22)
        Me.TUsr.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Observaciones:"
        '
        'TObs
        '
        Me.TObs.Enabled = False
        Me.TObs.Location = New System.Drawing.Point(135, 68)
        Me.TObs.Multiline = True
        Me.TObs.Name = "TObs"
        Me.TObs.Size = New System.Drawing.Size(393, 59)
        Me.TObs.TabIndex = 5
        '
        'RB_SA
        '
        Me.RB_SA.AutoSize = True
        Me.RB_SA.Checked = True
        Me.RB_SA.Enabled = False
        Me.RB_SA.Location = New System.Drawing.Point(15, 133)
        Me.RB_SA.Name = "RB_SA"
        Me.RB_SA.Size = New System.Drawing.Size(231, 20)
        Me.RB_SA.TabIndex = 6
        Me.RB_SA.TabStop = True
        Me.RB_SA.Text = "Si Autoriza Sobre / Bajo Peso"
        Me.RB_SA.UseVisualStyleBackColor = True
        '
        'RB_NA
        '
        Me.RB_NA.AutoSize = True
        Me.RB_NA.Enabled = False
        Me.RB_NA.Location = New System.Drawing.Point(15, 159)
        Me.RB_NA.Name = "RB_NA"
        Me.RB_NA.Size = New System.Drawing.Size(237, 20)
        Me.RB_NA.TabIndex = 7
        Me.RB_NA.Text = "No Autoriza Sobre / Bajo Peso"
        Me.RB_NA.UseVisualStyleBackColor = True
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.Enabled = False
        Me.Btn_Aceptar.Location = New System.Drawing.Point(417, 151)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(111, 23)
        Me.Btn_Aceptar.TabIndex = 8
        Me.Btn_Aceptar.Text = "Aceptar"
        Me.Btn_Aceptar.UseVisualStyleBackColor = True
        '
        'TPass
        '
        Me.TPass.Location = New System.Drawing.Point(376, 40)
        Me.TPass.Name = "TPass"
        Me.TPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TPass.Size = New System.Drawing.Size(152, 22)
        Me.TPass.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Contraseña:"
        '
        'FrmSobreBajoPeso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 186)
        Me.Controls.Add(Me.TPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_Aceptar)
        Me.Controls.Add(Me.RB_NA)
        Me.Controls.Add(Me.RB_SA)
        Me.Controls.Add(Me.TObs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TUsr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TSBPeso)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSobreBajoPeso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSobreBajoPeso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TSBPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TUsr As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TObs As System.Windows.Forms.TextBox
    Friend WithEvents RB_SA As System.Windows.Forms.RadioButton
    Friend WithEvents RB_NA As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents TPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
