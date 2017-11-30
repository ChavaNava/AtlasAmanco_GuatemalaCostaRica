<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductionMonitor
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
        Me.PM2 = New System.Windows.Forms.Panel()
        Me.Tx5 = New System.Windows.Forms.TextBox()
        Me.Tx4 = New System.Windows.Forms.TextBox()
        Me.Tx3 = New System.Windows.Forms.TextBox()
        Me.Tx1 = New System.Windows.Forms.TextBox()
        Me.TxDesc = New System.Windows.Forms.TextBox()
        Me.TxOrden = New System.Windows.Forms.TextBox()
        Me.Tx2 = New System.Windows.Forms.TextBox()
        Me.PL2 = New System.Windows.Forms.Panel()
        Me.PL1 = New System.Windows.Forms.Panel()
        Me.TCant = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxEquipo = New System.Windows.Forms.TextBox()
        Me.PM2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PM2
        '
        Me.PM2.BackColor = System.Drawing.Color.White
        Me.PM2.Controls.Add(Me.TxEquipo)
        Me.PM2.Controls.Add(Me.TextBox1)
        Me.PM2.Controls.Add(Me.TextBox7)
        Me.PM2.Controls.Add(Me.TextBox6)
        Me.PM2.Controls.Add(Me.TextBox5)
        Me.PM2.Controls.Add(Me.TCant)
        Me.PM2.Controls.Add(Me.PL2)
        Me.PM2.Controls.Add(Me.PL1)
        Me.PM2.Controls.Add(Me.Tx5)
        Me.PM2.Controls.Add(Me.Tx4)
        Me.PM2.Controls.Add(Me.Tx3)
        Me.PM2.Controls.Add(Me.Tx1)
        Me.PM2.Controls.Add(Me.TxDesc)
        Me.PM2.Controls.Add(Me.TxOrden)
        Me.PM2.Controls.Add(Me.Tx2)
        Me.PM2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PM2.Location = New System.Drawing.Point(0, 0)
        Me.PM2.Name = "PM2"
        Me.PM2.Size = New System.Drawing.Size(986, 626)
        Me.PM2.TabIndex = 3
        '
        'Tx5
        '
        Me.Tx5.BackColor = System.Drawing.Color.SkyBlue
        Me.Tx5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tx5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx5.Location = New System.Drawing.Point(130, 404)
        Me.Tx5.Name = "Tx5"
        Me.Tx5.Size = New System.Drawing.Size(482, 40)
        Me.Tx5.TabIndex = 7
        Me.Tx5.Text = "Sobrepeso"
        Me.Tx5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx4
        '
        Me.Tx4.BackColor = System.Drawing.Color.SkyBlue
        Me.Tx4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tx4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx4.Location = New System.Drawing.Point(130, 344)
        Me.Tx4.Name = "Tx4"
        Me.Tx4.Size = New System.Drawing.Size(482, 33)
        Me.Tx4.TabIndex = 6
        Me.Tx4.Text = "Cantidad acumulada de la OF"
        Me.Tx4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx3
        '
        Me.Tx3.BackColor = System.Drawing.Color.SkyBlue
        Me.Tx3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx3.Location = New System.Drawing.Point(130, 284)
        Me.Tx3.Name = "Tx3"
        Me.Tx3.Size = New System.Drawing.Size(482, 33)
        Me.Tx3.TabIndex = 5
        Me.Tx3.Text = "Cantidad Notificada"
        Me.Tx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx1
        '
        Me.Tx1.BackColor = System.Drawing.Color.SkyBlue
        Me.Tx1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx1.Location = New System.Drawing.Point(130, 224)
        Me.Tx1.Name = "Tx1"
        Me.Tx1.Size = New System.Drawing.Size(482, 33)
        Me.Tx1.TabIndex = 4
        Me.Tx1.Text = "Cantidad a Producir"
        Me.Tx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxDesc
        '
        Me.TxDesc.BackColor = System.Drawing.Color.SkyBlue
        Me.TxDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDesc.Location = New System.Drawing.Point(130, 90)
        Me.TxDesc.Multiline = True
        Me.TxDesc.Name = "TxDesc"
        Me.TxDesc.Size = New System.Drawing.Size(740, 99)
        Me.TxDesc.TabIndex = 3
        Me.TxDesc.Text = "ORDEN #"
        Me.TxDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxOrden
        '
        Me.TxOrden.BackColor = System.Drawing.Color.SkyBlue
        Me.TxOrden.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxOrden.Location = New System.Drawing.Point(618, 12)
        Me.TxOrden.Name = "TxOrden"
        Me.TxOrden.Size = New System.Drawing.Size(252, 33)
        Me.TxOrden.TabIndex = 2
        Me.TxOrden.Text = "ORDEN #"
        Me.TxOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx2
        '
        Me.Tx2.BackColor = System.Drawing.Color.SkyBlue
        Me.Tx2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx2.Location = New System.Drawing.Point(130, 12)
        Me.Tx2.Name = "Tx2"
        Me.Tx2.Size = New System.Drawing.Size(482, 33)
        Me.Tx2.TabIndex = 1
        Me.Tx2.Text = "Orden #"
        Me.Tx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PL2
        '
        Me.PL2.BackgroundImage = Global.Atlas.Consultations.My.Resources.Resources.Fluent
        Me.PL2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PL2.Location = New System.Drawing.Point(812, 497)
        Me.PL2.Name = "PL2"
        Me.PL2.Size = New System.Drawing.Size(162, 126)
        Me.PL2.TabIndex = 321
        '
        'PL1
        '
        Me.PL1.BackgroundImage = Global.Atlas.Consultations.My.Resources.Resources.Mexichem5
        Me.PL1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PL1.Location = New System.Drawing.Point(3, 497)
        Me.PL1.Name = "PL1"
        Me.PL1.Size = New System.Drawing.Size(800, 126)
        Me.PL1.TabIndex = 320
        '
        'TCant
        '
        Me.TCant.BackColor = System.Drawing.Color.Green
        Me.TCant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCant.Location = New System.Drawing.Point(618, 224)
        Me.TCant.Name = "TCant"
        Me.TCant.Size = New System.Drawing.Size(252, 33)
        Me.TCant.TabIndex = 322
        Me.TCant.Text = "0.00"
        Me.TCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Green
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(618, 284)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(252, 33)
        Me.TextBox5.TabIndex = 323
        Me.TextBox5.Text = "0.00"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Green
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(618, 344)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(252, 33)
        Me.TextBox6.TabIndex = 324
        Me.TextBox6.Text = "0.00"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Green
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(618, 404)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(252, 40)
        Me.TextBox7.TabIndex = 325
        Me.TextBox7.Text = "0.00"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(130, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(482, 33)
        Me.TextBox1.TabIndex = 326
        Me.TextBox1.Text = "Puesto de Trabajo"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxEquipo
        '
        Me.TxEquipo.BackColor = System.Drawing.Color.SkyBlue
        Me.TxEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxEquipo.Location = New System.Drawing.Point(618, 51)
        Me.TxEquipo.Name = "TxEquipo"
        Me.TxEquipo.Size = New System.Drawing.Size(252, 33)
        Me.TxEquipo.TabIndex = 327
        Me.TxEquipo.Text = "ORDEN #"
        Me.TxEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmProductionMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(986, 626)
        Me.Controls.Add(Me.PM2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProductionMonitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProductionMonitor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PM2.ResumeLayout(False)
        Me.PM2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PM2 As System.Windows.Forms.Panel
    Friend WithEvents Tx5 As System.Windows.Forms.TextBox
    Friend WithEvents Tx4 As System.Windows.Forms.TextBox
    Friend WithEvents Tx3 As System.Windows.Forms.TextBox
    Friend WithEvents Tx1 As System.Windows.Forms.TextBox
    Friend WithEvents TxDesc As System.Windows.Forms.TextBox
    Friend WithEvents TxOrden As System.Windows.Forms.TextBox
    Friend WithEvents Tx2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TCant As System.Windows.Forms.TextBox
    Friend WithEvents PL2 As System.Windows.Forms.Panel
    Friend WithEvents PL1 As System.Windows.Forms.Panel
    Friend WithEvents TxEquipo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
