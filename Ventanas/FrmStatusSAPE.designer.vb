<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStatusSAPE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStatusSAPE))
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnCancE = New System.Windows.Forms.Button
        Me.CBStatusE = New System.Windows.Forms.ComboBox
        Me.TxtStDescE = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtTurnoE = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtOpeE = New System.Windows.Forms.TextBox
        Me.TxtPlantaE = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.BtnActE = New System.Windows.Forms.Button
        Me.TxtUsrE = New System.Windows.Forms.TextBox
        Me.TxtClaveE = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(18, 198)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 20)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Status de Conexión:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnCancE
        '
        Me.BtnCancE.Enabled = False
        Me.BtnCancE.Image = CType(resources.GetObject("BtnCancE.Image"), System.Drawing.Image)
        Me.BtnCancE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancE.Location = New System.Drawing.Point(496, 77)
        Me.BtnCancE.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancE.Name = "BtnCancE"
        Me.BtnCancE.Size = New System.Drawing.Size(182, 60)
        Me.BtnCancE.TabIndex = 73
        Me.BtnCancE.Text = "Cerrar"
        Me.BtnCancE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancE.UseVisualStyleBackColor = True
        '
        'CBStatusE
        '
        Me.CBStatusE.FormattingEnabled = True
        Me.CBStatusE.Items.AddRange(New Object() {"Activado", "Desactivado"})
        Me.CBStatusE.Location = New System.Drawing.Point(176, 195)
        Me.CBStatusE.Margin = New System.Windows.Forms.Padding(4)
        Me.CBStatusE.Name = "CBStatusE"
        Me.CBStatusE.Size = New System.Drawing.Size(180, 24)
        Me.CBStatusE.TabIndex = 72
        '
        'TxtStDescE
        '
        Me.TxtStDescE.AcceptsReturn = True
        Me.TxtStDescE.AcceptsTab = True
        Me.TxtStDescE.Location = New System.Drawing.Point(176, 165)
        Me.TxtStDescE.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStDescE.Name = "TxtStDescE"
        Me.TxtStDescE.ReadOnly = True
        Me.TxtStDescE.Size = New System.Drawing.Size(127, 22)
        Me.TxtStDescE.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(18, 168)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 21)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Conexion Actual:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTurnoE
        '
        Me.TxtTurnoE.AcceptsReturn = True
        Me.TxtTurnoE.AcceptsTab = True
        Me.TxtTurnoE.Location = New System.Drawing.Point(176, 135)
        Me.TxtTurnoE.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTurnoE.Name = "TxtTurnoE"
        Me.TxtTurnoE.ReadOnly = True
        Me.TxtTurnoE.Size = New System.Drawing.Size(127, 22)
        Me.TxtTurnoE.TabIndex = 69
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(18, 138)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 20)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Turno:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtOpeE
        '
        Me.TxtOpeE.AcceptsReturn = True
        Me.TxtOpeE.AcceptsTab = True
        Me.TxtOpeE.Location = New System.Drawing.Point(176, 75)
        Me.TxtOpeE.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtOpeE.Name = "TxtOpeE"
        Me.TxtOpeE.ReadOnly = True
        Me.TxtOpeE.Size = New System.Drawing.Size(223, 22)
        Me.TxtOpeE.TabIndex = 67
        '
        'TxtPlantaE
        '
        Me.TxtPlantaE.AcceptsReturn = True
        Me.TxtPlantaE.AcceptsTab = True
        Me.TxtPlantaE.Location = New System.Drawing.Point(176, 105)
        Me.TxtPlantaE.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPlantaE.Name = "TxtPlantaE"
        Me.TxtPlantaE.ReadOnly = True
        Me.TxtPlantaE.Size = New System.Drawing.Size(223, 22)
        Me.TxtPlantaE.TabIndex = 65
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(18, 108)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 19)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Planta:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(18, 18)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 19)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Clave de Acceso:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnActE
        '
        Me.BtnActE.Enabled = False
        Me.BtnActE.Image = CType(resources.GetObject("BtnActE.Image"), System.Drawing.Image)
        Me.BtnActE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActE.Location = New System.Drawing.Point(496, 9)
        Me.BtnActE.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActE.Name = "BtnActE"
        Me.BtnActE.Size = New System.Drawing.Size(182, 60)
        Me.BtnActE.TabIndex = 62
        Me.BtnActE.Text = "Actualizar"
        Me.BtnActE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnActE.UseVisualStyleBackColor = True
        '
        'TxtUsrE
        '
        Me.TxtUsrE.AcceptsReturn = True
        Me.TxtUsrE.AcceptsTab = True
        Me.TxtUsrE.Location = New System.Drawing.Point(176, 45)
        Me.TxtUsrE.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsrE.Name = "TxtUsrE"
        Me.TxtUsrE.ReadOnly = True
        Me.TxtUsrE.Size = New System.Drawing.Size(223, 22)
        Me.TxtUsrE.TabIndex = 63
        '
        'TxtClaveE
        '
        Me.TxtClaveE.AcceptsReturn = True
        Me.TxtClaveE.AcceptsTab = True
        Me.TxtClaveE.Location = New System.Drawing.Point(176, 15)
        Me.TxtClaveE.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtClaveE.Name = "TxtClaveE"
        Me.TxtClaveE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClaveE.Size = New System.Drawing.Size(139, 22)
        Me.TxtClaveE.TabIndex = 60
        '
        'FrmStatusSAPE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 241)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnCancE)
        Me.Controls.Add(Me.CBStatusE)
        Me.Controls.Add(Me.TxtStDescE)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTurnoE)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtOpeE)
        Me.Controls.Add(Me.TxtPlantaE)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnActE)
        Me.Controls.Add(Me.TxtUsrE)
        Me.Controls.Add(Me.TxtClaveE)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmStatusSAPE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status Conexión SAP Extrusión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnCancE As System.Windows.Forms.Button
    Friend WithEvents CBStatusE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtStDescE As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTurnoE As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtOpeE As System.Windows.Forms.TextBox
    Friend WithEvents TxtPlantaE As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnActE As System.Windows.Forms.Button
    Friend WithEvents TxtUsrE As System.Windows.Forms.TextBox
    Friend WithEvents TxtClaveE As System.Windows.Forms.TextBox
End Class
