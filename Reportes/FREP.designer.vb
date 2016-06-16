<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FREP
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FREP))
        Me.CRV1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRV1
        '
        Me.CRV1.ActiveViewIndex = -1
        Me.CRV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV1.Location = New System.Drawing.Point(0, 0)
        Me.CRV1.Name = "CRV1"
        Me.CRV1.Size = New System.Drawing.Size(992, 534)
        Me.CRV1.TabIndex = 0
        '
        'FREP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 534)
        Me.Controls.Add(Me.CRV1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FREP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FREP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
