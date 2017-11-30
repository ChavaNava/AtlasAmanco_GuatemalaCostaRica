<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminODF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdminODF))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Btn_Cerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaODPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaODP = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciaODP = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalizaODP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReactivarODF = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarODPDeSAPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizaODPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Export = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV_ODF = New System.Windows.Forms.DataGridView()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.pgbAvance = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Avance_Consulta = New System.ComponentModel.BackgroundWorker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBContador = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_ODF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Cerrar, Me.Btn_Consulta, Me.NuevaODPToolStripMenuItem, Me.ModificaODP, Me.IniciaODP, Me.FinalizaODP, Me.ReactivarODF, Me.ImportarODPDeSAPToolStripMenuItem, Me.ActualizaODPToolStripMenuItem, Me.Btn_Export})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1372, 31)
        Me.MenuStrip1.TabIndex = 68
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Image = CType(resources.GetObject("Btn_Cerrar.Image"), System.Drawing.Image)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(89, 27)
        Me.Btn_Cerrar.Text = "Cerrar"
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = CType(resources.GetObject("Btn_Consulta.Image"), System.Drawing.Image)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(109, 27)
        Me.Btn_Consulta.Text = "Consulta"
        '
        'NuevaODPToolStripMenuItem
        '
        Me.NuevaODPToolStripMenuItem.Image = Global.Atlas.My.Resources.Resources.Btn_Nuevo
        Me.NuevaODPToolStripMenuItem.Name = "NuevaODPToolStripMenuItem"
        Me.NuevaODPToolStripMenuItem.Size = New System.Drawing.Size(132, 27)
        Me.NuevaODPToolStripMenuItem.Text = "Nueva ODP"
        '
        'ModificaODP
        '
        Me.ModificaODP.Image = Global.Atlas.My.Resources.Resources.Btn_Modifica
        Me.ModificaODP.Name = "ModificaODP"
        Me.ModificaODP.Size = New System.Drawing.Size(148, 27)
        Me.ModificaODP.Text = "Modifica ODF"
        '
        'IniciaODP
        '
        Me.IniciaODP.Image = Global.Atlas.My.Resources.Resources.Fabricacion_01
        Me.IniciaODP.Name = "IniciaODP"
        Me.IniciaODP.Size = New System.Drawing.Size(121, 27)
        Me.IniciaODP.Text = "Inicia ODF"
        '
        'FinalizaODP
        '
        Me.FinalizaODP.Image = Global.Atlas.My.Resources.Resources.Btn_Elimina
        Me.FinalizaODP.Name = "FinalizaODP"
        Me.FinalizaODP.Size = New System.Drawing.Size(138, 27)
        Me.FinalizaODP.Text = "Finaliza ODF"
        '
        'ReactivarODF
        '
        Me.ReactivarODF.Image = Global.Atlas.My.Resources.Resources.Reactivar
        Me.ReactivarODF.Name = "ReactivarODF"
        Me.ReactivarODF.Size = New System.Drawing.Size(152, 27)
        Me.ReactivarODF.Text = "Reactivar ODF"
        '
        'ImportarODPDeSAPToolStripMenuItem
        '
        Me.ImportarODPDeSAPToolStripMenuItem.Image = Global.Atlas.My.Resources.Resources.Import_01
        Me.ImportarODPDeSAPToolStripMenuItem.Name = "ImportarODPDeSAPToolStripMenuItem"
        Me.ImportarODPDeSAPToolStripMenuItem.Size = New System.Drawing.Size(208, 27)
        Me.ImportarODPDeSAPToolStripMenuItem.Text = "Importar ODP de SAP"
        '
        'ActualizaODPToolStripMenuItem
        '
        Me.ActualizaODPToolStripMenuItem.Image = Global.Atlas.My.Resources.Resources.Actualiza_02
        Me.ActualizaODPToolStripMenuItem.Name = "ActualizaODPToolStripMenuItem"
        Me.ActualizaODPToolStripMenuItem.Size = New System.Drawing.Size(151, 27)
        Me.ActualizaODPToolStripMenuItem.Text = "Actualiza ODP"
        '
        'Btn_Export
        '
        Me.Btn_Export.Image = CType(resources.GetObject("Btn_Export.Image"), System.Drawing.Image)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(159, 27)
        Me.Btn_Export.Text = "Exporta a Excel"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1372, 359)
        Me.Panel1.TabIndex = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_ODF)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1372, 359)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenes de Producción"
        '
        'DGV_ODF
        '
        Me.DGV_ODF.AllowUserToAddRows = False
        Me.DGV_ODF.AllowUserToDeleteRows = False
        Me.DGV_ODF.AllowUserToOrderColumns = True
        Me.DGV_ODF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_ODF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_ODF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ODF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_ODF.Location = New System.Drawing.Point(3, 22)
        Me.DGV_ODF.Name = "DGV_ODF"
        Me.DGV_ODF.ReadOnly = True
        Me.DGV_ODF.Size = New System.Drawing.Size(1366, 334)
        Me.DGV_ODF.TabIndex = 0
        '
        'TOrden
        '
        Me.TOrden.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TOrden.Location = New System.Drawing.Point(307, 44)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.Size = New System.Drawing.Size(110, 26)
        Me.TOrden.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 20)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Orden Fabricación:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Fecha Fin Orden:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 20)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Fecha Inicio Orden:"
        '
        'DTP2
        '
        Me.DTP2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTP2.CustomFormat = "yyyy-MM-dd"
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP2.Location = New System.Drawing.Point(307, 103)
        Me.DTP2.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(110, 26)
        Me.DTP2.TabIndex = 71
        '
        'DTP1
        '
        Me.DTP1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTP1.CustomFormat = "yyyy-MM-dd"
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(307, 73)
        Me.DTP1.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(110, 26)
        Me.DTP1.TabIndex = 70
        '
        'pgbAvance
        '
        Me.pgbAvance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgbAvance.Location = New System.Drawing.Point(381, 109)
        Me.pgbAvance.Name = "pgbAvance"
        Me.pgbAvance.Size = New System.Drawing.Size(707, 24)
        Me.pgbAvance.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbAvance.TabIndex = 91
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(381, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(707, 28)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'Avance_Consulta
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(939, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 20)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Ordenes Leidas:"
        '
        'LBContador
        '
        Me.LBContador.AutoSize = True
        Me.LBContador.Location = New System.Drawing.Point(1119, 117)
        Me.LBContador.Name = "LBContador"
        Me.LBContador.Size = New System.Drawing.Size(0, 20)
        Me.LBContador.TabIndex = 93
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(939, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1119, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 20)
        Me.Label7.TabIndex = 95
        '
        'FrmAdminODF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1372, 505)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LBContador)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pgbAvance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TOrden)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTP2)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdminODF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Ordenes de Fabricación Extrusión"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_ODF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Export As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_ODF As System.Windows.Forms.DataGridView
    Friend WithEvents ImportarODPDeSAPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaODPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificaODP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalizaODP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReactivarODF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ActualizaODPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pgbAvance As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Avance_Consulta As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBContador As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IniciaODP As System.Windows.Forms.ToolStripMenuItem
End Class
