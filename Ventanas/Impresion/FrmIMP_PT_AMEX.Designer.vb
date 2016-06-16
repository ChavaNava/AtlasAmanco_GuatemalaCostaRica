<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIMP_PT_AMEX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIMP_PT_AMEX))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.BImp = New System.Windows.Forms.Button()
        Me.BCancel = New System.Windows.Forms.Button()
        Me.CB_Prod = New System.Windows.Forms.CheckBox()
        Me.CB_ODF = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_Turno = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.THI = New System.Windows.Forms.TextBox()
        Me.THF = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_CompXProd = New System.Windows.Forms.CheckBox()
        Me.CB_CompXOrd = New System.Windows.Forms.CheckBox()
        Me.CB_Notif = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TOrden = New System.Windows.Forms.TextBox()
        Me.CB_Sub = New System.Windows.Forms.CheckBox()
        Me.CBODFRes = New System.Windows.Forms.CheckBox()
        Me.CB_DetXPtoTra = New System.Windows.Forms.CheckBox()
        Me.CB_ResXPtoTra = New System.Windows.Forms.CheckBox()
        Me.CB_EntPT = New System.Windows.Forms.CheckBox()
        Me.CB_ResXTipoComp = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio Pesaje"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Fin Pesaje"
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(168, 35)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(108, 22)
        Me.DTP_FI.TabIndex = 2
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy-MM-dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(168, 91)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(108, 22)
        Me.DTP_FF.TabIndex = 3
        '
        'BImp
        '
        Me.BImp.Image = CType(resources.GetObject("BImp.Image"), System.Drawing.Image)
        Me.BImp.Location = New System.Drawing.Point(282, 7)
        Me.BImp.Name = "BImp"
        Me.BImp.Size = New System.Drawing.Size(150, 36)
        Me.BImp.TabIndex = 4
        Me.BImp.Text = "Imprimir"
        Me.BImp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BImp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BImp.UseVisualStyleBackColor = True
        '
        'BCancel
        '
        Me.BCancel.Image = CType(resources.GetObject("BCancel.Image"), System.Drawing.Image)
        Me.BCancel.Location = New System.Drawing.Point(282, 49)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(150, 36)
        Me.BCancel.TabIndex = 5
        Me.BCancel.Text = "Cancelar"
        Me.BCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancel.UseVisualStyleBackColor = True
        '
        'CB_Prod
        '
        Me.CB_Prod.AutoSize = True
        Me.CB_Prod.Location = New System.Drawing.Point(11, 177)
        Me.CB_Prod.Name = "CB_Prod"
        Me.CB_Prod.Size = New System.Drawing.Size(244, 20)
        Me.CB_Prod.TabIndex = 6
        Me.CB_Prod.Text = "Detalle Ordenado Por Producto"
        Me.CB_Prod.UseVisualStyleBackColor = True
        '
        'CB_ODF
        '
        Me.CB_ODF.AutoSize = True
        Me.CB_ODF.Location = New System.Drawing.Point(11, 203)
        Me.CB_ODF.Name = "CB_ODF"
        Me.CB_ODF.Size = New System.Drawing.Size(304, 20)
        Me.CB_ODF.TabIndex = 7
        Me.CB_ODF.Text = "Detalle Ordenado Por Número de Orden"
        Me.CB_ODF.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Turno"
        '
        'CB_Turno
        '
        Me.CB_Turno.FormattingEnabled = True
        Me.CB_Turno.Location = New System.Drawing.Point(168, 147)
        Me.CB_Turno.Name = "CB_Turno"
        Me.CB_Turno.Size = New System.Drawing.Size(108, 24)
        Me.CB_Turno.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Hora Inicio Pesaje"
        '
        'THI
        '
        Me.THI.Location = New System.Drawing.Point(168, 63)
        Me.THI.Name = "THI"
        Me.THI.Size = New System.Drawing.Size(108, 22)
        Me.THI.TabIndex = 11
        Me.THI.Text = "00:00:01"
        '
        'THF
        '
        Me.THF.Location = New System.Drawing.Point(168, 119)
        Me.THF.Name = "THF"
        Me.THF.Size = New System.Drawing.Size(108, 22)
        Me.THF.TabIndex = 12
        Me.THF.Text = "23:59:59"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Hora Fin Pesaje"
        '
        'CB_CompXProd
        '
        Me.CB_CompXProd.AutoSize = True
        Me.CB_CompXProd.Location = New System.Drawing.Point(11, 255)
        Me.CB_CompXProd.Name = "CB_CompXProd"
        Me.CB_CompXProd.Size = New System.Drawing.Size(267, 20)
        Me.CB_CompXProd.TabIndex = 14
        Me.CB_CompXProd.Text = "Consumo Compuesto Por Producto"
        Me.CB_CompXProd.UseVisualStyleBackColor = True
        '
        'CB_CompXOrd
        '
        Me.CB_CompXOrd.AutoSize = True
        Me.CB_CompXOrd.Location = New System.Drawing.Point(11, 281)
        Me.CB_CompXOrd.Name = "CB_CompXOrd"
        Me.CB_CompXOrd.Size = New System.Drawing.Size(327, 20)
        Me.CB_CompXOrd.TabIndex = 15
        Me.CB_CompXOrd.Text = "Consumo Compuesto Por Número de Orden"
        Me.CB_CompXOrd.UseVisualStyleBackColor = True
        '
        'CB_Notif
        '
        Me.CB_Notif.AutoSize = True
        Me.CB_Notif.Location = New System.Drawing.Point(11, 411)
        Me.CB_Notif.Name = "CB_Notif"
        Me.CB_Notif.Size = New System.Drawing.Size(156, 20)
        Me.CB_Notif.TabIndex = 16
        Me.CB_Notif.Text = "Excluir Notificados"
        Me.CB_Notif.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Orden de Producción"
        '
        'TOrden
        '
        Me.TOrden.Location = New System.Drawing.Point(168, 7)
        Me.TOrden.Name = "TOrden"
        Me.TOrden.Size = New System.Drawing.Size(108, 22)
        Me.TOrden.TabIndex = 17
        Me.TOrden.Text = "*"
        '
        'CB_Sub
        '
        Me.CB_Sub.AutoSize = True
        Me.CB_Sub.Location = New System.Drawing.Point(11, 437)
        Me.CB_Sub.Name = "CB_Sub"
        Me.CB_Sub.Size = New System.Drawing.Size(135, 20)
        Me.CB_Sub.TabIndex = 19
        Me.CB_Sub.Text = "Sub Ensambles"
        Me.CB_Sub.UseVisualStyleBackColor = True
        '
        'CBODFRes
        '
        Me.CBODFRes.AutoSize = True
        Me.CBODFRes.Location = New System.Drawing.Point(11, 229)
        Me.CBODFRes.Name = "CBODFRes"
        Me.CBODFRes.Size = New System.Drawing.Size(319, 20)
        Me.CBODFRes.TabIndex = 20
        Me.CBODFRes.Text = "Resumen Ordenado Por Número de Orden"
        Me.CBODFRes.UseVisualStyleBackColor = True
        '
        'CB_DetXPtoTra
        '
        Me.CB_DetXPtoTra.AutoSize = True
        Me.CB_DetXPtoTra.Location = New System.Drawing.Point(11, 307)
        Me.CB_DetXPtoTra.Name = "CB_DetXPtoTra"
        Me.CB_DetXPtoTra.Size = New System.Drawing.Size(315, 20)
        Me.CB_DetXPtoTra.TabIndex = 21
        Me.CB_DetXPtoTra.Text = "Detalle Ordenado Por  Puesto de Trabajo"
        Me.CB_DetXPtoTra.UseVisualStyleBackColor = True
        '
        'CB_ResXPtoTra
        '
        Me.CB_ResXPtoTra.AutoSize = True
        Me.CB_ResXPtoTra.Location = New System.Drawing.Point(11, 333)
        Me.CB_ResXPtoTra.Name = "CB_ResXPtoTra"
        Me.CB_ResXPtoTra.Size = New System.Drawing.Size(324, 20)
        Me.CB_ResXPtoTra.TabIndex = 22
        Me.CB_ResXPtoTra.Text = "Resumen ordenado Por Puesto de Trabajo"
        Me.CB_ResXPtoTra.UseVisualStyleBackColor = True
        '
        'CB_EntPT
        '
        Me.CB_EntPT.AutoSize = True
        Me.CB_EntPT.Location = New System.Drawing.Point(11, 385)
        Me.CB_EntPT.Name = "CB_EntPT"
        Me.CB_EntPT.Size = New System.Drawing.Size(248, 20)
        Me.CB_EntPT.TabIndex = 23
        Me.CB_EntPT.Text = "Entrega de Producto Terminado"
        Me.CB_EntPT.UseVisualStyleBackColor = True
        '
        'CB_ResXTipoComp
        '
        Me.CB_ResXTipoComp.AutoSize = True
        Me.CB_ResXTipoComp.Location = New System.Drawing.Point(11, 359)
        Me.CB_ResXTipoComp.Name = "CB_ResXTipoComp"
        Me.CB_ResXTipoComp.Size = New System.Drawing.Size(308, 20)
        Me.CB_ResXTipoComp.TabIndex = 24
        Me.CB_ResXTipoComp.Text = "Resumen ordenado por Tipo Compuesto"
        Me.CB_ResXTipoComp.UseVisualStyleBackColor = True
        '
        'FrmIMP_PT_AMEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 474)
        Me.Controls.Add(Me.CB_ResXTipoComp)
        Me.Controls.Add(Me.CB_EntPT)
        Me.Controls.Add(Me.CB_ResXPtoTra)
        Me.Controls.Add(Me.CB_DetXPtoTra)
        Me.Controls.Add(Me.CBODFRes)
        Me.Controls.Add(Me.CB_Sub)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TOrden)
        Me.Controls.Add(Me.CB_Notif)
        Me.Controls.Add(Me.CB_CompXOrd)
        Me.Controls.Add(Me.CB_CompXProd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.THF)
        Me.Controls.Add(Me.THI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_Turno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_ODF)
        Me.Controls.Add(Me.CB_Prod)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.BImp)
        Me.Controls.Add(Me.DTP_FF)
        Me.Controls.Add(Me.DTP_FI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIMP_PT_AMEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents BImp As System.Windows.Forms.Button
    Friend WithEvents BCancel As System.Windows.Forms.Button
    Friend WithEvents CB_Prod As System.Windows.Forms.CheckBox
    Friend WithEvents CB_ODF As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CB_Turno As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents THI As System.Windows.Forms.TextBox
    Friend WithEvents THF As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CB_CompXProd As System.Windows.Forms.CheckBox
    Friend WithEvents CB_CompXOrd As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Notif As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TOrden As System.Windows.Forms.TextBox
    Friend WithEvents CB_Sub As System.Windows.Forms.CheckBox
    Friend WithEvents CBODFRes As System.Windows.Forms.CheckBox
    Friend WithEvents CB_DetXPtoTra As System.Windows.Forms.CheckBox
    Friend WithEvents CB_ResXPtoTra As System.Windows.Forms.CheckBox
    Friend WithEvents CB_EntPT As System.Windows.Forms.CheckBox
    Friend WithEvents CB_ResXTipoComp As System.Windows.Forms.CheckBox
End Class
