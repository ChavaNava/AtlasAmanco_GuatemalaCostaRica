<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MensajeBox
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
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.btOk = New System.Windows.Forms.Button()
        Me.pnOkCancel = New System.Windows.Forms.Panel()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btOk1 = New System.Windows.Forms.Button()
        Me.pnOk = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnOkCancel.SuspendLayout()
        Me.pnOk.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTexto
        '
        Me.lblTexto.AllowDrop = True
        Me.lblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(3, 3)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(230, 93)
        Me.lblTexto.TabIndex = 0
        Me.lblTexto.Text = "El usuario no existe"
        Me.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbImagen
        '
        Me.pbImagen.ErrorImage = Nothing
        Me.pbImagen.Image = My.Resources.warning_shield
        Me.pbImagen.InitialImage = Nothing
        Me.pbImagen.Location = New System.Drawing.Point(8, 7)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(90, 90)
        Me.pbImagen.TabIndex = 1
        Me.pbImagen.TabStop = False
        '
        'btOk
        '
        Me.btOk.Location = New System.Drawing.Point(3, 8)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(75, 26)
        Me.btOk.TabIndex = 2
        Me.btOk.Text = "Aceptar"
        Me.btOk.UseVisualStyleBackColor = True
        '
        'pnOkCancel
        '
        Me.pnOkCancel.Controls.Add(Me.btCancel)
        Me.pnOkCancel.Controls.Add(Me.btOk1)
        Me.pnOkCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnOkCancel.Location = New System.Drawing.Point(0, 0)
        Me.pnOkCancel.Name = "pnOkCancel"
        Me.pnOkCancel.Size = New System.Drawing.Size(193, 43)
        Me.pnOkCancel.TabIndex = 4
        Me.pnOkCancel.Visible = False
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(99, 9)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(81, 26)
        Me.btCancel.TabIndex = 3
        Me.btCancel.Text = "Cancelar"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btOk1
        '
        Me.btOk1.Location = New System.Drawing.Point(12, 9)
        Me.btOk1.Name = "btOk1"
        Me.btOk1.Size = New System.Drawing.Size(81, 26)
        Me.btOk1.TabIndex = 2
        Me.btOk1.Text = "Aceptar"
        Me.btOk1.UseVisualStyleBackColor = True
        '
        'pnOk
        '
        Me.pnOk.Controls.Add(Me.btOk)
        Me.pnOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnOk.Location = New System.Drawing.Point(257, 0)
        Me.pnOk.Name = "pnOk"
        Me.pnOk.Size = New System.Drawing.Size(82, 43)
        Me.pnOk.TabIndex = 5
        Me.pnOk.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.pnOk)
        Me.Panel1.Controls.Add(Me.pnOkCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 43)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.pbImagen)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(339, 100)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblTexto)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(94, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(245, 100)
        Me.Panel3.TabIndex = 2
        '
        'MensajeBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(339, 140)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MensajeBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensaje"
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnOkCancel.ResumeLayout(False)
        Me.pnOk.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTexto As System.Windows.Forms.Label
    Friend WithEvents pbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents btOk As System.Windows.Forms.Button
    Friend WithEvents pnOkCancel As System.Windows.Forms.Panel
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents btOk1 As System.Windows.Forms.Button
    Friend WithEvents pnOk As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
