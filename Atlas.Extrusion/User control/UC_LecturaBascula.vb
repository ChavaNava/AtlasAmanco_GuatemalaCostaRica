Imports Atlas.Accesos.CLVarGlobales
Public Class UC_LecturaBascula
    Public Event TextChanged1 As EventHandler
    Public Event TextChanged2 As EventHandler
    Public Event TextChanged3 As EventHandler

  
    Private Sub TPB_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPB.TextChanged
        RaiseEvent TextChanged1(sender, e)
    End Sub

    Private Sub TPT_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPT.TextChanged
        RaiseEvent TextChanged2(sender, e)
    End Sub

    Private Sub TPE_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPE.TextChanged
        RaiseEvent TextChanged3(sender, e)
    End Sub
End Class
