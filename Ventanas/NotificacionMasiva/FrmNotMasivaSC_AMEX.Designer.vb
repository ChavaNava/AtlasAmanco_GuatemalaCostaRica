<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotMasivaSC_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotMasivaSC_AMEX))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DateTimeNotiMasXOrden = New System.Windows.Forms.DateTimePicker()
        Me.Label150 = New System.Windows.Forms.Label()
        Me.CBNotif_ODF = New System.Windows.Forms.CheckBox()
        Me.ChBoxNotiMasXOrden = New System.Windows.Forms.CheckBox()
        Me.BtnConsulta1 = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnNotif = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtProd = New System.Windows.Forms.TextBox()
        Me.TxtEquipo = New System.Windows.Forms.TextBox()
        Me.TxtFec = New System.Windows.Forms.TextBox()
        Me.TxtOrdProd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGNotODF = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimeNotiMasiva = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.BtnNotPeriodo = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ChBoxNotiCierre = New System.Windows.Forms.CheckBox()
        Me.CBNot = New System.Windows.Forms.CheckBox()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DGNotPerScrap = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGNotODF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGNotPerScrap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(794, 575)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.DateTimeNotiMasXOrden)
        Me.TabPage1.Controls.Add(Me.Label150)
        Me.TabPage1.Controls.Add(Me.CBNotif_ODF)
        Me.TabPage1.Controls.Add(Me.ChBoxNotiMasXOrden)
        Me.TabPage1.Controls.Add(Me.BtnConsulta1)
        Me.TabPage1.Controls.Add(Me.BtnCancel)
        Me.TabPage1.Controls.Add(Me.BtnNotif)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(786, 549)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Por Orden de Producción"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(549, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(162, 17)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Label15"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimeNotiMasXOrden
        '
        Me.DateTimeNotiMasXOrden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimeNotiMasXOrden.CustomFormat = "yyyy/MM/dd"
        Me.DateTimeNotiMasXOrden.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeNotiMasXOrden.Location = New System.Drawing.Point(292, 107)
        Me.DateTimeNotiMasXOrden.Name = "DateTimeNotiMasXOrden"
        Me.DateTimeNotiMasXOrden.Size = New System.Drawing.Size(92, 20)
        Me.DateTimeNotiMasXOrden.TabIndex = 82
        Me.DateTimeNotiMasXOrden.Visible = False
        '
        'Label150
        '
        Me.Label150.AutoSize = True
        Me.Label150.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label150.Location = New System.Drawing.Point(289, 80)
        Me.Label150.Name = "Label150"
        Me.Label150.Size = New System.Drawing.Size(178, 13)
        Me.Label150.TabIndex = 81
        Me.Label150.Text = "Fecha de Contabilización SAP"
        Me.Label150.Visible = False
        '
        'CBNotif_ODF
        '
        Me.CBNotif_ODF.AutoSize = True
        Me.CBNotif_ODF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CBNotif_ODF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNotif_ODF.Location = New System.Drawing.Point(541, 6)
        Me.CBNotif_ODF.Name = "CBNotif_ODF"
        Me.CBNotif_ODF.Size = New System.Drawing.Size(181, 17)
        Me.CBNotif_ODF.TabIndex = 80
        Me.CBNotif_ODF.Text = "Notificación Periodo Actual"
        Me.CBNotif_ODF.UseVisualStyleBackColor = True
        '
        'ChBoxNotiMasXOrden
        '
        Me.ChBoxNotiMasXOrden.AutoSize = True
        Me.ChBoxNotiMasXOrden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChBoxNotiMasXOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChBoxNotiMasXOrden.Location = New System.Drawing.Point(541, 29)
        Me.ChBoxNotiMasXOrden.Name = "ChBoxNotiMasXOrden"
        Me.ChBoxNotiMasXOrden.Size = New System.Drawing.Size(131, 17)
        Me.ChBoxNotiMasXOrden.TabIndex = 79
        Me.ChBoxNotiMasXOrden.Text = "Notificación Cierre"
        Me.ChBoxNotiMasXOrden.UseVisualStyleBackColor = True
        '
        'BtnConsulta1
        '
        Me.BtnConsulta1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsulta1.Image = CType(resources.GetObject("BtnConsulta1.Image"), System.Drawing.Image)
        Me.BtnConsulta1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsulta1.Location = New System.Drawing.Point(567, 54)
        Me.BtnConsulta1.Name = "BtnConsulta1"
        Me.BtnConsulta1.Size = New System.Drawing.Size(127, 23)
        Me.BtnConsulta1.TabIndex = 78
        Me.BtnConsulta1.Text = "Consulta"
        Me.BtnConsulta1.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(567, 112)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(127, 23)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cerrar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnNotif
        '
        Me.BtnNotif.Enabled = False
        Me.BtnNotif.Image = CType(resources.GetObject("BtnNotif.Image"), System.Drawing.Image)
        Me.BtnNotif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotif.Location = New System.Drawing.Point(567, 83)
        Me.BtnNotif.Name = "BtnNotif"
        Me.BtnNotif.Size = New System.Drawing.Size(127, 23)
        Me.BtnNotif.TabIndex = 3
        Me.BtnNotif.Text = "Notificar"
        Me.BtnNotif.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtProd)
        Me.GroupBox2.Controls.Add(Me.TxtEquipo)
        Me.GroupBox2.Controls.Add(Me.TxtFec)
        Me.GroupBox2.Controls.Add(Me.TxtOrdProd)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 135)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Orden de Producción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Producto:"
        '
        'TxtProd
        '
        Me.TxtProd.Location = New System.Drawing.Point(123, 100)
        Me.TxtProd.Name = "TxtProd"
        Me.TxtProd.ReadOnly = True
        Me.TxtProd.Size = New System.Drawing.Size(100, 20)
        Me.TxtProd.TabIndex = 6
        '
        'TxtEquipo
        '
        Me.TxtEquipo.Location = New System.Drawing.Point(123, 74)
        Me.TxtEquipo.Name = "TxtEquipo"
        Me.TxtEquipo.ReadOnly = True
        Me.TxtEquipo.Size = New System.Drawing.Size(100, 20)
        Me.TxtEquipo.TabIndex = 5
        '
        'TxtFec
        '
        Me.TxtFec.Location = New System.Drawing.Point(123, 48)
        Me.TxtFec.Name = "TxtFec"
        Me.TxtFec.ReadOnly = True
        Me.TxtFec.Size = New System.Drawing.Size(100, 20)
        Me.TxtFec.TabIndex = 4
        '
        'TxtOrdProd
        '
        Me.TxtOrdProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOrdProd.Location = New System.Drawing.Point(123, 22)
        Me.TxtOrdProd.Name = "TxtOrdProd"
        Me.TxtOrdProd.Size = New System.Drawing.Size(100, 20)
        Me.TxtOrdProd.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Equipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Inicio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orden de Producción:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGNotODF)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(3, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 388)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenes a Notificar"
        '
        'DGNotODF
        '
        Me.DGNotODF.AllowUserToAddRows = False
        Me.DGNotODF.AllowUserToDeleteRows = False
        Me.DGNotODF.AllowUserToOrderColumns = True
        Me.DGNotODF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGNotODF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGNotODF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGNotODF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGNotODF.Location = New System.Drawing.Point(3, 16)
        Me.DGNotODF.Name = "DGNotODF"
        Me.DGNotODF.ReadOnly = True
        Me.DGNotODF.Size = New System.Drawing.Size(774, 369)
        Me.DGNotODF.TabIndex = 79
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.DateTimeNotiMasiva)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.BtnConsulta)
        Me.TabPage2.Controls.Add(Me.BtnNotPeriodo)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(786, 549)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Por Periodo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(304, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(178, 13)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Fecha de Contabilización SAP"
        Me.Label12.Visible = False
        '
        'DateTimeNotiMasiva
        '
        Me.DateTimeNotiMasiva.CustomFormat = "yyyy/MM/dd"
        Me.DateTimeNotiMasiva.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeNotiMasiva.Location = New System.Drawing.Point(307, 111)
        Me.DateTimeNotiMasiva.Name = "DateTimeNotiMasiva"
        Me.DateTimeNotiMasiva.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeNotiMasiva.TabIndex = 74
        Me.DateTimeNotiMasiva.Visible = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(560, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 17)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Label11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(572, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 23)
        Me.Button3.TabIndex = 65
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Image = CType(resources.GetObject("BtnConsulta.Image"), System.Drawing.Image)
        Me.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsulta.Location = New System.Drawing.Point(572, 28)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(126, 23)
        Me.BtnConsulta.TabIndex = 69
        Me.BtnConsulta.Text = "Consulta"
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'BtnNotPeriodo
        '
        Me.BtnNotPeriodo.Enabled = False
        Me.BtnNotPeriodo.Image = CType(resources.GetObject("BtnNotPeriodo.Image"), System.Drawing.Image)
        Me.BtnNotPeriodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotPeriodo.Location = New System.Drawing.Point(572, 57)
        Me.BtnNotPeriodo.Name = "BtnNotPeriodo"
        Me.BtnNotPeriodo.Size = New System.Drawing.Size(127, 23)
        Me.BtnNotPeriodo.TabIndex = 64
        Me.BtnNotPeriodo.Text = "Notificar"
        Me.BtnNotPeriodo.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ChBoxNotiCierre)
        Me.GroupBox5.Controls.Add(Me.CBNot)
        Me.GroupBox5.Controls.Add(Me.DTP2)
        Me.GroupBox5.Controls.Add(Me.DTP1)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(233, 135)
        Me.GroupBox5.TabIndex = 63
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Periodo a Notificar"
        '
        'ChBoxNotiCierre
        '
        Me.ChBoxNotiCierre.AutoSize = True
        Me.ChBoxNotiCierre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChBoxNotiCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChBoxNotiCierre.Location = New System.Drawing.Point(11, 113)
        Me.ChBoxNotiCierre.Name = "ChBoxNotiCierre"
        Me.ChBoxNotiCierre.Size = New System.Drawing.Size(131, 17)
        Me.ChBoxNotiCierre.TabIndex = 75
        Me.ChBoxNotiCierre.Text = "Notificación Cierre"
        Me.ChBoxNotiCierre.UseVisualStyleBackColor = True
        '
        'CBNot
        '
        Me.CBNot.AutoSize = True
        Me.CBNot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CBNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNot.Location = New System.Drawing.Point(11, 90)
        Me.CBNot.Name = "CBNot"
        Me.CBNot.Size = New System.Drawing.Size(181, 17)
        Me.CBNot.TabIndex = 74
        Me.CBNot.Text = "Notificación Periodo Actual"
        Me.CBNot.UseVisualStyleBackColor = True
        '
        'DTP2
        '
        Me.DTP2.CustomFormat = "yyyy/MM/dd"
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP2.Location = New System.Drawing.Point(123, 47)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(100, 20)
        Me.DTP2.TabIndex = 71
        '
        'DTP1
        '
        Me.DTP1.CustomFormat = "yyyy/MM/dd"
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(123, 18)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(100, 20)
        Me.DTP1.TabIndex = 70
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Fecha Fin:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Fecha Inicio:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DGNotPerScrap)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox6.Location = New System.Drawing.Point(3, 158)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(780, 388)
        Me.GroupBox6.TabIndex = 62
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Ordenes a Notificar"
        '
        'DGNotPerScrap
        '
        Me.DGNotPerScrap.AllowUserToAddRows = False
        Me.DGNotPerScrap.AllowUserToDeleteRows = False
        Me.DGNotPerScrap.AllowUserToOrderColumns = True
        Me.DGNotPerScrap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGNotPerScrap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGNotPerScrap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGNotPerScrap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGNotPerScrap.Location = New System.Drawing.Point(3, 16)
        Me.DGNotPerScrap.Name = "DGNotPerScrap"
        Me.DGNotPerScrap.ReadOnly = True
        Me.DGNotPerScrap.Size = New System.Drawing.Size(774, 369)
        Me.DGNotPerScrap.TabIndex = 80
        '
        'FrmNotMasivaSC_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 575)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNotMasivaSC_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGNotODF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DGNotPerScrap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnNotif As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtProd As System.Windows.Forms.TextBox
    Friend WithEvents TxtEquipo As System.Windows.Forms.TextBox
    Friend WithEvents TxtFec As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrdProd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnNotPeriodo As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnConsulta1 As System.Windows.Forms.Button
    Friend WithEvents DGNotODF As System.Windows.Forms.DataGridView
    Friend WithEvents CBNotif_ODF As System.Windows.Forms.CheckBox
    Friend WithEvents ChBoxNotiMasXOrden As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimeNotiMasXOrden As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label150 As System.Windows.Forms.Label
    Friend WithEvents DGNotPerScrap As System.Windows.Forms.DataGridView
    Friend WithEvents ChBoxNotiCierre As System.Windows.Forms.CheckBox
    Friend WithEvents CBNot As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTimeNotiMasiva As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
