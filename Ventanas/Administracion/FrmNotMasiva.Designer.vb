<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotMasiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotMasiva))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBFolio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.RB_SC = New System.Windows.Forms.RadioButton()
        Me.RB_PT = New System.Windows.Forms.RadioButton()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTPNotiMasiva = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GB_Notifica = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalxPeriodo = New System.Windows.Forms.Label()
        Me.BtnNotPeriodo = New System.Windows.Forms.Button()
        Me.rbNotCierrePer = New System.Windows.Forms.RadioButton()
        Me.rbPerActualPer = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsImagen = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pgbAvance = New System.Windows.Forms.ProgressBar()
        Me.Avance_Notifica = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Notifica.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.TBFolio)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.TOrden)
        Me.GroupBox5.Controls.Add(Me.RB_SC)
        Me.GroupBox5.Controls.Add(Me.RB_PT)
        Me.GroupBox5.Controls.Add(Me.DTP2)
        Me.GroupBox5.Controls.Add(Me.DTP1)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.BtnConsulta)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox5.Size = New System.Drawing.Size(311, 288)
        Me.GroupBox5.TabIndex = 64
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Periodo a Notificar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Folio:"
        '
        'TBFolio
        '
        Me.TBFolio.Location = New System.Drawing.Point(163, 105)
        Me.TBFolio.Name = "TBFolio"
        Me.TBFolio.Size = New System.Drawing.Size(130, 22)
        Me.TBFolio.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Orden Producción:"
        '
        'TOrden
        '
        Me.TOrden.Location = New System.Drawing.Point(163, 77)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.Size = New System.Drawing.Size(130, 22)
        Me.TOrden.TabIndex = 76
        '
        'RB_SC
        '
        Me.RB_SC.AutoSize = True
        Me.RB_SC.Location = New System.Drawing.Point(23, 180)
        Me.RB_SC.Name = "RB_SC"
        Me.RB_SC.Size = New System.Drawing.Size(67, 20)
        Me.RB_SC.TabIndex = 75
        Me.RB_SC.Text = "Scrap"
        Me.RB_SC.UseVisualStyleBackColor = True
        '
        'RB_PT
        '
        Me.RB_PT.AutoSize = True
        Me.RB_PT.Checked = True
        Me.RB_PT.Location = New System.Drawing.Point(23, 154)
        Me.RB_PT.Name = "RB_PT"
        Me.RB_PT.Size = New System.Drawing.Size(167, 20)
        Me.RB_PT.TabIndex = 74
        Me.RB_PT.TabStop = True
        Me.RB_PT.Text = "Producto Terminado"
        Me.RB_PT.UseVisualStyleBackColor = True
        '
        'DTP2
        '
        Me.DTP2.CustomFormat = "yyyy/MM/dd"
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP2.Location = New System.Drawing.Point(163, 49)
        Me.DTP2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(130, 22)
        Me.DTP2.TabIndex = 71
        '
        'DTP1
        '
        Me.DTP1.CustomFormat = "yyyy/MM/dd"
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(163, 21)
        Me.DTP1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(130, 22)
        Me.DTP1.TabIndex = 70
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 52)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Fecha Fin:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 22)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Fecha Inicio:"
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsulta.Image = CType(resources.GetObject("BtnConsulta.Image"), System.Drawing.Image)
        Me.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsulta.Location = New System.Drawing.Point(72, 232)
        Me.BtnConsulta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(140, 27)
        Me.BtnConsulta.TabIndex = 69
        Me.BtnConsulta.Text = "Consulta"
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(429, 117)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(178, 13)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Fecha de Contabilización SAP"
        Me.Label12.Visible = False
        '
        'DTPNotiMasiva
        '
        Me.DTPNotiMasiva.CustomFormat = "yyyy/MM/dd"
        Me.DTPNotiMasiva.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPNotiMasiva.Location = New System.Drawing.Point(621, 110)
        Me.DTPNotiMasiva.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DTPNotiMasiva.Name = "DTPNotiMasiva"
        Me.DTPNotiMasiva.Size = New System.Drawing.Size(121, 22)
        Me.DTPNotiMasiva.TabIndex = 78
        Me.DTPNotiMasiva.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox1.Image = Global.Atlas.My.Resources.Resources.mexichem3
        Me.PictureBox1.Location = New System.Drawing.Point(377, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(497, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'GB_Notifica
        '
        Me.GB_Notifica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Notifica.Controls.Add(Me.Label4)
        Me.GB_Notifica.Controls.Add(Me.Label3)
        Me.GB_Notifica.Controls.Add(Me.Label1)
        Me.GB_Notifica.Controls.Add(Me.lblTotalxPeriodo)
        Me.GB_Notifica.Controls.Add(Me.BtnNotPeriodo)
        Me.GB_Notifica.Controls.Add(Me.rbNotCierrePer)
        Me.GB_Notifica.Controls.Add(Me.rbPerActualPer)
        Me.GB_Notifica.Enabled = False
        Me.GB_Notifica.Location = New System.Drawing.Point(942, 3)
        Me.GB_Notifica.Name = "GB_Notifica"
        Me.GB_Notifica.Size = New System.Drawing.Size(244, 288)
        Me.GB_Notifica.TabIndex = 81
        Me.GB_Notifica.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Registro Notificados:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 82
        '
        'lblTotalxPeriodo
        '
        Me.lblTotalxPeriodo.AutoSize = True
        Me.lblTotalxPeriodo.Location = New System.Drawing.Point(47, 213)
        Me.lblTotalxPeriodo.Name = "lblTotalxPeriodo"
        Me.lblTotalxPeriodo.Size = New System.Drawing.Size(145, 16)
        Me.lblTotalxPeriodo.TabIndex = 81
        Me.lblTotalxPeriodo.Text = "Total de Registros: "
        '
        'BtnNotPeriodo
        '
        Me.BtnNotPeriodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNotPeriodo.Image = CType(resources.GetObject("BtnNotPeriodo.Image"), System.Drawing.Image)
        Me.BtnNotPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotPeriodo.Location = New System.Drawing.Point(50, 112)
        Me.BtnNotPeriodo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnNotPeriodo.Name = "BtnNotPeriodo"
        Me.BtnNotPeriodo.Size = New System.Drawing.Size(140, 27)
        Me.BtnNotPeriodo.TabIndex = 64
        Me.BtnNotPeriodo.Text = "Notificar"
        Me.BtnNotPeriodo.UseVisualStyleBackColor = True
        '
        'rbNotCierrePer
        '
        Me.rbNotCierrePer.AutoSize = True
        Me.rbNotCierrePer.Location = New System.Drawing.Point(50, 50)
        Me.rbNotCierrePer.Name = "rbNotCierrePer"
        Me.rbNotCierrePer.Size = New System.Drawing.Size(156, 20)
        Me.rbNotCierrePer.TabIndex = 78
        Me.rbNotCierrePer.TabStop = True
        Me.rbNotCierrePer.Text = "Notificación cierre."
        Me.rbNotCierrePer.UseVisualStyleBackColor = True
        '
        'rbPerActualPer
        '
        Me.rbPerActualPer.AutoSize = True
        Me.rbPerActualPer.Location = New System.Drawing.Point(50, 20)
        Me.rbPerActualPer.Name = "rbPerActualPer"
        Me.rbPerActualPer.Size = New System.Drawing.Size(127, 20)
        Me.rbPerActualPer.TabIndex = 77
        Me.rbPerActualPer.TabStop = True
        Me.rbPerActualPer.Text = "Período actual"
        Me.rbPerActualPer.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.DGV)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 297)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox6.Size = New System.Drawing.Size(1190, 369)
        Me.GroupBox6.TabIndex = 82
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Ordenes a Notificar"
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
        Me.DGV.Location = New System.Drawing.Point(4, 18)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(1182, 348)
        Me.DGV.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsImagen})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 669)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1190, 22)
        Me.StatusStrip1.TabIndex = 83
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsImagen
        '
        Me.tsImagen.Name = "tsImagen"
        Me.tsImagen.Size = New System.Drawing.Size(0, 17)
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(377, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(497, 28)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'pgbAvance
        '
        Me.pgbAvance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgbAvance.Location = New System.Drawing.Point(377, 204)
        Me.pgbAvance.Name = "pgbAvance"
        Me.pgbAvance.Size = New System.Drawing.Size(497, 24)
        Me.pgbAvance.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbAvance.TabIndex = 89
        '
        'Avance_Notifica
        '
        '
        'FrmNotMasiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1190, 691)
        Me.Controls.Add(Me.pgbAvance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GB_Notifica)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DTPNotiMasiva)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNotMasiva"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notificación Masiva"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Notifica.ResumeLayout(False)
        Me.GB_Notifica.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DTPNotiMasiva As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GB_Notifica As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNotPeriodo As System.Windows.Forms.Button
    Friend WithEvents rbNotCierrePer As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerActualPer As System.Windows.Forms.RadioButton
    Friend WithEvents lblTotalxPeriodo As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RB_SC As System.Windows.Forms.RadioButton
    Friend WithEvents RB_PT As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsImagen As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pgbAvance As System.Windows.Forms.ProgressBar
    Friend WithEvents Avance_Notifica As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBFolio As System.Windows.Forms.TextBox
End Class
