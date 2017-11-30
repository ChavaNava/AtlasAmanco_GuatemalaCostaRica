<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingForm
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
        Me.components = New System.ComponentModel.Container()
        Me.pcbWait = New System.Windows.Forms.PictureBox()
        Me.TimerClose = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pcbWait, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbWait
        '
        Me.pcbWait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pcbWait.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcbWait.Image = Global.Utili_Generales.My.Resources.Resources.loader
        Me.pcbWait.Location = New System.Drawing.Point(0, 0)
        Me.pcbWait.Name = "pcbWait"
        Me.pcbWait.Size = New System.Drawing.Size(316, 220)
        Me.pcbWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbWait.TabIndex = 0
        Me.pcbWait.TabStop = False
        '
        'TimerClose
        '
        Me.TimerClose.Interval = 333
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(316, 220)
        Me.Controls.Add(Me.pcbWait)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "LoadingForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoadingForm"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.pcbWait, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pcbWait As System.Windows.Forms.PictureBox
    Friend WithEvents TimerClose As System.Windows.Forms.Timer
End Class
