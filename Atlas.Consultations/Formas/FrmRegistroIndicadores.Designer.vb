<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroIndicadores
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
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbcIndicadores = New System.Windows.Forms.TabControl()
        Me.tpProduccion = New System.Windows.Forms.TabPage()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEditarProd = New System.Windows.Forms.Button()
        Me.gbValores = New System.Windows.Forms.GroupBox()
        Me.dgvProduccion = New System.Windows.Forms.DataGridView()
        Me.tpSeguridad = New System.Windows.Forms.TabPage()
        Me.btnEditarSeg = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSeguridad = New System.Windows.Forms.DataGridView()
        Me.btnCancelSeg = New System.Windows.Forms.Button()
        Me.btnSaveSeg = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.tbcIndicadores.SuspendLayout()
        Me.tpProduccion.SuspendLayout()
        Me.gbValores.SuspendLayout()
        CType(Me.dgvProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSeguridad.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(882, 33)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.Atlas.Consultations.My.Resources.Resources.Exit_1
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(99, 29)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'tbcIndicadores
        '
        Me.tbcIndicadores.Controls.Add(Me.tpProduccion)
        Me.tbcIndicadores.Controls.Add(Me.tpSeguridad)
        Me.tbcIndicadores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcIndicadores.Location = New System.Drawing.Point(0, 33)
        Me.tbcIndicadores.Name = "tbcIndicadores"
        Me.tbcIndicadores.SelectedIndex = 0
        Me.tbcIndicadores.Size = New System.Drawing.Size(882, 419)
        Me.tbcIndicadores.TabIndex = 4
        '
        'tpProduccion
        '
        Me.tpProduccion.Controls.Add(Me.btnCancel)
        Me.tpProduccion.Controls.Add(Me.btnSave)
        Me.tpProduccion.Controls.Add(Me.btnEditarProd)
        Me.tpProduccion.Controls.Add(Me.gbValores)
        Me.tpProduccion.Location = New System.Drawing.Point(4, 29)
        Me.tpProduccion.Name = "tpProduccion"
        Me.tpProduccion.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProduccion.Size = New System.Drawing.Size(874, 386)
        Me.tpProduccion.TabIndex = 0
        Me.tpProduccion.Text = "Producción"
        Me.tpProduccion.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Atlas.Consultations.My.Resources.Resources.Btn_Cancel
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(613, 152)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(249, 57)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Atlas.Consultations.My.Resources.Resources.Btn_Save_Mini
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(613, 89)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(249, 57)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Guardar"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEditarProd
        '
        Me.btnEditarProd.Image = Global.Atlas.Consultations.My.Resources.Resources.Btn_Modifica
        Me.btnEditarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditarProd.Location = New System.Drawing.Point(613, 26)
        Me.btnEditarProd.Name = "btnEditarProd"
        Me.btnEditarProd.Size = New System.Drawing.Size(249, 57)
        Me.btnEditarProd.TabIndex = 6
        Me.btnEditarProd.Text = "Modificar Valores"
        Me.btnEditarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditarProd.UseVisualStyleBackColor = True
        '
        'gbValores
        '
        Me.gbValores.Controls.Add(Me.dgvProduccion)
        Me.gbValores.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbValores.Location = New System.Drawing.Point(3, 3)
        Me.gbValores.Name = "gbValores"
        Me.gbValores.Size = New System.Drawing.Size(604, 380)
        Me.gbValores.TabIndex = 5
        Me.gbValores.TabStop = False
        Me.gbValores.Text = "Valores Indicadores"
        '
        'dgvProduccion
        '
        Me.dgvProduccion.AllowUserToAddRows = False
        Me.dgvProduccion.AllowUserToDeleteRows = False
        Me.dgvProduccion.AllowUserToOrderColumns = True
        Me.dgvProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvProduccion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvProduccion.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProduccion.GridColor = System.Drawing.SystemColors.Control
        Me.dgvProduccion.Location = New System.Drawing.Point(3, 23)
        Me.dgvProduccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvProduccion.Name = "dgvProduccion"
        Me.dgvProduccion.ReadOnly = True
        Me.dgvProduccion.Size = New System.Drawing.Size(598, 354)
        Me.dgvProduccion.TabIndex = 340
        '
        'tpSeguridad
        '
        Me.tpSeguridad.Controls.Add(Me.btnCancelSeg)
        Me.tpSeguridad.Controls.Add(Me.btnSaveSeg)
        Me.tpSeguridad.Controls.Add(Me.btnEditarSeg)
        Me.tpSeguridad.Controls.Add(Me.GroupBox1)
        Me.tpSeguridad.Location = New System.Drawing.Point(4, 29)
        Me.tpSeguridad.Name = "tpSeguridad"
        Me.tpSeguridad.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSeguridad.Size = New System.Drawing.Size(874, 386)
        Me.tpSeguridad.TabIndex = 1
        Me.tpSeguridad.Text = "Seguridad"
        Me.tpSeguridad.UseVisualStyleBackColor = True
        '
        'btnEditarSeg
        '
        Me.btnEditarSeg.Image = Global.Atlas.Consultations.My.Resources.Resources.Btn_Modifica
        Me.btnEditarSeg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditarSeg.Location = New System.Drawing.Point(613, 26)
        Me.btnEditarSeg.Name = "btnEditarSeg"
        Me.btnEditarSeg.Size = New System.Drawing.Size(249, 57)
        Me.btnEditarSeg.TabIndex = 7
        Me.btnEditarSeg.Text = "Modificar Valores"
        Me.btnEditarSeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarSeg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditarSeg.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSeguridad)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 380)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valores Indicadores"
        '
        'dgvSeguridad
        '
        Me.dgvSeguridad.AllowUserToAddRows = False
        Me.dgvSeguridad.AllowUserToDeleteRows = False
        Me.dgvSeguridad.AllowUserToOrderColumns = True
        Me.dgvSeguridad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvSeguridad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSeguridad.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvSeguridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeguridad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSeguridad.Location = New System.Drawing.Point(3, 23)
        Me.dgvSeguridad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSeguridad.Name = "dgvSeguridad"
        Me.dgvSeguridad.ReadOnly = True
        Me.dgvSeguridad.Size = New System.Drawing.Size(598, 354)
        Me.dgvSeguridad.TabIndex = 340
        '
        'btnCancelSeg
        '
        Me.btnCancelSeg.Image = Global.Atlas.Consultations.My.Resources.Resources.Btn_Cancel
        Me.btnCancelSeg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelSeg.Location = New System.Drawing.Point(613, 152)
        Me.btnCancelSeg.Name = "btnCancelSeg"
        Me.btnCancelSeg.Size = New System.Drawing.Size(249, 57)
        Me.btnCancelSeg.TabIndex = 16
        Me.btnCancelSeg.Text = "Cancelar"
        Me.btnCancelSeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelSeg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelSeg.UseVisualStyleBackColor = True
        '
        'btnSaveSeg
        '
        Me.btnSaveSeg.Image = Global.Atlas.Consultations.My.Resources.Resources.Btn_Save_Mini
        Me.btnSaveSeg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveSeg.Location = New System.Drawing.Point(613, 89)
        Me.btnSaveSeg.Name = "btnSaveSeg"
        Me.btnSaveSeg.Size = New System.Drawing.Size(249, 57)
        Me.btnSaveSeg.TabIndex = 15
        Me.btnSaveSeg.Text = "Guardar"
        Me.btnSaveSeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveSeg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveSeg.UseVisualStyleBackColor = True
        '
        'FrmRegistroIndicadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 452)
        Me.Controls.Add(Me.tbcIndicadores)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmRegistroIndicadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistroIndicadores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tbcIndicadores.ResumeLayout(False)
        Me.tpProduccion.ResumeLayout(False)
        Me.gbValores.ResumeLayout(False)
        CType(Me.dgvProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSeguridad.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbcIndicadores As System.Windows.Forms.TabControl
    Friend WithEvents tpProduccion As System.Windows.Forms.TabPage
    Friend WithEvents gbValores As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProduccion As System.Windows.Forms.DataGridView
    Friend WithEvents tpSeguridad As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSeguridad As System.Windows.Forms.DataGridView
    Friend WithEvents btnEditarProd As System.Windows.Forms.Button
    Friend WithEvents btnEditarSeg As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnCancelSeg As System.Windows.Forms.Button
    Friend WithEvents btnSaveSeg As System.Windows.Forms.Button
End Class
