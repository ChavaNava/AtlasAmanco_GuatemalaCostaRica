<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Catalogos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Catalogos))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Btn_Cerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Guardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Modifica = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Elimina = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Cancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Export = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Actualiza = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PBActualiza = New System.Windows.Forms.ProgressBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.BGW1 = New System.ComponentModel.BackgroundWorker()
        Me.bwPrecarga = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Cerrar, Me.Btn_Nuevo, Me.Btn_Consulta, Me.Btn_Guardar, Me.Btn_Modifica, Me.Btn_Elimina, Me.Btn_Cancel, Me.Btn_Export, Me.Btn_Actualiza})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(992, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Image = Global.Atlas.Catalogos.My.Resources.Resources.Exit_1
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(82, 29)
        Me.Btn_Cerrar.Text = "Cerrar"
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.Image = Global.Atlas.Catalogos.My.Resources.Resources.Btn_Nuevo
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(85, 29)
        Me.Btn_Nuevo.Text = "Nuevo"
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = Global.Atlas.Catalogos.My.Resources.Resources.Btn_Consulta
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(98, 29)
        Me.Btn_Consulta.Text = "Consulta"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(94, 29)
        Me.Btn_Guardar.Text = "Guardar"
        '
        'Btn_Modifica
        '
        Me.Btn_Modifica.Image = Global.Atlas.Catalogos.My.Resources.Resources.Btn_Modifica
        Me.Btn_Modifica.Name = "Btn_Modifica"
        Me.Btn_Modifica.Size = New System.Drawing.Size(101, 29)
        Me.Btn_Modifica.Text = "Modificar"
        '
        'Btn_Elimina
        '
        Me.Btn_Elimina.Image = Global.Atlas.Catalogos.My.Resources.Resources.Btn_Elimina
        Me.Btn_Elimina.Name = "Btn_Elimina"
        Me.Btn_Elimina.Size = New System.Drawing.Size(93, 29)
        Me.Btn_Elimina.Text = "Eliminar"
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Image = Global.Atlas.Catalogos.My.Resources.Resources.Btn_Cancel
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(96, 29)
        Me.Btn_Cancel.Text = "Cancelar"
        '
        'Btn_Export
        '
        Me.Btn_Export.Image = Global.Atlas.Catalogos.My.Resources.Resources.Btn_Excel
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(137, 29)
        Me.Btn_Export.Text = "Exporta a Excel"
        '
        'Btn_Actualiza
        '
        Me.Btn_Actualiza.Image = Global.Atlas.Catalogos.My.Resources.Resources.Importar
        Me.Btn_Actualiza.Name = "Btn_Actualiza"
        Me.Btn_Actualiza.Size = New System.Drawing.Size(162, 29)
        Me.Btn_Actualiza.Text = "Actualizar Catalogo"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 223)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PBActualiza)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 256)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(992, 41)
        Me.Panel2.TabIndex = 3
        '
        'PBActualiza
        '
        Me.PBActualiza.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBActualiza.Location = New System.Drawing.Point(184, 9)
        Me.PBActualiza.Name = "PBActualiza"
        Me.PBActualiza.Size = New System.Drawing.Size(624, 23)
        Me.PBActualiza.TabIndex = 305
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGV1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 297)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(992, 326)
        Me.Panel3.TabIndex = 4
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToOrderColumns = True
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV1.Location = New System.Drawing.Point(0, 0)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.Size = New System.Drawing.Size(992, 326)
        Me.DGV1.TabIndex = 340
        '
        'bwPrecarga
        '
        Me.bwPrecarga.WorkerReportsProgress = True
        '
        'Frm_Catalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 623)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Catalogos"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Public WithEvents Btn_Cerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Nuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Guardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Modifica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Elimina As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Cancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Export As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Actualiza As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PBActualiza As System.Windows.Forms.ProgressBar
    Friend WithEvents BGW1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwPrecarga As System.ComponentModel.BackgroundWorker
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView

End Class
