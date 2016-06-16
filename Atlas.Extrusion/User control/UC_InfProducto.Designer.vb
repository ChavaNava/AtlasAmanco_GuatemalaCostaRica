<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_InfProducto
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TGrpproddesc = New System.Windows.Forms.TextBox()
        Me.TSP_Permitido = New System.Windows.Forms.TextBox()
        Me.lblSPpermitido = New System.Windows.Forms.Label()
        Me.TGrupo = New System.Windows.Forms.TextBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.TGrpprod = New System.Windows.Forms.TextBox()
        Me.TPesoTeorico = New System.Windows.Forms.TextBox()
        Me.lblTeorico = New System.Windows.Forms.Label()
        Me.lblSobrepeso = New System.Windows.Forms.Label()
        Me.TSobrePeso = New System.Windows.Forms.TextBox()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.TCodPT = New System.Windows.Forms.TextBox()
        Me.TCodPtDecr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TGrpproddesc
        '
        Me.TGrpproddesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGrpproddesc.Location = New System.Drawing.Point(208, 26)
        Me.TGrpproddesc.Name = "TGrpproddesc"
        Me.TGrpproddesc.ReadOnly = True
        Me.TGrpproddesc.Size = New System.Drawing.Size(247, 22)
        Me.TGrpproddesc.TabIndex = 435
        '
        'TSP_Permitido
        '
        Me.TSP_Permitido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSP_Permitido.Location = New System.Drawing.Point(338, 50)
        Me.TSP_Permitido.Name = "TSP_Permitido"
        Me.TSP_Permitido.ReadOnly = True
        Me.TSP_Permitido.Size = New System.Drawing.Size(54, 22)
        Me.TSP_Permitido.TabIndex = 433
        '
        'lblSPpermitido
        '
        Me.lblSPpermitido.AutoSize = True
        Me.lblSPpermitido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSPpermitido.ForeColor = System.Drawing.Color.Black
        Me.lblSPpermitido.Location = New System.Drawing.Point(204, 53)
        Me.lblSPpermitido.Name = "lblSPpermitido"
        Me.lblSPpermitido.Size = New System.Drawing.Size(125, 16)
        Me.lblSPpermitido.TabIndex = 434
        Me.lblSPpermitido.Text = "SP Permitido (%)"
        Me.lblSPpermitido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TGrupo
        '
        Me.TGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGrupo.Location = New System.Drawing.Point(517, 26)
        Me.TGrupo.Name = "TGrupo"
        Me.TGrupo.ReadOnly = True
        Me.TGrupo.Size = New System.Drawing.Size(72, 22)
        Me.TGrupo.TabIndex = 431
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.ForeColor = System.Drawing.Color.Black
        Me.lblGrupo.Location = New System.Drawing.Point(461, 29)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(50, 16)
        Me.lblGrupo.TabIndex = 432
        Me.lblGrupo.Text = "Grupo"
        Me.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblArea
        '
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.Black
        Me.lblArea.Location = New System.Drawing.Point(2, 30)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(118, 17)
        Me.lblArea.TabIndex = 430
        Me.lblArea.Text = "Area Producción"
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TGrpprod
        '
        Me.TGrpprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGrpprod.Location = New System.Drawing.Point(126, 27)
        Me.TGrpprod.Name = "TGrpprod"
        Me.TGrpprod.ReadOnly = True
        Me.TGrpprod.Size = New System.Drawing.Size(75, 22)
        Me.TGrpprod.TabIndex = 426
        '
        'TPesoTeorico
        '
        Me.TPesoTeorico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPesoTeorico.Location = New System.Drawing.Point(126, 50)
        Me.TPesoTeorico.Name = "TPesoTeorico"
        Me.TPesoTeorico.ReadOnly = True
        Me.TPesoTeorico.Size = New System.Drawing.Size(75, 22)
        Me.TPesoTeorico.TabIndex = 427
        '
        'lblTeorico
        '
        Me.lblTeorico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeorico.ForeColor = System.Drawing.Color.Black
        Me.lblTeorico.Location = New System.Drawing.Point(2, 53)
        Me.lblTeorico.Name = "lblTeorico"
        Me.lblTeorico.Size = New System.Drawing.Size(118, 17)
        Me.lblTeorico.TabIndex = 429
        Me.lblTeorico.Text = "Peso Teórico"
        Me.lblTeorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSobrepeso
        '
        Me.lblSobrepeso.AutoSize = True
        Me.lblSobrepeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSobrepeso.ForeColor = System.Drawing.Color.Black
        Me.lblSobrepeso.Location = New System.Drawing.Point(398, 53)
        Me.lblSobrepeso.Name = "lblSobrepeso"
        Me.lblSobrepeso.Size = New System.Drawing.Size(117, 16)
        Me.lblSobrepeso.TabIndex = 423
        Me.lblSobrepeso.Text = "Sobre Peso (%)"
        Me.lblSobrepeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TSobrePeso
        '
        Me.TSobrePeso.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TSobrePeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSobrePeso.Location = New System.Drawing.Point(517, 50)
        Me.TSobrePeso.Name = "TSobrePeso"
        Me.TSobrePeso.ReadOnly = True
        Me.TSobrePeso.Size = New System.Drawing.Size(72, 22)
        Me.TSobrePeso.TabIndex = 428
        '
        'lblMaterial
        '
        Me.lblMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterial.ForeColor = System.Drawing.Color.Black
        Me.lblMaterial.Location = New System.Drawing.Point(2, 6)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(118, 17)
        Me.lblMaterial.TabIndex = 422
        Me.lblMaterial.Text = "Código Material"
        Me.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TCodPT
        '
        Me.TCodPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodPT.Location = New System.Drawing.Point(126, 3)
        Me.TCodPT.Multiline = True
        Me.TCodPT.Name = "TCodPT"
        Me.TCodPT.ReadOnly = True
        Me.TCodPT.Size = New System.Drawing.Size(75, 23)
        Me.TCodPT.TabIndex = 424
        '
        'TCodPtDecr
        '
        Me.TCodPtDecr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodPtDecr.Location = New System.Drawing.Point(208, 3)
        Me.TCodPtDecr.Name = "TCodPtDecr"
        Me.TCodPtDecr.ReadOnly = True
        Me.TCodPtDecr.Size = New System.Drawing.Size(381, 22)
        Me.TCodPtDecr.TabIndex = 425
        '
        'UC_InfProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TGrpproddesc)
        Me.Controls.Add(Me.TSP_Permitido)
        Me.Controls.Add(Me.lblSPpermitido)
        Me.Controls.Add(Me.TGrupo)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.TGrpprod)
        Me.Controls.Add(Me.TPesoTeorico)
        Me.Controls.Add(Me.lblTeorico)
        Me.Controls.Add(Me.lblSobrepeso)
        Me.Controls.Add(Me.TSobrePeso)
        Me.Controls.Add(Me.lblMaterial)
        Me.Controls.Add(Me.TCodPT)
        Me.Controls.Add(Me.TCodPtDecr)
        Me.Name = "UC_InfProducto"
        Me.Size = New System.Drawing.Size(592, 75)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TGrpproddesc As System.Windows.Forms.TextBox
    Friend WithEvents TSP_Permitido As System.Windows.Forms.TextBox
    Friend WithEvents lblSPpermitido As System.Windows.Forms.Label
    Friend WithEvents TGrupo As System.Windows.Forms.TextBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents TGrpprod As System.Windows.Forms.TextBox
    Friend WithEvents TPesoTeorico As System.Windows.Forms.TextBox
    Friend WithEvents lblTeorico As System.Windows.Forms.Label
    Friend WithEvents lblSobrepeso As System.Windows.Forms.Label
    Friend WithEvents TSobrePeso As System.Windows.Forms.TextBox
    Friend WithEvents lblMaterial As System.Windows.Forms.Label
    Friend WithEvents TCodPT As System.Windows.Forms.TextBox
    Friend WithEvents TCodPtDecr As System.Windows.Forms.TextBox

End Class
