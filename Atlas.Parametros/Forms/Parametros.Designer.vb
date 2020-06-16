<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parametros
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tcParametros = New System.Windows.Forms.TabControl()
        Me.tp1 = New System.Windows.Forms.TabPage()
        Me.tp2 = New System.Windows.Forms.TabPage()
        Me.gbNotificación = New System.Windows.Forms.GroupBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.tb3 = New System.Windows.Forms.TabPage()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tcParametros.SuspendLayout()
        Me.tp2.SuspendLayout()
        Me.gbNotificación.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1303, 29)
        Me.MenuStrip1.TabIndex = 176
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(90, 25)
        Me.ToolStripMenuItem1.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tcParametros)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1303, 509)
        Me.Panel1.TabIndex = 177
        '
        'tcParametros
        '
        Me.tcParametros.Controls.Add(Me.tp1)
        Me.tcParametros.Controls.Add(Me.tp2)
        Me.tcParametros.Controls.Add(Me.tb3)
        Me.tcParametros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcParametros.Location = New System.Drawing.Point(0, 0)
        Me.tcParametros.Name = "tcParametros"
        Me.tcParametros.SelectedIndex = 0
        Me.tcParametros.Size = New System.Drawing.Size(1303, 509)
        Me.tcParametros.TabIndex = 1
        '
        'tp1
        '
        Me.tp1.Location = New System.Drawing.Point(4, 25)
        Me.tp1.Name = "tp1"
        Me.tp1.Padding = New System.Windows.Forms.Padding(3)
        Me.tp1.Size = New System.Drawing.Size(1295, 480)
        Me.tp1.TabIndex = 0
        Me.tp1.Text = "Parametros Generales"
        Me.tp1.UseVisualStyleBackColor = True
        '
        'tp2
        '
        Me.tp2.Controls.Add(Me.gbNotificación)
        Me.tp2.Location = New System.Drawing.Point(4, 25)
        Me.tp2.Name = "tp2"
        Me.tp2.Padding = New System.Windows.Forms.Padding(3)
        Me.tp2.Size = New System.Drawing.Size(1295, 480)
        Me.tp2.TabIndex = 1
        Me.tp2.Text = "Extrusión"
        Me.tp2.UseVisualStyleBackColor = True
        '
        'gbNotificación
        '
        Me.gbNotificación.Controls.Add(Me.cb1)
        Me.gbNotificación.Location = New System.Drawing.Point(8, 6)
        Me.gbNotificación.Name = "gbNotificación"
        Me.gbNotificación.Size = New System.Drawing.Size(632, 277)
        Me.gbNotificación.TabIndex = 0
        Me.gbNotificación.TabStop = False
        Me.gbNotificación.Text = "Notificación"
        '
        'cb1
        '
        Me.cb1.Location = New System.Drawing.Point(6, 21)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(620, 73)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Activar esta opción para el envio de un aviso de exceso de producción en la orden" & _
    " y bloquearla, de lo contrario solo se visualizara el aviso."
        Me.cb1.UseVisualStyleBackColor = True
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(4, 25)
        Me.tb3.Name = "tb3"
        Me.tb3.Padding = New System.Windows.Forms.Padding(3)
        Me.tb3.Size = New System.Drawing.Size(1295, 480)
        Me.tb3.TabIndex = 2
        Me.tb3.Text = "Inyección"
        Me.tb3.UseVisualStyleBackColor = True
        '
        'Parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 538)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Parametros"
        Me.Text = "Parametros"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.tcParametros.ResumeLayout(False)
        Me.tp2.ResumeLayout(False)
        Me.gbNotificación.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tcParametros As System.Windows.Forms.TabControl
    Friend WithEvents tp1 As System.Windows.Forms.TabPage
    Friend WithEvents tp2 As System.Windows.Forms.TabPage
    Friend WithEvents tb3 As System.Windows.Forms.TabPage
    Friend WithEvents gbNotificación As System.Windows.Forms.GroupBox
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
End Class
