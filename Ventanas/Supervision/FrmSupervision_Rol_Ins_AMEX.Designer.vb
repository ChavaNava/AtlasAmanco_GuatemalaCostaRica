<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupervision_Rol_Ins_AMEX
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupervision_Rol_Ins_AMEX))
        Me.CB_Sup = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CB_Turno = New System.Windows.Forms.ComboBox
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnPost = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CB_Sup
        '
        Me.CB_Sup.FormattingEnabled = True
        Me.CB_Sup.Location = New System.Drawing.Point(112, 13)
        Me.CB_Sup.Name = "CB_Sup"
        Me.CB_Sup.Size = New System.Drawing.Size(401, 24)
        Me.CB_Sup.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Supervisor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Turno"
        '
        'CB_Turno
        '
        Me.CB_Turno.FormattingEnabled = True
        Me.CB_Turno.Location = New System.Drawing.Point(112, 44)
        Me.CB_Turno.Name = "CB_Turno"
        Me.CB_Turno.Size = New System.Drawing.Size(130, 24)
        Me.CB_Turno.TabIndex = 8
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(383, 43)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(130, 22)
        Me.DTP_FI.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha"
        '
        'BtnPost
        '
        Me.BtnPost.Image = CType(resources.GetObject("BtnPost.Image"), System.Drawing.Image)
        Me.BtnPost.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPost.Location = New System.Drawing.Point(553, 12)
        Me.BtnPost.Name = "BtnPost"
        Me.BtnPost.Size = New System.Drawing.Size(137, 23)
        Me.BtnPost.TabIndex = 12
        Me.BtnPost.Text = "Guardar"
        Me.BtnPost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPost.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.Location = New System.Drawing.Point(553, 41)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(137, 23)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FrmSupervision_Rol_Ins_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 87)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnPost)
        Me.Controls.Add(Me.DTP_FI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_Turno)
        Me.Controls.Add(Me.CB_Sup)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSupervision_Rol_Ins_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Ingresa Rol de Supervisor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_Sup As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CB_Turno As System.Windows.Forms.ComboBox
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnPost As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
