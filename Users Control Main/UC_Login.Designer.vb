<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Login
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Login))
		Me.GB_Login = New System.Windows.Forms.GroupBox()
		Me.CB_Centro = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label02 = New System.Windows.Forms.Label()
		Me.TPass = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TUser = New System.Windows.Forms.TextBox()
		Me.BtnLoginSSO = New System.Windows.Forms.Button()
		Me.GB_Login.SuspendLayout()
		Me.SuspendLayout()
		'
		'GB_Login
		'
		Me.GB_Login.Controls.Add(Me.CB_Centro)
		Me.GB_Login.Controls.Add(Me.Label2)
		Me.GB_Login.Controls.Add(Me.Label02)
		Me.GB_Login.Controls.Add(Me.TPass)
		Me.GB_Login.Controls.Add(Me.Label1)
		Me.GB_Login.Controls.Add(Me.TUser)
		Me.GB_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GB_Login.Location = New System.Drawing.Point(3, 3)
		Me.GB_Login.Name = "GB_Login"
		Me.GB_Login.Size = New System.Drawing.Size(321, 112)
		Me.GB_Login.TabIndex = 313
		Me.GB_Login.TabStop = False
		Me.GB_Login.Text = "Validación Usuario"
		'
		'CB_Centro
		'
		Me.CB_Centro.Enabled = False
		Me.CB_Centro.FormattingEnabled = True
		Me.CB_Centro.Location = New System.Drawing.Point(107, 77)
		Me.CB_Centro.Name = "CB_Centro"
		Me.CB_Centro.Size = New System.Drawing.Size(114, 24)
		Me.CB_Centro.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(8, 78)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(93, 23)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Centro:"
		'
		'Label02
		'
		Me.Label02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label02.Location = New System.Drawing.Point(8, 22)
		Me.Label02.Name = "Label02"
		Me.Label02.Size = New System.Drawing.Size(86, 23)
		Me.Label02.TabIndex = 0
		Me.Label02.Text = "Usuario:"
		'
		'TPass
		'
		Me.TPass.AcceptsReturn = True
		Me.TPass.AcceptsTab = True
		Me.TPass.Location = New System.Drawing.Point(107, 49)
		Me.TPass.MaxLength = 20
		Me.TPass.Name = "TPass"
		Me.TPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TPass.Size = New System.Drawing.Size(208, 22)
		Me.TPass.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(8, 50)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(93, 23)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Contraseña:"
		'
		'TUser
		'
		Me.TUser.AcceptsReturn = True
		Me.TUser.AcceptsTab = True
		Me.TUser.Location = New System.Drawing.Point(107, 21)
		Me.TUser.Name = "TUser"
		Me.TUser.Size = New System.Drawing.Size(208, 22)
		Me.TUser.TabIndex = 0
		'
		'BtnLoginSSO
		'
		Me.BtnLoginSSO.BackgroundImage = CType(resources.GetObject("BtnLoginSSO.BackgroundImage"), System.Drawing.Image)
		Me.BtnLoginSSO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.BtnLoginSSO.Location = New System.Drawing.Point(344, 21)
		Me.BtnLoginSSO.Name = "BtnLoginSSO"
		Me.BtnLoginSSO.Size = New System.Drawing.Size(170, 80)
		Me.BtnLoginSSO.TabIndex = 314
		Me.BtnLoginSSO.UseVisualStyleBackColor = True
		'
		'UC_Login
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.BtnLoginSSO)
		Me.Controls.Add(Me.GB_Login)
		Me.Name = "UC_Login"
		Me.Size = New System.Drawing.Size(540, 128)
		Me.GB_Login.ResumeLayout(False)
		Me.GB_Login.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GB_Login As System.Windows.Forms.GroupBox
	Friend WithEvents CB_Centro As System.Windows.Forms.ComboBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label02 As System.Windows.Forms.Label
	Friend WithEvents TPass As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents TUser As System.Windows.Forms.TextBox
	Friend WithEvents BtnLoginSSO As Button
End Class
