<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatalogUsers
    Inherits Atlas.Catalogos.FrmMaster

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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_Status = New System.Windows.Forms.CheckBox()
        Me.TNumEmp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TTelMovil = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TTelFijo = New System.Windows.Forms.TextBox()
        Me.TEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_Perfil = New System.Windows.Forms.ComboBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TAlias = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.GB_Usuarios = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GB_Usuarios.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(69, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Celular"
        '
        'CB_Status
        '
        Me.CB_Status.AutoSize = True
        Me.CB_Status.Location = New System.Drawing.Point(132, 185)
        Me.CB_Status.Name = "CB_Status"
        Me.CB_Status.Size = New System.Drawing.Size(99, 20)
        Me.CB_Status.TabIndex = 360
        Me.CB_Status.Text = "Habilitado"
        Me.CB_Status.UseVisualStyleBackColor = True
        '
        'TNumEmp
        '
        Me.TNumEmp.Location = New System.Drawing.Point(699, 129)
        Me.TNumEmp.Name = "TNumEmp"
        Me.TNumEmp.Size = New System.Drawing.Size(258, 22)
        Me.TNumEmp.TabIndex = 359
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(575, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 16)
        Me.Label6.TabIndex = 367
        Me.Label6.Text = "Num.Empleado "
        '
        'TTelMovil
        '
        Me.TTelMovil.Location = New System.Drawing.Point(132, 157)
        Me.TTelMovil.Name = "TTelMovil"
        Me.TTelMovil.Size = New System.Drawing.Size(258, 22)
        Me.TTelMovil.TabIndex = 357
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(56, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 366
        Me.Label5.Text = "Telefono"
        '
        'TTelFijo
        '
        Me.TTelFijo.Location = New System.Drawing.Point(132, 129)
        Me.TTelFijo.Name = "TTelFijo"
        Me.TTelFijo.Size = New System.Drawing.Size(258, 22)
        Me.TTelFijo.TabIndex = 358
        '
        'TEmail
        '
        Me.TEmail.Location = New System.Drawing.Point(132, 101)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.Size = New System.Drawing.Size(399, 22)
        Me.TEmail.TabIndex = 355
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(74, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 365
        Me.Label4.Text = "E-mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(569, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 364
        Me.Label3.Text = "Perfil"
        '
        'CB_Perfil
        '
        Me.CB_Perfil.FormattingEnabled = True
        Me.CB_Perfil.Location = New System.Drawing.Point(619, 73)
        Me.CB_Perfil.Name = "CB_Perfil"
        Me.CB_Perfil.Size = New System.Drawing.Size(338, 24)
        Me.CB_Perfil.TabIndex = 356
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(132, 73)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(399, 22)
        Me.TNombre.TabIndex = 354
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(63, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 363
        Me.Label2.Text = "Nombre"
        '
        'TPassword
        '
        Me.TPassword.Location = New System.Drawing.Point(436, 45)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Size = New System.Drawing.Size(521, 22)
        Me.TPassword.TabIndex = 353
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(343, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 362
        Me.Label1.Text = "Contraseña"
        '
        'TAlias
        '
        Me.TAlias.Location = New System.Drawing.Point(132, 45)
        Me.TAlias.Name = "TAlias"
        Me.TAlias.Size = New System.Drawing.Size(205, 22)
        Me.TAlias.TabIndex = 352
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.BackColor = System.Drawing.Color.Transparent
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblProducto.Location = New System.Drawing.Point(25, 48)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(101, 16)
        Me.lblProducto.TabIndex = 361
        Me.lblProducto.Text = "Alias Usuario"
        '
        'GB_Usuarios
        '
        Me.GB_Usuarios.Controls.Add(Me.DGV)
        Me.GB_Usuarios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GB_Usuarios.Location = New System.Drawing.Point(0, 264)
        Me.GB_Usuarios.Name = "GB_Usuarios"
        Me.GB_Usuarios.Size = New System.Drawing.Size(984, 348)
        Me.GB_Usuarios.TabIndex = 369
        Me.GB_Usuarios.TabStop = False
        Me.GB_Usuarios.Text = "Usuarios"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToOrderColumns = True
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(3, 18)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(978, 327)
        Me.DGV.TabIndex = 351
        '
        'CatalogUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.GB_Usuarios)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CB_Status)
        Me.Controls.Add(Me.TNumEmp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TTelMovil)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TTelFijo)
        Me.Controls.Add(Me.TEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_Perfil)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TAlias)
        Me.Controls.Add(Me.lblProducto)
        Me.Name = "CatalogUsers"
        Me.Text = "Form1"
        Me.Controls.SetChildIndex(Me.lblProducto, 0)
        Me.Controls.SetChildIndex(Me.TAlias, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TPassword, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TNombre, 0)
        Me.Controls.SetChildIndex(Me.CB_Perfil, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TEmail, 0)
        Me.Controls.SetChildIndex(Me.TTelFijo, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TTelMovil, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TNumEmp, 0)
        Me.Controls.SetChildIndex(Me.CB_Status, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.GB_Usuarios, 0)
        Me.GB_Usuarios.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CB_Status As System.Windows.Forms.CheckBox
    Friend WithEvents TNumEmp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TTelMovil As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TTelFijo As System.Windows.Forms.TextBox
    Friend WithEvents TEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CB_Perfil As System.Windows.Forms.ComboBox
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TAlias As System.Windows.Forms.TextBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents GB_Usuarios As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
End Class
