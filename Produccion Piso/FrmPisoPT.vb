Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmPisoPT
#Region "Variables Miembro"

#End Region

#Region "Eventos"
    Private Sub FrmPisoPT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Centro.Text = SessionUser._sCentro.Trim        'Clave Centro 
        NomCentro.Text = SessionUser._sPlanta   'Nombre Centro
        ' ---------------------------------------------------------------------------------
        'Se asigna turno que corresponde acorde al horario
        Dim HReal As String = DateTime.Now
        Catalogo_Turnos.Combo_Turnos(cmbTurnos)
        Catalogo_Turnos.Asigna_turno(cmbTurnos, HReal.Trim)
        ' ---------------------------------------------------------------------------------
        Carga_Grid()
        CveOperador.Focus()
    End Sub

    Private Sub CveOperador_Leave(sender As System.Object, e As System.EventArgs) Handles CveOperador.Leave
        Dim Cadena As String
        Dim aryTextFile() As String
        Dim Usr_Status As Boolean
        Dim Usr_Pass As String = ""
        Dim Usr_Nom As String = ""
        Cadena = Prod_Piso.Valida_Usr(SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, CveOperador.Text.Trim)

        aryTextFile = Cadena.Split("|")
        Usr_Status = aryTextFile(0)
        Usr_Pass = aryTextFile(1)
        Usr_Nom = aryTextFile(2)

        If Usr_Status = False Then
            MensajeBox.Mostrar("Usuario Dado de Baja", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            Exit Sub
        ElseIf Usr_Pass = "" And Usr_Nom = "" Then
            MensajeBox.Mostrar("Usuario No Existe en el Centro " & SessionUser._sCentro.Trim & " ", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            Exit Sub
        ElseIf Usr_Status = True Then
            CodOperador.Text = Usr_Pass.Trim
            NomOperador.Text = Usr_Nom.Trim
        End If
    End Sub

    Private Sub CveOperador_Enter(sender As System.Object, e As System.EventArgs) Handles CveOperador.Enter
        CveOperador.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub CveOperador_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CveOperador.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TOrden_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TOrden.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TOrden_Enter(sender As System.Object, e As System.EventArgs) Handles TOrden.Enter
        TOrden.BackColor = Color.LightSkyBlue
    End Sub


#End Region

#Region "Metodos"

#End Region


    Private Sub TOrden_Leave(sender As System.Object, e As System.EventArgs) Handles TOrden.Leave
        'Lee orden de producción
        Prod_Piso.Read_Order(SessionUser._sAlias.Trim, TOrden.Text.Trim, SessionUser._sCentro.Trim, TCodMat, TDesMat, TCodMaq, TDesMaq)
    End Sub

    Private Sub Btn_RegProd_Click(sender As System.Object, e As System.EventArgs) Handles Btn_RegProd.Click

        If CodOperador.Text.Trim = "" Then
            MensajeBox.Mostrar("El campo Clave Controlador debe de llevar un valor", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            CodOperador.Focus()
            Return
        End If

        If TOrden.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese numero de orden de fabricación", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TOrden.Focus()
            Return
        End If

        If TUnidades.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese cantidad de unidades", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TUnidades.Focus()
            Return
        End If

        If TCajas.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese cantidad de cajas", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TCajas.Focus()
            Return
        End If

        If TKilos.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese cantidad de kilos", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TKilos.Focus()
            Return
        End If

        'Valida si existe un registro de la orden lo inhabilita
        Produccion_Piso.Actualiza_Registro(SessionUser._sAlias.Trim, TOrden.Text.Trim, SessionUser._sCentro.Trim)
        'Ingresa la informacion de la orden
        Produccion_Piso.Insert_Prod_Piso(CodOperador.Text.Trim, TOrden.Text.Trim, SessionUser._sCentro.Trim, TCodMat.Text.Trim, TUnidades.Text.Trim, TCajas.Text.Trim, _
                                         TKilos.Text.Trim, TCodMaq.Text.Trim, TDesMaq.Text.Trim)
        Limpiar()
        Carga_Grid()
    End Sub

    Private Sub Limpiar()
        CveOperador.Text = ""
        CodOperador.Text = ""
        NomOperador.Text = ""
        TCodMat.Text = ""
        TDesMat.Text = ""
        TCodMaq.Text = ""
        TDesMaq.Text = ""
        TOrden.Text = ""
        TUnidades.Text = "0"
        TCajas.Text = "0"
        TKilos.Text = "0.0"
    End Sub

    Public Sub Carga_Grid()
        Produccion_Piso.Catalogo_Prod_Piso(SessionUser._sAlias.Trim, DGV, SessionUser._sCentro.Trim, "", "")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Limpiar()
        Close()
    End Sub

    Private Sub Btn_Consulta_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Consulta.Click
        Carga_Grid()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        MdFormControl.Calculadora()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub

    Private Sub Btn_Export_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Export.Click
        Util.ExportaExcel(DGV)
    End Sub

    Private Sub DGV_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        With DGV
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        End With
    End Sub
End Class
