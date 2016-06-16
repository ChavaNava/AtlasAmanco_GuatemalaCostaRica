<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAutorizaOrdenesSobrepeso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAutorizaOrdenesSobrepeso))
        Me.Label20 = New System.Windows.Forms.Label
        Me.TCodOperador = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TFolioFinal = New System.Windows.Forms.TextBox
        Me.TNomOperador = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TClaveOperador = New System.Windows.Forms.TextBox
        Me.BActualiza = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.TDocConsNotiSAP = New System.Windows.Forms.TextBox
        Me.TPesoBrutoFinal = New System.Windows.Forms.TextBox
        Me.DRSE = New System.Windows.Forms.DataGrid
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.TPesoBrutoScrap = New System.Windows.Forms.TextBox
        Me.TDocNotiSAP = New System.Windows.Forms.TextBox
        Me.BSalir = New System.Windows.Forms.Button
        Me.btnAutorizascrap = New System.Windows.Forms.Button
        Me.TFolio = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TUnidadesScrap = New System.Windows.Forms.TextBox
        Me.TUnidadesFinal = New System.Windows.Forms.TextBox
        Me.TUnidadesNeto = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.btnLooktcar = New System.Windows.Forms.Button
        Me.Desccausa = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TCausas = New System.Windows.Forms.TextBox
        Me.TPesoScrap = New System.Windows.Forms.TextBox
        Me.TPerScrap = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TPesoFinal = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TPesoNeto = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAutoriza = New System.Windows.Forms.Button
        Me.TPorFinal = New System.Windows.Forms.TextBox
        Me.TDescrPTerminado = New System.Windows.Forms.TextBox
        Me.TGrpprod = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TFechaPesaje = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TPTerminado = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TOproduccion = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DRSE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(108, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 16)
        Me.Label20.TabIndex = 109
        Me.Label20.Text = "Folio"
        '
        'TCodOperador
        '
        Me.TCodOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodOperador.Location = New System.Drawing.Point(189, 57)
        Me.TCodOperador.MaxLength = 10
        Me.TCodOperador.Name = "TCodOperador"
        Me.TCodOperador.ReadOnly = True
        Me.TCodOperador.Size = New System.Drawing.Size(70, 20)
        Me.TCodOperador.TabIndex = 200
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 201
        Me.Label4.Text = "Clave Op."
        '
        'TFolioFinal
        '
        Me.TFolioFinal.BackColor = System.Drawing.Color.White
        Me.TFolioFinal.Location = New System.Drawing.Point(169, 23)
        Me.TFolioFinal.Name = "TFolioFinal"
        Me.TFolioFinal.ReadOnly = True
        Me.TFolioFinal.Size = New System.Drawing.Size(116, 20)
        Me.TFolioFinal.TabIndex = 108
        '
        'TNomOperador
        '
        Me.TNomOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNomOperador.Location = New System.Drawing.Point(265, 56)
        Me.TNomOperador.Name = "TNomOperador"
        Me.TNomOperador.ReadOnly = True
        Me.TNomOperador.Size = New System.Drawing.Size(259, 20)
        Me.TNomOperador.TabIndex = 202
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Notificación"
        '
        'TClaveOperador
        '
        Me.TClaveOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TClaveOperador.Location = New System.Drawing.Point(108, 56)
        Me.TClaveOperador.MaxLength = 10
        Me.TClaveOperador.Name = "TClaveOperador"
        Me.TClaveOperador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TClaveOperador.Size = New System.Drawing.Size(75, 20)
        Me.TClaveOperador.TabIndex = 203
        '
        'BActualiza
        '
        Me.BActualiza.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BActualiza.Image = CType(resources.GetObject("BActualiza.Image"), System.Drawing.Image)
        Me.BActualiza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BActualiza.Location = New System.Drawing.Point(815, 12)
        Me.BActualiza.Name = "BActualiza"
        Me.BActualiza.Size = New System.Drawing.Size(57, 57)
        Me.BActualiza.TabIndex = 181
        Me.BActualiza.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 16)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Cons. Notificación"
        '
        'TDocConsNotiSAP
        '
        Me.TDocConsNotiSAP.BackColor = System.Drawing.Color.White
        Me.TDocConsNotiSAP.Location = New System.Drawing.Point(169, 75)
        Me.TDocConsNotiSAP.Name = "TDocConsNotiSAP"
        Me.TDocConsNotiSAP.ReadOnly = True
        Me.TDocConsNotiSAP.Size = New System.Drawing.Size(116, 20)
        Me.TDocConsNotiSAP.TabIndex = 102
        '
        'TPesoBrutoFinal
        '
        Me.TPesoBrutoFinal.BackColor = System.Drawing.SystemColors.Control
        Me.TPesoBrutoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPesoBrutoFinal.Location = New System.Drawing.Point(436, 113)
        Me.TPesoBrutoFinal.Name = "TPesoBrutoFinal"
        Me.TPesoBrutoFinal.ReadOnly = True
        Me.TPesoBrutoFinal.Size = New System.Drawing.Size(59, 22)
        Me.TPesoBrutoFinal.TabIndex = 197
        Me.TPesoBrutoFinal.Visible = False
        '
        'DRSE
        '
        Me.DRSE.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DRSE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DRSE.BackColor = System.Drawing.Color.White
        Me.DRSE.CaptionBackColor = System.Drawing.Color.Maroon
        Me.DRSE.CaptionFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DRSE.CaptionForeColor = System.Drawing.Color.White
        Me.DRSE.CaptionText = "Detalle Registros SEPARADOS Extrusión "
        Me.DRSE.DataMember = ""
        Me.DRSE.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DRSE.ForeColor = System.Drawing.Color.Black
        Me.DRSE.GridLineColor = System.Drawing.Color.Silver
        Me.DRSE.HeaderBackColor = System.Drawing.Color.Silver
        Me.DRSE.HeaderFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DRSE.HeaderForeColor = System.Drawing.Color.Black
        Me.DRSE.LinkColor = System.Drawing.Color.Maroon
        Me.DRSE.Location = New System.Drawing.Point(15, 106)
        Me.DRSE.Name = "DRSE"
        Me.DRSE.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DRSE.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DRSE.ReadOnly = True
        Me.DRSE.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DRSE.SelectionForeColor = System.Drawing.Color.White
        Me.DRSE.Size = New System.Drawing.Size(978, 191)
        Me.DRSE.TabIndex = 186
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(923, 74)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 17)
        Me.Label26.TabIndex = 184
        Me.Label26.Text = "Salir"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(806, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 17)
        Me.Label19.TabIndex = 185
        Me.Label19.Text = "Consultar"
        '
        'TPesoBrutoScrap
        '
        Me.TPesoBrutoScrap.BackColor = System.Drawing.SystemColors.Control
        Me.TPesoBrutoScrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPesoBrutoScrap.Location = New System.Drawing.Point(327, 202)
        Me.TPesoBrutoScrap.Name = "TPesoBrutoScrap"
        Me.TPesoBrutoScrap.ReadOnly = True
        Me.TPesoBrutoScrap.Size = New System.Drawing.Size(77, 22)
        Me.TPesoBrutoScrap.TabIndex = 196
        Me.TPesoBrutoScrap.Visible = False
        '
        'TDocNotiSAP
        '
        Me.TDocNotiSAP.BackColor = System.Drawing.Color.White
        Me.TDocNotiSAP.Location = New System.Drawing.Point(169, 49)
        Me.TDocNotiSAP.Name = "TDocNotiSAP"
        Me.TDocNotiSAP.ReadOnly = True
        Me.TDocNotiSAP.Size = New System.Drawing.Size(116, 20)
        Me.TDocNotiSAP.TabIndex = 103
        '
        'BSalir
        '
        Me.BSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSalir.BackgroundImage = CType(resources.GetObject("BSalir.BackgroundImage"), System.Drawing.Image)
        Me.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BSalir.Location = New System.Drawing.Point(910, 14)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(67, 58)
        Me.BSalir.TabIndex = 183
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'btnAutorizascrap
        '
        Me.btnAutorizascrap.BackColor = System.Drawing.Color.Red
        Me.btnAutorizascrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutorizascrap.Location = New System.Drawing.Point(502, 142)
        Me.btnAutorizascrap.Name = "btnAutorizascrap"
        Me.btnAutorizascrap.Size = New System.Drawing.Size(130, 24)
        Me.btnAutorizascrap.TabIndex = 195
        Me.btnAutorizascrap.Text = "SCRAP"
        Me.btnAutorizascrap.UseVisualStyleBackColor = False
        '
        'TFolio
        '
        Me.TFolio.BackColor = System.Drawing.Color.LightGray
        Me.TFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFolio.Location = New System.Drawing.Point(327, 112)
        Me.TFolio.Name = "TFolio"
        Me.TFolio.ReadOnly = True
        Me.TFolio.Size = New System.Drawing.Size(103, 26)
        Me.TFolio.TabIndex = 194
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(327, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 18)
        Me.Label18.TabIndex = 193
        Me.Label18.Text = "Folio"
        '
        'TUnidadesScrap
        '
        Me.TUnidadesScrap.BackColor = System.Drawing.SystemColors.Control
        Me.TUnidadesScrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUnidadesScrap.Location = New System.Drawing.Point(108, 204)
        Me.TUnidadesScrap.Name = "TUnidadesScrap"
        Me.TUnidadesScrap.ReadOnly = True
        Me.TUnidadesScrap.Size = New System.Drawing.Size(98, 22)
        Me.TUnidadesScrap.TabIndex = 191
        Me.TUnidadesScrap.Visible = False
        '
        'TUnidadesFinal
        '
        Me.TUnidadesFinal.BackColor = System.Drawing.Color.White
        Me.TUnidadesFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUnidadesFinal.Location = New System.Drawing.Point(108, 147)
        Me.TUnidadesFinal.Name = "TUnidadesFinal"
        Me.TUnidadesFinal.Size = New System.Drawing.Size(98, 22)
        Me.TUnidadesFinal.TabIndex = 190
        '
        'TUnidadesNeto
        '
        Me.TUnidadesNeto.BackColor = System.Drawing.Color.LightGray
        Me.TUnidadesNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUnidadesNeto.Location = New System.Drawing.Point(108, 114)
        Me.TUnidadesNeto.Name = "TUnidadesNeto"
        Me.TUnidadesNeto.ReadOnly = True
        Me.TUnidadesNeto.Size = New System.Drawing.Size(98, 26)
        Me.TUnidadesNeto.TabIndex = 189
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(109, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 18)
        Me.Label16.TabIndex = 188
        Me.Label16.Text = "Tramos (Ud)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TClaveOperador)
        Me.GroupBox2.Controls.Add(Me.TNomOperador)
        Me.GroupBox2.Controls.Add(Me.TCodOperador)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TPesoBrutoFinal)
        Me.GroupBox2.Controls.Add(Me.TPesoBrutoScrap)
        Me.GroupBox2.Controls.Add(Me.btnAutorizascrap)
        Me.GroupBox2.Controls.Add(Me.TFolio)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TUnidadesScrap)
        Me.GroupBox2.Controls.Add(Me.TUnidadesFinal)
        Me.GroupBox2.Controls.Add(Me.TUnidadesNeto)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.btnLooktcar)
        Me.GroupBox2.Controls.Add(Me.Desccausa)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TCausas)
        Me.GroupBox2.Controls.Add(Me.TPesoScrap)
        Me.GroupBox2.Controls.Add(Me.TPerScrap)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TPesoFinal)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TPesoNeto)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.btnAutoriza)
        Me.GroupBox2.Controls.Add(Me.TPorFinal)
        Me.GroupBox2.Controls.Add(Me.TDescrPTerminado)
        Me.GroupBox2.Controls.Add(Me.TGrpprod)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TFechaPesaje)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TPTerminado)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TOproduccion)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 303)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(980, 239)
        Me.GroupBox2.TabIndex = 182
        Me.GroupBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(220, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 18)
        Me.Label15.TabIndex = 187
        Me.Label15.Text = "PESO (Kg)"
        '
        'btnLooktcar
        '
        Me.btnLooktcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLooktcar.Image = CType(resources.GetObject("btnLooktcar.Image"), System.Drawing.Image)
        Me.btnLooktcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLooktcar.Location = New System.Drawing.Point(209, 177)
        Me.btnLooktcar.Name = "btnLooktcar"
        Me.btnLooktcar.Size = New System.Drawing.Size(25, 22)
        Me.btnLooktcar.TabIndex = 186
        Me.btnLooktcar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLooktcar.UseVisualStyleBackColor = True
        '
        'Desccausa
        '
        Me.Desccausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desccausa.Location = New System.Drawing.Point(238, 176)
        Me.Desccausa.Name = "Desccausa"
        Me.Desccausa.ReadOnly = True
        Me.Desccausa.Size = New System.Drawing.Size(257, 22)
        Me.Desccausa.TabIndex = 185
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 184
        Me.Label11.Text = "Causa"
        '
        'TCausas
        '
        Me.TCausas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCausas.Location = New System.Drawing.Point(108, 176)
        Me.TCausas.Name = "TCausas"
        Me.TCausas.Size = New System.Drawing.Size(98, 22)
        Me.TCausas.TabIndex = 183
        '
        'TPesoScrap
        '
        Me.TPesoScrap.BackColor = System.Drawing.SystemColors.Control
        Me.TPesoScrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPesoScrap.Location = New System.Drawing.Point(214, 204)
        Me.TPesoScrap.Name = "TPesoScrap"
        Me.TPesoScrap.ReadOnly = True
        Me.TPesoScrap.Size = New System.Drawing.Size(98, 22)
        Me.TPesoScrap.TabIndex = 181
        Me.TPesoScrap.Visible = False
        '
        'TPerScrap
        '
        Me.TPerScrap.BackColor = System.Drawing.SystemColors.Control
        Me.TPerScrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPerScrap.Location = New System.Drawing.Point(418, 204)
        Me.TPerScrap.Name = "TPerScrap"
        Me.TPerScrap.ReadOnly = True
        Me.TPerScrap.Size = New System.Drawing.Size(77, 22)
        Me.TPerScrap.TabIndex = 179
        Me.TPerScrap.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(406, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 20)
        Me.Label3.TabIndex = 178
        Me.Label3.Text = "%"
        '
        'TPesoFinal
        '
        Me.TPesoFinal.BackColor = System.Drawing.SystemColors.Control
        Me.TPesoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPesoFinal.Location = New System.Drawing.Point(214, 147)
        Me.TPesoFinal.Name = "TPesoFinal"
        Me.TPesoFinal.ReadOnly = True
        Me.TPesoFinal.Size = New System.Drawing.Size(98, 22)
        Me.TPesoFinal.TabIndex = 177
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(45, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 18)
        Me.Label12.TabIndex = 176
        Me.Label12.Text = "NETO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 175
        Me.Label10.Text = "NOTIFICAR"
        '
        'TPesoNeto
        '
        Me.TPesoNeto.BackColor = System.Drawing.Color.LightGray
        Me.TPesoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPesoNeto.Location = New System.Drawing.Point(213, 114)
        Me.TPesoNeto.Name = "TPesoNeto"
        Me.TPesoNeto.ReadOnly = True
        Me.TPesoNeto.Size = New System.Drawing.Size(98, 26)
        Me.TPesoNeto.TabIndex = 174
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.TFolioFinal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TDocConsNotiSAP)
        Me.GroupBox1.Controls.Add(Me.TDocNotiSAP)
        Me.GroupBox1.Location = New System.Drawing.Point(662, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 110)
        Me.GroupBox1.TabIndex = 173
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documentos SAP"
        '
        'btnAutoriza
        '
        Me.btnAutoriza.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAutoriza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoriza.Location = New System.Drawing.Point(502, 113)
        Me.btnAutoriza.Name = "btnAutoriza"
        Me.btnAutoriza.Size = New System.Drawing.Size(130, 24)
        Me.btnAutoriza.TabIndex = 172
        Me.btnAutoriza.Text = "FINAL"
        Me.btnAutoriza.UseVisualStyleBackColor = False
        '
        'TPorFinal
        '
        Me.TPorFinal.BackColor = System.Drawing.SystemColors.Control
        Me.TPorFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPorFinal.Location = New System.Drawing.Point(327, 147)
        Me.TPorFinal.Name = "TPorFinal"
        Me.TPorFinal.ReadOnly = True
        Me.TPorFinal.Size = New System.Drawing.Size(77, 22)
        Me.TPorFinal.TabIndex = 171
        '
        'TDescrPTerminado
        '
        Me.TDescrPTerminado.BackColor = System.Drawing.Color.RoyalBlue
        Me.TDescrPTerminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDescrPTerminado.ForeColor = System.Drawing.Color.White
        Me.TDescrPTerminado.Location = New System.Drawing.Point(256, 15)
        Me.TDescrPTerminado.Name = "TDescrPTerminado"
        Me.TDescrPTerminado.ReadOnly = True
        Me.TDescrPTerminado.Size = New System.Drawing.Size(239, 20)
        Me.TDescrPTerminado.TabIndex = 111
        '
        'TGrpprod
        '
        Me.TGrpprod.BackColor = System.Drawing.Color.RoyalBlue
        Me.TGrpprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGrpprod.ForeColor = System.Drawing.Color.White
        Me.TGrpprod.Location = New System.Drawing.Point(502, 204)
        Me.TGrpprod.Name = "TGrpprod"
        Me.TGrpprod.ReadOnly = True
        Me.TGrpprod.Size = New System.Drawing.Size(57, 20)
        Me.TGrpprod.TabIndex = 108
        Me.TGrpprod.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(517, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Fecha Pesaje"
        '
        'TFechaPesaje
        '
        Me.TFechaPesaje.BackColor = System.Drawing.Color.RoyalBlue
        Me.TFechaPesaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFechaPesaje.ForeColor = System.Drawing.Color.White
        Me.TFechaPesaje.Location = New System.Drawing.Point(595, 16)
        Me.TFechaPesaje.Name = "TFechaPesaje"
        Me.TFechaPesaje.ReadOnly = True
        Me.TFechaPesaje.Size = New System.Drawing.Size(100, 20)
        Me.TFechaPesaje.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Producto"
        '
        'TPTerminado
        '
        Me.TPTerminado.BackColor = System.Drawing.Color.RoyalBlue
        Me.TPTerminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPTerminado.ForeColor = System.Drawing.Color.White
        Me.TPTerminado.Location = New System.Drawing.Point(184, 15)
        Me.TPTerminado.Name = "TPTerminado"
        Me.TPTerminado.ReadOnly = True
        Me.TPTerminado.Size = New System.Drawing.Size(65, 20)
        Me.TPTerminado.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "ODF:"
        '
        'TOproduccion
        '
        Me.TOproduccion.BackColor = System.Drawing.Color.RoyalBlue
        Me.TOproduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOproduccion.ForeColor = System.Drawing.Color.White
        Me.TOproduccion.Location = New System.Drawing.Point(48, 15)
        Me.TOproduccion.Name = "TOproduccion"
        Me.TOproduccion.ReadOnly = True
        Me.TOproduccion.Size = New System.Drawing.Size(77, 20)
        Me.TOproduccion.TabIndex = 100
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(15, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 180
        Me.PictureBox1.TabStop = False
        '
        'FormAutorizaOrdenesSobrepeso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 554)
        Me.Controls.Add(Me.BActualiza)
        Me.Controls.Add(Me.DRSE)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormAutorizaOrdenesSobrepeso"
        Me.Text = "FormAutorizaOrdenesSobrepeso"
        CType(Me.DRSE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TCodOperador As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TFolioFinal As System.Windows.Forms.TextBox
    Friend WithEvents TNomOperador As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TClaveOperador As System.Windows.Forms.TextBox
    Friend WithEvents BActualiza As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TDocConsNotiSAP As System.Windows.Forms.TextBox
    Friend WithEvents TPesoBrutoFinal As System.Windows.Forms.TextBox
    Friend WithEvents DRSE As System.Windows.Forms.DataGrid
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TPesoBrutoScrap As System.Windows.Forms.TextBox
    Friend WithEvents TDocNotiSAP As System.Windows.Forms.TextBox
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents btnAutorizascrap As System.Windows.Forms.Button
    Friend WithEvents TFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TUnidadesScrap As System.Windows.Forms.TextBox
    Friend WithEvents TUnidadesFinal As System.Windows.Forms.TextBox
    Friend WithEvents TUnidadesNeto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnLooktcar As System.Windows.Forms.Button
    Friend WithEvents Desccausa As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TCausas As System.Windows.Forms.TextBox
    Friend WithEvents TPesoScrap As System.Windows.Forms.TextBox
    Friend WithEvents TPerScrap As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TPesoFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TPesoNeto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAutoriza As System.Windows.Forms.Button
    Friend WithEvents TPorFinal As System.Windows.Forms.TextBox
    Friend WithEvents TDescrPTerminado As System.Windows.Forms.TextBox
    Friend WithEvents TGrpprod As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TFechaPesaje As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TPTerminado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TOproduccion As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
