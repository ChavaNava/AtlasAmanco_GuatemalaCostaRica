<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCtrlODF_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCtrlODF_AMEX))
        Me.TProg = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tord = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.CB_Lineas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Producto = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TProg
        '
        Me.TProg.Location = New System.Drawing.Point(160, 38)
        Me.TProg.Name = "TProg"
        Me.TProg.Size = New System.Drawing.Size(147, 20)
        Me.TProg.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(90, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 15)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Cantidad Programa"
        '
        'TxtFecha
        '
        Me.TxtFecha.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFecha.Location = New System.Drawing.Point(491, 8)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(107, 20)
        Me.TxtFecha.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(400, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Fecha Inicio"
        '
        'Tord
        '
        Me.Tord.BackColor = System.Drawing.SystemColors.Window
        Me.Tord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tord.Location = New System.Drawing.Point(160, 12)
        Me.Tord.Name = "Tord"
        Me.Tord.Size = New System.Drawing.Size(147, 20)
        Me.Tord.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 15)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Orden de Fabricación"
        '
        'BCancelar
        '
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.Image = CType(resources.GetObject("BCancelar.Image"), System.Drawing.Image)
        Me.BCancelar.Location = New System.Drawing.Point(376, 144)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(132, 57)
        Me.BCancelar.TabIndex = 6
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAceptar.Image = CType(resources.GetObject("BAceptar.Image"), System.Drawing.Image)
        Me.BAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAceptar.Location = New System.Drawing.Point(139, 144)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(132, 57)
        Me.BAceptar.TabIndex = 5
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'CB_Lineas
        '
        Me.CB_Lineas.FormattingEnabled = True
        Me.CB_Lineas.Location = New System.Drawing.Point(160, 64)
        Me.CB_Lineas.Name = "CB_Lineas"
        Me.CB_Lineas.Size = New System.Drawing.Size(438, 21)
        Me.CB_Lineas.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 321
        Me.Label1.Text = "Linea Producción"
        '
        'CB_Producto
        '
        Me.CB_Producto.FormattingEnabled = True
        Me.CB_Producto.Location = New System.Drawing.Point(160, 91)
        Me.CB_Producto.Name = "CB_Producto"
        Me.CB_Producto.Size = New System.Drawing.Size(438, 21)
        Me.CB_Producto.TabIndex = 4
        '
        'FrmCtrlODF_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 209)
        Me.Controls.Add(Me.CB_Producto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_Lineas)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.TProg)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tord)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCtrlODF_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Orden de Fabricación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TProg As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tord As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents CB_Lineas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CB_Producto As System.Windows.Forms.ComboBox
End Class
