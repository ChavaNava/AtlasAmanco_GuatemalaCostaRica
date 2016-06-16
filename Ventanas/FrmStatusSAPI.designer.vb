<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStatusSAPI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStatusSAPI))
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtnCancI = New System.Windows.Forms.Button
        Me.CBStatusI = New System.Windows.Forms.ComboBox
        Me.TxtStDescI = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtTurnoI = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtOpeI = New System.Windows.Forms.TextBox
        Me.TxtPlantaI = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnActI = New System.Windows.Forms.Button
        Me.TxtUsrI = New System.Windows.Forms.TextBox
        Me.TxtClaveI = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(18, 198)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 20)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Status de Conexión:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnCancI
        '
        Me.BtnCancI.Enabled = False
        Me.BtnCancI.Image = CType(resources.GetObject("BtnCancI.Image"), System.Drawing.Image)
        Me.BtnCancI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancI.Location = New System.Drawing.Point(496, 77)
        Me.BtnCancI.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancI.Name = "BtnCancI"
        Me.BtnCancI.Size = New System.Drawing.Size(182, 60)
        Me.BtnCancI.TabIndex = 89
        Me.BtnCancI.Text = "Cerrar"
        Me.BtnCancI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancI.UseVisualStyleBackColor = True
        '
        'CBStatusI
        '
        Me.CBStatusI.FormattingEnabled = True
        Me.CBStatusI.Items.AddRange(New Object() {"Activado", "Desactivado"})
        Me.CBStatusI.Location = New System.Drawing.Point(176, 195)
        Me.CBStatusI.Margin = New System.Windows.Forms.Padding(4)
        Me.CBStatusI.Name = "CBStatusI"
        Me.CBStatusI.Size = New System.Drawing.Size(180, 24)
        Me.CBStatusI.TabIndex = 88
        '
        'TxtStDescI
        '
        Me.TxtStDescI.AcceptsReturn = True
        Me.TxtStDescI.AcceptsTab = True
        Me.TxtStDescI.Location = New System.Drawing.Point(176, 165)
        Me.TxtStDescI.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStDescI.Name = "TxtStDescI"
        Me.TxtStDescI.ReadOnly = True
        Me.TxtStDescI.Size = New System.Drawing.Size(127, 22)
        Me.TxtStDescI.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(18, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 19)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Conexion Actual:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTurnoI
        '
        Me.TxtTurnoI.AcceptsReturn = True
        Me.TxtTurnoI.AcceptsTab = True
        Me.TxtTurnoI.Location = New System.Drawing.Point(176, 135)
        Me.TxtTurnoI.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTurnoI.Name = "TxtTurnoI"
        Me.TxtTurnoI.ReadOnly = True
        Me.TxtTurnoI.Size = New System.Drawing.Size(127, 22)
        Me.TxtTurnoI.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(18, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 23)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Turno:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtOpeI
        '
        Me.TxtOpeI.AcceptsReturn = True
        Me.TxtOpeI.AcceptsTab = True
        Me.TxtOpeI.Location = New System.Drawing.Point(176, 75)
        Me.TxtOpeI.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtOpeI.Name = "TxtOpeI"
        Me.TxtOpeI.ReadOnly = True
        Me.TxtOpeI.Size = New System.Drawing.Size(223, 22)
        Me.TxtOpeI.TabIndex = 83
        '
        'TxtPlantaI
        '
        Me.TxtPlantaI.AcceptsReturn = True
        Me.TxtPlantaI.AcceptsTab = True
        Me.TxtPlantaI.Location = New System.Drawing.Point(176, 105)
        Me.TxtPlantaI.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPlantaI.Name = "TxtPlantaI"
        Me.TxtPlantaI.ReadOnly = True
        Me.TxtPlantaI.Size = New System.Drawing.Size(223, 22)
        Me.TxtPlantaI.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Planta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(18, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 19)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Clave de Acceso:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnActI
        '
        Me.BtnActI.Enabled = False
        Me.BtnActI.Image = CType(resources.GetObject("BtnActI.Image"), System.Drawing.Image)
        Me.BtnActI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActI.Location = New System.Drawing.Point(496, 9)
        Me.BtnActI.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActI.Name = "BtnActI"
        Me.BtnActI.Size = New System.Drawing.Size(182, 60)
        Me.BtnActI.TabIndex = 78
        Me.BtnActI.Text = "Actualizar"
        Me.BtnActI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnActI.UseVisualStyleBackColor = True
        '
        'TxtUsrI
        '
        Me.TxtUsrI.AcceptsReturn = True
        Me.TxtUsrI.AcceptsTab = True
        Me.TxtUsrI.Location = New System.Drawing.Point(176, 45)
        Me.TxtUsrI.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsrI.Name = "TxtUsrI"
        Me.TxtUsrI.ReadOnly = True
        Me.TxtUsrI.Size = New System.Drawing.Size(223, 22)
        Me.TxtUsrI.TabIndex = 79
        '
        'TxtClaveI
        '
        Me.TxtClaveI.AcceptsReturn = True
        Me.TxtClaveI.AcceptsTab = True
        Me.TxtClaveI.Location = New System.Drawing.Point(176, 15)
        Me.TxtClaveI.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtClaveI.Name = "TxtClaveI"
        Me.TxtClaveI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClaveI.Size = New System.Drawing.Size(139, 22)
        Me.TxtClaveI.TabIndex = 76
        '
        'FrmStatusSAPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 241)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCancI)
        Me.Controls.Add(Me.CBStatusI)
        Me.Controls.Add(Me.TxtStDescI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTurnoI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtOpeI)
        Me.Controls.Add(Me.TxtPlantaI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnActI)
        Me.Controls.Add(Me.TxtUsrI)
        Me.Controls.Add(Me.TxtClaveI)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmStatusSAPI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status Conexión SAP Inyección"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnCancI As System.Windows.Forms.Button
    Friend WithEvents CBStatusI As System.Windows.Forms.ComboBox
    Friend WithEvents TxtStDescI As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTurnoI As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtOpeI As System.Windows.Forms.TextBox
    Friend WithEvents TxtPlantaI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnActI As System.Windows.Forms.Button
    Friend WithEvents TxtUsrI As System.Windows.Forms.TextBox
    Friend WithEvents TxtClaveI As System.Windows.Forms.TextBox
End Class
