<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Extrusion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Extrusion))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_PTE_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CON_PROD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MP_CON_SP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoTerminadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PGeneral = New System.Windows.Forms.Panel()
        Me.Compuestos = New Atlas.Extrusion.UC_Compuestos()
        Me.Tara = New Atlas.Extrusion.UC_Tara()
        Me.OperadorLinea = New Atlas.Extrusion.UC_OperadorLinea()
        Me.ReadODF = New Atlas.Extrusion.UC_ReadODF()
        Me.Basculas = New Atlas.Extrusion.UC_Basculas()
        Me.Login = New Atlas.Extrusion.UC_LoginUser()
        Me.FechaTurno = New Atlas.Extrusion.UC_FechaTurno()
        Me.PInformacion = New System.Windows.Forms.Panel()
        Me.InfProducto = New Atlas.Extrusion.UC_InfProducto()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.PEmbalajes = New System.Windows.Forms.Panel()
        Me.UC_LecturaBascula1 = New Atlas.Extrusion.UC_LecturaBascula()
        Me.MenuStrip1.SuspendLayout()
        Me.PGeneral.SuspendLayout()
        Me.PInformacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MP_PTE_Consulta, Me.ReportesToolStripMenuItem, Me.CalculadoraToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 29)
        Me.MenuStrip1.TabIndex = 176
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(90, 25)
        Me.ToolStripMenuItem1.Text = "Salir"
        '
        'MP_PTE_Consulta
        '
        Me.MP_PTE_Consulta.AutoSize = False
        Me.MP_PTE_Consulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MP_PTE_Consulta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MP_CON_PROD, Me.MP_CON_SP})
        Me.MP_PTE_Consulta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MP_PTE_Consulta.Name = "MP_PTE_Consulta"
        Me.MP_PTE_Consulta.Size = New System.Drawing.Size(94, 25)
        Me.MP_PTE_Consulta.Text = "Consultas"
        '
        'MP_CON_PROD
        '
        Me.MP_CON_PROD.Name = "MP_CON_PROD"
        Me.MP_CON_PROD.Size = New System.Drawing.Size(260, 22)
        Me.MP_CON_PROD.Text = "Consulta Producción / Scrap"
        '
        'MP_CON_SP
        '
        Me.MP_CON_SP.Name = "MP_CON_SP"
        Me.MP_CON_SP.Size = New System.Drawing.Size(260, 22)
        Me.MP_CON_SP.Text = "Consulta Sobre / Bajo Peso"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.AutoSize = False
        Me.ReportesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoTerminadoToolStripMenuItem, Me.ScrapToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(90, 25)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        Me.ReportesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProductoTerminadoToolStripMenuItem
        '
        Me.ProductoTerminadoToolStripMenuItem.Name = "ProductoTerminadoToolStripMenuItem"
        Me.ProductoTerminadoToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ProductoTerminadoToolStripMenuItem.Text = "Producto Terminado"
        '
        'ScrapToolStripMenuItem
        '
        Me.ScrapToolStripMenuItem.Name = "ScrapToolStripMenuItem"
        Me.ScrapToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ScrapToolStripMenuItem.Text = "Scrap"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.AutoSize = False
        Me.CalculadoraToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(110, 25)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'PGeneral
        '
        Me.PGeneral.Controls.Add(Me.Compuestos)
        Me.PGeneral.Controls.Add(Me.Tara)
        Me.PGeneral.Controls.Add(Me.OperadorLinea)
        Me.PGeneral.Controls.Add(Me.ReadODF)
        Me.PGeneral.Controls.Add(Me.Basculas)
        Me.PGeneral.Controls.Add(Me.Login)
        Me.PGeneral.Controls.Add(Me.FechaTurno)
        Me.PGeneral.Location = New System.Drawing.Point(0, 32)
        Me.PGeneral.Name = "PGeneral"
        Me.PGeneral.Size = New System.Drawing.Size(649, 316)
        Me.PGeneral.TabIndex = 181
        '
        'Compuestos
        '
        Me.Compuestos.Location = New System.Drawing.Point(3, 258)
        Me.Compuestos.Name = "Compuestos"
        Me.Compuestos.Size = New System.Drawing.Size(638, 54)
        Me.Compuestos.TabIndex = 0
        '
        'Tara
        '
        Me.Tara.Location = New System.Drawing.Point(37, 204)
        Me.Tara.Name = "Tara"
        Me.Tara.Size = New System.Drawing.Size(584, 29)
        Me.Tara.TabIndex = 184
        '
        'OperadorLinea
        '
        Me.OperadorLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperadorLinea.Location = New System.Drawing.Point(30, 232)
        Me.OperadorLinea.Name = "OperadorLinea"
        Me.OperadorLinea.Size = New System.Drawing.Size(447, 31)
        Me.OperadorLinea.TabIndex = 183
        '
        'ReadODF
        '
        Me.ReadODF.Location = New System.Drawing.Point(39, 121)
        Me.ReadODF.Name = "ReadODF"
        Me.ReadODF.Size = New System.Drawing.Size(582, 86)
        Me.ReadODF.TabIndex = 182
        '
        'Basculas
        '
        Me.Basculas.Location = New System.Drawing.Point(3, 3)
        Me.Basculas.Name = "Basculas"
        Me.Basculas.Size = New System.Drawing.Size(643, 39)
        Me.Basculas.TabIndex = 181
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(1, 63)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(620, 57)
        Me.Login.TabIndex = 0
        '
        'FechaTurno
        '
        Me.FechaTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaTurno.Location = New System.Drawing.Point(47, 42)
        Me.FechaTurno.Name = "FechaTurno"
        Me.FechaTurno.Size = New System.Drawing.Size(574, 26)
        Me.FechaTurno.TabIndex = 180
        '
        'PInformacion
        '
        Me.PInformacion.Controls.Add(Me.InfProducto)
        Me.PInformacion.Location = New System.Drawing.Point(655, 32)
        Me.PInformacion.Name = "PInformacion"
        Me.PInformacion.Size = New System.Drawing.Size(649, 79)
        Me.PInformacion.TabIndex = 182
        '
        'InfProducto
        '
        Me.InfProducto.Location = New System.Drawing.Point(3, 3)
        Me.InfProducto.Name = "InfProducto"
        Me.InfProducto.Size = New System.Drawing.Size(589, 75)
        Me.InfProducto.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 651)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1304, 22)
        Me.StatusStrip1.TabIndex = 183
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'PEmbalajes
        '
        Me.PEmbalajes.Location = New System.Drawing.Point(655, 117)
        Me.PEmbalajes.Name = "PEmbalajes"
        Me.PEmbalajes.Size = New System.Drawing.Size(649, 122)
        Me.PEmbalajes.TabIndex = 185
        '
        'UC_LecturaBascula1
        '
        Me.UC_LecturaBascula1.Location = New System.Drawing.Point(0, 350)
        Me.UC_LecturaBascula1.Name = "UC_LecturaBascula1"
        Me.UC_LecturaBascula1.Size = New System.Drawing.Size(1300, 99)
        Me.UC_LecturaBascula1.TabIndex = 186
        '
        'Frm_Extrusion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(1304, 673)
        Me.Controls.Add(Me.UC_LecturaBascula1)
        Me.Controls.Add(Me.PEmbalajes)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PInformacion)
        Me.Controls.Add(Me.PGeneral)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_Extrusion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PGeneral.ResumeLayout(False)
        Me.PInformacion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_PTE_Consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CON_PROD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MP_CON_SP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoTerminadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScrapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PGeneral As System.Windows.Forms.Panel
    Friend WithEvents PInformacion As System.Windows.Forms.Panel
    Friend WithEvents Login As Atlas.Extrusion.UC_LoginUser
    Friend WithEvents FechaTurno As Atlas.Extrusion.UC_FechaTurno
    Friend WithEvents Basculas As Atlas.Extrusion.UC_Basculas
    Friend WithEvents ReadODF As Atlas.Extrusion.UC_ReadODF
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents OperadorLinea As Atlas.Extrusion.UC_OperadorLinea
    Friend WithEvents InfProducto As Atlas.Extrusion.UC_InfProducto
    Friend WithEvents Tara As Atlas.Extrusion.UC_Tara
    Friend WithEvents Compuestos As Atlas.Extrusion.UC_Compuestos
    Friend WithEvents PEmbalajes As System.Windows.Forms.Panel
    Friend WithEvents UC_LecturaBascula1 As Atlas.Extrusion.UC_LecturaBascula

End Class
