Imports System.Windows.Forms.Form
Imports System.Windows.Forms.Form.ControlCollection
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales

Module MdFormControl
#Region "Variables de Miembro"
    Dim N_Text As String
    Dim Nom_Text As String
    Dim NameItem As String
#End Region
   
    'Limpia Cajas de Texto
    Public Sub LimpiarText(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is TextBox Then
                fcontrol.Text = ""
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Control In tcontrol.Controls
                            If TypeOf pcontrol Is TextBox Then
                                If pcontrol.Name <> "TCentro" Then
                                    pcontrol.Text = ""
                                End If
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Bloquea Cajas de Texto
    Public Sub BloqueaText(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is TextBox Then
                fcontrol.Enabled = False
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Control In tcontrol.Controls
                            If TypeOf pcontrol Is TextBox Then
                                If pcontrol.Name <> "TCentro" Then
                                    pcontrol.Enabled = False
                                End If                                
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Activa Cajas de Texto
    Public Sub ActivaText(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is TextBox Then
                fcontrol.Enabled = True
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Control In tcontrol.Controls
                            If TypeOf pcontrol Is TextBox Then
                                If pcontrol.Name <> "TCentro" Then
                                    pcontrol.Enabled = True
                                End If                                
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Activa Cajas de Texto de Pantalla Verifica PT
    Public Sub ActivaTextPT(ByVal frmForm As Form)
        Dim actTextPT As Object
        Dim Nom_Txt As Object
        On Error Resume Next
        For Each actTextPT In frmForm.Controls
            If TypeOf actTextPT Is System.Windows.Forms.TextBox Then

                Nom_Txt = actTextPT.Name

                If Nom_Txt.Trim Like "TS*" Or Nom_Txt.Trim Like "TA*" Or Nom_Txt.Trim Like "TL*" Then
                    actTextPT.Enabled = True
                    actTextPT.ReadOnly = False
                    actTextPT.ListIndex = -1
                End If

            End If
        Next actTextPT
    End Sub

    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.LightBlue
    End Sub

    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.White
    End Sub

    'Focus en un textbox dentro de un Goup Box
    Public Sub Focus_Text(ByVal frmForm As Form, TextName As String)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is TextBox Then
                fcontrol.Text = ""
            ElseIf TypeOf fcontrol Is GroupBox Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Control In tcontrol.Controls
                            If TypeOf pcontrol Is ComboBox Then
                                pcontrol.Text = ""
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub


    'Limpia Masked Text Box
    Public Sub LimpiarMText(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is MaskedTextBox Then
                fcontrol.Text = ""
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Control In tcontrol.Controls
                            If TypeOf pcontrol Is MaskedTextBox Then
                                pcontrol.Text = ""
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Bloquear Masked Text Box
    Public Sub BloqueaMText(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is MaskedTextBox Then
                fcontrol.Enabled = False
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Control In tcontrol.Controls
                            If TypeOf pcontrol Is MaskedTextBox Then
                                pcontrol.Enabled = False
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Activa Masked Text Box
    Public Sub ActivaMText(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is MaskedTextBox Then
                fcontrol.Enabled = True
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Control In tcontrol.Controls
                            If TypeOf pcontrol Is MaskedTextBox Then
                                pcontrol.Enabled = True
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Limpiar ComboBox
    Public Sub LimpiarCombo(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is ComboBox Then
                fcontrol.Text = ""
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Control In tcontrol.Controls
                            If TypeOf pcontrol Is ComboBox Then
                                pcontrol.Text = ""
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Bloquear ComboBox
    Public Sub BloqueaCombo(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is ComboBox Then
                fcontrol.Enabled = False
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Control In tcontrol.Controls
                            If TypeOf pcontrol Is ComboBox Then
                                pcontrol.Enabled = False
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Activar ComboBox
    Public Sub ActivaCombo(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is ComboBox Then
                fcontrol.Enabled = True
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Control In tcontrol.Controls
                            If TypeOf pcontrol Is ComboBox Then
                                pcontrol.Enabled = True
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Limpiar CheckBox
    Public Sub LimpiarCheckBox(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Object In frmForm.Controls
            If TypeOf fcontrol Is CheckBox Then
                fcontrol.Checked = False
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Object In tcontrol.Controls
                            If TypeOf pcontrol Is CheckBox Then
                                pcontrol.Checked = False
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Bloquear CheckBox
    Public Sub BloqueaCheckBox(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Object In frmForm.Controls
            If TypeOf fcontrol Is CheckBox Then
                fcontrol.Enabled = False
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Object In tcontrol.Controls
                            If TypeOf pcontrol Is CheckBox Then
                                pcontrol.Enabled = False
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Activar CheckBox
    Public Sub ActivaCheckBox(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Object In frmForm.Controls
            If TypeOf fcontrol Is CheckBox Then
                fcontrol.Enabled = True
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Object In tcontrol.Controls
                            If TypeOf pcontrol Is CheckBox Then
                                pcontrol.Enabled = True
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Limpiar Label
    Public Sub LimpiarLabel(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Object In frmForm.Controls
            If TypeOf fcontrol Is Label Then
                fcontrol.Text = ""
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Object In tcontrol.Controls
                            If TypeOf pcontrol Is Label Then
                                pcontrol.Text = ""
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Bloquear Label
    Public Sub BloquearLabel(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Object In frmForm.Controls
            If TypeOf fcontrol Is Label Then
                fcontrol.Enabled = False
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Object In tcontrol.Controls
                            If TypeOf pcontrol Is Label Then
                                pcontrol.Enabled = False
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Bloquear Button
    Public Sub BloqueaButton(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Object In frmForm.Controls
            If TypeOf fcontrol Is Button Then
                fcontrol.Enabled = False
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Object In tcontrol.Controls
                            If TypeOf pcontrol Is Button Then
                                pcontrol.Enabled = False
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Activar Button
    Public Sub ActivaButton(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Object In frmForm.Controls
            If TypeOf fcontrol Is Button Then
                fcontrol.Enabled = True
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Object In tcontrol.Controls
                            If TypeOf pcontrol Is Button Then
                                pcontrol.Enabled = True
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Activar Label
    Public Sub ActivarLabel(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Object In frmForm.Controls
            If TypeOf fcontrol Is Label Then
                fcontrol.Enabled = True
            ElseIf TypeOf fcontrol Is TabControl Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TabPage Then
                        'Recorremos los controles de cada pestaña del TAB
                        For Each pcontrol As Object In tcontrol.Controls
                            If TypeOf pcontrol Is Label Then
                                pcontrol.Enabled = True
                            End If
                        Next pcontrol
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Controla que no se dupliquen numeros de sello
    Public Sub Verifica(ByVal frmForm As Form, ByVal N_sello As String, ByVal T_Sello As String)
        Dim CtrVer As Object

        On Error Resume Next
        For Each CtrVer In frmForm.Controls
            If TypeOf CtrVer Is System.Windows.Forms.TextBox Then
                If CtrVer.Text <> "" Then

                    N_Text = CtrVer.Text.Trim
                    Nom_Text = CtrVer.Name

                    If Nom_Text Like "T*" Then

                        Dim Cont As Integer

                        QRY = "Select * from Sellos "
                        QRY = QRY & "where Sello  = '" & N_sello.Trim & "' "
                        QRY = QRY & "And T_Sello = '" & T_Sello.Trim & "' "
                        QRY = QRY & "And Centro = '" & SessionUser._sCentro.Trim & "' "
                        LecturaQry(QRY)

                        Cont = 0

                        Do While (LecturaBD.Read)
                            Cont = Cont + 1
                        Loop

                        LecturaBD.Close()

                        If Cont > 0 Then
                            MessageBox.Show("--- El numero de sello ya ha sido utilizado, capture otro por favor ---")
                            CtrVer.Text = ""
                            CtrVer.Focus()
                            Exit Sub
                        End If


                    End If
                End If
                CtrVer.ListIndex = -1
            End If
        Next CtrVer

    End Sub

    'Desactiva Button en MenuStrip del Menu Principal
    Public Sub DesButtons_Main(ByVal frmForm As Form)
        Dim Tool As Object
        Dim Pr As ToolStripItem
        Dim item As ToolStripMenuItem
        Dim Item_Name As Object

        On Error Resume Next
        For Each Tool In frmForm.Controls
            If TypeOf Tool Is System.Windows.Forms.MenuStrip Then
                If Tool.Name = FrmMain.MenuStrip1.Name Then
                    Dim items As ToolStripItemCollection = Tool.Items
                    For i As Integer = 0 To items.Count - 1
                        Pr = items(i)
                        If Pr.Name Like "MP*" Then
                            Pr.Visible = False
                        ElseIf Pr.Name.Trim = "Reiniciar" Then
                            Pr.Enabled = False
                        End If
                    Next
                    For Each item In FrmMain.MP_ADM.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmMain.MP_EXT.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmMain.MP_INY.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmMain.MP_ROT.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmMain.MP_GEO.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmMain.MP_SUP.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmMain.MP_ORDENES.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmMain.MP_ALM.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmMain.MP_CON.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                End If
            End If
        Next Tool
    End Sub

    'Desactiva Button en MenuStrip del Administración
    Public Sub DesButtons_Admin(ByVal frmForm As Form)
        Dim Tool As Object
        Dim Pr As ToolStripItem
        Dim item As ToolStripMenuItem
        Dim Item_Name As Object

        On Error Resume Next
        For Each Tool In frmForm.Controls
            If TypeOf Tool Is System.Windows.Forms.MenuStrip Then
                If Tool.Name = FrmAdmin.MenuStrip2.Name Then
                    Dim items As ToolStripItemCollection = Tool.Items
                    For i As Integer = 0 To items.Count - 1
                        Pr = items(i)
                        If Pr.Name Like "MA%" Then
                            Pr.Visible = False
                        End If
                    Next
                    For Each item In FrmAdmin.MA_CONFIG.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmAdmin.MA_PE.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmAdmin.MA_PRD.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmAdmin.MA_ODP.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmAdmin.MA_CAT.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                    For Each item In FrmAdmin.MA_PESHRS.DropDownItems
                        Item_Name = item.Name
                        item.Visible = False
                        item.Enabled = False
                    Next
                End If
            End If
        Next Tool
    End Sub

    'Activa Button en MenuStrip de Menu Principal
    Public Sub ActButMS_Main(ByVal frmForm As Form, ByVal Modulo As String)
        Dim Tool As Object
        Dim Pr As ToolStripItem
        Dim item As ToolStripMenuItem
        Dim Item_Name As String
        On Error Resume Next
        For Each Tool In frmForm.Controls
            If TypeOf Tool Is System.Windows.Forms.ToolStrip Then
                If Tool.Name = FrmMain.MenuStrip1.Name Then
                    Dim items As ToolStripItemCollection = Tool.Items
                    For i As Integer = 0 To items.Count - 1
                        Pr = items(i)
                        If Pr.Name = Modulo.Trim Then
                            Pr.Visible = True
                            Pr.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_ADM.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_EXT.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_INY.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_ROT.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_GEO.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_SUP.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_ORDENES.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_ORDENES.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_CALIDAD.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_PLANEACION.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_ALM.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.MP_CON.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                    For Each item In FrmMain.CNFG.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            item.Enabled = True
                        End If
                    Next
                End If
            End If
        Next Tool
    End Sub

    'Activa Button en MenuStrip de Administración
    Public Sub ActButMS_Admin(ByVal frmForm As Form, ByVal Modulo As String)
        Dim Tool As Object
        Dim Pr As ToolStripItem
        Dim item As ToolStripMenuItem
        Dim Item_Name As String
        On Error Resume Next
        For Each Tool In frmForm.Controls
            If TypeOf Tool Is System.Windows.Forms.ToolStrip Then
                If Tool.Name = FrmAdmin.MenuStrip2.Name Then
                    Dim items As ToolStripItemCollection = Tool.Items
                    For i As Integer = 0 To items.Count - 1
                        Pr = items(i)
                        'If Pr.Name = Modulo.Trim Then
                        Pr.Visible = True
                        'End If
                    Next
                    For Each item In FrmAdmin.MA_CONFIG.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            Exit Sub
                        End If
                    Next
                    For Each item In FrmAdmin.MA_PE.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            Exit Sub
                        End If
                    Next
                    For Each item In FrmAdmin.MA_PRD.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            Exit Sub
                        End If
                    Next
                    For Each item In FrmAdmin.MA_ODP.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            Exit Sub
                        End If
                    Next
                    For Each item In FrmAdmin.MA_CAT.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            Exit Sub
                        End If
                    Next
                    For Each item In FrmAdmin.MA_PESHRS.DropDownItems
                        Item_Name = item.Name
                        If Item_Name = Modulo.Trim Then
                            item.Visible = True
                            Exit Sub
                        End If
                    Next
                End If
            End If
        Next Tool
    End Sub

    'Exportar resultado de un datagridview a Excel

    Public Sub Export_Excel(ByVal DGV As DataGridView)

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DGV.ColumnCount
            Dim NRow As Integer = DGV.RowCount
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DGV.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DGV.Rows(Fila).Cells(Col).Value
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            'Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub

    'Pasarle a esta rutina la fecha que queremos averiguar   
    Public Sub PrimerUltimoDia(ByVal Fecha As Date)

        Dim Primer As Date
        Dim Ultimo As Date

        'Usamos la funcion DateSerial para obtener el primero y el ultimo dia   
        Primer = DateSerial(Year(Fecha), Month(Fecha) + 0, 1)
        Ultimo = DateSerial(Year(Fecha), Month(Fecha) + 1, 0)

        MsgBox(" Primer día : " & Primer & vbNewLine & _
               " Último día : " & Ultimo, vbInformation)

    End Sub

    Public Sub GenerateColumns(ByVal DGV As DataGridView)

        DGV.Columns.Clear()

        Dim arrCols(0 To 10) As DataGridViewColumn  'Arreglo que contendrá la definición de las columnas.

        arrCols(0) = New DataGridViewTextBoxColumn()    'Creación del Objeto de Columna en la posición '0' del Arreglo.     
        arrCols(0).HeaderText = "Folio"                 'Texto de Cabecera de la Columna.     
        arrCols(0).Name = "CFolio"                      'Nombre de la Columna dentro del DataGridView.   
        arrCols(0).ReadOnly = True

        arrCols(1) = New DataGridViewTextBoxColumn()
        arrCols(1).HeaderText = "Clave Material"
        arrCols(1).Name = "CCVEMAT"
        arrCols(1).ReadOnly = True

        arrCols(2) = New DataGridViewTextBoxColumn()
        arrCols(2).HeaderText = "Descripción Material"
        arrCols(2).Name = "CDESMAT"
        arrCols(2).ReadOnly = True

        arrCols(3) = New DataGridViewTextBoxColumn()
        arrCols(3).HeaderText = "Tipo Pesaje"
        arrCols(3).Name = "CTP"
        arrCols(3).ReadOnly = True

        arrCols(4) = New DataGridViewTextBoxColumn()
        arrCols(4).HeaderText = "Clave Proveedor"
        arrCols(4).Name = "CCVEPROV"             'Clave Proveedor
        arrCols(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(4).ReadOnly = True
        arrCols(4).Visible = True

        arrCols(5) = New DataGridViewTextBoxColumn()
        arrCols(5).HeaderText = "Proveedor"
        arrCols(5).Name = "CPR"
        arrCols(5).ReadOnly = True

        arrCols(6) = New DataGridViewTextBoxColumn()
        arrCols(6).HeaderText = "Peso Neto"
        arrCols(6).Name = "CPN"
        arrCols(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(6).ReadOnly = True
        arrCols(6).Width = 2

        arrCols(7) = New DataGridViewTextBoxColumn()
        arrCols(7).HeaderText = "Verificación"
        arrCols(7).Name = "VER"
        arrCols(7).ReadOnly = True
        arrCols(7).Visible = False

        arrCols(8) = New DataGridViewTextBoxColumn()
        arrCols(8).HeaderText = "Status SAP"
        arrCols(8).Name = "STSAP"
        arrCols(8).ReadOnly = True

        arrCols(9) = New DataGridViewTextBoxColumn()
        arrCols(9).HeaderText = "Tipo Movimiento"
        arrCols(9).Name = "TPM"
        arrCols(9).ReadOnly = True
        arrCols(9).Visible = False

        arrCols(10) = New DataGridViewTextBoxColumn()
        arrCols(10).HeaderText = "Status Pesaje"
        arrCols(10).Name = "SP"
        arrCols(10).ReadOnly = True
        arrCols(10).Visible = False


        DGV.Columns.AddRange(arrCols) 'Agregamos el conjunto de Columnas al DataGridView. 
    End Sub

    Public Sub FocoText(ByVal FrmForm As Form)

        On Error Resume Next

        For Each c As Object In FrmForm.Controls
            If TypeOf c Is System.Windows.Forms.TextBox Then
                If c.GetType Is GetType(TextBox) Then
                    AddHandler DirectCast(c, TextBox).GotFocus, AddressOf conFoco
                    AddHandler DirectCast(c, TextBox).LostFocus, AddressOf sinFoco
                End If
            End If
        Next

    End Sub

    Public Function Update_DGV_Amanco(ByVal DGV As DataGridView, ByVal Fila As Integer) As Object

        UP_TPN = DGV.Rows(Fila).Cells("CPN").Value
        Pesos(0) = FormatNumber(Suma_TPN("CPN", DGV), 2)
        Return Pesos

    End Function

    Public Function Suma_TPN(ByVal nombre_Columna As String, ByVal Dgv As DataGridView) As Double

        Dim total As Double = 0

        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"   
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' retornar el valor   
        Return total

    End Function

    Public Function RecordsExist(ByVal DGV As DataGridView) As Object
        Dim oldRowIndex As Object
        oldRowIndex = DGV.CurrentCellAddress.Y
        Return oldRowIndex
    End Function

    Public Sub DelRow(ByVal DGV As DataGridView)
        DGV.Rows.Remove(DGV.CurrentRow)
    End Sub

    Public Sub ShowSplash(ByVal Frm As Form)
        Dim fSplash As New SplashScreenMexichem
        fSplash.Owner = Frm
        fSplash.Show()
        Application.DoEvents()
        Threading.Thread.Sleep(2500)
        fSplash.Close()
        fSplash.Dispose()
    End Sub

    Public Sub Calculadora()
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Public Sub Inicializa_Frm_PTEI(ByVal DT_Turno As DateTimePicker, DT_SAP As DateTimePicker, ByVal CB_SAP As CheckBox)
        DT_Turno.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_SAP.Value = Date.Today.ToString("yyyy-MM-dd")
        DT_Turno.Enabled = True
        CB_SAP.Enabled = True
    End Sub
End Module
