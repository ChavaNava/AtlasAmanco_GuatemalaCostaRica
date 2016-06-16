<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminDelTPERIny
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdminDelTPERIny))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CB4 = New System.Windows.Forms.CheckBox
        Me.CB5 = New System.Windows.Forms.CheckBox
        Me.CB3 = New System.Windows.Forms.CheckBox
        Me.CB2 = New System.Windows.Forms.CheckBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.lblODF = New System.Windows.Forms.Label
        Me.TxtOrdProd = New System.Windows.Forms.TextBox
        Me.BtnConsulta = New System.Windows.Forms.Button
        Me.DTP2 = New System.Windows.Forms.DateTimePicker
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.GBNotif = New System.Windows.Forms.GroupBox
        Me.txtUKID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtPtotrabajo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtFecha = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtODF = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnPost = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblEQUIPO = New System.Windows.Forms.Label
        Me.txtEquipo = New System.Windows.Forms.TextBox
        Me.DGDHP = New System.Windows.Forms.DataGrid
        Me.DGHP = New System.Windows.Forms.DataGrid
        Me.DGRHP = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GBNotif.SuspendLayout()
        CType(Me.DGDHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRHP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB4)
        Me.GroupBox1.Controls.Add(Me.CB5)
        Me.GroupBox1.Controls.Add(Me.CB3)
        Me.GroupBox1.Controls.Add(Me.CB2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 126)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Consulta"
        '
        'CB4
        '
        Me.CB4.AutoSize = True
        Me.CB4.Location = New System.Drawing.Point(14, 72)
        Me.CB4.Name = "CB4"
        Me.CB4.Size = New System.Drawing.Size(106, 17)
        Me.CB4.TabIndex = 5
        Me.CB4.Text = "Equipo / Periodo"
        Me.CB4.UseVisualStyleBackColor = True
        '
        'CB5
        '
        Me.CB5.AutoSize = True
        Me.CB5.Location = New System.Drawing.Point(14, 94)
        Me.CB5.Name = "CB5"
        Me.CB5.Size = New System.Drawing.Size(62, 17)
        Me.CB5.TabIndex = 4
        Me.CB5.Text = "Eliminar"
        Me.CB5.UseVisualStyleBackColor = True
        '
        'CB3
        '
        Me.CB3.AutoSize = True
        Me.CB3.Location = New System.Drawing.Point(14, 51)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(174, 17)
        Me.CB3.TabIndex = 2
        Me.CB3.Text = "Orden de Producción / Periodo"
        Me.CB3.UseVisualStyleBackColor = True
        '
        'CB2
        '
        Me.CB2.AutoSize = True
        Me.CB2.Location = New System.Drawing.Point(14, 28)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(127, 17)
        Me.CB2.TabIndex = 1
        Me.CB2.Text = "Orden de Producción"
        Me.CB2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(991, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(991, 25)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton1.Text = "Cerrar"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(19, 214)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(46, 13)
        Me.lblPeriodo.TabIndex = 34
        Me.lblPeriodo.Text = "Periodo:"
        Me.lblPeriodo.Visible = False
        '
        'lblODF
        '
        Me.lblODF.AutoSize = True
        Me.lblODF.Location = New System.Drawing.Point(38, 194)
        Me.lblODF.Name = "lblODF"
        Me.lblODF.Size = New System.Drawing.Size(32, 13)
        Me.lblODF.TabIndex = 32
        Me.lblODF.Text = "ODF:"
        Me.lblODF.Visible = False
        '
        'TxtOrdProd
        '
        Me.TxtOrdProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOrdProd.Location = New System.Drawing.Point(79, 190)
        Me.TxtOrdProd.MaxLength = 15
        Me.TxtOrdProd.Name = "TxtOrdProd"
        Me.TxtOrdProd.Size = New System.Drawing.Size(100, 20)
        Me.TxtOrdProd.TabIndex = 29
        Me.TxtOrdProd.Text = "*"
        Me.TxtOrdProd.Visible = False
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Image = CType(resources.GetObject("BtnConsulta.Image"), System.Drawing.Image)
        Me.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsulta.Location = New System.Drawing.Point(29, 293)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(176, 23)
        Me.BtnConsulta.TabIndex = 28
        Me.BtnConsulta.Text = "Consulta"
        Me.BtnConsulta.UseVisualStyleBackColor = True
        Me.BtnConsulta.Visible = False
        '
        'DTP2
        '
        Me.DTP2.CustomFormat = "yyyy-MM-dd"
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP2.Location = New System.Drawing.Point(123, 230)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(90, 20)
        Me.DTP2.TabIndex = 27
        Me.DTP2.Visible = False
        '
        'DTP1
        '
        Me.DTP1.CustomFormat = "yyyy-MM-dd"
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(19, 230)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(90, 20)
        Me.DTP1.TabIndex = 26
        Me.DTP1.Visible = False
        '
        'GBNotif
        '
        Me.GBNotif.Controls.Add(Me.txtUKID)
        Me.GBNotif.Controls.Add(Me.Label4)
        Me.GBNotif.Controls.Add(Me.TxtPtotrabajo)
        Me.GBNotif.Controls.Add(Me.Label3)
        Me.GBNotif.Controls.Add(Me.TxtFecha)
        Me.GBNotif.Controls.Add(Me.Label2)
        Me.GBNotif.Controls.Add(Me.TxtODF)
        Me.GBNotif.Controls.Add(Me.Label1)
        Me.GBNotif.Controls.Add(Me.BtnPost)
        Me.GBNotif.Location = New System.Drawing.Point(8, 334)
        Me.GBNotif.Name = "GBNotif"
        Me.GBNotif.Size = New System.Drawing.Size(209, 191)
        Me.GBNotif.TabIndex = 35
        Me.GBNotif.TabStop = False
        Me.GBNotif.Text = "Modifica Status Notificacion"
        Me.GBNotif.Visible = False
        '
        'txtUKID
        '
        Me.txtUKID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUKID.Location = New System.Drawing.Point(81, 153)
        Me.txtUKID.Name = "txtUKID"
        Me.txtUKID.ReadOnly = True
        Me.txtUKID.Size = New System.Drawing.Size(100, 20)
        Me.txtUKID.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "UKID:"
        '
        'TxtPtotrabajo
        '
        Me.TxtPtotrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPtotrabajo.Location = New System.Drawing.Point(80, 102)
        Me.TxtPtotrabajo.MaxLength = 15
        Me.TxtPtotrabajo.Name = "TxtPtotrabajo"
        Me.TxtPtotrabajo.ReadOnly = True
        Me.TxtPtotrabajo.Size = New System.Drawing.Size(100, 20)
        Me.TxtPtotrabajo.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Equipo:"
        '
        'TxtFecha
        '
        Me.TxtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFecha.Location = New System.Drawing.Point(81, 127)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.ReadOnly = True
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Fecha:"
        '
        'TxtODF
        '
        Me.TxtODF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtODF.Location = New System.Drawing.Point(81, 77)
        Me.TxtODF.MaxLength = 15
        Me.TxtODF.Name = "TxtODF"
        Me.TxtODF.ReadOnly = True
        Me.TxtODF.Size = New System.Drawing.Size(100, 20)
        Me.TxtODF.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ODF:"
        '
        'BtnPost
        '
        Me.BtnPost.Image = CType(resources.GetObject("BtnPost.Image"), System.Drawing.Image)
        Me.BtnPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPost.Location = New System.Drawing.Point(21, 30)
        Me.BtnPost.Name = "BtnPost"
        Me.BtnPost.Size = New System.Drawing.Size(176, 23)
        Me.BtnPost.TabIndex = 20
        Me.BtnPost.Text = "Eliminar"
        Me.BtnPost.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 560)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(991, 22)
        Me.StatusStrip1.TabIndex = 42
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEQUIPO
        '
        Me.lblEQUIPO.AutoSize = True
        Me.lblEQUIPO.Location = New System.Drawing.Point(33, 193)
        Me.lblEQUIPO.Name = "lblEQUIPO"
        Me.lblEQUIPO.Size = New System.Drawing.Size(43, 13)
        Me.lblEQUIPO.TabIndex = 44
        Me.lblEQUIPO.Text = "Equipo:"
        Me.lblEQUIPO.Visible = False
        '
        'txtEquipo
        '
        Me.txtEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEquipo.Location = New System.Drawing.Point(79, 190)
        Me.txtEquipo.MaxLength = 15
        Me.txtEquipo.Name = "txtEquipo"
        Me.txtEquipo.Size = New System.Drawing.Size(100, 20)
        Me.txtEquipo.TabIndex = 43
        Me.txtEquipo.Text = "*"
        Me.txtEquipo.Visible = False
        '
        'DGDHP
        '
        Me.DGDHP.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DGDHP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGDHP.BackColor = System.Drawing.Color.White
        Me.DGDHP.CaptionBackColor = System.Drawing.Color.Maroon
        Me.DGDHP.CaptionFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGDHP.CaptionForeColor = System.Drawing.Color.White
        Me.DGDHP.CaptionText = "Detalle registros eliminados Horas PARO por Maquina"
        Me.DGDHP.DataMember = ""
        Me.DGDHP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGDHP.ForeColor = System.Drawing.Color.Black
        Me.DGDHP.GridLineColor = System.Drawing.Color.Silver
        Me.DGDHP.HeaderBackColor = System.Drawing.Color.Silver
        Me.DGDHP.HeaderFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGDHP.HeaderForeColor = System.Drawing.Color.Black
        Me.DGDHP.LinkColor = System.Drawing.Color.Maroon
        Me.DGDHP.Location = New System.Drawing.Point(233, 395)
        Me.DGDHP.Name = "DGDHP"
        Me.DGDHP.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DGDHP.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGDHP.ReadOnly = True
        Me.DGDHP.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DGDHP.SelectionForeColor = System.Drawing.Color.White
        Me.DGDHP.Size = New System.Drawing.Size(746, 153)
        Me.DGDHP.TabIndex = 49
        '
        'DGHP
        '
        Me.DGHP.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DGHP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGHP.BackColor = System.Drawing.Color.White
        Me.DGHP.CaptionBackColor = System.Drawing.Color.Maroon
        Me.DGHP.CaptionFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGHP.CaptionForeColor = System.Drawing.Color.White
        Me.DGHP.CaptionText = "Detalle Horas PARO por Maquina"
        Me.DGHP.DataMember = ""
        Me.DGHP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGHP.ForeColor = System.Drawing.Color.Black
        Me.DGHP.GridLineColor = System.Drawing.Color.Silver
        Me.DGHP.HeaderBackColor = System.Drawing.Color.Silver
        Me.DGHP.HeaderFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGHP.HeaderForeColor = System.Drawing.Color.Black
        Me.DGHP.LinkColor = System.Drawing.Color.Maroon
        Me.DGHP.Location = New System.Drawing.Point(233, 57)
        Me.DGHP.Name = "DGHP"
        Me.DGHP.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DGHP.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGHP.ReadOnly = True
        Me.DGHP.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DGHP.SelectionForeColor = System.Drawing.Color.White
        Me.DGHP.Size = New System.Drawing.Size(746, 163)
        Me.DGHP.TabIndex = 48
        '
        'DGRHP
        '
        Me.DGRHP.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DGRHP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGRHP.BackColor = System.Drawing.Color.White
        Me.DGRHP.CaptionBackColor = System.Drawing.Color.Maroon
        Me.DGRHP.CaptionFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGRHP.CaptionForeColor = System.Drawing.Color.White
        Me.DGRHP.CaptionText = "Resumen Horas PARO por Maquina"
        Me.DGRHP.DataMember = ""
        Me.DGRHP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGRHP.ForeColor = System.Drawing.Color.Black
        Me.DGRHP.GridLineColor = System.Drawing.Color.Silver
        Me.DGRHP.HeaderBackColor = System.Drawing.Color.Silver
        Me.DGRHP.HeaderFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGRHP.HeaderForeColor = System.Drawing.Color.Black
        Me.DGRHP.LinkColor = System.Drawing.Color.Maroon
        Me.DGRHP.Location = New System.Drawing.Point(233, 230)
        Me.DGRHP.Name = "DGRHP"
        Me.DGRHP.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DGRHP.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGRHP.ReadOnly = True
        Me.DGRHP.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DGRHP.SelectionForeColor = System.Drawing.Color.White
        Me.DGRHP.Size = New System.Drawing.Size(746, 156)
        Me.DGRHP.TabIndex = 122
        '
        'FrmAdminDelTPERIny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 582)
        Me.Controls.Add(Me.DGRHP)
        Me.Controls.Add(Me.DGDHP)
        Me.Controls.Add(Me.DGHP)
        Me.Controls.Add(Me.lblEQUIPO)
        Me.Controls.Add(Me.txtEquipo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GBNotif)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.lblODF)
        Me.Controls.Add(Me.TxtOrdProd)
        Me.Controls.Add(Me.BtnConsulta)
        Me.Controls.Add(Me.DTP2)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmAdminDelTPERIny"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elimina registros  Horas PARO Inyección"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GBNotif.ResumeLayout(False)
        Me.GBNotif.PerformLayout()
        CType(Me.DGDHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGRHP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CB5 As System.Windows.Forms.CheckBox
    Friend WithEvents CB3 As System.Windows.Forms.CheckBox
    Friend WithEvents CB2 As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblODF As System.Windows.Forms.Label
    Friend WithEvents TxtOrdProd As System.Windows.Forms.TextBox
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GBNotif As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPost As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CB4 As System.Windows.Forms.CheckBox
    Friend WithEvents lblEQUIPO As System.Windows.Forms.Label
    Friend WithEvents txtEquipo As System.Windows.Forms.TextBox
    Friend WithEvents DGDHP As System.Windows.Forms.DataGrid
    Friend WithEvents DGHP As System.Windows.Forms.DataGrid
    Friend WithEvents txtUKID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPtotrabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtODF As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGRHP As System.Windows.Forms.DataGrid
End Class
