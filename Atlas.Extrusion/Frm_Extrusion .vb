Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Imports Atlas.Accesos.Parametrizacion
Public Class Frm_Extrusion

#Region "Variables"

#End Region

#Region "Eventos"
    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Close()
    End Sub

    Private Sub Extrusion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Parametrized_Form(Me)
        Parametrizacion()
        FechaTurno.Asigna_Turno()
    End Sub

    Private Sub Login_Leave1(sender As System.Object, e As System.EventArgs) Handles Login.Leave1
        ReadODF.TOrden.Text = ""
        ReadODF.TOrden.Focus()
    End Sub

    Private Sub Login_Text_Leave1(sender As System.Object, e As System.EventArgs) Handles Login.Leave1
        ReadODF.RB_PT.Focus()
    End Sub

    Private Sub ReadODF_TOrdenKeyPress(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReadODF.TOrdenKeyPress
        LlenaCampos()
    End Sub

    Private Sub Basculas_CheckedChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Basculas.CheckedChanged1
        If Basculas.RB1.Checked Then
            If ValCodigoBascula.Trim = "M" Then
                'TPesoCaptura.Enabled = True
                'TPesoCaptura.Visible = True
                'LPesoCaptura.Visible = True
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
            Else
                Timer1.Enabled = True
                Timer2.Enabled = False
                Timer3.Enabled = False
            End If
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Basculas_CheckedChanged2(ByVal sender As Object, ByVal e As System.EventArgs) Handles Basculas.CheckedChanged2
        If Basculas.RB2.Checked Then
            If ValCodigoBascula_2.Trim = "M" Then
                'TPesoCaptura.Enabled = True
                'TPesoCaptura.Visible = True
                'LPesoCaptura.Visible = True
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
            Else
                Timer1.Enabled = False
                Timer2.Enabled = True
                Timer3.Enabled = False
            End If
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Basculas_CheckedChanged3(ByVal sender As Object, ByVal e As System.EventArgs) Handles Basculas.CheckedChanged3
        If Basculas.RB3.Checked Then
            If ValCodigoBascula_3.Trim = "M" Then
                'TPesoCaptura.Enabled = True
                'TPesoCaptura.Visible = True
                'LPesoCaptura.Visible = True
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
            Else
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = True
            End If
        Else
            Timer3.Enabled = False
        End If
    End Sub
#End Region

#Region "Metodos"

    Private Sub Parametrizacion()
        Login.Centro.Text = SessionUser._sCentro
        Basculas.GB_Basculas.Enabled = P_MB
        Login.TPassNotifier.Focus()

    End Sub

    Public Shared Function Read_Timer(ByVal Cadena As String)
        Dim Lectura As String = ""
        Dim AddChar As Integer = 0
        Dim CH1 As String = ""
        Dim CH2 As String = ""
        Dim LenghtLec As Integer = 0
        Dim TPC As String = ""
        Dim TPC2 As String = ""
        Dim PN As Decimal



        TPC = Chr(CH1)
        TPC2 = Chr(CH2)
        If Cadena.Length > 13 Then
            If Cadena.StartsWith(TPC) = True Then
                Lectura = Cadena.Substring((Cadena.IndexOf(TPC2) + AddChar), LenghtLec).Trim
            End If
        End If

        If SessionUser._sCentro.Trim = "GT01" Then
            PN = Format((Val(Lectura) / 10), xFD2)
        Else
            PN = Format(Val(Lectura), xFD2)
        End If

        Return PN

    End Function

    Private Sub LlenaCampos()
        ReadODF.TPtoTrabajo.Text = Read_ODF._rPuestoTrabajo
        ReadODF.TNomPtoTrabajo.Text = Read_ODF._rDescPtoTrabajo
    End Sub
#End Region


End Class
