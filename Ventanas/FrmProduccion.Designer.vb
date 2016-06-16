<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProduccion
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProduccion))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BExpExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TSC_R = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TSC_B = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GTC = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TCPt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TCScrap = New System.Windows.Forms.TextBox
        Me.lblCntproc = New System.Windows.Forms.Label
        Me.TCantEnproce = New System.Windows.Forms.TextBox
        Me.TCantProgra = New System.Windows.Forms.TextBox
        Me.lblCntprog = New System.Windows.Forms.Label
        Me.lblCntentr = New System.Windows.Forms.Label
        Me.TCantEntre = New System.Windows.Forms.TextBox
        Me.lblCntpend = New System.Windows.Forms.Label
        Me.TCantPendiente = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TPTPU = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.THF = New System.Windows.Forms.TextBox
        Me.THI = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TTC = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TOrdProd = New System.Windows.Forms.TextBox
        Me.BtnConsulta = New System.Windows.Forms.Button
        Me.CB_Turno = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.CB_Linea = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GB_TC = New System.Windows.Forms.GroupBox
        Me.RB3 = New System.Windows.Forms.RadioButton
        Me.RB2 = New System.Windows.Forms.RadioButton
        Me.RB1 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RB5 = New System.Windows.Forms.RadioButton
        Me.RB4 = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DGV_ConProd = New System.Windows.Forms.DataGridView
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GB_TC.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV_ConProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.BExpExcel})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = CType(resources.GetObject("CerrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'BExpExcel
        '
        Me.BExpExcel.Image = CType(resources.GetObject("BExpExcel.Image"), System.Drawing.Image)
        Me.BExpExcel.Name = "BExpExcel"
        Me.BExpExcel.Size = New System.Drawing.Size(116, 20)
        Me.BExpExcel.Text = "Exportar Excel"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TSC_R)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TSC_B)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GTC)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TCPt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TCScrap)
        Me.GroupBox1.Controls.Add(Me.lblCntproc)
        Me.GroupBox1.Controls.Add(Me.TCantEnproce)
        Me.GroupBox1.Controls.Add(Me.TCantProgra)
        Me.GroupBox1.Controls.Add(Me.lblCntprog)
        Me.GroupBox1.Controls.Add(Me.lblCntentr)
        Me.GroupBox1.Controls.Add(Me.TCantEntre)
        Me.GroupBox1.Controls.Add(Me.lblCntpend)
        Me.GroupBox1.Controls.Add(Me.TCantPendiente)
        Me.GroupBox1.Location = New System.Drawing.Point(975, 24)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(285, 251)
        Me.GroupBox1.TabIndex = 141
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales por Orden"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(88, 126)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 15)
        Me.Label18.TabIndex = 157
        Me.Label18.Text = "Scrap Recuperable"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TSC_R
        '
        Me.TSC_R.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSC_R.Location = New System.Drawing.Point(185, 123)
        Me.TSC_R.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TSC_R.Name = "TSC_R"
        Me.TSC_R.ReadOnly = True
        Me.TSC_R.Size = New System.Drawing.Size(85, 20)
        Me.TSC_R.TabIndex = 158
        Me.TSC_R.Text = "0.00"
        Me.TSC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(113, 148)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 15)
        Me.Label17.TabIndex = 155
        Me.Label17.Text = "Scrap Basura"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TSC_B
        '
        Me.TSC_B.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSC_B.Location = New System.Drawing.Point(185, 145)
        Me.TSC_B.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TSC_B.Name = "TSC_B"
        Me.TSC_B.ReadOnly = True
        Me.TSC_B.Size = New System.Drawing.Size(85, 20)
        Me.TSC_B.TabIndex = 156
        Me.TSC_B.Text = "0.00"
        Me.TSC_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(73, 215)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 15)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "Kilos Consumo Total"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GTC
        '
        Me.GTC.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GTC.Location = New System.Drawing.Point(185, 212)
        Me.GTC.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTC.Name = "GTC"
        Me.GTC.ReadOnly = True
        Me.GTC.Size = New System.Drawing.Size(85, 20)
        Me.GTC.TabIndex = 154
        Me.GTC.Text = "0.00"
        Me.GTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(5, 193)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 15)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Kilos Consumo Producto Terminado"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TCPt
        '
        Me.TCPt.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCPt.Location = New System.Drawing.Point(185, 190)
        Me.TCPt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TCPt.Name = "TCPt"
        Me.TCPt.ReadOnly = True
        Me.TCPt.Size = New System.Drawing.Size(85, 20)
        Me.TCPt.TabIndex = 152
        Me.TCPt.Text = "0.00"
        Me.TCPt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(73, 170)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Kilos Consumo Scrap"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TCScrap
        '
        Me.TCScrap.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCScrap.Location = New System.Drawing.Point(185, 167)
        Me.TCScrap.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TCScrap.Name = "TCScrap"
        Me.TCScrap.ReadOnly = True
        Me.TCScrap.Size = New System.Drawing.Size(85, 20)
        Me.TCScrap.TabIndex = 150
        Me.TCScrap.Text = "0.00"
        Me.TCScrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCntproc
        '
        Me.lblCntproc.AutoSize = True
        Me.lblCntproc.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCntproc.ForeColor = System.Drawing.Color.Black
        Me.lblCntproc.Location = New System.Drawing.Point(122, 65)
        Me.lblCntproc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCntproc.Name = "lblCntproc"
        Me.lblCntproc.Size = New System.Drawing.Size(59, 15)
        Me.lblCntproc.TabIndex = 147
        Me.lblCntproc.Text = "En proceso"
        '
        'TCantEnproce
        '
        Me.TCantEnproce.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantEnproce.Location = New System.Drawing.Point(185, 62)
        Me.TCantEnproce.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TCantEnproce.Name = "TCantEnproce"
        Me.TCantEnproce.ReadOnly = True
        Me.TCantEnproce.Size = New System.Drawing.Size(85, 20)
        Me.TCantEnproce.TabIndex = 148
        Me.TCantEnproce.Text = "0.00"
        Me.TCantEnproce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TCantProgra
        '
        Me.TCantProgra.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantProgra.Location = New System.Drawing.Point(185, 17)
        Me.TCantProgra.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TCantProgra.Name = "TCantProgra"
        Me.TCantProgra.ReadOnly = True
        Me.TCantProgra.Size = New System.Drawing.Size(85, 20)
        Me.TCantProgra.TabIndex = 144
        Me.TCantProgra.Text = "0.00"
        Me.TCantProgra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCntprog
        '
        Me.lblCntprog.AutoSize = True
        Me.lblCntprog.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCntprog.ForeColor = System.Drawing.Color.Black
        Me.lblCntprog.Location = New System.Drawing.Point(118, 20)
        Me.lblCntprog.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCntprog.Name = "lblCntprog"
        Me.lblCntprog.Size = New System.Drawing.Size(63, 15)
        Me.lblCntprog.TabIndex = 141
        Me.lblCntprog.Text = "Programada"
        '
        'lblCntentr
        '
        Me.lblCntentr.AutoSize = True
        Me.lblCntentr.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCntentr.ForeColor = System.Drawing.Color.Black
        Me.lblCntentr.Location = New System.Drawing.Point(128, 43)
        Me.lblCntentr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCntentr.Name = "lblCntentr"
        Me.lblCntentr.Size = New System.Drawing.Size(53, 15)
        Me.lblCntentr.TabIndex = 142
        Me.lblCntentr.Text = "Entregada"
        '
        'TCantEntre
        '
        Me.TCantEntre.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantEntre.Location = New System.Drawing.Point(185, 40)
        Me.TCantEntre.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TCantEntre.Name = "TCantEntre"
        Me.TCantEntre.ReadOnly = True
        Me.TCantEntre.Size = New System.Drawing.Size(85, 20)
        Me.TCantEntre.TabIndex = 145
        Me.TCantEntre.Text = "0.00"
        Me.TCantEntre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCntpend
        '
        Me.lblCntpend.AutoSize = True
        Me.lblCntpend.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCntpend.ForeColor = System.Drawing.Color.Black
        Me.lblCntpend.Location = New System.Drawing.Point(129, 88)
        Me.lblCntpend.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCntpend.Name = "lblCntpend"
        Me.lblCntpend.Size = New System.Drawing.Size(52, 15)
        Me.lblCntpend.TabIndex = 143
        Me.lblCntpend.Text = "Pendiente"
        '
        'TCantPendiente
        '
        Me.TCantPendiente.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCantPendiente.Location = New System.Drawing.Point(185, 85)
        Me.TCantPendiente.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TCantPendiente.Name = "TCantPendiente"
        Me.TCantPendiente.ReadOnly = True
        Me.TCantPendiente.Size = New System.Drawing.Size(85, 20)
        Me.TCantPendiente.TabIndex = 146
        Me.TCantPendiente.Text = "0.00"
        Me.TCantPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TPTPU)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.THF)
        Me.GroupBox2.Controls.Add(Me.THI)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TTC)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TOrdProd)
        Me.GroupBox2.Controls.Add(Me.BtnConsulta)
        Me.GroupBox2.Controls.Add(Me.CB_Turno)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DTP_FF)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DTP_FI)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CB_Linea)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(171, 24)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(800, 251)
        Me.GroupBox2.TabIndex = 142
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consulta"
        '
        'TPTPU
        '
        Me.TPTPU.Location = New System.Drawing.Point(708, 40)
        Me.TPTPU.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TPTPU.Name = "TPTPU"
        Me.TPTPU.ReadOnly = True
        Me.TPTPU.Size = New System.Drawing.Size(88, 20)
        Me.TPTPU.TabIndex = 160
        Me.TPTPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Red
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(4, 230)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 15)
        Me.Label16.TabIndex = 161
        Me.Label16.Text = "Scrap Basura"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(582, 43)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 15)
        Me.Label15.TabIndex = 159
        Me.Label15.Text = "Peso Promedio P/Unidad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(367, 75)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 15)
        Me.Label13.TabIndex = 157
        Me.Label13.Text = "Hora Fin Pesaje"
        '
        'THF
        '
        Me.THF.Location = New System.Drawing.Point(450, 72)
        Me.THF.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.THF.Name = "THF"
        Me.THF.Size = New System.Drawing.Size(88, 20)
        Me.THF.TabIndex = 156
        Me.THF.Text = "23:59:59"
        '
        'THI
        '
        Me.THI.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THI.Location = New System.Drawing.Point(115, 72)
        Me.THI.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.THI.Name = "THI"
        Me.THI.Size = New System.Drawing.Size(88, 20)
        Me.THI.TabIndex = 155
        Me.THI.Text = "00:00:01"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LimeGreen
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(112, 230)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(167, 15)
        Me.Label14.TabIndex = 158
        Me.Label14.Text = "Producto Terminado en Almacen"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 75)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 15)
        Me.Label12.TabIndex = 154
        Me.Label12.Text = "Hora Inicio Pesaje"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(591, 20)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 15)
        Me.Label11.TabIndex = 153
        Me.Label11.Text = "Total Tramos Consulta "
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(112, 207)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 15)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Producto Terminado en Procesos"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightCoral
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 207)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 15)
        Me.Label8.TabIndex = 150
        Me.Label8.Text = "Scrap Reprocesado"
        '
        'TTC
        '
        Me.TTC.Location = New System.Drawing.Point(708, 17)
        Me.TTC.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TTC.Name = "TTC"
        Me.TTC.ReadOnly = True
        Me.TTC.Size = New System.Drawing.Size(88, 20)
        Me.TTC.TabIndex = 152
        Me.TTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(355, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 15)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "Orden Produccion"
        '
        'TOrdProd
        '
        Me.TOrdProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TOrdProd.Location = New System.Drawing.Point(450, 98)
        Me.TOrdProd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TOrdProd.Name = "TOrdProd"
        Me.TOrdProd.Size = New System.Drawing.Size(88, 20)
        Me.TOrdProd.TabIndex = 148
        Me.TOrdProd.Text = "*"
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Image = CType(resources.GetObject("BtnConsulta.Image"), System.Drawing.Image)
        Me.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConsulta.Location = New System.Drawing.Point(594, 201)
        Me.BtnConsulta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(202, 44)
        Me.BtnConsulta.TabIndex = 147
        Me.BtnConsulta.Text = "Generar Consulta"
        Me.BtnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnConsulta.UseVisualStyleBackColor = True
        '
        'CB_Turno
        '
        Me.CB_Turno.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Turno.FormattingEnabled = True
        Me.CB_Turno.Location = New System.Drawing.Point(115, 98)
        Me.CB_Turno.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CB_Turno.Name = "CB_Turno"
        Me.CB_Turno.Size = New System.Drawing.Size(88, 23)
        Me.CB_Turno.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Turno"
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(450, 46)
        Me.DTP_FF.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(88, 20)
        Me.DTP_FF.TabIndex = 144
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(362, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Fecha Fin Pesaje"
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(115, 46)
        Me.DTP_FI.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(88, 20)
        Me.DTP_FI.TabIndex = 142
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Fecha Inicio Pesaje"
        '
        'CB_Linea
        '
        Me.CB_Linea.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Linea.FormattingEnabled = True
        Me.CB_Linea.Location = New System.Drawing.Point(115, 17)
        Me.CB_Linea.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CB_Linea.Name = "CB_Linea"
        Me.CB_Linea.Size = New System.Drawing.Size(423, 23)
        Me.CB_Linea.TabIndex = 140
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Linea de Producción "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GB_TC
        '
        Me.GB_TC.Controls.Add(Me.RB3)
        Me.GB_TC.Controls.Add(Me.RB2)
        Me.GB_TC.Controls.Add(Me.RB1)
        Me.GB_TC.Location = New System.Drawing.Point(0, 24)
        Me.GB_TC.Name = "GB_TC"
        Me.GB_TC.Size = New System.Drawing.Size(166, 129)
        Me.GB_TC.TabIndex = 162
        Me.GB_TC.TabStop = False
        Me.GB_TC.Text = "Tipo Consulta"
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Location = New System.Drawing.Point(13, 102)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(78, 19)
        Me.RB3.TabIndex = 2
        Me.RB3.Text = "Compuesto"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Location = New System.Drawing.Point(12, 65)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(119, 19)
        Me.RB2.TabIndex = 1
        Me.RB2.Text = "Producto Terminado"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Location = New System.Drawing.Point(12, 30)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(107, 19)
        Me.RB1.TabIndex = 0
        Me.RB1.Text = "Puesto de Trabajo"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RB5)
        Me.GroupBox3.Controls.Add(Me.RB4)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 159)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(162, 116)
        Me.GroupBox3.TabIndex = 163
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Area"
        '
        'RB5
        '
        Me.RB5.AutoSize = True
        Me.RB5.Location = New System.Drawing.Point(9, 66)
        Me.RB5.Name = "RB5"
        Me.RB5.Size = New System.Drawing.Size(69, 19)
        Me.RB5.TabIndex = 1
        Me.RB5.Text = "Inyección"
        Me.RB5.UseVisualStyleBackColor = True
        '
        'RB4
        '
        Me.RB4.AutoSize = True
        Me.RB4.Checked = True
        Me.RB4.Location = New System.Drawing.Point(9, 28)
        Me.RB4.Name = "RB4"
        Me.RB4.Size = New System.Drawing.Size(69, 19)
        Me.RB4.TabIndex = 0
        Me.RB4.TabStop = True
        Me.RB4.Text = "Extrusión"
        Me.RB4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DGV_ConProd)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(0, 281)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1264, 433)
        Me.GroupBox4.TabIndex = 164
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Consulta"
        '
        'DGV_ConProd
        '
        Me.DGV_ConProd.AllowUserToAddRows = False
        Me.DGV_ConProd.AllowUserToDeleteRows = False
        Me.DGV_ConProd.AllowUserToOrderColumns = True
        Me.DGV_ConProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_ConProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_ConProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ConProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_ConProd.Location = New System.Drawing.Point(3, 16)
        Me.DGV_ConProd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DGV_ConProd.Name = "DGV_ConProd"
        Me.DGV_ConProd.ReadOnly = True
        Me.DGV_ConProd.Size = New System.Drawing.Size(1258, 414)
        Me.DGV_ConProd.TabIndex = 2
        '
        'FrmProduccion_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 714)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GB_TC)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProduccion_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo Consulta Producción"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GB_TC.ResumeLayout(False)
        Me.GB_TC.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGV_ConProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GTC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TCPt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TCScrap As System.Windows.Forms.TextBox
    Friend WithEvents lblCntproc As System.Windows.Forms.Label
    Friend WithEvents TCantEnproce As System.Windows.Forms.TextBox
    Friend WithEvents TCantProgra As System.Windows.Forms.TextBox
    Friend WithEvents lblCntprog As System.Windows.Forms.Label
    Friend WithEvents lblCntentr As System.Windows.Forms.Label
    Friend WithEvents TCantEntre As System.Windows.Forms.TextBox
    Friend WithEvents lblCntpend As System.Windows.Forms.Label
    Friend WithEvents TCantPendiente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TOrdProd As System.Windows.Forms.TextBox
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents CB_Turno As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CB_Linea As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TTC As System.Windows.Forms.TextBox
    Friend WithEvents THI As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents THF As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TPTPU As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TSC_R As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TSC_B As System.Windows.Forms.TextBox
    Friend WithEvents BExpExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GB_TC As System.Windows.Forms.GroupBox
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RB5 As System.Windows.Forms.RadioButton
    Friend WithEvents RB4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_ConProd As System.Windows.Forms.DataGridView
End Class
