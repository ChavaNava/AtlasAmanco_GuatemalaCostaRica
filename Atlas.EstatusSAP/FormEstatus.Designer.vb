<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstatus
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxContrasena = New System.Windows.Forms.TextBox()
        Me.TxNombre = New System.Windows.Forms.TextBox()
        Me.TxCentro = New System.Windows.Forms.TextBox()
        Me.TxAlias = New System.Windows.Forms.TextBox()
        Me.TxEstatus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBStatus = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 17)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 16)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Clave de Acceso"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxContrasena
        '
        Me.TxContrasena.AcceptsReturn = True
        Me.TxContrasena.AcceptsTab = True
        Me.TxContrasena.Location = New System.Drawing.Point(157, 14)
        Me.TxContrasena.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TxContrasena.Name = "TxContrasena"
        Me.TxContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxContrasena.Size = New System.Drawing.Size(129, 22)
        Me.TxContrasena.TabIndex = 62
        '
        'TxNombre
        '
        Me.TxNombre.AcceptsReturn = True
        Me.TxNombre.AcceptsTab = True
        Me.TxNombre.Location = New System.Drawing.Point(157, 45)
        Me.TxNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxNombre.Multiline = True
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.ReadOnly = True
        Me.TxNombre.Size = New System.Drawing.Size(318, 47)
        Me.TxNombre.TabIndex = 70
        '
        'TxCentro
        '
        Me.TxCentro.AcceptsReturn = True
        Me.TxCentro.AcceptsTab = True
        Me.TxCentro.Location = New System.Drawing.Point(157, 100)
        Me.TxCentro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxCentro.Name = "TxCentro"
        Me.TxCentro.ReadOnly = True
        Me.TxCentro.Size = New System.Drawing.Size(318, 22)
        Me.TxCentro.TabIndex = 69
        '
        'TxAlias
        '
        Me.TxAlias.AcceptsReturn = True
        Me.TxAlias.AcceptsTab = True
        Me.TxAlias.Location = New System.Drawing.Point(296, 15)
        Me.TxAlias.Margin = New System.Windows.Forms.Padding(4)
        Me.TxAlias.Name = "TxAlias"
        Me.TxAlias.ReadOnly = True
        Me.TxAlias.Size = New System.Drawing.Size(179, 22)
        Me.TxAlias.TabIndex = 68
        '
        'TxEstatus
        '
        Me.TxEstatus.AcceptsReturn = True
        Me.TxEstatus.AcceptsTab = True
        Me.TxEstatus.Location = New System.Drawing.Point(157, 130)
        Me.TxEstatus.Margin = New System.Windows.Forms.Padding(4)
        Me.TxEstatus.Name = "TxEstatus"
        Me.TxEstatus.ReadOnly = True
        Me.TxEstatus.Size = New System.Drawing.Size(149, 22)
        Me.TxEstatus.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 133)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 16)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Conexión a SAP"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackgroundImage = Global.Atlas.EstatusSAP.My.Resources.Resources.BtnAceptar
        Me.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAceptar.Location = New System.Drawing.Point(496, 14)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(123, 50)
        Me.BtnAceptar.TabIndex = 74
        Me.BtnAceptar.Text = "Actualizar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = Global.Atlas.EstatusSAP.My.Resources.Resources.BtnCancelar
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.Location = New System.Drawing.Point(496, 72)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(123, 50)
        Me.BtnCancelar.TabIndex = 75
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 163)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 16)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Status de Conexión"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBStatus
        '
        Me.CBStatus.FormattingEnabled = True
        Me.CBStatus.Location = New System.Drawing.Point(157, 160)
        Me.CBStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.CBStatus.Name = "CBStatus"
        Me.CBStatus.Size = New System.Drawing.Size(149, 24)
        Me.CBStatus.TabIndex = 76
        '
        'FormEstatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(634, 202)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CBStatus)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxEstatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxNombre)
        Me.Controls.Add(Me.TxCentro)
        Me.Controls.Add(Me.TxAlias)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxContrasena)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormEstatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEstatus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxContrasena As System.Windows.Forms.TextBox
    Friend WithEvents TxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxCentro As System.Windows.Forms.TextBox
    Friend WithEvents TxAlias As System.Windows.Forms.TextBox
    Friend WithEvents TxEstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBStatus As System.Windows.Forms.ComboBox
End Class
