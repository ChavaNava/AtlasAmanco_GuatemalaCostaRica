<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaUsuarioAvisoSobrepeso
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
        Me.TxEmail = New System.Windows.Forms.TextBox()
        Me.CBUsuarios = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'TxEmail
        '
        Me.TxEmail.Location = New System.Drawing.Point(80, 42)
        Me.TxEmail.Name = "TxEmail"
        Me.TxEmail.ReadOnly = True
        Me.TxEmail.Size = New System.Drawing.Size(415, 22)
        Me.TxEmail.TabIndex = 1
        '
        'CBUsuarios
        '
        Me.CBUsuarios.FormattingEnabled = True
        Me.CBUsuarios.Location = New System.Drawing.Point(80, 12)
        Me.CBUsuarios.Name = "CBUsuarios"
        Me.CBUsuarios.Size = New System.Drawing.Size(415, 24)
        Me.CBUsuarios.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Correo"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.Atlas.Administracion.My.Resources.Resources.Aceptar
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAceptar.Location = New System.Drawing.Point(501, 12)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(107, 23)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Atlas.Administracion.My.Resources.Resources.Cancelar
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.Location = New System.Drawing.Point(501, 41)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(107, 23)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmAltaUsuarioAvisoSobrepeso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(620, 76)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBUsuarios)
        Me.Controls.Add(Me.TxEmail)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmAltaUsuarioAvisoSobrepeso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAltaUsuarioAvisoSobrepeso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxEmail As System.Windows.Forms.TextBox
    Friend WithEvents CBUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
