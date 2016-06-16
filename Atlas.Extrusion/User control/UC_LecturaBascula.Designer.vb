<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_LecturaBascula
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TPE = New System.Windows.Forms.TextBox()
        Me.lblPesoneto2 = New System.Windows.Forms.Label()
        Me.lblPesotara2 = New System.Windows.Forms.Label()
        Me.TPB = New System.Windows.Forms.TextBox()
        Me.TPN = New System.Windows.Forms.TextBox()
        Me.TPT = New System.Windows.Forms.TextBox()
        Me.lpbPesobruto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(684, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(272, 20)
        Me.Label9.TabIndex = 496
        Me.Label9.Text = "Peso Emp./Embalajes/Retenes (Kg)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TPE
        '
        Me.TPE.BackColor = System.Drawing.Color.Black
        Me.TPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPE.ForeColor = System.Drawing.Color.Lime
        Me.TPE.Location = New System.Drawing.Point(684, 26)
        Me.TPE.Multiline = True
        Me.TPE.Name = "TPE"
        Me.TPE.ReadOnly = True
        Me.TPE.Size = New System.Drawing.Size(275, 70)
        Me.TPE.TabIndex = 495
        Me.TPE.Text = "0.00"
        Me.TPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPesoneto2
        '
        Me.lblPesoneto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoneto2.Location = New System.Drawing.Point(1009, 2)
        Me.lblPesoneto2.Name = "lblPesoneto2"
        Me.lblPesoneto2.Size = New System.Drawing.Size(272, 20)
        Me.lblPesoneto2.TabIndex = 494
        Me.lblPesoneto2.Text = "Peso Neto ( Kg )"
        Me.lblPesoneto2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPesotara2
        '
        Me.lblPesotara2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesotara2.Location = New System.Drawing.Point(354, 2)
        Me.lblPesotara2.Name = "lblPesotara2"
        Me.lblPesotara2.Size = New System.Drawing.Size(272, 20)
        Me.lblPesotara2.TabIndex = 490
        Me.lblPesotara2.Text = "Peso Tara (Kg)"
        Me.lblPesotara2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TPB
        '
        Me.TPB.BackColor = System.Drawing.Color.Black
        Me.TPB.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPB.ForeColor = System.Drawing.Color.Lime
        Me.TPB.Location = New System.Drawing.Point(19, 25)
        Me.TPB.Multiline = True
        Me.TPB.Name = "TPB"
        Me.TPB.ReadOnly = True
        Me.TPB.Size = New System.Drawing.Size(275, 70)
        Me.TPB.TabIndex = 491
        Me.TPB.Text = "0.00"
        Me.TPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPN
        '
        Me.TPN.BackColor = System.Drawing.Color.Black
        Me.TPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPN.ForeColor = System.Drawing.Color.Lime
        Me.TPN.Location = New System.Drawing.Point(1009, 25)
        Me.TPN.Multiline = True
        Me.TPN.Name = "TPN"
        Me.TPN.ReadOnly = True
        Me.TPN.Size = New System.Drawing.Size(275, 70)
        Me.TPN.TabIndex = 493
        Me.TPN.Text = "0.00"
        Me.TPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPT
        '
        Me.TPT.BackColor = System.Drawing.Color.Black
        Me.TPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPT.ForeColor = System.Drawing.Color.Lime
        Me.TPT.Location = New System.Drawing.Point(354, 25)
        Me.TPT.Multiline = True
        Me.TPT.Name = "TPT"
        Me.TPT.ReadOnly = True
        Me.TPT.Size = New System.Drawing.Size(275, 70)
        Me.TPT.TabIndex = 492
        Me.TPT.Text = "0.00"
        Me.TPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lpbPesobruto
        '
        Me.lpbPesobruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lpbPesobruto.Location = New System.Drawing.Point(19, 2)
        Me.lpbPesobruto.Name = "lpbPesobruto"
        Me.lpbPesobruto.Size = New System.Drawing.Size(275, 20)
        Me.lpbPesobruto.TabIndex = 489
        Me.lpbPesobruto.Text = "Peso Bruto ( Kg )"
        Me.lpbPesobruto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UC_LecturaBascula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TPE)
        Me.Controls.Add(Me.lblPesoneto2)
        Me.Controls.Add(Me.lblPesotara2)
        Me.Controls.Add(Me.TPB)
        Me.Controls.Add(Me.TPN)
        Me.Controls.Add(Me.TPT)
        Me.Controls.Add(Me.lpbPesobruto)
        Me.Name = "UC_LecturaBascula"
        Me.Size = New System.Drawing.Size(1300, 99)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TPE As System.Windows.Forms.TextBox
    Friend WithEvents lblPesoneto2 As System.Windows.Forms.Label
    Friend WithEvents lblPesotara2 As System.Windows.Forms.Label
    Friend WithEvents TPB As System.Windows.Forms.TextBox
    Friend WithEvents TPN As System.Windows.Forms.TextBox
    Friend WithEvents TPT As System.Windows.Forms.TextBox
    Friend WithEvents lpbPesobruto As System.Windows.Forms.Label

End Class
