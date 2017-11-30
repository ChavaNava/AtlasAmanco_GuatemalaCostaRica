<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultasExt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultasExt))
        Me.Btn_Cerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Elimina = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Export = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Btn_Imprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GB_Msges = New System.Windows.Forms.GroupBox()
        Me.TObservaciones = New System.Windows.Forms.TextBox()
        Me.TMensajes = New System.Windows.Forms.TextBox()
        Me.GB_Consulta = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TOrdProd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.GB_Not = New System.Windows.Forms.GroupBox()
        Me.lblGraba = New System.Windows.Forms.Label()
        Me.Btn_Notif = New System.Windows.Forms.Button()
        Me.TPN = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TTramos = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GB_Totales = New System.Windows.Forms.GroupBox()
        Me.TScrapPorc = New System.Windows.Forms.TextBox()
        Me.TSobPesoPorc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TScrapPurPorc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TScrapPurKilos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TScrapKilos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TSobPesoKilos = New System.Windows.Forms.TextBox()
        Me.TProcUnidades = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TProcKilos = New System.Windows.Forms.TextBox()
        Me.TProdUnidades = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TProdKilos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GB_Cant = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TPend = New System.Windows.Forms.TextBox()
        Me.TProc = New System.Windows.Forms.TextBox()
        Me.TEnt = New System.Windows.Forms.TextBox()
        Me.TProg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GB_Pesajes = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GB_Msges.SuspendLayout()
        Me.GB_Consulta.SuspendLayout()
        Me.GB_Not.SuspendLayout()
        Me.GB_Totales.SuspendLayout()
        Me.GB_Cant.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GB_Pesajes.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Image = CType(resources.GetObject("Btn_Cerrar.Image"), System.Drawing.Image)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(82, 24)
        Me.Btn_Cerrar.Text = "Cerrar"
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = CType(resources.GetObject("Btn_Consulta.Image"), System.Drawing.Image)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(96, 24)
        Me.Btn_Consulta.Text = "Consulta"
        '
        'Btn_Elimina
        '
        Me.Btn_Elimina.Image = CType(resources.GetObject("Btn_Elimina.Image"), System.Drawing.Image)
        Me.Btn_Elimina.Name = "Btn_Elimina"
        Me.Btn_Elimina.Size = New System.Drawing.Size(141, 24)
        Me.Btn_Elimina.Text = "Reversa Pesaje"
        '
        'Btn_Export
        '
        Me.Btn_Export.Image = CType(resources.GetObject("Btn_Export.Image"), System.Drawing.Image)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(138, 24)
        Me.Btn_Export.Text = "Exporta a Excel"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Cerrar, Me.Btn_Consulta, Me.Btn_Elimina, Me.Btn_Imprimir, Me.Btn_Export})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1684, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Image = Global.Atlas.My.Resources.Resources.imprimir
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(138, 24)
        Me.Btn_Imprimir.Text = "Imprimir Boleta"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GB_Msges)
        Me.Panel1.Controls.Add(Me.GB_Consulta)
        Me.Panel1.Controls.Add(Me.GB_Not)
        Me.Panel1.Controls.Add(Me.GB_Totales)
        Me.Panel1.Controls.Add(Me.GB_Cant)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1684, 301)
        Me.Panel1.TabIndex = 6
        '
        'GB_Msges
        '
        Me.GB_Msges.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Msges.Controls.Add(Me.TObservaciones)
        Me.GB_Msges.Controls.Add(Me.TMensajes)
        Me.GB_Msges.Location = New System.Drawing.Point(3, 230)
        Me.GB_Msges.Name = "GB_Msges"
        Me.GB_Msges.Size = New System.Drawing.Size(1684, 58)
        Me.GB_Msges.TabIndex = 12
        Me.GB_Msges.TabStop = False
        Me.GB_Msges.Text = "Mensajes y Observaciones"
        '
        'TObservaciones
        '
        Me.TObservaciones.Location = New System.Drawing.Point(658, 21)
        Me.TObservaciones.Name = "TObservaciones"
        Me.TObservaciones.ReadOnly = True
        Me.TObservaciones.Size = New System.Drawing.Size(620, 22)
        Me.TObservaciones.TabIndex = 2
        '
        'TMensajes
        '
        Me.TMensajes.Location = New System.Drawing.Point(18, 21)
        Me.TMensajes.Name = "TMensajes"
        Me.TMensajes.ReadOnly = True
        Me.TMensajes.Size = New System.Drawing.Size(620, 22)
        Me.TMensajes.TabIndex = 0
        '
        'GB_Consulta
        '
        Me.GB_Consulta.Controls.Add(Me.Label3)
        Me.GB_Consulta.Controls.Add(Me.TOrdProd)
        Me.GB_Consulta.Controls.Add(Me.Label2)
        Me.GB_Consulta.Controls.Add(Me.DTP_FF)
        Me.GB_Consulta.Controls.Add(Me.Label1)
        Me.GB_Consulta.Controls.Add(Me.DTP_FI)
        Me.GB_Consulta.Location = New System.Drawing.Point(0, 0)
        Me.GB_Consulta.Name = "GB_Consulta"
        Me.GB_Consulta.Size = New System.Drawing.Size(303, 224)
        Me.GB_Consulta.TabIndex = 11
        Me.GB_Consulta.TabStop = False
        Me.GB_Consulta.Text = "Consulta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Orden de Producción"
        '
        'TOrdProd
        '
        Me.TOrdProd.Location = New System.Drawing.Point(176, 37)
        Me.TOrdProd.Name = "TOrdProd"
        Me.TOrdProd.Size = New System.Drawing.Size(109, 22)
        Me.TOrdProd.TabIndex = 21
        Me.TOrdProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(176, 93)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FF.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(176, 65)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(109, 22)
        Me.DTP_FI.TabIndex = 17
        '
        'GB_Not
        '
        Me.GB_Not.Controls.Add(Me.lblGraba)
        Me.GB_Not.Controls.Add(Me.Btn_Notif)
        Me.GB_Not.Controls.Add(Me.TPN)
        Me.GB_Not.Controls.Add(Me.Label18)
        Me.GB_Not.Controls.Add(Me.TTramos)
        Me.GB_Not.Controls.Add(Me.Label17)
        Me.GB_Not.Controls.Add(Me.TOrden)
        Me.GB_Not.Controls.Add(Me.Label16)
        Me.GB_Not.Location = New System.Drawing.Point(1423, 0)
        Me.GB_Not.Name = "GB_Not"
        Me.GB_Not.Size = New System.Drawing.Size(261, 224)
        Me.GB_Not.TabIndex = 8
        Me.GB_Not.TabStop = False
        Me.GB_Not.Text = "Notificación"
        '
        'lblGraba
        '
        Me.lblGraba.AutoSize = True
        Me.lblGraba.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraba.ForeColor = System.Drawing.Color.Black
        Me.lblGraba.Location = New System.Drawing.Point(166, 191)
        Me.lblGraba.Name = "lblGraba"
        Me.lblGraba.Size = New System.Drawing.Size(69, 17)
        Me.lblGraba.TabIndex = 170
        Me.lblGraba.Text = "Notificar"
        '
        'Btn_Notif
        '
        Me.Btn_Notif.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Notif.BackgroundImage = Global.Atlas.My.Resources.Resources.sap_notificar
        Me.Btn_Notif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Notif.Enabled = False
        Me.Btn_Notif.Location = New System.Drawing.Point(169, 132)
        Me.Btn_Notif.Name = "Btn_Notif"
        Me.Btn_Notif.Size = New System.Drawing.Size(60, 56)
        Me.Btn_Notif.TabIndex = 168
        Me.Btn_Notif.UseVisualStyleBackColor = False
        '
        'TPN
        '
        Me.TPN.BackColor = System.Drawing.Color.Yellow
        Me.TPN.Location = New System.Drawing.Point(149, 93)
        Me.TPN.Name = "TPN"
        Me.TPN.ReadOnly = True
        Me.TPN.Size = New System.Drawing.Size(100, 22)
        Me.TPN.TabIndex = 44
        Me.TPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 16)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Peso Neto"
        '
        'TTramos
        '
        Me.TTramos.BackColor = System.Drawing.Color.Yellow
        Me.TTramos.Location = New System.Drawing.Point(149, 65)
        Me.TTramos.Name = "TTramos"
        Me.TTramos.ReadOnly = True
        Me.TTramos.Size = New System.Drawing.Size(100, 22)
        Me.TTramos.TabIndex = 42
        Me.TTramos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 16)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Tramos"
        '
        'TOrden
        '
        Me.TOrden.BackColor = System.Drawing.Color.Yellow
        Me.TOrden.Location = New System.Drawing.Point(149, 37)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.ReadOnly = True
        Me.TOrden.Size = New System.Drawing.Size(100, 22)
        Me.TOrden.TabIndex = 40
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 16)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Orden Producción"
        '
        'GB_Totales
        '
        Me.GB_Totales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Totales.Controls.Add(Me.TScrapPorc)
        Me.GB_Totales.Controls.Add(Me.TSobPesoPorc)
        Me.GB_Totales.Controls.Add(Me.Label15)
        Me.GB_Totales.Controls.Add(Me.TScrapPurPorc)
        Me.GB_Totales.Controls.Add(Me.Label14)
        Me.GB_Totales.Controls.Add(Me.TScrapPurKilos)
        Me.GB_Totales.Controls.Add(Me.Label13)
        Me.GB_Totales.Controls.Add(Me.TScrapKilos)
        Me.GB_Totales.Controls.Add(Me.Label12)
        Me.GB_Totales.Controls.Add(Me.TSobPesoKilos)
        Me.GB_Totales.Controls.Add(Me.TProcUnidades)
        Me.GB_Totales.Controls.Add(Me.Label11)
        Me.GB_Totales.Controls.Add(Me.TProcKilos)
        Me.GB_Totales.Controls.Add(Me.TProdUnidades)
        Me.GB_Totales.Controls.Add(Me.Label10)
        Me.GB_Totales.Controls.Add(Me.TProdKilos)
        Me.GB_Totales.Controls.Add(Me.Label9)
        Me.GB_Totales.Controls.Add(Me.Label8)
        Me.GB_Totales.Location = New System.Drawing.Point(571, 0)
        Me.GB_Totales.Name = "GB_Totales"
        Me.GB_Totales.Size = New System.Drawing.Size(846, 224)
        Me.GB_Totales.TabIndex = 9
        Me.GB_Totales.TabStop = False
        Me.GB_Totales.Text = "Totales"
        '
        'TScrapPorc
        '
        Me.TScrapPorc.BackColor = System.Drawing.Color.Red
        Me.TScrapPorc.Location = New System.Drawing.Point(372, 121)
        Me.TScrapPorc.Name = "TScrapPorc"
        Me.TScrapPorc.ReadOnly = True
        Me.TScrapPorc.Size = New System.Drawing.Size(67, 22)
        Me.TScrapPorc.TabIndex = 57
        Me.TScrapPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TSobPesoPorc
        '
        Me.TSobPesoPorc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TSobPesoPorc.Location = New System.Drawing.Point(372, 93)
        Me.TSobPesoPorc.Name = "TSobPesoPorc"
        Me.TSobPesoPorc.ReadOnly = True
        Me.TSobPesoPorc.Size = New System.Drawing.Size(67, 22)
        Me.TSobPesoPorc.TabIndex = 56
        Me.TSobPesoPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(369, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 16)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "%"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TScrapPurPorc
        '
        Me.TScrapPurPorc.BackColor = System.Drawing.Color.Blue
        Me.TScrapPurPorc.Location = New System.Drawing.Point(372, 149)
        Me.TScrapPurPorc.Name = "TScrapPurPorc"
        Me.TScrapPurPorc.ReadOnly = True
        Me.TScrapPurPorc.Size = New System.Drawing.Size(67, 22)
        Me.TScrapPurPorc.TabIndex = 54
        Me.TScrapPurPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 16)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Purga"
        '
        'TScrapPurKilos
        '
        Me.TScrapPurKilos.BackColor = System.Drawing.Color.Blue
        Me.TScrapPurKilos.Location = New System.Drawing.Point(135, 149)
        Me.TScrapPurKilos.Name = "TScrapPurKilos"
        Me.TScrapPurKilos.ReadOnly = True
        Me.TScrapPurKilos.Size = New System.Drawing.Size(100, 22)
        Me.TScrapPurKilos.TabIndex = 52
        Me.TScrapPurKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 16)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Scrap"
        '
        'TScrapKilos
        '
        Me.TScrapKilos.BackColor = System.Drawing.Color.Red
        Me.TScrapKilos.Location = New System.Drawing.Point(135, 121)
        Me.TScrapKilos.Name = "TScrapKilos"
        Me.TScrapKilos.ReadOnly = True
        Me.TScrapKilos.Size = New System.Drawing.Size(100, 22)
        Me.TScrapKilos.TabIndex = 49
        Me.TScrapKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 16)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Sobrepeso"
        '
        'TSobPesoKilos
        '
        Me.TSobPesoKilos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TSobPesoKilos.Location = New System.Drawing.Point(135, 93)
        Me.TSobPesoKilos.Name = "TSobPesoKilos"
        Me.TSobPesoKilos.ReadOnly = True
        Me.TSobPesoKilos.Size = New System.Drawing.Size(100, 22)
        Me.TSobPesoKilos.TabIndex = 46
        Me.TSobPesoKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TProcUnidades
        '
        Me.TProcUnidades.BackColor = System.Drawing.Color.Yellow
        Me.TProcUnidades.Location = New System.Drawing.Point(254, 65)
        Me.TProcUnidades.Name = "TProcUnidades"
        Me.TProcUnidades.ReadOnly = True
        Me.TProcUnidades.Size = New System.Drawing.Size(100, 22)
        Me.TProcUnidades.TabIndex = 45
        Me.TProcUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Proceso"
        '
        'TProcKilos
        '
        Me.TProcKilos.BackColor = System.Drawing.Color.Yellow
        Me.TProcKilos.Location = New System.Drawing.Point(135, 65)
        Me.TProcKilos.Name = "TProcKilos"
        Me.TProcKilos.ReadOnly = True
        Me.TProcKilos.Size = New System.Drawing.Size(100, 22)
        Me.TProcKilos.TabIndex = 43
        Me.TProcKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TProdUnidades
        '
        Me.TProdUnidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TProdUnidades.Location = New System.Drawing.Point(254, 37)
        Me.TProdUnidades.Name = "TProdUnidades"
        Me.TProdUnidades.ReadOnly = True
        Me.TProdUnidades.Size = New System.Drawing.Size(100, 22)
        Me.TProdUnidades.TabIndex = 42
        Me.TProdUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Producción"
        '
        'TProdKilos
        '
        Me.TProdKilos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TProdKilos.Location = New System.Drawing.Point(135, 37)
        Me.TProdKilos.Name = "TProdKilos"
        Me.TProdKilos.ReadOnly = True
        Me.TProdKilos.Size = New System.Drawing.Size(100, 22)
        Me.TProdKilos.TabIndex = 39
        Me.TProdKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(252, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Unidades"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(133, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Kilos"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GB_Cant
        '
        Me.GB_Cant.Controls.Add(Me.Label7)
        Me.GB_Cant.Controls.Add(Me.Label6)
        Me.GB_Cant.Controls.Add(Me.Label5)
        Me.GB_Cant.Controls.Add(Me.TPend)
        Me.GB_Cant.Controls.Add(Me.TProc)
        Me.GB_Cant.Controls.Add(Me.TEnt)
        Me.GB_Cant.Controls.Add(Me.TProg)
        Me.GB_Cant.Controls.Add(Me.Label4)
        Me.GB_Cant.Location = New System.Drawing.Point(309, 0)
        Me.GB_Cant.Name = "GB_Cant"
        Me.GB_Cant.Size = New System.Drawing.Size(256, 224)
        Me.GB_Cant.TabIndex = 7
        Me.GB_Cant.TabStop = False
        Me.GB_Cant.Text = "Cantidades"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Pendientes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "En Proceso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Entregadas"
        '
        'TPend
        '
        Me.TPend.Location = New System.Drawing.Point(136, 121)
        Me.TPend.Name = "TPend"
        Me.TPend.ReadOnly = True
        Me.TPend.Size = New System.Drawing.Size(100, 22)
        Me.TPend.TabIndex = 35
        Me.TPend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TProc
        '
        Me.TProc.Location = New System.Drawing.Point(136, 93)
        Me.TProc.Name = "TProc"
        Me.TProc.ReadOnly = True
        Me.TProc.Size = New System.Drawing.Size(100, 22)
        Me.TProc.TabIndex = 34
        Me.TProc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TEnt
        '
        Me.TEnt.Location = New System.Drawing.Point(136, 65)
        Me.TEnt.Name = "TEnt"
        Me.TEnt.ReadOnly = True
        Me.TEnt.Size = New System.Drawing.Size(100, 22)
        Me.TEnt.TabIndex = 33
        Me.TEnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TProg
        '
        Me.TProg.Location = New System.Drawing.Point(136, 37)
        Me.TProg.Name = "TProg"
        Me.TProg.ReadOnly = True
        Me.TProg.Size = New System.Drawing.Size(100, 22)
        Me.TProg.TabIndex = 32
        Me.TProg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Programadas"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GB_Pesajes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 329)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1684, 532)
        Me.Panel2.TabIndex = 7
        '
        'GB_Pesajes
        '
        Me.GB_Pesajes.Controls.Add(Me.DGV)
        Me.GB_Pesajes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Pesajes.Location = New System.Drawing.Point(0, 0)
        Me.GB_Pesajes.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GB_Pesajes.Name = "GB_Pesajes"
        Me.GB_Pesajes.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GB_Pesajes.Size = New System.Drawing.Size(1684, 532)
        Me.GB_Pesajes.TabIndex = 2
        Me.GB_Pesajes.TabStop = False
        Me.GB_Pesajes.Text = "Pesajes"
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
        Me.DGV.Location = New System.Drawing.Point(6, 20)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(1672, 507)
        Me.DGV.TabIndex = 0
        '
        'FrmConsultasExt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1684, 861)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmConsultasExt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Pesajes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GB_Msges.ResumeLayout(False)
        Me.GB_Msges.PerformLayout()
        Me.GB_Consulta.ResumeLayout(False)
        Me.GB_Consulta.PerformLayout()
        Me.GB_Not.ResumeLayout(False)
        Me.GB_Not.PerformLayout()
        Me.GB_Totales.ResumeLayout(False)
        Me.GB_Totales.PerformLayout()
        Me.GB_Cant.ResumeLayout(False)
        Me.GB_Cant.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GB_Pesajes.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Elimina As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Export As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Btn_Imprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GB_Totales As System.Windows.Forms.GroupBox
    Friend WithEvents TScrapPorc As System.Windows.Forms.TextBox
    Friend WithEvents TSobPesoPorc As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TScrapPurPorc As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TScrapPurKilos As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TScrapKilos As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TSobPesoKilos As System.Windows.Forms.TextBox
    Friend WithEvents TProcUnidades As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TProcKilos As System.Windows.Forms.TextBox
    Friend WithEvents TProdUnidades As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TProdKilos As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GB_Cant As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TPend As System.Windows.Forms.TextBox
    Friend WithEvents TProc As System.Windows.Forms.TextBox
    Friend WithEvents TEnt As System.Windows.Forms.TextBox
    Friend WithEvents TProg As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GB_Pesajes As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Not As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TOrdProd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TPN As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TTramos As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblGraba As System.Windows.Forms.Label
    Friend WithEvents Btn_Notif As System.Windows.Forms.Button
    Friend WithEvents GB_Msges As System.Windows.Forms.GroupBox
    Friend WithEvents TObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents TMensajes As System.Windows.Forms.TextBox
End Class
