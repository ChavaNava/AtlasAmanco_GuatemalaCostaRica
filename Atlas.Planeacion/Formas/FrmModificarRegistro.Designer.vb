<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarRegistro
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
        Me.gbActividad = New System.Windows.Forms.GroupBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.rbReabrir = New System.Windows.Forms.RadioButton()
        Me.rbCerrar = New System.Windows.Forms.RadioButton()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.gbActividad.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿ Que desea hacer ?"
        '
        'gbActividad
        '
        Me.gbActividad.Controls.Add(Me.BtnCancel)
        Me.gbActividad.Controls.Add(Me.BtnAceptar)
        Me.gbActividad.Controls.Add(Me.rbReabrir)
        Me.gbActividad.Controls.Add(Me.rbCerrar)
        Me.gbActividad.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbActividad.Location = New System.Drawing.Point(0, 38)
        Me.gbActividad.Name = "gbActividad"
        Me.gbActividad.Size = New System.Drawing.Size(426, 232)
        Me.gbActividad.TabIndex = 1
        Me.gbActividad.TabStop = False
        Me.gbActividad.Text = "Actividad"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.Atlas.Planeacion.My.Resources.Resources.Aceptar
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAceptar.Location = New System.Drawing.Point(34, 150)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(137, 39)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'rbReabrir
        '
        Me.rbReabrir.AutoSize = True
        Me.rbReabrir.Location = New System.Drawing.Point(34, 94)
        Me.rbReabrir.Name = "rbReabrir"
        Me.rbReabrir.Size = New System.Drawing.Size(275, 24)
        Me.rbReabrir.TabIndex = 1
        Me.rbReabrir.Text = "Reabrir Orden de Producción"
        Me.rbReabrir.UseVisualStyleBackColor = True
        '
        'rbCerrar
        '
        Me.rbCerrar.AutoSize = True
        Me.rbCerrar.Checked = True
        Me.rbCerrar.Location = New System.Drawing.Point(34, 49)
        Me.rbCerrar.Name = "rbCerrar"
        Me.rbCerrar.Size = New System.Drawing.Size(267, 24)
        Me.rbCerrar.TabIndex = 0
        Me.rbCerrar.TabStop = True
        Me.rbCerrar.Text = "Cerrar Orden de Producción"
        Me.rbCerrar.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.Atlas.Planeacion.My.Resources.Resources.Cancel
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.Location = New System.Drawing.Point(238, 150)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(137, 39)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FrmModificarRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 270)
        Me.Controls.Add(Me.gbActividad)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmModificarRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModificarRegistro"
        Me.gbActividad.ResumeLayout(False)
        Me.gbActividad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbActividad As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents rbReabrir As System.Windows.Forms.RadioButton
    Friend WithEvents rbCerrar As System.Windows.Forms.RadioButton
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
