Imports System.Drawing
Imports System.Windows.Forms
Public Class FrontUtils
    Public Sub DeshabilitarMenus(ByVal menustrip As MenuStrip)
        For Each menu As ToolStripMenuItem In menustrip.Items
            menu.Visible = False
            'Me.HabilitarSubMenus(menu)
        Next
    End Sub

    Public Sub DeshabilitarSubMenus(ByVal menu As ToolStripMenuItem)
        For Each SubMenu As ToolStripMenuItem In menu.DropDownItems
            SubMenu.Visible = False
            'Me.HabilitarSubMenus(SubMenu)
        Next
    End Sub

    'Limpia Cajas de Texto
    Public Shared Sub LimpiarText(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is TextBox Then
                If fcontrol.Name Like "T*" Then
                    fcontrol.Text = ""
                End If
            End If
        Next fcontrol
    End Sub

    'Bloquear Cajas de Texto
    Public Shared Sub BloquearText(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is TextBox Then
                If fcontrol.Name Like "T*" Then
                    fcontrol.Enabled = False
                End If
            End If
        Next fcontrol
    End Sub
    'Activa Cajas de Texto
    Public Shared Sub ActivaText(ByVal frmForm As Form)
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

    'Limpia Combo Box
    Public Shared Sub LimpiarComboBox(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is ComboBox Then
                fcontrol.Text = ""            
            End If
        Next fcontrol
    End Sub

    'Bloquear Combo Box
    Public Shared Sub BloquearComboBox(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is ComboBox Then
                fcontrol.Enabled = False
            End If
        Next fcontrol
    End Sub

    'Activar ComboBox
    Public Shared Sub ActivaCombo(ByVal frmForm As Form)
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

    'Limpia Cajas de Texto dentro de un GroupBox
    Public Shared Sub LimpiarText_GroupBox(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is TextBox Then
                If fcontrol.Name Like "T*" Then
                    fcontrol.Text = ""
                End If
            ElseIf TypeOf fcontrol Is GroupBox Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    Dim Nomcontrol As String
                    Nomcontrol = tcontrol.Name
                    If TypeOf tcontrol Is TextBox Then
                        If tcontrol.Name Like "T*" Then
                            tcontrol.Text = ""
                        End If
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub

    'Limpia Cajas de ComboBox dentro de un GroupBox
    Public Shared Sub LimpiarComboBox_GroupBox(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is TextBox Then
                fcontrol.Text = ""
            ElseIf TypeOf fcontrol Is GroupBox Then
                'Recorremos las pestañas del TAB
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TextBox Then
                        tcontrol.Text = ""
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub
    'Limpia Cajas de Texto dentro de un GroupBox
    Public Shared Sub LimpiarText_Inyeccion(ByVal frmForm As Form)
        On Error Resume Next
        For Each fcontrol As Control In frmForm.Controls
            If TypeOf fcontrol Is TextBox Then
                If fcontrol.Name Like "T*" Then
                    fcontrol.Text = ""
                End If
                If fcontrol.Name = "TPesoCaptura" Then
                    fcontrol.Text = "0.00"
                End If
            ElseIf TypeOf fcontrol Is GroupBox Then
                'Recorremos el Group Box
                For Each tcontrol As Control In fcontrol.Controls
                    If TypeOf tcontrol Is TextBox Then
                        If tcontrol.Name = "TtramosNoti" Then
                            tcontrol.Text = "0"
                        End If
                        If tcontrol.Name = "TPesoRack" Then
                            tcontrol.Text = "0"
                        End If
                        If tcontrol.Name = "TC_Descrack" Then
                            tcontrol.Text = " "
                        End If
                        If tcontrol.Name = "TPtoTrabajo" Then
                            tcontrol.Text = " "
                        End If
                        If tcontrol.Name = "TNomPtoTrabajo" Then
                            tcontrol.Text = " "
                        End If
                        If tcontrol.Name = "TPComp1" Then
                            tcontrol.Text = "100"
                        End If
                        If tcontrol.Name = "TCComp1" Then
                            tcontrol.Text = "0"
                        End If
                        If tcontrol.Name = "TPComp2" Then
                            tcontrol.Text = "0"
                        End If
                        If tcontrol.Name = "TCComp2" Then
                            tcontrol.Text = "0"
                        End If
                        If tcontrol.Name = "TPComp3" Then
                            tcontrol.Text = "0"
                        End If
                        If tcontrol.Name = "TCComp3" Then
                            tcontrol.Text = "0"
                        End If
                        If tcontrol.Name = "TCantProgra" Then
                            tcontrol.Text = "0"
                        End If
                        If tcontrol.Name = "TCantEntre" Then
                            tcontrol.Text = "0"
                        End If
                        If tcontrol.Name = "TCantEnproce" Then
                            tcontrol.Text = "0"
                        End If
                        If tcontrol.Name = "TCantPendiente" Then
                            tcontrol.Text = "0"
                        End If
                        If tcontrol.Name = "TFolioAtlas" Then
                            tcontrol.Text = ""
                        End If
                        If tcontrol.Name = "TNumNoti" Then
                            tcontrol.Text = ""
                        End If
                        If tcontrol.Name = "TConsNoti" Then
                            tcontrol.Text = ""
                        End If
                        If tcontrol.Name = "TC_Orden" Then
                            tcontrol.Text = ""
                            tcontrol.Enabled = True
                        End If                       
                    End If
                Next tcontrol
            End If
        Next fcontrol
    End Sub


    'Activar CheckBox
    Public Shared Sub ActivaCheckBox(ByVal frmForm As Form)
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

End Class
