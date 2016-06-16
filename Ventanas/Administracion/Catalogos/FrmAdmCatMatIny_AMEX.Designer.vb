<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmCatMatIny_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmCatMatIny_AMEX))
        Me.tsbPrincipal = New System.Windows.Forms.ToolStrip
        Me.tsbCerrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAlta = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.TSB_Cancelar = New System.Windows.Forms.ToolStripButton
        Me.pnlConsulta = New System.Windows.Forms.Panel
        Me.DGVProd = New System.Windows.Forms.DataGridView
        Me.TPeso = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblUmPT = New System.Windows.Forms.Label
        Me.TCodMat = New System.Windows.Forms.TextBox
        Me.PBActualiza = New System.Windows.Forms.ProgressBar
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.TDesMat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TDesCorMat = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TTipMat = New System.Windows.Forms.TextBox
        Me.TDesTipo = New System.Windows.Forms.TextBox
        Me.BtnEmpaque = New System.Windows.Forms.Button
        Me.btnLookUmPT = New System.Windows.Forms.Button
        Me.TDesUm = New System.Windows.Forms.TextBox
        Me.TUm = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CB_Status = New System.Windows.Forms.CheckBox
        Me.tsbPrincipal.SuspendLayout()
        Me.pnlConsulta.SuspendLayout()
        CType(Me.DGVProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsbPrincipal
        '
        Me.tsbPrincipal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tsbPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCerrar, Me.ToolStripSeparator2, Me.tsbConsultar, Me.ToolStripSeparator1, Me.tsbAlta, Me.ToolStripSeparator4, Me.tsbGrabar, Me.ToolStripSeparator3, Me.tsbModificar, Me.ToolStripSeparator6, Me.tsbEliminar, Me.ToolStripSeparator5, Me.TSB_Cancelar})
        Me.tsbPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsbPrincipal.Name = "tsbPrincipal"
        Me.tsbPrincipal.Size = New System.Drawing.Size(954, 25)
        Me.tsbPrincipal.TabIndex = 222
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(12, 25)
        '
        'tsbConsultar
        '
        Me.tsbConsultar.Image = CType(resources.GetObject("tsbConsultar.Image"), System.Drawing.Image)
        Me.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultar.Name = "tsbConsultar"
        Me.tsbConsultar.Size = New System.Drawing.Size(78, 22)
        Me.tsbConsultar.Text = "Consultar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(12, 25)
        '
        'tsbAlta
        '
        Me.tsbAlta.Image = CType(resources.GetObject("tsbAlta.Image"), System.Drawing.Image)
        Me.tsbAlta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAlta.Name = "tsbAlta"
        Me.tsbAlta.Size = New System.Drawing.Size(62, 22)
        Me.tsbAlta.Text = "Nuevo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(12, 25)
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Image = CType(resources.GetObject("tsbGrabar.Image"), System.Drawing.Image)
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGrabar.Text = "Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(12, 25)
        '
        'tsbModificar
        '
        Me.tsbModificar.Image = CType(resources.GetObject("tsbModificar.Image"), System.Drawing.Image)
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(78, 22)
        Me.tsbModificar.Text = "Modificar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(12, 25)
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(70, 22)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'TSB_Cancelar
        '
        Me.TSB_Cancelar.Image = CType(resources.GetObject("TSB_Cancelar.Image"), System.Drawing.Image)
        Me.TSB_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_Cancelar.Name = "TSB_Cancelar"
        Me.TSB_Cancelar.Size = New System.Drawing.Size(73, 22)
        Me.TSB_Cancelar.Text = "Cancelar"
        '
        'pnlConsulta
        '
        Me.pnlConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConsulta.Controls.Add(Me.DGVProd)
        Me.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlConsulta.Location = New System.Drawing.Point(0, 220)
        Me.pnlConsulta.Name = "pnlConsulta"
        Me.pnlConsulta.Size = New System.Drawing.Size(954, 260)
        Me.pnlConsulta.TabIndex = 224
        '
        'DGVProd
        '
        Me.DGVProd.AllowUserToAddRows = False
        Me.DGVProd.AllowUserToDeleteRows = False
        Me.DGVProd.AllowUserToOrderColumns = True
        Me.DGVProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVProd.Location = New System.Drawing.Point(0, 0)
        Me.DGVProd.Name = "DGVProd"
        Me.DGVProd.ReadOnly = True
        Me.DGVProd.Size = New System.Drawing.Size(952, 258)
        Me.DGVProd.TabIndex = 180
        '
        'TPeso
        '
        Me.TPeso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPeso.Location = New System.Drawing.Point(135, 176)
        Me.TPeso.MaxLength = 15
        Me.TPeso.Name = "TPeso"
        Me.TPeso.Size = New System.Drawing.Size(68, 15)
        Me.TPeso.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "Peso Unitario"
        '
        'lblUmPT
        '
        Me.lblUmPT.AutoSize = True
        Me.lblUmPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUmPT.Location = New System.Drawing.Point(49, 59)
        Me.lblUmPT.Name = "lblUmPT"
        Me.lblUmPT.Size = New System.Drawing.Size(80, 13)
        Me.lblUmPT.TabIndex = 195
        Me.lblUmPT.Text = "Codigo Material"
        '
        'TCodMat
        '
        Me.TCodMat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCodMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TCodMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodMat.Location = New System.Drawing.Point(135, 57)
        Me.TCodMat.MaxLength = 50
        Me.TCodMat.Name = "TCodMat"
        Me.TCodMat.Size = New System.Drawing.Size(68, 16)
        Me.TCodMat.TabIndex = 0
        '
        'PBActualiza
        '
        Me.PBActualiza.Location = New System.Drawing.Point(135, 28)
        Me.PBActualiza.Name = "PBActualiza"
        Me.PBActualiza.Size = New System.Drawing.Size(624, 23)
        Me.PBActualiza.TabIndex = 303
        '
        'BackgroundWorker1
        '
        '
        'TDesMat
        '
        Me.TDesMat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDesMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TDesMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesMat.Location = New System.Drawing.Point(135, 79)
        Me.TDesMat.MaxLength = 50
        Me.TDesMat.Name = "TDesMat"
        Me.TDesMat.Size = New System.Drawing.Size(397, 16)
        Me.TDesMat.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 309
        Me.Label1.Text = "Descripción"
        '
        'TDesCorMat
        '
        Me.TDesCorMat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDesCorMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TDesCorMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesCorMat.Location = New System.Drawing.Point(135, 101)
        Me.TDesCorMat.MaxLength = 50
        Me.TDesCorMat.Name = "TDesCorMat"
        Me.TDesCorMat.Size = New System.Drawing.Size(397, 16)
        Me.TDesCorMat.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 311
        Me.Label2.Text = "Descripción Corta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 324
        Me.Label3.Text = "Tipo Material"
        '
        'TTipMat
        '
        Me.TTipMat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TTipMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTipMat.Location = New System.Drawing.Point(135, 123)
        Me.TTipMat.MaxLength = 50
        Me.TTipMat.Name = "TTipMat"
        Me.TTipMat.Size = New System.Drawing.Size(68, 16)
        Me.TTipMat.TabIndex = 6
        '
        'TDesTipo
        '
        Me.TDesTipo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TDesTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDesTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesTipo.Location = New System.Drawing.Point(240, 123)
        Me.TDesTipo.MaxLength = 5
        Me.TDesTipo.Name = "TDesTipo"
        Me.TDesTipo.ReadOnly = True
        Me.TDesTipo.Size = New System.Drawing.Size(292, 16)
        Me.TDesTipo.TabIndex = 7
        '
        'BtnEmpaque
        '
        Me.BtnEmpaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpaque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpaque.Image = CType(resources.GetObject("BtnEmpaque.Image"), System.Drawing.Image)
        Me.BtnEmpaque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpaque.Location = New System.Drawing.Point(209, 120)
        Me.BtnEmpaque.Name = "BtnEmpaque"
        Me.BtnEmpaque.Size = New System.Drawing.Size(25, 22)
        Me.BtnEmpaque.TabIndex = 3
        Me.BtnEmpaque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEmpaque.UseVisualStyleBackColor = True
        '
        'btnLookUmPT
        '
        Me.btnLookUmPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLookUmPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookUmPT.Image = CType(resources.GetObject("btnLookUmPT.Image"), System.Drawing.Image)
        Me.btnLookUmPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLookUmPT.Location = New System.Drawing.Point(209, 148)
        Me.btnLookUmPT.Name = "btnLookUmPT"
        Me.btnLookUmPT.Size = New System.Drawing.Size(25, 22)
        Me.btnLookUmPT.TabIndex = 4
        Me.btnLookUmPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLookUmPT.UseVisualStyleBackColor = True
        '
        'TDesUm
        '
        Me.TDesUm.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TDesUm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDesUm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDesUm.Location = New System.Drawing.Point(240, 151)
        Me.TDesUm.MaxLength = 5
        Me.TDesUm.Name = "TDesUm"
        Me.TDesUm.ReadOnly = True
        Me.TDesUm.Size = New System.Drawing.Size(154, 16)
        Me.TDesUm.TabIndex = 9
        '
        'TUm
        '
        Me.TUm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TUm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUm.Location = New System.Drawing.Point(135, 151)
        Me.TUm.MaxLength = 50
        Me.TUm.Name = "TUm"
        Me.TUm.Size = New System.Drawing.Size(68, 16)
        Me.TUm.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 329
        Me.Label6.Text = "Un. Medida"
        '
        'CB_Status
        '
        Me.CB_Status.AutoSize = True
        Me.CB_Status.Location = New System.Drawing.Point(135, 197)
        Me.CB_Status.Name = "CB_Status"
        Me.CB_Status.Size = New System.Drawing.Size(56, 17)
        Me.CB_Status.TabIndex = 330
        Me.CB_Status.Text = "Activo"
        Me.CB_Status.UseVisualStyleBackColor = True
        '
        'FrmAdmCatMatIny_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(954, 480)
        Me.Controls.Add(Me.CB_Status)
        Me.Controls.Add(Me.btnLookUmPT)
        Me.Controls.Add(Me.TDesUm)
        Me.Controls.Add(Me.TUm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TTipMat)
        Me.Controls.Add(Me.TDesTipo)
        Me.Controls.Add(Me.BtnEmpaque)
        Me.Controls.Add(Me.TDesCorMat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TDesMat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBActualiza)
        Me.Controls.Add(Me.pnlConsulta)
        Me.Controls.Add(Me.tsbPrincipal)
        Me.Controls.Add(Me.TCodMat)
        Me.Controls.Add(Me.lblUmPT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TPeso)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdmCatMatIny_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Materiales Inyección"
        Me.tsbPrincipal.ResumeLayout(False)
        Me.tsbPrincipal.PerformLayout()
        Me.pnlConsulta.ResumeLayout(False)
        CType(Me.DGVProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsbPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAlta As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlConsulta As System.Windows.Forms.Panel
    Friend WithEvents DGVProd As System.Windows.Forms.DataGridView
    Friend WithEvents TPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblUmPT As System.Windows.Forms.Label
    Friend WithEvents TCodMat As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PBActualiza As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TSB_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TDesMat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TDesCorMat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TTipMat As System.Windows.Forms.TextBox
    Friend WithEvents TDesTipo As System.Windows.Forms.TextBox
    Friend WithEvents BtnEmpaque As System.Windows.Forms.Button
    Friend WithEvents btnLookUmPT As System.Windows.Forms.Button
    Friend WithEvents TDesUm As System.Windows.Forms.TextBox
    Friend WithEvents TUm As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CB_Status As System.Windows.Forms.CheckBox
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
End Class
