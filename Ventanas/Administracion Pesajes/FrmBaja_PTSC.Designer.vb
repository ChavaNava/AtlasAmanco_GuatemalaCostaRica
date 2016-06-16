<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBaja_PTSC
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TFecha = New System.Windows.Forms.TextBox()
        Me.TFolio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TProceso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TNumSap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TdocSap = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tobservaciones = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'TFecha
        '
        Me.TFecha.Location = New System.Drawing.Point(145, 16)
        Me.TFecha.Name = "TFecha"
        Me.TFecha.ReadOnly = True
        Me.TFecha.Size = New System.Drawing.Size(118, 22)
        Me.TFecha.TabIndex = 1
        '
        'TFolio
        '
        Me.TFolio.Location = New System.Drawing.Point(419, 16)
        Me.TFolio.Name = "TFolio"
        Me.TFolio.ReadOnly = True
        Me.TFolio.Size = New System.Drawing.Size(118, 22)
        Me.TFolio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(366, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Folio:"
        '
        'TProceso
        '
        Me.TProceso.Location = New System.Drawing.Point(145, 44)
        Me.TProceso.Name = "TProceso"
        Me.TProceso.ReadOnly = True
        Me.TProceso.Size = New System.Drawing.Size(118, 22)
        Me.TProceso.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Proceso:"
        '
        'TOrden
        '
        Me.TOrden.Location = New System.Drawing.Point(419, 44)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.ReadOnly = True
        Me.TOrden.Size = New System.Drawing.Size(118, 22)
        Me.TOrden.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(269, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Orden Fabricación :"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackgroundImage = Global.Atlas.My.Resources.Resources.msgOk
        Me.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAceptar.Location = New System.Drawing.Point(585, 12)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(141, 50)
        Me.BtnAceptar.TabIndex = 8
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = Global.Atlas.My.Resources.Resources.msgError
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCancelar.Location = New System.Drawing.Point(585, 68)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(141, 50)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TNumSap
        '
        Me.TNumSap.Location = New System.Drawing.Point(419, 72)
        Me.TNumSap.Name = "TNumSap"
        Me.TNumSap.ReadOnly = True
        Me.TNumSap.Size = New System.Drawing.Size(118, 22)
        Me.TNumSap.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(282, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Consecutivo SAP:"
        '
        'TdocSap
        '
        Me.TdocSap.Location = New System.Drawing.Point(145, 72)
        Me.TdocSap.Name = "TdocSap"
        Me.TdocSap.ReadOnly = True
        Me.TdocSap.Size = New System.Drawing.Size(118, 22)
        Me.TdocSap.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Documento SAP:"
        '
        'Tobservaciones
        '
        Me.Tobservaciones.Location = New System.Drawing.Point(145, 100)
        Me.Tobservaciones.Multiline = True
        Me.Tobservaciones.Name = "Tobservaciones"
        Me.Tobservaciones.Size = New System.Drawing.Size(392, 81)
        Me.Tobservaciones.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Observaciones"
        '
        'FrmBaja_PTSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 186)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Tobservaciones)
        Me.Controls.Add(Me.TNumSap)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TdocSap)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TOrden)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TProceso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TFolio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TFecha)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmBaja_PTSC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBaja_PTSC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TFecha As System.Windows.Forms.TextBox
    Friend WithEvents TFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TProceso As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents TNumSap As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TdocSap As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
