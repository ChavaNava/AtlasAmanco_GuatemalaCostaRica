Imports System.Deployment.Application
Imports Utili_Generales 
Public Class AtlasUpdate
    Public Shared Sub Version()
        Dim deployment As ApplicationDeployment
        Dim info As UpdateCheckInfo
        deployment = ApplicationDeployment.CurrentDeployment
        Try
            info = deployment.CheckForDetailedUpdate()
        Catch dde As DeploymentDownloadException
            MensajeBox.Mostrar("La nueva version de ATLAS no puede ser descargada en este momento " + vbCrLf & " Por favor verifique su conexión de red e intente nuevamente. Error: " + dde.Message, "Error", MensajeBox.TipoMensaje.Critical)
            Return
        Catch ioe As InvalidOperationException
            MensajeBox.Mostrar("Imposible realizar actualización de la aplicación " + vbCrLf & "Error: " + ioe.Message, "Error", MensajeBox.TipoMensaje.Critical)
            Return
        End Try

        Dim doUpdate As Boolean = True
        If (Not info.IsUpdateRequired) Then
            MensajeBox.Mostrar("Existe una nueva actualización de ATLAS, ¿Desea descargarla ahora?", "ATLAS Update", MensajeBox.TipoMensaje.Exclamation, MensajeBox.TipoBoton.OkCancel)
            'Dim dr As DialogResult = MessageBox.Show("Existe una nueva actualización de ATLAS, ¿Desea descargarla ahora?", "ATLAS Update", MessageBoxButtons.OKCancel)
            If MensajeBox.Respuesta() Then
                doUpdate = True
            End If
        Else
            ' Display a message that the app MUST reboot. Display the minimum required version.
            MensajeBox.Mostrar("Se ha detectado que existe una actualización de ATLAS necesaria para continuar la operación", "ATLAS Update", MensajeBox.TipoMensaje.Information)
        End If
        If (doUpdate) Then
            Try
                'LoadingForm.ShowLoading()
                deployment.Update()
                MensajeBox.Mostrar("La aplicación se ha actualizado con éxito, vuelva a ejecutarla desde el acceso directo", "ATLAS Update", MensajeBox.TipoMensaje.Good)
                'logger.Success("ATLAS se actualizado a la nueva versión del sisteama correctamente", CurrentSesion.UsuarioNombre)
                'LoadingForm.CloseForm()
                Application.Exit()
            Catch dde As DeploymentDownloadException
                MensajeBox.Mostrar("No fue posible terminar con la actualización" & ControlChars.Lf & ControlChars.Lf & "Verifique su conexión a Internet " & _
                  "o contacte a su administrador", "ATLAS Update", MensajeBox.TipoMensaje.Critical)
                'logger.Errorr("No fue posible terminar con la actualización de la versión correctamente", CurrentSesion.UsuarioNombre)
            End Try
        End If

    End Sub

    Public Shared Sub Actualiza_Version()
        Dim info As UpdateCheckInfo = Nothing
        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
            Catch ioe As InvalidOperationException
            End Try
            If (info.UpdateAvailable) Then
                Try
                    AD.Update()
                    Application.Restart()
                Catch dde As DeploymentDownloadException
                End Try
            End If
        End If
    End Sub

End Class
