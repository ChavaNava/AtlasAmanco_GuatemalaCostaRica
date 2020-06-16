<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiemposAlta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTiemposAlta))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbTiempos = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHorasRegistradas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbConceptoParo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbGpoCausa = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGpoDiametro = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdSeccion = New System.Windows.Forms.TextBox()
        Me.txtSeccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdArea = New System.Windows.Forms.TextBox()
        Me.cmbGpoDiametro = New System.Windows.Forms.ComboBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPuestoTrabajo = New System.Windows.Forms.TextBox()
        Me.cmbPuestoTrabajo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSinOrden = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbTiempos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(64, 18)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 20)
        Me.Label11.TabIndex = 288
        Me.Label11.Text = "Fecha Registro"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.Location = New System.Drawing.Point(209, 47)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(128, 26)
        Me.txtPassword.TabIndex = 2
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(209, 13)
        Me.DTP_FI.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(128, 26)
        Me.DTP_FI.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 20)
        Me.Label1.TabIndex = 291
        Me.Label1.Text = "Contraseña operador"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNombre.Location = New System.Drawing.Point(344, 47)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 10
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(435, 26)
        Me.txtNombre.TabIndex = 292
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.White
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(97, 440)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(240, 49)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(442, 440)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(240, 49)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'gbTiempos
        '
        Me.gbTiempos.Controls.Add(Me.Label13)
        Me.gbTiempos.Controls.Add(Me.txtHorasRegistradas)
        Me.gbTiempos.Controls.Add(Me.Label12)
        Me.gbTiempos.Controls.Add(Me.txtHoras)
        Me.gbTiempos.Controls.Add(Me.Label10)
        Me.gbTiempos.Controls.Add(Me.cmbConceptoParo)
        Me.gbTiempos.Controls.Add(Me.Label9)
        Me.gbTiempos.Controls.Add(Me.cmbGpoCausa)
        Me.gbTiempos.Controls.Add(Me.Label8)
        Me.gbTiempos.Controls.Add(Me.txtGpoDiametro)
        Me.gbTiempos.Controls.Add(Me.txtIdProducto)
        Me.gbTiempos.Controls.Add(Me.txtProducto)
        Me.gbTiempos.Controls.Add(Me.Label7)
        Me.gbTiempos.Controls.Add(Me.txtIdSeccion)
        Me.gbTiempos.Controls.Add(Me.txtSeccion)
        Me.gbTiempos.Controls.Add(Me.Label6)
        Me.gbTiempos.Controls.Add(Me.txtIdArea)
        Me.gbTiempos.Controls.Add(Me.cmbGpoDiametro)
        Me.gbTiempos.Controls.Add(Me.txtArea)
        Me.gbTiempos.Controls.Add(Me.Label5)
        Me.gbTiempos.Controls.Add(Me.txtPuestoTrabajo)
        Me.gbTiempos.Controls.Add(Me.cmbPuestoTrabajo)
        Me.gbTiempos.Controls.Add(Me.Label4)
        Me.gbTiempos.Controls.Add(Me.cbSinOrden)
        Me.gbTiempos.Controls.Add(Me.Label2)
        Me.gbTiempos.Controls.Add(Me.txtOrden)
        Me.gbTiempos.Location = New System.Drawing.Point(0, 80)
        Me.gbTiempos.Name = "gbTiempos"
        Me.gbTiempos.Size = New System.Drawing.Size(792, 354)
        Me.gbTiempos.TabIndex = 323
        Me.gbTiempos.TabStop = False
        Me.gbTiempos.Text = "Registro Tiempos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(476, 298)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(167, 20)
        Me.Label13.TabIndex = 354
        Me.Label13.Text = "Horas Registradas"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHorasRegistradas
        '
        Me.txtHorasRegistradas.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorasRegistradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorasRegistradas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorasRegistradas.Location = New System.Drawing.Point(651, 282)
        Me.txtHorasRegistradas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHorasRegistradas.MaxLength = 10
        Me.txtHorasRegistradas.Name = "txtHorasRegistradas"
        Me.txtHorasRegistradas.ReadOnly = True
        Me.txtHorasRegistradas.Size = New System.Drawing.Size(128, 41)
        Me.txtHorasRegistradas.TabIndex = 353
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(64, 298)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 20)
        Me.Label12.TabIndex = 352
        Me.Label12.Text = "Registro Horas"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHoras
        '
        Me.txtHoras.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoras.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoras.Location = New System.Drawing.Point(209, 282)
        Me.txtHoras.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoras.MaxLength = 10
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(128, 41)
        Me.txtHoras.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(124, 233)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 20)
        Me.Label10.TabIndex = 350
        Me.Label10.Text = "Causa"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbConceptoParo
        '
        Me.cmbConceptoParo.FormattingEnabled = True
        Me.cmbConceptoParo.Location = New System.Drawing.Point(209, 235)
        Me.cmbConceptoParo.Name = "cmbConceptoParo"
        Me.cmbConceptoParo.Size = New System.Drawing.Size(570, 28)
        Me.cmbConceptoParo.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(79, 204)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 20)
        Me.Label9.TabIndex = 347
        Me.Label9.Text = "Gpo. Causas"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbGpoCausa
        '
        Me.cmbGpoCausa.FormattingEnabled = True
        Me.cmbGpoCausa.Location = New System.Drawing.Point(209, 205)
        Me.cmbGpoCausa.Name = "cmbGpoCausa"
        Me.cmbGpoCausa.Size = New System.Drawing.Size(570, 28)
        Me.cmbGpoCausa.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 174)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 20)
        Me.Label8.TabIndex = 344
        Me.Label8.Text = "Gpo. Diametro"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGpoDiametro
        '
        Me.txtGpoDiametro.BackColor = System.Drawing.SystemColors.Window
        Me.txtGpoDiametro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGpoDiametro.Location = New System.Drawing.Point(344, 175)
        Me.txtGpoDiametro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGpoDiametro.MaxLength = 10
        Me.txtGpoDiametro.Name = "txtGpoDiametro"
        Me.txtGpoDiametro.ReadOnly = True
        Me.txtGpoDiametro.Size = New System.Drawing.Size(435, 26)
        Me.txtGpoDiametro.TabIndex = 343
        '
        'txtIdProducto
        '
        Me.txtIdProducto.BackColor = System.Drawing.SystemColors.Window
        Me.txtIdProducto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIdProducto.Location = New System.Drawing.Point(209, 146)
        Me.txtIdProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdProducto.MaxLength = 10
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.ReadOnly = True
        Me.txtIdProducto.Size = New System.Drawing.Size(128, 26)
        Me.txtIdProducto.TabIndex = 7
        '
        'txtProducto
        '
        Me.txtProducto.BackColor = System.Drawing.SystemColors.Window
        Me.txtProducto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProducto.Location = New System.Drawing.Point(344, 146)
        Me.txtProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProducto.MaxLength = 10
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(435, 26)
        Me.txtProducto.TabIndex = 341
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(105, 145)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 340
        Me.Label7.Text = "Producto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIdSeccion
        '
        Me.txtIdSeccion.BackColor = System.Drawing.SystemColors.Window
        Me.txtIdSeccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIdSeccion.Location = New System.Drawing.Point(209, 116)
        Me.txtIdSeccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdSeccion.MaxLength = 10
        Me.txtIdSeccion.Name = "txtIdSeccion"
        Me.txtIdSeccion.ReadOnly = True
        Me.txtIdSeccion.Size = New System.Drawing.Size(128, 26)
        Me.txtIdSeccion.TabIndex = 6
        '
        'txtSeccion
        '
        Me.txtSeccion.BackColor = System.Drawing.SystemColors.Window
        Me.txtSeccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSeccion.Location = New System.Drawing.Point(344, 116)
        Me.txtSeccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSeccion.MaxLength = 10
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.ReadOnly = True
        Me.txtSeccion.Size = New System.Drawing.Size(435, 26)
        Me.txtSeccion.TabIndex = 338
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(111, 115)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 337
        Me.Label6.Text = "Sección"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIdArea
        '
        Me.txtIdArea.BackColor = System.Drawing.SystemColors.Window
        Me.txtIdArea.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIdArea.Location = New System.Drawing.Point(209, 86)
        Me.txtIdArea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdArea.MaxLength = 10
        Me.txtIdArea.Name = "txtIdArea"
        Me.txtIdArea.ReadOnly = True
        Me.txtIdArea.Size = New System.Drawing.Size(128, 26)
        Me.txtIdArea.TabIndex = 5
        '
        'cmbGpoDiametro
        '
        Me.cmbGpoDiametro.FormattingEnabled = True
        Me.cmbGpoDiametro.Location = New System.Drawing.Point(209, 175)
        Me.cmbGpoDiametro.Name = "cmbGpoDiametro"
        Me.cmbGpoDiametro.Size = New System.Drawing.Size(128, 28)
        Me.cmbGpoDiametro.TabIndex = 8
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.SystemColors.Window
        Me.txtArea.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtArea.Location = New System.Drawing.Point(344, 86)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArea.MaxLength = 10
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(435, 26)
        Me.txtArea.TabIndex = 334
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(134, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 333
        Me.Label5.Text = "Area"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPuestoTrabajo
        '
        Me.txtPuestoTrabajo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPuestoTrabajo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPuestoTrabajo.Location = New System.Drawing.Point(344, 55)
        Me.txtPuestoTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPuestoTrabajo.MaxLength = 10
        Me.txtPuestoTrabajo.Name = "txtPuestoTrabajo"
        Me.txtPuestoTrabajo.ReadOnly = True
        Me.txtPuestoTrabajo.Size = New System.Drawing.Size(435, 26)
        Me.txtPuestoTrabajo.TabIndex = 332
        '
        'cmbPuestoTrabajo
        '
        Me.cmbPuestoTrabajo.FormattingEnabled = True
        Me.cmbPuestoTrabajo.Location = New System.Drawing.Point(209, 55)
        Me.cmbPuestoTrabajo.Name = "cmbPuestoTrabajo"
        Me.cmbPuestoTrabajo.Size = New System.Drawing.Size(128, 28)
        Me.cmbPuestoTrabajo.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 20)
        Me.Label4.TabIndex = 330
        Me.Label4.Text = "Puesto Trabajo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSinOrden
        '
        Me.cbSinOrden.AutoSize = True
        Me.cbSinOrden.Location = New System.Drawing.Point(344, 28)
        Me.cbSinOrden.Name = "cbSinOrden"
        Me.cbSinOrden.Size = New System.Drawing.Size(115, 24)
        Me.cbSinOrden.TabIndex = 328
        Me.cbSinOrden.Text = "Sin Orden"
        Me.cbSinOrden.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 20)
        Me.Label2.TabIndex = 326
        Me.Label2.Text = "Orden de Fabricación"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOrden
        '
        Me.txtOrden.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrden.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrden.Location = New System.Drawing.Point(209, 26)
        Me.txtOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrden.MaxLength = 10
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(128, 26)
        Me.txtOrden.TabIndex = 3
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Location = New System.Drawing.Point(689, 15)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(90, 28)
        Me.cmbTurno.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(625, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 330
        Me.Label3.Text = "Turno"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmTiemposAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(798, 501)
        Me.Controls.Add(Me.cmbTurno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbTiempos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_FI)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPassword)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTiemposAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTiemposAlta"
        Me.gbTiempos.ResumeLayout(False)
        Me.gbTiempos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Public WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents gbTiempos As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtHoras As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbConceptoParo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbGpoCausa As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIdProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIdSeccion As System.Windows.Forms.TextBox
    Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdArea As System.Windows.Forms.TextBox
    Friend WithEvents cmbGpoDiametro As System.Windows.Forms.ComboBox
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPuestoTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents cmbPuestoTrabajo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbSinOrden As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtHorasRegistradas As System.Windows.Forms.TextBox
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGpoDiametro As System.Windows.Forms.TextBox
End Class
