Imports System.Configuration
Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class FrmCtrlODF_AMEX

#Region "Variables Miembro"
    Dim RegistrosActualizados As Integer
    Dim myDataReader As SqlClient.SqlDataReader
    Dim Q As String

    Dim Linea_Prod As String
    Dim Producto As String
    Dim Hora As String
    Dim Origen As String
    Dim GpMat As String

    'Variables combobox
    Dim INDX As Integer

    Dim strOrden As String = ""
    Dim aryTextFile() As String
    Dim C_Equipo As String = ""
    Dim D_Equipo As String = ""
    Dim C_Producto As String = ""
    Dim D_Producto As String = ""
#End Region

#Region "Eventos"

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Select Case Accion
            Case Is = "Altas"
                'Valida que la orden no este dada de alta
                Dim Cont As Integer
                Cont = Catalogo_Ordenes_Produccion.Valida_Orden_Fabricacion(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, Tord.Text.Trim)
                If Cont = 0 Then
                    'Determinar el grupo de materia de acuerdo al producto
                    GpMat = Catalogo_Ordenes_Produccion.Grupo_Material(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, CB_Producto.SelectedValue.Trim, EXTINY)
                    Try
                        Catalogo_Ordenes_Produccion.Inser_Orden_Produccion(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, Tord.Text.Trim,
                                                                           CB_Lineas.SelectedValue.Trim, CB_Producto.SelectedValue.Trim,
                                                                           TProg.Text, GpMat.Trim, Ver_Atlas)
                        MensajeBox.Mostrar("Se dio de alta la orden '" & Tord.Text.Trim & "'", "Aviso", MensajeBox.TipoMensaje.Information)
                        _Termina = 1
                        Close()
                    Catch ex As Exception
                        MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                        _Termina = 0
                        Close()
                    End Try
                Else
                    MensajeBox.Mostrar("La Orden de Fabricación ya existe", "Aviso", MensajeBox.TipoMensaje.Information)
                    _Termina = 0
                    Close()
                End If
            Case Is = "Cambios"
                Dim I_Linea As String = ""
                Dim I_Producto As String = ""
                Dim Cantidad As Integer = 0

                If CB_Lineas.SelectedValue = Nothing Then
                    I_Linea = C_Equipo.Trim
                Else
                    I_Linea = CB_Lineas.SelectedValue.Trim
                End If

                If CB_Producto.SelectedValue = Nothing Then
                    I_Producto = C_Producto.Trim
                Else
                    I_Producto = CB_Producto.SelectedValue.Trim
                End If

                Cantidad = TProg.Text

                'Determinar el grupo de materia de acuerdo al producto
                GpMat = Catalogo_Ordenes_Produccion.Grupo_Material(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, I_Producto, EXTINY)

                Try
                    Catalogo_Ordenes_Produccion.Actualiza_Orden_Fabricacion(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, OrdOld.Trim, Tord.Text.Trim, I_Linea, I_Producto, Cantidad, Ver_Atlas)
                    MensajeBox.Mostrar("Se actualizo la orden '" & Tord.Text.Trim & "'", "Aviso", MensajeBox.TipoMensaje.Information)
                    _Termina = 1
                    Close()
                Catch ex As Exception
                    MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
                    _Termina = 0
                    Close()
                End Try
        End Select
    End Sub

    Private Sub FrmCtrlODF_Ext_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Accion
            Case Is <> "Altas"
                Limpiar()
                strOrden = Catalogo_Ordenes_Produccion.Consulta_Orden_Fabricacion(SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, OrdOld.Trim)
                aryTextFile = strOrden.Split("|")
                Tord.Text = aryTextFile(0)
                C_Equipo = aryTextFile(2)
                D_Equipo = aryTextFile(3)
                C_Producto = aryTextFile(4)
                D_Producto = aryTextFile(5)
                TProg.Text = aryTextFile(6)
                TxtFecha.Text = aryTextFile(7)

                CB_Lineas.Text = C_Equipo.Trim & " " & D_Equipo.Trim
                CB_Producto.Text = C_Producto.Trim & " " & D_Producto.Trim
                Tord.Enabled = True
            Case Is = "Altas"
                Limpiar()
                Catalogo_Ordenes_Produccion.Consulta_Linea_Produccion(CB_Lineas, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, EXTINY)
                Catalogo_Ordenes_Produccion.Consulta_Producto_Terminado(CB_Producto, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, EXTINY)
                TxtFecha.Text = Date.Today.ToString("yyyy-MM-dd")
                Tord.Enabled = True
                Tord.Focus()
        End Select

    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        Close()
    End Sub

    Private Sub FrmCtrlODF_AMEX_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        OrdOld = ""
        CB_Lineas.DataSource = Nothing
        CB_Producto.DataSource = Nothing
    End Sub

    Private Sub CB_Producto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CB_Producto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CB_Lineas_Click(sender As System.Object, e As System.EventArgs) Handles CB_Lineas.Click
        If Accion <> "Altas" Then
            INDX = CB_Lineas.SelectedIndex
            If INDX = -1 Then
                Catalogo_Ordenes_Produccion.Consulta_Linea_Produccion(CB_Lineas, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, EXTINY)
            End If
        End If
    End Sub

    Private Sub CB_Producto_Click(sender As System.Object, e As System.EventArgs) Handles CB_Producto.Click
        If Accion <> "Altas" Then
            INDX = CB_Producto.SelectedIndex
            If INDX = -1 Then
                Catalogo_Ordenes_Produccion.Consulta_Producto_Terminado(CB_Producto, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim, EXTINY)
            End If
        End If
    End Sub

#End Region

#Region "Metodos"

    Sub Limpiar()
        Tord.Text = ""
        TxtFecha.Text = ""
        TProg.Text = ""
    End Sub

#End Region
   
End Class