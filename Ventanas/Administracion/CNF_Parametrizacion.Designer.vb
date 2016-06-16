<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CNF_Parametrizacion
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
        Me.TBC1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBascula3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBascula2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBascula1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DGVSobrePeso = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TBC1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGVSobrePeso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(797, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TBC1
        '
        Me.TBC1.Controls.Add(Me.TabPage1)
        Me.TBC1.Controls.Add(Me.TabPage2)
        Me.TBC1.Controls.Add(Me.TabPage3)
        Me.TBC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBC1.Location = New System.Drawing.Point(0, 24)
        Me.TBC1.Name = "TBC1"
        Me.TBC1.SelectedIndex = 0
        Me.TBC1.Size = New System.Drawing.Size(797, 308)
        Me.TBC1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(789, 279)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Información General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TBascula3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TBascula2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.TBascula1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(789, 279)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Basculas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(504, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Bascula 3"
        '
        'TBascula3
        '
        Me.TBascula3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBascula3.Location = New System.Drawing.Point(106, 84)
        Me.TBascula3.Name = "TBascula3"
        Me.TBascula3.Size = New System.Drawing.Size(100, 22)
        Me.TBascula3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bascula 2"
        '
        'TBascula2
        '
        Me.TBascula2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBascula2.Location = New System.Drawing.Point(106, 56)
        Me.TBascula2.Name = "TBascula2"
        Me.TBascula2.Size = New System.Drawing.Size(100, 22)
        Me.TBascula2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bascula 1"
        '
        'TBascula1
        '
        Me.TBascula1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBascula1.Location = New System.Drawing.Point(106, 28)
        Me.TBascula1.Name = "TBascula1"
        Me.TBascula1.Size = New System.Drawing.Size(100, 22)
        Me.TBascula1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.DGVSobrePeso)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(789, 279)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cuentas Usuarios Sobre/Bajo Peso"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DGVSobrePeso
        '
        Me.DGVSobrePeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSobrePeso.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGVSobrePeso.Location = New System.Drawing.Point(3, 3)
        Me.DGVSobrePeso.Name = "DGVSobrePeso"
        Me.DGVSobrePeso.Size = New System.Drawing.Size(513, 273)
        Me.DGVSobrePeso.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Image = Global.Atlas.My.Resources.Resources.Btn_Nuevo
        Me.Button2.Location = New System.Drawing.Point(606, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Nuevo Usuario"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Atlas.My.Resources.Resources.Btn_Elimina
        Me.Button3.Location = New System.Drawing.Point(606, 62)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 50)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Baja Usuario"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CNF_Parametrizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 332)
        Me.Controls.Add(Me.TBC1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CNF_Parametrizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNF_Parametrizacion"
        Me.TBC1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DGVSobrePeso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TBC1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBascula3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBascula2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBascula1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DGVSobrePeso As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
