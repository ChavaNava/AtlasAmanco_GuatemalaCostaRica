<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtPass1 = New System.Windows.Forms.TextBox()
		Me.lblContraseña = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtPass2 = New System.Windows.Forms.TextBox()
		Me.btnGuardarPass = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnGuardarPass)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtPass2)
		Me.GroupBox1.Controls.Add(Me.lblContraseña)
		Me.GroupBox1.Controls.Add(Me.txtPass1)
		Me.GroupBox1.Location = New System.Drawing.Point(1, -1)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(429, 206)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		'
		'txtPass1
		'
		Me.txtPass1.Location = New System.Drawing.Point(44, 35)
		Me.txtPass1.Name = "txtPass1"
		Me.txtPass1.Size = New System.Drawing.Size(327, 20)
		Me.txtPass1.TabIndex = 0
		'
		'lblContraseña
		'
		Me.lblContraseña.AutoSize = True
		Me.lblContraseña.Location = New System.Drawing.Point(44, 16)
		Me.lblContraseña.Name = "lblContraseña"
		Me.lblContraseña.Size = New System.Drawing.Size(110, 13)
		Me.lblContraseña.TabIndex = 1
		Me.lblContraseña.Text = "Escribe la Contraseña"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(44, 77)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(106, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Repite la Contraseña"
		'
		'txtPass2
		'
		Me.txtPass2.Location = New System.Drawing.Point(44, 96)
		Me.txtPass2.Name = "txtPass2"
		Me.txtPass2.Size = New System.Drawing.Size(327, 20)
		Me.txtPass2.TabIndex = 2
		'
		'btnGuardarPass
		'
		Me.btnGuardarPass.Location = New System.Drawing.Point(150, 145)
		Me.btnGuardarPass.Name = "btnGuardarPass"
		Me.btnGuardarPass.Size = New System.Drawing.Size(135, 34)
		Me.btnGuardarPass.TabIndex = 4
		Me.btnGuardarPass.Text = "Guardar"
		Me.btnGuardarPass.UseVisualStyleBackColor = True
		'
		'frmChangePassword
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(431, 206)
		Me.Controls.Add(Me.GroupBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmChangePassword"
		Me.Text = "Actualiza Contraseña"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtPass2 As TextBox
	Friend WithEvents lblContraseña As Label
	Friend WithEvents txtPass1 As TextBox
	Friend WithEvents btnGuardarPass As Button
End Class
