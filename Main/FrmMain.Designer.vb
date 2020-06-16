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
        Me.MP_MPE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MPE_A = New System.Windows.Forms.ToolStripMenuItem()
        Me.MPE_D = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MP_CON = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PROD_DR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PROD_DR_EXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PROD_DR_INY = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CPROD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CEXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CEXTR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MR_CESC = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CEHP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_REXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_RESC = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_REHP = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CINY = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CINYEC = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CISC = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CIHP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_RPINY = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_RISC = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_RIHP = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CALIDAD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_AvanceProduccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PLANEACION = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ProduccionPlaneacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_SUP = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_RHE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_RHI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ORDENES = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ORDEXT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ORDINY = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ALM = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ALE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_ALI = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 842)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(19, 0, 1, 0)
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(2313, 26)
        Me.StatusStrip1.TabIndex = 313
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LVersion
        '
        Me.LVersion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVersion.ForeColor = System.Drawing.Color.Red
        Me.LVersion.Name = "LVersion"
        Me.LVersion.Size = New System.Drawing.Size(69, 21)
        Me.LVersion.Text = "1.0.0.1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Salir, Me.Reiniciar, Me.MP_ADM, Me.MP_EXT, Me.MP_INY, Me.MP_ROT, Me.MP_GEO, Me.MP_CON, Me.MP_CALIDAD, Me.MP_PLANEACION, Me.MP_SUP, Me.MP_ORDENES, Me.MP_ALM, Me.CNFG, Me.Acerca_de})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(2313, 47)
        Me.MenuStrip1.TabIndex = 312
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Salir
        '
        Me.Salir.Image = Global.Atlas.My.Resources.Resources.SalirAtlas
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(89, 43)
        Me.Salir.Text = "Salir "
        '
        'Reiniciar
        '
        Me.Reiniciar.Image = Global.Atlas.My.Resources.Resources.reiniciarsesion
        Me.Reiniciar.Name = "Reiniciar"
        Me.Reiniciar.Size = New System.Drawing.Size(169, 43)
        Me.Reiniciar.Text = "Reiniciar Sesión"
        '
        'MP_ADM
        '
        Me.MP_ADM.Image = Global.Atlas.My.Resources.Resources.user_admin
        Me.MP_ADM.Name = "MP_ADM"
        Me.MP_ADM.Size = New System.Drawing.Size(162, 43)
        Me.MP_ADM.Text = "Administración"
        '
        'MP_EXT
        '
        Me.MP_EXT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_PTE, Me.MP_PTEC, Me.MP_PTE_OLD, Me.MP_SCE_OLD, Me.MP_Control_Tiempos_Ext, Me.MP_MPExtrusion, Me.MP_NEXT, Me.MP_REP_PTE, Me.MP_REP_SCE, Me.MP_MPE})
        Me.MP_EXT.Image = Global.Atlas.My.Resources.Resources.Extrusion_002
        Me.MP_EXT.Name = "MP_EXT"
        Me.MP_EXT.Size = New System.Drawing.Size(121, 43)
        Me.MP_EXT.Text = "Extrusión"
        '
        'MP_PTE
        '
        Me.MP_PTE.Name = "MP_PTE"
        Me.MP_PTE.Size = New System.Drawing.Size(397, 26)
        Me.MP_PTE.Text = "Captura Pesajes Extrusión"
        '
        'MP_PTEC
        '
        Me.MP_PTEC.Name = "MP_PTEC"
        Me.MP_PTEC.Size = New System.Drawing.Size(397, 26)
        Me.MP_PTEC.Text = "Captura Pesaje Extrusión Cintilla de Riego"
        '
        'MP_PTE_OLD
        '
        Me.MP_PTE_OLD.Name = "MP_PTE_OLD"
        Me.MP_PTE_OLD.Size = New System.Drawing.Size(397, 26)
        Me.MP_PTE_OLD.Text = "Producto Terminado Extrusión"
        '
        'MP_SCE_OLD
        '
        Me.MP_SCE_OLD.Name = "MP_SCE_OLD"
        Me.MP_SCE_OLD.Size = New System.Drawing.Size(397, 26)
        Me.MP_SCE_OLD.Text = "Scrap Extrusión"
        '
        'MP_Control_Tiempos_Ext
        '
        Me.MP_Control_Tiempos_Ext.Name = "MP_Control_Tiempos_Ext"
        Me.MP_Control_Tiempos_Ext.Size = New System.Drawing.Size(397, 26)
        Me.MP_Control_Tiempos_Ext.Text = "Captura Tiempos Productivos/Paros"
        '
        'MP_MPExtrusion
        '
        Me.MP_MPExtrusion.Name = "MP_MPExtrusion"
        Me.MP_MPExtrusion.Size = New System.Drawing.Size(397, 26)
        Me.MP_MPExtrusion.Text = "Modificación Pesajes Extrusión"
        '
        'MP_NEXT
        '
        Me.MP_NEXT.Name = "MP_NEXT"
        Me.MP_NEXT.Size = New System.Drawing.Size(397, 26)
        Me.MP_NEXT.Text = "Notificación Extrusión"
        '
        'MP_REP_PTE
        '
        Me.MP_REP_PTE.Name = "MP_REP_PTE"
        Me.MP_REP_PTE.Size = New System.Drawing.Size(397, 26)
        Me.MP_REP_PTE.Text = "Reportes Producto Terminado"
        '
        'MP_REP_SCE
        '
        Me.MP_REP_SCE.Name = "MP_REP_SCE"
        Me.MP_REP_SCE.Size = New System.Drawing.Size(397, 26)
        Me.MP_REP_SCE.Text = "Reportes Scrap"
        '
        'MP_MPE
        '
        Me.MP_MPE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MPE_A, Me.MPE_D})
        Me.MP_MPE.Name = "MP_MPE"
        Me.MP_MPE.Size = New System.Drawing.Size(397, 26)
        Me.MP_MPE.Text = "Monitor de Producción Extrusión"
        '
        'MPE_A
        '
        Me.MPE_A.Name = "MPE_A"
        Me.MPE_A.Size = New System.Drawing.Size(146, 26)
        Me.MPE_A.Text = "Activar"
        '
        'MPE_D
        '
        Me.MPE_D.Name = "MPE_D"
        Me.MPE_D.Size = New System.Drawing.Size(146, 26)
        Me.MPE_D.Text = "Detener"
        '
        'MP_INY
        '
        Me.MP_INY.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_PTI, Me.MP_ENS, Me.MP_SCI, Me.MP_PTP, Me.MP_Control_Tiempos_Iny, Me.ControlProgramaDeProducciónToolStripMenuItem})
        Me.MP_INY.Image = Global.Atlas.My.Resources.Resources.Inyeccion_003
        Me.MP_INY.Name = "MP_INY"
        Me.MP_INY.Size = New System.Drawing.Size(122, 43)
        Me.MP_INY.Text = "Inyección"
        '
        'MP_PTI
        '
        Me.MP_PTI.Name = "MP_PTI"
        Me.MP_PTI.Size = New System.Drawing.Size(350, 26)
        Me.MP_PTI.Text = "Captura Pesajes Inyección"
        '
        'MP_ENS
        '
        Me.MP_ENS.Name = "MP_ENS"
        Me.MP_ENS.Size = New System.Drawing.Size(350, 26)
        Me.MP_ENS.Text = "Captura Ensamblados"
        '
        'MP_SCI
        '
        Me.MP_SCI.Name = "MP_SCI"
        Me.MP_SCI.Size = New System.Drawing.Size(350, 26)
        Me.MP_SCI.Text = "Captura Scrap Inyección"
        '
        'MP_PTP
        '
        Me.MP_PTP.Name = "MP_PTP"
        Me.MP_PTP.Size = New System.Drawing.Size(350, 26)
        Me.MP_PTP.Text = "Producción en Piso"
        '
        'MP_Control_Tiempos_Iny
        '
        Me.MP_Control_Tiempos_Iny.Name = "MP_Control_Tiempos_Iny"
        Me.MP_Control_Tiempos_Iny.Size = New System.Drawing.Size(350, 26)
        Me.MP_Control_Tiempos_Iny.Text = "Captura Tiempos Productivos/Paros"
        '
        'ControlProgramaDeProducciónToolStripMenuItem
        '
        Me.ControlProgramaDeProducciónToolStripMenuItem.Name = "ControlProgramaDeProducciónToolStripMenuItem"
        Me.ControlProgramaDeProducciónToolStripMenuItem.Size = New System.Drawing.Size(350, 26)
        Me.ControlProgramaDeProducciónToolStripMenuItem.Text = "Control Programa de Producción"
        '
        'MP_ROT
        '
        Me.MP_ROT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_PTR})
        Me.MP_ROT.Image = Global.Atlas.My.Resources.Resources.Rotomoldeo_021
        Me.MP_ROT.Name = "MP_ROT"
        Me.MP_ROT.Size = New System.Drawing.Size(141, 43)
        Me.MP_ROT.Text = "Rotomoldeo"
        Me.MP_ROT.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'MP_PTR
        '
        Me.MP_PTR.Name = "MP_PTR"
        Me.MP_PTR.Size = New System.Drawing.Size(292, 26)
        Me.MP_PTR.Text = "Captura Pesaje Rotomoldeo"
        '
        'MP_GEO
        '
        Me.MP_GEO.Image = Global.Atlas.My.Resources.Resources.GeoTextiles_01
        Me.MP_GEO.Name = "MP_GEO"
        Me.MP_GEO.Size = New System.Drawing.Size(139, 43)
        Me.MP_GEO.Text = "GeoTextiles"
        '
        'MP_CON
        '
        Me.MP_CON.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_PROD_DR, Me.MP_CPROD, Me.MP_CEXT, Me.MP_CINY})
        Me.MP_CON.Image = Global.Atlas.My.Resources.Resources.Consulta_02
        Me.MP_CON.Name = "MP_CON"
        Me.MP_CON.Size = New System.Drawing.Size(124, 43)
        Me.MP_CON.Text = "Consultas"
        '
        'MP_PROD_DR
        '
        Me.MP_PROD_DR.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_PROD_DR_EXT, Me.MP_PROD_DR_INY})
        Me.MP_PROD_DR.Name = "MP_PROD_DR"
        Me.MP_PROD_DR.Size = New System.Drawing.Size(300, 26)
        Me.MP_PROD_DR.Text = "Producción Resumen/Detalle"
        '
        'MP_PROD_DR_EXT
        '
        Me.MP_PROD_DR_EXT.Name = "MP_PROD_DR_EXT"
        Me.MP_PROD_DR_EXT.Size = New System.Drawing.Size(156, 26)
        Me.MP_PROD_DR_EXT.Text = "Extrusión"
        '
        'MP_PROD_DR_INY
        '
        Me.MP_PROD_DR_INY.Name = "MP_PROD_DR_INY"
        Me.MP_PROD_DR_INY.Size = New System.Drawing.Size(156, 26)
        Me.MP_PROD_DR_INY.Text = "Inyección"
        '
        'MP_CPROD
        '
        Me.MP_CPROD.Name = "MP_CPROD"
        Me.MP_CPROD.Size = New System.Drawing.Size(300, 26)
        Me.MP_CPROD.Text = "Producción"
        '
        'MP_CEXT
        '
        Me.MP_CEXT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MP_CEXT.Name = "MP_CEXT"
        Me.MP_CEXT.Size = New System.Drawing.Size(300, 26)
        Me.MP_CEXT.Text = "Extrusión"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_CEXTR, Me.MR_CESC, Me.MP_CEHP})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'MP_CEXTR
        '
        Me.MP_CEXTR.Name = "MP_CEXTR"
        Me.MP_CEXTR.Size = New System.Drawing.Size(181, 26)
        Me.MP_CEXTR.Text = "Producción"
        '
        'MR_CESC
        '
        Me.MR_CESC.Name = "MR_CESC"
        Me.MR_CESC.Size = New System.Drawing.Size(181, 26)
        Me.MR_CESC.Text = "Scrap"
        '
        'MP_CEHP
        '
        Me.MP_CEHP.Name = "MP_CEHP"
        Me.MP_CEHP.Size = New System.Drawing.Size(181, 26)
        Me.MP_CEHP.Text = "Horas Paro"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_REXT, Me.MP_RESC, Me.MP_REHP})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'MP_REXT
        '
        Me.MP_REXT.Name = "MP_REXT"
        Me.MP_REXT.Size = New System.Drawing.Size(167, 26)
        Me.MP_REXT.Text = "Producción"
        '
        'MP_RESC
        '
        Me.MP_RESC.Name = "MP_RESC"
        Me.MP_RESC.Size = New System.Drawing.Size(167, 26)
        Me.MP_RESC.Text = "Scrap"
        '
        'MP_REHP
        '
        Me.MP_REHP.Name = "MP_REHP"
        Me.MP_REHP.Size = New System.Drawing.Size(167, 26)
        Me.MP_REHP.Text = "Horas Paro"
        '
        'MP_CINY
        '
        Me.MP_CINY.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem1, Me.ReportesToolStripMenuItem1})
        Me.MP_CINY.Name = "MP_CINY"
        Me.MP_CINY.Size = New System.Drawing.Size(300, 26)
        Me.MP_CINY.Text = "Inyección"
        '
        'ConsultasToolStripMenuItem1
        '
        Me.ConsultasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_CINYEC, Me.MP_CISC, Me.MP_CIHP})
        Me.ConsultasToolStripMenuItem1.Name = "ConsultasToolStripMenuItem1"
        Me.ConsultasToolStripMenuItem1.Size = New System.Drawing.Size(158, 26)
        Me.ConsultasToolStripMenuItem1.Text = "Consultas"
        '
        'MP_CINYEC
        '
        Me.MP_CINYEC.Name = "MP_CINYEC"
        Me.MP_CINYEC.Size = New System.Drawing.Size(167, 26)
        Me.MP_CINYEC.Text = "Producción"
        '
        'MP_CISC
        '
        Me.MP_CISC.Name = "MP_CISC"
        Me.MP_CISC.Size = New System.Drawing.Size(167, 26)
        Me.MP_CISC.Text = "Scrap"
        '
        'MP_CIHP
        '
        Me.MP_CIHP.Name = "MP_CIHP"
        Me.MP_CIHP.Size = New System.Drawing.Size(167, 26)
        Me.MP_CIHP.Text = "Horas Paro"
        '
        'ReportesToolStripMenuItem1
        '
        Me.ReportesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_RPINY, Me.MP_RISC, Me.MP_RIHP})
        Me.ReportesToolStripMenuItem1.Name = "ReportesToolStripMenuItem1"
        Me.ReportesToolStripMenuItem1.Size = New System.Drawing.Size(158, 26)
        Me.ReportesToolStripMenuItem1.Text = "Reportes"
        '
        'MP_RPINY
        '
        Me.MP_RPINY.Name = "MP_RPINY"
        Me.MP_RPINY.Size = New System.Drawing.Size(167, 26)
        Me.MP_RPINY.Text = "Producción"
        '
        'MP_RISC
        '
        Me.MP_RISC.Name = "MP_RISC"
        Me.MP_RISC.Size = New System.Drawing.Size(167, 26)
        Me.MP_RISC.Text = "Scrap"
        '
        'MP_RIHP
        '
        Me.MP_RIHP.Name = "MP_RIHP"
        Me.MP_RIHP.Size = New System.Drawing.Size(167, 26)
        Me.MP_RIHP.Text = "Horas Paro"
        '
        'MP_CALIDAD
        '
        Me.MP_CALIDAD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_AvanceProduccion})
        Me.MP_CALIDAD.Image = Global.Atlas.My.Resources.Resources.Calidad_06
        Me.MP_CALIDAD.Name = "MP_CALIDAD"
        Me.MP_CALIDAD.Size = New System.Drawing.Size(106, 43)
        Me.MP_CALIDAD.Text = "Calidad"
        '
        'MP_AvanceProduccion
        '
        Me.MP_AvanceProduccion.Name = "MP_AvanceProduccion"
        Me.MP_AvanceProduccion.Size = New System.Drawing.Size(294, 26)
        Me.MP_AvanceProduccion.Text = "Consulta Avance Producción"
        '
        'MP_PLANEACION
        '
        Me.MP_PLANEACION.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_ProduccionPlaneacion})
        Me.MP_PLANEACION.Image = Global.Atlas.My.Resources.Resources.Planeacion_01
        Me.MP_PLANEACION.Name = "MP_PLANEACION"
        Me.MP_PLANEACION.Size = New System.Drawing.Size(131, 43)
        Me.MP_PLANEACION.Text = "Planeación"
        '
        'MP_ProduccionPlaneacion
        '
        Me.MP_ProduccionPlaneacion.Name = "MP_ProduccionPlaneacion"
        Me.MP_ProduccionPlaneacion.Size = New System.Drawing.Size(225, 26)
        Me.MP_ProduccionPlaneacion.Text = "Avance Producción"
        '
        'MP_SUP
        '
        Me.MP_SUP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_RHE, Me.MP_RHI})
        Me.MP_SUP.Image = CType(resources.GetObject("MP_SUP.Image"), System.Drawing.Image)
        Me.MP_SUP.Name = "MP_SUP"
        Me.MP_SUP.Size = New System.Drawing.Size(136, 43)
        Me.MP_SUP.Text = "Supervisión"
        '
        'MP_RHE
        '
        Me.MP_RHE.Name = "MP_RHE"
        Me.MP_RHE.Size = New System.Drawing.Size(268, 26)
        Me.MP_RHE.Text = "Reporte Horas Extrusión"
        '
        'MP_RHI
        '
        Me.MP_RHI.Name = "MP_RHI"
        Me.MP_RHI.Size = New System.Drawing.Size(268, 26)
        Me.MP_RHI.Text = "Reporte Horas Inyección"
        '
        'MP_ORDENES
        '
        Me.MP_ORDENES.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_ORDEXT, Me.MP_ORDINY})
        Me.MP_ORDENES.Image = Global.Atlas.My.Resources.Resources.Ordenes_Produccion_02
        Me.MP_ORDENES.Name = "MP_ORDENES"
        Me.MP_ORDENES.Size = New System.Drawing.Size(200, 43)
        Me.MP_ORDENES.Text = "Ordenes en Proceso"
        '
        'MP_ORDEXT
        '
        Me.MP_ORDEXT.Name = "MP_ORDEXT"
        Me.MP_ORDEXT.Size = New System.Drawing.Size(246, 26)
        Me.MP_ORDEXT.Text = "Ordenes de Extrusión"
        '
        'MP_ORDINY
        '
        Me.MP_ORDINY.Name = "MP_ORDINY"
        Me.MP_ORDINY.Size = New System.Drawing.Size(246, 26)
        Me.MP_ORDINY.Text = "Ordenes de Inyección"
        '
        'MP_ALM
        '
        Me.MP_ALM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_ALE, Me.MP_ALI})
        Me.MP_ALM.Image = CType(resources.GetObject("MP_ALM.Image"), System.Drawing.Image)
        Me.MP_ALM.Name = "MP_ALM"
        Me.MP_ALM.Size = New System.Drawing.Size(116, 43)
        Me.MP_ALM.Text = "Almacen"
        '
        'MP_ALE
        '
        Me.MP_ALE.Name = "MP_ALE"
        Me.MP_ALE.Size = New System.Drawing.Size(156, 26)
        Me.MP_ALE.Text = "Extrusión"
        '
        'MP_ALI
        '
        Me.MP_ALI.Name = "MP_ALI"
        Me.MP_ALI.Size = New System.Drawing.Size(156, 26)
        Me.MP_ALI.Text = "Inyección"
        '
        'CNFG
        '
        Me.CNFG.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_ACTUALIZA})
        Me.CNFG.Image = Global.Atlas.My.Resources.Resources.Configuration
        Me.CNFG.Name = "CNFG"
        Me.CNFG.Size = New System.Drawing.Size(152, 43)
        Me.CNFG.Text = "Configuración"
        '
        'MP_ACTUALIZA
        '
        Me.MP_ACTUALIZA.Name = "MP_ACTUALIZA"
        Me.MP_ACTUALIZA.Size = New System.Drawing.Size(256, 26)
        Me.MP_ACTUALIZA.Text = "Buscar Actualizaciones"
        '
        'Acerca_de
        '
        Me.Acerca_de.Image = Global.Atlas.My.Resources.Resources.msgInformation
        Me.Acerca_de.Name = "Acerca_de"
        Me.Acerca_de.Size = New System.Drawing.Size(126, 43)
        Me.Acerca_de.Text = "Acerca de"
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(16, 79)
        Me.Login.Margin = New System.Windows.Forms.Padding(5)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(435, 143)
        Me.Login.TabIndex = 318
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Atlas.My.Resources.Resources.LogoFluent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(2313, 868)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents MP_MPE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MPE_A As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MPE_D As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CEXT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CEXTR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MR_CESC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CEHP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_REXT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_RESC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_REHP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CINY As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CINYEC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CISC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CIHP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_RPINY As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_RISC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_RIHP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CALIDAD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_AvanceProduccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_PLANEACION As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_ProduccionPlaneacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_RHE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_RHI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_ORDENES As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_ORDEXT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_ORDINY As System.Windows.Forms.ToolStripMenuItem

End Class
