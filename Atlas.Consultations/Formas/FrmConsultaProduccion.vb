Public Class FrmConsultaProduccion
#Region "Variables"

#End Region

#Region "Eventos"
    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        Parametrosconsulta("rb1")
    End Sub
    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        Parametrosconsulta("rb2")
    End Sub
    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        Parametrosconsulta("rb3")
    End Sub

#End Region

#Region "Metodos"
    Private Sub Parametrosconsulta(ByVal RadioBtn As String)
        If rb1.Checked Then
            DTPI.Enabled = False
            DTPF.Enabled = False
        End If

        If rb2.Checked Then
            DTPI.Enabled = True
            DTPF.Enabled = True
        End If

        If rb1.Checked Then
            DTPI.Enabled = True
            DTPF.Enabled = True
        End If
    End Sub

#End Region
   
End Class