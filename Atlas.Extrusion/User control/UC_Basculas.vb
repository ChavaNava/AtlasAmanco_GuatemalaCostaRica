Public Class UC_Basculas
    Public Event CheckedChanged1 As EventHandler
    Public Event CheckedChanged2 As EventHandler
    Public Event CheckedChanged3 As EventHandler

    Private Sub RB1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB1.CheckedChanged
        RaiseEvent CheckedChanged1(sender, e)
    End Sub

    Private Sub RB2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB2.CheckedChanged
        RaiseEvent CheckedChanged2(sender, e)
    End Sub

    Private Sub RB3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB3.CheckedChanged
        RaiseEvent CheckedChanged3(sender, e)
    End Sub
End Class
