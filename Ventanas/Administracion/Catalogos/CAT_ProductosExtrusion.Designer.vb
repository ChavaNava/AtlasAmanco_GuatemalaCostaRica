<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAT_ProductosExtrusion
    Inherits Atlas.Master_Cat

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAT_ProductosExtrusion))
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TCod_Reten = New System.Windows.Forms.TextBox()
        Me.CB_Reten = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TCod_Empaque = New System.Windows.Forms.TextBox()
        Me.CB_EMP = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TCod_Marca = New System.Windows.Forms.TextBox()
        Me.TCod_UM = New System.Windows.Forms.TextBox()
        Me.LCodBarr = New System.Windows.Forms.Label()
        Me.CB_Marcas = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TCodBarr = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_State = New System.Windows.Forms.CheckBox()
        Me.TCentro = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TDesProd = New System.Windows.Forms.TextBox()
        Me.TCodProd = New System.Windows.Forms.TextBox()
        Me.CB_CC = New System.Windows.Forms.CheckBox()
        Me.CB_UM = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.RB_CT = New System.Windows.Forms.RadioButton()
        Me.RB_VD = New System.Windows.Forms.RadioButton()
        Me.RB_TC = New System.Windows.Forms.RadioButton()
        Me.TBPitch = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TBEngroso = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TBLongEngroso = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TBGama = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TBDiamMax = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TBArea = New System.Windows.Forms.TextBox()
        Me.label24 = New System.Windows.Forms.Label()
        Me.TBEMN = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.TBExpMax = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBEMT = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TSobProm = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TSobHist = New System.Windows.Forms.TextBox()
        Me.TLongitud = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TDiametro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TSobrepeso = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TPesoStn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TPesoTeo = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TCod_UsoMaq = New System.Windows.Forms.TextBox()
        Me.TCod_Area = New System.Windows.Forms.TextBox()
        Me.TCod_Seccion = New System.Windows.Forms.TextBox()
        Me.TCod_TipoComp = New System.Windows.Forms.TextBox()
        Me.TCod_GrpDiam = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CB_TipoComp = New System.Windows.Forms.ComboBox()
        Me.CB_GpoDiam = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CB_Seccion = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CB_UsoMaq = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CB_Area = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CB_SoloPiezas = New System.Windows.Forms.CheckBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DGV.Location = New System.Drawing.Point(0, 329)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(984, 283)
        Me.DGV.TabIndex = 338
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 231)
        Me.TabControl1.TabIndex = 339
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CB_SoloPiezas)
        Me.TabPage1.Controls.Add(Me.TCod_Reten)
        Me.TabPage1.Controls.Add(Me.CB_Reten)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.TCod_Empaque)
        Me.TabPage1.Controls.Add(Me.CB_EMP)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TCod_Marca)
        Me.TabPage1.Controls.Add(Me.TCod_UM)
        Me.TabPage1.Controls.Add(Me.LCodBarr)
        Me.TabPage1.Controls.Add(Me.CB_Marcas)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.TCodBarr)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.CB_State)
        Me.TabPage1.Controls.Add(Me.TCentro)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.TDesProd)
        Me.TabPage1.Controls.Add(Me.TCodProd)
        Me.TabPage1.Controls.Add(Me.CB_CC)
        Me.TabPage1.Controls.Add(Me.CB_UM)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblProducto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(976, 202)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Descripción Producto"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TCod_Reten
        '
        Me.TCod_Reten.Location = New System.Drawing.Point(579, 95)
        Me.TCod_Reten.Name = "TCod_Reten"
        Me.TCod_Reten.ReadOnly = True
        Me.TCod_Reten.Size = New System.Drawing.Size(70, 22)
        Me.TCod_Reten.TabIndex = 394
        '
        'CB_Reten
        '
        Me.CB_Reten.FormattingEnabled = True
        Me.CB_Reten.Location = New System.Drawing.Point(144, 95)
        Me.CB_Reten.Name = "CB_Reten"
        Me.CB_Reten.Size = New System.Drawing.Size(429, 24)
        Me.CB_Reten.TabIndex = 393
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(89, 98)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 16)
        Me.Label30.TabIndex = 392
        Me.Label30.Text = "Reten"
        '
        'TCod_Empaque
        '
        Me.TCod_Empaque.Location = New System.Drawing.Point(579, 65)
        Me.TCod_Empaque.Name = "TCod_Empaque"
        Me.TCod_Empaque.ReadOnly = True
        Me.TCod_Empaque.Size = New System.Drawing.Size(70, 22)
        Me.TCod_Empaque.TabIndex = 391
        '
        'CB_EMP
        '
        Me.CB_EMP.FormattingEnabled = True
        Me.CB_EMP.Location = New System.Drawing.Point(144, 65)
        Me.CB_EMP.Name = "CB_EMP"
        Me.CB_EMP.Size = New System.Drawing.Size(429, 24)
        Me.CB_EMP.TabIndex = 390
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(64, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 389
        Me.Label2.Text = "Empaque"
        '
        'TCod_Marca
        '
        Me.TCod_Marca.Location = New System.Drawing.Point(579, 37)
        Me.TCod_Marca.Name = "TCod_Marca"
        Me.TCod_Marca.ReadOnly = True
        Me.TCod_Marca.Size = New System.Drawing.Size(70, 22)
        Me.TCod_Marca.TabIndex = 388
        '
        'TCod_UM
        '
        Me.TCod_UM.Location = New System.Drawing.Point(437, 125)
        Me.TCod_UM.Name = "TCod_UM"
        Me.TCod_UM.ReadOnly = True
        Me.TCod_UM.Size = New System.Drawing.Size(70, 22)
        Me.TCod_UM.TabIndex = 387
        '
        'LCodBarr
        '
        Me.LCodBarr.AutoSize = True
        Me.LCodBarr.Location = New System.Drawing.Point(666, 7)
        Me.LCodBarr.Name = "LCodBarr"
        Me.LCodBarr.Size = New System.Drawing.Size(63, 16)
        Me.LCodBarr.TabIndex = 385
        Me.LCodBarr.Text = "Label13"
        Me.LCodBarr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CB_Marcas
        '
        Me.CB_Marcas.FormattingEnabled = True
        Me.CB_Marcas.Location = New System.Drawing.Point(144, 35)
        Me.CB_Marcas.Name = "CB_Marcas"
        Me.CB_Marcas.Size = New System.Drawing.Size(429, 24)
        Me.CB_Marcas.TabIndex = 381
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(87, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 16)
        Me.Label18.TabIndex = 380
        Me.Label18.Text = "Marca"
        '
        'TCodBarr
        '
        Me.TCodBarr.Location = New System.Drawing.Point(144, 155)
        Me.TCodBarr.Name = "TCodBarr"
        Me.TCodBarr.Size = New System.Drawing.Size(184, 22)
        Me.TCodBarr.TabIndex = 379
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(8, 158)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(130, 16)
        Me.Label17.TabIndex = 378
        Me.Label17.Text = "Código de Barras"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(655, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 16)
        Me.Label16.TabIndex = 377
        Me.Label16.Text = "Estado"
        '
        'CB_State
        '
        Me.CB_State.AutoSize = True
        Me.CB_State.BackColor = System.Drawing.SystemColors.Control
        Me.CB_State.Enabled = False
        Me.CB_State.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CB_State.Location = New System.Drawing.Point(718, 97)
        Me.CB_State.Name = "CB_State"
        Me.CB_State.Size = New System.Drawing.Size(70, 20)
        Me.CB_State.TabIndex = 376
        Me.CB_State.Text = "Activo"
        Me.CB_State.UseVisualStyleBackColor = False
        '
        'TCentro
        '
        Me.TCentro.Location = New System.Drawing.Point(718, 65)
        Me.TCentro.Name = "TCentro"
        Me.TCentro.Size = New System.Drawing.Size(100, 22)
        Me.TCentro.TabIndex = 375
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(659, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 16)
        Me.Label15.TabIndex = 374
        Me.Label15.Text = "Centro"
        '
        'TDesProd
        '
        Me.TDesProd.Location = New System.Drawing.Point(250, 7)
        Me.TDesProd.Name = "TDesProd"
        Me.TDesProd.Size = New System.Drawing.Size(399, 22)
        Me.TDesProd.TabIndex = 371
        '
        'TCodProd
        '
        Me.TCodProd.Location = New System.Drawing.Point(144, 7)
        Me.TCodProd.Name = "TCodProd"
        Me.TCodProd.Size = New System.Drawing.Size(100, 22)
        Me.TCodProd.TabIndex = 369
        '
        'CB_CC
        '
        Me.CB_CC.AutoSize = True
        Me.CB_CC.BackColor = System.Drawing.SystemColors.Control
        Me.CB_CC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CB_CC.Location = New System.Drawing.Point(718, 123)
        Me.CB_CC.Name = "CB_CC"
        Me.CB_CC.Size = New System.Drawing.Size(188, 20)
        Me.CB_CC.TabIndex = 366
        Me.CB_CC.Text = "Consumos combinados"
        Me.CB_CC.UseVisualStyleBackColor = False
        '
        'CB_UM
        '
        Me.CB_UM.FormattingEnabled = True
        Me.CB_UM.Location = New System.Drawing.Point(144, 125)
        Me.CB_UM.Name = "CB_UM"
        Me.CB_UM.Size = New System.Drawing.Size(287, 24)
        Me.CB_UM.TabIndex = 345
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(107, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 344
        Me.Label1.Text = "UM"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.BackColor = System.Drawing.SystemColors.Control
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblProducto.Location = New System.Drawing.Point(68, 10)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(70, 16)
        Me.lblProducto.TabIndex = 343
        Me.lblProducto.Text = "Producto"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.RB_CT)
        Me.TabPage2.Controls.Add(Me.RB_VD)
        Me.TabPage2.Controls.Add(Me.RB_TC)
        Me.TabPage2.Controls.Add(Me.TBPitch)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.TBEngroso)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.TBLongEngroso)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.TBGama)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.TBDiamMax)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.TBArea)
        Me.TabPage2.Controls.Add(Me.label24)
        Me.TabPage2.Controls.Add(Me.TBEMN)
        Me.TabPage2.Controls.Add(Me.Label)
        Me.TabPage2.Controls.Add(Me.TBExpMax)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.TBEMT)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.TSobProm)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.TSobHist)
        Me.TabPage2.Controls.Add(Me.TLongitud)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TDiametro)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TSobrepeso)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TPesoStn)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TPesoTeo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(976, 202)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dimensiones y Pesos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(8, 9)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(214, 16)
        Me.Label29.TabIndex = 389
        Me.Label29.Text = "Método Cálculo Peso Teórico"
        '
        'RB_CT
        '
        Me.RB_CT.AutoSize = True
        Me.RB_CT.Location = New System.Drawing.Point(692, 7)
        Me.RB_CT.Name = "RB_CT"
        Me.RB_CT.Size = New System.Drawing.Size(265, 20)
        Me.RB_CT.TabIndex = 388
        Me.RB_CT.Text = "Calculado como tuberia corrugada"
        Me.RB_CT.UseVisualStyleBackColor = True
        '
        'RB_VD
        '
        Me.RB_VD.AutoSize = True
        Me.RB_VD.Location = New System.Drawing.Point(520, 7)
        Me.RB_VD.Name = "RB_VD"
        Me.RB_VD.Size = New System.Drawing.Size(166, 20)
        Me.RB_VD.TabIndex = 387
        Me.RB_VD.Text = "Valor fijo por diseño"
        Me.RB_VD.UseVisualStyleBackColor = True
        '
        'RB_TC
        '
        Me.RB_TC.AutoSize = True
        Me.RB_TC.Location = New System.Drawing.Point(228, 7)
        Me.RB_TC.Name = "RB_TC"
        Me.RB_TC.Size = New System.Drawing.Size(286, 20)
        Me.RB_TC.TabIndex = 386
        Me.RB_TC.Text = "Calculado como tuberia convencional"
        Me.RB_TC.UseVisualStyleBackColor = True
        '
        'TBPitch
        '
        Me.TBPitch.Location = New System.Drawing.Point(493, 145)
        Me.TBPitch.Name = "TBPitch"
        Me.TBPitch.Size = New System.Drawing.Size(100, 22)
        Me.TBPitch.TabIndex = 385
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(407, 148)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 16)
        Me.Label27.TabIndex = 384
        Me.Label27.Text = "Pitch (mm)"
        '
        'TBEngroso
        '
        Me.TBEngroso.Location = New System.Drawing.Point(196, 145)
        Me.TBEngroso.Name = "TBEngroso"
        Me.TBEngroso.Size = New System.Drawing.Size(100, 22)
        Me.TBEngroso.TabIndex = 383
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(51, 148)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(139, 16)
        Me.Label28.TabIndex = 382
        Me.Label28.Text = "Engrosamiento (%)"
        '
        'TBLongEngroso
        '
        Me.TBLongEngroso.Location = New System.Drawing.Point(493, 117)
        Me.TBLongEngroso.Name = "TBLongEngroso"
        Me.TBLongEngroso.Size = New System.Drawing.Size(100, 22)
        Me.TBLongEngroso.TabIndex = 381
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(308, 120)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(179, 16)
        Me.Label25.TabIndex = 380
        Me.Label25.Text = "Longitud Engrosam. (cm)"
        '
        'TBGama
        '
        Me.TBGama.Location = New System.Drawing.Point(493, 173)
        Me.TBGama.Name = "TBGama"
        Me.TBGama.Size = New System.Drawing.Size(100, 22)
        Me.TBGama.TabIndex = 379
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(93, 117)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(97, 16)
        Me.Label26.TabIndex = 378
        Me.Label26.Text = "Longitud (Mt)"
        '
        'TBDiamMax
        '
        Me.TBDiamMax.Location = New System.Drawing.Point(493, 89)
        Me.TBDiamMax.Name = "TBDiamMax"
        Me.TBDiamMax.Size = New System.Drawing.Size(100, 22)
        Me.TBDiamMax.TabIndex = 377
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(342, 92)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(145, 16)
        Me.Label23.TabIndex = 376
        Me.Label23.Text = "Diámetro Max. (mm)"
        '
        'TBArea
        '
        Me.TBArea.Location = New System.Drawing.Point(196, 173)
        Me.TBArea.Name = "TBArea"
        Me.TBArea.Size = New System.Drawing.Size(100, 22)
        Me.TBArea.TabIndex = 375
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.BackColor = System.Drawing.SystemColors.Control
        Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label24.Location = New System.Drawing.Point(49, 92)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(141, 16)
        Me.label24.TabIndex = 374
        Me.label24.Text = "Diámetro Min. (mm)"
        '
        'TBEMN
        '
        Me.TBEMN.Location = New System.Drawing.Point(196, 61)
        Me.TBEMN.Name = "TBEMN"
        Me.TBEMN.Size = New System.Drawing.Size(100, 22)
        Me.TBEMN.TabIndex = 373
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label.Location = New System.Drawing.Point(4, 64)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(186, 16)
        Me.Label.TabIndex = 372
        Me.Label.Text = "Espesor Min. Norma (mm)"
        '
        'TBExpMax
        '
        Me.TBExpMax.Location = New System.Drawing.Point(493, 33)
        Me.TBExpMax.Name = "TBExpMax"
        Me.TBExpMax.Size = New System.Drawing.Size(100, 22)
        Me.TBExpMax.TabIndex = 371
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(347, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(140, 16)
        Me.Label13.TabIndex = 370
        Me.Label13.Text = "Espesor Max. (mm)"
        '
        'TBEMT
        '
        Me.TBEMT.Location = New System.Drawing.Point(196, 33)
        Me.TBEMT.Name = "TBEMT"
        Me.TBEMT.Size = New System.Drawing.Size(100, 22)
        Me.TBEMT.TabIndex = 369
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(13, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(177, 16)
        Me.Label21.TabIndex = 368
        Me.Label21.Text = "Espesor Min. Trab. (mm)"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(682, 120)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(178, 16)
        Me.Label20.TabIndex = 367
        Me.Label20.Text = "% Sobre Peso Promedio"
        '
        'TSobProm
        '
        Me.TSobProm.Location = New System.Drawing.Point(866, 117)
        Me.TSobProm.Name = "TSobProm"
        Me.TSobProm.Size = New System.Drawing.Size(100, 22)
        Me.TSobProm.TabIndex = 366
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(687, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(173, 16)
        Me.Label19.TabIndex = 365
        Me.Label19.Text = "% Sobre Peso Historico"
        '
        'TSobHist
        '
        Me.TSobHist.Location = New System.Drawing.Point(866, 89)
        Me.TSobHist.Name = "TSobHist"
        Me.TSobHist.Size = New System.Drawing.Size(100, 22)
        Me.TSobHist.TabIndex = 364
        '
        'TLongitud
        '
        Me.TLongitud.Location = New System.Drawing.Point(196, 117)
        Me.TLongitud.Name = "TLongitud"
        Me.TLongitud.Size = New System.Drawing.Size(100, 22)
        Me.TLongitud.TabIndex = 363
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(350, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 16)
        Me.Label7.TabIndex = 362
        Me.Label7.Text = "% Correción Gama"
        '
        'TDiametro
        '
        Me.TDiametro.Location = New System.Drawing.Point(196, 89)
        Me.TDiametro.Name = "TDiametro"
        Me.TDiametro.Size = New System.Drawing.Size(100, 22)
        Me.TDiametro.TabIndex = 361
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(103, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 360
        Me.Label6.Text = "Area (mm2)"
        '
        'TSobrepeso
        '
        Me.TSobrepeso.Location = New System.Drawing.Point(866, 145)
        Me.TSobrepeso.Name = "TSobrepeso"
        Me.TSobrepeso.Size = New System.Drawing.Size(100, 22)
        Me.TSobrepeso.TabIndex = 359
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(720, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 16)
        Me.Label5.TabIndex = 358
        Me.Label5.Text = "% Meta Sobrepeso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(673, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 16)
        Me.Label4.TabIndex = 357
        Me.Label4.Text = "Peso Standart (Real) Kgs."
        '
        'TPesoStn
        '
        Me.TPesoStn.Location = New System.Drawing.Point(866, 33)
        Me.TPesoStn.Name = "TPesoStn"
        Me.TPesoStn.Size = New System.Drawing.Size(100, 22)
        Me.TPesoStn.TabIndex = 356
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(724, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 355
        Me.Label3.Text = "Peso Teorico Kgs."
        '
        'TPesoTeo
        '
        Me.TPesoTeo.Location = New System.Drawing.Point(866, 61)
        Me.TPesoTeo.Name = "TPesoTeo"
        Me.TPesoTeo.Size = New System.Drawing.Size(100, 22)
        Me.TPesoTeo.TabIndex = 354
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TCod_UsoMaq)
        Me.TabPage3.Controls.Add(Me.TCod_Area)
        Me.TabPage3.Controls.Add(Me.TCod_Seccion)
        Me.TabPage3.Controls.Add(Me.TCod_TipoComp)
        Me.TabPage3.Controls.Add(Me.TCod_GrpDiam)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.CB_TipoComp)
        Me.TabPage3.Controls.Add(Me.CB_GpoDiam)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.CB_Seccion)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.CB_UsoMaq)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.CB_Area)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(976, 202)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Categorización"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TCod_UsoMaq
        '
        Me.TCod_UsoMaq.Location = New System.Drawing.Point(606, 127)
        Me.TCod_UsoMaq.Name = "TCod_UsoMaq"
        Me.TCod_UsoMaq.ReadOnly = True
        Me.TCod_UsoMaq.Size = New System.Drawing.Size(70, 22)
        Me.TCod_UsoMaq.TabIndex = 384
        '
        'TCod_Area
        '
        Me.TCod_Area.Location = New System.Drawing.Point(606, 97)
        Me.TCod_Area.Name = "TCod_Area"
        Me.TCod_Area.ReadOnly = True
        Me.TCod_Area.Size = New System.Drawing.Size(70, 22)
        Me.TCod_Area.TabIndex = 383
        '
        'TCod_Seccion
        '
        Me.TCod_Seccion.Location = New System.Drawing.Point(606, 67)
        Me.TCod_Seccion.Name = "TCod_Seccion"
        Me.TCod_Seccion.ReadOnly = True
        Me.TCod_Seccion.Size = New System.Drawing.Size(70, 22)
        Me.TCod_Seccion.TabIndex = 382
        '
        'TCod_TipoComp
        '
        Me.TCod_TipoComp.Location = New System.Drawing.Point(606, 39)
        Me.TCod_TipoComp.Name = "TCod_TipoComp"
        Me.TCod_TipoComp.ReadOnly = True
        Me.TCod_TipoComp.Size = New System.Drawing.Size(70, 22)
        Me.TCod_TipoComp.TabIndex = 381
        '
        'TCod_GrpDiam
        '
        Me.TCod_GrpDiam.Location = New System.Drawing.Point(606, 9)
        Me.TCod_GrpDiam.Name = "TCod_GrpDiam"
        Me.TCod_GrpDiam.ReadOnly = True
        Me.TCod_GrpDiam.Size = New System.Drawing.Size(70, 22)
        Me.TCod_GrpDiam.TabIndex = 380
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(20, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 16)
        Me.Label14.TabIndex = 379
        Me.Label14.Text = "Familia Producto"
        '
        'CB_TipoComp
        '
        Me.CB_TipoComp.FormattingEnabled = True
        Me.CB_TipoComp.Location = New System.Drawing.Point(151, 39)
        Me.CB_TipoComp.Name = "CB_TipoComp"
        Me.CB_TipoComp.Size = New System.Drawing.Size(449, 24)
        Me.CB_TipoComp.TabIndex = 378
        '
        'CB_GpoDiam
        '
        Me.CB_GpoDiam.FormattingEnabled = True
        Me.CB_GpoDiam.Location = New System.Drawing.Point(151, 9)
        Me.CB_GpoDiam.Name = "CB_GpoDiam"
        Me.CB_GpoDiam.Size = New System.Drawing.Size(449, 24)
        Me.CB_GpoDiam.TabIndex = 377
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(35, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 16)
        Me.Label11.TabIndex = 376
        Me.Label11.Text = "Grupo Material"
        '
        'CB_Seccion
        '
        Me.CB_Seccion.FormattingEnabled = True
        Me.CB_Seccion.Location = New System.Drawing.Point(151, 67)
        Me.CB_Seccion.Name = "CB_Seccion"
        Me.CB_Seccion.Size = New System.Drawing.Size(449, 24)
        Me.CB_Seccion.TabIndex = 375
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(81, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 374
        Me.Label9.Text = "Sección"
        '
        'CB_UsoMaq
        '
        Me.CB_UsoMaq.FormattingEnabled = True
        Me.CB_UsoMaq.Location = New System.Drawing.Point(151, 127)
        Me.CB_UsoMaq.Name = "CB_UsoMaq"
        Me.CB_UsoMaq.Size = New System.Drawing.Size(449, 24)
        Me.CB_UsoMaq.TabIndex = 367
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(46, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 16)
        Me.Label10.TabIndex = 366
        Me.Label10.Text = "Uso Maquina"
        '
        'CB_Area
        '
        Me.CB_Area.FormattingEnabled = True
        Me.CB_Area.Location = New System.Drawing.Point(151, 97)
        Me.CB_Area.Name = "CB_Area"
        Me.CB_Area.Size = New System.Drawing.Size(449, 24)
        Me.CB_Area.TabIndex = 365
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(58, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 364
        Me.Label8.Text = "Grupo RTM"
        '
        'TTotal
        '
        Me.TTotal.Location = New System.Drawing.Point(872, 295)
        Me.TTotal.Name = "TTotal"
        Me.TTotal.ReadOnly = True
        Me.TTotal.Size = New System.Drawing.Size(100, 22)
        Me.TTotal.TabIndex = 370
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(858, 267)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 16)
        Me.Label12.TabIndex = 369
        Me.Label12.Text = "Total Productos "
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(164, 262)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(624, 19)
        Me.Label22.TabIndex = 371
        Me.Label22.Text = "Label22"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CB_SoloPiezas
        '
        Me.CB_SoloPiezas.AutoSize = True
        Me.CB_SoloPiezas.BackColor = System.Drawing.SystemColors.Control
        Me.CB_SoloPiezas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CB_SoloPiezas.Location = New System.Drawing.Point(718, 149)
        Me.CB_SoloPiezas.Name = "CB_SoloPiezas"
        Me.CB_SoloPiezas.Size = New System.Drawing.Size(167, 20)
        Me.CB_SoloPiezas.TabIndex = 395
        Me.CB_SoloPiezas.Text = "Notifica Solo Piezas"
        Me.CB_SoloPiezas.UseVisualStyleBackColor = False
        '
        'CAT_ProductosExtrusion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CAT_ProductosExtrusion"
        Me.Text = "Productos Extrusión"
        Me.Controls.SetChildIndex(Me.DGV, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.TTotal, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CB_State As System.Windows.Forms.CheckBox
    Friend WithEvents TCentro As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TDesProd As System.Windows.Forms.TextBox
    Friend WithEvents TCodProd As System.Windows.Forms.TextBox
    Friend WithEvents CB_CC As System.Windows.Forms.CheckBox
    Friend WithEvents CB_UM As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TSobrepeso As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TPesoStn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TPesoTeo As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TLongitud As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TDiametro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TCodBarr As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CB_TipoComp As System.Windows.Forms.ComboBox
    Friend WithEvents CB_GpoDiam As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CB_Seccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CB_UsoMaq As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CB_Area As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CB_Marcas As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TSobProm As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TSobHist As System.Windows.Forms.TextBox
    Friend WithEvents LCodBarr As System.Windows.Forms.Label
    Friend WithEvents TCod_UM As System.Windows.Forms.TextBox
    Friend WithEvents TBPitch As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TBEngroso As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TBLongEngroso As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TBGama As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TBDiamMax As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TBArea As System.Windows.Forms.TextBox
    Friend WithEvents label24 As System.Windows.Forms.Label
    Friend WithEvents TBEMN As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents TBExpMax As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TBEMT As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents RB_CT As System.Windows.Forms.RadioButton
    Friend WithEvents RB_VD As System.Windows.Forms.RadioButton
    Friend WithEvents RB_TC As System.Windows.Forms.RadioButton
    Friend WithEvents TCod_UsoMaq As System.Windows.Forms.TextBox
    Friend WithEvents TCod_Area As System.Windows.Forms.TextBox
    Friend WithEvents TCod_Seccion As System.Windows.Forms.TextBox
    Friend WithEvents TCod_TipoComp As System.Windows.Forms.TextBox
    Friend WithEvents TCod_GrpDiam As System.Windows.Forms.TextBox
    Friend WithEvents TCod_Marca As System.Windows.Forms.TextBox
    Friend WithEvents TTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TCod_Empaque As System.Windows.Forms.TextBox
    Friend WithEvents CB_EMP As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TCod_Reten As System.Windows.Forms.TextBox
    Friend WithEvents CB_Reten As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents CB_SoloPiezas As System.Windows.Forms.CheckBox
End Class
