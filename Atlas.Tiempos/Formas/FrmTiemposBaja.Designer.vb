<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiemposBaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTiemposBaja))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.txtEquipo = New System.Windows.Forms.TextBox()
        Me.txtTurno = New System.Windows.Forms.TextBox()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdTiempo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(342, 212)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(170, 49)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.White
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(12, 212)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(170, 49)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 33)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Se realizara la baja del siguiente registros, esta de acuerdo ?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fecha Registro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(330, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Turno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Puesto Trabajo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Orden Producción:"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(132, 85)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(107, 22)
        Me.txtFecha.TabIndex = 21
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(388, 85)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.ReadOnly = True
        Me.txtOrden.Size = New System.Drawing.Size(124, 22)
        Me.txtOrden.TabIndex = 22
        '
        'txtEquipo
        '
        Me.txtEquipo.Location = New System.Drawing.Point(132, 113)
        Me.txtEquipo.Name = "txtEquipo"
        Me.txtEquipo.ReadOnly = True
        Me.txtEquipo.Size = New System.Drawing.Size(153, 22)
        Me.txtEquipo.TabIndex = 23
        '
        'txtTurno
        '
        Me.txtTurno.Location = New System.Drawing.Point(388, 113)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.ReadOnly = True
        Me.txtTurno.Size = New System.Drawing.Size(45, 22)
        Me.txtTurno.TabIndex = 24
        '
        'txtHoras
        '
        Me.txtHoras.Location = New System.Drawing.Point(132, 141)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.ReadOnly = True
        Me.txtHoras.Size = New System.Drawing.Size(77, 22)
        Me.txtHoras.TabIndex = 25
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(132, 169)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ReadOnly = True
        Me.txtConcepto.Size = New System.Drawing.Size(380, 22)
        Me.txtConcepto.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Horas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Concepto Paro:"
        '
        'txtIdTiempo
        '
        Me.txtIdTiempo.Location = New System.Drawing.Point(132, 57)
        Me.txtIdTiempo.Name = "txtIdTiempo"
        Me.txtIdTiempo.ReadOnly = True
        Me.txtIdTiempo.Size = New System.Drawing.Size(77, 22)
        Me.txtIdTiempo.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(79, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Folio:"
        '
        'FrmTiemposBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(524, 273)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIdTiempo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.txtTurno)
        Me.Controls.Add(Me.txtEquipo)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTiemposBaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTiemposBaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtEquipo As System.Windows.Forms.TextBox
    Friend WithEvents txtTurno As System.Windows.Forms.TextBox
    Friend WithEvents txtHoras As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIdTiempo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
