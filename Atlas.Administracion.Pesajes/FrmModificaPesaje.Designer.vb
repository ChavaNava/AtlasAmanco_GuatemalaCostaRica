<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificaPesaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificaPesaje))
        Me.GB_Pesajes = New System.Windows.Forms.GroupBox()
        Me.PModifica = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TCantEmp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TTP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TSBPeso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBC2 = New System.Windows.Forms.ComboBox()
        Me.CBC1 = New System.Windows.Forms.ComboBox()
        Me.TKC2 = New System.Windows.Forms.TextBox()
        Me.TKC1 = New System.Windows.Forms.TextBox()
        Me.TPC2 = New System.Windows.Forms.TextBox()
        Me.TPC1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TPEmp = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TPesoNeto = New System.Windows.Forms.TextBox()
        Me.TPesoBruto = New System.Windows.Forms.TextBox()
        Me.lblRack = New System.Windows.Forms.Label()
        Me.TPesoRack = New System.Windows.Forms.TextBox()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.TtramosNoti = New System.Windows.Forms.TextBox()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.TcodPt = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TFolioAtlas = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TSI_Cerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSI_Modifica = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSI_Cancela = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSI_Guarda = New System.Windows.Forms.ToolStripMenuItem()
        Me.Consulta = New Atlas.Administracion.Pesajes.Consulta()
        Me.Usr_DGV1 = New Atlas.Administracion.Pesajes.Usr_DGV()
        Me.GB_Pesajes.SuspendLayout()
        Me.PModifica.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_Pesajes
        '
        Me.GB_Pesajes.Controls.Add(Me.Usr_DGV1)
        Me.GB_Pesajes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GB_Pesajes.Location = New System.Drawing.Point(0, 370)
        Me.GB_Pesajes.Name = "GB_Pesajes"
        Me.GB_Pesajes.Size = New System.Drawing.Size(1211, 282)
        Me.GB_Pesajes.TabIndex = 5
        Me.GB_Pesajes.TabStop = False
        Me.GB_Pesajes.Text = "Pesajes"
        '
        'PModifica
        '
        Me.PModifica.Controls.Add(Me.Label5)
        Me.PModifica.Controls.Add(Me.TCantEmp)
        Me.PModifica.Controls.Add(Me.Label4)
        Me.PModifica.Controls.Add(Me.TTP)
        Me.PModifica.Controls.Add(Me.Label3)
        Me.PModifica.Controls.Add(Me.TSBPeso)
        Me.PModifica.Controls.Add(Me.Label2)
        Me.PModifica.Controls.Add(Me.Label1)
        Me.PModifica.Controls.Add(Me.CBC2)
        Me.PModifica.Controls.Add(Me.CBC1)
        Me.PModifica.Controls.Add(Me.TKC2)
        Me.PModifica.Controls.Add(Me.TKC1)
        Me.PModifica.Controls.Add(Me.TPC2)
        Me.PModifica.Controls.Add(Me.TPC1)
        Me.PModifica.Controls.Add(Me.Label18)
        Me.PModifica.Controls.Add(Me.Label17)
        Me.PModifica.Controls.Add(Me.Label16)
        Me.PModifica.Controls.Add(Me.Label15)
        Me.PModifica.Controls.Add(Me.Label23)
        Me.PModifica.Controls.Add(Me.TPEmp)
        Me.PModifica.Controls.Add(Me.Label20)
        Me.PModifica.Controls.Add(Me.Label19)
        Me.PModifica.Controls.Add(Me.TPesoNeto)
        Me.PModifica.Controls.Add(Me.TPesoBruto)
        Me.PModifica.Controls.Add(Me.lblRack)
        Me.PModifica.Controls.Add(Me.TPesoRack)
        Me.PModifica.Controls.Add(Me.Label144)
        Me.PModifica.Controls.Add(Me.TtramosNoti)
        Me.PModifica.Controls.Add(Me.TOrden)
        Me.PModifica.Controls.Add(Me.TcodPt)
        Me.PModifica.Controls.Add(Me.Label22)
        Me.PModifica.Controls.Add(Me.Label13)
        Me.PModifica.Controls.Add(Me.Label12)
        Me.PModifica.Controls.Add(Me.TFolioAtlas)
        Me.PModifica.Enabled = False
        Me.PModifica.Location = New System.Drawing.Point(316, 45)
        Me.PModifica.Name = "PModifica"
        Me.PModifica.Size = New System.Drawing.Size(895, 319)
        Me.PModifica.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(271, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 19)
        Me.Label5.TabIndex = 321
        Me.Label5.Text = "Cantidad Empaques"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TCantEmp
        '
        Me.TCantEmp.Location = New System.Drawing.Point(455, 44)
        Me.TCantEmp.Name = "TCantEmp"
        Me.TCantEmp.ReadOnly = True
        Me.TCantEmp.Size = New System.Drawing.Size(95, 22)
        Me.TCantEmp.TabIndex = 322
        Me.TCantEmp.Text = "0"
        Me.TCantEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(28, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 320
        Me.Label4.Text = "Tipo Producción"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TTP
        '
        Me.TTP.Location = New System.Drawing.Point(157, 72)
        Me.TTP.Name = "TTP"
        Me.TTP.ReadOnly = True
        Me.TTP.Size = New System.Drawing.Size(95, 22)
        Me.TTP.TabIndex = 319
        Me.TTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(638, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 318
        Me.Label3.Text = "Sobre/Bajo Peso"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TSBPeso
        '
        Me.TSBPeso.Location = New System.Drawing.Point(788, 100)
        Me.TSBPeso.Name = "TSBPeso"
        Me.TSBPeso.ReadOnly = True
        Me.TSBPeso.Size = New System.Drawing.Size(95, 22)
        Me.TSBPeso.TabIndex = 317
        Me.TSBPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 316
        Me.Label2.Text = "Porcentaje"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 315
        Me.Label1.Text = "Kilos"
        '
        'CBC2
        '
        Me.CBC2.FormattingEnabled = True
        Me.CBC2.Location = New System.Drawing.Point(157, 228)
        Me.CBC2.Name = "CBC2"
        Me.CBC2.Size = New System.Drawing.Size(480, 24)
        Me.CBC2.TabIndex = 312
        '
        'CBC1
        '
        Me.CBC1.FormattingEnabled = True
        Me.CBC1.Location = New System.Drawing.Point(157, 144)
        Me.CBC1.Name = "CBC1"
        Me.CBC1.Size = New System.Drawing.Size(480, 24)
        Me.CBC1.TabIndex = 311
        '
        'TKC2
        '
        Me.TKC2.BackColor = System.Drawing.SystemColors.Window
        Me.TKC2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TKC2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TKC2.Location = New System.Drawing.Point(157, 256)
        Me.TKC2.MaxLength = 10
        Me.TKC2.Name = "TKC2"
        Me.TKC2.ReadOnly = True
        Me.TKC2.Size = New System.Drawing.Size(88, 22)
        Me.TKC2.TabIndex = 310
        Me.TKC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TKC1
        '
        Me.TKC1.BackColor = System.Drawing.SystemColors.Window
        Me.TKC1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TKC1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TKC1.Location = New System.Drawing.Point(157, 172)
        Me.TKC1.MaxLength = 10
        Me.TKC1.Name = "TKC1"
        Me.TKC1.ReadOnly = True
        Me.TKC1.Size = New System.Drawing.Size(88, 22)
        Me.TKC1.TabIndex = 309
        Me.TKC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TPC2
        '
        Me.TPC2.BackColor = System.Drawing.SystemColors.Window
        Me.TPC2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TPC2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TPC2.Location = New System.Drawing.Point(157, 284)
        Me.TPC2.MaxLength = 10
        Me.TPC2.Name = "TPC2"
        Me.TPC2.ReadOnly = True
        Me.TPC2.Size = New System.Drawing.Size(88, 22)
        Me.TPC2.TabIndex = 308
        Me.TPC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TPC1
        '
        Me.TPC1.BackColor = System.Drawing.SystemColors.Window
        Me.TPC1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TPC1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TPC1.Location = New System.Drawing.Point(157, 200)
        Me.TPC1.MaxLength = 10
        Me.TPC1.Name = "TPC1"
        Me.TPC1.Size = New System.Drawing.Size(88, 22)
        Me.TPC1.TabIndex = 307
        Me.TPC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(109, 175)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 16)
        Me.Label18.TabIndex = 306
        Me.Label18.Text = "Kilos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(68, 203)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 16)
        Me.Label17.TabIndex = 305
        Me.Label17.Text = "Porcentaje"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(41, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 17)
        Me.Label16.TabIndex = 304
        Me.Label16.Text = "Compuesto 2"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(41, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 17)
        Me.Label15.TabIndex = 302
        Me.Label15.Text = "Compuesto 1"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(656, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(126, 19)
        Me.Label23.TabIndex = 299
        Me.Label23.Text = "Peso Empaques"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TPEmp
        '
        Me.TPEmp.Location = New System.Drawing.Point(788, 16)
        Me.TPEmp.Name = "TPEmp"
        Me.TPEmp.ReadOnly = True
        Me.TPEmp.Size = New System.Drawing.Size(95, 22)
        Me.TPEmp.TabIndex = 300
        Me.TPEmp.Text = "0"
        Me.TPEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(701, 47)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 16)
        Me.Label20.TabIndex = 294
        Me.Label20.Text = "Peso Neto"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(365, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 16)
        Me.Label19.TabIndex = 292
        Me.Label19.Text = "Peso Bruto"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TPesoNeto
        '
        Me.TPesoNeto.Location = New System.Drawing.Point(788, 44)
        Me.TPesoNeto.Name = "TPesoNeto"
        Me.TPesoNeto.ReadOnly = True
        Me.TPesoNeto.Size = New System.Drawing.Size(95, 22)
        Me.TPesoNeto.TabIndex = 290
        Me.TPesoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TPesoBruto
        '
        Me.TPesoBruto.Location = New System.Drawing.Point(455, 69)
        Me.TPesoBruto.Name = "TPesoBruto"
        Me.TPesoBruto.Size = New System.Drawing.Size(95, 22)
        Me.TPesoBruto.TabIndex = 291
        Me.TPesoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRack
        '
        Me.lblRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRack.ForeColor = System.Drawing.Color.Black
        Me.lblRack.Location = New System.Drawing.Point(342, 99)
        Me.lblRack.Name = "lblRack"
        Me.lblRack.Size = New System.Drawing.Size(107, 19)
        Me.lblRack.TabIndex = 297
        Me.lblRack.Text = "Peso Tara"
        Me.lblRack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TPesoRack
        '
        Me.TPesoRack.Location = New System.Drawing.Point(455, 97)
        Me.TPesoRack.Name = "TPesoRack"
        Me.TPesoRack.Size = New System.Drawing.Size(95, 22)
        Me.TPesoRack.TabIndex = 298
        Me.TPesoRack.Text = "0"
        Me.TPesoRack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label144
        '
        Me.Label144.Location = New System.Drawing.Point(328, 19)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(121, 16)
        Me.Label144.TabIndex = 296
        Me.Label144.Text = "Cantidad Piezas"
        Me.Label144.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TtramosNoti
        '
        Me.TtramosNoti.BackColor = System.Drawing.SystemColors.Window
        Me.TtramosNoti.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TtramosNoti.Location = New System.Drawing.Point(455, 16)
        Me.TtramosNoti.MaxLength = 10
        Me.TtramosNoti.Name = "TtramosNoti"
        Me.TtramosNoti.Size = New System.Drawing.Size(95, 22)
        Me.TtramosNoti.TabIndex = 295
        Me.TtramosNoti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TOrden
        '
        Me.TOrden.Location = New System.Drawing.Point(157, 16)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.ReadOnly = True
        Me.TOrden.Size = New System.Drawing.Size(95, 22)
        Me.TOrden.TabIndex = 285
        Me.TOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TcodPt
        '
        Me.TcodPt.Location = New System.Drawing.Point(157, 44)
        Me.TcodPt.Name = "TcodPt"
        Me.TcodPt.ReadOnly = True
        Me.TcodPt.Size = New System.Drawing.Size(95, 22)
        Me.TcodPt.TabIndex = 287
        Me.TcodPt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(33, 47)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(118, 16)
        Me.Label22.TabIndex = 288
        Me.Label22.Text = "Código Material"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(19, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 16)
        Me.Label13.TabIndex = 286
        Me.Label13.Text = "Orden Producción"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(108, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 284
        Me.Label12.Text = "Folio"
        '
        'TFolioAtlas
        '
        Me.TFolioAtlas.Location = New System.Drawing.Point(157, 100)
        Me.TFolioAtlas.Name = "TFolioAtlas"
        Me.TFolioAtlas.ReadOnly = True
        Me.TFolioAtlas.Size = New System.Drawing.Size(95, 22)
        Me.TFolioAtlas.TabIndex = 283
        Me.TFolioAtlas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSI_Cerrar, Me.TSI_Modifica, Me.TSI_Cancela, Me.TSI_Guarda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1211, 38)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TSI_Cerrar
        '
        Me.TSI_Cerrar.Image = CType(resources.GetObject("TSI_Cerrar.Image"), System.Drawing.Image)
        Me.TSI_Cerrar.Name = "TSI_Cerrar"
        Me.TSI_Cerrar.Size = New System.Drawing.Size(92, 34)
        Me.TSI_Cerrar.Text = "Cerrar"
        '
        'TSI_Modifica
        '
        Me.TSI_Modifica.Image = CType(resources.GetObject("TSI_Modifica.Image"), System.Drawing.Image)
        Me.TSI_Modifica.Name = "TSI_Modifica"
        Me.TSI_Modifica.Size = New System.Drawing.Size(109, 34)
        Me.TSI_Modifica.Text = "Modificar"
        '
        'TSI_Cancela
        '
        Me.TSI_Cancela.Image = CType(resources.GetObject("TSI_Cancela.Image"), System.Drawing.Image)
        Me.TSI_Cancela.Name = "TSI_Cancela"
        Me.TSI_Cancela.Size = New System.Drawing.Size(106, 34)
        Me.TSI_Cancela.Text = "Cancelar"
        '
        'TSI_Guarda
        '
        Me.TSI_Guarda.Image = CType(resources.GetObject("TSI_Guarda.Image"), System.Drawing.Image)
        Me.TSI_Guarda.Name = "TSI_Guarda"
        Me.TSI_Guarda.Size = New System.Drawing.Size(102, 34)
        Me.TSI_Guarda.Text = "Guardar"
        '
        'Consulta
        '
        Me.Consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consulta.Location = New System.Drawing.Point(0, 42)
        Me.Consulta.Margin = New System.Windows.Forms.Padding(4)
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Size = New System.Drawing.Size(303, 277)
        Me.Consulta.TabIndex = 8
        '
        'Usr_DGV1
        '
        Me.Usr_DGV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Usr_DGV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_DGV1.Location = New System.Drawing.Point(3, 18)
        Me.Usr_DGV1.Margin = New System.Windows.Forms.Padding(4)
        Me.Usr_DGV1.Name = "Usr_DGV1"
        Me.Usr_DGV1.Size = New System.Drawing.Size(1205, 261)
        Me.Usr_DGV1.TabIndex = 0
        '
        'FrmModificaPesaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 652)
        Me.Controls.Add(Me.PModifica)
        Me.Controls.Add(Me.Consulta)
        Me.Controls.Add(Me.GB_Pesajes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmModificaPesaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GB_Pesajes.ResumeLayout(False)
        Me.PModifica.ResumeLayout(False)
        Me.PModifica.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv1 As Atlas.Administracion.Pesajes.Usr_DGV
    Friend WithEvents GB_Pesajes As System.Windows.Forms.GroupBox
    Friend WithEvents Usr_DGV1 As Atlas.Administracion.Pesajes.Usr_DGV
    Friend WithEvents Consulta As Atlas.Administracion.Pesajes.Consulta
    Friend WithEvents PModifica As System.Windows.Forms.Panel
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents TcodPt As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TFolioAtlas As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TPEmp As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TPesoNeto As System.Windows.Forms.TextBox
    Friend WithEvents TPesoBruto As System.Windows.Forms.TextBox
    Friend WithEvents lblRack As System.Windows.Forms.Label
    Friend WithEvents TPesoRack As System.Windows.Forms.TextBox
    Friend WithEvents Label144 As System.Windows.Forms.Label
    Friend WithEvents TtramosNoti As System.Windows.Forms.TextBox
    Friend WithEvents TKC2 As System.Windows.Forms.TextBox
    Friend WithEvents TKC1 As System.Windows.Forms.TextBox
    Friend WithEvents TPC2 As System.Windows.Forms.TextBox
    Friend WithEvents TPC1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CBC2 As System.Windows.Forms.ComboBox
    Friend WithEvents CBC1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TSBPeso As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TSI_Cerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSI_Modifica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSI_Cancela As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSI_Guarda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TTP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TCantEmp As System.Windows.Forms.TextBox

End Class
