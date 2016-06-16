<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort3 = New System.IO.Ports.SerialPort(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Reiniciar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ADM = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_EXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PTE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PTEC = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PTE_OLD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_SCE_OLD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_Control_Tiempos_Ext = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_MPExtrusion = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_NEXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_REP_PTE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_REP_SCE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_INY = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PTI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ENS = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_SCI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PTP = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_Control_Tiempos_Iny = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlProgramaDeProducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ROT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PTR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_GEO = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_SUP = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ALM = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ALE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ALI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CON = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PROD_DR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PROD_DR_EXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PROD_DR_INY = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CPROD = New System.Windows.Forms.ToolStripMenuItem()
        Me.CNFG = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ACTUALIZA = New System.Windows.Forms.ToolStripMenuItem()
        Me.Acerca_de = New System.Windows.Forms.ToolStripMenuItem()
        Me.Login = New Atlas.UC_Login()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.DataBits = 7
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 683)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1368, 22)
        Me.StatusStrip1.TabIndex = 313
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LVersion
        '
        Me.LVersion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVersion.ForeColor = System.Drawing.Color.Red
        Me.LVersion.Name = "LVersion"
        Me.LVersion.Size = New System.Drawing.Size(52, 17)
        Me.LVersion.Text = "1.0.0.1"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Atlas.My.Resources.Resources.Logo_Fluent
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(647, 368)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(142, 144)
        Me.Panel3.TabIndex = 316
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.Atlas.My.Resources.Resources.mexichem
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(199, 186)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1039, 164)
        Me.Panel4.TabIndex = 317
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Salir, Me.Reiniciar, Me.MP_ADM, Me.MP_EXT, Me.MP_INY, Me.MP_ROT, Me.MP_GEO, Me.MP_SUP, Me.MP_ALM, Me.MP_CON, Me.CNFG, Me.Acerca_de})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1368, 44)
        Me.MenuStrip1.TabIndex = 312
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Salir
        '
        Me.Salir.Image = Global.Atlas.My.Resources.Resources.SalirAtlas
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(92, 40)
        Me.Salir.Text = "Salir    "
        '
        'Reiniciar
        '
        Me.Reiniciar.Image = Global.Atlas.My.Resources.Resources.reiniciarsesion
        Me.Reiniciar.Name = "Reiniciar"
        Me.Reiniciar.Size = New System.Drawing.Size(141, 40)
        Me.Reiniciar.Text = "Reiniciar Sesión"
        '
        'MP_ADM
        '
        Me.MP_ADM.Image = Global.Atlas.My.Resources.Resources.user_admin
        Me.MP_ADM.Name = "MP_ADM"
        Me.MP_ADM.Size = New System.Drawing.Size(134, 40)
        Me.MP_ADM.Text = "Administración"
        '
        'MP_EXT
        '
        Me.MP_EXT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_PTE, Me.MP_PTEC, Me.MP_PTE_OLD, Me.MP_SCE_OLD, Me.MP_Control_Tiempos_Ext, Me.MP_MPExtrusion, Me.MP_NEXT, Me.MP_REP_PTE, Me.MP_REP_SCE})
        Me.MP_EXT.Image = Global.Atlas.My.Resources.Resources.Extrusion_002
        Me.MP_EXT.Name = "MP_EXT"
        Me.MP_EXT.Size = New System.Drawing.Size(102, 40)
        Me.MP_EXT.Text = "Extrusión"
        '
        'MP_PTE
        '
        Me.MP_PTE.Name = "MP_PTE"
        Me.MP_PTE.Size = New System.Drawing.Size(315, 22)
        Me.MP_PTE.Text = "Captura Pesajes Extrusión"
        '
        'MP_PTEC
        '
        Me.MP_PTEC.Name = "MP_PTEC"
        Me.MP_PTEC.Size = New System.Drawing.Size(315, 22)
        Me.MP_PTEC.Text = "Captura Pesaje Extrusión Cintilla de Riego"
        '
        'MP_PTE_OLD
        '
        Me.MP_PTE_OLD.Name = "MP_PTE_OLD"
        Me.MP_PTE_OLD.Size = New System.Drawing.Size(315, 22)
        Me.MP_PTE_OLD.Text = "Producto Terminado Extrusión"
        '
        'MP_SCE_OLD
        '
        Me.MP_SCE_OLD.Name = "MP_SCE_OLD"
        Me.MP_SCE_OLD.Size = New System.Drawing.Size(315, 22)
        Me.MP_SCE_OLD.Text = "Scrap Extrusión"
        '
        'MP_Control_Tiempos_Ext
        '
        Me.MP_Control_Tiempos_Ext.Name = "MP_Control_Tiempos_Ext"
        Me.MP_Control_Tiempos_Ext.Size = New System.Drawing.Size(315, 22)
        Me.MP_Control_Tiempos_Ext.Text = "Captura Tiempos Productivos/Paros"
        '
        'MP_MPExtrusion
        '
        Me.MP_MPExtrusion.Name = "MP_MPExtrusion"
        Me.MP_MPExtrusion.Size = New System.Drawing.Size(315, 22)
        Me.MP_MPExtrusion.Text = "Modificación Pesajes Extrusión"
        '
        'MP_NEXT
        '
        Me.MP_NEXT.Name = "MP_NEXT"
        Me.MP_NEXT.Size = New System.Drawing.Size(315, 22)
        Me.MP_NEXT.Text = "Notificación Extrusión"
        '
        'MP_REP_PTE
        '
        Me.MP_REP_PTE.Name = "MP_REP_PTE"
        Me.MP_REP_PTE.Size = New System.Drawing.Size(315, 22)
        Me.MP_REP_PTE.Text = "Reportes Producto Terminado"
        '
        'MP_REP_SCE
        '
        Me.MP_REP_SCE.Name = "MP_REP_SCE"
        Me.MP_REP_SCE.Size = New System.Drawing.Size(315, 22)
        Me.MP_REP_SCE.Text = "Reportes Scrap"
        '
        'MP_INY
        '
        Me.MP_INY.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_PTI, Me.MP_ENS, Me.MP_SCI, Me.MP_PTP, Me.MP_Control_Tiempos_Iny, Me.ControlProgramaDeProducciónToolStripMenuItem})
        Me.MP_INY.Image = Global.Atlas.My.Resources.Resources.Inyeccion_003
        Me.MP_INY.Name = "MP_INY"
        Me.MP_INY.Size = New System.Drawing.Size(103, 40)
        Me.MP_INY.Text = "Inyección"
        '
        'MP_PTI
        '
        Me.MP_PTI.Name = "MP_PTI"
        Me.MP_PTI.Size = New System.Drawing.Size(280, 22)
        Me.MP_PTI.Text = "Captura Pesajes Inyección"
        '
        'MP_ENS
        '
        Me.MP_ENS.Name = "MP_ENS"
        Me.MP_ENS.Size = New System.Drawing.Size(280, 22)
        Me.MP_ENS.Text = "Captura Ensamblados"
        '
        'MP_SCI
        '
        Me.MP_SCI.Name = "MP_SCI"
        Me.MP_SCI.Size = New System.Drawing.Size(280, 22)
        Me.MP_SCI.Text = "Captura Scrap Inyección"
        '
        'MP_PTP
        '
        Me.MP_PTP.Name = "MP_PTP"
        Me.MP_PTP.Size = New System.Drawing.Size(280, 22)
        Me.MP_PTP.Text = "Producción en Piso"
        '
        'MP_Control_Tiempos_Iny
        '
        Me.MP_Control_Tiempos_Iny.Name = "MP_Control_Tiempos_Iny"
        Me.MP_Control_Tiempos_Iny.Size = New System.Drawing.Size(280, 22)
        Me.MP_Control_Tiempos_Iny.Text = "Captura Tiempos Productivos/Paros"
        '
        'ControlProgramaDeProducciónToolStripMenuItem
        '
        Me.ControlProgramaDeProducciónToolStripMenuItem.Name = "ControlProgramaDeProducciónToolStripMenuItem"
        Me.ControlProgramaDeProducciónToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.ControlProgramaDeProducciónToolStripMenuItem.Text = "Control Programa de Producción"
        '
        'MP_ROT
        '
        Me.MP_ROT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_PTR})
        Me.MP_ROT.Image = Global.Atlas.My.Resources.Resources.Rotomoldeo_03
        Me.MP_ROT.Name = "MP_ROT"
        Me.MP_ROT.Size = New System.Drawing.Size(118, 40)
        Me.MP_ROT.Text = "Rotomoldeo"
        Me.MP_ROT.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'MP_PTR
        '
        Me.MP_PTR.Name = "MP_PTR"
        Me.MP_PTR.Size = New System.Drawing.Size(235, 22)
        Me.MP_PTR.Text = "Captura Pesaje Rotomoldeo"
        '
        'MP_GEO
        '
        Me.MP_GEO.Image = Global.Atlas.My.Resources.Resources.GeoTextiles_01
        Me.MP_GEO.Name = "MP_GEO"
        Me.MP_GEO.Size = New System.Drawing.Size(116, 40)
        Me.MP_GEO.Text = "GeoTextiles"
        '
        'MP_SUP
        '
        Me.MP_SUP.Image = CType(resources.GetObject("MP_SUP.Image"), System.Drawing.Image)
        Me.MP_SUP.Name = "MP_SUP"
        Me.MP_SUP.Size = New System.Drawing.Size(116, 40)
        Me.MP_SUP.Text = "Supervisión"
        '
        'MP_ALM
        '
        Me.MP_ALM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_ALE, Me.MP_ALI})
        Me.MP_ALM.Image = CType(resources.GetObject("MP_ALM.Image"), System.Drawing.Image)
        Me.MP_ALM.Name = "MP_ALM"
        Me.MP_ALM.Size = New System.Drawing.Size(99, 40)
        Me.MP_ALM.Text = "Almacen"
        '
        'MP_ALE
        '
        Me.MP_ALE.Name = "MP_ALE"
        Me.MP_ALE.Size = New System.Drawing.Size(129, 22)
        Me.MP_ALE.Text = "Extrusión"
        '
        'MP_ALI
        '
        Me.MP_ALI.Name = "MP_ALI"
        Me.MP_ALI.Size = New System.Drawing.Size(129, 22)
        Me.MP_ALI.Text = "Inyección"
        '
        'MP_CON
        '
        Me.MP_CON.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_PROD_DR, Me.MP_CPROD})
        Me.MP_CON.Image = Global.Atlas.My.Resources.Resources.Consulta_1
        Me.MP_CON.Name = "MP_CON"
        Me.MP_CON.Size = New System.Drawing.Size(105, 40)
        Me.MP_CON.Text = "Consultas"
        '
        'MP_PROD_DR
        '
        Me.MP_PROD_DR.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_PROD_DR_EXT, Me.MP_PROD_DR_INY})
        Me.MP_PROD_DR.Name = "MP_PROD_DR"
        Me.MP_PROD_DR.Size = New System.Drawing.Size(239, 22)
        Me.MP_PROD_DR.Text = "Producción Resumen/Detalle"
        '
        'MP_PROD_DR_EXT
        '
        Me.MP_PROD_DR_EXT.Name = "MP_PROD_DR_EXT"
        Me.MP_PROD_DR_EXT.Size = New System.Drawing.Size(129, 22)
        Me.MP_PROD_DR_EXT.Text = "Extrusión"
        '
        'MP_PROD_DR_INY
        '
        Me.MP_PROD_DR_INY.Name = "MP_PROD_DR_INY"
        Me.MP_PROD_DR_INY.Size = New System.Drawing.Size(129, 22)
        Me.MP_PROD_DR_INY.Text = "Inyección"
        '
        'MP_CPROD
        '
        Me.MP_CPROD.Name = "MP_CPROD"
        Me.MP_CPROD.Size = New System.Drawing.Size(239, 22)
        Me.MP_CPROD.Text = "Producción"
        '
        'CNFG
        '
        Me.CNFG.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_ACTUALIZA})
        Me.CNFG.Image = Global.Atlas.My.Resources.Resources.Configuration
        Me.CNFG.Name = "CNFG"
        Me.CNFG.Size = New System.Drawing.Size(128, 40)
        Me.CNFG.Text = "Configuración"
        '
        'MP_ACTUALIZA
        '
        Me.MP_ACTUALIZA.Name = "MP_ACTUALIZA"
        Me.MP_ACTUALIZA.Size = New System.Drawing.Size(205, 22)
        Me.MP_ACTUALIZA.Text = "Buscar Actualizaciones"
        '
        'Acerca_de
        '
        Me.Acerca_de.Image = Global.Atlas.My.Resources.Resources.M
        Me.Acerca_de.Name = "Acerca_de"
        Me.Acerca_de.Size = New System.Drawing.Size(107, 40)
        Me.Acerca_de.Text = "Acerca de"
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(12, 64)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(326, 116)
        Me.Login.TabIndex = 318
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1368, 705)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fluent"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort3 As System.IO.Ports.SerialPort
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Reiniciar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_ADM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_EXT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_PTE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_INY As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_PTI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_ENS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_SUP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_ALM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_ALE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_ALI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CNFG As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Acerca_de As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CON As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_ACTUALIZA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_PROD_DR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CPROD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_SCI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_PTP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_PROD_DR_EXT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_PROD_DR_INY As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_PTE_OLD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_SCE_OLD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_ROT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_PTR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents MP_Control_Tiempos_Ext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlProgramaDeProducciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_MPExtrusion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_NEXT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_REP_PTE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_REP_SCE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_Control_Tiempos_Iny As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Login As Atlas.UC_Login
    Friend WithEvents MP_PTEC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_GEO As System.Windows.Forms.ToolStripMenuItem

End Class
