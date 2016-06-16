<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPisoPT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPisoPT))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_RegProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.NomCentro = New System.Windows.Forms.TextBox()
        Me.CveOperador = New System.Windows.Forms.TextBox()
        Me.NomOperador = New System.Windows.Forms.TextBox()
        Me.CodOperador = New System.Windows.Forms.TextBox()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.lblCentro = New System.Windows.Forms.Label()
        Me.Centro = New System.Windows.Forms.TextBox()
        Me.cmbTurnos = New System.Windows.Forms.ComboBox()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.TUnidades = New System.Windows.Forms.TextBox()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.TCodMat = New System.Windows.Forms.TextBox()
        Me.TDesMat = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TCodMaq = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TCajas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TKilos = New System.Windows.Forms.TextBox()
        Me.TDesMaq = New System.Windows.Forms.TextBox()
        Me.Btn_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Export = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.Btn_Consulta, Me.ReportesToolStripMenuItem, Me.CalculadoraToolStripMenuItem, Me.Btn_RegProd, Me.Btn_Export})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1212, 29)
        Me.MenuStrip1.TabIndex = 176
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(75, 25)
        Me.ToolStripMenuItem1.Text = "Salir"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.AutoSize = False
        Me.ReportesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.Image = Global.Atlas.My.Resources.Resources.report
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(90, 25)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        Me.ReportesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.AutoSize = False
        Me.CalculadoraToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(110, 25)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'Btn_RegProd
        '
        Me.Btn_RegProd.Image = CType(resources.GetObject("Btn_RegProd.Image"), System.Drawing.Image)
        Me.Btn_RegProd.Name = "Btn_RegProd"
        Me.Btn_RegProd.Size = New System.Drawing.Size(176, 25)
        Me.Btn_RegProd.Text = "Registrar Producción"
        '
        'NomCentro
        '
        Me.NomCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomCentro.Location = New System.Drawing.Point(258, 72)
        Me.NomCentro.Name = "NomCentro"
        Me.NomCentro.ReadOnly = True
        Me.NomCentro.Size = New System.Drawing.Size(374, 22)
        Me.NomCentro.TabIndex = 542
        '
        'CveOperador
        '
        Me.CveOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CveOperador.Location = New System.Drawing.Point(149, 100)
        Me.CveOperador.MaxLength = 10
        Me.CveOperador.Name = "CveOperador"
        Me.CveOperador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CveOperador.Size = New System.Drawing.Size(105, 22)
        Me.CveOperador.TabIndex = 0
        '
        'NomOperador
        '
        Me.NomOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomOperador.Location = New System.Drawing.Point(389, 100)
        Me.NomOperador.Name = "NomOperador"
        Me.NomOperador.ReadOnly = True
        Me.NomOperador.Size = New System.Drawing.Size(243, 22)
        Me.NomOperador.TabIndex = 540
        '
        'CodOperador
        '
        Me.CodOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodOperador.Location = New System.Drawing.Point(258, 100)
        Me.CodOperador.MaxLength = 10
        Me.CodOperador.Name = "CodOperador"
        Me.CodOperador.ReadOnly = True
        Me.CodOperador.Size = New System.Drawing.Size(125, 22)
        Me.CodOperador.TabIndex = 537
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.ForeColor = System.Drawing.Color.Black
        Me.lblClave.Location = New System.Drawing.Point(13, 103)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(133, 16)
        Me.lblClave.TabIndex = 541
        Me.lblClave.Text = "Clave Controlador"
        '
        'lblCentro
        '
        Me.lblCentro.AutoSize = True
        Me.lblCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentro.ForeColor = System.Drawing.Color.Black
        Me.lblCentro.Location = New System.Drawing.Point(93, 75)
        Me.lblCentro.Name = "lblCentro"
        Me.lblCentro.Size = New System.Drawing.Size(53, 16)
        Me.lblCentro.TabIndex = 538
        Me.lblCentro.Text = "Centro"
        '
        'Centro
        '
        Me.Centro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Centro.Location = New System.Drawing.Point(149, 72)
        Me.Centro.Name = "Centro"
        Me.Centro.ReadOnly = True
        Me.Centro.Size = New System.Drawing.Size(105, 22)
        Me.Centro.TabIndex = 539
        '
        'cmbTurnos
        '
        Me.cmbTurnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTurnos.FormattingEnabled = True
        Me.cmbTurnos.Location = New System.Drawing.Point(149, 42)
        Me.cmbTurnos.MaxLength = 15
        Me.cmbTurnos.Name = "cmbTurnos"
        Me.cmbTurnos.Size = New System.Drawing.Size(105, 24)
        Me.cmbTurnos.TabIndex = 530
        '
        'lblTurno
        '
        Me.lblTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.ForeColor = System.Drawing.Color.Black
        Me.lblTurno.Location = New System.Drawing.Point(94, 47)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(51, 17)
        Me.lblTurno.TabIndex = 535
        Me.lblTurno.Text = "Turno"
        '
        'lblOrden
        '
        Me.lblOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrden.ForeColor = System.Drawing.Color.Black
        Me.lblOrden.Location = New System.Drawing.Point(8, 130)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(135, 20)
        Me.lblOrden.TabIndex = 545
        Me.lblOrden.Text = "Orden Producción"
        Me.lblOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TOrden
        '
        Me.TOrden.BackColor = System.Drawing.SystemColors.Window
        Me.TOrden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOrden.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TOrden.Location = New System.Drawing.Point(149, 128)
        Me.TOrden.MaxLength = 12
        Me.TOrden.Name = "TOrden"
        Me.TOrden.Size = New System.Drawing.Size(105, 22)
        Me.TOrden.TabIndex = 1
        '
        'lblcantidad
        '
        Me.lblcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidad.ForeColor = System.Drawing.Color.Black
        Me.lblcantidad.Location = New System.Drawing.Point(299, 130)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(84, 20)
        Me.lblcantidad.TabIndex = 546
        Me.lblcantidad.Text = "Unidades"
        Me.lblcantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TUnidades
        '
        Me.TUnidades.BackColor = System.Drawing.SystemColors.Window
        Me.TUnidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUnidades.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TUnidades.Location = New System.Drawing.Point(389, 129)
        Me.TUnidades.MaxLength = 10
        Me.TUnidades.Name = "TUnidades"
        Me.TUnidades.Size = New System.Drawing.Size(105, 22)
        Me.TUnidades.TabIndex = 2
        Me.TUnidades.Text = "0"
        '
        'lblMaterial
        '
        Me.lblMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterial.ForeColor = System.Drawing.Color.Black
        Me.lblMaterial.Location = New System.Drawing.Point(677, 47)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(78, 17)
        Me.lblMaterial.TabIndex = 569
        Me.lblMaterial.Text = "Material"
        Me.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TCodMat
        '
        Me.TCodMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodMat.Location = New System.Drawing.Point(761, 44)
        Me.TCodMat.Multiline = True
        Me.TCodMat.Name = "TCodMat"
        Me.TCodMat.ReadOnly = True
        Me.TCodMat.Size = New System.Drawing.Size(75, 22)
        Me.TCodMat.TabIndex = 570
        '
        'TDesMat
        '
        Me.TDesMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesMat.Location = New System.Drawing.Point(842, 44)
        Me.TDesMat.Name = "TDesMat"
        Me.TDesMat.ReadOnly = True
        Me.TDesMat.Size = New System.Drawing.Size(358, 22)
        Me.TDesMat.TabIndex = 571
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToOrderColumns = True
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV.Location = New System.Drawing.Point(0, 185)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(1212, 440)
        Me.DGV.TabIndex = 577
        '
        'TCodMaq
        '
        Me.TCodMaq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodMaq.Location = New System.Drawing.Point(761, 72)
        Me.TCodMaq.Multiline = True
        Me.TCodMaq.Name = "TCodMaq"
        Me.TCodMaq.ReadOnly = True
        Me.TCodMaq.Size = New System.Drawing.Size(75, 22)
        Me.TCodMaq.TabIndex = 578
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(672, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 579
        Me.Label1.Text = "Inyectora"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(59, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 582
        Me.Label2.Text = "Cajas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TCajas
        '
        Me.TCajas.BackColor = System.Drawing.SystemColors.Window
        Me.TCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCajas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TCajas.Location = New System.Drawing.Point(149, 156)
        Me.TCajas.MaxLength = 10
        Me.TCajas.Name = "TCajas"
        Me.TCajas.Size = New System.Drawing.Size(105, 22)
        Me.TCajas.TabIndex = 3
        Me.TCajas.Text = "0"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(299, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 584
        Me.Label3.Text = "Kilos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TKilos
        '
        Me.TKilos.BackColor = System.Drawing.SystemColors.Window
        Me.TKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TKilos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TKilos.Location = New System.Drawing.Point(389, 157)
        Me.TKilos.MaxLength = 10
        Me.TKilos.Name = "TKilos"
        Me.TKilos.Size = New System.Drawing.Size(105, 22)
        Me.TKilos.TabIndex = 4
        Me.TKilos.Text = "0.0"
        '
        'TDesMaq
        '
        Me.TDesMaq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesMaq.Location = New System.Drawing.Point(842, 72)
        Me.TDesMaq.Name = "TDesMaq"
        Me.TDesMaq.ReadOnly = True
        Me.TDesMaq.Size = New System.Drawing.Size(358, 22)
        Me.TDesMaq.TabIndex = 580
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.AutoSize = False
        Me.Btn_Consulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Consulta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Consulta.Image = Global.Atlas.My.Resources.Resources.preview
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(94, 25)
        Me.Btn_Consulta.Text = "Consultas"
        '
        'Btn_Export
        '
        Me.Btn_Export.Image = CType(resources.GetObject("Btn_Export.Image"), System.Drawing.Image)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(138, 25)
        Me.Btn_Export.Text = "Exporta a Excel"
        '
        'FrmPisoPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(1212, 625)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TKilos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TCajas)
        Me.Controls.Add(Me.TDesMaq)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TCodMaq)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.lblMaterial)
        Me.Controls.Add(Me.TCodMat)
        Me.Controls.Add(Me.TDesMat)
        Me.Controls.Add(Me.lblOrden)
        Me.Controls.Add(Me.TOrden)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.TUnidades)
        Me.Controls.Add(Me.NomCentro)
        Me.Controls.Add(Me.CveOperador)
        Me.Controls.Add(Me.NomOperador)
        Me.Controls.Add(Me.CodOperador)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.lblCentro)
        Me.Controls.Add(Me.Centro)
        Me.Controls.Add(Me.cmbTurnos)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPisoPT"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NomCentro As System.Windows.Forms.TextBox
    Friend WithEvents CveOperador As System.Windows.Forms.TextBox
    Friend WithEvents NomOperador As System.Windows.Forms.TextBox
    Friend WithEvents CodOperador As System.Windows.Forms.TextBox
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents lblCentro As System.Windows.Forms.Label
    Friend WithEvents Centro As System.Windows.Forms.TextBox
    Friend WithEvents cmbTurnos As System.Windows.Forms.ComboBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents lblOrden As System.Windows.Forms.Label
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents lblcantidad As System.Windows.Forms.Label
    Friend WithEvents TUnidades As System.Windows.Forms.TextBox
    Friend WithEvents lblMaterial As System.Windows.Forms.Label
    Friend WithEvents TCodMat As System.Windows.Forms.TextBox
    Friend WithEvents TDesMat As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_RegProd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TCodMaq As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TCajas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TKilos As System.Windows.Forms.TextBox
    Friend WithEvents TDesMaq As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Export As System.Windows.Forms.ToolStripMenuItem

End Class
