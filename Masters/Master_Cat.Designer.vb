<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master_Cat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Master_Cat))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Btn_Cerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Guardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Modifica = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Elimina = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Cancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Export = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Actualiza = New System.Windows.Forms.ToolStripMenuItem()
        Me.PBActualiza = New System.Windows.Forms.ProgressBar()
        Me.BGW1 = New System.ComponentModel.BackgroundWorker()
        Me.bwPrecarga = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Cerrar, Me.Btn_Nuevo, Me.Btn_Consulta, Me.Btn_Guardar, Me.Btn_Modifica, Me.Btn_Elimina, Me.Btn_Cancel, Me.Btn_Export, Me.Btn_Actualiza})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Image = CType(resources.GetObject("Btn_Cerrar.Image"), System.Drawing.Image)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(77, 24)
        Me.Btn_Cerrar.Text = "Cerrar"
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = CType(resources.GetObject("Btn_Consulta.Image"), System.Drawing.Image)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(93, 24)
        Me.Btn_Consulta.Text = "Consulta"
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.Image = Global.Atlas.My.Resources.Resources.Btn_Nuevo
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(80, 24)
        Me.Btn_Nuevo.Text = "Nuevo"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(89, 24)
        Me.Btn_Guardar.Text = "Guardar"
        '
        'Btn_Modifica
        '
        Me.Btn_Modifica.Image = CType(resources.GetObject("Btn_Modifica.Image"), System.Drawing.Image)
        Me.Btn_Modifica.Name = "Btn_Modifica"
        Me.Btn_Modifica.Size = New System.Drawing.Size(96, 24)
        Me.Btn_Modifica.Text = "Modificar"
        '
        'Btn_Elimina
        '
        Me.Btn_Elimina.Image = CType(resources.GetObject("Btn_Elimina.Image"), System.Drawing.Image)
        Me.Btn_Elimina.Name = "Btn_Elimina"
        Me.Btn_Elimina.Size = New System.Drawing.Size(88, 24)
        Me.Btn_Elimina.Text = "Eliminar"
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Image = CType(resources.GetObject("Btn_Cancel.Image"), System.Drawing.Image)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(91, 24)
        Me.Btn_Cancel.Text = "Cancelar"
        '
        'Btn_Export
        '
        Me.Btn_Export.Image = CType(resources.GetObject("Btn_Export.Image"), System.Drawing.Image)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(132, 24)
        Me.Btn_Export.Text = "Exporta a Excel"
        '
        'Btn_Actualiza
        '
        Me.Btn_Actualiza.Image = Global.Atlas.My.Resources.Resources.Importar
        Me.Btn_Actualiza.Name = "Btn_Actualiza"
        Me.Btn_Actualiza.Size = New System.Drawing.Size(157, 24)
        Me.Btn_Actualiza.Text = "Actualizar Catalogo"
        '
        'PBActualiza
        '
        Me.PBActualiza.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBActualiza.Location = New System.Drawing.Point(164, 296)
        Me.PBActualiza.Name = "PBActualiza"
        Me.PBActualiza.Size = New System.Drawing.Size(624, 23)
        Me.PBActualiza.TabIndex = 304
        '
        'BGW1
        '
        '
        'bwPrecarga
        '
        Me.bwPrecarga.WorkerReportsProgress = True
        '
        'Master_Cat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 612)
        Me.Controls.Add(Me.PBActualiza)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Master_Cat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master_Cat"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBActualiza As System.Windows.Forms.ProgressBar
    Friend WithEvents BGW1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwPrecarga As System.ComponentModel.BackgroundWorker
    Friend WithEvents Btn_Actualiza As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Guardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Modifica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Elimina As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Cancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Export As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Btn_Cerrar As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Btn_Nuevo As System.Windows.Forms.ToolStripMenuItem
End Class
