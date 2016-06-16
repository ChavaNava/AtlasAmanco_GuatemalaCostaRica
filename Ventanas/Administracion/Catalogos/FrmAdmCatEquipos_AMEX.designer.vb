<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmCatEquipos_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmCatEquipos_AMEX))
        Me.txtSobrepeso = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCapacidad = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.rbtInyeccion = New System.Windows.Forms.RadioButton
        Me.rbtExtrusion = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtModelo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMarca = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tsbPrincipal = New System.Windows.Forms.ToolStrip
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton
        Me.pnlXxx = New System.Windows.Forms.Panel
        Me.Tgrpmaterial = New System.Windows.Forms.TextBox
        Me.TNomgrpmaterial = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnLookGrMaterial = New System.Windows.Forms.Button
        Me.btnLookSeccion = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TNomSeccion = New System.Windows.Forms.TextBox
        Me.TSeccion = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnLookArea = New System.Windows.Forms.Button
        Me.TNomArea = New System.Windows.Forms.TextBox
        Me.TArea = New System.Windows.Forms.TextBox
        Me.pnlConsulta = New System.Windows.Forms.Panel
        Me.DGV_EQP = New System.Windows.Forms.DataGridView
        Me.tsbPrincipal.SuspendLayout()
        Me.pnlXxx.SuspendLayout()
        Me.pnlConsulta.SuspendLayout()
        CType(Me.DGV_EQP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSobrepeso
        '
        Me.txtSobrepeso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSobrepeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSobrepeso.Location = New System.Drawing.Point(346, 184)
        Me.txtSobrepeso.MaxLength = 15
        Me.txtSobrepeso.Name = "txtSobrepeso"
        Me.txtSobrepeso.Size = New System.Drawing.Size(109, 16)
        Me.txtSobrepeso.TabIndex = 145
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(246, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Limite Sobrepeso:"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidad.Location = New System.Drawing.Point(100, 182)
        Me.txtCapacidad.MaxLength = 15
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(109, 16)
        Me.txtCapacidad.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Capacidad:"
        '
        'chkActivo
        '
        Me.chkActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkActivo.Location = New System.Drawing.Point(590, 183)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(53, 17)
        Me.chkActivo.TabIndex = 4
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(100, 16)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(109, 16)
        Me.txtCodigo.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(359, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 154
        Me.Label8.Text = "Tipo Equipo:"
        '
        'rbtInyeccion
        '
        Me.rbtInyeccion.AutoSize = True
        Me.rbtInyeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtInyeccion.Location = New System.Drawing.Point(563, 12)
        Me.rbtInyeccion.Name = "rbtInyeccion"
        Me.rbtInyeccion.Size = New System.Drawing.Size(80, 17)
        Me.rbtInyeccion.TabIndex = 153
        Me.rbtInyeccion.Text = "Inyección"
        Me.rbtInyeccion.UseVisualStyleBackColor = True
        '
        'rbtExtrusion
        '
        Me.rbtExtrusion.AutoSize = True
        Me.rbtExtrusion.Checked = True
        Me.rbtExtrusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtExtrusion.Location = New System.Drawing.Point(467, 13)
        Me.rbtExtrusion.Name = "rbtExtrusion"
        Me.rbtExtrusion.Size = New System.Drawing.Size(77, 17)
        Me.rbtExtrusion.TabIndex = 152
        Me.rbtExtrusion.TabStop = True
        Me.rbtExtrusion.Text = "Extrusión"
        Me.rbtExtrusion.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(49, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Modelo:"
        '
        'txtModelo
        '
        Me.txtModelo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(99, 90)
        Me.txtModelo.MaxLength = 80
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(710, 16)
        Me.txtModelo.TabIndex = 150
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Marca:"
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(100, 66)
        Me.txtMarca.MaxLength = 80
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(710, 16)
        Me.txtMarca.TabIndex = 147
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(531, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Estado:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(100, 42)
        Me.txtDescripcion.MaxLength = 80
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(710, 16)
        Me.txtDescripcion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Equipo:"
        '
        'tsbPrincipal
        '
        Me.tsbPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tsbPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCerrar, Me.ToolStripSeparator1, Me.tsbConsultar, Me.ToolStripSeparator5, Me.tsbGrabar, Me.ToolStripSeparator7, Me.tsbModificar})
        Me.tsbPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsbPrincipal.Name = "tsbPrincipal"
        Me.tsbPrincipal.Size = New System.Drawing.Size(906, 25)
        Me.tsbPrincipal.TabIndex = 221
        Me.tsbPrincipal.Text = "ToolStrip1"
        '
        'tsbCerrar
        '
        Me.tsbCerrar.AutoSize = False
        Me.tsbCerrar.Image = CType(resources.GetObject("tsbCerrar.Image"), System.Drawing.Image)
        Me.tsbCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCerrar.Name = "tsbCerrar"
        Me.tsbCerrar.Size = New System.Drawing.Size(70, 22)
        Me.tsbCerrar.Text = "Cerrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbConsultar
        '
        Me.tsbConsultar.Image = CType(resources.GetObject("tsbConsultar.Image"), System.Drawing.Image)
        Me.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultar.Name = "tsbConsultar"
        Me.tsbConsultar.Size = New System.Drawing.Size(78, 22)
        Me.tsbConsultar.Text = "Consultar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Image = CType(resources.GetObject("tsbGrabar.Image"), System.Drawing.Image)
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(115, 22)
        Me.tsbGrabar.Text = "Agregar Registro"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tsbModificar
        '
        Me.tsbModificar.Image = CType(resources.GetObject("tsbModificar.Image"), System.Drawing.Image)
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(78, 22)
        Me.tsbModificar.Text = "Modificar"
        '
        'pnlXxx
        '
        Me.pnlXxx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlXxx.BackColor = System.Drawing.Color.Lavender
        Me.pnlXxx.Controls.Add(Me.Tgrpmaterial)
        Me.pnlXxx.Controls.Add(Me.TNomgrpmaterial)
        Me.pnlXxx.Controls.Add(Me.Label11)
        Me.pnlXxx.Controls.Add(Me.btnLookGrMaterial)
        Me.pnlXxx.Controls.Add(Me.btnLookSeccion)
        Me.pnlXxx.Controls.Add(Me.Label10)
        Me.pnlXxx.Controls.Add(Me.TNomSeccion)
        Me.pnlXxx.Controls.Add(Me.TSeccion)
        Me.pnlXxx.Controls.Add(Me.Label9)
        Me.pnlXxx.Controls.Add(Me.btnLookArea)
        Me.pnlXxx.Controls.Add(Me.TNomArea)
        Me.pnlXxx.Controls.Add(Me.TArea)
        Me.pnlXxx.Controls.Add(Me.chkActivo)
        Me.pnlXxx.Controls.Add(Me.Label3)
        Me.pnlXxx.Controls.Add(Me.Label8)
        Me.pnlXxx.Controls.Add(Me.txtDescripcion)
        Me.pnlXxx.Controls.Add(Me.rbtInyeccion)
        Me.pnlXxx.Controls.Add(Me.Label2)
        Me.pnlXxx.Controls.Add(Me.rbtExtrusion)
        Me.pnlXxx.Controls.Add(Me.txtCodigo)
        Me.pnlXxx.Controls.Add(Me.Label7)
        Me.pnlXxx.Controls.Add(Me.Label1)
        Me.pnlXxx.Controls.Add(Me.txtModelo)
        Me.pnlXxx.Controls.Add(Me.txtCapacidad)
        Me.pnlXxx.Controls.Add(Me.Label6)
        Me.pnlXxx.Controls.Add(Me.Label4)
        Me.pnlXxx.Controls.Add(Me.Label5)
        Me.pnlXxx.Controls.Add(Me.txtSobrepeso)
        Me.pnlXxx.Controls.Add(Me.txtMarca)
        Me.pnlXxx.Location = New System.Drawing.Point(3, 28)
        Me.pnlXxx.Name = "pnlXxx"
        Me.pnlXxx.Size = New System.Drawing.Size(898, 228)
        Me.pnlXxx.TabIndex = 222
        '
        'Tgrpmaterial
        '
        Me.Tgrpmaterial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tgrpmaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tgrpmaterial.Location = New System.Drawing.Point(100, 157)
        Me.Tgrpmaterial.MaxLength = 10
        Me.Tgrpmaterial.Name = "Tgrpmaterial"
        Me.Tgrpmaterial.Size = New System.Drawing.Size(109, 15)
        Me.Tgrpmaterial.TabIndex = 241
        '
        'TNomgrpmaterial
        '
        Me.TNomgrpmaterial.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TNomgrpmaterial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNomgrpmaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNomgrpmaterial.Location = New System.Drawing.Point(250, 157)
        Me.TNomgrpmaterial.Name = "TNomgrpmaterial"
        Me.TNomgrpmaterial.ReadOnly = True
        Me.TNomgrpmaterial.Size = New System.Drawing.Size(560, 15)
        Me.TNomgrpmaterial.TabIndex = 242
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 243
        Me.Label11.Text = "Grp. Diametro:"
        '
        'btnLookGrMaterial
        '
        Me.btnLookGrMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLookGrMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookGrMaterial.Image = CType(resources.GetObject("btnLookGrMaterial.Image"), System.Drawing.Image)
        Me.btnLookGrMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLookGrMaterial.Location = New System.Drawing.Point(220, 156)
        Me.btnLookGrMaterial.Name = "btnLookGrMaterial"
        Me.btnLookGrMaterial.Size = New System.Drawing.Size(24, 16)
        Me.btnLookGrMaterial.TabIndex = 244
        Me.btnLookGrMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLookGrMaterial.UseVisualStyleBackColor = True
        '
        'btnLookSeccion
        '
        Me.btnLookSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLookSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookSeccion.Image = CType(resources.GetObject("btnLookSeccion.Image"), System.Drawing.Image)
        Me.btnLookSeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLookSeccion.Location = New System.Drawing.Point(219, 134)
        Me.btnLookSeccion.Name = "btnLookSeccion"
        Me.btnLookSeccion.Size = New System.Drawing.Size(24, 16)
        Me.btnLookSeccion.TabIndex = 238
        Me.btnLookSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLookSeccion.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 237
        Me.Label10.Text = "Sección:"
        '
        'TNomSeccion
        '
        Me.TNomSeccion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TNomSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNomSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNomSeccion.Location = New System.Drawing.Point(249, 135)
        Me.TNomSeccion.Name = "TNomSeccion"
        Me.TNomSeccion.ReadOnly = True
        Me.TNomSeccion.Size = New System.Drawing.Size(561, 15)
        Me.TNomSeccion.TabIndex = 236
        '
        'TSeccion
        '
        Me.TSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSeccion.Location = New System.Drawing.Point(100, 136)
        Me.TSeccion.MaxLength = 10
        Me.TSeccion.Name = "TSeccion"
        Me.TSeccion.Size = New System.Drawing.Size(109, 15)
        Me.TSeccion.TabIndex = 235
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(61, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 233
        Me.Label9.Text = "Area:"
        '
        'btnLookArea
        '
        Me.btnLookArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLookArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookArea.Image = CType(resources.GetObject("btnLookArea.Image"), System.Drawing.Image)
        Me.btnLookArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLookArea.Location = New System.Drawing.Point(218, 113)
        Me.btnLookArea.Name = "btnLookArea"
        Me.btnLookArea.Size = New System.Drawing.Size(25, 17)
        Me.btnLookArea.TabIndex = 234
        Me.btnLookArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLookArea.UseVisualStyleBackColor = True
        '
        'TNomArea
        '
        Me.TNomArea.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TNomArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNomArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNomArea.Location = New System.Drawing.Point(249, 114)
        Me.TNomArea.Name = "TNomArea"
        Me.TNomArea.ReadOnly = True
        Me.TNomArea.Size = New System.Drawing.Size(561, 15)
        Me.TNomArea.TabIndex = 232
        '
        'TArea
        '
        Me.TArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TArea.Location = New System.Drawing.Point(100, 114)
        Me.TArea.MaxLength = 10
        Me.TArea.Name = "TArea"
        Me.TArea.Size = New System.Drawing.Size(109, 15)
        Me.TArea.TabIndex = 231
        '
        'pnlConsulta
        '
        Me.pnlConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConsulta.Controls.Add(Me.DGV_EQP)
        Me.pnlConsulta.Location = New System.Drawing.Point(3, 262)
        Me.pnlConsulta.Name = "pnlConsulta"
        Me.pnlConsulta.Size = New System.Drawing.Size(898, 258)
        Me.pnlConsulta.TabIndex = 223
        '
        'DGV_EQP
        '
        Me.DGV_EQP.AllowUserToAddRows = False
        Me.DGV_EQP.AllowUserToDeleteRows = False
        Me.DGV_EQP.AllowUserToOrderColumns = True
        Me.DGV_EQP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_EQP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_EQP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_EQP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_EQP.Location = New System.Drawing.Point(0, 0)
        Me.DGV_EQP.Name = "DGV_EQP"
        Me.DGV_EQP.ReadOnly = True
        Me.DGV_EQP.Size = New System.Drawing.Size(896, 256)
        Me.DGV_EQP.TabIndex = 0
        '
        'FrmAdmCatEquipos_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(906, 523)
        Me.Controls.Add(Me.pnlConsulta)
        Me.Controls.Add(Me.pnlXxx)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdmCatEquipos_AMEX"
        Me.Text = "Catalogo EQUIPOS"
        Me.tsbPrincipal.ResumeLayout(False)
        Me.tsbPrincipal.PerformLayout()
        Me.pnlXxx.ResumeLayout(False)
        Me.pnlXxx.PerformLayout()
        Me.pnlConsulta.ResumeLayout(False)
        CType(Me.DGV_EQP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSobrepeso As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbtInyeccion As System.Windows.Forms.RadioButton
    Friend WithEvents rbtExtrusion As System.Windows.Forms.RadioButton
    Friend WithEvents tsbPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlXxx As System.Windows.Forms.Panel
    Friend WithEvents pnlConsulta As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnLookArea As System.Windows.Forms.Button
    Friend WithEvents TNomArea As System.Windows.Forms.TextBox
    Friend WithEvents TArea As System.Windows.Forms.TextBox
    Friend WithEvents btnLookSeccion As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TNomSeccion As System.Windows.Forms.TextBox
    Friend WithEvents TSeccion As System.Windows.Forms.TextBox
    Friend WithEvents Tgrpmaterial As System.Windows.Forms.TextBox
    Friend WithEvents TNomgrpmaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnLookGrMaterial As System.Windows.Forms.Button
    Friend WithEvents DGV_EQP As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
End Class
