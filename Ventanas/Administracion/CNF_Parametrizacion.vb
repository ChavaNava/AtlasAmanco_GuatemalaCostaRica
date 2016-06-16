Imports Utili_Generales
Imports Utili_Generales.ConfigScales
Imports Atlas.Accesos.CLVarGlobales
Public Class CNF_Parametrizacion

#Region "Variables"

#End Region

#Region "Eventos"

#End Region

#Region "Metodos"

#End Region

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Boot_Files.Delete_File()
            Boot_Files.Edit_File(TBascula1.Text, TBascula2.Text, TBascula3.Text)
            MensajeBox.Mostrar("Se guarda satisfactoriamente la configuracion de los puertos", "Aviso", MensajeBox.TipoMensaje.Good)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CNF_Parametrizacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Util.ApplicationIcon()
        Dim Scales() As String

        Scales = ReedFile(2, "C:\App Settings\Scales.ini").Split("|")
        Val_Bascula = Mid(Scales(0), 11, 6)
        Val_Bascula_2 = Mid(Scales(1), 13, 6)
        Val_Bascula_3 = Mid(Scales(2), 13, 6)

        'Bascula 1
        TBascula1.Text = Val_Bascula.Trim
        'Bascula 2
        TBascula2.Text = Val_Bascula_2.Trim
        'Bascula 3
        TBascula3.Text = Val_Bascula_3.Trim

    End Sub
End Class