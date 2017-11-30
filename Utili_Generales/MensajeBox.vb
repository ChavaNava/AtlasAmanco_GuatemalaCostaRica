Imports Utili_Generales
Public Class MensajeBox

    Public Enum TipoMensaje
        Exclamation = 1
        Information = 2
        Critical = 3
        Good = 4
    End Enum
    Public Enum TipoBoton
        OkOnly = 1
        OkCancel = 2
    End Enum

    Shared m_regreso As Boolean
    Public Shared Function Respuesta() As Boolean
        Return m_regreso
    End Function

    Sub New(ByVal mensaje As String, ByVal titulo As String, ByVal tipoMsg As TipoMensaje, Optional ByVal botones As TipoBoton = TipoBoton.OkOnly)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblTexto.Text = mensaje
        Me.Text = titulo

        Select Case tipoMsg
            Case TipoMensaje.Exclamation
                pbImagen.Image = My.Resources.warning_shield
            Case TipoMensaje.Information
                pbImagen.Image = My.Resources.question_shield
            Case TipoMensaje.Critical
                pbImagen.Image = My.Resources.error_shield
            Case TipoMensaje.Good
                pbImagen.Image = My.Resources.good_shield
        End Select

        Select Case botones
            Case TipoBoton.OkOnly
                pnOk.Visible = True
            Case TipoBoton.OkCancel
                pnOkCancel.Visible = True
        End Select
    End Sub

    Public Shared Function Mostrar(ByVal mensaje As String, ByVal titulo As String, ByVal tipoMsg As MensajeBox.TipoMensaje, Optional ByVal botones As MensajeBox.TipoBoton = MensajeBox.TipoBoton.OkOnly) As String
        Dim mensajeBox As MensajeBox = New MensajeBox(mensaje, titulo, tipoMsg, botones)
        Return mensajeBox.ShowDialog()
    End Function

    ''' <summary>
    ''' Es la función que debe llamarse antes de mostrar el Formulario para 
    ''' llenarlo de manera correcta ej. Mensaje.CargaMensaje("Mensaje", "Titulo", _
    ''' TipoMensaje.Exclamation, 2)
    ''' </summary>
    ''' <param name="mensaje">Mensaje que mostrará el cuadro de diálogo</param>
    ''' <param name="titulo">Titulo del cuadro de diálogo</param>
    ''' <param name="tipoMsg">Estilo del cuadro de Texto TipoMensaje.Exclamation, TipoMensaje.Information, TipoMensaje.Critical, TipoMensaje.Good</param>
    ''' <param name="botones">TipoBotones.OkOnly, TipoBoton.OkCancel</param>
    ''' <remarks></remarks>
    Public Sub CargaMensaje(ByVal mensaje As String, ByVal titulo As String, ByVal tipoMsg As TipoMensaje, _
                            Optional ByVal botones As TipoBoton = TipoBoton.OkOnly)
        lblTexto.Text = mensaje
        Me.Text = titulo

        Select Case tipoMsg
            Case TipoMensaje.Exclamation
                pbImagen.Image = My.Resources.warning_shield
                'pbImagen.ImageLocation = sExclamation
            Case TipoMensaje.Information
                pbImagen.Image = My.Resources.question_shield
                'pbImagen.ImageLocation = sQuestion
            Case TipoMensaje.Critical
                pbImagen.Image = My.Resources.error_shield
                'pbImagen.ImageLocation = sError
            Case TipoMensaje.Good
                pbImagen.Image = My.Resources.good_shield
                'pbImagen.ImageLocation = sGood
        End Select

        Select Case botones
            Case TipoBoton.OkOnly
                pnOk.Visible = True
            Case TipoBoton.OkCancel
                pnOkCancel.Visible = True
        End Select

    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click, btOk1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        m_regreso = True
        Me.Close()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        m_regreso = False
        Me.Close()
    End Sub

    Private Sub Mensaje_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        pnOk.Visible = False
        pnOkCancel.Visible = False
    End Sub

    Private Sub MensajeBox_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
    End Sub
End Class