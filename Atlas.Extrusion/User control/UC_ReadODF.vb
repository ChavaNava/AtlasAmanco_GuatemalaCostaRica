Imports Utili_Generales
Imports SQL_DATA
Public Class UC_ReadODF
    Public Event TOrdenKeyPress As EventHandler
#Region "Variables"
    Dim TipoProd As String  'T = Producto Terminado S = Scrap
#End Region

#Region "Eventos"
    Private Sub RB_PT_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PT.CheckedChanged
        TipoProd = ""
        TipoProd = "T"
        TOrden.Text = ""
        TOrden.Enabled = True
        TOrden.Focus()
    End Sub

    Private Sub RB_SC_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_SC.CheckedChanged
        TipoProd = ""
        TipoProd = "S"
        TOrden.Text = ""
        TOrden.Enabled = True
        TOrden.Focus()
    End Sub

    Private Sub TOrden_Enter(sender As System.Object, e As System.EventArgs) Handles TOrden.Enter
        TOrden.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TOrden_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TOrden.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TOrden_Leave(sender As System.Object, e As System.EventArgs) Handles TOrden.Leave
        Dim Existe As Boolean = Read_Order()
        If Existe = True Then
            RaiseEvent TOrdenKeyPress(sender, e)
        End If
    End Sub

    Private Sub BtnActualiza_Click(sender As System.Object, e As System.EventArgs)
        If TOrden.Text.Trim = "" Then
            MensajeBox.Mostrar("Ingrese un numero de Orden", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            TOrden.Focus()
            Exit Sub
        Else
            ProductionOrder.Act_Ins_ProductionOrder(TOrden.Text.Trim, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, TipoProd.Trim, SessionUser._sAmbiente)

        End If
    End Sub
#End Region

#Region "Metodos"
    Public Function Read_Order() As Boolean
        'Valida si la orden Existe en A-tlas
        Dim Exist As Boolean = ProductionOrder.ODF(SessionUser._sAlias, TOrden.Text.Trim, 1)
        Select Case Exist
            Case Is = True  'Existe Orden en A-tlas
                ProductionOrder.ODF(SessionUser._sAlias, TOrden.Text.Trim, 2)
                'Valida Existencia de Producto en A-tlas
                Dim Ok_Codigo As Boolean = ProductionOrder.Valida_PT(SessionUser._sAlias, Read_ODF._rCodigo, 1, 1)
                If Ok_Codigo = False Then
                    MensajeBox.Mostrar("El código del porducto no esta dado de alta en A-tlas ", "Aviso", MensajeBox.TipoMensaje.Information)
                    TOrden.Focus()
                    Return Ok_Codigo
                    Exit Function
                Else
                    'Validad Existencia de Puesto de Trabajo en A-tlas
                    Dim PuestoTrabajo As Boolean = ProductionOrder.Valida_Work_Center(SessionUser._sAlias, Read_ODF._rPuestoTrabajo, 1)
                    If PuestoTrabajo = False Then
                        MensajeBox.Mostrar("Puesto de trabajo no esta dado de alta en A-tlas ", "Aviso", MensajeBox.TipoMensaje.Information)
                        TOrden.Focus()
                        Return PuestoTrabajo
                        Exit Function
                    Else
                        'Valida asignacion de compuesto BOM
                        Dim Bom As Boolean = ProductionOrder.Compuesto_Bom(SessionUser._sAlias, Read_ODF.rCodigo, 1)
                        If Bom = False Then
                            MensajeBox.Mostrar("Producto no tiene asignado compuesto BOM ", "Aviso", MensajeBox.TipoMensaje.Information)
                            TOrden.Focus()
                            Return Bom
                        Else
                            Return Bom
                        End If
                    End If
                End If
            Case Is = False 'No Existe Orden en A-tlas
                Return Exist
                MensajeBox.Mostrar("Orden de Producción no existe en A-tlas se procede a darla de alta ", "Aviso", MensajeBox.TipoMensaje.Information)

        End Select
    End Function
#End Region

End Class
