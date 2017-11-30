<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParametrizacion
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
        Me.TBCParametrizacion = New System.Windows.Forms.TabControl()
        Me.TP1 = New System.Windows.Forms.TabPage()
        Me.TP2 = New System.Windows.Forms.TabPage()
        Me.TP3 = New System.Windows.Forms.TabPage()
        Me.DGVSobrePeso = New System.Windows.Forms.DataGridView()
        Me.TP4 = New System.Windows.Forms.TabPage()
        Me.DGVExt = New System.Windows.Forms.DataGridView()
        Me.Btn_Consulta = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnExtEdit = New System.Windows.Forms.Button()
        Me.BtnExtConsulta = New System.Windows.Forms.Button()
        Me.BtnExtDel = New System.Windows.Forms.Button()
        Me.BtnExtNew = New System.Windows.Forms.Button()
        Me.TBCParametrizacion.SuspendLayout()
        Me.TP3.SuspendLayout()
        CType(Me.DGVSobrePeso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP4.SuspendLayout()
        CType(Me.DGVExt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBCParametrizacion
        '
        Me.TBCParametrizacion.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TBCParametrizacion.Controls.Add(Me.TP1)
        Me.TBCParametrizacion.Controls.Add(Me.TP2)
        Me.TBCParametrizacion.Controls.Add(Me.TP3)
        Me.TBCParametrizacion.Controls.Add(Me.TP4)
        Me.TBCParametrizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBCParametrizacion.Location = New System.Drawing.Point(0, 0)
        Me.TBCParametrizacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCParametrizacion.Name = "TBCParametrizacion"
        Me.TBCParametrizacion.SelectedIndex = 0
        Me.TBCParametrizacion.Size = New System.Drawing.Size(941, 466)
        Me.TBCParametrizacion.TabIndex = 0
        '
        'TP1
        '
        Me.TP1.Location = New System.Drawing.Point(4, 28)
        Me.TP1.Margin = New System.Windows.Forms.Padding(4)
        Me.TP1.Name = "TP1"
        Me.TP1.Padding = New System.Windows.Forms.Padding(4)
        Me.TP1.Size = New System.Drawing.Size(933, 434)
        Me.TP1.TabIndex = 0
        Me.TP1.Text = "Información General"
        Me.TP1.UseVisualStyleBackColor = True
        '
        'TP2
        '
        Me.TP2.Location = New System.Drawing.Point(4, 28)
        Me.TP2.Margin = New System.Windows.Forms.Padding(4)
        Me.TP2.Name = "TP2"
        Me.TP2.Padding = New System.Windows.Forms.Padding(4)
        Me.TP2.Size = New System.Drawing.Size(933, 434)
        Me.TP2.TabIndex = 1
        Me.TP2.Text = "Basculas"
        Me.TP2.UseVisualStyleBackColor = True
        '
        'TP3
        '
        Me.TP3.Controls.Add(Me.Btn_Consulta)
        Me.TP3.Controls.Add(Me.BtnCancelar)
        Me.TP3.Controls.Add(Me.BtnNuevo)
        Me.TP3.Controls.Add(Me.DGVSobrePeso)
        Me.TP3.Location = New System.Drawing.Point(4, 28)
        Me.TP3.Name = "TP3"
        Me.TP3.Padding = New System.Windows.Forms.Padding(3)
        Me.TP3.Size = New System.Drawing.Size(933, 434)
        Me.TP3.TabIndex = 2
        Me.TP3.Text = "Avisos Sobre/Bajo Pesos"
        Me.TP3.UseVisualStyleBackColor = True
        '
        'DGVSobrePeso
        '
        Me.DGVSobrePeso.AllowUserToAddRows = False
        Me.DGVSobrePeso.AllowUserToDeleteRows = False
        Me.DGVSobrePeso.AllowUserToOrderColumns = True
        Me.DGVSobrePeso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVSobrePeso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVSobrePeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSobrePeso.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGVSobrePeso.Location = New System.Drawing.Point(3, 3)
        Me.DGVSobrePeso.Name = "DGVSobrePeso"
        Me.DGVSobrePeso.ReadOnly = True
        Me.DGVSobrePeso.Size = New System.Drawing.Size(629, 428)
        Me.DGVSobrePeso.TabIndex = 1
        '
        'TP4
        '
        Me.TP4.Controls.Add(Me.BtnExtEdit)
        Me.TP4.Controls.Add(Me.BtnExtConsulta)
        Me.TP4.Controls.Add(Me.BtnExtDel)
        Me.TP4.Controls.Add(Me.BtnExtNew)
        Me.TP4.Controls.Add(Me.DGVExt)
        Me.TP4.Location = New System.Drawing.Point(4, 28)
        Me.TP4.Name = "TP4"
        Me.TP4.Padding = New System.Windows.Forms.Padding(3)
        Me.TP4.Size = New System.Drawing.Size(933, 434)
        Me.TP4.TabIndex = 3
        Me.TP4.Text = "Extrusión"
        Me.TP4.UseVisualStyleBackColor = True
        '
        'DGVExt
        '
        Me.DGVExt.AllowUserToAddRows = False
        Me.DGVExt.AllowUserToDeleteRows = False
        Me.DGVExt.AllowUserToOrderColumns = True
        Me.DGVExt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVExt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVExt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVExt.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGVExt.Location = New System.Drawing.Point(3, 3)
        Me.DGVExt.Name = "DGVExt"
        Me.DGVExt.ReadOnly = True
        Me.DGVExt.Size = New System.Drawing.Size(629, 428)
        Me.DGVExt.TabIndex = 2
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = Global.Atlas.Administracion.My.Resources.Resources.Btn_Consulta
        Me.Btn_Consulta.Location = New System.Drawing.Point(707, 6)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(175, 50)
        Me.Btn_Consulta.TabIndex = 5
        Me.Btn_Consulta.Text = "Consulta"
        Me.Btn_Consulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Consulta.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Atlas.Administracion.My.Resources.Resources.Btn_Elimina
        Me.BtnCancelar.Location = New System.Drawing.Point(707, 118)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(175, 50)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Baja Usuario"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.Atlas.Administracion.My.Resources.Resources.Btn_Nuevo
        Me.BtnNuevo.Location = New System.Drawing.Point(707, 62)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(175, 50)
        Me.BtnNuevo.TabIndex = 3
        Me.BtnNuevo.Text = "Nuevo Usuario"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnExtEdit
        '
        Me.BtnExtEdit.Image = Global.Atlas.Administracion.My.Resources.Resources.Btn_Modifica
        Me.BtnExtEdit.Location = New System.Drawing.Point(707, 118)
        Me.BtnExtEdit.Name = "BtnExtEdit"
        Me.BtnExtEdit.Size = New System.Drawing.Size(175, 50)
        Me.BtnExtEdit.TabIndex = 9
        Me.BtnExtEdit.Text = "Modifica"
        Me.BtnExtEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExtEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnExtEdit.UseVisualStyleBackColor = True
        '
        'BtnExtConsulta
        '
        Me.BtnExtConsulta.Image = Global.Atlas.Administracion.My.Resources.Resources.Btn_Consulta
        Me.BtnExtConsulta.Location = New System.Drawing.Point(707, 6)
        Me.BtnExtConsulta.Name = "BtnExtConsulta"
        Me.BtnExtConsulta.Size = New System.Drawing.Size(175, 50)
        Me.BtnExtConsulta.TabIndex = 8
        Me.BtnExtConsulta.Text = "Consulta"
        Me.BtnExtConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExtConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnExtConsulta.UseVisualStyleBackColor = True
        '
        'BtnExtDel
        '
        Me.BtnExtDel.Image = Global.Atlas.Administracion.My.Resources.Resources.Btn_Elimina
        Me.BtnExtDel.Location = New System.Drawing.Point(707, 174)
        Me.BtnExtDel.Name = "BtnExtDel"
        Me.BtnExtDel.Size = New System.Drawing.Size(175, 50)
        Me.BtnExtDel.TabIndex = 7
        Me.BtnExtDel.Text = "Baja"
        Me.BtnExtDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExtDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnExtDel.UseVisualStyleBackColor = True
        '
        'BtnExtNew
        '
        Me.BtnExtNew.Image = Global.Atlas.Administracion.My.Resources.Resources.Btn_Nuevo
        Me.BtnExtNew.Location = New System.Drawing.Point(707, 62)
        Me.BtnExtNew.Name = "BtnExtNew"
        Me.BtnExtNew.Size = New System.Drawing.Size(175, 50)
        Me.BtnExtNew.TabIndex = 6
        Me.BtnExtNew.Text = "Nuevo"
        Me.BtnExtNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExtNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnExtNew.UseVisualStyleBackColor = True
        '
        'FrmParametrizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(941, 466)
        Me.Controls.Add(Me.TBCParametrizacion)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmParametrizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmParametrizacion"
        Me.TBCParametrizacion.ResumeLayout(False)
        Me.TP3.ResumeLayout(False)
        CType(Me.DGVSobrePeso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP4.ResumeLayout(False)
        CType(Me.DGVExt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TBCParametrizacion As System.Windows.Forms.TabControl
    Friend WithEvents TP1 As System.Windows.Forms.TabPage
    Friend WithEvents TP2 As System.Windows.Forms.TabPage
    Friend WithEvents TP3 As System.Windows.Forms.TabPage
    Friend WithEvents DGVSobrePeso As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents Btn_Consulta As System.Windows.Forms.Button
    Friend WithEvents TP4 As System.Windows.Forms.TabPage
    Friend WithEvents BtnExtConsulta As System.Windows.Forms.Button
    Friend WithEvents BtnExtDel As System.Windows.Forms.Button
    Friend WithEvents BtnExtNew As System.Windows.Forms.Button
    Friend WithEvents DGVExt As System.Windows.Forms.DataGridView
    Friend WithEvents BtnExtEdit As System.Windows.Forms.Button
End Class
